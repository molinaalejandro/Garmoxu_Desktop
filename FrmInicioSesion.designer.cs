namespace Garmoxu_Project
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
            this.PnlTitle = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnMinimize = new FontAwesome.Sharp.IconButton();
            this.BtnClose = new FontAwesome.Sharp.IconButton();
            this.LblTitle = new System.Windows.Forms.Label();
            this.PnlMain = new System.Windows.Forms.Panel();
            this.ChkRemember = new MaterialSkin.Controls.MaterialCheckBox();
            this.BtnPassword = new FontAwesome.Sharp.IconButton();
            this.BtnPerfil = new FontAwesome.Sharp.IconButton();
            this.TbxPassword = new System.Windows.Forms.TextBox();
            this.LblPass = new System.Windows.Forms.Label();
            this.TbxUser = new System.Windows.Forms.TextBox();
            this.LblUser = new System.Windows.Forms.Label();
            this.LblSubTitle = new System.Windows.Forms.Label();
            this.BtnIniciar = new RJCodeAdvance.RJControls.RJButton();
            this.PnlTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlTitle
            // 
            this.PnlTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(45)))));
            this.PnlTitle.Controls.Add(this.pictureBox1);
            this.PnlTitle.Controls.Add(this.BtnMinimize);
            this.PnlTitle.Controls.Add(this.BtnClose);
            this.PnlTitle.Controls.Add(this.LblTitle);
            this.PnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlTitle.Location = new System.Drawing.Point(0, 0);
            this.PnlTitle.Margin = new System.Windows.Forms.Padding(4);
            this.PnlTitle.Name = "PnlTitle";
            this.PnlTitle.Size = new System.Drawing.Size(539, 66);
            this.PnlTitle.TabIndex = 2;
            this.PnlTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitle_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 62);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // BtnMinimize
            // 
            this.BtnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.BtnMinimize.FlatAppearance.BorderSize = 0;
            this.BtnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.BtnMinimize.IconColor = System.Drawing.Color.White;
            this.BtnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnMinimize.IconSize = 20;
            this.BtnMinimize.Location = new System.Drawing.Point(412, 0);
            this.BtnMinimize.Margin = new System.Windows.Forms.Padding(4);
            this.BtnMinimize.Name = "BtnMinimize";
            this.BtnMinimize.Size = new System.Drawing.Size(67, 49);
            this.BtnMinimize.TabIndex = 4;
            this.BtnMinimize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMinimize.UseVisualStyleBackColor = false;
            this.BtnMinimize.Click += new System.EventHandler(this.BtnMinimize_Click);
            this.BtnMinimize.MouseEnter += new System.EventHandler(this.FABtnMinimize_MouseEnter);
            this.BtnMinimize.MouseLeave += new System.EventHandler(this.FABtnMinimize_MouseLeave);
            // 
            // BtnClose
            // 
            this.BtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClose.BackColor = System.Drawing.Color.Transparent;
            this.BtnClose.FlatAppearance.BorderSize = 0;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.BtnClose.IconColor = System.Drawing.Color.White;
            this.BtnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnClose.IconSize = 25;
            this.BtnClose.Location = new System.Drawing.Point(472, 0);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(4);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(67, 49);
            this.BtnClose.TabIndex = 3;
            this.BtnClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            this.BtnClose.MouseEnter += new System.EventHandler(this.FABtnClose_MouseEnter);
            this.BtnClose.MouseLeave += new System.EventHandler(this.FABtnClose_MouseLeave);
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.BackColor = System.Drawing.Color.Transparent;
            this.LblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(41)))), ((int)(((byte)(83)))));
            this.LblTitle.Location = new System.Drawing.Point(159, 11);
            this.LblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(192, 46);
            this.LblTitle.TabIndex = 0;
            this.LblTitle.Text = "Garmoxu";
            this.LblTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitle_MouseDown);
            // 
            // PnlMain
            // 
            this.PnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(54)))), ((int)(((byte)(58)))));
            this.PnlMain.Controls.Add(this.ChkRemember);
            this.PnlMain.Controls.Add(this.BtnPassword);
            this.PnlMain.Controls.Add(this.BtnPerfil);
            this.PnlMain.Controls.Add(this.TbxPassword);
            this.PnlMain.Controls.Add(this.LblPass);
            this.PnlMain.Controls.Add(this.TbxUser);
            this.PnlMain.Controls.Add(this.LblUser);
            this.PnlMain.Controls.Add(this.LblSubTitle);
            this.PnlMain.Controls.Add(this.BtnIniciar);
            this.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlMain.Location = new System.Drawing.Point(0, 66);
            this.PnlMain.Margin = new System.Windows.Forms.Padding(4);
            this.PnlMain.Name = "PnlMain";
            this.PnlMain.Size = new System.Drawing.Size(539, 600);
            this.PnlMain.TabIndex = 3;
            // 
            // ChkRemember
            // 
            this.ChkRemember.AutoSize = true;
            this.ChkRemember.Depth = 0;
            this.ChkRemember.Font = new System.Drawing.Font("Roboto", 10F);
            this.ChkRemember.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(41)))), ((int)(((byte)(83)))));
            this.ChkRemember.Location = new System.Drawing.Point(193, 460);
            this.ChkRemember.Margin = new System.Windows.Forms.Padding(0);
            this.ChkRemember.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ChkRemember.MouseState = MaterialSkin.MouseState.HOVER;
            this.ChkRemember.Name = "ChkRemember";
            this.ChkRemember.Ripple = true;
            this.ChkRemember.Size = new System.Drawing.Size(143, 30);
            this.ChkRemember.TabIndex = 13;
            this.ChkRemember.Text = "Remember Me";
            this.ChkRemember.UseVisualStyleBackColor = true;
            // 
            // BtnPassword
            // 
            this.BtnPassword.FlatAppearance.BorderSize = 0;
            this.BtnPassword.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnPassword.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPassword.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            this.BtnPassword.IconColor = System.Drawing.Color.Gray;
            this.BtnPassword.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnPassword.IconSize = 34;
            this.BtnPassword.Location = new System.Drawing.Point(427, 261);
            this.BtnPassword.Margin = new System.Windows.Forms.Padding(4);
            this.BtnPassword.Name = "BtnPassword";
            this.BtnPassword.Size = new System.Drawing.Size(40, 42);
            this.BtnPassword.TabIndex = 10;
            this.BtnPassword.UseVisualStyleBackColor = true;
            this.BtnPassword.Click += new System.EventHandler(this.BtnPassword_Click);
            this.BtnPassword.MouseEnter += new System.EventHandler(this.BtnPassword_MouseEnter);
            this.BtnPassword.MouseLeave += new System.EventHandler(this.BtnPassword_MouseLeave);
            // 
            // BtnPerfil
            // 
            this.BtnPerfil.FlatAppearance.BorderSize = 0;
            this.BtnPerfil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnPerfil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPerfil.IconChar = FontAwesome.Sharp.IconChar.Portrait;
            this.BtnPerfil.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnPerfil.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnPerfil.IconSize = 34;
            this.BtnPerfil.Location = new System.Drawing.Point(427, 188);
            this.BtnPerfil.Margin = new System.Windows.Forms.Padding(4);
            this.BtnPerfil.Name = "BtnPerfil";
            this.BtnPerfil.Size = new System.Drawing.Size(40, 41);
            this.BtnPerfil.TabIndex = 9;
            this.BtnPerfil.UseVisualStyleBackColor = true;
            this.BtnPerfil.Click += new System.EventHandler(this.FABtnPerfil_Click);
            this.BtnPerfil.MouseEnter += new System.EventHandler(this.FABtnPerfil_MouseEnter);
            this.BtnPerfil.MouseLeave += new System.EventHandler(this.FABtnPerfil_MouseLeave);
            // 
            // TbxPassword
            // 
            this.TbxPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(54)))), ((int)(((byte)(58)))));
            this.TbxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TbxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxPassword.Location = new System.Drawing.Point(80, 274);
            this.TbxPassword.Margin = new System.Windows.Forms.Padding(4);
            this.TbxPassword.Name = "TbxPassword";
            this.TbxPassword.Size = new System.Drawing.Size(352, 23);
            this.TbxPassword.TabIndex = 6;
            this.TbxPassword.Text = "Contraseña";
            this.TbxPassword.Enter += new System.EventHandler(this.TbxPassword_Enter);
            this.TbxPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TbxPassword_KeyDown);
            this.TbxPassword.Leave += new System.EventHandler(this.TbxPassword_Leave);
            // 
            // LblPass
            // 
            this.LblPass.AutoSize = true;
            this.LblPass.BackColor = System.Drawing.Color.Transparent;
            this.LblPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPass.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.LblPass.Location = new System.Drawing.Point(73, 288);
            this.LblPass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblPass.Name = "LblPass";
            this.LblPass.Size = new System.Drawing.Size(386, 17);
            this.LblPass.TabIndex = 7;
            this.LblPass.Text = "__________________________________________";
            // 
            // TbxUser
            // 
            this.TbxUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(54)))), ((int)(((byte)(58)))));
            this.TbxUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TbxUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxUser.Location = new System.Drawing.Point(80, 202);
            this.TbxUser.Margin = new System.Windows.Forms.Padding(4);
            this.TbxUser.Name = "TbxUser";
            this.TbxUser.Size = new System.Drawing.Size(352, 23);
            this.TbxUser.TabIndex = 2;
            this.TbxUser.Text = "Nombre de usuario";
            this.TbxUser.Enter += new System.EventHandler(this.TbxUser_Enter);
            this.TbxUser.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TbxUser_KeyDown);
            this.TbxUser.Leave += new System.EventHandler(this.TbxUser_Leave);
            // 
            // LblUser
            // 
            this.LblUser.AutoSize = true;
            this.LblUser.BackColor = System.Drawing.Color.Transparent;
            this.LblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUser.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.LblUser.Location = new System.Drawing.Point(73, 215);
            this.LblUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblUser.Name = "LblUser";
            this.LblUser.Size = new System.Drawing.Size(386, 17);
            this.LblUser.TabIndex = 5;
            this.LblUser.Text = "__________________________________________";
            // 
            // LblSubTitle
            // 
            this.LblSubTitle.AutoSize = true;
            this.LblSubTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSubTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(41)))), ((int)(((byte)(83)))));
            this.LblSubTitle.Location = new System.Drawing.Point(151, 41);
            this.LblSubTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblSubTitle.Name = "LblSubTitle";
            this.LblSubTitle.Size = new System.Drawing.Size(237, 91);
            this.LblSubTitle.TabIndex = 1;
            this.LblSubTitle.Text = "Login";
            // 
            // BtnIniciar
            // 
            this.BtnIniciar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnIniciar.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnIniciar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnIniciar.BorderRadius = 0;
            this.BtnIniciar.BorderSize = 0;
            this.BtnIniciar.FlatAppearance.BorderSize = 0;
            this.BtnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIniciar.ForeColor = System.Drawing.Color.White;
            this.BtnIniciar.Location = new System.Drawing.Point(180, 391);
            this.BtnIniciar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnIniciar.Name = "BtnIniciar";
            this.BtnIniciar.Size = new System.Drawing.Size(200, 49);
            this.BtnIniciar.TabIndex = 0;
            this.BtnIniciar.Text = "Iniciar";
            this.BtnIniciar.TextColor = System.Drawing.Color.White;
            this.BtnIniciar.UseVisualStyleBackColor = false;
            this.BtnIniciar.Click += new System.EventHandler(this.RJBtnIniciar_Click);
            // 
            // FrmInicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 666);
            this.Controls.Add(this.PnlMain);
            this.Controls.Add(this.PnlTitle);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmInicioSesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmInicioSesion_FormClosing);
            this.VisibleChanged += new System.EventHandler(this.FrmInicioSesion_VisibleChanged);
            this.PnlTitle.ResumeLayout(false);
            this.PnlTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PnlMain.ResumeLayout(false);
            this.PnlMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlTitle;
        private FontAwesome.Sharp.IconButton BtnMinimize;
        private FontAwesome.Sharp.IconButton BtnClose;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Panel PnlMain;
        private RJCodeAdvance.RJControls.RJButton BtnIniciar;
        private System.Windows.Forms.Label LblSubTitle;
        private System.Windows.Forms.TextBox TbxUser;
        private System.Windows.Forms.Label LblUser;
        private System.Windows.Forms.TextBox TbxPassword;
        private System.Windows.Forms.Label LblPass;
        private FontAwesome.Sharp.IconButton BtnPassword;
        private FontAwesome.Sharp.IconButton BtnPerfil;
        private MaterialSkin.Controls.MaterialCheckBox ChkRemember;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}