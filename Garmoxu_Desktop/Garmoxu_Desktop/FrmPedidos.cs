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
using static Garmoxu_Desktop.MessageBoxPersonalizado;
using static Garmoxu_Desktop.ConexionMySql;

namespace Garmoxu_Desktop
{
    public partial class FrmPedidos : Form
    {
        // Contendrá la tabla de pedidos actuales.
        private DataSet Ds;

        // Último data set almacenado.
        private DataSet UltimoDs;

        // Usuario actual con el que está logeado.
        private string UsuarioActual;

        private int IVA;

        public FrmPedidos(string usuarioActual, int iva)
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            UsuarioActual = usuarioActual;
            IVA = iva;
            IniciarPedidos();
        }

        #region Funciones y diseños de controles
        #region Boton Buscar
        private void BtnBuscar_MouseEnter(object sender, EventArgs e)
        {
            BtnBuscar.IconColor = Color.DeepSkyBlue;
        }

        private void BtnBuscar_MouseLeave(object sender, EventArgs e)
        {
            BtnBuscar.IconColor = Color.MediumSlateBlue;
        }
        #endregion

        #region Boton Añadir
        private void BtnNuevo_MouseEnter(object sender, EventArgs e)
        {
            BtnNuevo.IconColor = Color.Tan;
        }

        private void BtnNuevo_MouseLeave(object sender, EventArgs e)
        {
            BtnNuevo.IconColor = Color.NavajoWhite;
        }
        #endregion

        #region Text box Buscar
        private void TxtBuscar_Enter(object sender, EventArgs e)
        {
            if (TxtBuscar.Texts.Trim().Equals("Buscar por nº de mesa o teléfono de cliente"))
            {
                TxtBuscar.Texts = string.Empty;
                TxtBuscar.ForeColor = Color.White;
            }
        }

        private void TxtBuscar_Leave(object sender, EventArgs e)
        {
            if (TxtBuscar.Texts.Trim().Equals(string.Empty))
            {
                TxtBuscar.Texts = "Buscar por nº de mesa o teléfono de cliente";
                TxtBuscar.ForeColor = Color.Gray;
            }
        }
        #endregion
        #endregion

