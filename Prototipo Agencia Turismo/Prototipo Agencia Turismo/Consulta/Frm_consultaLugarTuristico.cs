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
    public partial class Frm_consultaLugarTuristico : Form
    {
        string consultaLugarT = " ";
        string consultaDepartamento = " ";

        public Frm_consultaLugarTuristico()
        {
            InitializeComponent();
        }

        private void CargarDatos()
        {
            Dgv_consultaLugarT.Rows.Clear();
            try
            {
                consultaLugarT = "SELECT * FROM tbl_lugarturistico WHERE estadoLugarTuristico = 1;";
                OdbcCommand comm = new OdbcCommand(consultaLugarT, Conexion.nuevaConexion());
                OdbcDataReader cargarDgv = comm.ExecuteReader();
                Dgv_consultaLugarT.Rows.Clear();
                while (cargarDgv.Read())
                {
                    consultaDepartamento = "SELECT D.NombreDepartamento FROM tbl_departamentos D " +
                           "INNER JOIN tbl_lugarturistico L ON D.Pk_idDepartamento = " + cargarDgv.GetInt32(3);

                    OdbcCommand comm1 = new OdbcCommand(consultaDepartamento, Conexion.nuevaConexion());
                    OdbcDataReader cargar = comm1.ExecuteReader();

                    while (cargar.Read())
                    {
                        Dgv_consultaLugarT.Rows.Add(cargarDgv.GetInt32(0), cargarDgv.GetString(1),
                            cargarDgv.GetString(2), cargar.GetString(0), cargarDgv.GetString(4));
                        break;
                    }
                    comm1.Connection.Close();
                    cargar.Close();
                }
                comm.Connection.Close();
                cargarDgv.Close();
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
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

        private void Frm_consultaLugarTuristico_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void Btn_actualizar_Click(object sender, EventArgs e)
        {
            Dgv_consultaLugarT.Rows.Clear();
            CargarDatos();
        }

        private void Btn_seleccionar_Click(object sender, EventArgs e)
        {
            if (Dgv_consultaLugarT.Rows.Count == 0)
            {
                return;
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void Btn_consultaLugarT_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Txt_consultaLugarT.Text.Trim()) == false)
            {
                Dgv_consultaLugarT.Rows.Clear();

                try
                {
                    consultaLugarT = "SELECT * FROM tbl_lugarturistico WHERE NombreLugarTuristico LIKE ('%" + Txt_consultaLugarT.Text.Trim() + "%') AND estadoLugarTuristico = 1;";
                    OdbcCommand comm = new OdbcCommand(consultaLugarT, Conexion.nuevaConexion());
                    OdbcDataReader cargarDgv = comm.ExecuteReader();
                    Dgv_consultaLugarT.Rows.Clear();
                    while (cargarDgv.Read())
                    {
                        //Búsqueda del nombre del departamento para agregarlo al dataGrid de la consulta
                        consultaDepartamento = "SELECT D.NombreDepartamento FROM tbl_departamentos D " +
                            "INNER JOIN tbl_lugarturistico L ON D.Pk_idDepartamento = " + cargarDgv.GetInt32(3);

                        OdbcCommand comm1 = new OdbcCommand(consultaDepartamento, Conexion.nuevaConexion());
                        OdbcDataReader cargar = comm1.ExecuteReader();
                        while (cargar.Read())
                        {
                            Dgv_consultaLugarT.Rows.Add(cargarDgv.GetInt32(0), cargarDgv.GetString(1),
                                cargarDgv.GetString(2), cargar.GetString(0));
                            break;
                        }
                        comm1.Connection.Close();
                        cargar.Close();
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
    }
}
