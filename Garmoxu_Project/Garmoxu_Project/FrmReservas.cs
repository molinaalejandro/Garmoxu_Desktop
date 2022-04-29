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

namespace Garmoxu_Project
{
    public partial class FrmReservas : Form
    {
        private MySqlConnection ConexionBD;
        MySqlCommand comando;
        MySqlCommand comando2;
        public static MySqlDataAdapter adapterReservas;
        public static DataSet dataSet = new DataSet();
        public static DataTable tablaReservas;

        Boolean BtnMesaActivado = false;
        Boolean BtnClienteActivado = true;

        String fechaCogida = "";

        public FrmReservas(MySqlConnection conexionBD)
        {
            InitializeComponent();
            ConexionBD = conexionBD;
            ConexionBBDD();
            TraerTablaReservas();
            CargarCbo_Guia();
            Cargar_DataGrid_Default(); // Ver si molina hizo lo del tema de comprobar que no se repita al abrir si no se abre mas de 1
        }

        #region Quitar la barra superior de la ventana con los botones(cerrar, reajustar y minimizar)(es normal que no tenga referencias) y poder reajustar manualmente la ventana
        protected override void WndProc(ref Message m)
        {
            const int WM_NCCALCSIZE = 0x0083;//Standar Title Bar - Snap Window
            //Remove border and keep snap window
            if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
            {
                return;
            }
            base.WndProc(ref m);
        }
        #endregion

        #region Botones del filtro para saber que hay pulsado si MESA o CLIENTE y BtnCliente
        private void BtnCliente_Click(object sender, EventArgs e)
        {
            PnlSubFiltro.BackColor = BtnCliente.BackColor;

            BtnMesaActivado = false;
            BtnClienteActivado = true;
        }

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

        #region BtnMesa
        private void BtnMesa_Click(object sender, EventArgs e)
        {
            PnlSubFiltro.BackColor = BtnMesa.BackColor;

            BtnMesaActivado = true;
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

        #region Abrir el form de nueva reserva pero solo 1 vez hasta que se cierre
        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            Boolean encontrado = false;

            foreach (Form form in Application.OpenForms)
            {
                Type tipo = form.GetType();

                if (tipo.Name.Equals("FrmDetallesReserva"))
                {
                    encontrado = true;
                    form.BringToFront();
                    form.Show();
                }
            }

            if (!(encontrado))
            {
                encontrado = true;
                NuevaReserva(new FrmDetallesReserva(ConexionBD));
            }
        }
        #endregion

        #region Mostrar Boton nueva reserva
        private void NuevaReserva(Form f)
        {
            f.Width = (FrmMain.instance.Height / 2);
            f.Height = (FrmMain.instance.Height / 2);
            f.TopMost = true;
            f.Show();
        }
        #endregion

        #region Boton para cerrar el formulario 
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Abrir conexión con base de datos MYSQL
        public void ConexionBBDD()
        {
            string servidor = "127.0.0.1";
            string puerto = "3306";
            string usuario = "root";
            string password = "root";

            string cadenaConexion = "server=" + servidor + "; port=" + puerto + "; user id = " + usuario + "; password=" + password + "; database=garmoxu";

            ConexionBD = new MySqlConnection(cadenaConexion);

            try
            {
                ConexionBD.Open();
            }
            catch (MySqlException e)
            {
                MessageBox.Show("La conexión ha fallado -> " + e.Message);
            }
        }
        #endregion

        #region Traemos la tabla Reservas a local para trabajar con ella 
        public void TraerTablaReservas()
        {
            // Nos traemos esta tabla a local
            adapterReservas = new MySqlDataAdapter();

            comando = new MySqlCommand();
            comando.Connection = ConexionBD;
            comando.CommandText = "SELECT * FROM Reservas";

            adapterReservas.SelectCommand = comando;
            adapterReservas.Fill(dataSet, "TABLA_RESERVAS");

            ConexionBD.Close();
        }
        #endregion

        #region Cargar el combo box que nos hará de guía para pillar el registro
        public void CargarCbo_Guia()
        {
            // Cargamos el data grid view de forma por defecto con todo lo que tiene sin filtro
            // Primero cargamos un combo box para que nos sirva de guía para el registro seleccionado

            tablaReservas = dataSet.Tables["TABLA_RESERVAS"];
            CboGuia.DataSource = tablaReservas;
            CboGuia.DisplayMember = "IdReserva";
        }
        #endregion

        #region Cargar Data Grid por defecto
        public void Cargar_DataGrid_Default()
        {
            // Como es el de defecto habría que coger todos los elementos
            DtgReservas.DataSource = dataSet.Tables["TABLA_RESERVAS"];
            DtgReservas.Columns.RemoveAt(0); // Para que no salga la primera columna
        }
        #endregion

