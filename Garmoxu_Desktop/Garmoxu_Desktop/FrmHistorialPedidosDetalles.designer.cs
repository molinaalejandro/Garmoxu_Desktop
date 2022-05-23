namespace Garmoxu_Desktop
{
    partial class FrmHistorialPedidosDetalles
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHistorialPedidosDetalles));
            this.PnlPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.PnlTitleBar = new System.Windows.Forms.TableLayoutPanel();
            this.BtnClose = new FontAwesome.Sharp.IconButton();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.PnlDatos = new System.Windows.Forms.TableLayoutPanel();
            this.DtgPlatosPedidos = new System.Windows.Forms.DataGridView();
            this.Código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.LblMetodoPago = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.BtnBorrar = new RJCodeAdvance.RJControls.RJButton();
            this.LblPrecioConIVA = new System.Windows.Forms.Label();
            this.LblPrecioSinIVA = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.LblTlf = new System.Windows.Forms.Label();
            this.LblTipo = new System.Windows.Forms.Label();
            this.LblFecha = new System.Windows.Forms.Label();
            this.LblHora = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnPdf = new FontAwesome.Sharp.IconButton();
            this.PnlPrincipal.SuspendLayout();
            this.PnlTitleBar.SuspendLayout();
            this.PnlDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgPlatosPedidos)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlPrincipal
            // 
            this.PnlPrincipal.ColumnCount = 1;
            this.PnlPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PnlPrincipal.Controls.Add(this.PnlTitleBar, 0, 0);
            this.PnlPrincipal.Controls.Add(this.PnlDatos, 0, 2);
            this.PnlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlPrincipal.Location = new System.Drawing.Point(0, 0);
            this.PnlPrincipal.Name = "PnlPrincipal";
            this.PnlPrincipal.RowCount = 3;
            this.PnlPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.PnlPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.PnlPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PnlPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.PnlPrincipal.Size = new System.Drawing.Size(1498, 817);
            this.PnlPrincipal.TabIndex = 25;
            // 
            // PnlTitleBar
            // 
            this.PnlTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(45)))));
            this.PnlTitleBar.ColumnCount = 2;
            this.PnlTitleBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PnlTitleBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.PnlTitleBar.Controls.Add(this.BtnClose, 1, 0);
            this.PnlTitleBar.Controls.Add(this.LblTitulo, 0, 0);
            this.PnlTitleBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlTitleBar.Location = new System.Drawing.Point(0, 0);
            this.PnlTitleBar.Margin = new System.Windows.Forms.Padding(0);
            this.PnlTitleBar.Name = "PnlTitleBar";
            this.PnlTitleBar.RowCount = 1;
            this.PnlTitleBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PnlTitleBar.Size = new System.Drawing.Size(1498, 72);
            this.PnlTitleBar.TabIndex = 54;
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.Color.Transparent;
            this.BtnClose.Dock = System.Windows.Forms.DockStyle.Right;
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
            this.BtnClose.Location = new System.Drawing.Point(1431, 0);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(0);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(67, 72);
            this.BtnClose.TabIndex = 2;
            this.BtnClose.TabStop = false;
            this.BtnClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblTitulo.Font = new System.Drawing.Font("Source Sans Pro", 18F, System.Drawing.FontStyle.Bold);
            this.LblTitulo.ForeColor = System.Drawing.Color.White;
            this.LblTitulo.Location = new System.Drawing.Point(14, 0);
            this.LblTitulo.Margin = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(1417, 72);
            this.LblTitulo.TabIndex = 52;
            this.LblTitulo.Text = "Consulta el pedido ";
            this.LblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PnlDatos
            // 
            this.PnlDatos.ColumnCount = 3;
            this.PnlDatos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.PnlDatos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PnlDatos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.PnlDatos.Controls.Add(this.DtgPlatosPedidos, 1, 2);
            this.PnlDatos.Controls.Add(this.tableLayoutPanel3, 1, 3);
            this.PnlDatos.Controls.Add(this.tableLayoutPanel1, 1, 0);
            this.PnlDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlDatos.Location = new System.Drawing.Point(3, 125);
            this.PnlDatos.Name = "PnlDatos";
            this.PnlDatos.RowCount = 5;
            this.PnlDatos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.PnlDatos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.PnlDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PnlDatos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.PnlDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.PnlDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.PnlDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.PnlDatos.Size = new System.Drawing.Size(1492, 689);
            this.PnlDatos.TabIndex = 25;
            // 
            // DtgPlatosPedidos
            // 
            this.DtgPlatosPedidos.AllowUserToAddRows = false;
            this.DtgPlatosPedidos.AllowUserToDeleteRows = false;
            this.DtgPlatosPedidos.AllowUserToOrderColumns = true;
            this.DtgPlatosPedidos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Source Sans Pro", 15F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(190)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.DtgPlatosPedidos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DtgPlatosPedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtgPlatosPedidos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DtgPlatosPedidos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.DtgPlatosPedidos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DtgPlatosPedidos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DtgPlatosPedidos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Source Sans Pro", 14F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DtgPlatosPedidos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DtgPlatosPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgPlatosPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Código,
            this.Column1,
            this.Column2,
            this.Column5,
            this.Column3,
            this.Column4,
            this.Column6});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Source Sans Pro", 14F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(190)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DtgPlatosPedidos.DefaultCellStyle = dataGridViewCellStyle3;
            this.DtgPlatosPedidos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DtgPlatosPedidos.EnableHeadersVisualStyles = false;
            this.DtgPlatosPedidos.GridColor = System.Drawing.Color.MediumSlateBlue;
            this.DtgPlatosPedidos.Location = new System.Drawing.Point(75, 70);
            this.DtgPlatosPedidos.Margin = new System.Windows.Forms.Padding(5, 4, 5, 15);
            this.DtgPlatosPedidos.MultiSelect = false;
            this.DtgPlatosPedidos.Name = "DtgPlatosPedidos";
            this.DtgPlatosPedidos.ReadOnly = true;
            this.DtgPlatosPedidos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(110)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DtgPlatosPedidos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DtgPlatosPedidos.RowHeadersVisible = false;
            this.DtgPlatosPedidos.RowHeadersWidth = 51;
            this.DtgPlatosPedidos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DtgPlatosPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DtgPlatosPedidos.Size = new System.Drawing.Size(1342, 483);
            this.DtgPlatosPedidos.TabIndex = 55;
            this.DtgPlatosPedidos.TabStop = false;
            // 
            // Código
            // 
            this.Código.FillWeight = 74.86631F;
            this.Código.HeaderText = "Código";
            this.Código.MinimumWidth = 6;
            this.Código.Name = "Código";
            this.Código.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.FillWeight = 226.1971F;
            this.Column1.HeaderText = "Nombre";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 90.10651F;
            this.Column2.HeaderText = "P. Unitario sin IVA";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.FillWeight = 88.13225F;
            this.Column5.HeaderText = "P. Unitario con IVA";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 73.7607F;
            this.Column3.HeaderText = "Cantidad";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.FillWeight = 74.17769F;
            this.Column4.HeaderText = "P. Total sin IVA";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.FillWeight = 72.75949F;
            this.Column6.HeaderText = "P. Total con IVA";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 10;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.Controls.Add(this.LblMetodoPago, 7, 0);
            this.tableLayoutPanel3.Controls.Add(this.label8, 6, 0);
            this.tableLayoutPanel3.Controls.Add(this.BtnBorrar, 9, 0);
            this.tableLayoutPanel3.Controls.Add(this.LblPrecioConIVA, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.LblPrecioSinIVA, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label1, 3, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(73, 571);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1346, 65);
            this.tableLayoutPanel3.TabIndex = 62;
            // 
            // LblMetodoPago
            // 
            this.LblMetodoPago.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LblMetodoPago.AutoSize = true;
            this.LblMetodoPago.Font = new System.Drawing.Font("Source Sans Pro", 15.2F, System.Drawing.FontStyle.Bold);
            this.LblMetodoPago.ForeColor = System.Drawing.Color.Gainsboro;
            this.LblMetodoPago.Location = new System.Drawing.Point(951, 16);
            this.LblMetodoPago.Name = "LblMetodoPago";
            this.LblMetodoPago.Size = new System.Drawing.Size(94, 33);
            this.LblMetodoPago.TabIndex = 67;
            this.LblMetodoPago.Text = "Tarjeta";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Source Sans Pro", 15.2F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Silver;
            this.label8.Location = new System.Drawing.Point(741, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(204, 33);
            this.label8.TabIndex = 66;
            this.label8.Text = "Método de pago:";
            // 
            // BtnBorrar
            // 
            this.BtnBorrar.BackColor = System.Drawing.Color.Crimson;
            this.BtnBorrar.BackgroundColor = System.Drawing.Color.Crimson;
            this.BtnBorrar.BorderColor = System.Drawing.Color.Transparent;
            this.BtnBorrar.BorderRadius = 15;
            this.BtnBorrar.BorderSize = 0;
            this.BtnBorrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBorrar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnBorrar.FlatAppearance.BorderSize = 0;
            this.BtnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBorrar.Font = new System.Drawing.Font("Source Sans Pro", 16.2F, System.Drawing.FontStyle.Bold);
            this.BtnBorrar.ForeColor = System.Drawing.Color.White;
            this.BtnBorrar.Location = new System.Drawing.Point(1154, 0);
            this.BtnBorrar.Margin = new System.Windows.Forms.Padding(0);
            this.BtnBorrar.Name = "BtnBorrar";
            this.BtnBorrar.Size = new System.Drawing.Size(192, 65);
            this.BtnBorrar.TabIndex = 59;
            this.BtnBorrar.TabStop = false;
            this.BtnBorrar.Text = "Eliminar";
            this.BtnBorrar.TextColor = System.Drawing.Color.White;
            this.BtnBorrar.UseVisualStyleBackColor = false;
            this.BtnBorrar.Click += new System.EventHandler(this.BtnBorrar_Click);
            // 
            // LblPrecioConIVA
            // 
            this.LblPrecioConIVA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LblPrecioConIVA.AutoSize = true;
            this.LblPrecioConIVA.Font = new System.Drawing.Font("Source Sans Pro", 15.2F, System.Drawing.FontStyle.Bold);
            this.LblPrecioConIVA.ForeColor = System.Drawing.Color.Gainsboro;
            this.LblPrecioConIVA.Location = new System.Drawing.Point(190, 16);
            this.LblPrecioConIVA.Name = "LblPrecioConIVA";
            this.LblPrecioConIVA.Size = new System.Drawing.Size(79, 33);
            this.LblPrecioConIVA.TabIndex = 65;
            this.LblPrecioConIVA.Text = "0,00€";
            // 
            // LblPrecioSinIVA
            // 
            this.LblPrecioSinIVA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LblPrecioSinIVA.AutoSize = true;
            this.LblPrecioSinIVA.Font = new System.Drawing.Font("Source Sans Pro", 15.2F, System.Drawing.FontStyle.Bold);
            this.LblPrecioSinIVA.ForeColor = System.Drawing.Color.Gainsboro;
            this.LblPrecioSinIVA.Location = new System.Drawing.Point(556, 16);
            this.LblPrecioSinIVA.Name = "LblPrecioSinIVA";
            this.LblPrecioSinIVA.Size = new System.Drawing.Size(79, 33);
            this.LblPrecioSinIVA.TabIndex = 64;
            this.LblPrecioSinIVA.Text = "0,00€";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Source Sans Pro", 15.2F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(3, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 33);
            this.label3.TabIndex = 63;
            this.label3.Text = "Precio con IVA:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Source Sans Pro", 15.2F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(375, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 33);
            this.label1.TabIndex = 62;
            this.label1.Text = "Precio sin IVA:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 13;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.LblTlf, 10, 0);
            this.tableLayoutPanel1.Controls.Add(this.LblTipo, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.LblFecha, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.LblHora, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.label7, 9, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label6, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.BtnPdf, 12, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(73, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1346, 60);
            this.tableLayoutPanel1.TabIndex = 63;
            // 
            // LblTlf
            // 
            this.LblTlf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LblTlf.AutoSize = true;
            this.LblTlf.Font = new System.Drawing.Font("Source Sans Pro", 15.2F, System.Drawing.FontStyle.Bold);
            this.LblTlf.ForeColor = System.Drawing.Color.Gainsboro;
            this.LblTlf.Location = new System.Drawing.Point(1048, 13);
            this.LblTlf.Name = "LblTlf";
            this.LblTlf.Size = new System.Drawing.Size(183, 33);
            this.LblTlf.TabIndex = 80;
            this.LblTlf.Text = "+34000000000";
            // 
            // LblTipo
            // 
            this.LblTipo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LblTipo.AutoSize = true;
            this.LblTipo.Font = new System.Drawing.Font("Source Sans Pro", 15.2F, System.Drawing.FontStyle.Bold);
            this.LblTipo.ForeColor = System.Drawing.Color.Gainsboro;
            this.LblTipo.Location = new System.Drawing.Point(696, 13);
            this.LblTipo.Name = "LblTipo";
            this.LblTipo.Size = new System.Drawing.Size(65, 33);
            this.LblTipo.TabIndex = 79;
            this.LblTipo.Text = "Tipo";
            // 
            // LblFecha
            // 
            this.LblFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LblFecha.AutoSize = true;
            this.LblFecha.Font = new System.Drawing.Font("Source Sans Pro", 15.2F, System.Drawing.FontStyle.Bold);
            this.LblFecha.ForeColor = System.Drawing.Color.Gainsboro;
            this.LblFecha.Location = new System.Drawing.Point(100, 13);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(145, 33);
            this.LblFecha.TabIndex = 78;
            this.LblFecha.Text = "00/00/0000";
            // 
            // LblHora
            // 
            this.LblHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LblHora.AutoSize = true;
            this.LblHora.Font = new System.Drawing.Font("Source Sans Pro", 15.2F, System.Drawing.FontStyle.Bold);
            this.LblHora.ForeColor = System.Drawing.Color.Gainsboro;
            this.LblHora.Location = new System.Drawing.Point(375, 13);
            this.LblHora.Name = "LblHora";
            this.LblHora.Size = new System.Drawing.Size(79, 33);
            this.LblHora.TabIndex = 77;
            this.LblHora.Text = "00:00";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Source Sans Pro", 15.2F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Silver;
            this.label7.Location = new System.Drawing.Point(807, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(235, 33);
            this.label7.TabIndex = 76;
            this.label7.Text = "Teléfono de cliente:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Source Sans Pro", 15.2F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(3, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 33);
            this.label5.TabIndex = 73;
            this.label5.Text = "Fecha:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Source Sans Pro", 15.2F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Silver;
            this.label6.Location = new System.Drawing.Point(500, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(190, 33);
            this.label6.TabIndex = 75;
            this.label6.Text = "Tipo de pedido:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Source Sans Pro", 15.2F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(291, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 33);
            this.label4.TabIndex = 74;
            this.label4.Text = "Hora:";
            // 
            // BtnPdf
            // 
            this.BtnPdf.BackColor = System.Drawing.Color.Transparent;
            this.BtnPdf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPdf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnPdf.FlatAppearance.BorderSize = 0;
            this.BtnPdf.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnPdf.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnPdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPdf.ForeColor = System.Drawing.Color.Transparent;
            this.BtnPdf.IconChar = FontAwesome.Sharp.IconChar.FilePdf;
            this.BtnPdf.IconColor = System.Drawing.Color.White;
            this.BtnPdf.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtnPdf.Location = new System.Drawing.Point(1294, 0);
            this.BtnPdf.Margin = new System.Windows.Forms.Padding(0);
            this.BtnPdf.Name = "BtnPdf";
            this.BtnPdf.Size = new System.Drawing.Size(52, 60);
            this.BtnPdf.TabIndex = 72;
            this.BtnPdf.TabStop = false;
            this.BtnPdf.UseVisualStyleBackColor = false;
            this.BtnPdf.Click += new System.EventHandler(this.BtnPdf_Click);
            this.BtnPdf.MouseEnter += new System.EventHandler(this.BtnPdf_MouseEnter);
            this.BtnPdf.MouseLeave += new System.EventHandler(this.BtnPdf_MouseLeave);
            // 
            // FrmHistorialPedidosDetalles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(54)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(1498, 817);
            this.Controls.Add(this.PnlPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmHistorialPedidosDetalles";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta el historial de un pedido - Garmoxu";
            this.TopMost = true;
            this.Shown += new System.EventHandler(this.FrmHistorialPedidosDetalles_Shown);
            this.PnlPrincipal.ResumeLayout(false);
            this.PnlTitleBar.ResumeLayout(false);
            this.PnlTitleBar.PerformLayout();
            this.PnlDatos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DtgPlatosPedidos)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel PnlPrincipal;
        private System.Windows.Forms.TableLayoutPanel PnlTitleBar;
        private FontAwesome.Sharp.IconButton BtnClose;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.TableLayoutPanel PnlDatos;
        private System.Windows.Forms.DataGridView DtgPlatosPedidos;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label LblPrecioConIVA;
        private System.Windows.Forms.Label LblPrecioSinIVA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private RJCodeAdvance.RJControls.RJButton BtnBorrar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private FontAwesome.Sharp.IconButton BtnPdf;
        private System.Windows.Forms.Label LblTlf;
        private System.Windows.Forms.Label LblTipo;
        private System.Windows.Forms.Label LblFecha;
        private System.Windows.Forms.Label LblHora;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Código;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Label LblMetodoPago;
        private System.Windows.Forms.Label label8;
    }
}