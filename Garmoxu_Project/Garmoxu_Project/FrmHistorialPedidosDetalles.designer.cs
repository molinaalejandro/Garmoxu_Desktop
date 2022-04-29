namespace Garmoxu_Project
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
            this.LblIdPedido = new MaterialSkin.Controls.MaterialLabel();
            this.LblFecha = new MaterialSkin.Controls.MaterialLabel();
            this.LblHora = new MaterialSkin.Controls.MaterialLabel();
            this.LblTelefono = new MaterialSkin.Controls.MaterialLabel();
            this.LblTipo = new MaterialSkin.Controls.MaterialLabel();
            this.LblPrecioSinIva = new MaterialSkin.Controls.MaterialLabel();
            this.LblPrecioConIva = new MaterialSkin.Controls.MaterialLabel();
            this.DtgReservas = new System.Windows.Forms.DataGridView();
            this.ClnNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnPrecioUnitarioConIva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnTotalConIva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DtgReservas)).BeginInit();
            this.SuspendLayout();
            // 
            // LblIdPedido
            // 
            this.LblIdPedido.AutoSize = true;
            this.LblIdPedido.Depth = 0;
            this.LblIdPedido.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblIdPedido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblIdPedido.Location = new System.Drawing.Point(16, 10);
            this.LblIdPedido.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblIdPedido.Name = "LblIdPedido";
            this.LblIdPedido.Size = new System.Drawing.Size(79, 19);
            this.LblIdPedido.TabIndex = 0;
            this.LblIdPedido.Text = "Id Pedido: ";
            // 
            // LblFecha
            // 
            this.LblFecha.AutoSize = true;
            this.LblFecha.Depth = 0;
            this.LblFecha.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblFecha.Location = new System.Drawing.Point(16, 46);
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
            this.LblHora.Location = new System.Drawing.Point(171, 46);
            this.LblHora.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblHora.Name = "LblHora";
            this.LblHora.Size = new System.Drawing.Size(42, 19);
            this.LblHora.TabIndex = 2;
            this.LblHora.Text = "Hora";
            // 
            // LblTelefono
            // 
            this.LblTelefono.AutoSize = true;
            this.LblTelefono.Depth = 0;
            this.LblTelefono.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblTelefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblTelefono.Location = new System.Drawing.Point(171, 86);
            this.LblTelefono.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblTelefono.Name = "LblTelefono";
            this.LblTelefono.Size = new System.Drawing.Size(73, 19);
            this.LblTelefono.TabIndex = 3;
            this.LblTelefono.Text = "Telefono:";
            // 
            // LblTipo
            // 
            this.LblTipo.AutoSize = true;
            this.LblTipo.Depth = 0;
            this.LblTipo.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblTipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblTipo.Location = new System.Drawing.Point(16, 86);
            this.LblTipo.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblTipo.Name = "LblTipo";
            this.LblTipo.Size = new System.Drawing.Size(47, 19);
            this.LblTipo.TabIndex = 4;
            this.LblTipo.Text = "Tipo: ";
            // 
            // LblPrecioSinIva
            // 
            this.LblPrecioSinIva.AutoSize = true;
            this.LblPrecioSinIva.Depth = 0;
            this.LblPrecioSinIva.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblPrecioSinIva.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblPrecioSinIva.Location = new System.Drawing.Point(14, 448);
            this.LblPrecioSinIva.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblPrecioSinIva.Name = "LblPrecioSinIva";
            this.LblPrecioSinIva.Size = new System.Drawing.Size(109, 19);
            this.LblPrecioSinIva.TabIndex = 5;
            this.LblPrecioSinIva.Text = "Precio Sin IVA:";
            // 
            // LblPrecioConIva
            // 
            this.LblPrecioConIva.AutoSize = true;
            this.LblPrecioConIva.Depth = 0;
            this.LblPrecioConIva.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblPrecioConIva.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblPrecioConIva.Location = new System.Drawing.Point(205, 448);
            this.LblPrecioConIva.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblPrecioConIva.Name = "LblPrecioConIva";
            this.LblPrecioConIva.Size = new System.Drawing.Size(115, 19);
            this.LblPrecioConIva.TabIndex = 6;
            this.LblPrecioConIva.Text = "Precio Con IVA:";
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
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DtgReservas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DtgReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DtgReservas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClnNombre,
            this.ClnPrecioUnitarioConIva,
            this.ClnCantidad,
            this.ClnTotalConIva});
            this.DtgReservas.EnableHeadersVisualStyles = false;
            this.DtgReservas.GridColor = System.Drawing.Color.MediumSlateBlue;
            this.DtgReservas.Location = new System.Drawing.Point(12, 122);
            this.DtgReservas.Name = "DtgReservas";
            this.DtgReservas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DtgReservas.RowHeadersVisible = false;
            this.DtgReservas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DtgReservas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DtgReservas.Size = new System.Drawing.Size(597, 300);
            this.DtgReservas.TabIndex = 7;
            // 
            // ClnNombre
            // 
            this.ClnNombre.HeaderText = "Nombre";
            this.ClnNombre.Name = "ClnNombre";
            // 
            // ClnPrecioUnitarioConIva
            // 
            this.ClnPrecioUnitarioConIva.HeaderText = "PrecioUnitarioConIVA";
            this.ClnPrecioUnitarioConIva.Name = "ClnPrecioUnitarioConIva";
            // 
            // ClnCantidad
            // 
            this.ClnCantidad.HeaderText = "Cantidad";
            this.ClnCantidad.Name = "ClnCantidad";
            // 
            // ClnTotalConIva
            // 
            this.ClnTotalConIva.HeaderText = "PrecioTotalConIVA";
            this.ClnTotalConIva.Name = "ClnTotalConIva";
            // 
            // FrmHistorialPedidosDetalles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(54)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(648, 532);
            this.Controls.Add(this.DtgReservas);
            this.Controls.Add(this.LblPrecioConIva);
            this.Controls.Add(this.LblPrecioSinIva);
            this.Controls.Add(this.LblTipo);
            this.Controls.Add(this.LblTelefono);
            this.Controls.Add(this.LblHora);
            this.Controls.Add(this.LblFecha);
            this.Controls.Add(this.LblIdPedido);
            this.Name = "FrmHistorialPedidosDetalles";
            this.Text = "FrmHistorialPedidosDetalles";
            ((System.ComponentModel.ISupportInitialize)(this.DtgReservas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel LblIdPedido;
        private MaterialSkin.Controls.MaterialLabel LblFecha;
        private MaterialSkin.Controls.MaterialLabel LblHora;
        private MaterialSkin.Controls.MaterialLabel LblTelefono;
        private MaterialSkin.Controls.MaterialLabel LblTipo;
        private MaterialSkin.Controls.MaterialLabel LblPrecioSinIva;
        private MaterialSkin.Controls.MaterialLabel LblPrecioConIva;
        private System.Windows.Forms.DataGridView DtgReservas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnPrecioUnitarioConIva;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnTotalConIva;
    }
}