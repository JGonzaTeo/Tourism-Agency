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
        DateTime fecha = DateTime.Now;
        int controlSeleccionHotel = 0;
        int controlSeleccionRestaurante = 0;
        string usuario = " ";

        public Frm_facturacion(string nombreUsuario)
        {
            InitializeComponent();
            usuario = nombreUsuario;
        }

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

            Txt_IdEmpleado.Text = usuario;
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
            Frm_consultaHotel consultaHotel = new Frm_consultaHotel();
            consultaHotel.ShowDialog();

            if(consultaHotel.DialogResult == DialogResult.OK)
            {
                Txt_lugarHotel.Text = consultaHotel.Dgv_consultaHotel.Rows[consultaHotel.Dgv_consultaHotel.CurrentRow.Index].Cells[1].Value.ToString();
            }

            controlSeleccionHotel = controlSeleccionHotel + 1;
            if(controlSeleccionHotel == 2)
            {
                Grb_Hotel.Enabled = false;
                Grb_Restaurante.Enabled = true;
                controlSeleccionHotel = 0;
            }
            Btn_consultaHotel.Enabled = false;
        }

        private void Btn_consultaHabitación_Click(object sender, EventArgs e)
        {
            Frm_consultaHabitacion consultaHabitacion = new Frm_consultaHabitacion();
            consultaHabitacion.ShowDialog();
            //variable para almacenar y convertir la cantidad y precio de una habitación
            string precioHabitacion = " ";
            double precioHabitacionConvertido = 0;
            double totalPrecioHabitacion = 0;
            string cantidadHabitacion = " ";
            double cantidadHabitacionConvertido = 0;

            if(consultaHabitacion.DialogResult == DialogResult.OK)
            {
                Txt_habitacion.Text = consultaHabitacion.Dgv_consultaHabitacion.Rows[consultaHabitacion.Dgv_consultaHabitacion.CurrentRow.Index].Cells[2].Value.ToString();
                Lbl_idHabitacion.Text = consultaHabitacion.Dgv_consultaHabitacion.Rows[consultaHabitacion.Dgv_consultaHabitacion.CurrentRow.Index].Cells[0].Value.ToString();
                precioHabitacion = consultaHabitacion.Dgv_consultaHabitacion.Rows[consultaHabitacion.Dgv_consultaHabitacion.CurrentRow.Index].Cells[4].Value.ToString();
            }
            cantidadHabitacion = CB_noHab.SelectedIndex.ToString();

            precioHabitacionConvertido = Convert.ToDouble(precioHabitacion);
            cantidadHabitacionConvertido = Convert.ToDouble(cantidadHabitacion);

            totalPrecioHabitacion = precioHabitacionConvertido * cantidadHabitacionConvertido + precioHabitacionConvertido;
            Lbl_precioHabitacion.Text = Convert.ToString(totalPrecioHabitacion);

            controlSeleccionHotel = controlSeleccionHotel + 1;
            if (controlSeleccionHotel == 2)
            {
                Grb_Hotel.Enabled = false;
                Grb_Restaurante.Enabled = true;
                controlSeleccionHotel = 0;
            }
            Btn_consultaHabitación.Enabled = false;
        }

        private void Btn_consultaRestaurante_Click(object sender, EventArgs e)
        {
            Frm_consultaRestaurante consultaRestaurante = new Frm_consultaRestaurante();
            consultaRestaurante.ShowDialog();

            if(consultaRestaurante.DialogResult == DialogResult.OK)
            {
                Txt_lugarRestaurante.Text = consultaRestaurante.Dgv_consultaRestaurante.Rows[consultaRestaurante.Dgv_consultaRestaurante.CurrentRow.Index].Cells[1].Value.ToString();
            }

            controlSeleccionRestaurante = controlSeleccionRestaurante + 1;
            if (controlSeleccionRestaurante == 2)
            {
                Grb_Restaurante.Enabled = false;
                Grb_LugarT.Enabled = true;
                controlSeleccionRestaurante = 0;
            }
            Btn_consultaRestaurante.Enabled = false;
        }

        private void Btn_consultaLugarTuristico_Click(object sender, EventArgs e)
        {
            Frm_consultaLugarTuristico consultaLugarTuristico = new Frm_consultaLugarTuristico();
            consultaLugarTuristico.ShowDialog();

            if(consultaLugarTuristico.DialogResult == DialogResult.OK)
            {
                Lbl_idLugarT.Text = consultaLugarTuristico.Dgv_consultaLugarT.Rows[consultaLugarTuristico.Dgv_consultaLugarT.CurrentRow.Index].Cells[0].Value.ToString();
                Txt_lugarTuristico.Text = consultaLugarTuristico.Dgv_consultaLugarT.Rows[consultaLugarTuristico.Dgv_consultaLugarT.CurrentRow.Index].Cells[1].Value.ToString();
                Lbl_precioLugarT.Text = consultaLugarTuristico.Dgv_consultaLugarT.Rows[consultaLugarTuristico.Dgv_consultaLugarT.CurrentRow.Index].Cells[4].Value.ToString();
            }
            Btn_colocar.Enabled = true;
            Btn_quitar.Enabled = true;
            Btn_facturar.Enabled = true;
        }

        private void CB_Pasajero_SelectedIndexChanged(object sender, EventArgs e)
        {
            Btn_consultaCliente.Enabled = true;
        }

        private void CB_noHab_SelectedIndexChanged(object sender, EventArgs e)
        {
            Btn_consultaHotel.Enabled = true;
            Btn_consultaHabitación.Enabled = true;
        }

        private void Pnl_Detalle_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Btn_consultaMenu_Click(object sender, EventArgs e)
        {
            Frm_consultaMenu consultaMenu = new Frm_consultaMenu();
            consultaMenu.ShowDialog();

            if (consultaMenu.DialogResult == DialogResult.OK)
            {
                Lbl_idMenu.Text = consultaMenu.Dgv_consultaMenu.Rows[consultaMenu.Dgv_consultaMenu.CurrentRow.Index].Cells[0].Value.ToString();
                Txt_menu.Text = consultaMenu.Dgv_consultaMenu.Rows[consultaMenu.Dgv_consultaMenu.CurrentRow.Index].Cells[2].Value.ToString();
                Lbl_precioMenu.Text = consultaMenu.Dgv_consultaMenu.Rows[consultaMenu.Dgv_consultaMenu.CurrentRow.Index].Cells[4].Value.ToString();
            }

            controlSeleccionRestaurante = controlSeleccionRestaurante + 1;
            if (controlSeleccionRestaurante == 2)
            {
                Grb_Restaurante.Enabled = false;
                Grb_LugarT.Enabled = true;
                controlSeleccionRestaurante = 0;
            }
            Btn_consultaMenu.Enabled = false;
        }
    }
}
