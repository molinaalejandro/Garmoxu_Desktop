using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Garmoxu_Desktop.FrmMessageBoxPersonalizado;

namespace Garmoxu_Desktop
{
    public partial class FrmCategorias : Form
    {
        private MySqlConnection ConexionBD;

        public FrmCategorias(MySqlConnection conexionBD)
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            ConexionBD = conexionBD;
            CargarCategorias();
        }

        #region Apertura del formulario
        #region Cargar datos
        private void CargarCategorias()
        {
            string sql = "SELECT IdCategoria, Nombre, ImagenCategoria FROM Categorias ORDER BY Nombre DESC";
            RellenarListView(sql);
        }

        private void RellenarListView(string sql)
        {
            LstCategorias.Items.Clear();
            ImgImagenesCateg.Images.Clear();

            MySqlCommand cmd = new MySqlCommand(sql, ConexionBD);
            MySqlDataReader lector = cmd.ExecuteReader();

            while (lector.Read())
            {
                ImgImagenesCateg.Images.Add(CargarImagen(lector));
                LstCategorias.Items.Add(lector[1].ToString(), ImgImagenesCateg.Images.Count - 1);
                LstCategorias.Items[LstCategorias.Items.Count - 1].Tag = lector[0].ToString(); // ClavePrimaria guardada en tag
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
        #endregion
        #endregion

        #region Funciones y diseños de controles
        #region Text Box Busqueda
        private void TxtBusqueda_Enter(object sender, EventArgs e)
        {
            if (TxtBusqueda.Texts.Trim().Equals("Buscar por nombre de categoría"))
            {
                TxtBusqueda.Texts = string.Empty;
                TxtBusqueda.ForeColor = Color.Gainsboro;
            }
        }

        private void TxtBusqueda_Leave(object sender, EventArgs e)
        {
            if (TxtBusqueda.Texts.Trim().Equals(string.Empty))
            {
                TxtBusqueda.Texts = "Buscar por nombre de categoría";
                TxtBusqueda.ForeColor = Color.Gray;
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
        #endregion

        #region Búsqueda de categorias
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            BtnEliminar.Enabled = false;
            if (!string.IsNullOrEmpty(TxtBusqueda.Texts.Trim()) && !TxtBusqueda.Texts.Equals("Buscar por nombre de categoría"))
            {
                string sql = "SELECT IdCategoria, Nombre, ImagenCategoria FROM Categorias " +
                    "WHERE Nombre LIKE '%" + TxtBusqueda.Texts.Trim() + "%' ORDER BY Nombre DESC";
                RellenarListView(sql);
            }
            else
                CargarCategorias(); // Carga sin filtro
        }

        private void TxtBusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals((char)Keys.Enter))
            {
                e.Handled = true;
                BtnBuscar_Click(null, null);
            }
        }
        #endregion

        #region Alta de categoría
        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            Form frmShadow = new Form();
            FrmCategoriasDetalles frm = new FrmCategoriasDetalles(ConexionBD, string.Empty, ref frmShadow);
            BtnEliminar.Enabled = false;

            frm.ShowDialog();
            frmShadow.Close();
            CargarCategorias();
        }
        #endregion

        #region Modificación de categorias
        private void LstCategorias_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string clavePrimaria = LstCategorias.SelectedItems[0].Tag.ToString();

            Form frmShadow = new Form();
            FrmCategoriasDetalles frm = new FrmCategoriasDetalles(ConexionBD, clavePrimaria, ref frmShadow);
            BtnEliminar.Enabled = false;

            frm.ShowDialog();
            frmShadow.Close();
            CargarCategorias();
        }
        #endregion

        #region Eliminación de categorias
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            string idCategoria = LstCategorias.SelectedItems[0].Tag.ToString();

            if (ConfirmarAccion("eliminar permanentemente") && ValidarCategoriaSinPlatosAsociados(idCategoria))
            {
                string sql = "DELETE FROM Categorias WHERE IdCategoria = '" + idCategoria + "'";
                MySqlCommand cmd = new MySqlCommand(sql, ConexionBD);
                cmd.ExecuteNonQuery();

                ImgImagenesCateg.Images.RemoveAt(LstCategorias.SelectedItems[0].ImageIndex);
                LstCategorias.Items.RemoveAt(LstCategorias.SelectedItems[0].Index);

                InformarAccionConExito();
            }
        }

        private bool ValidarCategoriaSinPlatosAsociados(string idCategoria)
        {
            string sql = "Select IdCategoria FROM PlatosComida WHERE IdCategoria = '" + idCategoria + "'";
            MySqlCommand cmd = new MySqlCommand(sql, ConexionBD);

            if (cmd.ExecuteScalar() == null) return true;

            string mensaje = "¡No se ha podido eliminar la categoría ya que tiene platos asociados! " +
                "Elimínalos o cámbialos de categoría para poder continuar.";
            ShowWarningMessage(mensaje, "");
            return false;
        }

        private void LstCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LstCategorias.SelectedItems.Count > 0) BtnEliminar.Enabled = true;
            else BtnEliminar.Enabled = false;
        }
        #endregion

        #region Actualización automática de la list view
        private void FrmCategoria_EnabledChanged(object sender, EventArgs e)
        {
            //if (this.Enabled)
            //    CargarCategorias();
        }
        #endregion

        #region Mensajes
        // Muestra un mensaje de confirmación
        private bool ConfirmarAccion(string accion)
        {
            string mensaje = "¿Desea " + accion + " la categoría actual?";
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
        #region Boton de cerrar
        //private void BtnCerrar_Click(object sender, EventArgs e)
        //{
        //    this.Close();
        //}
        #endregion

        #endregion
    }
}
