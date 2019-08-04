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


namespace Prototipo_Agencia_Turismo.Procesos
{


    public partial class Frm_Nominas : Form
    {
        double totalbono;
        double totaldescuento;
        String nombreUsuario = "";
        Validacion v = new Validacion();
        double var1 = 0;
        String codigo;
        String cantidad;

        String codigoemp;
        String dias;
        String fecha;

        String idbono;
        String iddesc;

        IPHostEntry host;
        string localIP = "?";
        int numale;

        //Creamos un objeto random, simplemente





        DateTime fechai = DateTime.Now;
        public Frm_Nominas(string user)
        {
            InitializeComponent();
            nombreUsuario = user;
            Txt_codempleado.Enabled = false;
            Dtp_FechaEmi.Enabled = false;
            Txt_direccion.Enabled = false;
            Txt_sueldobase.Enabled = false;
            Txt_numerocuenta.Enabled = false;
            Btn_consultaEmp.Enabled = true;
            Gpb_operaciones.Enabled = false;
            totalbono = 0;
            Txt_bono.Visible = false;
            Txt_descuentos.Visible = false;
            Lbl_sueldoliquido.Visible = false;
            Txt_sueldoliquido.Visible = false;
            Txt_codbonos.Visible = false;
            Txt_coddescus.Visible = false;

        }

        public void llenacomboboxbono()
        {

            try
            {
                string consultaMostrar = "SELECT * FROM tbl_bonos_descuentos WHERE Estado='0' AND Bono_Desc='0';";
                OdbcCommand comm = new OdbcCommand(consultaMostrar, Conexion.nuevaConexion());
                OdbcDataReader mostrarDatos = comm.ExecuteReader();

                while (mostrarDatos.Read())
                {
                    Cmb_Bonos.Items.Add(mostrarDatos.GetString(1));
                }

            }
            catch (Exception err)
            {
                Console.Write(err.Message);
            }

        }
        public void llenacomboboxdescuento()
        {

            try
            {
                string consultaMostrar = "SELECT * FROM tbl_bonos_descuentos WHERE Estado='0' AND Bono_Desc='1';";
                OdbcCommand comm = new OdbcCommand(consultaMostrar, Conexion.nuevaConexion());
                OdbcDataReader mostrarDatos = comm.ExecuteReader();

                while (mostrarDatos.Read())
                {
                    Cmb_Descuentos.Items.Add(mostrarDatos.GetString(1));
                }

            }
            catch (Exception err)
            {
                Console.Write(err.Message);
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

        private void ActualizarDatos()
        {
            codigo = Txt_coddoc.Text;
            cantidad = Txt_sueldoliquido.Text;



            try
            {
                OdbcCommand comm = new OdbcCommand("{call Sp_sueldoliquido(?,?)}", Conexion.nuevaConexion());
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.Add("cod", OdbcType.Text).Value = codigo;
                comm.Parameters.Add("cantidad", OdbcType.Text).Value = cantidad;

                comm.ExecuteNonQuery();






            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);

            }
        }

        private void GuardarDatos()
        {
            codigo = Txt_coddoc.Text;
            cantidad = Txt_sueldoliquido.Text;
            codigoemp = Txt_codempleado.Text;
            dias = Txt_dias.Text;
            fecha = Dtp_FechaEmi.Text;



            try
            {
                OdbcCommand comm = new OdbcCommand("{call Sp_InsertarNominaencabezado(?,?,?,?,?)}", Conexion.nuevaConexion());
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.Add("idenca", OdbcType.Text).Value = codigo;
                comm.Parameters.Add("idemp", OdbcType.Text).Value = codigoemp;
                comm.Parameters.Add("dias", OdbcType.Text).Value = dias;
                comm.Parameters.Add("fecha", OdbcType.Text).Value = fecha;
                comm.Parameters.Add("sueldoliquido", OdbcType.Text).Value = cantidad;


                comm.ExecuteNonQuery();

                MessageBox.Show("Registro Guardado correctamente");

                OdbcCommand comm1 = new OdbcCommand("{call SP_InsertarBitacora(?,?,?,?,?)}", Conexion.nuevaConexion());
                comm1.CommandType = CommandType.StoredProcedure;
                comm1.Parameters.Add("ope", OdbcType.Text).Value = "NUEVO REGISTRO";
                comm1.Parameters.Add("usr", OdbcType.Text).Value = nombreUsuario;
                comm1.Parameters.Add("fecha", OdbcType.Text).Value = fechai.ToString("yyyy/MM/dd HH:mm:ss");
                comm1.Parameters.Add("proc", OdbcType.Text).Value = "Proceso Nomina";
                comm1.Parameters.Add("dirIp", OdbcType.Text).Value = localIP;
                comm1.ExecuteNonQuery();




            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                MessageBox.Show("Registro no guardado");

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

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloCodigo(e);
        }

        private void Frm_Nominas_Load(object sender, EventArgs e)
        {
            llenacomboboxbono();
            llenacomboboxdescuento();
            ObtenerIp();

            Random numran = new Random();
            numale = numran.Next(0, 100000);
        }

        private void Btn_consultaPerfil_Click(object sender, EventArgs e)
        {
            Frm_consultaEmpleado consultaEmpleado = new Frm_consultaEmpleado();
            consultaEmpleado.ShowDialog();

            if (consultaEmpleado.DialogResult == DialogResult.OK)
            {
                Txt_codempleado.Text = consultaEmpleado.Dgv_consultaEmpleados.Rows[consultaEmpleado.Dgv_consultaEmpleados.CurrentRow.Index].
                    Cells[0].Value.ToString();
                Txt_numerocuenta.Text = consultaEmpleado.Dgv_consultaEmpleados.Rows[consultaEmpleado.Dgv_consultaEmpleados.CurrentRow.Index].
                    Cells[10].Value.ToString();
                Txt_direccion.Text = consultaEmpleado.Dgv_consultaEmpleados.Rows[consultaEmpleado.Dgv_consultaEmpleados.CurrentRow.Index].
                  Cells[13].Value.ToString();
                Txt_sueldobase.Text = consultaEmpleado.Dgv_consultaEmpleados.Rows[consultaEmpleado.Dgv_consultaEmpleados.CurrentRow.Index].
                  Cells[12].Value.ToString();
            }
        }

        private void Btn_borrar_Click(object sender, EventArgs e)
        {
            Txt_codempleado.Text = "";
            Txt_dias.Text = "";
            Txt_direccion.Text = "";
            Txt_sueldobase.Text = "";
            Txt_numerocuenta.Text = "";
        }

        private void Cmb_Bonos_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string consultaMostrar = "SELECT * FROM tbl_bonos_descuentos WHERE Nombre='" + Cmb_Bonos.Text + "'";
                OdbcCommand comm = new OdbcCommand(consultaMostrar, Conexion.nuevaConexion());
                OdbcDataReader mostrarDatos = comm.ExecuteReader();

                if (mostrarDatos.Read() == true)
                {
                    Txt_bono.Text = mostrarDatos["Valor"].ToString();
                    Txt_codbonos.Text = mostrarDatos["Pk_idBonos_Desc"].ToString();
                }

            }
            catch (Exception err)
            {
                Console.Write(err.Message);
            }

        }

