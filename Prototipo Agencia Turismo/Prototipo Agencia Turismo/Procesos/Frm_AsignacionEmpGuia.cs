/* 
 -----------------------------------------------------
            AUTOR: Jose Gonzalez
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

namespace Prototipo_Agencia_Turismo.Procesos
{
    public partial class Frm_AsignacionEmpGuia : Form
    {

        String nombreUsuario;
        string localIP = "?";
        DateTime fechai = DateTime.Now;
        String cod_guia;
        String cod_empleado;
        String fechainicio;
        String fechafin;
        String idguia;
        IPHostEntry host;

        String idempleado;
        public Frm_AsignacionEmpGuia(String user)
        {
            InitializeComponent();
            nombreUsuario = user;
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

        private void Frm_AsignacionEmpGuia_Load(object sender, EventArgs e)
        {
            ObtenerIp();
        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            // cod_guia = Txt_Guia.Text;
            //cod_empleado = Txt_idEmpleado.Text;
            fechainicio = Dtp_Fechainicio.Text;
            fechafin = Dtp_Fechafin.Text;

            try
            {
                OdbcCommand comm = new OdbcCommand("{call Sp_Insertarasignacionempguia(?,?,?,?)}", Conexion.nuevaConexion());
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.Add("idempleado", OdbcType.Text).Value = idempleado;
                comm.Parameters.Add("idguia", OdbcType.Text).Value = idguia;
                comm.Parameters.Add("horarioinicio", OdbcType.Text).Value = fechainicio;
                comm.Parameters.Add("horariofin", OdbcType.Text).Value = fechafin;
                comm.ExecuteNonQuery();
                MessageBox.Show("Registro Guardado correctamente");
                comm.Connection.Close();

                OdbcCommand comm1 = new OdbcCommand("{call SP_InsertarBitacora(?,?,?,?,?)}", Conexion.nuevaConexion());
                comm1.CommandType = CommandType.StoredProcedure;
                comm1.Parameters.Add("ope", OdbcType.Text).Value = "REGISTRO INGRESADO";
                comm1.Parameters.Add("usr", OdbcType.Text).Value = nombreUsuario;
                comm1.Parameters.Add("fecha", OdbcType.Text).Value = fechai.ToString("yyyy/MM/dd HH:mm:ss");
                comm1.Parameters.Add("proc", OdbcType.Text).Value = "Asignacion de guia";
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

        private void Btn_ConsultaEmpleado_Click(object sender, EventArgs e)
        {
            Frm_consultaEmpleado consultaEmpleado = new Frm_consultaEmpleado();
            consultaEmpleado.ShowDialog();

            if (consultaEmpleado.DialogResult == DialogResult.OK)
            {
                Txt_idEmpleado.Text = consultaEmpleado.Dgv_consultaEmpleados.Rows[consultaEmpleado.Dgv_consultaEmpleados.CurrentRow.Index].
                    Cells[1].Value.ToString();

                idempleado = consultaEmpleado.Dgv_consultaEmpleados.Rows[consultaEmpleado.Dgv_consultaEmpleados.CurrentRow.Index].
                    Cells[0].Value.ToString();
            }
            Console.WriteLine(idempleado);
        }

        private void Btn_buscarGuia_Click(object sender, EventArgs e)
        {
            Frm_consultaGuiaT consultaguia = new Frm_consultaGuiaT();
            consultaguia.ShowDialog();

            if (consultaguia.DialogResult == DialogResult.OK)
            {
                Txt_Guia.Text = consultaguia.Dgv_consultaBonoYDesc.Rows[consultaguia.Dgv_consultaBonoYDesc.CurrentRow.Index].
                    Cells[1].Value.ToString();

                idguia = consultaguia.Dgv_consultaBonoYDesc.Rows[consultaguia.Dgv_consultaBonoYDesc.CurrentRow.Index].
                    Cells[0].Value.ToString();
            }
            Console.WriteLine(idguia);
        }

        private void Btn_borrar_Click(object sender, EventArgs e)
        {
            cod_guia = Txt_Guia.Text;
            cod_empleado = Txt_idEmpleado.Text;

            try
            {
                OdbcCommand comm = new OdbcCommand("{call Sp_Eliminarasignacionguiaemp(?,?,?)}", Conexion.nuevaConexion());
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.Add("cod", OdbcType.Text).Value = idempleado;
                comm.Parameters.Add("codguia", OdbcType.Text).Value = idguia;
                comm.Parameters.Add("estdo", OdbcType.Text).Value = "1";
                comm.ExecuteNonQuery();
                MessageBox.Show("Registro eliminado correctamente");
                comm.Connection.Close();

                OdbcCommand comm1 = new OdbcCommand("{call SP_InsertarBitacora(?,?,?,?,?)}", Conexion.nuevaConexion());
                comm1.CommandType = CommandType.StoredProcedure;
                comm1.Parameters.Add("ope", OdbcType.Text).Value = "BORRAR ASIGNACION";
                comm1.Parameters.Add("usr", OdbcType.Text).Value = nombreUsuario;
                comm1.Parameters.Add("fecha", OdbcType.Text).Value = fechai.ToString("yyyy/MM/dd HH:mm:ss");
                comm1.Parameters.Add("proc", OdbcType.Text).Value = "Asignacion Guia";
                comm1.Parameters.Add("dirIp", OdbcType.Text).Value = localIP;
                comm1.ExecuteNonQuery();
                comm1.Connection.Close();
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                MessageBox.Show("Error al intentar borrar el registro");
            }
        }

        private void Btn_consultar_Click(object sender, EventArgs e)
        {
            Frm_consultaEmpGuiacs conguia = new Frm_consultaEmpGuiacs();
            conguia.ShowDialog();

            if (conguia.DialogResult == DialogResult.OK)
            {
                idempleado = conguia.Dgv_consultaEmpleadoguia.Rows[conguia.Dgv_consultaEmpleadoguia.CurrentRow.Index].
                      Cells[0].Value.ToString();

                idguia = conguia.Dgv_consultaEmpleadoguia.Rows[conguia.Dgv_consultaEmpleadoguia.CurrentRow.Index].
                    Cells[1].Value.ToString();

                Dtp_Fechainicio.Text = conguia.Dgv_consultaEmpleadoguia.Rows[conguia.Dgv_consultaEmpleadoguia.CurrentRow.Index].
                    Cells[2].Value.ToString();
                Dtp_Fechafin.Text = conguia.Dgv_consultaEmpleadoguia.Rows[conguia.Dgv_consultaEmpleadoguia.CurrentRow.Index].
                   Cells[3].Value.ToString();

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

        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            Txt_Guia.Text = "";
            Txt_idEmpleado.Text = "";
        }
    }
}
