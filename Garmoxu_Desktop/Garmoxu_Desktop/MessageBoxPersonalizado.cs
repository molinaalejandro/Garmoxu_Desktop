using FontAwesome.Sharp;
using MySql.Data.MySqlClient;
using RJCodeAdvance.RJControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Garmoxu_Desktop.ConexionMySql;

namespace Garmoxu_Desktop
{
    public partial class MessageBoxPersonalizado : Form
    {
        // Resultado que retornará automaticamente cuando se cierre la ventana.
        private static DialogResult Result;
        private static string UsuarioActual;

        public MessageBoxPersonalizado()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
        }

        #region Apertura del formulario
        private void MessageBoxPersonalizado_Shown(object sender, EventArgs e)
        {
            BtnYes.NotifyDefault(false);

            int borderRadius = TabOpc.SelectedIndex == 0 ? 5 : 15;

            BtnYes.BorderRadius = borderRadius;
            BtnNo.BorderRadius = borderRadius;
            BtnCancel.BorderRadius = borderRadius;
        }
        #endregion

        #region Funciones y diseño del formulario
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

                //cp.Style |= 0x00800000; // Borde simple fino
                cp.Style |= 0x00400000; // Borde 3D abajo y derecha
                // https://docs.microsoft.com/en-us/windows/win32/winmsg/window-styles

