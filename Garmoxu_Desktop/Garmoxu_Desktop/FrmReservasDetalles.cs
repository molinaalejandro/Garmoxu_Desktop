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
using static Garmoxu_Desktop.MessageBoxPersonalizado;
using static Garmoxu_Desktop.ConexionMySql;

namespace Garmoxu_Desktop
{
    public partial class FrmReservasDetalles : Form
    {
        private string ClavePrimaria;
        private string HoraApertura;
        private string HoraCierre;
        private int NivelPermisos;
        private List<string> DatosIniciales;

        public FrmReservasDetalles(string clavePrimaria, ref Form frmShadow, string horaApertura, string horaCierre, int nivelPermisos)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            ClavePrimaria = clavePrimaria;
            HoraApertura = horaApertura;
            HoraCierre = horaCierre;
            NivelPermisos = nivelPermisos;
            LimitarPermisos();
            CargarTipoForm();
            SombrearPantalla(ref frmShadow);
        }

        #region Apertura del formulario
        #region Limitación de permisos
        private void LimitarPermisos()
        {
            if (NivelPermisos == 0)
            {
                BtnBorrar.Visible = false;
                PnlBotones.Controls.Add(BtnConfirmar, 2, 0);
                PnlBotones.ColumnStyles[2] = new ColumnStyle(SizeType.AutoSize, 100f);
            }
        }
        #endregion

        // Si la clave primaria está con datos es porque se ha abierto con el doble click, si no NUEVA RESERVA
        private void CargarTipoForm()
        {
            DtpReserva.Value = DateTime.Now;

            if (string.IsNullOrEmpty(ClavePrimaria)) ConfigurarFormularioDeReservaNueva();
            else ConfigurarFormularioDeReservaExistente();
        }

        private void ConfigurarFormularioDeReservaNueva()
        {
            CargarMesasNoReservadas();
            DtpReserva.Value = DateTime.Now;
            DtpHora.Value = DateTime.Now;
            BtnBorrar.Visible = false;
            PnlBotones.Controls.Add(BtnConfirmar, 2, 0);
            BtnConfirmar.Text = "Registrar";
            DtpReserva.MinDate = DateTime.Now;
        }

        private void ConfigurarFormularioDeReservaExistente()
        {
            string sql = "SELECT * FROM Reservas WHERE IdReserva = " + ClavePrimaria;

            MySqlDataReader lector = EjecutarConsulta(sql);
            lector.Read();

            LblTitulo.Text = "Consulta la reserva " + lector["IdReserva"].ToString();
            DateTime fechaReserva = DateTime.Parse(lector[1].ToString());
            DateTime horaReserva = DateTime.Parse(lector[2].ToString());
            string tlfClienteReserva = lector[3].ToString();
            string mesaReservada = lector[4].ToString();

            CerrarConexion();
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

            if (esReservaAntigua) ConfigurarFormularioDeReservaHistorial();
            else DtpReserva.MinDate = DateTime.Parse(DateTime.Now.ToString("dd/MM/yyyy"));

            // Se asignan tras cerrar el lector, ya que si no, el lector actual entra en conflicto
            // con el que se genera en el evento de asignar las mesas no reservadas.
            DtpReserva.Value = fechaReserva;
            DtpHora.Value = horaReserva;
            TxtTelefono.Texts = tlfClienteReserva;

            CboMesa.SelectedIndex = CboMesa.Items.Count - 1;
            LblCboDisabled.Text = CboMesa.Items[CboMesa.Items.Count - 1].ToString();
            CboMesa.IconColor = Color.DimGray;
        }

        private void ConfigurarFormularioDeReservaHistorial()
        {
            PnlBotones.Controls.Add(BtnBorrar, 2, 0);
            BtnConfirmar.Visible = false;

            DtpReserva.Enabled = false;
            DtpReserva.TextColor = Color.DimGray;

            DtpHora.Enabled = false;
            DtpHora.TextColor = Color.DimGray;

            CboMesa.Enabled = false;
            CboMesa.IconColor = Color.DimGray;
            LblCboDisabled.Visible = true;

            TxtTelefono.Enabled = false;
            TxtNombreCliente.Enabled = false;
        }
        #endregion

        #region Funciones y diseño del formulario
        #region Bordeado del formulario
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;

                // Solo se acumulan modificaciones de diferente tipos, es decir,
                // una de ExStyle, otra de Style y otra de ClassStyle. Pero, nunca
                // se pueden acumular dos modificaciones del mismo tipo, por ejemplo,
                // no se acumulan dos ExStyle, o aplicas uno, o aplicas el otro.

                //cp.ExStyle = 0x00000100; // Aperentemente no hace nada
                //cp.ExStyle = 0x00020000; // Borde simple fino arriba e izquierda y grueso abajo y derecha
                cp.ExStyle = 0x00000200; // Borde 3D arriba e izquierda
                //cp.ExStyle = 0x00000001; // Borde 3D abajo y derecha
                // https://docs.microsoft.com/en-us/windows/win32/winmsg/extended-window-styles

