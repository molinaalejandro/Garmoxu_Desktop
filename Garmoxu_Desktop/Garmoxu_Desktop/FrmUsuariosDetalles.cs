using iText.IO.Image;
using iText.Kernel.Colors;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Draw;
using iText.Layout;
using iText.Layout.Borders;
using iText.Layout.Element;
using iText.Layout.Properties;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Garmoxu_Desktop.FrmMessageBoxPersonalizado;
using static Garmoxu_Desktop.ConexionMySql;

namespace Garmoxu_Desktop
{
    public partial class FrmUsuariosDetalles : Form
    {
        private List<string> IdsTiposUsuario;

        public FrmUsuariosDetalles(ref Form frmShadow)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            CargarTiposDeUsuario();
            SombrearPantalla(ref frmShadow);
        }

        #region Apertura del formulario
        #region Cargar tipos de usuario
        private void CargarTiposDeUsuario()
        {
            IdsTiposUsuario = new List<string>();

            string sql = "SELECT Nombre, IdTipoUsuario FROM TiposUsuarios ORDER BY Nombre ASC";
            MySqlDataReader lector = EjecutarConsulta(sql);

            while (lector.Read())
            {
                CboTipoUsuario.Items.Add(lector[0].ToString());
                IdsTiposUsuario.Add(lector[1].ToString());
            }
            CerrarConexion();
            lector.Close();
        }
        #endregion
        #endregion

        #region Funciones y diseño del formulario
        #region Bordeado del formulario
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;

                // Solo se acumulan modificaciones de diferente tipos, es decir,
                // una de ExStyle, otra de Style y otra de ClassStyle. Pero, nunca
                // se pueden acumular dos modificaciones del mismo tipo, por ejemplo,
                // no se acumulan dos ExStyle, o aplicas uno, o aplicas el otro.

                //cp.ExStyle = 0x00000100; // Aperentemente no hace nada
                //cp.ExStyle = 0x00020000; // Borde simple fino arriba e izquierda y grueso abajo y derecha
                cp.ExStyle = 0x00000200; // Borde 3D arriba e izquierda
                //cp.ExStyle = 0x00000001; // Borde 3D abajo y derecha
                // https://docs.microsoft.com/en-us/windows/win32/winmsg/extended-window-styles

                //cp.Style |= 0x00800000; // Borde simple fino
                cp.Style |= 0x00400000; // Borde 3D abajo y derecha
                // https://docs.microsoft.com/en-us/windows/win32/winmsg/window-styles

