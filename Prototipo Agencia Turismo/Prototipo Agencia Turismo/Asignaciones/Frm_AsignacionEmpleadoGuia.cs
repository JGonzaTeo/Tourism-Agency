
/////////////////////////////////////////////////////////

//Creador José                                          /

/////////////////////////////////////////////////////////

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

namespace Prototipo_Agencia_Turismo.Asignaciones
{
    public partial class Frm_AsignacionEmpleadoGuia : Form
    {
        string nombreUsuario = " ";
        String idempleado;
        String idguia;
        IPHostEntry host;
        string localIP = "?";
        DateTime fechai = DateTime.Now;
        Validacion v = new Validacion();
        bool presionado = false;

       String cod_guia;
       String cod_empleado;
        String fechainicio=" ";
        String fechafin = " ";
        public Frm_AsignacionEmpleadoGuia(String user)
        {
            nombreUsuario = user;
            InitializeComponent();
            Txt_idEmpleado.Enabled = false;
            Txt_Guia.Enabled = false;
            Dtp_Fechafin.Text = " ";
            Dtp_Fechainicio.Text = " ";

        }

        private void Habilitarcampos()
        {

            Txt_Guia.Enabled = true;
            Txt_idEmpleado.Enabled = true;

        }


        private void Deshabilitarcampos()
        {

            Txt_idEmpleado.Enabled = false;
            Txt_Guia.Enabled = false;
        }

        private void Habilitarbtn()
        {
            Btn_ingresar.Enabled = true;
            Btn_guardar.Enabled = true;
            Btn_borrar.Enabled = true;
            Btn_consultar.Enabled = true;
            Btn_buscarGuia.Enabled = true;
            Btn_ConsultaEmpleado.Enabled = true;
        }

        private void Desahiblitarbtn()
        {
            Btn_ingresar.Enabled = false;
            Btn_guardar.Enabled = false;
            Btn_borrar.Enabled = false;
            Btn_consultar.Enabled = false;
            Btn_buscarGuia.Enabled = false;
            Btn_ConsultaEmpleado.Enabled = false;
        }

