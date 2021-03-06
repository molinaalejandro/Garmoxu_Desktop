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
using static Garmoxu_Desktop.MessageBoxPersonalizado;
using static Garmoxu_Desktop.ConexionMySql;

namespace Garmoxu_Desktop
{
    public partial class FrmMain : Form
    {
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

        public FrmMain(string usuarioActual, int nivelPermisos, Image imagenUsuario, FrmInicioSesion instanciaInicioSesion)
        {
            InitializeComponent();
            ConfigurarTamañoControles();
            CargarConfiguracion();
            if (VentanaCompleta)
            {
                this.FormBorderStyle = FormBorderStyle.None;
                PnlTitleBar.Padding = new Padding(20, 0, 5, 0);
                PnlBody.Padding = new Padding(0, 0, 5, 0);
            }            
            LblHora.Text = DateTime.Now.ToString("HH:mm");
            InstanciaInicioSesion = instanciaInicioSesion;
            UsuarioActual = usuarioActual;
            NivelPermisos = nivelPermisos;
            ImagenUsuario = imagenUsuario;

            LimitarPermisos();
            CargarDatosUsuario();
        }

        #region Funciones y diseño del formulario
        #region Eliminado de la title bar y reajustado manual de la ventana
        protected override void WndProc(ref Message m)
        {
            const int WM_NCCALCSIZE = 0x0083; // Standar Title Bar - Snap Window

            // Remove border and keep snap window
            if (!VentanaCompleta && m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
                return;

            base.WndProc(ref m);
        }
        #endregion

        #region Botones Title Bar
        #region BtnMinimize
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion

        #region BtnCerrar
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
        #endregion
        #endregion

        #region Funciones y diseños de controles
        #region Configuración de tamaño de controles
        private void ConfigurarTamañoControles()
        {
            //PnlTitleBar.Height = 90;
            //PnlCabeceraMenu.Height = 155;
            //PnlMenuLateral.Width = 250;
            //PicUsuario.Size = new Size(150, 150);
            //BtnEsconderMenu.Size = new Size(75, 150);
            //BtnPedidos.Height = 62;
            //BtnReservas.Height = 62;
            //BtnHistorial.Height = 62;
            //BtnPlatos.Height = 62;
            //BtnCategorias.Height = 62;
            //BtnClientes.Height = 62;
            //BtnUsuarios.Height = 62;
            //BtnAjustes.Height = 62;
            BtnPedidos.Font = new Font(BtnPedidos.Font.FontFamily, 13, BtnPedidos.Font.Style);
        }
        #endregion
        #endregion

        #region Apertura del formulario
        #region Cargar configuración
        private void CargarConfiguracion()
        {
            NombreRestaurante = "Garmoxu";
            HoraApertura = "08:00";
            HoraCierre = "23:59";
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
            catch (Exception ex) { ShowErrorMessage(ex.Message, ""); }
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
                PicUsuario.BorderSize = 0;
                PicUsuario.Tag = "NoBorder";
            }

            PicUsuario.Image = ImagenUsuario;
        }

