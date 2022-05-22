
namespace Garmoxu_Desktop
{
    partial class FrmMessageBoxPersonalizado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMessageBoxPersonalizado));
            this.PnlBody = new System.Windows.Forms.TableLayoutPanel();
            this.PnlTitleBar = new System.Windows.Forms.TableLayoutPanel();
            this.BtnClose = new FontAwesome.Sharp.IconButton();
            this.LblTitle = new System.Windows.Forms.Label();
            this.PnlButton = new System.Windows.Forms.TableLayoutPanel();
            this.BtnYes = new RJCodeAdvance.RJControls.RJButton();
            this.BtnNo = new RJCodeAdvance.RJControls.RJButton();
            this.BtnCancel = new RJCodeAdvance.RJControls.RJButton();
            this.PnlTexto = new System.Windows.Forms.TableLayoutPanel();
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
            this.BtnIcon = new FontAwesome.Sharp.IconButton();
            this.PnlBody.SuspendLayout();
            this.PnlTitleBar.SuspendLayout();
            this.PnlButton.SuspendLayout();
            this.PnlTexto.SuspendLayout();
            this.TabOpc.SuspendLayout();
            this.TabInfo.SuspendLayout();
            this.PnlInfo.SuspendLayout();
            this.TabPassword.SuspendLayout();
            this.PnlPassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlBody
            // 
            this.PnlBody.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(54)))), ((int)(((byte)(58)))));
            this.PnlBody.ColumnCount = 1;
            this.PnlBody.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PnlBody.Controls.Add(this.PnlTitleBar, 0, 0);
            this.PnlBody.Controls.Add(this.PnlButton, 0, 2);
            this.PnlBody.Controls.Add(this.PnlTexto, 0, 1);
            this.PnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlBody.Location = new System.Drawing.Point(0, 0);
            this.PnlBody.Margin = new System.Windows.Forms.Padding(0);
            this.PnlBody.Name = "PnlBody";
            this.PnlBody.RowCount = 3;
            this.PnlBody.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.PnlBody.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PnlBody.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.PnlBody.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.PnlBody.Size = new System.Drawing.Size(827, 467);
            this.PnlBody.TabIndex = 0;
            // 
            // PnlTitleBar
            // 
            this.PnlTitleBar.BackColor = System.Drawing.Color.Black;
            this.PnlTitleBar.ColumnCount = 3;
            this.PnlTitleBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PnlTitleBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.PnlTitleBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.PnlTitleBar.Controls.Add(this.BtnClose, 2, 0);
            this.PnlTitleBar.Controls.Add(this.LblTitle, 0, 0);
            this.PnlTitleBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlTitleBar.Location = new System.Drawing.Point(0, 0);
            this.PnlTitleBar.Margin = new System.Windows.Forms.Padding(0);
            this.PnlTitleBar.Name = "PnlTitleBar";
            this.PnlTitleBar.RowCount = 1;
            this.PnlTitleBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PnlTitleBar.Size = new System.Drawing.Size(827, 40);
            this.PnlTitleBar.TabIndex = 3;
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.Color.Transparent;
            this.BtnClose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(45)))));
            this.BtnClose.FlatAppearance.BorderSize = 0;
            this.BtnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(71)))), ((int)(((byte)(83)))));
            this.BtnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(41)))), ((int)(((byte)(83)))));
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(54)))), ((int)(((byte)(58)))));
            this.BtnClose.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.BtnClose.IconColor = System.Drawing.Color.White;
            this.BtnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnClose.IconSize = 25;
            this.BtnClose.Location = new System.Drawing.Point(787, 0);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(0);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(40, 40);
            this.BtnClose.TabIndex = 2;
            this.BtnClose.TabStop = false;
            this.BtnClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblTitle.Font = new System.Drawing.Font("Source Sans Pro", 12F, System.Drawing.FontStyle.Bold);
            this.LblTitle.ForeColor = System.Drawing.Color.White;
            this.LblTitle.Location = new System.Drawing.Point(14, 0);
            this.LblTitle.Margin = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(773, 40);
            this.LblTitle.TabIndex = 0;
            this.LblTitle.Text = "Titulo";
            this.LblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PnlButton
            // 
            this.PnlButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(45)))));
            this.PnlButton.ColumnCount = 5;
            this.PnlButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PnlButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.PnlButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.PnlButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.PnlButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.PnlButton.Controls.Add(this.BtnYes, 1, 0);
            this.PnlButton.Controls.Add(this.BtnNo, 2, 0);
            this.PnlButton.Controls.Add(this.BtnCancel, 3, 0);
            this.PnlButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlButton.Location = new System.Drawing.Point(0, 402);
            this.PnlButton.Margin = new System.Windows.Forms.Padding(0);
            this.PnlButton.Name = "PnlButton";
            this.PnlButton.RowCount = 1;
            this.PnlButton.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.PnlButton.Size = new System.Drawing.Size(827, 65);
            this.PnlButton.TabIndex = 1;
            // 
            // BtnYes
            // 
            this.BtnYes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnYes.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnYes.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.BtnYes.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.BtnYes.BorderRadius = 0;
            this.BtnYes.BorderSize = 0;
            this.BtnYes.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.BtnYes.FlatAppearance.BorderSize = 0;
            this.BtnYes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnYes.Font = new System.Drawing.Font("Source Sans Pro", 10F, System.Drawing.FontStyle.Bold);
            this.BtnYes.ForeColor = System.Drawing.Color.Transparent;
            this.BtnYes.Location = new System.Drawing.Point(397, 15);
            this.BtnYes.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.BtnYes.Name = "BtnYes";
            this.BtnYes.Size = new System.Drawing.Size(110, 35);
            this.BtnYes.TabIndex = 0;
            this.BtnYes.Text = "Si";
            this.BtnYes.TextColor = System.Drawing.Color.Transparent;
            this.BtnYes.UseVisualStyleBackColor = false;
            this.BtnYes.Click += new System.EventHandler(this.BtnYes_Click);
            this.BtnYes.Enter += new System.EventHandler(this.Button_Enter);
            this.BtnYes.Leave += new System.EventHandler(this.Button_Leave);
            // 
            // BtnNo
            // 
            this.BtnNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnNo.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnNo.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.BtnNo.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.BtnNo.BorderRadius = 0;
            this.BtnNo.BorderSize = 0;
            this.BtnNo.FlatAppearance.BorderSize = 0;
            this.BtnNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNo.Font = new System.Drawing.Font("Source Sans Pro", 10F, System.Drawing.FontStyle.Bold);
            this.BtnNo.ForeColor = System.Drawing.Color.White;
            this.BtnNo.Location = new System.Drawing.Point(547, 15);
            this.BtnNo.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.BtnNo.Name = "BtnNo";
            this.BtnNo.Size = new System.Drawing.Size(110, 35);
            this.BtnNo.TabIndex = 1;
            this.BtnNo.Text = "No";
            this.BtnNo.TextColor = System.Drawing.Color.White;
            this.BtnNo.UseVisualStyleBackColor = false;
            this.BtnNo.Visible = false;
            this.BtnNo.Click += new System.EventHandler(this.BtnNo_Click);
            this.BtnNo.Enter += new System.EventHandler(this.Button_Enter);
            this.BtnNo.Leave += new System.EventHandler(this.Button_Leave);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancel.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnCancel.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.BtnCancel.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.BtnCancel.BorderRadius = 0;
            this.BtnCancel.BorderSize = 0;
            this.BtnCancel.FlatAppearance.BorderSize = 0;
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancel.Font = new System.Drawing.Font("Source Sans Pro", 10F, System.Drawing.FontStyle.Bold);
            this.BtnCancel.ForeColor = System.Drawing.Color.White;
            this.BtnCancel.Location = new System.Drawing.Point(697, 15);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(110, 35);
            this.BtnCancel.TabIndex = 2;
            this.BtnCancel.Text = "Cancelar";
            this.BtnCancel.TextColor = System.Drawing.Color.White;
            this.BtnCancel.UseVisualStyleBackColor = false;
            this.BtnCancel.Visible = false;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            this.BtnCancel.Enter += new System.EventHandler(this.Button_Enter);
            this.BtnCancel.Leave += new System.EventHandler(this.Button_Leave);
            // 
            // PnlTexto
            // 
            this.PnlTexto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlTexto.ColumnCount = 4;
            this.PnlTexto.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PnlTexto.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.PnlTexto.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.PnlTexto.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PnlTexto.Controls.Add(this.TabOpc, 2, 1);
            this.PnlTexto.Controls.Add(this.BtnIcon, 1, 1);
            this.PnlTexto.Location = new System.Drawing.Point(20, 60);
            this.PnlTexto.Margin = new System.Windows.Forms.Padding(20);
            this.PnlTexto.Name = "PnlTexto";
            this.PnlTexto.RowCount = 3;
            this.PnlTexto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PnlTexto.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.PnlTexto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PnlTexto.Size = new System.Drawing.Size(787, 322);
            this.PnlTexto.TabIndex = 0;
            // 
            // TabOpc
            // 
            this.TabOpc.Controls.Add(this.TabInfo);
            this.TabOpc.Controls.Add(this.TabPassword);
            this.TabOpc.Depth = 0;
            this.TabOpc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabOpc.Location = new System.Drawing.Point(82, 22);
            this.TabOpc.Margin = new System.Windows.Forms.Padding(4);
            this.TabOpc.MouseState = MaterialSkin.MouseState.HOVER;
            this.TabOpc.Name = "TabOpc";
            this.TabOpc.SelectedIndex = 0;
            this.TabOpc.Size = new System.Drawing.Size(682, 277);
            this.TabOpc.TabIndex = 1;
            this.TabOpc.TabStop = false;
            // 
            // TabInfo
            // 
            this.TabInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(54)))), ((int)(((byte)(58)))));
            this.TabInfo.Controls.Add(this.PnlInfo);
            this.TabInfo.Location = new System.Drawing.Point(4, 25);
            this.TabInfo.Margin = new System.Windows.Forms.Padding(0);
            this.TabInfo.Name = "TabInfo";
            this.TabInfo.Size = new System.Drawing.Size(674, 248);
            this.TabInfo.TabIndex = 0;
            this.TabInfo.Text = "Info";
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
            this.PnlInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlInfo.Location = new System.Drawing.Point(0, 0);
            this.PnlInfo.Margin = new System.Windows.Forms.Padding(0);
            this.PnlInfo.Name = "PnlInfo";
            this.PnlInfo.RowCount = 1;
            this.PnlInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PnlInfo.Size = new System.Drawing.Size(674, 248);
            this.PnlInfo.TabIndex = 0;
            // 
            // LblText
            // 
            this.LblText.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LblText.AutoSize = true;
            this.LblText.Font = new System.Drawing.Font("Source Sans Pro", 12F, System.Drawing.FontStyle.Bold);
            this.LblText.ForeColor = System.Drawing.Color.White;
            this.LblText.Location = new System.Drawing.Point(0, 111);
            this.LblText.Margin = new System.Windows.Forms.Padding(0);
            this.LblText.Name = "LblText";
            this.LblText.Size = new System.Drawing.Size(59, 25);
            this.LblText.TabIndex = 10;
            this.LblText.Text = "Texto";
            this.LblText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TabPassword
            // 
            this.TabPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(54)))), ((int)(((byte)(58)))));
            this.TabPassword.Controls.Add(this.PnlPassword);
            this.TabPassword.Location = new System.Drawing.Point(4, 25);
            this.TabPassword.Margin = new System.Windows.Forms.Padding(4);
            this.TabPassword.Name = "TabPassword";
            this.TabPassword.Padding = new System.Windows.Forms.Padding(4);
            this.TabPassword.Size = new System.Drawing.Size(674, 248);
            this.TabPassword.TabIndex = 1;
            this.TabPassword.Text = "Password";
            // 
            // PnlPassword
            // 
            this.PnlPassword.ColumnCount = 2;
            this.PnlPassword.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PnlPassword.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.PnlPassword.Controls.Add(this.TxtOldPassword, 0, 0);
            this.PnlPassword.Controls.Add(this.TxtNewPassword, 0, 2);
            this.PnlPassword.Controls.Add(this.TxtConfirmPassword, 0, 4);
            this.PnlPassword.Controls.Add(this.BtnOldPassword, 1, 0);
            this.PnlPassword.Controls.Add(this.BtnConfirmPassword, 1, 4);
            this.PnlPassword.Controls.Add(this.BtnNewPassword, 1, 2);
            this.PnlPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlPassword.Location = new System.Drawing.Point(4, 4);
            this.PnlPassword.Margin = new System.Windows.Forms.Padding(4);
            this.PnlPassword.Name = "PnlPassword";
            this.PnlPassword.RowCount = 6;
            this.PnlPassword.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.PnlPassword.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.PnlPassword.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.PnlPassword.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.PnlPassword.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.PnlPassword.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PnlPassword.Size = new System.Drawing.Size(666, 240);
            this.PnlPassword.TabIndex = 0;
            // 
            // TxtOldPassword
            // 
            this.TxtOldPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.TxtOldPassword.BorderColor = System.Drawing.Color.Transparent;
            this.TxtOldPassword.BorderFocusColor = System.Drawing.Color.Gainsboro;
            this.TxtOldPassword.BorderRadius = 10;
            this.TxtOldPassword.BorderSize = 2;
            this.TxtOldPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtOldPassword.Font = new System.Drawing.Font("Source Sans Pro", 16.2F, System.Drawing.FontStyle.Bold);
            this.TxtOldPassword.ForeColor = System.Drawing.Color.Gray;
            this.TxtOldPassword.Location = new System.Drawing.Point(5, 5);
            this.TxtOldPassword.Margin = new System.Windows.Forms.Padding(5);
            this.TxtOldPassword.Multiline = false;
            this.TxtOldPassword.Name = "TxtOldPassword";
            this.TxtOldPassword.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.TxtOldPassword.PasswordChar = false;
            this.TxtOldPassword.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TxtOldPassword.PlaceholderText = "";
            this.TxtOldPassword.Size = new System.Drawing.Size(617, 55);
            this.TxtOldPassword.TabIndex = 0;
            this.TxtOldPassword.Tag = "Contraseña actual";
            this.TxtOldPassword.Texts = "Contraseña actual";
            this.TxtOldPassword.UnderlinedStyle = false;
            this.TxtOldPassword.Enter += new System.EventHandler(this.TxtPassword_Enter);
            this.TxtOldPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxPassword_KeyPress);
            this.TxtOldPassword.Leave += new System.EventHandler(this.TxtPassword_Leave);
            // 
            // TxtNewPassword
            // 
            this.TxtNewPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.TxtNewPassword.BorderColor = System.Drawing.Color.Transparent;
            this.TxtNewPassword.BorderFocusColor = System.Drawing.Color.Gainsboro;
            this.TxtNewPassword.BorderRadius = 10;
            this.TxtNewPassword.BorderSize = 2;
            this.TxtNewPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtNewPassword.Font = new System.Drawing.Font("Source Sans Pro", 16.2F, System.Drawing.FontStyle.Bold);
            this.TxtNewPassword.ForeColor = System.Drawing.Color.Gray;
            this.TxtNewPassword.Location = new System.Drawing.Point(5, 90);
            this.TxtNewPassword.Margin = new System.Windows.Forms.Padding(5);
            this.TxtNewPassword.Multiline = false;
            this.TxtNewPassword.Name = "TxtNewPassword";
            this.TxtNewPassword.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.TxtNewPassword.PasswordChar = false;
            this.TxtNewPassword.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TxtNewPassword.PlaceholderText = "";
            this.TxtNewPassword.Size = new System.Drawing.Size(617, 55);
            this.TxtNewPassword.TabIndex = 1;
            this.TxtNewPassword.Tag = "Nueva contraseña";
            this.TxtNewPassword.Texts = "Nueva contraseña";
            this.TxtNewPassword.UnderlinedStyle = false;
            this.TxtNewPassword.Enter += new System.EventHandler(this.TxtPassword_Enter);
            this.TxtNewPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxPassword_KeyPress);
            this.TxtNewPassword.Leave += new System.EventHandler(this.TxtPassword_Leave);
            // 
            // TxtConfirmPassword
            // 
            this.TxtConfirmPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.TxtConfirmPassword.BorderColor = System.Drawing.Color.Transparent;
            this.TxtConfirmPassword.BorderFocusColor = System.Drawing.Color.Gainsboro;
            this.TxtConfirmPassword.BorderRadius = 10;
            this.TxtConfirmPassword.BorderSize = 2;
            this.TxtConfirmPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtConfirmPassword.Font = new System.Drawing.Font("Source Sans Pro", 16.2F, System.Drawing.FontStyle.Bold);
            this.TxtConfirmPassword.ForeColor = System.Drawing.Color.Gray;
            this.TxtConfirmPassword.Location = new System.Drawing.Point(5, 175);
            this.TxtConfirmPassword.Margin = new System.Windows.Forms.Padding(5);
            this.TxtConfirmPassword.Multiline = false;
            this.TxtConfirmPassword.Name = "TxtConfirmPassword";
            this.TxtConfirmPassword.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.TxtConfirmPassword.PasswordChar = false;
            this.TxtConfirmPassword.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TxtConfirmPassword.PlaceholderText = "";
            this.TxtConfirmPassword.Size = new System.Drawing.Size(617, 55);
            this.TxtConfirmPassword.TabIndex = 2;
            this.TxtConfirmPassword.Tag = "Confirmar contraseña";
            this.TxtConfirmPassword.Texts = "Confirmar contraseña";
            this.TxtConfirmPassword.UnderlinedStyle = false;
            this.TxtConfirmPassword.Enter += new System.EventHandler(this.TxtPassword_Enter);
            this.TxtConfirmPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxPassword_KeyPress);
            this.TxtConfirmPassword.Leave += new System.EventHandler(this.TxtPassword_Leave);
            // 
            // BtnOldPassword
            // 
            this.BtnOldPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnOldPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnOldPassword.FlatAppearance.BorderSize = 0;
            this.BtnOldPassword.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnOldPassword.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnOldPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOldPassword.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            this.BtnOldPassword.IconColor = System.Drawing.Color.Gray;
            this.BtnOldPassword.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtnOldPassword.IconSize = 34;
            this.BtnOldPassword.Location = new System.Drawing.Point(631, 4);
            this.BtnOldPassword.Margin = new System.Windows.Forms.Padding(4);
            this.BtnOldPassword.Name = "BtnOldPassword";
            this.BtnOldPassword.Size = new System.Drawing.Size(31, 57);
            this.BtnOldPassword.TabIndex = 13;
            this.BtnOldPassword.TabStop = false;
            this.BtnOldPassword.UseVisualStyleBackColor = true;
            this.BtnOldPassword.Click += new System.EventHandler(this.FABtnPassword_Click);
            this.BtnOldPassword.MouseEnter += new System.EventHandler(this.FABtnPassword_MouseEnter);
            this.BtnOldPassword.MouseLeave += new System.EventHandler(this.FABtnPassword_MouseLeave);
            // 
            // BtnConfirmPassword
            // 
            this.BtnConfirmPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnConfirmPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnConfirmPassword.FlatAppearance.BorderSize = 0;
            this.BtnConfirmPassword.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnConfirmPassword.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnConfirmPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConfirmPassword.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            this.BtnConfirmPassword.IconColor = System.Drawing.Color.Gray;
            this.BtnConfirmPassword.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtnConfirmPassword.IconSize = 34;
            this.BtnConfirmPassword.Location = new System.Drawing.Point(631, 174);
            this.BtnConfirmPassword.Margin = new System.Windows.Forms.Padding(4);
            this.BtnConfirmPassword.Name = "BtnConfirmPassword";
            this.BtnConfirmPassword.Size = new System.Drawing.Size(31, 57);
            this.BtnConfirmPassword.TabIndex = 11;
            this.BtnConfirmPassword.TabStop = false;
            this.BtnConfirmPassword.UseVisualStyleBackColor = true;
            this.BtnConfirmPassword.Click += new System.EventHandler(this.FABtnPassword_Click);
            this.BtnConfirmPassword.MouseEnter += new System.EventHandler(this.FABtnPassword_MouseEnter);
            this.BtnConfirmPassword.MouseLeave += new System.EventHandler(this.FABtnPassword_MouseLeave);
            // 
            // BtnNewPassword
            // 
            this.BtnNewPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNewPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnNewPassword.FlatAppearance.BorderSize = 0;
            this.BtnNewPassword.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnNewPassword.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnNewPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNewPassword.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            this.BtnNewPassword.IconColor = System.Drawing.Color.Gray;
            this.BtnNewPassword.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtnNewPassword.IconSize = 34;
            this.BtnNewPassword.Location = new System.Drawing.Point(631, 89);
            this.BtnNewPassword.Margin = new System.Windows.Forms.Padding(4);
            this.BtnNewPassword.Name = "BtnNewPassword";
            this.BtnNewPassword.Size = new System.Drawing.Size(31, 57);
            this.BtnNewPassword.TabIndex = 12;
            this.BtnNewPassword.TabStop = false;
            this.BtnNewPassword.UseVisualStyleBackColor = true;
            this.BtnNewPassword.Click += new System.EventHandler(this.FABtnPassword_Click);
            this.BtnNewPassword.MouseEnter += new System.EventHandler(this.FABtnPassword_MouseEnter);
            this.BtnNewPassword.MouseLeave += new System.EventHandler(this.FABtnPassword_MouseLeave);
            // 
            // BtnIcon
            // 
            this.BtnIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnIcon.BackColor = System.Drawing.Color.Transparent;
            this.BtnIcon.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnIcon.FlatAppearance.BorderSize = 0;
            this.BtnIcon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnIcon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIcon.ForeColor = System.Drawing.Color.Transparent;
            this.BtnIcon.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.BtnIcon.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.BtnIcon.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtnIcon.IconSize = 60;
            this.BtnIcon.Location = new System.Drawing.Point(18, 128);
            this.BtnIcon.Margin = new System.Windows.Forms.Padding(0);
            this.BtnIcon.Name = "BtnIcon";
            this.BtnIcon.Size = new System.Drawing.Size(60, 65);
            this.BtnIcon.TabIndex = 3;
            this.BtnIcon.TabStop = false;
            this.BtnIcon.UseVisualStyleBackColor = false;
            // 
            // FrmMessageBoxPersonalizado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(827, 467);
            this.Controls.Add(this.PnlBody);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmMessageBoxPersonalizado";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mensaje - Garmoxu";
            this.TopMost = true;
            this.Shown += new System.EventHandler(this.FrmMessageBoxPersonalizado_Shown);
            this.PnlBody.ResumeLayout(false);
            this.PnlTitleBar.ResumeLayout(false);
            this.PnlTitleBar.PerformLayout();
            this.PnlButton.ResumeLayout(false);
            this.PnlTexto.ResumeLayout(false);
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
        private System.Windows.Forms.TableLayoutPanel PnlTitleBar;
        private FontAwesome.Sharp.IconButton BtnClose;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.TableLayoutPanel PnlTexto;
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
        private System.Windows.Forms.TableLayoutPanel PnlButton;
        private RJCodeAdvance.RJControls.RJButton BtnCancel;
        private RJCodeAdvance.RJControls.RJButton BtnNo;
        private RJCodeAdvance.RJControls.RJButton BtnYes;
    }
}