        private void Limpiar()
        {
            Txt_idEmpleado.Text = " ";
            Txt_Guia.Text = " ";
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

       private void ActualizarDatos()
        {
         /*   cod_guia = Txt_Guia.Text;
            cod_empleado = Txt_idEmpleado.Text;

            try
            {
                OdbcCommand comm = new OdbcCommand("{call  Sp_Modificarguia(?,?,?)}", Conexion.nuevaConexion());
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.Add("cod", OdbcType.Text).Value = cod_guia;
                comm.Parameters.Add("rut", OdbcType.Text).Value = ruta;
                comm.Parameters.Add("descrip", OdbcType.Text).Value = descripcion;
                comm.ExecuteNonQuery();
                MessageBox.Show("Registro actualizado correctamente");

                OdbcCommand comm1 = new OdbcCommand("{call SP_InsertarBitacora(?,?,?,?,?)}", Conexion.nuevaConexion());
                comm1.CommandType = CommandType.StoredProcedure;
                comm1.Parameters.Add("ope", OdbcType.Text).Value = "REGISTRO Modificado";
                comm1.Parameters.Add("usr", OdbcType.Text).Value = nombreUsuario;
                comm1.Parameters.Add("fecha", OdbcType.Text).Value = fechai.ToString("yyyy/MM/dd HH:mm:ss");
                comm1.Parameters.Add("proc", OdbcType.Text).Value = "Guia Turistico";
                comm1.Parameters.Add("dirIp", OdbcType.Text).Value = localIP;
                comm1.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                MessageBox.Show("Error al intentar actualizar el registro");
            }*/
        }


        private void Guardardatos()
        {
            cod_guia = Txt_Guia.Text;
            cod_empleado = Txt_idEmpleado.Text;
            fechainicio = Dtp_Fechainicio.Text;
            fechafin = Dtp_Fechafin.Text;

            try
            {
                OdbcCommand comm = new OdbcCommand("{call Sp_Insertarasignacionempguia(?,?,?,?)}", Conexion.nuevaConexion());
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.Add("idempleado", OdbcType.Text).Value = idguia;
                comm.Parameters.Add("idguia", OdbcType.Text).Value = idempleado;
                comm.Parameters.Add("horarioinicio", OdbcType.Text).Value = fechainicio;
                comm.Parameters.Add("horariofin", OdbcType.Text).Value = fechafin;
                comm.ExecuteNonQuery();
                MessageBox.Show("Registro Guardado correctamente");

                OdbcCommand comm1 = new OdbcCommand("{call SP_InsertarBitacora(?,?,?,?,?)}", Conexion.nuevaConexion());
                comm1.CommandType = CommandType.StoredProcedure;
                comm1.Parameters.Add("ope", OdbcType.Text).Value = "REGISTRO INGRESADO";
                comm1.Parameters.Add("usr", OdbcType.Text).Value = nombreUsuario;
                comm1.Parameters.Add("fecha", OdbcType.Text).Value = fechai.ToString("yyyy/MM/dd HH:mm:ss");
                comm1.Parameters.Add("proc", OdbcType.Text).Value = "Asignacion de guia";
                comm1.Parameters.Add("dirIp", OdbcType.Text).Value = localIP;
                comm1.ExecuteNonQuery();

            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                MessageBox.Show("Error al intentar actualizar el registro");
            }
        }

       private void Borrardatos()
        {
        /*    cod_guia = Txt_idguia.Text;

            try
            {
                OdbcCommand comm = new OdbcCommand("{call Sp_Eliminarguia(?,?)}", Conexion.nuevaConexion());
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.Add("cod", OdbcType.Text).Value = cod_guia;
                comm.Parameters.Add("estdo", OdbcType.Text).Value = "1";
                comm.ExecuteNonQuery();
                MessageBox.Show("Registro eliminado correctamente");

                OdbcCommand comm1 = new OdbcCommand("{call SP_InsertarBitacora(?,?,?,?,?)}", Conexion.nuevaConexion());
                comm1.CommandType = CommandType.StoredProcedure;
                comm1.Parameters.Add("ope", OdbcType.Text).Value = "BORRAR REGISTRO";
                comm1.Parameters.Add("usr", OdbcType.Text).Value = nombreUsuario;
                comm1.Parameters.Add("fecha", OdbcType.Text).Value = fechai.ToString("yyyy/MM/dd HH:mm:ss");
                comm1.Parameters.Add("proc", OdbcType.Text).Value = "Guia Truristico";
                comm1.Parameters.Add("dirIp", OdbcType.Text).Value = localIP;
                comm1.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                MessageBox.Show("Error al intentar borrar el registro");
            }*/
        }

        private void Lbl_titulo_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_idempleado_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_consultaEmpleado consultaEmpleado = new Frm_consultaEmpleado();
            consultaEmpleado.ShowDialog();

            if (consultaEmpleado.DialogResult == DialogResult.OK)
            {
                Txt_idEmpleado.Text = consultaEmpleado.Dgv_consultaEmpleados.Rows[consultaEmpleado.Dgv_consultaEmpleados.CurrentRow.Index].
                    Cells[1].Value.ToString();

                idempleado=consultaEmpleado.Dgv_consultaEmpleados.Rows[consultaEmpleado.Dgv_consultaEmpleados.CurrentRow.Index].
                    Cells[0].Value.ToString();
            }
            MessageBox.Show(idempleado);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Frm_AsignacionEmpleadoGuia_Load(object sender, EventArgs e)
        {
            DateTime date1 = new DateTime();
            DateTime date2 = new DateTime();
            //int result = DateTime.Compare(Dtp_Fechainicio, date2);
            ObtenerIp();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Frm_consultaGuiaT consultaguia = new Frm_consultaGuiaT();
            consultaguia.ShowDialog();

            if (consultaguia.DialogResult == DialogResult.OK)
            {
                Txt_Guia.Text = consultaguia.Dgv_consultaguia.Rows[consultaguia.Dgv_consultaguia.CurrentRow.Index].
                    Cells[1].Value.ToString();

                idguia = consultaguia.Dgv_consultaguia.Rows[consultaguia.Dgv_consultaguia.CurrentRow.Index].
                    Cells[0].Value.ToString();
            }
            MessageBox.Show(idguia);
        }

        private void Btn_ingresar_Click(object sender, EventArgs e)
        {
            Habilitarcampos();
        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            if (presionado == false)
            {
                Desahiblitarbtn();
                Btn_guardar.Enabled = true;
                presionado = true;
            }
            else
            {
                Guardardatos();
                Txt_Guia.Focus();
                presionado = false;
                Deshabilitarcampos();
                Habilitarbtn();
                Limpiar();

            }
        }

        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
            presionado = false;
            Habilitarbtn();
        }

        private void Btn_borrar_Click(object sender, EventArgs e)
        {
            if (presionado == false)
            {
                Desahiblitarbtn();
                Btn_borrar.Enabled = true;
                presionado = true;
            }
            else
            {
                Borrardatos();
                Txt_Guia.Focus();
                presionado = false;
                Deshabilitarcampos();
                Habilitarbtn();
                Limpiar();
            }
        }

        private void Btn_consultar_Click(object sender, EventArgs e)
        {
            if (presionado == false)
            {
                Desahiblitarbtn();
                Btn_consultar.Enabled = true;
                presionado = true;
            }
            else
            {
                Frm_consultaGuiaT conBonos_Desc = new Frm_consultaGuiaT();
                conBonos_Desc.ShowDialog();

                if (conBonos_Desc.DialogResult == DialogResult.OK)
                {
                  /*Txt_idguia.Text = conBonos_Desc.Dgv_consultaguia.Rows[conBonos_Desc.Dgv_consultaguia.CurrentRow.Index].
                        Cells[0].Value.ToString();

                    Txt_ruta.Text = conBonos_Desc.Dgv_consultaguia.Rows[conBonos_Desc.Dgv_consultaguia.CurrentRow.Index].
                        Cells[1].Value.ToString();

                    Txt_descripcion.Text = conBonos_Desc.Dgv_consultaguia.Rows[conBonos_Desc.Dgv_consultaguia.CurrentRow.Index].
                        Cells[2].Value.ToString();



                    Txt_idguia.Focus();
                    presionado = false;
                    Habilitarbtn();*/
                }
            }
        }
    }
}
