using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Garmoxu_Desktop.MessageBoxPersonalizado;

namespace Garmoxu_Desktop
{
    class ConexionMySql
    {
        // Conexión local
        //private const string SERVIDOR = "localhost"; // Nombre o IP del servidor.
        //private const string BD = "garmoxu"; // Nombre de la base de datos.
        //private const string USUARIO = "root"; // Usuario de acceso.
        //private const string PASSWORD = "root"; // Contraseña de usuario de acceso.

        // Conexión remota
        private const string SERVIDOR = "sql781.main-hosting.eu"; // Nombre o IP del servidor.
        private const string BD = "u184120704_garmoxudb"; // Nombre de la base de datos.
        private const string USUARIO = "u184120704_admindam"; // Usuario de acceso.
        private const string PASSWORD = "damAdmin123"; // Contraseña de usuario de acceso.

        // Instancia de la conexión a la base de datos.
        private static MySqlConnection Conexion = new MySqlConnection(
                "Database=" + BD + "; Data Source=" + SERVIDOR + "; User Id=" + USUARIO + "; Password=" + PASSWORD + ";");

        public static MySqlDataReader EjecutarConsulta(string sql)
        {
            try
            {
                Conexion.Open();
                MySqlCommand cmd = new MySqlCommand(sql, Conexion);
                MySqlDataReader reader = cmd.ExecuteReader();
                //Conexion.Close();
                return reader;
            }
            catch (AggregateException ex)
            {
                string mensaje = "No se ha podido establecer la conexión al servidor, revise su conexión a internet y el estado del servidor.";
                if (ShowRetryDialog(mensaje, "").Equals(DialogResult.Retry)) Application.Restart();
                else Environment.Exit(0);
            }
            catch (Exception ex)
            {
                string mensaje = "No se ha podido conectar al servidor debido al siguiente error de tipo '" + ex.GetType().Name + "' : \n" + ex.Message;
                if (ShowRetryDialog(mensaje, "").Equals(DialogResult.Retry)) Application.Restart();
                else Environment.Exit(0);
            }
            if (Conexion.State.Equals(ConnectionState.Open)) Conexion.Close();
            return null;
        }        
        
        public static string EjecutarScalar(string sql)
        {
            try
            {
                Conexion.Open();
                MySqlCommand cmd = new MySqlCommand(sql, Conexion);
                if (cmd.ExecuteScalar() == null) 
                {
                    Conexion.Close();
                    return string.Empty;
                }
                else
                {
                    string scalar = cmd.ExecuteScalar().ToString();
                    Conexion.Close();
                    return scalar;
                }
            }
            catch (AggregateException ex)
            {
                string mensaje = "No se ha podido establecer la conexión al servidor, revise su conexión a internet y el estado del servidor.";
                if (ShowRetryDialog(mensaje, "").Equals(DialogResult.Retry)) Application.Restart();
                else Environment.Exit(0);
            }
            catch (Exception ex)
            {
                string mensaje = "No se ha podido conectar al servidor debido al siguiente error de tipo '" + ex.GetType().Name + "' : \n" + ex.Message;
                if (ShowRetryDialog(mensaje, "").Equals(DialogResult.Retry)) Application.Restart();
                else Environment.Exit(0);
            }
            if (Conexion.State.Equals(ConnectionState.Open)) Conexion.Close();
            return null;
        }

        public static bool EjecutarSentencia(string sql)
        {
            try
            {
                Conexion.Open();
                MySqlCommand cmd = new MySqlCommand(sql, Conexion);
                int filasAfectadas = cmd.ExecuteNonQuery();
                Conexion.Close();
                return filasAfectadas < 1 ? false : true;
            }
            catch (AggregateException ex)
            {
                string mensaje = "No se ha podido establecer la conexión al servidor, revise su conexión a internet y el estado del servidor.";
                if (ShowRetryDialog(mensaje, "").Equals(DialogResult.Retry)) Application.Restart();
                else Environment.Exit(0);
            }
            catch (Exception ex)
            {
                string mensaje = "No se ha podido conectar al servidor debido al siguiente error de tipo '" + ex.GetType().Name + "' : \n" + ex.Message;
                if (ShowRetryDialog(mensaje, "").Equals(DialogResult.Retry)) Application.Restart();
                else Environment.Exit(0);
            }
            if (Conexion.State.Equals(ConnectionState.Open)) Conexion.Close();
            return false;
        }        
        
