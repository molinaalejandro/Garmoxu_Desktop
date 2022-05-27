
namespace Garmoxu_Desktop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCategorias));
            this.ImgImagenesCateg = new System.Windows.Forms.ImageList(this.components);
            this.PnlMain = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnNuevo = new FontAwesome.Sharp.IconButton();
            this.BtnEliminar = new FontAwesome.Sharp.IconButton();
            this.TxtBusqueda = new RJCodeAdvance.RJControls.RJTextBox();
            this.BtnBuscar = new FontAwesome.Sharp.IconButton();
            this.myGroupBox1 = new Garmoxu_Desktop.MyGroupBox();
            this.LstCategorias = new System.Windows.Forms.ListView();
            this.PnlMain.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.myGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ImgImagenesCateg
            // 
            this.ImgImagenesCateg.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.ImgImagenesCateg.ImageSize = new System.Drawing.Size(128, 128);
            this.ImgImagenesCateg.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // PnlMain
            // 
            this.PnlMain.ColumnCount = 1;
            this.PnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PnlMain.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.PnlMain.Controls.Add(this.myGroupBox1, 0, 1);
            this.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlMain.Location = new System.Drawing.Point(0, 0);
            this.PnlMain.Margin = new System.Windows.Forms.Padding(0);
            this.PnlMain.Name = "PnlMain";
            this.PnlMain.Padding = new System.Windows.Forms.Padding(70, 50, 70, 50);
            this.PnlMain.RowCount = 2;
            this.PnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.PnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PnlMain.Size = new System.Drawing.Size(1186, 629);
            this.PnlMain.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 4;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Controls.Add(this.BtnNuevo, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.BtnEliminar, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.TxtBusqueda, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.BtnBuscar, 3, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.ForeColor = System.Drawing.Color.White;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(73, 53);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1040, 65);
            this.tableLayoutPanel4.TabIndex = 0;
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
            this.BtnNuevo.Location = new System.Drawing.Point(0, 0);
            this.BtnNuevo.Margin = new System.Windows.Forms.Padding(0);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(35, 65);
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
            this.BtnEliminar.Location = new System.Drawing.Point(50, 0);
            this.BtnEliminar.Margin = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(61, 65);
            this.BtnEliminar.TabIndex = 44;
            this.BtnEliminar.TabStop = false;
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            this.BtnEliminar.MouseEnter += new System.EventHandler(this.BtnEliminar_MouseEnter);
            this.BtnEliminar.MouseLeave += new System.EventHandler(this.BtnEliminar_MouseLeave);
            // 
            // TxtBusqueda
            // 
            this.TxtBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtBusqueda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.TxtBusqueda.BorderColor = System.Drawing.Color.Transparent;
            this.TxtBusqueda.BorderFocusColor = System.Drawing.Color.Gainsboro;
            this.TxtBusqueda.BorderRadius = 10;
            this.TxtBusqueda.BorderSize = 2;
            this.TxtBusqueda.Font = new System.Drawing.Font("Source Sans Pro", 16.2F, System.Drawing.FontStyle.Bold);
            this.TxtBusqueda.ForeColor = System.Drawing.Color.Gray;
            this.TxtBusqueda.Location = new System.Drawing.Point(121, 6);
            this.TxtBusqueda.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.TxtBusqueda.Multiline = false;
            this.TxtBusqueda.Name = "TxtBusqueda";
            this.TxtBusqueda.Padding = new System.Windows.Forms.Padding(13, 12, 13, 3);
            this.TxtBusqueda.PasswordChar = false;
            this.TxtBusqueda.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TxtBusqueda.PlaceholderText = "";
            this.TxtBusqueda.Size = new System.Drawing.Size(857, 52);
            this.TxtBusqueda.TabIndex = 49;
            this.TxtBusqueda.Texts = "Buscar por nombre de categoría";
            this.TxtBusqueda.UnderlinedStyle = false;
            this.TxtBusqueda.Enter += new System.EventHandler(this.TxtBusqueda_Enter);
            this.TxtBusqueda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBusqueda_KeyPress);
            this.TxtBusqueda.Leave += new System.EventHandler(this.TxtBusqueda_Leave);
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
            this.BtnBuscar.Location = new System.Drawing.Point(998, 0);
            this.BtnBuscar.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(42, 65);
            this.BtnBuscar.TabIndex = 45;
            this.BtnBuscar.TabStop = false;
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            this.BtnBuscar.MouseEnter += new System.EventHandler(this.BtnBuscar_MouseEnter);
            this.BtnBuscar.MouseLeave += new System.EventHandler(this.BtnBuscar_MouseLeave);
            // 
            // myGroupBox1
            // 
            this.myGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.myGroupBox1.Background = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.myGroupBox1.BorderColor = System.Drawing.Color.Silver;
            this.myGroupBox1.BorderSize = 5;
            this.myGroupBox1.Controls.Add(this.LstCategorias);
            this.myGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myGroupBox1.EnabledText = false;
            this.myGroupBox1.Location = new System.Drawing.Point(73, 131);
            this.myGroupBox1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.myGroupBox1.Name = "myGroupBox1";
            this.myGroupBox1.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.myGroupBox1.Size = new System.Drawing.Size(1040, 445);
            this.myGroupBox1.TabIndex = 1;
            this.myGroupBox1.TabStop = false;
            this.myGroupBox1.Text = "Platos";
            // 
            // LstCategorias
            // 
            this.LstCategorias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.LstCategorias.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LstCategorias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LstCategorias.Font = new System.Drawing.Font("Source Sans Pro", 14F, System.Drawing.FontStyle.Bold);
            this.LstCategorias.ForeColor = System.Drawing.Color.White;
            this.LstCategorias.HideSelection = false;
            this.LstCategorias.LargeImageList = this.ImgImagenesCateg;
            this.LstCategorias.Location = new System.Drawing.Point(20, 45);
            this.LstCategorias.Margin = new System.Windows.Forms.Padding(4, 20, 4, 4);
            this.LstCategorias.MultiSelect = false;
            this.LstCategorias.Name = "LstCategorias";
            this.LstCategorias.Size = new System.Drawing.Size(1000, 380);
            this.LstCategorias.TabIndex = 7;
            this.LstCategorias.TabStop = false;
            this.LstCategorias.UseCompatibleStateImageBehavior = false;
            this.LstCategorias.SelectedIndexChanged += new System.EventHandler(this.LstCategorias_SelectedIndexChanged);
            this.LstCategorias.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LstCategorias_MouseDoubleClick);
            // 
            // FrmCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(54)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(1186, 629);
            this.Controls.Add(this.PnlMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmCategorias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "Categorias";
            this.Text = "Gestión de categorías - Garmoxu";
            this.EnabledChanged += new System.EventHandler(this.FrmCategoria_EnabledChanged);
            this.PnlMain.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.myGroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList ImgImagenesCateg;
        private System.Windows.Forms.TableLayoutPanel PnlMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private FontAwesome.Sharp.IconButton BtnNuevo;
        private FontAwesome.Sharp.IconButton BtnEliminar;
        private RJCodeAdvance.RJControls.RJTextBox TxtBusqueda;
        private FontAwesome.Sharp.IconButton BtnBuscar;
        private MyGroupBox myGroupBox1;
        private System.Windows.Forms.ListView LstCategorias;
    }
}