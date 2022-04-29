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
    public partial class FrmDetallesReserva : Form
    {
        private MySqlConnection ConexionBD;
        MySqlCommand comando;
        MySqlCommand update;
        MySqlCommand insertar;

        String cogerIdMesa = "";

        public FrmDetallesReserva(MySqlConnection conexionBD)
        {
            InitializeComponent();
            ConexionBD = conexionBD;
        }

        #region Comprobar estado conexion y abrir
        public void comprobarEstado_Conexion()
        {
            if (ConexionBD.State == ConnectionState.Open)
            {
                MessageBox.Show("La conexión ya está abierta");
            }
            else
            {
                ConexionBD.Open();
            }
        }
        #endregion  

        private void FrmDetallesReserva_Load(object sender, EventArgs e)
        {
            comprobarEstado_Conexion();
            cargarUltimo_IdReserva();
            cargarUltimo_IdMesa();
        }

        #region Método que devuelve la consulta de la busqueda de registros por fecha y hora
        public String Devolver_Fecha_Hora()
        {
            // Tenemos que coger la fecha del date picker, y formatearla para poder usarla en la select
            String cogerFecha = DtpReserva.Value.ToString("yyyy/MM/dd");
            // Tambien necesitamos la hora de los numeric para comprobar tambien por hora y minutos si hay alguna reserva en esa mesa

            String cogerHoras = NucHora.Value.ToString();
            String cogerMinutos = NucMinuto.Value.ToString();
            String horasMinutosFormateado = cogerHoras + ":" + cogerMinutos + ":00";
            // Ahora hacemos la select
            String sql = "SELECT r.IdMesa FROM Reservas r, Mesas m WHERE r.IdMesa = m.IdMesa AND m.Estado = 'Libre' AND r.Fecha = '" + cogerFecha + "' AND r.Hora = '" + horasMinutosFormateado + "'";

            return sql;
        }
        #endregion

        #region Cargar por defecto Mesas disponibles en fecha por defecto (Cogiendo fecha Actual)
        public void cargarUltimo_IdMesa()
        {
            CboMesa.Items.Clear();

            MySqlCommand cargarIdMesa = new MySqlCommand();
            cargarIdMesa.Connection = ConexionBD;
            cargarIdMesa.CommandText = Devolver_Fecha_Hora();

            MySqlDataReader lector = cargarIdMesa.ExecuteReader();

            while (lector.Read())
            {
                CboMesa.Items.Add(lector[0]);
            }
            lector.Close();
        }
        #endregion

        #region Cargar Mesas disponibles cuando se cambie el valor del calendario
        private void DtpReserva_ValueChanged(object sender, EventArgs e)
        {
            CboMesa.Items.Clear();

            try
            {

                MySqlCommand cargarIdMesa = new MySqlCommand();
                cargarIdMesa.Connection = ConexionBD;
                cargarIdMesa.CommandText = Devolver_Fecha_Hora();

                MySqlDataReader lector = cargarIdMesa.ExecuteReader();

                while (lector.Read())
                {
                    CboMesa.Items.Add(lector[0]);
                }
                lector.Close();
            }
            catch (MySqlException error)
            {
                MessageBox.Show("No hemos podido entender esa orden, haz click en el sitio adecuado del calendario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region  Cargar Mesas disponibles cuando se cambie el valor del numerico de la hora
        private void NucHora_ValueChanged(object sender, EventArgs e)
        {
            CboMesa.Items.Clear();

            MySqlCommand cargarIdMesa = new MySqlCommand();
            cargarIdMesa.Connection = ConexionBD;
            cargarIdMesa.CommandText = Devolver_Fecha_Hora();

            MySqlDataReader lector = cargarIdMesa.ExecuteReader();

            while (lector.Read())
            {
                CboMesa.Items.Add(lector[0]);
            }
            lector.Close();
        }

        #endregion

        #region Cargar Mesas disponibles cuando se cambie el valor del numerico de la hora
        private void NucMinuto_ValueChanged(object sender, EventArgs e)
        {
            CboMesa.Items.Clear();

            MySqlCommand cargarIdMesa = new MySqlCommand();
            cargarIdMesa.Connection = ConexionBD;
            cargarIdMesa.CommandText = Devolver_Fecha_Hora();

            MySqlDataReader lector = cargarIdMesa.ExecuteReader();

            while (lector.Read())
            {
                CboMesa.Items.Add(lector[0]);
            }
            lector.Close();
        }
        #endregion

        #region Coger el IdReserva máximo y sumarle 1
        public void cargarUltimo_IdReserva()
        {
            String sql = "SELECT MAX(IdReserva)+1 FROM Reservas";

            MySqlCommand comando = new MySqlCommand();
            comando.Connection = ConexionBD;
            comando.CommandText = sql;

            MySqlDataReader lector = comando.ExecuteReader();

            if (lector.Read()) { CboReserva.Items.Add(lector[0]); CboReserva.SelectedIndex = 0; }
            lector.Close();
        }
        #endregion

        #region Boton de confirmar
        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            // Cogemos los campos y los metemos en la base de datos, tenemos que coger la fecha actual y hora actual

            String cogerFecha = DtpReserva.Value.ToString("yyyy/MM/dd");

            String cogerHoras = NucHora.Value.ToString();
            String cogerMinutos = NucMinuto.Value.ToString();
            String horaminutos = cogerHoras + ":" + cogerMinutos + ":00";

            try
            {
                String cogerNombreCliente = TxtNombreCliente.Texts.ToString();

                // Una vez cogidos todos los datos, comprobar que el telefono y el nombre del cliente existen si no existen, tiramos error
                // La comprobación en modo conectado
                comando = ConexionBD.CreateCommand();
                comando.CommandText = "SELECT Nombre FROM Clientes WHERE Nombre='" + cogerNombreCliente + "' AND TelefonoCliente= '" + TxtTelefono.Texts.ToString() + "'";

                MySqlDataReader lector;
                lector = comando.ExecuteReader();

                if (lector.Read())
                {
                    lector.Close(); // Lo tengo que cerrar para el tema de ejecutar el comando de inserción

                    if (!(CboMesa.SelectedItem == null))
                    {
                        insertar = new MySqlCommand();
                        insertar = ConexionBD.CreateCommand();

                        insertar.CommandText = "INSERT INTO Reservas(Fecha, Hora, TelefonoCliente, IdMesa) " +
                            "VALUES ('" + cogerFecha + "', '" + horaminutos + "'," + TxtTelefono.Texts.ToString() + ", '" + CboMesa.SelectedItem + "')";

                        insertar.ExecuteNonQuery();
                        // Una vez se haya hecho el insertado hay que hacer el update para decir que el estado ahora de la mesa NO ES LIBRE

                        String sqlUpdate = "UPDATE Mesas SET Estado='Reservada', NumeroComensales=null  WHERE IdMesa=" + CboMesa.SelectedItem;
                        update = ConexionBD.CreateCommand();
                        update.CommandText = sqlUpdate;
                        update.ExecuteNonQuery();

                        MessageBox.Show("RESERVA HECHA -> " + cogerFecha + " -- " + horaminutos + " A nombre de " + TxtNombreCliente.Texts.ToString(), "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Close(); // La cerramos por si quiere abrir otra vez el form, que se abra otra vez la conexión
                    }
                    else
                    {
                        // Si esta vacio la seleccion de mesa, no se puede reservar
                        MessageBox.Show("No has seleccionado una mesa Libre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("No se ha podido comprobar el cliente, comprueba los datos o registrale si no lo está", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                // No cierro conexión aquí fuera porque si ha puesto algo mal se le cierra y tiene que seleccionar todo de nuevo
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("No se pueden dejar campos vacíos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Hay algún formato mal", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (MySqlException error)
            {
                MessageBox.Show("No se ha podido completar la reserva, compruebe que todo esté bien" + error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Comprobar si hay mesa Reservada asociada a un telefono
        public Boolean Comprobar_ExisteMesa_AsocTelefono()
        {
            // EL NOMBRE DEL BOTÓN ES INSERTAR PORQUE NOS SIRVE Y ASÍ NO CREAMOS OTRO QUE CONSUME RECURSOS

            // PRIMERO COMPROBAMOS QUE EXISTA UNA MESA CON ESE ID Y QUE ESTÉ RESERVADA
            String sql = "SELECT r.IdMesa FROM Mesas m, Reservas r WHERE m.IdMesa = r.IdMesa AND m.Estado='Reservada' AND r.TelefonoCliente='" + TxtTelefono.Texts + "'";
            insertar = ConexionBD.CreateCommand();
            insertar.CommandText = sql;
            MySqlDataReader lector;
            lector = insertar.ExecuteReader();

            if (lector.Read())
            {
                // Si existe una mesa reservada al telefono del cliente, por lo que podemos seguir adelante
                cogerIdMesa = lector[0].ToString();
                MessageBox.Show(cogerIdMesa);
            }
            else
            {
                // El cliente no tiene ninguna mesa reservada, por lo que no se sigue
                lector.Close();
                return false;
            }
            lector.Close();
            return true;
        }
        #endregion

        #region Boton de Borrar Reserva
        private void BtnBorrar_Click_1(object sender, EventArgs e)
        {
            String cogerFecha = DtpReserva.Value.ToString("yyyy/MM/dd");
            // Tambien necesitamos la hora de los numeric para comprobar tambien por hora y minutos si hay alguna reserva en esa mesa
            String cogerHoras = NucHora.Value.ToString();
            String cogerMinutos = NucMinuto.Value.ToString();
            String horasMinutosFormateado = cogerHoras + ":" + cogerMinutos + ":00";

            if (Comprobar_ExisteMesa_AsocTelefono())
            {
                MessageBox.Show("ENTRA EN EL IF");

                String sqlDelete = "DELETE FROM Reservas WHERE Fecha = '" + cogerFecha + "' AND Hora = '" + horasMinutosFormateado + "' AND TelefonoCliente = '" + TxtTelefono.Texts + "' AND IdMesa = " + cogerIdMesa;

                MessageBox.Show(sqlDelete);

                comando = ConexionBD.CreateCommand();
                comando.CommandText = sqlDelete;

                comando.ExecuteNonQuery();

                // Después de eliminar la reserva hay que ponerle que la mesa sea LIBRE de nuevo para volver a poder reservar
                update = ConexionBD.CreateCommand();
                update.CommandText = "UPDATE Mesas SET Estado='Libre', NumeroComensales=null  WHERE IdMesa=" + cogerIdMesa;
                update.ExecuteNonQuery();

                MessageBox.Show("Se ha eliminado correctamente el registro", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No hay reservadas a tus parámetros de búsqueda, lo siento", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
        #endregion

        #region Que pasa cuando se cierre este Form
        private void FrmDetallesReserva_FormClosing(object sender, FormClosingEventArgs e)
        {
            //ConexionBD.Close();
        }
        #endregion
    }
}