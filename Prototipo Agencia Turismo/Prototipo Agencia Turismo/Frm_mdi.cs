/* 
 -----------------------------------------------------
            AUTOR: Edson Juarez
  -----------------------------------------------------
*/

using Prototipo_Agencia_Turismo.Mantenimiento;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Net;
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
        int idUsuario;

        public Frm_mdi(int idUsuario, string usuario, string tipoPerfil)
        {
            InitializeComponent();
            this.idUsuario = idUsuario;
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

            if (tipoPerfil == "1") //usuario normal
            {
                seguridadToolStripMenuItem.Enabled = false;
            }

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

        /*
        bool ventanaControlUsuario = false;
        Frm_controlUsuario controlUsuario = new Frm_controlUsuario();
        private void controlDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_controlUsuario);
            if (ventanaControlUsuario == false || frmC == null)
            {
                if (frmC == null)
                {
                    controlUsuario = new Frm_controlUsuario();
                }

                controlUsuario.MdiParent = this;
                controlUsuario.Show();
                Application.DoEvents();
                ventanaControlUsuario = true;
            }
            else
            {
                controlUsuario.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }
        */

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
            if (ventanaMantRestaurante == false || frmC == null)
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

        bool ventanaMantUsuario = false;
        Frm_mantUsuario usuarios = new Frm_mantUsuario("");
        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_mantUsuario);
            if (ventanaMantUsuario == false || frmC == null)
            {
                if (frmC == null)
                {
                    usuarios = new Frm_mantUsuario(nombreUsuario);
                }

                usuarios.MdiParent = this;
                usuarios.Show();
                Application.DoEvents();
                ventanaMantUsuario = true;
            }
            else
            {
                usuarios.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_login login = new Frm_login();
            login.Show();

            IPHostEntry host;
            string localIP = "?";
            host = Dns.GetHostEntry(Dns.GetHostName());

            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily.ToString() == "InterNetwork")
                {
                    localIP = ip.ToString();
                }
            }

            try
            {
                OdbcCommand comm = new OdbcCommand("{call SP_InsertarBitacora(?,?,?,?,?)}", Conexion.nuevaConexion());
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.Add("ope", OdbcType.Text).Value = "CIERRE DE SESIÓN";
                comm.Parameters.Add("usr", OdbcType.Text).Value = nombreUsuario;
                comm.Parameters.Add("fecha", OdbcType.Text).Value = fecha.ToString("yyyy/MM/dd HH:mm:ss");
                comm.Parameters.Add("proc", OdbcType.Text).Value = "-----";
                comm.Parameters.Add("dirIp", OdbcType.Text).Value = localIP;
                comm.ExecuteNonQuery();

                string actualizarCampo = "UPDATE tbl_usuario SET logeado = '0' WHERE Pk_idUsuario= " + idUsuario + " AND Fk_idPerfil= '" + tipoPerfil + "'"; 
                OdbcCommand commAct = new OdbcCommand(actualizarCampo, Conexion.nuevaConexion());
                commAct.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }

        bool ventanaMantPerfil = false;
        Frm_mantPerfil perfil = new Frm_mantPerfil("");
        private void perfilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_mantPerfil);
            if (ventanaMantPerfil == false || frmC == null)
            {
                if (frmC == null)
                {
                    perfil = new Frm_mantPerfil(nombreUsuario);
                }

                perfil.MdiParent = this;
                perfil.Show();
                Application.DoEvents();
                ventanaMantPerfil = true;
            }
            else
            {
                perfil.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }



        bool ventanaMantDepartamento = false;
        Frm_mantDepartamento mantenimientoDepartamento = new Frm_mantDepartamento();
        private void departamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_mantDepartamento);
            if (ventanaNominas == false || frmC == null)
            {
                if (frmC == null)
                {
                    mantenimientoDepartamento = new Frm_mantDepartamento();
                }

                mantenimientoDepartamento.MdiParent = this;
                mantenimientoDepartamento.Show();
                Application.DoEvents();
                ventanaMantDepartamento = true;
            }
            else
            {
                mantenimientoDepartamento.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }


        bool ventanaMantCliente = false;
        Frm_mantCliente mantenimientoCliente = new Frm_mantCliente();
        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_mantCliente);
            if (ventanaNominas == false || frmC == null)
            {
                if (frmC == null)
                {
                    mantenimientoCliente = new Frm_mantCliente();
                }

                mantenimientoCliente.MdiParent = this;
                mantenimientoCliente.Show();
                Application.DoEvents();
                ventanaMantCliente = true;
            }
            else
            {
                mantenimientoCliente.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }

        bool ventanaMantBonos = false;
        Frm_mantBono_Desc BonosyDescuentos = new Frm_mantBono_Desc("");
        private void bonosYDescuentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_mantBono_Desc);
            if (ventanaMantBonos == false || frmC == null)
            {
                if (frmC == null)
                {
                    BonosyDescuentos = new Frm_mantBono_Desc(nombreUsuario);
                }

                BonosyDescuentos.MdiParent = this;
                BonosyDescuentos.Show();
                Application.DoEvents();
                ventanaMantBonos = true;
            }
            else
            {
                mantenimientoCliente.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }


        bool ventanaMantGuia = false;
        Frm_manGuiaTuristico GuiaTuristico = new Frm_manGuiaTuristico("");
        private void guiaTuristicoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_manGuiaTuristico);
            if (ventanaMantGuia == false || frmC == null)
            {
                if (frmC == null)
                {
                    GuiaTuristico = new Frm_manGuiaTuristico(nombreUsuario);
                }

                GuiaTuristico.MdiParent = this;
                GuiaTuristico.Show();
                Application.DoEvents();
                ventanaMantGuia = true;
            }
            else
            {
                mantenimientoCliente.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }


        bool ventanaMantEmp = false;
        Frm_mantEmpleado Emple = new Frm_mantEmpleado("");
        private void empleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_mantEmpleado);
            if (ventanaMantEmp == false || frmC == null)
            {
                if (frmC == null)
                {
                    Emple = new Frm_mantEmpleado(nombreUsuario);
                }

                Emple.MdiParent = this;
                Emple.Show();
                Application.DoEvents();
                ventanaMantEmp = true;
            }
            else
            {
                mantenimientoCliente.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }



        }
        bool ventanaMenus = false;
        Frm_mantMenuscs menu = new Frm_mantMenuscs("");
        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
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
                ventanaMenus = true;
            }
            else
            {
                menu.WindowState = System.Windows.Forms.FormWindowState.Normal;
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


