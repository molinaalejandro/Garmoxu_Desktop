namespace Garmoxu_Desktop
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.PnlLateral = new System.Windows.Forms.Panel();
            this.BtnUsers = new FontAwesome.Sharp.IconButton();
            this.BtnAjustes = new FontAwesome.Sharp.IconButton();
            this.PnlEncabezado = new System.Windows.Forms.Panel();
            this.PnlBody = new System.Windows.Forms.Panel();
            this.PnlMain = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.PicLogo = new System.Windows.Forms.PictureBox();
            this.PnlTitle = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.LblReloj = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnClose = new FontAwesome.Sharp.IconButton();
            this.BtnMinimize = new FontAwesome.Sharp.IconButton();
            this.BtnResize = new FontAwesome.Sharp.IconButton();
            this.TmrRelojMain = new System.Windows.Forms.Timer(this.components);
            this.BtnReservas = new FontAwesome.Sharp.IconButton();
            this.BtnPedidos = new FontAwesome.Sharp.IconButton();
            this.BtnHistorial = new FontAwesome.Sharp.IconButton();
            this.BtnPlatos = new FontAwesome.Sharp.IconButton();
            this.BtnCategoria = new FontAwesome.Sharp.IconButton();
            this.PnlCabeceraMenu = new System.Windows.Forms.TableLayoutPanel();
            this.BtnPanel = new FontAwesome.Sharp.IconButton();
            this.PicUser = new RJCodeAdvance.RJControls.RJCircularPictureBox();
            this.BtnCliente = new FontAwesome.Sharp.IconButton();
            this.PnlLateral.SuspendLayout();
            this.PnlEncabezado.SuspendLayout();
            this.PnlBody.SuspendLayout();
            this.PnlMain.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).BeginInit();
            this.PnlTitle.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.PnlCabeceraMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicUser)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlLateral
            // 
            this.PnlLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(45)))));
            this.PnlLateral.Controls.Add(this.BtnCliente);
            this.PnlLateral.Controls.Add(this.BtnCategoria);
            this.PnlLateral.Controls.Add(this.BtnPlatos);
            this.PnlLateral.Controls.Add(this.BtnHistorial);
            this.PnlLateral.Controls.Add(this.BtnReservas);
            this.PnlLateral.Controls.Add(this.BtnPedidos);
            this.PnlLateral.Controls.Add(this.BtnUsers);
            this.PnlLateral.Controls.Add(this.BtnAjustes);
            this.PnlLateral.Controls.Add(this.PnlEncabezado);
            this.PnlLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlLateral.Location = new System.Drawing.Point(0, 74);
            this.PnlLateral.Margin = new System.Windows.Forms.Padding(4);
            this.PnlLateral.Name = "PnlLateral";
            this.PnlLateral.Size = new System.Drawing.Size(250, 795);
            this.PnlLateral.TabIndex = 7;
            // 
            // BtnUsers
            // 
            this.BtnUsers.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnUsers.FlatAppearance.BorderSize = 0;
            this.BtnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUsers.Font = new System.Drawing.Font("Source Sans Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUsers.ForeColor = System.Drawing.Color.White;
            this.BtnUsers.IconChar = FontAwesome.Sharp.IconChar.UserFriends;
            this.BtnUsers.IconColor = System.Drawing.Color.DodgerBlue;
            this.BtnUsers.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnUsers.Location = new System.Drawing.Point(0, 671);
            this.BtnUsers.Margin = new System.Windows.Forms.Padding(4);
            this.BtnUsers.Name = "BtnUsers";
            this.BtnUsers.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.BtnUsers.Size = new System.Drawing.Size(250, 62);
            this.BtnUsers.TabIndex = 18;
            this.BtnUsers.Tag = "Usuarios";
            this.BtnUsers.Text = "Usuarios";
            this.BtnUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnUsers.UseVisualStyleBackColor = true;
            this.BtnUsers.Click += new System.EventHandler(this.BtnUsers_Click);
            // 
            // BtnAjustes
            // 
            this.BtnAjustes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnAjustes.FlatAppearance.BorderSize = 0;
            this.BtnAjustes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAjustes.Font = new System.Drawing.Font("Source Sans Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAjustes.ForeColor = System.Drawing.Color.White;
            this.BtnAjustes.IconChar = FontAwesome.Sharp.IconChar.Cogs;
            this.BtnAjustes.IconColor = System.Drawing.Color.DarkGray;
            this.BtnAjustes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnAjustes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAjustes.Location = new System.Drawing.Point(0, 733);
            this.BtnAjustes.Margin = new System.Windows.Forms.Padding(4);
            this.BtnAjustes.Name = "BtnAjustes";
            this.BtnAjustes.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.BtnAjustes.Size = new System.Drawing.Size(250, 62);
            this.BtnAjustes.TabIndex = 17;
            this.BtnAjustes.Tag = "Ajustes";
            this.BtnAjustes.Text = "Ajustes";
            this.BtnAjustes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAjustes.UseVisualStyleBackColor = true;
            this.BtnAjustes.Click += new System.EventHandler(this.BtnAjustes_Click);
            // 
            // PnlEncabezado
            // 
            this.PnlEncabezado.Controls.Add(this.PnlCabeceraMenu);
            this.PnlEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlEncabezado.Location = new System.Drawing.Point(0, 0);
            this.PnlEncabezado.Margin = new System.Windows.Forms.Padding(4);
            this.PnlEncabezado.Name = "PnlEncabezado";
            this.PnlEncabezado.Size = new System.Drawing.Size(250, 155);
            this.PnlEncabezado.TabIndex = 11;
            // 
            // PnlBody
            // 
            this.PnlBody.Controls.Add(this.PnlMain);
            this.PnlBody.Controls.Add(this.PnlLateral);
            this.PnlBody.Controls.Add(this.PnlTitle);
            this.PnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlBody.Location = new System.Drawing.Point(0, 0);
            this.PnlBody.Margin = new System.Windows.Forms.Padding(4);
            this.PnlBody.Name = "PnlBody";
            this.PnlBody.Size = new System.Drawing.Size(1410, 869);
            this.PnlBody.TabIndex = 7;
            // 
            // PnlMain
            // 
            this.PnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(54)))), ((int)(((byte)(58)))));
            this.PnlMain.Controls.Add(this.tableLayoutPanel1);
            this.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlMain.Location = new System.Drawing.Point(250, 74);
            this.PnlMain.Margin = new System.Windows.Forms.Padding(4);
            this.PnlMain.Name = "PnlMain";
            this.PnlMain.Size = new System.Drawing.Size(1160, 795);
            this.PnlMain.TabIndex = 8;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Controls.Add(this.PicLogo, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1160, 795);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // PicLogo
            // 
            this.PicLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PicLogo.Image = global::Garmoxu_Desktop.Properties.Resources.Garmoxu_Logo_Circle_New_Red_Less_Opacity;
            this.PicLogo.Location = new System.Drawing.Point(174, 119);
            this.PicLogo.Margin = new System.Windows.Forms.Padding(0);
            this.PicLogo.Name = "PicLogo";
            this.PicLogo.Size = new System.Drawing.Size(812, 556);
            this.PicLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicLogo.TabIndex = 6;
            this.PicLogo.TabStop = false;
            // 
            // PnlTitle
            // 
            this.PnlTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(45)))));
            this.PnlTitle.Controls.Add(this.tableLayoutPanel2);
            this.PnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlTitle.Location = new System.Drawing.Point(0, 0);
            this.PnlTitle.Margin = new System.Windows.Forms.Padding(0);
            this.PnlTitle.Name = "PnlTitle";
            this.PnlTitle.Size = new System.Drawing.Size(1410, 74);
            this.PnlTitle.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.Controls.Add(this.LblTitulo, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.LblReloj, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1410, 74);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.LblTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblTitulo.Font = new System.Drawing.Font("Source Sans Pro", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.ForeColor = System.Drawing.Color.Silver;
            this.LblTitulo.Location = new System.Drawing.Point(14, 0);
            this.LblTitulo.Margin = new System.Windows.Forms.Padding(14, 0, 4, 0);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(123, 74);
            this.LblTitulo.TabIndex = 0;
            this.LblTitulo.Text = "Garmoxu";
            this.LblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblReloj
            // 
            this.LblReloj.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblReloj.AutoSize = true;
            this.LblReloj.BackColor = System.Drawing.Color.Transparent;
            this.LblReloj.Font = new System.Drawing.Font("Source Sans Pro", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblReloj.ForeColor = System.Drawing.Color.White;
            this.LblReloj.Location = new System.Drawing.Point(144, 0);
            this.LblReloj.Name = "LblReloj";
            this.LblReloj.Size = new System.Drawing.Size(1122, 74);
            this.LblReloj.TabIndex = 5;
            this.LblReloj.Text = "00:00";
            this.LblReloj.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.BtnClose, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.BtnMinimize, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.BtnResize, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(1272, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(138, 74);
            this.tableLayoutPanel3.TabIndex = 6;
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
            this.BtnClose.ForeColor = System.Drawing.Color.Silver;
            this.BtnClose.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.BtnClose.IconColor = System.Drawing.Color.Silver;
            this.BtnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnClose.IconSize = 25;
            this.BtnClose.Location = new System.Drawing.Point(85, 0);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(0);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(53, 74);
            this.BtnClose.TabIndex = 11;
            this.BtnClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnClose.UseVisualStyleBackColor = false;
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
            this.BtnMinimize.ForeColor = System.Drawing.Color.Silver;
            this.BtnMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.BtnMinimize.IconColor = System.Drawing.Color.Silver;
            this.BtnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnMinimize.IconSize = 20;
            this.BtnMinimize.Location = new System.Drawing.Point(0, 0);
            this.BtnMinimize.Margin = new System.Windows.Forms.Padding(0);
            this.BtnMinimize.Name = "BtnMinimize";
            this.BtnMinimize.Size = new System.Drawing.Size(52, 74);
            this.BtnMinimize.TabIndex = 10;
            this.BtnMinimize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMinimize.UseVisualStyleBackColor = false;
            this.BtnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // BtnResize
            // 
            this.BtnResize.BackColor = System.Drawing.Color.Transparent;
            this.BtnResize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnResize.FlatAppearance.BorderSize = 0;
            this.BtnResize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnResize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnResize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnResize.ForeColor = System.Drawing.Color.Silver;
            this.BtnResize.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            this.BtnResize.IconColor = System.Drawing.Color.Silver;
            this.BtnResize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnResize.IconSize = 20;
            this.BtnResize.Location = new System.Drawing.Point(52, 0);
            this.BtnResize.Margin = new System.Windows.Forms.Padding(0);
            this.BtnResize.Name = "BtnResize";
            this.BtnResize.Size = new System.Drawing.Size(33, 74);
            this.BtnResize.TabIndex = 9;
            this.BtnResize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnResize.UseVisualStyleBackColor = false;
            this.BtnResize.Visible = false;
            // 
            // TmrRelojMain
            // 
            this.TmrRelojMain.Enabled = true;
            this.TmrRelojMain.Interval = 1000;
            this.TmrRelojMain.Tick += new System.EventHandler(this.TmrRelojMain_Tick);
            // 
            // BtnReservas
            // 
            this.BtnReservas.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnReservas.FlatAppearance.BorderSize = 0;
            this.BtnReservas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReservas.Font = new System.Drawing.Font("Source Sans Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReservas.ForeColor = System.Drawing.Color.White;
            this.BtnReservas.IconChar = FontAwesome.Sharp.IconChar.CalendarAlt;
            this.BtnReservas.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(215)))), ((int)(((byte)(255)))));
            this.BtnReservas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnReservas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnReservas.Location = new System.Drawing.Point(0, 217);
            this.BtnReservas.Margin = new System.Windows.Forms.Padding(4);
            this.BtnReservas.Name = "BtnReservas";
            this.BtnReservas.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.BtnReservas.Size = new System.Drawing.Size(250, 62);
            this.BtnReservas.TabIndex = 24;
            this.BtnReservas.Tag = "Reservas";
            this.BtnReservas.Text = "Reservas";
            this.BtnReservas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnReservas.UseVisualStyleBackColor = true;
            this.BtnReservas.Click += new System.EventHandler(this.BtnReservas_Click);
            // 
            // BtnPedidos
            // 
            this.BtnPedidos.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnPedidos.FlatAppearance.BorderSize = 0;
            this.BtnPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPedidos.Font = new System.Drawing.Font("Source Sans Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPedidos.ForeColor = System.Drawing.Color.White;
            this.BtnPedidos.IconChar = FontAwesome.Sharp.IconChar.PencilAlt;
            this.BtnPedidos.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(2)))));
            this.BtnPedidos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnPedidos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPedidos.Location = new System.Drawing.Point(0, 155);
            this.BtnPedidos.Margin = new System.Windows.Forms.Padding(4);
            this.BtnPedidos.Name = "BtnPedidos";
            this.BtnPedidos.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.BtnPedidos.Size = new System.Drawing.Size(250, 62);
            this.BtnPedidos.TabIndex = 21;
            this.BtnPedidos.Tag = "Pedidos";
            this.BtnPedidos.Text = "Pedidos";
            this.BtnPedidos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnPedidos.UseVisualStyleBackColor = true;
            this.BtnPedidos.Click += new System.EventHandler(this.BtnPedidos_Click);
            // 
            // BtnHistorial
            // 
            this.BtnHistorial.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnHistorial.FlatAppearance.BorderSize = 0;
            this.BtnHistorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHistorial.Font = new System.Drawing.Font("Source Sans Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHistorial.ForeColor = System.Drawing.Color.White;
            this.BtnHistorial.IconChar = FontAwesome.Sharp.IconChar.Tasks;
            this.BtnHistorial.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(219)))), ((int)(((byte)(59)))));
            this.BtnHistorial.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnHistorial.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnHistorial.Location = new System.Drawing.Point(0, 279);
            this.BtnHistorial.Margin = new System.Windows.Forms.Padding(4);
            this.BtnHistorial.Name = "BtnHistorial";
            this.BtnHistorial.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.BtnHistorial.Size = new System.Drawing.Size(250, 62);
            this.BtnHistorial.TabIndex = 28;
            this.BtnHistorial.Tag = "Historial";
            this.BtnHistorial.Text = "Historial";
            this.BtnHistorial.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnHistorial.UseVisualStyleBackColor = true;
            this.BtnHistorial.Click += new System.EventHandler(this.BtnHistorial_Click);
            // 
            // BtnPlatos
            // 
            this.BtnPlatos.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnPlatos.FlatAppearance.BorderSize = 0;
            this.BtnPlatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPlatos.Font = new System.Drawing.Font("Source Sans Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPlatos.ForeColor = System.Drawing.Color.White;
            this.BtnPlatos.IconChar = FontAwesome.Sharp.IconChar.Hamburger;
            this.BtnPlatos.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(171)))), ((int)(((byte)(88)))));
            this.BtnPlatos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnPlatos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPlatos.Location = new System.Drawing.Point(0, 341);
            this.BtnPlatos.Margin = new System.Windows.Forms.Padding(4);
            this.BtnPlatos.Name = "BtnPlatos";
            this.BtnPlatos.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.BtnPlatos.Size = new System.Drawing.Size(250, 62);
            this.BtnPlatos.TabIndex = 31;
            this.BtnPlatos.Tag = "Platos";
            this.BtnPlatos.Text = "Platos";
            this.BtnPlatos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnPlatos.UseVisualStyleBackColor = true;
            this.BtnPlatos.Click += new System.EventHandler(this.BtnPlatos_Click);
            // 
            // BtnCategoria
            // 
            this.BtnCategoria.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnCategoria.FlatAppearance.BorderSize = 0;
            this.BtnCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCategoria.Font = new System.Drawing.Font("Source Sans Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCategoria.ForeColor = System.Drawing.Color.White;
            this.BtnCategoria.IconChar = FontAwesome.Sharp.IconChar.Tag;
            this.BtnCategoria.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(93)))), ((int)(((byte)(169)))));
            this.BtnCategoria.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnCategoria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCategoria.Location = new System.Drawing.Point(0, 403);
            this.BtnCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCategoria.Name = "BtnCategoria";
            this.BtnCategoria.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.BtnCategoria.Size = new System.Drawing.Size(250, 62);
            this.BtnCategoria.TabIndex = 32;
            this.BtnCategoria.Tag = "Categorías";
            this.BtnCategoria.Text = "Categorías";
            this.BtnCategoria.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCategoria.UseVisualStyleBackColor = true;
            this.BtnCategoria.Click += new System.EventHandler(this.BtnCategoria_Click);
            // 
            // PnlCabeceraMenu
            // 
            this.PnlCabeceraMenu.ColumnCount = 2;
            this.PnlCabeceraMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.PnlCabeceraMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.PnlCabeceraMenu.Controls.Add(this.PicUser, 0, 0);
            this.PnlCabeceraMenu.Controls.Add(this.BtnPanel, 1, 0);
            this.PnlCabeceraMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlCabeceraMenu.Location = new System.Drawing.Point(0, 0);
            this.PnlCabeceraMenu.Name = "PnlCabeceraMenu";
            this.PnlCabeceraMenu.RowCount = 1;
            this.PnlCabeceraMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PnlCabeceraMenu.Size = new System.Drawing.Size(250, 155);
            this.PnlCabeceraMenu.TabIndex = 1;
            // 
            // BtnPanel
            // 
            this.BtnPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnPanel.FlatAppearance.BorderSize = 0;
            this.BtnPanel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(74)))), ((int)(((byte)(78)))));
            this.BtnPanel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(54)))), ((int)(((byte)(58)))));
            this.BtnPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPanel.Font = new System.Drawing.Font("Source Sans Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPanel.ForeColor = System.Drawing.Color.White;
            this.BtnPanel.IconChar = FontAwesome.Sharp.IconChar.ChevronLeft;
            this.BtnPanel.IconColor = System.Drawing.Color.Silver;
            this.BtnPanel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnPanel.Location = new System.Drawing.Point(175, 0);
            this.BtnPanel.Margin = new System.Windows.Forms.Padding(0);
            this.BtnPanel.Name = "BtnPanel";
            this.BtnPanel.Size = new System.Drawing.Size(75, 155);
            this.BtnPanel.TabIndex = 22;
            this.BtnPanel.Tag = "";
            this.BtnPanel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnPanel.UseVisualStyleBackColor = true;
            this.BtnPanel.Click += new System.EventHandler(this.btnPanel_Click);
            // 
            // PicUser
            // 
            this.PicUser.BackColor = System.Drawing.Color.Silver;
            this.PicUser.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.PicUser.BorderColor = System.Drawing.Color.Silver;
            this.PicUser.BorderColor2 = System.Drawing.Color.Silver;
            this.PicUser.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.PicUser.BorderSize = 3;
            this.PicUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PicUser.GradientAngle = 50F;
            this.PicUser.Image = global::Garmoxu_Desktop.Properties.Resources.User_Default_Icon;
            this.PicUser.Location = new System.Drawing.Point(25, 0);
            this.PicUser.Margin = new System.Windows.Forms.Padding(25, 0, 3, 0);
            this.PicUser.Name = "PicUser";
            this.PicUser.Size = new System.Drawing.Size(147, 147);
            this.PicUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicUser.TabIndex = 24;
            this.PicUser.TabStop = false;
            this.PicUser.Click += new System.EventHandler(this.PicUser_Click);
            this.PicUser.MouseEnter += new System.EventHandler(this.PicUser_MouseEnter);
            this.PicUser.MouseLeave += new System.EventHandler(this.PicUser_MouseLeave);
            // 
            // BtnCliente
            // 
            this.BtnCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnCliente.FlatAppearance.BorderSize = 0;
            this.BtnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCliente.Font = new System.Drawing.Font("Source Sans Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCliente.ForeColor = System.Drawing.Color.White;
            this.BtnCliente.IconChar = FontAwesome.Sharp.IconChar.Portrait;
            this.BtnCliente.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(165)))), ((int)(((byte)(255)))));
            this.BtnCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCliente.Location = new System.Drawing.Point(0, 465);
            this.BtnCliente.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCliente.Name = "BtnCliente";
            this.BtnCliente.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.BtnCliente.Size = new System.Drawing.Size(250, 62);
            this.BtnCliente.TabIndex = 33;
            this.BtnCliente.Tag = "Clientes";
            this.BtnCliente.Text = "Cliente";
            this.BtnCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCliente.UseVisualStyleBackColor = true;
            this.BtnCliente.Click += new System.EventHandler(this.BtnCliente_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1410, 869);
            this.Controls.Add(this.PnlBody);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMain";
            this.Text = "Menú principal - Garmoxu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.PnlLateral.ResumeLayout(false);
            this.PnlEncabezado.ResumeLayout(false);
            this.PnlBody.ResumeLayout(false);
            this.PnlMain.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).EndInit();
            this.PnlTitle.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.PnlCabeceraMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlBody;
        private System.Windows.Forms.Panel PnlLateral;
        private FontAwesome.Sharp.IconButton BtnAjustes;
        private System.Windows.Forms.Panel PnlEncabezado;
        private FontAwesome.Sharp.IconButton BtnUsers;
        private System.Windows.Forms.Panel PnlMain;
        private System.Windows.Forms.Panel PnlTitle;
        private System.Windows.Forms.Timer TmrRelojMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox PicLogo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private FontAwesome.Sharp.IconButton BtnMinimize;
        private FontAwesome.Sharp.IconButton BtnResize;
        private System.Windows.Forms.Label LblReloj;
        private FontAwesome.Sharp.IconButton BtnClose;
        private FontAwesome.Sharp.IconButton BtnReservas;
        private FontAwesome.Sharp.IconButton BtnCategoria;
        private FontAwesome.Sharp.IconButton BtnPlatos;
        private FontAwesome.Sharp.IconButton BtnHistorial;
        private FontAwesome.Sharp.IconButton BtnPedidos;
        private System.Windows.Forms.TableLayoutPanel PnlCabeceraMenu;
        private RJCodeAdvance.RJControls.RJCircularPictureBox PicUser;
        private FontAwesome.Sharp.IconButton BtnPanel;
        private FontAwesome.Sharp.IconButton BtnCliente;
    }
}