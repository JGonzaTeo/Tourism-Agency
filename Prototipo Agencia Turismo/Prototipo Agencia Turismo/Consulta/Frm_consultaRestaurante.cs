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
    public partial class Frm_consultaRestaurante : Form
    {
        public Frm_consultaRestaurante()
        {
            InitializeComponent();
        }

        private void Txt_consultaHotel_TextChanged(object sender, EventArgs e)
        {

        }
        private void MostrarConsulta()
        {
            try
            {
                string consultaMostrar = "SELECT * FROM tbl_restaurantes WHERE estadoRestaurante = 1;";
                OdbcCommand comm = new OdbcCommand(consultaMostrar, Conexion.nuevaConexion());
                OdbcDataReader mostrarDatos = comm.ExecuteReader();

                while (mostrarDatos.Read())
                {
                    Dgv_consultaRestaurante.Refresh();
                    Dgv_consultaRestaurante.Rows.Add(mostrarDatos.GetInt32(0), mostrarDatos.GetString(1), mostrarDatos.GetString(2), mostrarDatos.GetInt32(3), mostrarDatos.GetString(4));
                }
                comm.Connection.Close();
                mostrarDatos.Close();
            }
            catch (Exception err)
            {
                Console.Write(err.Message);
            }
        }
        private void Frm_consultaRestaurante_Load(object sender, EventArgs e)
        {
            MostrarConsulta();
        }

        private void Btn_actu_Click(object sender, EventArgs e)
        {
            Dgv_consultaRestaurante.Rows.Clear();
            MostrarConsulta();
        }

        private void Btn_selec_Click(object sender, EventArgs e)
        {
            if (Dgv_consultaRestaurante.Rows.Count == 0)
            {
                return;
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void Btn_min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_cerr_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Txt_consultaRestaurante.Text.Trim()) == false)
            {
                Dgv_consultaRestaurante.Rows.Clear();
                try
                {
                    string consultaMostrar = "SELECT * FROM tbl_restaurantes WHERE NombreRestaurante LIKE ('%" + Txt_consultaRestaurante.Text.Trim() + "%')" + "AND estadoRestaurante=1" + ";";
                    OdbcCommand comm = new OdbcCommand(consultaMostrar, Conexion.nuevaConexion());
                    OdbcDataReader mostrarDatos = comm.ExecuteReader();

                    while (mostrarDatos.Read())
                    {
                        Dgv_consultaRestaurante.Refresh();
                        Dgv_consultaRestaurante.Rows.Add(mostrarDatos.GetString(0), mostrarDatos.GetString(1), mostrarDatos.GetString(2), mostrarDatos.GetString(3), mostrarDatos.GetString(4));
                    }
                    comm.Connection.Close();
                    mostrarDatos.Close();
                }
                catch (Exception err)
                {
                    Console.WriteLine("ERROR:" + err.Message);
                }
            }
        }

        private void Lbl_consultaUsuario_Click(object sender, EventArgs e)
        {

        }

        private void Btn_ayuda_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "C:\\Ayudas Agencia Turismo.chm");
        }
    }
}
