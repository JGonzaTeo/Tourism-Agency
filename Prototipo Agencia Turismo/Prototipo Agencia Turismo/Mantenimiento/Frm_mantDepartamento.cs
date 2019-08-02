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
    public partial class Frm_mantDepartamento : Form
    {
        string usuario = " ";
        DateTime fecha = DateTime.Now;
        bool presionado = false;

        string id = "";
        string nombreDepartamento = "";
        string descripcionDepartamento = "";


       
        public Frm_mantDepartamento(string nombreUsuario)
        {
            InitializeComponent();
            usuario = nombreUsuario;
        }

        private void limpiar()
        {
            Txt_id.Text = "";
            Txt_descripcion.Text = "";
            Txt_nombre.Text = "";
        }

        private void HabilitarCampos()
        {
            Txt_descripcion.Enabled = true;
            Txt_nombre.Enabled = true;
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
            
            Txt_nombre.Enabled = false;
            Txt_descripcion.Enabled = false;
        }

        private void GuardarDatos()
        {
            nombreDepartamento = Txt_nombre.Text;
            descripcionDepartamento = Txt_descripcion.Text;
            

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
                OdbcCommand comm = new OdbcCommand("{call SP_InsertarDepartamento(?,?)}", Conexion.nuevaConexion());
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.Add("Nombre", OdbcType.Text).Value = nombreDepartamento;
                comm.Parameters.Add("Descripcion", OdbcType.Text).Value = descripcionDepartamento;
                comm.ExecuteNonQuery();
                MessageBox.Show("Registro guardado correctamente");

                OdbcCommand commBitacora = new OdbcCommand("{call SP_InsertarBitacora(?,?,?,?,?)}", Conexion.nuevaConexion());
                commBitacora.CommandType = CommandType.StoredProcedure;
                commBitacora.Parameters.Add("ope", OdbcType.Text).Value = "INGRESO DE REGISTRO";
                commBitacora.Parameters.Add("usr", OdbcType.Text).Value = usuario;
                commBitacora.Parameters.Add("fecha", OdbcType.Text).Value = fecha.ToString("yyyy/MM/dd HH:mm:ss");
                commBitacora.Parameters.Add("proc", OdbcType.Text).Value = "DEPARTAMENTOS";
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
            nombreDepartamento = Txt_nombre.Text;
            id = Txt_id.Text;
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
                OdbcCommand comm = new OdbcCommand("{call SP_EliminarDepartamento(?)}", Conexion.nuevaConexion());
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.Add("Nombre", OdbcType.Text).Value = nombreDepartamento;
                comm.ExecuteNonQuery();

                string consulta2 = "UPDATE tbl_lugarturistico T " +
                 "INNER JOIN tbl_departamentos D ON T.Fk_idDepartamento = D.Pk_idDepartamento " +
                 "SET M.estadoLugarTuristico = 0 " +
                 "WHERE T.Fk_idDepartamento =" + id + "; ";
                OdbcCommand comm2 = new OdbcCommand(consulta2, Conexion.nuevaConexion());
                comm2.ExecuteNonQuery();

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
            id = Txt_id.Text;
            nombreDepartamento = Txt_nombre.Text;
            descripcionDepartamento = Txt_descripcion.Text;

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
                OdbcCommand comm = new OdbcCommand("{call SP_ActualizarDepartamento(?,?)}", Conexion.nuevaConexion());
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.Add("Nombre", OdbcType.Text).Value = nombreDepartamento;
                comm.Parameters.Add("Departamento", OdbcType.Text).Value = descripcionDepartamento;
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

        private void Btn_minimizar1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_cerrar1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_ingresar_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
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
                Txt_id.Focus();
                presionado = false;
                DeshabilitarCampos();
                HabilitarBtn();
                limpiar();
            }
        }

        private void Btn_editar_Click(object sender, EventArgs e)
        {
            if (presionado == false)
            {
                DeshabilitarBtn();
                Btn_editar.Enabled = true;
                presionado = true;
                Txt_nombre.Enabled = false;
            }
            else
            {
                ActualizarDatos();
                Txt_nombre.Focus();
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
                Txt_nombre.Focus();
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
                Consulta.Frm_consultaDepartamento conDepartamento = new Consulta.Frm_consultaDepartamento();
                conDepartamento.ShowDialog();

                if (conDepartamento.DialogResult == DialogResult.OK)
                {
                    Txt_id.Text =
                        conDepartamento.Dgv_consultaDepartamento.Rows[conDepartamento.Dgv_consultaDepartamento.CurrentRow.Index].
                        Cells[0].Value.ToString();

                    Txt_nombre.Text =
                        conDepartamento.Dgv_consultaDepartamento.Rows[conDepartamento.Dgv_consultaDepartamento.CurrentRow.Index].
                        Cells[1].Value.ToString();

                    Txt_descripcion.Text =
                        conDepartamento.Dgv_consultaDepartamento.Rows[conDepartamento.Dgv_consultaDepartamento.CurrentRow.Index].
                        Cells[2].Value.ToString();

                    Txt_id.Focus();
                    presionado = false;
                    HabilitarBtn();
                }
            }
        }

        private void Frm_mantDepartamento_Load(object sender, EventArgs e)
        {
            Btn_editar.Enabled = false;
            Btn_guardar.Enabled = false;
            Btn_borrar.Enabled = false;
        }
    }
}
