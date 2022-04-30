namespace Garmoxu_Project
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
            this.PnlTitle = new System.Windows.Forms.Panel();
            this.BtnCerrarSesion = new FontAwesome.Sharp.IconButton();
            this.PicLogo = new System.Windows.Forms.PictureBox();
            this.BtnMinimize = new FontAwesome.Sharp.IconButton();
            this.BtnResize = new FontAwesome.Sharp.IconButton();
            this.BtnClose = new FontAwesome.Sharp.IconButton();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.PnlLateral = new System.Windows.Forms.Panel();
            this.BtnClientes = new FontAwesome.Sharp.IconButton();
            this.BtnCategorias = new FontAwesome.Sharp.IconButton();
            this.BtnUsuarios = new FontAwesome.Sharp.IconButton();
            this.BtnAjustes = new FontAwesome.Sharp.IconButton();
            this.BtnPlatos = new FontAwesome.Sharp.IconButton();
            this.pnlSubMenu = new System.Windows.Forms.Panel();
            this.BtnEstadisticas = new FontAwesome.Sharp.IconButton();
            this.BtnHistorialPedidos = new FontAwesome.Sharp.IconButton();
            this.BtnHistorial = new FontAwesome.Sharp.IconButton();
            this.BtnReservas = new FontAwesome.Sharp.IconButton();
            this.BtnPedidos = new FontAwesome.Sharp.IconButton();
            this.PnlEncabezado = new System.Windows.Forms.Panel();
            this.BtnPanel = new FontAwesome.Sharp.IconButton();
            this.PicUser = new RJCodeAdvance.RJControls.RJCircularPictureBox();
            this.PnlMain = new System.Windows.Forms.Panel();
            this.PnlBody = new System.Windows.Forms.Panel();
            this.PnlTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).BeginInit();
            this.PnlLateral.SuspendLayout();
            this.pnlSubMenu.SuspendLayout();
            this.PnlEncabezado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicUser)).BeginInit();
            this.PnlBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlTitle
            // 
            this.PnlTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(45)))));
            this.PnlTitle.Controls.Add(this.BtnCerrarSesion);
            this.PnlTitle.Controls.Add(this.PicLogo);
            this.PnlTitle.Controls.Add(this.BtnMinimize);
            this.PnlTitle.Controls.Add(this.BtnResize);
            this.PnlTitle.Controls.Add(this.BtnClose);
            this.PnlTitle.Controls.Add(this.LblTitulo);
            this.PnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlTitle.Location = new System.Drawing.Point(0, 0);
            this.PnlTitle.Margin = new System.Windows.Forms.Padding(4);
            this.PnlTitle.Name = "PnlTitle";
            this.PnlTitle.Size = new System.Drawing.Size(1685, 74);
            this.PnlTitle.TabIndex = 1;
            this.PnlTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitle_MouseDown);
            // 
            // BtnCerrarSesion
            // 
            this.BtnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.BtnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrarSesion.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.BtnCerrarSesion.IconColor = System.Drawing.Color.Red;
            this.BtnCerrarSesion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnCerrarSesion.Location = new System.Drawing.Point(360, 21);
            this.BtnCerrarSesion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnCerrarSesion.Name = "BtnCerrarSesion";
            this.BtnCerrarSesion.Size = new System.Drawing.Size(81, 36);
            this.BtnCerrarSesion.TabIndex = 21;
            this.BtnCerrarSesion.UseVisualStyleBackColor = true;
            // 
            // PicLogo
            // 
            this.PicLogo.Location = new System.Drawing.Point(4, 4);
            this.PicLogo.Margin = new System.Windows.Forms.Padding(4);
            this.PicLogo.Name = "PicLogo";
            this.PicLogo.Size = new System.Drawing.Size(133, 62);
            this.PicLogo.TabIndex = 5;
            this.PicLogo.TabStop = false;
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
            this.BtnMinimize.Location = new System.Drawing.Point(1485, 0);
            this.BtnMinimize.Margin = new System.Windows.Forms.Padding(4);
            this.BtnMinimize.Name = "BtnMinimize";
            this.BtnMinimize.Size = new System.Drawing.Size(67, 37);
            this.BtnMinimize.TabIndex = 4;
            this.BtnMinimize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMinimize.UseVisualStyleBackColor = false;
            this.BtnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            this.BtnMinimize.MouseEnter += new System.EventHandler(this.BtnMinimize_MouseEnter);
            this.BtnMinimize.MouseLeave += new System.EventHandler(this.BtnMinimize_MouseLeave);
            // 
            // BtnResize
            // 
            this.BtnResize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnResize.BackColor = System.Drawing.Color.Transparent;
            this.BtnResize.FlatAppearance.BorderSize = 0;
            this.BtnResize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnResize.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            this.BtnResize.IconColor = System.Drawing.Color.White;
            this.BtnResize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnResize.IconSize = 20;
            this.BtnResize.Location = new System.Drawing.Point(1552, 0);
            this.BtnResize.Margin = new System.Windows.Forms.Padding(4);
            this.BtnResize.Name = "BtnResize";
            this.BtnResize.Size = new System.Drawing.Size(67, 37);
            this.BtnResize.TabIndex = 4;
            this.BtnResize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnResize.UseVisualStyleBackColor = false;
            this.BtnResize.Click += new System.EventHandler(this.btnResize_Click);
            this.BtnResize.MouseEnter += new System.EventHandler(this.BtnResize_MouseEnter);
            this.BtnResize.MouseLeave += new System.EventHandler(this.BtnResize_MouseLeave);
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
            this.BtnClose.Location = new System.Drawing.Point(1619, 0);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(4);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(67, 37);
            this.BtnClose.TabIndex = 3;
            this.BtnClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.BtnClose.MouseEnter += new System.EventHandler(this.BtnClose_MouseEnter);
            this.BtnClose.MouseLeave += new System.EventHandler(this.BtnClose_MouseLeave);
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.LblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(41)))), ((int)(((byte)(83)))));
            this.LblTitulo.Location = new System.Drawing.Point(145, 11);
            this.LblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(192, 46);
            this.LblTitulo.TabIndex = 0;
            this.LblTitulo.Text = "Garmoxu";
            // 
            // PnlLateral
            // 
            this.PnlLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(45)))));
            this.PnlLateral.Controls.Add(this.BtnClientes);
            this.PnlLateral.Controls.Add(this.BtnCategorias);
            this.PnlLateral.Controls.Add(this.BtnUsuarios);
            this.PnlLateral.Controls.Add(this.BtnAjustes);
            this.PnlLateral.Controls.Add(this.BtnPlatos);
            this.PnlLateral.Controls.Add(this.pnlSubMenu);
            this.PnlLateral.Controls.Add(this.BtnHistorial);
            this.PnlLateral.Controls.Add(this.BtnReservas);
            this.PnlLateral.Controls.Add(this.BtnPedidos);
            this.PnlLateral.Controls.Add(this.PnlEncabezado);
            this.PnlLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlLateral.Location = new System.Drawing.Point(0, 74);
            this.PnlLateral.Margin = new System.Windows.Forms.Padding(4);
            this.PnlLateral.Name = "PnlLateral";
            this.PnlLateral.Size = new System.Drawing.Size(267, 764);
            this.PnlLateral.TabIndex = 7;
            // 
            // BtnClientes
            // 
            this.BtnClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnClientes.FlatAppearance.BorderSize = 0;
            this.BtnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(41)))), ((int)(((byte)(83)))));
            this.BtnClientes.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
            this.BtnClientes.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(41)))), ((int)(((byte)(83)))));
            this.BtnClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnClientes.Location = new System.Drawing.Point(0, 530);
            this.BtnClientes.Margin = new System.Windows.Forms.Padding(4);
            this.BtnClientes.Name = "BtnClientes";
            this.BtnClientes.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.BtnClientes.Size = new System.Drawing.Size(267, 62);
            this.BtnClientes.TabIndex = 19;
            this.BtnClientes.Tag = "Clientes";
            this.BtnClientes.Text = "Clientes";
            this.BtnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnClientes.UseVisualStyleBackColor = true;
            this.BtnClientes.Click += new System.EventHandler(this.BtnCliente_Click);
            // 
            // BtnCategorias
            // 
            this.BtnCategorias.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnCategorias.FlatAppearance.BorderSize = 0;
            this.BtnCategorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCategorias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(41)))), ((int)(((byte)(83)))));
            this.BtnCategorias.IconChar = FontAwesome.Sharp.IconChar.Tag;
            this.BtnCategorias.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(41)))), ((int)(((byte)(83)))));
            this.BtnCategorias.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnCategorias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCategorias.Location = new System.Drawing.Point(0, 468);
            this.BtnCategorias.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCategorias.Name = "BtnCategorias";
            this.BtnCategorias.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.BtnCategorias.Size = new System.Drawing.Size(267, 62);
            this.BtnCategorias.TabIndex = 20;
            this.BtnCategorias.Tag = "Categoria";
            this.BtnCategorias.Text = "Categorias";
            this.BtnCategorias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCategorias.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCategorias.UseVisualStyleBackColor = true;
            this.BtnCategorias.Click += new System.EventHandler(this.BtnCategoria_Click);
            // 
            // BtnUsuarios
            // 
            this.BtnUsuarios.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnUsuarios.FlatAppearance.BorderSize = 0;
            this.BtnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUsuarios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(196)))), ((int)(((byte)(255)))));
            this.BtnUsuarios.IconChar = FontAwesome.Sharp.IconChar.UserFriends;
            this.BtnUsuarios.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(196)))), ((int)(((byte)(255)))));
            this.BtnUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnUsuarios.Location = new System.Drawing.Point(0, 640);
            this.BtnUsuarios.Margin = new System.Windows.Forms.Padding(4);
            this.BtnUsuarios.Name = "BtnUsuarios";
            this.BtnUsuarios.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.BtnUsuarios.Size = new System.Drawing.Size(267, 62);
            this.BtnUsuarios.TabIndex = 18;
            this.BtnUsuarios.Tag = "Usuarios";
            this.BtnUsuarios.Text = "Usuarios";
            this.BtnUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnUsuarios.UseVisualStyleBackColor = true;
            this.BtnUsuarios.Click += new System.EventHandler(this.BtnUsers_Click);
            // 
            // BtnAjustes
            // 
            this.BtnAjustes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnAjustes.FlatAppearance.BorderSize = 0;
            this.BtnAjustes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAjustes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAjustes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(105)))), ((int)(((byte)(216)))));
            this.BtnAjustes.IconChar = FontAwesome.Sharp.IconChar.Cog;
            this.BtnAjustes.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(105)))), ((int)(((byte)(216)))));
            this.BtnAjustes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnAjustes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAjustes.Location = new System.Drawing.Point(0, 702);
            this.BtnAjustes.Margin = new System.Windows.Forms.Padding(4);
            this.BtnAjustes.Name = "BtnAjustes";
            this.BtnAjustes.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.BtnAjustes.Size = new System.Drawing.Size(267, 62);
            this.BtnAjustes.TabIndex = 17;
            this.BtnAjustes.Tag = "Ajustes";
            this.BtnAjustes.Text = "Ajustes";
            this.BtnAjustes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAjustes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAjustes.UseVisualStyleBackColor = true;
            this.BtnAjustes.Click += new System.EventHandler(this.BtnAjustes_Click);
            // 
            // BtnPlatos
            // 
            this.BtnPlatos.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnPlatos.FlatAppearance.BorderSize = 0;
            this.BtnPlatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPlatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPlatos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(41)))), ((int)(((byte)(83)))));
            this.BtnPlatos.IconChar = FontAwesome.Sharp.IconChar.Utensils;
            this.BtnPlatos.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(41)))), ((int)(((byte)(83)))));
            this.BtnPlatos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnPlatos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPlatos.Location = new System.Drawing.Point(0, 406);
            this.BtnPlatos.Margin = new System.Windows.Forms.Padding(4);
            this.BtnPlatos.Name = "BtnPlatos";
            this.BtnPlatos.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.BtnPlatos.Size = new System.Drawing.Size(267, 62);
            this.BtnPlatos.TabIndex = 16;
            this.BtnPlatos.Tag = "Platos";
            this.BtnPlatos.Text = "Platos";
            this.BtnPlatos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPlatos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnPlatos.UseVisualStyleBackColor = true;
            this.BtnPlatos.Click += new System.EventHandler(this.BtnPlatos_Click);
            // 
            // pnlSubMenu
            // 
            this.pnlSubMenu.Controls.Add(this.BtnEstadisticas);
            this.pnlSubMenu.Controls.Add(this.BtnHistorialPedidos);
            this.pnlSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubMenu.Location = new System.Drawing.Point(0, 287);
            this.pnlSubMenu.Margin = new System.Windows.Forms.Padding(4);
            this.pnlSubMenu.Name = "pnlSubMenu";
            this.pnlSubMenu.Size = new System.Drawing.Size(267, 119);
            this.pnlSubMenu.TabIndex = 15;
            this.pnlSubMenu.Visible = false;
            // 
            // BtnEstadisticas
            // 
            this.BtnEstadisticas.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnEstadisticas.FlatAppearance.BorderSize = 0;
            this.BtnEstadisticas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEstadisticas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEstadisticas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(41)))), ((int)(((byte)(83)))));
            this.BtnEstadisticas.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.BtnEstadisticas.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(41)))), ((int)(((byte)(83)))));
            this.BtnEstadisticas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnEstadisticas.IconSize = 24;
            this.BtnEstadisticas.Location = new System.Drawing.Point(0, 55);
            this.BtnEstadisticas.Margin = new System.Windows.Forms.Padding(4);
            this.BtnEstadisticas.Name = "BtnEstadisticas";
            this.BtnEstadisticas.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.BtnEstadisticas.Size = new System.Drawing.Size(267, 55);
            this.BtnEstadisticas.TabIndex = 8;
            this.BtnEstadisticas.Tag = "Estadisticas";
            this.BtnEstadisticas.Text = "Estadisticas";
            this.BtnEstadisticas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEstadisticas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnEstadisticas.UseVisualStyleBackColor = true;
            this.BtnEstadisticas.Click += new System.EventHandler(this.BtnEstadisticas_Click);
            // 
            // BtnHistorialPedidos
            // 
            this.BtnHistorialPedidos.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnHistorialPedidos.FlatAppearance.BorderSize = 0;
            this.BtnHistorialPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHistorialPedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHistorialPedidos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(41)))), ((int)(((byte)(83)))));
            this.BtnHistorialPedidos.IconChar = FontAwesome.Sharp.IconChar.Wpforms;
            this.BtnHistorialPedidos.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(41)))), ((int)(((byte)(83)))));
            this.BtnHistorialPedidos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnHistorialPedidos.IconSize = 24;
            this.BtnHistorialPedidos.Location = new System.Drawing.Point(0, 0);
            this.BtnHistorialPedidos.Margin = new System.Windows.Forms.Padding(4);
            this.BtnHistorialPedidos.Name = "BtnHistorialPedidos";
            this.BtnHistorialPedidos.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.BtnHistorialPedidos.Size = new System.Drawing.Size(267, 55);
            this.BtnHistorialPedidos.TabIndex = 6;
            this.BtnHistorialPedidos.Tag = "Pedidos       ";
            this.BtnHistorialPedidos.Text = "Pedidos       ";
            this.BtnHistorialPedidos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnHistorialPedidos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnHistorialPedidos.UseVisualStyleBackColor = true;
            this.BtnHistorialPedidos.Click += new System.EventHandler(this.BtnHistorialPedidos_Click);
            // 
            // BtnHistorial
            // 
            this.BtnHistorial.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnHistorial.FlatAppearance.BorderSize = 0;
            this.BtnHistorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHistorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHistorial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(41)))), ((int)(((byte)(83)))));
            this.BtnHistorial.IconChar = FontAwesome.Sharp.IconChar.Tasks;
            this.BtnHistorial.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(41)))), ((int)(((byte)(83)))));
            this.BtnHistorial.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnHistorial.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnHistorial.Location = new System.Drawing.Point(0, 225);
            this.BtnHistorial.Margin = new System.Windows.Forms.Padding(4);
            this.BtnHistorial.Name = "BtnHistorial";
            this.BtnHistorial.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.BtnHistorial.Size = new System.Drawing.Size(267, 62);
            this.BtnHistorial.TabIndex = 14;
            this.BtnHistorial.Tag = "Historial";
            this.BtnHistorial.Text = "Historial";
            this.BtnHistorial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnHistorial.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnHistorial.UseVisualStyleBackColor = true;
            this.BtnHistorial.Click += new System.EventHandler(this.BtnHistorial_Click);
            // 
            // BtnReservas
            // 
            this.BtnReservas.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnReservas.FlatAppearance.BorderSize = 0;
            this.BtnReservas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReservas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReservas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(41)))), ((int)(((byte)(83)))));
            this.BtnReservas.IconChar = FontAwesome.Sharp.IconChar.CalendarAlt;
            this.BtnReservas.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(41)))), ((int)(((byte)(83)))));
            this.BtnReservas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnReservas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnReservas.Location = new System.Drawing.Point(0, 163);
            this.BtnReservas.Margin = new System.Windows.Forms.Padding(4);
            this.BtnReservas.Name = "BtnReservas";
            this.BtnReservas.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.BtnReservas.Size = new System.Drawing.Size(267, 62);
            this.BtnReservas.TabIndex = 13;
            this.BtnReservas.Tag = "Reservas";
            this.BtnReservas.Text = "Reservas";
            this.BtnReservas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnReservas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnReservas.UseVisualStyleBackColor = true;
            this.BtnReservas.Click += new System.EventHandler(this.BtnReservas_Click);
            // 
            // BtnPedidos
            // 
            this.BtnPedidos.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnPedidos.FlatAppearance.BorderSize = 0;
            this.BtnPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPedidos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(41)))), ((int)(((byte)(83)))));
            this.BtnPedidos.IconChar = FontAwesome.Sharp.IconChar.Receipt;
            this.BtnPedidos.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(41)))), ((int)(((byte)(83)))));
            this.BtnPedidos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnPedidos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPedidos.Location = new System.Drawing.Point(0, 101);
            this.BtnPedidos.Margin = new System.Windows.Forms.Padding(4);
            this.BtnPedidos.Name = "BtnPedidos";
            this.BtnPedidos.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.BtnPedidos.Size = new System.Drawing.Size(267, 62);
            this.BtnPedidos.TabIndex = 12;
            this.BtnPedidos.Tag = "Pedidos";
            this.BtnPedidos.Text = "Pedidos";
            this.BtnPedidos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPedidos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnPedidos.UseVisualStyleBackColor = true;
            this.BtnPedidos.Click += new System.EventHandler(this.BtnPedidos_Click);
            // 
            // PnlEncabezado
            // 
            this.PnlEncabezado.Controls.Add(this.BtnPanel);
            this.PnlEncabezado.Controls.Add(this.PicUser);
            this.PnlEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlEncabezado.Location = new System.Drawing.Point(0, 0);
            this.PnlEncabezado.Margin = new System.Windows.Forms.Padding(4);
            this.PnlEncabezado.Name = "PnlEncabezado";
            this.PnlEncabezado.Size = new System.Drawing.Size(267, 101);
            this.PnlEncabezado.TabIndex = 11;
            // 
            // BtnPanel
            // 
            this.BtnPanel.BackColor = System.Drawing.Color.Transparent;
            this.BtnPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnPanel.FlatAppearance.BorderSize = 0;
            this.BtnPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPanel.IconChar = FontAwesome.Sharp.IconChar.Bars;
            this.BtnPanel.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(41)))), ((int)(((byte)(83)))));
            this.BtnPanel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnPanel.IconSize = 30;
            this.BtnPanel.Location = new System.Drawing.Point(175, 0);
            this.BtnPanel.Margin = new System.Windows.Forms.Padding(4);
            this.BtnPanel.Name = "BtnPanel";
            this.BtnPanel.Size = new System.Drawing.Size(92, 101);
            this.BtnPanel.TabIndex = 5;
            this.BtnPanel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPanel.UseVisualStyleBackColor = false;
            this.BtnPanel.Click += new System.EventHandler(this.btnPanel_Click);
            // 
            // PicUser
            // 
            this.PicUser.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.PicUser.BorderColor = System.Drawing.Color.RoyalBlue;
            this.PicUser.BorderColor2 = System.Drawing.Color.HotPink;
            this.PicUser.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.PicUser.BorderSize = 2;
            this.PicUser.GradientAngle = 50F;
            this.PicUser.Location = new System.Drawing.Point(36, 4);
            this.PicUser.Margin = new System.Windows.Forms.Padding(4);
            this.PicUser.Name = "PicUser";
            this.PicUser.Size = new System.Drawing.Size(93, 93);
            this.PicUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicUser.TabIndex = 4;
            this.PicUser.TabStop = false;
            // 
            // PnlMain
            // 
            this.PnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(54)))), ((int)(((byte)(58)))));
            this.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlMain.Location = new System.Drawing.Point(267, 74);
            this.PnlMain.Margin = new System.Windows.Forms.Padding(4);
            this.PnlMain.Name = "PnlMain";
            this.PnlMain.Size = new System.Drawing.Size(1418, 764);
            this.PnlMain.TabIndex = 8;
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
            this.PnlBody.Size = new System.Drawing.Size(1685, 838);
            this.PnlBody.TabIndex = 7;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1685, 838);
            this.Controls.Add(this.PnlBody);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.PnlTitle.ResumeLayout(false);
            this.PnlTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).EndInit();
            this.PnlLateral.ResumeLayout(false);
            this.pnlSubMenu.ResumeLayout(false);
            this.PnlEncabezado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicUser)).EndInit();
            this.PnlBody.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlBody;
        private System.Windows.Forms.Panel PnlMain;
        private System.Windows.Forms.Panel PnlLateral;
        private FontAwesome.Sharp.IconButton BtnAjustes;
        private System.Windows.Forms.Panel pnlSubMenu;
        private FontAwesome.Sharp.IconButton BtnEstadisticas;
        private FontAwesome.Sharp.IconButton BtnHistorialPedidos;
        private FontAwesome.Sharp.IconButton BtnHistorial;
        private FontAwesome.Sharp.IconButton BtnReservas;
        private FontAwesome.Sharp.IconButton BtnPedidos;
        private System.Windows.Forms.Panel PnlEncabezado;
        private FontAwesome.Sharp.IconButton BtnPanel;
        private RJCodeAdvance.RJControls.RJCircularPictureBox PicUser;
        private System.Windows.Forms.Panel PnlTitle;
        private FontAwesome.Sharp.IconButton BtnMinimize;
        private FontAwesome.Sharp.IconButton BtnResize;
        private FontAwesome.Sharp.IconButton BtnClose;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.PictureBox PicLogo;
        private FontAwesome.Sharp.IconButton BtnPlatos;
        private FontAwesome.Sharp.IconButton BtnUsuarios;
        private FontAwesome.Sharp.IconButton BtnCerrarSesion;
        private FontAwesome.Sharp.IconButton BtnCategorias;
        private FontAwesome.Sharp.IconButton BtnClientes;
    }
}