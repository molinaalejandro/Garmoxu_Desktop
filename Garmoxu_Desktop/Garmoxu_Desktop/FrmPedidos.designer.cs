namespace Garmoxu_Desktop
{
    partial class FrmPedidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPedidos));
            this.TmrComprobarCambiosPedidos = new System.Windows.Forms.Timer(this.components);
            this.PnlMain = new System.Windows.Forms.TableLayoutPanel();
            this.PnlFoot = new System.Windows.Forms.TableLayoutPanel();
            this.BtnBuscar = new FontAwesome.Sharp.IconButton();
            this.BtnNuevo = new FontAwesome.Sharp.IconButton();
            this.TxtBuscar = new RJCodeAdvance.RJControls.RJTextBox();
            this.PnlPedidos = new System.Windows.Forms.TableLayoutPanel();
            this.GrpRecoger = new Garmoxu_Desktop.MyGroupBox();
            this.PnlRecoger = new System.Windows.Forms.FlowLayoutPanel();
            this.GrpDomicilio = new Garmoxu_Desktop.MyGroupBox();
            this.PnlDomicilio = new System.Windows.Forms.FlowLayoutPanel();
            this.GrpLocal = new Garmoxu_Desktop.MyGroupBox();
            this.PnlLocal = new System.Windows.Forms.FlowLayoutPanel();
            this.PnlMain.SuspendLayout();
            this.PnlFoot.SuspendLayout();
            this.PnlPedidos.SuspendLayout();
            this.GrpRecoger.SuspendLayout();
            this.GrpDomicilio.SuspendLayout();
            this.GrpLocal.SuspendLayout();
            this.SuspendLayout();
            // 
            // TmrComprobarCambiosPedidos
            // 
            this.TmrComprobarCambiosPedidos.Enabled = true;
            this.TmrComprobarCambiosPedidos.Interval = 1000;
            this.TmrComprobarCambiosPedidos.Tick += new System.EventHandler(this.TmrComprobarCambiosPedidos_Tick);
            // 
            // PnlMain
            // 
            this.PnlMain.ColumnCount = 1;
            this.PnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PnlMain.Controls.Add(this.PnlFoot, 0, 0);
            this.PnlMain.Controls.Add(this.PnlPedidos, 0, 1);
            this.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlMain.Location = new System.Drawing.Point(0, 0);
            this.PnlMain.Margin = new System.Windows.Forms.Padding(4);
            this.PnlMain.Name = "PnlMain";
            this.PnlMain.Padding = new System.Windows.Forms.Padding(70, 50, 70, 20);
            this.PnlMain.RowCount = 2;
            this.PnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.PnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.PnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.PnlMain.Size = new System.Drawing.Size(1100, 685);
            this.PnlMain.TabIndex = 0;
            // 
            // PnlFoot
            // 
            this.PnlFoot.ColumnCount = 3;
            this.PnlFoot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.PnlFoot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PnlFoot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.PnlFoot.Controls.Add(this.BtnBuscar, 2, 0);
            this.PnlFoot.Controls.Add(this.BtnNuevo, 0, 0);
            this.PnlFoot.Controls.Add(this.TxtBuscar, 1, 0);
            this.PnlFoot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlFoot.Location = new System.Drawing.Point(70, 50);
            this.PnlFoot.Margin = new System.Windows.Forms.Padding(0);
            this.PnlFoot.Name = "PnlFoot";
            this.PnlFoot.RowCount = 1;
            this.PnlFoot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PnlFoot.Size = new System.Drawing.Size(960, 55);
            this.PnlFoot.TabIndex = 0;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.AutoSize = true;
            this.BtnBuscar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBuscar.Enabled = false;
            this.BtnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(54)))), ((int)(((byte)(58)))));
            this.BtnBuscar.FlatAppearance.BorderSize = 0;
            this.BtnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscar.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.BtnBuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.BtnBuscar.IconColor = System.Drawing.Color.DodgerBlue;
            this.BtnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnBuscar.IconSize = 55;
            this.BtnBuscar.Location = new System.Drawing.Point(899, 0);
            this.BtnBuscar.Margin = new System.Windows.Forms.Padding(0);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(61, 55);
            this.BtnBuscar.TabIndex = 2;
            this.BtnBuscar.TabStop = false;
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            this.BtnBuscar.MouseEnter += new System.EventHandler(this.BtnBuscar_MouseEnter);
            this.BtnBuscar.MouseLeave += new System.EventHandler(this.BtnBuscar_MouseLeave);
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.AutoSize = true;
            this.BtnNuevo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(54)))), ((int)(((byte)(58)))));
            this.BtnNuevo.FlatAppearance.BorderSize = 0;
            this.BtnNuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNuevo.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.BtnNuevo.IconColor = System.Drawing.Color.NavajoWhite;
            this.BtnNuevo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnNuevo.IconSize = 55;
            this.BtnNuevo.Location = new System.Drawing.Point(0, 0);
            this.BtnNuevo.Margin = new System.Windows.Forms.Padding(0);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(61, 55);
            this.BtnNuevo.TabIndex = 0;
            this.BtnNuevo.TabStop = false;
            this.BtnNuevo.UseVisualStyleBackColor = true;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            this.BtnNuevo.MouseEnter += new System.EventHandler(this.BtnNuevo_MouseEnter);
            this.BtnNuevo.MouseLeave += new System.EventHandler(this.BtnNuevo_MouseLeave);
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.TxtBuscar.BorderColor = System.Drawing.Color.Transparent;
            this.TxtBuscar.BorderFocusColor = System.Drawing.Color.Gainsboro;
            this.TxtBuscar.BorderRadius = 10;
            this.TxtBuscar.BorderSize = 2;
            this.TxtBuscar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtBuscar.Font = new System.Drawing.Font("Source Sans Pro", 16.2F, System.Drawing.FontStyle.Bold);
            this.TxtBuscar.ForeColor = System.Drawing.Color.Gray;
            this.TxtBuscar.Location = new System.Drawing.Point(81, 0);
            this.TxtBuscar.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.TxtBuscar.Multiline = false;
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.TxtBuscar.PasswordChar = false;
            this.TxtBuscar.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TxtBuscar.PlaceholderText = "";
            this.TxtBuscar.Size = new System.Drawing.Size(798, 51);
            this.TxtBuscar.TabIndex = 1;
            this.TxtBuscar.TabStop = false;
            this.TxtBuscar.Texts = "Buscar por nº de mesa o teléfono de cliente";
            this.TxtBuscar.UnderlinedStyle = false;
            this.TxtBuscar._TextChanged += new System.EventHandler(this.TxtBuscar__TextChanged);
            this.TxtBuscar.Enter += new System.EventHandler(this.TxtBuscar_Enter);
            this.TxtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBuscar_KeyPress);
            this.TxtBuscar.Leave += new System.EventHandler(this.TxtBuscar_Leave);
            // 
            // PnlPedidos
            // 
            this.PnlPedidos.BackColor = System.Drawing.Color.Transparent;
            this.PnlPedidos.ColumnCount = 1;
            this.PnlPedidos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PnlPedidos.Controls.Add(this.GrpRecoger, 0, 2);
            this.PnlPedidos.Controls.Add(this.GrpDomicilio, 0, 1);
            this.PnlPedidos.Controls.Add(this.GrpLocal, 0, 0);
            this.PnlPedidos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlPedidos.Location = new System.Drawing.Point(74, 109);
            this.PnlPedidos.Margin = new System.Windows.Forms.Padding(4);
            this.PnlPedidos.Name = "PnlPedidos";
            this.PnlPedidos.RowCount = 3;
            this.PnlPedidos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.PnlPedidos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.PnlPedidos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.PnlPedidos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.PnlPedidos.Size = new System.Drawing.Size(952, 552);
            this.PnlPedidos.TabIndex = 1;
            // 
            // GrpRecoger
            // 
            this.GrpRecoger.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(54)))), ((int)(((byte)(58)))));
            this.GrpRecoger.Background = System.Drawing.Color.Transparent;
            this.GrpRecoger.BorderColor = System.Drawing.Color.Silver;
            this.GrpRecoger.BorderSize = 5;
            this.GrpRecoger.Controls.Add(this.PnlRecoger);
            this.GrpRecoger.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrpRecoger.Font = new System.Drawing.Font("Source Sans Pro", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpRecoger.ForeColor = System.Drawing.Color.Silver;
            this.GrpRecoger.Location = new System.Drawing.Point(0, 388);
            this.GrpRecoger.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.GrpRecoger.Name = "GrpRecoger";
            this.GrpRecoger.Padding = new System.Windows.Forms.Padding(20, 5, 20, 30);
            this.GrpRecoger.Size = new System.Drawing.Size(952, 164);
            this.GrpRecoger.TabIndex = 2;
            this.GrpRecoger.TabStop = false;
            this.GrpRecoger.Text = "Recoger";
            this.GrpRecoger.TextActivated = true;
            // 
            // PnlRecoger
            // 
            this.PnlRecoger.AutoScroll = true;
            this.PnlRecoger.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlRecoger.Location = new System.Drawing.Point(20, 43);
            this.PnlRecoger.Margin = new System.Windows.Forms.Padding(0);
            this.PnlRecoger.Name = "PnlRecoger";
            this.PnlRecoger.Size = new System.Drawing.Size(912, 91);
            this.PnlRecoger.TabIndex = 0;
            // 
            // GrpDomicilio
            // 
            this.GrpDomicilio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(54)))), ((int)(((byte)(58)))));
            this.GrpDomicilio.Background = System.Drawing.Color.Transparent;
            this.GrpDomicilio.BorderColor = System.Drawing.Color.Silver;
            this.GrpDomicilio.BorderSize = 5;
            this.GrpDomicilio.Controls.Add(this.PnlDomicilio);
            this.GrpDomicilio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrpDomicilio.Font = new System.Drawing.Font("Source Sans Pro", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpDomicilio.ForeColor = System.Drawing.Color.Silver;
            this.GrpDomicilio.Location = new System.Drawing.Point(0, 204);
            this.GrpDomicilio.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.GrpDomicilio.Name = "GrpDomicilio";
            this.GrpDomicilio.Padding = new System.Windows.Forms.Padding(20, 5, 20, 30);
            this.GrpDomicilio.Size = new System.Drawing.Size(952, 164);
            this.GrpDomicilio.TabIndex = 1;
            this.GrpDomicilio.TabStop = false;
            this.GrpDomicilio.Text = "Domicilio";
            this.GrpDomicilio.TextActivated = true;
            // 
            // PnlDomicilio
            // 
            this.PnlDomicilio.AutoScroll = true;
            this.PnlDomicilio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlDomicilio.Location = new System.Drawing.Point(20, 43);
            this.PnlDomicilio.Margin = new System.Windows.Forms.Padding(0);
            this.PnlDomicilio.Name = "PnlDomicilio";
            this.PnlDomicilio.Size = new System.Drawing.Size(912, 91);
            this.PnlDomicilio.TabIndex = 0;
            // 
            // GrpLocal
            // 
            this.GrpLocal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(54)))), ((int)(((byte)(58)))));
            this.GrpLocal.Background = System.Drawing.Color.Transparent;
            this.GrpLocal.BorderColor = System.Drawing.Color.Silver;
            this.GrpLocal.BorderSize = 5;
            this.GrpLocal.Controls.Add(this.PnlLocal);
            this.GrpLocal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrpLocal.Font = new System.Drawing.Font("Source Sans Pro", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpLocal.ForeColor = System.Drawing.Color.Silver;
            this.GrpLocal.Location = new System.Drawing.Point(0, 20);
            this.GrpLocal.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.GrpLocal.Name = "GrpLocal";
            this.GrpLocal.Padding = new System.Windows.Forms.Padding(20, 5, 20, 30);
            this.GrpLocal.Size = new System.Drawing.Size(952, 164);
            this.GrpLocal.TabIndex = 0;
            this.GrpLocal.TabStop = false;
            this.GrpLocal.Text = "Local";
            this.GrpLocal.TextActivated = true;
            // 
            // PnlLocal
            // 
            this.PnlLocal.AutoScroll = true;
            this.PnlLocal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlLocal.Font = new System.Drawing.Font("Source Sans Pro", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PnlLocal.Location = new System.Drawing.Point(20, 43);
            this.PnlLocal.Margin = new System.Windows.Forms.Padding(0);
            this.PnlLocal.Name = "PnlLocal";
            this.PnlLocal.Size = new System.Drawing.Size(912, 91);
            this.PnlLocal.TabIndex = 0;
            // 
            // FrmPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(54)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(1100, 685);
            this.Controls.Add(this.PnlMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmPedidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "Pedidos";
            this.Text = "Gestión de Pedidos - Garmoxu";
            this.EnabledChanged += new System.EventHandler(this.FrmPedidos_EnabledChanged);
            this.PnlMain.ResumeLayout(false);
            this.PnlFoot.ResumeLayout(false);
            this.PnlFoot.PerformLayout();
            this.PnlPedidos.ResumeLayout(false);
            this.GrpRecoger.ResumeLayout(false);
            this.GrpDomicilio.ResumeLayout(false);
            this.GrpLocal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Timer TmrComprobarCambiosPedidos;
        private System.Windows.Forms.TableLayoutPanel PnlMain;
        private System.Windows.Forms.TableLayoutPanel PnlPedidos;
        private MyGroupBox GrpRecoger;
        private System.Windows.Forms.FlowLayoutPanel PnlRecoger;
        private MyGroupBox GrpDomicilio;
        private System.Windows.Forms.FlowLayoutPanel PnlDomicilio;
        private MyGroupBox GrpLocal;
        private System.Windows.Forms.FlowLayoutPanel PnlLocal;
        private System.Windows.Forms.TableLayoutPanel PnlFoot;
        private FontAwesome.Sharp.IconButton BtnBuscar;
        private FontAwesome.Sharp.IconButton BtnNuevo;
        private RJCodeAdvance.RJControls.RJTextBox TxtBuscar;
    }
}