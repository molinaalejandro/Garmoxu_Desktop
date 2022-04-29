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
            this.BtnConfirmar = new RJCodeAdvance.RJControls.RJButton();
            this.BtnBorrar = new RJCodeAdvance.RJControls.RJButton();
            this.DtpReserva = new RJCodeAdvance.RJControls.RJDatePicker();
            this.DtpHora = new System.Windows.Forms.DateTimePicker();
            this.BtnClose = new FontAwesome.Sharp.IconButton();
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
            this.TxtNombreCliente.Location = new System.Drawing.Point(113, 410);
            this.TxtNombreCliente.Margin = new System.Windows.Forms.Padding(5);
            this.TxtNombreCliente.Multiline = false;
            this.TxtNombreCliente.Name = "TxtNombreCliente";
            this.TxtNombreCliente.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.TxtNombreCliente.PasswordChar = false;
            this.TxtNombreCliente.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TxtNombreCliente.PlaceholderText = "";
            this.TxtNombreCliente.Size = new System.Drawing.Size(344, 39);
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
            this.TxtTelefono.Location = new System.Drawing.Point(113, 336);
            this.TxtTelefono.Margin = new System.Windows.Forms.Padding(5);
            this.TxtTelefono.Multiline = false;
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.TxtTelefono.PasswordChar = false;
            this.TxtTelefono.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TxtTelefono.PlaceholderText = "";
            this.TxtTelefono.Size = new System.Drawing.Size(344, 39);
            this.TxtTelefono.TabIndex = 10;
            this.TxtTelefono.Texts = "Tlefono(Obligatorio)";
            this.TxtTelefono.UnderlinedStyle = false;
            this.TxtTelefono._TextChanged += new System.EventHandler(this.TxtTelefono__TextChanged);
            // 
            // CboMesa
            // 
            this.CboMesa.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CboMesa.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.CboMesa.BorderSize = 1;
            this.CboMesa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboMesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CboMesa.ForeColor = System.Drawing.Color.DimGray;
            this.CboMesa.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.CboMesa.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.CboMesa.ListTextColor = System.Drawing.Color.DimGray;
            this.CboMesa.Location = new System.Drawing.Point(113, 262);
            this.CboMesa.Margin = new System.Windows.Forms.Padding(4);
            this.CboMesa.MinimumSize = new System.Drawing.Size(267, 37);
            this.CboMesa.Name = "CboMesa";
            this.CboMesa.Padding = new System.Windows.Forms.Padding(1);
            this.CboMesa.Size = new System.Drawing.Size(344, 37);
            this.CboMesa.TabIndex = 12;
            this.CboMesa.Texts = "";
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
            this.BtnConfirmar.Location = new System.Drawing.Point(385, 558);
            this.BtnConfirmar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnConfirmar.Name = "BtnConfirmar";
            this.BtnConfirmar.Size = new System.Drawing.Size(200, 49);
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
            this.BtnBorrar.Location = new System.Drawing.Point(16, 558);
            this.BtnBorrar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnBorrar.Name = "BtnBorrar";
            this.BtnBorrar.Size = new System.Drawing.Size(200, 49);
            this.BtnBorrar.TabIndex = 17;
            this.BtnBorrar.Text = "Borrar Reserva";
            this.BtnBorrar.TextColor = System.Drawing.Color.White;
            this.BtnBorrar.UseVisualStyleBackColor = false;
            this.BtnBorrar.Click += new System.EventHandler(this.BtnBorrar_Click);
            // 
            // DtpReserva
            // 
            this.DtpReserva.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.DtpReserva.BorderSize = 0;
            this.DtpReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.DtpReserva.Location = new System.Drawing.Point(113, 175);
            this.DtpReserva.Margin = new System.Windows.Forms.Padding(4);
            this.DtpReserva.MinimumSize = new System.Drawing.Size(4, 35);
            this.DtpReserva.Name = "DtpReserva";
            this.DtpReserva.Size = new System.Drawing.Size(249, 35);
            this.DtpReserva.SkinColor = System.Drawing.Color.MediumSlateBlue;
            this.DtpReserva.TabIndex = 18;
            this.DtpReserva.TextColor = System.Drawing.Color.White;
            this.DtpReserva.Value = new System.DateTime(2022, 4, 16, 12, 0, 23, 0);
            this.DtpReserva.ValueChanged += new System.EventHandler(this.DtpReserva_ValueChanged);
            // 
            // DtpHora
            // 
            this.DtpHora.CustomFormat = "HH:mm";
            this.DtpHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpHora.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpHora.Location = new System.Drawing.Point(372, 185);
            this.DtpHora.Margin = new System.Windows.Forms.Padding(4);
            this.DtpHora.Name = "DtpHora";
            this.DtpHora.ShowUpDown = true;
            this.DtpHora.Size = new System.Drawing.Size(84, 32);
            this.DtpHora.TabIndex = 20;
            this.DtpHora.Value = new System.DateTime(2022, 4, 16, 0, 0, 0, 0);
            this.DtpHora.ValueChanged += new System.EventHandler(this.DtpHora_ValueChanged);
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.Color.Transparent;
            this.BtnClose.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnClose.FlatAppearance.BorderSize = 0;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.BtnClose.IconColor = System.Drawing.Color.White;
            this.BtnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnClose.IconSize = 25;
            this.BtnClose.Location = new System.Drawing.Point(0, 0);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(4);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(601, 41);
            this.BtnClose.TabIndex = 21;
            this.BtnClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // FrmDetallesReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(54)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(601, 622);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.DtpHora);
            this.Controls.Add(this.DtpReserva);
            this.Controls.Add(this.BtnBorrar);
            this.Controls.Add(this.BtnConfirmar);
            this.Controls.Add(this.CboMesa);
            this.Controls.Add(this.TxtNombreCliente);
            this.Controls.Add(this.TxtTelefono);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmDetallesReserva";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmDetallesReserva_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        public RJCodeAdvance.RJControls.RJTextBox TxtNombreCliente;
        public RJCodeAdvance.RJControls.RJTextBox TxtTelefono;
        public RJCodeAdvance.RJControls.RJComboBox CboMesa;
        public RJCodeAdvance.RJControls.RJButton BtnConfirmar;
        public RJCodeAdvance.RJControls.RJButton BtnBorrar;
        public RJCodeAdvance.RJControls.RJDatePicker DtpReserva;
        private System.Windows.Forms.DateTimePicker DtpHora;
        private FontAwesome.Sharp.IconButton BtnClose;
    }
}