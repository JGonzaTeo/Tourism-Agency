/* 
 -----------------------------------------------------
            AUTOR: Edson Juarez
  -----------------------------------------------------
*/


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;
using Prototipo_Agencia_Turismo.Consulta;

namespace Prototipo_Agencia_Turismo.Mantenimiento
{
    public partial class Frm_mantPerfil : Form
    {
        IPHostEntry host;
        string localIP = "?";
        bool presionado = false;
        string nombreUsuario = " ";
        DateTime fecha = DateTime.Now;

        string idPerfil = " ";
        string nombre = " ";
        string detalle = " ";

        Validacion validar = new Validacion();

        public Frm_mantPerfil(string usuario)
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
            Txt_detalle.Enabled = true;
        }

        private void DeshabilitarCampos()
        {
            Txt_nombre.Enabled = false;
            Txt_detalle.Enabled = false;
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
            Txt_idPerfil.Text = " ";
            Txt_nombre.Text = " ";
            Txt_detalle.Text = " ";
            Txt_estado.Text = " ";
        }

        private void ActualizarRegistro()
        {
            idPerfil = Txt_idPerfil.Text;
            nombre = Txt_nombre.Text;
            detalle = Txt_detalle.Text;

            try
            {
                string actualizarRegistro = "UPDATE `tbl_perfil` SET `Pk_idPerfil` = '" + idPerfil + "' ," +
                    "`nombre_Perfil` = '" + nombre + "', `detalle_perfil` = '" + detalle + "', " +
                    " `estado` = '1' WHERE Pk_idPerfil = " + idPerfil;

                OdbcCommand comm = new OdbcCommand(actualizarRegistro, Conexion.nuevaConexion());
                comm.ExecuteNonQuery();
                comm.Connection.Close();

                MessageBox.Show("Registro actualizado correctamente");

                OdbcCommand comm1 = new OdbcCommand("{call SP_InsertarBitacora(?,?,?,?,?)}", Conexion.nuevaConexion());
                comm1.CommandType = CommandType.StoredProcedure;
                comm1.Parameters.Add("ope", OdbcType.Text).Value = "ACTUALIZACIÓN DE REGISTRO";
                comm1.Parameters.Add("usr", OdbcType.Text).Value = nombreUsuario;
                comm1.Parameters.Add("fecha", OdbcType.Text).Value = fecha.ToString("yyyy/MM/dd HH:mm:ss");
                comm1.Parameters.Add("proc", OdbcType.Text).Value = "MANTENIMIENTO PERFIL";
                comm1.Parameters.Add("dirIp", OdbcType.Text).Value = localIP;
                comm1.ExecuteNonQuery();
                comm1.Connection.Close();
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                MessageBox.Show("No se han llenado todos los campos para actualizar el registro...");
            }
        }

