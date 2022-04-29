using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Garmoxu_Project
{
    public partial class FrmInicioSesion : Form
    {
        // Instancia de la conexión a la base de datos.
        private MySqlConnection conexionBD;

        public FrmInicioSesion()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            AbrirConexionBD();
        }

        #region Apertura del formulario
        #region Conexion BD
        // Abre la conexion a la base de datos.
        private void AbrirConexionBD()
        {
            string servidor = "localhost"; //Nombre o IP del servidor.
            string bd = "garmoxu"; //Nombre de la base de datos.
            string usuario = "root"; //Usuario de acceso.
            string password = "root"; //Contraseña de usuario de acceso.

            // Instancia de la conexión a la BD que recibe la cadena de conexión.
            conexionBD = new MySqlConnection(
                "Database=" + bd + "; Data Source=" + servidor + "; User Id=" + usuario + "; Password=" + password + ";");

            // Abre la BD y captura sus posibles errores.
            try
            {
                conexionBD.Open();
            }
            catch (Exception ex)
            {
                if (MessageBox.Show("No se ha podido conectar al servidor debido al siguiente error de tipo " + ex.GetType().Name + " : " + ex.Message,
                    "", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error).Equals(DialogResult.Retry))
                    AbrirConexionBD();
                else
                    Environment.Exit(0);
            }
        }
        #endregion
        #endregion

        #region Funciones y diseño del formulario
        #region Funcionamiento de arrastre del form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMassage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void pnlTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMassage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        #region Botones de Title Bar
        #region Boton de Cerrar
        //Salir de la aplicacion
        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Cambia de color cuando el raton esta encima del boton
        private void FABtnClose_MouseEnter(object sender, EventArgs e)
        {
            BtnClose.IconColor = Color.FromArgb(240, 41, 83);
            //FABtnClose.FlatAppearance.MouseDownBackColor = Color.Transparent;
            BtnClose.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        //Cambia de color cuando el raton deja de estar encima del boton
        private void FABtnClose_MouseLeave(object sender, EventArgs e)
        {
            BtnClose.IconColor = Color.White;
        }
        #endregion

        #region Boton de Minimizar
        //Minimiza la aplicacion
        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Cambia de color cuando el raton esta encima del boton
        private void FABtnMinimize_MouseEnter(object sender, EventArgs e)
        {
            BtnMinimize.IconColor = Color.MediumSlateBlue;
            //FABtnMinimize.FlatAppearance.MouseDownBackColor = Color.Transparent;
            BtnMinimize.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        //Cambia de color cuando el raton deja de estar encima del boton
        private void FABtnMinimize_MouseLeave(object sender, EventArgs e)
        {
            BtnMinimize.IconColor = Color.White;
        }
        #endregion
        #endregion
        #endregion

        #region Inicio de sesion
        #region Nombre de usuario
        //Si el textbox esta en por defecto al acceder se eliminara el texto, funciona como un hint en Android xml
        private void TbxUser_Enter(object sender, EventArgs e)
        {
            if (TbxUser.Text.ToString().Equals("Nombre de usuario")) TbxUser.Text = String.Empty;
        }

        //Tras dejar el textbox en vacio e ir a otro control dejara por defecto la parabra, funciona como un hint en Android xml
        private void TbxUser_Leave(object sender, EventArgs e)
        {
            if (TbxUser.Text.ToString().Equals(String.Empty)) TbxUser.Text = "Nombre de usuario";
        }

        private void FABtnPerfil_Click(object sender, EventArgs e)
        {
            //Al hacer click en el iconButton debera poder verificar si existe el usuario, en caso de existirlo el iconButton cambiara de color
        }

        //Cambia de color cuando el raton esta encima del Buton
        private void FABtnPerfil_MouseEnter(object sender, EventArgs e)
        {
            BtnPerfil.FlatAppearance.MouseOverBackColor = Color.Transparent;
            BtnPerfil.FlatAppearance.MouseDownBackColor = Color.Transparent;
            BtnPerfil.IconColor = Color.FromArgb(171, 159, 244);
        }

        //Cambia de color cuando el raton deja de estar encima del Buton
        private void FABtnPerfil_MouseLeave(object sender, EventArgs e)
        {
            BtnPerfil.IconColor = Color.MediumSlateBlue;
        }
        #endregion

        #region Contraseña
        // Al hacer click en el iconButton mostrar/ocultara la contraseña que se ha puesto en el textbox
        private void FABtnPassword_Click(object sender, EventArgs e)
        {
            if (TbxPassword.PasswordChar == '*')
            {
                TbxPassword.PasswordChar = '\0';
                BtnPassword.IconColor = Color.FromArgb(240, 41, 83);
            }
            else if (TbxPassword.PasswordChar == '\0')
            {
                TbxPassword.PasswordChar = '*';
                BtnPassword.IconColor = Color.MediumSlateBlue;
            }
        }

        //Cambia de color cuando el raton esta encima del Buton
        private void FABtnPassword_MouseEnter(object sender, EventArgs e)
        {
            BtnPassword.FlatAppearance.MouseOverBackColor = Color.Transparent;
            BtnPassword.FlatAppearance.MouseDownBackColor = Color.Transparent;
            BtnPassword.IconColor = Color.FromArgb(171, 159, 244);
        }

        //Cambia de color cuando el raton deja de estar encima del Buton
        private void FABtnPassword_MouseLeave(object sender, EventArgs e)
        {
            BtnPassword.IconColor = Color.MediumSlateBlue;
        }

        //Si el textbox esta en por defecto al acceder se eliminara el texto y lo pondra en modo contraseña, funciona como un hint en Android xml
        private void TbxPassword_Enter(object sender, EventArgs e)
        {
            if (TbxPassword.Text.ToString().Equals("Contraseña"))
            {
                TbxPassword.Text = String.Empty;
                TbxPassword.PasswordChar = '*';
            }
        }

        //Tras dejar el textbox en vacio e ir a otro control dejara por defecto la parabra, funciona como un hint en Android xml
        private void TbxPassword_Leave(object sender, EventArgs e)
        {
            if (TbxPassword.Text.ToString().Equals(String.Empty))
            {
                TbxPassword.PasswordChar = '\0';
                TbxPassword.Text = "Contraseña";
                BtnPassword.IconColor = Color.MediumSlateBlue;
            }
        }

        //Al introducir el Key.Enter iniciara el metodo de IniciarSesion
        private void TbxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) IniciarSesion();
        }
        #endregion

        #region Boton Inicio de sesion
        //Al hacer click al boton de iniciar activara el metodo de IniciarSesion
        private void RJBtnIniciar_Click(object sender, EventArgs e)
        {
            IniciarSesion();
        }

        private void IniciarSesion()
        {
            //Se encriptara y la contraseña para compararlo ya que en la bbdd la contraseña estara encriptada
            //tras ser verificado y en caso de ser incorrecto se mostrara con un mensaje y se borrara el textbox del password
            //si la verificacion es correcta se abrira el form principal

            TbxPassword.Text = String.Empty;
            //TbxUser.Text = String.Empty;
            this.Hide();
            FrmMain f = new FrmMain(conexionBD);
            f.Show();
        }
        #endregion
        #endregion

        #region Cierre del formulario
        // Cuando se cierre el formulario preguntará al usuario si desea salir de la aplicación,
        // de ser así, cierra la conexión con la BD.
        private void FrmInicioSesion_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Desea salir de la aplicación?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question).Equals(
                DialogResult.Yes))
                CerrarConexionBD();
            else
                e.Cancel = true;
        }

        // Cierra la conexión con la BD si está abierta.
        private void CerrarConexionBD()
        {
            if (conexionBD.State.Equals(ConnectionState.Open))
                conexionBD.Close();
        }
        #endregion

    }
}
