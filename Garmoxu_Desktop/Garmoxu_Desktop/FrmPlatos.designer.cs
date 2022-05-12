namespace Garmoxu_Desktop
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPlatos));
            this.ImgImagenesPlatos = new System.Windows.Forms.ImageList(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.TgbNombre = new RJCodeAdvance.RJControls.RJToggleButton();
            this.TxtNombre = new RJCodeAdvance.RJControls.RJTextBox();
            this.BtnNuevo = new FontAwesome.Sharp.IconButton();
            this.BtnEliminar = new FontAwesome.Sharp.IconButton();
            this.CboCategoria = new RJCodeAdvance.RJControls.RJComboBox();
            this.BtnBuscar = new FontAwesome.Sharp.IconButton();
            this.TgbDisponibilidad = new RJCodeAdvance.RJControls.RJToggleButton();
            this.TgbCategoriaPlato = new RJCodeAdvance.RJControls.RJToggleButton();
            this.myGroupBox1 = new Garmoxu_Desktop.MyGroupBox();
            this.LstPlatos = new System.Windows.Forms.ListView();
            this.LblDisponibilidad = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.myGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ImgImagenesPlatos
            // 
            this.ImgImagenesPlatos.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ImgImagenesPlatos.ImageSize = new System.Drawing.Size(128, 128);
            this.ImgImagenesPlatos.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.myGroupBox1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(70, 50, 70, 50);
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1085, 608);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 9;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.Controls.Add(this.TgbNombre, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.TxtNombre, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.BtnNuevo, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.BtnEliminar, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.BtnBuscar, 8, 0);
            this.tableLayoutPanel4.Controls.Add(this.CboCategoria, 4, 0);
            this.tableLayoutPanel4.Controls.Add(this.TgbCategoriaPlato, 5, 0);
            this.tableLayoutPanel4.Controls.Add(this.TgbDisponibilidad, 7, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(73, 53);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(939, 80);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // TgbNombre
            // 
            this.TgbNombre.AutoSize = true;
            this.TgbNombre.Checked = true;
            this.TgbNombre.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TgbNombre.Location = new System.Drawing.Point(379, 4);
            this.TgbNombre.Margin = new System.Windows.Forms.Padding(4);
            this.TgbNombre.MinimumSize = new System.Drawing.Size(60, 27);
            this.TgbNombre.Name = "TgbNombre";
            this.TgbNombre.OffBackColor = System.Drawing.Color.Gray;
            this.TgbNombre.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.TgbNombre.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.TgbNombre.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.TgbNombre.Size = new System.Drawing.Size(60, 27);
            this.TgbNombre.TabIndex = 52;
            this.TgbNombre.UseVisualStyleBackColor = true;
            // 
            // TxtNombre
            // 
            this.TxtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.TxtNombre.BorderColor = System.Drawing.Color.Transparent;
            this.TxtNombre.BorderFocusColor = System.Drawing.Color.Gainsboro;
            this.TxtNombre.BorderRadius = 10;
            this.TxtNombre.BorderSize = 2;
            this.TxtNombre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtNombre.Font = new System.Drawing.Font("Source Sans Pro", 16.2F, System.Drawing.FontStyle.Bold);
            this.TxtNombre.ForeColor = System.Drawing.Color.Gainsboro;
            this.TxtNombre.Location = new System.Drawing.Point(134, 5);
            this.TxtNombre.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.TxtNombre.Multiline = false;
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.TxtNombre.PasswordChar = false;
            this.TxtNombre.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TxtNombre.PlaceholderText = "";
            this.TxtNombre.Size = new System.Drawing.Size(241, 55);
            this.TxtNombre.TabIndex = 49;
            this.TxtNombre.Texts = "";
            this.TxtNombre.UnderlinedStyle = false;
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.AutoSize = true;
            this.BtnNuevo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnNuevo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnNuevo.FlatAppearance.BorderSize = 0;
            this.BtnNuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNuevo.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.BtnNuevo.IconColor = System.Drawing.Color.LimeGreen;
            this.BtnNuevo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnNuevo.IconSize = 55;
            this.BtnNuevo.Location = new System.Drawing.Point(3, 3);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(61, 54);
            this.BtnNuevo.TabIndex = 43;
            this.BtnNuevo.TabStop = false;
            this.BtnNuevo.UseVisualStyleBackColor = true;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnEliminar.FlatAppearance.BorderSize = 0;
            this.BtnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.IconChar = FontAwesome.Sharp.IconChar.UserMinus;
            this.BtnEliminar.IconColor = System.Drawing.Color.Crimson;
            this.BtnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnEliminar.IconSize = 55;
            this.BtnEliminar.Location = new System.Drawing.Point(70, 3);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(61, 54);
            this.BtnEliminar.TabIndex = 44;
            this.BtnEliminar.TabStop = false;
            this.BtnEliminar.UseVisualStyleBackColor = true;
            // 
            // CboCategoria
            // 
            this.CboCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.CboCategoria.BorderColor = System.Drawing.Color.Transparent;
            this.CboCategoria.BorderSize = 0;
            this.CboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboCategoria.Font = new System.Drawing.Font("Source Sans Pro", 14F, System.Drawing.FontStyle.Bold);
            this.CboCategoria.ForeColor = System.Drawing.Color.Gainsboro;
            this.CboCategoria.IconColor = System.Drawing.Color.Gainsboro;
            this.CboCategoria.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.CboCategoria.ListTextColor = System.Drawing.Color.DimGray;
            this.CboCategoria.Location = new System.Drawing.Point(446, 0);
            this.CboCategoria.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.CboCategoria.MinimumSize = new System.Drawing.Size(200, 30);
            this.CboCategoria.Name = "CboCategoria";
            this.CboCategoria.Size = new System.Drawing.Size(200, 54);
            this.CboCategoria.TabIndex = 28;
            this.CboCategoria.TabStop = false;
            this.CboCategoria.Texts = "";
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnBuscar.FlatAppearance.BorderSize = 0;
            this.BtnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscar.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.BtnBuscar.IconChar = FontAwesome.Sharp.IconChar.Filter;
            this.BtnBuscar.IconColor = System.Drawing.Color.Silver;
            this.BtnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnBuscar.Location = new System.Drawing.Point(820, 0);
            this.BtnBuscar.Margin = new System.Windows.Forms.Padding(0);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(119, 60);
            this.BtnBuscar.TabIndex = 45;
            this.BtnBuscar.TabStop = false;
            this.BtnBuscar.UseVisualStyleBackColor = true;
            // 
            // TgbDisponibilidad
            // 
            this.TgbDisponibilidad.AutoSize = true;
            this.TgbDisponibilidad.Checked = true;
            this.TgbDisponibilidad.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TgbDisponibilidad.Location = new System.Drawing.Point(756, 4);
            this.TgbDisponibilidad.Margin = new System.Windows.Forms.Padding(4);
            this.TgbDisponibilidad.MinimumSize = new System.Drawing.Size(60, 27);
            this.TgbDisponibilidad.Name = "TgbDisponibilidad";
            this.TgbDisponibilidad.OffBackColor = System.Drawing.Color.Gray;
            this.TgbDisponibilidad.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.TgbDisponibilidad.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.TgbDisponibilidad.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.TgbDisponibilidad.Size = new System.Drawing.Size(60, 27);
            this.TgbDisponibilidad.TabIndex = 13;
            this.TgbDisponibilidad.UseVisualStyleBackColor = true;
            // 
            // TgbCategoriaPlato
            // 
            this.TgbCategoriaPlato.AutoSize = true;
            this.TgbCategoriaPlato.Checked = true;
            this.TgbCategoriaPlato.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TgbCategoriaPlato.Location = new System.Drawing.Point(688, 4);
            this.TgbCategoriaPlato.Margin = new System.Windows.Forms.Padding(4);
            this.TgbCategoriaPlato.MinimumSize = new System.Drawing.Size(60, 27);
            this.TgbCategoriaPlato.Name = "TgbCategoriaPlato";
            this.TgbCategoriaPlato.OffBackColor = System.Drawing.Color.Gray;
            this.TgbCategoriaPlato.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.TgbCategoriaPlato.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.TgbCategoriaPlato.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.TgbCategoriaPlato.Size = new System.Drawing.Size(60, 27);
            this.TgbCategoriaPlato.TabIndex = 51;
            this.TgbCategoriaPlato.UseVisualStyleBackColor = true;
            // 
            // myGroupBox1
            // 
            this.myGroupBox1.BorderColor = System.Drawing.Color.White;
            this.myGroupBox1.Controls.Add(this.LstPlatos);
            this.myGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myGroupBox1.Location = new System.Drawing.Point(73, 139);
            this.myGroupBox1.Name = "myGroupBox1";
            this.myGroupBox1.Padding = new System.Windows.Forms.Padding(20, 10, 20, 20);
            this.myGroupBox1.Size = new System.Drawing.Size(939, 416);
            this.myGroupBox1.TabIndex = 1;
            this.myGroupBox1.TabStop = false;
            this.myGroupBox1.Text = "Platos";
            this.myGroupBox1.TextActivated = false;
            // 
            // LstPlatos
            // 
            this.LstPlatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(54)))), ((int)(((byte)(58)))));
            this.LstPlatos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LstPlatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LstPlatos.Font = new System.Drawing.Font("Source Sans Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LstPlatos.ForeColor = System.Drawing.Color.White;
            this.LstPlatos.HideSelection = false;
            this.LstPlatos.LargeImageList = this.ImgImagenesPlatos;
            this.LstPlatos.Location = new System.Drawing.Point(20, 25);
            this.LstPlatos.Margin = new System.Windows.Forms.Padding(4, 20, 4, 4);
            this.LstPlatos.MultiSelect = false;
            this.LstPlatos.Name = "LstPlatos";
            this.LstPlatos.Size = new System.Drawing.Size(899, 371);
            this.LstPlatos.TabIndex = 7;
            this.LstPlatos.UseCompatibleStateImageBehavior = false;
            // 
            // LblDisponibilidad
            // 
            this.LblDisponibilidad.AutoSize = true;
            this.LblDisponibilidad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblDisponibilidad.Font = new System.Drawing.Font("Source Sans Pro", 15.2F, System.Drawing.FontStyle.Bold);
            this.LblDisponibilidad.ForeColor = System.Drawing.Color.White;
            this.LblDisponibilidad.Location = new System.Drawing.Point(822, 0);
            this.LblDisponibilidad.Name = "LblDisponibilidad";
            this.LblDisponibilidad.Size = new System.Drawing.Size(102, 60);
            this.LblDisponibilidad.TabIndex = 14;
            this.LblDisponibilidad.Text = "Disponible";
            // 
            // FrmPlatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(54)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(1085, 608);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmPlatos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "Platos";
            this.Text = "Gestión de platos - Garmoxu";
            this.EnabledChanged += new System.EventHandler(this.FrmPlatos_EnabledChanged);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.myGroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList ImgImagenesPlatos;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MyGroupBox myGroupBox1;
        private System.Windows.Forms.ListView LstPlatos;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private RJCodeAdvance.RJControls.RJToggleButton TgbNombre;
        private RJCodeAdvance.RJControls.RJTextBox TxtNombre;
        private FontAwesome.Sharp.IconButton BtnNuevo;
        private FontAwesome.Sharp.IconButton BtnEliminar;
        private RJCodeAdvance.RJControls.RJComboBox CboCategoria;
        private FontAwesome.Sharp.IconButton BtnBuscar;
        private RJCodeAdvance.RJControls.RJToggleButton TgbDisponibilidad;
        private RJCodeAdvance.RJControls.RJToggleButton TgbCategoriaPlato;
        private System.Windows.Forms.Label LblDisponibilidad;
    }
}