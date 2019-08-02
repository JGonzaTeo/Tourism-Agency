/* 
 -----------------------------------------------------
            AUTOR: Angel Solares
  -----------------------------------------------------
*/


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;
using System.Net;

namespace Prototipo_Agencia_Turismo.Mantenimiento
{
    public partial class Frm_mantCliente : Form
    {
        public Frm_mantCliente()
        {
            InitializeComponent();
        }

        string usuario = " ";
        DateTime fecha = DateTime.Now;
        bool presionado = false;

        string id = "";
        string nombre = "";
        string apellido = "";
        int telefonoCel = 0;
        int telefonoRes = 0;
        string correo = "";
        string correoAlt = "";
        string dpi = "";
        string nit = "";

        //Validaciones
        Validacion v = new Validacion();


        private void limpiar()
        {
            Txt_idCliente.Text = "";
            Txt_Nombre.Text = "";
            Txt_Apellido.Text = "";
            Txt_telefonoCel.Text = "";
            Txt_TelefonoRes.Text = "";
            Txt_correo.Text = "";
            Txt_CorreoAlt.Text = "";
            Txt_dpi.Text = "";
            Txt_nit.Text = "";

        }

        private void HabilitarCampos()
        {
            Txt_Nombre.Enabled = true;
            Txt_Apellido.Enabled = true;
            Txt_telefonoCel.Enabled = true;
            Txt_TelefonoRes.Enabled = true;
            Txt_correo.Enabled = true;
            Txt_CorreoAlt.Enabled = true;
            Txt_dpi.Enabled = true;
            Txt_nit.Enabled = true;
        }

        private void HabilitarBtn()
        {
            Btn_ingresar.Enabled = true;
            Btn_editar.Enabled = true;
            Btn_guardar.Enabled = true;
            Btn_borrar.Enabled = true;
            Btn_consultar.Enabled = true;
        }

        private void DeshabilitarBtn()
        {
            Btn_ingresar.Enabled = false;
            Btn_editar.Enabled = false;
            Btn_guardar.Enabled = false;
            Btn_borrar.Enabled = false;
            Btn_consultar.Enabled = false;
        }

        private void DeshabilitarCampos()
        {

            Txt_Nombre.Enabled = false;
            Txt_Apellido.Enabled = false;
            Txt_telefonoCel.Enabled = false;
            Txt_TelefonoRes.Enabled = false;
            Txt_correo.Enabled = false;
            Txt_CorreoAlt.Enabled = false;
            Txt_dpi.Enabled = false;
            Txt_nit.Enabled = false;

        }

        private void GuardarDatos()
        {
            nombre = Txt_Nombre.Text;
            apellido = Txt_Apellido.Text;
            telefonoCel = int.Parse(Txt_telefonoCel.Text);
            telefonoRes = int.Parse(Txt_TelefonoRes.Text);
            correo = Txt_correo.Text;
            correoAlt = Txt_CorreoAlt.Text;
            dpi = Txt_dpi.Text;
            nit = Txt_nit.Text;


            try
            {
                IPHostEntry host;
                string localIP = "?";
                host = Dns.GetHostEntry(Dns.GetHostName());

                foreach (IPAddress ip in host.AddressList)
                {
                    if (ip.AddressFamily.ToString() == "InterNetwork")
                    {
                        localIP = ip.ToString();
                    }
                }
                string insertar = "INSERT INTO tbl_cliente (nombreCliente,apellidoCliente,telefonoCelCliente,telefonoCasaCliente,correoCliente,correoAltCliente,identificacionCliente,nitCliente,estadoCliente) VALUES('" + nombre + 
                    "', '" + apellido + "', '" + telefonoCel + "', '"+telefonoRes+ "', '" + correo + "', '" +correoAlt+"','"+ dpi + "', '" + nit + "', '1' )";

                OdbcCommand comm = new OdbcCommand(insertar, Conexion.nuevaConexion());
                comm.ExecuteNonQuery();
                MessageBox.Show("Registro guardado correctamente");

                OdbcCommand commBitacora = new OdbcCommand("{call SP_InsertarBitacora(?,?,?,?,?)}", Conexion.nuevaConexion());
                commBitacora.CommandType = CommandType.StoredProcedure;
                commBitacora.Parameters.Add("ope", OdbcType.Text).Value = "INGRESO DE REGISTRO";
                commBitacora.Parameters.Add("usr", OdbcType.Text).Value = usuario;
                commBitacora.Parameters.Add("fecha", OdbcType.Text).Value = fecha.ToString("yyyy/MM/dd HH:mm:ss");
                commBitacora.Parameters.Add("proc", OdbcType.Text).Value = "CLIENTES";
                commBitacora.Parameters.Add("dirIp", OdbcType.Text).Value = localIP;
                commBitacora.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                MessageBox.Show("Error al intentar guardar el registro");
            }
        }


