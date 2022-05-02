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

        #region Funciones y diseño del formulario
        #region Actualizacion automática de las reservas
        private void FrmReservas_EnabledChanged(object sender, EventArgs e)
        {
            // Si esta activado es que el form detalles se ha cerrado, actualiza
            if (this.Enabled)
                BtnBuscar_Click(null, null);
        }
        #endregion

        #region Control filtro
        private void BtnCliente_Click(object sender, EventArgs e)
        {
            PnlSubFiltro.BackColor = BtnCliente.BackColor;
            BtnClienteActivado = true;
        }

        #region Boton cliente
        private void BtnCliente_MouseEnter(object sender, EventArgs e)
        {
            if (PnlSubFiltro.BackColor == BtnCliente.BackColor)
            {
                BtnCliente.FlatAppearance.MouseOverBackColor = BtnCliente.BackColor;
                BtnCliente.FlatAppearance.MouseDownBackColor = BtnCliente.BackColor;
            }
            else
            {
                BtnCliente.FlatAppearance.MouseOverBackColor = Color.Empty;
                BtnCliente.FlatAppearance.MouseDownBackColor = Color.Empty;
            }
        }
        #endregion

        #region Boton mesa
        private void BtnMesa_Click(object sender, EventArgs e)
        {
            PnlSubFiltro.BackColor = BtnMesa.BackColor;
            BtnClienteActivado = false;
        }

        private void BtnMesa_MouseEnter(object sender, EventArgs e)
        {
            if (PnlSubFiltro.BackColor == BtnMesa.BackColor)
            {
                BtnMesa.FlatAppearance.MouseOverBackColor = BtnMesa.BackColor;
                BtnMesa.FlatAppearance.MouseDownBackColor = BtnMesa.BackColor;
            }
            else
            {
                BtnMesa.FlatAppearance.MouseOverBackColor = Color.Empty;
                BtnMesa.FlatAppearance.MouseDownBackColor = Color.Empty;
            }
        }
        #endregion
        #endregion
        #endregion

        #region Reservas
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

                if (!string.IsNullOrEmpty(TxtBuscar.Texts.Replace(" ", "")))
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
            }
            catch (EvaluateException ex) { MessageBox.Show(ex.Message); }
        }

        private void DtgReservas_SelectionChanged(object sender, EventArgs e)
        {
            if (DtgReservas.SelectedRows.Count < 1)
                BtnEliminar.Enabled = false;
            else
                BtnEliminar.Enabled = true;
        }

        private void DtpBuscar_ValueChanged(object sender, EventArgs e)
        {
            ChkCalendar.Checked = true;
            BtnBuscar_Click(null, null);
        }
        #endregion

        #region Eliminación de reservas
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
            // Como no ha sido llamado por doble click no es modificar si no nueva reserva
            FrmReservasDetalles f = new FrmReservasDetalles(ConexionBD, string.Empty, Instance);
            f.Width = (Instance.Width / 3);
            f.Height = (Instance.Height / 2) + (Instance.Height / 4);

            Instance.Enabled = false;
            f.Show();
        }
        #endregion

        #region Modificación de reservas
        private void DtgReservas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ValidarReservaDisponible())
            {
                string clavePrimaria = DtgReservas.CurrentRow.Cells[0].Value.ToString();
                FrmReservasDetalles f = new FrmReservasDetalles(ConexionBD, clavePrimaria, Instance);
                f.Width = (Instance.Width / 3);
                f.Height = (Instance.Height / 2) + (Instance.Height / 4);

                Instance.Enabled = false;
                f.Show();
            }
        }
        #endregion
        #endregion

        #region Cierre del formulario
        #region Boton cerrar 
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #endregion
    }
}