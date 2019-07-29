/* 
 -----------------------------------------------------
            AUTOR: Angel Solares
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
using System.Net;

namespace Prototipo_Agencia_Turismo.Consulta
{
    public partial class Frm_consultaDepartamento : Form
    {
        public Frm_consultaDepartamento()
        {
            InitializeComponent();
        }

        private void MostrarConsulta()
        {
            try
            {
                string consultaMostrar = "SELECT * FROM view_Departamento";
                OdbcCommand comm = new OdbcCommand(consultaMostrar, Conexion.nuevaConexion());
                OdbcDataReader mostrarDatos = comm.ExecuteReader();

                while (mostrarDatos.Read())
                {
                    Dgv_consultaDepartamento.Refresh();
                    Dgv_consultaDepartamento.Rows.Add(mostrarDatos.GetString(0), mostrarDatos.GetString(1), mostrarDatos.GetString(2));
                    
                }

            }
            catch (Exception err)
            {
                Console.Write(err.Message);
            }
        }

        private void Lbl_titulo_Click(object sender, EventArgs e)
        {

        }

        private void Btn_consultaPerfil_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Txt_consultaDepartamento.Text.Trim()) == false)
            {
                Dgv_consultaDepartamento.Rows.Clear();
                try
                {
                    OdbcCommand comm = new OdbcCommand("{call SP_BuscarDepartamento(?)}", Conexion.nuevaConexion());
                    comm.CommandType = CommandType.StoredProcedure;
                    comm.Parameters.Add("Nombre", OdbcType.Text).Value =Txt_consultaDepartamento.Text;
                    comm.ExecuteNonQuery();
                    OdbcDataReader mostrarDatos = comm.ExecuteReader();

                    while (mostrarDatos.Read())
                    {
                        Dgv_consultaDepartamento.Refresh();
                        Dgv_consultaDepartamento.Rows.Add(mostrarDatos.GetString(0), mostrarDatos.GetString(1), mostrarDatos.GetString(2));
                    }
                }
                catch (Exception err)
                {
                    Console.WriteLine("ERROR:" + err.Message);
                }
            }
        }

        private void Btn_actualizar_Click(object sender, EventArgs e)
        {
            Dgv_consultaDepartamento.Rows.Clear();
            MostrarConsulta();
        }

        private void Btn_seleccionar_Click(object sender, EventArgs e)
        {
            if (Dgv_consultaDepartamento.Rows.Count == 0)
            {
                return;
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void Frm_consultaDepartamento_Load(object sender, EventArgs e)
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
