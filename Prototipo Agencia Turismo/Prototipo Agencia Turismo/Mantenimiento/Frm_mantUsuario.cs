/* 
 -----------------------------------------------------
            AUTOR: Edson Juarez
  -----------------------------------------------------
*/


using Prototipo_Agencia_Turismo.Consulta;
using Prototipo_Agencia_Turismo.Seguridad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototipo_Agencia_Turismo.Mantenimiento
{
    public partial class Frm_mantUsuario : Form
    {
        IPHostEntry host;
        string localIP = "?";
        bool presionado = false;
        string nombreUsuario = " ";
        DateTime fecha = DateTime.Now;

        string idUsuario = " ";
        string nickUsuario = " ";
        string contrasenaUsuario = " ";
        string confirmarContraUsuario = " ";
        string idPerfil = " ";

        public Frm_mantUsuario(string usuario)
        {
            InitializeComponent();
            nombreUsuario = usuario;
        }

        private void ObtenerIp()
        {
            host = Dns.GetHostEntry(Dns.GetHostName());

            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily.ToString() == "InterNetwork")
                {
                    localIP = ip.ToString();
                }
            }
        }

        private void HabilitarCampos()
        {
            Txt_nombre.Enabled = true;
            Txt_contrasena.Enabled = true;
            Txt_confirmarContrasena.Enabled = true;
            Btn_consultaPerfil.Enabled = true;
        }

        private void DeshabilitarCampos()
        {
            Txt_nombre.Enabled = false;
            Txt_contrasena.Enabled = false;
            Txt_confirmarContrasena.Enabled = false;
            Btn_consultaPerfil.Enabled = false;
        }

        private void DeshabilitarBotones()
        {
            Btn_ingresar.Enabled = false;
            Btn_editar.Enabled = false;
            Btn_guardar.Enabled = false;
            Btn_borrar.Enabled = false;
            Btn_consultar.Enabled = false;
        }

        private void HabilitarBotones()
        {
            Btn_ingresar.Enabled = true;
            Btn_editar.Enabled = true;
            Btn_guardar.Enabled = true;
            Btn_cancelar.Enabled = true;
            Btn_borrar.Enabled = true;
            Btn_consultar.Enabled = true;
        }

        private void LimpiarCampos()
        {
            Txt_idUsuario.Text = " ";
            Txt_nombre.Text = " ";
            Txt_contrasena.Text = " ";
            Txt_confirmarContrasena.Text = " ";
            Txt_idPerfil.Text = " ";
            Txt_estado.Text = " ";
        }

        private void ActualizarEstado()
        {
            try
            {
                string consultaUsuario = "UPDATE tbl_usuario SET estado = 0 WHERE Pk_idUsuario = " + Txt_idUsuario.Text;
                OdbcCommand comm = new OdbcCommand(consultaUsuario, Conexion.nuevaConexion());
                comm.ExecuteNonQuery();
                MessageBox.Show("Registro eliminado correctamente");
                comm.Connection.Close();

                OdbcCommand comm1 = new OdbcCommand("{call SP_InsertarBitacora(?,?,?,?,?)}", Conexion.nuevaConexion());
                comm1.CommandType = CommandType.StoredProcedure;
                comm1.Parameters.Add("ope", OdbcType.Text).Value = "ELIMINACIÓN DE REGISTRO";
                comm1.Parameters.Add("usr", OdbcType.Text).Value = nombreUsuario;
                comm1.Parameters.Add("fecha", OdbcType.Text).Value = fecha.ToString("yyyy/MM/dd HH:mm:ss");
                comm1.Parameters.Add("proc", OdbcType.Text).Value = "MANTEMIMIENTO USUARIO";
                comm1.Parameters.Add("dirIp", OdbcType.Text).Value = localIP;
                comm1.ExecuteNonQuery();
                comm1.Connection.Close();
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }

        private void ActualizarRegistro()
        {
            string contrasenaEncriptada = " ";

            idUsuario = Txt_idUsuario.Text;
            nickUsuario = Txt_nombre.Text;
            contrasenaUsuario = Txt_contrasena.Text;
            idPerfil = Txt_idPerfil.Text;

            contrasenaEncriptada = Seguridad_Login.Encriptar(Txt_contrasena.Text);

            try
            {
                string actualizarRegistro = "UPDATE `tbl_usuario` SET `Pk_idUsuario` = '" + idUsuario + "' ," +
                    "`nombreUsuario` = '" + nickUsuario + "', `contrasenaUsuario` = '" + contrasenaEncriptada + "', " +
                    "`Fk_idPerfil` = '" + idPerfil + "', `estado` = '1' WHERE Pk_idUsuario = " + idUsuario;

                OdbcCommand comm = new OdbcCommand(actualizarRegistro, Conexion.nuevaConexion());
                comm.ExecuteNonQuery();
                MessageBox.Show("Registro actualizado correctamente");
                comm.Connection.Close();

                OdbcCommand comm1 = new OdbcCommand("{call SP_InsertarBitacora(?,?,?,?,?)}", Conexion.nuevaConexion());
                comm1.CommandType = CommandType.StoredProcedure;
                comm1.Parameters.Add("ope", OdbcType.Text).Value = "ACTUALIZACIÓN DE REGISTRO";
                comm1.Parameters.Add("usr", OdbcType.Text).Value = nombreUsuario;
                comm1.Parameters.Add("fecha", OdbcType.Text).Value = fecha.ToString("yyyy/MM/dd HH:mm:ss");
                comm1.Parameters.Add("proc", OdbcType.Text).Value = "MANTENIMIENTO USUARIO";
                comm1.Parameters.Add("dirIp", OdbcType.Text).Value = localIP;
                comm1.ExecuteNonQuery();
                comm1.Connection.Close();
            }
            catch(Exception err)
            {
                Console.WriteLine(err.Message);
                MessageBox.Show("No se han llenado todos los campos para actualizar el registro...");
            }
        }

        private void GuardarRegistro()
        {
            string contrasenaEncriptada = " ";

            nickUsuario = Txt_nombre.Text;
            contrasenaUsuario = Txt_contrasena.Text;
            confirmarContraUsuario = Txt_confirmarContrasena.Text;
            idPerfil = Txt_idPerfil.Text;

            contrasenaEncriptada = Seguridad_Login.Encriptar(Txt_contrasena.Text);

            if(contrasenaUsuario == confirmarContraUsuario)
            {
                try
                {
                    string insertarUsuario = "INSERT INTO tbl_usuario (nombreUsuario,contrasenaUsuario,Fk_idPerfil,estado,logeado) VALUES('" + nickUsuario + "', '" + contrasenaEncriptada + "', '" + idPerfil + "', '1', '0')";

                    OdbcCommand comm = new OdbcCommand(insertarUsuario, Conexion.nuevaConexion());
                    comm.ExecuteNonQuery();
                    MessageBox.Show("Registro guardado correctamente");
                    comm.Connection.Close();

                    OdbcCommand comm1 = new OdbcCommand("{call SP_InsertarBitacora(?,?,?,?,?)}", Conexion.nuevaConexion());
                    comm1.CommandType = CommandType.StoredProcedure;
                    comm1.Parameters.Add("ope", OdbcType.Text).Value = "INSERCIÓN DE REGISTRO";
                    comm1.Parameters.Add("usr", OdbcType.Text).Value = nombreUsuario;
                    comm1.Parameters.Add("fecha", OdbcType.Text).Value = fecha.ToString("yyyy/MM/dd HH:mm:ss");
                    comm1.Parameters.Add("proc", OdbcType.Text).Value = "MANTENIMIENTO USUARIO";
                    comm1.Parameters.Add("dirIp", OdbcType.Text).Value = localIP;
                    comm1.ExecuteNonQuery();
                    comm1.Connection.Close();
                }
                catch(Exception err)
                {
                    Console.WriteLine(err.Message);
                    MessageBox.Show("No se han llenado todos los campos para guardar el registro...");
                }
            }
            else
            {
                MessageBox.Show("Las contraseñas ingresadas no son idénticas");
            }
        }

        private void Btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_mantUsuario_Load(object sender, EventArgs e)
        {
            ObtenerIp();
        }

        private void Btn_ingresar_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
        }

        private void Btn_consultar_Click(object sender, EventArgs e)
        {
            if(presionado == false)
            {
                DeshabilitarBotones();
                Btn_consultar.Enabled = true;
                presionado = true;
            }
            else
            {
                Frm_consultaUsuario consultaUsuario = new Frm_consultaUsuario();
                consultaUsuario.ShowDialog();

                if(consultaUsuario.DialogResult == DialogResult.OK)
                {
                    Txt_idUsuario.Text =
                        consultaUsuario.Dgv_consultaUsuario.Rows[consultaUsuario.Dgv_consultaUsuario.CurrentRow.Index].
                        Cells[0].Value.ToString();

                    Txt_nombre.Text =
                        consultaUsuario.Dgv_consultaUsuario.Rows[consultaUsuario.Dgv_consultaUsuario.CurrentRow.Index].
                        Cells[1].Value.ToString();

                    Txt_contrasena.Text =
                        consultaUsuario.Dgv_consultaUsuario.Rows[consultaUsuario.Dgv_consultaUsuario.CurrentRow.Index].
                        Cells[2].Value.ToString();

                    Txt_idPerfil.Text =
                        consultaUsuario.Dgv_consultaUsuario.Rows[consultaUsuario.Dgv_consultaUsuario.CurrentRow.Index].
                        Cells[3].Value.ToString();

                    Txt_estado.Text =
                        consultaUsuario.Dgv_consultaUsuario.Rows[consultaUsuario.Dgv_consultaUsuario.CurrentRow.Index].
                        Cells[4].Value.ToString();

                    Txt_idUsuario.Focus();
                    presionado = false;
                    HabilitarBotones();
                }
            }
        }

        private void Btn_borrar_Click(object sender, EventArgs e)
        {
            if(presionado == false)
            {
                DeshabilitarBotones();
                Btn_borrar.Enabled = true;
                presionado = true;
            }
            else
            {
                ActualizarEstado();
                Txt_idUsuario.Focus();
                presionado = false;
                DeshabilitarCampos();
                HabilitarBotones();
                LimpiarCampos();
            }
        }

        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            presionado = false;
            HabilitarBotones();
            DeshabilitarCampos();
        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            if(presionado == false)
            {
                DeshabilitarBotones();
                Btn_guardar.Enabled = true;
                presionado = true;
            }
            else
            {
                GuardarRegistro();
                Txt_idUsuario.Focus();
                presionado = false;
                DeshabilitarCampos();
                HabilitarBotones();
                LimpiarCampos();
            }
        }

        private void Btn_consultaPerfil_Click(object sender, EventArgs e)
        {
            Frm_consultaPerfil consultaPerfil = new Frm_consultaPerfil();
            consultaPerfil.ShowDialog();

            if(consultaPerfil.DialogResult == DialogResult.OK)
            {
                Txt_idPerfil.Text = consultaPerfil.Dgv_consultaPerfil.Rows[consultaPerfil.Dgv_consultaPerfil.CurrentRow.Index].
                    Cells[0].Value.ToString();
            }
        }

        private void Btn_editar_Click(object sender, EventArgs e)
        {
            if(presionado == false)
            {
                DeshabilitarBotones();
                Btn_editar.Enabled = true;
                presionado = true;
            }
            else
            {
                ActualizarRegistro();
                Txt_idUsuario.Focus();
                presionado = false;
                DeshabilitarCampos();
                HabilitarBotones();
                LimpiarCampos();
            }
        }
    }
}
