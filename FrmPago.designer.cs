
namespace Garmoxu_Project
{
    partial class FrmPago
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
            this.LblImporte = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.TxtImporte = new RJCodeAdvance.RJControls.RJTextBox();
            this.TxtDevuelto = new RJCodeAdvance.RJControls.RJTextBox();
            this.RdbTarjeta = new RJCodeAdvance.RJControls.RJRadioButton();
            this.RdbEfectivo = new RJCodeAdvance.RJControls.RJRadioButton();
            this.RdbTicket = new RJCodeAdvance.RJControls.RJRadioButton();
            this.BtnConfirmar = new RJCodeAdvance.RJControls.RJButton();
            this.BtnVisa = new FontAwesome.Sharp.IconButton();
            this.BtnEfectivo = new FontAwesome.Sharp.IconButton();
            this.BtnTicket = new FontAwesome.Sharp.IconButton();
            this.BtnCerrar = new RJCodeAdvance.RJControls.RJButton();
            this.TxtCliente = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LblImporte
            // 
            this.LblImporte.AutoSize = true;
            this.LblImporte.Depth = 0;
            this.LblImporte.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblImporte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblImporte.Location = new System.Drawing.Point(28, 63);
            this.LblImporte.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblImporte.Name = "LblImporte";
            this.LblImporte.Size = new System.Drawing.Size(127, 24);
            this.LblImporte.TabIndex = 0;
            this.LblImporte.Text = "Importe Final:";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(32, 146);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(139, 24);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Importe Cliente";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(28, 238);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(122, 24);
            this.materialLabel2.TabIndex = 2;
            this.materialLabel2.Text = "Tipo de pago";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(32, 325);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(154, 24);
            this.materialLabel3.TabIndex = 3;
            this.materialLabel3.Text = "Importe Devuelto";
            // 
            // TxtImporte
            // 
            this.TxtImporte.BackColor = System.Drawing.SystemColors.Window;
            this.TxtImporte.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.TxtImporte.BorderFocusColor = System.Drawing.Color.HotPink;
            this.TxtImporte.BorderRadius = 0;
            this.TxtImporte.BorderSize = 2;
            this.TxtImporte.Enabled = false;
            this.TxtImporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtImporte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtImporte.Location = new System.Drawing.Point(226, 63);
            this.TxtImporte.Margin = new System.Windows.Forms.Padding(4);
            this.TxtImporte.Multiline = false;
            this.TxtImporte.Name = "TxtImporte";
            this.TxtImporte.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.TxtImporte.PasswordChar = false;
            this.TxtImporte.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TxtImporte.PlaceholderText = "";
            this.TxtImporte.Size = new System.Drawing.Size(250, 35);
            this.TxtImporte.TabIndex = 4;
            this.TxtImporte.Texts = "";
            this.TxtImporte.UnderlinedStyle = false;
            // 
            // TxtDevuelto
            // 
            this.TxtDevuelto.BackColor = System.Drawing.SystemColors.Window;
            this.TxtDevuelto.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.TxtDevuelto.BorderFocusColor = System.Drawing.Color.HotPink;
            this.TxtDevuelto.BorderRadius = 0;
            this.TxtDevuelto.BorderSize = 2;
            this.TxtDevuelto.Enabled = false;
            this.TxtDevuelto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDevuelto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtDevuelto.Location = new System.Drawing.Point(223, 325);
            this.TxtDevuelto.Margin = new System.Windows.Forms.Padding(4);
            this.TxtDevuelto.Multiline = false;
            this.TxtDevuelto.Name = "TxtDevuelto";
            this.TxtDevuelto.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.TxtDevuelto.PasswordChar = false;
            this.TxtDevuelto.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TxtDevuelto.PlaceholderText = "";
            this.TxtDevuelto.Size = new System.Drawing.Size(250, 35);
            this.TxtDevuelto.TabIndex = 7;
            this.TxtDevuelto.Texts = "";
            this.TxtDevuelto.UnderlinedStyle = false;
            // 
            // RdbTarjeta
            // 
            this.RdbTarjeta.AutoSize = true;
            this.RdbTarjeta.CheckedColor = System.Drawing.Color.MediumSlateBlue;
            this.RdbTarjeta.Location = new System.Drawing.Point(243, 213);
            this.RdbTarjeta.MinimumSize = new System.Drawing.Size(0, 21);
            this.RdbTarjeta.Name = "RdbTarjeta";
            this.RdbTarjeta.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.RdbTarjeta.Size = new System.Drawing.Size(27, 21);
            this.RdbTarjeta.TabIndex = 8;
            this.RdbTarjeta.TabStop = true;
            this.RdbTarjeta.UnCheckedColor = System.Drawing.Color.Gray;
            this.RdbTarjeta.UseVisualStyleBackColor = true;
            // 
            // RdbEfectivo
            // 
            this.RdbEfectivo.AutoSize = true;
            this.RdbEfectivo.CheckedColor = System.Drawing.Color.MediumSlateBlue;
            this.RdbEfectivo.Location = new System.Drawing.Point(321, 213);
            this.RdbEfectivo.MinimumSize = new System.Drawing.Size(0, 21);
            this.RdbEfectivo.Name = "RdbEfectivo";
            this.RdbEfectivo.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.RdbEfectivo.Size = new System.Drawing.Size(27, 21);
            this.RdbEfectivo.TabIndex = 9;
            this.RdbEfectivo.TabStop = true;
            this.RdbEfectivo.UnCheckedColor = System.Drawing.Color.Gray;
            this.RdbEfectivo.UseVisualStyleBackColor = true;
            this.RdbEfectivo.CheckedChanged += new System.EventHandler(this.RdbEfectivo_CheckedChanged);
            // 
            // RdbTicket
            // 
            this.RdbTicket.AutoSize = true;
            this.RdbTicket.CheckedColor = System.Drawing.Color.MediumSlateBlue;
            this.RdbTicket.Location = new System.Drawing.Point(403, 213);
            this.RdbTicket.MinimumSize = new System.Drawing.Size(0, 21);
            this.RdbTicket.Name = "RdbTicket";
            this.RdbTicket.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.RdbTicket.Size = new System.Drawing.Size(27, 21);
            this.RdbTicket.TabIndex = 10;
            this.RdbTicket.TabStop = true;
            this.RdbTicket.UnCheckedColor = System.Drawing.Color.Gray;
            this.RdbTicket.UseVisualStyleBackColor = true;
            // 
            // BtnConfirmar
            // 
            this.BtnConfirmar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnConfirmar.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnConfirmar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnConfirmar.BorderRadius = 0;
            this.BtnConfirmar.BorderSize = 0;
            this.BtnConfirmar.FlatAppearance.BorderSize = 0;
            this.BtnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConfirmar.ForeColor = System.Drawing.Color.White;
            this.BtnConfirmar.Location = new System.Drawing.Point(264, 412);
            this.BtnConfirmar.Name = "BtnConfirmar";
            this.BtnConfirmar.Size = new System.Drawing.Size(150, 40);
            this.BtnConfirmar.TabIndex = 11;
            this.BtnConfirmar.Text = "Confirmar";
            this.BtnConfirmar.TextColor = System.Drawing.Color.White;
            this.BtnConfirmar.UseVisualStyleBackColor = false;
            this.BtnConfirmar.Click += new System.EventHandler(this.BtnConfirmar_Click);
            // 
            // BtnVisa
            // 
            this.BtnVisa.Enabled = false;
            this.BtnVisa.FlatAppearance.BorderSize = 0;
            this.BtnVisa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVisa.IconChar = FontAwesome.Sharp.IconChar.Paypal;
            this.BtnVisa.IconColor = System.Drawing.Color.Black;
            this.BtnVisa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnVisa.Location = new System.Drawing.Point(214, 252);
            this.BtnVisa.Name = "BtnVisa";
            this.BtnVisa.Size = new System.Drawing.Size(75, 47);
            this.BtnVisa.TabIndex = 12;
            this.BtnVisa.UseVisualStyleBackColor = true;
            // 
            // BtnEfectivo
            // 
            this.BtnEfectivo.Enabled = false;
            this.BtnEfectivo.FlatAppearance.BorderSize = 0;
            this.BtnEfectivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEfectivo.IconChar = FontAwesome.Sharp.IconChar.MoneyBillAlt;
            this.BtnEfectivo.IconColor = System.Drawing.Color.Black;
            this.BtnEfectivo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnEfectivo.Location = new System.Drawing.Point(295, 252);
            this.BtnEfectivo.Name = "BtnEfectivo";
            this.BtnEfectivo.Size = new System.Drawing.Size(75, 47);
            this.BtnEfectivo.TabIndex = 13;
            this.BtnEfectivo.UseVisualStyleBackColor = true;
            // 
            // BtnTicket
            // 
            this.BtnTicket.Enabled = false;
            this.BtnTicket.FlatAppearance.BorderSize = 0;
            this.BtnTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTicket.IconChar = FontAwesome.Sharp.IconChar.MoneyCheckAlt;
            this.BtnTicket.IconColor = System.Drawing.Color.Black;
            this.BtnTicket.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnTicket.Location = new System.Drawing.Point(376, 252);
            this.BtnTicket.Name = "BtnTicket";
            this.BtnTicket.Size = new System.Drawing.Size(75, 47);
            this.BtnTicket.TabIndex = 14;
            this.BtnTicket.UseVisualStyleBackColor = true;
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnCerrar.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnCerrar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnCerrar.BorderRadius = 0;
            this.BtnCerrar.BorderSize = 0;
            this.BtnCerrar.FlatAppearance.BorderSize = 0;
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrar.ForeColor = System.Drawing.Color.White;
            this.BtnCerrar.Location = new System.Drawing.Point(32, 412);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(150, 40);
            this.BtnCerrar.TabIndex = 16;
            this.BtnCerrar.Text = "Cancelar";
            this.BtnCerrar.TextColor = System.Drawing.Color.White;
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // TxtCliente
            // 
            this.TxtCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCliente.Location = new System.Drawing.Point(226, 146);
            this.TxtCliente.Name = "TxtCliente";
            this.TxtCliente.Size = new System.Drawing.Size(250, 36);
            this.TxtCliente.TabIndex = 17;
            this.TxtCliente.TextChanged += new System.EventHandler(this.TxtCliente_TextChanged);
            // 
            // FrmPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(54)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(514, 506);
            this.Controls.Add(this.TxtCliente);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.BtnTicket);
            this.Controls.Add(this.BtnEfectivo);
            this.Controls.Add(this.BtnVisa);
            this.Controls.Add(this.BtnConfirmar);
            this.Controls.Add(this.RdbTicket);
            this.Controls.Add(this.RdbEfectivo);
            this.Controls.Add(this.RdbTarjeta);
            this.Controls.Add(this.TxtDevuelto);
            this.Controls.Add(this.TxtImporte);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.LblImporte);
            this.Name = "FrmPago";
            this.Text = "FrmPago";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPago_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel LblImporte;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private RJCodeAdvance.RJControls.RJTextBox TxtImporte;
        private RJCodeAdvance.RJControls.RJTextBox TxtDevuelto;
        private RJCodeAdvance.RJControls.RJRadioButton RdbTarjeta;
        private RJCodeAdvance.RJControls.RJRadioButton RdbEfectivo;
        private RJCodeAdvance.RJControls.RJRadioButton RdbTicket;
        private RJCodeAdvance.RJControls.RJButton BtnConfirmar;
        private FontAwesome.Sharp.IconButton BtnVisa;
        private FontAwesome.Sharp.IconButton BtnEfectivo;
        private FontAwesome.Sharp.IconButton BtnTicket;
        private RJCodeAdvance.RJControls.RJButton BtnCerrar;
        private System.Windows.Forms.TextBox TxtCliente;
    }
}