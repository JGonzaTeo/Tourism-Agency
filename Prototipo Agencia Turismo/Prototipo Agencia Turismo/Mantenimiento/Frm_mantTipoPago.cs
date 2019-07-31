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
    public partial class Frm_mantTipoPago : Form
    {
        public Frm_mantTipoPago(string nombreUsuario)
        {
            InitializeComponent();
            usuario = nombreUsuario;
        }

        //Declaracion de variables globales

        bool presionado = false;
        string usuario;
        DateTime fecha = DateTime.Now;

        string idPago = " ";
        string nombre = " ";
        string descripcion = " ";
        
        //Validaciones
        Validacion v = new Validacion();

        //Metodos
        private void DeshabilitarCampos()
        {
            Txt_idPago.Enabled = false;
            Txt_nombre.Enabled = false;
            Txt_descripcion.Enabled = false;
        }

        private void HabilitarCampos()
        {
            Txt_idPago.Enabled = false;
            Txt_nombre.Enabled = true;
            Txt_descripcion.Enabled = true;
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
            Txt_idPago.Text = "";
            Txt_nombre.Text = "";
            Txt_descripcion.Text = "";
        }

        private void Lbl_titulo_Click(object sender, EventArgs e)
        {

        }

        private void Btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_ingresar_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
            Txt_nombre.Focus();
        }

        private void ActualizarDatos()
        {
            idPago = Txt_idPago.Text;
            nombre = Txt_nombre.Text;
            descripcion = Txt_descripcion.Text;

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
                string consulta = "UPDATE `tbl_TipoPagos` SET `NombreTipoPago` = '" + nombre + "'" +
                    ", `DescripcionTipoPago` = '" + descripcion +
                    "' WHERE Pk_idTipoPago = " + idPago;

                OdbcCommand comm = new OdbcCommand(consulta, Conexion.nuevaConexion());
                comm.ExecuteNonQuery();
                MessageBox.Show("Registro actualizado correctamente");

                OdbcCommand comm1 = new OdbcCommand("{call SP_InsertarBitacora(?,?,?,?,?)}", Conexion.nuevaConexion());
                comm1.CommandType = CommandType.StoredProcedure;
                comm1.Parameters.Add("ope", OdbcType.Text).Value = "ACTUALIZACIÓN DE REGISTRO";
                comm1.Parameters.Add("usr", OdbcType.Text).Value = usuario;
                comm1.Parameters.Add("fecha", OdbcType.Text).Value = fecha.ToString("yyyy/MM/dd HH:mm:ss");
                comm1.Parameters.Add("proc", OdbcType.Text).Value = "PAGOS";
                comm1.Parameters.Add("dirIp", OdbcType.Text).Value = localIP;
                comm1.ExecuteNonQuery();
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
                Txt_idPago.Enabled = false;
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
            idPago = Txt_idPago.Text;
            nombre = Txt_nombre.Text;
            descripcion = Txt_descripcion.Text;

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
                string consulta = "INSERT INTO `tbl_tipoPagos` VALUES ('" + 0 + "', '" + nombre + "', '" + descripcion+ "', '" + 1 + "')";

                OdbcCommand comm = new OdbcCommand(consulta, Conexion.nuevaConexion());
                comm.ExecuteNonQuery();
                MessageBox.Show("Registro guardado correctamente");

                OdbcCommand comm1 = new OdbcCommand("{call SP_InsertarBitacora(?,?,?,?,?)}", Conexion.nuevaConexion());
                comm1.CommandType = CommandType.StoredProcedure;
                comm1.Parameters.Add("ope", OdbcType.Text).Value = "NUEVO REGISTRO";
                comm1.Parameters.Add("usr", OdbcType.Text).Value = usuario;
                comm1.Parameters.Add("fecha", OdbcType.Text).Value = fecha.ToString("yyyy/MM/dd HH:mm:ss");
                comm1.Parameters.Add("proc", OdbcType.Text).Value = "PAGOS";
                comm1.Parameters.Add("dirIp", OdbcType.Text).Value = localIP;
                comm1.ExecuteNonQuery();
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
            idPago = Txt_idPago.Text;
            nombre = Txt_nombre.Text;
            descripcion = Txt_descripcion.Text;

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
               string consulta = "UPDATE `tbl_TipoPagos` SET `estadoTipoPago` = '" + 0 +
                    "' WHERE Pk_idTipoPago = " + idPago;
 
                OdbcCommand comm = new OdbcCommand(consulta, Conexion.nuevaConexion());
                comm.ExecuteNonQuery();
                MessageBox.Show("Registro eliminado correctamente");

                OdbcCommand comm1 = new OdbcCommand("{call SP_InsertarBitacora(?,?,?,?,?)}", Conexion.nuevaConexion());
                comm1.CommandType = CommandType.StoredProcedure;
                comm1.Parameters.Add("ope", OdbcType.Text).Value = "ACTUALIZACIÓN DE REGISTRO";
                comm1.Parameters.Add("usr", OdbcType.Text).Value = usuario;
                comm1.Parameters.Add("fecha", OdbcType.Text).Value = fecha.ToString("yyyy/MM/dd HH:mm:ss");
                comm1.Parameters.Add("proc", OdbcType.Text).Value = "PAGOS";
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

                Frm_consultaTipoPago conPago = new Frm_consultaTipoPago();
                conPago.ShowDialog();

                if (conPago.DialogResult == DialogResult.OK)
                {
                    Txt_idPago.Text = conPago.Dgv_consultaPago.Rows[conPago.Dgv_consultaPago.CurrentRow.Index].
                        Cells[0].Value.ToString();
                    Txt_nombre.Text = conPago.Dgv_consultaPago.Rows[conPago.Dgv_consultaPago.CurrentRow.Index].
                        Cells[1].Value.ToString();
                    Txt_descripcion.Text = conPago.Dgv_consultaPago.Rows[conPago.Dgv_consultaPago.CurrentRow.Index].
                        Cells[2].Value.ToString();


                    Txt_nombre.Focus();
                    presionado = false;
                    HabilitarBtn();
                }
            }
        }

        private void Frm_mantTipoPago_Load(object sender, EventArgs e)
        {
            DeshabilitarCampos();
        }

        private void Lbl_descripcion_Click(object sender, EventArgs e)
        {

        }
    }
}