        #region Apertura del formulario
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
                        string sql = "SELECT Nombre FROM Clientes WHERE TelefonoCliente = '" + row["TelefonoCliente"].ToString() + "'";
                        string cliente = EjecutarScalar(sql);
                        CrearBotonDePedido(PnlRecoger, row["IdPedido"].ToString(), cliente);
                        break;
                }
            }
        }

        // Crea un RJButton en ejecución dentro de un flow panel y le asigna el texto que recibe.
        private void CrearBotonDePedido(FlowLayoutPanel pnl, string clavePrimaria, string texto)
        {
            RJButton btn = new RJButton();
            btn.AutoSize = true;

            btn.BorderColor = Color.White;
            btn.BorderRadius = 15;
            btn.BorderSize = 0;
            btn.Click += new EventHandler(BtnPedidoEnCurso_Click);
            btn.Cursor = Cursors.Hand;
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatStyle = FlatStyle.Flat;
            btn.Font = new Font("Source Sans Pro", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn.Location = new Point(0, 0);
            btn.Margin = new Padding(0, 0, 20, 20);
            btn.Size = new Size(100, 50);
            btn.TabStop = false;
            btn.Tag = clavePrimaria;
            btn.Text = texto;
            btn.UseVisualStyleBackColor = false;

            AsignarColoresBotonPedido(btn, pnl);

            pnl.Controls.Add(btn);
        }


        private void AsignarColoresBotonPedido(RJButton btn, FlowLayoutPanel pnl) 
        {
            Color backColor = new Color();
            Color overColor = new Color();
            Color downColor = new Color();
            Color textColor = new Color();

            switch (pnl.Name)
            {
                case "PnlLocal":
                    backColor = Color.FromArgb(170, 170, 110);
                    overColor = Color.FromArgb(190, 190, 110);
                    downColor = Color.FromArgb(220, 220, 110);
                    textColor = Color.White;
                    break;

                case "PnlDomicilio":
                    backColor = Color.DarkOrchid;
                    overColor = Color.FromArgb(153, 110, 204);
                    downColor = Color.FromArgb(183, 110, 204);
                    textColor = Color.White;
                    break;

                case "PnlRecoger":
                    backColor = Color.FromArgb(100, 149, 237);
                    overColor = Color.FromArgb(140, 149, 237);
                    downColor = Color.FromArgb(170, 149, 237);
                    textColor = Color.White;
                    break;
            }

            btn.BackgroundColor = backColor;
            btn.FlatAppearance.MouseOverBackColor = overColor;
            btn.FlatAppearance.MouseDownBackColor = downColor;
            btn.TextColor = textColor;
        }
        #endregion
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
            if (Ds == null) Ds = new DataSet();
            else Ds.Tables["PedidosEnCurso"].Rows.Clear();

            string sql = "SELECT * FROM PedidosEnCurso";
            LlenarDataSet(sql, "PedidosEnCurso", ref Ds);
        }

        private void RecogerTablaClientes()
        {
            string sql = "SELECT TelefonoCliente, Nombre FROM Clientes";
            LlenarDataSet(sql, "Clientes", ref Ds);
        }

        #region Actualización de pedidos añadidos
        // Busca si se han añadido pedidos, de ser así los añade de uno en uno.
        private void BuscarPedidosAñadidos()
        {
            foreach (DataRow row in Ds.Tables["PedidosEnCurso"].Rows)
            {
                if (!UltimoDs.Tables["PedidosEnCurso"].Rows.Contains(row["IdPedido"]))
                {
                    object[] rowCopy = new object[row.ItemArray.Length];
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
                            string sql = "SELECT Nombre FROM Clientes WHERE TelefonoCliente = '" + row["TelefonoCliente"].ToString() + "'";
                            string scalar = EjecutarScalar(sql);
                            CrearBotonDePedido(PnlRecoger, row["IdPedido"].ToString(), scalar);
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
                            textoNuevo = EjecutarScalar(sql);
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
            string clavePrimaria = ((RJButton)sender).Tag.ToString();
            Form frmShadow = new Form();
            FrmPedidosDetalles frm = new FrmPedidosDetalles(clavePrimaria, UsuarioActual, IVA, ref frmShadow);
            frm.ShowDialog();
            frmShadow.Close();
        }
        #endregion

        #region Busqueda de pedidos
        // Comprueba si el código del pedido que se quiere buscar existe y abre una ventana de detalles.
        private void TxtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals((char)Keys.Enter) && !string.IsNullOrEmpty(TxtBuscar.Texts) 
                && !TxtBuscar.Texts.Equals("Buscar por nº de mesa o teléfono de cliente"))
            {
                e.Handled = true;
                BuscarPedido();
            }
        }

        private void TxtBuscar__TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtBuscar.Texts) && !TxtBuscar.Texts.Equals("Buscar por nº de mesa o teléfono de cliente"))
                BtnBuscar.Enabled = true;
            else
                BtnBuscar.Enabled = false;
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            BuscarPedido();
        }

        private void BuscarPedido()
        {
            if (!ValidarDatoExistente("IdMesa") && !ValidarDatoExistente("TelefonoCliente"))
            {
                string mensaje = "¡No se ha encontrado ningún pedido asociado a ese dato!";
                ShowWarningMessage(mensaje, "");
            }
        }

        // Devuelve true y abre una ventana de detalles si el pedido con esa clave existe.
        private bool ValidarDatoExistente(string filtro)
        {
            string sql = "SELECT IdPedido FROM PedidosEnCurso WHERE " + filtro + " = '" + TxtBuscar.Texts.Replace(" ", "") + "'";
            string clave = EjecutarScalar(sql);
            if (!string.IsNullOrEmpty(clave))
            {
                Form frmShadow = new Form();
                FrmPedidosDetalles frm = new FrmPedidosDetalles(clave, UsuarioActual, IVA, ref frmShadow);
                frm.ShowDialog();
                frmShadow.Close();
                TxtBuscar.Texts = string.Empty;
                return true;
            }
            return false;
        }
        #endregion

        #region Botón Nuevo
        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            Form frmShadow = new Form();
            FrmPedidosDetalles frm = new FrmPedidosDetalles("", UsuarioActual, IVA, ref frmShadow);
            frm.Size = new Size(750, 750); // Solo se aplica pedidos nuevos para adaptarse a la pestaña de selección de tipo de pedido
            frm.ShowDialog();
            frmShadow.Close();
        }
        #endregion

        private void FrmPedidos_Shown(object sender, EventArgs e)
        {
            TxtBuscar.Height = 52;
        }
    }
}
