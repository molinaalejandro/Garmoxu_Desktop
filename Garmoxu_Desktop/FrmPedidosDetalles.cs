using iText.IO.Image;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Draw;
using iText.Layout;
using iText.Layout.Borders;
using iText.Layout.Element;
using iText.Layout.Properties;
using MySql.Data.MySqlClient;
using RJCodeAdvance.RJControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Garmoxu_Project
{
    public partial class FrmPedidosDetalles : Form
    {
        // Instancia de la conexión a la base de datos.
        private MySqlConnection ConexionBD;

        // Clave primaria del pedido que se está detallando. Estará vacía si es una pestaña de nuevo pedido.
        private string ClavePrimariaPedidoEnCurso;

        // Instancia del formulario main.
        private FrmMain Instance;

        // Contendrá una lista de las text box de datos que no son necesarias completar.
        private List<RJTextBox> ListaDatosOpcionales = new List<RJTextBox>();

        // Usuario actual con el que está iniciada la sesión.
        private string UsuarioActual;

        // IdMesa que tiene el pedido inicialmente, solo cuando sea un pedido en local.
        private string IdMesaInicial;

        // Datos iniciales que se cargan en el pedido cuando se trata de una ventanda de modificación.
        private List<string> DatosIniciales;

        // Platos iniciales con los que se carga el pedido cuando se trata de una ventanda de modificación.
        private List<string[]> PlatosIniciales;

        private string MetodoPago;

        private const decimal IVA = 10.00m;

        public FrmPedidosDetalles(MySqlConnection conexionBD, string clavePrimariaPedidoEnCurso, FrmMain instance, string usuarioActual)
        {
            InitializeComponent();
            ConexionBD = conexionBD;
            ClavePrimariaPedidoEnCurso = clavePrimariaPedidoEnCurso;
            Instance = instance;
            Instance.Enabled = false;
            UsuarioActual = usuarioActual;
            AsignarMesasLibres();
            AsignarEstadosPedido();
            InicializarListaDatosOpcionales();
            CargarTipoFormulario();
        }

        #region Apertura del formulario
        #region Carga del tipo de formulario
        // Si la clave primaria recibida está vacía, el formulario servirá para dar de alta un nuevo pedido en curso.
        // En caso contrario, el formulario servirá para consultar y modificar los datos del pedido asociado a la clave.
        private void CargarTipoFormulario()
        {
            if (!string.IsNullOrEmpty(ClavePrimariaPedidoEnCurso.Trim()))
            {
                TabPrincipal.SelectedIndex = 1;
                BtnConfirmar.Text = "Guardar cambios";
                AsignarDatosPedido();
            }
            else
            {
                BtnBorrarPedido.Visible = false;
                AsignarFechaHora();
                CboTipo.SelectedIndex = 0;
            }
        }

        //Asigna los datos del pedido a los controles correspondientes.
        private void AsignarDatosPedido()
        {
            string[] datosPedido = new string[10];
            CargarDatosPedido(ref datosPedido);

            LblFecha.Text = (DateTime.Parse(datosPedido[2])).ToString("dd/MM/yyyy"); //Fecha
            LblHora.Text = (DateTime.Parse(datosPedido[3])).ToString("HH:mm"); //Hora
            LblHora.Tag = (DateTime.Parse(datosPedido[3])).ToString("HH:mm:ss"); //Hora con segundos

            LblPrecioConIVA.Text = datosPedido[4] + "€"; //Precio con IVA
            LblPrecioSinIVA.Text = datosPedido[5] + "€"; //Precio sin IVA

            BuscarDatoEnComboBox(CboTipo, datosPedido[6]); //Tipo

            BuscarDatoEnComboBox(CboEstado, datosPedido[1]); //Estado

            switch (CboTipo.SelectedIndex) //Datos de tipo
            {
                case 0:
                    IdMesaInicial = datosPedido[9];
                    if (!BuscarDatoEnComboBox(CboMesasLocalDetalles, datosPedido[9]))
                    {
                        CboMesasLocalDetalles.Items.Add(datosPedido[9]);
                        CboMesasLocalDetalles.SelectedIndex = CboMesasLocalDetalles.Items.Count - 1;
                    }
                    break;

                case 1:
                    TxtTlfDomicilioDetalles.Texts = datosPedido[8];
                    break;

                case 2:
                    TxtTlfRecogerDetalles.Texts = datosPedido[8];
                    break;
            }

            AsignarPlatos(); //Platos
        }

        // Carga los datos del pedido relacionado con la clave primaria en una lista.
        private void CargarDatosPedido(ref string[] datosPedidos)
        {
            MySqlCommand cmd = new MySqlCommand(
                "SELECT * FROM PedidosEnCurso WHERE IdPedido = '" + ClavePrimariaPedidoEnCurso + "'", ConexionBD);

            MySqlDataReader lector = cmd.ExecuteReader();
            DatosIniciales = new List<string>();
            for (int i = 0; i < lector.FieldCount; i++)
            {
                lector.Read();
                try
                {
                    if (i == 4 || i == 5)
                        datosPedidos[i] = decimal.Parse(lector.GetString(i)).ToString(CultureInfo.CreateSpecificCulture("en-GB"));
                    else
                        datosPedidos[i] = lector.GetString(i);
                }
                catch (SqlNullValueException ex)
                {
                    datosPedidos[i] = "NULL";
                }
                DatosIniciales.Add(datosPedidos[i]);
            }
            lector.Close();
        }

        // Recorre una combo box en busca de un dato, si lo encuentra, lo selecciona.
        private bool BuscarDatoEnComboBox(RJComboBox cbo, string dato)
        {
            cbo.SelectedIndex = -1;
            for (int i = 0; i < cbo.Items.Count; i++)
            {
                if (cbo.Items[i].ToString().Equals(dato))
                {
                    cbo.SelectedIndex = i;
                    return true;
                }
            }
            return false;
        }

        // Asigna los datos de los platos asociados al pedido a la grid view.
        private void AsignarPlatos()
        {
            string sql = "SELECT * FROM PedidosEnCursoPlatos WHERE IdPedido = '" + ClavePrimariaPedidoEnCurso + "'";
            MySqlCommand cmd = new MySqlCommand(sql, ConexionBD);
            MySqlDataReader lector = cmd.ExecuteReader();

            List<string> idsPlatos = new List<string>();
            List<decimal> cantidades = new List<decimal>();
            PlatosIniciales = new List<string[]>();
            while (lector.Read())
            {
                idsPlatos.Add(lector["IdPlatoComida"].ToString());
                cantidades.Add(decimal.Parse(lector["Cantidad"].ToString()));

                PlatosIniciales.Add(new string[] { lector["IdPlatoComida"].ToString(), lector["Cantidad"].ToString() });
            }
            lector.Close();

            for (int i = 0; i < idsPlatos.Count; i++)
            {
                TxtCodigoPlato.Texts = idsPlatos[i];
                NucCantidad.Value = cantidades[i];
                TxtCodigoPlato_KeyPress(null, new KeyPressEventArgs(((char)Keys.Enter)));
            }
        }
        #endregion

        #region Asignacion de datos a controles
        // Asigna las mesas libres en la combo box correspondiente.
        private void AsignarMesasLibres()
        {
            CboMesasLocalDetalles.Items.Clear();
            CboMesasLocalTipo.Items.Clear();
            CargarMesasLibres();

            CboMesasLocalTipo.SelectedIndex = -1;
            CboMesasLocalDetalles.SelectedIndex = -1;
        }

        // Carga una tabla con las mesas que están disponibles.
        private void CargarMesasLibres()
        {
            string sql = "SELECT IdMesa FROM Mesas WHERE Estado = 'Libre'";
            MySqlCommand cmd = new MySqlCommand(sql, ConexionBD);
            MySqlDataReader lector = cmd.ExecuteReader();

            CboMesasLocalDetalles.Items.Clear();
            CboMesasLocalTipo.Items.Clear();
            while (lector.Read())
            {
                CboMesasLocalDetalles.Items.Add(lector["IdMesa"].ToString());
                CboMesasLocalTipo.Items.Add(lector["IdMesa"].ToString());
            }
            lector.Close();
        }

        // Añade la fecha y hora actuales a sus etiquetas correspondientes.
        private void AsignarFechaHora()
        {
            LblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            LblHora.Text = DateTime.Now.ToString("HH:mm");
            LblHora.Tag = DateTime.Now.ToString("HH:mm:ss");
        }

        // Asigna los tipos de estados de pedidos a su combo box correspondiente.
        private void AsignarEstadosPedido()
        {
            CboEstado.Items.Clear();
            switch (TabTipoDatosDetalles.SelectedIndex)
            {
                case 0:
                    CboEstado.Items.Add("En preparación");
                    CboEstado.Items.Add("Finalizado");
                    break;

                case 1:
                    CboEstado.Items.Add("En preparación");
                    CboEstado.Items.Add("Preparado");
                    CboEstado.Items.Add("En reparto");
                    CboEstado.Items.Add("Entregado");
                    break;

                case 2:
                    CboEstado.Items.Add("En preparación");
                    CboEstado.Items.Add("Preparado");
                    CboEstado.Items.Add("Recogido");
                    break;
            }
            CboEstado.SelectedIndex = 0;
        }
        #endregion

        #region Inicializacion de variables
        private void InicializarListaDatosOpcionales()
        {
            ListaDatosOpcionales.Add(TxtNombreDomicilioTipo);
            ListaDatosOpcionales.Add(TxtNombreDomicilioDetalles);
            ListaDatosOpcionales.Add(TxtNombreRecogerDetalles);
            ListaDatosOpcionales.Add(TxtNombreRecogerTipo);
        }
        #endregion
        #endregion

        #region Selección de tipo de pedido
        #region Botones tipo de pedido
        // Cambia a las pestaña de pedido local.
        private void BtnLocal_Click(object sender, EventArgs e)
        {
            TabTipoDatosTipo.SelectedIndex = 0;
        }

        // Cambia a las pestaña de pedido a domicilio.
        private void BtnDomicilio_Click(object sender, EventArgs e)
        {
            TabTipoDatosTipo.SelectedIndex = 1;
        }

        // Cambia a las pestaña de pedido a recoger.
        private void BtnRecoger_Click(object sender, EventArgs e)
        {
            TabTipoDatosTipo.SelectedIndex = 2;
        }

        // Si pulsa enter en alguna de las últimas text box de las tab pages, ejecuta el botón siguiente.
        private void LastTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals((char)Keys.Enter))
            {
                BtnSiguiente_Click(null, null);
                e.Handled = true;
            }
        }
        #endregion

        #region Boton siguiente
        // Cuando se pulsa el botón de siguiente, valida que los datos introducidos sean correctos
        // y cambia a la pestaña de detalles pasándoselos.
        private void BtnSiguiente_Click(object sender, EventArgs e)
        {
            if (ValidarDatosCompletados(TabTipoDatosTipo) && ValidarPedidoNoRepetido())
            {
                TabPrincipal.SelectedIndex = 1;
                PasarDatosADetalles();
                CboTipo.SelectedIndex = TabTipoDatosTipo.SelectedIndex;
            }
        }

        // Pasa los datos rellenados en la ventana de tipo a la ventana de detalles
        private void PasarDatosADetalles()
        {
            TabTipoDatosDetalles.SelectedIndex = TabTipoDatosTipo.SelectedIndex;

            if (CboMesasLocalTipo.SelectedIndex != -1 && TabTipoDatosTipo.SelectedIndex == 0)
                CboMesasLocalDetalles.SelectedIndex = CboMesasLocalTipo.SelectedIndex;

            for (int i = 0; i < TabTipoDatosTipo.SelectedTab.Controls.Count; i++)
            {
                try
                {
                    RJTextBox txtTipo = (RJTextBox)TabTipoDatosTipo.SelectedTab.Controls[i];
                    RJTextBox txtDetalles = (RJTextBox)TabTipoDatosDetalles.TabPages[TabTipoDatosTipo.SelectedIndex].Controls[i];
                    txtDetalles.Texts = txtTipo.Texts.Trim();
                }
                catch (InvalidCastException ex) { }
            }
        }

        // Valida que todas las text box obligatorias del tab page actual estén completadas.
        private bool ValidarDatosCompletados(TabControl tab)
        {
            foreach (Control control in tab.SelectedTab.Controls)
            {
                try
                {
                    RJTextBox txt = (RJTextBox)control;

                    if (!ListaDatosOpcionales.Contains(txt)
                        && string.IsNullOrEmpty(txt.Texts.Trim()))
                    {
                        MessageBox.Show("¡Debes completar todos los datos!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }
                catch (InvalidCastException ex) { }
            }

            if (TabPrincipal.SelectedIndex == 0
                && TabTipoDatosTipo.SelectedIndex == 0
                && CboMesasLocalTipo.SelectedIndex == -1)
            {
                MessageBox.Show("¡Debes completar todos los datos!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (TabPrincipal.SelectedIndex == 1
                && ((TabTipoDatosDetalles.SelectedIndex == 0
                && CboMesasLocalDetalles.SelectedIndex == -1)
                || CboEstado.SelectedIndex == -1 || CboTipo.SelectedIndex == -1))
            {
                MessageBox.Show("¡Debes completar todos los datos!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (TabPrincipal.SelectedIndex == 0)
                return ValidarNumeroTlfCliente(TabTipoDatosTipo);
            else
                return ValidarNumeroTlfCliente(TabTipoDatosDetalles);
        }

        private bool ValidarNumeroTlfCliente(TabControl tab)
        {
            if (tab.SelectedIndex != 0)
            {
                string tlf;
                if (TabPrincipal.SelectedIndex == 0)
                {
                    if (tab.SelectedIndex == 1)
                        tlf = TxtTlfDomicilioTipo.Texts.Replace(" ", "");
                    else
                        tlf = TxtTlfRecogerTipo.Texts.Replace(" ", "");
                }
                else
                {
                    if (tab.SelectedIndex == 1)
                        tlf = TxtTlfDomicilioDetalles.Texts.Replace(" ", "");
                    else
                        tlf = TxtTlfRecogerDetalles.Texts.Replace(" ", "");
                }

                //Regex regex = new Regex("^(\\+[0-9][0-9] ?)?([0-9]{3} ?)([0-9]{2} ?){2}([0-9]{2})$");
                Regex regex = new Regex("^(\\+[0-9][0-9])?([0-9]{9})$");
                if (regex.IsMatch(tlf))
                    return true;
                else
                {
                    MessageBox.Show("¡El formato del teléfono no es válido!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return true;
        }
        #endregion
        #endregion

        #region Detalles del pedido
        #region Tipo de pedido
        private void CboTipo_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (CboTipo.SelectedIndex != -1)
                TabTipoDatosDetalles.SelectedIndex = CboTipo.SelectedIndex;
            AsignarEstadosPedido();
        }

        #endregion

        #region Inserción de platos
        // Añade un plato.
        private void BtnAñadirPlato_Click(object sender, EventArgs e)
        {
            AñadirPlato();
        }

        // Si se ha pulsado enter, añade un plato.
        private void TxtCodigoPlato_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals((char)Keys.Enter))
            {
                e.Handled = true;
                AñadirPlato();
            }

            //else if (e.KeyChar.Equals((char)Keys.Up))
            //{
            //    NucCantidad.Value++;
            //}
            //else if (e.KeyChar.Equals((char)Keys.Down))
            //{
            //    NucCantidad.Value--;
            //}
        }

        // Si el código es correcto, añade un plato al data grid tanta veces como diga el numeric up down.
        private void AñadirPlato()
        {
            if (ValidarCodigoPlatoExistente())
            {
                int indexRow = ValidarPlatoNoRepetido();
                if (indexRow == -1)
                {
                    string[] datosPlatos = new string[3];
                    CargarPlatos(ref datosPlatos);
                    DtgPlatosPedidos.Rows.Add(new object[] 
                    {
                        datosPlatos[0], datosPlatos[1], NucCantidad.Value,
                        datosPlatos[2], decimal.Parse(datosPlatos[2])*NucCantidad.Value
                    });
                    DtgPlatosPedidos_CellValueChanged(null, null);
                }
                else
                {
                    decimal valorActual = decimal.Parse(DtgPlatosPedidos.Rows[indexRow].Cells[2].Value.ToString());
                    decimal cantidadTotal = valorActual + NucCantidad.Value;

                    if (cantidadTotal > 99) cantidadTotal = 99;
                    if (cantidadTotal < 1) cantidadTotal = 1;
                    DtgPlatosPedidos.Rows[indexRow].Cells[2].Value = cantidadTotal;
                }
                TxtCodigoPlato.Texts = string.Empty;
                NucCantidad.Value = 1;
            }
        }

        // Carga los datos necesarios para mostrar el plato en una lista. Si el plato no está repetido lo
        // mete en una fila nueva, en caso contrario, actualiza la fila correspondiente.
        private void CargarPlatos(ref string[] datosPlato)
        {

            string sql = "SELECT IdPlatoComida, Nombre, PrecioConIVA FROM PlatosComida " +
                "WHERE IdPlatoComida = '" + TxtCodigoPlato.Texts.Trim().ToUpper() + "'";
            MySqlCommand cmd = new MySqlCommand(sql, ConexionBD);
            MySqlDataReader lector = cmd.ExecuteReader();

            for (int i = 0; i < lector.FieldCount; i++)
            {
                lector.Read();
                datosPlato[i] = lector.GetString(i);
            }
            lector.Close();

        }

        // Valida que el plato que se está metiendo no esté repetido. Si el plato no está repetido devuelve
        // -1, en caso contrario, devuelve el indice de la fila donde ya está.
        private int ValidarPlatoNoRepetido()
        {
            for (int i = 0; i < DtgPlatosPedidos.Rows.Count; i++)
            {
                if (DtgPlatosPedidos.Rows[i].Cells[0].Value.ToString().Equals(TxtCodigoPlato.Texts.Trim().ToUpper()))
                    return i;
            }
            return -1;
        }

        // Valida si el código introducido corresponde a algún plato de comida.
        private bool ValidarCodigoPlatoExistente()
        {
            string sql = "SELECT * FROM PlatosComida WHERE IdPlatoComida = '" + TxtCodigoPlato.Texts.Trim().ToUpper() + "'";
            MySqlCommand cmd = new MySqlCommand(sql, ConexionBD);
            if (cmd.ExecuteScalar() != null)
                return true;

            string mensaje = "¡No se ha encontrado ningún plato que corresponda a ese código!";
            MessageBox.Show(mensaje, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        // Cada vez que se hacen cambios en el data grid de platos, calcula el precio final por cada fila y el precio total.
        private void DtgPlatosPedidos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            decimal precioConIVA = 0;
            decimal precioSinIVA = 0;
            foreach (DataGridViewRow row in DtgPlatosPedidos.Rows)
            {
                row.Cells[4].Value = decimal.Parse(row.Cells[3].Value.ToString()) * decimal.Parse(row.Cells[2].Value.ToString());
                precioConIVA += decimal.Parse(row.Cells[4].Value.ToString());
                precioSinIVA += (decimal.Parse(row.Cells[3].Value.ToString()) / 1.1m) * decimal.Parse(row.Cells[2].Value.ToString());
            }
            LblPrecioConIVA.Text = precioConIVA.ToString() + "€";
            LblPrecioSinIVA.Text = decimal.Round(precioSinIVA, 2).ToString() + "€";
        }
        #endregion

        #region Boton borrar fila plato
        // Borra la fila de platos seleccionada.
        private void BtnBorrarFilaPlato_Click(object sender, EventArgs e)
        {
            DtgPlatosPedidos.Rows.Remove(DtgPlatosPedidos.SelectedRows[0]);
            DtgPlatosPedidos_CellValueChanged(null, null);
        }

        // Cuando se selecciona una fila de platos el botón de borrar platos se activa. 
        // Cuando se deselecciona una fila, el botón se desactiva.
        private void DtgPlatosPedidos_SelectionChanged(object sender, EventArgs e)
        {
            if (DtgPlatosPedidos.SelectedRows.Count > 0)
                BtnBorrarFilaPlato.Enabled = true;
            else
                BtnBorrarFilaPlato.Enabled = false;
        }
        #endregion

        #region Boton confirmar/guardar cambios
        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            if (ValidarPedidoDisponible() && ValidarDatosCompletados(TabTipoDatosDetalles) && ValidarPlatosAñadidos())
            {
                bool continuarAccion;

                if (CboEstado.SelectedIndex == CboEstado.Items.Count - 1)
                    continuarAccion = FinalizarPedido();
                else if (string.IsNullOrEmpty(ClavePrimariaPedidoEnCurso))
                    continuarAccion = DarAltaPedido();
                else
                    continuarAccion = GuardarModificacionPedido();

                if (continuarAccion) this.Close();
            }
        }

        // Valida que el pedido aún esté disponible. Solo aplica para la finalizacion, modificación y borrado.
        private bool ValidarPedidoDisponible()
        {
            if (!string.IsNullOrEmpty(ClavePrimariaPedidoEnCurso))
            {
                string sql = "SELECT * FROM PedidosEnCurso WHERE IdPedido = " + ClavePrimariaPedidoEnCurso;
                MySqlCommand cmd = new MySqlCommand(sql, ConexionBD);

                if (cmd.ExecuteScalar() == null)
                {
                    string mensaje = "¡El pedido ya no está disponible, alguien debe haberlo cancelado o finalizado mientras lo consultabas!";
                    MessageBox.Show(mensaje, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    return false;
                }
            }
            return true;
        }

        // Valida que se haya añadido mínimo un plato al pedido.
        private bool ValidarPlatosAñadidos()
        {
            if (DtgPlatosPedidos.RowCount > 0)
                return true;
            MessageBox.Show("¡Debes añadir algún plato al pedido!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        #region Alta de pedido
        // Da de alta un pedido en la BBDD.
        private bool DarAltaPedido()
        {
            if (ConfirmarAccion("dar de alta") && ValidarCliente() && ValidarPedidoNoRepetido() && OcuparMesa())
            {
                string clavePrimaria = ""; // Clave primaria con la que se registrará en la BBDD
                RegistrarPedido(ref clavePrimaria);
                RegistrarPlatosPedido(clavePrimaria);
                InformarAccionConExito();
                return true;
            }
            else
                return false;
        }

        // Valida que el pedido actual no está ya asociado a una mesa o un cliente.
        private bool ValidarPedidoNoRepetido()
        {
            string condicion = "";
            string clienteAsociado = "";
            if (TabPrincipal.SelectedIndex == 0)
            {
                switch (TabTipoDatosTipo.SelectedIndex)
                {
                    case 0:
                        condicion = "IdMesa = " + CboMesasLocalTipo.SelectedItem.ToString();
                        clienteAsociado = "esta mesa";
                        break;

                    case 1:
                        condicion = "TelefonoCliente = '" + TxtTlfDomicilioTipo.Texts.Replace(" ", "") + "'";
                        clienteAsociado = "este cliente";
                        break;

                    case 2:
                        condicion = "TelefonoCliente = '" + TxtTlfRecogerTipo.Texts.Replace(" ", "") + "'";
                        clienteAsociado = "este cliente";
                        break;
                }
            }
            else
            {
                switch (CboTipo.SelectedIndex)
                {
                    case 0:
                        condicion = "IdMesa = " + CboMesasLocalDetalles.SelectedItem.ToString();
                        clienteAsociado = "esta mesa";
                        break;

                    case 1:
                        condicion = "TelefonoCliente = '" + TxtTlfDomicilioDetalles.Texts.Replace(" ", "") + "'";
                        clienteAsociado = "este cliente";
                        break;

                    case 2:
                        condicion = "TelefonoCliente = '" + TxtTlfRecogerDetalles.Texts.Replace(" ", "") + "'";
                        clienteAsociado = "este cliente";
                        break;
                }
            }

            string sql = "SELECT IdPedido FROM PedidosEnCurso WHERE " + condicion;
            MySqlCommand cmd = new MySqlCommand(sql, ConexionBD);

            if (cmd.ExecuteScalar() != null && !cmd.ExecuteScalar().ToString().Equals(ClavePrimariaPedidoEnCurso))
            {
                MessageBox.Show("¡Ya existe un pedido asociado a " + clienteAsociado + "!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void RegistrarPedido(ref string clavePrimaria)
        {
            string columnas = "";
            string valores = "";
            switch (CboTipo.SelectedIndex)
            {
                case 0:
                    columnas = "NombreUsuario, IdMesa";
                    valores = "'" + UsuarioActual + "', " + CboMesasLocalDetalles.SelectedItem.ToString();
                    break;

                case 1:
                    columnas = "TelefonoCliente";
                    valores = TxtTlfDomicilioDetalles.Texts.Replace(" ", "");
                    break;

                case 2:
                    columnas = "TelefonoCliente";
                    valores = TxtTlfRecogerDetalles.Texts.Replace(" ", "");
                    break;
            }

            string fechaFormateada = DateTime.Parse(LblFecha.Text).ToString("yyyy/MM/dd");
            string horaFormateada = DateTime.Parse(LblHora.Tag.ToString()).ToString("HH:mm:ss");
            string precioConIVAFormateado = decimal.Parse(LblPrecioConIVA.Text.Remove(LblPrecioConIVA.Text.Length - 1)).ToString(CultureInfo.CreateSpecificCulture("en-GB"));
            string precioSinIVAFormateado = decimal.Parse(LblPrecioSinIVA.Text.Remove(LblPrecioSinIVA.Text.Length - 1)).ToString(CultureInfo.CreateSpecificCulture("en-GB"));
            clavePrimaria = BuscarUltimaClavePrimaria("PedidosEnCurso");
            string sql = string.Format(
                "INSERT INTO PedidosEnCurso(IdPedido, Estado, Fecha, Hora, PrecioConIVA, PrecioSinIVA, Tipo, {0}) "
                + "VALUES({1}, '{2}', '{3}', '{4}', {5}, {6}, '{7}', {8});",
                columnas, clavePrimaria, CboEstado.Texts, fechaFormateada, horaFormateada, precioConIVAFormateado,
                precioSinIVAFormateado, CboTipo.SelectedItem.ToString(), valores);

            MySqlCommand cmd = new MySqlCommand(sql, ConexionBD);
            cmd.ExecuteNonQuery();
        }

        private void RegistrarPlatosPedido(string clavePrimaria)
        {
            foreach (DataGridViewRow row in DtgPlatosPedidos.Rows)
            {
                string sql = string.Format(
                        "INSERT INTO PedidosEnCursoPlatos(IdPedido, IdPlatoComida, Cantidad) VALUES({0}, '{1}', {2});",
                        clavePrimaria, row.Cells[0].Value.ToString(), row.Cells[2].Value.ToString());
                MySqlCommand cmd = new MySqlCommand(sql, ConexionBD);
                cmd.ExecuteNonQuery();
            }
        }

        // Devuelve la última clave primaria registrada en una tabla y le suma 1.
        private string BuscarUltimaClavePrimaria(string tabla)
        {
            string sql = "SELECT IdPedido FROM " + tabla + " ORDER BY IdPedido DESC";
            MySqlCommand cmd = new MySqlCommand(sql, ConexionBD);
            int clavePrimaria;
            if (cmd.ExecuteScalar() != null)
                clavePrimaria = int.Parse(cmd.ExecuteScalar().ToString()) + 1;
            else
                clavePrimaria = 1;
            return clavePrimaria.ToString();
        }
        #endregion

        #region Modificación de pedido
        // Guarda los datos realizados en el pedido en la BBDD.
        private bool GuardarModificacionPedido()
        {
            string valores = "";
            List<string[]> platosAñadidos = new List<string[]>();
            List<string[]> platosEliminados = new List<string[]>();
            List<string[]> platosModificados = new List<string[]>();

            bool datosHanSidoModificados = ComprobarDatosModificados(ref valores);
            bool platosHanSidoModificados = ComprobarPlatosModificados(ref platosAñadidos, ref platosEliminados, ref platosModificados);
            if (datosHanSidoModificados | platosHanSidoModificados)
            {
                if (ConfirmarAccion("guardar los cambios realizados en") && ValidarCliente() && ValidarPedidoNoRepetido() && OcuparMesa())
                {
                    string sql = "";
                    MySqlCommand cmd = new MySqlCommand(sql, ConexionBD);

                    // Actualiza los datos del pedido
                    if (datosHanSidoModificados)
                    {
                        sql = string.Format("UPDATE PedidosEnCurso SET {0} WHERE IdPedido = {1};",
                        valores, ClavePrimariaPedidoEnCurso);
                        cmd.CommandText = sql;
                        cmd.ExecuteNonQuery();
                    }

                    // Actualiza los platos del pedido
                    if (platosHanSidoModificados)
                    {
                        // Actualiza los platos añadidos
                        foreach (string[] plato in platosAñadidos)
                        {
                            sql = string.Format("INSERT INTO PedidosEnCursoPlatos(IdPedido, IdPlatoComida, Cantidad) "
                                + "VALUES({0}, '{1}', {2});", ClavePrimariaPedidoEnCurso, plato[0], plato[1]);
                            cmd.CommandText = sql;
                            cmd.ExecuteNonQuery();
                        }

                        // Actualiza los platos eliminados
                        foreach (string[] plato in platosEliminados)
                        {
                            sql = string.Format("DELETE FROM PedidosEnCursoPlatos WHERE IdPedido = {0} AND IdPlatoComida = '{1}';",
                                ClavePrimariaPedidoEnCurso, plato[0]);
                            cmd.CommandText = sql;
                            cmd.ExecuteNonQuery();
                        }

                        // Actualiza los platos cuyos datos han sido modificados
                        foreach (string[] plato in platosModificados)
                        {
                            sql = string.Format("UPDATE PedidosEnCursoPlatos SET Cantidad = {0} WHERE IdPedido = {1} AND IdPlatoComida = '{2}';",
                                plato[1], ClavePrimariaPedidoEnCurso, plato[0]);
                            cmd.CommandText = sql;
                            cmd.ExecuteNonQuery();
                        }
                    }

                    if (CboTipo.SelectedIndex == 0)
                    {
                        if (!CboMesasLocalDetalles.SelectedItem.ToString().Equals(IdMesaInicial))
                            LiberarMesa();
                    }
                    else
                        LiberarMesa();

                    InformarAccionConExito();
                    return true;
                }
                else
                    return false;
            }
            else
            {
                ValidarCliente();
                return true;
            }
        }

        private bool ComprobarDatosModificados(ref string valores)
        {
            bool modificacionRealizada = false;
            List<string> datosActuales = RecogerDatosActuales();
            List<string> columnasDatos = InicializarListaColumnasDatos();
            List<string> datosModificados = new List<string>();
            string dato;

            for (int i = 0; i < DatosIniciales.Count; i++)
            {
                if (!DatosIniciales[i].Equals(datosActuales[i]))
                {
                    bool llevaComillas = columnasDatos[i].Last<char>() == '\'';
                    if (llevaComillas && datosActuales[i].Equals("NULL"))
                    {
                        columnasDatos[i] = columnasDatos[i].Remove(columnasDatos[i].Length - 1);
                        llevaComillas = false;
                    }
                    dato = columnasDatos[i] + datosActuales[i];
                    if (llevaComillas) dato += "'";
                    datosModificados.Add(dato);
                    modificacionRealizada = true;
                }
            }

            // Le da el formato adecuado para la sentencia SQL
            for (int i = 0; i < datosModificados.Count; i++)
            {
                valores += datosModificados[i];
                if (i != datosModificados.Count - 1) valores += ", ";
            }

            return modificacionRealizada;
        }

        private List<string> RecogerDatosActuales()
        {
            List<string> datosActuales = new List<string>();

            datosActuales.Add(DatosIniciales[0]);
            datosActuales.Add(CboEstado.SelectedItem.ToString());
            datosActuales.Add(DatosIniciales[2]);
            datosActuales.Add(DatosIniciales[3]);
            string precioConIVAFormateado = LblPrecioConIVA.Text.Remove(LblPrecioConIVA.Text.Length - 1);
            datosActuales.Add(decimal.Parse(precioConIVAFormateado).ToString(CultureInfo.CreateSpecificCulture("en-GB")));
            string precioSinIVAFormateado = LblPrecioSinIVA.Text.Remove(LblPrecioSinIVA.Text.Length - 1);
            datosActuales.Add(decimal.Parse(precioSinIVAFormateado).ToString(CultureInfo.CreateSpecificCulture("en-GB")));
            datosActuales.Add(CboTipo.SelectedItem.ToString());

            switch (CboTipo.SelectedIndex)
            {
                case 0:
                    if (!DatosIniciales[7].Equals("NULL"))
                        datosActuales.Add(DatosIniciales[7]);
                    else
                        datosActuales.Add(UsuarioActual);
                    datosActuales.Add("NULL");
                    datosActuales.Add(CboMesasLocalDetalles.SelectedItem.ToString());
                    break;

                case 1:
                    if (!DatosIniciales[7].Equals("NULL"))
                        datosActuales.Add(DatosIniciales[7]);
                    else
                        datosActuales.Add("NULL");
                    datosActuales.Add(TxtTlfDomicilioDetalles.Texts.Replace(" ", ""));
                    datosActuales.Add("NULL");
                    break;

                case 2:
                    if (!DatosIniciales[7].Equals("NULL"))
                        datosActuales.Add(DatosIniciales[7]);
                    else
                        datosActuales.Add("NULL");
                    datosActuales.Add(TxtTlfRecogerDetalles.Texts.Replace(" ", ""));
                    datosActuales.Add("NULL");
                    break;
            }

            return datosActuales;
        }

        private List<string> InicializarListaColumnasDatos()
        {
            List<string> columnas = new List<string>();
            columnas.Add("IdPedido = ");
            columnas.Add("Estado = '");
            columnas.Add("Fecha = '");
            columnas.Add("Hora = '");
            columnas.Add("PrecioConIVA = ");
            columnas.Add("PrecioSinIVA = ");
            columnas.Add("Tipo = '");
            columnas.Add("NombreUsuario = '");
            columnas.Add("TelefonoCliente = '");
            columnas.Add("IdMesa = ");
            return columnas;
        }

        private bool ComprobarPlatosModificados(ref List<string[]> platosAñadidos, ref List<string[]> platosEliminados, ref List<string[]> platosModificados)
        {
            bool modificacionRealizada = false;
            List<string[]> platosActuales = RecogerPlatosActuales();
            List<string[]> platos = new List<string[]>();

            // Platos añadidos
            platos = platosActuales.ToList();
            foreach (string[] plato in platosActuales)
            {
                if (!PlatosIniciales.Exists(x => x[0].Equals(plato[0])))
                {
                    platosAñadidos.Add(plato);
                    platos.Remove(plato);
                    modificacionRealizada = true;
                }
            }
            platosActuales = platos.ToList();

            // Platos eliminados
            platos = PlatosIniciales.ToList();
            foreach (string[] plato in PlatosIniciales)
            {
                if (!platosActuales.Exists(x => x[0].Equals(plato[0])))
                {
                    platosEliminados.Add(plato);
                    platos.Remove(plato);
                    modificacionRealizada = true;
                }
            }
            PlatosIniciales = platos.ToList();

            // Platos modificados
            platosActuales.Sort((x, y) => x[0].CompareTo(y[0]));
            PlatosIniciales.Sort((x, y) => x[0].CompareTo(y[0]));
            for (int i = 0; i < platosActuales.Count; i++)
            {
                if (!platosActuales[i][1].Equals(PlatosIniciales[i][1]))
                {
                    platosModificados.Add(platosActuales[i]);
                    modificacionRealizada = true;
                }
            }
            return modificacionRealizada;
        }

        private List<string[]> RecogerPlatosActuales()
        {
            List<string[]> platosActuales = new List<string[]>();
            string[] platoActual = new string[2];
            foreach (DataGridViewRow row in DtgPlatosPedidos.Rows)
            {
                platosActuales.Add(new string[] { row.Cells[0].Value.ToString(), row.Cells[2].Value.ToString() });
            }

            return platosActuales;
        }
        #endregion

        #region Finalizacion de pedido
        // Finaliza el pedido moviéndolo a la tabla de historial de pedidos y borrándolo de la de pedidos en curso.
        private bool FinalizarPedido()
        {
            if (!string.IsNullOrEmpty(ClavePrimariaPedidoEnCurso))
            {
                if (ConfirmarAccion("ir a la ventana para finalizar y pagar") && ValidarCliente())
                {
                    string precioConIva = LblPrecioConIVA.Text.Remove(LblPrecioConIVA.Text.Length - 1);
                    FrmPedidosPagos frm = new FrmPedidosPagos(this, precioConIva, ClavePrimariaPedidoEnCurso);
                    frm.Width = Instance.Width / 2 - Instance.Width / 5;
                    frm.Height = Instance.Height / 2 + Instance.Height / 6;
                    frm.Show();
                    return false;
                }
                else
                    return false;
            }
            else
            {
                string mensaje = "¡Primero debes dar de alta un pedido antes de finalizarlo!";
                MessageBox.Show(mensaje, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        private void FrmDetallesPedido_EnabledChanged(object sender, EventArgs e)
        {
            if (Enabled && !string.IsNullOrEmpty(MetodoPago))
            {
                string clavePrimariaHistorial = string.Empty;
                GuardarPedidoEnHistorial(ref clavePrimariaHistorial);
                GuardarPlatosPedidoEnHistorial(ref clavePrimariaHistorial);

                BorrarPedidoEnCurso();
                LiberarMesa();
                IncrementarCantidadPedidosCliente();

                ConfirmarExportacionFacturaPdf(clavePrimariaHistorial);

                InformarAccionConExito();
                this.Close();
            }
        }

        private void GuardarPedidoEnHistorial(ref string clavePrimaria)
        {
            string tlfColumna = "";
            string tlf = "";
            switch (CboTipo.SelectedIndex)
            {
                case 1:
                    tlfColumna = ", TelefonoCliente";
                    tlf = ", '" + TxtTlfDomicilioDetalles.Texts.Replace(" ", "") + "'";
                    break;

                case 2:
                    tlfColumna = ", TelefonoCliente";
                    tlf = ", '" + TxtTlfRecogerDetalles.Texts.Replace(" ", "") + "'";
                    break;
            }

            string fechaFormateada = DateTime.Parse(LblFecha.Text).ToString("yyyy/MM/dd");
            string horaFormateada = DateTime.Parse(LblHora.Tag.ToString()).ToString("HH:mm:ss");
            string precioConIVAFormateado = decimal.Parse(LblPrecioConIVA.Text.Remove(LblPrecioConIVA.Text.Length - 1)).ToString(CultureInfo.CreateSpecificCulture("en-GB"));
            string precioSinIVAFormateado = decimal.Parse(LblPrecioSinIVA.Text.Remove(LblPrecioSinIVA.Text.Length - 1)).ToString(CultureInfo.CreateSpecificCulture("en-GB"));
            string tipo = TabTipoDatosDetalles.SelectedTab.Text;
            clavePrimaria = BuscarUltimaClavePrimaria("HistorialPedidos");
            string sql = string.Format(
                    "INSERT INTO HistorialPedidos(IdPedido, Fecha, Hora, PrecioConIVA, PrecioSinIVA, Tipo, TipoPago{0}) "
                    + "VALUES({1}, '{2}', '{3}', {4}, {5}, '{6}', '{7}'{8});",
                    tlfColumna, clavePrimaria, fechaFormateada, horaFormateada, precioConIVAFormateado,
                    precioSinIVAFormateado, tipo, MetodoPago, tlf);

            MySqlCommand cmd = new MySqlCommand(sql, ConexionBD);
            cmd.ExecuteNonQuery();
        }

        private void GuardarPlatosPedidoEnHistorial(ref string clavePrimaria)
        {
            foreach (DataGridViewRow row in DtgPlatosPedidos.Rows)
            {
                string precioConIVAFormateado = decimal.Parse(row.Cells[3].Value.ToString()).ToString(CultureInfo.CreateSpecificCulture("en-GB"));
                string precioSinIVAFormateado = decimal.Round(decimal.Parse(row.Cells[3].Value.ToString()) / 1.10m, 2).ToString(CultureInfo.CreateSpecificCulture("en-GB"));
                string sql = string.Format(
                        "INSERT INTO HistorialPedidosPlatos(IdPedido, IdPlatoComida, NombrePlatoComida, " +
                        "PrecioConIVAPlatoComida, PrecioSinIVAPlatoComida, CantidadPlatoComida) "
                        + "VALUES({0}, '{1}', '{2}', {3}, {4}, {5});",
                        clavePrimaria, row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString(),
                        precioConIVAFormateado, precioSinIVAFormateado, row.Cells[2].Value.ToString());

                MySqlCommand cmd = new MySqlCommand(sql, ConexionBD);
                cmd.ExecuteNonQuery();
            }
        }

        #region Generación de PDF
        private void ConfirmarExportacionFacturaPdf(string clavePrimariaHistorial)
        {
            if (ConfirmarAccion2("exportar a formato PDF la factura del"))
                ExportarFacturaPdf(clavePrimariaHistorial);
        }

        private void ExportarFacturaPdf(string clavePrimariaHistorial)
        {
            try
            {
                string ruta = RecogerRuta();
                if (!string.IsNullOrEmpty(ruta))
                {
                    ruta += "\\Factura " + clavePrimariaHistorial + " " + DateTime.Now.ToString("dd-MM-yyyy HH-mm tt", CultureInfo.InvariantCulture) + ".pdf";
                    PdfWriter writerPdf = new PdfWriter(ruta);
                    PdfDocument pdf = new PdfDocument(writerPdf);
                    Document documentoPdf = new Document(pdf);

                    AñadirCabeceraPdf(ref documentoPdf);
                    AñadirTitulo(ref documentoPdf);
                    AñadirCuerpoPdf(ref documentoPdf, clavePrimariaHistorial);

                    documentoPdf.Close();
                }
            }
            catch (IOException ex)
            {
                string mensaje = "¡No se ha podido generar la factura en PDF debido a que existe un archivo con el mismo nombre que ya está en uso!";
                MessageBox.Show(mensaje, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string RecogerRuta()
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Seleccione un directorio para exportar en formato PDF la factura del pedido.";
            if (fbd.ShowDialog().Equals(DialogResult.OK))
                return fbd.SelectedPath;
            else
                return string.Empty;
        }

        #region Cabecera
        private void AñadirCabeceraPdf(ref Document documentoPdf)
        {
            string rutaImagenPdf = @"..\..\Imagenes\Garmoxu_Logo_Circle_New.png";
            if (File.Exists(rutaImagenPdf))
            {
                Table tablaPdf = new Table(2, false).UseAllAvailableWidth();

                iText.Layout.Element.Image imagenPdf = new iText.Layout.Element.Image(
                    ImageDataFactory.Create(rutaImagenPdf)).ScaleAbsolute(50, 50);

                Cell celda1Pdf = new Cell(1, 1)
                    .SetBorder(Border.NO_BORDER)
                    .SetTextAlignment(TextAlignment.CENTER)
                    .SetVerticalAlignment(VerticalAlignment.MIDDLE)
                    .Add(imagenPdf);
                tablaPdf.AddCell(celda1Pdf);

                string fechaActual = DateTime.Now.ToString("dddd dd/MM/yyyy HH:mm");
                string fechaFormateada = fechaActual.Substring(0, 1).ToUpper() + fechaActual.Substring(1, fechaActual.Length - 1);
                CrearCelda(TextAlignment.RIGHT, 15, tablaPdf, fechaFormateada);

                documentoPdf.Add(tablaPdf);

                documentoPdf.Add(new Paragraph("\n"));
            }
        }
        #endregion

        #region Titulo
        private void AñadirTitulo(ref Document documentoPdf)
        {
            Paragraph restaurantePdf = new Paragraph(RecogerNombreRestaurante())
                .SetTextAlignment(TextAlignment.CENTER)
                .SetFontSize(30)
                .SetBold();
            documentoPdf.Add(restaurantePdf);
            documentoPdf.Add(new LineSeparator(new SolidLine()));
        }

        private string RecogerNombreRestaurante()
        {
            string nombreRestaurante = string.Empty;
            string rutaAjustes = @"Ajustes\Ajustes.csv";
            if (File.Exists(rutaAjustes))
                nombreRestaurante = File.ReadAllText(rutaAjustes).Split(';')[0];
            return nombreRestaurante;
        }
        #endregion

        #region Cuerpo
        private void AñadirCuerpoPdf(ref Document documentoPdf, string clavePrimariaHistorial)
        {
            LineSeparator separador1Pdf = new LineSeparator(new DashedLine(1));
            Paragraph saltoDeLineaPdf = new Paragraph("\n");

            AñadirFacturaYTipoPedido(ref documentoPdf, clavePrimariaHistorial);
            documentoPdf.Add(saltoDeLineaPdf);
            documentoPdf.Add(separador1Pdf);
            AñadirTablaPlatos(ref documentoPdf);
            documentoPdf.Add(separador1Pdf);
            AñadirTotal(ref documentoPdf);
            AñadirDatosComplementarios(ref documentoPdf);
        }

        #region Factura y tipo de pedido
        private void AñadirFacturaYTipoPedido(ref Document documentoPdf, string clavePrimariaHistorial)
        {
            string tipoPedido = string.Empty;
            string datoPedido = string.Empty;
            RecogerDatosTipoPedido(ref tipoPedido, ref datoPedido);

            Table tablaPdf = new Table(2, false).UseAllAvailableWidth();
            CrearCelda(TextAlignment.LEFT, 15, tablaPdf, "Factura simplificada:");
            CrearCelda(TextAlignment.RIGHT, 15, tablaPdf, clavePrimariaHistorial);
            CrearCelda(TextAlignment.LEFT, 15, tablaPdf, tipoPedido);
            CrearCelda(TextAlignment.RIGHT, 15, tablaPdf, datoPedido);
            //if (TabTipoDatosDetalles.SelectedIndex == 0)
            //{
            //    CrearCelda(TextAlignment.LEFT, 15, tablaPdf, "Atendido por: ");
            //    CrearCelda(TextAlignment.RIGHT, 15, tablaPdf, BuscarNombreUsuario());
            //}
            documentoPdf.Add(tablaPdf);
        }

        private void RecogerDatosTipoPedido(ref string tipoPedido, ref string datoPedido)
        {
            switch (TabTipoDatosDetalles.SelectedIndex)
            {
                case 0:
                    tipoPedido = "Mesa:";
                    datoPedido = CboMesasLocalDetalles.SelectedItem.ToString();
                    break;

                case 1:
                    tipoPedido = "Teléfono cliente:";
                    datoPedido = TxtTlfDomicilioDetalles.Texts.Replace(" ", "");
                    break;

                case 2:
                    tipoPedido = "Teléfono cliente:";
                    datoPedido = TxtTlfRecogerDetalles.Texts.Replace(" ", "");
                    break;
            }
        }
        #endregion

        #region Platos
        private void AñadirTablaPlatos(ref Document documentoPdf)
        {
            Table cabecerasTablaPdf = new Table(4, false).UseAllAvailableWidth();
            CrearCelda(TextAlignment.LEFT, 15, cabecerasTablaPdf, "Artículo");
            CrearCelda(80, TextAlignment.RIGHT, 15, cabecerasTablaPdf, "P. Unitario");
            CrearCelda(40, TextAlignment.RIGHT, 15, cabecerasTablaPdf, "Cant");
            CrearCelda(80, TextAlignment.RIGHT, 15, cabecerasTablaPdf, "P. Total");
            documentoPdf.Add(cabecerasTablaPdf);

            documentoPdf.Add(new LineSeparator(new DashedLine(1)));

            Table tablaPdf = new Table(4, false).UseAllAvailableWidth();
            foreach (DataGridViewRow row in DtgPlatosPedidos.Rows)
            {
                CrearCelda(TextAlignment.LEFT, 15, tablaPdf, row.Cells[1].Value.ToString());
                CrearCelda(80, TextAlignment.RIGHT, 15, tablaPdf, row.Cells[3].Value.ToString());
                CrearCelda(40, TextAlignment.RIGHT, 15, tablaPdf, row.Cells[2].Value.ToString());
                CrearCelda(80, TextAlignment.RIGHT, 15, tablaPdf, row.Cells[4].Value.ToString());
            }
            documentoPdf.Add(tablaPdf);
        }
        #endregion

        #region Total
        private void AñadirTotal(ref Document documentoPdf)
        {
            decimal conIva = decimal.Parse(LblPrecioConIVA.Text.Remove(LblPrecioConIVA.Text.Length - 1));
            decimal sinIva = decimal.Parse(LblPrecioSinIVA.Text.Remove(LblPrecioSinIVA.Text.Length - 1));

            Table tablaPdf = new Table(2, false).UseAllAvailableWidth();
            CrearCelda(TextAlignment.RIGHT, 15, tablaPdf, "Base imponible");
            CrearCelda(80, TextAlignment.RIGHT, 15, tablaPdf, sinIva.ToString());
            CrearCelda(TextAlignment.RIGHT, 15, tablaPdf, "I.V.A. " + IVA + "%");
            CrearCelda(TextAlignment.RIGHT, 15, tablaPdf, (conIva - sinIva).ToString());
            documentoPdf.Add(tablaPdf);

            documentoPdf.Add(new LineSeparator(new DashedLine(1)));

            Table tabla2Pdf = new Table(2, false).UseAllAvailableWidth();
            CrearCelda(TextAlignment.RIGHT, 22, tabla2Pdf, "Total:").SetBold();
            CrearCelda(100, TextAlignment.RIGHT, 22, tabla2Pdf, LblPrecioConIVA.Text).SetBold();
            documentoPdf.Add(tabla2Pdf);
        }
        #endregion

        #region Datos complementarios
        private void AñadirDatosComplementarios(ref Document documentoPdf)
        {
            Paragraph saltoDeLineaPdf = new Paragraph("\n");
            documentoPdf.Add(saltoDeLineaPdf);
            documentoPdf.Add(saltoDeLineaPdf);

            Paragraph agradecimientoPdf = new Paragraph("¡Gracias por su visita!")
                .SetTextAlignment(TextAlignment.CENTER)
                .SetFontSize(20);
            documentoPdf.Add(agradecimientoPdf);
        }

        private string BuscarNombreUsuario()
        {
            string sql = "SELECT NombreEmpleado FROM Usuarios WHERE NombreUsuario = '" + UsuarioActual + "'";
            MySqlCommand cmd = new MySqlCommand(sql, ConexionBD);
            return cmd.ExecuteScalar().ToString();
        }
        #endregion
        #endregion

        #region Crear celdas
        private Cell CrearCelda(int width, TextAlignment aligmnent, int fontSize, Table table, string text)
        {
            Cell cell = new Cell(1, 1)
                   .SetWidth(width)
                   .SetBorder(Border.NO_BORDER)
                   .SetTextAlignment(aligmnent)
                   .SetVerticalAlignment(VerticalAlignment.MIDDLE)
                   .Add(new Paragraph(text)
                       .SetFontSize(fontSize));
            table.AddCell(cell);
            return cell;
        }

        private Cell CrearCelda(TextAlignment aligmnent, int fontSize, Table table, string text)
        {
            Cell cell = new Cell(1, 1)
                   .SetBorder(Border.NO_BORDER)
                   .SetTextAlignment(aligmnent)
                   .SetVerticalAlignment(VerticalAlignment.MIDDLE)
                   .Add(new Paragraph(text)
                       .SetFontSize(fontSize));
            table.AddCell(cell);
            return cell;
        }
        #endregion
        #endregion
        #endregion

        #region Cliente
        private bool ValidarCliente()
        {
            if (CboTipo.SelectedIndex != 0)
            {
                bool cancelarOperacion = false;
                if (DarAltaCliente(ref cancelarOperacion) || (!cancelarOperacion &&
                    GuardarCambiosCliente(ref cancelarOperacion) && !cancelarOperacion))
                    return true;
                else
                    return false;
            }
            return true;
        }

        // Si el cliente no está dado de alta, lo crea en la BBDD.
        private bool DarAltaCliente(ref bool cancelarOperacion)
        {
            if (!ValidarClienteExistente())
            {
                string mensaje = "El cliente no está registrado, es necesario darlo de alta. ¿Deseas continuar?";
                DialogResult mensajeConfirmacion = MessageBox.Show(mensaje, "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (mensajeConfirmacion.Equals(DialogResult.Yes))
                {
                    string datos = "";
                    switch (TabTipoDatosDetalles.SelectedIndex)
                    {
                        case 1:
                            datos = TxtTlfDomicilioDetalles.Texts.Replace(" ", "") + "', '" + TxtDirDomicilioDetalles.Texts.Trim()
                                + "', 0, '" + TxtNombreDomicilioDetalles.Texts.Trim();
                            break;

                        case 2:
                            datos = TxtTlfRecogerDetalles.Texts.Replace(" ", "") + "', null, 0, '" + TxtNombreRecogerDetalles.Texts.Trim();
                            break;
                    }

                    string sql = string.Format("INSERT INTO Clientes(TelefonoCliente, Direccion, CantidadPedidos, Nombre) "
                        + "VALUES('{0}');", datos);
                    MySqlCommand cmd = new MySqlCommand(sql, ConexionBD);
                    cmd.ExecuteNonQuery();
                    return true;
                }
                else
                    cancelarOperacion = true;
            }
            return false;
        }

        private bool ValidarClienteExistente()
        {
            string tlf;
            if (CboTipo.SelectedIndex == 1) tlf = TxtTlfDomicilioDetalles.Texts.Replace(" ", "");
            else tlf = TxtTlfRecogerDetalles.Texts.Replace(" ", "");

            string sql = "SELECT * FROM Clientes WHERE TelefonoCliente = '" + tlf + "'";
            MySqlCommand cmd = new MySqlCommand(sql, ConexionBD);
            return cmd.ExecuteScalar() != null;
        }

        private bool GuardarCambiosCliente(ref bool cancelarOperacion)
        {
            string sql = "";
            MySqlCommand cmd = new MySqlCommand(sql, ConexionBD);

            string tlf = null;
            string dir = null;
            string nombre = null;
            switch (TabTipoDatosDetalles.SelectedIndex)
            {
                case 1:
                    tlf = TxtTlfDomicilioDetalles.Texts.Replace(" ", "");
                    dir = TxtDirDomicilioDetalles.Texts.Trim();
                    nombre = TxtNombreDomicilioDetalles.Texts.Trim();
                    break;

                case 2:
                    tlf = TxtTlfRecogerDetalles.Texts.Replace(" ", "");
                    nombre = TxtNombreRecogerDetalles.Texts.Trim();
                    break;
            }

            bool dirModificada = false;
            if (dir != null)
            {
                cmd.CommandText = "SELECT Direccion FROM Clientes WHERE TelefonoCliente = '" + tlf + "'";
                dirModificada = !cmd.ExecuteScalar().ToString().Equals(dir);
            }

            cmd.CommandText = "SELECT Nombre FROM Clientes WHERE TelefonoCliente = '" + tlf + "'";
            bool nombreModificado = !cmd.ExecuteScalar().ToString().Equals(nombre);

            if (dirModificada || nombreModificado)
            {
                string mensaje = "¿Desea aplicar los cambios realizados en los datos del cliente?";
                DialogResult mensajeConfirmacion = MessageBox.Show(mensaje, "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (mensajeConfirmacion.Equals(DialogResult.Yes))
                {
                    if (dirModificada)
                    {
                        sql = "UPDATE Clientes SET direccion = '" + dir + "' WHERE TelefonoCliente = '" + tlf + "'";
                        cmd = new MySqlCommand(sql, ConexionBD);
                        cmd.ExecuteNonQuery();
                    }

                    if (nombreModificado)
                    {
                        sql = "UPDATE Clientes SET nombre = '" + nombre + "' WHERE TelefonoCliente = '" + tlf + "'";
                        cmd = new MySqlCommand(sql, ConexionBD);
                        cmd.ExecuteNonQuery();
                    }
                }
                else if (mensajeConfirmacion.Equals(DialogResult.Cancel))
                    cancelarOperacion = true;
            }

            return true;
        }

        private void IncrementarCantidadPedidosCliente()
        {
            if (TabTipoDatosDetalles.SelectedIndex != 0)
            {
                string tlf;
                if (TabTipoDatosDetalles.SelectedIndex == 1)
                    tlf = TxtTlfDomicilioDetalles.Texts.Replace(" ", "");
                else
                    tlf = TxtTlfRecogerDetalles.Texts.Replace(" ", "");

                string sql = "SELECT CantidadPedidos FROM Clientes WHERE TelefonoCliente = '" + tlf + "'";
                MySqlCommand cmd = new MySqlCommand(sql, ConexionBD);
                int cantidadPedidos = int.Parse(cmd.ExecuteScalar().ToString());

                sql = "UPDATE Clientes SET CantidadPedidos = '" + cantidadPedidos++ + "' WHERE TelefonoCliente = '" + tlf + "'";
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
        }
        #endregion
        #endregion

        #region Boton borrar pedido
        // Borra el pedido de la BBDD y libera la mesa si tenía alguna ocupada.
        private void BtnBorrarPedido_Click(object sender, EventArgs e)
        {
            if (ValidarPedidoDisponible() && ConfirmarAccion("eliminar permanentemente"))
            {
                BorrarPedidoEnCurso();
                LiberarMesa();
                InformarAccionConExito();
                this.Close();
            }
        }

        // Borra un pedido en curso.
        private void BorrarPedidoEnCurso()
        {
            string sql = "DELETE FROM PedidosEnCurso WHERE IdPedido = '" + ClavePrimariaPedidoEnCurso + "'";
            MySqlCommand cmd = new MySqlCommand(sql, ConexionBD);
            cmd.ExecuteNonQuery();

            //foreach (DataGridViewRow row in DtgPlatosPedidos.Rows)
            //{
            //    sql = "DELETE FROM PedidosEnCursoPlatos WHERE IdPedido = " + ClavePrimariaPedidoEnCurso +
            //        " AND IdPlatoComida = '" + row.Cells[0].Value.ToString() + "'";
            //    cmd.CommandText = sql;
            //    cmd.ExecuteNonQuery();
            //}
        }
        #endregion

        #region Mesas
        // Comprueba si es necesario liberar alguna mesa, de ser así, lo hace.
        private void LiberarMesa()
        {
            if (!string.IsNullOrEmpty(IdMesaInicial))
            {
                string sql = "UPDATE Mesas SET Estado = 'Libre' WHERE IdMesa = " + IdMesaInicial;
                MySqlCommand cmd = new MySqlCommand(sql, ConexionBD);
                cmd.ExecuteNonQuery();
            }
        }

        // Comprueba si es necesario ocupar alguna mesa y si está libre, de ser así, lo hace.
        private bool OcuparMesa()
        {
            if (TabTipoDatosDetalles.SelectedIndex == 0 && !CboMesasLocalDetalles.SelectedItem.ToString().Equals(IdMesaInicial))
            {
                bool mesaEstaLibre = ComprobarMesaLibre(CboMesasLocalDetalles.SelectedItem.ToString());
                if (mesaEstaLibre)
                {
                    string sql = "UPDATE Mesas SET Estado = 'Ocupado' WHERE IdMesa = " + CboMesasLocalDetalles.SelectedItem.ToString();
                    MySqlCommand cmd = new MySqlCommand(sql, ConexionBD);
                    cmd.ExecuteNonQuery();
                    return true;
                }
                else
                    return false;
            }
            return true;
        }

        // Comprueba si una mesa está libre.
        private bool ComprobarMesaLibre(string idMesa)
        {
            string sql = "SELECT * FROM Mesas WHERE IdMesa = " + idMesa + " AND Estado = 'Libre'";
            MySqlCommand cmd = new MySqlCommand(sql, ConexionBD);

            if (cmd.ExecuteScalar() != null)
                return true;
            else
            {
                string mensaje = "¡La mesa seleccionada ha sido ocupada mientras realizabas el pedido, vuelve a revisar las mesas disponibles!";
                MessageBox.Show(mensaje, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CboMesasLocalDetalles.ResetText();
                CargarMesasLibres();
                return false;
            }
        }
        #endregion

        #region Escritura predictiva de cliente
        // Si se ha introducido un télefono y es válido, coge la dirección y/o el nombre del cliente asociado
        // y lo mete en las text box correspondientes.
        private void TextBoxTlf__TextChanged(object sender, EventArgs e)
        {
            if ((sender as TextBox).Text.Trim().Length > 8
                && ValidarTelefonoExistente(sender as TextBox))
            {
                string[] datosCliente;
                switch (TabPrincipal.SelectedIndex)
                {
                    case 0:
                        datosCliente = ObtenerDatosCliente(sender as TextBox);
                        AsignarDatosTlfCliente(TabTipoDatosTipo, new string[] { datosCliente[0], datosCliente[1] });
                        break;

                    case 1:
                        datosCliente = ObtenerDatosCliente(sender as TextBox);
                        AsignarDatosTlfCliente(TabTipoDatosDetalles, new string[] { datosCliente[0], datosCliente[1] });
                        break;
                }
            }
            else
            {
                switch (TabPrincipal.SelectedIndex)
                {
                    case 0:
                        AsignarDatosTlfCliente(TabTipoDatosTipo, new string[] { string.Empty, string.Empty });
                        break;

                    case 1:
                        AsignarDatosTlfCliente(TabTipoDatosDetalles, new string[] { string.Empty, string.Empty });
                        break;
                }
            }
        }

        // Asigna o borra los datos de las text box relacionadas con el cliente.
        private void AsignarDatosTlfCliente(TabControl tab, string[] datos)
        {
            switch (tab.SelectedIndex)
            {
                case 1:
                    ((RJTextBox)tab.TabPages[1].Controls[tab.TabPages[1].Controls.Count - 2]).Texts = datos[0];
                    ((RJTextBox)tab.TabPages[1].Controls[tab.TabPages[1].Controls.Count - 1]).Texts = datos[1];
                    break;

                case 2:
                    ((RJTextBox)tab.TabPages[2].Controls[tab.TabPages[2].Controls.Count - 1]).Texts = datos[1];
                    break;
            }
        }

        // Obtiene el nombre y dirección de un cliente y los devuelve en forma de array.
        private string[] ObtenerDatosCliente(TextBox txt)
        {
            string tlf = txt.Text.Replace(" ", "");
            string[] datosCliente = new string[2];
            MySqlCommand cmd = new MySqlCommand(
                "SELECT Direccion, Nombre FROM Clientes WHERE TelefonoCliente = '" + tlf + "'", ConexionBD);
            MySqlDataReader lector = cmd.ExecuteReader();
            for (int i = 0; i < lector.FieldCount; i++)
            {
                lector.Read();
                try
                {
                    datosCliente[i] = lector.GetString(i);
                }
                catch (SqlNullValueException ex)
                {
                    datosCliente[i] = string.Empty;
                }
            }
            lector.Close();
            return datosCliente;
        }

        // Devuelve true si el teléfono existe en la BBDD. False si no es así.
        private bool ValidarTelefonoExistente(TextBox txt)
        {
            string tlf = txt.Text.Replace(" ", "");
            MySqlCommand cmd = new MySqlCommand(
                "SELECT * FROM Clientes WHERE TelefonoCliente = '" + tlf + "'", ConexionBD);
            bool telefonoExistente = cmd.ExecuteScalar() != null;
            return telefonoExistente;
        }
        #endregion

        #region Mensajes
        // Muestra un mensaje de confirmación
        private bool ConfirmarAccion(string accion)
        {
            DialogResult accionConfirmada =
                MessageBox.Show("¿Desea " + accion + " el pedido actual?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (accionConfirmada.Equals(DialogResult.Yes))
                return true;
            return false;
        }

        private bool ConfirmarAccion2(string accion)
        {
            DialogResult accionConfirmada =
                MessageBox.Show("¿Desea " + accion + " pedido actual?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (accionConfirmada.Equals(DialogResult.Yes))
                return true;
            return false;
        }

        // Muestra un mensaje de éxito
        private void InformarAccionConExito()
        {
            MessageBox.Show("¡Operación concluida con éxito!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion
        #endregion

        #region Consulta de platos
        private void BtnConsultarPlatos_Click(object sender, EventArgs e)
        {
            FrmPedidosPlatosConsulta frm = new FrmPedidosPlatosConsulta(ConexionBD, Instance);

            bool encontrado = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.GetType().Equals(frm.GetType()))
                {
                    encontrado = true;
                    f.Show();
                    f.BringToFront();
                }
            }

            if (!encontrado)
                frm.Show();
        }
        #endregion

        #region Actualizacion automatica del numero de comensales 
        private void CboMesasLocal_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            Label lbl = new Label();
            string idMesa = string.Empty;
            switch (TabPrincipal.SelectedIndex)
            {
                case 0:
                    lbl = LblComensalesTipos;
                    idMesa = CboMesasLocalTipo.SelectedItem.ToString();
                    break;

                case 1:
                    lbl = LblComensalesDetalles;
                    idMesa = CboMesasLocalDetalles.SelectedItem.ToString();
                    break;
            }

            string sql = "SELECT NumeroComensales FROM Mesas WHERE IdMesa = " + idMesa;
            MySqlCommand cmd = new MySqlCommand(sql, ConexionBD);

            if (cmd.ExecuteScalar() != null)
                lbl.Text = cmd.ExecuteScalar().ToString();
            else
                lbl.Text = string.Empty;
        }
        #endregion 

        #region Cierre del formulario
        private void BtnClose_Click(object sender, EventArgs e)
        {
            if (!(!string.IsNullOrEmpty(ClavePrimariaPedidoEnCurso) && !ComprobarCualquierDatoModificado()))
            {
                string mensaje = "Se perderán todos los cambios no guardados. ¿Deseas continuar?";
                DialogResult cerrarVentana = MessageBox.Show(mensaje, "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (cerrarVentana.Equals(DialogResult.Yes))
                    this.Close();
            }
            else
                this.Close();
        }

        private bool ComprobarCualquierDatoModificado()
        {
            if (!(TabTipoDatosDetalles.SelectedIndex == 0 && CboMesasLocalDetalles.SelectedIndex == -1))
            {
                List<string> datosActuales = RecogerDatosActuales();

                bool modificacionRealizada = false;
                for (int i = 0; i < DatosIniciales.Count; i++)
                {
                    if (!DatosIniciales[i].Equals(datosActuales[i]))
                        modificacionRealizada = true;
                }

                if (!modificacionRealizada)
                {
                    string sql;
                    MySqlCommand cmd;

                    switch (TabTipoDatosDetalles.SelectedIndex)
                    {
                        case 1:
                            sql = "SELECT Direccion, Nombre FROM Clientes WHERE TelefonoCliente = '"
                                + TxtTlfDomicilioDetalles.Texts.Replace(" ", "") + "'";
                            cmd = new MySqlCommand(sql, ConexionBD);
                            MySqlDataReader lector = cmd.ExecuteReader();

                            if (lector.Read())
                            {
                                string dir;
                                string nombre;

                                if (string.IsNullOrEmpty(lector[0].ToString())) dir = string.Empty;
                                else dir = lector.GetString(0);

                                if (string.IsNullOrEmpty(lector[1].ToString())) nombre = string.Empty;
                                else nombre = lector.GetString(1);

                                if (!dir.Equals(TxtDirDomicilioDetalles.Texts.Trim()) 
                                    || !nombre.Equals(TxtNombreDomicilioDetalles.Texts.Trim()))
                                    modificacionRealizada = true;

                                lector.Close();
                            }
                            else
                                modificacionRealizada = true;
                            break;

                        case 2:
                            sql = "SELECT Nombre FROM Clientes WHERE TelefonoCliente = '"
                               + TxtTlfRecogerDetalles.Texts.Replace(" ", "") + "'";
                            cmd = new MySqlCommand(sql, ConexionBD);

                            if (cmd.ExecuteScalar() != null)
                            {
                                if (!cmd.ExecuteScalar().ToString().Equals(TxtNombreRecogerDetalles.Texts.Trim()))
                                    modificacionRealizada = true;
                            }
                            else
                                modificacionRealizada = true;

                            break;
                    }
                }

                if (!modificacionRealizada)
                {
                    List<string[]> v = new List<string[]>();
                    modificacionRealizada = ComprobarPlatosModificados(ref v, ref v, ref v);
                }

                return modificacionRealizada;
            }
            else
                return true;
        }

        // No poner muchas cosas aquí, ya que varias funciones llaman al this.Close() y se ejecuta lo que haya aquí.
        private void FrmDetallesPedido_FormClosing(object sender, FormClosingEventArgs e)
        {
            Instance.Enabled = true;
        }
        #endregion

        #region Getters y setters
        public string MetodoPagoGetSet { get => MetodoPago; set => MetodoPago = value; }
        #endregion
    }
}