/* 
 -----------------------------------------------------
            AUTOR: José Gonzalez
  -----------------------------------------------------
*/


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototipo_Agencia_Turismo.Consulta
{
    public partial class Frm_consultaEmpleado : Form
    {
        String nombre;
        public Frm_consultaEmpleado()
        {
            InitializeComponent();
        }
        private void MostrarConsulta()
        {
            try
            {
                string consultaMostrar = "SELECT * FROM tbl_empleado WHERE Estado='0';";
                OdbcCommand comm = new OdbcCommand(consultaMostrar, Conexion.nuevaConexion());
                OdbcDataReader mostrarDatos = comm.ExecuteReader();

                while (mostrarDatos.Read())
                {
                    Dgv_consultaEmpleados.Refresh();
                    Dgv_consultaEmpleados.Rows.Add(mostrarDatos.GetString(0), mostrarDatos.GetString(1), mostrarDatos.GetString(2),
                             mostrarDatos.GetString(3), mostrarDatos.GetString(4), mostrarDatos.GetString(5), mostrarDatos.GetString(6),
                              mostrarDatos.GetString(7), mostrarDatos.GetString(8), mostrarDatos.GetString(9), mostrarDatos.GetString(10),
                               mostrarDatos.GetString(11), mostrarDatos.GetString(12), mostrarDatos.GetString(13));
                }
                comm.Connection.Close();
                mostrarDatos.Close();
            }
            catch (Exception err)
            {
                Console.Write(err.Message);
            }
        }

        private void Frm_consultaEmpleado_Load(object sender, EventArgs e)
        {
            MostrarConsulta();
        }

        private void Btn_consulta_Click(object sender, EventArgs e)
        {
            Dgv_consultaEmpleados.Rows.Clear();
            nombre = Txt_consultaEmpleado.Text;
            try
            {
                OdbcCommand comm = new OdbcCommand("{call Sp_Buscarempleado(?)}", Conexion.nuevaConexion());
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.Add("nom", OdbcType.Text).Value = nombre;
                OdbcDataReader mostrarDatos = comm.ExecuteReader();

                while (mostrarDatos.Read())
                {
                    Dgv_consultaEmpleados.Refresh();
                    Dgv_consultaEmpleados.Rows.Add(mostrarDatos.GetString(0), mostrarDatos.GetString(1), mostrarDatos.GetString(2),
                             mostrarDatos.GetString(3), mostrarDatos.GetString(4), mostrarDatos.GetString(5), mostrarDatos.GetString(6),
                              mostrarDatos.GetString(7), mostrarDatos.GetString(8), mostrarDatos.GetString(9), mostrarDatos.GetString(10),
                               mostrarDatos.GetString(11), mostrarDatos.GetString(12), mostrarDatos.GetString(13));
                }
                comm.Connection.Close();
                mostrarDatos.Close();
            }

            catch (Exception err)
            {
                Console.WriteLine("ERROR:" + err.Message);
            }
        }

        private void Btn_actualizar_Click(object sender, EventArgs e)
        {
            Dgv_consultaEmpleados.Rows.Clear();
            MostrarConsulta();
        }

        private void Btn_seleccionar_Click(object sender, EventArgs e)
        {
            if (Dgv_consultaEmpleados.Rows.Count == 0)
            {
                return;
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_ayuda_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "C:\\Ayudas Agencia Turismo.chm");
        }
    }
}