        private void Txt_bono_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cmb_Descuentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string consultaMostrar = "SELECT * FROM tbl_bonos_descuentos WHERE Nombre='" + Cmb_Descuentos.Text + "'";
                OdbcCommand comm = new OdbcCommand(consultaMostrar, Conexion.nuevaConexion());
                OdbcDataReader mostrarDatos = comm.ExecuteReader();

                if (mostrarDatos.Read() == true)
                {
                    Txt_descuentos.Text = mostrarDatos["Valor"].ToString();
                    Txt_coddescus.Text = mostrarDatos["Pk_idBonos_Desc"].ToString();
                }

            }
            catch (Exception err)
            {
                Console.Write(err.Message);
            }


        }

        private void Btn_ingresar_Click(object sender, EventArgs e)
        {
            GuardarDatos();
            Gpb_operaciones.Enabled = true;
            Btn_ingresar.Enabled = false;
            Btn_borrar.Enabled = false;
        }

        private void Btn_ingresarbono_Click(object sender, EventArgs e)
        {
            Random numran = new Random();
            numale = numran.Next(0, 100000);
            Lbl_sueldoliquido.Visible = true;
            Txt_sueldoliquido.Visible = true;
            idbono = Txt_codbonos.Text;

            double bono = Convert.ToDouble(Txt_bono.Text);
            double sueldobase = Convert.ToDouble(Txt_sueldobase.Text);
            totalbono = bono * sueldobase;
            Txt_sueldoliquido.Text = Convert.ToString(totalbono);


            Txt_sueldoliquido.Text = " ";
            double operacion = totalbono + var1;

            Txt_sueldoliquido.Text = Convert.ToString(operacion);
            var1 = Convert.ToDouble(Txt_sueldoliquido.Text);
            ActualizarDatos();

            try
            {
                OdbcCommand comm = new OdbcCommand("{call Sp_InsertarNominadetalle(?,?,?)}", Conexion.nuevaConexion());
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.Add("idenca", OdbcType.Text).Value = codigo;
                comm.Parameters.Add("idliena", OdbcType.Text).Value = numale;
                comm.Parameters.Add("idbono", OdbcType.Text).Value = idbono;

                comm.ExecuteNonQuery();
               
            }

            catch (Exception err)
            {
                Console.WriteLine(err.Message);
               

            }




        }

        private void Btn_ingresardescuento_Click(object sender, EventArgs e)
        {
            Random numran = new Random();
            numale = numran.Next(0, 100000);
            iddesc = Txt_coddescus.Text;
            double descuento = Convert.ToDouble(Txt_descuentos.Text);
            double sueldobase = Convert.ToDouble(Txt_sueldobase.Text);
            totaldescuento = descuento * sueldobase;

            double operacion = var1 - totaldescuento;

            Txt_sueldoliquido.Text = Convert.ToString(operacion);
            var1 = Convert.ToDouble(Txt_sueldoliquido.Text);
            ActualizarDatos();

            try
            {
                OdbcCommand comm = new OdbcCommand("{call Sp_InsertarNominadetalle2(?,?,?)}", Conexion.nuevaConexion());
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.Add("idenca", OdbcType.Text).Value = codigo;
                comm.Parameters.Add("idliena", OdbcType.Text).Value = numale;
                comm.Parameters.Add("idbono", OdbcType.Text).Value = iddesc;

                comm.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);


            }
        }
    }
}
