namespace Garmoxu_Project
{
    partial class FrmClientes
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
            this.PnlClientes = new System.Windows.Forms.TableLayoutPanel();
            this.PnlDetalles = new System.Windows.Forms.Panel();
            this.TxtTelefono = new RJCodeAdvance.RJControls.RJTextBox();
            this.TxtDireccion = new RJCodeAdvance.RJControls.RJTextBox();
            this.TxtNombre = new RJCodeAdvance.RJControls.RJTextBox();
            this.rjButton1 = new RJCodeAdvance.RJControls.RJButton();
            this.LblCantidad = new MaterialSkin.Controls.MaterialLabel();
            this.PnlLista = new System.Windows.Forms.Panel();
            this.TxtBuscar = new RJCodeAdvance.RJControls.RJTextBox();
            this.BtnBuscar = new RJCodeAdvance.RJControls.RJButton();
            this.DtgClientes = new System.Windows.Forms.DataGridView();
            this.ClnTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PnlMain.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.PnlClientes.SuspendLayout();
            this.PnlDetalles.SuspendLayout();
            this.PnlLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlMain
            // 
            this.PnlMain.ColumnCount = 1;
            this.PnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PnlMain.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.PnlMain.Controls.Add(this.PnlClientes, 0, 0);
            this.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlMain.Location = new System.Drawing.Point(0, 0);
            this.PnlMain.Name = "PnlMain";
            this.PnlMain.Padding = new System.Windows.Forms.Padding(20);
            this.PnlMain.RowCount = 2;
            this.PnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.PnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.PnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.PnlMain.Size = new System.Drawing.Size(800, 450);
            this.PnlMain.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.Controls.Add(this.BtnCerrar, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(23, 371);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(754, 56);
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
            this.BtnCerrar.Size = new System.Drawing.Size(182, 40);
            this.BtnCerrar.TabIndex = 0;
            this.BtnCerrar.Text = "Cerrar";
            this.BtnCerrar.TextColor = System.Drawing.Color.White;
            this.BtnCerrar.UseVisualStyleBackColor = false;
            // 
            // PnlClientes
            // 
            this.PnlClientes.ColumnCount = 2;
            this.PnlClientes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.PnlClientes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.PnlClientes.Controls.Add(this.PnlDetalles, 1, 0);
            this.PnlClientes.Controls.Add(this.PnlLista, 0, 0);
            this.PnlClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlClientes.Location = new System.Drawing.Point(23, 23);
            this.PnlClientes.Name = "PnlClientes";
            this.PnlClientes.RowCount = 1;
            this.PnlClientes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PnlClientes.Size = new System.Drawing.Size(754, 342);
            this.PnlClientes.TabIndex = 5;
            // 
            // PnlDetalles
            // 
            this.PnlDetalles.Controls.Add(this.LblCantidad);
            this.PnlDetalles.Controls.Add(this.rjButton1);
            this.PnlDetalles.Controls.Add(this.TxtNombre);
            this.PnlDetalles.Controls.Add(this.TxtDireccion);
            this.PnlDetalles.Controls.Add(this.TxtTelefono);
            this.PnlDetalles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlDetalles.Location = new System.Drawing.Point(304, 3);
            this.PnlDetalles.Name = "PnlDetalles";
            this.PnlDetalles.Size = new System.Drawing.Size(447, 336);
            this.PnlDetalles.TabIndex = 0;
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
            this.TxtTelefono.Location = new System.Drawing.Point(94, 43);
            this.TxtTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.TxtTelefono.Multiline = false;
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.TxtTelefono.PasswordChar = false;
            this.TxtTelefono.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TxtTelefono.PlaceholderText = "";
            this.TxtTelefono.Size = new System.Drawing.Size(250, 31);
            this.TxtTelefono.TabIndex = 0;
            this.TxtTelefono.Texts = "Telefono";
            this.TxtTelefono.UnderlinedStyle = false;
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.BackColor = System.Drawing.SystemColors.Window;
            this.TxtDireccion.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.TxtDireccion.BorderFocusColor = System.Drawing.Color.HotPink;
            this.TxtDireccion.BorderRadius = 0;
            this.TxtDireccion.BorderSize = 2;
            this.TxtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDireccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtDireccion.Location = new System.Drawing.Point(94, 95);
            this.TxtDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.TxtDireccion.Multiline = true;
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.TxtDireccion.PasswordChar = false;
            this.TxtDireccion.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TxtDireccion.PlaceholderText = "";
            this.TxtDireccion.Size = new System.Drawing.Size(250, 73);
            this.TxtDireccion.TabIndex = 1;
            this.TxtDireccion.Texts = "Direccion";
            this.TxtDireccion.UnderlinedStyle = false;
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
            this.TxtNombre.Location = new System.Drawing.Point(94, 192);
            this.TxtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.TxtNombre.Multiline = false;
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.TxtNombre.PasswordChar = false;
            this.TxtNombre.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TxtNombre.PlaceholderText = "";
            this.TxtNombre.Size = new System.Drawing.Size(250, 31);
            this.TxtNombre.TabIndex = 2;
            this.TxtNombre.Texts = "Nombre";
            this.TxtNombre.UnderlinedStyle = false;
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton1.BorderRadius = 0;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Location = new System.Drawing.Point(294, 293);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(150, 40);
            this.rjButton1.TabIndex = 4;
            this.rjButton1.Text = "rjButton1";
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            // 
            // LblCantidad
            // 
            this.LblCantidad.AutoSize = true;
            this.LblCantidad.Depth = 0;
            this.LblCantidad.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblCantidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblCantidad.Location = new System.Drawing.Point(94, 246);
            this.LblCantidad.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblCantidad.Name = "LblCantidad";
            this.LblCantidad.Size = new System.Drawing.Size(142, 19);
            this.LblCantidad.TabIndex = 5;
            this.LblCantidad.Text = "Cantidad de Pedido:";
            // 
            // PnlLista
            // 
            this.PnlLista.Controls.Add(this.DtgClientes);
            this.PnlLista.Controls.Add(this.BtnBuscar);
            this.PnlLista.Controls.Add(this.TxtBuscar);
            this.PnlLista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlLista.Location = new System.Drawing.Point(3, 3);
            this.PnlLista.Name = "PnlLista";
            this.PnlLista.Size = new System.Drawing.Size(295, 336);
            this.PnlLista.TabIndex = 1;
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.BackColor = System.Drawing.SystemColors.Window;
            this.TxtBuscar.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.TxtBuscar.BorderFocusColor = System.Drawing.Color.HotPink;
            this.TxtBuscar.BorderRadius = 0;
            this.TxtBuscar.BorderSize = 2;
            this.TxtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtBuscar.Location = new System.Drawing.Point(4, 4);
            this.TxtBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.TxtBuscar.Multiline = false;
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.TxtBuscar.PasswordChar = false;
            this.TxtBuscar.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TxtBuscar.PlaceholderText = "";
            this.TxtBuscar.Size = new System.Drawing.Size(191, 31);
            this.TxtBuscar.TabIndex = 0;
            this.TxtBuscar.Texts = "";
            this.TxtBuscar.UnderlinedStyle = false;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnBuscar.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnBuscar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnBuscar.BorderRadius = 0;
            this.BtnBuscar.BorderSize = 0;
            this.BtnBuscar.FlatAppearance.BorderSize = 0;
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscar.ForeColor = System.Drawing.Color.White;
            this.BtnBuscar.Location = new System.Drawing.Point(202, 4);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(90, 31);
            this.BtnBuscar.TabIndex = 1;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.TextColor = System.Drawing.Color.White;
            this.BtnBuscar.UseVisualStyleBackColor = false;
            // 
            // DtgClientes
            // 
            this.DtgClientes.AllowUserToAddRows = false;
            this.DtgClientes.AllowUserToDeleteRows = false;
            this.DtgClientes.AllowUserToOrderColumns = true;
            this.DtgClientes.AllowUserToResizeRows = false;
            this.DtgClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DtgClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtgClientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(54)))), ((int)(((byte)(58)))));
            this.DtgClientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DtgClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(41)))), ((int)(((byte)(83)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DtgClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DtgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DtgClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClnTelefono});
            this.DtgClientes.EnableHeadersVisualStyles = false;
            this.DtgClientes.GridColor = System.Drawing.Color.MediumSlateBlue;
            this.DtgClientes.Location = new System.Drawing.Point(5, 43);
            this.DtgClientes.Name = "DtgClientes";
            this.DtgClientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DtgClientes.RowHeadersVisible = false;
            this.DtgClientes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DtgClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DtgClientes.Size = new System.Drawing.Size(287, 293);
            this.DtgClientes.TabIndex = 2;
            // 
            // ClnTelefono
            // 
            this.ClnTelefono.HeaderText = "Telefono";
            this.ClnTelefono.Name = "ClnTelefono";
            // 
            // FrmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(54)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PnlMain);
            this.Name = "FrmClientes";
            this.Text = "FrmClientes";
            this.PnlMain.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.PnlClientes.ResumeLayout(false);
            this.PnlDetalles.ResumeLayout(false);
            this.PnlDetalles.PerformLayout();
            this.PnlLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DtgClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel PnlMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private RJCodeAdvance.RJControls.RJButton BtnCerrar;
        private System.Windows.Forms.TableLayoutPanel PnlClientes;
        private System.Windows.Forms.Panel PnlDetalles;
        private MaterialSkin.Controls.MaterialLabel LblCantidad;
        private RJCodeAdvance.RJControls.RJButton rjButton1;
        private RJCodeAdvance.RJControls.RJTextBox TxtNombre;
        private RJCodeAdvance.RJControls.RJTextBox TxtDireccion;
        private RJCodeAdvance.RJControls.RJTextBox TxtTelefono;
        private System.Windows.Forms.Panel PnlLista;
        private RJCodeAdvance.RJControls.RJButton BtnBuscar;
        private RJCodeAdvance.RJControls.RJTextBox TxtBuscar;
        private System.Windows.Forms.DataGridView DtgClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnTelefono;
    }
}