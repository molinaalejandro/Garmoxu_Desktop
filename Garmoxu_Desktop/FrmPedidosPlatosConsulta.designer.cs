
namespace Garmoxu_Project
{
    partial class FrmPedidosPlatosConsulta
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
            this.PnlBusqueda = new System.Windows.Forms.TableLayoutPanel();
            this.BtnBuscar = new RJCodeAdvance.RJControls.RJButton();
            this.PnlCalendar = new System.Windows.Forms.Panel();
            this.TxtNombre = new RJCodeAdvance.RJControls.RJTextBox();
            this.ChkNombrePlato = new MaterialSkin.Controls.MaterialCheckBox();
            this.PnlTipo = new System.Windows.Forms.Panel();
            this.CboCategoria = new System.Windows.Forms.ComboBox();
            this.ChkCategoriaPlato = new MaterialSkin.Controls.MaterialCheckBox();
            this.PnlTelefono = new System.Windows.Forms.Panel();
            this.TglDisponibilidad = new RJCodeAdvance.RJControls.RJToggleButton();
            this.LblDisponibilidad = new MaterialSkin.Controls.MaterialLabel();
            this.LstPlatos = new System.Windows.Forms.ListView();
            this.ImgImagenesPlatos = new System.Windows.Forms.ImageList(this.components);
            this.PnlMain.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.PnlBusqueda.SuspendLayout();
            this.PnlCalendar.SuspendLayout();
            this.PnlTipo.SuspendLayout();
            this.PnlTelefono.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlMain
            // 
            this.PnlMain.ColumnCount = 1;
            this.PnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PnlMain.Controls.Add(this.tableLayoutPanel1, 0, 2);
            this.PnlMain.Controls.Add(this.PnlBusqueda, 0, 0);
            this.PnlMain.Controls.Add(this.LstPlatos, 0, 1);
            this.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlMain.Location = new System.Drawing.Point(0, 0);
            this.PnlMain.Margin = new System.Windows.Forms.Padding(4);
            this.PnlMain.Name = "PnlMain";
            this.PnlMain.Padding = new System.Windows.Forms.Padding(27, 25, 27, 25);
            this.PnlMain.RowCount = 3;
            this.PnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.PnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.PnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.PnlMain.Size = new System.Drawing.Size(1085, 608);
            this.PnlMain.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.BtnCerrar, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(31, 512);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1023, 67);
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
            this.BtnCerrar.Size = new System.Drawing.Size(333, 34);
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
            this.PnlBusqueda.Size = new System.Drawing.Size(1023, 54);
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
            this.BtnBuscar.Location = new System.Drawing.Point(870, 4);
            this.BtnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(149, 46);
            this.BtnBuscar.TabIndex = 0;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.TextColor = System.Drawing.Color.White;
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // PnlCalendar
            // 
            this.PnlCalendar.Controls.Add(this.TxtNombre);
            this.PnlCalendar.Controls.Add(this.ChkNombrePlato);
            this.PnlCalendar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlCalendar.Location = new System.Drawing.Point(4, 4);
            this.PnlCalendar.Margin = new System.Windows.Forms.Padding(4);
            this.PnlCalendar.Name = "PnlCalendar";
            this.PnlCalendar.Size = new System.Drawing.Size(298, 46);
            this.PnlCalendar.TabIndex = 9;
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
            this.TxtNombre.Location = new System.Drawing.Point(52, 5);
            this.TxtNombre.Margin = new System.Windows.Forms.Padding(5);
            this.TxtNombre.Multiline = false;
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.TxtNombre.PasswordChar = false;
            this.TxtNombre.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TxtNombre.PlaceholderText = "";
            this.TxtNombre.Size = new System.Drawing.Size(240, 39);
            this.TxtNombre.TabIndex = 8;
            this.TxtNombre.Texts = "Nombre";
            this.TxtNombre.UnderlinedStyle = false;
            this.TxtNombre._TextChanged += new System.EventHandler(this.TxtNombre__TextChanged);
            this.TxtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombre_KeyPress);
            // 
            // ChkNombrePlato
            // 
            this.ChkNombrePlato.AutoSize = true;
            this.ChkNombrePlato.Depth = 0;
            this.ChkNombrePlato.Font = new System.Drawing.Font("Roboto", 10F);
            this.ChkNombrePlato.Location = new System.Drawing.Point(12, 6);
            this.ChkNombrePlato.Margin = new System.Windows.Forms.Padding(0);
            this.ChkNombrePlato.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ChkNombrePlato.MouseState = MaterialSkin.MouseState.HOVER;
            this.ChkNombrePlato.Name = "ChkNombrePlato";
            this.ChkNombrePlato.Ripple = true;
            this.ChkNombrePlato.Size = new System.Drawing.Size(26, 30);
            this.ChkNombrePlato.TabIndex = 7;
            this.ChkNombrePlato.UseVisualStyleBackColor = true;
            // 
            // PnlTipo
            // 
            this.PnlTipo.Controls.Add(this.CboCategoria);
            this.PnlTipo.Controls.Add(this.ChkCategoriaPlato);
            this.PnlTipo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlTipo.Location = new System.Drawing.Point(310, 4);
            this.PnlTipo.Margin = new System.Windows.Forms.Padding(4);
            this.PnlTipo.Name = "PnlTipo";
            this.PnlTipo.Size = new System.Drawing.Size(257, 46);
            this.PnlTipo.TabIndex = 10;
            // 
            // CboCategoria
            // 
            this.CboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboCategoria.FormattingEnabled = true;
            this.CboCategoria.Location = new System.Drawing.Point(64, 12);
            this.CboCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.CboCategoria.Name = "CboCategoria";
            this.CboCategoria.Size = new System.Drawing.Size(188, 24);
            this.CboCategoria.TabIndex = 1;
            this.CboCategoria.SelectedIndexChanged += new System.EventHandler(this.CboCategoria_SelectedIndexChanged);
            // 
            // ChkCategoriaPlato
            // 
            this.ChkCategoriaPlato.AutoSize = true;
            this.ChkCategoriaPlato.Depth = 0;
            this.ChkCategoriaPlato.Font = new System.Drawing.Font("Roboto", 10F);
            this.ChkCategoriaPlato.Location = new System.Drawing.Point(12, 6);
            this.ChkCategoriaPlato.Margin = new System.Windows.Forms.Padding(0);
            this.ChkCategoriaPlato.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ChkCategoriaPlato.MouseState = MaterialSkin.MouseState.HOVER;
            this.ChkCategoriaPlato.Name = "ChkCategoriaPlato";
            this.ChkCategoriaPlato.Ripple = true;
            this.ChkCategoriaPlato.Size = new System.Drawing.Size(26, 30);
            this.ChkCategoriaPlato.TabIndex = 0;
            this.ChkCategoriaPlato.UseVisualStyleBackColor = true;
            // 
            // PnlTelefono
            // 
            this.PnlTelefono.Controls.Add(this.TglDisponibilidad);
            this.PnlTelefono.Controls.Add(this.LblDisponibilidad);
            this.PnlTelefono.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlTelefono.Location = new System.Drawing.Point(575, 4);
            this.PnlTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.PnlTelefono.Name = "PnlTelefono";
            this.PnlTelefono.Size = new System.Drawing.Size(257, 46);
            this.PnlTelefono.TabIndex = 11;
            // 
            // TglDisponibilidad
            // 
            this.TglDisponibilidad.AutoSize = true;
            this.TglDisponibilidad.Checked = true;
            this.TglDisponibilidad.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TglDisponibilidad.Location = new System.Drawing.Point(16, 11);
            this.TglDisponibilidad.Margin = new System.Windows.Forms.Padding(4);
            this.TglDisponibilidad.MinimumSize = new System.Drawing.Size(60, 27);
            this.TglDisponibilidad.Name = "TglDisponibilidad";
            this.TglDisponibilidad.OffBackColor = System.Drawing.Color.Gray;
            this.TglDisponibilidad.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.TglDisponibilidad.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.TglDisponibilidad.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.TglDisponibilidad.Size = new System.Drawing.Size(60, 27);
            this.TglDisponibilidad.TabIndex = 2;
            this.TglDisponibilidad.UseVisualStyleBackColor = true;
            // 
            // LblDisponibilidad
            // 
            this.LblDisponibilidad.AutoSize = true;
            this.LblDisponibilidad.Depth = 0;
            this.LblDisponibilidad.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblDisponibilidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblDisponibilidad.Location = new System.Drawing.Point(84, 11);
            this.LblDisponibilidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblDisponibilidad.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblDisponibilidad.Name = "LblDisponibilidad";
            this.LblDisponibilidad.Size = new System.Drawing.Size(132, 24);
            this.LblDisponibilidad.TabIndex = 1;
            this.LblDisponibilidad.Text = "Disponibilidad";
            // 
            // LstPlatos
            // 
            this.LstPlatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LstPlatos.HideSelection = false;
            this.LstPlatos.LargeImageList = this.ImgImagenesPlatos;
            this.LstPlatos.Location = new System.Drawing.Point(31, 91);
            this.LstPlatos.Margin = new System.Windows.Forms.Padding(4);
            this.LstPlatos.MultiSelect = false;
            this.LstPlatos.Name = "LstPlatos";
            this.LstPlatos.Size = new System.Drawing.Size(1023, 413);
            this.LstPlatos.TabIndex = 3;
            this.LstPlatos.UseCompatibleStateImageBehavior = false;
            this.LstPlatos.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LstPlatos_MouseDoubleClick);
            // 
            // ImgImagenesPlatos
            // 
            this.ImgImagenesPlatos.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ImgImagenesPlatos.ImageSize = new System.Drawing.Size(128, 128);
            this.ImgImagenesPlatos.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // FrmPedidosPlatosConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(54)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(1085, 608);
            this.Controls.Add(this.PnlMain);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmPedidosPlatosConsulta";
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel PnlMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private RJCodeAdvance.RJControls.RJButton BtnCerrar;
        private System.Windows.Forms.TableLayoutPanel PnlBusqueda;
        private RJCodeAdvance.RJControls.RJButton BtnBuscar;
        private System.Windows.Forms.Panel PnlCalendar;
        private MaterialSkin.Controls.MaterialCheckBox ChkNombrePlato;
        private System.Windows.Forms.Panel PnlTipo;
        private MaterialSkin.Controls.MaterialCheckBox ChkCategoriaPlato;
        private System.Windows.Forms.Panel PnlTelefono;
        private RJCodeAdvance.RJControls.RJTextBox TxtNombre;
        private MaterialSkin.Controls.MaterialLabel LblDisponibilidad;
        private System.Windows.Forms.ListView LstPlatos;
        private System.Windows.Forms.ImageList ImgImagenesPlatos;
        private System.Windows.Forms.ComboBox CboCategoria;
        private RJCodeAdvance.RJControls.RJToggleButton TglDisponibilidad;
    }
}
