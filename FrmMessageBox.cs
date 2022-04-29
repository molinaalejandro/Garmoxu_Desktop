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

namespace Garmoxu_Project
{
    public partial class FrmMessageBox : Form
    {
        // Resultado que retornará automaticamente cuando se cierre la ventana.
        private static DialogResult Result;

        private MySqlConnection ConexionBD;

        private static string UsuarioActual;

        public FrmMessageBox()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
        }

        #region Dialogos
        public static DialogResult ShowMe(string mensaje, string titulo, int button, IconChar icon)
        {
            System.Media.SystemSounds.Exclamation.Play();
            FrmMessageBox frm = new FrmMessageBox();
            frm.LblText.Text = mensaje;
            if (string.IsNullOrEmpty(titulo.Trim())) frm.LblTitle.Visible = false;
            else frm.LblTitle.Text = titulo;
            frm.TabOpc.SelectedIndex = 0;
            frm.BtnIcon.IconChar = icon;
            frm.CambiarColorIconos();
            frm.SetConfigButtons(button);

            frm.Height -= frm.ClientSize.Height / 4;
            frm.BringToFront();
            frm.ShowDialog();

            return Result;
        }
        #endregion

        #region Password
        public static DialogResult ShowMePassword(string usuarioActual, MySqlConnection conexionBD)
        {
            FrmMessageBox frm = new FrmMessageBox();
            frm.TopMost = false;
            frm.Text = "Cambiar contraseña";
            frm.LblTitle.Text = "Cambiar contraseña";
            frm.TabOpc.SelectedIndex = 1;
            frm.BtnIcon.IconChar = IconNone();
            frm.BtnIcon.Visible = false;
            frm.SetConfigButtons(FrmMessageBox.ButtonYesCancel());
            UsuarioActual = usuarioActual;
            frm.ConexionBD = conexionBD;

            frm.BringToFront();
            frm.ShowDialog();

            return Result;
        }