        #region Activamos botón de Eliminar Reserva
        private void DtgReservas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BtnEliminar.Enabled = true;
        }
        #endregion

        #region Coger Fecha y aplicar filtro si está el CheckBox marcado
        private void ChkCalendar_CheckedChanged(object sender, EventArgs e)
        {
            // Si está activado, cogeme la fecha
            DataRowView registro = (DataRowView)CboGuia.SelectedItem;
            fechaCogida = DtpBuscar.Value.ToString("yyyy/MM/dd"); // Cogemos solo la fecha no la hora

            // El filtro se va a aplicar en el botón de buscar
            /*dataSet.Tables["TABLA_RESERVAS"].DefaultView.RowFilter = "Fecha='" + fechaCogida + "'";
            DtgReservas.DataSource = dataSet.Tables["TABLA_RESERVAS"];*/
        }
        #endregion

        #region Boton de buscar
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            try
            {

                if (BtnClienteActivado == true)
                {
                    if (ChkCalendar.Checked)
                    {
                        // Con filtro de fecha
                        dataSet.Tables["TABLA_RESERVAS"].DefaultView.RowFilter = "TelefonoCliente='" + TxtBuscar.Texts.ToString() + "'";
                        dataSet.Tables["TABLA_RESERVAS"].DefaultView.RowFilter = "Fecha='" + fechaCogida + "'";
                        DtgReservas.DataSource = dataSet.Tables["TABLA_RESERVAS"];

                        ChkCalendar.Checked = false;
                    }
                    else
                    {
                        // Sin filtro de fecha
                        // Ahora tenemos que hacer el filtrado por numero de telefono
                        dataSet.Tables["TABLA_RESERVAS"].DefaultView.RowFilter = "TelefonoCliente='" + TxtBuscar.Texts.ToString() + "'";
                        DtgReservas.DataSource = dataSet.Tables["TABLA_RESERVAS"];
                    }
                } // if
                else
                {
                    // Ahora tenemos que hacer el filtrado por NUMERO DE TELEFONO
                    if (ChkCalendar.Checked)
                    {
                        dataSet.Tables["TABLA_RESERVAS"].DefaultView.RowFilter = "IdMesa='" + TxtBuscar.Texts.ToString() + "'";
                        dataSet.Tables["TABLA_RESERVAS"].DefaultView.RowFilter = "Fecha='" + fechaCogida + "'";
                        DtgReservas.DataSource = dataSet.Tables["TABLA_RESERVAS"];

                        ChkCalendar.Checked = false;
                    }
                    else
                    {
                        dataSet.Tables["TABLA_RESERVAS"].DefaultView.RowFilter = "IdMesa='" + TxtBuscar.Texts.ToString() + "'";
                        DtgReservas.DataSource = dataSet.Tables["TABLA_RESERVAS"];
                    }
                } // else
            }// try
            catch (EvaluateException error)
            {
                MessageBox.Show("No podemos filtrar por el campo que has metido, comprueba que esté bien", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Evento Borrar fila
        public void borrar_fila()
        {
            int rowIndex = DtgReservas.CurrentCell.RowIndex;
            DtgReservas.Rows.RemoveAt(rowIndex);

            DataGridViewRow row = DtgReservas.CurrentRow;

            string celda1 = row.Cells[0].Value.ToString();
            string celda2 = row.Cells[1].Value.ToString();
            string celda3 = row.Cells[2].Value.ToString();
            string celda4 = row.Cells[3].Value.ToString();
            string celda5 = row.Cells[4].Value.ToString();
        }
        #endregion

        #region Botón Eliminar
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            // Tenemos que coger la fila en la que se ha hecho click en la celda y borrarla
            try
            {

                if (MessageBox.Show("¿Seguro que quieres eliminar el registro?", "Cuidado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning).Equals(DialogResult.Yes))
                {
                    ConexionBD.Open();

                    String cogerIdReserva = CboGuia.Text;
                    String sql = "DELETE FROM Reservas WHERE IdReserva=" + cogerIdReserva; // Porque por defecto selecciona 1 que es la seleccionada en el DGV

                    MessageBox.Show(sql);

                    comando2 = ConexionBD.CreateCommand();
                    comando2.CommandText = sql;

                    comando2.ExecuteScalar();
                    borrar_fila();

                    MessageBox.Show("Borrado con éxito");
                    ConexionBD.Close();
                }
            }
            catch (MySqlException error)
            {
                MessageBox.Show("No se ha podido completar la eliminación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}