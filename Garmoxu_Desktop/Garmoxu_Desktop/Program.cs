using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Garmoxu_Desktop.FrmMessageBoxPersonalizado;

namespace Garmoxu_Desktop
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FrmInicioSesion frm = new FrmInicioSesion();
            try
            {
                Application.Run(frm);
            }
            //catch (MySqlException ex) 
            //{
            //    string mensaje = "Se ha perdido la conexión con el servidor, revise su conexión a internet y el estado del servidor.";
            //    if (ShowRetryDialog(mensaje, "").Equals(DialogResult.Retry)) Application.Restart();
            //    else Environment.Exit(0);
            //}            
            catch (Exception ex) 
            {
                string mensaje = "Ha ocurrido el siguiente error de tipo " + ex.GetType() + ": \n" + ex.Message;
                if (ShowRetryDialog(mensaje, "").Equals(DialogResult.Retry)) Application.Restart();
                else Environment.Exit(0);
            }
        }
    }
}
