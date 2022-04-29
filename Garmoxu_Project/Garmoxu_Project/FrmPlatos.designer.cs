namespace Garmoxu_Project
{
    partial class FrmPlatos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PnlMain = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnCerrar = new RJCodeAdvance.RJControls.RJButton();
            this.PnlBusqueda = new System.Windows.Forms.TableLayoutPanel();
            this.BtnBuscar = new RJCodeAdvance.RJControls.RJButton();
            this.PnlCalendar = new System.Windows.Forms.Panel();
            this.ChkCalendar = new MaterialSkin.Controls.MaterialCheckBox();
            this.PnlTipo = new System.Windows.Forms.Panel();
            this.ChkTipo = new MaterialSkin.Controls.MaterialCheckBox();
            this.PnlTelefono = new System.Windows.Forms.Panel();
            this.ChkTelefono = new MaterialSkin.Controls.MaterialCheckBox();
            this.DtgPlatos = new System.Windows.Forms.DataGridView();
            this.ClnIdPlato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnPrecioSinIva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnPrecioConIva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnAlergenos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnDisponibilidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtNombre = new RJCodeAdvance.RJControls.RJTextBox();
            this.TxtIdPlato = new RJCodeAdvance.RJControls.RJTextBox();
            this.LblDisponibilidad = new MaterialSkin.Controls.MaterialLabel();
            this.PnlMain.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.PnlBusqueda.SuspendLayout();
            this.PnlCalendar.SuspendLayout();
            this.PnlTipo.SuspendLayout();
            this.PnlTelefono.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgPlatos)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlMain
            // 
            this.PnlMain.ColumnCount = 1;
            this.PnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PnlMain.Controls.Add(this.tableLayoutPanel1, 0, 2);
            this.PnlMain.Controls.Add(this.PnlBusqueda, 0, 0);
            this.PnlMain.Controls.Add(this.DtgPlatos, 0, 1);
            this.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlMain.Location = new System.Drawing.Point(0, 0);
            this.PnlMain.Name = "PnlMain";
            this.PnlMain.Padding = new System.Windows.Forms.Padding(20);
            this.PnlMain.RowCount = 3;
            this.PnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.PnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.PnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.PnlMain.Size = new System.Drawing.Size(814, 508);
            this.PnlMain.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.Controls.Add(this.BtnCerrar, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(23, 428);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(768, 57);
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
            this.BtnCerrar.Location = new System.Drawing.Point(3, 3);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(186, 40);
            this.BtnCerrar.TabIndex = 0;
            this.BtnCerrar.Text = "Cerrar";
            this.BtnCerrar.TextColor = System.Drawing.Color.White;
            this.BtnCerrar.UseVisualStyleBackColor = false;
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
            this.PnlBusqueda.Location = new System.Drawing.Point(23, 23);
            this.PnlBusqueda.Name = "PnlBusqueda";
            this.PnlBusqueda.RowCount = 1;
            this.PnlBusqueda.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PnlBusqueda.Size = new System.Drawing.Size(768, 44);
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
            this.BtnBuscar.Location = new System.Drawing.Point(654, 3);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(111, 38);
            this.BtnBuscar.TabIndex = 0;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.TextColor = System.Drawing.Color.White;
            this.BtnBuscar.UseVisualStyleBackColor = false;
            // 
            // PnlCalendar
            // 
            this.PnlCalendar.Controls.Add(this.TxtNombre);
            this.PnlCalendar.Controls.Add(this.ChkCalendar);
            this.PnlCalendar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlCalendar.Location = new System.Drawing.Point(3, 3);
            this.PnlCalendar.Name = "PnlCalendar";
            this.PnlCalendar.Size = new System.Drawing.Size(224, 38);
            this.PnlCalendar.TabIndex = 9;
            // 
            // ChkCalendar
            // 
            this.ChkCalendar.AutoSize = true;
            this.ChkCalendar.Depth = 0;
            this.ChkCalendar.Font = new System.Drawing.Font("Roboto", 10F);
            this.ChkCalendar.Location = new System.Drawing.Point(9, 5);
            this.ChkCalendar.Margin = new System.Windows.Forms.Padding(0);
            this.ChkCalendar.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ChkCalendar.MouseState = MaterialSkin.MouseState.HOVER;
            this.ChkCalendar.Name = "ChkCalendar";
            this.ChkCalendar.Ripple = true;
            this.ChkCalendar.Size = new System.Drawing.Size(26, 30);
            this.ChkCalendar.TabIndex = 7;
            this.ChkCalendar.UseVisualStyleBackColor = true;
            // 
            // PnlTipo
            // 
            this.PnlTipo.Controls.Add(this.TxtIdPlato);
            this.PnlTipo.Controls.Add(this.ChkTipo);
            this.PnlTipo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlTipo.Location = new System.Drawing.Point(233, 3);
            this.PnlTipo.Name = "PnlTipo";
            this.PnlTipo.Size = new System.Drawing.Size(193, 38);
            this.PnlTipo.TabIndex = 10;
            // 
            // ChkTipo
            // 
            this.ChkTipo.AutoSize = true;
            this.ChkTipo.Depth = 0;
            this.ChkTipo.Font = new System.Drawing.Font("Roboto", 10F);
            this.ChkTipo.Location = new System.Drawing.Point(9, 5);
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
            this.PnlTelefono.Controls.Add(this.LblDisponibilidad);
            this.PnlTelefono.Controls.Add(this.ChkTelefono);
            this.PnlTelefono.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlTelefono.Location = new System.Drawing.Point(432, 3);
            this.PnlTelefono.Name = "PnlTelefono";
            this.PnlTelefono.Size = new System.Drawing.Size(193, 38);
            this.PnlTelefono.TabIndex = 11;
            // 
            // ChkTelefono
            // 
            this.ChkTelefono.AutoSize = true;
            this.ChkTelefono.Depth = 0;
            this.ChkTelefono.Font = new System.Drawing.Font("Roboto", 10F);
            this.ChkTelefono.Location = new System.Drawing.Point(4, 5);
            this.ChkTelefono.Margin = new System.Windows.Forms.Padding(0);
            this.ChkTelefono.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ChkTelefono.MouseState = MaterialSkin.MouseState.HOVER;
            this.ChkTelefono.Name = "ChkTelefono";
            this.ChkTelefono.Ripple = true;
            this.ChkTelefono.Size = new System.Drawing.Size(26, 30);
            this.ChkTelefono.TabIndex = 0;
            this.ChkTelefono.UseVisualStyleBackColor = true;
            // 
            // DtgPlatos
            // 
            this.DtgPlatos.AllowUserToAddRows = false;
            this.DtgPlatos.AllowUserToDeleteRows = false;
            this.DtgPlatos.AllowUserToOrderColumns = true;
            this.DtgPlatos.AllowUserToResizeRows = false;
            this.DtgPlatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DtgPlatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtgPlatos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(54)))), ((int)(((byte)(58)))));
            this.DtgPlatos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DtgPlatos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(41)))), ((int)(((byte)(83)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DtgPlatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DtgPlatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DtgPlatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClnIdPlato,
            this.ClnNombre,
            this.ClnDescripcion,
            this.ClnPrecioSinIva,
            this.ClnPrecioConIva,
            this.ClnAlergenos,
            this.ClnDisponibilidad});
            this.DtgPlatos.EnableHeadersVisualStyles = false;
            this.DtgPlatos.GridColor = System.Drawing.Color.MediumSlateBlue;
            this.DtgPlatos.Location = new System.Drawing.Point(23, 73);
            this.DtgPlatos.Name = "DtgPlatos";
            this.DtgPlatos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DtgPlatos.RowHeadersVisible = false;
            this.DtgPlatos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DtgPlatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DtgPlatos.Size = new System.Drawing.Size(768, 349);
            this.DtgPlatos.TabIndex = 1;
            // 
            // ClnIdPlato
            // 
            this.ClnIdPlato.HeaderText = "IdPlato";
            this.ClnIdPlato.Name = "ClnIdPlato";
            // 
            // ClnNombre
            // 
            this.ClnNombre.HeaderText = "Nombre";
            this.ClnNombre.Name = "ClnNombre";
            // 
            // ClnDescripcion
            // 
            this.ClnDescripcion.HeaderText = "Descripcion";
            this.ClnDescripcion.Name = "ClnDescripcion";
            // 
            // ClnPrecioSinIva
            // 
            this.ClnPrecioSinIva.HeaderText = "PrecioSinIva";
            this.ClnPrecioSinIva.Name = "ClnPrecioSinIva";
            // 
            // ClnPrecioConIva
            // 
            this.ClnPrecioConIva.HeaderText = "PrecioConIva";
            this.ClnPrecioConIva.Name = "ClnPrecioConIva";
            // 
            // ClnAlergenos
            // 
            this.ClnAlergenos.HeaderText = "Alergenos";
            this.ClnAlergenos.Name = "ClnAlergenos";
            // 
            // ClnDisponibilidad
            // 
            this.ClnDisponibilidad.HeaderText = "Disponibilidad";
            this.ClnDisponibilidad.Name = "ClnDisponibilidad";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtNombre.BackColor = System.Drawing.SystemColors.Window;
            this.TxtNombre.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.TxtNombre.BorderFocusColor = System.Drawing.Color.HotPink;
            this.TxtNombre.BorderRadius = 0;
            this.TxtNombre.BorderSize = 2;
            this.TxtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtNombre.Location = new System.Drawing.Point(39, 4);
            this.TxtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.TxtNombre.Multiline = false;
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.TxtNombre.PasswordChar = false;
            this.TxtNombre.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TxtNombre.PlaceholderText = "";
            this.TxtNombre.Size = new System.Drawing.Size(181, 31);
            this.TxtNombre.TabIndex = 8;
            this.TxtNombre.Texts = "Nombre";
            this.TxtNombre.UnderlinedStyle = false;
            // 
            // TxtIdPlato
            // 
            this.TxtIdPlato.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtIdPlato.BackColor = System.Drawing.SystemColors.Window;
            this.TxtIdPlato.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.TxtIdPlato.BorderFocusColor = System.Drawing.Color.HotPink;
            this.TxtIdPlato.BorderRadius = 0;
            this.TxtIdPlato.BorderSize = 2;
            this.TxtIdPlato.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIdPlato.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtIdPlato.Location = new System.Drawing.Point(39, 4);
            this.TxtIdPlato.Margin = new System.Windows.Forms.Padding(4);
            this.TxtIdPlato.Multiline = false;
            this.TxtIdPlato.Name = "TxtIdPlato";
            this.TxtIdPlato.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.TxtIdPlato.PasswordChar = false;
            this.TxtIdPlato.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TxtIdPlato.PlaceholderText = "";
            this.TxtIdPlato.Size = new System.Drawing.Size(150, 31);
            this.TxtIdPlato.TabIndex = 3;
            this.TxtIdPlato.Texts = "IdPlato";
            this.TxtIdPlato.UnderlinedStyle = false;
            // 
            // LblDisponibilidad
            // 
            this.LblDisponibilidad.AutoSize = true;
            this.LblDisponibilidad.Depth = 0;
            this.LblDisponibilidad.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblDisponibilidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblDisponibilidad.Location = new System.Drawing.Point(33, 9);
            this.LblDisponibilidad.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblDisponibilidad.Name = "LblDisponibilidad";
            this.LblDisponibilidad.Size = new System.Drawing.Size(104, 19);
            this.LblDisponibilidad.TabIndex = 1;
            this.LblDisponibilidad.Text = "Disponibilidad";
            // 
            // FrmPlatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(54)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(814, 508);
            this.Controls.Add(this.PnlMain);
            this.Name = "FrmPlatos";
            this.Text = "FrmPlatos";
            this.PnlMain.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.PnlBusqueda.ResumeLayout(false);
            this.PnlCalendar.ResumeLayout(false);
            this.PnlCalendar.PerformLayout();
            this.PnlTipo.ResumeLayout(false);
            this.PnlTipo.PerformLayout();
            this.PnlTelefono.ResumeLayout(false);
            this.PnlTelefono.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgPlatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel PnlMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private RJCodeAdvance.RJControls.RJButton BtnCerrar;
        private System.Windows.Forms.TableLayoutPanel PnlBusqueda;
        private RJCodeAdvance.RJControls.RJButton BtnBuscar;
        private System.Windows.Forms.Panel PnlCalendar;
        private MaterialSkin.Controls.MaterialCheckBox ChkCalendar;
        private System.Windows.Forms.Panel PnlTipo;
        private MaterialSkin.Controls.MaterialCheckBox ChkTipo;
        private System.Windows.Forms.Panel PnlTelefono;
        private MaterialSkin.Controls.MaterialCheckBox ChkTelefono;
        private System.Windows.Forms.DataGridView DtgPlatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnIdPlato;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnPrecioSinIva;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnPrecioConIva;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnAlergenos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnDisponibilidad;
        private RJCodeAdvance.RJControls.RJTextBox TxtNombre;
        private RJCodeAdvance.RJControls.RJTextBox TxtIdPlato;
        private MaterialSkin.Controls.MaterialLabel LblDisponibilidad;
    }
}