        private void ActualizarEstado()
        {
            try
            {
                string consultaPerfil = "UPDATE tbl_perfil SET estado = 0 WHERE Pk_idPerfil = " + Txt_idPerfil.Text;
                OdbcCommand comm = new OdbcCommand(consultaPerfil, Conexion.nuevaConexion());
                comm.ExecuteNonQuery();
                comm.Connection.Close();
                MessageBox.Show("Registro eliminado correctamente");

                OdbcCommand comm1 = new OdbcCommand("{call SP_InsertarBitacora(?,?,?,?,?)}", Conexion.nuevaConexion());
                comm1.CommandType = CommandType.StoredProcedure;
                comm1.Parameters.Add("ope", OdbcType.Text).Value = "ELIMINACIÓN DE REGISTRO";
                comm1.Parameters.Add("usr", OdbcType.Text).Value = nombreUsuario;
                comm1.Parameters.Add("fecha", OdbcType.Text).Value = fecha.ToString("yyyy/MM/dd HH:mm:ss");
                comm1.Parameters.Add("proc", OdbcType.Text).Value = "MANTEMIMIENTO PERFIL";
                comm1.Parameters.Add("dirIp", OdbcType.Text).Value = localIP;
                comm1.ExecuteNonQuery();
                comm1.Connection.Close();
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }

        private void GuardarRegistro()
        {
            idPerfil = Txt_idPerfil.Text;
            nombre = Txt_nombre.Text;
            detalle = Txt_detalle.Text;

            try
            {
                string insertarUsuario = "INSERT INTO tbl_perfil (nombre_Perfil,detalle_perfil,estado) VALUES('" + nombre + "', '" + detalle + "', '1' )";

                OdbcCommand comm = new OdbcCommand(insertarUsuario, Conexion.nuevaConexion());
                comm.ExecuteNonQuery();
                comm.Connection.Close();

                MessageBox.Show("Registro guardado correctamente");

                OdbcCommand comm1 = new OdbcCommand("{call SP_InsertarBitacora(?,?,?,?,?)}", Conexion.nuevaConexion());
                comm1.CommandType = CommandType.StoredProcedure;
                comm1.Parameters.Add("ope", OdbcType.Text).Value = "INSERCIÓN DE REGISTRO";
                comm1.Parameters.Add("usr", OdbcType.Text).Value = nombreUsuario;
                comm1.Parameters.Add("fecha", OdbcType.Text).Value = fecha.ToString("yyyy/MM/dd HH:mm:ss");
                comm1.Parameters.Add("proc", OdbcType.Text).Value = "MANTENIMIENTO PERFIL";
                comm1.Parameters.Add("dirIp", OdbcType.Text).Value = localIP;
                comm1.ExecuteNonQuery();
                comm1.Connection.Close();
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                MessageBox.Show("No se han llenado todos los campos para guardar el registro...");
            }
        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Txt_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.validarLetras(e);
        }

        private void Frm_mantPerfil_Load(object sender, EventArgs e)
        {
            ObtenerIp();
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
                Frm_consultaPerfil consultaPerfil = new Frm_consultaPerfil();
                consultaPerfil.ShowDialog();

                if(consultaPerfil.DialogResult == DialogResult.OK)
                {
                    Txt_idPerfil.Text =
                        consultaPerfil.Dgv_consultaPerfil.Rows[consultaPerfil.Dgv_consultaPerfil.CurrentRow.Index].
                        Cells[0].Value.ToString();

                    Txt_nombre.Text =
                        consultaPerfil.Dgv_consultaPerfil.Rows[consultaPerfil.Dgv_consultaPerfil.CurrentRow.Index].
                        Cells[1].Value.ToString();

                    Txt_detalle.Text =
                        consultaPerfil.Dgv_consultaPerfil.Rows[consultaPerfil.Dgv_consultaPerfil.CurrentRow.Index].
                        Cells[2].Value.ToString();

                    Txt_estado.Text =
                        consultaPerfil.Dgv_consultaPerfil.Rows[consultaPerfil.Dgv_consultaPerfil.CurrentRow.Index].
                        Cells[3].Value.ToString();

                    Txt_nombre.Focus();
                    presionado = false;
                    HabilitarBotones();
                }
            }
        }

        private void Txt_detalle_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.validarLetras(e);
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
                Txt_nombre.Focus();
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
            if (presionado == false)
            {
                DeshabilitarBotones();
                Btn_guardar.Enabled = true;
                presionado = true;
            }
            else
            {
                GuardarRegistro();
                Txt_nombre.Focus();
                presionado = false;
                DeshabilitarCampos();
                HabilitarBotones();
                LimpiarCampos();
            }
        }

        private void Btn_ingresar_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
        }

        private void Btn_editar_Click(object sender, EventArgs e)
        {
            if (presionado == false)
            {
                DeshabilitarBotones();
                Btn_editar.Enabled = true;
                presionado = true;
            }
            else
            {
                ActualizarRegistro();
                Txt_nombre.Focus();
                presionado = false;
                DeshabilitarCampos();
                HabilitarBotones();
                LimpiarCampos();
            }
        }
    }
}