                //cp.Style |= 0x00800000; // Borde simple fino
                cp.Style |= 0x00400000; // Borde 3D abajo y derecha
                // https://docs.microsoft.com/en-us/windows/win32/winmsg/window-styles

                //cp.ClassStyle |= 0x00020000; // Shadow border
                return cp;
            }
        }
        #endregion

        #region Sombreado de pantalla
        private void SombrearPantalla(ref Form frmShadow)
        {
            frmShadow = new Form();
            frmShadow.ShowInTaskbar = false;
            frmShadow.Text = "";
            frmShadow.FormBorderStyle = FormBorderStyle.None;
            frmShadow.Size = Size;
            frmShadow.WindowState = FormWindowState.Maximized;
            frmShadow.BackColor = Color.Black;
            frmShadow.Opacity = 0.7;
            frmShadow.Location = Location;
            frmShadow.Enabled = false;
            frmShadow.TopMost = true;
            frmShadow.Show();
        }
        #endregion
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

            string sql = "SELECT * FROM Mesas WHERE IdMesa NOT IN (SELECT IdMesa FROM Reservas WHERE " + CrearSQLConRangoHorario() + ")";
            MySqlDataReader lector = EjecutarConsulta(sql);

            while (lector.Read()) CboMesa.Items.Add(lector[0]);
            CerrarConexion();
            lector.Close();

            CargarMesaActualmenteReservada();
        }

        private void CargarMesaActualmenteReservada()
        {
            if (!string.IsNullOrEmpty(ClavePrimaria))
            {
                string sql = "SELECT IdReserva, IdMesa FROM Reservas WHERE " + CrearSQLConRangoHorario();
                MySqlDataReader lector = EjecutarConsulta(sql);

                while (lector.Read())
                {
                    if (ClavePrimaria.Equals(lector[0].ToString())) CboMesa.Items.Add(lector[1].ToString());
                }
                CerrarConexion();
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
            string scalar = EjecutarScalar(sql);

            if (!string.IsNullOrEmpty(scalar)) return scalar;
            else return string.Empty;
        }

        // Devuelve true si el teléfono existe en la BBDD. False si no es así.
        private bool ValidarTelefonoExistente(TextBox txt)
        {
            string tlf = txt.Text.Replace(" ", "");
            string sql = "SELECT * FROM Clientes WHERE TelefonoCliente = '" + tlf + "'";

            bool telefonoExistente = !string.IsNullOrEmpty(EjecutarScalar(sql));
            return telefonoExistente;
        }
        #endregion

        #region Boton de confirmar
        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals((char)Keys.Enter))
            {
                e.Handled = true;
                BtnConfirmar_Click(null, null);
            }
        }

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            if (ValidarReservaDisponible() && ValidarDatosCompletados())
            {
                // Cogemos la fecha y hora en la que se quiere hacer la reserva.
                string fechaReserva = DtpReserva.Value.ToString("yyyy/MM/dd");
                string horaReserva = DtpHora.Value.ToString("HH:mm");

                if (string.IsNullOrEmpty(ClavePrimaria)) DarAltaReserva(fechaReserva, horaReserva);
                else ModificarReserva();
            }
        }

        #region Validaciones
        private bool ValidarReservaDisponible()
        {
            if (!string.IsNullOrEmpty(ClavePrimaria))
            {
                string sql = "SELECT * FROM Reservas WHERE IdReserva = " + ClavePrimaria;
                if (string.IsNullOrEmpty(EjecutarScalar(sql)))
                {
                    string mensaje = "¡La reserva ya no está disponible! Alguien debe haberla eliminado mientras la consultabas.";
                    ShowErrorMessage(mensaje, "");
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
            bool nombreCompletado = !string.IsNullOrEmpty(TxtNombreCliente.Texts.Trim());

            if (mesaSeleccionada && tlfCompletado && nombreCompletado) return ValidarNumeroTlfCliente();

            string mensaje = "¡Debes completar todos los datos!";
            ShowWarningMessage(mensaje, "");
            return false;
        }

        private bool ValidarNumeroTlfCliente()
        {
            Regex regex = new Regex("^(\\+[0-9][0-9])?([0-9]{9})$");
            if (regex.IsMatch(TxtTelefono.Texts.Replace(" ", ""))) return true;
            else
            {
                string mensaje = "¡El formato del teléfono no es válido!";
                ShowWarningMessage(mensaje, "");
                return false;
            }
        }

        #region Cliente
        private bool ValidarClienteExistente()
        {
            string sql = "SELECT * FROM Clientes WHERE TelefonoCliente = '" + TxtTelefono.Texts.Replace(" ", "") + "'";
            bool clienteExiste = !string.IsNullOrEmpty(EjecutarScalar(sql));

            if (clienteExiste) return ModificarCliente();
            else return DarAltaCliente();
        }

        private bool DarAltaCliente()
        {
            string mensaje = "El cliente no está registrado, es necesario darlo de alta. ¿Deseas continuar?";
            if (ShowQuestionDialog(mensaje, "").Equals(DialogResult.Yes))
            {
                string sql = string.Format(
                    "INSERT INTO Clientes(TelefonoCliente, Direccion, CantidadPedidos, Nombre) VALUES('{0}', NULL, 0, '{1}')",
                    TxtTelefono.Texts.Replace(" ", ""), TxtNombreCliente.Texts.Trim());

                EjecutarSentencia(sql);
                return true;
            }
            else return false;
        }

        private bool ModificarCliente()
        {
            string sql = "SELECT Nombre FROM Clientes WHERE TelefonoCliente = '" + TxtTelefono.Texts.Replace(" ", "") + "'";

            bool nombreModificado = !EjecutarScalar(sql).Equals(TxtNombreCliente.Texts.Trim());
            if (nombreModificado)
            {
                string mensaje = "¿Desea aplicar los cambios realizados en el nombre del cliente?";
                DialogResult confirmacion = ShowMeDialog(mensaje, "", ButtonYesNoCancel(), IconQuestion());
                
                if(confirmacion.Equals(DialogResult.Yes))
                {
                    sql = string.Format("UPDATE Clientes SET nombre = '{0}' WHERE TelefonoCliente = '{1}'",
                        TxtNombreCliente.Texts.Trim(), TxtTelefono.Texts.Replace(" ", ""));
                    EjecutarSentencia(sql);

                    return true;
                }
                else if (confirmacion.Equals(DialogResult.Cancel)) return false;
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
                    EjecutarSentencia(sql);

                    InformarAccionConExito();
                    this.Close();
                }
                else ShowWarningMessage("¡Debes seleccionar una mesa!", "");
            }
        }
        #endregion

        #region Modificar reserva
        private void ModificarReserva()
        {
            string valoresModificados = "";
            bool datosModificados = ComprobarDatosModificados(ref valoresModificados);
            if (datosModificados)
            {
                if (ConfirmarAccion("guardar los cambios realizados en") && ValidarClienteExistente())
                {
                    string sql = "UPDATE Reservas SET " + valoresModificados + "  WHERE IdReserva = " + ClavePrimaria;
                    EjecutarSentencia(sql);

                    InformarAccionConExito();
                    this.Close();
                }
            }
            else if (ValidarClienteExistente()) this.Close();
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
                EjecutarSentencia(sql);

                InformarAccionConExito();
                this.Close();
            }
        }
        #endregion

        #region Mensajes
        // Muestra un mensaje de confirmación
        private bool ConfirmarAccion(string accion)
        {
            string mensaje = "¿Desea " + accion + " la reserva actual?";
            if (ShowQuestionDialog(mensaje, "").Equals(DialogResult.Yes)) return true;
            else return false;
        }

        // Muestra un mensaje de éxito
        private void InformarAccionConExito()
        {
            string mensaje = "¡Operación concluida con éxito!";
            ShowInfoMessage(mensaje, "");
        }
        #endregion

        #region Cierre del formulario
        private void BtnClose_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ClavePrimaria) || ComprobarCualquierDatoModificado())
            {
                string mensaje = "¿Desea salir sin guardar? Se perderán todos los cambios realizados.";
                if (ShowQuestionDialog(mensaje, "").Equals(DialogResult.Yes)) this.Close();
            }
            else this.Close();
        }

        private bool ComprobarCualquierDatoModificado()
        {
            List<string> datosActuales = new List<string>();
            datosActuales.Add(DtpReserva.Value.ToString("yyyy/MM/dd"));
            datosActuales.Add(DtpHora.Value.ToString("HH:mm"));
            if (CboMesa.SelectedIndex != -1) datosActuales.Add(CboMesa.SelectedItem.ToString());
            else datosActuales.Add(string.Empty);
            datosActuales.Add(TxtTelefono.Texts);

            bool modificacionRealizada = false;

            for (int i = 0; i < DatosIniciales.Count; i++)
            {
                if (!DatosIniciales[i].Equals(datosActuales[i])) modificacionRealizada = true;
            }

            if (!modificacionRealizada)
            {
                string sql = "SELECT Nombre FROM Clientes WHERE TelefonoCliente = '" + TxtTelefono.Texts.Replace(" ", "") + "'";
                if (!EjecutarScalar(sql).Equals(TxtNombreCliente.Texts.Trim())) modificacionRealizada = true;
            }

            return modificacionRealizada;
        }
        #endregion
    }
}