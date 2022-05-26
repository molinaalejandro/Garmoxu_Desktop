using iText.IO.Image;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Draw;
using iText.Layout;
using iText.Layout.Borders;
using iText.Layout.Element;
using iText.Layout.Properties;
using MaterialSkin.Controls;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Garmoxu_Desktop.MessageBoxPersonalizado;
using static Garmoxu_Desktop.ConexionMySql;

namespace Garmoxu_Desktop
{
    public partial class FrmHistorialPedidosDetalles : Form
    {
        private string ClavePrimaria;
        private int IVA;
        private int NivelPermisos;

        public FrmHistorialPedidosDetalles(string clavePrimaria, ref Form frmShadow, int nivelPermisos, int iva)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            ClavePrimaria = clavePrimaria;
            NivelPermisos = nivelPermisos;
            IVA = iva;
            SombrearPantalla(ref frmShadow);
            CargarDatosPedido();
            LimitarPermisos();
        }

        #region Apertura del formulario
        private void FrmHistorialPedidosDetalles_Shown(object sender, EventArgs e)
        {
            DtgPlatosPedidos.ClearSelection();
        }

        #region Cargar datos del pedido
        public void CargarDatosPedido()
        {
            string sql = "SELECT * FROM HistorialPedidos WHERE IdPedido = " + ClavePrimaria;
            MySqlDataReader lector = EjecutarConsulta(sql);

            if (lector.Read())
            {
                LblTitulo.Text += ClavePrimaria;
                LblFecha.Text = DateTime.Parse(lector["Fecha"].ToString()).ToString("dd/MM/yyyy");
                LblHora.Text = lector["Hora"].ToString();
                LblTipo.Text = lector["Tipo"].ToString();
                LblTlf.Text = lector["TelefonoCliente"].ToString();
                LblPrecioConIVA.Text = lector["PrecioConIva"].ToString() + "€";
                LblPrecioSinIVA.Text = lector["PrecioSinIva"].ToString() + "€";
                LblMetodoPago.Text = lector["TipoPago"].ToString();

                if (string.IsNullOrEmpty(LblTlf.Text.Trim()))
                {
                    label7.ForeColor = this.BackColor;
                    LblTlf.ForeColor = this.BackColor;
                }
            }
            CerrarConexion();
            lector.Close();

            CargarPlatosPedido();
        }

        public void CargarPlatosPedido()
        {
            string sql = "SELECT * FROM HistorialPedidosPlatos WHERE IdPedido = " + ClavePrimaria;
            MySqlDataReader lector = EjecutarConsulta(sql);

            for (int i = 0; lector.Read(); i++)
            {
                DtgPlatosPedidos.Rows.Add();
                DtgPlatosPedidos.Rows[i].Cells[0].Value = lector[1];
                DtgPlatosPedidos.Rows[i].Cells[1].Value = lector[2];
                DtgPlatosPedidos.Rows[i].Cells[2].Value = lector[4];
                DtgPlatosPedidos.Rows[i].Cells[3].Value = lector[3];
                DtgPlatosPedidos.Rows[i].Cells[4].Value = lector[5];

                decimal cantidad = decimal.Parse(DtgPlatosPedidos.Rows[i].Cells[4].Value.ToString());
                decimal unitarioSinIVA = decimal.Parse(DtgPlatosPedidos.Rows[i].Cells[2].Value.ToString());
                decimal unitarioConIVA = decimal.Parse(DtgPlatosPedidos.Rows[i].Cells[3].Value.ToString());

                DtgPlatosPedidos.Rows[i].Cells[5].Value = unitarioSinIVA * cantidad;
                DtgPlatosPedidos.Rows[i].Cells[6].Value = unitarioConIVA * cantidad;

            }
            CerrarConexion();
            lector.Close();
        }
        #endregion

        #region Limitación de permisos
        private void LimitarPermisos()
        {
            if (NivelPermisos == 0) BtnBorrar.Visible = false;
        }
        #endregion
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
        private void BtnPdf_MouseEnter(object sender, EventArgs e)
        {
            BtnPdf.IconColor = Color.Cornsilk;
        }

        private void BtnPdf_MouseLeave(object sender, EventArgs e)
        {
            BtnPdf.IconColor = Color.White;
        }
        #endregion

        #region Exportación a PDF
        private void BtnPdf_Click(object sender, EventArgs e)
        {
            if (ConfirmarAccion("exportar a formato PDF")) ExportarFacturaPdf(ClavePrimaria);
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
                    InformarAccionConExito();
                }
            }
            catch (IOException ex)
            {
                string mensaje = "¡No se ha podido generar la factura en PDF debido a que existe un archivo con el mismo nombre que ya está en uso!";
                ShowErrorMessage(mensaje, "");
            }
        }

        private string RecogerRuta()
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Seleccione un directorio para exportar en formato PDF los datos del pedido.";
            if (fbd.ShowDialog().Equals(DialogResult.OK)) return fbd.SelectedPath;
            else return string.Empty;
        }

        #region Cabecera
        private void AñadirCabeceraPdf(ref Document documentoPdf)
        {
            string rutaImagenPdf = @"..\..\Resources\Garmoxu_Logo_Circle_Red_New.png";
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

                string fechaActual = DateTime.Parse(LblFecha.Text + " " + LblHora.Text)
                    .ToString("dddd dd/MM/yyyy HH:mm");
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
            if (!LblTipo.Text.Equals("Local"))
            {
                tipoPedido = "Teléfono cliente:";
                datoPedido = LblTlf.Text;
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
                CrearCelda(40, TextAlignment.RIGHT, 15, tablaPdf, row.Cells[4].Value.ToString());
                CrearCelda(80, TextAlignment.RIGHT, 15, tablaPdf, row.Cells[6].Value.ToString());
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

        //private string BuscarNombreUsuario()
        //{
        //    string sql = "SELECT NombreEmpleado FROM Usuarios WHERE NombreUsuario = '" + UsuarioActual + "'";
        //    MySqlCommand cmd = new MySqlCommand(sql, ConexionBD);
        //    return cmd.ExecuteScalar().ToString();
        //}
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

        #region Borrar pedido en historial
        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ConfirmarAccion("eliminar permanentemente"))
                {
                    string sql = "DELETE FROM HistorialPedidos WHERE IdPedido = " + ClavePrimaria;
                    EjecutarSentencia(sql);
                    InformarAccionConExito();
                    this.Close();
                }
            }
            catch (MySqlException ex)
            {
                string mensaje = "No se ha podido completar la eliminación debido al siguiente error: \n" + ex.Message;
                ShowErrorMessage(mensaje, "");
            }
        }
        #endregion

        #region Mensajes
        // Muestra un mensaje de confirmación
        private bool ConfirmarAccion(string accion)
        {
            string mensaje = "¿Desea " + accion + " el historial del pedido actual?";
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
        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
