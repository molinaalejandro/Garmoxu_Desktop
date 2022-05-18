using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Garmoxu_Desktop
{
    public partial class FrmCategoriasDetalles : Form
    {
        private MySqlConnection ConexionBD;
        private string ClavePrimaria;
        //private Form FrmShadow;

        private Image ImagenInicial;
        private List<string> DatosIniciales;

        public FrmCategoriasDetalles(MySqlConnection conexionBD, string clavePrimaria, ref Form frmShadow)
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            ConexionBD = conexionBD;
            ClavePrimaria = clavePrimaria;

            SombrearPantalla(ref frmShadow);
            CargarTipoFormulario();
        }

        #region Apertura del formulario
        #region Cargar datos
        private void CargarTipoFormulario()
        {
            if (!string.IsNullOrEmpty(ClavePrimaria))
            {
                LblTitulo.Text = "Consulta la categoría " + ClavePrimaria;
                BtnConfirmar.Text = "Guardar";
                CargarDatos();
            }
        }

        private void CargarDatos()
        {
            string sql = "SELECT * FROM Categorias WHERE IdCategoria = '" + ClavePrimaria + "'";
            MySqlCommand cmd = new MySqlCommand(sql, ConexionBD);
            MySqlDataReader lector = cmd.ExecuteReader();

            if (lector.Read())
            {
                DatosIniciales = new List<string>();

                DatosIniciales.Add(lector["Nombre"].ToString());
                TxtNombre.Texts = lector["Nombre"].ToString();

                CargarImagen(lector);
            }
            lector.Close();
        }

        private void CargarImagen(MySqlDataReader lector)
        {
            Image imagen;

            if (!string.IsNullOrEmpty(lector["ImagenCategoria"].ToString()))
            {
                int tamañoMaximoArchivo = 16000000;
                byte[] imagenBytes = new byte[tamañoMaximoArchivo];

                lector.GetBytes(2, 0, imagenBytes, 0, tamañoMaximoArchivo);
                imagen = (Bitmap)((new ImageConverter()).ConvertFrom(imagenBytes));
            }
            else
                imagen = Properties.Resources.No_Image_Found;

            ImagenInicial = imagen;
            PicImagenCategoria.Image = imagen;
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
            frmShadow.BackColor = Color.Black;
            frmShadow.Opacity = 0.7;
            frmShadow.Location = Location;
            frmShadow.Enabled = false;
            frmShadow.TopMost = true;
            frmShadow.Show();
        }
        #endregion
        #endregion

        #region Funciones y diseños de controles
        private void PicImagenCategoria_MouseEnter(object sender, EventArgs e)
        {
            PnlBordeImagen.BackColor = Color.Silver;
        }

        private void PicImagenCategoria_MouseLeave(object sender, EventArgs e)
        {
            PnlBordeImagen.BackColor = Color.Transparent;
        }
        #endregion

        #region Cambio de imagen
        private void PicImagenCategoria_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Selecciona una imagen para tu categoría";
            //ofd.Filter = "Archivo de imagen |*.jpg| Archivo PNG|*.png| Todos los archivos|*.*";
            ofd.Filter = "Archivo de imagen |*.jpg| Archivo PNG|*.png";

            if (ofd.ShowDialog().Equals(DialogResult.OK))
            {
                string ruta = ofd.FileName;

                if (new FileInfo(ruta).Length <= 15000000)
                    PicImagenCategoria.Image = Image.FromFile(ruta);
                else
                    MessageBox.Show("¡La imagen no puede ser mayor de 15MB!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        #region Boton de confirmar
        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ClavePrimaria))
                DarAltaCategoria();
            else
                ModificarCategoria();
        }

        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals((char)Keys.Enter)) BtnConfirmar_Click(null, null);
        }

        #region Alta de categorias
        private void DarAltaCategoria()
        {
            if (ValidarDatosCompletados() && ValidarFormatoNombre() && ConfirmarAccion("dar de alta")
                && ValidarNombreNoRegistrado())
            {
                string sql = string.Format(
                    "INSERT INTO Categorias (Nombre, ImagenCategoria) " +
                    "VALUES ('{0}', @imagen)",
                    TxtNombre.Texts.Trim());

                MySqlCommand cmd = new MySqlCommand(sql, ConexionBD);
                byte[] imagenBytes = (byte[])(new ImageConverter()).ConvertTo(PicImagenCategoria.Image, typeof(byte[]));
                cmd.Parameters.Add("@imagen", MySqlDbType.MediumBlob).Value = imagenBytes;
                cmd.ExecuteNonQuery();

                InformarAccionConExito();
                this.Close();                
            }
        }
        #endregion

        #region Modificación de categorias
        private void ModificarCategoria()
        {
            string valores = string.Empty;
            byte[] imagenBytes = null;
            if (ValidarDatosCompletados() && ValidarFormatoNombre() && ComprobarDatosModificados(ref valores, ref imagenBytes)
                && ConfirmarAccion("guardar los cambios realizados en") && ValidarNombreNoRegistrado())
            {
                string sql = string.Format(
                    "UPDATE Categorias SET {0} WHERE IdCategoria = {1}",
                    valores, ClavePrimaria);
                MySqlCommand cmd = new MySqlCommand(sql, ConexionBD);
                if (imagenBytes != null) cmd.Parameters.Add("@imagen", MySqlDbType.MediumBlob).Value = imagenBytes;
                cmd.ExecuteNonQuery();

                InformarAccionConExito();
                this.Close();
            }
        }
        #endregion
        #endregion

        #region Validaciones y comprobaciones
        private bool ValidarDatosCompletados()
        {
            if (!string.IsNullOrEmpty(TxtNombre.Texts.Trim()))
                return true;

            string mensaje = "¡Debes completar todos los datos!";
            MessageBox.Show(mensaje, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        private bool ValidarFormatoNombre()
        {
            if (TxtNombre.Texts.Trim().Length < 101)
                return true;

            MostrarMensaje("¡El nombre de la categoría no puede contener más de 100 caracteres!", MessageBoxIcon.Warning);
            return false;
        }

        private bool ValidarNombreNoRegistrado()
        {
            string sql = "SELECT Nombre FROM Categorias WHERE Nombre = '" + TxtNombre.Texts.Trim() + "'";
            MySqlCommand cmd = new MySqlCommand(sql, ConexionBD);

            if (cmd.ExecuteScalar() == null)
                return true;

            bool esIdActual = !string.IsNullOrEmpty(ClavePrimaria) && cmd.ExecuteScalar().ToString().Equals(DatosIniciales[0]);
            if (esIdActual)
                return true;

            MostrarMensaje("¡El nombre escogido ya está en uso!", MessageBoxIcon.Warning);
            return false;
        }

        #region Comprobar cambios
        public bool ComprobarDatosModificados(ref string valores, ref byte[] imagenBytes)
        {
            bool modificacionRealizada = false;
            string dato;

            List<string> datosActuales = RecogerDatosActuales();
            List<string> columnasDatos = InicializarListaColumnasDatos();
            List<string> datosModificados = new List<string>();

            for (int i = 0; i < DatosIniciales.Count; i++)
            {
                if (!DatosIniciales[i].Equals(datosActuales[i]))
                {
                    bool llevaComillas = columnasDatos[i].Last<char>() == '\'';
                    if (llevaComillas && datosActuales[i].Equals("NULL"))
                    {
                        columnasDatos[i] = columnasDatos[i].Remove(columnasDatos[i].Length - 1);
                        llevaComillas = false;
                    }
                    dato = columnasDatos[i] + datosActuales[i];
                    if (llevaComillas) dato += "'";
                    datosModificados.Add(dato);
                    modificacionRealizada = true;
                }
            }

            // Le da el formato adecuado para la sentencia SQL
            for (int i = 0; i < datosModificados.Count; i++)
            {
                valores += datosModificados[i];
                if (i != datosModificados.Count - 1) valores += ", ";
            }

            Image fotoActual = PicImagenCategoria.Image;
            if (!ImagenInicial.Equals(fotoActual))
            {
                imagenBytes = (byte[])(new ImageConverter()).ConvertTo(fotoActual, typeof(byte[]));
                if (!string.IsNullOrEmpty(valores)) valores += ", ";
                valores += "ImagenCategoria = @imagen";
                modificacionRealizada = true;
            }

            if (!modificacionRealizada) this.Close();
            return modificacionRealizada;
        }

        private List<string> RecogerDatosActuales()
        {
            List<string> datosActuales = new List<string>();
            datosActuales.Add(TxtNombre.Texts.Trim());
            return datosActuales;
        }

        private List<string> InicializarListaColumnasDatos()
        {
            List<string> columnas = new List<string>();
            columnas.Add("Nombre = '");
            return columnas;
        }
        #endregion
        #endregion

        #region Mensajes
        private void MostrarMensaje(string mensaje, MessageBoxIcon iconoDeseado)
        {
            MessageBox.Show(mensaje, "", MessageBoxButtons.OK, iconoDeseado);
        }

        // Muestra un mensaje de confirmación
        private bool ConfirmarAccion(string accion)
        {
            DialogResult accionConfirmada =
                MessageBox.Show("¿Desea " + accion + " la categoria actual?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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

        #region Cierre del formulario
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            CerrarFormulario();
        }

        private void CerrarFormulario()
        {
            string v = string.Empty;
            byte[] v2 = null;
            if (string.IsNullOrEmpty(ClavePrimaria) || ComprobarDatosModificados(ref v, ref v2))
            {
                string mensaje = "¿Desea salir sin guardar? No se aplicarán los cambios realizados";
                DialogResult cerrarVentana = MessageBox.Show(mensaje, "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (cerrarVentana.Equals(DialogResult.Yes))
                    this.Close();
            }
        }
        #endregion
    }
}