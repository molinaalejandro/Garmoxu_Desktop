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

        public FrmPedidosPlatosConsulta(MySqlConnection conexionBD, ref Form frmShadow)
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            ConexionBD = conexionBD;
            BuscarPlatos();
            CargarComboBoxCategorias();
            SombrearPantalla(ref frmShadow);
        }

        #region Apertura del formulario
        private void RellenarListView(string sql)
        {
            bool continuar = ValidarCategoriaExistente();

            if (continuar)
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
        }

        private bool ValidarCategoriaExistente()
        {
            if (CboCategoria.SelectedIndex != -1)
            {
                string sql = "SELECT * FROM Categorias WHERE NombreCategoria = " + CboCategoria.SelectedItem.ToString();
                MySqlCommand cmd = new MySqlCommand(sql, ConexionBD);
                if (cmd == null)
                {
                    string mensaje = "¡La categoría seleccionada ya no está disponible!";
                    MessageBox.Show(mensaje, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    CargarComboBoxCategorias();
                    return false;
                }
            }
            return true;
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
            string sql = "SELECT DISTINCT Nombre FROM Categorias ORDER BY Nombre ASC";
            MySqlCommand cmd = new MySqlCommand(sql, ConexionBD);
            MySqlDataReader lector = cmd.ExecuteReader();

            CboCategoria.Items.Clear();
            while (lector.Read())
                CboCategoria.Items.Add(lector[0].ToString());
            lector.Close();
        }
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
        #region Text Box Nombre
        private void TxtNombre_Enter(object sender, EventArgs e)
        {
            if (TxtNombre.Texts.Trim().Equals("Buscar por nombre de plato"))
            {
                TxtNombre.Texts = string.Empty;
                TxtNombre.ForeColor = Color.Gainsboro;
            }
        }

        private void TxtNombre_Leave(object sender, EventArgs e)
        {
            if (TxtNombre.Texts.Trim().Equals(string.Empty))
            {
                TxtNombre.Texts = "Buscar por nombre de plato";
                TxtNombre.ForeColor = Color.Gray;
            }
        }
        #endregion

        #region Botón Buscar
        private void BtnBuscar_MouseEnter(object sender, EventArgs e)
        {
            BtnBuscar.IconColor = Color.DeepSkyBlue;
        }

        private void BtnBuscar_MouseLeave(object sender, EventArgs e)
        {
            BtnBuscar.IconColor = Color.MediumSlateBlue;

        }
        #endregion

        #region Check box categoria
        private void ChkNombre_MouseEnter(object sender, EventArgs e)
        {
            ChkNombre.BorderColor = ChkNombre.EnterColor;
            ChkNombre.ForeColor = ChkNombre.EnterColor;
            LblNombre.ForeColor = ChkNombre.EnterColor;
            ChkNombre.Invalidate();
        }

        private void ChkNombre_MouseLeave(object sender, EventArgs e)
        {
            ChkNombre.BorderColor = ChkNombre.LeaveColor;
            ChkNombre.ForeColor = ChkNombre.LeaveColor;
            LblNombre.ForeColor = ChkNombre.LeaveColor;
            ChkNombre.Invalidate();
        }
        #endregion

        #region Check box categoria
        private void ChkCategoría_MouseEnter(object sender, EventArgs e)
        {
            ChkCategoría.BorderColor = ChkCategoría.EnterColor;
            ChkCategoría.ForeColor = ChkCategoría.EnterColor;
            LblCategoria.ForeColor = ChkCategoría.EnterColor;
            ChkCategoría.Invalidate();
        }

        private void ChkCategoría_MouseLeave(object sender, EventArgs e)
        {
            ChkCategoría.BorderColor = ChkCategoría.LeaveColor;
            ChkCategoría.ForeColor = ChkCategoría.LeaveColor;
            LblCategoria.ForeColor = ChkCategoría.LeaveColor;
            ChkCategoría.Invalidate();
        }
        #endregion
        #endregion

        #region Búsqueda de platos
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            BuscarPlatos();
        }

        private void BuscarPlatos()
        {
            string filtro = string.Empty;

            if (ChkNombre.Checked && !string.IsNullOrEmpty(TxtNombre.Texts.Trim()) && !TxtNombre.Texts.Equals("Buscar por nombre de plato"))
                filtro = "pc.Nombre LIKE '%" + TxtNombre.Texts.Trim() + "%'";

            if (ChkCategoría.Checked && CboCategoria.SelectedIndex != -1)
            {
                if (!string.IsNullOrEmpty(filtro.Trim()))
                    filtro += " AND ";
                filtro += "c.Nombre = '" + CboCategoria.SelectedItem + "'";
            }

            if (TgbDisponibilidad.Checked)
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
                ChkCategoría.Checked = true;
                ChkCategoría.Invalidate();
                BuscarPlatos();
            }
            else
            {
                ChkCategoría.Checked = false;
                ChkCategoría.Invalidate();
            }
        }

        private void TxtNombre__TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtNombre.Texts.Trim()) && !TxtNombre.Texts.Equals("Buscar por nombre de plato"))
            {
                ChkNombre.Checked = true;
                ChkNombre.Invalidate();
            }
            else
            {
                ChkNombre.Checked = false;
                ChkNombre.Invalidate();
            }
        }

        private void TgbDisponibilidad_CheckedChanged(object sender, EventArgs e)
        {
            BuscarPlatos();
        }

        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals((char)Keys.Enter))
            {
                if (!string.IsNullOrEmpty(TxtNombre.Texts))
                    e.Handled = true;
                BuscarPlatos();
            }
        }

        private void LblNombre_Click(object sender, EventArgs e)
        {
            ChkNombre.Checked = !ChkNombre.Checked;
            ChkNombre.Invalidate();
        }

        private void LblCategoria_Click(object sender, EventArgs e)
        {
            ChkCategoría.Checked = !ChkCategoría.Checked;
            ChkCategoría.Invalidate();
        }
        #endregion
        #endregion

        #region Apertura de detalles de un plato
        private void LstPlatos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string clavePrimaria = LstPlatos.SelectedItems[0].Tag.ToString();
            Form frmShadow = new Form();
            FrmPedidosPlatosConsultaDetalles frm = new FrmPedidosPlatosConsultaDetalles(ConexionBD, clavePrimaria, ref frmShadow);

            frm.ShowDialog();
            frmShadow.Close();
        }
        #endregion

        #region Cierre del formulario
        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
