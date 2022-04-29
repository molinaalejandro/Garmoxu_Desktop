using MySql.Data.MySqlClient;
using RJCodeAdvance.RJControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Garmoxu_Project
{
    public partial class FrmPedidos : Form
    {
        // Instancia de la conexión a la base de datos.
        private MySqlConnection ConexionBD;

        // Instancia del form main.
        private FrmMain InstanceOfFrmMain;

        public FrmPedidos(MySqlConnection conexionBD, FrmMain instanceOfFrmMain)
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            ConexionBD = conexionBD;
            InstanceOfFrmMain = instanceOfFrmMain;
            IniciarPedidos();
        }

        #region Pedidos
        #region Cargar pedidos iniciales
        private void IniciarPedidos()
        {
            RecogerTablaPedidosEnCurso();
            AñadirBotonesPedidos();
            UltimoDs = Ds;
            UltimoDs.Tables["PedidosEnCurso"].PrimaryKey = new DataColumn[1] { UltimoDs.Tables["PedidosEnCurso"].Columns[0] };
            Ds.Tables["PedidosEnCurso"].PrimaryKey = new DataColumn[1] { Ds.Tables["PedidosEnCurso"].Columns[0] };
        }
        #endregion

        #region Actualización de los pedidos
        // Contendrá la tabla de pedidos actuales.
        DataSet Ds;

        // Almacenará la sentencia que se ejecutará en la BBDD.
        MySqlCommand Cmd;

        // Almacenará el adaptador.
        MySqlDataAdapter Da;

        #region V3 Comprobación de cambios en la BBDD
        //Último data set almacenado.
        DataSet UltimoDs;

        // Si ha habido cualquier cambio en la tabla de pedidos en curso, actualiza los botones de los pedidos.
        private void TmrComprobarCambiosPedidos_Tick(object sender, EventArgs e)
        {
            UltimoDs = Ds.Copy();
            RecogerTablaPedidosEnCurso();
            BuscarPedidosAñadidos();
            BuscarPedidosBorrados();
        }

        #region Pedidos en curso añadidos
        private void BuscarPedidosAñadidos()
        {
            //if (Ds.Tables["PedidosEnCurso"].Rows.Count - UltimoDs.Tables["PedidosEnCurso"].Rows.Count > UltimoDs.Tables["PedidosEnCurso"].Rows.Count)
            //{
            //    LimpiarBotonesPedidos();
            //    AñadirBotonesPedidos();
            //}
            //else
            //{
            foreach (DataRow row in Ds.Tables["PedidosEnCurso"].Rows)
            {
                if (!UltimoDs.Tables["PedidosEnCurso"].Rows.Contains(int.Parse(row["IdPedido"].ToString())))
                {
                    switch (row["Tipo"].ToString())
                    {
                        case "Local":
                            CrearBotonDePedido(PnlLocal, row["IdPedido"].ToString(), row["IdMesa"].ToString());

                            break;

                        case "A domicilio":
                            CrearBotonDePedido(PnlDomicilio, row["IdPedido"].ToString(), row["TelefonoCliente"].ToString());
                            break;

                        case "A recoger":
                            MySqlCommand cmd = new MySqlCommand(
                                "SELECT Nombre FROM Clientes WHERE TelefonoCliente = '" + row["TelefonoCliente"].ToString() + "'");
                            cmd.Connection = ConexionBD;
                            CrearBotonDePedido(PnlRecoger, row["IdPedido"].ToString(), cmd.ExecuteScalar().ToString());
                            break;
                    }
                }
            }
            //}
        }
        #endregion

        #region Pedidos en curso borrados
        private void BuscarPedidosBorrados()
        {
            if (UltimoDs.Tables["PedidosEnCurso"].Rows.Count - Ds.Tables["PedidosEnCurso"].Rows.Count >= Ds.Tables["PedidosEnCurso"].Rows.Count)
            {
                LimpiarBotonesPedidos();
                AñadirBotonesPedidos();
            }
            else
            {
                foreach (DataRow row in UltimoDs.Tables["PedidosEnCurso"].Rows)
                {
                    if (!Ds.Tables["PedidosEnCurso"].Rows.Contains(row["IdPedido"]))
                    {
                        switch (row["Tipo"].ToString())
                        {
                            case "Local":
                                BorrarBotonDePedido(PnlLocal, row["IdPedido"].ToString());
                                break;

                            case "A domicilio":
                                BorrarBotonDePedido(PnlDomicilio, row["IdPedido"].ToString());
                                break;

                            case "A recoger":
                                BorrarBotonDePedido(PnlRecoger, row["IdPedido"].ToString());
                                break;
                        }
                    }
                }
            }
        }

        // Limpiar los pedidos que están en los group box.
        private void LimpiarBotonesPedidos()
        {
            PnlLocal.Controls.Clear();
            PnlDomicilio.Controls.Clear();
            PnlRecoger.Controls.Clear();
        }

        // Recibe el data set con la tabla de pedidos en curso y añade cada pedido a su group box correspondiente.
        private void AñadirBotonesPedidos()
        {
            foreach (DataRow row in Ds.Tables["PedidosEnCurso"].Rows)
            {
                switch (row["Tipo"].ToString())
                {
                    case "Local":
                        CrearBotonDePedido(PnlLocal, row["IdPedido"].ToString(), row["IdMesa"].ToString());
                        break;

                    case "A domicilio":
                        CrearBotonDePedido(PnlDomicilio, row["IdPedido"].ToString(), row["TelefonoCliente"].ToString());
                        break;

                    case "A recoger":
                        MySqlCommand cmd = new MySqlCommand(
                            "SELECT Nombre FROM Clientes WHERE TelefonoCliente = '" + row["TelefonoCliente"].ToString() + "'");
                        cmd.Connection = ConexionBD;
                        CrearBotonDePedido(PnlRecoger, row["IdPedido"].ToString(), cmd.ExecuteScalar().ToString());
                        break;
                }
            }
        }

        private void BorrarBotonDePedido(FlowLayoutPanel pnl, String clavePrimaria)
        {
            foreach (Control control in pnl.Controls)
            {
                if (control.Tag.ToString().Equals(clavePrimaria))
                    pnl.Controls.Remove(control);
            }
        }
        #endregion
        #endregion

        private void RecogerTablaPedidosEnCurso()
        {
            if (Ds == null)
                Ds = new DataSet();
            else
                Ds.Tables["PedidosEnCurso"].Rows.Clear();
            Cmd = new MySqlCommand("SELECT * FROM PedidosEnCurso");
            Cmd.Connection = ConexionBD;
            Da = new MySqlDataAdapter();
            Da.SelectCommand = Cmd;
            Da.Fill(Ds, "PedidosEnCurso");
        }
        #endregion

        #region Añadir botón de pedido en ejecucción
        // Crea un RJButton en ejecución dentro de un flow panel y le asigna el texto que recibe.
        private void CrearBotonDePedido(FlowLayoutPanel pnl, string clavePrimaria, string texto)
        {
            RJCodeAdvance.RJControls.RJButton btn = new RJCodeAdvance.RJControls.RJButton();
            btn.AutoSize = true;
            btn.BackColor = Color.MediumSlateBlue;
            btn.BackgroundColor = Color.MediumSlateBlue;
            btn.BorderColor = Color.White;
            btn.BorderRadius = 5;
            btn.BorderSize = 0;
            btn.Click += new EventHandler(BtnPedidoEnCurso_Click);
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.MouseOverBackColor = Color.MediumBlue;
            btn.FlatAppearance.MouseDownBackColor = Color.MediumAquamarine;
            btn.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn.ForeColor = Color.White;
            btn.Location = new Point(0, 0);
            btn.Margin = new Padding(30, 0, 0, 20);
            btn.Size = new Size(100, 50);
            btn.Tag = clavePrimaria;
            btn.Text = texto;
            btn.TextColor = Color.White;
            btn.UseVisualStyleBackColor = false;

            pnl.Controls.Add(btn);
        }
        #endregion

        #region Apertura de detalles del pedido
        // Cuando se pulsa en el botón de un pedido en curso se abre una ventana con la clave primaria del pedido.
        private void BtnPedidoEnCurso_Click(object sender, EventArgs e)
        {
            AbrirFormDetallesPedido(new FrmDetallesPedido(((RJCodeAdvance.RJControls.RJButton)sender).Tag.ToString()));
        }

        // Comprueba si hay una ventana abierta de los detalles de dicho pedido. De ser así, la trae al frente.
        // En caso contrario, abre una nueva pasándole la clave primaria del pedido.
        private bool AbrirFormDetallesPedido(FrmDetallesPedido frmDetalles)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f.GetType().Equals(frmDetalles.GetType()))
                {
                    if (((FrmDetallesPedido)f).ClavePrimariaPedidoEnCursoGet.Equals(frmDetalles.ClavePrimariaPedidoEnCursoGet))
                    {
                        f.BringToFront();
                        frmDetalles.Close();
                        return true;
                    }
                }
            }
            frmDetalles.Show();
            return false;
        }
        #endregion

        #region Botón Pedidos
        private void BtnSimple_Click(object sender, EventArgs e)
        {
            if (PnlSubHeader.GetColumnWidths()[0] <= PnlSubHeader.GetColumnWidths()[1])
            {
                PnlSubHeader.BackColor = BtnSimple.BackColor;
                PnlSubHeader.ColumnStyles[0].Width = 80;
                PnlSubHeader.ColumnStyles[1].Width = 20;
                TabControl.SelectedIndex = 0;
            }
        }

        private void BtnSimple_MouseEnter(object sender, EventArgs e)
        {
            if (PnlSubHeader.GetColumnWidths()[0] > PnlSubHeader.GetColumnWidths()[1])
            {
                BtnSimple.FlatAppearance.MouseOverBackColor = BtnSimple.BackColor;
                BtnSimple.FlatAppearance.MouseDownBackColor = BtnSimple.BackColor;
            }
            else
            {
                BtnSimple.FlatAppearance.MouseOverBackColor = Color.Empty;
                BtnSimple.FlatAppearance.MouseDownBackColor = Color.Empty;
            }
        }
        #endregion

        #region Botón Nuevo
        private void NuevoPedido(Form f)
        {
            //No me deja dividir o multiplicar con decimales por algun motivo
            //La nueva esta al 75% del tamaño comparado con el Main
            f.Width = (FrmMain.instance.Width / 2) + (FrmMain.instance.Width / 4);
            f.Height = (FrmMain.instance.Height / 2) + (FrmMain.instance.Height / 4);
            f.Show();
            FrmMain.instance.Enabled = false;
        }

        private void TxtNuevo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) MessageBox.Show("Mostrara/abrira el form de DetallesPedido con su respectivo informacion almacenado");
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            NuevoPedido(new FrmDetallesPedido(""));
        }
        #endregion

        #region Botón Cerrar
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
        #endregion

        #region Mesas
        #region Boton Mesas
        private void BtnMapping_Click(object sender, EventArgs e)
        {
            if (PnlSubHeader.GetColumnWidths()[1] <= PnlSubHeader.GetColumnWidths()[0])
            {
                PnlSubHeader.BackColor = BtnMapping.BackColor;
                PnlSubHeader.ColumnStyles[0].Width = 20;
                PnlSubHeader.ColumnStyles[1].Width = 80;
                TabControl.SelectedIndex = 1;
            }
        }

        private void BtnMapping_MouseEnter(object sender, EventArgs e)
        {
            if (PnlSubHeader.GetColumnWidths()[1] > PnlSubHeader.GetColumnWidths()[0])
            {
                BtnMapping.FlatAppearance.MouseOverBackColor = BtnMapping.BackColor;
                BtnMapping.FlatAppearance.MouseDownBackColor = BtnMapping.BackColor;
            }
            else
            {
                BtnMapping.FlatAppearance.MouseOverBackColor = Color.Empty;
                BtnMapping.FlatAppearance.MouseDownBackColor = Color.Empty;
            }
        }
        #endregion

        #endregion
    }
}
