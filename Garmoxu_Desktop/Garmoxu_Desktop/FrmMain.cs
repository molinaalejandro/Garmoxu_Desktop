using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using FontAwesome.Sharp;
using RJCodeAdvance.RJControls;

namespace Garmoxu_Desktop
{
    public partial class FrmMain : Form
    {
        // Instancia de la conexión a la base de datos.
        private MySqlConnection ConexionBD;

        // Instancia de formulario main.
        private FrmMain Instance;

        // Instancia del formulario Inicio de sesión.
        private FrmInicioSesion InstanciaInicioSesion;

        // Usuario actual con el que se está logeado.
        private string UsuarioActual;

        // Nivel de permisos que tiene el usuario.
        private int NivelPermisos;

        // Imagen del usuario actual.
        private Image ImagenUsuario;

        private string NombreRestaurante;
        private string HoraApertura;
        private string HoraCierre;
        private bool ModoDiurno;
        private bool VentanaCompleta;
        private int IVA;

        public FrmMain(MySqlConnection conexionBD, string usuarioActual, int nivelPermisos, Image imagenUsuario, FrmInicioSesion instanciaInicioSesion)
        {
            InitializeComponent();
            CargarConfiguracion();
            if (VentanaCompleta)
                this.FormBorderStyle = FormBorderStyle.None;
            LblHora.Text = DateTime.Now.ToString("HH:mm");
            Instance = this;
            InstanciaInicioSesion = instanciaInicioSesion;
            ConexionBD = conexionBD;
            UsuarioActual = usuarioActual;
            NivelPermisos = nivelPermisos;
            ImagenUsuario = imagenUsuario;

            LimitarPermisos();
            CargarDatosUsuario();
        }

        #region Funciones y diseño del formulario
        #region Funcionamiento de arrastre del form
        //[DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        //private extern static void ReleaseCapture();

        //[DllImport("user32.DLL", EntryPoint = "SendMessage")]
        //private extern static void SendMassage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        //private void pnlTitle_MouseDown(object sender, MouseEventArgs e)
        //{
        //    ReleaseCapture();
        //    SendMassage(this.Handle, 0x112, 0xf012, 0);
        //}
        #endregion

