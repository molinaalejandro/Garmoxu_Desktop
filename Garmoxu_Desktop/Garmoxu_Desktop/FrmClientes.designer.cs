namespace Garmoxu_Desktop
{
    partial class FrmClientes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PnlMain = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnAbrirNuevo = new RJCodeAdvance.RJControls.RJButton();
            this.BtnCerrar = new RJCodeAdvance.RJControls.RJButton();
            this.PnlClientes = new System.Windows.Forms.TableLayoutPanel();
            this.PnlDetalles = new System.Windows.Forms.Panel();
            this.Tbc = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.LblCantidadPedidos = new MaterialSkin.Controls.MaterialLabel();
            this.BtnModificarCliente = new RJCodeAdvance.RJControls.RJButton();
            this.TxtTelefonoTB1 = new RJCodeAdvance.RJControls.RJTextBox();
            this.LblCantidad = new MaterialSkin.Controls.MaterialLabel();
            this.BtnBorrarCliente = new RJCodeAdvance.RJControls.RJButton();
            this.TxtDireccionTB1 = new RJCodeAdvance.RJControls.RJTextBox();
            this.TxtNombreTB1 = new RJCodeAdvance.RJControls.RJTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.TxtTelefonoTB2 = new RJCodeAdvance.RJControls.RJTextBox();
            this.BtnGuardarDatos = new RJCodeAdvance.RJControls.RJButton();
            this.TxtDireccionTB2 = new RJCodeAdvance.RJControls.RJTextBox();
            this.TxtNombreTB2 = new RJCodeAdvance.RJControls.RJTextBox();
            this.PnlLista = new System.Windows.Forms.Panel();
            this.DtgClientes = new System.Windows.Forms.DataGridView();
            this.TelefonoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnBuscar = new RJCodeAdvance.RJControls.RJButton();
            this.TxtBuscar = new RJCodeAdvance.RJControls.RJTextBox();
            this.PnlMain.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.PnlClientes.SuspendLayout();
            this.PnlDetalles.SuspendLayout();
            this.Tbc.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.PnlLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlMain
            // 
            this.PnlMain.ColumnCount = 1;
            this.PnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PnlMain.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.PnlMain.Controls.Add(this.PnlClientes, 0, 0);
            this.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlMain.Location = new System.Drawing.Point(0, 0);
            this.PnlMain.Margin = new System.Windows.Forms.Padding(4);
            this.PnlMain.Name = "PnlMain";
            this.PnlMain.Padding = new System.Windows.Forms.Padding(27, 25, 27, 25);
            this.PnlMain.RowCount = 2;
            this.PnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.PnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.PnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.PnlMain.Size = new System.Drawing.Size(1067, 554);
            this.PnlMain.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.Controls.Add(this.BtnAbrirNuevo, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.BtnCerrar, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(31, 457);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1005, 68);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // BtnAbrirNuevo
            // 
            this.BtnAbrirNuevo.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnAbrirNuevo.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnAbrirNuevo.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnAbrirNuevo.BorderRadius = 0;
            this.BtnAbrirNuevo.BorderSize = 0;
            this.BtnAbrirNuevo.FlatAppearance.BorderSize = 0;
            this.BtnAbrirNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAbrirNuevo.ForeColor = System.Drawing.Color.White;
            this.BtnAbrirNuevo.Location = new System.Drawing.Point(255, 4);
            this.BtnAbrirNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.BtnAbrirNuevo.Name = "BtnAbrirNuevo";
            this.BtnAbrirNuevo.Size = new System.Drawing.Size(219, 49);
            this.BtnAbrirNuevo.TabIndex = 7;
            this.BtnAbrirNuevo.Text = "Dar de alta cliente";
            this.BtnAbrirNuevo.TextColor = System.Drawing.Color.White;
            this.BtnAbrirNuevo.UseVisualStyleBackColor = false;
            this.BtnAbrirNuevo.Click += new System.EventHandler(this.BtnAbrirNuevo_Click);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnCerrar.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnCerrar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnCerrar.BorderRadius = 0;
            this.BtnCerrar.BorderSize = 0;
            this.BtnCerrar.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnCerrar.FlatAppearance.BorderSize = 0;
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCerrar.ForeColor = System.Drawing.Color.White;
            this.BtnCerrar.Location = new System.Drawing.Point(4, 4);
            this.BtnCerrar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(243, 49);
            this.BtnCerrar.TabIndex = 0;
            this.BtnCerrar.Text = "Cerrar";
            this.BtnCerrar.TextColor = System.Drawing.Color.White;
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // PnlClientes
            // 
            this.PnlClientes.ColumnCount = 2;
            this.PnlClientes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.PnlClientes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.PnlClientes.Controls.Add(this.PnlDetalles, 1, 0);
            this.PnlClientes.Controls.Add(this.PnlLista, 0, 0);
            this.PnlClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlClientes.Location = new System.Drawing.Point(31, 29);
            this.PnlClientes.Margin = new System.Windows.Forms.Padding(4);
            this.PnlClientes.Name = "PnlClientes";
            this.PnlClientes.RowCount = 1;
            this.PnlClientes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PnlClientes.Size = new System.Drawing.Size(1005, 420);
            this.PnlClientes.TabIndex = 5;
            // 
            // PnlDetalles
            // 
            this.PnlDetalles.Controls.Add(this.Tbc);
            this.PnlDetalles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlDetalles.Location = new System.Drawing.Point(406, 4);
            this.PnlDetalles.Margin = new System.Windows.Forms.Padding(4);
            this.PnlDetalles.Name = "PnlDetalles";
            this.PnlDetalles.Size = new System.Drawing.Size(595, 412);
            this.PnlDetalles.TabIndex = 0;
            // 
            // Tbc
            // 
            this.Tbc.Controls.Add(this.tabPage1);
            this.Tbc.Controls.Add(this.tabPage2);
            this.Tbc.Depth = 0;
            this.Tbc.Location = new System.Drawing.Point(4, 1);
            this.Tbc.Margin = new System.Windows.Forms.Padding(4);
            this.Tbc.MouseState = MaterialSkin.MouseState.HOVER;
            this.Tbc.Name = "Tbc";
            this.Tbc.SelectedIndex = 0;
            this.Tbc.Size = new System.Drawing.Size(592, 409);
            this.Tbc.TabIndex = 7;
            this.Tbc.Visible = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.LblCantidadPedidos);
            this.tabPage1.Controls.Add(this.BtnModificarCliente);
            this.tabPage1.Controls.Add(this.TxtTelefonoTB1);
            this.tabPage1.Controls.Add(this.LblCantidad);
            this.tabPage1.Controls.Add(this.BtnBorrarCliente);
            this.tabPage1.Controls.Add(this.TxtDireccionTB1);
            this.tabPage1.Controls.Add(this.TxtNombreTB1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(584, 380);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // LblCantidadPedidos
            // 
            this.LblCantidadPedidos.AutoSize = true;
            this.LblCantidadPedidos.Depth = 0;
            this.LblCantidadPedidos.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblCantidadPedidos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblCantidadPedidos.Location = new System.Drawing.Point(205, 209);
            this.LblCantidadPedidos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblCantidadPedidos.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblCantidadPedidos.Name = "LblCantidadPedidos";
            this.LblCantidadPedidos.Size = new System.Drawing.Size(26, 24);
            this.LblCantidadPedidos.TabIndex = 8;
            this.LblCantidadPedidos.Text = "0 ";
            // 
            // BtnModificarCliente
            // 
            this.BtnModificarCliente.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnModificarCliente.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnModificarCliente.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnModificarCliente.BorderRadius = 0;
            this.BtnModificarCliente.BorderSize = 0;
            this.BtnModificarCliente.FlatAppearance.BorderSize = 0;
            this.BtnModificarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnModificarCliente.ForeColor = System.Drawing.Color.White;
            this.BtnModificarCliente.Location = new System.Drawing.Point(377, 320);
            this.BtnModificarCliente.Margin = new System.Windows.Forms.Padding(4);
            this.BtnModificarCliente.Name = "BtnModificarCliente";
            this.BtnModificarCliente.Size = new System.Drawing.Size(200, 49);
            this.BtnModificarCliente.TabIndex = 7;
            this.BtnModificarCliente.Text = "Modificar Cliente";
            this.BtnModificarCliente.TextColor = System.Drawing.Color.White;
            this.BtnModificarCliente.UseVisualStyleBackColor = false;
            this.BtnModificarCliente.Click += new System.EventHandler(this.BtnModificarCliente_Click);
            // 
            // TxtTelefonoTB1
            // 
            this.TxtTelefonoTB1.BackColor = System.Drawing.SystemColors.Window;
            this.TxtTelefonoTB1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.TxtTelefonoTB1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.TxtTelefonoTB1.BorderRadius = 0;
            this.TxtTelefonoTB1.BorderSize = 2;
            this.TxtTelefonoTB1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTelefonoTB1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtTelefonoTB1.Location = new System.Drawing.Point(4, 9);
            this.TxtTelefonoTB1.Margin = new System.Windows.Forms.Padding(5);
            this.TxtTelefonoTB1.Multiline = false;
            this.TxtTelefonoTB1.Name = "TxtTelefonoTB1";
            this.TxtTelefonoTB1.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.TxtTelefonoTB1.PasswordChar = false;
            this.TxtTelefonoTB1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TxtTelefonoTB1.PlaceholderText = "";
            this.TxtTelefonoTB1.Size = new System.Drawing.Size(333, 39);
            this.TxtTelefonoTB1.TabIndex = 0;
            this.TxtTelefonoTB1.Texts = "Telefono";
            this.TxtTelefonoTB1.UnderlinedStyle = false;
            // 
            // LblCantidad
            // 
            this.LblCantidad.AutoSize = true;
            this.LblCantidad.Depth = 0;
            this.LblCantidad.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblCantidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblCantidad.Location = new System.Drawing.Point(8, 209);
            this.LblCantidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblCantidad.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblCantidad.Name = "LblCantidad";
            this.LblCantidad.Size = new System.Drawing.Size(181, 24);
            this.LblCantidad.TabIndex = 5;
            this.LblCantidad.Text = "Cantidad de Pedido:";
            // 
            // BtnBorrarCliente
            // 
            this.BtnBorrarCliente.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnBorrarCliente.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnBorrarCliente.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnBorrarCliente.BorderRadius = 0;
            this.BtnBorrarCliente.BorderSize = 0;
            this.BtnBorrarCliente.FlatAppearance.BorderSize = 0;
            this.BtnBorrarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBorrarCliente.ForeColor = System.Drawing.Color.White;
            this.BtnBorrarCliente.Location = new System.Drawing.Point(0, 324);
            this.BtnBorrarCliente.Margin = new System.Windows.Forms.Padding(4);
            this.BtnBorrarCliente.Name = "BtnBorrarCliente";
            this.BtnBorrarCliente.Size = new System.Drawing.Size(200, 49);
            this.BtnBorrarCliente.TabIndex = 4;
            this.BtnBorrarCliente.Text = "Borrar Cliente";
            this.BtnBorrarCliente.TextColor = System.Drawing.Color.White;
            this.BtnBorrarCliente.UseVisualStyleBackColor = false;
            this.BtnBorrarCliente.Click += new System.EventHandler(this.BtnBorrarCliente_Click);
            // 
            // TxtDireccionTB1
            // 
            this.TxtDireccionTB1.BackColor = System.Drawing.SystemColors.Window;
            this.TxtDireccionTB1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.TxtDireccionTB1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.TxtDireccionTB1.BorderRadius = 0;
            this.TxtDireccionTB1.BorderSize = 2;
            this.TxtDireccionTB1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDireccionTB1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtDireccionTB1.Location = new System.Drawing.Point(4, 50);
            this.TxtDireccionTB1.Margin = new System.Windows.Forms.Padding(5);
            this.TxtDireccionTB1.Multiline = true;
            this.TxtDireccionTB1.Name = "TxtDireccionTB1";
            this.TxtDireccionTB1.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.TxtDireccionTB1.PasswordChar = false;
            this.TxtDireccionTB1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TxtDireccionTB1.PlaceholderText = "";
            this.TxtDireccionTB1.Size = new System.Drawing.Size(333, 90);
            this.TxtDireccionTB1.TabIndex = 1;
            this.TxtDireccionTB1.Texts = "Direccion";
            this.TxtDireccionTB1.UnderlinedStyle = false;
            // 
            // TxtNombreTB1
            // 
            this.TxtNombreTB1.BackColor = System.Drawing.SystemColors.Window;
            this.TxtNombreTB1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.TxtNombreTB1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.TxtNombreTB1.BorderRadius = 0;
            this.TxtNombreTB1.BorderSize = 2;
            this.TxtNombreTB1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombreTB1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtNombreTB1.Location = new System.Drawing.Point(5, 150);
            this.TxtNombreTB1.Margin = new System.Windows.Forms.Padding(5);
            this.TxtNombreTB1.Multiline = false;
            this.TxtNombreTB1.Name = "TxtNombreTB1";
            this.TxtNombreTB1.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.TxtNombreTB1.PasswordChar = false;
            this.TxtNombreTB1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TxtNombreTB1.PlaceholderText = "";
            this.TxtNombreTB1.Size = new System.Drawing.Size(333, 39);
            this.TxtNombreTB1.TabIndex = 2;
            this.TxtNombreTB1.Texts = "Nombre";
            this.TxtNombreTB1.UnderlinedStyle = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.TxtTelefonoTB2);
            this.tabPage2.Controls.Add(this.BtnGuardarDatos);
            this.tabPage2.Controls.Add(this.TxtDireccionTB2);
            this.tabPage2.Controls.Add(this.TxtNombreTB2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(584, 380);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // TxtTelefonoTB2
            // 
            this.TxtTelefonoTB2.BackColor = System.Drawing.SystemColors.Window;
            this.TxtTelefonoTB2.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.TxtTelefonoTB2.BorderFocusColor = System.Drawing.Color.HotPink;
            this.TxtTelefonoTB2.BorderRadius = 0;
            this.TxtTelefonoTB2.BorderSize = 2;
            this.TxtTelefonoTB2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTelefonoTB2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtTelefonoTB2.Location = new System.Drawing.Point(164, 48);
            this.TxtTelefonoTB2.Margin = new System.Windows.Forms.Padding(5);
            this.TxtTelefonoTB2.Multiline = false;
            this.TxtTelefonoTB2.Name = "TxtTelefonoTB2";
            this.TxtTelefonoTB2.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.TxtTelefonoTB2.PasswordChar = false;
            this.TxtTelefonoTB2.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TxtTelefonoTB2.PlaceholderText = "";
            this.TxtTelefonoTB2.Size = new System.Drawing.Size(333, 39);
            this.TxtTelefonoTB2.TabIndex = 8;
            this.TxtTelefonoTB2.Texts = "Telefono";
            this.TxtTelefonoTB2.UnderlinedStyle = false;
            // 
            // BtnGuardarDatos
            // 
            this.BtnGuardarDatos.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnGuardarDatos.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnGuardarDatos.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnGuardarDatos.BorderRadius = 0;
            this.BtnGuardarDatos.BorderSize = 0;
            this.BtnGuardarDatos.FlatAppearance.BorderSize = 0;
            this.BtnGuardarDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardarDatos.ForeColor = System.Drawing.Color.White;
            this.BtnGuardarDatos.Location = new System.Drawing.Point(231, 263);
            this.BtnGuardarDatos.Margin = new System.Windows.Forms.Padding(4);
            this.BtnGuardarDatos.Name = "BtnGuardarDatos";
            this.BtnGuardarDatos.Size = new System.Drawing.Size(219, 49);
            this.BtnGuardarDatos.TabIndex = 6;
            this.BtnGuardarDatos.Text = "Guardar datos";
            this.BtnGuardarDatos.TextColor = System.Drawing.Color.White;
            this.BtnGuardarDatos.UseVisualStyleBackColor = false;
            this.BtnGuardarDatos.Click += new System.EventHandler(this.BtnGuardarDatos_Click);
            // 
            // TxtDireccionTB2
            // 
            this.TxtDireccionTB2.BackColor = System.Drawing.SystemColors.Window;
            this.TxtDireccionTB2.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.TxtDireccionTB2.BorderFocusColor = System.Drawing.Color.HotPink;
            this.TxtDireccionTB2.BorderRadius = 0;
            this.TxtDireccionTB2.BorderSize = 2;
            this.TxtDireccionTB2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDireccionTB2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtDireccionTB2.Location = new System.Drawing.Point(164, 96);
            this.TxtDireccionTB2.Margin = new System.Windows.Forms.Padding(5);
            this.TxtDireccionTB2.Multiline = true;
            this.TxtDireccionTB2.Name = "TxtDireccionTB2";
            this.TxtDireccionTB2.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.TxtDireccionTB2.PasswordChar = false;
            this.TxtDireccionTB2.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TxtDireccionTB2.PlaceholderText = "";
            this.TxtDireccionTB2.Size = new System.Drawing.Size(333, 90);
            this.TxtDireccionTB2.TabIndex = 9;
            this.TxtDireccionTB2.Texts = "Direccion";
            this.TxtDireccionTB2.UnderlinedStyle = false;
            // 
            // TxtNombreTB2
            // 
            this.TxtNombreTB2.BackColor = System.Drawing.SystemColors.Window;
            this.TxtNombreTB2.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.TxtNombreTB2.BorderFocusColor = System.Drawing.Color.HotPink;
            this.TxtNombreTB2.BorderRadius = 0;
            this.TxtNombreTB2.BorderSize = 2;
            this.TxtNombreTB2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombreTB2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtNombreTB2.Location = new System.Drawing.Point(164, 196);
            this.TxtNombreTB2.Margin = new System.Windows.Forms.Padding(5);
            this.TxtNombreTB2.Multiline = false;
            this.TxtNombreTB2.Name = "TxtNombreTB2";
            this.TxtNombreTB2.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.TxtNombreTB2.PasswordChar = false;
            this.TxtNombreTB2.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TxtNombreTB2.PlaceholderText = "";
            this.TxtNombreTB2.Size = new System.Drawing.Size(333, 39);
            this.TxtNombreTB2.TabIndex = 10;
            this.TxtNombreTB2.Texts = "Nombre";
            this.TxtNombreTB2.UnderlinedStyle = false;
            // 
            // PnlLista
            // 
            this.PnlLista.Controls.Add(this.DtgClientes);
            this.PnlLista.Controls.Add(this.BtnBuscar);
            this.PnlLista.Controls.Add(this.TxtBuscar);
            this.PnlLista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlLista.Location = new System.Drawing.Point(4, 4);
            this.PnlLista.Margin = new System.Windows.Forms.Padding(4);
            this.PnlLista.Name = "PnlLista";
            this.PnlLista.Size = new System.Drawing.Size(394, 412);
            this.PnlLista.TabIndex = 1;
            // 
            // DtgClientes
            // 
            this.DtgClientes.AllowUserToAddRows = false;
            this.DtgClientes.AllowUserToDeleteRows = false;
            this.DtgClientes.AllowUserToOrderColumns = true;
            this.DtgClientes.AllowUserToResizeRows = false;
            this.DtgClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DtgClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtgClientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(54)))), ((int)(((byte)(58)))));
            this.DtgClientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DtgClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(41)))), ((int)(((byte)(83)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DtgClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DtgClientes.ColumnHeadersHeight = 29;
            this.DtgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DtgClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TelefonoCliente});
            this.DtgClientes.EnableHeadersVisualStyles = false;
            this.DtgClientes.GridColor = System.Drawing.Color.MediumSlateBlue;
            this.DtgClientes.Location = new System.Drawing.Point(7, 53);
            this.DtgClientes.Margin = new System.Windows.Forms.Padding(4);
            this.DtgClientes.Name = "DtgClientes";
            this.DtgClientes.ReadOnly = true;
            this.DtgClientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DtgClientes.RowHeadersVisible = false;
            this.DtgClientes.RowHeadersWidth = 51;
            this.DtgClientes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DtgClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DtgClientes.Size = new System.Drawing.Size(384, 359);
            this.DtgClientes.TabIndex = 2;
            this.DtgClientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgClientes_CellDoubleClick);
            this.DtgClientes.Scroll += new System.Windows.Forms.ScrollEventHandler(this.DtgClientes_Scroll);
            // 
            // TelefonoCliente
            // 
            this.TelefonoCliente.HeaderText = "Telefono del cliente";
            this.TelefonoCliente.MinimumWidth = 6;
            this.TelefonoCliente.Name = "TelefonoCliente";
            this.TelefonoCliente.ReadOnly = true;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnBuscar.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnBuscar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnBuscar.BorderRadius = 0;
            this.BtnBuscar.BorderSize = 0;
            this.BtnBuscar.FlatAppearance.BorderSize = 0;
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscar.ForeColor = System.Drawing.Color.White;
            this.BtnBuscar.Location = new System.Drawing.Point(269, 5);
            this.BtnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(120, 38);
            this.BtnBuscar.TabIndex = 1;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.TextColor = System.Drawing.Color.White;
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.BackColor = System.Drawing.SystemColors.Window;
            this.TxtBuscar.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.TxtBuscar.BorderFocusColor = System.Drawing.Color.HotPink;
            this.TxtBuscar.BorderRadius = 0;
            this.TxtBuscar.BorderSize = 2;
            this.TxtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtBuscar.Location = new System.Drawing.Point(5, 5);
            this.TxtBuscar.Margin = new System.Windows.Forms.Padding(5);
            this.TxtBuscar.Multiline = false;
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.TxtBuscar.PasswordChar = false;
            this.TxtBuscar.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TxtBuscar.PlaceholderText = "";
            this.TxtBuscar.Size = new System.Drawing.Size(255, 39);
            this.TxtBuscar.TabIndex = 0;
            this.TxtBuscar.Texts = "";
            this.TxtBuscar.UnderlinedStyle = false;
            this.TxtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBuscar_KeyPress);
            // 
            // FrmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(54)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.PnlMain);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmClientes";
            this.Tag = "Clientes";
            this.Text = "FrmClientes";
            this.PnlMain.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.PnlClientes.ResumeLayout(false);
            this.PnlDetalles.ResumeLayout(false);
            this.Tbc.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.PnlLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DtgClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel PnlMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private RJCodeAdvance.RJControls.RJButton BtnCerrar;
        private System.Windows.Forms.TableLayoutPanel PnlClientes;
        private System.Windows.Forms.Panel PnlDetalles;
        private MaterialSkin.Controls.MaterialLabel LblCantidad;
        private RJCodeAdvance.RJControls.RJButton BtnBorrarCliente;
        private RJCodeAdvance.RJControls.RJTextBox TxtNombreTB1;
        private RJCodeAdvance.RJControls.RJTextBox TxtDireccionTB1;
        private RJCodeAdvance.RJControls.RJTextBox TxtTelefonoTB1;
        private System.Windows.Forms.Panel PnlLista;
        private RJCodeAdvance.RJControls.RJButton BtnBuscar;
        private RJCodeAdvance.RJControls.RJTextBox TxtBuscar;
        private System.Windows.Forms.DataGridView DtgClientes;
        private RJCodeAdvance.RJControls.RJButton BtnGuardarDatos;
        private MaterialSkin.Controls.MaterialTabControl Tbc;
        private System.Windows.Forms.TabPage tabPage1;
        private RJCodeAdvance.RJControls.RJButton BtnModificarCliente;
        private System.Windows.Forms.TabPage tabPage2;
        private RJCodeAdvance.RJControls.RJButton BtnAbrirNuevo;
        private MaterialSkin.Controls.MaterialLabel LblCantidadPedidos;
        private RJCodeAdvance.RJControls.RJTextBox TxtTelefonoTB2;
        private RJCodeAdvance.RJControls.RJTextBox TxtDireccionTB2;
        private RJCodeAdvance.RJControls.RJTextBox TxtNombreTB2;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelefonoCliente;
    }
}