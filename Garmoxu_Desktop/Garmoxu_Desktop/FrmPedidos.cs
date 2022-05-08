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

namespace Garmoxu_Desktop
{
    public partial class FrmPedidos : Form
    {
        // Instancia de la conexión a la base de datos.
        private MySqlConnection ConexionBD;

        // Contendrá la tabla de pedidos actuales.
        private DataSet Ds;

        // Almacenará la sentencia que se ejecutará en la BBDD.
        private MySqlCommand Cmd;

        // Almacenará el adaptador.
        private MySqlDataAdapter Da;

        // Último data set almacenado.
        private DataSet UltimoDs;

        // Instancia del formulario main.
        private FrmMain Instance;

        // Usuario actual con el que está logeado.
        private string UsuarioActual;

        private int IVA;

        public FrmPedidos(MySqlConnection conexionBD, FrmMain instance, string usuarioActual, int iva)
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            ConexionBD = conexionBD;
            Instance = instance;
            UsuarioActual = usuarioActual;
            IVA = iva;
            IniciarPedidos();
        }

        #region Pedidos
        #region Carga inicial de pedidos
        private void IniciarPedidos()
        {
            RecogerTablaPedidosEnCurso();
            RecogerTablaClientes();
            AñadirBotonesPedidos();
            UltimoDs = Ds;
            UltimoDs.Tables["PedidosEnCurso"].PrimaryKey = new DataColumn[1] { UltimoDs.Tables["PedidosEnCurso"].Columns[0] };
            Ds.Tables["PedidosEnCurso"].PrimaryKey = new DataColumn[1] { Ds.Tables["PedidosEnCurso"].Columns[0] };
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

                    case "Domicilio":
                        CrearBotonDePedido(PnlDomicilio, row["IdPedido"].ToString(), row["TelefonoCliente"].ToString());
                        break;

                    case "Recoger":
                        MySqlCommand cmd = new MySqlCommand(
                            "SELECT Nombre FROM Clientes WHERE TelefonoCliente = '" + row["TelefonoCliente"].ToString() + "'");
                        cmd.Connection = ConexionBD;
                        string cliente;
                        if (cmd.ExecuteScalar() != null)
                            cliente = cmd.ExecuteScalar().ToString();
                        else
                            cliente = string.Empty;
                        CrearBotonDePedido(PnlRecoger, row["IdPedido"].ToString(), cliente);
                        break;
                }
            }
        }

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

        #region Actualización de pedidos en tiempo real
        // Si ha habido cualquier cambio en la tabla de pedidos en curso, actualiza los botones de los pedidos.
        private void TmrComprobarCambiosPedidos_Tick(object sender, EventArgs e)
        {
            UltimoDs = Ds.Copy();
            RecogerTablaPedidosEnCurso();
            RecogerTablaClientes();
            BuscarPedidosAñadidos();
            BuscarPedidosBorrados();
            BuscarTipoPedidosActualizados();
            BuscarTextosBotonesPedidosActualizados();
        }

        private void RecogerTablaPedidosEnCurso()
        {
            if (Ds == null)
                Ds = new DataSet();
            else
                Ds.Tables["PedidosEnCurso"].Rows.Clear();
            Cmd = new MySqlCommand("SELECT * FROM PedidosEnCurso", ConexionBD);
            Da = new MySqlDataAdapter();
            Da.SelectCommand = Cmd;
            Da.FillAsync(Ds, "PedidosEnCurso");
        }

        private void RecogerTablaClientes()
        {
            Cmd = new MySqlCommand("SELECT TelefonoCliente, Nombre FROM Clientes", ConexionBD);
            Da = new MySqlDataAdapter();
            Da.SelectCommand = Cmd;
            Da.FillAsync(Ds, "Clientes");
        }

        #region Actualización de pedidos añadidos
        // Busca si se han añadido pedidos, de ser así los añade de uno en uno.
        private void BuscarPedidosAñadidos()
        {
            foreach (DataRow row in Ds.Tables["PedidosEnCurso"].Rows)
            {
                if (!UltimoDs.Tables["PedidosEnCurso"].Rows.Contains(row["IdPedido"]))
                {
                    Object[] rowCopy = new Object[row.ItemArray.Length];
                    row.ItemArray.CopyTo(rowCopy, 0);

                    switch (row["Tipo"].ToString())
                    {
                        case "Local":
                            CrearBotonDePedido(PnlLocal, row["IdPedido"].ToString(), row["IdMesa"].ToString());
                            UltimoDs.Tables["PedidosEnCurso"].Rows.Add(rowCopy);
                            break;

                        case "Domicilio":
                            CrearBotonDePedido(PnlDomicilio, row["IdPedido"].ToString(), row["TelefonoCliente"].ToString());
                            UltimoDs.Tables["PedidosEnCurso"].Rows.Add(rowCopy);
                            break;

                        case "Recoger":
                            MySqlCommand cmd = new MySqlCommand(
                                "SELECT Nombre FROM Clientes WHERE TelefonoCliente = '" + row["TelefonoCliente"].ToString() + "'");
                            cmd.Connection = ConexionBD;
                            CrearBotonDePedido(PnlRecoger, row["IdPedido"].ToString(), cmd.ExecuteScalar().ToString());
                            UltimoDs.Tables["PedidosEnCurso"].Rows.Add(rowCopy);
                            break;
                    }
                }
            }
        }
        #endregion

        #region Actualización de pedidos borrados
        // Busca si se han borrado pedidos, de ser así los elimina de uno en uno.
        private void BuscarPedidosBorrados()
        {
            DataSet ultimoDsCopy = UltimoDs.Copy();
            foreach (DataRow row in UltimoDs.Tables["PedidosEnCurso"].Rows)
            {
                if (!Ds.Tables["PedidosEnCurso"].Rows.Contains(row["IdPedido"]))
                {
                    switch (row["Tipo"].ToString())
                    {
                        case "Local":
                            BorrarBotonDePedido(PnlLocal, row["IdPedido"].ToString());
                            //ultimoDsCopy.Tables["PedidosEnCurso"].Rows.Remove(row);
                            row.Delete();
                            break;

                        case "Domicilio":
                            BorrarBotonDePedido(PnlDomicilio, row["IdPedido"].ToString());
                            //ultimoDsCopy.Tables["PedidosEnCurso"].Rows.Remove(row);
                            row.Delete();
                            break;

                        case "Recoger":
                            BorrarBotonDePedido(PnlRecoger, row["IdPedido"].ToString());
                            //ultimoDsCopy.Tables["PedidosEnCurso"].Rows.Remove(row);
                            row.Delete();
                            break;
                    }
                }
            }
            UltimoDs = ultimoDsCopy.Copy();
        }

        // Busca un botón dentro de los paneles y lo borra.
        private void BorrarBotonDePedido(FlowLayoutPanel pnl, string clavePrimaria)
        {
            foreach (Control control in pnl.Controls)
            {
                if (control.Tag.ToString().Equals(clavePrimaria))
                    pnl.Controls.Remove(control);
            }
        }
        #endregion

        #region Actualización tipo de pedido
        // Busca si se ha actualizado el tipo de alguno de los pedidos, de ser así, los actualiza de uno en uno moviéndolos
        // a su sección correspondiente.
        private void BuscarTipoPedidosActualizados()
        {
            for (int i = 0; i < Ds.Tables["PedidosEnCurso"].Rows.Count; i++)
            {
                string tipoAnterior = UltimoDs.Tables["PedidosEnCurso"].Rows[i]["Tipo"].ToString();
                string tipoActual = Ds.Tables["PedidosEnCurso"].Rows[i]["Tipo"].ToString();
                if (!tipoActual.Equals(tipoAnterior))
                {
                    string textoNuevo = "";
                    FlowLayoutPanel pnlAntiguo = new FlowLayoutPanel();
                    FlowLayoutPanel pnlNuevo = new FlowLayoutPanel();
                    string clavePrimaria = Ds.Tables["PedidosEnCurso"].Rows[i]["IdPedido"].ToString();

                    switch (tipoAnterior)
                    {
                        case "Local":
                            pnlAntiguo = PnlLocal;
                            break;

                        case "Domicilio":
                            pnlAntiguo = PnlDomicilio;
                            break;

                        case "Recoger":
                            pnlAntiguo = PnlRecoger;
                            break;
                    }

                    switch (tipoActual)
                    {
                        case "Local":
                            pnlNuevo = PnlLocal;
                            textoNuevo = Ds.Tables["PedidosEnCurso"].Rows[i]["IdMesa"].ToString();
                            break;

                        case "Domicilio":
                            pnlNuevo = PnlDomicilio;
                            textoNuevo = Ds.Tables["PedidosEnCurso"].Rows[i]["TelefonoCliente"].ToString();

                            break;

                        case "Recoger":
                            pnlNuevo = PnlRecoger;
                            string telefono = Ds.Tables["PedidosEnCurso"].Rows[i]["TelefonoCliente"].ToString();
                            string sql = "SELECT Nombre FROM Clientes WHERE TelefonoCliente = '" + telefono + "'";
                            MySqlCommand cmd = new MySqlCommand(sql, ConexionBD);
                            textoNuevo = cmd.ExecuteScalar().ToString();
                            break;
                    }

                    ActualizarLocalizacionBotonPedido(pnlAntiguo, pnlNuevo, clavePrimaria, textoNuevo);
                }
            }
        }

        // Busca un botón dentro de los paneles, lo elimina, lo añade al panel correcto y le da el nombre adecuado.
        private void ActualizarLocalizacionBotonPedido(FlowLayoutPanel pnlAntiguo, FlowLayoutPanel pnlNuevo,
            string clavePrimaria, string textoNuevo)
        {
            foreach (Control control in pnlAntiguo.Controls)
            {
                if (control.Tag.ToString().Equals(clavePrimaria))
                {
                    CrearBotonDePedido(pnlNuevo, clavePrimaria, textoNuevo);
                    pnlAntiguo.Controls.Remove(control);
                }
            }
        }
        #endregion

        #region Actualización de los textos de los botones de pedidos
        // Busca si se han actualizado los datos que aparecen en el texto de los botones de los
        // pedidos (IdMesa, tlf o nombre de cliente), de ser así los actualiza de uno en uno.
        private void BuscarTextosBotonesPedidosActualizados()
        {
            FlowLayoutPanel pnl = new FlowLayoutPanel();
            string textoAnterior = "";
            string textoActual = "";

            for (int i = 0; i < Ds.Tables["PedidosEnCurso"].Rows.Count; i++)
            {
                switch (Ds.Tables["PedidosEnCurso"].Rows[i]["Tipo"].ToString())
                {
                    case "Local":
                        pnl = PnlLocal;
                        textoAnterior = UltimoDs.Tables["PedidosEnCurso"].Rows[i]["IdMesa"].ToString();
                        textoActual = Ds.Tables["PedidosEnCurso"].Rows[i]["IdMesa"].ToString();
                        break;

                    case "Domicilio":
                        pnl = PnlDomicilio;
                        textoAnterior = UltimoDs.Tables["PedidosEnCurso"].Rows[i]["TelefonoCliente"].ToString();
                        textoActual = Ds.Tables["PedidosEnCurso"].Rows[i]["TelefonoCliente"].ToString();
                        break;

                    case "Recoger":
                        pnl = PnlRecoger;

                        foreach (DataRow clienteRow in UltimoDs.Tables["Clientes"].Rows)
                        {
                            string telefonoAnterior = UltimoDs.Tables["PedidosEnCurso"].Rows[i]["TelefonoCliente"].ToString();
                            if (clienteRow["TelefonoCliente"].ToString().Equals(telefonoAnterior))
                                textoAnterior = clienteRow["Nombre"].ToString();
                        }

                        foreach (DataRow clienteRow in Ds.Tables["Clientes"].Rows)
                        {
                            string telefonoActual = Ds.Tables["PedidosEnCurso"].Rows[i]["TelefonoCliente"].ToString();
                            if (clienteRow["TelefonoCliente"].ToString().Equals(telefonoActual))
                                textoActual = clienteRow["Nombre"].ToString();
                        }
                        break;
                }

                if (!textoActual.Equals(textoAnterior))
                {
                    string clavePrimaria = Ds.Tables["PedidosEnCurso"].Rows[i]["IdPedido"].ToString();
                    ActualizarTextoBotonPedido(pnl, clavePrimaria, textoActual);
                }
            }
        }

        // Busca un botón dentro de los paneles y actualiza su texto.
        private void ActualizarTextoBotonPedido(FlowLayoutPanel pnl, string clavePrimaria, string textoActualizado)
        {
            foreach (Control control in pnl.Controls)
            {
                if (control.Tag.ToString().Equals(clavePrimaria))
                    control.Text = textoActualizado;
            }
        }
        #endregion       
        #endregion

        #region Apertura de detalles del pedido
        // Cuando se pulsa en el botón de un pedido en curso se abre una ventana con la clave primaria del pedido.
        private void BtnPedidoEnCurso_Click(object sender, EventArgs e)
        {
            string clavePrimaria = ((RJCodeAdvance.RJControls.RJButton)sender).Tag.ToString();
            FrmPedidosDetalles frm = new FrmPedidosDetalles(ConexionBD, clavePrimaria, Instance, UsuarioActual, IVA);
            frm.Show();
        }

        private void FrmPedidos_EnabledChanged(object sender, EventArgs e)
        {
            //if (Enabled)
            //    TmrComprobarCambiosPedidos.Enabled = true;
            //else
            //    TmrComprobarCambiosPedidos.Enabled = false;
        }
        #endregion

        #region Busqueda de pedidos
        // Comprueba si el código del pedido que se quiere buscar existe y abre una ventana de detalles.
        private void TxtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals((char)Keys.Enter))
            {
                e.Handled = true;
                if (!ValidarDatoExistente("IdMesa") && !ValidarDatoExistente("TelefonoCliente"))
                    MessageBox.Show("¡No se ha encontrado ningún pedido asociado a ese dato!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //<<Mirar
        // Devuelve true y abre una ventana de detalles si el pedido con esa clave existe.
        private bool ValidarDatoExistente(String filtro)
        {
            string sql = "SELECT IdPedido FROM PedidosEnCurso WHERE " + filtro + " = '" + TxtBuscar.Text.Trim() + "'"; //TxtBuscar.Texts
            MySqlCommand cmd = new MySqlCommand(sql, ConexionBD);
            if (cmd.ExecuteScalar() != null)
            {
                FrmPedidosDetalles frm = new FrmPedidosDetalles(ConexionBD, cmd.ExecuteScalar().ToString(), Instance, UsuarioActual, IVA);
                frm.Show();
                TxtBuscar.Text = string.Empty; //TxtBuscar.Texts
                return true;
            }
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
        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            NuevoPedido(new FrmPedidosDetalles(ConexionBD, "", Instance, UsuarioActual, IVA));
        }

        private void NuevoPedido(Form f)
        {
            //No me deja dividir o multiplicar con decimales por algun motivo
            //La nueva esta al 75% del tamaño comparado con el Main
            f.Width = (Instance.Width / 2) + (Instance.Width / 4);
            f.Height = (Instance.Height / 2) + (Instance.Height / 4);
            f.Show();
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
