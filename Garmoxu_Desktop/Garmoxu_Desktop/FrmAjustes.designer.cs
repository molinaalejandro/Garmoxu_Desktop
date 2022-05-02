namespace Garmoxu_Desktop
{
    partial class FrmAjustes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAjustes));
            this.PnlBody = new System.Windows.Forms.TableLayoutPanel();
            this.PnlMid = new System.Windows.Forms.TableLayoutPanel();
            this.BtnClose = new FontAwesome.Sharp.IconButton();
            this.PnlPerfil = new System.Windows.Forms.TableLayoutPanel();
            this.PnlPerfilDetalles = new System.Windows.Forms.TableLayoutPanel();
            this.LblPerfil = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.PnlPerfilBoton = new System.Windows.Forms.TableLayoutPanel();
            this.BtnReset = new RJCodeAdvance.RJControls.RJButton();
            this.BtnEditar = new RJCodeAdvance.RJControls.RJButton();
            this.PicPerfil = new RJCodeAdvance.RJControls.RJCircularPictureBox();
            this.PnlHorario = new System.Windows.Forms.TableLayoutPanel();
            this.BtnCerrarSesion = new RJCodeAdvance.RJControls.RJButton();
            this.GrpSalida = new Garmoxu_Desktop.MyGroupBox();
            this.DtpSalida = new RJCodeAdvance.RJControls.RJDatePicker();
            this.GrpEntrada = new Garmoxu_Desktop.MyGroupBox();
            this.DtpEntrada = new RJCodeAdvance.RJControls.RJDatePicker();
            this.myGroupBox1 = new Garmoxu_Desktop.MyGroupBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.myGroupBox2 = new Garmoxu_Desktop.MyGroupBox();
            this.CboVentana = new RJCodeAdvance.RJControls.RJComboBox();
            this.myGroupBox3 = new Garmoxu_Desktop.MyGroupBox();
            this.RadOscuro = new RJCodeAdvance.RJControls.RJRadioButton();
            this.RadClaro = new RJCodeAdvance.RJControls.RJRadioButton();
            this.PnlBody.SuspendLayout();
            this.PnlMid.SuspendLayout();
            this.PnlPerfil.SuspendLayout();
            this.PnlPerfilDetalles.SuspendLayout();
            this.PnlPerfilBoton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicPerfil)).BeginInit();
            this.PnlHorario.SuspendLayout();
            this.GrpSalida.SuspendLayout();
            this.GrpEntrada.SuspendLayout();
            this.myGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.myGroupBox2.SuspendLayout();
            this.myGroupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlBody
            // 
            this.PnlBody.ColumnCount = 3;
            this.PnlBody.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28F));
            this.PnlBody.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44F));
            this.PnlBody.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28F));
            this.PnlBody.Controls.Add(this.PnlMid, 1, 0);
            this.PnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlBody.Location = new System.Drawing.Point(0, 0);
            this.PnlBody.Name = "PnlBody";
            this.PnlBody.RowCount = 1;
            this.PnlBody.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PnlBody.Size = new System.Drawing.Size(1151, 718);
            this.PnlBody.TabIndex = 0;
            // 
            // PnlMid
            // 
            this.PnlMid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(64)))), ((int)(((byte)(68)))));
            this.PnlMid.ColumnCount = 1;
            this.PnlMid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PnlMid.Controls.Add(this.BtnClose, 0, 0);
            this.PnlMid.Controls.Add(this.PnlPerfil, 0, 1);
            this.PnlMid.Controls.Add(this.PnlHorario, 0, 2);
            this.PnlMid.Controls.Add(this.myGroupBox1, 0, 3);
            this.PnlMid.Controls.Add(this.myGroupBox2, 0, 4);
            this.PnlMid.Controls.Add(this.myGroupBox3, 0, 5);
            this.PnlMid.Controls.Add(this.BtnCerrarSesion, 0, 6);
            this.PnlMid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlMid.Location = new System.Drawing.Point(325, 3);
            this.PnlMid.Name = "PnlMid";
            this.PnlMid.Padding = new System.Windows.Forms.Padding(10);
            this.PnlMid.RowCount = 8;
            this.PnlMid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.PnlMid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32F));
            this.PnlMid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.PnlMid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.PnlMid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.PnlMid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.PnlMid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.PnlMid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.PnlMid.Size = new System.Drawing.Size(500, 712);
            this.PnlMid.TabIndex = 0;
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.Color.Transparent;
            this.BtnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnClose.FlatAppearance.BorderSize = 0;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.BtnClose.IconColor = System.Drawing.Color.White;
            this.BtnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnClose.IconSize = 20;
            this.BtnClose.Location = new System.Drawing.Point(453, 14);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(4);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(33, 26);
            this.BtnClose.TabIndex = 6;
            this.BtnClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnClose.UseVisualStyleBackColor = false;
            // 
            // PnlPerfil
            // 
            this.PnlPerfil.ColumnCount = 2;
            this.PnlPerfil.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.PnlPerfil.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.PnlPerfil.Controls.Add(this.PnlPerfilDetalles, 1, 0);
            this.PnlPerfil.Controls.Add(this.PicPerfil, 0, 0);
            this.PnlPerfil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlPerfil.Location = new System.Drawing.Point(13, 47);
            this.PnlPerfil.Name = "PnlPerfil";
            this.PnlPerfil.RowCount = 1;
            this.PnlPerfil.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PnlPerfil.Size = new System.Drawing.Size(474, 215);
            this.PnlPerfil.TabIndex = 0;
            // 
            // PnlPerfilDetalles
            // 
            this.PnlPerfilDetalles.ColumnCount = 1;
            this.PnlPerfilDetalles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PnlPerfilDetalles.Controls.Add(this.LblPerfil, 0, 0);
            this.PnlPerfilDetalles.Controls.Add(this.TxtNombre, 0, 1);
            this.PnlPerfilDetalles.Controls.Add(this.PnlPerfilBoton, 0, 2);
            this.PnlPerfilDetalles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlPerfilDetalles.Location = new System.Drawing.Point(145, 3);
            this.PnlPerfilDetalles.Name = "PnlPerfilDetalles";
            this.PnlPerfilDetalles.RowCount = 3;
            this.PnlPerfilDetalles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.PnlPerfilDetalles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.PnlPerfilDetalles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.PnlPerfilDetalles.Size = new System.Drawing.Size(326, 209);
            this.PnlPerfilDetalles.TabIndex = 0;
            // 
            // LblPerfil
            // 
            this.LblPerfil.AutoSize = true;
            this.LblPerfil.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblPerfil.ForeColor = System.Drawing.Color.White;
            this.LblPerfil.Location = new System.Drawing.Point(3, 0);
            this.LblPerfil.Name = "LblPerfil";
            this.LblPerfil.Size = new System.Drawing.Size(320, 17);
            this.LblPerfil.TabIndex = 0;
            this.LblPerfil.Text = "Nombre de Usuario";
            // 
            // TxtNombre
            // 
            this.TxtNombre.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.TxtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtNombre.Dock = System.Windows.Forms.DockStyle.Top;
            this.TxtNombre.Location = new System.Drawing.Point(3, 72);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(320, 15);
            this.TxtNombre.TabIndex = 1;
            // 
            // PnlPerfilBoton
            // 
            this.PnlPerfilBoton.ColumnCount = 2;
            this.PnlPerfilBoton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PnlPerfilBoton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PnlPerfilBoton.Controls.Add(this.BtnReset, 0, 0);
            this.PnlPerfilBoton.Controls.Add(this.BtnEditar, 1, 0);
            this.PnlPerfilBoton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlPerfilBoton.Location = new System.Drawing.Point(3, 141);
            this.PnlPerfilBoton.Name = "PnlPerfilBoton";
            this.PnlPerfilBoton.RowCount = 1;
            this.PnlPerfilBoton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PnlPerfilBoton.Size = new System.Drawing.Size(320, 65);
            this.PnlPerfilBoton.TabIndex = 2;
            // 
            // BtnReset
            // 
            this.BtnReset.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnReset.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnReset.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnReset.BorderRadius = 5;
            this.BtnReset.BorderSize = 0;
            this.BtnReset.FlatAppearance.BorderSize = 0;
            this.BtnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReset.ForeColor = System.Drawing.Color.White;
            this.BtnReset.Location = new System.Drawing.Point(3, 3);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(150, 40);
            this.BtnReset.TabIndex = 0;
            this.BtnReset.Text = "Contraseña";
            this.BtnReset.TextColor = System.Drawing.Color.White;
            this.BtnReset.UseVisualStyleBackColor = false;
            this.BtnReset.Visible = false;
            // 
            // BtnEditar
            // 
            this.BtnEditar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnEditar.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnEditar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnEditar.BorderRadius = 5;
            this.BtnEditar.BorderSize = 0;
            this.BtnEditar.FlatAppearance.BorderSize = 0;
            this.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditar.ForeColor = System.Drawing.Color.White;
            this.BtnEditar.Location = new System.Drawing.Point(163, 3);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(150, 40);
            this.BtnEditar.TabIndex = 1;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.TextColor = System.Drawing.Color.White;
            this.BtnEditar.UseVisualStyleBackColor = false;
            // 
            // PicPerfil
            // 
            this.PicPerfil.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.PicPerfil.BorderColor = System.Drawing.Color.RoyalBlue;
            this.PicPerfil.BorderColor2 = System.Drawing.Color.HotPink;
            this.PicPerfil.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.PicPerfil.BorderSize = 2;
            this.PicPerfil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PicPerfil.GradientAngle = 50F;
            this.PicPerfil.Location = new System.Drawing.Point(10, 10);
            this.PicPerfil.Margin = new System.Windows.Forms.Padding(10);
            this.PicPerfil.Name = "PicPerfil";
            this.PicPerfil.Size = new System.Drawing.Size(122, 122);
            this.PicPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicPerfil.TabIndex = 1;
            this.PicPerfil.TabStop = false;
            // 
            // PnlHorario
            // 
            this.PnlHorario.ColumnCount = 2;
            this.PnlHorario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PnlHorario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PnlHorario.Controls.Add(this.GrpSalida, 1, 0);
            this.PnlHorario.Controls.Add(this.GrpEntrada, 0, 0);
            this.PnlHorario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlHorario.Location = new System.Drawing.Point(13, 268);
            this.PnlHorario.Name = "PnlHorario";
            this.PnlHorario.RowCount = 1;
            this.PnlHorario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PnlHorario.Size = new System.Drawing.Size(474, 77);
            this.PnlHorario.TabIndex = 1;
            // 
            // BtnCerrarSesion
            // 
            this.BtnCerrarSesion.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnCerrarSesion.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnCerrarSesion.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnCerrarSesion.BorderRadius = 18;
            this.BtnCerrarSesion.BorderSize = 0;
            this.BtnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.BtnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrarSesion.ForeColor = System.Drawing.Color.White;
            this.BtnCerrarSesion.Location = new System.Drawing.Point(13, 600);
            this.BtnCerrarSesion.Name = "BtnCerrarSesion";
            this.BtnCerrarSesion.Size = new System.Drawing.Size(150, 40);
            this.BtnCerrarSesion.TabIndex = 5;
            this.BtnCerrarSesion.Text = "Cerrar Sesion";
            this.BtnCerrarSesion.TextColor = System.Drawing.Color.White;
            this.BtnCerrarSesion.UseVisualStyleBackColor = false;
            // 
            // GrpSalida
            // 
            this.GrpSalida.BorderColor = System.Drawing.Color.Transparent;
            this.GrpSalida.Controls.Add(this.DtpSalida);
            this.GrpSalida.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrpSalida.ForeColor = System.Drawing.Color.White;
            this.GrpSalida.Location = new System.Drawing.Point(240, 3);
            this.GrpSalida.Name = "GrpSalida";
            this.GrpSalida.Size = new System.Drawing.Size(231, 71);
            this.GrpSalida.TabIndex = 1;
            this.GrpSalida.TabStop = false;
            this.GrpSalida.Text = "Horario de Salida";
            // 
            // DtpSalida
            // 
            this.DtpSalida.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.DtpSalida.BorderSize = 0;
            this.DtpSalida.Dock = System.Windows.Forms.DockStyle.Left;
            this.DtpSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.DtpSalida.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.DtpSalida.Location = new System.Drawing.Point(3, 18);
            this.DtpSalida.MinimumSize = new System.Drawing.Size(4, 35);
            this.DtpSalida.Name = "DtpSalida";
            this.DtpSalida.Size = new System.Drawing.Size(155, 35);
            this.DtpSalida.SkinColor = System.Drawing.Color.MediumSlateBlue;
            this.DtpSalida.TabIndex = 1;
            this.DtpSalida.TextColor = System.Drawing.Color.White;
            // 
            // GrpEntrada
            // 
            this.GrpEntrada.BorderColor = System.Drawing.Color.Transparent;
            this.GrpEntrada.Controls.Add(this.DtpEntrada);
            this.GrpEntrada.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrpEntrada.ForeColor = System.Drawing.Color.White;
            this.GrpEntrada.Location = new System.Drawing.Point(3, 3);
            this.GrpEntrada.Name = "GrpEntrada";
            this.GrpEntrada.Size = new System.Drawing.Size(231, 71);
            this.GrpEntrada.TabIndex = 0;
            this.GrpEntrada.TabStop = false;
            this.GrpEntrada.Text = "Horario de Entrada";
            // 
            // DtpEntrada
            // 
            this.DtpEntrada.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.DtpEntrada.BorderSize = 0;
            this.DtpEntrada.Dock = System.Windows.Forms.DockStyle.Left;
            this.DtpEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.DtpEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.DtpEntrada.Location = new System.Drawing.Point(3, 18);
            this.DtpEntrada.MinimumSize = new System.Drawing.Size(4, 35);
            this.DtpEntrada.Name = "DtpEntrada";
            this.DtpEntrada.Size = new System.Drawing.Size(147, 35);
            this.DtpEntrada.SkinColor = System.Drawing.Color.MediumSlateBlue;
            this.DtpEntrada.TabIndex = 0;
            this.DtpEntrada.TextColor = System.Drawing.Color.White;
            // 
            // myGroupBox1
            // 
            this.myGroupBox1.BorderColor = System.Drawing.Color.Transparent;
            this.myGroupBox1.Controls.Add(this.numericUpDown1);
            this.myGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myGroupBox1.ForeColor = System.Drawing.Color.White;
            this.myGroupBox1.Location = new System.Drawing.Point(13, 351);
            this.myGroupBox1.Name = "myGroupBox1";
            this.myGroupBox1.Size = new System.Drawing.Size(474, 77);
            this.myGroupBox1.TabIndex = 2;
            this.myGroupBox1.TabStop = false;
            this.myGroupBox1.Text = "IVA en los pedidos";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(35, 22);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 0;
            // 
            // myGroupBox2
            // 
            this.myGroupBox2.BorderColor = System.Drawing.Color.Transparent;
            this.myGroupBox2.Controls.Add(this.CboVentana);
            this.myGroupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myGroupBox2.ForeColor = System.Drawing.Color.White;
            this.myGroupBox2.Location = new System.Drawing.Point(13, 434);
            this.myGroupBox2.Name = "myGroupBox2";
            this.myGroupBox2.Size = new System.Drawing.Size(474, 77);
            this.myGroupBox2.TabIndex = 3;
            this.myGroupBox2.TabStop = false;
            this.myGroupBox2.Text = "Inicio de Modo de Ventana";
            // 
            // CboVentana
            // 
            this.CboVentana.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CboVentana.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.CboVentana.BorderSize = 1;
            this.CboVentana.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboVentana.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CboVentana.ForeColor = System.Drawing.Color.DimGray;
            this.CboVentana.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.CboVentana.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.CboVentana.ListTextColor = System.Drawing.Color.DimGray;
            this.CboVentana.Location = new System.Drawing.Point(35, 21);
            this.CboVentana.MinimumSize = new System.Drawing.Size(200, 30);
            this.CboVentana.Name = "CboVentana";
            this.CboVentana.Padding = new System.Windows.Forms.Padding(1);
            this.CboVentana.Size = new System.Drawing.Size(200, 30);
            this.CboVentana.TabIndex = 0;
            this.CboVentana.Texts = "";
            // 
            // myGroupBox3
            // 
            this.myGroupBox3.BorderColor = System.Drawing.Color.Transparent;
            this.myGroupBox3.Controls.Add(this.RadOscuro);
            this.myGroupBox3.Controls.Add(this.RadClaro);
            this.myGroupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myGroupBox3.ForeColor = System.Drawing.Color.White;
            this.myGroupBox3.Location = new System.Drawing.Point(13, 517);
            this.myGroupBox3.Name = "myGroupBox3";
            this.myGroupBox3.Size = new System.Drawing.Size(474, 77);
            this.myGroupBox3.TabIndex = 4;
            this.myGroupBox3.TabStop = false;
            this.myGroupBox3.Text = "Tema de Apariencia";
            // 
            // RadOscuro
            // 
            this.RadOscuro.AutoSize = true;
            this.RadOscuro.CheckedColor = System.Drawing.Color.MediumSlateBlue;
            this.RadOscuro.Location = new System.Drawing.Point(122, 21);
            this.RadOscuro.MinimumSize = new System.Drawing.Size(0, 21);
            this.RadOscuro.Name = "RadOscuro";
            this.RadOscuro.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.RadOscuro.Size = new System.Drawing.Size(85, 21);
            this.RadOscuro.TabIndex = 1;
            this.RadOscuro.TabStop = true;
            this.RadOscuro.Text = "Oscuro";
            this.RadOscuro.UnCheckedColor = System.Drawing.Color.Gray;
            this.RadOscuro.UseVisualStyleBackColor = true;
            // 
            // RadClaro
            // 
            this.RadClaro.AutoSize = true;
            this.RadClaro.CheckedColor = System.Drawing.Color.MediumSlateBlue;
            this.RadClaro.Location = new System.Drawing.Point(44, 21);
            this.RadClaro.MinimumSize = new System.Drawing.Size(0, 21);
            this.RadClaro.Name = "RadClaro";
            this.RadClaro.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.RadClaro.Size = new System.Drawing.Size(72, 21);
            this.RadClaro.TabIndex = 0;
            this.RadClaro.TabStop = true;
            this.RadClaro.Text = "Claro";
            this.RadClaro.UnCheckedColor = System.Drawing.Color.Gray;
            this.RadClaro.UseVisualStyleBackColor = true;
            // 
            // FrmAjustes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(54)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(1151, 718);
            this.Controls.Add(this.PnlBody);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAjustes";
            this.Text = "Ajustes - Garmoxu";
            this.PnlBody.ResumeLayout(false);
            this.PnlMid.ResumeLayout(false);
            this.PnlPerfil.ResumeLayout(false);
            this.PnlPerfilDetalles.ResumeLayout(false);
            this.PnlPerfilDetalles.PerformLayout();
            this.PnlPerfilBoton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicPerfil)).EndInit();
            this.PnlHorario.ResumeLayout(false);
            this.GrpSalida.ResumeLayout(false);
            this.GrpEntrada.ResumeLayout(false);
            this.myGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.myGroupBox2.ResumeLayout(false);
            this.myGroupBox3.ResumeLayout(false);
            this.myGroupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel PnlBody;
        private System.Windows.Forms.TableLayoutPanel PnlMid;
        private System.Windows.Forms.TableLayoutPanel PnlPerfil;
        private System.Windows.Forms.TableLayoutPanel PnlPerfilDetalles;
        private RJCodeAdvance.RJControls.RJCircularPictureBox PicPerfil;
        private System.Windows.Forms.Label LblPerfil;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TableLayoutPanel PnlPerfilBoton;
        private RJCodeAdvance.RJControls.RJButton BtnReset;
        private RJCodeAdvance.RJControls.RJButton BtnEditar;
        private System.Windows.Forms.TableLayoutPanel PnlHorario;
        private MyGroupBox GrpSalida;
        private RJCodeAdvance.RJControls.RJDatePicker DtpSalida;
        private MyGroupBox GrpEntrada;
        private RJCodeAdvance.RJControls.RJDatePicker DtpEntrada;
        private MyGroupBox myGroupBox1;
        private MyGroupBox myGroupBox2;
        private MyGroupBox myGroupBox3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private RJCodeAdvance.RJControls.RJComboBox CboVentana;
        private RJCodeAdvance.RJControls.RJRadioButton RadOscuro;
        private RJCodeAdvance.RJControls.RJRadioButton RadClaro;
        private RJCodeAdvance.RJControls.RJButton BtnCerrarSesion;
        private FontAwesome.Sharp.IconButton BtnClose;
    }
}