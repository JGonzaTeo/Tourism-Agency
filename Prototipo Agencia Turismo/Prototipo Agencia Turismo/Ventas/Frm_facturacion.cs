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

namespace Prototipo_Agencia_Turismo.Cotizacion
{
    public partial class Frm_facturacion : Form
    {
        public Frm_facturacion()
        {
            InitializeComponent();
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

            Habilitar();
        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Habilitar()
        {
            Lbl_Empleado.Enabled = true;
            Txt_IdEmpleado.Enabled = true;
            Lbl_codCliente.Enabled = true;
            Txt_codigoCliente.Enabled = true;
            Lbl_cliente.Enabled = true;
            Txt_cliente.Enabled = true;
            Lbl_fecha.Enabled = true;
            Lbl_fechaEmision.Enabled = true;
            Lbl_pasajeros.Enabled = true;
            CB_Pasajero.Enabled = true;
            Pnl_Detalle.Enabled = true;
        }

        private void Frm_facturacion_Load(object sender, EventArgs e)
        {
            Grpbx_encabezado.Enabled = false;
            Pnl_Detalle.Enabled = false;
        }

        private void Rbtn_facturacion_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void Rbtn_cotizacion_CheckedChanged(object sender, EventArgs e)
        {
            Grpbx_encabezado.Enabled = true;
            Lbl_titulo.Text = "COTIZACIÓN";

            Habilitar();
        }
    }
}
