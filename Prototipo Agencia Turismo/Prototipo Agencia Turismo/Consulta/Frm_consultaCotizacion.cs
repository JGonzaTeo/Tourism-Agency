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
    public partial class Frm_consultaCotizacion : Form
    {
        public Frm_consultaCotizacion()
        {
            InitializeComponent();
        }

        private void Btn_min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_cerr_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Lbl_consultaMenu_Click(object sender, EventArgs e)
        {

        }

        private void Txt_consultaMenu_TextChanged(object sender, EventArgs e)
        {

        }
        private void MostrarConsulta()
        {
            try
            {
                string consultaMostrar = "SELECT * FROM tbl_facturaencabezado WHERE Factura_Cotizacion = 0;";
                OdbcCommand comm = new OdbcCommand(consultaMostrar, Conexion.nuevaConexion());
                OdbcDataReader mostrarDatos = comm.ExecuteReader();

                while (mostrarDatos.Read())
                {
                    Dgv_consultaCotizacion.Refresh();
                    Dgv_consultaCotizacion.Rows.Add(mostrarDatos.GetString(0), mostrarDatos.GetString(1), mostrarDatos.GetString(2), mostrarDatos.GetString(3), mostrarDatos.GetString(4), mostrarDatos.GetString(5), mostrarDatos.GetString(6));
                    //Dgv_consultaCotizacion.Rows.Add(mostrarDatos.GetString(0), mostrarDatos.GetString(1), mostrarDatos.GetString(3), mostrarDatos.GetString(4), mostrarDatos.GetString(6), mostrarDatos.GetString(10), mostrarDatos.GetString(11), mostrarDatos.GetString(12), mostrarDatos.GetString(13));
                }

            }
            catch (Exception err)
            {
                Console.Write(err.Message);
            }
        }
        private void Btn_actu_Click(object sender, EventArgs e)
        {
            Dgv_consultaCotizacion.Rows.Clear();
            MostrarConsulta();
        }

        private void Btn_selec_Click(object sender, EventArgs e)
        {

        }

        private void Btn_consultar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Txt_consultaCotizacion.Text.Trim()) == false)
            {
                Dgv_consultaCotizacion.Rows.Clear();
                try
                {
                    string consultaMostrar = "SELECT * FROM tbl_facturaencabezado E, tbl_facturadetalle D WHERE  E.Pk_idFactura =  ('%" + Txt_consultaCotizacion.Text.Trim() + "%')"+ " AND D.Pk_idFactura = ('%" + Txt_consultaCotizacion.Text.Trim() + "%')" + " AND E.Factura_Cotizacion=0" + ";";
                    OdbcCommand comm = new OdbcCommand(consultaMostrar, Conexion.nuevaConexion());
                    OdbcDataReader mostrarDatos = comm.ExecuteReader();

                    while (mostrarDatos.Read())
                    {
                        Dgv_consultaCotizacion.Refresh();
                        Dgv_consultaCotizacion.Rows.Add(mostrarDatos.GetString(0), mostrarDatos.GetString(1), mostrarDatos.GetString(3), mostrarDatos.GetString(4), mostrarDatos.GetString(6),mostrarDatos.GetString(10), mostrarDatos.GetString(11), mostrarDatos.GetString(12), mostrarDatos.GetString(13));
                    }
                }
                catch (Exception err)
                {
                    Console.WriteLine("ERROR:" + err.Message);
                }
            }
        }

        private void Btn_selec_Click_1(object sender, EventArgs e)
        {
            if (Dgv_consultaCotizacion.Rows.Count == 0)
            {
                return;
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void Frm_consultaCotizacion_Load(object sender, EventArgs e)
        {
            MostrarConsulta();
        }
    }
}
