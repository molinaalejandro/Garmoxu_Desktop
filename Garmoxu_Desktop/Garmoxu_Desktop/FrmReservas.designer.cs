namespace Garmoxu_Desktop
{
    partial class FrmReservas
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
            this.BtnCerrar = new RJCodeAdvance.RJControls.RJButton();
            this.BtnNuevo = new RJCodeAdvance.RJControls.RJButton();
            this.BtnEliminar = new RJCodeAdvance.RJControls.RJButton();
            this.PnlBusqueda = new System.Windows.Forms.TableLayoutPanel();
            this.BtnBuscar = new RJCodeAdvance.RJControls.RJButton();
            this.PnlCalendar = new System.Windows.Forms.Panel();
            this.ChkCalendar = new MaterialSkin.Controls.MaterialCheckBox();
            this.DtpBuscar = new RJCodeAdvance.RJControls.RJDatePicker();
            this.PnlBuscar = new System.Windows.Forms.Panel();
            this.PnlSubFiltro = new System.Windows.Forms.TableLayoutPanel();
            this.BtnMesa = new RJCodeAdvance.RJControls.RJButton();
            this.TxtBuscar = new RJCodeAdvance.RJControls.RJTextBox();
            this.BtnCliente = new RJCodeAdvance.RJControls.RJButton();
            this.DtgReservas = new System.Windows.Forms.DataGridView();
            this.PnlMain.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.PnlBusqueda.SuspendLayout();
            this.PnlCalendar.SuspendLayout();
            this.PnlSubFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgReservas)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlMain
            // 
            this.PnlMain.ColumnCount = 1;
            this.PnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PnlMain.Controls.Add(this.tableLayoutPanel1, 0, 2);
            this.PnlMain.Controls.Add(this.PnlBusqueda, 0, 0);
            this.PnlMain.Controls.Add(this.DtgReservas, 0, 1);
            this.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlMain.Location = new System.Drawing.Point(0, 0);
            this.PnlMain.Margin = new System.Windows.Forms.Padding(4);
            this.PnlMain.Name = "PnlMain";
            this.PnlMain.Padding = new System.Windows.Forms.Padding(27, 25, 27, 25);
            this.PnlMain.RowCount = 3;
            this.PnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.PnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.PnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.PnlMain.Size = new System.Drawing.Size(1067, 554);
            this.PnlMain.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.BtnCerrar, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.BtnNuevo, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.BtnEliminar, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(31, 466);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1005, 59);
            this.tableLayoutPanel1.TabIndex = 4;
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
            this.BtnCerrar.Size = new System.Drawing.Size(193, 49);
            this.BtnCerrar.TabIndex = 0;
            this.BtnCerrar.Text = "Cerrar";
            this.BtnCerrar.TextColor = System.Drawing.Color.White;
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnNuevo.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnNuevo.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnNuevo.BorderRadius = 0;
            this.BtnNuevo.BorderSize = 0;
            this.BtnNuevo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnNuevo.FlatAppearance.BorderSize = 0;
            this.BtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNuevo.ForeColor = System.Drawing.Color.White;
            this.BtnNuevo.Location = new System.Drawing.Point(808, 4);
            this.BtnNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(193, 49);
            this.BtnNuevo.TabIndex = 1;
            this.BtnNuevo.Text = "Nueva Reserva";
            this.BtnNuevo.TextColor = System.Drawing.Color.White;
            this.BtnNuevo.UseVisualStyleBackColor = false;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnEliminar.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnEliminar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnEliminar.BorderRadius = 0;
            this.BtnEliminar.BorderSize = 0;
            this.BtnEliminar.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnEliminar.Enabled = false;
            this.BtnEliminar.FlatAppearance.BorderSize = 0;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.ForeColor = System.Drawing.Color.White;
            this.BtnEliminar.Location = new System.Drawing.Point(607, 4);
            this.BtnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(193, 49);
            this.BtnEliminar.TabIndex = 2;
            this.BtnEliminar.Text = "Eliminar Reserva";
            this.BtnEliminar.TextColor = System.Drawing.Color.White;
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // PnlBusqueda
            // 
            this.PnlBusqueda.ColumnCount = 5;
            this.PnlBusqueda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.PnlBusqueda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.PnlBusqueda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.PnlBusqueda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.PnlBusqueda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.PnlBusqueda.Controls.Add(this.BtnBuscar, 4, 0);
            this.PnlBusqueda.Controls.Add(this.PnlCalendar, 0, 0);
            this.PnlBusqueda.Controls.Add(this.PnlBuscar, 3, 0);
            this.PnlBusqueda.Controls.Add(this.PnlSubFiltro, 2, 0);
            this.PnlBusqueda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlBusqueda.Location = new System.Drawing.Point(31, 29);
            this.PnlBusqueda.Margin = new System.Windows.Forms.Padding(4);
            this.PnlBusqueda.Name = "PnlBusqueda";
            this.PnlBusqueda.RowCount = 1;
            this.PnlBusqueda.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PnlBusqueda.Size = new System.Drawing.Size(1005, 54);
            this.PnlBusqueda.TabIndex = 0;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnBuscar.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnBuscar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnBuscar.BorderRadius = 0;
            this.BtnBuscar.BorderSize = 0;
            this.BtnBuscar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnBuscar.FlatAppearance.BorderSize = 0;
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscar.ForeColor = System.Drawing.Color.White;
            this.BtnBuscar.Location = new System.Drawing.Point(806, 4);
            this.BtnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(195, 46);
            this.BtnBuscar.TabIndex = 0;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.TextColor = System.Drawing.Color.White;
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // PnlCalendar
            // 
            this.PnlCalendar.Controls.Add(this.ChkCalendar);
            this.PnlCalendar.Controls.Add(this.DtpBuscar);
            this.PnlCalendar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlCalendar.Location = new System.Drawing.Point(4, 4);
            this.PnlCalendar.Margin = new System.Windows.Forms.Padding(4);
            this.PnlCalendar.Name = "PnlCalendar";
            this.PnlCalendar.Size = new System.Drawing.Size(343, 46);
            this.PnlCalendar.TabIndex = 9;
            // 
            // ChkCalendar
            // 
            this.ChkCalendar.AutoSize = true;
            this.ChkCalendar.Depth = 0;
            this.ChkCalendar.Font = new System.Drawing.Font("Roboto", 10F);
            this.ChkCalendar.Location = new System.Drawing.Point(12, 2);
            this.ChkCalendar.Margin = new System.Windows.Forms.Padding(0);
            this.ChkCalendar.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ChkCalendar.MouseState = MaterialSkin.MouseState.HOVER;
            this.ChkCalendar.Name = "ChkCalendar";
            this.ChkCalendar.Ripple = true;
            this.ChkCalendar.Size = new System.Drawing.Size(26, 30);
            this.ChkCalendar.TabIndex = 7;
            this.ChkCalendar.UseVisualStyleBackColor = true;
            // 
            // DtpBuscar
            // 
            this.DtpBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DtpBuscar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.DtpBuscar.BorderSize = 0;
            this.DtpBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.DtpBuscar.Location = new System.Drawing.Point(51, 2);
            this.DtpBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.DtpBuscar.MinimumSize = new System.Drawing.Size(4, 35);
            this.DtpBuscar.Name = "DtpBuscar";
            this.DtpBuscar.Size = new System.Drawing.Size(291, 35);
            this.DtpBuscar.SkinColor = System.Drawing.Color.MediumSlateBlue;
            this.DtpBuscar.TabIndex = 6;
            this.DtpBuscar.TextColor = System.Drawing.Color.White;
            this.DtpBuscar.ValueChanged += new System.EventHandler(this.DtpBuscar_ValueChanged);
            // 
            // PnlBuscar
            // 
            this.PnlBuscar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlBuscar.Location = new System.Drawing.Point(756, 4);
            this.PnlBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.PnlBuscar.Name = "PnlBuscar";
            this.PnlBuscar.Size = new System.Drawing.Size(42, 46);
            this.PnlBuscar.TabIndex = 11;
            // 
            // PnlSubFiltro
            // 
            this.PnlSubFiltro.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.PnlSubFiltro.ColumnCount = 3;
            this.PnlSubFiltro.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.PnlSubFiltro.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.PnlSubFiltro.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.PnlSubFiltro.Controls.Add(this.BtnMesa, 0, 0);
            this.PnlSubFiltro.Controls.Add(this.TxtBuscar, 0, 0);
            this.PnlSubFiltro.Controls.Add(this.BtnCliente, 0, 0);
            this.PnlSubFiltro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlSubFiltro.Location = new System.Drawing.Point(405, 4);
            this.PnlSubFiltro.Margin = new System.Windows.Forms.Padding(4);
            this.PnlSubFiltro.Name = "PnlSubFiltro";
            this.PnlSubFiltro.RowCount = 1;
            this.PnlSubFiltro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PnlSubFiltro.Size = new System.Drawing.Size(343, 46);
            this.PnlSubFiltro.TabIndex = 12;
            // 
            // BtnMesa
            // 
            this.BtnMesa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(41)))), ((int)(((byte)(83)))));
            this.BtnMesa.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(41)))), ((int)(((byte)(83)))));
            this.BtnMesa.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnMesa.BorderRadius = 0;
            this.BtnMesa.BorderSize = 0;
            this.BtnMesa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnMesa.FlatAppearance.BorderSize = 0;
            this.BtnMesa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMesa.ForeColor = System.Drawing.Color.White;
            this.BtnMesa.Location = new System.Drawing.Point(277, 4);
            this.BtnMesa.Margin = new System.Windows.Forms.Padding(4);
            this.BtnMesa.Name = "BtnMesa";
            this.BtnMesa.Size = new System.Drawing.Size(62, 38);
            this.BtnMesa.TabIndex = 20;
            this.BtnMesa.Text = "Mesa";
            this.BtnMesa.TextColor = System.Drawing.Color.White;
            this.BtnMesa.UseVisualStyleBackColor = false;
            this.BtnMesa.Click += new System.EventHandler(this.BtnMesa_Click);
            this.BtnMesa.MouseEnter += new System.EventHandler(this.BtnMesa_MouseEnter);
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.BackColor = System.Drawing.SystemColors.Window;
            this.TxtBuscar.BorderColor = System.Drawing.SystemColors.Window;
            this.TxtBuscar.BorderFocusColor = System.Drawing.Color.MediumSlateBlue;
            this.TxtBuscar.BorderRadius = 0;
            this.TxtBuscar.BorderSize = 2;
            this.TxtBuscar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtBuscar.Location = new System.Drawing.Point(73, 5);
            this.TxtBuscar.Margin = new System.Windows.Forms.Padding(5);
            this.TxtBuscar.Multiline = false;
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.TxtBuscar.PasswordChar = false;
            this.TxtBuscar.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TxtBuscar.PlaceholderText = "";
            this.TxtBuscar.Size = new System.Drawing.Size(195, 39);
            this.TxtBuscar.TabIndex = 19;
            this.TxtBuscar.Texts = "";
            this.TxtBuscar.UnderlinedStyle = false;
            this.TxtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBuscar_KeyPress);
            // 
            // BtnCliente
            // 
            this.BtnCliente.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnCliente.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnCliente.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnCliente.BorderRadius = 0;
            this.BtnCliente.BorderSize = 0;
            this.BtnCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnCliente.FlatAppearance.BorderSize = 0;
            this.BtnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCliente.ForeColor = System.Drawing.Color.White;
            this.BtnCliente.Location = new System.Drawing.Point(4, 4);
            this.BtnCliente.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCliente.Name = "BtnCliente";
            this.BtnCliente.Size = new System.Drawing.Size(60, 38);
            this.BtnCliente.TabIndex = 18;
            this.BtnCliente.Text = "Cliente";
            this.BtnCliente.TextColor = System.Drawing.Color.White;
            this.BtnCliente.UseVisualStyleBackColor = false;
            this.BtnCliente.Click += new System.EventHandler(this.BtnCliente_Click);
            this.BtnCliente.MouseEnter += new System.EventHandler(this.BtnCliente_MouseEnter);
            // 
            // DtgReservas
            // 
            this.DtgReservas.AllowUserToAddRows = false;
            this.DtgReservas.AllowUserToDeleteRows = false;
            this.DtgReservas.AllowUserToOrderColumns = true;
            this.DtgReservas.AllowUserToResizeRows = false;
            this.DtgReservas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DtgReservas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtgReservas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(54)))), ((int)(((byte)(58)))));
            this.DtgReservas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DtgReservas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(41)))), ((int)(((byte)(83)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.OrangeRed;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DtgReservas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DtgReservas.ColumnHeadersHeight = 29;
            this.DtgReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DtgReservas.EnableHeadersVisualStyles = false;
            this.DtgReservas.GridColor = System.Drawing.Color.MediumSlateBlue;
            this.DtgReservas.Location = new System.Drawing.Point(31, 91);
            this.DtgReservas.Margin = new System.Windows.Forms.Padding(4);
            this.DtgReservas.MultiSelect = false;
            this.DtgReservas.Name = "DtgReservas";
            this.DtgReservas.ReadOnly = true;
            this.DtgReservas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DtgReservas.RowHeadersVisible = false;
            this.DtgReservas.RowHeadersWidth = 51;
            this.DtgReservas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DtgReservas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DtgReservas.Size = new System.Drawing.Size(1005, 367);
            this.DtgReservas.TabIndex = 1;
            this.DtgReservas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgReservas_CellDoubleClick);
            this.DtgReservas.SelectionChanged += new System.EventHandler(this.DtgReservas_SelectionChanged);
            // 
            // FrmReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(54)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.PnlMain);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmReservas";
            this.Text = "FrmReservas";
            this.EnabledChanged += new System.EventHandler(this.FrmReservas_EnabledChanged);
            this.PnlMain.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.PnlBusqueda.ResumeLayout(false);
            this.PnlCalendar.ResumeLayout(false);
            this.PnlCalendar.PerformLayout();
            this.PnlSubFiltro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DtgReservas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel PnlMain;
        private System.Windows.Forms.TableLayoutPanel PnlBusqueda;
        private System.Windows.Forms.DataGridView DtgReservas;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private RJCodeAdvance.RJControls.RJButton BtnCerrar;
        private System.Windows.Forms.Panel PnlCalendar;
        private MaterialSkin.Controls.MaterialCheckBox ChkCalendar;
        private RJCodeAdvance.RJControls.RJDatePicker DtpBuscar;
        private System.Windows.Forms.Panel PnlBuscar;
        private RJCodeAdvance.RJControls.RJButton BtnBuscar;
        private System.Windows.Forms.TableLayoutPanel PnlSubFiltro;
        private RJCodeAdvance.RJControls.RJButton BtnCliente;
        private RJCodeAdvance.RJControls.RJTextBox TxtBuscar;
        private RJCodeAdvance.RJControls.RJButton BtnMesa;
        private RJCodeAdvance.RJControls.RJButton BtnNuevo;
        private RJCodeAdvance.RJControls.RJButton BtnEliminar;
    }
}