        private void BorrarDatos()
        {
            dpi = Txt_dpi.Text;

            try
            {
                IPHostEntry host;
                string localIP = "?";
                host = Dns.GetHostEntry(Dns.GetHostName());

                foreach (IPAddress ip in host.AddressList)
                {
                    if (ip.AddressFamily.ToString() == "InterNetwork")
                    {
                        localIP = ip.ToString();
                    }
                }
                string consulta = "UPDATE tbl_cliente SET estadoCliente = 0 WHERE identificacionCliente = " + Txt_dpi.Text;
                OdbcCommand comm = new OdbcCommand(consulta, Conexion.nuevaConexion());
                comm.ExecuteNonQuery();
                MessageBox.Show("Registro eliminado correctamente");

                OdbcCommand commBitacora = new OdbcCommand("{call SP_InsertarBitacora(?,?,?,?,?)}", Conexion.nuevaConexion());
                commBitacora.CommandType = CommandType.StoredProcedure;
                commBitacora.Parameters.Add("ope", OdbcType.Text).Value = "ELIMINACION DE REGISTRO";
                commBitacora.Parameters.Add("usr", OdbcType.Text).Value = usuario;
                commBitacora.Parameters.Add("fecha", OdbcType.Text).Value = fecha.ToString("yyyy/MM/dd HH:mm:ss");
                commBitacora.Parameters.Add("proc", OdbcType.Text).Value = "CLIENTES";
                commBitacora.Parameters.Add("dirIp", OdbcType.Text).Value = localIP;
                commBitacora.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                MessageBox.Show("Error al intentar borrar el registro");
            }
        }


        private void ActualizarDatos()
        {
            id = Txt_idCliente.Text;
            nombre = Txt_Nombre.Text;
            apellido = Txt_Apellido.Text;
            telefonoCel = int.Parse(Txt_telefonoCel.Text);
            correo = Txt_correo.Text;
            dpi = Txt_dpi.Text;
            nit = Txt_nit.Text;


            try
            {
                IPHostEntry host;
                string localIP = "?";
                host = Dns.GetHostEntry(Dns.GetHostName());

                foreach (IPAddress ip in host.AddressList)
                {
                    if (ip.AddressFamily.ToString() == "InterNetwork")
                    {
                        localIP = ip.ToString();
                    }
                }
                string actualizar = "UPDATE `tbl_cliente` SET `Pk_idCliente` = '" + id  + "' ," +
                    "`nombreCliente` = '" + nombre + "', `apellidoCliente` = '" + apellido + "', " +
                    "`telefonoCelCliente` = '" + telefonoCel + "', " +
                    "`telefonoResCliente` = '" + telefonoRes + "', " +
                    "`correoCliente` = '" + correo + "', " +
                    "`correoAltCliente` = '" + correoAlt + "', " +
                    "`identificacionCliente` = '" + dpi + "', " +
                    "`nitCliente` = '" + nit + "', `estadoCliente` = '1' WHERE Pk_idCliente = " + id;

                OdbcCommand comm = new OdbcCommand(actualizar, Conexion.nuevaConexion());
                comm.ExecuteNonQuery();
                MessageBox.Show("Registro actualizado correctamente");

                OdbcCommand commBitacora = new OdbcCommand("{call SP_InsertarBitacora(?,?,?,?,?)}", Conexion.nuevaConexion());
                commBitacora.CommandType = CommandType.StoredProcedure;
                commBitacora.Parameters.Add("ope", OdbcType.Text).Value = "ACTUALIZAR REGISTRO";
                commBitacora.Parameters.Add("usr", OdbcType.Text).Value = usuario;
                commBitacora.Parameters.Add("fecha", OdbcType.Text).Value = fecha.ToString("yyyy/MM/dd HH:mm:ss");
                commBitacora.Parameters.Add("proc", OdbcType.Text).Value = "CLIENTES";
                commBitacora.Parameters.Add("dirIp", OdbcType.Text).Value = localIP;
                commBitacora.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                MessageBox.Show("Error al intentar actualizar el registro");
            }
        }

