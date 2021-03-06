using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Garmoxu_Desktop.MessageBoxPersonalizado;
using static Garmoxu_Desktop.ConexionMySql;

namespace Garmoxu_Desktop
{
    public partial class FrmAjustes : Form
    {
        private FrmMain Instance;
        private FrmInicioSesion InstanceInicioSesion;

        private int NivelPermisos;

        private Image ImagenInicial;
        private string UsuarioInicial;
        private bool RestablecerContraseña;
        private string NombreRestaurante;
        private decimal NumeroMesasIniciales;
        private string HoraApertura;
        private string HoraCierre;
        private int Iva;
        private bool VentanaCompleta;
        private bool ModoDiurno;

        private Panel PnlFormularios;

        private List<string> DatosIniciales;

        public FrmAjustes(FrmMain instance, FrmInicioSesion instanceInicioSesion, Panel pnlFormularios,
            string usuarioActual, Image imagenUsuario, int nivelPermisos, string nombreRestaurante, string horaApertura, string horaCierre,
            int iva, bool ventanaCompleta, bool modoDiurno)
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            tableLayoutPanel16.Height = 41;
            CboVentana.SelectedIndex = 0;
            LblVersion.Text = Assembly.GetExecutingAssembly().GetName().Version.ToString();

            Instance = instance;
            InstanceInicioSesion = instanceInicioSesion;
            PnlFormularios = pnlFormularios;
            UsuarioInicial = usuarioActual;
            ImagenInicial = imagenUsuario;
            NivelPermisos = nivelPermisos;
            NombreRestaurante = nombreRestaurante;
            HoraApertura = horaApertura;
            HoraCierre = horaCierre;
            Iva = iva;
            VentanaCompleta = ventanaCompleta;
            ModoDiurno = modoDiurno;

            LimitarPermisos();
            CargarDatos();
        }

        #region Apertura del formulario
        private void FrmAjustes_Shown(object sender, EventArgs e)
        {
            RadClaro.TabStop = false;
            RadOscuro.TabStop = false;
            TxtNombreRestaurante.Height = 52;
            TxtNombreUsuario.Height = 52;
        }

        #region Limitación de permisos
        private void LimitarPermisos()
        {
            if (NivelPermisos == 0)
            {
                TxtNombreRestaurante.Enabled = false;
                NucNumeroMesas.Enabled = false;
                DtpApertura.Enabled = false;
                DtpApertura.TextColor = Color.DimGray;
                DtpCierre.Enabled = false;
                DtpCierre.TextColor = Color.DimGray;
                NucIva.Enabled = false;
            }

            if (NivelPermisos != 2) TxtNombreUsuario.Enabled = false;
        }
        #endregion

        private void CargarDatos()
        {
            DatosIniciales = new List<string>();

            PicPerfil.Image = ImagenInicial;
            TxtNombreUsuario.Texts = UsuarioInicial;

            CargarDatoRestablecerContraseña();
            RestablecerContraseña = BtnRestablecer.Checked;

            TxtNombreRestaurante.Texts = NombreRestaurante;
            DatosIniciales.Add(NombreRestaurante);

            CargarDatoNumeroMesas();
            NumeroMesasIniciales = NucNumeroMesas.Value;

            DtpApertura.Value = DateTime.Parse(HoraApertura);
            DatosIniciales.Add(HoraApertura);

            DtpCierre.Value = DateTime.Parse(HoraCierre);
            DatosIniciales.Add(HoraCierre);

            NucIva.Value = Iva;
            DatosIniciales.Add(Iva.ToString());

            if (VentanaCompleta)
            {
                CboVentana.SelectedIndex = 0;
                DatosIniciales.Add("True");
            }
            else
            {
                CboVentana.SelectedIndex = 1;
                DatosIniciales.Add("False");
            }

            if (ModoDiurno)
            {
                RadClaro.Checked = true;
                DatosIniciales.Add("True");
            }
            else
            {
                RadOscuro.Checked = true;
                DatosIniciales.Add("False");
            }
        }

        private void CargarDatoRestablecerContraseña()
        {
            string sql = "SELECT RestablecerContraseña FROM Usuarios WHERE NombreUsuario = '" + UsuarioInicial + "'";
            if (EjecutarScalar(sql).Equals("False")) BtnRestablecer.Checked = false;
            else BtnRestablecer.Checked = true;
        }

