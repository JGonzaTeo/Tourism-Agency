/* 
 -----------------------------------------------------
            AUTOR: Ivan Mogollón
  -----------------------------------------------------
*/

using Prototipo_Agencia_Turismo.Consulta;
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
using Prototipo_Agencia_Turismo;

namespace Prototipo_Agencia_Turismo.Mantenimiento
{
    public partial class Frm_mantRestaurante : Form
    {
        //Declaracion de variables globales

        bool presionado = false;
        string usuario;
        DateTime fecha = DateTime.Now;

        string idRestaurante = " ";
        string nombre = " ";
        string direccion = " ";
        string telefono = " ";
        string correo = " ";

        //Validaciones
        Validacion v = new Validacion();

        //Metodos
        private void DeshabilitarCampos()
        {
            Txt_idRestaurante.Enabled = false;
            Txt_nombre.Enabled = false;
            Txt_direccion.Enabled = false;
            Txt_telefono.Enabled = false;
            Txt_correo.Enabled = false;
        }

        private void HabilitarCampos()
        {
            Txt_idRestaurante.Enabled = false;
            Txt_nombre.Enabled = true;
            Txt_direccion.Enabled = true;
            Txt_telefono.Enabled = true;
            Txt_correo.Enabled = true;
        }

        private void DeshabilitarBtn()
        {
            Btn_ingresar.Enabled = false;
            Btn_editar.Enabled = false;
            Btn_guardar.Enabled = false;
            Btn_borrar.Enabled = false;
            Btn_consultar.Enabled = false;
        }

        private void HabilitarBtn()
        {
            Btn_ingresar.Enabled = true;
            Btn_editar.Enabled = true;
            Btn_guardar.Enabled = true;
            Btn_borrar.Enabled = true;
            Btn_consultar.Enabled = true;
        }

        private void Limpiar()
        {
            Txt_idRestaurante.Text = "";
            Txt_nombre.Text = "";
            Txt_direccion.Text = "";
            Txt_telefono.Text = "";
            Txt_correo.Text = "";
        }

        public Frm_mantRestaurante(string nombreUsuario)
        {
            InitializeComponent();
            usuario = nombreUsuario;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Frm_mantRestaurante_Load(object sender, EventArgs e)
        {
            DeshabilitarCampos();
        }

        private void Txt_telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloNumero(e);
        }

        private void Btn_ingresar_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
            Txt_nombre.Focus();
        }

        private void ActualizarDatos()
        {
            idRestaurante = Txt_idRestaurante.Text;
            nombre = Txt_nombre.Text;
            direccion = Txt_direccion.Text;
            telefono = Txt_telefono.Text;
            correo = Txt_correo.Text;
            int numTelefonico = Convert.ToInt32(telefono);

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

            try
            {
                string consulta = "UPDATE `tbl_restaurantes` SET `NombreRestaurante` = '" + nombre + "'" +
                    ", `direccionRestaurante` = '" + direccion + "', `telefonoRestaurante` = '" + telefono + "', `correoRestaurante` = '" + correo +
                    "' WHERE Pk_idRestaurante = " + idRestaurante;

                OdbcCommand comm = new OdbcCommand(consulta, Conexion.nuevaConexion());
                comm.ExecuteNonQuery();
                MessageBox.Show("Registro actualizado correctamente");
                comm.Connection.Close();

                OdbcCommand comm1 = new OdbcCommand("{call SP_InsertarBitacora(?,?,?,?,?)}", Conexion.nuevaConexion());
                comm1.CommandType = CommandType.StoredProcedure;
                comm1.Parameters.Add("ope", OdbcType.Text).Value = "ACTUALIZACIÓN DE REGISTRO";
                comm1.Parameters.Add("usr", OdbcType.Text).Value = usuario;
                comm1.Parameters.Add("fecha", OdbcType.Text).Value = fecha.ToString("yyyy/MM/dd HH:mm:ss");
                comm1.Parameters.Add("proc", OdbcType.Text).Value = "RESTAURANTES";
                comm1.Parameters.Add("dirIp", OdbcType.Text).Value = localIP;
                comm1.ExecuteNonQuery();
                comm1.Connection.Close();
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                MessageBox.Show("Error al intentar actualizar el registro");
            }
        }

        private void Btn_editar_Click(object sender, EventArgs e)
        {
            if (presionado == false)
            {
                DeshabilitarBtn();
                Btn_editar.Enabled = true;
                HabilitarCampos();
                presionado = true;
                Txt_idRestaurante.Enabled = false;
            }
            else
            {
                ActualizarDatos();
                Txt_nombre.Focus();
                presionado = false;
                DeshabilitarCampos();
                HabilitarBtn();
                Limpiar();
            }
        }

