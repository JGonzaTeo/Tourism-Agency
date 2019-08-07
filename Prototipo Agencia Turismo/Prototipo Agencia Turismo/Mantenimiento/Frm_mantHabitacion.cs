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
using static Prototipo_Agencia_Turismo.Form1;

namespace Prototipo_Agencia_Turismo.Mantenimiento
{
    public partial class Frm_mantHabitacion : Form
    {
        //Declaracion de variables globales

        bool presionado = false;
        string usuario;
        DateTime fecha = DateTime.Now;

        string idHabitacion = " ";
        string idHotel = " ";
        string nombre = " ";
        string capacidad = " ";
        string costo = " ";

        //Validaciones
        Validacion v = new Validacion();

        //Metodos
        private void DeshabilitarCampos()
        {
            Txt_idHabitacion.Enabled = false;
            Txt_hotel.Enabled = false;
            Txt_nombre.Enabled = false;
            Txt_capacidad.Enabled = false;
            Txt_costo.Enabled = false;
            Btn_busqueda.Enabled = false;
        }

        private void HabilitarCampos()
        {
            Txt_idHabitacion.Enabled = false;
            Txt_hotel.Enabled = false;
            Txt_nombre.Enabled = true;
            Txt_capacidad.Enabled = true;
            Txt_costo.Enabled = true;
            Btn_busqueda.Enabled = true;
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
            Txt_idHabitacion.Text = "";
            Txt_hotel.Text = "";
            Txt_nombre.Text = "";
            Txt_capacidad.Text = "";
            Txt_costo.Text = "";
        }
        public Frm_mantHabitacion(string nombreUsuario)
        {
            InitializeComponent();
            usuario = nombreUsuario; 
        }

        private void Btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_mantHabitacion_Load(object sender, EventArgs e)
        {
            DeshabilitarCampos();
        }

        private void Btn_busqueda_Click(object sender, EventArgs e)
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
                    Txt_hotel.Text = conHotel.Dgv_consultaHotel.Rows[conHotel.Dgv_consultaHotel.CurrentRow.Index].
                    Cells[0].Value.ToString();