        #region Cambiar contraseña
        private bool AceptarPassword()
        {
            if (!string.IsNullOrEmpty(UsuarioActual))
            {
                if (ValidarDatosCompletados() && ValidarContraseñasCoincidentes()
                    && ValidarFormatoContraseñas() && ValidarContraseñaActual())
                {
                    CambiarContraseña();
                    string user = UsuarioActual;
                    UsuarioActual = string.Empty;
                    string mensaje = "¡Operación concluida con éxito!";
                    FrmMessageBox.ShowMe(mensaje, "", FrmMessageBox.ButtonYes(), FrmMessageBox.IconInfo());
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
            string sql = string.Format(
                "UPDATE Usuarios SET Contraseña = '{0}', RestablecerContraseña = 0 WHERE NombreUsuario = '{1}'",
                contraseñaEncriptada, UsuarioActual);
            MySqlCommand cmd = new MySqlCommand(sql, ConexionBD);
            cmd.ExecuteNonQuery();
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
            FrmMessageBox.ShowMe(mensaje, "", FrmMessageBox.ButtonYes(), FrmMessageBox.IconWarning());
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
            FrmMessageBox.ShowMe(mensaje, "", FrmMessageBox.ButtonYes(), FrmMessageBox.IconWarning());
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
                FrmMessageBox.ShowMe(mensaje, "", FrmMessageBox.ButtonYes(), FrmMessageBox.IconWarning());
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
            FrmMessageBox.ShowMe(mensaje, "", FrmMessageBox.ButtonYes(), FrmMessageBox.IconWarning());
            UsuarioActual = user;
            return false;
        }

        private bool ValidarContraseñaActual()
        {
            string contraseñaEncriptada = EncriptarContraseña(TxtOldPassword.Texts);

            string sql = string.Format(
                "SELECT * FROM Usuarios WHERE NombreUsuario = '{0}' AND Contraseña = '{1}'",
                UsuarioActual, contraseñaEncriptada);
            MySqlCommand cmd = new MySqlCommand(sql, ConexionBD);
            if(cmd.ExecuteScalar() != null)
                return true;

            string user = UsuarioActual;
            UsuarioActual = string.Empty;
            string mensaje = "¡La contraseña antigüa es incorrecta!";
            FrmMessageBox.ShowMe(mensaje, "", FrmMessageBox.ButtonYes(), FrmMessageBox.IconWarning());
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
            RJTextBox txt = sender as RJTextBox;
            IconButton btn = IdentificarTipoBoton(txt);

            string hint = IdentificarTipoHint(txt);
            if (txt.Texts.Trim().ToString().Equals(hint))
            {
                txt.Texts = string.Empty;
                txt.PasswordChar = true;
                btn.IconChar = IconChar.EyeSlash;
                btn.IconColor = Color.Gray;
            }
        }

        private void TxtPassword_Leave(object sender, EventArgs e)
        {
            RJTextBox txt = sender as RJTextBox;
            IconButton btn = IdentificarTipoBoton(txt);

            string hint = IdentificarTipoHint(txt);
            if (txt.Texts.Trim().Equals(string.Empty))
            {
                txt.Texts = hint;
                txt.PasswordChar = false;
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

        #region Mostrar contraseña
        // Al hacer click en el IconButton mostrará/ocultará la contraseña que se ha puesto en el TextBox.
        private void FABtnPassword_Click(object sender, EventArgs e)
        {
            IconButton btn = sender as IconButton;
            RJTextBox txt = IdentificarTipoTextBox(sender, btn);
            if (txt.PasswordChar)
            {
                txt.PasswordChar = false;
                btn.IconChar = IconChar.Eye;
                btn.IconColor = Color.MediumSlateBlue;
            }
            else if (!txt.Texts.Equals(IdentificarTipoHint(txt)))
            {
                txt.PasswordChar = true;
                btn.IconChar = IconChar.EyeSlash;
                btn.IconColor = Color.Gray;
            }
        }

        private RJTextBox IdentificarTipoTextBox(object sender, IconButton btn)
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
                btn.IconColor = Color.MediumSlateBlue;
        }
        #endregion
        #endregion

        #region Botones
        public static int ButtonYes() { return 0; }
        public static int ButtonYesNo() { return 1; }
        public static int ButtonYesCancel() { return 2; }
        public static int ButtonYesNoCancel() { return 3; }

        private void SetConfigButtons(int id)
        {
            switch (id)
            {
                case 0:
                    BtnYes.Text = "Aceptar";
                    PnlButton.Controls.Add(BtnYes, 2, 0);
                    break;

                case 1:
                    BtnNo.Visible = true;

                    PnlButton.Controls.Add(BtnYes, 1, 0);
                    PnlButton.Controls.Add(BtnNo, 3, 0);
                    break;

                case 2:
                    BtnYes.Text = "Aceptar";
                    BtnCancel.Visible = true;

                    PnlButton.Controls.Add(BtnYes, 1, 0);
                    PnlButton.Controls.Add(BtnCancel, 3, 0);
                    break;

                case 3:
                    BtnNo.Visible = true;
                    BtnCancel.Visible = true;
                    break;
            }
        }

        private void BtnYes_Click(object sender, EventArgs e)
        {
            if (AceptarPassword())
            {
                Result = DialogResult.Yes;
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
        public static FontAwesome.Sharp.IconChar IconNone() { return FontAwesome.Sharp.IconChar.None; }
        public static FontAwesome.Sharp.IconChar IconInfo() { return FontAwesome.Sharp.IconChar.InfoCircle; }
        public static FontAwesome.Sharp.IconChar IconError() { return FontAwesome.Sharp.IconChar.TimesCircle; }
        public static FontAwesome.Sharp.IconChar IconWarning() { return FontAwesome.Sharp.IconChar.ExclamationTriangle; }
        public static FontAwesome.Sharp.IconChar IconQuestion() { return FontAwesome.Sharp.IconChar.QuestionCircle; }

        private void CambiarColorIconos()
        {
            switch (BtnIcon.IconChar)
            {
                case IconChar.InfoCircle:
                    BtnIcon.IconColor = Color.RoyalBlue;
                    break;

                case IconChar.TimesCircle:
                    BtnIcon.IconColor = Color.Red;
                    break;

                case IconChar.ExclamationTriangle:
                    BtnIcon.IconColor = Color.FromArgb(255, 235, 0);
                    break;

                case IconChar.QuestionCircle:
                    BtnIcon.IconColor = Color.RoyalBlue;
                    break;
            }
        }
        #endregion
    }
}
