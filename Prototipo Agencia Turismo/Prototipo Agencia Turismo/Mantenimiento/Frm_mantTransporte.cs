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
    public partial class Frm_mantTransporte : Form
    {
        public Frm_mantTransporte()
        {
            InitializeComponent();
        }

        string usuario = " ";
        DateTime fecha = DateTime.Now;
        bool presionado = false;

        string id = "";
        string placa = "";
        string tipoTransporte = "";
        int capacidad = 0;
        //Validaciones
        Validacion v = new Validacion();



        private void limpiar()
        {
            Txt_idTransporte.Text = "";
            Txt_noPlaca.Text = "";
            Txt_tipoTransporte.Text = "";
            Txt_capacidad.Text = "";
        }

        private void HabilitarCampos()
        {
            Txt_noPlaca.Enabled = true;
            Txt_tipoTransporte.Enabled = true;
            Txt_capacidad.Enabled = true;
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

            Txt_noPlaca.Enabled = false;
            Txt_tipoTransporte.Enabled = false;
            Txt_capacidad.Enabled = false;

        }

        private void GuardarDatos()
        {
            placa = Txt_noPlaca.Text;
            tipoTransporte = Txt_tipoTransporte.Text;
            capacidad = int.Parse(Txt_capacidad.Text);


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
                OdbcCommand comm = new OdbcCommand("{call SP_InsertarTransporte(?,?,?)}", Conexion.nuevaConexion());
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.Add("Placa", OdbcType.Text).Value = placa;
                comm.Parameters.Add("TipoTransporte", OdbcType.Text).Value = tipoTransporte;
                comm.Parameters.Add("Capacidad", OdbcType.Int).Value = capacidad;
                comm.ExecuteNonQuery();
                MessageBox.Show("Registro guardado correctamente");

                OdbcCommand commBitacora = new OdbcCommand("{call SP_InsertarBitacora(?,?,?,?,?)}", Conexion.nuevaConexion());
                commBitacora.CommandType = CommandType.StoredProcedure;
                commBitacora.Parameters.Add("ope", OdbcType.Text).Value = "INGRESO DE REGISTRO";
                commBitacora.Parameters.Add("usr", OdbcType.Text).Value = usuario;
                commBitacora.Parameters.Add("fecha", OdbcType.Text).Value = fecha.ToString("yyyy/MM/dd HH:mm:ss");
                commBitacora.Parameters.Add("proc", OdbcType.Text).Value = "TRANSPORTE";
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
            placa = Txt_noPlaca.Text;

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
                OdbcCommand comm = new OdbcCommand("{call SP_EliminarTransporte(?)}", Conexion.nuevaConexion());
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.Add("Placa", OdbcType.Text).Value = placa;
                comm.ExecuteNonQuery();
                MessageBox.Show("Registro eliminado correctamente");

                OdbcCommand commBitacora = new OdbcCommand("{call SP_InsertarBitacora(?,?,?,?,?)}", Conexion.nuevaConexion());
                commBitacora.CommandType = CommandType.StoredProcedure;
                commBitacora.Parameters.Add("ope", OdbcType.Text).Value = "ELIMINACION DE REGISTRO";
                commBitacora.Parameters.Add("usr", OdbcType.Text).Value = usuario;
                commBitacora.Parameters.Add("fecha", OdbcType.Text).Value = fecha.ToString("yyyy/MM/dd HH:mm:ss");
                commBitacora.Parameters.Add("proc", OdbcType.Text).Value = "DEPARTAMENTOS";
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
            id = Txt_idTransporte.Text;
            placa = Txt_noPlaca.Text;
            tipoTransporte = Txt_tipoTransporte.Text;
            capacidad = int.Parse(Txt_capacidad.Text);

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
                OdbcCommand comm = new OdbcCommand("{call SP_ActualizarTransporte(?,?,?)}", Conexion.nuevaConexion());
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.Add("Placa", OdbcType.Text).Value = placa;
                comm.Parameters.Add("TipoTransporte", OdbcType.Text).Value = tipoTransporte;
                comm.Parameters.Add("Capacidad", OdbcType.Text).Value = capacidad;
                comm.ExecuteNonQuery();
                MessageBox.Show("Registro actualizado correctamente");

                OdbcCommand commBitacora = new OdbcCommand("{call SP_InsertarBitacora(?,?,?,?,?)}", Conexion.nuevaConexion());
                commBitacora.CommandType = CommandType.StoredProcedure;
                commBitacora.Parameters.Add("ope", OdbcType.Text).Value = "ACTUALIZAR REGISTRO";
                commBitacora.Parameters.Add("usr", OdbcType.Text).Value = usuario;
                commBitacora.Parameters.Add("fecha", OdbcType.Text).Value = fecha.ToString("yyyy/MM/dd HH:mm:ss");
                commBitacora.Parameters.Add("proc", OdbcType.Text).Value = "DEPARTAMENTOS";
                commBitacora.Parameters.Add("dirIp", OdbcType.Text).Value = localIP;
                commBitacora.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                MessageBox.Show("Error al intentar actualizar el registro");
            }
        }



        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Frm_mantTransporte_Load(object sender, EventArgs e)
        {
            Btn_editar.Enabled = false;
            Btn_guardar.Enabled = false;
            Btn_borrar.Enabled = false;
        }

        private void Btn_ingresar_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
        }

        private void Btn_editar_Click(object sender, EventArgs e)
        {
            if (presionado == false)
            {
                DeshabilitarBtn();
                Btn_editar.Enabled = true;
                presionado = true;
                Txt_noPlaca.Enabled = false;
            }
            else
            {
                ActualizarDatos();
                Txt_noPlaca.Focus();
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
                Txt_noPlaca.Focus();
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
                Txt_idTransporte.Focus();
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
                Consulta.Frm_consultaTransporte conTransporte = new Consulta.Frm_consultaTransporte();
                conTransporte.ShowDialog();

                if (conTransporte.DialogResult == DialogResult.OK)
                {
                    Txt_idTransporte.Text =
                        conTransporte.Dgv_consultaTransporte.Rows[conTransporte.Dgv_consultaTransporte.CurrentRow.Index].
                        Cells[0].Value.ToString();

                    Txt_noPlaca.Text =
                         conTransporte.Dgv_consultaTransporte.Rows[conTransporte.Dgv_consultaTransporte.CurrentRow.Index].
                         Cells[1].Value.ToString();

                    Txt_tipoTransporte.Text =
                        conTransporte.Dgv_consultaTransporte.Rows[conTransporte.Dgv_consultaTransporte.CurrentRow.Index].
                        Cells[2].Value.ToString();

                    Txt_capacidad.Text =
                        conTransporte.Dgv_consultaTransporte.Rows[conTransporte.Dgv_consultaTransporte.CurrentRow.Index].
                        Cells[3].Value.ToString();

                    Txt_idTransporte.Focus();
                    presionado = false;
                    HabilitarBtn();
                }
            }
        }

        private void Txt_capacidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void Lbl_capacidad_Click(object sender, EventArgs e)
        {

        }

        private void Txt_tipoTransporte_TextChanged(object sender, EventArgs e)
        {

        }

        private void Lbl_tipoTransporte_Click(object sender, EventArgs e)
        {

        }

        private void Txt_noPlaca_TextChanged(object sender, EventArgs e)
        {

        }

        private void Lbl_noPlaca_Click(object sender, EventArgs e)
        {

        }

        private void Txt_idTransporte_TextChanged(object sender, EventArgs e)
        {

        }

        private void Lbl_idTransporte_Click(object sender, EventArgs e)
        {

        }

        private void Txt_capacidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloNumero(e);
        }
    }
}
