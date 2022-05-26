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
using static Garmoxu_Desktop.MessageBoxPersonalizado;
using static Garmoxu_Desktop.ConexionMySql;

namespace Garmoxu_Desktop
{
    public partial class FrmPedidosPagos : Form
    {
        private FrmPedidosDetalles Instance;
        private string ImporteFinal;

        public FrmPedidosPagos(FrmPedidosDetalles instance, string importeFinal, ref Form frmShadow)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Instance = instance;
            ImporteFinal = importeFinal;
            CargarDatos();
            SombrearPantalla(ref frmShadow);
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

        #region Funciones y diseño del formulario
        #region Bordeado del formulario
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;

                // Solo se acumulan modificaciones de diferente tipos, es decir,
                // una de ExStyle, otra de Style y otra de ClassStyle. Pero, nunca
                // se pueden acumular dos modificaciones del mismo tipo, por ejemplo,
                // no se acumulan dos ExStyle, o aplicas uno, o aplicas el otro.

                //cp.ExStyle = 0x00000100; // Aperentemente no hace nada
                //cp.ExStyle = 0x00020000; // Borde simple fino arriba e izquierda y grueso abajo y derecha
                cp.ExStyle = 0x00000200; // Borde 3D arriba e izquierda
                //cp.ExStyle = 0x00000001; // Borde 3D abajo y derecha
                // https://docs.microsoft.com/en-us/windows/win32/winmsg/extended-window-styles

                //cp.Style |= 0x00800000; // Borde simple fino
                cp.Style |= 0x00400000; // Borde 3D abajo y derecha
                // https://docs.microsoft.com/en-us/windows/win32/winmsg/window-styles

                //cp.ClassStyle |= 0x00020000; // Shadow border
                return cp;
            }
        }
        #endregion

        #region Sombreado de pantalla
        private void SombrearPantalla(ref Form frmShadow)
        {
            frmShadow = new Form();
            frmShadow.ShowInTaskbar = false;
            frmShadow.Text = "";
            frmShadow.FormBorderStyle = FormBorderStyle.None;
            frmShadow.Size = Size;
            frmShadow.WindowState = FormWindowState.Maximized;
            frmShadow.BackColor = Color.Black;
            frmShadow.Opacity = 0.7;
            frmShadow.Location = Location;
            frmShadow.Enabled = false;
            frmShadow.TopMost = true;
            frmShadow.Show();
        }
        #endregion
        #endregion

        #region Funciones y diseños de controles
        private void FrmPedidosPagos_Shown(object sender, EventArgs e)
        {
            RdbTarjeta.TabStop = false;
            RdbEfectivo.TabStop = false;
            RdbTicket.TabStop = false;
        }
        #endregion

        #region Confirmar
        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals((char)Keys.Enter))
            {
                e.Handled = true;
                BtnConfirmar_Click(null, null);
            }
        }

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            if (RdbTarjeta.Checked) Instance.MetodoPagoGetSet = "Tarjeta";
            if (RdbEfectivo.Checked) Instance.MetodoPagoGetSet = "Efectivo";
            if (RdbTicket.Checked)  Instance.MetodoPagoGetSet = "Cheque";

            if (string.IsNullOrEmpty(Instance.MetodoPagoGetSet)) ShowWarningMessage("¡Debes seleccionar algún método de pago!", "");
            else if (ConfirmarAccion("pasar a finalizado el estado del")) this.Close();
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
        }

        private void TxtCliente__TextChanged(object sender, EventArgs e)
        {
            CalcularImporteDevuelto();
        }

        private void CalcularImporteDevuelto()
        {
            TxtDevuelto.Texts = "0,00";
            if (ValidarFormatoImporteCliente())
            {
                string importeClienteFormateado = TxtCliente.Texts.Replace(".", ",");
                decimal importeCliente = decimal.Parse(importeClienteFormateado);
                decimal importeFinal = decimal.Parse(TxtImporte.Texts);
                TxtDevuelto.Texts = (importeCliente - importeFinal) + string.Empty;
            }
        }

        private bool ValidarFormatoImporteCliente()
        {
            Regex rgx = new Regex("^[0-9]{1,8}([\\.,][0-9]{1,2})?$");

            if (rgx.IsMatch(TxtCliente.Texts))
                return true;

            TxtDevuelto.Texts = string.Empty;
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

        private void ZonaRdbTarjeta_Click(object sender, EventArgs e)
        {
            RdbTarjeta.Checked = true;
        }

        private void ZonaRdbEfectivo_Click(object sender, EventArgs e)
        {
            RdbEfectivo.Checked = true;
        }

        private void ZonaRdbTicket_Click(object sender, EventArgs e)
        {
            RdbTicket.Checked = true;
        }
        #endregion

        #region Mensajes
        // Muestra un mensaje de confirmación
        private bool ConfirmarAccion(string accion)
        {
            string mensaje = "¿Desea " + accion + " pedido actual?";
            if (ShowQuestionDialog(mensaje, "").Equals(DialogResult.Yes)) return true;
            else return false;
        }
        #endregion

        #region Cierre del formulario
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            string mensaje = "¿Desea cancelar la finalización del pedido? Se perderán todos los datos no guardados.";
            if (ShowQuestionDialog(mensaje, "").Equals(DialogResult.Yes))
            {
                Instance.MetodoPagoGetSet = string.Empty;
                this.Close();
            }
        }
        #endregion
    }
}
