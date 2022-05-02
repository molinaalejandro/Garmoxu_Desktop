using FontAwesome.Sharp;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.util;
using System.Windows.Forms;

namespace Garmoxu_Project
{
    public partial class FrmInicioSesion : Form
    {
        // Instancia de la conexión a la base de datos.
        private MySqlConnection ConexionBD;

        // Usuario actual con el que está logeado.
        private string UsuarioActual;

        public FrmInicioSesion()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            AbrirConexionBD();
            CargarUsuarioRecordado();


            TbxPassword.Text = "1234abcd";
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
            ConexionBD = new MySqlConnection(
                "Database=" + bd + "; Data Source=" + servidor + "; User Id=" + usuario + "; Password=" + password + ";");

            // Abre la BD y captura sus posibles errores.
            try
            {
                ConexionBD.Open();
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

        #region Carga de usuario recordado
        // Carga el último usuario que se ha querido recordar siempre que el fichero existe
        // y el usuario no esté vacio.
        private void CargarUsuarioRecordado()
        {
            try
            {
                string ruta = "Usuario_Recordado.txt";
                if (File.Exists(ruta))
                {
                    string usuarioRecordado = File.ReadAllText(ruta);
                    if (!string.IsNullOrEmpty(usuarioRecordado))
                    {
                        TbxUser.Text = usuarioRecordado;
                        TbxPassword.Focus();
                        ChkRemember.Checked = true;
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        #endregion

        private void FrmInicioSesion_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible)
                UsuarioActual = string.Empty;
        }
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
                //cp.ExStyle = 0x00000200; // Borde 3D arriba e izquierda
                //cp.ExStyle = 0x00000001; // Borde 3D abajo y derecha
                // https://docs.microsoft.com/en-us/windows/win32/winmsg/extended-window-styles

                cp.Style |= 0x00800000; // Borde simple fino
                // https://docs.microsoft.com/en-us/windows/win32/winmsg/window-styles

                //cp.ClassStyle |= 0x00020000; // Shadow border
                return cp;
            }
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
            if (TbxUser.Text.Equals("Nombre de usuario")) TbxUser.Text = String.Empty;
        }

        //Tras dejar el textbox en vacio e ir a otro control dejara por defecto la parabra, funciona como un hint en Android xml
        private void TbxUser_Leave(object sender, EventArgs e)
        {
            if (TbxUser.Text.Equals(String.Empty)) TbxUser.Text = "Nombre de usuario";
        }

        // Al hacer click en el botón verifica si existe el usuario, de ser así, cambia de color.
        private void FABtnPerfil_Click(object sender, EventArgs e)
        {
            ValidarUsuarioExistente();
        }

        private bool ValidarUsuarioExistente()
        {
            string sql = "SELECT * FROM Usuarios WHERE NombreUsuario = '" + TbxUser.Text + "'";
            MySqlCommand cmd = new MySqlCommand(sql, ConexionBD);
            bool usuarioEncontrado = cmd.ExecuteScalar() != null;
            if (usuarioEncontrado)
            {
                BtnPerfil.IconColor = Color.Green;
                LblUser.ForeColor = Color.Green;
                return true;
            }
            else
            {
                BtnPerfil.IconColor = Color.Red;
                LblUser.ForeColor = Color.Red;
                return false;
            }
        }

        //Cambia de color cuando el raton esta encima del Buton
        private void FABtnPerfil_MouseEnter(object sender, EventArgs e)
        {
            if (!BtnPerfil.IconColor.Equals(Color.Red) && !BtnPerfil.IconColor.Equals(Color.Green))
            {
                BtnPerfil.FlatAppearance.MouseOverBackColor = Color.Transparent;
                BtnPerfil.FlatAppearance.MouseDownBackColor = Color.Transparent;
                BtnPerfil.IconColor = Color.FromArgb(171, 159, 244);
            }
            //else
            //    BtnPerfil.IconColor = Color.IndianRed;
        }

        //Cambia de color cuando el raton deja de estar encima del Buton
        private void FABtnPerfil_MouseLeave(object sender, EventArgs e)
        {
            if (!BtnPerfil.IconColor.Equals(Color.Red) && !BtnPerfil.IconColor.Equals(Color.Green))
                BtnPerfil.IconColor = Color.MediumSlateBlue;
        }

        private void TbxUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TbxPassword.Focus();
                if (ValidarUsuarioExistente())
                {
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                }
            }
        }
        #endregion