        #region Eliminado de la title bar y reajustado manual de la ventana
        private Size formSize;
        protected override void WndProc(ref Message m)
        {
            const int WM_NCCALCSIZE = 0x0083; // Standar Title Bar - Snap Window
            //    const int WM_SYSCOMMAND = 0x0112;
            //    const int SC_MINIMIZE = 0xF020; // Minimize form (Before)
            //    const int SC_RESTORE = 0xF120; // Restore form (Before)
            //    const int WM_NCHITTEST = 0x0084; // Win32, Mouse Input Notification: Determine what part of the window corresponds to a point, allows to resize the form.
            //    const int resizeAreaSize = 10;

            //    #region Reajustado manual del tamaño del formulario
            //    //// Resize/WM_NCHITTEST values
            //    //const int HTCLIENT = 1; //Represents the client area of the window
            //    //const int HTLEFT = 10;  //Left border of a window, allows resize horizontally to the left
            //    //const int HTRIGHT = 11; //Right border of a window, allows resize horizontally to the right
            //    //const int HTTOP = 12;   //Upper-horizontal border of a window, allows resize vertically up
            //    //const int HTTOPLEFT = 13;//Upper-left corner of a window border, allows resize diagonally to the left
            //    //const int HTTOPRIGHT = 14;//Upper-right corner of a window border, allows resize diagonally to the right
            //    //const int HTBOTTOM = 15; //Lower-horizontal border of a window, allows resize vertically down
            //    //const int HTBOTTOMLEFT = 16;//Lower-left corner of a window border, allows resize diagonally to the left
            //    //const int HTBOTTOMRIGHT = 17;//Lower-right corner of a window border, allows resize diagonally to the right
            //    /////<Doc> More Information: https://docs.microsoft.com/en-us/windows/win32/inputdev/wm-nchittest </Doc>

            //    //if (m.Msg == WM_NCHITTEST)
            //    //{ //If the windows m is WM_NCHITTEST
            //    //    base.WndProc(ref m);
            //    //    if (this.WindowState == FormWindowState.Normal)//Resize the form if it is in normal state
            //    //    {
            //    //        if ((int)m.Result == HTCLIENT)//If the result of the m (mouse pointer) is in the client area of the window
            //    //        {
            //    //            Point screenPoint = new Point(m.LParam.ToInt32()); //Gets screen point coordinates(X and Y coordinate of the pointer)                           
            //    //            Point clientPoint = this.PointToClient(screenPoint); //Computes the location of the screen point into client coordinates                          
            //    //            if (clientPoint.Y <= resizeAreaSize)//If the pointer is at the top of the form (within the resize area- X coordinate)
            //    //            {
            //    //                if (clientPoint.X <= resizeAreaSize) //If the pointer is at the coordinate X=0 or less than the resizing area(X=10) in 
            //    //                    m.Result = (IntPtr)HTTOPLEFT; //Resize diagonally to the left
            //    //                else if (clientPoint.X < (this.Size.Width - resizeAreaSize))//If the pointer is at the coordinate X=11 or less than the width of the form(X=Form.Width-resizeArea)
            //    //                    m.Result = (IntPtr)HTTOP; //Resize vertically up
            //    //                else //Resize diagonally to the right
            //    //                    m.Result = (IntPtr)HTTOPRIGHT;
            //    //            }
            //    //            else if (clientPoint.Y <= (this.Size.Height - resizeAreaSize)) //If the pointer is inside the form at the Y coordinate(discounting the resize area size)
            //    //            {
            //    //                if (clientPoint.X <= resizeAreaSize)//Resize horizontally to the left
            //    //                    m.Result = (IntPtr)HTLEFT;
            //    //                else if (clientPoint.X > (this.Width - resizeAreaSize))//Resize horizontally to the right
            //    //                    m.Result = (IntPtr)HTRIGHT;
            //    //            }
            //    //            else
            //    //            {
            //    //                if (clientPoint.X <= resizeAreaSize)//Resize diagonally to the left
            //    //                    m.Result = (IntPtr)HTBOTTOMLEFT;
            //    //                else if (clientPoint.X < (this.Size.Width - resizeAreaSize)) //Resize vertically down
            //    //                    m.Result = (IntPtr)HTBOTTOM;
            //    //                else //Resize diagonally to the right
            //    //                    m.Result = (IntPtr)HTBOTTOMRIGHT;
            //    //            }
            //    //        }
            //    //    }
            //    //    return;
            //    //}
            //    #endregion

            //    #region Mantenido del tamaño al minizar
            //    ////Keep form size when it is minimized and restored. Since the form is resized because it takes into account the size of the title bar and borders.
            //    //if (m.Msg == WM_SYSCOMMAND)
            //    //{
            //    //    /// <see cref="https://docs.microsoft.com/en-us/windows/win32/menurc/wm-syscommand"/>
            //    //    /// Quote:
            //    //    /// In WM_SYSCOMMAND messages, the four low - order bits of the wParam parameter 
            //    //    /// are used internally by the system.To obtain the correct result when testing 
            //    //    /// the value of wParam, an application must combine the value 0xFFF0 with the 
            //    //    /// wParam value by using the bitwise AND operator.
            //    //    int wParam = (m.WParam.ToInt32() & 0xFFF0);
            //    //    if (wParam == SC_MINIMIZE)  //Before
            //    //        formSize = this.ClientSize;
            //    //    if (wParam == SC_RESTORE)// Restored form(Before)
            //    //        this.Size = formSize;
            //    //}
            //    #endregion

            //    #region Borrado del borde del formulario
            //    //Remove border and keep snap window
            if (!VentanaCompleta && m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
                return;
            //    #endregion

            base.WndProc(ref m);
        }
        #endregion

        #region Reajuste del formulario
        //private int borderSize = 2;
        //private void Form1_Resize(object sender, EventArgs e)
        //{
        //    AdjustForm();

        //    //Cambia el icono del buton btnResize
        //    if (this.WindowState == FormWindowState.Normal)
        //        BtnResize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
        //    else
        //        BtnResize.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
        //}

        //private void AdjustForm()
        //{
        //    switch (this.WindowState)
        //    {
        //        case FormWindowState.Maximized:
        //            this.Padding = new Padding(0, 8, 8, 0);
        //            break;
        //        case FormWindowState.Normal:
        //            if (this.Padding.Top != borderSize) this.Padding = new Padding(borderSize);
        //            break;
        //    }
        //}
        #endregion

        #region Botones Title Bar
        #region BtnMinimize
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion

        #region BtnResize
        private void btnResize_Click(object sender, EventArgs e)
        {
            //if (this.WindowState == FormWindowState.Normal)
            //{
            //    formSize = this.ClientSize;
            //    this.WindowState = FormWindowState.Maximized;
            //}
            //else
            //{
            //    this.WindowState = FormWindowState.Normal;
            //    this.Size = formSize;
            //}
        }
        #endregion

        #region BtnCerrar
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
        #endregion

        #region Cambios de enabled
        private void FrmMain_EnabledChanged(object sender, EventArgs e)
        {
            //IconButton[] botonesMenu = new IconButton[]
            //{
            //    BtnPedidos, BtnReservas, BtnHistorial, BtnPlatos,
            //    BtnCategorias, BtnClientes, BtnUsuarios, BtnAjustes
            //};

            //if (this.Enabled)
            //{
            //    foreach (IconButton boton in botonesMenu)
            //        boton.BackColor = Color.FromArgb(41, 42, 45);
            //}
            //else
            //{
            //    foreach (IconButton boton in botonesMenu)
            //        boton.BackColor = Color.Transparent;
            //}
        }
        #endregion
        #endregion

        #region Funciones y diseño de controles
        //private void BtnPanel_MouseEnter(object sender, EventArgs e)
        //{
        //    BtnPanel.IconColor = Color.White;
        //    BtnPanel.FlatAppearance.MouseOverBackColor = Color.Silver;
        //}

        //private void BtnPanel_MouseLeave(object sender, EventArgs e)
        //{
        //    BtnPanel.IconColor = Color.Silver;
        //    BtnPanel.FlatAppearance.MouseOverBackColor = Color.Transparent;
        //}
        #endregion

        #region Apertura del formulario
        #region Cargar configuración
        private void CargarConfiguracion()
        {
            NombreRestaurante = string.Empty;
            HoraApertura = "08:00";
            HoraCierre = "00:00";
            IVA = 10;
            VentanaCompleta = true;
            ModoDiurno = true;

            try
            {
                string ruta = @"Ajustes\ajustes.csv";
                if (File.Exists(ruta))
                {
                    string[] datosConfiguración = File.ReadAllText(ruta).Split(';');
                    NombreRestaurante = datosConfiguración[0];

                    string d1 = datosConfiguración[1];
                    if (!string.IsNullOrEmpty(d1)) HoraApertura = d1;

                    string d2 = datosConfiguración[2];
                    if (!string.IsNullOrEmpty(d2)) HoraCierre = d2;

                    string d3 = datosConfiguración[3];
                    if (!string.IsNullOrEmpty(d2)) IVA = int.Parse(d3);

                    string d4 = datosConfiguración[4];
                    if (!string.IsNullOrEmpty(d2)) VentanaCompleta = bool.Parse(d4);

                    string d5 = datosConfiguración[5];
                    if (!string.IsNullOrEmpty(d2)) ModoDiurno = bool.Parse(d5);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        #endregion

        #region Limitación de permisos
        private void LimitarPermisos()
        {
            if (NivelPermisos != 2)
                BtnUsuarios.Visible = false;

            if (NivelPermisos == 0)
            {
                BtnClientes.Visible = false;
                BtnCategorias.Visible = false;
                BtnPlatos.Visible = false;
            }
        }
        #endregion

        #region Cargar nombre de usuario
        private void CargarDatosUsuario()
        {
            CargarImagenUsuario();
            CargarNombreEmpleado();
        }

        private void CargarImagenUsuario()
        {
            byte[] imgUser = (byte[])(new ImageConverter()).ConvertTo(ImagenUsuario, typeof(byte[]));
            byte[] imgResources = (byte[])(new ImageConverter()).ConvertTo(Properties.Resources.User_Default_Icon, typeof(byte[]));

            if (BitConverter.ToString(imgUser).Equals(BitConverter.ToString(imgResources)))
            {
                PicUser.BorderSize = 0;
                PicUser.Tag = "NoBorder";
            }

            PicUser.Image = ImagenUsuario;
        }

        private void CargarNombreEmpleado()
        {
            string sql = "SELECT NombreEmpleado FROM Usuarios WHERE NombreUsuario = '" + UsuarioActual + "'";
            MySqlCommand cmd = new MySqlCommand(sql, ConexionBD);
            if (cmd.ExecuteScalar() != null)
            {
                string nombre = cmd.ExecuteScalar().ToString();

                int LONGITUDMAXIMA = 20;
                List<string> partesNombre = nombre.Split(' ').ToList();
                while (nombre.Length > LONGITUDMAXIMA)
                {
                    nombre = nombre.Remove(nombre.Length - partesNombre[partesNombre.Count - 1].Length);
                    if (nombre.Length < 1)
                    {
                        nombre = partesNombre[0];
                        nombre = nombre.Remove(LONGITUDMAXIMA - 1);
                        nombre += ".";
                    }
                    else
                        nombre = nombre.Remove(nombre.Length - 1);
                    partesNombre.RemoveAt(partesNombre.Count - 1);
                }
                LblUsuarioActual.Text = nombre;
            }
        }
        #endregion
        #endregion

        #region Menu lateral
        #region Ocultar o mostrar Menu Lateral
        private void BtnPanel_Click(object sender, EventArgs e)
        {
            if (PnlLateral.Width > 200) //colapsa el menu lateral
                OcultarMenuLateral();
            else
                MostrarMenuLateral(); //expande el menu lateral
        }

        private void OcultarMenuLateral()
        {
            PnlLateral.Width = 100;
            PnlCabeceraMenu.ColumnStyles[0].SizeType = SizeType.AutoSize;
            BtnPanel.IconChar = FontAwesome.Sharp.IconChar.ChevronRight;
            PicUser.Visible = false;
            LblUsuarioActual.Visible = false;
            BtnPanel.Dock = DockStyle.Top;
            foreach (Button b in PnlLateral.Controls.OfType<Button>())
            {
                b.TextImageRelation = TextImageRelation.ImageAboveText;
                b.Text = "";
                b.ImageAlign = ContentAlignment.MiddleCenter;
                b.Padding = new Padding(0);
            }
        }

        private void MostrarMenuLateral()
        {
            PnlLateral.Width = 250;
            PnlCabeceraMenu.ColumnStyles[0].SizeType = SizeType.Percent;
            BtnPanel.IconChar = FontAwesome.Sharp.IconChar.ChevronLeft;
            BtnPanel.Dock = DockStyle.Right;
            PicUser.Visible = true;
            LblUsuarioActual.Visible = true;
            foreach (Button b in PnlLateral.Controls.OfType<Button>())
            {
                b.TextImageRelation = TextImageRelation.ImageBeforeText;
                b.Text = b.Tag.ToString();
                b.ImageAlign = ContentAlignment.MiddleLeft;
                b.Padding = new Padding(20, 0, 0, 0);
            }
        }
        #endregion

        private void BtnPedidos_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmPedidos(ConexionBD, Instance, UsuarioActual, IVA));
        }

        private void BtnReservas_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmReservas(ConexionBD, Instance));
        }