        public static bool EjecutarSentencia(string sql, byte[] imagenBytes)
        {
            try
            {
                Conexion.Open();
                MySqlCommand cmd = new MySqlCommand(sql, Conexion);
                cmd.Parameters.Add("@imagen", MySqlDbType.MediumBlob).Value = imagenBytes;
                int filasAfectadas = cmd.ExecuteNonQuery();
                Conexion.Close();
                return filasAfectadas < 1 ? false : true;
            }
            catch (AggregateException ex)
            {
                string mensaje = "No se ha podido establecer la conexión al servidor, revise su conexión a internet y el estado del servidor.";
                if (ShowRetryDialog(mensaje, "").Equals(DialogResult.Retry)) Application.Restart();
                else Environment.Exit(0);
            }
            catch (Exception ex)
            {
                string mensaje = "No se ha podido conectar al servidor debido al siguiente error de tipo '" + ex.GetType().Name + "' : \n" + ex.Message;
                if (ShowRetryDialog(mensaje, "").Equals(DialogResult.Retry)) Application.Restart();
                else Environment.Exit(0);
            }
            if (Conexion.State.Equals(ConnectionState.Open)) Conexion.Close();
            return false;
        }

        public static DataSet RecogerTabla(string sql, string nombreTabla)
        {
            try
            {
                Conexion.Open();
                MySqlCommand cmd = new MySqlCommand(sql, Conexion);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds, nombreTabla);
                Conexion.Close();
                return ds;
            }
            catch (AggregateException ex)
            {
                string mensaje = "No se ha podido establecer la conexión al servidor, revise su conexión a internet y el estado del servidor.";
                if (ShowRetryDialog(mensaje, "").Equals(DialogResult.Retry)) Application.Restart();
                else Environment.Exit(0);
            }
            catch (Exception ex)
            {
                string mensaje = "No se ha podido conectar al servidor debido al siguiente error de tipo '" + ex.GetType().Name + "' : \n" + ex.Message;
                if (ShowRetryDialog(mensaje, "").Equals(DialogResult.Retry)) Application.Restart();
                else Environment.Exit(0);
            }
            if (Conexion.State.Equals(ConnectionState.Open)) Conexion.Close();
            return null;
        }
        
        public static void LlenarDataSet(string sql, string nombreTabla, ref DataSet ds)
        {
            try
            {
                Conexion.Open();
                MySqlCommand cmd = new MySqlCommand(sql, Conexion);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.FillAsync(ds, nombreTabla);
                Conexion.Close();
            }
            catch (AggregateException ex)
            {
                string mensaje = "No se ha podido establecer la conexión al servidor, revise su conexión a internet y el estado del servidor.";
                if (ShowRetryDialog(mensaje, "").Equals(DialogResult.Retry)) Application.Restart();
                else Environment.Exit(0);
            }
            catch (Exception ex)
            {
                string mensaje = "No se ha podido conectar al servidor debido al siguiente error de tipo '" + ex.GetType().Name + "' : \n" + ex.Message;
                if (ShowRetryDialog(mensaje, "").Equals(DialogResult.Retry)) Application.Restart();
                else Environment.Exit(0);
            }
            if (Conexion.State.Equals(ConnectionState.Open)) Conexion.Close();
        }

        public static void CerrarConexion()
        {
            if (Conexion.State.Equals(ConnectionState.Open)) Conexion.Close();
        }
    }
}
