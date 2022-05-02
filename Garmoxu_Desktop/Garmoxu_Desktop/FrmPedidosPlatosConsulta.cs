using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Garmoxu_Desktop
{
    public partial class FrmPedidosPlatosConsulta : Form
    {
        private MySqlConnection ConexionBD;
        private FrmMain Instance;

        public FrmPedidosPlatosConsulta(MySqlConnection conexionBD, FrmMain instance)
        {
            InitializeComponent();
            ConexionBD = conexionBD;
            Instance = instance;
            CargarPlatos();
            CargarComboBoxCategorias();
        }

        #region Apertura del formulario
        private void CargarPlatos()
        {
            string sql = "SELECT IdPlatoComida, Nombre, ImagenPlato FROM PlatosComida ORDER BY Nombre ASC";
            RellenarListView(sql);
        }

        private void RellenarListView(string sql)
        {
            MySqlCommand cmd = new MySqlCommand(sql, ConexionBD);

            MySqlDataReader lector = cmd.ExecuteReader();

            LstPlatos.Items.Clear();
            ImgImagenesPlatos.Images.Clear();
            while (lector.Read())
            {
                ImgImagenesPlatos.Images.Add(CargarImagen(lector));
                LstPlatos.Items.Add(lector[1].ToString(), ImgImagenesPlatos.Images.Count - 1); // Metemos nombre y fotos
                LstPlatos.Items[LstPlatos.Items.Count - 1].Tag = lector[0].ToString(); // Guardamos el código de plato para organizar en detalles
            }
            lector.Close();
        }

        private Image CargarImagen(MySqlDataReader lector)
        {
            if (!string.IsNullOrEmpty(lector[2].ToString()))
            {
                int tamañoMaximoArchivo = 16000000;
                byte[] imagenBytes = new byte[tamañoMaximoArchivo];

                lector.GetBytes(2, 0, imagenBytes, 0, tamañoMaximoArchivo);
                Image fotoconvertida = (Bitmap)((new ImageConverter()).ConvertFrom(imagenBytes));

                return fotoconvertida;
            }
            else
                return Properties.Resources.No_Image_Found;
        }

        private void CargarComboBoxCategorias()
        {
            //String sql = "SELECT DISTINCT c.Nombre FROM PlatosComida pc, Categorias c WHERE pc.IdCategoria = c.IdCategoria";
            String sql = "SELECT DISTINCT Nombre FROM Categorias ORDER BY Nombre ASC";

            MySqlCommand cmd = new MySqlCommand(sql, ConexionBD);

            MySqlDataReader lector = cmd.ExecuteReader();

            while (lector.Read())
                CboCategoria.Items.Add(lector[0].ToString());
            lector.Close();
        }
        #endregion

        #region Búsqueda de platos
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            BuscarPlatos();
        }

        private void BuscarPlatos()
        {
            string filtro = string.Empty;

            if (ChkNombrePlato.Checked && !string.IsNullOrEmpty(TxtNombre.Texts.Replace(" ", "")))
                filtro = "pc.Nombre LIKE '%" + TxtNombre.Texts.Trim() + "%'";

            if (ChkCategoriaPlato.Checked && CboCategoria.SelectedIndex != -1)
            {
                if (!string.IsNullOrEmpty(filtro.Trim()))
                    filtro += " AND ";
                filtro += "c.Nombre = '" + CboCategoria.SelectedItem + "'";
            }

            if (TglDisponibilidad.Checked)
            {
                if (!string.IsNullOrEmpty(filtro.Trim()))
                    filtro += " AND ";
                filtro += "pc.Disponibilidad = 1";
            }
            else
            {
                if (!string.IsNullOrEmpty(filtro.Trim()))
                    filtro += " AND ";
                filtro += "pc.Disponibilidad = 0";
            }

            string sql = "SELECT IdPlatoComida, pc.Nombre, ImagenPlato FROM PlatosComida pc, Categorias c " +
                "WHERE pc.IdCategoria = c.IdCategoria AND " + filtro + " ORDER BY pc.Nombre ASC";
            RellenarListView(sql);
        }

        #region Comportamiento y activaciones de elementos de filtrado
        private void CboCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CboCategoria.SelectedIndex != -1)
                ChkCategoriaPlato.Checked = true;
            else
                ChkCategoriaPlato.Checked = false;
        }

        private void TxtNombre__TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtNombre.Texts.Replace(" ", "")))
                ChkNombrePlato.Checked = true;
            else
                ChkNombrePlato.Checked = false;
        }

        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals((char)Keys.Enter))
                BuscarPlatos();
        }
        #endregion
        #endregion

        #region Apertura de detalles de un plato
        private void LstPlatos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // Abrimos el formulario de detalles con la clave primaria para ver los detalles
            string clavePrimaria = LstPlatos.SelectedItems[0].Tag.ToString();
            FrmPedidosPlatosConsultaDetalles frm = new FrmPedidosPlatosConsultaDetalles(ConexionBD, clavePrimaria); // Coger el tag = Clave primaria
            frm.Tag = LstPlatos.SelectedItems[0].Tag.ToString();

            bool encontrado = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.GetType().Equals(frm.GetType()) && 
                    f.Tag.ToString().Equals(frm.Tag.ToString()))
                {
                    encontrado = true;
                    f.Show();
                    f.BringToFront();
                }
            }

            if (!encontrado)
            {
                frm.Width = Instance.Width / 2;
                frm.Height = Instance.Height / 2 + Instance.Height / 3;
                frm.Show();
            }
        }
        #endregion

        #region Cierre del formulario
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
