using MaterialSkin.Controls;
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
    public partial class FrmHistorialPedidosDetalles : Form
    {
        MySqlConnection ConexionBD;
        private FrmMain Instance;
        private string ClavePrimaria;

        public FrmHistorialPedidosDetalles(MySqlConnection conexion, String clavePrimaria, FrmMain instance)
        {
            InitializeComponent();
            ConexionBD = conexion;
            ClavePrimaria = clavePrimaria;
            Instance = instance;
            CargarDatosPedido();
        }

        #region Apertura del formulario
        public void CargarDatosPedido()
        {
            string sql = "SELECT * FROM HistorialPedidos WHERE IdPedido = " + ClavePrimaria;
            MySqlCommand comando = new MySqlCommand(sql, ConexionBD);

            MySqlDataReader lector = comando.ExecuteReader();
            if (lector.Read())
            {
                LblID.Text = ClavePrimaria;
                LblFecha.Text = DateTime.Parse(lector["Fecha"].ToString()).ToString("dd/MM/yyyy");
                LblHora.Text = lector["Hora"].ToString();
                LblTipo.Text = lector["Tipo"].ToString();
                LblTlf.Text = lector["TelefonoCliente"].ToString();
                LblPrecioConIVA.Text = lector["PrecioConIva"].ToString();
                LblPrecioSinIVA.Text = lector["PrecioSinIva"].ToString();
            }
            lector.Close();

            CargarPlatosPedido();
        }

        public void CargarPlatosPedido()
        {
            string sql = "SELECT * FROM HistorialPedidosPlatos WHERE IdPedido = " + ClavePrimaria;
            MySqlCommand cmd = new MySqlCommand(sql, ConexionBD);

            MySqlDataReader lector = cmd.ExecuteReader();
            for (int i = 0; lector.Read(); i++)
            {
                DtgPlatosPedidos.Rows.Add();
                DtgPlatosPedidos.Rows[i].Cells[0].Value = lector[1];
                DtgPlatosPedidos.Rows[i].Cells[1].Value = lector[2];
                DtgPlatosPedidos.Rows[i].Cells[2].Value = lector[4];
                DtgPlatosPedidos.Rows[i].Cells[3].Value = lector[3];
                DtgPlatosPedidos.Rows[i].Cells[4].Value = lector[5];

                decimal cantidad = decimal.Parse(DtgPlatosPedidos.Rows[i].Cells[4].Value.ToString());
                string v = DtgPlatosPedidos.Rows[i].Cells[2].Value.ToString();
                decimal unitarioSinIVA = decimal.Parse(DtgPlatosPedidos.Rows[i].Cells[2].Value.ToString());
                decimal unitarioConIVA = decimal.Parse(DtgPlatosPedidos.Rows[i].Cells[3].Value.ToString());

                DtgPlatosPedidos.Rows[i].Cells[5].Value = unitarioSinIVA * cantidad;
                DtgPlatosPedidos.Rows[i].Cells[6].Value = unitarioConIVA * cantidad;

            }
            lector.Close();

            //MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            //DataSet ds = new DataSet();
            //adapter.Fill(ds, "HistorialPedidosPlatos");

            //DtgPlatosPedidos.DataSource = ds.Tables["HistorialPedidosPlatos"];
            //DtgPlatosPedidos.Columns.Add("PrecioFinalConIVA", "Precio final con IVA");
            //DtgPlatosPedidos.Columns.Add("PrecioFinalSinIVA", "Precio final sin IVA");

            //DtgPlatosPedidos.Columns[1].HeaderText = "Código";
            //DtgPlatosPedidos.Columns[2].HeaderText = "Nombre";
            //DtgPlatosPedidos.Columns[3].HeaderText = "Precio unitario con IVA";
            //DtgPlatosPedidos.Columns[4].HeaderText = "Precio unitario sin IVA";
            //DtgPlatosPedidos.Columns[5].HeaderText = "Cantidad";
            //DtgPlatosPedidos.Columns[6].HeaderText = "Precio final sin IVA";
            //DtgPlatosPedidos.Columns[7].HeaderText = "Precio final con IVA";

            //foreach (DataGridViewRow row in DtgPlatosPedidos.Rows)
            //{
            //    decimal finalConIVA = decimal.Parse(row.Cells[3].Value.ToString()) * decimal.Parse(row.Cells[5].Value.ToString());
            //    decimal finalSinIVA = decimal.Parse(row.Cells[4].Value.ToString()) * decimal.Parse(row.Cells[5].Value.ToString());

            //    row.Cells[6].Value = finalConIVA;
            //    row.Cells[7].Value = finalSinIVA;
            //}
        }
        #endregion

        #region Borrar pedido en historial
        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ConfirmarAccion("eliminar permanentemente"))
                {
                    string sql = "DELETE FROM HistorialPedidos WHERE IdPedido = " + ClavePrimaria;
                    MySqlCommand comando = new MySqlCommand(sql, ConexionBD);
                    comando.ExecuteNonQuery();

                    InformarAccionConExito();
                    this.Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("No se ha podido completar la eliminación debido al siguiente error: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Mensajes
        // Muestra un mensaje de confirmación
        private bool ConfirmarAccion(string accion)
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
        private void FrmHistorialPedidosDetalles_FormClosing(object sender, FormClosingEventArgs e)
        {
            Instance.Enabled = true;
        }
        #endregion
    }
}
