
namespace Garmoxu_Project
{
    partial class FrmMessageBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PnlBody = new System.Windows.Forms.TableLayoutPanel();
            this.PnlButton = new System.Windows.Forms.TableLayoutPanel();
            this.BtnYes = new RJCodeAdvance.RJControls.RJButton();
            this.BtnCancel = new RJCodeAdvance.RJControls.RJButton();
            this.BtnNo = new RJCodeAdvance.RJControls.RJButton();
            this.LblTitle = new System.Windows.Forms.Label();
            this.PnlIfo = new System.Windows.Forms.TableLayoutPanel();
            this.BtnIcon = new FontAwesome.Sharp.IconButton();
            this.TabOpc = new MaterialSkin.Controls.MaterialTabControl();
            this.TabInfo = new System.Windows.Forms.TabPage();
            this.PnlInfo = new System.Windows.Forms.TableLayoutPanel();
            this.LblText = new System.Windows.Forms.Label();
            this.TabPassword = new System.Windows.Forms.TabPage();
            this.PnlPassword = new System.Windows.Forms.TableLayoutPanel();
            this.TxtOldPassword = new RJCodeAdvance.RJControls.RJTextBox();
            this.TxtNewPassword = new RJCodeAdvance.RJControls.RJTextBox();
            this.TxtConfirmPassword = new RJCodeAdvance.RJControls.RJTextBox();
            this.BtnOldPassword = new FontAwesome.Sharp.IconButton();
            this.BtnConfirmPassword = new FontAwesome.Sharp.IconButton();
            this.BtnNewPassword = new FontAwesome.Sharp.IconButton();
            this.PnlBody.SuspendLayout();
            this.PnlButton.SuspendLayout();
            this.PnlIfo.SuspendLayout();
            this.TabOpc.SuspendLayout();
            this.TabInfo.SuspendLayout();
            this.PnlInfo.SuspendLayout();
            this.TabPassword.SuspendLayout();
            this.PnlPassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlBody
            // 
            this.PnlBody.ColumnCount = 1;
            this.PnlBody.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PnlBody.Controls.Add(this.PnlButton, 0, 2);
            this.PnlBody.Controls.Add(this.LblTitle, 0, 0);
            this.PnlBody.Controls.Add(this.PnlIfo, 0, 1);
            this.PnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlBody.Location = new System.Drawing.Point(0, 0);
            this.PnlBody.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PnlBody.Name = "PnlBody";
            this.PnlBody.RowCount = 3;
            this.PnlBody.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.PnlBody.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71.8232F));
            this.PnlBody.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.1768F));
            this.PnlBody.Size = new System.Drawing.Size(630, 313);
            this.PnlBody.TabIndex = 0;
            // 
            // PnlButton
            // 
            this.PnlButton.ColumnCount = 5;
            this.PnlButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.PnlButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.PnlButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.PnlButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.PnlButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.PnlButton.Controls.Add(this.BtnYes, 0, 0);
            this.PnlButton.Controls.Add(this.BtnCancel, 2, 0);
            this.PnlButton.Controls.Add(this.BtnNo, 4, 0);
            this.PnlButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlButton.Location = new System.Drawing.Point(3, 234);
            this.PnlButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PnlButton.Name = "PnlButton";
            this.PnlButton.RowCount = 1;
            this.PnlButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PnlButton.Size = new System.Drawing.Size(624, 77);
            this.PnlButton.TabIndex = 1;
            // 
            // BtnYes
            // 
            this.BtnYes.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnYes.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnYes.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnYes.BorderRadius = 0;
            this.BtnYes.BorderSize = 0;
            this.BtnYes.FlatAppearance.BorderSize = 0;
            this.BtnYes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnYes.ForeColor = System.Drawing.Color.White;
            this.BtnYes.Location = new System.Drawing.Point(15, 2);
            this.BtnYes.Margin = new System.Windows.Forms.Padding(15, 2, 15, 0);
            this.BtnYes.Name = "BtnYes";
            this.BtnYes.Size = new System.Drawing.Size(177, 53);
            this.BtnYes.TabIndex = 2;
            this.BtnYes.Text = "Si";
            this.BtnYes.TextColor = System.Drawing.Color.White;
            this.BtnYes.UseVisualStyleBackColor = false;
            this.BtnYes.Click += new System.EventHandler(this.BtnYes_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnCancel.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnCancel.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnCancel.BorderRadius = 0;
            this.BtnCancel.BorderSize = 0;
            this.BtnCancel.FlatAppearance.BorderSize = 0;
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.ForeColor = System.Drawing.Color.White;
            this.BtnCancel.Location = new System.Drawing.Point(222, 2);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(15, 2, 15, 0);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(178, 53);
            this.BtnCancel.TabIndex = 0;
            this.BtnCancel.Text = "Cancelar";
            this.BtnCancel.TextColor = System.Drawing.Color.White;
            this.BtnCancel.UseVisualStyleBackColor = false;
            this.BtnCancel.Visible = false;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnNo
            // 
            this.BtnNo.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnNo.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnNo.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnNo.BorderRadius = 0;
            this.BtnNo.BorderSize = 0;
            this.BtnNo.FlatAppearance.BorderSize = 0;
            this.BtnNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNo.ForeColor = System.Drawing.Color.White;
            this.BtnNo.Location = new System.Drawing.Point(430, 2);
            this.BtnNo.Margin = new System.Windows.Forms.Padding(15, 2, 15, 0);
            this.BtnNo.Name = "BtnNo";
            this.BtnNo.Size = new System.Drawing.Size(179, 53);
            this.BtnNo.TabIndex = 1;
            this.BtnNo.Text = "No";
            this.BtnNo.TextColor = System.Drawing.Color.White;
            this.BtnNo.UseVisualStyleBackColor = false;
            this.BtnNo.Visible = false;
            this.BtnNo.Click += new System.EventHandler(this.BtnNo_Click);
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.BackColor = System.Drawing.Color.Transparent;
            this.LblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LblTitle.Location = new System.Drawing.Point(3, 0);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(624, 29);
            this.LblTitle.TabIndex = 2;
            this.LblTitle.Text = "Title";
            this.LblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PnlIfo
            // 
            this.PnlIfo.ColumnCount = 2;
            this.PnlIfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.PnlIfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PnlIfo.Controls.Add(this.BtnIcon, 0, 0);
            this.PnlIfo.Controls.Add(this.TabOpc, 1, 0);
            this.PnlIfo.Location = new System.Drawing.Point(3, 31);
            this.PnlIfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PnlIfo.Name = "PnlIfo";
            this.PnlIfo.RowCount = 1;
            this.PnlIfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PnlIfo.Size = new System.Drawing.Size(624, 199);
            this.PnlIfo.TabIndex = 0;
            // 
            // BtnIcon
            // 
            this.BtnIcon.BackColor = System.Drawing.Color.Transparent;
            this.BtnIcon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnIcon.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnIcon.FlatAppearance.BorderSize = 0;
            this.BtnIcon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnIcon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIcon.IconChar = FontAwesome.Sharp.IconChar.ExclamationTriangle;
            this.BtnIcon.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(0)))));
            this.BtnIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnIcon.IconSize = 70;
            this.BtnIcon.Location = new System.Drawing.Point(30, 2);
            this.BtnIcon.Margin = new System.Windows.Forms.Padding(30, 2, 3, 2);
            this.BtnIcon.Name = "BtnIcon";
            this.BtnIcon.Size = new System.Drawing.Size(60, 195);
            this.BtnIcon.TabIndex = 3;
            this.BtnIcon.UseVisualStyleBackColor = false;
            // 
            // TabOpc
            // 
            this.TabOpc.Controls.Add(this.TabInfo);
            this.TabOpc.Controls.Add(this.TabPassword);
            this.TabOpc.Depth = 0;
            this.TabOpc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabOpc.Location = new System.Drawing.Point(97, 4);
            this.TabOpc.Margin = new System.Windows.Forms.Padding(4);
            this.TabOpc.MouseState = MaterialSkin.MouseState.HOVER;
            this.TabOpc.Name = "TabOpc";
            this.TabOpc.SelectedIndex = 0;
            this.TabOpc.Size = new System.Drawing.Size(523, 191);
            this.TabOpc.TabIndex = 1;
            // 
            // TabInfo
            // 
            this.TabInfo.Controls.Add(this.PnlInfo);
            this.TabInfo.Location = new System.Drawing.Point(4, 25);
            this.TabInfo.Margin = new System.Windows.Forms.Padding(4);
            this.TabInfo.Name = "TabInfo";
            this.TabInfo.Padding = new System.Windows.Forms.Padding(4);
            this.TabInfo.Size = new System.Drawing.Size(515, 162);
            this.TabInfo.TabIndex = 0;
            this.TabInfo.Text = "Info";
            this.TabInfo.UseVisualStyleBackColor = true;
            // 
            // PnlInfo
            // 
            this.PnlInfo.ColumnCount = 1;
            this.PnlInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PnlInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.PnlInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.PnlInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.PnlInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.PnlInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.PnlInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.PnlInfo.Controls.Add(this.LblText, 0, 0);
            this.PnlInfo.Location = new System.Drawing.Point(4, 4);
            this.PnlInfo.Margin = new System.Windows.Forms.Padding(4);
            this.PnlInfo.Name = "PnlInfo";
            this.PnlInfo.RowCount = 1;
            this.PnlInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PnlInfo.Size = new System.Drawing.Size(507, 154);
            this.PnlInfo.TabIndex = 0;
            // 
            // LblText
            // 
            this.LblText.AutoSize = true;
            this.LblText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblText.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblText.Location = new System.Drawing.Point(3, 0);
            this.LblText.Name = "LblText";
            this.LblText.Size = new System.Drawing.Size(501, 154);
            this.LblText.TabIndex = 10;
            this.LblText.Text = "Texto";
            this.LblText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TabPassword
            // 
            this.TabPassword.Controls.Add(this.PnlPassword);
            this.TabPassword.Location = new System.Drawing.Point(4, 25);
            this.TabPassword.Margin = new System.Windows.Forms.Padding(4);
            this.TabPassword.Name = "TabPassword";
            this.TabPassword.Padding = new System.Windows.Forms.Padding(4);
            this.TabPassword.Size = new System.Drawing.Size(515, 162);
            this.TabPassword.TabIndex = 1;
            this.TabPassword.Text = "Password";
            this.TabPassword.UseVisualStyleBackColor = true;
            // 
            // PnlPassword
            // 
            this.PnlPassword.ColumnCount = 2;
            this.PnlPassword.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PnlPassword.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.PnlPassword.Controls.Add(this.TxtOldPassword, 0, 0);
            this.PnlPassword.Controls.Add(this.TxtNewPassword, 0, 1);
            this.PnlPassword.Controls.Add(this.TxtConfirmPassword, 0, 2);
            this.PnlPassword.Controls.Add(this.BtnOldPassword, 1, 0);
            this.PnlPassword.Controls.Add(this.BtnConfirmPassword, 1, 2);
            this.PnlPassword.Controls.Add(this.BtnNewPassword, 1, 1);
            this.PnlPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlPassword.Location = new System.Drawing.Point(4, 4);
            this.PnlPassword.Margin = new System.Windows.Forms.Padding(4);
            this.PnlPassword.Name = "PnlPassword";
            this.PnlPassword.RowCount = 3;
            this.PnlPassword.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.PnlPassword.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.PnlPassword.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.PnlPassword.Size = new System.Drawing.Size(507, 154);
            this.PnlPassword.TabIndex = 0;
            // 
            // TxtOldPassword
            // 
            this.TxtOldPassword.BackColor = System.Drawing.SystemColors.Window;
            this.TxtOldPassword.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.TxtOldPassword.BorderFocusColor = System.Drawing.Color.HotPink;
            this.TxtOldPassword.BorderRadius = 0;
            this.TxtOldPassword.BorderSize = 2;
            this.TxtOldPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtOldPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtOldPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtOldPassword.Location = new System.Drawing.Point(5, 5);
            this.TxtOldPassword.Margin = new System.Windows.Forms.Padding(5);
            this.TxtOldPassword.Multiline = false;
            this.TxtOldPassword.Name = "TxtOldPassword";
            this.TxtOldPassword.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.TxtOldPassword.PasswordChar = false;
            this.TxtOldPassword.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TxtOldPassword.PlaceholderText = "";
            this.TxtOldPassword.Size = new System.Drawing.Size(458, 48);
            this.TxtOldPassword.TabIndex = 0;
            this.TxtOldPassword.Texts = "Contraseña actual";
            this.TxtOldPassword.UnderlinedStyle = false;
            this.TxtOldPassword.Enter += new System.EventHandler(this.TxtPassword_Enter);
            this.TxtOldPassword.Leave += new System.EventHandler(this.TxtPassword_Leave);
            // 
            // TxtNewPassword
            // 
            this.TxtNewPassword.BackColor = System.Drawing.SystemColors.Window;
            this.TxtNewPassword.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.TxtNewPassword.BorderFocusColor = System.Drawing.Color.HotPink;
            this.TxtNewPassword.BorderRadius = 0;
            this.TxtNewPassword.BorderSize = 2;
            this.TxtNewPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNewPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtNewPassword.Location = new System.Drawing.Point(5, 63);
            this.TxtNewPassword.Margin = new System.Windows.Forms.Padding(5);
            this.TxtNewPassword.Multiline = false;
            this.TxtNewPassword.Name = "TxtNewPassword";
            this.TxtNewPassword.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.TxtNewPassword.PasswordChar = false;
            this.TxtNewPassword.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TxtNewPassword.PlaceholderText = "";
            this.TxtNewPassword.Size = new System.Drawing.Size(458, 48);
            this.TxtNewPassword.TabIndex = 1;
            this.TxtNewPassword.Texts = "Nueva contraseña";
            this.TxtNewPassword.UnderlinedStyle = false;
            this.TxtNewPassword.Enter += new System.EventHandler(this.TxtPassword_Enter);
            this.TxtNewPassword.Leave += new System.EventHandler(this.TxtPassword_Leave);
            // 
            // TxtConfirmPassword
            // 
            this.TxtConfirmPassword.BackColor = System.Drawing.SystemColors.Window;
            this.TxtConfirmPassword.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.TxtConfirmPassword.BorderFocusColor = System.Drawing.Color.HotPink;
            this.TxtConfirmPassword.BorderRadius = 0;
            this.TxtConfirmPassword.BorderSize = 2;
            this.TxtConfirmPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtConfirmPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtConfirmPassword.Location = new System.Drawing.Point(5, 121);
            this.TxtConfirmPassword.Margin = new System.Windows.Forms.Padding(5);
            this.TxtConfirmPassword.Multiline = false;
            this.TxtConfirmPassword.Name = "TxtConfirmPassword";
            this.TxtConfirmPassword.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.TxtConfirmPassword.PasswordChar = false;
            this.TxtConfirmPassword.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TxtConfirmPassword.PlaceholderText = "";
            this.TxtConfirmPassword.Size = new System.Drawing.Size(458, 48);
            this.TxtConfirmPassword.TabIndex = 2;
            this.TxtConfirmPassword.Texts = "Confirmar contraseña";
            this.TxtConfirmPassword.UnderlinedStyle = false;
            this.TxtConfirmPassword.Enter += new System.EventHandler(this.TxtPassword_Enter);
            this.TxtConfirmPassword.Leave += new System.EventHandler(this.TxtPassword_Leave);
            // 
            // BtnOldPassword
            // 
            this.BtnOldPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnOldPassword.FlatAppearance.BorderSize = 0;
            this.BtnOldPassword.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnOldPassword.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnOldPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOldPassword.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            this.BtnOldPassword.IconColor = System.Drawing.Color.Gray;
            this.BtnOldPassword.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnOldPassword.IconSize = 34;
            this.BtnOldPassword.Location = new System.Drawing.Point(472, 4);
            this.BtnOldPassword.Margin = new System.Windows.Forms.Padding(4);
            this.BtnOldPassword.Name = "BtnOldPassword";
            this.BtnOldPassword.Size = new System.Drawing.Size(31, 50);
            this.BtnOldPassword.TabIndex = 13;
            this.BtnOldPassword.UseVisualStyleBackColor = true;
            this.BtnOldPassword.Click += new System.EventHandler(this.FABtnPassword_Click);
            this.BtnOldPassword.MouseEnter += new System.EventHandler(this.FABtnPassword_MouseEnter);
            this.BtnOldPassword.MouseLeave += new System.EventHandler(this.FABtnPassword_MouseLeave);
            // 
            // BtnConfirmPassword
            // 
            this.BtnConfirmPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnConfirmPassword.FlatAppearance.BorderSize = 0;
            this.BtnConfirmPassword.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnConfirmPassword.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnConfirmPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConfirmPassword.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            this.BtnConfirmPassword.IconColor = System.Drawing.Color.Gray;
            this.BtnConfirmPassword.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnConfirmPassword.IconSize = 34;
            this.BtnConfirmPassword.Location = new System.Drawing.Point(472, 120);
            this.BtnConfirmPassword.Margin = new System.Windows.Forms.Padding(4);
            this.BtnConfirmPassword.Name = "BtnConfirmPassword";
            this.BtnConfirmPassword.Size = new System.Drawing.Size(31, 50);
            this.BtnConfirmPassword.TabIndex = 11;
            this.BtnConfirmPassword.UseVisualStyleBackColor = true;
            this.BtnConfirmPassword.Click += new System.EventHandler(this.FABtnPassword_Click);
            this.BtnConfirmPassword.MouseEnter += new System.EventHandler(this.FABtnPassword_MouseEnter);
            this.BtnConfirmPassword.MouseLeave += new System.EventHandler(this.FABtnPassword_MouseLeave);
            // 
            // BtnNewPassword
            // 
            this.BtnNewPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnNewPassword.FlatAppearance.BorderSize = 0;
            this.BtnNewPassword.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnNewPassword.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnNewPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNewPassword.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            this.BtnNewPassword.IconColor = System.Drawing.Color.Gray;
            this.BtnNewPassword.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnNewPassword.IconSize = 34;
            this.BtnNewPassword.Location = new System.Drawing.Point(472, 62);
            this.BtnNewPassword.Margin = new System.Windows.Forms.Padding(4);
            this.BtnNewPassword.Name = "BtnNewPassword";
            this.BtnNewPassword.Size = new System.Drawing.Size(31, 50);
            this.BtnNewPassword.TabIndex = 12;
            this.BtnNewPassword.UseVisualStyleBackColor = true;
            this.BtnNewPassword.Click += new System.EventHandler(this.FABtnPassword_Click);
            this.BtnNewPassword.MouseEnter += new System.EventHandler(this.FABtnPassword_MouseEnter);
            this.BtnNewPassword.MouseLeave += new System.EventHandler(this.FABtnPassword_MouseLeave);
            // 
            // FrmMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(630, 313);
            this.Controls.Add(this.PnlBody);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmMessageBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMessageBox";
            this.TopMost = true;
            this.PnlBody.ResumeLayout(false);
            this.PnlBody.PerformLayout();
            this.PnlButton.ResumeLayout(false);
            this.PnlIfo.ResumeLayout(false);
            this.TabOpc.ResumeLayout(false);
            this.TabInfo.ResumeLayout(false);
            this.PnlInfo.ResumeLayout(false);
            this.PnlInfo.PerformLayout();
            this.TabPassword.ResumeLayout(false);
            this.PnlPassword.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel PnlBody;
        private System.Windows.Forms.TableLayoutPanel PnlIfo;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.TableLayoutPanel PnlButton;
        private RJCodeAdvance.RJControls.RJButton BtnYes;
        private RJCodeAdvance.RJControls.RJButton BtnCancel;
        private RJCodeAdvance.RJControls.RJButton BtnNo;
        private FontAwesome.Sharp.IconButton BtnIcon;
        private MaterialSkin.Controls.MaterialTabControl TabOpc;
        private System.Windows.Forms.TabPage TabInfo;
        private System.Windows.Forms.TableLayoutPanel PnlInfo;
        private System.Windows.Forms.Label LblText;
        private System.Windows.Forms.TabPage TabPassword;
        private System.Windows.Forms.TableLayoutPanel PnlPassword;
        private RJCodeAdvance.RJControls.RJTextBox TxtOldPassword;
        private RJCodeAdvance.RJControls.RJTextBox TxtNewPassword;
        private RJCodeAdvance.RJControls.RJTextBox TxtConfirmPassword;
        private FontAwesome.Sharp.IconButton BtnOldPassword;
        private FontAwesome.Sharp.IconButton BtnConfirmPassword;
        private FontAwesome.Sharp.IconButton BtnNewPassword;
    }
}