                //cp.ClassStyle |= 0x00020000; // Shadow border
                return cp;
            }
        }
        #endregion

        //#region Sombreado de pantalla
        //private void SombrearPantalla(ref Form frmShadow)
        //{
        //    frmShadow = new Form();
        //    frmShadow.ShowInTaskbar = false;
        //    frmShadow.Text = "";
        //    frmShadow.FormBorderStyle = FormBorderStyle.None;
        //    frmShadow.Size = Size;
        //    frmShadow.WindowState = FormWindowState.Maximized;
        //    frmShadow.BackColor = Color.Black;
        //    frmShadow.Opacity = 0.7;
        //    frmShadow.Location = Location;
        //    frmShadow.Enabled = false;
        //    frmShadow.TopMost = true;
        //    frmShadow.Show();
        //}
        //#endregion
        #endregion

        #region Funciones y diseños de controles
        private void Button_Enter(object sender, EventArgs e)
        {
            RJButton btn = ((RJButton)sender);
            btn.BorderSize = 2;
            //btn.Font = new Font(btn.Font, FontStyle.Underline | FontStyle.Bold ); 
        }

        private void Button_Leave(object sender, EventArgs e)
        {
            RJButton btn = ((RJButton)sender);
            btn.BorderSize = 0;
            //btn.Font = new Font(btn.Font, FontStyle.Bold);
        }
        #endregion

        #region Dialogos
        public static DialogResult ShowWarningMessage(string mensaje, string titulo)
        {
            return ShowMeDialog(mensaje, titulo, ButtonYes(), IconWarning());
        }

        public static DialogResult ShowErrorMessage(string mensaje, string titulo)
        {
            
            return ShowMeDialog(mensaje, titulo, ButtonYes(), IconError());
        }

        public static DialogResult ShowInfoMessage(string mensaje, string titulo)
        {
            return ShowMeDialog(mensaje, titulo, ButtonYes(), IconInfo());
        }

        public static DialogResult ShowQuestionDialog(string mensaje, string titulo)
        {
            return ShowMeDialog(mensaje, titulo, ButtonYesNo(), IconQuestion());
        }

        public static DialogResult ShowRetryDialog(string mensaje, string titulo)
        {
            return ShowMeDialog(mensaje, titulo, ButtonRetryCancel(), IconError());
        }

        public static DialogResult ShowMeDialog(string mensaje, string titulo, int button, IconChar icon)
        {
            
            MessageBoxPersonalizado frm = new MessageBoxPersonalizado();

            frm.LblText.Text = mensaje;
            if (string.IsNullOrEmpty(titulo.Trim())) frm.LblTitle.Visible = false;
            else frm.LblTitle.Text = titulo;

            frm.TabOpc.SelectedIndex = 0;
            frm.BtnIcon.IconChar = icon;
            frm.SetIconsConfig();
            frm.SetButtonsConfig(button);

            frm.SetHeight();
            frm.SetWidth();

            frm.BringToFront();
            frm.ShowDialog();

            return Result;
        }
        #endregion

        #region Password
        public static DialogResult ShowNewPasswordDialog(string usuarioActual)
        {
            MessageBoxPersonalizado frm = new MessageBoxPersonalizado();
            frm.Text = "Crea una nueva contraseña - Garmoxu Desktop";
            frm.Size = new Size(700, 550);
            frm.TopMost = false;
            frm.ShowInTaskbar = true;
            frm.LblTitle.Text = "Crea una nueva contraseña";
            frm.TabOpc.SelectedIndex = 1;
            frm.BtnIcon.IconChar = IconNone();
            frm.BtnIcon.Visible = false;
            frm.SetButtonsConfig(ButtonYesCancel());
            UsuarioActual = usuarioActual;

            frm.PnlTitleBar.Height = 72;

            frm.PnlTexto.Size = new Size(787, 340);
            frm.PnlTexto.Margin = new Padding(0, 0, 0, 0);
            frm.PnlTexto.RowStyles[0] = new RowStyle(SizeType.Absolute, 50f);
            frm.PnlTexto.RowStyles[1] = new RowStyle(SizeType.Percent, 100f);
            frm.PnlTexto.RowStyles[2] = new RowStyle(SizeType.Absolute, 30f);
            frm.PnlTexto.ColumnStyles[0] = new ColumnStyle(SizeType.Absolute, 70f);
            frm.PnlTexto.ColumnStyles[2] = new ColumnStyle(SizeType.Percent, 100f);
            frm.PnlTexto.ColumnStyles[3] = new ColumnStyle(SizeType.Absolute, 70f);

            frm.PnlBody.RowStyles[1] = new RowStyle(SizeType.AutoSize);
            frm.PnlBody.RowStyles[2] = new RowStyle(SizeType.Percent, 100f);

            frm.PnlButton.ColumnStyles[0] = new ColumnStyle(SizeType.Percent, 33f);
            frm.PnlButton.ColumnStyles[2] = new ColumnStyle(SizeType.Percent, 33f);
            frm.PnlButton.ColumnStyles[4] = new ColumnStyle(SizeType.Percent, 33f);
            frm.PnlButton.BackColor = Color.Transparent;
            frm.PnlButton.Margin = new Padding(0, 0, 0, 50);

            frm.PnlButton.Controls.Add(frm.BtnYes, 1, 0);
            frm.BtnYes.Font = new Font("Source Sans Pro", 16.2f, FontStyle.Bold);
            frm.BtnYes.Size = new Size(184, 60);
            frm.BtnYes.TabStop = false;
            frm.BtnYes.BackColor = Color.SeaGreen;
            frm.BtnYes.BorderRadius = 15;
            frm.BtnYes.Cursor = Cursors.Hand;
            frm.BtnYes.BorderColor = Color.Transparent;

            frm.PnlButton.Controls.Add(frm.BtnCancel, 3, 0);
            frm.BtnCancel.Font = new Font("Source Sans Pro", 16.2f, FontStyle.Bold);
            frm.BtnCancel.Size = new Size(184, 60);
            frm.BtnCancel.TabStop = false;
            frm.BtnCancel.BackColor = Color.Crimson;
            frm.BtnCancel.BorderRadius = 15;
            frm.BtnCancel.Cursor = Cursors.Hand;
            frm.BtnCancel.BorderColor = Color.Transparent;

            frm.LblTitle.Font = new Font("Source Sans Pro", 18, FontStyle.Bold);
            frm.BtnClose.Size = new Size(67, 72);

            frm.BringToFront();
            frm.ShowDialog();

            return Result;
        }

        #region Cambiar contraseña
        private void TextBoxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals((char)Keys.Enter))
            {
                e.Handled = true;
                BtnYes_Click(null, null);
            }
        }

        private bool AceptarPassword()
        {
            if (!string.IsNullOrEmpty(UsuarioActual) && TabOpc.SelectedIndex == 1)
            {
                if (ValidarDatosCompletados() && ValidarContraseñasCoincidentes() && ValidarFormatoContraseñas() 
                    && ValidarContraseñaActual() && ValidarContraseñaNoAntigua())
                {
                    CambiarContraseña();
                    string user = UsuarioActual;
                    UsuarioActual = string.Empty;
                    string mensaje = "¡Operación concluida con éxito!";
                    ShowMeDialog(mensaje, "", ButtonYes(), IconInfo());
                    UsuarioActual = user;
                    return true;
                }
                else return false;
            }
            else return true;
        }

        private void CambiarContraseña()
        {
            string contraseñaEncriptada = EncriptarContraseña(TxtNewPassword.Texts);
            string sql = string.Format("UPDATE Usuarios SET Contraseña = '{0}', RestablecerContraseña = 0 WHERE NombreUsuario = '{1}'",
                contraseñaEncriptada, UsuarioActual);
            EjecutarSentencia(sql);
        }

        #region Validaciones 
        private bool ValidarDatosCompletados()
        {
            if (!string.IsNullOrEmpty(TxtOldPassword.Texts.Trim()) && !TxtOldPassword.Texts.Equals("Contraseña actual")
                && !string.IsNullOrEmpty(TxtNewPassword.Texts.Trim()) && !TxtNewPassword.Texts.Equals("Nueva contraseña")
                && !string.IsNullOrEmpty(TxtConfirmPassword.Texts.Trim()) && !TxtConfirmPassword.Texts.Equals("Confirmar contraseña"))
                return true;

            string user = UsuarioActual;
            UsuarioActual = string.Empty;
            string mensaje = "¡Debes completar todos los campos! ";
            ShowMeDialog(mensaje, "", ButtonYes(), IconWarning());
            UsuarioActual = user;
            return false;
        }

        private bool ValidarContraseñasCoincidentes()
        {
            if (TxtNewPassword.Texts.Equals(TxtConfirmPassword.Texts))
                return true;

            string user = UsuarioActual;
            UsuarioActual = string.Empty;
            string mensaje = "¡Las contraseñas no coinciden! ";
            MessageBoxPersonalizado.ShowMeDialog(mensaje, "", ButtonYes(), IconWarning());
            UsuarioActual = user;
            return false;
        }

        private bool ValidarFormatoContraseñas()
        {
            string user;
            string mensaje;

            if (TxtNewPassword.Texts.Contains(" "))
            {
                user = UsuarioActual;
                UsuarioActual = string.Empty;
                mensaje = "¡La nueva contraseña no puede contener espacios en blanco!";
                ShowMeDialog(mensaje, "", ButtonYes(), IconWarning());
                UsuarioActual = user;
                return false;
            }

            Regex rgxNumero = new Regex(@"[0-9]+");
            Regex rgxMayuscula = new Regex(@"[A-Z]+");

            if (rgxNumero.IsMatch(TxtNewPassword.Texts) &&
                rgxMayuscula.IsMatch(TxtNewPassword.Texts) &&
                TxtNewPassword.Texts.Length > 7 &&
                TxtNewPassword.Texts.Length < 65)
                return true;

            user = UsuarioActual;
            UsuarioActual = string.Empty;
            mensaje = "¡La nueva contraseña debe tener entre 8 y 64 caracteres, contener un número y una letra mayúscula!";
            ShowMeDialog(mensaje, "", ButtonYes(), IconWarning());
            UsuarioActual = user;
            return false;
        }

        private bool ValidarContraseñaActual()
        {
            string contraseñaEncriptada = EncriptarContraseña(TxtOldPassword.Texts);

            string sql = string.Format("SELECT * FROM Usuarios WHERE NombreUsuario = '{0}' AND Contraseña = '{1}'",
                UsuarioActual, contraseñaEncriptada);
            if (string.IsNullOrEmpty(EjecutarScalar(sql))) return true;

            string user = UsuarioActual;
            UsuarioActual = string.Empty;
            string mensaje = "¡La contraseña antigüa es incorrecta!";
            ShowMeDialog(mensaje, "", ButtonYes(), IconWarning());
            UsuarioActual = user;
            return false;
        }

        private bool ValidarContraseñaNoAntigua()
        {
            string contraseñaEncriptada = EncriptarContraseña(TxtNewPassword.Texts);

            string sql = string.Format("SELECT * FROM Usuarios WHERE NombreUsuario = '{0}' AND Contraseña = '{1}'",
                UsuarioActual, contraseñaEncriptada);
            if (string.IsNullOrEmpty(EjecutarScalar(sql))) return true;

            string user = UsuarioActual;
            UsuarioActual = string.Empty;
            string mensaje = "¡No puedes utilizar la misma contraseña que ya tenías!";
            ShowMeDialog(mensaje, "", ButtonYes(), IconWarning());
            UsuarioActual = user;
            return false;
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
        #endregion
        #endregion

        #region Hint Password
        private void TxtPassword_Enter(object sender, EventArgs e)
        {
            //TxtConfirmPassword.PasswordChar = false;
            //TxtNewPassword.PasswordChar = false;
            //TxtOldPassword.PasswordChar = false;

            RJTextBox txt = sender as RJTextBox;
            IconButton btn = IdentificarTipoBoton(txt);

            string hint = IdentificarTipoHint(txt);
            if (txt.Texts.Trim().Equals(hint))
            {
                txt.ForeColor = Color.White;
                txt.Texts = string.Empty;
                if (btn.IconChar.Equals(IconChar.EyeSlash))
                    txt.PasswordChar = true;
            }
        }

        private void TxtPassword_Leave(object sender, EventArgs e)
        {
            RJTextBox txt = sender as RJTextBox;

            string hint = IdentificarTipoHint(txt);
            //if (string.IsNullOrEmpty(txt.Texts.Trim()) && !txt.Texts.Equals(txt.Tag))
            if (string.IsNullOrEmpty(txt.Texts.Trim()))
            {
                txt.ForeColor = Color.Gray;
                txt.Texts = hint;
                if (txt.PasswordChar) txt.PasswordChar = false;
                //if (txt.PasswordChar) txt.PasswordChar = false;
                //txt.Focus();
            }
        }

        private IconButton IdentificarTipoBoton(RJTextBox txt)
        {
            IconButton btn = new IconButton();
            switch (txt.Name)
            {
                case "TxtOldPassword":
                    btn = BtnOldPassword;
                    break;

                case "TxtNewPassword":
                    btn = BtnNewPassword;
                    break;

                case "TxtConfirmPassword":
                    btn = BtnConfirmPassword;
                    break;
            }
            return btn;
        }

        private string IdentificarTipoHint(RJTextBox txt)
        {
            string hint = string.Empty;
            switch (txt.Name.ToString())
            {
                case "TxtOldPassword":
                    hint = "Contraseña actual";
                    break;

                case "TxtNewPassword":
                    hint = "Nueva contraseña";
                    break;

                case "TxtConfirmPassword":
                    hint = "Confirmar contraseña";
                    break;
            }
            return hint;
        }
        #endregion

        #region Funcionalidades y diseños de controles de contraseña
        // Al hacer click en el IconButton mostrará/ocultará la contraseña que se ha puesto en el TextBox.
        private void FABtnPassword_Click(object sender, EventArgs e)
        {
            IconButton btn = sender as IconButton;
            RJTextBox txt = IdentificarTipoTextBox(btn);

            if (btn.IconChar.Equals(IconChar.EyeSlash))
            {
                btn.IconChar = IconChar.Eye;
                btn.IconColor = Color.FromArgb(110, 110, 255);
                txt.PasswordChar = false;
            }
            else
            {
                btn.IconChar = IconChar.EyeSlash;
                btn.IconColor = Color.Gray;
                if (!txt.Texts.Equals(txt.Tag.ToString()))
                    txt.PasswordChar = true;
            }
        }

        private RJTextBox IdentificarTipoTextBox(IconButton btn)
        {
            RJTextBox txt = new RJTextBox();
            switch (btn.Name)
            {
                case "BtnOldPassword":
                    txt = TxtOldPassword;
                    break;

                case "BtnNewPassword":
                    txt = TxtNewPassword;
                    break;

                case "BtnConfirmPassword":
                    txt = TxtConfirmPassword;
                    break;
            }
            return txt;
        }

        // Cambia de color cuando el raton está encima del Button.
        private void FABtnPassword_MouseEnter(object sender, EventArgs e)
        {
            IconButton btn = sender as IconButton;
            btn.IconColor = Color.FromArgb(171, 159, 244);
        }

        // Cambia de color cuando el raton deja de estar encima del Button.
        private void FABtnPassword_MouseLeave(object sender, EventArgs e)
        {
            IconButton btn = sender as IconButton;
            if (btn.IconChar.Equals(IconChar.EyeSlash))
                btn.IconColor = Color.Gray;
            else
                btn.IconColor = Color.FromArgb(110, 110, 255);
        }
        #endregion
        #endregion

        #region Botones
        public static int ButtonYes() { return 0; }
        public static int ButtonYesNo() { return 1; }
        public static int ButtonYesCancel() { return 2; }
        public static int ButtonYesNoCancel() { return 3; }
        public static int ButtonRetryCancel() { return 4; }

        private void SetButtonsConfig(int id)
        {
            switch (id)
            {
                case 0:
                    BtnYes.Text = "Aceptar";
                    break;

                case 1:
                    BtnNo.Visible = true;
                    break;

                case 2:
                    BtnYes.Text = "Aceptar";
                    BtnCancel.Visible = true;
                    break;

                case 3:
                    BtnNo.Visible = true;
                    BtnCancel.Visible = true;
                    break;

                case 4:
                    BtnYes.Text = "Reintentar";
                    BtnCancel.Visible = true;
                    break;
            }
        }

        private void BtnYes_Click(object sender, EventArgs e)
        {
            if (AceptarPassword())
            {
                if (BtnYes.Text.Equals("Reintentar")) Result = DialogResult.Retry;
                else Result = DialogResult.Yes;
                this.Close();
            }
        }

        private void BtnNo_Click(object sender, EventArgs e)
        {
            Result = DialogResult.No;
            this.Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Result = DialogResult.Cancel;
            this.Close();
        }
        #endregion

        #region Iconos 
        public static IconChar IconNone() { return IconChar.None; }
        public static IconChar IconInfo() { return IconChar.InfoCircle; }
        public static IconChar IconError() { return IconChar.TimesCircle; }
        public static IconChar IconWarning() { return IconChar.ExclamationTriangle; }
        public static IconChar IconQuestion() { return IconChar.QuestionCircle; }

        private void SetIconsConfig()
        {
            switch (BtnIcon.IconChar)
            {
                case IconChar.InfoCircle:
                    BtnIcon.IconColor = Color.DeepSkyBlue;
                    System.Media.SystemSounds.Exclamation.Play();
                    break;

                case IconChar.TimesCircle:
                    BtnIcon.IconColor = Color.FromArgb(255, 70, 70);
                    BtnIcon.IconFont = IconFont.Solid;
                    System.Media.SystemSounds.Exclamation.Play();
                    break;

                case IconChar.ExclamationTriangle:
                    BtnIcon.IconColor = Color.FromArgb(255, 235, 0);
                    System.Media.SystemSounds.Exclamation.Play();
                    break;

                case IconChar.QuestionCircle:
                    BtnIcon.IconColor = Color.DeepSkyBlue;
                    break;
            }
        }
        #endregion

        #region Set size
        public void SetWidth()
        {
            TabOpc.Width = LblText.Width;

            int buttonsWidth =
                (BtnCancel.Visible ? BtnCancel.Size.Width : 0) +
                (BtnYes.Visible ? BtnYes.Size.Width : 0) +
                (BtnNo.Visible ? BtnNo.Size.Width : 0);

            int textWidth = TabOpc.Width + 100 + BtnIcon.Width;
            int result = buttonsWidth > textWidth ? buttonsWidth : textWidth;
            this.Width = result;
        }

        public void SetHeight()
        {
            int textoHeight = LblText.Height > BtnIcon.Height ? LblText.Height : BtnIcon.Height;

            int result = textoHeight + BtnYes.Height + 100 + PnlTitleBar.Height;
            this.Height = result;
        }
        #endregion

        #region Cierre del formulario
        private void BtnClose_Click(object sender, EventArgs e)
        {
            Result = DialogResult.None;
            this.Close();
        }
        #endregion
    }
}
