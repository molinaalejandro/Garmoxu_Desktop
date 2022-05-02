
namespace Garmoxu_Project
{
    partial class FrmCategorias
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
            this.components = new System.ComponentModel.Container();
            this.PnlMain = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnCerrar = new RJCodeAdvance.RJControls.RJButton();
            this.BtnNuevo = new RJCodeAdvance.RJControls.RJButton();
            this.BtnEliminar = new RJCodeAdvance.RJControls.RJButton();
            this.PnlBusqueda = new System.Windows.Forms.TableLayoutPanel();
            this.BtnBuscar = new RJCodeAdvance.RJControls.RJButton();
            this.PnlCalendar = new System.Windows.Forms.Panel();
            this.TxtNombre = new RJCodeAdvance.RJControls.RJTextBox();
            this.LstCategorias = new System.Windows.Forms.ListView();
            this.ImgImagenesCateg = new System.Windows.Forms.ImageList(this.components);
            this.PnlMain.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.PnlBusqueda.SuspendLayout();
            this.PnlCalendar.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlMain
            // 
            this.PnlMain.ColumnCount = 1;
            this.PnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PnlMain.Controls.Add(this.tableLayoutPanel1, 0, 2);
            this.PnlMain.Controls.Add(this.PnlBusqueda, 0, 0);
            this.PnlMain.Controls.Add(this.LstCategorias, 0, 1);
            this.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlMain.Location = new System.Drawing.Point(0, 0);
            this.PnlMain.Margin = new System.Windows.Forms.Padding(4);
            this.PnlMain.Name = "PnlMain";
            this.PnlMain.Padding = new System.Windows.Forms.Padding(27, 25, 27, 25);
            this.PnlMain.RowCount = 3;
            this.PnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.PnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.PnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.PnlMain.Size = new System.Drawing.Size(943, 539);
            this.PnlMain.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Controls.Add(this.BtnCerrar, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.BtnNuevo, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.BtnEliminar, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(31, 453);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(881, 57);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnCerrar.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnCerrar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnCerrar.BorderRadius = 0;
            this.BtnCerrar.BorderSize = 0;
            this.BtnCerrar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnCerrar.FlatAppearance.BorderSize = 0;
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCerrar.ForeColor = System.Drawing.Color.White;
            this.BtnCerrar.Location = new System.Drawing.Point(4, 4);
            this.BtnCerrar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(256, 49);
            this.BtnCerrar.TabIndex = 0;
            this.BtnCerrar.Text = "Cerrar";
            this.BtnCerrar.TextColor = System.Drawing.Color.White;
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnNuevo.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnNuevo.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnNuevo.BorderRadius = 0;
            this.BtnNuevo.BorderSize = 0;
            this.BtnNuevo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnNuevo.FlatAppearance.BorderSize = 0;
            this.BtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNuevo.ForeColor = System.Drawing.Color.White;
            this.BtnNuevo.Location = new System.Drawing.Point(620, 4);
            this.BtnNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(257, 49);
            this.BtnNuevo.TabIndex = 2;
            this.BtnNuevo.Text = "Crear categoría nueva";
            this.BtnNuevo.TextColor = System.Drawing.Color.White;
            this.BtnNuevo.UseVisualStyleBackColor = false;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnEliminar.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnEliminar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnEliminar.BorderRadius = 0;
            this.BtnEliminar.BorderSize = 0;
            this.BtnEliminar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnEliminar.Enabled = false;
            this.BtnEliminar.FlatAppearance.BorderSize = 0;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.ForeColor = System.Drawing.Color.White;
            this.BtnEliminar.Location = new System.Drawing.Point(312, 4);
            this.BtnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(256, 49);
            this.BtnEliminar.TabIndex = 1;
            this.BtnEliminar.Text = "Eliminar Categoria";
            this.BtnEliminar.TextColor = System.Drawing.Color.White;
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // PnlBusqueda
            // 
            this.PnlBusqueda.ColumnCount = 3;
            this.PnlBusqueda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.PnlBusqueda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.PnlBusqueda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.PnlBusqueda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.PnlBusqueda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.PnlBusqueda.Controls.Add(this.BtnBuscar, 2, 0);
            this.PnlBusqueda.Controls.Add(this.PnlCalendar, 0, 0);
            this.PnlBusqueda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlBusqueda.Location = new System.Drawing.Point(31, 29);
            this.PnlBusqueda.Margin = new System.Windows.Forms.Padding(4);
            this.PnlBusqueda.Name = "PnlBusqueda";
            this.PnlBusqueda.RowCount = 1;
            this.PnlBusqueda.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PnlBusqueda.Size = new System.Drawing.Size(881, 54);
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
            this.BtnBuscar.Location = new System.Drawing.Point(752, 4);
            this.BtnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(125, 46);
            this.BtnBuscar.TabIndex = 0;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.TextColor = System.Drawing.Color.White;
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // PnlCalendar
            // 
            this.PnlCalendar.Controls.Add(this.TxtNombre);
            this.PnlCalendar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlCalendar.Location = new System.Drawing.Point(4, 4);
            this.PnlCalendar.Margin = new System.Windows.Forms.Padding(4);
            this.PnlCalendar.Name = "PnlCalendar";
            this.PnlCalendar.Size = new System.Drawing.Size(256, 46);
            this.PnlCalendar.TabIndex = 9;
            // 
            // TxtNombre
            // 
            this.TxtNombre.BackColor = System.Drawing.SystemColors.Window;
            this.TxtNombre.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.TxtNombre.BorderFocusColor = System.Drawing.Color.HotPink;
            this.TxtNombre.BorderRadius = 0;
            this.TxtNombre.BorderSize = 2;
            this.TxtNombre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtNombre.Location = new System.Drawing.Point(0, 0);
            this.TxtNombre.Margin = new System.Windows.Forms.Padding(5);
            this.TxtNombre.Multiline = false;
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.TxtNombre.PasswordChar = false;
            this.TxtNombre.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TxtNombre.PlaceholderText = "";
            this.TxtNombre.Size = new System.Drawing.Size(256, 39);
            this.TxtNombre.TabIndex = 8;
            this.TxtNombre.Texts = "Nombre";
            this.TxtNombre.UnderlinedStyle = false;
            this.TxtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombre_KeyPress);
            // 
            // LstCategorias
            // 
            this.LstCategorias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(54)))), ((int)(((byte)(58)))));
            this.LstCategorias.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LstCategorias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LstCategorias.Font = new System.Drawing.Font("Source Sans Pro", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LstCategorias.ForeColor = System.Drawing.Color.White;
            this.LstCategorias.HideSelection = false;
            this.LstCategorias.LargeImageList = this.ImgImagenesCateg;
            this.LstCategorias.Location = new System.Drawing.Point(31, 91);
            this.LstCategorias.Margin = new System.Windows.Forms.Padding(4);
            this.LstCategorias.MultiSelect = false;
            this.LstCategorias.Name = "LstCategorias";
            this.LstCategorias.Size = new System.Drawing.Size(881, 354);
            this.LstCategorias.TabIndex = 3;
            this.LstCategorias.UseCompatibleStateImageBehavior = false;
            this.LstCategorias.SelectedIndexChanged += new System.EventHandler(this.LstCategorias_SelectedIndexChanged);
            this.LstCategorias.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LstCategorias_MouseDoubleClick);
            // 
            // ImgImagenesCateg
            // 
            this.ImgImagenesCateg.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ImgImagenesCateg.ImageSize = new System.Drawing.Size(128, 128);
            this.ImgImagenesCateg.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // FrmCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(54)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(943, 539);
            this.Controls.Add(this.PnlMain);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmCategoria";
            this.Text = "FrmCategoria";
            this.EnabledChanged += new System.EventHandler(this.FrmCategoria_EnabledChanged);
            this.PnlMain.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.PnlBusqueda.ResumeLayout(false);
            this.PnlCalendar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel PnlMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private RJCodeAdvance.RJControls.RJButton BtnCerrar;
        private RJCodeAdvance.RJControls.RJButton BtnNuevo;
        private RJCodeAdvance.RJControls.RJButton BtnEliminar;
        private System.Windows.Forms.TableLayoutPanel PnlBusqueda;
        private RJCodeAdvance.RJControls.RJButton BtnBuscar;
        private System.Windows.Forms.Panel PnlCalendar;
        private RJCodeAdvance.RJControls.RJTextBox TxtNombre;
        private System.Windows.Forms.ListView LstCategorias;
        private System.Windows.Forms.ImageList ImgImagenesCateg;
    }
}