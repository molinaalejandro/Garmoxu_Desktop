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

        public FrmMain(MySqlConnection conexionBD, string usuarioActual, int nivelPermisos, Image imagenUsuario, FrmInicioSesion instanciaInicioSesion)
        {
            InitializeComponent();
            Instance = this;
            InstanciaInicioSesion = instanciaInicioSesion;
            ConexionBD = conexionBD;
            UsuarioActual = usuarioActual;
            NivelPermisos = nivelPermisos;
            ImagenUsuario = imagenUsuario;
            PicUser.Image = ImagenUsuario;
            MostrarMenuLateral();
        }

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

        #region Quitar la barra superior de la ventana con los botones(cerrar, reajustar y minimizar)(es normal que no tenga referencias) y poder reajustar manualmente la ventana
        private Size formSize;
        protected override void WndProc(ref Message m)
        {
            const int WM_NCCALCSIZE = 0x0083;//Standar Title Bar - Snap Window
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MINIMIZE = 0xF020; //Minimize form (Before)
            const int SC_RESTORE = 0xF120; //Restore form (Before)
            const int WM_NCHITTEST = 0x0084;//Win32, Mouse Input Notification: Determine what part of the window corresponds to a point, allows to resize the form.
            const int resizeAreaSize = 10;

            #region Form Resize
            // Resize/WM_NCHITTEST values
            const int HTCLIENT = 1; //Represents the client area of the window
            const int HTLEFT = 10;  //Left border of a window, allows resize horizontally to the left
            const int HTRIGHT = 11; //Right border of a window, allows resize horizontally to the right
            const int HTTOP = 12;   //Upper-horizontal border of a window, allows resize vertically up
            const int HTTOPLEFT = 13;//Upper-left corner of a window border, allows resize diagonally to the left
            const int HTTOPRIGHT = 14;//Upper-right corner of a window border, allows resize diagonally to the right
            const int HTBOTTOM = 15; //Lower-horizontal border of a window, allows resize vertically down
            const int HTBOTTOMLEFT = 16;//Lower-left corner of a window border, allows resize diagonally to the left
            const int HTBOTTOMRIGHT = 17;//Lower-right corner of a window border, allows resize diagonally to the right
            ///<Doc> More Information: https://docs.microsoft.com/en-us/windows/win32/inputdev/wm-nchittest </Doc>

            if (m.Msg == WM_NCHITTEST)
            { //If the windows m is WM_NCHITTEST
                base.WndProc(ref m);
                if (this.WindowState == FormWindowState.Normal)//Resize the form if it is in normal state
                {
                    if ((int)m.Result == HTCLIENT)//If the result of the m (mouse pointer) is in the client area of the window
                    {
                        Point screenPoint = new Point(m.LParam.ToInt32()); //Gets screen point coordinates(X and Y coordinate of the pointer)                           
                        Point clientPoint = this.PointToClient(screenPoint); //Computes the location of the screen point into client coordinates                          
                        if (clientPoint.Y <= resizeAreaSize)//If the pointer is at the top of the form (within the resize area- X coordinate)
                        {
                            if (clientPoint.X <= resizeAreaSize) //If the pointer is at the coordinate X=0 or less than the resizing area(X=10) in 
                                m.Result = (IntPtr)HTTOPLEFT; //Resize diagonally to the left
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize))//If the pointer is at the coordinate X=11 or less than the width of the form(X=Form.Width-resizeArea)
                                m.Result = (IntPtr)HTTOP; //Resize vertically up
                            else //Resize diagonally to the right
                                m.Result = (IntPtr)HTTOPRIGHT;
                        }
                        else if (clientPoint.Y <= (this.Size.Height - resizeAreaSize)) //If the pointer is inside the form at the Y coordinate(discounting the resize area size)
                        {
                            if (clientPoint.X <= resizeAreaSize)//Resize horizontally to the left
                                m.Result = (IntPtr)HTLEFT;
                            else if (clientPoint.X > (this.Width - resizeAreaSize))//Resize horizontally to the right
                                m.Result = (IntPtr)HTRIGHT;
                        }
                        else
                        {
                            if (clientPoint.X <= resizeAreaSize)//Resize diagonally to the left
                                m.Result = (IntPtr)HTBOTTOMLEFT;
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize)) //Resize vertically down
                                m.Result = (IntPtr)HTBOTTOM;
                            else //Resize diagonally to the right
                                m.Result = (IntPtr)HTBOTTOMRIGHT;
                        }
                    }
                }
                return;
            }
            #endregion

            //Remove border and keep snap window
            if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
            {
                return;
            }
            //Keep form size when it is minimized and restored. Since the form is resized because it takes into account the size of the title bar and borders.
            if (m.Msg == WM_SYSCOMMAND)
            {
                /// <see cref="https://docs.microsoft.com/en-us/windows/win32/menurc/wm-syscommand"/>
                /// Quote:
                /// In WM_SYSCOMMAND messages, the four low - order bits of the wParam parameter 
                /// are used internally by the system.To obtain the correct result when testing 
                /// the value of wParam, an application must combine the value 0xFFF0 with the 
                /// wParam value by using the bitwise AND operator.
                int wParam = (m.WParam.ToInt32() & 0xFFF0);
                if (wParam == SC_MINIMIZE)  //Before
                    formSize = this.ClientSize;
                if (wParam == SC_RESTORE)// Restored form(Before)
                    this.Size = formSize;
            }
            base.WndProc(ref m);
        }
        #endregion

        #region Funcionamiento de Re-Ajuste del form
        private int borderSize = 2;
        private void Form1_Resize(object sender, EventArgs e)
        {
            AdjustForm();

            //Cambia el icono del buton btnResize
            if (this.WindowState == FormWindowState.Normal)
                BtnResize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            else
                BtnResize.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
        }

        private void AdjustForm()
        {
            switch (this.WindowState)
            {
                case FormWindowState.Maximized:
                    this.Padding = new Padding(0, 8, 8, 0);
                    break;
                case FormWindowState.Normal:
                    if (this.Padding.Top != borderSize) this.Padding = new Padding(borderSize);
                    break;
            }
        }
        #endregion

        #region Botones Title Bar
        #region BtnMinimize
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnMinimize_MouseEnter(object sender, EventArgs e)
        {
            BtnMinimize.IconColor = Color.MediumSlateBlue;
            //FABtnMinimize.FlatAppearance.MouseDownBackColor = Color.Transparent;
            BtnMinimize.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        private void BtnMinimize_MouseLeave(object sender, EventArgs e)
        {
            BtnMinimize.IconColor = Color.White;
        }
        #endregion

        #region BtnResize
        private void btnResize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                formSize = this.ClientSize;
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                this.Size = formSize;
            }
        }

        private void BtnResize_MouseEnter(object sender, EventArgs e)
        {
            BtnResize.IconColor = Color.FromArgb(64, 196, 255);
            //BtnResize.FlatAppearance.MouseDownBackColor = Color.Transparent;
            BtnResize.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        private void BtnResize_MouseLeave(object sender, EventArgs e)
        {
            BtnResize.IconColor = Color.White;
        }
        #endregion

        #region BtnClose
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnClose_MouseEnter(object sender, EventArgs e)
        {
            BtnClose.IconColor = Color.FromArgb(240, 41, 83);
            //FABtnClose.FlatAppearance.MouseDownBackColor = Color.Transparent;
            BtnClose.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        private void BtnClose_MouseLeave(object sender, EventArgs e)
        {
            BtnClose.IconColor = Color.White;
        }
        #endregion
        #endregion
        #endregion

        #region Menu lateral
        #region Ocultar o mostrar Menu Lateral
        private void btnPanel_Click(object sender, EventArgs e)
        {
            OcultarMenuLateral();
        }

        private void OcultarMenuLateral()
        {
            if (PnlLateral.Width > 200) //colapsa el menu lateral
            {
                PnlLateral.Width = 100;
                PicUser.Visible = false;
                BtnPanel.Dock = DockStyle.Top;
                foreach (Button b in PnlLateral.Controls.OfType<Button>())
                {
                    b.TextImageRelation = TextImageRelation.ImageAboveText;
                    b.Text = " ";
                    b.ImageAlign = ContentAlignment.MiddleCenter;
                    b.Padding = new Padding(0);
                }
                foreach (Button b in pnlSubMenu.Controls.OfType<Button>())
                {
                    b.TextImageRelation = TextImageRelation.Overlay;
                    b.Text = " ";
                    b.ImageAlign = ContentAlignment.MiddleCenter;
                    b.Padding = new Padding(30, 0, 0, 0);
                }
            }
            else //expande el menu lateral
            {
                MostrarMenuLateral();
            }
        }

        private void MostrarMenuLateral()
        {
            PnlLateral.Width = 201;
            PicUser.Visible = true;
            BtnPanel.Dock = DockStyle.Right;
            foreach (Button b in PnlLateral.Controls.OfType<Button>())
            {
                b.TextImageRelation = TextImageRelation.ImageBeforeText;
                b.Text = "  " + b.Tag.ToString();
                b.ImageAlign = ContentAlignment.MiddleLeft;
                b.Padding = new Padding(20, 0, 0, 0);
            }
            foreach (Button b in pnlSubMenu.Controls.OfType<Button>())
            {
                b.TextImageRelation = TextImageRelation.ImageBeforeText;
                b.Text = " " + b.Tag.ToString();
                b.ImageAlign = ContentAlignment.MiddleLeft;
                b.TextAlign = ContentAlignment.MiddleLeft;
                b.Padding = new Padding(50, 0, 0, 0);
            }
        }
        #endregion

        private void BtnPedidos_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmPedidos(ConexionBD, Instance, UsuarioActual));
        }

        private void BtnReservas_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmReservas(ConexionBD, Instance));
        }

        private void BtnHistorialPedidos_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmHistorialPedidos(ConexionBD, Instance));
        }

        private void BtnEstadisticas_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmEstadisticas());
        }

        private void BtnPlatos_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmPlatos(ConexionBD, this));
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
            //AbrirFormulario(new FrmAjustes());
            FrmAjustes frmAjustes = new FrmAjustes();
            frmAjustes.TopLevel = false;
            frmAjustes.Dock = DockStyle.Fill;
            PnlBody.Controls.Add(frmAjustes);
            frmAjustes.Show();
            frmAjustes.BringToFront();
            PnlTitle.Visible = false;
            PnlLateral.Visible = false;
            PnlMain.Visible = false;
        }

        #region SubMenu del apartado Historial
        private void BtnHistorial_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlSubMenu);
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        #endregion

        // Recibe un formulario para comprobar si está abierto, de ser así, lo trae al frente.
        // En caso contrario, lo abre dentro del panel principal.
        private void AbrirFormulario(Form form)
        {
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

        private void BtnCerrarSesion_Click(object sender, EventArgs e)
        {
            DialogResult cerrarSesion = MessageBox.Show("¿Desea cerrar la sesión actual?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cerrarSesion.Equals(DialogResult.Yes))
            {
                try
                {
                    string ruta = "Accesos_Usuarios.csv";
                    if (File.Exists(ruta))
                        File.AppendAllText(ruta, ";" + DateTime.Now.ToString() + ";\n");
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }

                InstanciaInicioSesion.Show();
                this.Close();
            }
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!InstanciaInicioSesion.Visible)
            {
                InstanciaInicioSesion.Close();

                // Solo ejecuta si la aplicación no se ha cerrado
                this.BringToFront();
                e.Cancel = true;
            }
        }
    }
}