        private void Btn_ingresar_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
            HabilitarBtn();
        }

        private void Btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_editar_Click(object sender, EventArgs e)
        {
            if (presionado == false)
            {
                DeshabilitarBtn();
                Btn_editar.Enabled = true;
                presionado = true;
                Txt_dpi.Enabled = false;
            }
            else
            {
                ActualizarDatos();
                Txt_dpi.Focus();
                presionado = false;
                DeshabilitarCampos();
                HabilitarBtn();
                limpiar();
            }
        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            if (presionado == false)
            {
                DeshabilitarBtn();
                Btn_guardar.Enabled = true;
                presionado = true;
            }
            else
            {
                GuardarDatos();
                Txt_dpi.Focus();
                presionado = false;
                DeshabilitarCampos();
                HabilitarBtn();
                limpiar();
            }
        }

        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            limpiar();
            presionado = false;
            HabilitarBtn();
        }

        private void Btn_borrar_Click(object sender, EventArgs e)
        {
            if (presionado == false)
            {
                DeshabilitarBtn();
                Btn_borrar.Enabled = true;
                presionado = true;
            }
            else
            {
                BorrarDatos();
                Txt_idCliente.Focus();
                presionado = false;
                DeshabilitarCampos();
                HabilitarBtn();
                limpiar();
            }
        }

        private void Btn_consultar_Click(object sender, EventArgs e)
        {
            if (presionado == false)
            {
                DeshabilitarBtn();
                Btn_consultar.Enabled = true;
                presionado = true;
            }
            else
            {
                Consulta.Frm_consultaCliente conCliente = new Consulta.Frm_consultaCliente();
                conCliente.ShowDialog();

                if (conCliente.DialogResult == DialogResult.OK)
                {
                    Txt_idCliente.Text =
                        conCliente.Dgv_consultaCliente.Rows[conCliente.Dgv_consultaCliente.CurrentRow.Index].
                        Cells[0].Value.ToString();

                    Txt_Nombre.Text =
                        conCliente.Dgv_consultaCliente.Rows[conCliente.Dgv_consultaCliente.CurrentRow.Index].
                        Cells[1].Value.ToString();

                    Txt_Apellido.Text =
                        conCliente.Dgv_consultaCliente.Rows[conCliente.Dgv_consultaCliente.CurrentRow.Index].
                        Cells[2].Value.ToString();

                    Txt_telefonoCel.Text =
                        conCliente.Dgv_consultaCliente.Rows[conCliente.Dgv_consultaCliente.CurrentRow.Index].
                        Cells[3].Value.ToString();

                     Txt_TelefonoRes.Text =
                        conCliente.Dgv_consultaCliente.Rows[conCliente.Dgv_consultaCliente.CurrentRow.Index].
                        Cells[4].Value.ToString();

                    Txt_correo.Text =
                        conCliente.Dgv_consultaCliente.Rows[conCliente.Dgv_consultaCliente.CurrentRow.Index].
                        Cells[5].Value.ToString();

                    Txt_CorreoAlt.Text =
                        conCliente.Dgv_consultaCliente.Rows[conCliente.Dgv_consultaCliente.CurrentRow.Index].
                        Cells[6].Value.ToString();

                    Txt_dpi.Text =
                       conCliente.Dgv_consultaCliente.Rows[conCliente.Dgv_consultaCliente.CurrentRow.Index].
                       Cells[7].Value.ToString();

                    Txt_nit.Text =
                       conCliente.Dgv_consultaCliente.Rows[conCliente.Dgv_consultaCliente.CurrentRow.Index].
                       Cells[8].Value.ToString();

                    


                    Txt_idCliente.Focus();
                    presionado = false;
                    HabilitarBtn();
                }
            }
        }

        private void Frm_mantCliente_Load(object sender, EventArgs e)
        {
            Btn_editar.Enabled = false;
            Btn_guardar.Enabled = false;
            Btn_borrar.Enabled = false;
        }

        private void Txt_telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloNumero(e);
        }

        private void Txt_TelefonoRes_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloNumero(e);
        }
    }
}
