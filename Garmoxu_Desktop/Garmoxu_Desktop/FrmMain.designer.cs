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
            this.TmrRelojMain = new System.Windows.Forms.Timer(this.components);
            this.PnlPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.PnlTitleBar = new System.Windows.Forms.TableLayoutPanel();
            this.PnlSeccion = new System.Windows.Forms.TableLayoutPanel();
            this.BtnCerrarSeccion = new FontAwesome.Sharp.IconButton();
            this.LblSeccion = new System.Windows.Forms.Label();
            this.PnlBotonesTitleBar = new System.Windows.Forms.TableLayoutPanel();
            this.BtnCerrar = new FontAwesome.Sharp.IconButton();
            this.BtnMinimizar = new FontAwesome.Sharp.IconButton();
            this.LblHora = new System.Windows.Forms.Label();
            this.LblFecha = new System.Windows.Forms.Label();
            this.LblMarca = new System.Windows.Forms.Label();
            this.PnlBody = new System.Windows.Forms.Panel();
            this.PnlFormularios = new System.Windows.Forms.Panel();
            this.PnlLogo = new System.Windows.Forms.TableLayoutPanel();
            this.PicLogo = new System.Windows.Forms.PictureBox();
            this.PnlMenuLateral = new System.Windows.Forms.Panel();
            this.BtnClientes = new FontAwesome.Sharp.IconButton();
            this.BtnCategorias = new FontAwesome.Sharp.IconButton();
            this.BtnPlatos = new FontAwesome.Sharp.IconButton();
            this.BtnHistorial = new FontAwesome.Sharp.IconButton();
            this.BtnReservas = new FontAwesome.Sharp.IconButton();
            this.BtnPedidos = new FontAwesome.Sharp.IconButton();
            this.BtnUsuarios = new FontAwesome.Sharp.IconButton();
            this.BtnAjustes = new FontAwesome.Sharp.IconButton();
            this.LblUsuarioActual = new System.Windows.Forms.Label();
            this.PnlCabeceraMenu = new System.Windows.Forms.TableLayoutPanel();
            this.PicUsuario = new RJCodeAdvance.RJControls.RJCircularPictureBox();
            this.BtnEsconderMenu = new FontAwesome.Sharp.IconButton();
            this.PnlPrincipal.SuspendLayout();
            this.PnlTitleBar.SuspendLayout();
            this.PnlSeccion.SuspendLayout();
            this.PnlBotonesTitleBar.SuspendLayout();
            this.PnlBody.SuspendLayout();
            this.PnlFormularios.SuspendLayout();
            this.PnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).BeginInit();
            this.PnlMenuLateral.SuspendLayout();
            this.PnlCabeceraMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // TmrRelojMain
            // 
            this.TmrRelojMain.Enabled = true;
            this.TmrRelojMain.Interval = 10000;
            this.TmrRelojMain.Tick += new System.EventHandler(this.TmrRelojMain_Tick);
            // 
            // PnlPrincipal
            // 
            this.PnlPrincipal.ColumnCount = 1;
            this.PnlPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.PnlPrincipal.Controls.Add(this.PnlTitleBar, 0, 0);
            this.PnlPrincipal.Controls.Add(this.PnlBody, 0, 1);
            this.PnlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlPrincipal.Location = new System.Drawing.Point(0, 0);
            this.PnlPrincipal.Margin = new System.Windows.Forms.Padding(0);
            this.PnlPrincipal.Name = "PnlPrincipal";
            this.PnlPrincipal.RowCount = 2;
            this.PnlPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.PnlPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PnlPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.PnlPrincipal.Size = new System.Drawing.Size(1924, 1055);
            this.PnlPrincipal.TabIndex = 7;
            // 
            // PnlTitleBar
            // 
            this.PnlTitleBar.ColumnCount = 9;
            this.PnlTitleBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.PnlTitleBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PnlTitleBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.PnlTitleBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.PnlTitleBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.PnlTitleBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.PnlTitleBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.PnlTitleBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PnlTitleBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 153F));
            this.PnlTitleBar.Controls.Add(this.PnlSeccion, 4, 0);
            this.PnlTitleBar.Controls.Add(this.PnlBotonesTitleBar, 8, 0);
            this.PnlTitleBar.Controls.Add(this.LblHora, 2, 0);
            this.PnlTitleBar.Controls.Add(this.LblFecha, 6, 0);
            this.PnlTitleBar.Controls.Add(this.LblMarca, 0, 0);
            this.PnlTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlTitleBar.Location = new System.Drawing.Point(0, 0);
            this.PnlTitleBar.Margin = new System.Windows.Forms.Padding(0);
            this.PnlTitleBar.Name = "PnlTitleBar";
            this.PnlTitleBar.Padding = new System.Windows.Forms.Padding(25, 10, 10, 0);
            this.PnlTitleBar.RowCount = 1;
            this.PnlTitleBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PnlTitleBar.Size = new System.Drawing.Size(1924, 90);
            this.PnlTitleBar.TabIndex = 9;
            // 
            // PnlSeccion
            // 
            this.PnlSeccion.ColumnCount = 4;
            this.PnlSeccion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PnlSeccion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.PnlSeccion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.PnlSeccion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PnlSeccion.Controls.Add(this.BtnCerrarSeccion, 2, 0);
            this.PnlSeccion.Controls.Add(this.LblSeccion, 1, 0);
            this.PnlSeccion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlSeccion.Location = new System.Drawing.Point(697, 10);
            this.PnlSeccion.Margin = new System.Windows.Forms.Padding(0);
            this.PnlSeccion.Name = "PnlSeccion";
            this.PnlSeccion.RowCount = 1;
            this.PnlSeccion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PnlSeccion.Size = new System.Drawing.Size(542, 80);
            this.PnlSeccion.TabIndex = 4;
            // 
            // BtnCerrarSeccion
            // 
            this.BtnCerrarSeccion.BackColor = System.Drawing.Color.Transparent;
            this.BtnCerrarSeccion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCerrarSeccion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnCerrarSeccion.FlatAppearance.BorderSize = 0;
            this.BtnCerrarSeccion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnCerrarSeccion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnCerrarSeccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrarSeccion.ForeColor = System.Drawing.Color.White;
            this.BtnCerrarSeccion.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.BtnCerrarSeccion.IconColor = System.Drawing.Color.White;
            this.BtnCerrarSeccion.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtnCerrarSeccion.IconSize = 35;
            this.BtnCerrarSeccion.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnCerrarSeccion.Location = new System.Drawing.Point(387, 0);
            this.BtnCerrarSeccion.Margin = new System.Windows.Forms.Padding(0);
            this.BtnCerrarSeccion.Name = "BtnCerrarSeccion";
            this.BtnCerrarSeccion.Size = new System.Drawing.Size(30, 80);
            this.BtnCerrarSeccion.TabIndex = 7;
            this.BtnCerrarSeccion.TabStop = false;
            this.BtnCerrarSeccion.UseVisualStyleBackColor = false;
            this.BtnCerrarSeccion.Visible = false;
            this.BtnCerrarSeccion.Click += new System.EventHandler(this.BtnCerrarSeccion_Click);
            this.BtnCerrarSeccion.MouseEnter += new System.EventHandler(this.BtnCerrarSeccion_MouseEnter);
            this.BtnCerrarSeccion.MouseLeave += new System.EventHandler(this.BtnCerrarSeccion_MouseLeave);
            // 
            // LblSeccion
            // 
            this.LblSeccion.AutoSize = true;
            this.LblSeccion.BackColor = System.Drawing.Color.Transparent;
            this.LblSeccion.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.LblSeccion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblSeccion.Font = new System.Drawing.Font("Source Sans Pro", 22F, System.Drawing.FontStyle.Bold);
            this.LblSeccion.ForeColor = System.Drawing.Color.White;
            this.LblSeccion.Location = new System.Drawing.Point(125, 0);
            this.LblSeccion.Margin = new System.Windows.Forms.Padding(0);
            this.LblSeccion.Name = "LblSeccion";
            this.LblSeccion.Size = new System.Drawing.Size(262, 80);
            this.LblSeccion.TabIndex = 5;
            this.LblSeccion.Text = "Menú principal";
            this.LblSeccion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LblSeccion.Click += new System.EventHandler(this.BtnCerrarSeccion_Click);
            this.LblSeccion.MouseEnter += new System.EventHandler(this.BtnCerrarSeccion_MouseEnter);
            this.LblSeccion.MouseLeave += new System.EventHandler(this.BtnCerrarSeccion_MouseLeave);
            // 
            // PnlBotonesTitleBar
            // 
            this.PnlBotonesTitleBar.ColumnCount = 2;
            this.PnlBotonesTitleBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.PnlBotonesTitleBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.PnlBotonesTitleBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.PnlBotonesTitleBar.Controls.Add(this.BtnCerrar, 1, 0);
            this.PnlBotonesTitleBar.Controls.Add(this.BtnMinimizar, 0, 0);
            this.PnlBotonesTitleBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlBotonesTitleBar.Location = new System.Drawing.Point(1761, 10);
            this.PnlBotonesTitleBar.Margin = new System.Windows.Forms.Padding(0);
            this.PnlBotonesTitleBar.Name = "PnlBotonesTitleBar";
            this.PnlBotonesTitleBar.RowCount = 1;
            this.PnlBotonesTitleBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PnlBotonesTitleBar.Size = new System.Drawing.Size(153, 80);
            this.PnlBotonesTitleBar.TabIndex = 1;
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.BtnCerrar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(45)))));
            this.BtnCerrar.FlatAppearance.BorderSize = 0;
            this.BtnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(71)))), ((int)(((byte)(83)))));
            this.BtnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(41)))), ((int)(((byte)(83)))));
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrar.ForeColor = System.Drawing.Color.Silver;
            this.BtnCerrar.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.BtnCerrar.IconColor = System.Drawing.Color.White;
            this.BtnCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnCerrar.IconSize = 25;
            this.BtnCerrar.Location = new System.Drawing.Point(75, 0);
            this.BtnCerrar.Margin = new System.Windows.Forms.Padding(0);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(78, 80);
            this.BtnCerrar.TabIndex = 3;
            this.BtnCerrar.TabStop = false;
            this.BtnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // BtnMinimizar
            // 
            this.BtnMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.BtnMinimizar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnMinimizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(45)))));
            this.BtnMinimizar.FlatAppearance.BorderSize = 0;
            this.BtnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.BtnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMinimizar.ForeColor = System.Drawing.Color.Silver;
            this.BtnMinimizar.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.BtnMinimizar.IconColor = System.Drawing.Color.White;
            this.BtnMinimizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnMinimizar.IconSize = 20;
            this.BtnMinimizar.Location = new System.Drawing.Point(0, 0);
            this.BtnMinimizar.Margin = new System.Windows.Forms.Padding(0);
            this.BtnMinimizar.Name = "BtnMinimizar";
            this.BtnMinimizar.Size = new System.Drawing.Size(75, 80);
            this.BtnMinimizar.TabIndex = 0;
            this.BtnMinimizar.TabStop = false;
            this.BtnMinimizar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMinimizar.UseVisualStyleBackColor = false;
            this.BtnMinimizar.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // LblHora
            // 
            this.LblHora.AutoSize = true;
            this.LblHora.BackColor = System.Drawing.Color.Transparent;
            this.LblHora.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblHora.Font = new System.Drawing.Font("Source Sans Pro", 22F, System.Drawing.FontStyle.Bold);
            this.LblHora.ForeColor = System.Drawing.Color.White;
            this.LblHora.Location = new System.Drawing.Point(397, 10);
            this.LblHora.Margin = new System.Windows.Forms.Padding(0);
            this.LblHora.Name = "LblHora";
            this.LblHora.Size = new System.Drawing.Size(250, 80);
            this.LblHora.TabIndex = 0;
            this.LblHora.Text = "00:00";
            this.LblHora.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblFecha
            // 
            this.LblFecha.AutoSize = true;
            this.LblFecha.BackColor = System.Drawing.Color.Transparent;
            this.LblFecha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblFecha.Font = new System.Drawing.Font("Source Sans Pro", 22F, System.Drawing.FontStyle.Bold);
            this.LblFecha.ForeColor = System.Drawing.Color.White;
            this.LblFecha.Location = new System.Drawing.Point(1289, 10);
            this.LblFecha.Margin = new System.Windows.Forms.Padding(0);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(250, 80);
            this.LblFecha.TabIndex = 2;
            this.LblFecha.Text = "15/06/2022";
            this.LblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblMarca
            // 
            this.LblMarca.AutoSize = true;
            this.LblMarca.BackColor = System.Drawing.Color.Transparent;
            this.LblMarca.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblMarca.Font = new System.Drawing.Font("Source Sans Pro", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMarca.ForeColor = System.Drawing.Color.Silver;
            this.LblMarca.Location = new System.Drawing.Point(25, 10);
            this.LblMarca.Margin = new System.Windows.Forms.Padding(0);
            this.LblMarca.Name = "LblMarca";
            this.LblMarca.Size = new System.Drawing.Size(150, 80);
            this.LblMarca.TabIndex = 0;
            this.LblMarca.Text = "Garmoxu";
            this.LblMarca.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PnlBody
            // 
            this.PnlBody.Controls.Add(this.PnlFormularios);
            this.PnlBody.Controls.Add(this.PnlMenuLateral);
            this.PnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlBody.Location = new System.Drawing.Point(0, 90);
            this.PnlBody.Margin = new System.Windows.Forms.Padding(0);
            this.PnlBody.Name = "PnlBody";
            this.PnlBody.Padding = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.PnlBody.Size = new System.Drawing.Size(1924, 965);
            this.PnlBody.TabIndex = 0;
            // 
            // PnlFormularios
            // 
            this.PnlFormularios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(54)))), ((int)(((byte)(58)))));
            this.PnlFormularios.Controls.Add(this.PnlLogo);
            this.PnlFormularios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlFormularios.Location = new System.Drawing.Point(250, 0);
            this.PnlFormularios.Margin = new System.Windows.Forms.Padding(4);
            this.PnlFormularios.Name = "PnlFormularios";
            this.PnlFormularios.Size = new System.Drawing.Size(1664, 955);
            this.PnlFormularios.TabIndex = 2;
            this.PnlFormularios.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.PnlMain_ControlRemoved);
            // 
            // PnlLogo
            // 
            this.PnlLogo.ColumnCount = 3;
            this.PnlLogo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.PnlLogo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.PnlLogo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.PnlLogo.Controls.Add(this.PicLogo, 1, 1);
            this.PnlLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlLogo.Location = new System.Drawing.Point(0, 0);
            this.PnlLogo.Margin = new System.Windows.Forms.Padding(15, 15, 15, 3);
            this.PnlLogo.Name = "PnlLogo";
            this.PnlLogo.RowCount = 3;
            this.PnlLogo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.PnlLogo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.PnlLogo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.PnlLogo.Size = new System.Drawing.Size(1664, 955);
            this.PnlLogo.TabIndex = 3;
            // 
            // PicLogo
            // 
            this.PicLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PicLogo.Image = global::Garmoxu_Desktop.Properties.Resources.Garmoxu_Logo_Circle_New_Red_Less_Opacity;
            this.PicLogo.Location = new System.Drawing.Point(249, 143);
            this.PicLogo.Margin = new System.Windows.Forms.Padding(0);
            this.PicLogo.Name = "PicLogo";
            this.PicLogo.Size = new System.Drawing.Size(1164, 668);
            this.PicLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicLogo.TabIndex = 6;
            this.PicLogo.TabStop = false;
            // 
            // PnlMenuLateral
            // 
            this.PnlMenuLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(45)))));
            this.PnlMenuLateral.Controls.Add(this.BtnClientes);
            this.PnlMenuLateral.Controls.Add(this.BtnCategorias);
            this.PnlMenuLateral.Controls.Add(this.BtnPlatos);
            this.PnlMenuLateral.Controls.Add(this.BtnHistorial);
            this.PnlMenuLateral.Controls.Add(this.BtnReservas);
            this.PnlMenuLateral.Controls.Add(this.BtnPedidos);
            this.PnlMenuLateral.Controls.Add(this.BtnUsuarios);
            this.PnlMenuLateral.Controls.Add(this.BtnAjustes);
            this.PnlMenuLateral.Controls.Add(this.LblUsuarioActual);
            this.PnlMenuLateral.Controls.Add(this.PnlCabeceraMenu);
            this.PnlMenuLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlMenuLateral.Location = new System.Drawing.Point(0, 0);
            this.PnlMenuLateral.Margin = new System.Windows.Forms.Padding(0);
            this.PnlMenuLateral.Name = "PnlMenuLateral";
            this.PnlMenuLateral.Size = new System.Drawing.Size(250, 955);
            this.PnlMenuLateral.TabIndex = 1;
            // 
            // BtnClientes
            // 
            this.BtnClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnClientes.FlatAppearance.BorderSize = 0;
            this.BtnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClientes.Font = new System.Drawing.Font("Source Sans Pro", 13F, System.Drawing.FontStyle.Bold);
            this.BtnClientes.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnClientes.IconChar = FontAwesome.Sharp.IconChar.Portrait;
            this.BtnClientes.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(250)))));
            this.BtnClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnClientes.Location = new System.Drawing.Point(0, 510);
            this.BtnClientes.Margin = new System.Windows.Forms.Padding(4);
            this.BtnClientes.Name = "BtnClientes";
            this.BtnClientes.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.BtnClientes.Size = new System.Drawing.Size(250, 62);
            this.BtnClientes.TabIndex = 8;
            this.BtnClientes.TabStop = false;
            this.BtnClientes.Tag = "Clientes";
            this.BtnClientes.Text = "Clientes";
            this.BtnClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnClientes.UseVisualStyleBackColor = true;
            this.BtnClientes.Click += new System.EventHandler(this.BtnCliente_Click);
            // 
            // BtnCategorias
            // 
            this.BtnCategorias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCategorias.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnCategorias.FlatAppearance.BorderSize = 0;
            this.BtnCategorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCategorias.Font = new System.Drawing.Font("Source Sans Pro", 13F, System.Drawing.FontStyle.Bold);
            this.BtnCategorias.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnCategorias.IconChar = FontAwesome.Sharp.IconChar.Tag;
            this.BtnCategorias.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.BtnCategorias.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnCategorias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCategorias.Location = new System.Drawing.Point(0, 448);
            this.BtnCategorias.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCategorias.Name = "BtnCategorias";
            this.BtnCategorias.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.BtnCategorias.Size = new System.Drawing.Size(250, 62);
            this.BtnCategorias.TabIndex = 7;
            this.BtnCategorias.TabStop = false;
            this.BtnCategorias.Tag = "Categorías";
            this.BtnCategorias.Text = "Categorías";
            this.BtnCategorias.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCategorias.UseVisualStyleBackColor = true;
            this.BtnCategorias.Click += new System.EventHandler(this.BtnCategoria_Click);
            // 
            // BtnPlatos
            // 
            this.BtnPlatos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPlatos.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnPlatos.FlatAppearance.BorderSize = 0;
            this.BtnPlatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPlatos.Font = new System.Drawing.Font("Source Sans Pro", 13F, System.Drawing.FontStyle.Bold);
            this.BtnPlatos.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnPlatos.IconChar = FontAwesome.Sharp.IconChar.Hamburger;
            this.BtnPlatos.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(171)))), ((int)(((byte)(88)))));
            this.BtnPlatos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnPlatos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPlatos.Location = new System.Drawing.Point(0, 386);
            this.BtnPlatos.Margin = new System.Windows.Forms.Padding(4);
            this.BtnPlatos.Name = "BtnPlatos";
            this.BtnPlatos.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.BtnPlatos.Size = new System.Drawing.Size(250, 62);
            this.BtnPlatos.TabIndex = 6;
            this.BtnPlatos.TabStop = false;
            this.BtnPlatos.Tag = "Platos";
            this.BtnPlatos.Text = "Platos";
            this.BtnPlatos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnPlatos.UseVisualStyleBackColor = true;
            this.BtnPlatos.Click += new System.EventHandler(this.BtnPlatos_Click);
            // 
            // BtnHistorial
            // 
            this.BtnHistorial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnHistorial.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnHistorial.FlatAppearance.BorderSize = 0;
            this.BtnHistorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHistorial.Font = new System.Drawing.Font("Source Sans Pro", 13F, System.Drawing.FontStyle.Bold);
            this.BtnHistorial.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnHistorial.IconChar = FontAwesome.Sharp.IconChar.Tasks;
            this.BtnHistorial.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(219)))), ((int)(((byte)(59)))));
            this.BtnHistorial.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnHistorial.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnHistorial.Location = new System.Drawing.Point(0, 324);
            this.BtnHistorial.Margin = new System.Windows.Forms.Padding(4);
            this.BtnHistorial.Name = "BtnHistorial";
            this.BtnHistorial.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.BtnHistorial.Size = new System.Drawing.Size(250, 62);
            this.BtnHistorial.TabIndex = 5;
            this.BtnHistorial.TabStop = false;
            this.BtnHistorial.Tag = "Historial";
            this.BtnHistorial.Text = "Historial";
            this.BtnHistorial.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnHistorial.UseVisualStyleBackColor = true;
            this.BtnHistorial.Click += new System.EventHandler(this.BtnHistorial_Click);
            // 
            // BtnReservas
            // 
            this.BtnReservas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnReservas.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnReservas.FlatAppearance.BorderSize = 0;
            this.BtnReservas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReservas.Font = new System.Drawing.Font("Source Sans Pro", 13F, System.Drawing.FontStyle.Bold);
            this.BtnReservas.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnReservas.IconChar = FontAwesome.Sharp.IconChar.CalendarAlt;
            this.BtnReservas.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.BtnReservas.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtnReservas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnReservas.Location = new System.Drawing.Point(0, 262);
            this.BtnReservas.Margin = new System.Windows.Forms.Padding(4);
            this.BtnReservas.Name = "BtnReservas";
            this.BtnReservas.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.BtnReservas.Size = new System.Drawing.Size(250, 62);
            this.BtnReservas.TabIndex = 4;
            this.BtnReservas.TabStop = false;
            this.BtnReservas.Tag = "Reservas";
            this.BtnReservas.Text = "Reservas";
            this.BtnReservas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnReservas.UseVisualStyleBackColor = true;
            this.BtnReservas.Click += new System.EventHandler(this.BtnReservas_Click);
            // 
            // BtnPedidos
            // 
            this.BtnPedidos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPedidos.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnPedidos.FlatAppearance.BorderSize = 0;
            this.BtnPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPedidos.Font = new System.Drawing.Font("Source Sans Pro", 13F, System.Drawing.FontStyle.Bold);
            this.BtnPedidos.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnPedidos.IconChar = FontAwesome.Sharp.IconChar.PencilAlt;
            this.BtnPedidos.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(200)))), ((int)(((byte)(70)))));
            this.BtnPedidos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnPedidos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPedidos.Location = new System.Drawing.Point(0, 200);
            this.BtnPedidos.Margin = new System.Windows.Forms.Padding(4);
            this.BtnPedidos.Name = "BtnPedidos";
            this.BtnPedidos.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.BtnPedidos.Size = new System.Drawing.Size(250, 62);
            this.BtnPedidos.TabIndex = 3;
            this.BtnPedidos.TabStop = false;
            this.BtnPedidos.Tag = "Pedidos";
            this.BtnPedidos.Text = "Pedidos";
            this.BtnPedidos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnPedidos.UseVisualStyleBackColor = true;
            this.BtnPedidos.Click += new System.EventHandler(this.BtnPedidos_Click);
            // 
            // BtnUsuarios
            // 
            this.BtnUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnUsuarios.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnUsuarios.FlatAppearance.BorderSize = 0;
            this.BtnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUsuarios.Font = new System.Drawing.Font("Source Sans Pro", 13F, System.Drawing.FontStyle.Bold);
            this.BtnUsuarios.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnUsuarios.IconChar = FontAwesome.Sharp.IconChar.UserFriends;
            this.BtnUsuarios.IconColor = System.Drawing.Color.DodgerBlue;
            this.BtnUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnUsuarios.Location = new System.Drawing.Point(0, 831);
            this.BtnUsuarios.Margin = new System.Windows.Forms.Padding(4);
            this.BtnUsuarios.Name = "BtnUsuarios";
            this.BtnUsuarios.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.BtnUsuarios.Size = new System.Drawing.Size(250, 62);
            this.BtnUsuarios.TabIndex = 9;
            this.BtnUsuarios.TabStop = false;
            this.BtnUsuarios.Tag = "Usuarios";
            this.BtnUsuarios.Text = "Usuarios";
            this.BtnUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnUsuarios.UseVisualStyleBackColor = true;
            this.BtnUsuarios.Click += new System.EventHandler(this.BtnUsers_Click);
            // 
            // BtnAjustes
            // 
            this.BtnAjustes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAjustes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnAjustes.FlatAppearance.BorderSize = 0;
            this.BtnAjustes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAjustes.Font = new System.Drawing.Font("Source Sans Pro", 13F, System.Drawing.FontStyle.Bold);
            this.BtnAjustes.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnAjustes.IconChar = FontAwesome.Sharp.IconChar.Cogs;
            this.BtnAjustes.IconColor = System.Drawing.Color.DarkGray;
            this.BtnAjustes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnAjustes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAjustes.Location = new System.Drawing.Point(0, 893);
            this.BtnAjustes.Margin = new System.Windows.Forms.Padding(4);
            this.BtnAjustes.Name = "BtnAjustes";
            this.BtnAjustes.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.BtnAjustes.Size = new System.Drawing.Size(250, 62);
            this.BtnAjustes.TabIndex = 10;
            this.BtnAjustes.TabStop = false;
            this.BtnAjustes.Tag = "Ajustes";
            this.BtnAjustes.Text = "Ajustes";
            this.BtnAjustes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAjustes.UseVisualStyleBackColor = true;
            this.BtnAjustes.Click += new System.EventHandler(this.BtnAjustes_Click);
            // 
            // LblUsuarioActual
            // 
            this.LblUsuarioActual.AutoSize = true;
            this.LblUsuarioActual.BackColor = System.Drawing.Color.Transparent;
            this.LblUsuarioActual.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblUsuarioActual.Font = new System.Drawing.Font("Source Sans Pro", 12F, System.Drawing.FontStyle.Bold);
            this.LblUsuarioActual.ForeColor = System.Drawing.Color.Gainsboro;
            this.LblUsuarioActual.Location = new System.Drawing.Point(0, 155);
            this.LblUsuarioActual.Margin = new System.Windows.Forms.Padding(0);
            this.LblUsuarioActual.Name = "LblUsuarioActual";
            this.LblUsuarioActual.Padding = new System.Windows.Forms.Padding(25, 0, 0, 20);
            this.LblUsuarioActual.Size = new System.Drawing.Size(106, 45);
            this.LblUsuarioActual.TabIndex = 1;
            this.LblUsuarioActual.Text = "Usuario";
            this.LblUsuarioActual.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PnlCabeceraMenu
            // 
            this.PnlCabeceraMenu.ColumnCount = 2;
            this.PnlCabeceraMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.PnlCabeceraMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PnlCabeceraMenu.Controls.Add(this.PicUsuario, 0, 0);
            this.PnlCabeceraMenu.Controls.Add(this.BtnEsconderMenu, 1, 0);
            this.PnlCabeceraMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlCabeceraMenu.Location = new System.Drawing.Point(0, 0);
            this.PnlCabeceraMenu.Margin = new System.Windows.Forms.Padding(0);
            this.PnlCabeceraMenu.Name = "PnlCabeceraMenu";
            this.PnlCabeceraMenu.RowCount = 1;
            this.PnlCabeceraMenu.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.PnlCabeceraMenu.Size = new System.Drawing.Size(250, 155);
            this.PnlCabeceraMenu.TabIndex = 11;
            // 
            // PicUsuario
            // 
            this.PicUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(255)))));
            this.PicUsuario.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.PicUsuario.BorderColor = System.Drawing.Color.Gainsboro;
            this.PicUsuario.BorderColor2 = System.Drawing.Color.Gainsboro;
            this.PicUsuario.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.PicUsuario.BorderSize = 3;
            this.PicUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PicUsuario.GradientAngle = 50F;
            this.PicUsuario.Image = global::Garmoxu_Desktop.Properties.Resources.User_Default_Icon;
            this.PicUsuario.Location = new System.Drawing.Point(25, 0);
            this.PicUsuario.Margin = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.PicUsuario.Name = "PicUsuario";
            this.PicUsuario.Size = new System.Drawing.Size(150, 150);
            this.PicUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicUsuario.TabIndex = 25;
            this.PicUsuario.TabStop = false;
            this.PicUsuario.Click += new System.EventHandler(this.PicUser_Click);
            this.PicUsuario.MouseEnter += new System.EventHandler(this.PicUser_MouseEnter);
            this.PicUsuario.MouseLeave += new System.EventHandler(this.PicUser_MouseLeave);
            // 
            // BtnEsconderMenu
            // 
            this.BtnEsconderMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEsconderMenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnEsconderMenu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(45)))));
            this.BtnEsconderMenu.FlatAppearance.BorderSize = 0;
            this.BtnEsconderMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(74)))), ((int)(((byte)(78)))));
            this.BtnEsconderMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(54)))), ((int)(((byte)(58)))));
            this.BtnEsconderMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEsconderMenu.Font = new System.Drawing.Font("Source Sans Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEsconderMenu.ForeColor = System.Drawing.Color.White;
            this.BtnEsconderMenu.IconChar = FontAwesome.Sharp.IconChar.ChevronLeft;
            this.BtnEsconderMenu.IconColor = System.Drawing.Color.Gainsboro;
            this.BtnEsconderMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnEsconderMenu.Location = new System.Drawing.Point(175, 0);
            this.BtnEsconderMenu.Margin = new System.Windows.Forms.Padding(0);
            this.BtnEsconderMenu.Name = "BtnEsconderMenu";
            this.BtnEsconderMenu.Size = new System.Drawing.Size(75, 155);
            this.BtnEsconderMenu.TabIndex = 0;
            this.BtnEsconderMenu.TabStop = false;
            this.BtnEsconderMenu.Tag = "";
            this.BtnEsconderMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnEsconderMenu.UseVisualStyleBackColor = true;
            this.BtnEsconderMenu.Click += new System.EventHandler(this.BtnEsconderMenu_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.PnlPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "Menú principal";
            this.Text = "Garmoxu Desktop";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.EnabledChanged += new System.EventHandler(this.FrmMain_EnabledChanged);
            this.PnlPrincipal.ResumeLayout(false);
            this.PnlTitleBar.ResumeLayout(false);
            this.PnlTitleBar.PerformLayout();
            this.PnlSeccion.ResumeLayout(false);
            this.PnlSeccion.PerformLayout();
            this.PnlBotonesTitleBar.ResumeLayout(false);
            this.PnlBody.ResumeLayout(false);
            this.PnlFormularios.ResumeLayout(false);
            this.PnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).EndInit();
            this.PnlMenuLateral.ResumeLayout(false);
            this.PnlMenuLateral.PerformLayout();
            this.PnlCabeceraMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicUsuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer TmrRelojMain;
        private System.Windows.Forms.TableLayoutPanel PnlPrincipal;
        private System.Windows.Forms.Panel PnlBody;
        private System.Windows.Forms.Panel PnlFormularios;
        private System.Windows.Forms.TableLayoutPanel PnlLogo;
        private System.Windows.Forms.PictureBox PicLogo;
        private System.Windows.Forms.Panel PnlMenuLateral;
        private FontAwesome.Sharp.IconButton BtnClientes;
        private FontAwesome.Sharp.IconButton BtnCategorias;
        private FontAwesome.Sharp.IconButton BtnPlatos;
        private FontAwesome.Sharp.IconButton BtnHistorial;
        private FontAwesome.Sharp.IconButton BtnReservas;
        private FontAwesome.Sharp.IconButton BtnPedidos;
        private FontAwesome.Sharp.IconButton BtnUsuarios;
        private FontAwesome.Sharp.IconButton BtnAjustes;
        private System.Windows.Forms.Label LblUsuarioActual;
        private System.Windows.Forms.TableLayoutPanel PnlCabeceraMenu;
        private RJCodeAdvance.RJControls.RJCircularPictureBox PicUsuario;
        private FontAwesome.Sharp.IconButton BtnEsconderMenu;
        private System.Windows.Forms.TableLayoutPanel PnlTitleBar;
        private System.Windows.Forms.TableLayoutPanel PnlSeccion;
        private FontAwesome.Sharp.IconButton BtnCerrarSeccion;
        private System.Windows.Forms.Label LblSeccion;
        private System.Windows.Forms.TableLayoutPanel PnlBotonesTitleBar;
        private FontAwesome.Sharp.IconButton BtnCerrar;
        private FontAwesome.Sharp.IconButton BtnMinimizar;
        private System.Windows.Forms.Label LblHora;
        private System.Windows.Forms.Label LblFecha;
        private System.Windows.Forms.Label LblMarca;
    }
}