/* 
 -----------------------------------------------------
            AUTOR: Edson Juarez
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

namespace Prototipo_Agencia_Turismo
{
    public partial class Frm_bitacora : Form
    {

        string consultaBitacora = " ";
        public Frm_bitacora()
        {
            InitializeComponent();
        }

        private void CargarDatos()
        {
            try
            {
                consultaBitacora = "SELECT * FROM tbl_bitacora;";
                OdbcCommand comm = new OdbcCommand(consultaBitacora, Conexion.nuevaConexion());
                OdbcDataReader cargarDgv = comm.ExecuteReader();

                while (cargarDgv.Read())
                {
                    Dgv_tablaBitacora.Refresh();
                    Dgv_tablaBitacora.Rows.Add(cargarDgv.GetString(0), cargarDgv.GetString(1),
                        cargarDgv.GetString(2), cargarDgv.GetString(3), cargarDgv.GetString(4), cargarDgv.GetString(5));
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Frm_bitacora_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void Btn_consultaPerfil_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Txt_consultaUsuario.Text.Trim()) == false)
            {
                Dgv_tablaBitacora.Rows.Clear();

                try
                {
                    consultaBitacora = "SELECT * FROM tbl_bitacora WHERE usuario LIKE ('%" + Txt_consultaUsuario.Text.Trim() + "%')";
                    OdbcCommand comm = new OdbcCommand(consultaBitacora, Conexion.nuevaConexion());
                    OdbcDataReader cargarDgv = comm.ExecuteReader();

                    while (cargarDgv.Read())
                    {
                        Dgv_tablaBitacora.Refresh();
                        Dgv_tablaBitacora.Rows.Add(cargarDgv.GetString(0), cargarDgv.GetString(1),
                            cargarDgv.GetString(2), cargarDgv.GetString(3), cargarDgv.GetString(4), cargarDgv.GetString(5));
                    }
                }
                catch (Exception err)
                {
                    Console.WriteLine(err.Message);
                }
            }
            else
            {
                MessageBox.Show("No se ha ingresado ningún campo");
            }
        }

        private void Btn_actualizar_Click(object sender, EventArgs e)
        {
            Dgv_tablaBitacora.Rows.Clear();
            CargarDatos();
        }
    }
}
