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

namespace Garmoxu_Project
{
    public partial class FrmCategorias : Form
    {
        private MySqlConnection ConexionBD;
        private FrmMain Instance;

        public FrmCategorias(MySqlConnection conexionBD, FrmMain instance)
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            ConexionBD = conexionBD;
            Instance = instance;
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
                return Properties.Resources.noImage;
        }
        #endregion
        #endregion

        #region Búsqueda de categorias
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtNombre.Texts.Trim()))
            {
                string sql = "SELECT IdCategoria, Nombre, ImagenCategoria FROM Categorias " +
                    "WHERE Nombre LIKE '%" + TxtNombre.Texts.Trim() + "%' ORDER BY Nombre DESC";
                RellenarListView(sql);
            }
            else
                CargarCategorias(); // Carga sin filtro
        }

        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals((char)Keys.Enter)) BtnBuscar_Click(null, null);
        }
        #endregion

        #region Alta de categoría
        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            FrmCategoriasDetalles frm = new FrmCategoriasDetalles(ConexionBD, string.Empty, Instance);
            frm.Width = 316;
            frm.Height = 434;
            BtnEliminar.Enabled = false;
            Instance.Enabled = false;

            frm.Show();
        }
        #endregion

        #region Modificación de categorias
        private void LstCategorias_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string clavePrimaria = LstCategorias.SelectedItems[0].Tag.ToString();

            FrmCategoriasDetalles frm = new FrmCategoriasDetalles(ConexionBD, clavePrimaria, Instance);
            frm.Width = 316;
            frm.Height = 434;
            BtnEliminar.Enabled = false;
            Instance.Enabled = false;

            frm.Show();
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

            if (cmd.ExecuteScalar() == null)
                return true;

            string mensaje = "¡No se ha podido eliminar la categoría ya que tiene platos asociados! " +
                "Elimínalos o cámbialos de categoría para poder continuar";
            MostrarMensaje(mensaje, MessageBoxIcon.Warning);
            return false;
        }

        private void LstCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LstCategorias.SelectedItems.Count > 0)
                BtnEliminar.Enabled = true;
            else
                BtnEliminar.Enabled = false;
        }
        #endregion

        #region Actualización automática de la list view
        private void FrmCategoria_EnabledChanged(object sender, EventArgs e)
        {
            if (this.Enabled)
                CargarCategorias();
        }
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
        #region Boton de cerrar
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
        #endregion
    }
}
