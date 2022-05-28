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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReservas));
            this.PnlMain = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnNuevo = new FontAwesome.Sharp.IconButton();
            this.BtnEliminar = new FontAwesome.Sharp.IconButton();
            this.DtpBuscar = new RJCodeAdvance.RJControls.RJDatePicker();
            this.TxtBuscar = new RJCodeAdvance.RJControls.RJTextBox();
            this.BtnBuscar = new FontAwesome.Sharp.IconButton();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnMesa = new RJCodeAdvance.RJControls.RJButton();
            this.BtnCliente = new RJCodeAdvance.RJControls.RJButton();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.ChkCalendar = new Garmoxu_Desktop.MyCheckBox();
            this.LblFecha = new System.Windows.Forms.Label();
            this.DtgReservas = new System.Windows.Forms.DataGridView();
            this.PnlMain.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgReservas)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlMain
            // 
            this.PnlMain.ColumnCount = 1;
            this.PnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PnlMain.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.PnlMain.Controls.Add(this.DtgReservas, 0, 1);
            this.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlMain.Location = new System.Drawing.Point(0, 0);
            this.PnlMain.Margin = new System.Windows.Forms.Padding(0);
            this.PnlMain.Name = "PnlMain";
            this.PnlMain.Padding = new System.Windows.Forms.Padding(70, 50, 70, 50);
            this.PnlMain.RowCount = 2;
            this.PnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.PnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.PnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.PnlMain.Size = new System.Drawing.Size(1924, 1055);
            this.PnlMain.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 5;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.Controls.Add(this.BtnNuevo, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.BtnEliminar, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.DtpBuscar, 2, 1);
            this.tableLayoutPanel4.Controls.Add(this.TxtBuscar, 3, 1);
            this.tableLayoutPanel4.Controls.Add(this.BtnBuscar, 4, 1);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel3, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 2, 0);
            this.tableLayoutPanel4.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.ForeColor = System.Drawing.Color.White;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(70, 50);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1784, 96);
            this.tableLayoutPanel4.TabIndex = 10;
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNuevo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(54)))), ((int)(((byte)(58)))));
            this.BtnNuevo.FlatAppearance.BorderSize = 0;
            this.BtnNuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNuevo.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.BtnNuevo.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(225)))), ((int)(((byte)(70)))));
            this.BtnNuevo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnNuevo.Location = new System.Drawing.Point(0, 48);
            this.BtnNuevo.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(35, 48);
            this.BtnNuevo.TabIndex = 63;
            this.BtnNuevo.TabStop = false;
            this.BtnNuevo.UseVisualStyleBackColor = true;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            this.BtnNuevo.MouseEnter += new System.EventHandler(this.BtnNuevo_MouseEnter);
            this.BtnNuevo.MouseLeave += new System.EventHandler(this.BtnNuevo_MouseLeave);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEliminar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnEliminar.Enabled = false;
            this.BtnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(54)))), ((int)(((byte)(58)))));
            this.BtnEliminar.FlatAppearance.BorderSize = 0;
            this.BtnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.BtnEliminar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.BtnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnEliminar.Location = new System.Drawing.Point(50, 48);
            this.BtnEliminar.Margin = new System.Windows.Forms.Padding(15, 5, 0, 2);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(51, 46);
            this.BtnEliminar.TabIndex = 64;
            this.BtnEliminar.TabStop = false;
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            this.BtnEliminar.MouseEnter += new System.EventHandler(this.BtnEliminar_MouseEnter);
            this.BtnEliminar.MouseLeave += new System.EventHandler(this.BtnEliminar_MouseLeave);
            // 
            // DtpBuscar
            // 
            this.DtpBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.DtpBuscar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.DtpBuscar.BorderSize = 0;
            this.DtpBuscar.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.DtpBuscar.Font = new System.Drawing.Font("Source Sans Pro", 16.2F, System.Drawing.FontStyle.Bold);
            this.DtpBuscar.Location = new System.Drawing.Point(131, 51);
            this.DtpBuscar.Margin = new System.Windows.Forms.Padding(30, 5, 0, 0);
            this.DtpBuscar.MinimumSize = new System.Drawing.Size(4, 35);
            this.DtpBuscar.Name = "DtpBuscar";
            this.DtpBuscar.Size = new System.Drawing.Size(440, 41);
            this.DtpBuscar.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.DtpBuscar.TabIndex = 62;
            this.DtpBuscar.TabStop = false;
            this.DtpBuscar.TextColor = System.Drawing.Color.White;
            this.DtpBuscar.Value = new System.DateTime(2022, 5, 19, 0, 0, 0, 0);
            this.DtpBuscar.ValueChanged += new System.EventHandler(this.DtpBuscar_ValueChanged);
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.TxtBuscar.BorderColor = System.Drawing.Color.Transparent;
            this.TxtBuscar.BorderFocusColor = System.Drawing.Color.Gainsboro;
            this.TxtBuscar.BorderRadius = 10;
            this.TxtBuscar.BorderSize = 2;
            this.TxtBuscar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtBuscar.Font = new System.Drawing.Font("Source Sans Pro", 16.2F, System.Drawing.FontStyle.Bold);
            this.TxtBuscar.ForeColor = System.Drawing.Color.Gray;
            this.TxtBuscar.Location = new System.Drawing.Point(601, 48);
            this.TxtBuscar.Margin = new System.Windows.Forms.Padding(30, 5, 0, 0);
            this.TxtBuscar.Multiline = false;
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.TxtBuscar.PasswordChar = false;
            this.TxtBuscar.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TxtBuscar.PlaceholderText = "";
            this.TxtBuscar.Size = new System.Drawing.Size(1118, 55);
            this.TxtBuscar.TabIndex = 49;
            this.TxtBuscar.TabStop = false;
            this.TxtBuscar.Texts = "Buscar por teléfono de cliente";
            this.TxtBuscar.UnderlinedStyle = false;
            this.TxtBuscar.Enter += new System.EventHandler(this.TxtBuscar_Enter);
            this.TxtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBuscar_KeyPress);
            this.TxtBuscar.Leave += new System.EventHandler(this.TxtBuscar_Leave);
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
            this.BtnBuscar.Location = new System.Drawing.Point(1739, 48);
            this.BtnBuscar.Margin = new System.Windows.Forms.Padding(20, 5, 3, 2);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(42, 46);
            this.BtnBuscar.TabIndex = 45;
            this.BtnBuscar.TabStop = false;
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            this.BtnBuscar.MouseEnter += new System.EventHandler(this.BtnBuscar_MouseEnter);
            this.BtnBuscar.MouseLeave += new System.EventHandler(this.BtnBuscar_MouseLeave);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.BtnMesa, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.BtnCliente, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(571, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1148, 43);
            this.tableLayoutPanel3.TabIndex = 58;
            // 
            // BtnMesa
            // 
            this.BtnMesa.BackColor = System.Drawing.Color.Gray;
            this.BtnMesa.BackgroundColor = System.Drawing.Color.Gray;
            this.BtnMesa.BorderColor = System.Drawing.Color.Black;
            this.BtnMesa.BorderRadius = 15;
            this.BtnMesa.BorderSize = 0;
            this.BtnMesa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMesa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnMesa.FlatAppearance.BorderSize = 0;
            this.BtnMesa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMesa.Font = new System.Drawing.Font("Source Sans Pro", 12.2F, System.Drawing.FontStyle.Bold);
            this.BtnMesa.ForeColor = System.Drawing.Color.White;
            this.BtnMesa.Location = new System.Drawing.Point(293, 5);
            this.BtnMesa.Margin = new System.Windows.Forms.Padding(20, 5, 0, 5);
            this.BtnMesa.Name = "BtnMesa";
            this.BtnMesa.Size = new System.Drawing.Size(95, 33);
            this.BtnMesa.TabIndex = 65;
            this.BtnMesa.TabStop = false;
            this.BtnMesa.Text = "Mesa";
            this.BtnMesa.TextColor = System.Drawing.Color.White;
            this.BtnMesa.UseVisualStyleBackColor = false;
            this.BtnMesa.Click += new System.EventHandler(this.BtnMesa_Click);
            // 
            // BtnCliente
            // 
            this.BtnCliente.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnCliente.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnCliente.BorderColor = System.Drawing.Color.Black;
            this.BtnCliente.BorderRadius = 15;
            this.BtnCliente.BorderSize = 0;
            this.BtnCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnCliente.FlatAppearance.BorderSize = 0;
            this.BtnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCliente.Font = new System.Drawing.Font("Source Sans Pro", 12.2F, System.Drawing.FontStyle.Bold);
            this.BtnCliente.ForeColor = System.Drawing.Color.White;
            this.BtnCliente.Location = new System.Drawing.Point(178, 5);
            this.BtnCliente.Margin = new System.Windows.Forms.Padding(10, 5, 0, 5);
            this.BtnCliente.Name = "BtnCliente";
            this.BtnCliente.Size = new System.Drawing.Size(95, 33);
            this.BtnCliente.TabIndex = 64;
            this.BtnCliente.TabStop = false;
            this.BtnCliente.Text = "Cliente";
            this.BtnCliente.TextColor = System.Drawing.Color.White;
            this.BtnCliente.UseVisualStyleBackColor = false;
            this.BtnCliente.Click += new System.EventHandler(this.BtnCliente_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Source Sans Pro", 15.2F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(27, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(27, 0, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 43);
            this.label1.TabIndex = 63;
            this.label1.Text = "Buscar por";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.ChkCalendar, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.LblFecha, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(101, 0);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(470, 43);
            this.tableLayoutPanel5.TabIndex = 61;
            // 
            // ChkCalendar
            // 
            this.ChkCalendar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ChkCalendar.BackColor = System.Drawing.Color.Transparent;
            this.ChkCalendar.Background = System.Drawing.Color.Transparent;
            this.ChkCalendar.BorderColor = System.Drawing.Color.Silver;
            this.ChkCalendar.BorderHeight = 15;
            this.ChkCalendar.BorderWidth = 15;
            this.ChkCalendar.Checked = false;
            this.ChkCalendar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChkCalendar.EnterColor = System.Drawing.Color.White;
            this.ChkCalendar.Font = new System.Drawing.Font("Source Sans Pro Black", 14F, System.Drawing.FontStyle.Bold);
            this.ChkCalendar.ForeColor = System.Drawing.Color.Silver;
            this.ChkCalendar.LeaveColor = System.Drawing.Color.Silver;
            this.ChkCalendar.Location = new System.Drawing.Point(239, 7);
            this.ChkCalendar.Name = "ChkCalendar";
            this.ChkCalendar.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.ChkCalendar.PaddingCheck = new System.Windows.Forms.Padding(0);
            this.ChkCalendar.Size = new System.Drawing.Size(35, 28);
            this.ChkCalendar.TabIndex = 59;
            this.ChkCalendar.TabStop = false;
            this.ChkCalendar.Text = "myCheckBox2";
            this.ChkCalendar.MouseEnter += new System.EventHandler(this.ChkCalendar_MouseEnter);
            this.ChkCalendar.MouseLeave += new System.EventHandler(this.ChkCalendar_MouseLeave);
            // 
            // LblFecha
            // 
            this.LblFecha.AutoSize = true;
            this.LblFecha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblFecha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblFecha.Font = new System.Drawing.Font("Source Sans Pro", 15.2F, System.Drawing.FontStyle.Bold);
            this.LblFecha.ForeColor = System.Drawing.Color.Silver;
            this.LblFecha.Location = new System.Drawing.Point(27, 0);
            this.LblFecha.Margin = new System.Windows.Forms.Padding(27, 0, 3, 0);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(206, 43);
            this.LblFecha.TabIndex = 60;
            this.LblFecha.Text = "Fecha de reserva";
            this.LblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblFecha.Click += new System.EventHandler(this.LblFecha_Click);
            this.LblFecha.MouseEnter += new System.EventHandler(this.ChkCalendar_MouseEnter);
            this.LblFecha.MouseLeave += new System.EventHandler(this.ChkCalendar_MouseLeave);
            // 
            // DtgReservas
            // 
            this.DtgReservas.AllowUserToAddRows = false;
            this.DtgReservas.AllowUserToDeleteRows = false;
            this.DtgReservas.AllowUserToOrderColumns = true;
            this.DtgReservas.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Source Sans Pro", 15F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(190)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.DtgReservas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DtgReservas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtgReservas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DtgReservas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.DtgReservas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DtgReservas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DtgReservas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Source Sans Pro", 15F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DtgReservas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DtgReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Source Sans Pro", 15F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(190)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DtgReservas.DefaultCellStyle = dataGridViewCellStyle3;
            this.DtgReservas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DtgReservas.EnableHeadersVisualStyles = false;
            this.DtgReservas.GridColor = System.Drawing.Color.MediumSlateBlue;
            this.DtgReservas.Location = new System.Drawing.Point(70, 166);
            this.DtgReservas.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.DtgReservas.MultiSelect = false;
            this.DtgReservas.Name = "DtgReservas";
            this.DtgReservas.ReadOnly = true;
            this.DtgReservas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DtgReservas.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DtgReservas.RowHeadersVisible = false;
            this.DtgReservas.RowHeadersWidth = 51;
            this.DtgReservas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DtgReservas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DtgReservas.Size = new System.Drawing.Size(1784, 839);
            this.DtgReservas.TabIndex = 9;
            this.DtgReservas.TabStop = false;
            this.DtgReservas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgReservas_CellDoubleClick);
            this.DtgReservas.SelectionChanged += new System.EventHandler(this.DtgReservas_SelectionChanged);
            // 
            // FrmReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(54)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.PnlMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmReservas";
            this.Tag = "Reservas";
            this.Text = "Gestión de reservas - Garmoxu";
            this.Shown += new System.EventHandler(this.FrmReservas_Shown);
            this.PnlMain.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgReservas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel PnlMain;
        private System.Windows.Forms.DataGridView DtgReservas;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private RJCodeAdvance.RJControls.RJDatePicker DtpBuscar;
        private FontAwesome.Sharp.IconButton BtnBuscar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private MyCheckBox ChkCalendar;
        private System.Windows.Forms.Label LblFecha;
        private FontAwesome.Sharp.IconButton BtnNuevo;
        private FontAwesome.Sharp.IconButton BtnEliminar;
        private RJCodeAdvance.RJControls.RJTextBox TxtBuscar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private RJCodeAdvance.RJControls.RJButton BtnMesa;
        private RJCodeAdvance.RJControls.RJButton BtnCliente;
        private System.Windows.Forms.Label label1;
    }
}