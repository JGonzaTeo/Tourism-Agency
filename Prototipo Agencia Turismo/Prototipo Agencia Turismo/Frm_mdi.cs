/* 
 -----------------------------------------------------
            AUTOR: Edson Juarez
  -----------------------------------------------------
*/

using Prototipo_Agencia_Turismo.Cotizacion;
using Prototipo_Agencia_Turismo.Mantenimiento;
using Prototipo_Agencia_Turismo.Procesos;
using Prototipo_Agencia_Turismo.Ventas;
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
        int tipoPerfil = 0;
        DateTime fecha = DateTime.Now;
        int idUsuario;

        public Frm_mdi(int idUsuario, string usuario, int tipoPerfil)
        {
            InitializeComponent();
            this.idUsuario = idUsuario;
            nombreUsuario = usuario;
            this.tipoPerfil = tipoPerfil;
        }

        private void Frm_mdi_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                string actualizarCampo = "UPDATE tbl_usuario SET logeado = '0' WHERE Pk_idUsuario= " + idUsuario + " AND Fk_idPerfil= '" + tipoPerfil + "'";
                OdbcCommand commAct = new OdbcCommand(actualizarCampo, Conexion.nuevaConexion());
                commAct.ExecuteNonQuery();

                commAct.Connection.Close();
            }
            catch(Exception err)
            {
                Console.WriteLine(err.Message);
            }
            Application.Exit();
        }

        private void Frm_mdi_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "BIENVENIDO: " + nombreUsuario;

            if (tipoPerfil == 1) //Administrador
            {
                //Todas las opciones habilitadas
            }
            else if(tipoPerfil == 2) //Contador (Nóminas)
            {
                reservacionesToolStripMenuItem.Enabled = false;
                guíasTurísticasToolStripMenuItem.Enabled = false;
                planesDeViajeToolStripMenuItem.Enabled = false;
                cotizacionesToolStripMenuItem.Enabled = false;
                seguridadToolStripMenuItem.Enabled = false;
                transporteToolStripMenuItem.Enabled = false;
                restauranteToolStripMenuItem.Enabled = false;
                hotelToolStripMenuItem.Enabled = false;
                departamentoToolStripMenuItem.Enabled = false;
                clienteToolStripMenuItem.Enabled = false;
                bonosYDescuentosToolStripMenuItem.Enabled = false;
                guiaTuristicoToolStripMenuItem.Enabled = false;
                empleadoToolStripMenuItem.Enabled = false;
                menuToolStripMenuItem.Enabled = false;
                tipoDePagoToolStripMenuItem.Enabled = false;
                habitacionToolStripMenuItem.Enabled = false;
            }
            else if(tipoPerfil == 3) //ventas (Facturación) 
            {
                reservacionesToolStripMenuItem.Enabled = false;
                guíasTurísticasToolStripMenuItem.Enabled = false;
                planesDeViajeToolStripMenuItem.Enabled = false;
                seguridadToolStripMenuItem.Enabled = false;
                mantenimientosToolStripMenuItem.Enabled = false;
                contabilidadToolStripMenuItem.Enabled = false;
            }
            else if(tipoPerfil == 4) //Reservación
            {
                cotizacionesToolStripMenuItem.Enabled = false;
                guíasTurísticasToolStripMenuItem.Enabled = false;
                planesDeViajeToolStripMenuItem.Enabled = false;
                seguridadToolStripMenuItem.Enabled = false;
                mantenimientosToolStripMenuItem.Enabled = false;
                contabilidadToolStripMenuItem.Enabled = false;
            }
            else if(tipoPerfil == 5) //Usuario normal (solo accederá a algunos mantenimientos 
            {
                reservacionesToolStripMenuItem.Enabled = false;
                cotizacionesToolStripMenuItem.Enabled = false;
                guíasTurísticasToolStripMenuItem.Enabled = false;
                planesDeViajeToolStripMenuItem.Enabled = false;
                seguridadToolStripMenuItem.Enabled = false;
                contabilidadToolStripMenuItem.Enabled = false;

                restauranteToolStripMenuItem.Enabled = false;
                hotelToolStripMenuItem.Enabled = false;
                departamentoToolStripMenuItem.Enabled = false;
                bonosYDescuentosToolStripMenuItem.Enabled = false;
                guiaTuristicoToolStripMenuItem.Enabled = false;
                empleadoToolStripMenuItem.Enabled = false;
                asignacionEmpleadoToolStripMenuItem.Enabled = false;

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
        Frm_mantTransporte mantenimientoTransporte = new Frm_mantTransporte("");
        private void transporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_mantTransporte);
            if (ventanaMantTransporte == false || frmC == null)
            {
                if (frmC == null)
                {
                    mantenimientoTransporte = new Frm_mantTransporte(nombreUsuario);
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

        private void cotizacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
        }

        bool ventanaNominas = false;
        Frm_Nominas nominas = new Frm_Nominas("");
        private void nóminasToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_Nominas);
            if (ventanaNominas== false || frmC == null)
            {
                if (frmC == null)
                {
                    nominas = new Frm_Nominas(nombreUsuario);
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

                comm.Connection.Close();

                string actualizarCampo = "UPDATE tbl_usuario SET logeado = '0' WHERE Pk_idUsuario= " + idUsuario + " AND Fk_idPerfil= '" + tipoPerfil + "'"; 
                OdbcCommand commAct = new OdbcCommand(actualizarCampo, Conexion.nuevaConexion());
                commAct.ExecuteNonQuery();

                commAct.Connection.Close();
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
        Frm_mantDepartamento mantenimientoDepartamento = new Frm_mantDepartamento("");
        private void departamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_mantDepartamento);
            if (ventanaNominas == false || frmC == null)
            {
                if (frmC == null)
                {
                    mantenimientoDepartamento = new Frm_mantDepartamento(nombreUsuario);
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
        Frm_mantCliente mantenimientoCliente = new Frm_mantCliente("");
        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_mantCliente);
            if (ventanaNominas == false || frmC == null)
            {
                if (frmC == null)
                {
                    mantenimientoCliente = new Frm_mantCliente(nombreUsuario);
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

        bool ventanaReservacion = false;
        Frm_reservacion reservacion = new Frm_reservacion("");
        private void reservacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_reservacion);
            if (ventanaReservacion == false || frmC == null)
            {
                if (frmC == null)
                {
                    reservacion = new Frm_reservacion(nombreUsuario);
                }

                reservacion.MdiParent = this;
                reservacion.Show();
                Application.DoEvents();
                ventanaReservacion = true;
            }
            else
            {
                reservacion.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }

        bool ventanaasginacionguiaemp = false;
        Frm_AsignacionEmpGuia asig = new Frm_AsignacionEmpGuia("");
        private void asignacionEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_AsignacionEmpGuia);
            if (ventanaasginacionguiaemp == false || frmC == null)
            {
                if (frmC == null)
                {
                    asig = new Frm_AsignacionEmpGuia(nombreUsuario);
                }

                asig.MdiParent = this;
                asig.Show();
                Application.DoEvents();
                ventanaasginacionguiaemp = true;
            }
            else
            {
                habitacion.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }

        bool ventanaControlFactura = false;
        Frm_controlFacturas controlFactura = new Frm_controlFacturas("");
        private void controlDeFacturasToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_controlFacturas);
            if (ventanaControlFactura == false || frmC == null)
            {
                if (frmC == null)
                {
                    controlFactura = new Frm_controlFacturas(nombreUsuario);
                }

                controlFactura.MdiParent = this;
                controlFactura.Show();
                Application.DoEvents();
                ventanaControlFactura = true;
            }
            else
            {
                controlFactura.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }

        bool ventanaFacturacion = false;
        Frm_facturacion facturacion = new Frm_facturacion("");
        private void facturaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_facturacion);
            if (ventanaFacturacion == false || frmC == null)
            {
                if (frmC == null)
                {
                    facturacion = new Frm_facturacion(nombreUsuario);
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

        private void xToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "C:\\Ayudas Agencia Turismo.chm");
        }
    }
    }


