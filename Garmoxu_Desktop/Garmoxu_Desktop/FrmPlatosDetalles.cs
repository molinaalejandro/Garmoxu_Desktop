using MySql.Data.MySqlClient;
using RJCodeAdvance.RJControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Garmoxu_Desktop.MessageBoxPersonalizado;
using static Garmoxu_Desktop.ConexionMySql;

namespace Garmoxu_Desktop
{
    public partial class FrmPlatosDetalles : Form
    {
        private string ClavePrimaria;

        private List<string> DatosIniciales = new List<string>();
        private Image ImagenInicial;
        private bool ImagenCambiada;

        private List<string> IdsCategorias;

        private int IVA;

        public FrmPlatosDetalles(string clavePrimaria, int iva, ref Form frmShadow)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            ClavePrimaria = clavePrimaria;
            IVA = iva;

            CargarCategorias();
            CargarTipoFormulario();
            SombrearPantalla(ref frmShadow);
        }

        #region Apertura del formulario
        private void FrmPlatosDetalles_Shown(object sender, EventArgs e)
        {
            PicFotoPlato.Width = PicFotoPlato.Height;
            TxtIdPlato.Height = 52;
            TxtNombre.Height = 52;
            TxtPrecioConIva.Height = 52;
            TxtPrecioSinIva.Height = 52;
        }

        #region Cargar categorias
        public void CargarCategorias()
        {
            CboCategorias.Items.Clear();
            IdsCategorias = new List<string>();

            string sql = "SELECT DISTINCT Nombre, IdCategoria FROM Categorias ORDER BY Nombre ASC";
            MySqlDataReader lector = EjecutarConsulta(sql);

            while (lector.Read())
            {
                CboCategorias.Items.Add(lector.GetString(0));
                IdsCategorias.Add(lector.GetString(1));
            }
            CerrarConexion();
            lector.Close();
        }
        #endregion

        #region Cargar datos
        private void CargarTipoFormulario()
        {
            ImagenCambiada = false;

            if (!string.IsNullOrEmpty(ClavePrimaria))
            {
                LblTitulo.Text = "Consulta el plato " + ClavePrimaria;
                BtnConfirmar.Text = "Guardar";
                CargarDatos();
            }
        }

        private void CargarDatos()
        {
            string sql = "SELECT * FROM PlatosComida WHERE IdPlatoComida = '" + ClavePrimaria + "'";
            MySqlDataReader lector = EjecutarConsulta(sql);

            if (lector.Read())
            {
                TxtIdPlato.Texts = lector["IdPlatoComida"].ToString();
                TxtNombre.Texts = lector["Nombre"].ToString();
                TxtPrecioConIva.Texts = lector["PrecioConIVA"].ToString();
                //TxtPrecioSinIva.Text = lector["PrecioSinIVA"].ToString();
                TxtDescripcion.Texts = lector["Descripcion"].ToString();
                TxtListaAlergenos.Texts = lector["Alergenos"].ToString();

                int disponibilidad;
                if (lector["Disponibilidad"].ToString().Equals("True"))
                {
                    ChkDisponibilidad.Checked = true;
                    disponibilidad = 1;
                }
                else disponibilidad = 0;

                int indexCategoria = IdsCategorias.IndexOf(lector["IdCategoria"].ToString());
                CboCategorias.SelectedIndex = indexCategoria;

                CargarImagen(lector);

                DatosIniciales.Add(lector["IdPlatoComida"].ToString());
                DatosIniciales.Add(lector["Nombre"].ToString());
                DatosIniciales.Add(decimal.Parse(lector["PrecioConIVA"].ToString()).ToString(CultureInfo.CreateSpecificCulture("en-GB")));
                DatosIniciales.Add(decimal.Parse(lector["PrecioSinIVA"].ToString()).ToString(CultureInfo.CreateSpecificCulture("en-GB")));
                DatosIniciales.Add(lector["Descripcion"].ToString());
                DatosIniciales.Add(lector["Alergenos"].ToString());
                DatosIniciales.Add(disponibilidad.ToString());
                DatosIniciales.Add(IdsCategorias[indexCategoria]);
            }
            CerrarConexion();
            lector.Close();
        }