        #region Contraseña
        // Al hacer click en el iconButton mostrar/ocultara la contraseña que se ha puesto en el textbox.
        private void BtnPassword_Click(object sender, EventArgs e)
        {
            if (BtnPassword.IconChar.Equals(IconChar.EyeSlash))
            {
                BtnPassword.IconChar = IconChar.Eye;
                BtnPassword.IconColor = Color.MediumSlateBlue;
                TbxPassword.UseSystemPasswordChar = false;
            }
            else
            {
                BtnPassword.IconChar = IconChar.EyeSlash;
                BtnPassword.IconColor = Color.Gray;
                if (!TbxPassword.Text.Equals("Contraseña"))
                    TbxPassword.UseSystemPasswordChar = true;
            }
        }

        // Cambia de color cuando el raton esta encima del Button.
        private void BtnPassword_MouseEnter(object sender, EventArgs e)
        {
            BtnPassword.IconColor = Color.FromArgb(171, 159, 244);
        }

        // Cambia de color cuando el raton deja de estar encima del Button.
        private void BtnPassword_MouseLeave(object sender, EventArgs e)
        {
            if (BtnPassword.IconChar.Equals(IconChar.EyeSlash))
                BtnPassword.IconColor = Color.Gray;
            else
                BtnPassword.IconColor = Color.MediumSlateBlue;
        }

        // Si el textbox esta en por defecto al acceder se eliminara el texto y lo pondra en modo contraseña,
        // funciona como un hint en Android xml
        private void TbxPassword_Enter(object sender, EventArgs e)
        {
            if (TbxPassword.Text.Equals("Contraseña"))
            {
                TbxPassword.Text = string.Empty;
                if (BtnPassword.IconChar.Equals(IconChar.EyeSlash))
                    TbxPassword.UseSystemPasswordChar = true;
            }
        }

