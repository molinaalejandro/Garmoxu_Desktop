using MySql.Data.MySqlClient;
using RJCodeAdvance.RJControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Garmoxu_Project
{
    public partial class FrmClientes : Form
    {
        private MySqlConnection ConexionBD;
        private DataSet Ds;
        private List<string> DatosIniciales;

        private int RegistrosCargados;
        private const int CantidadRegistrosCargadosPorIteraccion = 50;

        public FrmClientes(MySqlConnection conexionBD)
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            ConexionBD = conexionBD;
            CargarDatos();
        }

        #region Apertura del formulario
        #region Cargar datos
        private void CargarDatos()
        {
            Ds = new DataSet();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            string sql = "SELECT TelefonoCliente FROM Clientes ORDER BY TelefonoCliente ASC";
            MySqlCommand cmd = new MySqlCommand(sql, ConexionBD);
            adapter.SelectCommand = cmd;
            adapter.Fill(Ds, "Clientes");

            ResetearDataGrid();
            RellenarDataGrid();
        }

        private void ResetearDataGrid()
        {
            DtgClientes.Rows.Clear();
            RegistrosCargados = 0;
        }

        private void RellenarDataGrid()
        {
            for (int i = 0; i < CantidadRegistrosCargadosPorIteraccion; i++)
            {
                if (RegistrosCargados < Ds.Tables["Clientes"].Rows.Count)
                {
                    DtgClientes.Rows.Add(Ds.Tables["Clientes"].Rows[RegistrosCargados].ItemArray[0]);
                    RegistrosCargados++;
                }
            }
        }
        #endregion
        #endregion

        #region Carga progresiva de usuarios
        private void DtgClientes_Scroll(object sender, ScrollEventArgs e)
        {
            if ((e.Type == ScrollEventType.SmallIncrement || e.Type == ScrollEventType.LargeIncrement)
                && e.NewValue >= DtgClientes.Rows.Count - GetDisplayedRowsCount())
                RellenarDataGrid();
        }

        private int GetDisplayedRowsCount()
        {
            int count = DtgClientes.Rows[DtgClientes.FirstDisplayedScrollingRowIndex].Height;
            count = DtgClientes.Height / count;
            return count;
        }
        #endregion

        #region Busqueda de clientes
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtBuscar.Texts.Trim()))
            {
                Ds = new DataSet();
                MySqlDataAdapter adapter = new MySqlDataAdapter();

                string busqueda = TxtBuscar.Texts.Replace(" ", "");
                string sql = "SELECT TelefonoCliente FROM Clientes WHERE TelefonoCliente LIKE '" + busqueda + "%' " +
                    "OR TelefonoCliente LIKE '+__" + busqueda + "%' OR TelefonoCliente LIKE '+" + busqueda + "%' " +
                    "ORDER BY TelefonoCliente ASC";
                MySqlCommand cmd = new MySqlCommand(sql, ConexionBD);
                adapter.SelectCommand = cmd;
                adapter.Fill(Ds, "Clientes");

                ResetearDataGrid();
                RellenarDataGrid();
            }
            else
                CargarDatos();
        }

        private void TxtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals((char)Keys.Enter))
                BtnBuscar_Click(null, null);
        }
        #endregion

        #region Alta de clientes
        private void BtnAbrirNuevo_Click(object sender, EventArgs e)
        {
            Tbc.SelectedTab = tabPage2;
            Tbc.Visible = true;
        }

        #region Boton de guardar
        private void BtnGuardarDatos_Click(object sender, EventArgs e)
        {
            if (ValidarDatosCompletados() && ValidarFormatoTelefono(TxtTelefonoTB2.Texts.Replace(" ", ""))
                && ConfirmarAccion("dar de alta") && ValidarTelefonoNoRegistrado(TxtTelefonoTB2))
            {
                string sql = string.Format(
                    "INSERT INTO Clientes (TelefonoCliente, Direccion, CantidadPedidos, Nombre) " +
                    "VALUES ('{0}', '{1}', 0, '{2}')",
                    TxtTelefonoTB2.Texts.Replace(" ", ""),
                    TxtDireccionTB2.Texts.Trim(),
                    TxtNombreTB2.Texts.Trim());

                MySqlCommand cmd = new MySqlCommand(sql, ConexionBD);
                cmd.ExecuteNonQuery();

                LimpiarControles();
                CargarDatos();
                InformarAccionConExito();
            }
        }
        #endregion
        #endregion

        #region Modificacion de clientes
        #region Carga de los detalles del cliente
        private void DtgClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string tlfSeleccionado = DtgClientes.SelectedRows[0].Cells[0].Value.ToString();
            if (ValidarClienteDisponible(tlfSeleccionado))
            {
                Tbc.SelectedTab = tabPage1;
                Tbc.Visible = true;

                string sql = "SELECT * FROM Clientes WHERE TelefonoCliente = '" + tlfSeleccionado + "'";

                MySqlCommand cmd = new MySqlCommand(sql, ConexionBD);
                MySqlDataReader lector = cmd.ExecuteReader();

                if (lector.Read())
                {
                    TxtTelefonoTB1.Texts = lector[0].ToString();
                    TxtDireccionTB1.Texts = lector[1].ToString();
                    LblCantidadPedidos.Text = lector[2].ToString();
                    TxtNombreTB1.Texts = lector[3].ToString();

                    DatosIniciales = new List<string>();
                    DatosIniciales.Add(TxtTelefonoTB1.Texts);
                    DatosIniciales.Add(TxtDireccionTB1.Texts);
                    DatosIniciales.Add(TxtNombreTB1.Texts);
                }
                lector.Close();
            }
        }
        #endregion

        #region Boton de modificación de cliente
        private void BtnModificarCliente_Click(object sender, EventArgs e)
        {
            string valores = string.Empty;
            if (ValidarDatosCompletados() && ValidarFormatoTelefono(TxtTelefonoTB1.Texts.Replace(" ", ""))
                && ValidarClienteDisponible(DatosIniciales[0]) && ComprobarDatosModificados(ref valores)
                && ConfirmarAccion("modificar") && ValidarTelefonoNoRegistrado(TxtTelefonoTB1))
            {
                string sql = string.Format(
                    "UPDATE Clientes SET {0} WHERE TelefonoCliente = '{1}'",
                    valores, DatosIniciales[0]);

                MySqlCommand cmd = new MySqlCommand(sql, ConexionBD);
                cmd.ExecuteNonQuery();

                LimpiarControles();
                CargarDatos();
                InformarAccionConExito();
            }
        }
        #endregion
        #endregion

        #region Eliminación de clientes
        private void BtnBorrarCliente_Click(object sender, EventArgs e)
        {
            string tlfActual = TxtTelefonoTB1.Texts.Replace(" ", "");
            if (ValidarClienteDisponible(tlfActual) && ConfirmarAccion("eliminar permanentemente")
                && !ComprobarPedidosEnCurso() && ConfirmarEliminacionConReservas())
            {
                string tlfSeleccionado = DtgClientes.SelectedRows[0].Cells[0].Value.ToString();
                string sql = "DELETE FROM Clientes WHERE TelefonoCliente = '" + tlfSeleccionado + "'";
                MySqlCommand cmd = new MySqlCommand(sql, ConexionBD);
                cmd.ExecuteNonQuery();

                LimpiarControles();
                CargarDatos();
                InformarAccionConExito();
            }
        }

        private bool ComprobarPedidosEnCurso()
        {
            string tlfSeleccionado = DtgClientes.SelectedRows[0].Cells[0].Value.ToString();
            string sql = "SELECT TelefonoCliente FROM PedidosEnCurso WHERE TelefonoCliente = '" + tlfSeleccionado + "'";
            MySqlCommand cmd = new MySqlCommand(sql, ConexionBD);

            if (cmd.ExecuteScalar() == null)
                return false;

            string mensaje = "¡No se puede eliminar el cliente seleccionado debido a que tiene pedidos en curso asociados! " +
                "Finalice o cancele todos los pedidos en curso antes de continuar.";
            MessageBox.Show(mensaje, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return true;
        }

        //private bool ComprobarReservasEnCurso()
        //{
        //    string tlfSeleccionado = DtgClientes.SelectedRows[0].Cells[0].Value.ToString();
        //    string sql = string.Format(
        //        "SELECT TelefonoCliente FROM Reservas WHERE TelefonoCliente = '{0}' AND Fecha >= '{1}'",
        //        tlfSeleccionado, DateTime.Now.ToString("yyyy/MM/dd"));
        //    MySqlCommand cmd = new MySqlCommand(sql, ConexionBD);

        //    if (cmd.ExecuteScalar() == null)
        //        return false;

        //    string mensaje = "¡No se puede eliminar el cliente seleccionado debido a que tiene reservas en curso asociadas! " +
        //        "Finalice o cancele todas las reservas en curso antes de continuar";
        //    MessageBox.Show(mensaje, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //    return true;
        //}

        private bool ConfirmarEliminacionConReservas()
        {
            string tlfSeleccionado = DtgClientes.SelectedRows[0].Cells[0].Value.ToString();
            string sql = string.Format(
                "SELECT TelefonoCliente FROM Reservas WHERE TelefonoCliente = '{0}'",
                tlfSeleccionado);
            MySqlCommand cmd = new MySqlCommand(sql, ConexionBD);

            if (cmd.ExecuteScalar() == null)
                return true;

            string mensaje = "Este cliente tiene asociadas algunas reservas, tenga en cuenta que todas ellas serán eliminadas. ¿Desea continuar?";
            DialogResult confirmar = MessageBox.Show(mensaje, "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmar.Equals(DialogResult.Yes))
                return true;
            return false;
        }
        #endregion

        #region Validaciones y comprobaciones
        private bool ValidarClienteDisponible(string tlf)
        {
            string sql = "SELECT * FROM Clientes WHERE TelefonoCliente = '" + tlf + "'";
            MySqlCommand cmd = new MySqlCommand(sql, ConexionBD);

            if (cmd.ExecuteScalar() == null)
            {
                string mensaje = "¡El cliente ya no está disponible! Alguien debe haberlo borrado";
                MessageBox.Show(mensaje, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LimpiarControles();
                CargarDatos();
                return false;
            }

            return true;
        }

        private bool ValidarDatosCompletados()
        {
            if (Tbc.SelectedIndex == 0)
            {
                if (!string.IsNullOrEmpty(TxtTelefonoTB1.Texts.Trim())
                    && !string.IsNullOrEmpty(TxtDireccionTB1.Texts.Trim())
                    && !string.IsNullOrEmpty(TxtNombreTB1.Texts.Trim()))
                    return true;
            }
            else
            {
                if (!string.IsNullOrEmpty(TxtTelefonoTB2.Texts.Trim())
                    && !string.IsNullOrEmpty(TxtDireccionTB2.Texts.Trim())
                    && !string.IsNullOrEmpty(TxtNombreTB2.Texts.Trim()))
                    return true;
            }

            string mensaje = "¡Debes completar todos los datos!";
            MessageBox.Show(mensaje, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        private bool ValidarFormatoTelefono(string tlf)
        {
            Regex rgx = new Regex("^(\\+[0-9][0-9])?([0-9]{9})$");

            if (!rgx.IsMatch(tlf))
            {
                string mensaje = "¡El formato del teléfono introducido no es válido!";
                MessageBox.Show(mensaje, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private bool ValidarTelefonoNoRegistrado(RJTextBox txt)
        {
            string sql = "SELECT TelefonoCliente FROM Clientes WHERE TelefonoCliente = '" + txt.Texts.Replace(" ", "") + "'";
            MySqlCommand cmd = new MySqlCommand(sql, ConexionBD);

            if (cmd.ExecuteScalar() == null)
                return true;

            bool esTlfActual = (Tbc.SelectedIndex != 1) && cmd.ExecuteScalar().ToString().Equals(DatosIniciales[0]);
            if (esTlfActual)
                return true;

            string mensaje = "¡El telefono introducido ya está registrado!";
            MessageBox.Show(mensaje, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        #region Comprobacion de datos modificados
        private bool ComprobarDatosModificados(ref string valores)
        {
            bool modificacionRealizada = false;

            if (DatosIniciales != null && DatosIniciales.Count == 3)
            {
                string dato;

                List<string> datosActuales = RecogerDatosActuales();
                List<string> columnasDatos = InicializarListaColumnasDatos();
                List<string> datosModificados = new List<string>();

                for (int i = 0; i < datosActuales.Count; i++)
                {
                    if (!DatosIniciales[i].Equals(datosActuales[i]))
                    {
                        bool llevaComillas = columnasDatos[i].Last<char>() == '\'';
                        if (llevaComillas && datosActuales[i].Equals("NULL"))
                        {
                            columnasDatos[i] = columnasDatos[i].Remove(columnasDatos[i].Length - 1);
                            llevaComillas = false;
                        }
                        dato = columnasDatos[i] + datosActuales[i];
                        if (llevaComillas) dato += "'";
                        datosModificados.Add(dato);
                        modificacionRealizada = true;
                    }
                }

                // Le da el formato adecuado para la sentencia SQL
                for (int i = 0; i < datosModificados.Count; i++)
                {
                    valores += datosModificados[i];
                    if (i != datosModificados.Count - 1) valores += ", ";
                }

                if (!modificacionRealizada) Tbc.Visible = false;
            }
            return modificacionRealizada;
        }

        private List<string> RecogerDatosActuales()
        {
            List<string> datosActuales = new List<string>();
            datosActuales.Add(TxtTelefonoTB1.Texts.Replace(" ", ""));
            datosActuales.Add(TxtDireccionTB1.Texts.Trim());
            datosActuales.Add(TxtNombreTB1.Texts.Trim());

            return datosActuales;
        }

        private List<string> InicializarListaColumnasDatos()
        {
            List<string> columnas = new List<string>();
            columnas.Add("TelefonoCliente = '");
            columnas.Add("Direccion = '");
            columnas.Add("Nombre = '");
            return columnas;
        }
        #endregion
        #endregion

        #region Limpiar controles
        private void LimpiarControles()
        {
            if (Tbc.SelectedIndex == 0)
            {
                TxtTelefonoTB1.Texts = string.Empty;
                TxtDireccionTB1.Texts = string.Empty;
                TxtNombreTB1.Texts = string.Empty;
            }
            else
            {
                TxtTelefonoTB2.Texts = string.Empty;
                TxtDireccionTB2.Texts = string.Empty;
                TxtNombreTB2.Texts = string.Empty;
            }

            Tbc.Visible = false;
        }
        #endregion

        #region Mensajes
        // Muestra un mensaje de confirmación
        private bool ConfirmarAccion(string accion)
        {
            DialogResult accionConfirmada =
                MessageBox.Show("¿Desea " + accion + " el cliente actual?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            string v = string.Empty;
            if ((Tbc.Visible && Tbc.SelectedIndex == 1) || ComprobarDatosModificados(ref v))
            {
                string mensaje = "Se perderán todos los cambios no guardados. ¿Deseas continuar?";
                DialogResult cerrarVentana = MessageBox.Show(mensaje, "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (cerrarVentana.Equals(DialogResult.Yes))
                    this.Close();
            }
            else
                this.Close();
        }
        #endregion
    }
}