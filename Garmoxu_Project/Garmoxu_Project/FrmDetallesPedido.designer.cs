namespace Garmoxu_Project
{
    partial class FrmDetallesPedido
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
            this.TabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.TabCliente = new System.Windows.Forms.TabPage();
            this.PnlMainCliente = new System.Windows.Forms.TableLayoutPanel();
            this.PnlTipos = new System.Windows.Forms.TableLayoutPanel();
            this.BtnLocal = new RJCodeAdvance.RJControls.RJButton();
            this.BtnDomicilio = new RJCodeAdvance.RJControls.RJButton();
            this.BtnRecoger = new RJCodeAdvance.RJControls.RJButton();
            this.BtnNext = new RJCodeAdvance.RJControls.RJButton();
            this.TabTipo = new MaterialSkin.Controls.MaterialTabControl();
            this.TabLocal = new System.Windows.Forms.TabPage();
            this.TxtComensales = new RJCodeAdvance.RJControls.RJTextBox();
            this.TxtMesa = new RJCodeAdvance.RJControls.RJTextBox();
            this.TabDomicilio = new System.Windows.Forms.TabPage();
            this.TxtNombre = new RJCodeAdvance.RJControls.RJTextBox();
            this.TxtDir = new RJCodeAdvance.RJControls.RJTextBox();
            this.TxtTlf = new RJCodeAdvance.RJControls.RJTextBox();
            this.TabRecoger = new System.Windows.Forms.TabPage();
            this.TxtNombreRecoger = new RJCodeAdvance.RJControls.RJTextBox();
            this.TxtTlfRecoger = new RJCodeAdvance.RJControls.RJTextBox();
            this.TabDetalles = new System.Windows.Forms.TabPage();
            this.PnlMain = new System.Windows.Forms.TableLayoutPanel();
            this.BtnConfirmar = new RJCodeAdvance.RJControls.RJButton();
            this.PnlCliente = new System.Windows.Forms.Panel();
            this.PnlHeader = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.TabtTipoCambio = new MaterialSkin.Controls.MaterialTabControl();
            this.TabLocalCambiar = new System.Windows.Forms.TabPage();
            this.TabDomicilioCambiar = new System.Windows.Forms.TabPage();
            this.LblFecha = new MaterialSkin.Controls.MaterialLabel();
            this.LblHora = new MaterialSkin.Controls.MaterialLabel();
            this.CboEstado = new RJCodeAdvance.RJControls.RJComboBox();
            this.CboTipo = new RJCodeAdvance.RJControls.RJComboBox();
            this.TabRecogerCambiar = new System.Windows.Forms.TabPage();
            this.rjTextBox1 = new RJCodeAdvance.RJControls.RJTextBox();
            this.rjTextBox2 = new RJCodeAdvance.RJControls.RJTextBox();
            this.rjTextBox3 = new RJCodeAdvance.RJControls.RJTextBox();
            this.rjTextBox4 = new RJCodeAdvance.RJControls.RJTextBox();
            this.rjTextBox5 = new RJCodeAdvance.RJControls.RJTextBox();
            this.rjTextBox6 = new RJCodeAdvance.RJControls.RJTextBox();
            this.rjTextBox7 = new RJCodeAdvance.RJControls.RJTextBox();
            this.PnlPedidos = new System.Windows.Forms.TableLayoutPanel();
            this.DtgReservas = new System.Windows.Forms.DataGridView();
            this.ClnCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnPrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnPrecioFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PnlAdd = new System.Windows.Forms.Panel();
            this.TxtCode = new System.Windows.Forms.TextBox();
            this.NucCantidad = new System.Windows.Forms.NumericUpDown();
            this.TabControl.SuspendLayout();
            this.TabCliente.SuspendLayout();
            this.PnlMainCliente.SuspendLayout();
            this.PnlTipos.SuspendLayout();
            this.TabTipo.SuspendLayout();
            this.TabLocal.SuspendLayout();
            this.TabDomicilio.SuspendLayout();
            this.TabRecoger.SuspendLayout();
            this.TabDetalles.SuspendLayout();
            this.PnlMain.SuspendLayout();
            this.PnlCliente.SuspendLayout();
            this.PnlHeader.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.TabtTipoCambio.SuspendLayout();
            this.TabLocalCambiar.SuspendLayout();
            this.TabDomicilioCambiar.SuspendLayout();
            this.TabRecogerCambiar.SuspendLayout();
            this.PnlPedidos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgReservas)).BeginInit();
            this.PnlAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NucCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.TabCliente);
            this.TabControl.Controls.Add(this.TabDetalles);
            this.TabControl.Depth = 0;
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(1020, 560);
            this.TabControl.TabIndex = 0;
            // 
            // TabCliente
            // 
            this.TabCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(54)))), ((int)(((byte)(58)))));
            this.TabCliente.Controls.Add(this.PnlMainCliente);
            this.TabCliente.Location = new System.Drawing.Point(4, 22);
            this.TabCliente.Name = "TabCliente";
            this.TabCliente.Padding = new System.Windows.Forms.Padding(3);
            this.TabCliente.Size = new System.Drawing.Size(987, 618);
            this.TabCliente.TabIndex = 0;
            this.TabCliente.Text = "Cliente";
            // 
            // PnlMainCliente
            // 
            this.PnlMainCliente.ColumnCount = 1;
            this.PnlMainCliente.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PnlMainCliente.Controls.Add(this.PnlTipos, 0, 0);
            this.PnlMainCliente.Controls.Add(this.BtnNext, 0, 2);
            this.PnlMainCliente.Controls.Add(this.TabTipo, 0, 1);
            this.PnlMainCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlMainCliente.Location = new System.Drawing.Point(3, 3);
            this.PnlMainCliente.Name = "PnlMainCliente";
            this.PnlMainCliente.RowCount = 3;
            this.PnlMainCliente.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.PnlMainCliente.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.PnlMainCliente.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.PnlMainCliente.Size = new System.Drawing.Size(981, 612);
            this.PnlMainCliente.TabIndex = 1;
            // 
            // PnlTipos
            // 
            this.PnlTipos.ColumnCount = 3;
            this.PnlTipos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.PnlTipos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.PnlTipos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.PnlTipos.Controls.Add(this.BtnLocal, 0, 0);
            this.PnlTipos.Controls.Add(this.BtnDomicilio, 1, 0);
            this.PnlTipos.Controls.Add(this.BtnRecoger, 2, 0);
            this.PnlTipos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlTipos.Location = new System.Drawing.Point(3, 3);
            this.PnlTipos.Name = "PnlTipos";
            this.PnlTipos.RowCount = 1;
            this.PnlTipos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PnlTipos.Size = new System.Drawing.Size(975, 85);
            this.PnlTipos.TabIndex = 0;
            // 
            // BtnLocal
            // 
            this.BtnLocal.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnLocal.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnLocal.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnLocal.BorderRadius = 0;
            this.BtnLocal.BorderSize = 0;
            this.BtnLocal.FlatAppearance.BorderSize = 0;
            this.BtnLocal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLocal.ForeColor = System.Drawing.Color.White;
            this.BtnLocal.Location = new System.Drawing.Point(3, 3);
            this.BtnLocal.Name = "BtnLocal";
            this.BtnLocal.Size = new System.Drawing.Size(150, 40);
            this.BtnLocal.TabIndex = 0;
            this.BtnLocal.Text = "Local";
            this.BtnLocal.TextColor = System.Drawing.Color.White;
            this.BtnLocal.UseVisualStyleBackColor = false;
            this.BtnLocal.Click += new System.EventHandler(this.BtnLocal_Click);
            // 
            // BtnDomicilio
            // 
            this.BtnDomicilio.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnDomicilio.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnDomicilio.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnDomicilio.BorderRadius = 0;
            this.BtnDomicilio.BorderSize = 0;
            this.BtnDomicilio.FlatAppearance.BorderSize = 0;
            this.BtnDomicilio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDomicilio.ForeColor = System.Drawing.Color.White;
            this.BtnDomicilio.Location = new System.Drawing.Point(783, 3);
            this.BtnDomicilio.Name = "BtnDomicilio";
            this.BtnDomicilio.Size = new System.Drawing.Size(72, 40);
            this.BtnDomicilio.TabIndex = 1;
            this.BtnDomicilio.Text = "Domicilio";
            this.BtnDomicilio.TextColor = System.Drawing.Color.White;
            this.BtnDomicilio.UseVisualStyleBackColor = false;
            this.BtnDomicilio.Click += new System.EventHandler(this.BtnDomicilio_Click);
            // 
            // BtnRecoger
            // 
            this.BtnRecoger.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnRecoger.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnRecoger.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnRecoger.BorderRadius = 0;
            this.BtnRecoger.BorderSize = 0;
            this.BtnRecoger.FlatAppearance.BorderSize = 0;
            this.BtnRecoger.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRecoger.ForeColor = System.Drawing.Color.White;
            this.BtnRecoger.Location = new System.Drawing.Point(880, 3);
            this.BtnRecoger.Name = "BtnRecoger";
            this.BtnRecoger.Size = new System.Drawing.Size(72, 40);
            this.BtnRecoger.TabIndex = 2;
            this.BtnRecoger.Text = "Recoger";
            this.BtnRecoger.TextColor = System.Drawing.Color.White;
            this.BtnRecoger.UseVisualStyleBackColor = false;
            this.BtnRecoger.Click += new System.EventHandler(this.BtnRecoger_Click);
            // 
            // BtnNext
            // 
            this.BtnNext.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnNext.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnNext.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnNext.BorderRadius = 0;
            this.BtnNext.BorderSize = 0;
            this.BtnNext.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnNext.FlatAppearance.BorderSize = 0;
            this.BtnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNext.ForeColor = System.Drawing.Color.White;
            this.BtnNext.Location = new System.Drawing.Point(828, 583);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(150, 26);
            this.BtnNext.TabIndex = 2;
            this.BtnNext.Text = "Siguiente";
            this.BtnNext.TextColor = System.Drawing.Color.White;
            this.BtnNext.UseVisualStyleBackColor = false;
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // TabTipo
            // 
            this.TabTipo.Controls.Add(this.TabLocal);
            this.TabTipo.Controls.Add(this.TabDomicilio);
            this.TabTipo.Controls.Add(this.TabRecoger);
            this.TabTipo.Depth = 0;
            this.TabTipo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabTipo.Location = new System.Drawing.Point(3, 94);
            this.TabTipo.MouseState = MaterialSkin.MouseState.HOVER;
            this.TabTipo.Name = "TabTipo";
            this.TabTipo.SelectedIndex = 0;
            this.TabTipo.Size = new System.Drawing.Size(975, 483);
            this.TabTipo.TabIndex = 3;
            // 
            // TabLocal
            // 
            this.TabLocal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(54)))), ((int)(((byte)(58)))));
            this.TabLocal.Controls.Add(this.TxtComensales);
            this.TabLocal.Controls.Add(this.TxtMesa);
            this.TabLocal.Location = new System.Drawing.Point(4, 22);
            this.TabLocal.Name = "TabLocal";
            this.TabLocal.Padding = new System.Windows.Forms.Padding(3);
            this.TabLocal.Size = new System.Drawing.Size(967, 457);
            this.TabLocal.TabIndex = 0;
            this.TabLocal.Text = "Local";
            // 
            // TxtComensales
            // 
            this.TxtComensales.BackColor = System.Drawing.SystemColors.Window;
            this.TxtComensales.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.TxtComensales.BorderFocusColor = System.Drawing.Color.HotPink;
            this.TxtComensales.BorderRadius = 0;
            this.TxtComensales.BorderSize = 2;
            this.TxtComensales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtComensales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtComensales.Location = new System.Drawing.Point(78, 222);
            this.TxtComensales.Margin = new System.Windows.Forms.Padding(4);
            this.TxtComensales.Multiline = false;
            this.TxtComensales.Name = "TxtComensales";
            this.TxtComensales.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.TxtComensales.PasswordChar = false;
            this.TxtComensales.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TxtComensales.PlaceholderText = "";
            this.TxtComensales.Size = new System.Drawing.Size(250, 31);
            this.TxtComensales.TabIndex = 9;
            this.TxtComensales.Texts = "Comensales(Opcional)";
            this.TxtComensales.UnderlinedStyle = false;
            // 
            // TxtMesa
            // 
            this.TxtMesa.BackColor = System.Drawing.SystemColors.Window;
            this.TxtMesa.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.TxtMesa.BorderFocusColor = System.Drawing.Color.HotPink;
            this.TxtMesa.BorderRadius = 0;
            this.TxtMesa.BorderSize = 2;
            this.TxtMesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMesa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtMesa.Location = new System.Drawing.Point(78, 162);
            this.TxtMesa.Margin = new System.Windows.Forms.Padding(4);
            this.TxtMesa.Multiline = false;
            this.TxtMesa.Name = "TxtMesa";
            this.TxtMesa.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.TxtMesa.PasswordChar = false;
            this.TxtMesa.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TxtMesa.PlaceholderText = "";
            this.TxtMesa.Size = new System.Drawing.Size(250, 31);
            this.TxtMesa.TabIndex = 8;
            this.TxtMesa.Texts = "Mesa(Obligatorio)";
            this.TxtMesa.UnderlinedStyle = false;
            // 
            // TabDomicilio
            // 
            this.TabDomicilio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(54)))), ((int)(((byte)(58)))));
            this.TabDomicilio.Controls.Add(this.TxtNombre);
            this.TabDomicilio.Controls.Add(this.TxtDir);
            this.TabDomicilio.Controls.Add(this.TxtTlf);
            this.TabDomicilio.Location = new System.Drawing.Point(4, 22);
            this.TabDomicilio.Name = "TabDomicilio";
            this.TabDomicilio.Padding = new System.Windows.Forms.Padding(3);
            this.TabDomicilio.Size = new System.Drawing.Size(967, 457);
            this.TabDomicilio.TabIndex = 1;
            this.TabDomicilio.Text = "Domicilio";
            // 
            // TxtNombre
            // 
            this.TxtNombre.BackColor = System.Drawing.SystemColors.Window;
            this.TxtNombre.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.TxtNombre.BorderFocusColor = System.Drawing.Color.HotPink;
            this.TxtNombre.BorderRadius = 0;
            this.TxtNombre.BorderSize = 2;
            this.TxtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtNombre.Location = new System.Drawing.Point(73, 196);
            this.TxtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.TxtNombre.Multiline = false;
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.TxtNombre.PasswordChar = false;
            this.TxtNombre.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TxtNombre.PlaceholderText = "";
            this.TxtNombre.Size = new System.Drawing.Size(250, 31);
            this.TxtNombre.TabIndex = 15;
            this.TxtNombre.Texts = "Nombre(Opcional)";
            this.TxtNombre.UnderlinedStyle = false;
            // 
            // TxtDir
            // 
            this.TxtDir.BackColor = System.Drawing.SystemColors.Window;
            this.TxtDir.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.TxtDir.BorderFocusColor = System.Drawing.Color.HotPink;
            this.TxtDir.BorderRadius = 0;
            this.TxtDir.BorderSize = 2;
            this.TxtDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtDir.Location = new System.Drawing.Point(73, 146);
            this.TxtDir.Margin = new System.Windows.Forms.Padding(4);
            this.TxtDir.Multiline = false;
            this.TxtDir.Name = "TxtDir";
            this.TxtDir.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.TxtDir.PasswordChar = false;
            this.TxtDir.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TxtDir.PlaceholderText = "";
            this.TxtDir.Size = new System.Drawing.Size(250, 31);
            this.TxtDir.TabIndex = 14;
            this.TxtDir.Texts = "Direccion(Obligatorio)";
            this.TxtDir.UnderlinedStyle = false;
            // 
            // TxtTlf
            // 
            this.TxtTlf.BackColor = System.Drawing.SystemColors.Window;
            this.TxtTlf.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.TxtTlf.BorderFocusColor = System.Drawing.Color.HotPink;
            this.TxtTlf.BorderRadius = 0;
            this.TxtTlf.BorderSize = 2;
            this.TxtTlf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTlf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtTlf.Location = new System.Drawing.Point(73, 94);
            this.TxtTlf.Margin = new System.Windows.Forms.Padding(4);
            this.TxtTlf.Multiline = false;
            this.TxtTlf.Name = "TxtTlf";
            this.TxtTlf.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.TxtTlf.PasswordChar = false;
            this.TxtTlf.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TxtTlf.PlaceholderText = "";
            this.TxtTlf.Size = new System.Drawing.Size(250, 31);
            this.TxtTlf.TabIndex = 13;
            this.TxtTlf.Texts = "Telefono(Obligatorio)";
            this.TxtTlf.UnderlinedStyle = false;
            // 
            // TabRecoger
            // 
            this.TabRecoger.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(54)))), ((int)(((byte)(58)))));
            this.TabRecoger.Controls.Add(this.TxtNombreRecoger);
            this.TabRecoger.Controls.Add(this.TxtTlfRecoger);
            this.TabRecoger.Location = new System.Drawing.Point(4, 22);
            this.TabRecoger.Name = "TabRecoger";
            this.TabRecoger.Size = new System.Drawing.Size(967, 457);
            this.TabRecoger.TabIndex = 2;
            this.TabRecoger.Text = "Recoger";
            // 
            // TxtNombreRecoger
            // 
            this.TxtNombreRecoger.BackColor = System.Drawing.SystemColors.Window;
            this.TxtNombreRecoger.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.TxtNombreRecoger.BorderFocusColor = System.Drawing.Color.HotPink;
            this.TxtNombreRecoger.BorderRadius = 0;
            this.TxtNombreRecoger.BorderSize = 2;
            this.TxtNombreRecoger.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombreRecoger.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtNombreRecoger.Location = new System.Drawing.Point(88, 163);
            this.TxtNombreRecoger.Margin = new System.Windows.Forms.Padding(4);
            this.TxtNombreRecoger.Multiline = false;
            this.TxtNombreRecoger.Name = "TxtNombreRecoger";
            this.TxtNombreRecoger.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.TxtNombreRecoger.PasswordChar = false;
            this.TxtNombreRecoger.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TxtNombreRecoger.PlaceholderText = "";
            this.TxtNombreRecoger.Size = new System.Drawing.Size(250, 31);
            this.TxtNombreRecoger.TabIndex = 16;
            this.TxtNombreRecoger.Texts = "Nombre(Obligatorio)";
            this.TxtNombreRecoger.UnderlinedStyle = false;
            // 
            // TxtTlfRecoger
            // 
            this.TxtTlfRecoger.BackColor = System.Drawing.SystemColors.Window;
            this.TxtTlfRecoger.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.TxtTlfRecoger.BorderFocusColor = System.Drawing.Color.HotPink;
            this.TxtTlfRecoger.BorderRadius = 0;
            this.TxtTlfRecoger.BorderSize = 2;
            this.TxtTlfRecoger.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTlfRecoger.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtTlfRecoger.Location = new System.Drawing.Point(88, 112);
            this.TxtTlfRecoger.Margin = new System.Windows.Forms.Padding(4);
            this.TxtTlfRecoger.Multiline = false;
            this.TxtTlfRecoger.Name = "TxtTlfRecoger";
            this.TxtTlfRecoger.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.TxtTlfRecoger.PasswordChar = false;
            this.TxtTlfRecoger.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TxtTlfRecoger.PlaceholderText = "";
            this.TxtTlfRecoger.Size = new System.Drawing.Size(250, 31);
            this.TxtTlfRecoger.TabIndex = 15;
            this.TxtTlfRecoger.Texts = "Telefono(Obligatorio)";
            this.TxtTlfRecoger.UnderlinedStyle = false;
            // 
            // TabDetalles
            // 
            this.TabDetalles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(54)))), ((int)(((byte)(58)))));
            this.TabDetalles.Controls.Add(this.PnlMain);
            this.TabDetalles.Location = new System.Drawing.Point(4, 22);
            this.TabDetalles.Name = "TabDetalles";
            this.TabDetalles.Padding = new System.Windows.Forms.Padding(3);
            this.TabDetalles.Size = new System.Drawing.Size(1012, 534);
            this.TabDetalles.TabIndex = 1;
            this.TabDetalles.Text = "Detalles";
            // 
            // PnlMain
            // 
            this.PnlMain.ColumnCount = 1;
            this.PnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PnlMain.Controls.Add(this.BtnConfirmar, 0, 2);
            this.PnlMain.Controls.Add(this.PnlCliente, 0, 0);
            this.PnlMain.Controls.Add(this.PnlPedidos, 0, 1);
            this.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlMain.Location = new System.Drawing.Point(3, 3);
            this.PnlMain.Name = "PnlMain";
            this.PnlMain.RowCount = 3;
            this.PnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.PnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.PnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.PnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.PnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.PnlMain.Size = new System.Drawing.Size(1006, 528);
            this.PnlMain.TabIndex = 1;
            // 
            // BtnConfirmar
            // 
            this.BtnConfirmar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnConfirmar.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnConfirmar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnConfirmar.BorderRadius = 0;
            this.BtnConfirmar.BorderSize = 0;
            this.BtnConfirmar.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnConfirmar.FlatAppearance.BorderSize = 0;
            this.BtnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConfirmar.ForeColor = System.Drawing.Color.White;
            this.BtnConfirmar.Location = new System.Drawing.Point(853, 504);
            this.BtnConfirmar.Name = "BtnConfirmar";
            this.BtnConfirmar.Size = new System.Drawing.Size(150, 21);
            this.BtnConfirmar.TabIndex = 3;
            this.BtnConfirmar.Text = "Confirmar";
            this.BtnConfirmar.TextColor = System.Drawing.Color.White;
            this.BtnConfirmar.UseVisualStyleBackColor = false;
            this.BtnConfirmar.Click += new System.EventHandler(this.BtnConfirmar_Click);
            // 
            // PnlCliente
            // 
            this.PnlCliente.Controls.Add(this.PnlHeader);
            this.PnlCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlCliente.Location = new System.Drawing.Point(3, 3);
            this.PnlCliente.Name = "PnlCliente";
            this.PnlCliente.Size = new System.Drawing.Size(1000, 99);
            this.PnlCliente.TabIndex = 0;
            // 
            // PnlHeader
            // 
            this.PnlHeader.ColumnCount = 1;
            this.PnlHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PnlHeader.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.PnlHeader.Controls.Add(this.TabtTipoCambio, 0, 1);
            this.PnlHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlHeader.Location = new System.Drawing.Point(0, 0);
            this.PnlHeader.Name = "PnlHeader";
            this.PnlHeader.RowCount = 2;
            this.PnlHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PnlHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PnlHeader.Size = new System.Drawing.Size(1000, 99);
            this.PnlHeader.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.Controls.Add(this.LblFecha, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.LblHora, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.CboEstado, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.CboTipo, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(994, 43);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // TabtTipoCambio
            // 
            this.TabtTipoCambio.Controls.Add(this.TabLocalCambiar);
            this.TabtTipoCambio.Controls.Add(this.TabDomicilioCambiar);
            this.TabtTipoCambio.Controls.Add(this.TabRecogerCambiar);
            this.TabtTipoCambio.Depth = 0;
            this.TabtTipoCambio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabtTipoCambio.Location = new System.Drawing.Point(3, 52);
            this.TabtTipoCambio.MouseState = MaterialSkin.MouseState.HOVER;
            this.TabtTipoCambio.Name = "TabtTipoCambio";
            this.TabtTipoCambio.SelectedIndex = 0;
            this.TabtTipoCambio.Size = new System.Drawing.Size(994, 44);
            this.TabtTipoCambio.TabIndex = 1;
            // 
            // TabLocalCambiar
            // 
            this.TabLocalCambiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(54)))), ((int)(((byte)(58)))));
            this.TabLocalCambiar.Controls.Add(this.rjTextBox2);
            this.TabLocalCambiar.Controls.Add(this.rjTextBox1);
            this.TabLocalCambiar.Location = new System.Drawing.Point(4, 22);
            this.TabLocalCambiar.Name = "TabLocalCambiar";
            this.TabLocalCambiar.Padding = new System.Windows.Forms.Padding(3);
            this.TabLocalCambiar.Size = new System.Drawing.Size(986, 18);
            this.TabLocalCambiar.TabIndex = 0;
            this.TabLocalCambiar.Text = "Local";
            // 
            // TabDomicilioCambiar
            // 
            this.TabDomicilioCambiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(54)))), ((int)(((byte)(58)))));
            this.TabDomicilioCambiar.Controls.Add(this.rjTextBox5);
            this.TabDomicilioCambiar.Controls.Add(this.rjTextBox4);
            this.TabDomicilioCambiar.Controls.Add(this.rjTextBox3);
            this.TabDomicilioCambiar.Location = new System.Drawing.Point(4, 22);
            this.TabDomicilioCambiar.Name = "TabDomicilioCambiar";
            this.TabDomicilioCambiar.Padding = new System.Windows.Forms.Padding(3);
            this.TabDomicilioCambiar.Size = new System.Drawing.Size(961, 26);
            this.TabDomicilioCambiar.TabIndex = 1;
            this.TabDomicilioCambiar.Text = "Domicilio";
            // 
            // LblFecha
            // 
            this.LblFecha.AutoSize = true;
            this.LblFecha.Depth = 0;
            this.LblFecha.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblFecha.Location = new System.Drawing.Point(350, 0);
            this.LblFecha.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(57, 19);
            this.LblFecha.TabIndex = 1;
            this.LblFecha.Text = "Fecha: ";
            // 
            // LblHora
            // 
            this.LblHora.AutoSize = true;
            this.LblHora.Depth = 0;
            this.LblHora.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblHora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblHora.Location = new System.Drawing.Point(548, 0);
            this.LblHora.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblHora.Name = "LblHora";
            this.LblHora.Size = new System.Drawing.Size(50, 19);
            this.LblHora.TabIndex = 2;
            this.LblHora.Text = "Hora: ";
            // 
            // CboEstado
            // 
            this.CboEstado.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CboEstado.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.CboEstado.BorderSize = 1;
            this.CboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.CboEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CboEstado.ForeColor = System.Drawing.Color.DimGray;
            this.CboEstado.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.CboEstado.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.CboEstado.ListTextColor = System.Drawing.Color.DimGray;
            this.CboEstado.Location = new System.Drawing.Point(647, 3);
            this.CboEstado.MinimumSize = new System.Drawing.Size(200, 30);
            this.CboEstado.Name = "CboEstado";
            this.CboEstado.Padding = new System.Windows.Forms.Padding(1);
            this.CboEstado.Size = new System.Drawing.Size(200, 30);
            this.CboEstado.TabIndex = 3;
            this.CboEstado.Texts = "";
            // 
            // CboTipo
            // 
            this.CboTipo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CboTipo.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.CboTipo.BorderSize = 1;
            this.CboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.CboTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CboTipo.ForeColor = System.Drawing.Color.DimGray;
            this.CboTipo.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.CboTipo.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.CboTipo.ListTextColor = System.Drawing.Color.DimGray;
            this.CboTipo.Location = new System.Drawing.Point(3, 3);
            this.CboTipo.MinimumSize = new System.Drawing.Size(200, 30);
            this.CboTipo.Name = "CboTipo";
            this.CboTipo.Padding = new System.Windows.Forms.Padding(1);
            this.CboTipo.Size = new System.Drawing.Size(200, 30);
            this.CboTipo.TabIndex = 4;
            this.CboTipo.Texts = "";
            // 
            // TabRecogerCambiar
            // 
            this.TabRecogerCambiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(54)))), ((int)(((byte)(58)))));
            this.TabRecogerCambiar.Controls.Add(this.rjTextBox7);
            this.TabRecogerCambiar.Controls.Add(this.rjTextBox6);
            this.TabRecogerCambiar.Location = new System.Drawing.Point(4, 22);
            this.TabRecogerCambiar.Name = "TabRecogerCambiar";
            this.TabRecogerCambiar.Padding = new System.Windows.Forms.Padding(3);
            this.TabRecogerCambiar.Size = new System.Drawing.Size(961, 26);
            this.TabRecogerCambiar.TabIndex = 2;
            this.TabRecogerCambiar.Text = "Recoger";
            // 
            // rjTextBox1
            // 
            this.rjTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.rjTextBox1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjTextBox1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjTextBox1.BorderRadius = 0;
            this.rjTextBox1.BorderSize = 2;
            this.rjTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjTextBox1.Location = new System.Drawing.Point(0, 2);
            this.rjTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBox1.Multiline = false;
            this.rjTextBox1.Name = "rjTextBox1";
            this.rjTextBox1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBox1.PasswordChar = false;
            this.rjTextBox1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBox1.PlaceholderText = "";
            this.rjTextBox1.Size = new System.Drawing.Size(250, 31);
            this.rjTextBox1.TabIndex = 9;
            this.rjTextBox1.Texts = "Mesa(Obligatorio)";
            this.rjTextBox1.UnderlinedStyle = false;
            // 
            // rjTextBox2
            // 
            this.rjTextBox2.BackColor = System.Drawing.SystemColors.Window;
            this.rjTextBox2.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjTextBox2.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjTextBox2.BorderRadius = 0;
            this.rjTextBox2.BorderSize = 2;
            this.rjTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjTextBox2.Location = new System.Drawing.Point(277, 4);
            this.rjTextBox2.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBox2.Multiline = false;
            this.rjTextBox2.Name = "rjTextBox2";
            this.rjTextBox2.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBox2.PasswordChar = false;
            this.rjTextBox2.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBox2.PlaceholderText = "";
            this.rjTextBox2.Size = new System.Drawing.Size(250, 31);
            this.rjTextBox2.TabIndex = 10;
            this.rjTextBox2.Texts = "Comensales(Opcional)";
            this.rjTextBox2.UnderlinedStyle = false;
            // 
            // rjTextBox3
            // 
            this.rjTextBox3.BackColor = System.Drawing.SystemColors.Window;
            this.rjTextBox3.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjTextBox3.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjTextBox3.BorderRadius = 0;
            this.rjTextBox3.BorderSize = 2;
            this.rjTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjTextBox3.Location = new System.Drawing.Point(4, 1);
            this.rjTextBox3.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBox3.Multiline = false;
            this.rjTextBox3.Name = "rjTextBox3";
            this.rjTextBox3.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBox3.PasswordChar = false;
            this.rjTextBox3.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBox3.PlaceholderText = "";
            this.rjTextBox3.Size = new System.Drawing.Size(250, 31);
            this.rjTextBox3.TabIndex = 14;
            this.rjTextBox3.Texts = "Telefono(Obligatorio)";
            this.rjTextBox3.UnderlinedStyle = false;
            // 
            // rjTextBox4
            // 
            this.rjTextBox4.BackColor = System.Drawing.SystemColors.Window;
            this.rjTextBox4.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjTextBox4.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjTextBox4.BorderRadius = 0;
            this.rjTextBox4.BorderSize = 2;
            this.rjTextBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjTextBox4.Location = new System.Drawing.Point(262, 1);
            this.rjTextBox4.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBox4.Multiline = false;
            this.rjTextBox4.Name = "rjTextBox4";
            this.rjTextBox4.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBox4.PasswordChar = false;
            this.rjTextBox4.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBox4.PlaceholderText = "";
            this.rjTextBox4.Size = new System.Drawing.Size(250, 31);
            this.rjTextBox4.TabIndex = 15;
            this.rjTextBox4.Texts = "Direccion(Obligatorio)";
            this.rjTextBox4.UnderlinedStyle = false;
            // 
            // rjTextBox5
            // 
            this.rjTextBox5.BackColor = System.Drawing.SystemColors.Window;
            this.rjTextBox5.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjTextBox5.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjTextBox5.BorderRadius = 0;
            this.rjTextBox5.BorderSize = 2;
            this.rjTextBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjTextBox5.Location = new System.Drawing.Point(520, 1);
            this.rjTextBox5.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBox5.Multiline = false;
            this.rjTextBox5.Name = "rjTextBox5";
            this.rjTextBox5.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBox5.PasswordChar = false;
            this.rjTextBox5.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBox5.PlaceholderText = "";
            this.rjTextBox5.Size = new System.Drawing.Size(250, 31);
            this.rjTextBox5.TabIndex = 16;
            this.rjTextBox5.Texts = "Nombre(Opcional)";
            this.rjTextBox5.UnderlinedStyle = false;
            // 
            // rjTextBox6
            // 
            this.rjTextBox6.BackColor = System.Drawing.SystemColors.Window;
            this.rjTextBox6.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjTextBox6.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjTextBox6.BorderRadius = 0;
            this.rjTextBox6.BorderSize = 2;
            this.rjTextBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjTextBox6.Location = new System.Drawing.Point(7, 4);
            this.rjTextBox6.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBox6.Multiline = false;
            this.rjTextBox6.Name = "rjTextBox6";
            this.rjTextBox6.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBox6.PasswordChar = false;
            this.rjTextBox6.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBox6.PlaceholderText = "";
            this.rjTextBox6.Size = new System.Drawing.Size(250, 31);
            this.rjTextBox6.TabIndex = 16;
            this.rjTextBox6.Texts = "Telefono(Obligatorio)";
            this.rjTextBox6.UnderlinedStyle = false;
            // 
            // rjTextBox7
            // 
            this.rjTextBox7.BackColor = System.Drawing.SystemColors.Window;
            this.rjTextBox7.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjTextBox7.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjTextBox7.BorderRadius = 0;
            this.rjTextBox7.BorderSize = 2;
            this.rjTextBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjTextBox7.Location = new System.Drawing.Point(265, 4);
            this.rjTextBox7.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBox7.Multiline = false;
            this.rjTextBox7.Name = "rjTextBox7";
            this.rjTextBox7.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBox7.PasswordChar = false;
            this.rjTextBox7.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBox7.PlaceholderText = "";
            this.rjTextBox7.Size = new System.Drawing.Size(250, 31);
            this.rjTextBox7.TabIndex = 17;
            this.rjTextBox7.Texts = "Nombre(Obligatorio)";
            this.rjTextBox7.UnderlinedStyle = false;
            // 
            // PnlPedidos
            // 
            this.PnlPedidos.ColumnCount = 1;
            this.PnlPedidos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PnlPedidos.Controls.Add(this.DtgReservas, 0, 0);
            this.PnlPedidos.Controls.Add(this.PnlAdd, 0, 1);
            this.PnlPedidos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlPedidos.Location = new System.Drawing.Point(3, 108);
            this.PnlPedidos.Name = "PnlPedidos";
            this.PnlPedidos.RowCount = 2;
            this.PnlPedidos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.PnlPedidos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.PnlPedidos.Size = new System.Drawing.Size(1000, 390);
            this.PnlPedidos.TabIndex = 4;
            // 
            // DtgReservas
            // 
            this.DtgReservas.AllowUserToAddRows = false;
            this.DtgReservas.AllowUserToDeleteRows = false;
            this.DtgReservas.AllowUserToOrderColumns = true;
            this.DtgReservas.AllowUserToResizeRows = false;
            this.DtgReservas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtgReservas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(54)))), ((int)(((byte)(58)))));
            this.DtgReservas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DtgReservas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(41)))), ((int)(((byte)(83)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DtgReservas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DtgReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DtgReservas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClnCodigo,
            this.ClnNombre,
            this.ClnCantidad,
            this.ClnPrecioUnitario,
            this.ClnPrecioFinal});
            this.DtgReservas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DtgReservas.EnableHeadersVisualStyles = false;
            this.DtgReservas.GridColor = System.Drawing.Color.MediumSlateBlue;
            this.DtgReservas.Location = new System.Drawing.Point(3, 3);
            this.DtgReservas.Name = "DtgReservas";
            this.DtgReservas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DtgReservas.RowHeadersVisible = false;
            this.DtgReservas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DtgReservas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DtgReservas.Size = new System.Drawing.Size(994, 345);
            this.DtgReservas.TabIndex = 3;
            // 
            // ClnCodigo
            // 
            this.ClnCodigo.HeaderText = "Codigo";
            this.ClnCodigo.Name = "ClnCodigo";
            // 
            // ClnNombre
            // 
            this.ClnNombre.HeaderText = "Nombre";
            this.ClnNombre.Name = "ClnNombre";
            // 
            // ClnCantidad
            // 
            this.ClnCantidad.HeaderText = "Cantidad";
            this.ClnCantidad.Name = "ClnCantidad";
            // 
            // ClnPrecioUnitario
            // 
            this.ClnPrecioUnitario.HeaderText = "Precio Unitario";
            this.ClnPrecioUnitario.Name = "ClnPrecioUnitario";
            // 
            // ClnPrecioFinal
            // 
            this.ClnPrecioFinal.HeaderText = "Precio Final";
            this.ClnPrecioFinal.Name = "ClnPrecioFinal";
            // 
            // PnlAdd
            // 
            this.PnlAdd.Controls.Add(this.NucCantidad);
            this.PnlAdd.Controls.Add(this.TxtCode);
            this.PnlAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlAdd.Location = new System.Drawing.Point(3, 354);
            this.PnlAdd.Name = "PnlAdd";
            this.PnlAdd.Size = new System.Drawing.Size(994, 33);
            this.PnlAdd.TabIndex = 4;
            // 
            // TxtCode
            // 
            this.TxtCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtCode.Location = new System.Drawing.Point(838, 7);
            this.TxtCode.Name = "TxtCode";
            this.TxtCode.Size = new System.Drawing.Size(100, 20);
            this.TxtCode.TabIndex = 5;
            // 
            // NucCantidad
            // 
            this.NucCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NucCantidad.Location = new System.Drawing.Point(944, 7);
            this.NucCantidad.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.NucCantidad.Name = "NucCantidad";
            this.NucCantidad.Size = new System.Drawing.Size(46, 20);
            this.NucCantidad.TabIndex = 6;
            // 
            // FrmDetallesPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(54)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(1020, 560);
            this.Controls.Add(this.TabControl);
            this.Name = "FrmDetallesPedido";
            this.Text = "FrmDetallesPedido";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmDetallesPedido_FormClosed);
            this.TabControl.ResumeLayout(false);
            this.TabCliente.ResumeLayout(false);
            this.PnlMainCliente.ResumeLayout(false);
            this.PnlTipos.ResumeLayout(false);
            this.TabTipo.ResumeLayout(false);
            this.TabLocal.ResumeLayout(false);
            this.TabDomicilio.ResumeLayout(false);
            this.TabRecoger.ResumeLayout(false);
            this.TabDetalles.ResumeLayout(false);
            this.PnlMain.ResumeLayout(false);
            this.PnlCliente.ResumeLayout(false);
            this.PnlHeader.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.TabtTipoCambio.ResumeLayout(false);
            this.TabLocalCambiar.ResumeLayout(false);
            this.TabDomicilioCambiar.ResumeLayout(false);
            this.TabRecogerCambiar.ResumeLayout(false);
            this.PnlPedidos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DtgReservas)).EndInit();
            this.PnlAdd.ResumeLayout(false);
            this.PnlAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NucCantidad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl TabControl;
        private System.Windows.Forms.TabPage TabCliente;
        private System.Windows.Forms.TabPage TabDetalles;
        private System.Windows.Forms.TableLayoutPanel PnlMain;
        private System.Windows.Forms.Panel PnlCliente;
        private System.Windows.Forms.TableLayoutPanel PnlMainCliente;
        private System.Windows.Forms.TableLayoutPanel PnlTipos;
        private RJCodeAdvance.RJControls.RJButton BtnLocal;
        private RJCodeAdvance.RJControls.RJButton BtnDomicilio;
        private RJCodeAdvance.RJControls.RJButton BtnRecoger;
        private RJCodeAdvance.RJControls.RJButton BtnNext;
        private RJCodeAdvance.RJControls.RJButton BtnConfirmar;
        private MaterialSkin.Controls.MaterialTabControl TabTipo;
        private System.Windows.Forms.TabPage TabLocal;
        private RJCodeAdvance.RJControls.RJTextBox TxtComensales;
        private RJCodeAdvance.RJControls.RJTextBox TxtMesa;
        private System.Windows.Forms.TabPage TabDomicilio;
        private RJCodeAdvance.RJControls.RJTextBox TxtNombre;
        private RJCodeAdvance.RJControls.RJTextBox TxtDir;
        private RJCodeAdvance.RJControls.RJTextBox TxtTlf;
        private System.Windows.Forms.TabPage TabRecoger;
        private RJCodeAdvance.RJControls.RJTextBox TxtNombreRecoger;
        private RJCodeAdvance.RJControls.RJTextBox TxtTlfRecoger;
        private System.Windows.Forms.TableLayoutPanel PnlHeader;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MaterialSkin.Controls.MaterialTabControl TabtTipoCambio;
        private System.Windows.Forms.TabPage TabLocalCambiar;
        private System.Windows.Forms.TabPage TabDomicilioCambiar;
        private MaterialSkin.Controls.MaterialLabel LblFecha;
        private MaterialSkin.Controls.MaterialLabel LblHora;
        private RJCodeAdvance.RJControls.RJComboBox CboEstado;
        private RJCodeAdvance.RJControls.RJComboBox CboTipo;
        private System.Windows.Forms.TabPage TabRecogerCambiar;
        private RJCodeAdvance.RJControls.RJTextBox rjTextBox2;
        private RJCodeAdvance.RJControls.RJTextBox rjTextBox1;
        private RJCodeAdvance.RJControls.RJTextBox rjTextBox5;
        private RJCodeAdvance.RJControls.RJTextBox rjTextBox4;
        private RJCodeAdvance.RJControls.RJTextBox rjTextBox3;
        private RJCodeAdvance.RJControls.RJTextBox rjTextBox7;
        private RJCodeAdvance.RJControls.RJTextBox rjTextBox6;
        private System.Windows.Forms.TableLayoutPanel PnlPedidos;
        private System.Windows.Forms.DataGridView DtgReservas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnPrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnPrecioFinal;
        private System.Windows.Forms.Panel PnlAdd;
        private System.Windows.Forms.NumericUpDown NucCantidad;
        private System.Windows.Forms.TextBox TxtCode;
    }
}