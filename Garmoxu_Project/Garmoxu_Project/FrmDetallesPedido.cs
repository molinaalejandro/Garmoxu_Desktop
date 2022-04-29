using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Garmoxu_Project
{
    public partial class FrmDetallesPedido : Form
    {
        // Clave primaria del pedido que se está detallando. Estará vacía si es una pestaña de nuevo pedido.
        private string ClavePrimariaPedidoEnCurso;

        public FrmDetallesPedido(String clavePrimariaPedidoEnCurso)
        {
            InitializeComponent();
            FrmMain.instance.Enabled = false;
            ClavePrimariaPedidoEnCurso = clavePrimariaPedidoEnCurso;
            CargarDatosPedido();
        }

        #region Cargar datos pedido
        // Si la clave primaria recibida está vacía, el formulario servirá para dar de alta un nuevo pedido en curso.
        // En caso contrario, el formulario servirá para consultar y modificar los datos del pedido asociado a la clave.
        private void CargarDatosPedido()
        {
            if (!String.IsNullOrEmpty(ClavePrimariaPedidoEnCurso.Trim()))
            {
                TabControl.SelectedIndex = 1;
                BtnConfirmar.Text = "Guardar cambios";
            }
        }
        #endregion

        #region Botones sin acabar
        private void BtnLocal_Click(object sender, EventArgs e)
        {
            TabTipo.SelectedIndex = 0;
        }

        private void BtnDomicilio_Click(object sender, EventArgs e)
        {
            TabTipo.SelectedIndex = 1;
        }

        private void BtnRecoger_Click(object sender, EventArgs e)
        {
            TabTipo.SelectedIndex = 2;
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            TabControl.SelectedIndex = 1;
        }

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            //Debe guardar la informacion al confirmar
            this.Close();
        }

        private void FrmDetallesPedido_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmMain.instance.Enabled = true;
        }
        #endregion

        #region Getter y setters
        public string ClavePrimariaPedidoEnCursoGet { get => ClavePrimariaPedidoEnCurso; }
        #endregion
    }
}

