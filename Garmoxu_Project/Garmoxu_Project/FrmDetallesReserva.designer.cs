namespace Garmoxu_Project
{
    partial class FrmDetallesReserva
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
            this.TxtNombreCliente = new RJCodeAdvance.RJControls.RJTextBox();
            this.TxtTelefono = new RJCodeAdvance.RJControls.RJTextBox();
            this.CboMesa = new RJCodeAdvance.RJControls.RJComboBox();
            this.NucHora = new System.Windows.Forms.NumericUpDown();
            this.NucMinuto = new System.Windows.Forms.NumericUpDown();
            this.BtnConfirmar = new RJCodeAdvance.RJControls.RJButton();
            this.BtnBorrar = new RJCodeAdvance.RJControls.RJButton();
            this.DtpReserva = new RJCodeAdvance.RJControls.RJDatePicker();
            this.CboReserva = new RJCodeAdvance.RJControls.RJComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.NucHora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NucMinuto)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtNombreCliente
            // 
            this.TxtNombreCliente.BackColor = System.Drawing.SystemColors.Window;
            this.TxtNombreCliente.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.TxtNombreCliente.BorderFocusColor = System.Drawing.Color.HotPink;
            this.TxtNombreCliente.BorderRadius = 0;
            this.TxtNombreCliente.BorderSize = 2;
            this.TxtNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombreCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtNombreCliente.Location = new System.Drawing.Point(85, 333);
            this.TxtNombreCliente.Margin = new System.Windows.Forms.Padding(4);
            this.TxtNombreCliente.Multiline = false;
            this.TxtNombreCliente.Name = "TxtNombreCliente";
            this.TxtNombreCliente.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.TxtNombreCliente.PasswordChar = false;
            this.TxtNombreCliente.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TxtNombreCliente.PlaceholderText = "";
            this.TxtNombreCliente.Size = new System.Drawing.Size(250, 31);
            this.TxtNombreCliente.TabIndex = 11;
            this.TxtNombreCliente.Texts = "NOmbre(Obligatorio)";
            this.TxtNombreCliente.UnderlinedStyle = false;
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.BackColor = System.Drawing.SystemColors.Window;
            this.TxtTelefono.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.TxtTelefono.BorderFocusColor = System.Drawing.Color.HotPink;
            this.TxtTelefono.BorderRadius = 0;
            this.TxtTelefono.BorderSize = 2;
            this.TxtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTelefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtTelefono.Location = new System.Drawing.Point(85, 273);
            this.TxtTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.TxtTelefono.Multiline = false;
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.TxtTelefono.PasswordChar = false;
            this.TxtTelefono.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TxtTelefono.PlaceholderText = "";
            this.TxtTelefono.Size = new System.Drawing.Size(250, 31);
            this.TxtTelefono.TabIndex = 10;
            this.TxtTelefono.Texts = "Tlefono(Obligatorio)";
            this.TxtTelefono.UnderlinedStyle = false;
            // 
            // CboMesa
            // 
            this.CboMesa.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CboMesa.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.CboMesa.BorderSize = 1;
            this.CboMesa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.CboMesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CboMesa.ForeColor = System.Drawing.Color.DimGray;
            this.CboMesa.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.CboMesa.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.CboMesa.ListTextColor = System.Drawing.Color.DimGray;
            this.CboMesa.Location = new System.Drawing.Point(85, 70);
            this.CboMesa.MinimumSize = new System.Drawing.Size(200, 30);
            this.CboMesa.Name = "CboMesa";
            this.CboMesa.Padding = new System.Windows.Forms.Padding(1);
            this.CboMesa.Size = new System.Drawing.Size(250, 30);
            this.CboMesa.TabIndex = 12;
            this.CboMesa.Texts = "";
            // 
            // NucHora
            // 
            this.NucHora.Location = new System.Drawing.Point(85, 218);
            this.NucHora.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.NucHora.Name = "NucHora";
            this.NucHora.Size = new System.Drawing.Size(120, 20);
            this.NucHora.TabIndex = 14;
            this.NucHora.ValueChanged += new System.EventHandler(this.NucHora_ValueChanged);
            // 
            // NucMinuto
            // 
            this.NucMinuto.Location = new System.Drawing.Point(215, 218);
            this.NucMinuto.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.NucMinuto.Name = "NucMinuto";
            this.NucMinuto.Size = new System.Drawing.Size(120, 20);
            this.NucMinuto.TabIndex = 15;
            this.NucMinuto.ValueChanged += new System.EventHandler(this.NucMinuto_ValueChanged);
            // 
            // BtnConfirmar
            // 
            this.BtnConfirmar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnConfirmar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnConfirmar.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnConfirmar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnConfirmar.BorderRadius = 0;
            this.BtnConfirmar.BorderSize = 0;
            this.BtnConfirmar.FlatAppearance.BorderSize = 0;
            this.BtnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConfirmar.ForeColor = System.Drawing.Color.White;
            this.BtnConfirmar.Location = new System.Drawing.Point(263, 463);
            this.BtnConfirmar.Name = "BtnConfirmar";
            this.BtnConfirmar.Size = new System.Drawing.Size(150, 40);
            this.BtnConfirmar.TabIndex = 16;
            this.BtnConfirmar.Text = "Confirmar";
            this.BtnConfirmar.TextColor = System.Drawing.Color.White;
            this.BtnConfirmar.UseVisualStyleBackColor = false;
            this.BtnConfirmar.Click += new System.EventHandler(this.BtnConfirmar_Click);
            // 
            // BtnBorrar
            // 
            this.BtnBorrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnBorrar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnBorrar.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnBorrar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnBorrar.BorderRadius = 0;
            this.BtnBorrar.BorderSize = 0;
            this.BtnBorrar.FlatAppearance.BorderSize = 0;
            this.BtnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBorrar.ForeColor = System.Drawing.Color.White;
            this.BtnBorrar.Location = new System.Drawing.Point(12, 463);
            this.BtnBorrar.Name = "BtnBorrar";
            this.BtnBorrar.Size = new System.Drawing.Size(150, 40);
            this.BtnBorrar.TabIndex = 17;
            this.BtnBorrar.Text = "Borrar Reserva";
            this.BtnBorrar.TextColor = System.Drawing.Color.White;
            this.BtnBorrar.UseVisualStyleBackColor = false;
            this.BtnBorrar.Click += new System.EventHandler(this.BtnBorrar_Click_1);
            // 
            // DtpReserva
            // 
            this.DtpReserva.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.DtpReserva.BorderSize = 0;
            this.DtpReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.DtpReserva.Location = new System.Drawing.Point(85, 142);
            this.DtpReserva.MinimumSize = new System.Drawing.Size(4, 35);
            this.DtpReserva.Name = "DtpReserva";
            this.DtpReserva.Size = new System.Drawing.Size(250, 35);
            this.DtpReserva.SkinColor = System.Drawing.Color.MediumSlateBlue;
            this.DtpReserva.TabIndex = 18;
            this.DtpReserva.TextColor = System.Drawing.Color.White;
            this.DtpReserva.ValueChanged += new System.EventHandler(this.DtpReserva_ValueChanged);
            // 
            // CboReserva
            // 
            this.CboReserva.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CboReserva.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.CboReserva.BorderSize = 1;
            this.CboReserva.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.CboReserva.Enabled = false;
            this.CboReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CboReserva.ForeColor = System.Drawing.Color.DimGray;
            this.CboReserva.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.CboReserva.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.CboReserva.ListTextColor = System.Drawing.Color.DimGray;
            this.CboReserva.Location = new System.Drawing.Point(85, 21);
            this.CboReserva.MinimumSize = new System.Drawing.Size(200, 30);
            this.CboReserva.Name = "CboReserva";
            this.CboReserva.Padding = new System.Windows.Forms.Padding(1);
            this.CboReserva.Size = new System.Drawing.Size(250, 30);
            this.CboReserva.TabIndex = 19;
            this.CboReserva.Texts = "";
            this.CboReserva.Visible = false;
            // 
            // FrmDetallesReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(54)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(425, 515);
            this.Controls.Add(this.CboReserva);
            this.Controls.Add(this.DtpReserva);
            this.Controls.Add(this.BtnBorrar);
            this.Controls.Add(this.BtnConfirmar);
            this.Controls.Add(this.NucMinuto);
            this.Controls.Add(this.NucHora);
            this.Controls.Add(this.CboMesa);
            this.Controls.Add(this.TxtNombreCliente);
            this.Controls.Add(this.TxtTelefono);
            this.Name = "FrmDetallesReserva";
            this.Text = "FrmDetallesReserva";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmDetallesReserva_FormClosing);
            this.Load += new System.EventHandler(this.FrmDetallesReserva_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NucHora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NucMinuto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private RJCodeAdvance.RJControls.RJTextBox TxtNombreCliente;
        private RJCodeAdvance.RJControls.RJTextBox TxtTelefono;
        private RJCodeAdvance.RJControls.RJComboBox CboMesa;
        private System.Windows.Forms.NumericUpDown NucHora;
        private System.Windows.Forms.NumericUpDown NucMinuto;
        private RJCodeAdvance.RJControls.RJButton BtnConfirmar;
        private RJCodeAdvance.RJControls.RJButton BtnBorrar;
        private RJCodeAdvance.RJControls.RJDatePicker DtpReserva;
        private RJCodeAdvance.RJControls.RJComboBox CboReserva;
    }
}