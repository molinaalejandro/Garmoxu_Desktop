using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Garmoxu_Desktop
{
    public partial class FrmUsuarios : Form
    {
        private MySqlConnection ConexionBD;
        private FrmMain Instance;
        private DataSet Ds;
        private string UsuarioActual;

        private List<string> DatosIniciales;
        private List<string> IdsTiposUsuario;

        public FrmUsuarios(MySqlConnection conexionBD, FrmMain instance, string usuarioActual)
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            ConexionBD = conexionBD;
            Instance = instance;
            UsuarioActual = usuarioActual;
            CargarDatos();
        }

        #region Apertura del formulario
        #region Cargar datos
        private void CargarDatos()
        {
            string sql = "SELECT u.NombreUsuario, u.NombreEmpleado, tu.Nombre FROM Usuarios u, TiposUsuarios tu " +
                "WHERE u.IdTipoUsuario = tu.IdTipoUsuario ORDER BY u.NombreUsuario";
            MySqlCommand cmd = new MySqlCommand(sql, ConexionBD);

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            Ds = new DataSet();
            adapter.Fill(Ds, "Usuarios");

            DtgUsuarios.DataSource = Ds.Tables["Usuarios"];
            DtgUsuarios.Columns[0].HeaderText = "Nombre de usuario";
            DtgUsuarios.Columns[1].HeaderText = "Nombre y apellidos";
            DtgUsuarios.Columns[2].HeaderText = "Tipo de usuario";
        }
        #endregion
        #endregion

        #region Funciones y diseños de controles
        #region Boton Cerrar
        //private void BtnCerrar_MouseEnter(object sender, EventArgs e)
        //{
        //    BtnCerrar.IconColor = Color.FromArgb(240, 41, 83);
        //    BtnCerrar.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
        //}

        //private void BtnCerrar_MouseLeave(object sender, EventArgs e)
        //{
        //    BtnCerrar.IconColor = Color.DarkGray;
        //    BtnCerrar.IconChar = FontAwesome.Sharp.IconChar.DoorClosed;
        //}
        #endregion

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
            BtnNuevo.IconColor = Color.FromArgb(110, 255, 110);
        }

        private void BtnNuevo_MouseLeave(object sender, EventArgs e)
        {
            BtnNuevo.IconColor = Color.FromArgb(70, 225, 70);
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
        //private void DtgUsuarios_Scroll(object sender, ScrollEventArgs e)
        //{
        //    if ((e.Type == ScrollEventType.SmallIncrement || e.Type == ScrollEventType.LargeIncrement)
        //        && e.NewValue >= DtgUsuarios.Rows.Count - GetDisplayedRowsCount())
        //        RellenarDataGrid();
        //}

        //private int GetDisplayedRowsCount()
        //{
        //    int count = DtgUsuarios.Rows[DtgUsuarios.FirstDisplayedScrollingRowIndex].Height;
        //    count = DtgUsuarios.Height / count;
        //    return count;
        //}

        //private void RellenarDataGrid()
        //{
        //    for (int i = 0; i < CantidadRegistrosCargadosPorIteraccion; i++)
        //    {
        //        if (RegistrosCargados < Ds.Tables["Clientes"].Rows.Count)
        //        {
        //            DtgClientes.Rows.Add(Ds.Tables["Clientes"].Rows[RegistrosCargados].ItemArray[0]);
        //            RegistrosCargados++;
        //        }
        //    }
        //}
        #endregion

        #region Alta de usuarios
        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            FrmUsuariosDetalles f = new FrmUsuariosDetalles(ConexionBD, Instance);
            f.Width = (Instance.Width / 4) + (Instance.Width / 20);
            f.Height = (Instance.Height / 2)+ (Instance.Height / 10);

            Instance.Enabled = false;
            f.Show();
        }
        #endregion

        #region Busqueda de usuarios
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtBuscar.Texts.Trim()) || TxtBuscar.Texts.Trim().Equals("Buscar por nombre de usuario / empleado"))
                CargarDatos();
            else
            {
                string busqueda = TxtBuscar.Texts.Trim();
                Ds.Tables["Usuarios"].DefaultView.RowFilter = "NombreUsuario LIKE '%" + busqueda + "%' OR NombreEmpleado LIKE '%" + busqueda + "%'";
                DtgUsuarios.DataSource = Ds.Tables["Usuarios"];
            }
            DeshabilitarControles();
        }

        private void TxtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals((char)Keys.Enter))
                BtnBuscar_Click(null, null);
        }

        private void TxtBuscar_Enter(object sender, EventArgs e)
        {
            if (TxtBuscar.Texts.Trim().Equals("Buscar por nombre de usuario / empleado"))
            {
                TxtBuscar.Texts = string.Empty;
                TxtBuscar.ForeColor = Color.Gainsboro;
            }
        }

        private void TxtBuscar_Leave(object sender, EventArgs e)
        {
            if (TxtBuscar.Texts.Trim().Equals(string.Empty))
            {
                TxtBuscar.Texts = "Buscar por nombre de usuario / empleado";
                TxtBuscar.ForeColor = Color.Gray;
            }
        }
        #endregion

        #region Eliminación de usuarios
        private void BtnQuitar_Click(object sender, EventArgs e)
        {
            BtnEliminar_Click(null, null);
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            string userName = DtgUsuarios.SelectedRows[0].Cells[0].Value.ToString();

            if (ValidarUsuarioDisponible(userName) && ConfirmarAccion("eliminar permanentemente") &&
                ValidarNoEsUsuarioActual() && ValidarUsuarioSinPedidosEnCursoAsociados(userName))
            {
                string sql = "DELETE FROM Usuarios WHERE NombreUsuario = '" + userName + "'";
                MySqlCommand cmd = new MySqlCommand(sql, ConexionBD);
                cmd.ExecuteNonQuery();

                DeshabilitarControles();
                CargarDatos();

                InformarAccionConExito();
            }
        }

        private bool ValidarUsuarioSinPedidosEnCursoAsociados(string userName)
        {
            string sql = "SELECT NombreUsuario FROM PedidosEnCurso WHERE NombreUsuario = '" + userName + "'";
            MySqlCommand cmd = new MySqlCommand(sql, ConexionBD);
            if (cmd.ExecuteScalar() == null)
                return true;
            else
            {
                string mensaje = "¡No se ha podido eliminar al usuario debido a que tiene pedidos en curso asociados! " +
                    "Primero debe finalizar o cancelar los pedidos para poder continuar";
                MessageBox.Show(mensaje, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        private bool ValidarNoEsUsuarioActual()
        {
            if (!DatosIniciales[0].Equals(UsuarioActual))
                return true;

            string mensaje = "¡No puedes eliminar el usuario con el que has iniciado sesión!";
            MessageBox.Show(mensaje, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        private void DtgUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            if (DtgUsuarios.SelectedRows.Count < 1)
            {
                BtnEliminar.Enabled = false;
                BtnEliminar.BackColor = Color.Gray;
                BtnQuitar.Enabled = false;
                BtnQuitar.IconColor = Color.Gray;
            }
            else
            {
                BtnEliminar.Enabled = true;
                BtnEliminar.BackColor = Color.Crimson;
                BtnQuitar.Enabled = true;
                BtnQuitar.IconColor = Color.Crimson;
            }
        }
        #endregion

        #region Modificación de usuarios
        #region Carga de datos
        private void DtgUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            HabilitarControles();
            CargarTiposDeUsuario();

            string sql = "SELECT NombreUsuario, NombreEmpleado, IdTipoUsuario, RestablecerContraseña, ImagenUsuario " +
                "FROM Usuarios WHERE NombreUsuario = '" + DtgUsuarios.SelectedRows[0].Cells[0].Value + "'";
            MySqlCommand cmd = new MySqlCommand(sql, ConexionBD);

            MySqlDataReader lector = cmd.ExecuteReader();
            if (lector.Read())
            {
                DatosIniciales.Add(lector[0].ToString());
                DatosIniciales.Add(lector[1].ToString());
                DatosIniciales.Add(lector[2].ToString());
                DatosIniciales.Add(lector[3].ToString());

                TxtUsuario.Texts = lector[0].ToString();
                TxtNombre.Texts = lector[1].ToString();
                //GrpUsuario.Text = lector[1].ToString();

                int indexTipoUsuario = IdsTiposUsuario.IndexOf(lector[2].ToString());
                CboTipoUsuario.SelectedIndex = indexTipoUsuario;

                if (lector[3].ToString().Equals("True"))
                    TgbRestablecerContraseña.Checked = true;
                else
                    TgbRestablecerContraseña.Checked = false;

                CargarImagen(lector);
            }
            lector.Close();
        }

        private void CargarTiposDeUsuario()
        {
            CboTipoUsuario.Items.Clear();
            IdsTiposUsuario = new List<string>();

            string sql = "SELECT Nombre, IdTipoUsuario FROM TiposUsuarios ORDER BY Nombre ASC";
            MySqlCommand cmd = new MySqlCommand(sql, ConexionBD);

            MySqlDataReader lector = cmd.ExecuteReader();
            while (lector.Read())
            {
                CboTipoUsuario.Items.Add(lector[0].ToString());
                IdsTiposUsuario.Add(lector[1].ToString());
            }
            lector.Close();
        }

        private void CargarImagen(MySqlDataReader lector)
        {
            if (!string.IsNullOrEmpty(lector[4].ToString()))
            {
                int tamañoMaximoArchivo = 16000000;
                byte[] imagenBytes = new byte[tamañoMaximoArchivo];

                lector.GetBytes(4, 0, imagenBytes, 0, tamañoMaximoArchivo);
                PicUsuario.Image = (Bitmap)((new ImageConverter()).ConvertFrom(imagenBytes));
            }
            else
                PicUsuario.Image = Properties.Resources.User_Default_Icon;
        }
        #endregion

        #region Modificación de datos
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            string valores = string.Empty;
            if (ValidarUsuarioDisponible(DatosIniciales[0]) && ComprobarCamposNoVacios()
                && ValidarFormatoNombreUsuario() && ComprobarDatosModificados(ref valores)
                && ConfirmarAccion("guardar los cambios realizados") && ValidarUsuarioNoExistente())
            {
                string sql = string.Format(
                    "UPDATE Usuarios SET {0} WHERE NombreUsuario = '{1}'",
                    valores, DatosIniciales[0]);
                MySqlCommand cmd = new MySqlCommand(sql, ConexionBD);
                cmd.ExecuteNonQuery();

                InformarCambioContraseña();

                DeshabilitarControles();
                CargarDatos();

                InformarAccionConExito();
            }
        }

        private void InformarCambioContraseña()
        {
            if (!DatosIniciales[3].Equals(TgbRestablecerContraseña.Checked.ToString())
                && TgbRestablecerContraseña.Checked)
            {
                string mensaje = "El cambio de contraseña será llevado a cabo en el próximo inicio de sesión";
                MessageBox.Show(mensaje, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
        #endregion

        #region Modificación de controles
        private void HabilitarControles()
        {
            PnlDetalles.Visible = true;
            GrpUsuario.Visible = true;
            DatosIniciales = new List<string>();
            LimpiarControles();
        }

        private void DeshabilitarControles()
        {
            PnlDetalles.Visible = false;
            GrpUsuario.Visible = false;
            DatosIniciales = null;
            LimpiarControles();
        }

        private void LimpiarControles()
        {
            TxtNombre.Texts = string.Empty;
            TxtUsuario.Texts = string.Empty;
            //TgbRestablecerContraseña.Checked = false;
            //CboTipoUsuario.Items.Clear();
            PicUsuario.Image = Properties.Resources.User_Default_Icon;
        }
        #endregion

        #region Validaciones y comprobaciones
        private bool ValidarUsuarioDisponible(string userName)
        {
            string sql = "SELECT NombreUsuario FROM Usuarios WHERE NombreUsuario = '" + userName + "'";
            MySqlCommand cmd = new MySqlCommand(sql, ConexionBD);
            if (cmd.ExecuteScalar() != null)
                return true;
            else
            {
                CargarDatos();
                string mensaje = "¡El usuario ya no se encuentra disponible! Alguien debe haberlo borrado o modificado.";
                MessageBox.Show(mensaje, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DeshabilitarControles();
                CargarDatos();
                return false;
            }
        }

        private bool ComprobarCamposNoVacios()
        {
            if (!string.IsNullOrEmpty(TxtUsuario.Texts.Trim()) &&
                !string.IsNullOrEmpty(TxtNombre.Texts.Trim()) &&
                CboTipoUsuario.SelectedIndex != -1)
                return true;

            string mensaje = "¡Debes completar todos los campos!";
            MessageBox.Show(mensaje, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        private bool ValidarFormatoNombreUsuario()
        {
            Regex rgx = new Regex("^[a-zA-Z0-9]{1,40}$");
            if (rgx.IsMatch(TxtUsuario.Texts.Trim()))
                return true;

            string mensaje = "¡El nombre de usuario solo puede contener una secuencia de letras sin acentuación y números de 40 caracteres máximo!";
            MessageBox.Show(mensaje, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        private bool ValidarUsuarioNoExistente()
        {
            string sql = "SELECT NombreUsuario FROM Usuarios WHERE NombreUsuario = '" + TxtUsuario.Texts + "'";
            MySqlCommand cmd = new MySqlCommand(sql, ConexionBD);

            if (cmd.ExecuteScalar() == null)
                return true;
            else if(!cmd.ExecuteScalar().ToString().Equals(DatosIniciales[0]))
            {
                string mensaje = "¡El nombre de usuario ya está registrado!";
                MessageBox.Show(mensaje, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        #region Comprobacion de datos modificados
        private bool ComprobarDatosModificados(ref string valores)
        {
            bool modificacionRealizada = false;

            if (DatosIniciales != null && DatosIniciales.Count == 4)
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
            }
            if (!modificacionRealizada) DeshabilitarControles();
            return modificacionRealizada;
        }

        private List<string> RecogerDatosActuales()
        {
            List<string> datosActuales = new List<string>();
            datosActuales.Add(TxtUsuario.Texts.Trim());
            datosActuales.Add(TxtNombre.Texts.Trim());
            datosActuales.Add(IdsTiposUsuario[CboTipoUsuario.SelectedIndex]);
            datosActuales.Add(TgbRestablecerContraseña.Checked.ToString());

            return datosActuales;
        }

        private List<string> InicializarListaColumnasDatos()
        {
            List<string> columnas = new List<string>();
            columnas.Add("NombreUsuario = '");
            columnas.Add("NombreEmpleado = '");
            columnas.Add("IdTipoUsuario = ");
            columnas.Add("RestablecerContraseña = ");
            return columnas;
        }
        #endregion
        #endregion

        #region Mensajes
        // Muestra un mensaje de confirmación
        private bool ConfirmarAccion(string accion)
        {
            DialogResult accionConfirmada =
                MessageBox.Show("¿Desea " + accion + " el usuario actual?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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

        #region Actualización automática de enabled
        private void FrmUsuarios_EnabledChanged(object sender, EventArgs e)
        {
            if (Enabled)
                CargarDatos();
        }
        #endregion

        #region Cierre del formulario
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FrmUsuarios_FormClosing(object sender, FormClosingEventArgs e)
        {
            string v = string.Empty;
            if (PnlDetalles.Visible && ComprobarDatosModificados(ref v))
            {
                string mensaje = "Se perderán todos los cambios no guardados. ¿Deseas continuar?";
                DialogResult cerrarVentana = MessageBox.Show(mensaje, "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (!cerrarVentana.Equals(DialogResult.Yes))
                    e.Cancel = true;
            }
        }
        #endregion
    }
}