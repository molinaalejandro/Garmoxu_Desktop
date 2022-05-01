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
            this.BtnBorrar = new RJCodeAdvance.RJControls.RJButton();
            this.label1 = new System.Windows.Forms.Label();
            this.LblID = new System.Windows.Forms.Label();
            this.LblFecha = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LblHora = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LblTipo = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.LblTlf = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.LblPrecioConIVA = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.LblPrecioSinIVA = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.DtgPlatosPedidos = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioUnitarioSinIVA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioUnitarioConIVA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioFinalSinIVA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioFinalConIVA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DtgPlatosPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnBorrar
            // 
            this.BtnBorrar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnBorrar.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnBorrar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnBorrar.BorderRadius = 0;
            this.BtnBorrar.BorderSize = 0;
            this.BtnBorrar.FlatAppearance.BorderSize = 0;
            this.BtnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBorrar.ForeColor = System.Drawing.Color.White;
            this.BtnBorrar.Location = new System.Drawing.Point(648, 591);
            this.BtnBorrar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnBorrar.Name = "BtnBorrar";
            this.BtnBorrar.Size = new System.Drawing.Size(200, 49);
            this.BtnBorrar.TabIndex = 8;
            this.BtnBorrar.Text = "Eliminar pedido";
            this.BtnBorrar.TextColor = System.Drawing.Color.White;
            this.BtnBorrar.UseVisualStyleBackColor = false;
            this.BtnBorrar.Click += new System.EventHandler(this.BtnBorrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "ID:";
            // 
            // LblID
            // 
            this.LblID.AutoSize = true;
            this.LblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblID.Location = new System.Drawing.Point(121, 9);
            this.LblID.Name = "LblID";
            this.LblID.Size = new System.Drawing.Size(97, 29);
            this.LblID.TabIndex = 10;
            this.LblID.Text = "000000";
            // 
            // LblFecha
            // 
            this.LblFecha.AutoSize = true;
            this.LblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFecha.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblFecha.Location = new System.Drawing.Point(121, 57);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(139, 29);
            this.LblFecha.TabIndex = 12;
            this.LblFecha.Text = "00/00/0000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(12, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 29);
            this.label4.TabIndex = 11;
            this.label4.Text = "Fecha:";
            // 
            // LblHora
            // 
            this.LblHora.AutoSize = true;
            this.LblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHora.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblHora.Location = new System.Drawing.Point(121, 101);
            this.LblHora.Name = "LblHora";
            this.LblHora.Size = new System.Drawing.Size(76, 29);
            this.LblHora.TabIndex = 14;
            this.LblHora.Text = "00:00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(12, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 29);
            this.label6.TabIndex = 13;
            this.label6.Text = "Hora:";
            // 
            // LblTipo
            // 
            this.LblTipo.AutoSize = true;
            this.LblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTipo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblTipo.Location = new System.Drawing.Point(440, 57);
            this.LblTipo.Name = "LblTipo";
            this.LblTipo.Size = new System.Drawing.Size(62, 29);
            this.LblTipo.TabIndex = 16;
            this.LblTipo.Text = "Tipo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(298, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 29);
            this.label8.TabIndex = 15;
            this.label8.Text = "Tipo:";
            // 
            // LblTlf
            // 
            this.LblTlf.AutoSize = true;
            this.LblTlf.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTlf.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblTlf.Location = new System.Drawing.Point(440, 101);
            this.LblTlf.Name = "LblTlf";
            this.LblTlf.Size = new System.Drawing.Size(182, 29);
            this.LblTlf.TabIndex = 18;
            this.LblTlf.Text = "+34000000000";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(298, 101);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(127, 29);
            this.label10.TabIndex = 17;
            this.label10.Text = "Teléfono:";
            // 
            // LblPrecioConIVA
            // 
            this.LblPrecioConIVA.AutoSize = true;
            this.LblPrecioConIVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrecioConIVA.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblPrecioConIVA.Location = new System.Drawing.Point(223, 546);
            this.LblPrecioConIVA.Name = "LblPrecioConIVA";
            this.LblPrecioConIVA.Size = new System.Drawing.Size(104, 29);
            this.LblPrecioConIVA.TabIndex = 20;
            this.LblPrecioConIVA.Text = "000,00€";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(12, 546);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(202, 29);
            this.label12.TabIndex = 19;
            this.label12.Text = "Precio con IVA:";
            // 
            // LblPrecioSinIVA
            // 
            this.LblPrecioSinIVA.AutoSize = true;
            this.LblPrecioSinIVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrecioSinIVA.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblPrecioSinIVA.Location = new System.Drawing.Point(223, 596);
            this.LblPrecioSinIVA.Name = "LblPrecioSinIVA";
            this.LblPrecioSinIVA.Size = new System.Drawing.Size(104, 29);
            this.LblPrecioSinIVA.TabIndex = 22;
            this.LblPrecioSinIVA.Text = "000,00€";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label14.Location = new System.Drawing.Point(12, 596);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(194, 29);
            this.label14.TabIndex = 21;
            this.label14.Text = "Precio sin IVA:";
            // 
            // DtgPlatosPedidos
            // 
            this.DtgPlatosPedidos.AllowUserToAddRows = false;
            this.DtgPlatosPedidos.AllowUserToDeleteRows = false;
            this.DtgPlatosPedidos.AllowUserToOrderColumns = true;
            this.DtgPlatosPedidos.AllowUserToResizeRows = false;
            this.DtgPlatosPedidos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DtgPlatosPedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtgPlatosPedidos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(54)))), ((int)(((byte)(58)))));
            this.DtgPlatosPedidos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DtgPlatosPedidos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(41)))), ((int)(((byte)(83)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DtgPlatosPedidos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DtgPlatosPedidos.ColumnHeadersHeight = 29;
            this.DtgPlatosPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DtgPlatosPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.PrecioUnitarioSinIVA,
            this.PrecioUnitarioConIVA,
            this.Cantidad,
            this.PrecioFinalSinIVA,
            this.PrecioFinalConIVA});
            this.DtgPlatosPedidos.EnableHeadersVisualStyles = false;
            this.DtgPlatosPedidos.GridColor = System.Drawing.Color.MediumSlateBlue;
            this.DtgPlatosPedidos.Location = new System.Drawing.Point(17, 134);
            this.DtgPlatosPedidos.Margin = new System.Windows.Forms.Padding(4);
            this.DtgPlatosPedidos.Name = "DtgPlatosPedidos";
            this.DtgPlatosPedidos.ReadOnly = true;
            this.DtgPlatosPedidos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DtgPlatosPedidos.RowHeadersVisible = false;
            this.DtgPlatosPedidos.RowHeadersWidth = 51;
            this.DtgPlatosPedidos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DtgPlatosPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DtgPlatosPedidos.Size = new System.Drawing.Size(831, 367);
            this.DtgPlatosPedidos.TabIndex = 23;
            // 
            // Codigo
            // 
            this.Codigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Codigo.HeaderText = "Código";
            this.Codigo.MinimumWidth = 6;
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // PrecioUnitarioSinIVA
            // 
            this.PrecioUnitarioSinIVA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PrecioUnitarioSinIVA.HeaderText = "Precio unitario sin IVA";
            this.PrecioUnitarioSinIVA.MinimumWidth = 6;
            this.PrecioUnitarioSinIVA.Name = "PrecioUnitarioSinIVA";
            this.PrecioUnitarioSinIVA.ReadOnly = true;
            // 
            // PrecioUnitarioConIVA
            // 
            this.PrecioUnitarioConIVA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PrecioUnitarioConIVA.HeaderText = "Precio unitario con IVA";
            this.PrecioUnitarioConIVA.MinimumWidth = 6;
            this.PrecioUnitarioConIVA.Name = "PrecioUnitarioConIVA";
            this.PrecioUnitarioConIVA.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // PrecioFinalSinIVA
            // 
            this.PrecioFinalSinIVA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PrecioFinalSinIVA.HeaderText = "Precio final sin IVA";
            this.PrecioFinalSinIVA.MinimumWidth = 6;
            this.PrecioFinalSinIVA.Name = "PrecioFinalSinIVA";
            this.PrecioFinalSinIVA.ReadOnly = true;
            // 
            // PrecioFinalConIVA
            // 
            this.PrecioFinalConIVA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PrecioFinalConIVA.HeaderText = "Precio final con IVA";
            this.PrecioFinalConIVA.MinimumWidth = 6;
            this.PrecioFinalConIVA.Name = "PrecioFinalConIVA";
            this.PrecioFinalConIVA.ReadOnly = true;
            // 
            // FrmHistorialPedidosDetalles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(54)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(864, 655);
            this.Controls.Add(this.DtgPlatosPedidos);
            this.Controls.Add(this.LblPrecioSinIVA);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.LblPrecioConIVA);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.LblTlf);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.LblTipo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.LblHora);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LblFecha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LblID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnBorrar);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmHistorialPedidosDetalles";
            this.Text = "FrmHistorialPedidosDetalles";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmHistorialPedidosDetalles_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.DtgPlatosPedidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private RJCodeAdvance.RJControls.RJButton BtnBorrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblID;
        private System.Windows.Forms.Label LblFecha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblHora;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LblTipo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label LblTlf;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label LblPrecioConIVA;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label LblPrecioSinIVA;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView DtgPlatosPedidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioUnitarioSinIVA;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioUnitarioConIVA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioFinalSinIVA;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioFinalConIVA;
    }
}