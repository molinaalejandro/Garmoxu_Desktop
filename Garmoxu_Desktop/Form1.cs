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

namespace Garmoxu_Desktop
{
    public partial class Form1 : Form
    {
        private int borderSize = 2;
        private Size formSize;

        public Form1()
        {
            InitializeComponent();
            CollapseMenu();
            this.Padding = new Padding(borderSize);
            hideSubMenu();
            //this.BackColor = Color.FromArgb(98,102,244);
        }

        #region funcinamiento de arrastre del form
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
        private void Form1_Resize(object sender, EventArgs e)
        {
            AdjustForm();

            //Cambia el icono del buton btnResize
            if (this.WindowState == FormWindowState.Normal)
                btnResize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            else
                btnResize.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;

            ;
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

        #region Botones superiores esquina derecha
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

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

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region Collapse/Expand Menu Lateral
        private void btnPanel_Click(object sender, EventArgs e)
        {
            CollapseMenu();
        }

        private void CollapseMenu()
        {
            if (pnlLateral.Width > 200) //colapsa el menu lateral
            {
                pnlLateral.Width = 100;
                pictureBox1.Visible = false;
                btnPanel.Dock = DockStyle.Top;
                foreach (Button b in pnlLateral.Controls.OfType<Button>())
                {
                    b.Text = String.Empty;
                    b.ImageAlign = ContentAlignment.MiddleCenter;
                    b.Padding = new Padding(0);
                }
            }
            else //expande el menu lateral
            {
                pnlLateral.Width = 201;
                pictureBox1.Visible = true;
                btnPanel.Dock = DockStyle.None;
                foreach (Button b in pnlLateral.Controls.OfType<Button>())
                {
                    b.Text = "   " + b.Tag.ToString();
                    b.ImageAlign = ContentAlignment.MiddleCenter;
                    b.Padding = new Padding(10, 0, 0, 0);
                }
            }
        }

        #endregion

        #region Cambio de Color en general de Nocturno a Claro
        private void iconButton5_Click(object sender, EventArgs e)
        {
            foreach (Control c in Controls)
                cambiarColorGeneral(c);
        }

        private void cambiarColorGeneral(Control c)
        {
            pnlTitle.BackColor = Color.FromArgb(239, 239, 241);
            pnlLateral.BackColor = Color.FromArgb(239, 239, 241);
            pnlMain.BackColor = Color.FromArgb(255, 255, 255);

            if (c is Label) c.ForeColor = Color.FromArgb(6, 95, 212);
            else if (c is FontAwesome.Sharp.IconButton)
                foreach (FontAwesome.Sharp.IconButton ib in pnlLateral.Controls.OfType<FontAwesome.Sharp.IconButton>())
                {
                    ib.IconColor = Color.FromArgb(6, 95, 212);
                }

            foreach (Control subC in c.Controls)
                cambiarColorGeneral(subC);
        }
        #endregion


        private void iconButton_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlSubMenu);
        }

        private void hideSubMenu()
        {
            pnlSubMenu.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Form2());
        }

        private void AbrirFormHija(object formhija)
        {
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.pnlMain.Controls.Add(fh);
            this.pnlMain.Tag = fh;
            fh.Show();
        }

        private void RJBtnPruebas_Click(object sender, EventArgs e)
        {
            FrmInicioSesion frmInicioSesion = new FrmInicioSesion();
            frmInicioSesion.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            materialTabControl1.SelectedIndex = 1;
        }

        private void rjTextBox2_KeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show("a");
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show("b");
        }

        //https://youtu.be/0XOeXDpHueI?t=916
        //https://www.youtube.com/watch?v=p-QrdRD_H_o
        //https://i.pinimg.com/originals/c5/ce/c2/c5cec29073f1d47451973d24fed3188b.jpg
    }
}