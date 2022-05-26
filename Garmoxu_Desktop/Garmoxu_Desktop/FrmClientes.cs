using MySql.Data.MySqlClient;
using RJCodeAdvance.RJControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Garmoxu_Desktop.MessageBoxPersonalizado;
using static Garmoxu_Desktop.ConexionMySql;

namespace Garmoxu_Desktop
{
    public partial class FrmClientes : Form
    {
        private DataSet Ds;
        private List<string> DatosIniciales;
        private int RegistrosCargados;
        private const int CantidadRegistrosCargadosPorIteraccion = 50;

        public FrmClientes()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            CargarDatos();
        }

        #region Apertura del formulario

        private void FrmClientes_Shown(object sender, EventArgs e)
        {
            DtgClientes.ClearSelection();
        }

        #region Cargar datos
        private void CargarDatos()
        {
            string sql = "SELECT TelefonoCliente FROM Clientes ORDER BY TelefonoCliente ASC";
            Ds = new DataSet();
            Ds = RecogerTabla(sql, "Clientes");

            ResetearDataGrid();
            RellenarDataGrid();
        }

        private void ResetearDataGrid()
        {
            DtgClientes.Rows.Clear();
            RegistrosCargados = 0;
        }

        private void RellenarDataGrid()
        {
            for (int i = 0; i < CantidadRegistrosCargadosPorIteraccion; i++)
            {
                if (RegistrosCargados < Ds.Tables["Clientes"].Rows.Count)
                {
                    DtgClientes.Rows.Add(Ds.Tables["Clientes"].Rows[RegistrosCargados].ItemArray[0]);
                    RegistrosCargados++;
                }
            }
        }
        #endregion
        #endregion

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
            BtnAbrirNuevo.IconColor = Color.FromArgb(110, 255, 110);
        }

        private void BtnNuevo_MouseLeave(object sender, EventArgs e)
        {
            BtnAbrirNuevo.IconColor = Color.FromArgb(70, 225, 70);
        }
        #endregion

        #region Boton Quitar
        private void BtnQuitar_MouseEnter(object sender, EventArgs e)
        {
            BtnQuitar.IconColor = Color.LightCoral;
        }

        private void BtnQuitar_MouseLeave(object sender, EventArgs e)
        {
            BtnQuitar.IconColor = Color.FromArgb(255, 70, 70);
        }
        #endregion
        #endregion

        #region Carga progresiva de usuarios
        private void DtgClientes_Scroll(object sender, ScrollEventArgs e)
        {
            if ((e.Type == ScrollEventType.SmallIncrement || e.Type == ScrollEventType.LargeIncrement)
                && e.NewValue >= DtgClientes.Rows.Count - GetDisplayedRowsCount())
                RellenarDataGrid();
        }

        private int GetDisplayedRowsCount()
        {
            int count = DtgClientes.Rows[DtgClientes.FirstDisplayedScrollingRowIndex].Height;
            count = DtgClientes.Height / count;
            return count;
        }
        #endregion

        #region Busqueda de clientes
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtBuscar.Texts.Trim()) || TxtBuscar.Texts.Trim().Equals("Buscar por teléfono de cliente"))
            {
                string busqueda = TxtBuscar.Texts.Replace(" ", "");
                string sql = "SELECT TelefonoCliente FROM Clientes WHERE TelefonoCliente LIKE '" + busqueda + "%' " +
                    "OR TelefonoCliente LIKE '+__" + busqueda + "%' OR TelefonoCliente LIKE '+" + busqueda + "%' " +
                    "ORDER BY TelefonoCliente ASC";
                Ds = new DataSet();
                Ds = RecogerTabla(sql, "Clientes");

                ResetearDataGrid();
                RellenarDataGrid();
            }
            else CargarDatos();

            LimpiarControles();
        }

        private void TxtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals((char)Keys.Enter)) 
            {
                e.Handled = true;
                BtnBuscar_Click(null, null);
            }
        }

        private void TxtBuscar_Enter(object sender, EventArgs e)
        {
            if (TxtBuscar.Texts.Trim().Equals("Buscar por teléfono de cliente"))
            {
                TxtBuscar.Texts = string.Empty;
                TxtBuscar.ForeColor = Color.White;
            }
        }

        private void TxtBuscar_Leave(object sender, EventArgs e)
        {
            if (TxtBuscar.Texts.Trim().Equals(string.Empty))
            {
                TxtBuscar.Texts = "Buscar por teléfono de cliente";
                TxtBuscar.ForeColor = Color.Gray;
            }
        }
        #endregion

        #region Alta de clientes
        private void BtnAbrirNuevo_Click(object sender, EventArgs e)
        {
            Tbc.SelectedTab = tabPage2;
            tableLayoutPanel4.Visible = true;
        }

        #region Boton de guardar
        private void TextBoxAlta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals((char)Keys.Enter)) BtnRegistrarDatos_Click(null, null);
        }

        private void BtnRegistrarDatos_Click(object sender, EventArgs e)
        {
            if (ValidarDatosCompletados() && ValidarFormatoTelefono(TxtTelefonoTB2.Texts.Replace(" ", ""))
                && ConfirmarAccion("dar de alta") && ValidarTelefonoNoRegistrado(TxtTelefonoTB2))
            {
                string sql = string.Format( "INSERT INTO Clientes (TelefonoCliente, Direccion, CantidadPedidos, Nombre) " +
                    "VALUES ('{0}', '{1}', 0, '{2}')",
                    TxtTelefonoTB2.Texts.Replace(" ", ""), TxtDireccionTB2.Texts.Trim(), TxtNombreTB2.Texts.Trim());
                EjecutarSentencia(sql);

                CargarDatos();
                LimpiarControles();
                InformarAccionConExito();
            }
        }
        #endregion
        #endregion

        #region Modificacion de clientes
        #region Carga de los detalles del cliente
        private void DtgClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DtgClientes.SelectedRows.Count > 0)
            {
                string tlfSeleccionado = DtgClientes.SelectedRows[0].Cells[0].Value.ToString();
                if (ValidarClienteDisponible(tlfSeleccionado))
                {
                    Tbc.SelectedTab = tabPage1;
                    tableLayoutPanel9.Visible = true;

                    string sql = "SELECT * FROM Clientes WHERE TelefonoCliente = '" + tlfSeleccionado + "'";
                    MySqlDataReader lector = EjecutarConsulta(sql);

                    if (lector.Read())
                    {
                        TxtTelefonoTB1.Texts = lector[0].ToString();
                        TxtDireccionTB1.Texts = lector[1].ToString();
                        LblCantidadPedidos.Text = lector[2].ToString();
                        TxtNombreTB1.Texts = lector[3].ToString();

                        DatosIniciales = new List<string>();
                        DatosIniciales.Add(TxtTelefonoTB1.Texts);
                        DatosIniciales.Add(TxtDireccionTB1.Texts);
                        DatosIniciales.Add(TxtNombreTB1.Texts);
                    }
                    CerrarConexion();
                    lector.Close();
                }
            }
        }
        #endregion

        #region Boton de modificación de cliente
        private void TextBoxModificacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals((char)Keys.Enter)) BtnModificarCliente_Click(null, null);
        }

        private void BtnModificarCliente_Click(object sender, EventArgs e)
        {
            string valores = string.Empty;
            if (ValidarDatosCompletados() && ValidarFormatoTelefono(TxtTelefonoTB1.Texts.Replace(" ", ""))
                && ValidarClienteDisponible(DatosIniciales[0]) && ComprobarDatosModificados(ref valores)
                && ConfirmarAccion("modificar") && ValidarTelefonoNoRegistrado(TxtTelefonoTB1))
            {
                string sql = string.Format("UPDATE Clientes SET {0} WHERE TelefonoCliente = '{1}'", valores, DatosIniciales[0]);
                EjecutarSentencia(sql);

                CargarDatos();
                LimpiarControles();
                InformarAccionConExito();
            }
        }
        #endregion
        #endregion

        #region Eliminación de clientes
        private void DtgClientes_SelectionChanged(object sender, EventArgs e)
        {
            if (DtgClientes.SelectedRows.Count < 1)
            {
                BtnBorrarCliente.Enabled = false;
                BtnBorrarCliente.BackColor = Color.Gray;
                BtnQuitar.Enabled = false;
                BtnQuitar.IconColor = Color.Gray;
            }
            else
            {
                BtnBorrarCliente.Enabled = true;
                BtnBorrarCliente.BackColor = Color.Crimson;
                BtnQuitar.Enabled = true;
                BtnQuitar.IconColor = Color.Crimson;
            }
        }

        private void BtnBorrarCliente_Click(object sender, EventArgs e)
        {
            string tlfActual = TxtTelefonoTB1.Texts.Replace(" ", "");
            if (ValidarClienteDisponible(tlfActual) && ConfirmarAccion("eliminar permanentemente") && !ComprobarPedidosEnCurso()
                && ConfirmarEliminacionConReservas())
            {
                string tlfSeleccionado = DtgClientes.SelectedRows[0].Cells[0].Value.ToString();
                string sql = "DELETE FROM Clientes WHERE TelefonoCliente = '" + tlfSeleccionado + "'";
                EjecutarSentencia(sql);

                CargarDatos();
                LimpiarControles();
                InformarAccionConExito();
            }
        }

        private bool ComprobarPedidosEnCurso()
        {
            string tlfSeleccionado = DtgClientes.SelectedRows[0].Cells[0].Value.ToString();
            string sql = "SELECT TelefonoCliente FROM PedidosEnCurso WHERE TelefonoCliente = '" + tlfSeleccionado + "'";
            if (string.IsNullOrEmpty(EjecutarScalar(sql))) return false;

            string mensaje = "¡No se puede eliminar el cliente seleccionado debido a que tiene pedidos en curso asociados! " +
                "Finalice o cancele todos los pedidos en curso antes de continuar.";
            ShowWarningMessage(mensaje, "");

            return true;
        }

        private bool ConfirmarEliminacionConReservas()
        {
            string tlfSeleccionado = DtgClientes.SelectedRows[0].Cells[0].Value.ToString();
            string sql = string.Format("SELECT TelefonoCliente FROM Reservas WHERE TelefonoCliente = '{0}'", tlfSeleccionado);
            if (string.IsNullOrEmpty(EjecutarScalar(sql))) return true;

            string mensaje = "Este cliente tiene asociadas algunas reservas, tenga en cuenta que todas ellas serán eliminadas. ¿Desea continuar?";
            if (ShowQuestionDialog(mensaje, "").Equals(DialogResult.Yes)) return true;
            else return false;
        }
        #endregion

        #region Validaciones y comprobaciones
        private bool ValidarClienteDisponible(string tlf)
        {
            string sql = "SELECT * FROM Clientes WHERE TelefonoCliente = '" + tlf + "'";
            if (string.IsNullOrEmpty(EjecutarScalar(sql)))
            {
                string mensaje = "¡El cliente ya no está disponible! Alguien debe haberlo eliminado.";
                ShowErrorMessage(mensaje, "");
                CargarDatos();
                LimpiarControles();
                return false;
            }

            return true;
        }

        private bool ValidarDatosCompletados()
        {
            if (Tbc.SelectedIndex == 0)
            {
                if (!string.IsNullOrEmpty(TxtTelefonoTB1.Texts.Trim())
                    && !string.IsNullOrEmpty(TxtDireccionTB1.Texts.Trim())
                    && !string.IsNullOrEmpty(TxtNombreTB1.Texts.Trim()))
                    return true;
            }
            else
            {
                if (!string.IsNullOrEmpty(TxtTelefonoTB2.Texts.Trim())
                    && !string.IsNullOrEmpty(TxtDireccionTB2.Texts.Trim())
                    && !string.IsNullOrEmpty(TxtNombreTB2.Texts.Trim()))
                    return true;
            }

            string mensaje = "¡Debes completar todos los datos!";
            ShowWarningMessage(mensaje, "");
            return false;
        }

        private bool ValidarFormatoTelefono(string tlf)
        {
            Regex rgx = new Regex("^(\\+[0-9][0-9])?([0-9]{9})$");

            if (!rgx.IsMatch(tlf))
            {
                string mensaje = "¡El formato del teléfono introducido no es válido!";
                ShowWarningMessage(mensaje, "");
                return false;
            }

            return true;
        }

        private bool ValidarTelefonoNoRegistrado(RJTextBox txt)
        {
            string sql = "SELECT TelefonoCliente FROM Clientes WHERE TelefonoCliente = '" + txt.Texts.Replace(" ", "") + "'";
            string scalar = EjecutarScalar(sql);

            if (string.IsNullOrEmpty(scalar)) return true;

            if ((Tbc.SelectedIndex != 1) && scalar.Equals(DatosIniciales[0])) return true;

            string mensaje = "¡El teléfono introducido ya está registrado!";
            ShowWarningMessage(mensaje, "");
            return false;
        }

        #region Comprobacion de datos modificados
        private bool ComprobarDatosModificados(ref string valores)
        {
            bool modificacionRealizada = false;

            if (DatosIniciales != null && DatosIniciales.Count == 3)
            {
                string dato;

                List<string> datosActuales = RecogerDatosActuales();
                List<string> columnasDatos = InicializarListaColumnasDatos();
                List<string> datosModificados = new List<string>();

                for (int i = 0; i < datosActuales.Count; i++)
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

                if (!modificacionRealizada) LimpiarControles();
            }
            return modificacionRealizada;
        }

        private List<string> RecogerDatosActuales()
        {
            List<string> datosActuales = new List<string>();
            datosActuales.Add(TxtTelefonoTB1.Texts.Replace(" ", ""));
            datosActuales.Add(TxtDireccionTB1.Texts.Trim());
            datosActuales.Add(TxtNombreTB1.Texts.Trim());

            return datosActuales;
        }

        private List<string> InicializarListaColumnasDatos()
        {
            List<string> columnas = new List<string>();
            columnas.Add("TelefonoCliente = '");
            columnas.Add("Direccion = '");
            columnas.Add("Nombre = '");
            return columnas;
        }
        #endregion
        #endregion

        #region Limpiar controles
        private void LimpiarControles()
        {
            if (Tbc.SelectedIndex == 0)
            {
                TxtTelefonoTB1.Texts = string.Empty;
                TxtDireccionTB1.Texts = string.Empty;
                TxtNombreTB1.Texts = string.Empty;
            }
            else
            {
                TxtTelefonoTB2.Texts = string.Empty;
                TxtDireccionTB2.Texts = string.Empty;
                TxtNombreTB2.Texts = string.Empty;
            }
            DtgClientes.ClearSelection();
            tableLayoutPanel4.Visible = false;
            tableLayoutPanel9.Visible = false;
            //Tbc.Visible = false;
        }
        #endregion

        #region Mensajes
        // Muestra un mensaje de confirmación
        private bool ConfirmarAccion(string accion)
        {
            string mensaje = "¿Desea " + accion + " el cliente actual?";
            if (ShowQuestionDialog(mensaje, "").Equals(DialogResult.Yes)) return true;
            else return false;
        }

        // Muestra un mensaje de éxito
        private void InformarAccionConExito()
        {
            string mensaje = "¡Operación concluida con éxito!";
            ShowInfoMessage(mensaje, "");
        }
        #endregion

        #region Cierre del formulario
        private void FrmClientes_FormClosing(object sender, FormClosingEventArgs e)
        {
            string var = string.Empty;
            if ((Tbc.SelectedIndex == 1 && tableLayoutPanel4.Visible) || ComprobarDatosModificados(ref var))
            {
                string mensaje = "¿Desea salir sin guardar? Se perderán todos los cambios realizados.";
                if (!ShowQuestionDialog(mensaje, "").Equals(DialogResult.Yes)) e.Cancel = true;
            }
        }
        #endregion
    }
}