                //cp.ClassStyle |= 0x00020000; // Shadow border
                return cp;
            }
        }
        #endregion

        #region Sombreado de pantalla
        private void SombrearPantalla(ref Form frmShadow)
        {
            frmShadow = new Form();
            frmShadow.ShowInTaskbar = false;
            frmShadow.Text = "";
            frmShadow.FormBorderStyle = FormBorderStyle.None;
            frmShadow.Size = Size;
            frmShadow.WindowState = FormWindowState.Maximized;
            frmShadow.BackColor = System.Drawing.Color.Black;
            frmShadow.Opacity = 0.7;
            frmShadow.Show();
            frmShadow.Location = Location;
            frmShadow.Enabled = false;
            frmShadow.TopMost = true;
        }
        #endregion
        #endregion

        #region Alta de usuario
        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals((char)Keys.Enter))
            {
                e.Handled = true;
                BtnGuardar_Click(null, null);
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (ComprobarCamposNoVacios() && ValidarFormatoNombreUsuario() && ConfirmarAccion("dar de alta") && ValidarUsuarioNoExistente())
            {
                string contraseñaSinEncriptar = string.Empty;
                string contraseñaEncriptada = GenerarContraseñaAleatoria(ref contraseñaSinEncriptar);

                string sql = string.Format(
                    "INSERT INTO Usuarios (NombreUsuario, Contraseña, NombreEmpleado, ImagenUsuario, IdTipoUsuario) " +
                    "VALUES ('{0}', '{1}', '{2}', NULL, {3})",
                    TxtUsuario.Texts.Trim(), contraseñaEncriptada,
                    TxtNombre.Texts.Trim(), IdsTiposUsuario[CboTipoUsuario.SelectedIndex]
                    );

                EjecutarSentencia(sql);

                ExportarAPdf(contraseñaSinEncriptar);
                InformarAccionConExito();
                this.Close();
            }
        }

        #region Generación de contraseñas
        private string GenerarContraseñaAleatoria(ref string contraseñaSinEncriptar)
        {
            string contraseña = System.Web.Security.Membership.GeneratePassword(10, 0);
            contraseñaSinEncriptar = contraseña;
            return EncriptarContraseña(contraseña);
        }

        private string EncriptarContraseña(string contraseña)
        {
            SHA256 sha256 = SHA256Managed.Create();

            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] stream = null;
            StringBuilder sb = new StringBuilder();

            stream = sha256.ComputeHash(encoding.GetBytes(contraseña));

            for (int i = 0; i < stream.Length; i++)
                sb.AppendFormat("{0:x2}", stream[i]);

            return sb.ToString();
        }
        #endregion

        #region Generación de PDF
        private void ExportarAPdf(string contraseña)
        {
            bool dirSeleccionado = true;
            string ruta = RecogerRuta(ref dirSeleccionado);

            string usuario = TxtUsuario.Texts.Trim();
            string nombreYApellidos = TxtNombre.Texts.Trim();
            string tipoUsuario = CboTipoUsuario.SelectedItem.ToString();

            ruta += "\\Credenciales " + usuario + " - " + nombreYApellidos + ".pdf";
            PdfWriter writerPdf = new PdfWriter(ruta);
            PdfDocument pdf = new PdfDocument(writerPdf);
            Document documentoPdf = new Document(pdf);

            AñadirCabeceraPdf(ref documentoPdf);
            AñadirTitulo(ref documentoPdf, nombreYApellidos);
            AñadirCuerpoPdf(ref documentoPdf, usuario, contraseña, tipoUsuario);

            documentoPdf.Close();

            if (!dirSeleccionado)
            {
                string mensaje = "Se ha generado un archivo PDF con las credenciales del nuevo usuario en la siguiente ubicación: \n'" + ruta + "'.";
                ShowInfoMessage(mensaje, "");
            }
        }

        private string RecogerRuta(ref bool dirSeleccionado)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Seleccione un directorio para exportar a formato PDF las credenciales del nuevo usuario.";
            if (fbd.ShowDialog().Equals(DialogResult.OK)) return fbd.SelectedPath;
            else
            {
                if (!Directory.Exists("Credenciales")) Directory.CreateDirectory("Credenciales");

                dirSeleccionado = false;
                return "Credenciales";
            }
        }

        #region Cabecera
        private void AñadirCabeceraPdf(ref Document documentoPdf)
        {
            string rutaImagenPdf = @"..\..\Resources\Garmoxu_Logo_Circle_Red_New.png";
            if (File.Exists(rutaImagenPdf))
            {
                Table tablaPdf = new Table(2, false).UseAllAvailableWidth();

                iText.Layout.Element.Image imagenPdf = new iText.Layout.Element.Image(
                    ImageDataFactory.Create(rutaImagenPdf)).ScaleAbsolute(50, 50);

                Cell celda1Pdf = new Cell(1, 1)
                    .SetBorder(Border.NO_BORDER)
                    .SetTextAlignment(TextAlignment.CENTER)
                    .SetVerticalAlignment(VerticalAlignment.MIDDLE)
                    .Add(imagenPdf);
                tablaPdf.AddCell(celda1Pdf);

                string fechaActual = DateTime.Now.ToString("dddd dd/MM/yyyy HH:mm");
                string fechaFormateada = fechaActual.Substring(0, 1).ToUpper() + fechaActual.Substring(1, fechaActual.Length - 1);
                CrearCelda(TextAlignment.RIGHT, 15, tablaPdf, fechaFormateada);

                documentoPdf.Add(tablaPdf);

                Paragraph saltoDeLineaImagenPdf = new Paragraph("\n");
                documentoPdf.Add(saltoDeLineaImagenPdf);
            }
        }
        #endregion

        #region Titulo
        private void AñadirTitulo(ref Document documentoPdf, string nombreYApellidos)
        {
            Paragraph tituloPdf = new Paragraph("Credenciales " + nombreYApellidos)
                .SetTextAlignment(TextAlignment.CENTER)
                .SetFontSize(25);
            documentoPdf.Add(tituloPdf);

            LineSeparator separadorPdf = new LineSeparator(new SolidLine());
            documentoPdf.Add(separadorPdf);

            Paragraph saltoDeLineaPdf = new Paragraph("\n");
            documentoPdf.Add(saltoDeLineaPdf);
        }
        #endregion

        #region Cuerpo
        private void AñadirCuerpoPdf(ref Document documentoPdf, string usuario, string contraseña, string tipoUsuario)
        {
            Table tablaPdf = new Table(2, false);
            CrearCelda(TextAlignment.LEFT, 15, tablaPdf, "Nombre de usuario: ");
            CrearCelda(TextAlignment.LEFT, 15, tablaPdf, usuario).SetBold();
            CrearCelda(TextAlignment.LEFT, 15, tablaPdf, "Contraseña: ");
            CrearCelda(TextAlignment.LEFT, 15, tablaPdf, contraseña).SetBold();
            CrearCelda(TextAlignment.LEFT, 15, tablaPdf, "Tipo de usuario: ");
            CrearCelda(TextAlignment.LEFT, 15, tablaPdf, tipoUsuario).SetBold();
            documentoPdf.Add(tablaPdf);
        }
        #endregion

        #region Crear celdas
        private Cell CrearCelda(TextAlignment aligmnent, int fontSize, Table table, string text)
        {
            Cell cell = new Cell(1, 1)
                   .SetBorder(Border.NO_BORDER)
                   .SetTextAlignment(aligmnent)
                   .SetVerticalAlignment(VerticalAlignment.MIDDLE)
                   .Add(new Paragraph(text)
                       .SetFontSize(fontSize));
            table.AddCell(cell);
            return cell;
        }
        #endregion
        #endregion
        #endregion

        #region Validaciones y comprobaciones
        private bool ComprobarCamposNoVacios()
        {
            if (!string.IsNullOrEmpty(TxtUsuario.Texts.Trim()) && !string.IsNullOrEmpty(TxtNombre.Texts.Trim()) && CboTipoUsuario.SelectedIndex != -1)
                return true;

            string mensaje = "¡Debes completar todos los datos!";
            ShowWarningMessage(mensaje, "");
            return false;
        }

        private bool ValidarFormatoNombreUsuario()
        {
            string mensaje;
            Regex rgx = new Regex("^[a-zA-Z0-9._]{1,40}$");
            if (rgx.IsMatch(TxtUsuario.Texts.Trim()))
            {
                if (TxtUsuario.Texts.Trim().StartsWith("."))
                {
                    mensaje = "¡El nombre de usuario no puede empezar por punto!";
                    ShowWarningMessage(mensaje, "");
                    return false;
                }

                if (TxtUsuario.Texts.Trim().StartsWith("_"))
                {
                    mensaje = "¡El nombre de usuario no puede empezar por barra baja!";
                    ShowWarningMessage(mensaje, "");
                    return false;
                }
                return true;
            }

            mensaje = "¡El nombre de usuario solo puede contener una cadena 40 caracteres de letras, números, barras bajas o puntos!";
            ShowWarningMessage(mensaje, "");
            return false;
        }

        private bool ValidarUsuarioNoExistente()
        {
            string sql = "SELECT NombreUsuario FROM Usuarios WHERE NombreUsuario = '" + TxtUsuario.Texts + "'";

            if (string.IsNullOrEmpty(EjecutarScalar(sql))) return true;
            else
            {
                string mensaje = "¡El nombre de usuario ya está registrado!";
                ShowWarningMessage(mensaje, "");
                return false;
            }
        }
        #endregion

        #region Mensajes
        // Muestra un mensaje de confirmación
        private bool ConfirmarAccion(string accion)
        {
            string mensaje = "¿Desea " + accion + " al usuario actual?";
            if (ShowQuestionDialog(mensaje, "").Equals(DialogResult.Yes)) return true;
            else return false;
        }

        // Muestra un mensaje de éxito
        private void InformarAccionConExito()
        {
            string mensaje = "¡Operación concluida con éxito!";
            ShowInfoMessage(mensaje, "");
        }
        #endregion

        #region Cierre de formulario
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            string mensaje = "¿Desea salir sin guardar? Se perderán todos los cambios realizados.";
            if (ShowQuestionDialog(mensaje, "").Equals(DialogResult.Yes)) this.Close();
        }
        #endregion
    }
}
