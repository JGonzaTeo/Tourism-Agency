/* 
 -----------------------------------------------------
            AUTOR: Ivan Mogollón
  -----------------------------------------------------
*/


using System;
using System.Data;
using System.Data.Odbc;
using System.Net;
using System.Windows.Forms;
using Prototipo_Agencia_Turismo.Consulta;
using Prototipo_Agencia_Turismo;

namespace Prototipo_Agencia_Turismo.Mantenimiento
{
    public partial class Frm_mantHotel : Form
    {
        //Declaracion de variables globales

        bool presionado = false;
        string usuario;
        DateTime fecha = DateTime.Now;

        string idHotel = " ";
        string nombre = " ";
        string direccion = " ";
        string telefono = " ";
        string correo = " ";

        //Validaciones
        Validacion v = new Validacion();

        //Metodos
        private void DeshabilitarCampos()
        {
            Txt_idHotel.Enabled = false;
            Txt_nombre.Enabled = false;
            Txt_direccion.Enabled = false;
            Txt_telefono.Enabled = false;
            Txt_correo.Enabled = false;
        }

        private void HabilitarCampos()
        {
            Txt_idHotel.Enabled = false;
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
            Txt_idHotel.Text = "";
            Txt_nombre.Text = "";
            Txt_direccion.Text = "";
            Txt_telefono.Text = "";
            Txt_correo.Text = "";
        }

        public Frm_mantHotel(string nombreUsuario)
        {
            InitializeComponent();
            usuario = nombreUsuario;
        }

        private void Frm_mantHotelcs_Load(object sender, EventArgs e)
        {
            DeshabilitarCampos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_ingresar_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
            Txt_nombre.Focus();
        }

        private void GuardarDatos()
        {
            idHotel = Txt_idHotel.Text;
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
                string consulta = "INSERT INTO `tbl_hoteles` VALUES ('" + 0+ "', '" + nombre + "', '" + direccion + "'," +
                    " '" + telefono + "', '" + correo + "', '" + 1 + "')";

                OdbcCommand comm = new OdbcCommand(consulta, Conexion.nuevaConexion());
                comm.ExecuteNonQuery();
                MessageBox.Show("Registro guardado correctamente");

                OdbcCommand comm1 = new OdbcCommand("{call SP_InsertarBitacora(?,?,?,?,?)}", Conexion.nuevaConexion());
                comm1.CommandType = CommandType.StoredProcedure;
                comm1.Parameters.Add("ope", OdbcType.Text).Value = "NUEVO REGISTRO";
                comm1.Parameters.Add("usr", OdbcType.Text).Value = usuario;
                comm1.Parameters.Add("fecha", OdbcType.Text).Value = fecha.ToString("yyyy/MM/dd HH:mm:ss");
                comm1.Parameters.Add("proc", OdbcType.Text).Value = "HOTELES";
                comm1.Parameters.Add("dirIp", OdbcType.Text).Value = localIP;
                comm1.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                MessageBox.Show("Error al intentar guardar el registro");
            }
        }

