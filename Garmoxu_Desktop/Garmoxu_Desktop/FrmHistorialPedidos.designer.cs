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
            this.PnlMain = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnCerrar = new RJCodeAdvance.RJControls.RJButton();
            this.PnlBusqueda = new System.Windows.Forms.TableLayoutPanel();
            this.BtnBuscar = new RJCodeAdvance.RJControls.RJButton();
            this.PnlCalendar = new System.Windows.Forms.Panel();
            this.DtpBuscar = new RJCodeAdvance.RJControls.RJDatePicker();
            this.PnlTipo = new System.Windows.Forms.Panel();
            this.CboTipo = new RJCodeAdvance.RJControls.RJComboBox();
            this.ChkTipo = new MaterialSkin.Controls.MaterialCheckBox();
            this.PnlTelefono = new System.Windows.Forms.Panel();
            this.TxtTelefono = new RJCodeAdvance.RJControls.RJTextBox();
            this.ChkTelefono = new MaterialSkin.Controls.MaterialCheckBox();
            this.DtgHistorial = new System.Windows.Forms.DataGridView();
            this.PnlMain.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.PnlBusqueda.SuspendLayout();
            this.PnlCalendar.SuspendLayout();
            this.PnlTipo.SuspendLayout();
            this.PnlTelefono.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgHistorial)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlMain
            // 
            this.PnlMain.ColumnCount = 1;
            this.PnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PnlMain.Controls.Add(this.tableLayoutPanel1, 0, 2);
            this.PnlMain.Controls.Add(this.PnlBusqueda, 0, 0);
            this.PnlMain.Controls.Add(this.DtgHistorial, 0, 1);
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
            this.PnlMain.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.Controls.Add(this.BtnCerrar, 0, 0);
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
            this.BtnCerrar.Size = new System.Drawing.Size(243, 49);
            this.BtnCerrar.TabIndex = 0;
            this.BtnCerrar.Text = "Cerrar";
            this.BtnCerrar.TextColor = System.Drawing.Color.White;
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // PnlBusqueda
            // 
            this.PnlBusqueda.ColumnCount = 5;
            this.PnlBusqueda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.PnlBusqueda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26F));
            this.PnlBusqueda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26F));
            this.PnlBusqueda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3F));
            this.PnlBusqueda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.PnlBusqueda.Controls.Add(this.BtnBuscar, 4, 0);
            this.PnlBusqueda.Controls.Add(this.PnlCalendar, 0, 0);
            this.PnlBusqueda.Controls.Add(this.PnlTipo, 1, 0);
            this.PnlBusqueda.Controls.Add(this.PnlTelefono, 2, 0);
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
            this.BtnBuscar.Location = new System.Drawing.Point(857, 4);
            this.BtnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(144, 46);
            this.BtnBuscar.TabIndex = 0;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.TextColor = System.Drawing.Color.White;
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // PnlCalendar
            // 
            this.PnlCalendar.Controls.Add(this.DtpBuscar);
            this.PnlCalendar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlCalendar.Location = new System.Drawing.Point(4, 4);
            this.PnlCalendar.Margin = new System.Windows.Forms.Padding(4);
            this.PnlCalendar.Name = "PnlCalendar";
            this.PnlCalendar.Size = new System.Drawing.Size(293, 46);
            this.PnlCalendar.TabIndex = 9;
            // 
            // DtpBuscar
            // 
            this.DtpBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DtpBuscar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.DtpBuscar.BorderSize = 0;
            this.DtpBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.DtpBuscar.Location = new System.Drawing.Point(4, 2);
            this.DtpBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.DtpBuscar.MinimumSize = new System.Drawing.Size(4, 35);
            this.DtpBuscar.Name = "DtpBuscar";
            this.DtpBuscar.Size = new System.Drawing.Size(288, 35);
            this.DtpBuscar.SkinColor = System.Drawing.Color.MediumSlateBlue;
            this.DtpBuscar.TabIndex = 6;
            this.DtpBuscar.TextColor = System.Drawing.Color.White;
            this.DtpBuscar.ValueChanged += new System.EventHandler(this.DtpBuscar_ValueChanged);
            // 
            // PnlTipo
            // 
            this.PnlTipo.Controls.Add(this.CboTipo);
            this.PnlTipo.Controls.Add(this.ChkTipo);
            this.PnlTipo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlTipo.Location = new System.Drawing.Point(305, 4);
            this.PnlTipo.Margin = new System.Windows.Forms.Padding(4);
            this.PnlTipo.Name = "PnlTipo";
            this.PnlTipo.Size = new System.Drawing.Size(253, 46);
            this.PnlTipo.TabIndex = 10;
            // 
            // CboTipo
            // 
            this.CboTipo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CboTipo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CboTipo.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.CboTipo.BorderSize = 1;
            this.CboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CboTipo.ForeColor = System.Drawing.Color.DimGray;
            this.CboTipo.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.CboTipo.Items.AddRange(new object[] {
            "Local",
            "Domicilio",
            "Recoger"});
            this.CboTipo.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.CboTipo.ListTextColor = System.Drawing.Color.DimGray;
            this.CboTipo.Location = new System.Drawing.Point(51, 4);
            this.CboTipo.Margin = new System.Windows.Forms.Padding(4);
            this.CboTipo.MinimumSize = new System.Drawing.Size(200, 37);
            this.CboTipo.Name = "CboTipo";
            this.CboTipo.Padding = new System.Windows.Forms.Padding(1);
            this.CboTipo.Size = new System.Drawing.Size(200, 37);
            this.CboTipo.TabIndex = 1;
            this.CboTipo.Texts = "";
            this.CboTipo.OnSelectedIndexChanged += new System.EventHandler(this.CboTipo_OnSelectedIndexChanged);
            // 
            // ChkTipo
            // 
            this.ChkTipo.AutoSize = true;
            this.ChkTipo.Depth = 0;
            this.ChkTipo.Font = new System.Drawing.Font("Roboto", 10F);
            this.ChkTipo.Location = new System.Drawing.Point(12, 6);
            this.ChkTipo.Margin = new System.Windows.Forms.Padding(0);
            this.ChkTipo.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ChkTipo.MouseState = MaterialSkin.MouseState.HOVER;
            this.ChkTipo.Name = "ChkTipo";
            this.ChkTipo.Ripple = true;
            this.ChkTipo.Size = new System.Drawing.Size(26, 30);
            this.ChkTipo.TabIndex = 0;
            this.ChkTipo.UseVisualStyleBackColor = true;
            // 
            // PnlTelefono
            // 
            this.PnlTelefono.Controls.Add(this.TxtTelefono);
            this.PnlTelefono.Controls.Add(this.ChkTelefono);
            this.PnlTelefono.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlTelefono.Location = new System.Drawing.Point(566, 4);
            this.PnlTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.PnlTelefono.Name = "PnlTelefono";
            this.PnlTelefono.Size = new System.Drawing.Size(253, 46);
            this.PnlTelefono.TabIndex = 11;
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtTelefono.BackColor = System.Drawing.SystemColors.Window;
            this.TxtTelefono.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.TxtTelefono.BorderFocusColor = System.Drawing.Color.HotPink;
            this.TxtTelefono.BorderRadius = 0;
            this.TxtTelefono.BorderSize = 2;
            this.TxtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTelefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtTelefono.Location = new System.Drawing.Point(45, 4);
            this.TxtTelefono.Margin = new System.Windows.Forms.Padding(5);
            this.TxtTelefono.Multiline = false;
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.TxtTelefono.PasswordChar = false;
            this.TxtTelefono.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TxtTelefono.PlaceholderText = "";
            this.TxtTelefono.Size = new System.Drawing.Size(203, 39);
            this.TxtTelefono.TabIndex = 2;
            this.TxtTelefono.Texts = "Telefono";
            this.TxtTelefono.UnderlinedStyle = false;
            this.TxtTelefono._TextChanged += new System.EventHandler(this.TxtTelefono__TextChanged);
            this.TxtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTelefono_KeyPress);
            // 
            // ChkTelefono
            // 
            this.ChkTelefono.AutoSize = true;
            this.ChkTelefono.Depth = 0;
            this.ChkTelefono.Font = new System.Drawing.Font("Roboto", 10F);
            this.ChkTelefono.Location = new System.Drawing.Point(5, 6);
            this.ChkTelefono.Margin = new System.Windows.Forms.Padding(0);
            this.ChkTelefono.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ChkTelefono.MouseState = MaterialSkin.MouseState.HOVER;
            this.ChkTelefono.Name = "ChkTelefono";
            this.ChkTelefono.Ripple = true;
            this.ChkTelefono.Size = new System.Drawing.Size(26, 30);
            this.ChkTelefono.TabIndex = 0;
            this.ChkTelefono.UseVisualStyleBackColor = true;
            // 
            // DtgHistorial
            // 
            this.DtgHistorial.AllowUserToAddRows = false;
            this.DtgHistorial.AllowUserToDeleteRows = false;
            this.DtgHistorial.AllowUserToOrderColumns = true;
            this.DtgHistorial.AllowUserToResizeRows = false;
            this.DtgHistorial.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DtgHistorial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtgHistorial.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(54)))), ((int)(((byte)(58)))));
            this.DtgHistorial.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DtgHistorial.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(41)))), ((int)(((byte)(83)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DtgHistorial.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DtgHistorial.ColumnHeadersHeight = 29;
            this.DtgHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DtgHistorial.EnableHeadersVisualStyles = false;
            this.DtgHistorial.GridColor = System.Drawing.Color.MediumSlateBlue;
            this.DtgHistorial.Location = new System.Drawing.Point(31, 91);
            this.DtgHistorial.Margin = new System.Windows.Forms.Padding(4);
            this.DtgHistorial.Name = "DtgHistorial";
            this.DtgHistorial.ReadOnly = true;
            this.DtgHistorial.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DtgHistorial.RowHeadersVisible = false;
            this.DtgHistorial.RowHeadersWidth = 51;
            this.DtgHistorial.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DtgHistorial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DtgHistorial.Size = new System.Drawing.Size(1005, 367);
            this.DtgHistorial.TabIndex = 1;
            this.DtgHistorial.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgHistorial_CellDoubleClick);
            // 
            // FrmHistorialPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(54)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.PnlMain);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmHistorialPedidos";
            this.Text = "FrmHistorialPedidos";
            this.EnabledChanged += new System.EventHandler(this.FrmHistorialPedidos_EnabledChanged);
            this.PnlMain.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.PnlBusqueda.ResumeLayout(false);
            this.PnlCalendar.ResumeLayout(false);
            this.PnlTipo.ResumeLayout(false);
            this.PnlTipo.PerformLayout();
            this.PnlTelefono.ResumeLayout(false);
            this.PnlTelefono.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgHistorial)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel PnlMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private RJCodeAdvance.RJControls.RJButton BtnCerrar;
        private System.Windows.Forms.TableLayoutPanel PnlBusqueda;
        private System.Windows.Forms.Panel PnlCalendar;
        private RJCodeAdvance.RJControls.RJDatePicker DtpBuscar;
        private System.Windows.Forms.DataGridView DtgHistorial;
        private RJCodeAdvance.RJControls.RJButton BtnBuscar;
        private System.Windows.Forms.Panel PnlTipo;
        private MaterialSkin.Controls.MaterialCheckBox ChkTipo;
        private System.Windows.Forms.Panel PnlTelefono;
        private RJCodeAdvance.RJControls.RJTextBox TxtTelefono;
        private MaterialSkin.Controls.MaterialCheckBox ChkTelefono;
        private RJCodeAdvance.RJControls.RJComboBox CboTipo;
    }
}