        private void CargarImagen(MySqlDataReader lector)
        {
            try
            {
                if (!string.IsNullOrEmpty(lector[5].ToString()))
                {
                    int tamañoMaximoArchivo = 16000000;
                    byte[] imagenBytes = new byte[tamañoMaximoArchivo];

                    lector.GetBytes(5, 0, imagenBytes, 0, tamañoMaximoArchivo);
                    ImagenInicial = (Bitmap)((new ImageConverter()).ConvertFrom(imagenBytes));
                }
                else ImagenInicial = Properties.Resources.No_Image_Found;
            }
            catch (Exception ex)
            {
                string mensaje = "¡No se ha podido cargar la imagen debido a que tiene un formato incompatible! Pruebe a cambiarla por otra.";
                ShowErrorMessage(mensaje, "");
                ImagenInicial = Properties.Resources.No_Image_Found;
            }

            PicFotoPlato.Image = ImagenInicial;
            PicFotoPlato.SizeMode = PictureBoxSizeMode.StretchImage;
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

        #region Funciones y diseño de controles
        #region Picture Plato
        private void PicFotoPlato_MouseEnter(object sender, EventArgs e)
        {
            PnlBordeImagen.BackColor = Color.White;
        }

        private void PicFotoPlato_MouseLeave(object sender, EventArgs e)
        {
            PnlBordeImagen.BackColor = Color.Transparent;
        }
        #endregion
        #endregion

        #region Boton de confirmar
        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals((char)Keys.Enter))
            {
                e.Handled = true;
                BtnConfirmar_Click(null, null);
            }
        }

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ClavePrimaria)) DarAltaPlato();
            else ModificarPlato();
        }

        #region Alta plato 
        private void DarAltaPlato()
        {
            if (ValidarDatosCompletados() && ConfirmarAccion("dar de alta") && ValidarFormatoId()
                && ValidarPlatoNoRepetido() && ValidarNombreNoRegistrado())
            {
                List<string> datosActuales = RecogerDatosActuales();

                string sql = string.Format(
                    "INSERT INTO PlatosComida(IdPlatoComida, Nombre, PrecioConIVA, PrecioSinIVA, " +
                    "Descripcion, ImagenPlato, Alergenos, Disponibilidad, IdCategoria) " +
                    "VALUES('{0}', '{1}', '{2}', '{3}', '{4}', {5}, '{6}', '{7}', '{8}')",
                    datosActuales[0], datosActuales[1], datosActuales[2], datosActuales[3],
                    datosActuales[4], ImagenCambiada ? "@imagen" : "NULL", datosActuales[5], datosActuales[6], datosActuales[7]
                    );

                if (ImagenCambiada)
                {
                    byte[] imagenBytes = (byte[])new ImageConverter().ConvertTo(PicFotoPlato.Image, typeof(byte[]));
                    EjecutarSentencia(sql, imagenBytes);
                }
                else EjecutarSentencia(sql);

                InformarAccionConExito();
                this.Close();
            }
        }
        #endregion

        #region Modificar plato
        private void ModificarPlato()
        {
            string valores = string.Empty;
            byte[] imagenBytes = null;
            if (ValidarDatosCompletados() && ComprobarDatosModificados(ref valores, ref imagenBytes)
                && ConfirmarAccion("guardar los cambios realizados en") && ValidarFormatoId()
                && ValidarPlatoNoRepetido() && ValidarNombreNoRegistrado())
            {
                string sql = "UPDATE PlatosComida SET " + valores + " WHERE IdPlatoComida = '" + ClavePrimaria + "'";
                if (ImagenCambiada && imagenBytes != null) EjecutarSentencia(sql, imagenBytes);
                else EjecutarSentencia(sql);

                InformarAccionConExito();
                this.Close();
            }
        }

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

            try
            {
                if (ImagenCambiada)
                {
                    imagenBytes = (byte[])new ImageConverter().ConvertTo(PicFotoPlato.Image, typeof(byte[]));
                    if (!string.IsNullOrEmpty(valores)) valores += ", ";
                    valores += "ImagenPlato = @imagen";
                    modificacionRealizada = true;
                }
            }
            catch (Exception ex)
            {
                string mensaje = "¡La imagen seleccionada tiene un formato incompatible! Pruebe a cambiarla por otra.";
                ShowErrorMessage(mensaje, "");
            }

            if (!modificacionRealizada) this.Close();
            return modificacionRealizada;
        }

        private List<string> InicializarListaColumnasDatos()
        {
            List<string> columnas = new List<string>();
            columnas.Add("IdPlatoComida = '");
            columnas.Add("Nombre = '");
            columnas.Add("PrecioConIVA = ");
            columnas.Add("PrecioSinIVA = ");
            columnas.Add("Descripcion = '");
            columnas.Add("Alergenos = '");
            columnas.Add("Disponibilidad = ");
            columnas.Add("IdCategoria = ");
            return columnas;
        }
        #endregion

        #region Recogida de datos
        private List<string> RecogerDatosActuales()
        {
            List<string> datosActuales = new List<string>();

            string conIva;
            string sinIva;
            try
            {
                conIva = decimal.Parse(TxtPrecioConIva.Texts.Replace(".", ",")).ToString(CultureInfo.CreateSpecificCulture("en-GB"));
                if (!conIva.Contains('.')) conIva += ".00";
                else if (conIva.Split('.')[1].Length == 1) conIva += "0";

                sinIva = decimal.Parse(TxtPrecioSinIva.Texts.Replace(".", ",")).ToString(CultureInfo.CreateSpecificCulture("en-GB"));
                if (!sinIva.Contains('.')) sinIva += ".00";
                else if (sinIva.Split('.')[1].Length == 1) sinIva += "0";
            }
            catch (FormatException ex)
            {
                conIva = string.Empty;
                sinIva = string.Empty;
            }

            string disponibilidad;
            if (ChkDisponibilidad.Checked) disponibilidad = "1";
            else disponibilidad = "0";

            int idCategoria = int.Parse(IdsCategorias[CboCategorias.SelectedIndex]);

            datosActuales.Add(TxtIdPlato.Texts.Replace(" ", ""));
            datosActuales.Add(TxtNombre.Texts.Trim());
            datosActuales.Add(conIva);
            datosActuales.Add(sinIva);
            datosActuales.Add(TxtDescripcion.Texts.Trim());
            datosActuales.Add(TxtListaAlergenos.Texts.Trim());
            datosActuales.Add(disponibilidad);
            datosActuales.Add(idCategoria.ToString());

            return datosActuales;
        }
        #endregion

        #region Validaciones y comprobaciones
        private bool ValidarDatosCompletados()
        {
            if (!string.IsNullOrEmpty(TxtIdPlato.Texts.Replace(" ", "")) && !string.IsNullOrEmpty(TxtNombre.Texts.Replace(" ", ""))
                && !string.IsNullOrEmpty(TxtPrecioSinIva.Texts.Replace(" ", "")) && !string.IsNullOrEmpty(TxtPrecioConIva.Texts.Replace(" ", ""))
                && CboCategorias.SelectedIndex != -1)
                return true;

            string mensaje = "¡Debes completar todos los datos!";
            ShowWarningMessage(mensaje, "");
            return false;
        }

        private bool ValidarFormatoId()
        {
            if (TxtIdPlato.Texts.Replace(" ", "").Length > 10)
            {
                string mensaje = "¡El identificador del plato es demasiado largo!";
                ShowErrorMessage(mensaje, "");
                return false;
            }
            return true;
        }

        private bool ValidarPlatoNoRepetido()
        {
            string sql = "SELECT IdPlatoComida FROM PlatosComida WHERE IdPlatoComida = '" + TxtIdPlato.Texts.Replace(" ", "") + "'";
            string scalar = EjecutarScalar(sql);

            if (string.IsNullOrEmpty(scalar)) return true;

            bool esIdActual = !string.IsNullOrEmpty(ClavePrimaria) && scalar.Equals(DatosIniciales[0]);
            if (esIdActual) return true;

            string mensaje = "¡El identificador del plato introducido ya está registrado!";
            ShowWarningMessage(mensaje, "");
            return false;
        }

        private bool ValidarNombreNoRegistrado()
        {
            string sql = "SELECT Nombre FROM PlatosComida WHERE Nombre = '" + TxtNombre.Texts.Trim() + "'";
            string scalar = EjecutarScalar(sql);

            if (string.IsNullOrEmpty(scalar)) return true;

            bool esNombreActual = !string.IsNullOrEmpty(ClavePrimaria) && scalar.Equals(DatosIniciales[1]);
            if (esNombreActual) return true;

            string mensaje = "¡El nombre del plato introducido ya está registrado!";
            ShowWarningMessage(mensaje, "");
            return false;
        }
        #endregion
        #endregion

        #region Botón cambiar foto
        private void BtnCambiarFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Selecciona una imagen para tu plato";
            ofd.Filter = "Archivo de imagen |*.jpg| Archivo PNG|*.png";

            try
            {
                if (ofd.ShowDialog().Equals(DialogResult.OK))
                {
                    string ruta = ofd.FileName;
                    if (new FileInfo(ruta).Length <= 15000000)
                    {
                        PicFotoPlato.Image = Image.FromFile(ruta); ;
                        ImagenCambiada = true;
                    }
                    else ShowWarningMessage("¡La imagen no puede ser mayor de 15MB!", "");
                }
            }
            catch (Exception ex)
            {
                string mensaje = "¡La imagen seleccionada tiene un formato incompatible! Pruebe a cambiarla por otra.";
                ShowErrorMessage(mensaje, "");
            }
        }
        #endregion

        #region Cálculo del IVA automatico
        private void TxtPrecio__TextChanged(object sender, EventArgs e)
        {
            TextBox txtActual = sender as TextBox;
            int initialCaretPosition = txtActual.SelectionStart;

            RJTextBox txtAsignar = TxtPrecioConIva;
            if (txtActual.Parent.Name.Equals("TxtPrecioConIva")) txtAsignar = TxtPrecioSinIva;

            decimal ivaLocal = decimal.Parse("1," + IVA.ToString());

            string precio = txtActual.Text.Replace(" ", "");
            if (!string.IsNullOrEmpty(precio) && ValidarPrecio(precio))
            {
                precio = precio.Replace(",", ".");
                decimal numFormateado = decimal.Parse(precio, CultureInfo.InvariantCulture);
                decimal numResult;

                if (txtActual.Parent.Name.Equals("TxtPrecioConIva")) numResult = decimal.Round(numFormateado / ivaLocal, 2);
                else numResult = decimal.Round(numFormateado * ivaLocal, 2);

                if (!CalcularParadaTextBox(txtAsignar, txtActual, ivaLocal))
                {
                    txtAsignar.Texts = numResult.ToString(CultureInfo.InvariantCulture);

                    ((RJTextBox)txtActual.Parent).Texts = precio;
                    txtActual.Select(initialCaretPosition, 0);
                }
            }
        }

        private bool CalcularParadaTextBox(RJTextBox txtAsignar, TextBox txtActual, decimal ivaLocal)
        {
            bool debeParar = false;
            string textTxtAsignar = txtAsignar.Texts.Replace(",", ".");

            if (!string.IsNullOrEmpty(textTxtAsignar))
            {
                decimal numTxtAsignar = decimal.Parse(textTxtAsignar, CultureInfo.InvariantCulture);
                decimal numCalculado;

                if (txtAsignar.Name.Equals("TxtPrecioConIva")) numCalculado = decimal.Round(numTxtAsignar / ivaLocal, 2);
                else numCalculado = decimal.Round(numTxtAsignar * ivaLocal, 2);

                debeParar = numCalculado.ToString().Equals(txtActual.Text);
            }

            return debeParar;
        }

        private void TxtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            RJTextBox txtActual = sender as RJTextBox;
            if (txtActual.Name.Equals("TxtPrecioConIva")) TxtPrecioSinIva.Texts = string.Empty;
            else TxtPrecioConIva.Texts = string.Empty;
        }

        private bool ValidarPrecio(string precio)
        {
            Regex rgx = new Regex("^[0-9]{1,8}[\\.,]$");
            if (rgx.IsMatch(precio)) return false;

            rgx = new Regex("^[0-9]{1,8}([\\.,][0-9]{1,2})?$");
            if (!rgx.IsMatch(precio))
            {
                string mensaje = "¡Formato de precio no válido!";
                ShowWarningMessage(mensaje, "");
                return false;
            }

            return true;
        }
        #endregion

        #region Mensajes
        // Muestra un mensaje de confirmación
        private bool ConfirmarAccion(string accion)
        {
            string mensaje = "¿Desea " + accion + " el plato actual?";
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

        #region Cierre del formulario
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            CerrarFormulario();
        }

        private void CerrarFormulario()
        {
            string var = string.Empty;
            byte[] var2 = null;
            if (string.IsNullOrEmpty(ClavePrimaria) || ComprobarDatosModificados(ref var, ref var2))
            {
                string mensaje = "¿Desea salir sin guardar? Se perderán todos los cambios realizados.";
                if (ShowQuestionDialog(mensaje, "").Equals(DialogResult.Yes)) this.Close();
            }
        }
        #endregion Cierre del formulario
    }
}