/* 
 -----------------------------------------------------
            AUTOR: Ivan Mogollón
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
    public partial class Frm_consultaHabitacion : Form
    {
        public Frm_consultaHabitacion()
        {
            InitializeComponent();
        }

        private void MostrarConsulta()
        {
            try
            {
                string consultaMostrar = "SELECT * FROM tbl_tipohabitacion WHERE estadoHabitacion = 1;";
                OdbcCommand comm = new OdbcCommand(consultaMostrar, Conexion.nuevaConexion());
                OdbcDataReader mostrarDatos = comm.ExecuteReader();

                while (mostrarDatos.Read())
                {
                    Dgv_consultaHabitacion.Refresh();
                    Dgv_consultaHabitacion.Rows.Add(mostrarDatos.GetInt32(0), mostrarDatos.GetString(1), mostrarDatos.GetString(2), mostrarDatos.GetInt32(3), mostrarDatos.GetString(4));
                }

            }
            catch (Exception err)
            {
                Console.Write(err.Message);
            }
        }

        private void Frm_consultaHabitacion_Load(object sender, EventArgs e)
        {
            MostrarConsulta();
        }

        private void Btn_min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_cerr_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_busqueda_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Txt_consultaHabitacion.Text.Trim()) == false)
            {
                Dgv_consultaHabitacion.Rows.Clear();
                try
                {
                    string consultaMostrar = "SELECT * FROM tbl_tipohabitacion WHERE nombreHabitacion LIKE ('%" + Txt_consultaHabitacion.Text.Trim() + "%')" + "AND estadoHabitacion=1" + ";";
                    OdbcCommand comm = new OdbcCommand(consultaMostrar, Conexion.nuevaConexion());
                    OdbcDataReader mostrarDatos = comm.ExecuteReader();

                    while (mostrarDatos.Read())
                    {
                        Dgv_consultaHabitacion.Refresh();
                        Dgv_consultaHabitacion.Rows.Add(mostrarDatos.GetString(0), mostrarDatos.GetString(1), mostrarDatos.GetString(2), mostrarDatos.GetString(3), mostrarDatos.GetString(4));
                    }
                }
                catch (Exception err)
                {
                    Console.WriteLine("ERROR:" + err.Message);
                }
            }
        }

        private void Btn_actu_Click(object sender, EventArgs e)
        {
            Dgv_consultaHabitacion.Rows.Clear();
            MostrarConsulta();
        }

        private void Btn_selec_Click(object sender, EventArgs e)
        {
            if (Dgv_consultaHabitacion.Rows.Count == 0)
            {
                return;
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
