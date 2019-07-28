/* 
 -----------------------------------------------------
            AUTOR: Edson Juarez
  -----------------------------------------------------
*/

using Prototipo_Agencia_Turismo.Mantenimiento;
using Prototipo_Agencia_Turismo.Mantenimientos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototipo_Agencia_Turismo
{
    public partial class Frm_mdi : Form
    {
        string nombreUsuario = " ";
        string tipoPerfil = " ";
        DateTime fecha = DateTime.Now;

        public Frm_mdi(string usuario, string tipoPerfil)
        {
            InitializeComponent();
            nombreUsuario = usuario;
            this.tipoPerfil = tipoPerfil;
        }

        private void Frm_mdi_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Frm_mdi_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "BIENVENIDO: " + nombreUsuario;

            MdiClient ctlMDI; 

            foreach (Control ctl in this.Controls)
            {
                try
                {
                    ctlMDI = (MdiClient)ctl;

                    ctlMDI.BackColor = this.BackColor;
                }
                catch (InvalidCastException exc)
                {
                    // 
                }
            }
        }

        bool ventanaBitacora = false;
        Frm_bitacora bitacora = new Frm_bitacora();
        private void bitácoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_bitacora);
            if (ventanaBitacora == false || frmC == null)
            {
                if (frmC == null)
                {
                    bitacora = new Frm_bitacora();
                }

                bitacora.MdiParent = this;
                bitacora.Show();
                Application.DoEvents();
                ventanaBitacora = true;
            }
            else
            {
                bitacora.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }

        bool ventanaMantTransporte = false;
        Frm_mantTransporte mantenimientoTransporte = new Frm_mantTransporte();
        private void transporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_mantTransporte);
            if (ventanaMantTransporte == false || frmC == null)
            {
                if (frmC == null)
                {
                    mantenimientoTransporte = new Frm_mantTransporte();
                }

                mantenimientoTransporte.MdiParent = this;
                mantenimientoTransporte.Show();
                Application.DoEvents();
                ventanaMantTransporte = true;
            }
            else
            {
                mantenimientoTransporte.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }

        bool ventanaMantRestaurante = false;
        Frm_mantRestaurante mantenimientoRestaurante = new Frm_mantRestaurante("");
        private void restauranteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_mantRestaurante);
            if (ventanaMantRestaurante == false || frmC == null)
            {
                if (frmC == null)
                {
                    mantenimientoRestaurante = new Frm_mantRestaurante(nombreUsuario);
                }

                mantenimientoRestaurante.MdiParent = this;
                mantenimientoRestaurante.Show();
                Application.DoEvents();
                ventanaMantRestaurante = true;
            }
            else
            {
                mantenimientoRestaurante.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }

        bool ventanaMantHotel = false;
        Frm_mantHotel mantenimientoHotel = new Frm_mantHotel("");
        private void hotelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_mantHotel);
            if (ventanaMantHotel == false || frmC == null)
            {
                if (frmC == null)
                {
                    mantenimientoHotel = new Frm_mantHotel(nombreUsuario);
                }

                mantenimientoHotel.MdiParent = this;
                mantenimientoHotel.Show();
                Application.DoEvents();
                ventanaMantHotel = true;
            }
            else
            {
                mantenimientoHotel.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }

        bool ventanaFacturacion = false;
        Frm_facturacion facturacion = new Frm_facturacion();
        private void cotizacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_facturacion);
            if (ventanaFacturacion == false || frmC == null)
            {
                if (frmC == null)
                {
                    facturacion = new Frm_facturacion();
                }

                facturacion.MdiParent = this;
                facturacion.Show();
                Application.DoEvents();
                ventanaFacturacion = true;
            }
            else
            {
                facturacion.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }

        bool ventanaNominas = false;
        Frm_nominas nominas = new Frm_nominas();
        private void nóminasToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_nominas);
            if (ventanaNominas== false || frmC == null)
            {
                if (frmC == null)
                {
                    nominas = new Frm_nominas();
                }

                nominas.MdiParent = this;
                nominas.Show();
                Application.DoEvents();
                ventanaNominas = true;
            }
            else
            {
                nominas.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }
        bool ventanaPagos = false;
        Frm_mantTipoPago pagos = new Frm_mantTipoPago("");
        private void tipoDePagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_mantTipoPago);
            if (ventanaPagos == false || frmC == null)
            {
                if (frmC == null)
                {
                    pagos = new Frm_mantTipoPago(nombreUsuario);
                }

                pagos.MdiParent = this;
                pagos.Show();
                Application.DoEvents();
                ventanaPagos = true;
            }
            else
            {
                pagos.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }

        bool ventanaMenus = false;
        Frm_mantMenuscs menu = new Frm_mantMenuscs("");
        private void menusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_mantMenuscs);
            if (ventanaMenus == false || frmC == null)
            {
                if (frmC == null)
                {
                    menu = new Frm_mantMenuscs(nombreUsuario);
                }

                menu.MdiParent = this;
                menu.Show();
                Application.DoEvents();
                ventanaMenus= true;
            }
            else
            {
                menu.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }

        bool ventanaHabitacion = false;
        Frm_mantHabitacion habitacion = new Frm_mantHabitacion("");
        private void habitacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_mantHabitacion);
            if (ventanaHabitacion == false || frmC == null)
            {
                if (frmC == null)
                {
                    habitacion = new Frm_mantHabitacion(nombreUsuario);
                }

                habitacion.MdiParent = this;
                habitacion.Show();
                Application.DoEvents();
                ventanaHabitacion = true;
            }
            else
            {
                habitacion.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }
    }
}
