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
    public partial class FrmPedidosPlatosConsultaDetalles : Form
    {
        private string ClavePrimaria;

        private List<string> DatosIniciales = new List<string>();
        private Image ImagenInicial;

        private List<string> IdsCategorias;

        public FrmPedidosPlatosConsultaDetalles(string clavePrimaria, ref Form frmShadow)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            ClavePrimaria = clavePrimaria;

            CargarCategorias();
            CargarDatos();
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
        private void CargarDatos()
        {
            string sql = "SELECT * FROM PlatosComida WHERE IdPlatoComida = '" + ClavePrimaria + "'";

            MySqlDataReader lector = EjecutarConsulta(sql);
            if (lector.Read())
            {
                LblTitulo.Text = "Consulta el plato " + ClavePrimaria;
                TxtIdPlato.Texts = lector["IdPlatoComida"].ToString();
                TxtNombre.Texts = lector["Nombre"].ToString();
                TxtPrecioConIva.Texts = lector["PrecioConIVA"].ToString();
                TxtPrecioSinIva.Texts = lector["PrecioSinIVA"].ToString();
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
                LblCboDisabled.Text = CboCategorias.Items[indexCategoria].ToString();

                CargarImagen(lector);

                DatosIniciales.Add(lector["IdPlatoComida"].ToString());
                DatosIniciales.Add(lector["Nombre"].ToString());
                DatosIniciales.Add(decimal.Parse(lector["PrecioConIVA"].ToString()).ToString(CultureInfo.CreateSpecificCulture("en-GB")));
                DatosIniciales.Add(decimal.Parse(lector["PrecioSinIVA"].ToString()).ToString(CultureInfo.CreateSpecificCulture("en-GB")));
                DatosIniciales.Add(lector["Descripcion"].ToString());
                DatosIniciales.Add(lector["Alergenos"].ToString());
                DatosIniciales.Add(disponibilidad.ToString());
                DatosIniciales.Add((indexCategoria + 1).ToString());
            }
            CerrarConexion();
            lector.Close();
        }

        private void CargarImagen(MySqlDataReader lector)
        {
            if (!string.IsNullOrEmpty(lector[5].ToString()))
            {
                int tamañoMaximoArchivo = 16000000;
                byte[] imagenBytes = new byte[tamañoMaximoArchivo];

                lector.GetBytes(5, 0, imagenBytes, 0, tamañoMaximoArchivo);
                ImagenInicial = (Bitmap)((new ImageConverter()).ConvertFrom(imagenBytes));
            }
            else ImagenInicial = Properties.Resources.No_Image_Found;

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

        #region Cierre del formulario
        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
