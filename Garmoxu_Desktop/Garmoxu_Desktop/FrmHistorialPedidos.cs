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

namespace Garmoxu_Desktop
{
    public partial class FrmHistorialPedidos : Form
    {
        private MySqlConnection ConexionBD;
        private DataSet Ds;
        private FrmMain Instance;

        public FrmHistorialPedidos(MySqlConnection conexionBD, FrmMain instance)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Instance = instance;
            ConexionBD = conexionBD;
            CboTipo.SelectedIndex = 0;
            ChkTipo.Checked = false;
            BtnBuscar_Click(null, null);
            FormatearDataGridView();
        }

        #region Apertura del formulario
        private void FormatearDataGridView()
        {
            DtgHistorial.Columns[0].Visible = false;
            DtgHistorial.Columns[3].HeaderText = "Precio con IVA";
            DtgHistorial.Columns[4].HeaderText = "Precio sin IVA";
            DtgHistorial.Columns[5].HeaderText = "Tipo de pedido";
            DtgHistorial.Columns[6].HeaderText = "Tipo de pago";
            DtgHistorial.Columns[7].HeaderText = "Teléfono del cliente";
        }
        #endregion

        #region Funciones y diseño del formulario
        private void FrmHistorialPedidos_EnabledChanged(object sender, EventArgs e)
        {
            if (this.Enabled)
                BtnBuscar_Click(null, null);
        }
        #endregion

        #region Boton de buscar 
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            string filtro = "Fecha = '" + DtpBuscar.Value.ToString("yyyy/MM/dd") + "'";

            if (ChkTipo.Checked)
                filtro += " AND Tipo = '" + CboTipo.SelectedItem.ToString() + "'";

            if (ChkTelefono.Checked)
                filtro += " AND TelefonoCliente = '" + TxtTelefono.Texts.Replace(" ", "") + "'";

            CargarDatosPedidos(filtro);
        }

        private void CargarDatosPedidos(string filtro)
        {
            string sql = "SELECT * FROM HistorialPedidos WHERE " + filtro;
            MySqlCommand cmd = new MySqlCommand(sql, ConexionBD);

            Ds = new DataSet();
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(Ds, "HistorialPedidos");
            Ds.Tables["HistorialPedidos"].DefaultView.Sort = "Fecha ASC";

            DtgHistorial.DataSource = Ds.Tables["HistorialPedidos"];
        }

        private void TxtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals((char)Keys.Enter))
                BtnBuscar_Click(null, null);
        }

        #region Actualizacion automatica de los check boxs
        private void DtpBuscar_ValueChanged(object sender, EventArgs e)
        {
            BtnBuscar_Click(null, null);
        }

        private void CboTipo_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            ChkTipo.Checked = true;
            BtnBuscar_Click(null, null);
        }

        private void TxtTelefono__TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtTelefono.Texts.Replace(" ", "")))
                ChkTelefono.Checked = true;
            else
                ChkTelefono.Checked = false;
        }
        #endregion
        #endregion

        #region Apertura de detalles
        private void DtgHistorial_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string clavePrimaria = DtgHistorial.CurrentRow.Cells[0].Value.ToString();
            FrmHistorialPedidosDetalles frm = new FrmHistorialPedidosDetalles(ConexionBD, clavePrimaria, Instance);
            Instance.Enabled = false;
            frm.Show();
        }
        #endregion

        #region Boton de cerrar 
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
