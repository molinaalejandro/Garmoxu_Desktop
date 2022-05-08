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
            this.PnlMain = new System.Windows.Forms.TableLayoutPanel();
            this.PnlHeader = new System.Windows.Forms.Panel();
            this.PnlSubHeader = new System.Windows.Forms.TableLayoutPanel();
            this.BtnSimple = new RJCodeAdvance.RJControls.RJButton();
            this.BtnMapping = new RJCodeAdvance.RJControls.RJButton();
            this.TabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.TabSimple = new System.Windows.Forms.TabPage();
            this.PanelPedidos = new System.Windows.Forms.TableLayoutPanel();
            this.GrpRecoger = new Garmoxu_Desktop.MyGroupBox();
            this.PnlRecoger = new System.Windows.Forms.FlowLayoutPanel();
            this.GrpDomicilio = new Garmoxu_Desktop.MyGroupBox();
            this.PnlDomicilio = new System.Windows.Forms.FlowLayoutPanel();
            this.GrpLocal = new Garmoxu_Desktop.MyGroupBox();
            this.PnlLocal = new System.Windows.Forms.FlowLayoutPanel();
            this.PnlFoot = new System.Windows.Forms.TableLayoutPanel();
            this.PnlNuevo = new System.Windows.Forms.Panel();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.BtnCerrar = new RJCodeAdvance.RJControls.RJButton();
            this.BtnNuevo = new RJCodeAdvance.RJControls.RJButton();
            this.TabMapping = new System.Windows.Forms.TabPage();
            this.TmrComprobarCambiosPedidos = new System.Windows.Forms.Timer(this.components);
            this.PnlMain.SuspendLayout();
            this.PnlHeader.SuspendLayout();
            this.PnlSubHeader.SuspendLayout();
            this.TabControl.SuspendLayout();
            this.TabSimple.SuspendLayout();
            this.PanelPedidos.SuspendLayout();
            this.GrpRecoger.SuspendLayout();
            this.GrpDomicilio.SuspendLayout();
            this.GrpLocal.SuspendLayout();
            this.PnlFoot.SuspendLayout();
            this.PnlNuevo.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlMain
            // 
            this.PnlMain.ColumnCount = 1;
            this.PnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PnlMain.Controls.Add(this.PnlHeader, 0, 0);
            this.PnlMain.Controls.Add(this.TabControl, 0, 1);
            this.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlMain.Location = new System.Drawing.Point(0, 0);
            this.PnlMain.Margin = new System.Windows.Forms.Padding(4);
            this.PnlMain.Name = "PnlMain";
            this.PnlMain.RowCount = 2;
            this.PnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.PnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88F));
            this.PnlMain.Size = new System.Drawing.Size(1067, 683);
            this.PnlMain.TabIndex = 7;
            // 
            // PnlHeader
            // 
            this.PnlHeader.Controls.Add(this.PnlSubHeader);
            this.PnlHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlHeader.Location = new System.Drawing.Point(4, 4);
            this.PnlHeader.Margin = new System.Windows.Forms.Padding(4);
            this.PnlHeader.Name = "PnlHeader";
            this.PnlHeader.Padding = new System.Windows.Forms.Padding(27, 12, 27, 0);
            this.PnlHeader.Size = new System.Drawing.Size(1059, 73);
            this.PnlHeader.TabIndex = 7;
            // 
            // PnlSubHeader
            // 
            this.PnlSubHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(41)))), ((int)(((byte)(83)))));
            this.PnlSubHeader.ColumnCount = 2;
            this.PnlSubHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PnlSubHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.PnlSubHeader.Controls.Add(this.BtnSimple, 0, 0);
            this.PnlSubHeader.Controls.Add(this.BtnMapping, 1, 0);
            this.PnlSubHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlSubHeader.Location = new System.Drawing.Point(27, 12);
            this.PnlSubHeader.Margin = new System.Windows.Forms.Padding(4);
            this.PnlSubHeader.Name = "PnlSubHeader";
            this.PnlSubHeader.RowCount = 1;
            this.PnlSubHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PnlSubHeader.Size = new System.Drawing.Size(1005, 61);
            this.PnlSubHeader.TabIndex = 8;
            // 
            // BtnSimple
            // 
            this.BtnSimple.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(41)))), ((int)(((byte)(83)))));
            this.BtnSimple.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(41)))), ((int)(((byte)(83)))));
            this.BtnSimple.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnSimple.BorderRadius = 0;
            this.BtnSimple.BorderSize = 0;
            this.BtnSimple.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnSimple.FlatAppearance.BorderSize = 0;
            this.BtnSimple.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSimple.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSimple.ForeColor = System.Drawing.Color.White;
            this.BtnSimple.Location = new System.Drawing.Point(4, 4);
            this.BtnSimple.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSimple.Name = "BtnSimple";
            this.BtnSimple.Size = new System.Drawing.Size(844, 53);
            this.BtnSimple.TabIndex = 0;
            this.BtnSimple.Text = "Pedidos";
            this.BtnSimple.TextColor = System.Drawing.Color.White;
            this.BtnSimple.UseVisualStyleBackColor = false;
            this.BtnSimple.Click += new System.EventHandler(this.BtnSimple_Click);
            this.BtnSimple.MouseEnter += new System.EventHandler(this.BtnSimple_MouseEnter);
            // 
            // BtnMapping
            // 
            this.BtnMapping.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnMapping.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnMapping.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnMapping.BorderRadius = 0;
            this.BtnMapping.BorderSize = 0;
            this.BtnMapping.FlatAppearance.BorderSize = 0;
            this.BtnMapping.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMapping.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMapping.ForeColor = System.Drawing.Color.White;
            this.BtnMapping.Location = new System.Drawing.Point(856, 4);
            this.BtnMapping.Margin = new System.Windows.Forms.Padding(4);
            this.BtnMapping.Name = "BtnMapping";
            this.BtnMapping.Size = new System.Drawing.Size(145, 53);
            this.BtnMapping.TabIndex = 1;
            this.BtnMapping.Text = "Mesas";
            this.BtnMapping.TextColor = System.Drawing.Color.White;
            this.BtnMapping.UseVisualStyleBackColor = false;
            this.BtnMapping.Visible = false;
            this.BtnMapping.Click += new System.EventHandler(this.BtnMapping_Click);
            this.BtnMapping.MouseEnter += new System.EventHandler(this.BtnMapping_MouseEnter);
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.TabSimple);
            this.TabControl.Controls.Add(this.TabMapping);
            this.TabControl.Depth = 0;
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Location = new System.Drawing.Point(4, 85);
            this.TabControl.Margin = new System.Windows.Forms.Padding(4);
            this.TabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(1059, 594);
            this.TabControl.TabIndex = 8;
            // 
            // TabSimple
            // 
            this.TabSimple.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(54)))), ((int)(((byte)(58)))));
            this.TabSimple.Controls.Add(this.PanelPedidos);
            this.TabSimple.Location = new System.Drawing.Point(4, 25);
            this.TabSimple.Margin = new System.Windows.Forms.Padding(4);
            this.TabSimple.Name = "TabSimple";
            this.TabSimple.Padding = new System.Windows.Forms.Padding(27, 12, 27, 25);
            this.TabSimple.Size = new System.Drawing.Size(1051, 565);
            this.TabSimple.TabIndex = 0;
            this.TabSimple.Text = "tabPage1";
            // 
            // PanelPedidos
            // 
            this.PanelPedidos.BackColor = System.Drawing.Color.Transparent;
            this.PanelPedidos.ColumnCount = 1;
            this.PanelPedidos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PanelPedidos.Controls.Add(this.GrpRecoger, 0, 2);
            this.PanelPedidos.Controls.Add(this.GrpDomicilio, 0, 1);
            this.PanelPedidos.Controls.Add(this.GrpLocal, 0, 0);
            this.PanelPedidos.Controls.Add(this.PnlFoot, 0, 3);
            this.PanelPedidos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelPedidos.Location = new System.Drawing.Point(27, 12);
            this.PanelPedidos.Margin = new System.Windows.Forms.Padding(4);
            this.PanelPedidos.Name = "PanelPedidos";
            this.PanelPedidos.RowCount = 4;
            this.PanelPedidos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.PanelPedidos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.PanelPedidos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.PanelPedidos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.PanelPedidos.Size = new System.Drawing.Size(997, 528);
            this.PanelPedidos.TabIndex = 7;
            // 
            // GrpRecoger
            // 
            this.GrpRecoger.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(54)))), ((int)(((byte)(58)))));
            this.GrpRecoger.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.GrpRecoger.Controls.Add(this.PnlRecoger);
            this.GrpRecoger.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrpRecoger.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpRecoger.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(41)))), ((int)(((byte)(83)))));
            this.GrpRecoger.Location = new System.Drawing.Point(4, 320);
            this.GrpRecoger.Margin = new System.Windows.Forms.Padding(4);
            this.GrpRecoger.Name = "GrpRecoger";
            this.GrpRecoger.Padding = new System.Windows.Forms.Padding(4);
            this.GrpRecoger.Size = new System.Drawing.Size(989, 150);
            this.GrpRecoger.TabIndex = 2;
            this.GrpRecoger.TabStop = false;
            this.GrpRecoger.Text = "Recoger";
            // 
            // PnlRecoger
            // 
            this.PnlRecoger.AutoScroll = true;
            this.PnlRecoger.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlRecoger.Location = new System.Drawing.Point(4, 33);
            this.PnlRecoger.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PnlRecoger.Name = "PnlRecoger";
            this.PnlRecoger.Size = new System.Drawing.Size(981, 113);
            this.PnlRecoger.TabIndex = 2;
            // 
            // GrpDomicilio
            // 
            this.GrpDomicilio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(54)))), ((int)(((byte)(58)))));
            this.GrpDomicilio.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.GrpDomicilio.Controls.Add(this.PnlDomicilio);
            this.GrpDomicilio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrpDomicilio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpDomicilio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(41)))), ((int)(((byte)(83)))));
            this.GrpDomicilio.Location = new System.Drawing.Point(4, 162);
            this.GrpDomicilio.Margin = new System.Windows.Forms.Padding(4);
            this.GrpDomicilio.Name = "GrpDomicilio";
            this.GrpDomicilio.Padding = new System.Windows.Forms.Padding(4);
            this.GrpDomicilio.Size = new System.Drawing.Size(989, 150);
            this.GrpDomicilio.TabIndex = 1;
            this.GrpDomicilio.TabStop = false;
            this.GrpDomicilio.Text = "A Domicilio ";
            // 
            // PnlDomicilio
            // 
            this.PnlDomicilio.AutoScroll = true;
            this.PnlDomicilio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlDomicilio.Location = new System.Drawing.Point(4, 33);
            this.PnlDomicilio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PnlDomicilio.Name = "PnlDomicilio";
            this.PnlDomicilio.Size = new System.Drawing.Size(981, 113);
            this.PnlDomicilio.TabIndex = 1;
            // 
            // GrpLocal
            // 
            this.GrpLocal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(54)))), ((int)(((byte)(58)))));
            this.GrpLocal.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.GrpLocal.Controls.Add(this.PnlLocal);
            this.GrpLocal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrpLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpLocal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(41)))), ((int)(((byte)(83)))));
            this.GrpLocal.Location = new System.Drawing.Point(4, 4);
            this.GrpLocal.Margin = new System.Windows.Forms.Padding(4);
            this.GrpLocal.Name = "GrpLocal";
            this.GrpLocal.Padding = new System.Windows.Forms.Padding(4);
            this.GrpLocal.Size = new System.Drawing.Size(989, 150);
            this.GrpLocal.TabIndex = 0;
            this.GrpLocal.TabStop = false;
            this.GrpLocal.Text = "Local";
            // 
            // PnlLocal
            // 
            this.PnlLocal.AutoScroll = true;
            this.PnlLocal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlLocal.Location = new System.Drawing.Point(4, 33);
            this.PnlLocal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PnlLocal.Name = "PnlLocal";
            this.PnlLocal.Size = new System.Drawing.Size(981, 113);
            this.PnlLocal.TabIndex = 0;
            // 
            // PnlFoot
            // 
            this.PnlFoot.ColumnCount = 3;
            this.PnlFoot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.PnlFoot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.PnlFoot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.PnlFoot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.PnlFoot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.PnlFoot.Controls.Add(this.PnlNuevo, 1, 0);
            this.PnlFoot.Controls.Add(this.BtnCerrar, 0, 0);
            this.PnlFoot.Controls.Add(this.BtnNuevo, 2, 0);
            this.PnlFoot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlFoot.Location = new System.Drawing.Point(4, 478);
            this.PnlFoot.Margin = new System.Windows.Forms.Padding(4);
            this.PnlFoot.Name = "PnlFoot";
            this.PnlFoot.RowCount = 1;
            this.PnlFoot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PnlFoot.Size = new System.Drawing.Size(989, 46);
            this.PnlFoot.TabIndex = 3;
            // 
            // PnlNuevo
            // 
            this.PnlNuevo.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.PnlNuevo.Controls.Add(this.TxtBuscar);
            this.PnlNuevo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlNuevo.Location = new System.Drawing.Point(184, 4);
            this.PnlNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.PnlNuevo.Name = "PnlNuevo";
            this.PnlNuevo.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PnlNuevo.Size = new System.Drawing.Size(437, 26);
            this.PnlNuevo.TabIndex = 16;
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBuscar.Dock = System.Windows.Forms.DockStyle.Right;
            this.TxtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBuscar.Location = new System.Drawing.Point(-2, 0);
            this.TxtBuscar.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(435, 25);
            this.TxtBuscar.TabIndex = 2;
            this.TxtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBuscar_KeyPress);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnCerrar.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnCerrar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnCerrar.BorderRadius = 0;
            this.BtnCerrar.BorderSize = 0;
            this.BtnCerrar.FlatAppearance.BorderSize = 0;
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCerrar.ForeColor = System.Drawing.Color.White;
            this.BtnCerrar.Location = new System.Drawing.Point(4, 4);
            this.BtnCerrar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(172, 38);
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
            this.BtnNuevo.FlatAppearance.BorderSize = 0;
            this.BtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNuevo.ForeColor = System.Drawing.Color.White;
            this.BtnNuevo.Location = new System.Drawing.Point(629, 4);
            this.BtnNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(155, 38);
            this.BtnNuevo.TabIndex = 17;
            this.BtnNuevo.Text = "Nuevo";
            this.BtnNuevo.TextColor = System.Drawing.Color.White;
            this.BtnNuevo.UseVisualStyleBackColor = false;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // TabMapping
            // 
            this.TabMapping.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(54)))), ((int)(((byte)(58)))));
            this.TabMapping.Location = new System.Drawing.Point(4, 25);
            this.TabMapping.Margin = new System.Windows.Forms.Padding(4);
            this.TabMapping.Name = "TabMapping";
            this.TabMapping.Padding = new System.Windows.Forms.Padding(27, 12, 27, 25);
            this.TabMapping.Size = new System.Drawing.Size(1051, 565);
            this.TabMapping.TabIndex = 1;
            this.TabMapping.Text = "tabPage2";
            // 
            // TmrComprobarCambiosPedidos
            // 
            this.TmrComprobarCambiosPedidos.Enabled = true;
            this.TmrComprobarCambiosPedidos.Interval = 1000;
            this.TmrComprobarCambiosPedidos.Tick += new System.EventHandler(this.TmrComprobarCambiosPedidos_Tick);
            // 
            // FrmPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(54)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(1067, 683);
            this.Controls.Add(this.PnlMain);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmPedidos";
            this.Tag = "Pedidos";
            this.Text = "FrmPedidos";
            this.PnlMain.ResumeLayout(false);
            this.PnlHeader.ResumeLayout(false);
            this.PnlSubHeader.ResumeLayout(false);
            this.TabControl.ResumeLayout(false);
            this.TabSimple.ResumeLayout(false);
            this.PanelPedidos.ResumeLayout(false);
            this.GrpRecoger.ResumeLayout(false);
            this.GrpDomicilio.ResumeLayout(false);
            this.GrpLocal.ResumeLayout(false);
            this.PnlFoot.ResumeLayout(false);
            this.PnlNuevo.ResumeLayout(false);
            this.PnlNuevo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel PnlMain;
        private System.Windows.Forms.Panel PnlHeader;
        private MaterialSkin.Controls.MaterialTabControl TabControl;
        private System.Windows.Forms.TabPage TabSimple;
        private System.Windows.Forms.TableLayoutPanel PanelPedidos;
        private MyGroupBox GrpRecoger;
        private MyGroupBox GrpDomicilio;
        private MyGroupBox GrpLocal;
        private System.Windows.Forms.TabPage TabMapping;
        private System.Windows.Forms.TableLayoutPanel PnlFoot;
        private RJCodeAdvance.RJControls.RJButton BtnCerrar;
        private System.Windows.Forms.Panel PnlNuevo;
        private System.Windows.Forms.TextBox TxtBuscar;
        private RJCodeAdvance.RJControls.RJButton BtnNuevo;
        private System.Windows.Forms.FlowLayoutPanel PnlLocal;
        private System.Windows.Forms.FlowLayoutPanel PnlRecoger;
        private System.Windows.Forms.FlowLayoutPanel PnlDomicilio;
        public System.Windows.Forms.Timer TmrComprobarCambiosPedidos;
        private System.Windows.Forms.TableLayoutPanel PnlSubHeader;
        private RJCodeAdvance.RJControls.RJButton BtnSimple;
        private RJCodeAdvance.RJControls.RJButton BtnMapping;
    }
}