        private void CargarNombreEmpleado()
        {
            string sql = "SELECT NombreEmpleado FROM Usuarios WHERE NombreUsuario = '" + UsuarioActual + "'";
            string nombre = EjecutarScalar(sql);
            if (!string.IsNullOrEmpty(nombre))
            {
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
        private void BtnEsconderMenu_Click(object sender, EventArgs e)
        {
            if (PnlMenuLateral.Width > 200) OcultarMenuLateral();
            else MostrarMenuLateral();
        }

        private void OcultarMenuLateral()
        {
            PnlMenuLateral.Width = 100;
            BtnEsconderMenu.IconChar = IconChar.ChevronRight;
            //BtnEsconderMenu.Dock = DockStyle.Top;
            PicUsuario.Visible = false;
            LblUsuarioActual.Visible = false;
            foreach (Button b in PnlMenuLateral.Controls.OfType<Button>())
            {
                b.Text = "";
                b.ImageAlign = ContentAlignment.MiddleCenter;
                b.Padding = new Padding(0);
            }
        }

        private void MostrarMenuLateral()
        {
            PnlMenuLateral.Width = 250;
            //PnlCabeceraMenu.ColumnStyles[0].SizeType = SizeType.Percent;
            BtnEsconderMenu.IconChar = FontAwesome.Sharp.IconChar.ChevronLeft;
            //BtnEsconderMenu.Dock = DockStyle.Right;
            PicUsuario.Visible = true;
            LblUsuarioActual.Visible = true;
            foreach (Button b in PnlMenuLateral.Controls.OfType<Button>())
            {
                //b.TextImageRelation = TextImageRelation.ImageBeforeText;
                b.Text = b.Tag.ToString();
                b.ImageAlign = ContentAlignment.MiddleLeft;
                b.Padding = new Padding(20, 0, 0, 0);
            }
        }
        #endregion

        private void BtnPedidos_Click(object sender, EventArgs e)
        {
            //AbrirFormulario(new FrmPedidos(UsuarioActual, IVA));
            AbrirFormulario(typeof(FrmPedidos), new object[] { UsuarioActual, IVA });
        }

        private void BtnReservas_Click(object sender, EventArgs e)
        {
            //AbrirFormulario(new FrmReservas(HoraApertura, HoraCierre, NivelPermisos));
            AbrirFormulario(typeof(FrmReservas), new object[] { HoraApertura, HoraCierre, NivelPermisos });
        }

        private void BtnHistorial_Click(object sender, EventArgs e)
        {
            //AbrirFormulario(new FrmHistorialPedidos(NivelPermisos, IVA));
            AbrirFormulario(typeof(FrmHistorialPedidos), new object[] { NivelPermisos, IVA });
        }

        private void BtnPlatos_Click(object sender, EventArgs e)
        {
            //AbrirFormulario(new FrmPlatos(IVA));
            AbrirFormulario(typeof(FrmPlatos), new object[] { IVA });
        }

        private void BtnCliente_Click(object sender, EventArgs e)
        {
            //AbrirFormulario(new FrmClientes());
            AbrirFormulario(typeof(FrmClientes), new object[] { });
        }

        private void BtnCategoria_Click(object sender, EventArgs e)
        {
            //AbrirFormulario(new FrmCategorias());
            AbrirFormulario(typeof(FrmCategorias), new object[] { });
        }

        private void BtnUsers_Click(object sender, EventArgs e)
        {
            //AbrirFormulario(new FrmUsuarios(UsuarioActual));
            AbrirFormulario(typeof(FrmUsuarios), new object[] { UsuarioActual });
        }

        private void BtnAjustes_Click(object sender, EventArgs e)
        {
            FrmAjustes frmAjustes = new FrmAjustes(this, InstanciaInicioSesion, PnlFormularios, UsuarioActual, ImagenUsuario,
                NivelPermisos, NombreRestaurante, HoraApertura, HoraCierre, IVA, VentanaCompleta, ModoDiurno);

            frmAjustes.TopLevel = false;
            PnlPrincipal.Controls.Add(frmAjustes);
            frmAjustes.Dock = DockStyle.Fill;
            frmAjustes.BringToFront();
            frmAjustes.WindowState = FormWindowState.Maximized;
            frmAjustes.Show();
        }

        // Recibe un formulario para comprobar si está abierto, de ser así, lo trae al frente.
        // En caso contrario, lo abre dentro del panel principal.
        private void AbrirFormulario(Type clase, object[] argumentos)
        {
            bool encontrado = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.GetType().Equals(clase))
                {
                    encontrado = true;
                    LblSeccion.Text = f.Tag.ToString();
                    BtnCerrarSeccion.Visible = true;
                    LblSeccion.Cursor = Cursors.Hand;
                    f.Show();
                    f.BringToFront();
                    return;
                }
            }

            if (!encontrado)
            {
                Form form;
                if (argumentos.Length != 0) form = (Form)Activator.CreateInstance(clase, argumentos);
                else form = (Form)Activator.CreateInstance(clase);

                LblSeccion.Text = form.Tag.ToString();
                BtnCerrarSeccion.Visible = true;
                LblSeccion.Cursor = Cursors.Hand;
                form.TopLevel = false;
                form.Dock = DockStyle.Fill;
                PnlFormularios.Controls.Add(form);
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
            if (BtnCerrarSeccion.Visible) ((Form)PnlFormularios.Controls[0]).Close();
        }

        private void BtnCerrarSeccion_MouseEnter(object sender, EventArgs e)
        {
            BtnCerrarSeccion.IconColor = Color.FromArgb(255, 103, 103);
        }

        private void BtnCerrarSeccion_MouseLeave(object sender, EventArgs e)
        {
            BtnCerrarSeccion.IconColor = Color.White;
        }

        private void PnlMain_ControlRemoved(object sender, ControlEventArgs e)
        {
            if (PnlFormularios.Controls.Count < 2)
            {
                LblSeccion.Text = this.Tag.ToString();
                BtnCerrarSeccion.Visible = false;
                LblSeccion.Cursor = Cursors.Arrow;
            }
            else LblSeccion.Text = PnlFormularios.Controls[0].Tag.ToString();
        }
        #endregion

        #region Cierre de sesion
        private void PicUser_MouseEnter(object sender, EventArgs e)
        {
            PicUsuario.Image = Properties.Resources.Power_On_Off;
            PicUsuario.BorderSize = 0;
            PicUsuario.BackColor = Color.Transparent;
        }

        private void PicUser_MouseLeave(object sender, EventArgs e)
        {
            PicUsuario.Image = ImagenUsuario;
            if (PicUsuario.Tag == null) PicUsuario.BorderSize = 3;
            PicUsuario.BackColor = Color.FromArgb(130, 130, 255);
        }

        private void PicUser_Click(object sender, EventArgs e)
        {
            if (ShowQuestionDialog("¿Desea cerrar la sesión actual?", "").Equals(DialogResult.Yes))
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
                if (File.Exists(ruta)) File.AppendAllText(ruta, ";" + DateTime.Now.ToString() + ";\n");
            }
            catch (Exception ex) { ShowErrorMessage(ex.Message, ""); }

            InstanciaInicioSesion.Show();
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!InstanciaInicioSesion.Visible && PnlFormularios.Visible)
            {
                InstanciaInicioSesion.Close();

                // Solo ejecuta si la aplicación no se ha cerrado
                this.BringToFront();
                e.Cancel = true;
            }
            else if (!PnlFormularios.Visible) CerrarSesion();
        }
        #endregion
    }
}