using RJCodeAdvance.RJControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    public partial class FrmPedidosPagos : Form
    {
        private FrmPedidosDetalles Instance;

        private string ImporteFinal;
        private string ClavePrimaria;

        public FrmPedidosPagos(FrmPedidosDetalles instance, string importeFinal, string clavePrimaria)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Instance = instance;
            Instance.Enabled = false;
            ImporteFinal = importeFinal;
            ClavePrimaria = clavePrimaria;
            CargarDatos();
        }

        #region Apertura del formulario
        private void CargarDatos()
        {
            TxtImporte.ForeColor = Color.Gainsboro;
            TxtDevuelto.ForeColor = Color.Gainsboro;

            TxtImporte.Texts = ImporteFinal;
            TxtCliente.Texts = ImporteFinal;
            TxtCliente.Select();
        }
        #endregion

        #region FrontEnd
        private void BtnClose_MouseEnter(object sender, EventArgs e)
        {
            BtnClose.IconColor = Color.FromArgb(240, 41, 83);
        }

        private void BtnClose_MouseLeave(object sender, EventArgs e)
        {
            BtnClose.IconColor = Color.DarkGray;
        }
        #endregion

        #region Confirmar
        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            if (RdbTarjeta.Checked)
                Instance.MetodoPagoGetSet = "Tarjeta";

            if (RdbEfectivo.Checked)
                Instance.MetodoPagoGetSet = "Efectivo";

            if (RdbTicket.Checked)
                Instance.MetodoPagoGetSet = "Cheque";

            if (string.IsNullOrEmpty(Instance.MetodoPagoGetSet))
                MessageBox.Show("¡Debes seleccionar algún método de pago!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (ConfirmarAccion("pasar a finalizado el estado del"))
                this.Close();
        }
        #endregion

        #region Calculo del importe a devolver
        private void RdbEfectivo_CheckedChanged(object sender, EventArgs e)
        {
            if (RdbEfectivo.Checked)
            {
                RdbTarjeta.Checked = false;
                RdbTicket.Checked = false;
            }

            CalcularImporteDevuelto();
        }

        private void TxtCliente__TextChanged(object sender, EventArgs e)
        {
            CalcularImporteDevuelto();
        }

        private void CalcularImporteDevuelto()
        {
            if (RdbEfectivo.Checked && ValidarFormatoImporteCliente())
            {
                string importeClienteFormateado = TxtCliente.Texts.Replace(".", ",");
                decimal importeCliente = decimal.Parse(importeClienteFormateado);
                decimal importeFinal = decimal.Parse(TxtImporte.Texts);
                TxtDevuelto.Texts = (importeCliente - importeFinal) + string.Empty;
            }
            else
                TxtDevuelto.Texts = string.Empty;
        }

        private bool ValidarFormatoImporteCliente()
        {
            Regex rgx = new Regex("^[0-9]{1,8}([\\.,][0-9]{1,2})?$");

            if (rgx.IsMatch(TxtCliente.Texts))
                return true;

            return false;
        }
        #endregion

        #region Cambios de checked
        private void RdbTarjeta_CheckedChanged(object sender, EventArgs e)
        {
            if (RdbTarjeta.Checked)
            {
                RdbEfectivo.Checked = false;
                RdbTicket.Checked = false;
            }
        }

        private void RdbTicket_CheckedChanged(object sender, EventArgs e)
        {
            if (RdbTicket.Checked)
            {
                RdbTarjeta.Checked = false;
                RdbEfectivo.Checked = false;
            }
        }
        #endregion

        #region Mensajes
        // Muestra un mensaje de confirmación
        private bool ConfirmarAccion(String accion)
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

        #region Cierre del formulario
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            string mensaje = "¿Desea cancelar la finalización del pedido? Se perderán todos los datos no guardados";
            DialogResult confirmacion = MessageBox.Show(mensaje, "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacion.Equals(DialogResult.Yes))
            {
                Instance.MetodoPagoGetSet = string.Empty;
                this.Close();
            }
        }

        private void FrmPago_FormClosing(object sender, FormClosingEventArgs e)
        {
            Instance.Enabled = true;
        }
        #endregion
    }
}