        private int CargarDatoNumeroMesas()
        {
            string sql = "SELECT COUNT(*) FROM Mesas";
            string scalar = EjecutarScalar(sql);
            if (!string.IsNullOrEmpty(scalar))
            {
                NucNumeroMesas.Value = decimal.Parse(scalar);
                return int.Parse(scalar);
            }

            return 0;
        }
        #endregion

        #region Funcionalidades y diseños de controles
        private void BtnAtras_MouseEnter(object sender, EventArgs e)
        {
            BtnAtras.IconColor = Color.White;
            BtnAtras.ForeColor = Color.White;
            BtnAtras.IconChar = FontAwesome.Sharp.IconChar.AngleDoubleLeft;
        }

        private void BtnAtras_MouseLeave(object sender, EventArgs e)
        {
            BtnAtras.IconColor = Color.Silver;
            BtnAtras.ForeColor = Color.Silver;
            BtnAtras.IconChar = FontAwesome.Sharp.IconChar.AngleLeft;
        }
        #endregion

        #region Cambiar foto de perfil
        private void PicPerfil_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Selecciona una imagen para tu usuario";
            //ofd.Filter = "Archivo de imagen |*.jpg| Archivo PNG|*.png|Todos los archivos|*.*";
            ofd.Filter = "Archivo de imagen |*.jpg| Archivo PNG|*.png";