        private void GuardarDatos()
        {
            idRestaurante = Txt_idRestaurante.Text;
            nombre = Txt_nombre.Text;
            direccion = Txt_direccion.Text;
            telefono = Txt_telefono.Text;
            correo = Txt_correo.Text;

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

            try
            {
                string consulta = "INSERT INTO `tbl_restaurantes` VALUES ('" + 0 + "', '" + nombre + "', '" + direccion + "'," +
                    " '" + telefono + "', '" + correo + "', '" + 1 + "')";

                OdbcCommand comm = new OdbcCommand(consulta, Conexion.nuevaConexion());
                comm.ExecuteNonQuery();
                MessageBox.Show("Registro guardado correctamente");
                comm.Connection.Close();

                OdbcCommand comm1 = new OdbcCommand("{call SP_InsertarBitacora(?,?,?,?,?)}", Conexion.nuevaConexion());
                comm1.CommandType = CommandType.StoredProcedure;
                comm1.Parameters.Add("ope", OdbcType.Text).Value = "NUEVO REGISTRO";
                comm1.Parameters.Add("usr", OdbcType.Text).Value = usuario;
                comm1.Parameters.Add("fecha", OdbcType.Text).Value = fecha.ToString("yyyy/MM/dd HH:mm:ss");
                comm1.Parameters.Add("proc", OdbcType.Text).Value = "RESTAURANTES";
                comm1.Parameters.Add("dirIp", OdbcType.Text).Value = localIP;
                comm1.ExecuteNonQuery();
                comm1.Connection.Close();
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                MessageBox.Show("Error al intentar guardar el registro");
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
                presionado = false;
                DeshabilitarCampos();
                HabilitarBtn();
                Limpiar();
            }
        }

        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
            presionado = false;
            HabilitarBtn();
        }

        private void BorrarDatos()
        {
            idRestaurante = Txt_idRestaurante.Text;

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

            try
            {
                string consulta = "UPDATE `tbl_restaurantes` SET `estadoRestaurante` = '" + 0  +
                    "' WHERE Pk_idRestaurante = " + idRestaurante;

                OdbcCommand comm = new OdbcCommand(consulta, Conexion.nuevaConexion());
                comm.ExecuteNonQuery();
                comm.Connection.Close();

                string consulta2 = "UPDATE tbl_menus M " +
                "INNER JOIN tbl_restaurantes R ON M.Fk_idRestaurantes = R.Pk_idRestaurante " +
                "SET M.estadoMenu = 0 " +
                "WHERE M.Fk_idRestaurantes =" + idRestaurante + "; ";
                OdbcCommand comm2 = new OdbcCommand(consulta2, Conexion.nuevaConexion());
                comm2.ExecuteNonQuery();
                comm2.Connection.Close();
                MessageBox.Show("Registro eliminado correctamente");

                OdbcCommand comm1 = new OdbcCommand("{call SP_InsertarBitacora(?,?,?,?,?)}", Conexion.nuevaConexion());
                comm1.CommandType = CommandType.StoredProcedure;
                comm1.Parameters.Add("ope", OdbcType.Text).Value = "ACTUALIZACIÓN DE REGISTRO";
                comm1.Parameters.Add("usr", OdbcType.Text).Value = usuario;
                comm1.Parameters.Add("fecha", OdbcType.Text).Value = fecha.ToString("yyyy/MM/dd HH:mm:ss");
                comm1.Parameters.Add("proc", OdbcType.Text).Value = "RESTAURANTES";
                comm1.Parameters.Add("dirIp", OdbcType.Text).Value = localIP;
                comm1.ExecuteNonQuery();
                comm1.Connection.Close();
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                MessageBox.Show("Error al intentar eliminar el registro");
            }
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
                Txt_nombre.Focus();
                presionado = false;
                DeshabilitarCampos();
                HabilitarBtn();
                Limpiar();
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

                Frm_consultaRestaurante conRestaurante = new Frm_consultaRestaurante();
                conRestaurante.ShowDialog();

                if (conRestaurante.DialogResult == DialogResult.OK)
                {
                    Txt_idRestaurante.Text = conRestaurante.Dgv_consultaRestaurante.Rows[conRestaurante.Dgv_consultaRestaurante.CurrentRow.Index].
                        Cells[0].Value.ToString();
                    Txt_nombre.Text = conRestaurante.Dgv_consultaRestaurante.Rows[conRestaurante.Dgv_consultaRestaurante.CurrentRow.Index].
                        Cells[1].Value.ToString();
                    Txt_direccion.Text = conRestaurante.Dgv_consultaRestaurante.Rows[conRestaurante.Dgv_consultaRestaurante.CurrentRow.Index].
                        Cells[2].Value.ToString();
                    Txt_telefono.Text = conRestaurante.Dgv_consultaRestaurante.Rows[conRestaurante.Dgv_consultaRestaurante.CurrentRow.Index].
                        Cells[3].Value.ToString();
                    Txt_correo.Text = conRestaurante.Dgv_consultaRestaurante.Rows[conRestaurante.Dgv_consultaRestaurante.CurrentRow.Index].
                        Cells[0].Value.ToString();
                    Txt_nombre.Focus();
                    presionado = false;
                    HabilitarBtn();
                }
            }
        }
    }
}
