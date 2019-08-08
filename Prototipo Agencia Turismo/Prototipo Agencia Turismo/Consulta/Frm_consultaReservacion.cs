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
    public partial class Frm_consultaReservacion : Form
    {
        public Frm_consultaReservacion()
        {
            InitializeComponent();
        }

        private void MostrarConsulta()
        {
            try
            {
                string consultaMostrar = "SELECT * from tbl_reservacion R  INNER JOIN tbl_asignaciontransporte T ON R.Pk_idReservacion=T.Fk_idReservacion;";
                OdbcCommand comm = new OdbcCommand(consultaMostrar, Conexion.nuevaConexion());
                OdbcDataReader mostrarDatos = comm.ExecuteReader();

                while (mostrarDatos.Read())
                {
                    Dgv_consultaReservacion.Refresh();
                    Dgv_consultaReservacion.Rows.Add(mostrarDatos.GetString(0), mostrarDatos.GetString(1), mostrarDatos.GetString(2),  mostrarDatos.GetString(3), mostrarDatos.GetString(4), mostrarDatos.GetString(6), mostrarDatos.GetString(7), mostrarDatos.GetString(8));
                }
                comm.Connection.Close();
                mostrarDatos.Close();
            }
            catch (Exception err)
            {
                Console.Write(err.Message);
            }
        }

        private void Lbl_consultaUsuario_Click(object sender, EventArgs e)
        {

        }

        private void Btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_consultaReservacion_Load(object sender, EventArgs e)
        {
            MostrarConsulta();
        }

        private void Btn_actualizar_Click(object sender, EventArgs e)
        {
            Dgv_consultaReservacion.Rows.Clear();
            MostrarConsulta();
        }

        private void Btn_seleccionar_Click(object sender, EventArgs e)
        {
            if (Dgv_consultaReservacion.Rows.Count == 0)
            {
                return;
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void Btn_consultaPerfil_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Txt_consultaReservacion.Text.Trim()) == false)
            {
                Dgv_consultaReservacion.Rows.Clear();
                try
                {
                    string consultaMostrar = "SELECT R.Pk_idReservacion, R.Fk_idCotizacion, R.Fk_idTipoPago, T.Pk_idAsignacion, T.Fk_idTransporte, T.Fk_idEmpleado, T.FechaSalida, T.FechaEntrada FROM tbl_reservacion R, tbl_asignaciontransporte T WHERE R.Pk_idReservacion =  (" + Txt_consultaReservacion.Text.Trim() + ")" + " AND (T.Fk_idReservacion = "+ Txt_consultaReservacion.Text.Trim()+");";
                    OdbcCommand comm = new OdbcCommand(consultaMostrar, Conexion.nuevaConexion());
                    OdbcDataReader mostrarDatos = comm.ExecuteReader();

                    while (mostrarDatos.Read())
                    {
                        Dgv_consultaReservacion.Refresh();
                        Dgv_consultaReservacion.Rows.Add(mostrarDatos.GetString(0), mostrarDatos.GetString(1), mostrarDatos.GetString(2), mostrarDatos.GetString(3), mostrarDatos.GetString(4), mostrarDatos.GetString(5), mostrarDatos.GetString(6), mostrarDatos.GetString(7));
                        //ID reservacion 0, cotizacion 1 , tipo de pago 2 , transporte 4, empleado, salida, entrada
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
    }
}
