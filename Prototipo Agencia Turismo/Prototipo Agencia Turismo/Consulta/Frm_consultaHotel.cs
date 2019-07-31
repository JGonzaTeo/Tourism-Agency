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
    public partial class Frm_consultaHotel : Form
    {
        public Frm_consultaHotel()
        {
            InitializeComponent();
        }
        private void MostrarConsulta()
        {
            try
            {
                string consultaMostrar = "SELECT * FROM tbl_hoteles WHERE estadoHotel = 1;";
                OdbcCommand comm = new OdbcCommand(consultaMostrar, Conexion.nuevaConexion());
                OdbcDataReader mostrarDatos = comm.ExecuteReader();

                while (mostrarDatos.Read())
                {
                    Dgv_consultaHotel.Refresh();
                    Dgv_consultaHotel.Rows.Add(mostrarDatos.GetInt32(0), mostrarDatos.GetString(1), mostrarDatos.GetString(2), mostrarDatos.GetInt32(3), mostrarDatos.GetString(4));
                }

            }
            catch (Exception err)
            {
                Console.Write(err.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Txt_consultaHotel.Text.Trim()) == false)
            {
                Dgv_consultaHotel.Rows.Clear();
                try
                {
                    string consultaMostrar = "SELECT * FROM tbl_hoteles WHERE NombreHotel LIKE ('%" + Txt_consultaHotel.Text.Trim() + "%')" + "AND estadoHotel=1" + ";";
                    OdbcCommand comm = new OdbcCommand(consultaMostrar, Conexion.nuevaConexion());
                    OdbcDataReader mostrarDatos = comm.ExecuteReader();

                    while (mostrarDatos.Read())
                    {
                        Dgv_consultaHotel.Refresh();
                        Dgv_consultaHotel.Rows.Add(mostrarDatos.GetString(0), mostrarDatos.GetString(1),mostrarDatos.GetString(2), mostrarDatos.GetString(3), mostrarDatos.GetString(4));
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
            Dgv_consultaHotel.Rows.Clear();
            MostrarConsulta();
        }

        private void Btn_selec_Click(object sender, EventArgs e)
        {
            if (Dgv_consultaHotel.Rows.Count == 0)
            {
                return;
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void Frm_consultaHotel_Load(object sender, EventArgs e)
        {
            MostrarConsulta();
        }
    }
}
