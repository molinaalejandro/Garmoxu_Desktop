using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Garmoxu_Project
{
    public partial class FrmPago : Form
    {
        private FrmDetallesPedido Instance;

        public FrmPago(FrmDetallesPedido instance, string importeFinal)
        {
            InitializeComponent();
            Instance = instance;
            Instance.Enabled = false;
            TxtImporte.Texts = importeFinal;
            RdbTarjeta.Checked = true;
            TxtCliente.Text = importeFinal;
            TxtCliente.Select();
        }

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
            else if(ConfirmarAccion("pasar a finalizado el estado del"))

                this.Close();
        }
        #endregion

        #region Calculo del importe a devolver
        private void RdbEfectivo_CheckedChanged(object sender, EventArgs e)
        {
            CalcularImporteDevuelto();
        }

        private void TxtCliente_TextChanged(object sender, EventArgs e)
        {
            CalcularImporteDevuelto();
        }

        private void CalcularImporteDevuelto()
        {
            if (RdbEfectivo.Checked && ComprobarFormatoImporte())
            {
                string importeClienteFormateado = TxtCliente.Text.Replace(".", ",");
                decimal importeCliente = decimal.Parse(importeClienteFormateado);
                decimal importeFinal = decimal.Parse(TxtImporte.Texts);
                TxtDevuelto.Texts = (importeCliente - importeFinal) + string.Empty;
            }
            else
                TxtDevuelto.Texts = string.Empty;
        }

        private bool ComprobarFormatoImporte()
        {
            Regex rgx = new Regex("^[0-9]+([\\.,][0-9]{1,2})?$");

            if (!rgx.IsMatch(TxtCliente.Text))
                return false;

            return true;
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
        #endregion

        #region Cierre del formulario
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            string mensaje = "¿Desea cancelar la finalización del pedido? Se perderán todos los datos no guardados";

            DialogResult confirmacion = MessageBox.Show(mensaje, "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(confirmacion.Equals(DialogResult.Yes)) 
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