                    Txt_nombre.Focus();
                    presionado = false;
                    HabilitarBtn();
                }
            }
        }

        private void Btn_ingresar_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
            Txt_nombre.Focus();
        }

        private void ActualizarDatos()
        {
            idHabitacion = Txt_idHabitacion.Text;
            idHotel = Txt_hotel.Text;
            nombre = Txt_nombre.Text;
            capacidad = Txt_capacidad.Text;
            costo = Txt_costo.Text;
            
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
                string consulta = "UPDATE `tbl_tipohabitacion` SET `Fk_idHotel` = '" + idHotel + "'" +
                    ", `nombreHabitacion` = '" + nombre + "', `capacidadHabitacion` = '" + capacidad + "', `costoHabitacion` = '" + costo +
                    "' WHERE Pk_idTipoHabitacion = " + idHabitacion;

                OdbcCommand comm = new OdbcCommand(consulta, Conexion.nuevaConexion());
                comm.ExecuteNonQuery();
                MessageBox.Show("Registro actualizado correctamente");
                comm.Connection.Close();

                OdbcCommand comm1 = new OdbcCommand("{call SP_InsertarBitacora(?,?,?,?,?)}", Conexion.nuevaConexion());
                comm1.CommandType = CommandType.StoredProcedure;
                comm1.Parameters.Add("ope", OdbcType.Text).Value = "ACTUALIZACIÓN DE REGISTRO";
                comm1.Parameters.Add("usr", OdbcType.Text).Value = usuario;
                comm1.Parameters.Add("fecha", OdbcType.Text).Value = fecha.ToString("yyyy/MM/dd HH:mm:ss");
                comm1.Parameters.Add("proc", OdbcType.Text).Value = "HABITACION";
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
                Txt_idHabitacion.Enabled = false;
                Txt_hotel.Enabled = false;
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
            idHabitacion = Txt_idHabitacion.Text;
            idHotel = Txt_hotel.Text;
            nombre = Txt_nombre.Text;
            capacidad = Txt_capacidad.Text;
            costo = Txt_costo.Text;

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
                string consulta = "INSERT INTO `tbl_tipohabitacion` VALUES ('" + 0 + "', '" + idHotel + "', '" + nombre + "'," +
                    " '" + capacidad + "', '" + costo + "', '" + 1 + "')";

                OdbcCommand comm = new OdbcCommand(consulta, Conexion.nuevaConexion());
                comm.ExecuteNonQuery();
                MessageBox.Show("Registro guardado correctamente");
                comm.Connection.Close();

                OdbcCommand comm1 = new OdbcCommand("{call SP_InsertarBitacora(?,?,?,?,?)}", Conexion.nuevaConexion());
                comm1.CommandType = CommandType.StoredProcedure;
                comm1.Parameters.Add("ope", OdbcType.Text).Value = "NUEVO REGISTRO";
                comm1.Parameters.Add("usr", OdbcType.Text).Value = usuario;
                comm1.Parameters.Add("fecha", OdbcType.Text).Value = fecha.ToString("yyyy/MM/dd HH:mm:ss");
                comm1.Parameters.Add("proc", OdbcType.Text).Value = "HABITACION";
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

        private void Txt_costo_KeyUp(object sender, KeyEventArgs e)
        {
            Funciones.ValidarCampoDecimal((TextBox)sender);
        }

        private void Txt_capacidad_KeyUp(object sender, KeyEventArgs e)
        {
            Funciones.ValidarCampoEntero((TextBox)sender);
        }

        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
            presionado = false;
            HabilitarBtn();
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

                Frm_consultaHabitacion conHabitacion = new Frm_consultaHabitacion();
                conHabitacion.ShowDialog();

                if (conHabitacion.DialogResult == DialogResult.OK)
                {
                    Txt_idHabitacion.Text = conHabitacion.Dgv_consultaHabitacion.Rows[conHabitacion.Dgv_consultaHabitacion.CurrentRow.Index].
                        Cells[0].Value.ToString();
                    Txt_hotel.Text = conHabitacion.Dgv_consultaHabitacion.Rows[conHabitacion.Dgv_consultaHabitacion.CurrentRow.Index].
                        Cells[1].Value.ToString();
                    Txt_nombre.Text = conHabitacion.Dgv_consultaHabitacion.Rows[conHabitacion.Dgv_consultaHabitacion.CurrentRow.Index].
                        Cells[2].Value.ToString();
                    Txt_capacidad.Text = conHabitacion.Dgv_consultaHabitacion.Rows[conHabitacion.Dgv_consultaHabitacion.CurrentRow.Index].
                        Cells[3].Value.ToString();
                    Txt_costo.Text = conHabitacion.Dgv_consultaHabitacion.Rows[conHabitacion.Dgv_consultaHabitacion.CurrentRow.Index].
                        Cells[4].Value.ToString();


                    Txt_nombre.Focus();
                    presionado = false;
                    HabilitarBtn();
                }
            }
        }

        private void BorrarDatos()
        {
            idHabitacion = Txt_idHabitacion.Text;

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
                string consulta = "UPDATE `tbl_tipohabitacion` SET `estadoHabitacion` = '" + 0 +
                    "' WHERE Pk_idTipoHabitacion = " + idHabitacion;

                OdbcCommand comm = new OdbcCommand(consulta, Conexion.nuevaConexion());
                comm.ExecuteNonQuery();
                MessageBox.Show("Registro eliminado correctamente");
                comm.Connection.Close();

                OdbcCommand comm1 = new OdbcCommand("{call SP_InsertarBitacora(?,?,?,?,?)}", Conexion.nuevaConexion());
                comm1.CommandType = CommandType.StoredProcedure;
                comm1.Parameters.Add("ope", OdbcType.Text).Value = "ACTUALIZACIÓN DE REGISTRO";
                comm1.Parameters.Add("usr", OdbcType.Text).Value = usuario;
                comm1.Parameters.Add("fecha", OdbcType.Text).Value = fecha.ToString("yyyy/MM/dd HH:mm:ss");
                comm1.Parameters.Add("proc", OdbcType.Text).Value = "HABITACION";
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
    }
}
