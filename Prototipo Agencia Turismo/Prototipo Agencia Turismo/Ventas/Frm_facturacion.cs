/* 
 -----------------------------------------------------
            AUTOR: Edson Juarez y Angel Solares
  -----------------------------------------------------
*/

using Prototipo_Agencia_Turismo.Consulta;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototipo_Agencia_Turismo.Cotizacion
{
    public partial class Frm_facturacion : Form
    {
        public Frm_facturacion()
        {
            InitializeComponent();
        }

        DateTime fecha = DateTime.Now;
        int controlSeleccionHotel = 0;

        private void Lbl_titulo_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_IdEmpleado_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Rbtn_facturacion_CheckedChanged(object sender, EventArgs e)
        {
            Grpbx_encabezado.Enabled = true;
            Lbl_titulo.Text = "FACTURACIÓN";
        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Frm_facturacion_Load(object sender, EventArgs e)
        {
            Grpbx_encabezado.Enabled = false;
            Grb_Hotel.Enabled = false;
            Grb_Restaurante.Enabled = false;
            Grb_LugarT.Enabled = false;

            Lbl_fechaEmision.Text = fecha.ToString("yyyy/MM/dd");
        }

        private void Rbtn_facturacion_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void Rbtn_cotizacion_CheckedChanged(object sender, EventArgs e)
        {
            Grpbx_encabezado.Enabled = true;
            Lbl_titulo.Text = "COTIZACIÓN";
        }

        private void button1_Click(object sender, EventArgs e) //Consulta Cliente
        {
            Frm_consultaCliente consultaCliente = new Frm_consultaCliente();
            consultaCliente.ShowDialog();

            if (consultaCliente.DialogResult == DialogResult.OK)
            {
                Txt_codigoCliente.Text = consultaCliente.Dgv_consultaCliente.Rows[consultaCliente.Dgv_consultaCliente.CurrentRow.Index].Cells[0].Value.ToString();
                Txt_cliente.Text = consultaCliente.Dgv_consultaCliente.Rows[consultaCliente.Dgv_consultaCliente.CurrentRow.Index].Cells[1].Value.ToString();
            }

            Grpbx_encabezado.Enabled = false;
            Grb_Hotel.Enabled = true;
        }

        private void Btn_consultaHotel_Click(object sender, EventArgs e)
        {
            //Proceso de consulta 

            controlSeleccionHotel = controlSeleccionHotel + 1;
            if(controlSeleccionHotel == 2)
            {
                Grb_Hotel.Enabled = false;
                Grb_Restaurante.Enabled = true;
                controlSeleccionHotel = 0;
            }
        }

        private void Btn_consultaHabitación_Click(object sender, EventArgs e)
        {
            //Proceso de consulta 

            controlSeleccionHotel = controlSeleccionHotel + 1;
            if (controlSeleccionHotel == 2)
            {
                Grb_Hotel.Enabled = false;
                Grb_Restaurante.Enabled = true;
                controlSeleccionHotel = 0;
            }
        }

        private void Btn_consultaRestaurante_Click(object sender, EventArgs e)
        {
            //Proceso de consulta
            Grb_Restaurante.Enabled = false;
            Grb_LugarT.Enabled = true;
        }

        private void Btn_consultaLugarTuristico_Click(object sender, EventArgs e)
        {
            Frm_consultaLugarTuristico consultaLugarTuristico = new Frm_consultaLugarTuristico();
            consultaLugarTuristico.ShowDialog();

            if(consultaLugarTuristico.DialogResult == DialogResult.OK)
            {
                Txt_lugarTuristico.Text = consultaLugarTuristico.Dgv_consultaLugarT.Rows[consultaLugarTuristico.Dgv_consultaLugarT.CurrentRow.Index].Cells[1].Value.ToString();
            }
        }
    }
}
