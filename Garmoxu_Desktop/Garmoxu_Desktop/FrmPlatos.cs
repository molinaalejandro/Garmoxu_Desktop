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
using static Garmoxu_Desktop.MessageBoxPersonalizado;
using static Garmoxu_Desktop.ConexionMySql;

namespace Garmoxu_Desktop
{
    public partial class FrmPlatos : Form
    {
        private int IVA;

        public FrmPlatos(int iva)
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            IVA = iva;
            BuscarPlatos();
            CargarComboBoxCategorias();
        }

        #region Apertura del formulario
        private void RellenarListView(string sql)
        {
            try
            {
                bool continuar = ValidarCategoriaExistente();

                if (continuar)
                {
                    MySqlDataReader lector = EjecutarConsulta(sql);

                    LstPlatos.BeginUpdate();
                    LstPlatos.Items.Clear();
                    ImgImagenesPlatos.Images.Clear();
                    while (lector.Read())
                    {
                        try
                        {
                            if (!string.IsNullOrEmpty(lector[2].ToString()))
                                ImgImagenesPlatos.Images.Add(Image.FromStream(lector.GetStream(2)));
                            else
                                ImgImagenesPlatos.Images.Add(Properties.Resources.No_Image_Found);
                        }
                        catch (Exception ex)
                        {
                            string message = "¡No se ha podido cargar la imagen del plato '" + lector[1].ToString() + "' debido a que el formato de la imagen no es compatible! Pruebe a cambiar la imagen.";
                            ShowErrorMessage(message, "");
                            ImgImagenesPlatos.Images.Add(Properties.Resources.No_Image_Found);
                        }

                        LstPlatos.Items.Add(lector[1].ToString(), ImgImagenesPlatos.Images.Count - 1); // Metemos nombre y fotos
                        LstPlatos.Items[LstPlatos.Items.Count - 1].Tag = lector[0].ToString(); // Guardamos el código de plato para organizar en detalles
                    }
                    CerrarConexion();
                    lector.Close();
                    LstPlatos.EndUpdate();
                }
            }
            catch (Exception ex)
            {
                string message = "¡No se han podido cargar todos los platos debido a que hay algunas imágenes incompatibles!";
                ShowErrorMessage(message, "");
            }
        }

        private bool ValidarCategoriaExistente()
        {
            if (CboCategoria.SelectedIndex != -1)
            {
                string sql = "SELECT * FROM Categorias WHERE Nombre = '" + CboCategoria.SelectedItem.ToString() + "'";
                if (string.IsNullOrEmpty(EjecutarScalar(sql)))
                {
                    string mensaje = "¡La categoría seleccionada ya no está disponible!";
                    ShowErrorMessage(mensaje, "");
                    CargarComboBoxCategorias();
                    return false;
                }
            }
            return true;
        }

        private void CargarComboBoxCategorias()
        {
            string sql = "SELECT DISTINCT Nombre FROM Categorias ORDER BY Nombre ASC";
            MySqlDataReader lector = EjecutarConsulta(sql);

            CboCategoria.Items.Clear();
            while (lector.Read())
                CboCategoria.Items.Add(lector[0].ToString());
            CerrarConexion();
            lector.Close();
        }
        #endregion

        #region Funciones y diseños de controles
        #region Text Box Nombre
        private void TxtNombre_Enter(object sender, EventArgs e)
        {
            if (TxtNombre.Texts.Trim().Equals("Buscar por nombre de plato"))
            {
                TxtNombre.Texts = string.Empty;
                TxtNombre.ForeColor = Color.White;
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

        #region Botón Eliminar
        private void BtnEliminar_MouseEnter(object sender, EventArgs e)
        {
            BtnEliminar.IconColor = Color.LightCoral;
        }

        private void BtnEliminar_MouseLeave(object sender, EventArgs e)
        {
            BtnEliminar.IconColor = Color.FromArgb(255, 70, 70);
        }
        #endregion

        #region Botón Nuevo
        private void BtnNuevo_MouseEnter(object sender, EventArgs e)
        {
            BtnNuevo.IconColor = Color.FromArgb(110, 255, 110);
        }

        private void BtnNuevo_MouseLeave(object sender, EventArgs e)
        {
            BtnNuevo.IconColor = Color.FromArgb(70, 225, 70);
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
                if (!string.IsNullOrEmpty(filtro.Trim())) filtro += " AND ";
                filtro += "c.Nombre = '" + CboCategoria.SelectedItem + "'";
            }

            if (TgbDisponibilidad.Checked)
            {
                if (!string.IsNullOrEmpty(filtro.Trim())) filtro += " AND ";
                filtro += "pc.Disponibilidad = 1";
            }
            else
            {
                if (!string.IsNullOrEmpty(filtro.Trim())) filtro += " AND ";
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
                if (!string.IsNullOrEmpty(TxtNombre.Texts.Trim())) e.Handled = true;
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
                    EjecutarSentencia(sql);

                    InformarAccionConExito();
                }
            }
            catch (MySqlException ex)
            {
                string mensaje = "¡No se ha podido eliminar el plato!";
                ShowErrorMessage(mensaje, "");
            }
        }

        private bool ComprobarPedidoPlatoAsociado(string codigoPlatoCogido)
        {
            string sql = "SELECT * FROM PedidosEnCursoPlatos WHERE IdPlatoComida = '" + codigoPlatoCogido + "'";

            if (string.IsNullOrEmpty(EjecutarScalar(sql))) return false;
            else
            {
                string mensaje = "¡No se ha podido eliminar debido a que existe un pedido en curso que contiene este plato! " +
                    "Finaliza o cancela todos los pedidos asociados antes de eliminarlo.";
                ShowWarningMessage(mensaje, "");
                return true;
            }
        }

        private void LstPlatos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LstPlatos.SelectedItems.Count > 0) BtnEliminar.Enabled = true;
            else BtnEliminar.Enabled = false;
        }
        #endregion

        #region Alta de platos
        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            Form frmShadow = new Form();
            FrmPlatosDetalles frm = new FrmPlatosDetalles(string.Empty, IVA, ref frmShadow);

            frm.ShowDialog();
            frmShadow.Close();
            BuscarPlatos();
        }
        #endregion

        #region Apertura de detalles de un plato
        private void LstPlatos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string clavePrimaria = LstPlatos.SelectedItems[0].Tag.ToString();
            Form frmShadow = new Form();
            FrmPlatosDetalles frm = new FrmPlatosDetalles(clavePrimaria, IVA, ref frmShadow);

            frm.ShowDialog();
            frmShadow.Close();
            BuscarPlatos();
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
    }
}
