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
using static Garmoxu_Desktop.ConexionMySql;

namespace Garmoxu_Desktop
{
    public partial class FrmHistorialPedidos : Form
    {
        private DataSet Ds;
        private int NivelPermisos;
        private int IVA;

        public FrmHistorialPedidos(int nivelPermisos, int iva)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            NivelPermisos = nivelPermisos;
            IVA = iva;
            CboTipos.SelectedIndex = 0;
            ChkTipo.Checked = false;
            ChkTipo.Invalidate();
            DtpFechaPedido.Value = DateTime.Now;

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
            DtgHistorial.Columns[6].HeaderText = "Método de pago";
            DtgHistorial.Columns[7].HeaderText = "Teléfono del cliente";
        }

        private void FrmHistorialPedidos_Shown(object sender, EventArgs e)
        {
            DtgHistorial.Columns[1].Width = 170;
            DtgHistorial.Columns[2].Width = 150;
            DtgHistorial.Columns[5].Width = 220;
            DtgHistorial.Columns[6].Width = 220;
            DtgHistorial.ClearSelection();
        }
        #endregion

        #region Funciones y diseño del formulario
        private void FrmHistorialPedidos_EnabledChanged(object sender, EventArgs e)
        {
            if (this.Enabled) BtnBuscar_Click(null, null);
        }
        #endregion

        #region Funciones y diseños de controles
        #region Text box teléfono
        private void TxtTelefono_Enter(object sender, EventArgs e)
        {
            if (TxtTelefono.Texts.Trim().Equals("Buscar por teléfono de cliente"))
            {
                TxtTelefono.Texts = string.Empty;
                TxtTelefono.ForeColor = Color.White;
            }
        }

        private void TxtTelefono_Leave(object sender, EventArgs e)
        {
            if (TxtTelefono.Texts.Trim().Equals(string.Empty))
            {
                TxtTelefono.Texts = "Buscar por teléfono de cliente";
                TxtTelefono.ForeColor = Color.Gray;
            }
        }
        #endregion

        #region Botón de buscar
        private void BtnBuscar_MouseEnter(object sender, EventArgs e)
        {
            BtnBuscar.IconColor = Color.DeepSkyBlue;
        }

        private void BtnBuscar_MouseLeave(object sender, EventArgs e)
        {
            BtnBuscar.IconColor = Color.MediumSlateBlue;
        }
        #endregion

        #region Check box y label de teléfono
        private void ChkTelefono_MouseEnter(object sender, EventArgs e)
        {
            ChkTelefono.BorderColor = ChkTelefono.EnterColor;
            ChkTelefono.ForeColor = ChkTelefono.EnterColor;
            LblTelefono.ForeColor = ChkTelefono.EnterColor;
            ChkTelefono.Invalidate();
        }

        private void ChkTelefono_MouseLeave(object sender, EventArgs e)
        {
            ChkTelefono.BorderColor = ChkTelefono.LeaveColor;
            ChkTelefono.ForeColor = ChkTelefono.LeaveColor;
            LblTelefono.ForeColor = ChkTelefono.LeaveColor;
            ChkTelefono.Invalidate();
        }
        #endregion

        #region Check box y label de tipo
        private void ChkTipo_MouseEnter(object sender, EventArgs e)
        {
            ChkTipo.BorderColor = ChkTipo.EnterColor;
            ChkTipo.ForeColor = ChkTipo.EnterColor;
            LblTipo.ForeColor = ChkTipo.EnterColor;
            ChkTipo.Invalidate();
        }

        private void ChkTipo_MouseLeave(object sender, EventArgs e)
        {
            ChkTipo.BorderColor = ChkTipo.LeaveColor;
            ChkTipo.ForeColor = ChkTipo.LeaveColor;
            LblTipo.ForeColor = ChkTipo.LeaveColor;
            ChkTipo.Invalidate();
        }
        #endregion
        #endregion

        #region Boton de buscar 
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            string filtro = "Fecha = '" + DtpFechaPedido.Value.ToString("yyyy/MM/dd") + "'";

            if (ChkTipo.Checked)
                filtro += " AND Tipo = '" + CboTipos.SelectedItem.ToString() + "'";

            if (ChkTelefono.Checked && !TxtTelefono.Texts.Equals("Buscar por teléfono de cliente"))
                filtro += " AND TelefonoCliente = '" + TxtTelefono.Texts.Replace(" ", "") + "'";

            CargarDatosPedidos(filtro);
            DtgHistorial.ClearSelection();
        }

        private void CargarDatosPedidos(string filtro)
        {
            string sql = "SELECT * FROM HistorialPedidos WHERE " + filtro;
            Ds = new DataSet();
            Ds = RecogerTabla(sql, "HistorialPedidos");
            Ds.Tables["HistorialPedidos"].DefaultView.Sort = "Fecha ASC";
            DtgHistorial.DataSource = Ds.Tables["HistorialPedidos"];
        }

        private void TxtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals((char)Keys.Enter))
            {
                e.Handled = true;
                BtnBuscar_Click(null, null);
            }
        }

        #region Actualizacion automatica de los check boxs
        private void DtpBuscar_ValueChanged(object sender, EventArgs e)
        {
            BtnBuscar_Click(null, null);
        }

        private void CboTipo_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            ChkTipo.Checked = true;
            ChkTipo.Invalidate();
            BtnBuscar_Click(null, null);
        }

        private void TxtTelefono__TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtTelefono.Texts.Trim()) && !TxtTelefono.Texts.Equals("Buscar por teléfono de cliente"))
                ChkTelefono.Checked = true;
            else
                ChkTelefono.Checked = false;
            ChkTelefono.Invalidate();
        }

        private void LblTipo_Click(object sender, EventArgs e)
        {
            ChkTipo.Checked = !ChkTipo.Checked;
            ChkTipo.Invalidate();
        }

        private void LblTelefono_Click(object sender, EventArgs e)
        {
            ChkTelefono.Checked = !ChkTelefono.Checked;
            ChkTelefono.Invalidate();
        }
        #endregion
        #endregion

        #region Apertura de detalles
        private void DtgHistorial_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DtgHistorial.SelectedRows.Count > 0)
            {
                string clavePrimaria = DtgHistorial.CurrentRow.Cells[0].Value.ToString();
                Form frmShadow = new Form();
                FrmHistorialPedidosDetalles frm = new FrmHistorialPedidosDetalles(clavePrimaria, ref frmShadow, NivelPermisos, IVA);
                frm.ShowDialog();
                frmShadow.Close();
                BtnBuscar_Click(null, null);
            }
        }
        #endregion
    }
}
