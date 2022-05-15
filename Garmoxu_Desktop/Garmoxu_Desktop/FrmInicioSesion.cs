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

namespace Garmoxu_Desktop
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
            //Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 150, 150));
            AbrirConexionBD();




            TxtContraseña.Texts = "1234abcd";
        }

        #region Apertura del formulario
        #region Conexion BD
        // Abre la conexion a la base de datos.
        private void AbrirConexionBD()
        {
            // Conexión local
            string servidor = "localhost"; //Nombre o IP del servidor.
            string bd = "garmoxu"; //Nombre de la base de datos.
            string usuario = "root"; //Usuario de acceso.
            string password = "root"; //Contraseña de usuario de acceso.

            // Conexión remota
            //string servidor = "sql781.main-hosting.eu"; //Nombre o IP del servidor.
            //string bd = "u184120704_garmoxudb"; //Nombre de la base de datos.
            //string usuario = "u184120704_admindam"; //Usuario de acceso.
            //string password = "damAdmin123"; //Contraseña de usuario de acceso.

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
        private void FrmInicioSesion_Shown(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(UsuarioActual))
                CargarUsuarioRecordado();
        }

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
                        TxtUsuario.Texts = usuarioRecordado;
                        //TxtContraseña.Focus();
                        TxtContraseña.Focus();
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
            this.CenterToScreen();
            if (BtnContraseña.IconChar.Equals(IconChar.Eye))
                BtnPassword_Click(null, null);
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

        #region Redondeado del formulario
        //[DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        //private static extern IntPtr CreateRoundRectRgn
        //(
        //    int nLeftRect,     // x-coordinate of upper-left corner
        //    int nTopRect,      // y-coordinate of upper-left corner
        //    int nRightRect,    // x-coordinate of lower-right corner
        //    int nBottomRect,   // y-coordinate of lower-right corner
        //    int nWidthEllipse, // width of ellipse
        //    int nHeightEllipse // height of ellipse
        //);
        #endregion

        #region Botones de Title Bar
        #region Boton de Cerrar
        //Salir de la aplicacion
        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        ////Cambia de color cuando el raton esta encima del boton
        //private void BtnClose_MouseEnter(object sender, EventArgs e)
        //{
        //    BtnClose.IconColor = Color.FromArgb(240, 41, 83);
        //    //FABtnClose.FlatAppearance.MouseDownBackColor = Color.Transparent;
        //    BtnClose.FlatAppearance.MouseOverBackColor = Color.Transparent;
        //}

        ////Cambia de color cuando el raton deja de estar encima del boton
        //private void BtnClose_MouseLeave(object sender, EventArgs e)
        //{
        //    BtnClose.IconColor = Color.White;
        //}
        #endregion

        #region Boton de Minimizar
        //Minimiza la aplicacion
        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        ////Cambia de color cuando el raton esta encima del boton
        //private void FABtnMinimize_MouseEnter(object sender, EventArgs e)
        //{
        //    BtnMinimize.IconColor = Color.MediumSlateBlue;
        //    //FABtnMinimize.FlatAppearance.MouseDownBackColor = Color.Transparent;
        //    BtnMinimize.FlatAppearance.MouseOverBackColor = Color.Transparent;
        //}

        ////Cambia de color cuando el raton deja de estar encima del boton
        //private void FABtnMinimize_MouseLeave(object sender, EventArgs e)
        //{
        //    BtnMinimize.IconColor = Color.White;
        //}
        #endregion
        #endregion
        #endregion

        #region Funciones y diseños de controles
        #region Check Box Recordar usuario
        private void ChkRemember_MouseEnter(object sender, EventArgs e)
        {
            LblRecordarUsuario.Tag = LblRecordarUsuario.ForeColor.Name;
            LblRecordarUsuario.ForeColor = ChkRemember.EnterColor;

            //ChkRemember.BorderColor = ChkRemember.EnterColor;
            //ChkRemember.ForeColor = ChkRemember.EnterColor;

            ChkRemember.Invalidate();
        }

        private void ChkRemember_MouseLeave(object sender, EventArgs e)
        {
            LblRecordarUsuario.ForeColor = Color.FromName(LblRecordarUsuario.Tag.ToString());

            //ChkRemember.ForeColor = ChkRemember.LeaveColor;
            //LblRecordarUsuario.ForeColor = ChkRemember.LeaveColor;
            //ChkRemember.BorderColor = ChkRemember.LeaveColor;

            ChkRemember.Invalidate();
        }
        #endregion
        #endregion

        #region Inicio de sesion
        #region Nombre de usuario
        //Si el textbox esta en por defecto al acceder se eliminara el texto, funciona como un hint en Android xml
        private void TxtUser_Enter(object sender, EventArgs e)
        {
            if (TxtUsuario.Texts.Equals("Nombre de usuario"))
            {
                TxtUsuario.ForeColor = Color.White;
                TxtUsuario.Texts = String.Empty;
            }
            if (string.IsNullOrEmpty(TxtContraseña.Texts) || TxtContraseña.Texts.Equals("Contraseña"))
                TxtContraseña.PasswordChar = false;
        }

        //Tras dejar el textbox en vacio e ir a otro control dejara por defecto la parabra, funciona como un hint en Android xml
        private void TxtUser_Leave(object sender, EventArgs e)
        {
            if (TxtUsuario.Texts.Equals(String.Empty))
            {
                TxtUsuario.ForeColor = Color.Gray;
                TxtUsuario.Texts = "Nombre de usuario";
            }
            else
                ValidarUsuarioExistente();
        }

        // Al hacer click en el botón verifica si existe el usuario, de ser así, cambia de color.
        private void BtnPerfil_Click(object sender, EventArgs e)
        {
            ValidarUsuarioExistente();
        }

        private bool ValidarUsuarioExistente()
        {
            string sql = "SELECT * FROM Usuarios WHERE NombreUsuario = '" + TxtUsuario.Texts + "'";
            MySqlCommand cmd = new MySqlCommand(sql, ConexionBD);
            bool usuarioEncontrado = cmd.ExecuteScalar() != null;
            if (usuarioEncontrado)
            {
                BtnUsuario.IconColor = Color.FromArgb(100, 200, 100);
                BtnUsuario.IconChar = IconChar.UserCheck;
                return true;
            }
            else
            {
                BtnUsuario.IconColor = Color.FromArgb(240, 83, 83);
                BtnUsuario.IconChar = IconChar.UserTimes;
                return false;
            }
        }

        //Cambia de color cuando el raton esta encima del Buton
        private void BtnPerfil_MouseEnter(object sender, EventArgs e)
        {
            if (BtnUsuario.IconColor.Equals(Color.FromArgb(110, 110, 255)))
                BtnUsuario.IconColor = Color.FromArgb(150, 150, 255);

            if (BtnUsuario.IconColor.Equals(Color.FromArgb(100, 200, 100)))
                BtnUsuario.IconColor = Color.FromArgb(140, 200, 140);

            if (BtnUsuario.IconColor.Equals(Color.FromArgb(240, 83, 83)))
                BtnUsuario.IconColor = Color.FromArgb(240, 123, 123);
        }

        //Cambia de color cuando el raton deja de estar encima del Buton
        private void BtnPerfil_MouseLeave(object sender, EventArgs e)
        {
            if (BtnUsuario.IconColor.Equals(Color.FromArgb(150, 150, 255)))
                BtnUsuario.IconColor = Color.FromArgb(110, 110, 255);

            if (BtnUsuario.IconColor.Equals(Color.FromArgb(140, 200, 140)))
                BtnUsuario.IconColor = Color.FromArgb(100, 200, 100);

            if (BtnUsuario.IconColor.Equals(Color.FromArgb(240, 123, 123)))
                BtnUsuario.IconColor = Color.FromArgb(240, 83, 83);
        }

        private void TxtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals((char)Keys.Enter))
                IniciarSesion();
        }
        #endregion

        #region Contraseña
        // Al hacer click en el iconButton mostrar/ocultara la contraseña que se ha puesto en el textbox.
        private void BtnPassword_Click(object sender, EventArgs e)
        {
            if (BtnContraseña.IconChar.Equals(IconChar.EyeSlash))
            {
                BtnContraseña.IconChar = IconChar.Eye;
                BtnContraseña.IconColor = Color.CornflowerBlue;
                TxtContraseña.PasswordChar = false;
            }
            else
            {
                BtnContraseña.IconChar = IconChar.EyeSlash;
                BtnContraseña.IconColor = Color.Gray;
                if (!TxtContraseña.Texts.Equals("Contraseña"))
                    TxtContraseña.PasswordChar = true;
            }
        }

        // Cambia de color cuando el raton esta encima del Button.
        private void BtnPassword_MouseEnter(object sender, EventArgs e)
        {
            BtnContraseña.IconColor = Color.FromArgb(171, 159, 244);
        }

        // Cambia de color cuando el raton deja de estar encima del Button.
        private void BtnPassword_MouseLeave(object sender, EventArgs e)
        {
            if (BtnContraseña.IconChar.Equals(IconChar.EyeSlash))
                BtnContraseña.IconColor = Color.Gray;
            else
                BtnContraseña.IconColor = Color.CornflowerBlue;
        }

        // Si el textbox esta en por defecto al acceder se eliminara el texto y lo pondra en modo contraseña,
        // funciona como un hint en Android xml
        private void TxtPassword_Enter(object sender, EventArgs e)
        {
            if (TxtContraseña.Texts.Equals("Contraseña"))
            {
                TxtContraseña.ForeColor = Color.White;
                TxtContraseña.Texts = string.Empty;
                if (BtnContraseña.IconChar.Equals(IconChar.EyeSlash))
                    TxtContraseña.PasswordChar = true;
            }
        }

        //Tras dejar el textbox en vacio e ir a otro control dejara por defecto la parabra, funciona como un hint en Android xml
        private void TxtPassword_Leave(object sender, EventArgs e)
        {
            if (TxtContraseña.Texts.Equals(string.Empty))
            {
                TxtContraseña.ForeColor = Color.Gray;
                TxtContraseña.Texts = "Contraseña";
                TxtUsuario.Focus();
                //TxtContraseña.PasswordChar = false;
            }
        }

        private void TxtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals((char)Keys.Enter))
                IniciarSesion();
        }
        #endregion

        #region Recordar usuario
        private void LblRecordarUsuario_Click(object sender, EventArgs e)
        {
            ChkRemember.Checked = !ChkRemember.Checked;
            ChkRemember.Invalidate();
        }
        #endregion

        #region Boton Inicio de sesion
        //Al hacer click al boton de iniciar activara el metodo de IniciarSesion
        private void BtnIniciar_Click(object sender, EventArgs e)
        {
            IniciarSesion();
        }

        private void IniciarSesion()
        {
            string contraseñaActual = TxtContraseña.Texts;

            string contraseñaActualEncriptada = EncriptarContraseña(contraseñaActual);

            string sql = "SELECT * FROM Usuarios WHERE NombreUsuario = '" + TxtUsuario.Texts + "' " +
                "AND Contraseña = '" + contraseñaActualEncriptada + "'";
            MySqlCommand cmd = new MySqlCommand(sql, ConexionBD);
            if (cmd.ExecuteScalar() != null)
            {
                UsuarioActual = TxtUsuario.Texts;
                RegistrarAcceso();
                RecordarUsuario();
                TxtContraseña.Texts = string.Empty;
                BtnPassword_Click(null, null);
                TxtContraseña.Focus();
                this.Hide();
                CrearNuevaContraseña();
            }
            else
            {
                MessageBox.Show("¡Las credenciales introducidas no son correctas!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (!contraseñaActual.Equals("Contraseña")) TxtContraseña.Texts = string.Empty;
                if (TxtUsuario.Texts.Equals("Nombre de usuario"))
                    TxtUsuario.Focus();
                else
                    TxtContraseña.Focus();
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
            string sql = "SELECT RestablecerContraseña FROM Usuarios WHERE NombreUsuario = '" + TxtUsuario.Texts + "'";
            MySqlCommand cmd = new MySqlCommand(sql, ConexionBD);
            if (cmd.ExecuteScalar().ToString().Equals("True"))
            {
                if (FrmMessageBoxPersonalizado.ShowMePassword(TxtUsuario.Texts, ConexionBD).Equals(DialogResult.Yes))
                {
                    FrmMain f = new FrmMain(ConexionBD, TxtUsuario.Texts, RecogerNivelDePermisos(), RecogerImagenDelUsuario(), this);
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
                FrmMain f = new FrmMain(ConexionBD, TxtUsuario.Texts, RecogerNivelDePermisos(), RecogerImagenDelUsuario(), this);
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
                return Properties.Resources.User_Default_Icon;
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