        private void BtnHistorial_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmHistorialPedidos(ConexionBD, Instance, NivelPermisos));
        }

        //private void BtnHistorialPedidos_Click(object sender, EventArgs e)
        //{
        //    AbrirFormulario(new FrmHistorialPedidos(ConexionBD, Instance));
        //}

        //private void BtnEstadisticas_Click(object sender, EventArgs e)
        //{
        //    AbrirFormulario(new FrmEstadisticas());
        //}

        private void BtnPlatos_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmPlatos(ConexionBD, this, IVA));
        }

        private void BtnCliente_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmClientes(ConexionBD));
        }

        private void BtnCategoria_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmCategorias(ConexionBD, Instance));
        }

        private void BtnUsers_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmUsuarios(ConexionBD, this, UsuarioActual));
        }

        private void BtnAjustes_Click(object sender, EventArgs e)
        {
            FrmAjustes frmAjustes = new FrmAjustes(this, InstanciaInicioSesion, ConexionBD, UsuarioActual, ImagenUsuario,
                NivelPermisos, NombreRestaurante, HoraApertura, HoraCierre, IVA, VentanaCompleta, ModoDiurno, PnlTitle,
                PnlLateral, PnlMain);
            frmAjustes.TopLevel = false;
            PnlBody.Controls.Add(frmAjustes);
            frmAjustes.Dock = DockStyle.Fill;
            frmAjustes.BringToFront();
            frmAjustes.WindowState = FormWindowState.Maximized;
            frmAjustes.Show();
            PnlTitle.Visible = false;
            PnlLateral.Visible = false;
            PnlMain.Visible = false;
        }

        #region SubMenu del apartado Historial
        //private void BtnHistorial_Click(object sender, EventArgs e)
        //{
        //    showSubMenu(pnlSubMenu);
        //}

        //private void showSubMenu(Panel subMenu)
        //{
        //    if (subMenu.Visible == false)
        //    {
        //        subMenu.Visible = true;
        //    }
        //    else
        //        subMenu.Visible = false;
        //}
        #endregion

        // Recibe un formulario para comprobar si está abierto, de ser así, lo trae al frente.
        // En caso contrario, lo abre dentro del panel principal.
        private void AbrirFormulario(Form form)
        {
            LblSeccion.Text = form.Tag.ToString();
            //BtnCerrarSeccion.Enabled = true;
            BtnCerrarSeccion.Visible = true;
            //BtnCerrarSeccion.IconColor = Color.White;
            //BtnCerrarSeccion.Cursor = Cursors.Hand;

            Boolean encontrado = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.GetType().Equals(form.GetType()))
                {
                    encontrado = true;
                    f.Show();
                    f.BringToFront();
                }
            }

            if (!encontrado)
            {
                form.TopLevel = false;
                form.Dock = DockStyle.Fill;
                PnlMain.Controls.Add(form);
                form.Show();
                form.BringToFront();
            }
        }
        #endregion

        #region Asignacion de hora y fecha
        private void TmrRelojMain_Tick(object sender, EventArgs e)
        {
            LblHora.Text = DateTime.Now.ToString("HH:mm");
            LblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }
        #endregion

        #region Cierre de formularios
        private void BtnCerrarSeccion_Click(object sender, EventArgs e)
        {
            //if (!BtnCerrarSeccion.IconColor.Equals(Color.Silver))
            ((Form)PnlMain.Controls[0]).Close();
        }

        private void BtnCerrarSeccion_MouseEnter(object sender, EventArgs e)
        {
            //if (!BtnCerrarSeccion.IconColor.Equals(Color.Silver))
            //{
            BtnCerrarSeccion.IconColor = Color.FromArgb(255, 103, 103);
            //BtnCerrar.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            //}
        }

        private void BtnCerrarSeccion_MouseLeave(object sender, EventArgs e)
        {
            //if (!BtnCerrarSeccion.IconColor.Equals(Color.Silver))
            //{
            BtnCerrarSeccion.IconColor = Color.White;
            //BtnCerrar.IconChar = FontAwesome.Sharp.IconChar.DoorClosed;
            //}
        }

        private void PnlMain_ControlRemoved(object sender, ControlEventArgs e)
        {
            if (PnlMain.Controls.Count < 2)
            {
                LblSeccion.Text = this.Tag.ToString();
                //BtnCerrarSeccion.IconColor = Color.Silver;
                BtnCerrarSeccion.Visible = false;
                //BtnCerrar.IconChar = IconChar.DoorClosed;
                //BtnCerrarSeccion.Cursor = Cursors.Arrow;
            }
            else
                LblSeccion.Text = PnlMain.Controls[0].Tag.ToString();
        }
        #endregion

        #region Cierre de sesion
        private void PicUser_MouseEnter(object sender, EventArgs e)
        {
            PicUser.Image = Properties.Resources.Power_On_Off;
            PicUser.BorderSize = 0;
            PicUser.BackColor = Color.Transparent;
        }

        private void PicUser_MouseLeave(object sender, EventArgs e)
        {
            PicUser.Image = ImagenUsuario;
            if (PicUser.Tag == null)
                PicUser.BorderSize = 3;
            PicUser.BackColor = Color.FromArgb(130, 130, 255);
        }

        private void PicUser_Click(object sender, EventArgs e)
        {
            DialogResult cerrarSesion = MessageBox.Show("¿Desea cerrar la sesión actual?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cerrarSesion.Equals(DialogResult.Yes))
            {
                CerrarSesion();
                this.Close();
            }
        }

        private void CerrarSesion()
        {
            try
            {
                string ruta = "Accesos_Usuarios.csv";
                if (File.Exists(ruta))
                    File.AppendAllText(ruta, ";" + DateTime.Now.ToString() + ";\n");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

            InstanciaInicioSesion.Show();
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!InstanciaInicioSesion.Visible && PnlMain.Visible)
            {
                InstanciaInicioSesion.Close();

                // Solo ejecuta si la aplicación no se ha cerrado
                this.BringToFront();
                e.Cancel = true;
            }
            else if (!PnlMain.Visible)
                CerrarSesion();
        }
        #endregion
    }
}