/* 
 -----------------------------------------------------
            AUTOR: Edson Juarez
  -----------------------------------------------------
*/


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;

namespace Prototipo_Agencia_Turismo.Consulta
{
    public partial class Frm_consultaUsuario : Form
    {
        string consultaUsuarios = " ";
        public Frm_consultaUsuario()
        {
            InitializeComponent();
        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_seleccionar_Click(object sender, EventArgs e)
        {
            if (Dgv_consultaUsuario.Rows.Count == 0)
            {
                return;
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void CargarDatos()
        {
            try
            {
                consultaUsuarios = "SELECT * FROM tbl_usuario WHERE estado = 1;";
                OdbcCommand comm = new OdbcCommand(consultaUsuarios, Conexion.nuevaConexion());
                OdbcDataReader cargarDgv = comm.ExecuteReader();

                while(cargarDgv.Read())
                {
                    Dgv_consultaUsuario.Refresh();
                    Dgv_consultaUsuario.Rows.Add(cargarDgv.GetString(0), cargarDgv.GetString(1),
                        cargarDgv.GetString(2), cargarDgv.GetString(3), cargarDgv.GetString(4));
                }
                comm.Connection.Close();
                cargarDgv.Close();
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }

        private void Frm_consultaUsuario_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void Btn_actualizar_Click(object sender, EventArgs e)
        {
            Dgv_consultaUsuario.Rows.Clear();
            CargarDatos();
        }

        private void Btn_consultaPerfil_Click(object sender, EventArgs e)
        {
            if( string.IsNullOrEmpty(Txt_consultaUsuario.Text.Trim()) == false )
            {
                Dgv_consultaUsuario.Rows.Clear();

                try
                {
                    consultaUsuarios = "SELECT * FROM tbl_usuario WHERE nombreUsuario LIKE ('%" + Txt_consultaUsuario.Text.Trim() + "%') AND estado = 1;";
                    OdbcCommand comm = new OdbcCommand(consultaUsuarios, Conexion.nuevaConexion());
                    OdbcDataReader cargarDgv = comm.ExecuteReader();

                    while (cargarDgv.Read())
                    {
                        Dgv_consultaUsuario.Refresh();
                        Dgv_consultaUsuario.Rows.Add(cargarDgv.GetString(0), cargarDgv.GetString(1),
                            cargarDgv.GetString(2), cargarDgv.GetString(3), cargarDgv.GetString(4));
                    }
                    comm.Connection.Close();
                    cargarDgv.Close();
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

        private void Btn_ayuda_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "C:\\Ayudas Agencia Turismo.chm");
        }
    }
}
