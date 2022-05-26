
namespace Garmoxu_Desktop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPedidosPlatosConsulta));
            this.ImgImagenesPlatos = new System.Windows.Forms.ImageList(this.components);
            this.myGroupBox1 = new Garmoxu_Desktop.MyGroupBox();
            this.LstPlatos = new System.Windows.Forms.ListView();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.TgbDisponibilidad = new RJCodeAdvance.RJControls.RJToggleButton();
            this.TxtNombre = new RJCodeAdvance.RJControls.RJTextBox();
            this.LblDisponibilidad = new System.Windows.Forms.Label();
            this.CboCategoria = new RJCodeAdvance.RJControls.RJComboBox();
            this.BtnBuscar = new FontAwesome.Sharp.IconButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.ChkCategoría = new Garmoxu_Desktop.MyCheckBox();
            this.LblCategoria = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.ChkNombre = new Garmoxu_Desktop.MyCheckBox();
            this.LblNombre = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnClose = new FontAwesome.Sharp.IconButton();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.myGroupBox1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // ImgImagenesPlatos
            // 
            this.ImgImagenesPlatos.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ImgImagenesPlatos.ImageSize = new System.Drawing.Size(128, 128);
            this.ImgImagenesPlatos.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // myGroupBox1
            // 
            this.myGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.myGroupBox1.Background = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.myGroupBox1.BorderColor = System.Drawing.Color.Silver;
            this.myGroupBox1.BorderSize = 5;
            this.myGroupBox1.Controls.Add(this.LstPlatos);
            this.myGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myGroupBox1.Location = new System.Drawing.Point(3, 112);
            this.myGroupBox1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.myGroupBox1.Name = "myGroupBox1";
            this.myGroupBox1.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.myGroupBox1.Size = new System.Drawing.Size(1390, 674);
            this.myGroupBox1.TabIndex = 1;
            this.myGroupBox1.TabStop = false;
            this.myGroupBox1.Text = "Platos";
            this.myGroupBox1.EnabledText = false;
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
            this.LstPlatos.Size = new System.Drawing.Size(1350, 609);
            this.LstPlatos.TabIndex = 7;
            this.LstPlatos.TabStop = false;
            this.LstPlatos.UseCompatibleStateImageBehavior = false;
            this.LstPlatos.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LstPlatos_MouseDoubleClick);
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
            this.tableLayoutPanel4.Controls.Add(this.TxtNombre, 2, 1);
            this.tableLayoutPanel4.Controls.Add(this.LblDisponibilidad, 6, 0);
            this.tableLayoutPanel4.Controls.Add(this.CboCategoria, 4, 1);
            this.tableLayoutPanel4.Controls.Add(this.BtnBuscar, 8, 1);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel2, 4, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel3, 2, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.ForeColor = System.Drawing.Color.White;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1390, 96);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // TgbDisponibilidad
            // 
            this.TgbDisponibilidad.AutoSize = true;
            this.TgbDisponibilidad.Checked = true;
            this.TgbDisponibilidad.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TgbDisponibilidad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TgbDisponibilidad.Location = new System.Drawing.Point(1148, 47);
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
            this.TxtNombre.Location = new System.Drawing.Point(0, 43);
            this.TxtNombre.Margin = new System.Windows.Forms.Padding(0);
            this.TxtNombre.Multiline = false;
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Padding = new System.Windows.Forms.Padding(13, 12, 13, 3);
            this.TxtNombre.PasswordChar = false;
            this.TxtNombre.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TxtNombre.PlaceholderText = "";
            this.TxtNombre.Size = new System.Drawing.Size(783, 52);
            this.TxtNombre.TabIndex = 49;
            this.TxtNombre.TabStop = false;
            this.TxtNombre.Texts = "Buscar por nombre de plato";
            this.TxtNombre.UnderlinedStyle = false;
            this.TxtNombre._TextChanged += new System.EventHandler(this.TxtNombre__TextChanged);
            this.TxtNombre.Enter += new System.EventHandler(this.TxtNombre_Enter);
            this.TxtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombre_KeyPress);
            this.TxtNombre.Leave += new System.EventHandler(this.TxtNombre_Leave);
            // 
            // LblDisponibilidad
            // 
            this.LblDisponibilidad.AutoSize = true;
            this.LblDisponibilidad.Font = new System.Drawing.Font("Source Sans Pro", 15.2F, System.Drawing.FontStyle.Bold);
            this.LblDisponibilidad.ForeColor = System.Drawing.Color.Gainsboro;
            this.LblDisponibilidad.Location = new System.Drawing.Point(1143, 0);
            this.LblDisponibilidad.Margin = new System.Windows.Forms.Padding(30, 0, 3, 0);
            this.LblDisponibilidad.Name = "LblDisponibilidad";
            this.LblDisponibilidad.Size = new System.Drawing.Size(182, 33);
            this.LblDisponibilidad.TabIndex = 14;
            this.LblDisponibilidad.Text = "Disponibilidad";
            this.LblDisponibilidad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CboCategoria
            // 
            this.CboCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.CboCategoria.BorderColor = System.Drawing.Color.Transparent;
            this.CboCategoria.BorderSize = 0;
            this.CboCategoria.Dock = System.Windows.Forms.DockStyle.Top;
            this.CboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboCategoria.Font = new System.Drawing.Font("Source Sans Pro", 14F, System.Drawing.FontStyle.Bold);
            this.CboCategoria.ForeColor = System.Drawing.Color.Gainsboro;
            this.CboCategoria.IconColor = System.Drawing.Color.Gainsboro;
            this.CboCategoria.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.CboCategoria.ListTextColor = System.Drawing.Color.DimGray;
            this.CboCategoria.Location = new System.Drawing.Point(813, 43);
            this.CboCategoria.Margin = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.CboCategoria.MinimumSize = new System.Drawing.Size(200, 30);
            this.CboCategoria.Name = "CboCategoria";
            this.CboCategoria.Size = new System.Drawing.Size(300, 51);
            this.CboCategoria.TabIndex = 28;
            this.CboCategoria.TabStop = false;
            this.CboCategoria.Texts = "";
            this.CboCategoria.OnSelectedIndexChanged += new System.EventHandler(this.CboCategoria_SelectedIndexChanged);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBuscar.Dock = System.Windows.Forms.DockStyle.Top;
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
            this.BtnBuscar.Location = new System.Drawing.Point(1348, 43);
            this.BtnBuscar.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(42, 53);
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
            this.tableLayoutPanel2.Location = new System.Drawing.Point(786, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(324, 37);
            this.tableLayoutPanel2.TabIndex = 58;
            // 
            // ChkCategoría
            // 
            this.ChkCategoría.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ChkCategoría.BackColor = System.Drawing.Color.Transparent;
            this.ChkCategoría.Background = System.Drawing.Color.Transparent;
            this.ChkCategoría.BorderColor = System.Drawing.Color.Gainsboro;
            this.ChkCategoría.BorderHeight = 15;
            this.ChkCategoría.BorderWidth = 15;
            this.ChkCategoría.Checked = false;
            this.ChkCategoría.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChkCategoría.EnterColor = System.Drawing.Color.White;
            this.ChkCategoría.Font = new System.Drawing.Font("Source Sans Pro Black", 14F, System.Drawing.FontStyle.Bold);
            this.ChkCategoría.ForeColor = System.Drawing.Color.White;
            this.ChkCategoría.LeaveColor = System.Drawing.Color.Gainsboro;
            this.ChkCategoría.Location = new System.Drawing.Point(162, 4);
            this.ChkCategoría.Name = "ChkCategoría";
            this.ChkCategoría.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.ChkCategoría.PaddingCheck = new System.Windows.Forms.Padding(0);
            this.ChkCategoría.Size = new System.Drawing.Size(35, 28);
            this.ChkCategoría.TabIndex = 57;
            this.ChkCategoría.TabStop = false;
            this.ChkCategoría.MouseEnter += new System.EventHandler(this.ChkCategoría_MouseEnter);
            this.ChkCategoría.MouseLeave += new System.EventHandler(this.ChkCategoría_MouseLeave);
            // 
            // LblCategoria
            // 
            this.LblCategoria.AutoSize = true;
            this.LblCategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblCategoria.Font = new System.Drawing.Font("Source Sans Pro", 15.2F, System.Drawing.FontStyle.Bold);
            this.LblCategoria.ForeColor = System.Drawing.Color.Gainsboro;
            this.LblCategoria.Location = new System.Drawing.Point(30, 0);
            this.LblCategoria.Margin = new System.Windows.Forms.Padding(30, 0, 3, 0);
            this.LblCategoria.Name = "LblCategoria";
            this.LblCategoria.Size = new System.Drawing.Size(126, 33);
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
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(777, 37);
            this.tableLayoutPanel3.TabIndex = 61;
            // 
            // ChkNombre
            // 
            this.ChkNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ChkNombre.BackColor = System.Drawing.Color.Transparent;
            this.ChkNombre.Background = System.Drawing.Color.Transparent;
            this.ChkNombre.BorderColor = System.Drawing.Color.Gainsboro;
            this.ChkNombre.BorderHeight = 15;
            this.ChkNombre.BorderWidth = 15;
            this.ChkNombre.Checked = false;
            this.ChkNombre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChkNombre.EnterColor = System.Drawing.Color.White;
            this.ChkNombre.Font = new System.Drawing.Font("Source Sans Pro Black", 14F, System.Drawing.FontStyle.Bold);
            this.ChkNombre.ForeColor = System.Drawing.Color.White;
            this.ChkNombre.LeaveColor = System.Drawing.Color.Gainsboro;
            this.ChkNombre.Location = new System.Drawing.Point(210, 4);
            this.ChkNombre.Name = "ChkNombre";
            this.ChkNombre.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.ChkNombre.PaddingCheck = new System.Windows.Forms.Padding(0);
            this.ChkNombre.Size = new System.Drawing.Size(35, 28);
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
            this.LblNombre.Font = new System.Drawing.Font("Source Sans Pro", 15.2F, System.Drawing.FontStyle.Bold);
            this.LblNombre.ForeColor = System.Drawing.Color.Gainsboro;
            this.LblNombre.Location = new System.Drawing.Point(0, 0);
            this.LblNombre.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(204, 33);
            this.LblNombre.TabIndex = 60;
            this.LblNombre.Text = "Nombre de plato";
            this.LblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblNombre.Click += new System.EventHandler(this.LblNombre_Click);
            this.LblNombre.MouseEnter += new System.EventHandler(this.ChkNombre_MouseEnter);
            this.LblNombre.MouseLeave += new System.EventHandler(this.ChkNombre_MouseLeave);
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
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1396, 789);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel1, 0, 2);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(70, 122);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(70, 50, 70, 50);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 3;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(1396, 789);
            this.tableLayoutPanel5.TabIndex = 2;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel7, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel5, 0, 1);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(1536, 961);
            this.tableLayoutPanel6.TabIndex = 3;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(45)))));
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel7.Controls.Add(this.BtnClose, 1, 0);
            this.tableLayoutPanel7.Controls.Add(this.LblTitulo, 0, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(1536, 72);
            this.tableLayoutPanel7.TabIndex = 1;
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.Color.Transparent;
            this.BtnClose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(45)))));
            this.BtnClose.FlatAppearance.BorderSize = 0;
            this.BtnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(71)))), ((int)(((byte)(83)))));
            this.BtnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(41)))), ((int)(((byte)(83)))));
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(54)))), ((int)(((byte)(58)))));
            this.BtnClose.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.BtnClose.IconColor = System.Drawing.Color.White;
            this.BtnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnClose.IconSize = 25;
            this.BtnClose.Location = new System.Drawing.Point(1469, 0);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(0);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(67, 72);
            this.BtnClose.TabIndex = 1;
            this.BtnClose.TabStop = false;
            this.BtnClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblTitulo.Font = new System.Drawing.Font("Source Sans Pro", 18F, System.Drawing.FontStyle.Bold);
            this.LblTitulo.ForeColor = System.Drawing.Color.White;
            this.LblTitulo.Location = new System.Drawing.Point(14, 0);
            this.LblTitulo.Margin = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(1455, 72);
            this.LblTitulo.TabIndex = 0;
            this.LblTitulo.Text = "Consulta los platos";
            this.LblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmPedidosPlatosConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(54)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(1536, 961);
            this.Controls.Add(this.tableLayoutPanel6);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmPedidosPlatosConsulta";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta los platos - Garmoxu";
            this.TopMost = true;
            this.myGroupBox1.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList ImgImagenesPlatos;
        private MyGroupBox myGroupBox1;
        private System.Windows.Forms.ListView LstPlatos;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private RJCodeAdvance.RJControls.RJToggleButton TgbDisponibilidad;
        private RJCodeAdvance.RJControls.RJTextBox TxtNombre;
        private System.Windows.Forms.Label LblDisponibilidad;
        private RJCodeAdvance.RJControls.RJComboBox CboCategoria;
        private FontAwesome.Sharp.IconButton BtnBuscar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private MyCheckBox ChkCategoría;
        private System.Windows.Forms.Label LblCategoria;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private MyCheckBox ChkNombre;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private FontAwesome.Sharp.IconButton BtnClose;
        private System.Windows.Forms.Label LblTitulo;
    }
}