            if (ofd.ShowDialog().Equals(DialogResult.OK))
            {
                string ruta = ofd.FileName;

                if (new FileInfo(ruta).Length <= 15000000)
                    PicPerfil.Image = Image.FromFile(ruta);
                else
                    ShowWarningMessage("¡La imagen no puede ser mayor de 15MB!", "");

            }
        }

        private void PicPerfil_MouseEnter(object sender, EventArgs e)
        {
            PicPerfil.BorderSize += 2;
            PicPerfil.BorderColor = Color.White;
            PicPerfil.BorderColor2 = Color.White;
            //PicPerfil.BackColor = Color.White;
        }

        private void PicPerfil_MouseLeave(object sender, EventArgs e)
        {
            PicPerfil.BorderSize -= 2;
            PicPerfil.BorderColor = Color.Silver;
            PicPerfil.BorderColor2 = Color.Silver;
            //PicPerfil.BackColor = Color.Silver;
        }
        #endregion

        #region Guardar cambios
        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals((char)Keys.Enter))
            {
                e.Handled = true;
                BtnGuardar_Click(null, null);
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            string datosActuales = string.Empty;
            if (ComprobarCamposNoVacios() && ValidarFormatoNombreUsuario() && ValidarFormatoNombreRestaurante() && ValidarNumeroMesas()
                && ComprobarDatosModificados(ref datosActuales) && ConfirmarAccion("guardar los cambios realizados")
                && ValidarUsuarioNoExistente())
            {
                GuardarDatos(datosActuales);
                InformarReinicio();
            }
        }

        private void GuardarDatos(string datosActuales)
        {
            if (!ImagenInicial.Equals(PicPerfil.Image))
                ActualizarImagen();

            if (!RestablecerContraseña.Equals(BtnRestablecer.Checked))
                ActualizarRestablecerContraseña();

            if (!UsuarioInicial.Equals(TxtNombreUsuario.Texts.Trim()))
                ActualizarNombreUsuario();

            if (NumeroMesasIniciales != NucNumeroMesas.Value)
                ModificarMesas();

            if (!Directory.Exists("Ajustes")) Directory.CreateDirectory("Ajustes");
            File.WriteAllText(@"Ajustes\ajustes.csv", datosActuales);
        }

        private void ActualizarImagen()
        {
            string sql = "UPDATE Usuarios SET ImagenUsuario = @imagen WHERE NombreUsuario = '" + UsuarioInicial + "'";
            byte[] imagenBytes = (byte[])new ImageConverter().ConvertTo(PicPerfil.Image, typeof(byte[]));
            EjecutarSentencia(sql, imagenBytes);
        }

        private void ActualizarNombreUsuario()
        {
            string sql = "UPDATE Usuarios SET NombreUsuario = '" + TxtNombreUsuario.Texts.Trim() + "' " +
                "WHERE NombreUsuario = '" + UsuarioInicial + "'";
            EjecutarSentencia(sql);
        }

        private void ActualizarRestablecerContraseña()
        {
            int restablecer = 0;
            if (BtnRestablecer.Checked) restablecer = 1;
            string sql = "UPDATE Usuarios SET RestablecerContraseña = '" + restablecer + "' " +
                "WHERE NombreUsuario = '" + UsuarioInicial + "'";
            EjecutarSentencia(sql);
        }

        private void ModificarMesas()
        {
            int numeroMesasBase = 0;

            string sql = "SELECT COUNT(*) FROM Mesas";
            string scalar = EjecutarScalar(sql);
            if (!string.IsNullOrEmpty(scalar)) numeroMesasBase = int.Parse(scalar);

            decimal numeroMesasActuales = NucNumeroMesas.Value;
            decimal diferenciaNumeroMesas = 0;
            sql = string.Empty;
            string sql2 = string.Empty;
            if (numeroMesasBase < NucNumeroMesas.Value)
            {
                diferenciaNumeroMesas = numeroMesasActuales - numeroMesasBase;
                sql = "INSERT INTO Mesas (Estado, NumeroComensales) VALUES ('Libre', 1)";
                sql2 = "";
            }
            else if (numeroMesasBase > NucNumeroMesas.Value)
            {
                diferenciaNumeroMesas = numeroMesasBase - numeroMesasActuales;
                sql = "DELETE FROM Mesas ORDER BY IdMesa DESC LIMIT 1";
                sql2 = "SELECT IdMesa FROM Mesas ORDER BY IdMesa DESC LIMIT 1";
            }

            string scalar2 = string.Empty;
            for (int i = 0; i < diferenciaNumeroMesas; i++)
            {
                if(!string.IsNullOrEmpty(sql2)) scalar2 = EjecutarScalar(sql2);
                if (string.IsNullOrEmpty(sql2) || (!ComprobarPedidosEnCurso(scalar2) && ConfirmarEliminacionConReservas(scalar2)))
                    EjecutarSentencia(sql);
                else break;
            }

            sql = "SELECT COUNT(*) FROM Mesas";
            string numeroMesasTotales = EjecutarScalar(sql);

            sql = "ALTER TABLE Mesas AUTO_INCREMENT = " + numeroMesasTotales;
            EjecutarSentencia(sql);
        }

        #region Comprobacion de datos modificados
        private bool ComprobarDatosModificados(ref string datosActuales)
        {
            bool modificacionRealizada = false;

            List<string> datosActualesLista = RecogerDatosActuales();

            for (int i = 0; i < datosActualesLista.Count; i++)
            {
                datosActuales += datosActualesLista[i];
                if (i != datosActualesLista.Count - 1) datosActuales += ";";

                if (!DatosIniciales[i].Equals(datosActualesLista[i])) modificacionRealizada = true;
            }

            if (!ImagenInicial.Equals(PicPerfil.Image)) modificacionRealizada = true;
            if (!UsuarioInicial.Equals(TxtNombreUsuario.Texts.Trim())) modificacionRealizada = true;
            if (!RestablecerContraseña.Equals(BtnRestablecer.Checked)) modificacionRealizada = true;
            if (NumeroMesasIniciales != NucNumeroMesas.Value) modificacionRealizada = true;

            if (!modificacionRealizada) this.Close();
            return modificacionRealizada;
        }

        private List<string> RecogerDatosActuales()
        {
            List<string> datosActuales = new List<string>();
            datosActuales.Add(TxtNombreRestaurante.Texts.Trim());
            datosActuales.Add(DtpApertura.Value.ToString("HH:mm"));
            datosActuales.Add(DtpCierre.Value.ToString("HH:mm"));
            datosActuales.Add(NucIva.Value.ToString());
            if (CboVentana.SelectedIndex == 1) datosActuales.Add("False");
            else datosActuales.Add("True");
            if (RadOscuro.Checked) datosActuales.Add("False");
            else datosActuales.Add("True");

            return datosActuales;
        }
        #endregion
        #endregion

        #region Validaciones y comprobaciones
        private bool ComprobarCamposNoVacios()
        {
            if (!string.IsNullOrEmpty(TxtNombreUsuario.Texts.Trim()) &&
                !string.IsNullOrEmpty(TxtNombreRestaurante.Texts.Trim()) &&
                CboVentana.SelectedIndex != -1)
                return true;

            string mensaje = "¡Debes completar todos los campos!";
            ShowWarningMessage(mensaje, "");
            return false;
        }

        private bool ValidarFormatoNombreUsuario()
        {
            Regex rgx = new Regex("^[a-zA-Z0-9]{1,40}$");
            if (rgx.IsMatch(TxtNombreUsuario.Texts.Trim()))
                return true;

            string mensaje = "¡El nombre de usuario solo puede contener una secuencia de letras sin acentuación y números de 40 caracteres máximo!";
            ShowWarningMessage(mensaje, "");
            return false;
        }

        private bool ValidarFormatoNombreRestaurante()
        {
            if (TxtNombreRestaurante.Texts.Trim().Contains(";"))
            {
                string mensaje = "¡El nombre del restaurante no puede contener punto y coma!";
                ShowWarningMessage(mensaje, "");
                return false;
            }
            return true;
        }

        private bool ValidarNumeroMesas()
        {
            if (NucNumeroMesas.Value == 0)
            {
                string mensaje = "¡No puedes eliminar todas las mesas!";
                ShowWarningMessage(mensaje, "");
                return false;
            }
            else return true;

        }

        private bool ValidarUsuarioNoExistente()
        {
            string sql = "SELECT NombreUsuario FROM Usuarios WHERE NombreUsuario = '" + TxtNombreUsuario.Texts + "'";
            string scalar = EjecutarScalar(sql);

            if (!string.IsNullOrEmpty(scalar)) return true;
            else if (!scalar.Equals(UsuarioInicial))
            {
                string mensaje = "¡El nombre de usuario ya está registrado!";
                ShowWarningMessage(mensaje, "");
                return false;
            }
            return true;
        }

        private bool ComprobarPedidosEnCurso(string idMesa)
        {
            string sql = string.Format("SELECT IdMesa FROM PedidosEnCurso WHERE IdMesa = '{0}'", idMesa);
            if (string.IsNullOrEmpty(EjecutarScalar(sql))) return false;

            string mensaje = "¡No se puede eliminar la mesa " + idMesa + " debido a que tiene pedidos en curso asociados! " +
                "Finalice o cancele todos los pedidos en curso antes de continuar.";
            ShowWarningMessage(mensaje, "");

            return true;
        }

        private bool ConfirmarEliminacionConReservas(string idMesa)
        {
            string sql = string.Format("SELECT IdMesa FROM Reservas WHERE IdMesa = '{0}'", idMesa);
            if (string.IsNullOrEmpty(EjecutarScalar(sql))) return true;

            string mensaje = "La mesa " + idMesa + " tiene asociadas algunas reservas, tenga en cuenta que todas ellas serán eliminadas. " +
                "¿Desea continuar?";
            if (ShowQuestionDialog(mensaje, "").Equals(DialogResult.Yes)) return true;
            else return false;
        }
        #endregion

        #region Mensajes
        // Muestra un mensaje de confirmación
        private bool ConfirmarAccion(string accion)
        {
            string mensaje = "¿Desea " + accion + "?";
            if (ShowQuestionDialog(mensaje, "").Equals(DialogResult.Yes)) return true;
            else return false;
        }

        // Muestra un mensaje de éxito
        private void InformarReinicio()
        {
            string mensaje = "La aplicación se reiniciará para aplicar los cambios.";
            ShowInfoMessage(mensaje, "");
            PnlFormularios.Visible = false;
            Instance.Close();
        }
        #endregion

        #region Cierre de sesion
        private void BtnCerrarSesion_Click(object sender, EventArgs e)
        {
            string mensaje = "¿Desea cerrar la sesión actual?";
            if (ShowQuestionDialog(mensaje, "").Equals(DialogResult.Yes))
            {
                try
                {
                    string ruta = "Accesos_Usuarios.csv";
                    if (File.Exists(ruta)) File.AppendAllText(ruta, ";" + DateTime.Now.ToString() + ";\n");
                }
                catch (Exception ex) { ShowErrorMessage(ex.Message, ""); }

                InstanceInicioSesion.Show();
                Instance.Close();
            }
        }
        #endregion

        #region Cierre del formulario
        private void BtnClose_Click(object sender, EventArgs e)
        {
            string v = string.Empty;
            if (ComprobarDatosModificados(ref v))
            {
                string mensaje = "¿Desea salir sin guardar? Se perderán todos los cambios realizados.";
                if (ShowQuestionDialog(mensaje, "").Equals(DialogResult.Yes)) this.Close();
            }
            else this.Close();
        }

        private void FrmAjustes_FormClosing(object sender, FormClosingEventArgs e)
        {
            Instance.Visible = true;
        }
        #endregion
    }
}
