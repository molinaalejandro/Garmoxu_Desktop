namespace Garmoxu_Desktop
{
    partial class FrmInicioSesion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInicioSesion));
            this.PnlTitle = new System.Windows.Forms.Panel();
            this.tableLayoutPanel11 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnMinimize = new FontAwesome.Sharp.IconButton();
            this.BtnClose = new FontAwesome.Sharp.IconButton();
            this.label4 = new System.Windows.Forms.Label();
            this.PnlMain = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.PicLogo = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.TxtUsuario = new RJCodeAdvance.RJControls.RJTextBox();
            this.BtnUsuario = new FontAwesome.Sharp.IconButton();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnContraseña = new FontAwesome.Sharp.IconButton();
            this.TxtContraseña = new RJCodeAdvance.RJControls.RJTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.LblRecordarUsuario = new System.Windows.Forms.Label();
            this.ChkRemember = new Garmoxu_Desktop.MyCheckBox();
            this.BtnIniciar = new RJCodeAdvance.RJControls.RJButton();
            this.PnlTitle.SuspendLayout();
            this.tableLayoutPanel11.SuspendLayout();
            this.PnlMain.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlTitle
            // 
            this.PnlTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(45)))));
            this.PnlTitle.Controls.Add(this.tableLayoutPanel11);
            this.PnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlTitle.Location = new System.Drawing.Point(0, 0);
            this.PnlTitle.Margin = new System.Windows.Forms.Padding(4);
            this.PnlTitle.Name = "PnlTitle";
            this.PnlTitle.Size = new System.Drawing.Size(539, 72);
            this.PnlTitle.TabIndex = 0;
            this.PnlTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitle_MouseDown);
            // 
            // tableLayoutPanel11
            // 
            this.tableLayoutPanel11.ColumnCount = 3;
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel11.Controls.Add(this.BtnMinimize, 1, 0);
            this.tableLayoutPanel11.Controls.Add(this.BtnClose, 2, 0);
            this.tableLayoutPanel11.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel11.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel11.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel11.Name = "tableLayoutPanel11";
            this.tableLayoutPanel11.RowCount = 1;
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel11.Size = new System.Drawing.Size(539, 72);
            this.tableLayoutPanel11.TabIndex = 0;
            this.tableLayoutPanel11.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitle_MouseDown);
            // 
            // BtnMinimize
            // 
            this.BtnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.BtnMinimize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnMinimize.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(45)))));
            this.BtnMinimize.FlatAppearance.BorderSize = 0;
            this.BtnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.BtnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.BtnMinimize.IconColor = System.Drawing.Color.White;
            this.BtnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnMinimize.IconSize = 20;
            this.BtnMinimize.Location = new System.Drawing.Point(405, 0);
            this.BtnMinimize.Margin = new System.Windows.Forms.Padding(0);
            this.BtnMinimize.Name = "BtnMinimize";
            this.BtnMinimize.Size = new System.Drawing.Size(67, 72);
            this.BtnMinimize.TabIndex = 1;
            this.BtnMinimize.TabStop = false;
            this.BtnMinimize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMinimize.UseVisualStyleBackColor = false;
            this.BtnMinimize.Click += new System.EventHandler(this.BtnMinimize_Click);
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
            this.BtnClose.Location = new System.Drawing.Point(472, 0);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(0);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(67, 72);
            this.BtnClose.TabIndex = 2;
            this.BtnClose.TabStop = false;
            this.BtnClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Source Sans Pro", 18F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(14, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(391, 72);
            this.label4.TabIndex = 0;
            this.label4.Text = "Iniciar sesión";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitle_MouseDown);
            // 
            // PnlMain
            // 
            this.PnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(54)))), ((int)(((byte)(58)))));
            this.PnlMain.Controls.Add(this.tableLayoutPanel1);
            this.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlMain.Location = new System.Drawing.Point(0, 72);
            this.PnlMain.Margin = new System.Windows.Forms.Padding(4);
            this.PnlMain.Name = "PnlMain";
            this.PnlMain.Size = new System.Drawing.Size(539, 594);
            this.PnlMain.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel7, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(70, 30, 70, 30);
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(539, 594);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.PicLogo, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(70, 30);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(399, 191);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // PicLogo
            // 
            this.PicLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PicLogo.Image = global::Garmoxu_Desktop.Properties.Resources.Garmoxu_Logo_Circle_Red_New;
            this.PicLogo.Location = new System.Drawing.Point(0, 0);
            this.PicLogo.Margin = new System.Windows.Forms.Padding(0, 0, 0, 30);
            this.PicLogo.Name = "PicLogo";
            this.PicLogo.Size = new System.Drawing.Size(399, 161);
            this.PicLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicLogo.TabIndex = 5;
            this.PicLogo.TabStop = false;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel8, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(70, 221);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(399, 160);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 1;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel8.Controls.Add(this.tableLayoutPanel9, 0, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 2;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(393, 74);
            this.tableLayoutPanel8.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Source Sans Pro", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(10, 45);
            this.label3.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(380, 2);
            this.label3.TabIndex = 1;
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 2;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel9.Controls.Add(this.TxtUsuario, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.BtnUsuario, 1, 0);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 1;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(387, 39);
            this.tableLayoutPanel9.TabIndex = 0;
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(54)))), ((int)(((byte)(58)))));
            this.TxtUsuario.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(54)))), ((int)(((byte)(58)))));
            this.TxtUsuario.BorderFocusColor = System.Drawing.Color.Transparent;
            this.TxtUsuario.BorderRadius = 0;
            this.TxtUsuario.BorderSize = 2;
            this.TxtUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtUsuario.Font = new System.Drawing.Font("Source Sans Pro", 16.2F, System.Drawing.FontStyle.Bold);
            this.TxtUsuario.ForeColor = System.Drawing.Color.Gray;
            this.TxtUsuario.Location = new System.Drawing.Point(0, 10);
            this.TxtUsuario.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.TxtUsuario.Multiline = false;
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.TxtUsuario.PasswordChar = false;
            this.TxtUsuario.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TxtUsuario.PlaceholderText = "";
            this.TxtUsuario.Size = new System.Drawing.Size(347, 37);
            this.TxtUsuario.TabIndex = 0;
            this.TxtUsuario.Texts = "Nombre de usuario";
            this.TxtUsuario.UnderlinedStyle = false;
            this.TxtUsuario.Enter += new System.EventHandler(this.TxtUser_Enter);
            this.TxtUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtUsuario_KeyPress);
            this.TxtUsuario.Leave += new System.EventHandler(this.TxtUser_Leave);
            // 
            // BtnUsuario
            // 
            this.BtnUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnUsuario.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.BtnUsuario.FlatAppearance.BorderSize = 0;
            this.BtnUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(54)))), ((int)(((byte)(58)))));
            this.BtnUsuario.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.BtnUsuario.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(255)))));
            this.BtnUsuario.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtnUsuario.IconSize = 34;
            this.BtnUsuario.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnUsuario.Location = new System.Drawing.Point(347, 5);
            this.BtnUsuario.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.BtnUsuario.Name = "BtnUsuario";
            this.BtnUsuario.Size = new System.Drawing.Size(40, 34);
            this.BtnUsuario.TabIndex = 0;
            this.BtnUsuario.TabStop = false;
            this.BtnUsuario.UseVisualStyleBackColor = true;
            this.BtnUsuario.Click += new System.EventHandler(this.BtnPerfil_Click);
            this.BtnUsuario.MouseEnter += new System.EventHandler(this.BtnPerfil_MouseEnter);
            this.BtnUsuario.MouseLeave += new System.EventHandler(this.BtnPerfil_MouseLeave);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 83);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(393, 74);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.BtnContraseña, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.TxtContraseña, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(387, 39);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // BtnContraseña
            // 
            this.BtnContraseña.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnContraseña.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnContraseña.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(54)))), ((int)(((byte)(58)))));
            this.BtnContraseña.FlatAppearance.BorderSize = 0;
            this.BtnContraseña.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnContraseña.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnContraseña.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnContraseña.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(54)))), ((int)(((byte)(58)))));
            this.BtnContraseña.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            this.BtnContraseña.IconColor = System.Drawing.Color.Gray;
            this.BtnContraseña.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtnContraseña.IconSize = 34;
            this.BtnContraseña.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnContraseña.Location = new System.Drawing.Point(347, 5);
            this.BtnContraseña.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.BtnContraseña.Name = "BtnContraseña";
            this.BtnContraseña.Size = new System.Drawing.Size(40, 42);
            this.BtnContraseña.TabIndex = 0;
            this.BtnContraseña.TabStop = false;
            this.BtnContraseña.UseVisualStyleBackColor = true;
            this.BtnContraseña.Click += new System.EventHandler(this.BtnPassword_Click);
            this.BtnContraseña.MouseEnter += new System.EventHandler(this.BtnPassword_MouseEnter);
            this.BtnContraseña.MouseLeave += new System.EventHandler(this.BtnPassword_MouseLeave);
            // 
            // TxtContraseña
            // 
            this.TxtContraseña.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.TxtContraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(54)))), ((int)(((byte)(58)))));
            this.TxtContraseña.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(54)))), ((int)(((byte)(58)))));
            this.TxtContraseña.BorderFocusColor = System.Drawing.Color.Transparent;
            this.TxtContraseña.BorderRadius = 0;
            this.TxtContraseña.BorderSize = 2;
            this.TxtContraseña.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtContraseña.Font = new System.Drawing.Font("Source Sans Pro", 16.2F, System.Drawing.FontStyle.Bold);
            this.TxtContraseña.ForeColor = System.Drawing.Color.Gray;
            this.TxtContraseña.Location = new System.Drawing.Point(0, 10);
            this.TxtContraseña.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.TxtContraseña.Multiline = false;
            this.TxtContraseña.Name = "TxtContraseña";
            this.TxtContraseña.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.TxtContraseña.PasswordChar = false;
            this.TxtContraseña.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TxtContraseña.PlaceholderText = "";
            this.TxtContraseña.Size = new System.Drawing.Size(347, 37);
            this.TxtContraseña.TabIndex = 1;
            this.TxtContraseña.Texts = "Contraseña";
            this.TxtContraseña.UnderlinedStyle = false;
            this.TxtContraseña.Enter += new System.EventHandler(this.TxtPassword_Enter);
            this.TxtContraseña.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtContraseña_KeyPress);
            this.TxtContraseña.Leave += new System.EventHandler(this.TxtPassword_Leave);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Source Sans Pro", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 2);
            this.label1.TabIndex = 1;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Controls.Add(this.tableLayoutPanel6, 0, 2);
            this.tableLayoutPanel7.Controls.Add(this.BtnIniciar, 0, 1);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(70, 381);
            this.tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 3;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(399, 183);
            this.tableLayoutPanel7.TabIndex = 1;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 4;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.LblRecordarUsuario, 2, 0);
            this.tableLayoutPanel6.Controls.Add(this.ChkRemember, 1, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 96);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.Size = new System.Drawing.Size(393, 84);
            this.tableLayoutPanel6.TabIndex = 3;
            // 
            // LblRecordarUsuario
            // 
            this.LblRecordarUsuario.AutoSize = true;
            this.LblRecordarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblRecordarUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblRecordarUsuario.Font = new System.Drawing.Font("Source Sans Pro", 11F, System.Drawing.FontStyle.Bold);
            this.LblRecordarUsuario.ForeColor = System.Drawing.Color.Silver;
            this.LblRecordarUsuario.Location = new System.Drawing.Point(130, 10);
            this.LblRecordarUsuario.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.LblRecordarUsuario.Name = "LblRecordarUsuario";
            this.LblRecordarUsuario.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.LblRecordarUsuario.Size = new System.Drawing.Size(156, 74);
            this.LblRecordarUsuario.TabIndex = 1;
            this.LblRecordarUsuario.Text = "Recordar usuario";
            this.LblRecordarUsuario.Click += new System.EventHandler(this.LblRecordarUsuario_Click);
            this.LblRecordarUsuario.MouseEnter += new System.EventHandler(this.ChkRemember_MouseEnter);
            this.LblRecordarUsuario.MouseLeave += new System.EventHandler(this.ChkRemember_MouseLeave);
            // 
            // ChkRemember
            // 
            this.ChkRemember.BackColor = System.Drawing.Color.Transparent;
            this.ChkRemember.Background = System.Drawing.Color.Transparent;
            this.ChkRemember.BorderColor = System.Drawing.Color.Silver;
            this.ChkRemember.BorderHeight = 15;
            this.ChkRemember.BorderWidth = 15;
            this.ChkRemember.Checked = false;
            this.ChkRemember.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChkRemember.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChkRemember.EnterColor = System.Drawing.Color.White;
            this.ChkRemember.Font = new System.Drawing.Font("Source Sans Pro Black", 14F, System.Drawing.FontStyle.Bold);
            this.ChkRemember.ForeColor = System.Drawing.Color.Silver;
            this.ChkRemember.LeaveColor = System.Drawing.Color.Silver;
            this.ChkRemember.Location = new System.Drawing.Point(106, 10);
            this.ChkRemember.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.ChkRemember.Name = "ChkRemember";
            this.ChkRemember.Padding = new System.Windows.Forms.Padding(2, 5, 0, 0);
            this.ChkRemember.PaddingCheck = new System.Windows.Forms.Padding(1, 1, 0, 0);
            this.ChkRemember.Size = new System.Drawing.Size(24, 74);
            this.ChkRemember.TabIndex = 2;
            this.ChkRemember.Text = "myCheckBox1";
            this.ChkRemember.Click += new System.EventHandler(this.LblRecordarUsuario_Click);
            this.ChkRemember.MouseEnter += new System.EventHandler(this.ChkRemember_MouseEnter);
            this.ChkRemember.MouseLeave += new System.EventHandler(this.ChkRemember_MouseLeave);
            // 
            // BtnIniciar
            // 
            this.BtnIniciar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnIniciar.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnIniciar.BackgroundColor = System.Drawing.Color.SeaGreen;
            this.BtnIniciar.BorderColor = System.Drawing.Color.SeaGreen;
            this.BtnIniciar.BorderRadius = 15;
            this.BtnIniciar.BorderSize = 0;
            this.BtnIniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnIniciar.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.BtnIniciar.FlatAppearance.BorderSize = 0;
            this.BtnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIniciar.Font = new System.Drawing.Font("Source Sans Pro", 16.2F, System.Drawing.FontStyle.Bold);
            this.BtnIniciar.ForeColor = System.Drawing.Color.White;
            this.BtnIniciar.Location = new System.Drawing.Point(95, 34);
            this.BtnIniciar.Margin = new System.Windows.Forms.Padding(95, 4, 95, 4);
            this.BtnIniciar.Name = "BtnIniciar";
            this.BtnIniciar.Size = new System.Drawing.Size(209, 55);
            this.BtnIniciar.TabIndex = 0;
            this.BtnIniciar.TabStop = false;
            this.BtnIniciar.Text = "Acceder";
            this.BtnIniciar.TextColor = System.Drawing.Color.White;
            this.BtnIniciar.UseVisualStyleBackColor = false;
            this.BtnIniciar.Click += new System.EventHandler(this.BtnIniciar_Click);
            // 
            // FrmInicioSesion
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(539, 666);
            this.Controls.Add(this.PnlMain);
            this.Controls.Add(this.PnlTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmInicioSesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iniciar sesión - Garmoxu Desktop";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmInicioSesion_FormClosing);
            this.Shown += new System.EventHandler(this.FrmInicioSesion_Shown);
            this.VisibleChanged += new System.EventHandler(this.FrmInicioSesion_VisibleChanged);
            this.PnlTitle.ResumeLayout(false);
            this.tableLayoutPanel11.ResumeLayout(false);
            this.tableLayoutPanel11.PerformLayout();
            this.PnlMain.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlTitle;
        private System.Windows.Forms.Panel PnlMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel11;
        private FontAwesome.Sharp.IconButton BtnMinimize;
        private FontAwesome.Sharp.IconButton BtnClose;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private RJCodeAdvance.RJControls.RJTextBox TxtUsuario;
        private FontAwesome.Sharp.IconButton BtnUsuario;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private FontAwesome.Sharp.IconButton BtnContraseña;
        private RJCodeAdvance.RJControls.RJTextBox TxtContraseña;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private RJCodeAdvance.RJControls.RJButton BtnIniciar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label LblRecordarUsuario;
        private MyCheckBox ChkRemember;
        private System.Windows.Forms.PictureBox PicLogo;
    }
}