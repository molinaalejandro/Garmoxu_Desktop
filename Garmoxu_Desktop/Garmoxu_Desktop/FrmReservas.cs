using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Garmoxu_Desktop
{
    public partial class FrmReservas : Form
    {
        private MySqlConnection ConexionBD;
        private DataSet Ds;
        private FrmMain Instance;
        private bool BtnClienteActivado;

        public FrmReservas(MySqlConnection conexionBD, FrmMain instance)
        {
            InitializeComponent();
            BtnClienteActivado = true;
            Instance = instance;
            FormBorderStyle = FormBorderStyle.None;
            ConexionBD = conexionBD;
            CargarReservasGridView();
        }

        #region Apertura del formulario
        private void FrmReservas_Shown(object sender, EventArgs e)
        {
            DtgReservas.ClearSelection();
        }

        #region Cargar tabla reservas
        private void CargarReservasGridView()
        {
            string sql = string.Format(
                "SELECT * FROM Reservas WHERE Fecha BETWEEN '{0}' AND '{1}' ",
                DateTime.Now.ToString("yyyy/MM/dd"),
                DateTime.Now.AddDays(7).ToString("yyyy/MM/dd"));

            MySqlCommand cmd = new MySqlCommand(sql, ConexionBD);
            MySqlDataAdapter adapterReservas = new MySqlDataAdapter(cmd);

            Ds = new DataSet();
            adapterReservas.Fill(Ds, "Reservas");
            Ds.Tables["Reservas"].DefaultView.Sort = "Fecha, Hora ASC";

            DtgReservas.DataSource = Ds.Tables["Reservas"];
            DtgReservas.Columns[0].Visible = false;

            DtgReservas.Columns[3].HeaderText = "Teléfono cliente";
            DtgReservas.Columns[4].HeaderText = "Mesa";
        }
        #endregion
        #endregion

        #region Funciones y diseños de controles
        #region Text box cliente y mesa
        private void TxtBuscar_Enter(object sender, EventArgs e)
        {
            if (TxtBuscar.Texts.Trim().Equals(BtnClienteActivado ? "Buscar por teléfono de cliente" : "Buscar por número de mesa"))
            {
                TxtBuscar.Texts = string.Empty;
                TxtBuscar.ForeColor = Color.Gainsboro;
            }
        }

        private void TxtBuscar_Leave(object sender, EventArgs e)
        {
            if (TxtBuscar.Texts.Trim().Equals(string.Empty))
            {
                TxtBuscar.Texts = BtnClienteActivado ? "Buscar por teléfono de cliente" : "Buscar por número de mesa";
                TxtBuscar.ForeColor = Color.Gray;
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

        #region Check box y label de calendar
        private void ChkCalendar_MouseEnter(object sender, EventArgs e)
        {
            ChkCalendar.BorderColor = ChkCalendar.EnterColor;
            ChkCalendar.ForeColor = ChkCalendar.EnterColor;
            LblFecha.ForeColor = ChkCalendar.EnterColor;
            ChkCalendar.Invalidate();
        }

        private void ChkCalendar_MouseLeave(object sender, EventArgs e)
        {
            ChkCalendar.BorderColor = ChkCalendar.LeaveColor;
            ChkCalendar.ForeColor = ChkCalendar.LeaveColor;
            LblFecha.ForeColor = ChkCalendar.LeaveColor;
            ChkCalendar.Invalidate();
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

        #region Búsqueda de reservas
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            BuscarReserva();
        }

        private void TxtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals((char)Keys.Enter))
                BuscarReserva();
        }

        private void BuscarReserva()
        {
            try
            {
                string filtroSemana = string.Format(
                        "Fecha BETWEEN '{0}' AND '{1}' ",
                        DateTime.Now.ToString("yyyy/MM/dd"),
                        DateTime.Now.AddDays(7).ToString("yyyy/MM/dd"));

                string filtro = "";

                if (ChkCalendar.Checked)
                    filtro += "Fecha = '" + DtpBuscar.Value.ToString("yyyy/MM/dd") + "'";

                bool textBoxConHint = TxtBuscar.Texts.Trim().Equals(BtnClienteActivado ? "Buscar por teléfono de cliente" : "Buscar por número de mesa");
                if (!string.IsNullOrEmpty(TxtBuscar.Texts.Replace(" ", "")) && !textBoxConHint)
                {
                    if (ChkCalendar.Checked) filtro += " AND ";

                    if (BtnClienteActivado)
                    {
                        filtro += "TelefonoCliente = '" + TxtBuscar.Texts.Replace(" ", "") + "'";
                        if (!ChkCalendar.Checked)
                            filtro += " AND Fecha >= '" + DateTime.Now.ToString("yyyy/MM/dd") + "'";
                    }
                    else
                    {
                        filtro += "IdMesa = " + TxtBuscar.Texts.Replace(" ", "");
                        if (!ChkCalendar.Checked)
                            filtro += " AND " + filtroSemana;
                    }
                }

                if (string.IsNullOrEmpty(filtro)) filtro = filtroSemana;

                string sql = "SELECT * FROM Reservas WHERE " + filtro;
                MySqlCommand cmd = new MySqlCommand(sql, ConexionBD);

                Ds = new DataSet();
                MySqlDataAdapter adapterReservas = new MySqlDataAdapter(cmd);
                adapterReservas.Fill(Ds, "Reservas");
                Ds.Tables["Reservas"].DefaultView.Sort = "Fecha, Hora ASC";

                DtgReservas.DataSource = Ds.Tables["Reservas"];
                DtgReservas.ClearSelection();
            }
            catch (EvaluateException ex) { MessageBox.Show(ex.Message); }
        }

        private void DtpBuscar_ValueChanged(object sender, EventArgs e)
        {
            ChkCalendar.Checked = true;
            ChkCalendar.Invalidate();
            BtnBuscar_Click(null, null);
        }

        private void LblFecha_Click(object sender, EventArgs e)
        {
            ChkCalendar.Checked = !ChkCalendar.Checked;
            ChkCalendar.Invalidate();
        }

        private void TxtBuscar__TextChanged(object sender, EventArgs e)
        {
            //bool textBoxConHint = TxtBuscar.Texts.Trim().Equals(BtnClienteActivado ? "Buscar por teléfono de cliente" : "Buscar por número de mesa");
            //bool textBoxVacia = string.IsNullOrEmpty(TxtBuscar.Texts.Trim());

            //ChkCalendar.Checked = !textBoxVacia && !textBoxConHint;
            //ChkCalendar.Invalidate();
        }

        private void BtnCliente_Click(object sender, EventArgs e)
        {
            BtnCliente.BackColor = Color.MediumSlateBlue;
            BtnMesa.BackColor = Color.Gray;
            BtnClienteActivado = true;

            if (TxtBuscar.Texts.Trim().Equals("Buscar por número de mesa"))
            {
                TxtBuscar.Texts = "Buscar por teléfono de cliente";
                TxtBuscar.ForeColor = Color.Gray;
            }
        }

        private void BtnMesa_Click(object sender, EventArgs e)
        {
            BtnMesa.BackColor = Color.MediumSlateBlue;
            BtnCliente.BackColor = Color.Gray;
            BtnClienteActivado = false;

            if (TxtBuscar.Texts.Trim().Equals("Buscar por teléfono de cliente"))
            {
                TxtBuscar.Texts = "Buscar por número de mesa";
                TxtBuscar.ForeColor = Color.Gray;
            }
        }
        #endregion

        #region Eliminación de reservas
        private void DtgReservas_SelectionChanged(object sender, EventArgs e)
        {
            BtnEliminar.Enabled = DtgReservas.SelectedRows.Count < 1 ? false : true;
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                bool registroSeleccionado = DtgReservas.SelectedRows.Count > 0;
                if (registroSeleccionado)
                {
                    if (ValidarReservaDisponible())
                    {
                        bool confirmarBorrado = MessageBox.Show("¿Deseas eliminar permanentemente la reserva seleccionada?", "",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Warning).Equals(DialogResult.Yes);
                        if (confirmarBorrado)
                        {
                            // Porque por defecto selecciona 1 que es la seleccionada en el DGV
                            string sql = "DELETE FROM Reservas WHERE IdReserva = " + DtgReservas.SelectedRows[0].Cells[0].Value;
                            MySqlCommand cmd = new MySqlCommand(sql, ConexionBD);
                            cmd.ExecuteNonQuery();
                            DtgReservas.Rows.RemoveAt(DtgReservas.SelectedRows[0].Index);
                            MessageBox.Show("¡Operación completada con éxito!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                    MessageBox.Show("¡Debe seleccionar alguna fila!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("¡No se ha podido completar la eliminación!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarReservaDisponible()
        {
            if (!string.IsNullOrEmpty(DtgReservas.SelectedRows[0].Cells[0].Value.ToString()))
            {
                string sql = "SELECT * FROM Reservas WHERE IdReserva = " + DtgReservas.SelectedRows[0].Cells[0].Value.ToString();
                MySqlCommand cmd = new MySqlCommand(sql, ConexionBD);

                if (cmd.ExecuteScalar() == null)
                {
                    string mensaje = "¡La reserva ya no está disponible, alguien debe haberla eliminado mientras la consultabas!";
                    MessageBox.Show(mensaje, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    BtnBuscar_Click(null, null);
                    return false;
                }
            }
            return true;
        }
        #endregion

        #region Alta de reservas
        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            Form frmShadow = new Form();
            FrmReservasDetalles f = new FrmReservasDetalles(ConexionBD, string.Empty, ref frmShadow);

            f.ShowDialog();
            frmShadow.Close();

            BuscarReserva();
        }
        #endregion

        #region Modificación de reservas
        private void DtgReservas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ValidarReservaDisponible())
            {
                Form frmShadow = new Form();
                string clavePrimaria = DtgReservas.CurrentRow.Cells[0].Value.ToString();
                FrmReservasDetalles f = new FrmReservasDetalles(ConexionBD, clavePrimaria, ref frmShadow);

                f.ShowDialog();
                frmShadow.Close();

                BuscarReserva();
            }
        }
        #endregion
    }
}