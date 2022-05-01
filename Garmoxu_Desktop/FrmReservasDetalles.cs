using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Garmoxu_Desktop
{
    public partial class FrmReservasDetalles : Form
    {
        private MySqlConnection ConexionBD;
        private FrmMain Instance;
        private string ClavePrimaria;

        private List<string> DatosIniciales;

        public FrmReservasDetalles(MySqlConnection conexionBD, string clavePrimaria, FrmMain instance)
        {
            InitializeComponent();
            ConexionBD = conexionBD;
            ClavePrimaria = clavePrimaria;
            Instance = instance;
            Instance.Enabled = false;
            CargarTipoForm();
        }

        #region Apertura del formulario
        private void CargarTipoForm()
        {
            // Si la clave primaria está con datos es porque se ha abierto con el doble click, si no NUEVA RESERVA
            if (string.IsNullOrEmpty(ClavePrimaria))
                ConfigurarFormularioDeReservaNueva();
            else
                ConfigurarFormularioDeReservaExistente();
        }

        private void ConfigurarFormularioDeReservaNueva()
        {
            CargarMesasNoReservadas();
            DtpReserva.Value = DateTime.Now;
            DtpHora.Value = DateTime.Now;
            BtnBorrar.Visible = false;
            BtnConfirmar.Location = new Point(150, 550);
            DtpReserva.MinDate = DateTime.Now;
        }

        private void ConfigurarFormularioDeReservaExistente()
        {
            BtnConfirmar.Text = "Guardar cambios";

            string sql = "SELECT * FROM Reservas WHERE IdReserva = " + ClavePrimaria;
            MySqlCommand cmd = new MySqlCommand(sql, ConexionBD);

            MySqlDataReader lector = cmd.ExecuteReader();
            lector.Read();

            DateTime fechaReserva = DateTime.Parse(lector[1].ToString());
            DateTime horaReserva = DateTime.Parse(lector[2].ToString());
            string tlfClienteReserva = lector[3].ToString();
            string mesaReservada = lector[4].ToString();

            lector.Close();

            DatosIniciales = new List<string>();
            DatosIniciales.Add(fechaReserva.ToString("yyyy/MM/dd"));
            DatosIniciales.Add(horaReserva.ToString("HH:mm"));
            DatosIniciales.Add(mesaReservada);
            DatosIniciales.Add(tlfClienteReserva);

            bool esReservaAntigua =
                    (fechaReserva.Year < DateTime.Now.Year)
                    ||
                    (fechaReserva.Year == DateTime.Now.Year && fechaReserva.Month < DateTime.Now.Month)
                    ||
                    (fechaReserva.Month == DateTime.Now.Month && fechaReserva.Day < DateTime.Now.Day);

            if (esReservaAntigua)
                ConfigurarFormularioDeReservaHistorial();
            else
                DtpReserva.MinDate = DateTime.Parse(DateTime.Now.ToString("dd/MM/yyyy"));

            // Se asignan tras cerrar el lector, ya que si no, el lector actual entra en conflicto
            // con el que se genera en el evento de asignar las mesas no reservadas.
            DtpReserva.Value = fechaReserva;
            DtpHora.Value = horaReserva;
            TxtTelefono.Texts = tlfClienteReserva;

            CboMesa.SelectedIndex = CboMesa.Items.Count - 1;
        }

        private void ConfigurarFormularioDeReservaHistorial()
        {
            BtnBorrar.Location = new Point(150, 550);
            BtnConfirmar.Visible = false;
            DtpReserva.Enabled = false;
            DtpHora.Enabled = false;
            CboMesa.Enabled = false;
            TxtTelefono.Enabled = false;
            TxtNombreCliente.Enabled = false;
        }
        #endregion

        #region Comprobar mesas libres
        private void DtpReserva_ValueChanged(object sender, EventArgs e)
        {
            CargarMesasNoReservadas();
        }

        private void DtpHora_ValueChanged(object sender, EventArgs e)
        {
            CargarMesasNoReservadas();
        }

        private void CargarMesasNoReservadas()
        {
            CboMesa.Items.Clear();
            CboMesa.ResetText();
            CboMesa.Texts = string.Empty;

            string sql = "SELECT * FROM Mesas WHERE IdMesa NOT IN " +
                "(SELECT IdMesa FROM Reservas WHERE " + CrearSQLConRangoHorario() + ")";

            MySqlCommand cmd = new MySqlCommand(sql, ConexionBD);
            MySqlDataReader lector = cmd.ExecuteReader();

            while (lector.Read())
                CboMesa.Items.Add(lector[0]);
            lector.Close();

            CargarMesaActualmenteReservada();
        }

        private void CargarMesaActualmenteReservada()
        {
            if (!string.IsNullOrEmpty(ClavePrimaria))
            {
                string sql = "SELECT IdReserva, IdMesa FROM Reservas WHERE " + CrearSQLConRangoHorario();

                MySqlCommand cmd = new MySqlCommand(sql, ConexionBD);
                MySqlDataReader lector = cmd.ExecuteReader();

                //string idReservaCompare = "";
                //string mesaReservada = "";
                //int i = 0;
                while (lector.Read())
                {
                    //idReservaCompare = lector[0].ToString();
                    //mesaReservada = lector[1].ToString();

                    //i++;

                    if (ClavePrimaria.Equals(lector[0].ToString()))
                        CboMesa.Items.Add(lector[1].ToString());
                }

                //if (i == 1 && ClavePrimaria.Equals(idReservaCompare))
                //  CboMesa.Items.Add(mesaReservada);

                lector.Close();
            }
        }

        private string CrearSQLConRangoHorario()
        {
            string sql = "";

            if (DtpHora.Value.Hour < 2)
            {
                sql = string.Format(
                    "(Fecha = '{0}' AND Hora BETWEEN '00:00' AND '{1}')" +
                    " OR (Fecha = '{2}' AND Hora BETWEEN '{3}' AND '23:59')",
                    DtpReserva.Value.ToString("yyyy/MM/dd"), DtpHora.Value.AddHours(2).ToString("HH:mm"),
                    DtpReserva.Value.AddDays(-1).ToString("yyyy/MM/dd"), DtpHora.Value.AddHours(-2).ToString("HH:mm"));
            }

            if (DtpHora.Value.Hour >= 22)
            {
                sql = string.Format(
                    "(Fecha = '{0}' AND Hora BETWEEN '{1}' AND '23:59')" +
                    " OR (Fecha = '{2}' AND Hora BETWEEN '00:00' AND '{3}')",
                    DtpReserva.Value.ToString("yyyy/MM/dd"), DtpHora.Value.AddHours(-2).ToString("HH:mm"),
                    DtpReserva.Value.AddDays(1).ToString("yyyy/MM/dd"), DtpHora.Value.AddHours(2).ToString("HH:mm"));
            }

            if (string.IsNullOrEmpty(sql))
            {
                sql = string.Format(
                    "(Fecha = '{0}' AND Hora BETWEEN '{1}' AND '{2}')",
                    DtpReserva.Value.ToString("yyyy/MM/dd"),
                    DtpHora.Value.AddHours(-2).ToString("HH:mm"),
                    DtpHora.Value.AddHours(2).ToString("HH:mm"));
            }

            return sql;
        }
        #endregion

        #region Escritura predictiva de telefono de cliente
        // Si se ha introducido un télefono y es válido, coge el nombre del cliente y lo mete en la text box.
        private void TxtTelefono__TextChanged(object sender, EventArgs e)
        {
            if ((sender as TextBox).Text.Trim().Length > 8 && ValidarTelefonoExistente(sender as TextBox))
                TxtNombreCliente.Texts = ObtenerNombreCliente(sender as TextBox);
            else
                TxtNombreCliente.Texts = string.Empty;
        }

        // Obtiene el nombre de un cliente y lo devuelve.
        private string ObtenerNombreCliente(TextBox txt)
        {
            string tlf = txt.Text.Replace(" ", "");
            string sql = "SELECT Nombre FROM Clientes WHERE TelefonoCliente = '" + tlf + "'";

            MySqlCommand cmd = new MySqlCommand(sql, ConexionBD);

            if (cmd.ExecuteScalar() != null)
                return cmd.ExecuteScalar().ToString();
            else
                return string.Empty;
        }

        // Devuelve true si el teléfono existe en la BBDD. False si no es así.
        private bool ValidarTelefonoExistente(TextBox txt)
        {
            string tlf = txt.Text.Replace(" ", "");

            MySqlCommand cmd = new MySqlCommand(
                "SELECT * FROM Clientes WHERE TelefonoCliente = '" + tlf + "'", ConexionBD);

            bool telefonoExistente = cmd.ExecuteScalar() != null;
            return telefonoExistente;
        }
        #endregion

        #region Boton de confirmar
        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            if (ValidarReservaDisponible() && ValidarDatosCompletados())
            {
                // Cogemos la fecha y hora en la que se quiere hacer la reserva.
                string fechaReserva = DtpReserva.Value.ToString("yyyy/MM/dd");
                string horaReserva = DtpHora.Value.ToString("HH:mm");

                if (string.IsNullOrEmpty(ClavePrimaria))
                    DarAltaReserva(fechaReserva, horaReserva);
                else
                    ModificarReserva(fechaReserva, horaReserva);
            }
        }

        #region Validaciones
        private bool ValidarReservaDisponible()
        {
            if (!string.IsNullOrEmpty(ClavePrimaria))
            {
                string sql = "SELECT * FROM Reservas WHERE IdReserva = " + ClavePrimaria;
                MySqlCommand cmd = new MySqlCommand(sql, ConexionBD);

                if (cmd.ExecuteScalar() == null)
                {
                    string mensaje = "¡La reserva ya no está disponible, alguien debe haberla eliminado mientras la consultabas!";
                    MessageBox.Show(mensaje, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    return false;
                }
            }
            return true;
        }

        private bool ValidarDatosCompletados()
        {
            bool mesaSeleccionada = CboMesa.SelectedIndex != -1;
            bool tlfCompletado = !string.IsNullOrEmpty(TxtTelefono.Texts.Replace(" ", ""));
            bool nombreCompletado = !string.IsNullOrEmpty(TxtNombreCliente.Texts);

            if (mesaSeleccionada && tlfCompletado && nombreCompletado)
                return ValidarNumeroTlfCliente();

            MessageBox.Show("¡Debes completar todos los datos!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        private bool ValidarNumeroTlfCliente()
        {
            Regex regex = new Regex("^(\\+[0-9][0-9])?([0-9]{9})$");
            if (regex.IsMatch(TxtTelefono.Texts.Replace(" ", "")))
                return true;
            else
            {
                MessageBox.Show("¡El formato del teléfono no es válido!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        #region Cliente
        private bool ValidarClienteExistente()
        {
            string sql = "SELECT * FROM Clientes WHERE TelefonoCliente = '" + TxtTelefono.Texts.Replace(" ", "") + "'";
            MySqlCommand cmd = new MySqlCommand(sql, ConexionBD);
            bool clienteExiste = cmd.ExecuteScalar() != null;

            if (clienteExiste)
                return ModificarCliente();
            else
                return DarAltaCliente();
        }

        private bool DarAltaCliente()
        {
            string mensaje = "El cliente no está registrado, es necesario darlo de alta. ¿Deseas continuar?";
            DialogResult mensajeConfirmacion = MessageBox.Show(mensaje, "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (mensajeConfirmacion.Equals(DialogResult.Yes))
            {
                string sql = string.Format(
                    "INSERT INTO Clientes(TelefonoCliente, Direccion, CantidadPedidos, Nombre) VALUES('{0}', NULL, 0, '{1}')",
                    TxtTelefono.Texts.Replace(" ", ""), TxtNombreCliente.Texts);

                MySqlCommand cmd = new MySqlCommand(sql, ConexionBD);
                cmd.ExecuteNonQuery();
                return true;
            }
            else
                return false;
        }

        private bool ModificarCliente()
        {
            string sql = "SELECT Nombre FROM Clientes WHERE TelefonoCliente = '" + TxtTelefono.Texts.Replace(" ", "") + "'";
            MySqlCommand cmd = new MySqlCommand(sql, ConexionBD);

            bool nombreModificado = !cmd.ExecuteScalar().ToString().Equals(TxtNombreCliente.Texts);

            if (nombreModificado)
            {
                string mensaje = "¿Desea aplicar los cambios realizados en el nombre del cliente?";
                DialogResult mensajeConfirmacion = MessageBox.Show(mensaje, "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (mensajeConfirmacion.Equals(DialogResult.Yes))
                {
                    sql = string.Format(
                        "UPDATE Clientes SET nombre = '{0}' WHERE TelefonoCliente = '{1}'",
                        TxtNombreCliente.Texts, TxtTelefono.Texts.Replace(" ", ""));
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();

                    return true;
                }
                else if (mensajeConfirmacion.Equals(DialogResult.Cancel))
                    return false;
            }

            return true;
        }
        #endregion
        #endregion

        #region Alta de reserva
        private void DarAltaReserva(string fechaReserva, string horaReserva)
        {
            if (ConfirmarAccion("dar de alta") && ValidarClienteExistente())
            {
                if (CboMesa.SelectedItem != null)
                {
                    string sql = string.Format(
                        "INSERT INTO Reservas(Fecha, Hora, TelefonoCliente, IdMesa) VALUES ('{0}', '{1}', '{2}', {3})",
                        fechaReserva, horaReserva, TxtTelefono.Texts.Replace(" ", ""), CboMesa.SelectedItem);
                    MySqlCommand cmd = new MySqlCommand(sql, ConexionBD);
                    cmd.ExecuteNonQuery();

                    InformarAccionConExito();
                    this.Close();
                }
                else
                    MessageBox.Show("¡Debes seleccionar una mesa!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        #region Modificar reserva
        private void ModificarReserva(string fechaReserva, string horaReserva)
        {
            string valoresModificados = "";
            bool datosModificados = ComprobarDatosModificados(ref valoresModificados);
            if (datosModificados)
            {
                if (ConfirmarAccion("guardar los cambios realizados en") && ValidarClienteExistente())
                {
                    string sql = "UPDATE Reservas SET " + valoresModificados + "  WHERE IdReserva = " + ClavePrimaria;

                    MySqlCommand cmd = new MySqlCommand(sql, ConexionBD);
                    cmd.ExecuteNonQuery();

                    InformarAccionConExito();
                    this.Close();
                }
            }
            else
            {
                if (ValidarClienteExistente())
                    this.Close();
            }
        }

        private bool ComprobarDatosModificados(ref string valoresModificados)
        {
            List<string> columnasDatos = new List<string>();
            columnasDatos.Add("Fecha = '");
            columnasDatos.Add("Hora = '");
            columnasDatos.Add("IdMesa = ");
            columnasDatos.Add("TelefonoCliente = '");

            List<string> datosActuales = new List<string>();
            datosActuales.Add(DtpReserva.Value.ToString("yyyy/MM/dd"));
            datosActuales.Add(DtpHora.Value.ToString("HH:mm"));
            datosActuales.Add(CboMesa.SelectedItem.ToString());
            datosActuales.Add(TxtTelefono.Texts);

            bool modificacionRealizada = false;
            List<string> datosModificados = new List<string>();

            string dato;
            for (int i = 0; i < DatosIniciales.Count; i++)
            {
                if (!DatosIniciales[i].Equals(datosActuales[i]))
                {
                    bool llevaComillas = columnasDatos[i].Last<char>() == '\'';
                    dato = columnasDatos[i] + datosActuales[i];
                    if (llevaComillas) dato += "'";
                    datosModificados.Add(dato);
                    modificacionRealizada = true;
                }
            }

            // Le da el formato adecuado para la sentencia SQL
            for (int i = 0; i < datosModificados.Count; i++)
            {
                valoresModificados += datosModificados[i];
                if (i != datosModificados.Count - 1) valoresModificados += ", ";
            }

            return modificacionRealizada;
        }
        #endregion
        #endregion

        #region Borrar reserva
        // Solo se puede borrar cuando vengamos con doble click
        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            if (ValidarReservaDisponible() && ConfirmarAccion("eliminar permanentemente"))
            {
                string sql = "DELETE FROM Reservas WHERE IdReserva = " + ClavePrimaria;

                MySqlCommand cmd = new MySqlCommand(sql, ConexionBD);
                cmd.ExecuteNonQuery();

                InformarAccionConExito();
                this.Close();
            }
        }
        #endregion

        #region Mensajes
        // Muestra un mensaje de confirmación
        private bool ConfirmarAccion(string accion)
        {
            DialogResult accionConfirmada =
                MessageBox.Show("¿Desea " + accion + " la reserva actual?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
        private void BtnClose_Click(object sender, EventArgs e)
        {
            if (!(!string.IsNullOrEmpty(ClavePrimaria) && !ComprobarCualquierDatoModificado()))
            {
                string mensaje = "Se perderán todos los cambios no guardados. ¿Deseas continuar?";
                DialogResult cerrarVentana = MessageBox.Show(mensaje, "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (cerrarVentana.Equals(DialogResult.Yes))
                    this.Close();
            }
            else
                this.Close();
        }

        private bool ComprobarCualquierDatoModificado()
        {
            List<string> datosActuales = new List<string>();
            datosActuales.Add(DtpReserva.Value.ToString("yyyy/MM/dd"));
            datosActuales.Add(DtpHora.Value.ToString("HH:mm"));
            if (CboMesa.SelectedIndex != -1)
                datosActuales.Add(CboMesa.SelectedItem.ToString());
            else
                datosActuales.Add(string.Empty);
            datosActuales.Add(TxtTelefono.Texts);

            bool modificacionRealizada = false;

            for (int i = 0; i < DatosIniciales.Count; i++)
            {
                if (!DatosIniciales[i].Equals(datosActuales[i]))
                    modificacionRealizada = true;
            }

            if (!modificacionRealizada)
            {
                string sql = "SELECT Nombre FROM Clientes WHERE TelefonoCliente = '" + TxtTelefono.Texts.Replace(" ", "") + "'";
                MySqlCommand cmd = new MySqlCommand(sql, ConexionBD);
                if (!cmd.ExecuteScalar().ToString().Equals(TxtNombreCliente.Texts))
                    modificacionRealizada = true;
            }

            return modificacionRealizada;
        }

        private void FrmDetallesReserva_FormClosing(object sender, FormClosingEventArgs e)
        {
            Instance.Enabled = true;
        }
        #endregion
    }
}