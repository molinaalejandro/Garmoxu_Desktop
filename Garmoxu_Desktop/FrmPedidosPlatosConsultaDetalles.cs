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

namespace Garmoxu_Project
{
    public partial class FrmPedidosPlatosConsultaDetalles : Form
    {
        private MySqlConnection ConexionBD;
        private string ClavePrimaria;

        public FrmPedidosPlatosConsultaDetalles(MySqlConnection conexionBD, string clavePrimaria)
        {
            InitializeComponent();
            ConexionBD = conexionBD;
            ClavePrimaria = clavePrimaria;
            CargarDatos();
        }

        #region Apertura del formulario
        #region Cargar datos
        private void CargarDatos()
        {
            string sql = "SELECT * FROM PlatosComida WHERE IdPlatoComida = '" + ClavePrimaria + "'";
            MySqlCommand cmd = new MySqlCommand(sql, ConexionBD);

            string idCategoria = string.Empty;

            MySqlDataReader lector = cmd.ExecuteReader();
            if (lector.Read())
            {
                TxtIdPlato.Texts = lector["IdPlatoComida"].ToString();
                TxtNombre.Texts = lector["Nombre"].ToString();
                TxtPrecioConIva.Text = lector["PrecioConIVA"].ToString();
                TxtPrecioSinIva.Text = lector["PrecioSinIVA"].ToString();
                TxtDescripcion.Texts = lector["Descripcion"].ToString();
                TxtListaAlergenos.Texts = lector["Alergenos"].ToString();

                if (lector["Disponibilidad"].ToString().Equals("True"))
                    ChkDisponibilidad.Checked = true;

                CargarImagen(lector);

                idCategoria = lector["IdCategoria"].ToString();
            }
            lector.Close();

            sql = "SELECT Nombre FROM Categorias WHERE IdCategoria = '" + idCategoria + "'";
            cmd.CommandText = sql;
            string categoria = cmd.ExecuteScalar().ToString();

            CboCategorias.Items.Add(categoria);
            CboCategorias.SelectedIndex = 0;
        }

        private void CargarImagen(MySqlDataReader lector)
        {
            Image imagen;
            if (!string.IsNullOrEmpty(lector[5].ToString()))
            {
                int tamañoMaximoArchivo = 16000000;
                byte[] imagenBytes = new byte[tamañoMaximoArchivo];

                lector.GetBytes(5, 0, imagenBytes, 0, tamañoMaximoArchivo);
                imagen = (Bitmap)((new ImageConverter()).ConvertFrom(imagenBytes));
            }
            else
                imagen = Properties.Resources.noImage;

            PicFotoPlato.Image = imagen;
            PicFotoPlato.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        #endregion
        #endregion

        #region Cierre del formulario
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion Cierre del formulario
    }
}
