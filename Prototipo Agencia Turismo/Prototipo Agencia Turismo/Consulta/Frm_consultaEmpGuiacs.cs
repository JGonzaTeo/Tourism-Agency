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
    public partial class Frm_consultaEmpGuiacs : Form
    {
        String nombre;
        public Frm_consultaEmpGuiacs()
        {
            InitializeComponent();
        }
        private void MostrarConsulta()
        {
            try
            {
                string consultaMostrar = "SELECT * FROM tbl_asignacionempleadoaguia WHERE Estado='0';";
                OdbcCommand comm = new OdbcCommand(consultaMostrar, Conexion.nuevaConexion());
                OdbcDataReader mostrarDatos = comm.ExecuteReader();

                while (mostrarDatos.Read())
                {
                    Dgv_consultaEmpleadoguia.Refresh();
                    Dgv_consultaEmpleadoguia.Rows.Add(mostrarDatos.GetString(0), mostrarDatos.GetString(1), mostrarDatos.GetString(2),
                        mostrarDatos.GetString(3));
                }
            
            }
            catch (Exception err)
            {
                Console.Write(err.Message);
            }
        }
        private void Frm_consultaEmpGuiacs_Load(object sender, EventArgs e)
        {
            MostrarConsulta();
        }

        private void Btn_seleccionar_Click(object sender, EventArgs e)
        {
            if (Dgv_consultaEmpleadoguia.Rows.Count == 0)
            {
                return;
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void Btn_consulta_Click(object sender, EventArgs e)
        {

            Dgv_consultaEmpleadoguia.Rows.Clear();
            nombre = Txt_consultaGuiaturistico.Text;
            try
            {
                OdbcCommand comm = new OdbcCommand("{call Sp_Buscarempleadoguia(?)}", Conexion.nuevaConexion());
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.Add("nom", OdbcType.Text).Value = nombre;
                OdbcDataReader mostrarDatos = comm.ExecuteReader();

                while (mostrarDatos.Read())
                {
                    Dgv_consultaEmpleadoguia.Refresh();
                    Dgv_consultaEmpleadoguia.Rows.Add(mostrarDatos.GetString(0), mostrarDatos.GetString(1), mostrarDatos.GetString(2),
                             mostrarDatos.GetString(3));
                }
            }

            catch (Exception err)
            {
                Console.WriteLine("ERROR:" + err.Message);
            }


        }

        private void Btn_actualizar_Click(object sender, EventArgs e)
        {
            MostrarConsulta();
        }

        private void Btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
 }

