/* 
 -----------------------------------------------------
            AUTOR: José Gonzalez
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

namespace Prototipo_Agencia_Turismo.Mantenimiento
{
 
    public partial class Frm_mantEmpleado : Form
    {
        IPHostEntry host;
        string localIP = "?";
        string nombreUsuario = " ";
        DateTime fechai = DateTime.Now;
        Validacion v = new Validacion();
        bool presionado = false;
        String nombre;
        String apellido;
        String fechanac = " ";
        String correo;
        String telefono;
        String dpi;
        String cuentabancaria;
        String nit;
        String usuario;
        String sueldobase;
        String direccion;
        String departamento;
        String codigo;

    

        DateTime fecha;
        public Frm_mantEmpleado(String user)
        {
            InitializeComponent();
            nombreUsuario = user;
            Txt_nombre.Enabled = false;
            Txt_apellido.Enabled = false;
            Dtp_FechaNc.Enabled = false;
            Txt_correo.Enabled = false;
            Txt_telefono.Enabled = false;
            Txt_dpi.Enabled = false;
            Txt_cuentaBancaria.Enabled = false;
            Txt_nit.Enabled = false;
            Txt_usuario.Enabled = false;
            Txt_sueldoBase.Enabled = false;
            Txt_direccion.Enabled = false;
            Txt_departamento.Enabled = false;
            Btn_consultaPerfil.Enabled = true;
            nombreUsuario = usuario;
         
        }

        private void Habilitarcampos()
        {

            Txt_nombre.Enabled = true;
            Txt_apellido.Enabled = true;
            Dtp_FechaNc.Enabled = true;
            Txt_correo.Enabled = true;
            Txt_telefono.Enabled = true;
            Txt_dpi.Enabled = true;
            Txt_cuentaBancaria.Enabled = true;
            Txt_nit.Enabled = true;
            Txt_usuario.Enabled = true;
            Txt_sueldoBase.Enabled = true;
            Txt_direccion.Enabled = true;
            Txt_departamento.Enabled = true;

        }


        private void Deshabilitarcampos()
        {

            Txt_nombre.Enabled = false;
            Txt_apellido.Enabled = false;
            Dtp_FechaNc.Enabled = false;
            Txt_correo.Enabled = false;
            Txt_telefono.Enabled = false;
            Txt_dpi.Enabled = false;
            Txt_cuentaBancaria.Enabled = false;
            Txt_nit.Enabled = false;
            Txt_usuario.Enabled = false;
            Txt_sueldoBase.Enabled = false;
            Txt_direccion.Enabled = false;
            Txt_departamento.Enabled = false;
        }

        private void Habilitarbtn()
        {
            Btn_ingresar.Enabled = true;
            Btn_editar.Enabled = true;
            Btn_guardar.Enabled = true;
            Btn_borrar.Enabled = true;
            Btn_consultar.Enabled = true;
            Btn_consultaPerfil.Enabled = true;
        }

        private void Desahiblitarbtn()
        {
            Btn_ingresar.Enabled = false;
            Btn_editar.Enabled = false;
            Btn_guardar.Enabled = false;
            Btn_borrar.Enabled = false;
            Btn_consultar.Enabled = false;
        }

        private void Limpiar()
        {
            Txt_nombre.Text = " ";
            Txt_apellido.Text = "";
            Dtp_FechaNc.Text = "";
            Txt_correo.Text = "";
            Txt_telefono.Text = "";
            Txt_dpi.Text = "";
            Txt_cuentaBancaria.Text = "";
            Txt_nit.Text = "";
            Txt_usuario.Text = "";
            Txt_sueldoBase.Text = "";
            Txt_direccion.Text = "";
            Txt_departamento.Text = "";
        }

        private void ActualizarDatos()
        {
            nombre = Txt_nombre.Text;
            apellido = Txt_apellido.Text;
            fechanac = Dtp_FechaNc.Text;
            correo = Txt_correo.Text;
            telefono = Txt_telefono.Text;
            dpi = Txt_dpi.Text;
            cuentabancaria = Txt_cuentaBancaria.Text;
            nit = Txt_nit.Text;
            usuario = Txt_usuario.Text;
            sueldobase = Txt_sueldoBase.Text;
            direccion = Txt_direccion.Text;
            departamento = Txt_departamento.Text;


            try
            {
                OdbcCommand comm = new OdbcCommand("{call Sp_Modificarempleado(?,?,?,?,?,?,?,?,?,?,?,?,?)}", Conexion.nuevaConexion());
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.Add("cod", OdbcType.Text).Value = codigo;
                comm.Parameters.Add("nombre", OdbcType.Text).Value = nombre;
                comm.Parameters.Add("apellido", OdbcType.Text).Value = apellido;
                comm.Parameters.Add("fechanac", OdbcType.Text).Value = fechanac;
                comm.Parameters.Add("corr", OdbcType.Text).Value = correo;
                comm.Parameters.Add("tel", OdbcType.Text).Value = telefono;
                comm.Parameters.Add("dpi", OdbcType.Text).Value = dpi;
                comm.Parameters.Add("usu", OdbcType.Text).Value = usuario;
                comm.Parameters.Add("cuentabancaria", OdbcType.Text).Value = cuentabancaria;
                comm.Parameters.Add("nit", OdbcType.Text).Value = nit;
                comm.Parameters.Add("sueldobase", OdbcType.Text).Value = sueldobase;
                comm.Parameters.Add("dir", OdbcType.Text).Value = direccion;
                comm.Parameters.Add("dep", OdbcType.Text).Value = departamento;
                comm.ExecuteNonQuery();
                MessageBox.Show("Registro actualizado correctamente");

                OdbcCommand comm1 = new OdbcCommand("{call SP_InsertarBitacora(?,?,?,?,?)}", Conexion.nuevaConexion());
                comm1.CommandType = CommandType.StoredProcedure;
                comm1.Parameters.Add("ope", OdbcType.Text).Value = "MODIFICAR";
                comm1.Parameters.Add("usr", OdbcType.Text).Value = nombreUsuario;
                comm1.Parameters.Add("fecha", OdbcType.Text).Value = fechai.ToString("yyyy/MM/dd HH:mm:ss");
                comm1.Parameters.Add("proc", OdbcType.Text).Value = "Empleado";
                comm1.Parameters.Add("dirIp", OdbcType.Text).Value = localIP;
                comm1.ExecuteNonQuery();



            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                MessageBox.Show("Error al intentar actualizar el registro");
            }
        }


        private void Guardardatos()
        {
            nombre = Txt_nombre.Text;
            apellido = Txt_apellido.Text;
            fechanac = Dtp_FechaNc.Text;
            correo = Txt_correo.Text;
            telefono = Txt_telefono.Text;
            dpi = Txt_dpi.Text;
            cuentabancaria = Txt_cuentaBancaria.Text;
            nit = Txt_nit.Text;
            usuario = Txt_usuario.Text;
            sueldobase = Txt_sueldoBase.Text;
            direccion = Txt_direccion.Text;
            departamento = Txt_departamento.Text;

            try
            {
                OdbcCommand comm = new OdbcCommand("{call Sp_Insertarempleado(?,?,?,?,?,?,?,?,?,?,?,?,?)}", Conexion.nuevaConexion());
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.Add("nombre", OdbcType.Text).Value = nombre;
                comm.Parameters.Add("apellido", OdbcType.Text).Value = apellido;
                comm.Parameters.Add("fechanac", OdbcType.Text).Value = fechanac;
                comm.Parameters.Add("corr", OdbcType.Text).Value = correo;
                comm.Parameters.Add("tel", OdbcType.Text).Value = telefono;
                comm.Parameters.Add("dpi", OdbcType.Text).Value = dpi;
                comm.Parameters.Add("usu", OdbcType.Text).Value = usuario;
                comm.Parameters.Add("cuentabancaria", OdbcType.Text).Value = cuentabancaria;
                comm.Parameters.Add("nit", OdbcType.Text).Value = nit;
                comm.Parameters.Add("sueldobase", OdbcType.Text).Value = sueldobase;
                comm.Parameters.Add("dir", OdbcType.Text).Value = direccion;
                comm.Parameters.Add("dep", OdbcType.Text).Value = departamento;
                comm.Parameters.Add("estado", OdbcType.Text).Value = "0";
                comm.ExecuteNonQuery();
                MessageBox.Show("Registro Guardado correctamente");

                OdbcCommand comm1 = new OdbcCommand("{call SP_InsertarBitacora(?,?,?,?,?)}", Conexion.nuevaConexion());
                comm1.CommandType = CommandType.StoredProcedure;
                comm1.Parameters.Add("ope", OdbcType.Text).Value = "NUEVO REGISTRO";
                comm1.Parameters.Add("usr", OdbcType.Text).Value = nombreUsuario;
                comm1.Parameters.Add("fecha", OdbcType.Text).Value = fechai.ToString("yyyy/MM/dd HH:mm:ss");
                comm1.Parameters.Add("proc", OdbcType.Text).Value = "Empleado";
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


            try
            {
                OdbcCommand comm = new OdbcCommand("{call Sp_Eliminarempleado(?)}", Conexion.nuevaConexion());
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.Add("cod", OdbcType.Text).Value = codigo;
                comm.ExecuteNonQuery();
                MessageBox.Show("Registro eliminado correctamente");

                OdbcCommand comm1 = new OdbcCommand("{call SP_InsertarBitacora(?,?,?,?,?)}", Conexion.nuevaConexion());
                comm1.CommandType = CommandType.StoredProcedure;
                comm1.Parameters.Add("ope", OdbcType.Text).Value = "REGISTRO BORRADO";
                comm1.Parameters.Add("usr", OdbcType.Text).Value = nombreUsuario;
                comm1.Parameters.Add("fecha", OdbcType.Text).Value = fechai.ToString("yyyy/MM/dd HH:mm:ss");
                comm1.Parameters.Add("proc", OdbcType.Text).Value = "Empleado";
                comm1.Parameters.Add("dirIp", OdbcType.Text).Value = localIP;
                comm1.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                MessageBox.Show("Error al intentar borrar el registro");
            }
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

        private void Frm_mantEmpleado_Load(object sender, EventArgs e)
        {
            ObtenerIp();
        }

        private void Btn_ingresar_Click(object sender, EventArgs e)
        {
            Habilitarcampos();
        }

        private void Btn_editar_Click(object sender, EventArgs e)
        {

            if (presionado == false)
            {
                Desahiblitarbtn();
                Btn_editar.Enabled = true;
                presionado = true;
                Txt_nombre.Enabled = false;
            }
            else
            {
                ActualizarDatos();
                Txt_nombre.Focus();
                presionado = false;
                Deshabilitarcampos();
                Habilitarbtn();
                Limpiar();
            }
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
                Txt_nombre.Focus();
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
                Txt_nombre.Focus();
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
                Frm_consultaEmpleado con_Emp = new Frm_consultaEmpleado();
                con_Emp.ShowDialog();

                if (con_Emp.DialogResult == DialogResult.OK)
                {
                    codigo = con_Emp.Dgv_consultaEmpleados.Rows[con_Emp.Dgv_consultaEmpleados.CurrentRow.Index].
                        Cells[0].Value.ToString();

                    Txt_nombre.Text = con_Emp.Dgv_consultaEmpleados.Rows[con_Emp.Dgv_consultaEmpleados.CurrentRow.Index].
                        Cells[1].Value.ToString();

                    Txt_apellido.Text = con_Emp.Dgv_consultaEmpleados.Rows[con_Emp.Dgv_consultaEmpleados.CurrentRow.Index].
                        Cells[2].Value.ToString();

                    Dtp_FechaNc.Text = con_Emp.Dgv_consultaEmpleados.Rows[con_Emp.Dgv_consultaEmpleados.CurrentRow.Index].
                      Cells[3].Value.ToString();

                    Txt_correo.Text = con_Emp.Dgv_consultaEmpleados.Rows[con_Emp.Dgv_consultaEmpleados.CurrentRow.Index].
                      Cells[4].Value.ToString();

                    Txt_telefono.Text = con_Emp.Dgv_consultaEmpleados.Rows[con_Emp.Dgv_consultaEmpleados.CurrentRow.Index].
                      Cells[5].Value.ToString();

                    Txt_dpi.Text = con_Emp.Dgv_consultaEmpleados.Rows[con_Emp.Dgv_consultaEmpleados.CurrentRow.Index].
                      Cells[6].Value.ToString();

                    Txt_usuario.Text = con_Emp.Dgv_consultaEmpleados.Rows[con_Emp.Dgv_consultaEmpleados.CurrentRow.Index].
                     Cells[7].Value.ToString();

                    Txt_cuentaBancaria.Text = con_Emp.Dgv_consultaEmpleados.Rows[con_Emp.Dgv_consultaEmpleados.CurrentRow.Index].
                     Cells[8].Value.ToString();

                    Txt_nit.Text = con_Emp.Dgv_consultaEmpleados.Rows[con_Emp.Dgv_consultaEmpleados.CurrentRow.Index].
                     Cells[9].Value.ToString();

                    Txt_sueldoBase.Text = con_Emp.Dgv_consultaEmpleados.Rows[con_Emp.Dgv_consultaEmpleados.CurrentRow.Index].
                      Cells[10].Value.ToString();

                    Txt_direccion.Text = con_Emp.Dgv_consultaEmpleados.Rows[con_Emp.Dgv_consultaEmpleados.CurrentRow.Index].
                      Cells[11].Value.ToString();

                    Txt_departamento.Text = con_Emp.Dgv_consultaEmpleados.Rows[con_Emp.Dgv_consultaEmpleados.CurrentRow.Index].
                      Cells[12].Value.ToString();




                    Txt_nombre.Focus();
                    presionado = false;
                    Habilitarbtn();
                }
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

 

        private void Btn_consultaPerfil_Click(object sender, EventArgs e)
        {
            Frm_consultaUsuario consultaUsuario = new Frm_consultaUsuario();
            consultaUsuario.ShowDialog();

            if (consultaUsuario.DialogResult == DialogResult.OK)
            {
                Txt_usuario.Text = consultaUsuario.Dgv_consultaUsuario.Rows[consultaUsuario.Dgv_consultaUsuario.CurrentRow.Index].
                    Cells[0].Value.ToString();
            }
        }

        private void Txt_nombre_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void Txt_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloLetra(e);
        }

        private void Txt_apellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloLetra(e);
        }

        private void Txt_telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloCodigo(e);
        }

        private void Txt_dpi_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloCodigo(e);
        }

        private void Txt_cuentaBancaria_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloCodigo(e);
        }

        private void Txt_nit_KeyDown(object sender, KeyEventArgs e)
        {
         
        }

        private void Txt_sueldoBase_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloNumero(e);
        }

        private void Txt_direccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.Numerosletras(e);
        }

        private void Txt_departamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloLetra(e);
        }

        private void Txt_nit_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.Numerosletras(e);
        }
    }
}