        private void ActualizarDatos()
        {
            idHotel = Txt_idHotel.Text;
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
                string consulta = "UPDATE `tbl_hoteles` SET `NombreHotel` = '" + nombre + "'" +
                    ", `direccionHotel` = '" + direccion + "', `telefonoHotel` = '" + telefono + "', `correoHotel` = '" + correo + 
                    "' WHERE Pk_idHotel = " + idHotel;

                OdbcCommand comm = new OdbcCommand(consulta, Conexion.nuevaConexion());
                comm.ExecuteNonQuery();
                MessageBox.Show("Registro actualizado correctamente");

                OdbcCommand comm1 = new OdbcCommand("{call SP_InsertarBitacora(?,?,?,?,?)}", Conexion.nuevaConexion());
                comm1.CommandType = CommandType.StoredProcedure;
                comm1.Parameters.Add("ope", OdbcType.Text).Value = "ACTUALIZACIÓN DE REGISTRO";
                comm1.Parameters.Add("usr", OdbcType.Text).Value = usuario;
                comm1.Parameters.Add("fecha", OdbcType.Text).Value = fecha.ToString("yyyy/MM/dd HH:mm:ss");
                comm1.Parameters.Add("proc", OdbcType.Text).Value = "HOTELES";
                comm1.Parameters.Add("dirIp", OdbcType.Text).Value = localIP;
                comm1.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                MessageBox.Show("Error al intentar actualizar el registro");
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

        private void Btn_editar_Click(object sender, EventArgs e)
        {
            if (presionado == false)
            {
                DeshabilitarBtn();
                Btn_editar.Enabled = true;
                HabilitarCampos();
                presionado = true;
                Txt_idHotel.Enabled = false;
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

        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
            presionado = false;
            HabilitarBtn();
        }

        private void BorrarDatos()
        {
            idHotel = Txt_idHotel.Text;

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
                string consulta = "UPDATE `tbl_hoteles` SET `estadoHotel` = '" + 0 +
                    "' WHERE Pk_idHotel = " + idHotel;
         
                OdbcCommand comm = new OdbcCommand(consulta, Conexion.nuevaConexion());
                comm.ExecuteNonQuery();
                string consulta2 = "UPDATE tbl_tipohabitacion T " +
                "INNER JOIN tbl_hoteles H ON T.Fk_idhotel = H.Pk_idHotel " +
                "SET T.estadoHabitacion = 0 " +
                "WHERE T.Fk_idHotel =" + idHotel + "; ";
                OdbcCommand comm2 = new OdbcCommand(consulta2, Conexion.nuevaConexion());
                comm2.ExecuteNonQuery();
                MessageBox.Show("Registro eliminado correctamente");

                OdbcCommand comm1 = new OdbcCommand("{call SP_InsertarBitacora(?,?,?,?,?)}", Conexion.nuevaConexion());
                comm1.CommandType = CommandType.StoredProcedure;
                comm1.Parameters.Add("ope", OdbcType.Text).Value = "ACTUALIZACIÓN DE REGISTRO";
                comm1.Parameters.Add("usr", OdbcType.Text).Value = usuario;
                comm1.Parameters.Add("fecha", OdbcType.Text).Value = fecha.ToString("yyyy/MM/dd HH:mm:ss");
                comm1.Parameters.Add("proc", OdbcType.Text).Value = "HOTELES";
                comm1.Parameters.Add("dirIp", OdbcType.Text).Value = localIP;
                comm1.ExecuteNonQuery();
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
                
                Frm_consultaHotel conHotel = new Frm_consultaHotel();
                conHotel.ShowDialog();

                if (conHotel.DialogResult == DialogResult.OK)
                {
                    Txt_idHotel.Text = conHotel.Dgv_consultaHotel.Rows[conHotel.Dgv_consultaHotel.CurrentRow.Index].
                        Cells[0].Value.ToString();
                    Txt_nombre.Text = conHotel.Dgv_consultaHotel.Rows[conHotel.Dgv_consultaHotel.CurrentRow.Index].
                        Cells[1].Value.ToString();
                    Txt_direccion.Text = conHotel.Dgv_consultaHotel.Rows[conHotel.Dgv_consultaHotel.CurrentRow.Index].
                        Cells[2].Value.ToString();
                    Txt_telefono.Text = conHotel.Dgv_consultaHotel.Rows[conHotel.Dgv_consultaHotel.CurrentRow.Index].
                        Cells[3].Value.ToString();
                    Txt_correo.Text = conHotel.Dgv_consultaHotel.Rows[conHotel.Dgv_consultaHotel.CurrentRow.Index].
                        Cells[0].Value.ToString();


                    Txt_nombre.Focus();
                    presionado = false;
                    HabilitarBtn();
                }
            }
        }

        private void Txt_telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloNumeros(e);
        }
    }
    }