        //Tras dejar el textbox en vacio e ir a otro control dejara por defecto la parabra, funciona como un hint en Android xml
        private void TbxPassword_Leave(object sender, EventArgs e)
        {
            if (TbxPassword.Text.Equals(string.Empty))
            {
                TbxPassword.Text = "Contraseña";
                TbxPassword.UseSystemPasswordChar = false;
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
            string contraseñaActual = TbxPassword.Text;

            string contraseñaActualEncriptada = EncriptarContraseña(contraseñaActual);

            string sql = "SELECT * FROM Usuarios WHERE NombreUsuario = '" + TbxUser.Text + "' " +
                "AND Contraseña = '" + contraseñaActualEncriptada + "'";
            MySqlCommand cmd = new MySqlCommand(sql, ConexionBD);
            if (cmd.ExecuteScalar() != null)
            {
                UsuarioActual = TbxUser.Text;
                RegistrarAcceso();
                RecordarUsuario();
                TbxPassword.Text = string.Empty;
                BtnPassword_Click(null, null);
                TbxPassword.Focus();
                this.Hide();
                CrearNuevaContraseña();
            }
            else
            {
                MessageBox.Show("¡Las credenciales introducidas no son correctas!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (!contraseñaActual.Equals("Contraseña")) TbxPassword.Text = string.Empty;
                if (TbxUser.Text.Equals("Nombre de usuario"))
                    TbxUser.Focus();
                else
                    TbxPassword.Focus();
            }
        }

        private string EncriptarContraseña(string contraseña)
        {
            SHA256 sha256 = SHA256Managed.Create();

            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] stream = null;
            StringBuilder sb = new StringBuilder();

            stream = sha256.ComputeHash(encoding.GetBytes(contraseña));

            for (int i = 0; i < stream.Length; i++)
                sb.AppendFormat("{0:x2}", stream[i]);

            return sb.ToString();
        }

        private void CrearNuevaContraseña()
        {
            string sql = "SELECT RestablecerContraseña FROM Usuarios WHERE NombreUsuario = '" + TbxUser.Text + "'";
            MySqlCommand cmd = new MySqlCommand(sql, ConexionBD);
            if (cmd.ExecuteScalar().ToString().Equals("True"))
            {
                if (FrmMessageBoxPersonalizado.ShowMePassword(TbxUser.Text, ConexionBD).Equals(DialogResult.Yes))
                {
                    FrmMain f = new FrmMain(ConexionBD, TbxUser.Text, RecogerNivelDePermisos(), RecogerImagenDelUsuario(), this);
                    f.Show();
                }
                else
                {
                    RegistrarCierreDeSesion();
                    this.Visible = true;
                }
            }
            else
            {
                FrmMain f = new FrmMain(ConexionBD, TbxUser.Text, RecogerNivelDePermisos(), RecogerImagenDelUsuario(), this);
                f.Show();
            }
        }

        private void RegistrarAcceso()
        {
            try
            {
                string ruta = "Accesos_Usuarios.csv";
                string contenidos = string.Format("{0};{1}", UsuarioActual, DateTime.Now.ToString());
                File.AppendAllText(ruta, contenidos);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void RecordarUsuario()
        {
            string ruta = "Usuario_Recordado.txt";
            if (ChkRemember.Checked)
                File.WriteAllText(ruta, UsuarioActual);
            else
                File.WriteAllText(ruta, string.Empty);
        }

        private int RecogerNivelDePermisos()
        {
            string sql = "SELECT NivelPermiso FROM TiposUsuarios WHERE IdTipoUsuario = " +
                "(SELECT IdTipoUsuario FROM Usuarios WHERE NombreUsuario = '" + UsuarioActual + "')";
            MySqlCommand cmd = new MySqlCommand(sql, ConexionBD);
            return int.Parse(cmd.ExecuteScalar().ToString());
        }

        private Image RecogerImagenDelUsuario()
        {
            string sql = "SELECT ImagenUsuario FROM Usuarios WHERE NombreUsuario = '" + UsuarioActual + "'";
            MySqlCommand cmd = new MySqlCommand(sql, ConexionBD);

            MySqlDataReader lector = cmd.ExecuteReader(CommandBehavior.SequentialAccess);

            int tamañoMaximoArchivo = 16000000;
            byte[] imagenBytes = new byte[tamañoMaximoArchivo];
            lector.Read();

            if (!lector[0].ToString().Equals(string.Empty))
            {
                lector.GetBytes(0, 0, imagenBytes, 0, tamañoMaximoArchivo);
                lector.Close();
                return (Bitmap)((new ImageConverter()).ConvertFrom(imagenBytes));
            }
            else
            {
                lector.Close();
                return null;
            }
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
            {
                CerrarConexionBD();
                RegistrarCierreDeSesion();
            }
            else
                e.Cancel = true;
        }

        // Cierra la conexión con la BD si está abierta.
        private void CerrarConexionBD()
        {
            if (ConexionBD.State.Equals(ConnectionState.Open))
                ConexionBD.Close();
        }

        // Registra el cierre de sesion en el fichero de accesos.
        private void RegistrarCierreDeSesion()
        {
            try
            {
                if (!string.IsNullOrEmpty(UsuarioActual))
                {
                    string ruta = "Accesos_Usuarios.csv";
                    if (File.Exists(ruta))
                        File.AppendAllText(ruta, ";" + DateTime.Now.ToString() + ";\n");
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        #endregion               
    }
}