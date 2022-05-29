namespace Garmoxu_Desktop
{
    partial class FrmHistorialPedidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHistorialPedidos));
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.DtgHistorial = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.DtpFechaPedido = new RJCodeAdvance.RJControls.RJDatePicker();
            this.TxtTelefono = new RJCodeAdvance.RJControls.RJTextBox();
            this.CboTipos = new RJCodeAdvance.RJControls.RJComboBox();
            this.BtnBuscar = new FontAwesome.Sharp.IconButton();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.ChkTipo = new Garmoxu_Desktop.MyCheckBox();
            this.LblTipo = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.ChkTelefono = new Garmoxu_Desktop.MyCheckBox();
            this.LblTelefono = new System.Windows.Forms.Label();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgHistorial)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.DtgHistorial, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.Padding = new System.Windows.Forms.Padding(70, 50, 70, 50);
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1587, 897);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // DtgHistorial
            // 
            this.DtgHistorial.AllowUserToAddRows = false;
            this.DtgHistorial.AllowUserToDeleteRows = false;
            this.DtgHistorial.AllowUserToOrderColumns = true;
            this.DtgHistorial.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Source Sans Pro", 15F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(190)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.DtgHistorial.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DtgHistorial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtgHistorial.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DtgHistorial.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.DtgHistorial.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DtgHistorial.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DtgHistorial.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Source Sans Pro", 15F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DtgHistorial.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DtgHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Source Sans Pro", 15F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(190)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DtgHistorial.DefaultCellStyle = dataGridViewCellStyle3;
            this.DtgHistorial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DtgHistorial.EnableHeadersVisualStyles = false;
            this.DtgHistorial.GridColor = System.Drawing.Color.MediumSlateBlue;
            this.DtgHistorial.Location = new System.Drawing.Point(70, 166);
            this.DtgHistorial.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.DtgHistorial.MultiSelect = false;
            this.DtgHistorial.Name = "DtgHistorial";
            this.DtgHistorial.ReadOnly = true;
            this.DtgHistorial.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DtgHistorial.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DtgHistorial.RowHeadersVisible = false;
            this.DtgHistorial.RowHeadersWidth = 51;
            this.DtgHistorial.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DtgHistorial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DtgHistorial.Size = new System.Drawing.Size(1447, 681);
            this.DtgHistorial.TabIndex = 8;
            this.DtgHistorial.TabStop = false;
            this.DtgHistorial.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgHistorial_CellDoubleClick);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 4;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.DtpFechaPedido, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.TxtTelefono, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.CboTipos, 2, 1);
            this.tableLayoutPanel4.Controls.Add(this.BtnBuscar, 3, 1);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel3, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.ForeColor = System.Drawing.Color.White;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(70, 50);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1447, 96);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Source Sans Pro", 15.2F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(437, 43);
            this.label1.TabIndex = 63;
            this.label1.Text = "Fecha de pedido";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DtpFechaPedido
            // 
            this.DtpFechaPedido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.DtpFechaPedido.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.DtpFechaPedido.BorderSize = 0;
            this.DtpFechaPedido.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.DtpFechaPedido.Font = new System.Drawing.Font("Source Sans Pro", 16.2F, System.Drawing.FontStyle.Bold);
            this.DtpFechaPedido.Location = new System.Drawing.Point(0, 64);
            this.DtpFechaPedido.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.DtpFechaPedido.MinimumSize = new System.Drawing.Size(4, 35);
            this.DtpFechaPedido.Name = "DtpFechaPedido";
            this.DtpFechaPedido.Size = new System.Drawing.Size(440, 41);
            this.DtpFechaPedido.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.DtpFechaPedido.TabIndex = 62;
            this.DtpFechaPedido.TabStop = false;
            this.DtpFechaPedido.TextColor = System.Drawing.Color.White;
            this.DtpFechaPedido.Value = new System.DateTime(2022, 5, 19, 0, 0, 0, 0);
            this.DtpFechaPedido.ValueChanged += new System.EventHandler(this.DtpBuscar_ValueChanged);
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.TxtTelefono.BorderColor = System.Drawing.Color.Transparent;
            this.TxtTelefono.BorderFocusColor = System.Drawing.Color.Gainsboro;
            this.TxtTelefono.BorderRadius = 10;
            this.TxtTelefono.BorderSize = 2;
            this.TxtTelefono.Dock = System.Windows.Forms.DockStyle.Top;
            this.TxtTelefono.Font = new System.Drawing.Font("Source Sans Pro", 16.2F, System.Drawing.FontStyle.Bold);
            this.TxtTelefono.ForeColor = System.Drawing.Color.Gray;
            this.TxtTelefono.Location = new System.Drawing.Point(470, 48);
            this.TxtTelefono.Margin = new System.Windows.Forms.Padding(30, 5, 0, 0);
            this.TxtTelefono.Multiline = false;
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.TxtTelefono.PasswordChar = false;
            this.TxtTelefono.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TxtTelefono.PlaceholderText = "";
            this.TxtTelefono.Size = new System.Drawing.Size(731, 55);
            this.TxtTelefono.TabIndex = 49;
            this.TxtTelefono.TabStop = false;
            this.TxtTelefono.Texts = "Buscar por teléfono de cliente";
            this.TxtTelefono.UnderlinedStyle = false;
            this.TxtTelefono._TextChanged += new System.EventHandler(this.TxtTelefono__TextChanged);
            this.TxtTelefono.Enter += new System.EventHandler(this.TxtTelefono_Enter);
            this.TxtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTelefono_KeyPress);
            this.TxtTelefono.Leave += new System.EventHandler(this.TxtTelefono_Leave);
            // 
            // CboTipos
            // 
            this.CboTipos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.CboTipos.BorderColor = System.Drawing.Color.Transparent;
            this.CboTipos.BorderSize = 0;
            this.CboTipos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CboTipos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CboTipos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboTipos.Font = new System.Drawing.Font("Source Sans Pro", 14F, System.Drawing.FontStyle.Bold);
            this.CboTipos.ForeColor = System.Drawing.Color.White;
            this.CboTipos.IconColor = System.Drawing.Color.White;
            this.CboTipos.Items.AddRange(new object[] {
            "Local",
            "Domicilio",
            "Recoger"});
            this.CboTipos.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.CboTipos.ListTextColor = System.Drawing.Color.DimGray;
            this.CboTipos.Location = new System.Drawing.Point(1085, 48);
            this.CboTipos.Margin = new System.Windows.Forms.Padding(30, 5, 0, 0);
            this.CboTipos.MinimumSize = new System.Drawing.Size(200, 30);
            this.CboTipos.Name = "CboTipos";
            this.CboTipos.Size = new System.Drawing.Size(300, 48);
            this.CboTipos.TabIndex = 28;
            this.CboTipos.TabStop = false;
            this.CboTipos.Texts = "";
            this.CboTipos.OnSelectedIndexChanged += new System.EventHandler(this.CboTipo_OnSelectedIndexChanged);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBuscar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(54)))), ((int)(((byte)(58)))));
            this.BtnBuscar.FlatAppearance.BorderSize = 0;
            this.BtnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscar.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.BtnBuscar.ForeColor = System.Drawing.Color.Transparent;
            this.BtnBuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.BtnBuscar.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnBuscar.Location = new System.Drawing.Point(1405, 48);
            this.BtnBuscar.Margin = new System.Windows.Forms.Padding(20, 5, 0, 0);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(42, 48);
            this.BtnBuscar.TabIndex = 45;
            this.BtnBuscar.TabStop = false;
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            this.BtnBuscar.MouseEnter += new System.EventHandler(this.BtnBuscar_MouseEnter);
            this.BtnBuscar.MouseLeave += new System.EventHandler(this.BtnBuscar_MouseLeave);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.ChkTipo, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.LblTipo, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(1055, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(330, 43);
            this.tableLayoutPanel3.TabIndex = 58;
            // 
            // ChkTipo
            // 
            this.ChkTipo.BackColor = System.Drawing.Color.Transparent;
            this.ChkTipo.Background = System.Drawing.Color.Transparent;
            this.ChkTipo.BorderColor = System.Drawing.Color.Silver;
            this.ChkTipo.BorderHeight = 15;
            this.ChkTipo.BorderWidth = 15;
            this.ChkTipo.Checked = false;
            this.ChkTipo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChkTipo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChkTipo.EnterColor = System.Drawing.Color.White;
            this.ChkTipo.Font = new System.Drawing.Font("Source Sans Pro Black", 14F, System.Drawing.FontStyle.Bold);
            this.ChkTipo.ForeColor = System.Drawing.Color.Silver;
            this.ChkTipo.LeaveColor = System.Drawing.Color.Silver;
            this.ChkTipo.Location = new System.Drawing.Point(218, 3);
            this.ChkTipo.Name = "ChkTipo";
            this.ChkTipo.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.ChkTipo.PaddingCheck = new System.Windows.Forms.Padding(0);
            this.ChkTipo.Size = new System.Drawing.Size(35, 37);
            this.ChkTipo.TabIndex = 57;
            this.ChkTipo.TabStop = false;
            this.ChkTipo.MouseEnter += new System.EventHandler(this.ChkTipo_MouseEnter);
            this.ChkTipo.MouseLeave += new System.EventHandler(this.ChkTipo_MouseLeave);
            // 
            // LblTipo
            // 
            this.LblTipo.AutoSize = true;
            this.LblTipo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblTipo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblTipo.Font = new System.Drawing.Font("Source Sans Pro", 15.2F, System.Drawing.FontStyle.Bold);
            this.LblTipo.ForeColor = System.Drawing.Color.Silver;
            this.LblTipo.Location = new System.Drawing.Point(30, 0);
            this.LblTipo.Margin = new System.Windows.Forms.Padding(30, 0, 3, 0);
            this.LblTipo.Name = "LblTipo";
            this.LblTipo.Size = new System.Drawing.Size(182, 43);
            this.LblTipo.TabIndex = 58;
            this.LblTipo.Text = "Tipo de pedido";
            this.LblTipo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblTipo.Click += new System.EventHandler(this.LblTipo_Click);
            this.LblTipo.MouseEnter += new System.EventHandler(this.ChkTipo_MouseEnter);
            this.LblTipo.MouseLeave += new System.EventHandler(this.ChkTipo_MouseLeave);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.ChkTelefono, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.LblTelefono, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(440, 0);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(615, 43);
            this.tableLayoutPanel5.TabIndex = 61;
            // 
            // ChkTelefono
            // 
            this.ChkTelefono.BackColor = System.Drawing.Color.Transparent;
            this.ChkTelefono.Background = System.Drawing.Color.Transparent;
            this.ChkTelefono.BorderColor = System.Drawing.Color.Silver;
            this.ChkTelefono.BorderHeight = 15;
            this.ChkTelefono.BorderWidth = 15;
            this.ChkTelefono.Checked = false;
            this.ChkTelefono.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChkTelefono.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChkTelefono.EnterColor = System.Drawing.Color.White;
            this.ChkTelefono.Font = new System.Drawing.Font("Source Sans Pro Black", 14F, System.Drawing.FontStyle.Bold);
            this.ChkTelefono.ForeColor = System.Drawing.Color.Silver;
            this.ChkTelefono.LeaveColor = System.Drawing.Color.Silver;
            this.ChkTelefono.Location = new System.Drawing.Point(263, 3);
            this.ChkTelefono.Name = "ChkTelefono";
            this.ChkTelefono.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.ChkTelefono.PaddingCheck = new System.Windows.Forms.Padding(0);
            this.ChkTelefono.Size = new System.Drawing.Size(35, 37);
            this.ChkTelefono.TabIndex = 59;
            this.ChkTelefono.TabStop = false;
            this.ChkTelefono.Text = "myCheckBox2";
            this.ChkTelefono.MouseEnter += new System.EventHandler(this.ChkTelefono_MouseEnter);
            this.ChkTelefono.MouseLeave += new System.EventHandler(this.ChkTelefono_MouseLeave);
            // 
            // LblTelefono
            // 
            this.LblTelefono.AutoSize = true;
            this.LblTelefono.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblTelefono.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblTelefono.Font = new System.Drawing.Font("Source Sans Pro", 15.2F, System.Drawing.FontStyle.Bold);
            this.LblTelefono.ForeColor = System.Drawing.Color.Silver;
            this.LblTelefono.Location = new System.Drawing.Point(30, 0);
            this.LblTelefono.Margin = new System.Windows.Forms.Padding(30, 0, 3, 0);
            this.LblTelefono.Name = "LblTelefono";
            this.LblTelefono.Size = new System.Drawing.Size(227, 43);
            this.LblTelefono.TabIndex = 60;
            this.LblTelefono.Text = "Teléfono de cliente";
            this.LblTelefono.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblTelefono.Click += new System.EventHandler(this.LblTelefono_Click);
            this.LblTelefono.MouseEnter += new System.EventHandler(this.ChkTelefono_MouseEnter);
            this.LblTelefono.MouseLeave += new System.EventHandler(this.ChkTelefono_MouseLeave);
            // 
            // FrmHistorialPedidos
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(54)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(1587, 897);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmHistorialPedidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "Historial de pedidos";
            this.Text = "Gestión de historial de pedidos - Garmoxu";
            this.Shown += new System.EventHandler(this.FrmHistorialPedidos_Shown);
            this.EnabledChanged += new System.EventHandler(this.FrmHistorialPedidos_EnabledChanged);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DtgHistorial)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView DtgHistorial;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private RJCodeAdvance.RJControls.RJDatePicker DtpFechaPedido;
        private RJCodeAdvance.RJControls.RJTextBox TxtTelefono;
        private RJCodeAdvance.RJControls.RJComboBox CboTipos;
        private FontAwesome.Sharp.IconButton BtnBuscar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private MyCheckBox ChkTipo;
        private System.Windows.Forms.Label LblTipo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private MyCheckBox ChkTelefono;
        private System.Windows.Forms.Label LblTelefono;
        private System.Windows.Forms.Label label1;
    }
}