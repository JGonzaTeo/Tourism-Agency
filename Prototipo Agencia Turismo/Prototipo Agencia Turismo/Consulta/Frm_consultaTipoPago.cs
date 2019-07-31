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
    public partial class Frm_consultaTipoPago : Form
    {
        public Frm_consultaTipoPago()
        {
            InitializeComponent();
        }

        private void Lbl_titulo_Click(object sender, EventArgs e)
        {

        }

        private void Btn_min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_cerr_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Lbl_consultaUsuario_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Txt_consultaPago.Text.Trim()) == false)
            {
                Dgv_consultaPago.Rows.Clear();
                try
                {
                    string consultaMostrar = "SELECT * FROM tbl_tipopagos WHERE nombreTipoPago LIKE ('%" + Txt_consultaPago.Text.Trim() + "%')"+"AND estadoTipoPago=1"+";";
                    OdbcCommand comm = new OdbcCommand(consultaMostrar, Conexion.nuevaConexion());
                    OdbcDataReader mostrarDatos = comm.ExecuteReader();

                    while (mostrarDatos.Read())
                    {
                        Dgv_consultaPago.Refresh();
                        Dgv_consultaPago.Rows.Add(mostrarDatos.GetString(0), mostrarDatos.GetString(1), mostrarDatos.GetString(2), mostrarDatos.GetString(3));
                    }
                }
                catch (Exception err)
                {
                    Console.WriteLine("ERROR:" + err.Message);
                }
            }
        }

        private void MostrarConsulta()
        {
            try
            {
                string consultaMostrar = "SELECT * FROM tbl_tipopagos WHERE estadoTipoPago = 1;";
                OdbcCommand comm = new OdbcCommand(consultaMostrar, Conexion.nuevaConexion());
                OdbcDataReader mostrarDatos = comm.ExecuteReader();

                while (mostrarDatos.Read())
                {
                    Dgv_consultaPago.Refresh();
                    Dgv_consultaPago.Rows.Add(mostrarDatos.GetInt32(0), mostrarDatos.GetString(1), mostrarDatos.GetString(2), mostrarDatos.GetString(3));
                }

            }
            catch (Exception err)
            {
                Console.Write(err.Message);
            }
        }

        private void Btn_actu_Click(object sender, EventArgs e)
        {
            Dgv_consultaPago.Rows.Clear();
            MostrarConsulta();
        }

        private void Btn_selec_Click(object sender, EventArgs e)
        {
            if (Dgv_consultaPago.Rows.Count == 0)
            {
                return;
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void Frm_consultaTipoPago_Load(object sender, EventArgs e)
        {
            MostrarConsulta();
        }
    }
}
