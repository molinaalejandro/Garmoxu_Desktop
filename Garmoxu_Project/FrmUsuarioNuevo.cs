using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Draw;
using iText.Layout;
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
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Garmoxu_Project
{
    public partial class FrmUsuarioNuevo : Form
    {
        private MySqlConnection ConexionBD;
        private FrmMain Instance;
        private List<string> IdsTiposUsuario;

        public FrmUsuarioNuevo(MySqlConnection conexionBD, FrmMain instance)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            ConexionBD = conexionBD;
            Instance = instance;
            Instance.Enabled = false;
            CargarTiposDeUsuario();
        }

        #region Apertura del formulario
        #region Cargar tipos de usuario
        private void CargarTiposDeUsuario()
        {
            IdsTiposUsuario = new List<string>();

            string sql = "SELECT Nombre, IdTipoUsuario FROM TiposUsuarios ORDER BY Nombre ASC";
            MySqlCommand cmd = new MySqlCommand(sql, ConexionBD);

            MySqlDataReader lector = cmd.ExecuteReader();
            while (lector.Read())
            {
                CboTipoUsuario.Items.Add(lector[0].ToString());
                IdsTiposUsuario.Add(lector[1].ToString());
            }
            lector.Close();
        }
        #endregion
        #endregion

        #region FrontEnd
        // Cambia de color cuando el raton esta encima del Button.
        private void BtnClose_MouseEnter(object sender, EventArgs e)
        {
            BtnClose.IconColor = Color.FromArgb(240, 41, 83);
            BtnClose.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        // Cambia de color cuando el raton deja de estar encima del boton.
        private void BtnClose_MouseLeave(object sender, EventArgs e)
        {
            BtnClose.IconColor = Color.DarkGray;
        }
        #endregion

        #region Boton de Guardar cambios
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (ComprobarCamposNoVacios() && ValidarFormatoNombreUsuario()
                && ConfirmarAccion("dar de alta")
                && ValidarUsuarioNoExistente())
            {
                string contraseña = string.Empty;
                GenerarContraseñaAleatoria(ref contraseña);

                string sql = string.Format(
                "INSERT INTO Usuarios (NombreUsuario, Contraseña, NombreEmpleado, ImagenUsuario, IdTipoUsuario) " +
                "VALUES ('{0}', '{1}', '{2}', NULL, {3})",
                TxtUsuario.Texts.Trim(), contraseña,
                TxtNombre.Texts.Trim(), IdsTiposUsuario[CboTipoUsuario.SelectedIndex]);

                MySqlCommand cmd = new MySqlCommand(sql, ConexionBD);
                cmd.ExecuteNonQuery();

                ExportarAPdf(contraseña);
                InformarAccionConExito();
                this.Close();
            }
        }

        #region Generación de contraseñas
        private string GenerarContraseñaAleatoria(ref string contraseña)
        {
            contraseña = System.Web.Security.Membership.GeneratePassword(10, 0);
            MessageBox.Show(contraseña);
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
            string usuario = TxtUsuario.Texts.Trim();
            string nombreYApellidos = TxtNombre.Texts.Trim();
            string tipoUsuario = CboTipoUsuario.SelectedItem.ToString();

            bool dirSeleccionado = true;
            string ruta;
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Seleccione un directorio para exportar a PDF las credenciales del nuevo usuario";
            if (fbd.ShowDialog().Equals(DialogResult.OK))
                ruta = fbd.SelectedPath;
            else
            {
                if (!Directory.Exists("Credenciales"))
                    Directory.CreateDirectory("Credenciales");

                ruta = "Credenciales";
                dirSeleccionado = false;
            }

            PdfWriter writer = new PdfWriter(ruta + "\\Credenciales " + usuario + ".pdf");
            PdfDocument pdf = new PdfDocument(writer);
            Document document = new Document(pdf);

            Paragraph pTitulo = new Paragraph("Credenciales de " + nombreYApellidos)
               .SetTextAlignment(TextAlignment.CENTER)
               .SetFontSize(15)
               .SetBold();
            document.Add(pTitulo);

            LineSeparator separador = new LineSeparator(new SolidLine());
            document.Add(separador);

            Paragraph pSaltoDeLinea = new Paragraph("\t");
            document.Add(pSaltoDeLinea);

            Paragraph pTipoUsuario = new Paragraph("Tipo de usuario: " + tipoUsuario)
                .SetFontSize(10);
            document.Add(pTipoUsuario);

            Paragraph pUsuario = new Paragraph("Nombre de usuario: " + usuario)
                .SetFontSize(10);
            document.Add(pUsuario);

            Paragraph pContraseña = new Paragraph("Contraseña: " + contraseña)
                .SetFontSize(10);
            document.Add(pContraseña);

            document.Close();

            if(!dirSeleccionado) 
            {
                DirectoryInfo dir = new DirectoryInfo(ruta + "\\Credenciales " + usuario + ".pdf");
                string mensaje = "Se ha generado un archivo PDF con las credenciales del nuevo usuario en \"" + dir.FullName + "\"";
                MessageBox.Show(mensaje, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
        #endregion

        #region Validaciones y comprobaciones
        private bool ComprobarCamposNoVacios()
        {
            if (!string.IsNullOrEmpty(TxtUsuario.Texts.Trim()) &&
                !string.IsNullOrEmpty(TxtNombre.Texts.Trim()))
                return true;

            string mensaje = "¡Debes completar todos los campos!";
            MessageBox.Show(mensaje, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        private bool ValidarFormatoNombreUsuario()
        {
            Regex rgx = new Regex("^[a-zA-Z0-9]{1,40}$");
            if (rgx.IsMatch(TxtUsuario.Texts.Trim()))
                return true;

            string mensaje = "¡El nombre de usuario solo puede contener una secuencia de letras sin acentuación y números de 40 caracteres máximo!";
            MessageBox.Show(mensaje, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        private bool ValidarUsuarioNoExistente()
        {
            string sql = "SELECT NombreUsuario FROM Usuarios WHERE NombreUsuario = '" + TxtUsuario.Texts + "'";
            MySqlCommand comando = new MySqlCommand(sql, ConexionBD);

            if (comando.ExecuteScalar() == null)
                return true;
            else
            {
                string mensaje = "¡El nombre de usuario ya está registrado!";
                MessageBox.Show(mensaje, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }
        #endregion

        #region Mensajes
        // Muestra un mensaje de confirmación
        private bool ConfirmarAccion(string accion)
        {
            DialogResult accionConfirmada =
                MessageBox.Show("¿Desea " + accion + " al usuario actual?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (accionConfirmada.Equals(DialogResult.Yes))
                return true;
            return false;
        }

        // Muestra un mensaje de éxito
        private void InformarAccionConExito()
        {
            MessageBox.Show("¡Operación concluida con éxito!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        #region Cierre de formulario
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            string mensaje = "Se perderán todos los cambios no guardados. ¿Deseas continuar?";
            DialogResult cerrarVentana = MessageBox.Show(mensaje, "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cerrarVentana.Equals(DialogResult.Yes))
                this.Close();
        }

        private void FrmUsuarioNuevo_FormClosing(object sender, FormClosingEventArgs e)
        {
            Instance.Enabled = true;
        }
        #endregion
    }
}
