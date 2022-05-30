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
            this.LblDisponibilidad = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.TgbDisponibilidad = new RJCodeAdvance.RJControls.RJToggleButton();
            this.BtnNuevo = new FontAwesome.Sharp.IconButton();
            this.BtnEliminar = new FontAwesome.Sharp.IconButton();
            this.TxtNombre = new RJCodeAdvance.RJControls.RJTextBox();
            this.CboCategoria = new RJCodeAdvance.RJControls.RJComboBox();
            this.BtnBuscar = new FontAwesome.Sharp.IconButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.ChkCategoría = new Garmoxu_Desktop.MyCheckBox();
            this.LblCategoria = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.ChkNombre = new Garmoxu_Desktop.MyCheckBox();
            this.LblNombre = new System.Windows.Forms.Label();
            this.myGroupBox1 = new Garmoxu_Desktop.MyGroupBox();
            this.LstPlatos = new System.Windows.Forms.ListView();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.myGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ImgImagenesPlatos
            // 
            this.ImgImagenesPlatos.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.ImgImagenesPlatos.ImageSize = new System.Drawing.Size(128, 128);
            this.ImgImagenesPlatos.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // LblDisponibilidad
            // 
            this.LblDisponibilidad.AutoSize = true;
            this.LblDisponibilidad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblDisponibilidad.Font = new System.Drawing.Font("Source Sans Pro", 15.2F, System.Drawing.FontStyle.Bold);
            this.LblDisponibilidad.ForeColor = System.Drawing.Color.Silver;
            this.LblDisponibilidad.Location = new System.Drawing.Point(912, 0);
            this.LblDisponibilidad.Margin = new System.Windows.Forms.Padding(30, 0, 3, 0);
            this.LblDisponibilidad.Name = "LblDisponibilidad";
            this.LblDisponibilidad.Size = new System.Drawing.Size(182, 43);
            this.LblDisponibilidad.TabIndex = 14;
            this.LblDisponibilidad.Text = "Disponibilidad";
            this.LblDisponibilidad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1309, 608);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 9;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.Controls.Add(this.TgbDisponibilidad, 6, 1);
            this.tableLayoutPanel4.Controls.Add(this.BtnNuevo, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.BtnEliminar, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.TxtNombre, 2, 1);
            this.tableLayoutPanel4.Controls.Add(this.LblDisponibilidad, 6, 0);
            this.tableLayoutPanel4.Controls.Add(this.CboCategoria, 4, 1);
            this.tableLayoutPanel4.Controls.Add(this.BtnBuscar, 8, 1);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel2, 4, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel3, 2, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.ForeColor = System.Drawing.Color.White;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(73, 53);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1163, 96);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // TgbDisponibilidad
            // 
            this.TgbDisponibilidad.AutoSize = true;
            this.TgbDisponibilidad.Checked = true;
            this.TgbDisponibilidad.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TgbDisponibilidad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TgbDisponibilidad.Location = new System.Drawing.Point(917, 47);
            this.TgbDisponibilidad.Margin = new System.Windows.Forms.Padding(35, 4, 4, 4);
            this.TgbDisponibilidad.MinimumSize = new System.Drawing.Size(60, 27);
            this.TgbDisponibilidad.Name = "TgbDisponibilidad";
            this.TgbDisponibilidad.OffBackColor = System.Drawing.Color.Gray;
            this.TgbDisponibilidad.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.TgbDisponibilidad.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.TgbDisponibilidad.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.TgbDisponibilidad.Size = new System.Drawing.Size(60, 27);
            this.TgbDisponibilidad.TabIndex = 56;
            this.TgbDisponibilidad.TabStop = false;
            this.TgbDisponibilidad.UseVisualStyleBackColor = true;
            this.TgbDisponibilidad.CheckedChanged += new System.EventHandler(this.TgbDisponibilidad_CheckedChanged);
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNuevo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(54)))), ((int)(((byte)(58)))));
            this.BtnNuevo.FlatAppearance.BorderSize = 0;
            this.BtnNuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNuevo.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.BtnNuevo.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(225)))), ((int)(((byte)(70)))));
            this.BtnNuevo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnNuevo.Location = new System.Drawing.Point(4, 45);
            this.BtnNuevo.Margin = new System.Windows.Forms.Padding(4, 2, 0, 3);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(35, 48);
            this.BtnNuevo.TabIndex = 43;
            this.BtnNuevo.TabStop = false;
            this.BtnNuevo.UseVisualStyleBackColor = true;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            this.BtnNuevo.MouseEnter += new System.EventHandler(this.BtnNuevo_MouseEnter);
            this.BtnNuevo.MouseLeave += new System.EventHandler(this.BtnNuevo_MouseLeave);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEliminar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnEliminar.Enabled = false;
            this.BtnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(54)))), ((int)(((byte)(58)))));
            this.BtnEliminar.FlatAppearance.BorderSize = 0;
            this.BtnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.BtnEliminar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.BtnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnEliminar.Location = new System.Drawing.Point(54, 45);
            this.BtnEliminar.Margin = new System.Windows.Forms.Padding(15, 2, 0, 2);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(61, 49);
            this.BtnEliminar.TabIndex = 44;
            this.BtnEliminar.TabStop = false;
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            this.BtnEliminar.MouseEnter += new System.EventHandler(this.BtnEliminar_MouseEnter);
            this.BtnEliminar.MouseLeave += new System.EventHandler(this.BtnEliminar_MouseLeave);
            // 
            // TxtNombre
            // 
            this.TxtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.TxtNombre.BorderColor = System.Drawing.Color.Transparent;
            this.TxtNombre.BorderFocusColor = System.Drawing.Color.Gainsboro;
            this.TxtNombre.BorderRadius = 10;
            this.TxtNombre.BorderSize = 2;
            this.TxtNombre.Dock = System.Windows.Forms.DockStyle.Top;
            this.TxtNombre.Font = new System.Drawing.Font("Source Sans Pro", 16.2F, System.Drawing.FontStyle.Bold);
            this.TxtNombre.ForeColor = System.Drawing.Color.Gray;
            this.TxtNombre.Location = new System.Drawing.Point(135, 43);
            this.TxtNombre.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.TxtNombre.Multiline = false;
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Padding = new System.Windows.Forms.Padding(13, 12, 13, 3);
            this.TxtNombre.PasswordChar = false;
            this.TxtNombre.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TxtNombre.PlaceholderText = "";
            this.TxtNombre.Size = new System.Drawing.Size(342, 52);
            this.TxtNombre.TabIndex = 49;
            this.TxtNombre.TabStop = false;
            this.TxtNombre.Texts = "Buscar por nombre de plato";
            this.TxtNombre.UnderlinedStyle = false;
            this.TxtNombre._TextChanged += new System.EventHandler(this.TxtNombre__TextChanged);
            this.TxtNombre.Enter += new System.EventHandler(this.TxtNombre_Enter);
            this.TxtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombre_KeyPress);
            this.TxtNombre.Leave += new System.EventHandler(this.TxtNombre_Leave);
            // 
            // CboCategoria
            // 
            this.CboCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.CboCategoria.BorderColor = System.Drawing.Color.Transparent;
            this.CboCategoria.BorderSize = 0;
            this.CboCategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CboCategoria.Dock = System.Windows.Forms.DockStyle.Top;
            this.CboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboCategoria.Font = new System.Drawing.Font("Source Sans Pro", 14F, System.Drawing.FontStyle.Bold);
            this.CboCategoria.ForeColor = System.Drawing.Color.White;
            this.CboCategoria.IconColor = System.Drawing.Color.White;
            this.CboCategoria.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.CboCategoria.ListTextColor = System.Drawing.Color.DimGray;
            this.CboCategoria.Location = new System.Drawing.Point(507, 46);
            this.CboCategoria.Margin = new System.Windows.Forms.Padding(30, 3, 0, 0);
            this.CboCategoria.MinimumSize = new System.Drawing.Size(200, 30);
            this.CboCategoria.Name = "CboCategoria";
            this.CboCategoria.Size = new System.Drawing.Size(375, 50);
            this.CboCategoria.TabIndex = 28;
            this.CboCategoria.TabStop = false;
            this.CboCategoria.Texts = "";
            this.CboCategoria.OnSelectedIndexChanged += new System.EventHandler(this.CboCategoria_SelectedIndexChanged);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBuscar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(54)))), ((int)(((byte)(58)))));
            this.BtnBuscar.FlatAppearance.BorderSize = 0;
            this.BtnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscar.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.BtnBuscar.ForeColor = System.Drawing.Color.Transparent;
            this.BtnBuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.BtnBuscar.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnBuscar.Location = new System.Drawing.Point(1117, 45);
            this.BtnBuscar.Margin = new System.Windows.Forms.Padding(20, 2, 4, 3);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(42, 48);
            this.BtnBuscar.TabIndex = 45;
            this.BtnBuscar.TabStop = false;
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            this.BtnBuscar.MouseEnter += new System.EventHandler(this.BtnBuscar_MouseEnter);
            this.BtnBuscar.MouseLeave += new System.EventHandler(this.BtnBuscar_MouseLeave);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.ChkCategoría, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.LblCategoria, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(480, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(399, 37);
            this.tableLayoutPanel2.TabIndex = 58;
            // 
            // ChkCategoría
            // 
            this.ChkCategoría.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ChkCategoría.BackColor = System.Drawing.Color.Transparent;
            this.ChkCategoría.Background = System.Drawing.Color.Transparent;
            this.ChkCategoría.BorderColor = System.Drawing.Color.Silver;
            this.ChkCategoría.BorderHeight = 20;
            this.ChkCategoría.BorderWidth = 20;
            this.ChkCategoría.Checked = false;
            this.ChkCategoría.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChkCategoría.EnterColor = System.Drawing.Color.White;
            this.ChkCategoría.Font = new System.Drawing.Font("Source Sans Pro Black", 15F, System.Drawing.FontStyle.Bold);
            this.ChkCategoría.ForeColor = System.Drawing.Color.Silver;
            this.ChkCategoría.LeaveColor = System.Drawing.Color.Silver;
            this.ChkCategoría.Location = new System.Drawing.Point(162, 4);
            this.ChkCategoría.Name = "ChkCategoría";
            this.ChkCategoría.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.ChkCategoría.PaddingCheck = new System.Windows.Forms.Padding(0);
            this.ChkCategoría.Size = new System.Drawing.Size(28, 28);
            this.ChkCategoría.TabIndex = 57;
            this.ChkCategoría.TabStop = false;
            this.ChkCategoría.MouseEnter += new System.EventHandler(this.ChkCategoría_MouseEnter);
            this.ChkCategoría.MouseLeave += new System.EventHandler(this.ChkCategoría_MouseLeave);
            // 
            // LblCategoria
            // 
            this.LblCategoria.AutoSize = true;
            this.LblCategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblCategoria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblCategoria.Font = new System.Drawing.Font("Source Sans Pro", 15.2F, System.Drawing.FontStyle.Bold);
            this.LblCategoria.ForeColor = System.Drawing.Color.Silver;
            this.LblCategoria.Location = new System.Drawing.Point(30, 0);
            this.LblCategoria.Margin = new System.Windows.Forms.Padding(30, 0, 3, 0);
            this.LblCategoria.Name = "LblCategoria";
            this.LblCategoria.Size = new System.Drawing.Size(126, 37);
            this.LblCategoria.TabIndex = 58;
            this.LblCategoria.Text = "Categoría";
            this.LblCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblCategoria.Click += new System.EventHandler(this.LblCategoria_Click);
            this.LblCategoria.MouseEnter += new System.EventHandler(this.ChkCategoría_MouseEnter);
            this.LblCategoria.MouseLeave += new System.EventHandler(this.ChkCategoría_MouseLeave);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.ChkNombre, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.LblNombre, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(118, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(356, 37);
            this.tableLayoutPanel3.TabIndex = 61;
            // 
            // ChkNombre
            // 
            this.ChkNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ChkNombre.BackColor = System.Drawing.Color.Transparent;
            this.ChkNombre.Background = System.Drawing.Color.Transparent;
            this.ChkNombre.BorderColor = System.Drawing.Color.Silver;
            this.ChkNombre.BorderHeight = 20;
            this.ChkNombre.BorderWidth = 20;
            this.ChkNombre.Checked = false;
            this.ChkNombre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChkNombre.EnterColor = System.Drawing.Color.White;
            this.ChkNombre.Font = new System.Drawing.Font("Source Sans Pro Black", 15F, System.Drawing.FontStyle.Bold);
            this.ChkNombre.ForeColor = System.Drawing.Color.Silver;
            this.ChkNombre.LeaveColor = System.Drawing.Color.Silver;
            this.ChkNombre.Location = new System.Drawing.Point(230, 4);
            this.ChkNombre.Name = "ChkNombre";
            this.ChkNombre.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.ChkNombre.PaddingCheck = new System.Windows.Forms.Padding(0);
            this.ChkNombre.Size = new System.Drawing.Size(28, 28);
            this.ChkNombre.TabIndex = 59;
            this.ChkNombre.TabStop = false;
            this.ChkNombre.Text = "myCheckBox2";
            this.ChkNombre.MouseEnter += new System.EventHandler(this.ChkNombre_MouseEnter);
            this.ChkNombre.MouseLeave += new System.EventHandler(this.ChkNombre_MouseLeave);
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblNombre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblNombre.Font = new System.Drawing.Font("Source Sans Pro", 15.2F, System.Drawing.FontStyle.Bold);
            this.LblNombre.ForeColor = System.Drawing.Color.Silver;
            this.LblNombre.Location = new System.Drawing.Point(20, 0);
            this.LblNombre.Margin = new System.Windows.Forms.Padding(20, 0, 3, 0);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(204, 37);
            this.LblNombre.TabIndex = 60;
            this.LblNombre.Text = "Nombre de plato";
            this.LblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblNombre.Click += new System.EventHandler(this.LblNombre_Click);
            this.LblNombre.MouseEnter += new System.EventHandler(this.ChkNombre_MouseEnter);
            this.LblNombre.MouseLeave += new System.EventHandler(this.ChkNombre_MouseLeave);
            // 
            // myGroupBox1
            // 
            this.myGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.myGroupBox1.Background = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.myGroupBox1.BorderColor = System.Drawing.Color.Silver;
            this.myGroupBox1.BorderSize = 5;
            this.myGroupBox1.Controls.Add(this.LstPlatos);
            this.myGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myGroupBox1.EnabledText = false;
            this.myGroupBox1.Location = new System.Drawing.Point(73, 162);
            this.myGroupBox1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.myGroupBox1.Name = "myGroupBox1";
            this.myGroupBox1.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.myGroupBox1.Size = new System.Drawing.Size(1163, 393);
            this.myGroupBox1.TabIndex = 1;
            this.myGroupBox1.TabStop = false;
            this.myGroupBox1.Text = "Platos";
            // 
            // LstPlatos
            // 
            this.LstPlatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.LstPlatos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LstPlatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LstPlatos.Font = new System.Drawing.Font("Source Sans Pro", 14F, System.Drawing.FontStyle.Bold);
            this.LstPlatos.ForeColor = System.Drawing.Color.White;
            this.LstPlatos.HideSelection = false;
            this.LstPlatos.LargeImageList = this.ImgImagenesPlatos;
            this.LstPlatos.Location = new System.Drawing.Point(20, 45);
            this.LstPlatos.Margin = new System.Windows.Forms.Padding(4, 20, 4, 4);
            this.LstPlatos.MultiSelect = false;
            this.LstPlatos.Name = "LstPlatos";
            this.LstPlatos.Size = new System.Drawing.Size(1123, 328);
            this.LstPlatos.TabIndex = 7;
            this.LstPlatos.TabStop = false;
            this.LstPlatos.UseCompatibleStateImageBehavior = false;
            this.LstPlatos.SelectedIndexChanged += new System.EventHandler(this.LstPlatos_SelectedIndexChanged);
            this.LstPlatos.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LstPlatos_MouseDoubleClick);
            // 
            // FrmPlatos
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(54)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(1309, 608);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmPlatos";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "Platos";
            this.Text = "Gestión de platos - Garmoxu";
            this.TopMost = true;
            this.Shown += new System.EventHandler(this.FrmPlatos_Shown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.myGroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList ImgImagenesPlatos;
        private System.Windows.Forms.Label LblDisponibilidad;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private FontAwesome.Sharp.IconButton BtnNuevo;
        private FontAwesome.Sharp.IconButton BtnEliminar;
        private FontAwesome.Sharp.IconButton BtnBuscar;
        private RJCodeAdvance.RJControls.RJComboBox CboCategoria;
        private RJCodeAdvance.RJControls.RJToggleButton TgbDisponibilidad;
        private MyCheckBox myCheckBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private RJCodeAdvance.RJControls.RJTextBox TxtNombre;
        private MyCheckBox ChkNombre;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label LblCategoria;
        private MyCheckBox ChkCategoría;
        private MyGroupBox myGroupBox1;
        private System.Windows.Forms.ListView LstPlatos;
    }
}