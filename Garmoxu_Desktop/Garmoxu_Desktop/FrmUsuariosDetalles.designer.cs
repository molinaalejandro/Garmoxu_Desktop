
namespace Garmoxu_Desktop
{
    partial class FrmUsuariosDetalles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsuariosDetalles));
            this.PnlDatos = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtUsuario = new RJCodeAdvance.RJControls.RJTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtNombre = new RJCodeAdvance.RJControls.RJTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CboTipoUsuario = new RJCodeAdvance.RJControls.RJComboBox();
            this.PnlBotones = new System.Windows.Forms.TableLayoutPanel();
            this.BtnGuardar = new RJCodeAdvance.RJControls.RJButton();
            this.BtnCancelar = new RJCodeAdvance.RJControls.RJButton();
            this.PnlTitleBar = new System.Windows.Forms.TableLayoutPanel();
            this.BtnClose = new FontAwesome.Sharp.IconButton();
            this.label4 = new System.Windows.Forms.Label();
            this.PnlPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.PnlDatos.SuspendLayout();
            this.PnlBotones.SuspendLayout();
            this.PnlTitleBar.SuspendLayout();
            this.PnlPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlDatos
            // 
            this.PnlDatos.ColumnCount = 3;
            this.PnlDatos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.PnlDatos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PnlDatos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.PnlDatos.Controls.Add(this.label1, 1, 0);
            this.PnlDatos.Controls.Add(this.TxtUsuario, 1, 1);
            this.PnlDatos.Controls.Add(this.label2, 1, 3);
            this.PnlDatos.Controls.Add(this.TxtNombre, 1, 4);
            this.PnlDatos.Controls.Add(this.label3, 1, 6);
            this.PnlDatos.Controls.Add(this.CboTipoUsuario, 1, 7);
            this.PnlDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlDatos.Location = new System.Drawing.Point(3, 125);
            this.PnlDatos.Name = "PnlDatos";
            this.PnlDatos.RowCount = 9;
            this.PnlDatos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.PnlDatos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.PnlDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.PnlDatos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.PnlDatos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.PnlDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.PnlDatos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.PnlDatos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.PnlDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PnlDatos.Size = new System.Drawing.Size(598, 365);
            this.PnlDatos.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Source Sans Pro", 15.2F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(73, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(452, 33);
            this.label1.TabIndex = 35;
            this.label1.Text = "Nombre de usuario";
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.TxtUsuario.BorderColor = System.Drawing.Color.Transparent;
            this.TxtUsuario.BorderFocusColor = System.Drawing.Color.Gainsboro;
            this.TxtUsuario.BorderRadius = 10;
            this.TxtUsuario.BorderSize = 2;
            this.TxtUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtUsuario.Font = new System.Drawing.Font("Source Sans Pro", 16.2F, System.Drawing.FontStyle.Bold);
            this.TxtUsuario.ForeColor = System.Drawing.Color.White;
            this.TxtUsuario.Location = new System.Drawing.Point(75, 38);
            this.TxtUsuario.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.TxtUsuario.Multiline = false;
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Padding = new System.Windows.Forms.Padding(13, 12, 13, 3);
            this.TxtUsuario.PasswordChar = false;
            this.TxtUsuario.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TxtUsuario.PlaceholderText = "";
            this.TxtUsuario.Size = new System.Drawing.Size(448, 52);
            this.TxtUsuario.TabIndex = 1;
            this.TxtUsuario.Texts = "";
            this.TxtUsuario.UnderlinedStyle = false;
            this.TxtUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Source Sans Pro", 15.2F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(73, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(452, 33);
            this.label2.TabIndex = 36;
            this.label2.Text = "Nombre y apellidos";
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
            this.TxtNombre.ForeColor = System.Drawing.Color.White;
            this.TxtNombre.Location = new System.Drawing.Point(75, 148);
            this.TxtNombre.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.TxtNombre.Multiline = false;
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Padding = new System.Windows.Forms.Padding(13, 12, 13, 3);
            this.TxtNombre.PasswordChar = false;
            this.TxtNombre.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TxtNombre.PlaceholderText = "";
            this.TxtNombre.Size = new System.Drawing.Size(448, 52);
            this.TxtNombre.TabIndex = 2;
            this.TxtNombre.Texts = "";
            this.TxtNombre.UnderlinedStyle = false;
            this.TxtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Source Sans Pro", 15.2F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(73, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(452, 33);
            this.label3.TabIndex = 26;
            this.label3.Text = "Tipo de usuario";
            // 
            // CboTipoUsuario
            // 
            this.CboTipoUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.CboTipoUsuario.BorderColor = System.Drawing.Color.Transparent;
            this.CboTipoUsuario.BorderSize = 0;
            this.CboTipoUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CboTipoUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboTipoUsuario.Font = new System.Drawing.Font("Source Sans Pro", 14.2F, System.Drawing.FontStyle.Bold);
            this.CboTipoUsuario.ForeColor = System.Drawing.Color.White;
            this.CboTipoUsuario.IconColor = System.Drawing.Color.White;
            this.CboTipoUsuario.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.CboTipoUsuario.ListTextColor = System.Drawing.Color.DimGray;
            this.CboTipoUsuario.Location = new System.Drawing.Point(75, 258);
            this.CboTipoUsuario.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.CboTipoUsuario.MinimumSize = new System.Drawing.Size(200, 30);
            this.CboTipoUsuario.Name = "CboTipoUsuario";
            this.CboTipoUsuario.Size = new System.Drawing.Size(448, 51);
            this.CboTipoUsuario.TabIndex = 3;
            this.CboTipoUsuario.TabStop = false;
            this.CboTipoUsuario.Texts = "";
            // 
            // PnlBotones
            // 
            this.PnlBotones.ColumnCount = 5;
            this.PnlBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.PnlBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.PnlBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.PnlBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.PnlBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.PnlBotones.Controls.Add(this.BtnGuardar, 1, 1);
            this.PnlBotones.Controls.Add(this.BtnCancelar, 3, 1);
            this.PnlBotones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlBotones.Location = new System.Drawing.Point(3, 496);
            this.PnlBotones.Name = "PnlBotones";
            this.PnlBotones.RowCount = 3;
            this.PnlBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PnlBotones.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.PnlBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PnlBotones.Size = new System.Drawing.Size(598, 129);
            this.PnlBotones.TabIndex = 44;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnGuardar.BackgroundColor = System.Drawing.Color.SeaGreen;
            this.BtnGuardar.BorderColor = System.Drawing.Color.Black;
            this.BtnGuardar.BorderRadius = 15;
            this.BtnGuardar.BorderSize = 0;
            this.BtnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGuardar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnGuardar.FlatAppearance.BorderSize = 0;
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardar.Font = new System.Drawing.Font("Source Sans Pro", 16.2F, System.Drawing.FontStyle.Bold);
            this.BtnGuardar.ForeColor = System.Drawing.Color.White;
            this.BtnGuardar.Location = new System.Drawing.Point(77, 34);
            this.BtnGuardar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(192, 60);
            this.BtnGuardar.TabIndex = 4;
            this.BtnGuardar.TabStop = false;
            this.BtnGuardar.Text = "Registrar";
            this.BtnGuardar.TextColor = System.Drawing.Color.White;
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.Crimson;
            this.BtnCancelar.BackgroundColor = System.Drawing.Color.Crimson;
            this.BtnCancelar.BorderColor = System.Drawing.Color.Black;
            this.BtnCancelar.BorderRadius = 15;
            this.BtnCancelar.BorderSize = 0;
            this.BtnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCancelar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnCancelar.FlatAppearance.BorderSize = 0;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Font = new System.Drawing.Font("Source Sans Pro", 16.2F, System.Drawing.FontStyle.Bold);
            this.BtnCancelar.ForeColor = System.Drawing.Color.White;
            this.BtnCancelar.Location = new System.Drawing.Point(327, 34);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(192, 60);
            this.BtnCancelar.TabIndex = 5;
            this.BtnCancelar.TabStop = false;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.TextColor = System.Drawing.Color.White;
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // PnlTitleBar
            // 
            this.PnlTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(45)))));
            this.PnlTitleBar.ColumnCount = 2;
            this.PnlTitleBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PnlTitleBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.PnlTitleBar.Controls.Add(this.BtnClose, 1, 0);
            this.PnlTitleBar.Controls.Add(this.label4, 0, 0);
            this.PnlTitleBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlTitleBar.Location = new System.Drawing.Point(0, 0);
            this.PnlTitleBar.Margin = new System.Windows.Forms.Padding(0);
            this.PnlTitleBar.Name = "PnlTitleBar";
            this.PnlTitleBar.RowCount = 1;
            this.PnlTitleBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PnlTitleBar.Size = new System.Drawing.Size(604, 72);
            this.PnlTitleBar.TabIndex = 54;
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.Color.Transparent;
            this.BtnClose.Dock = System.Windows.Forms.DockStyle.Right;
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
            this.BtnClose.Location = new System.Drawing.Point(537, 0);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(0);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(67, 72);
            this.BtnClose.TabIndex = 2;
            this.BtnClose.TabStop = false;
            this.BtnClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Source Sans Pro", 18F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(14, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(523, 72);
            this.label4.TabIndex = 52;
            this.label4.Text = "Crea un nuevo usuario";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PnlPrincipal
            // 
            this.PnlPrincipal.ColumnCount = 1;
            this.PnlPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PnlPrincipal.Controls.Add(this.PnlTitleBar, 0, 0);
            this.PnlPrincipal.Controls.Add(this.PnlBotones, 0, 3);
            this.PnlPrincipal.Controls.Add(this.PnlDatos, 0, 2);
            this.PnlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlPrincipal.Location = new System.Drawing.Point(0, 0);
            this.PnlPrincipal.Name = "PnlPrincipal";
            this.PnlPrincipal.RowCount = 4;
            this.PnlPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.PnlPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.PnlPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PnlPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.PnlPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.PnlPrincipal.Size = new System.Drawing.Size(604, 628);
            this.PnlPrincipal.TabIndex = 3;
            // 
            // FrmUsuariosDetalles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(54)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(604, 628);
            this.Controls.Add(this.PnlPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmUsuariosDetalles";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear nuevo usuario - Garmoxu";
            this.TopMost = true;
            this.PnlDatos.ResumeLayout(false);
            this.PnlDatos.PerformLayout();
            this.PnlBotones.ResumeLayout(false);
            this.PnlTitleBar.ResumeLayout(false);
            this.PnlTitleBar.PerformLayout();
            this.PnlPrincipal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel PnlDatos;
        private System.Windows.Forms.Label label1;
        private RJCodeAdvance.RJControls.RJTextBox TxtUsuario;
        private System.Windows.Forms.Label label2;
        private RJCodeAdvance.RJControls.RJTextBox TxtNombre;
        private System.Windows.Forms.Label label3;
        private RJCodeAdvance.RJControls.RJComboBox CboTipoUsuario;
        private System.Windows.Forms.TableLayoutPanel PnlBotones;
        private RJCodeAdvance.RJControls.RJButton BtnGuardar;
        private RJCodeAdvance.RJControls.RJButton BtnCancelar;
        private System.Windows.Forms.TableLayoutPanel PnlTitleBar;
        private FontAwesome.Sharp.IconButton BtnClose;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel PnlPrincipal;
    }
}