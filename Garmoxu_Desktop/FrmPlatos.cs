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
    public partial class FrmPlatos : Form
    {
        private MySqlConnection ConexionBD;
        private FrmMain Instance;

        public FrmPlatos(MySqlConnection conexionBD, FrmMain instance)
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
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
                return Properties.Resources.noImage;
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
            {
                ChkCategoriaPlato.Checked = true;
                BuscarPlatos();
            }
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

        #region Eliminación de platos
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string codigoPlatoCogido = LstPlatos.SelectedItems[0].Tag.ToString();

                if (ConfirmarAccion("eliminar permanentemente") && !ComprobarPedidoPlatoAsociado(codigoPlatoCogido))
                {
                    ImgImagenesPlatos.Images.RemoveAt(LstPlatos.SelectedItems[0].ImageIndex);
                    LstPlatos.Items.RemoveAt(LstPlatos.SelectedItems[0].Index);

                    string sql = "DELETE FROM PlatosComida WHERE IdPlatoComida = '" + codigoPlatoCogido + "'";
                    MySqlCommand cmd = new MySqlCommand(sql, ConexionBD);
                    cmd.ExecuteNonQuery();

                    InformarAccionConExito();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("¡No se ha podido eliminar el plato!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ComprobarPedidoPlatoAsociado(string codigoPlatoCogido)
        {
            string sql = "SELECT * FROM PedidosEnCursoPlatos WHERE IdPlatoComida = '" + codigoPlatoCogido + "'";
            MySqlCommand cmd = new MySqlCommand(sql, ConexionBD);

            if (cmd.ExecuteScalar() == null)
                return false;
            else
            {
                string mensaje = "¡No se ha podido eliminar debido a que existe un pedido en curso que contiene este plato! " +
                        "Debe finalizar todos los pedidos asociados antes de eliminarlo";
                MessageBox.Show(mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return true;
            }
        }

        private void LstPlatos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LstPlatos.SelectedItems.Count > 0)
                BtnEliminar.Enabled = true;
            else
                BtnEliminar.Enabled = false;
        }
        #endregion

        #region Alta de platos
        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            FrmPlatosDetalles frm = new FrmPlatosDetalles(ConexionBD, string.Empty, Instance);
            frm.Width = Instance.Width / 2;
            frm.Height = Instance.Height / 2 + Instance.Height / 3;
            Instance.Enabled = false;

            frm.Show();
        }
        #endregion

        #region Apertura de detalles de un plato
        private void LstPlatos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string clavePrimaria = LstPlatos.SelectedItems[0].Tag.ToString();
            FrmPlatosDetalles frm = new FrmPlatosDetalles(ConexionBD, clavePrimaria, Instance);
            frm.Width = Instance.Width / 2;
            frm.Height = Instance.Height / 2 + Instance.Height / 3;
            Instance.Enabled = false;

            frm.Show();
        }
        #endregion

        #region Actualización automatica al cerrar los detalles/nuevo plato
        private void FrmPlatos_EnabledChanged(object sender, EventArgs e)
        {
            if (this.Enabled)
            {
                LstPlatos.Items.Clear();
                ImgImagenesPlatos.Images.Clear();
                CargarPlatos();
            }
        }
        #endregion

        #region Mensajes
        // Muestra un mensaje de confirmación
        private bool ConfirmarAccion(String accion)
        {
            DialogResult accionConfirmada =
                MessageBox.Show("¿Desea " + accion + " el pedido actual?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
