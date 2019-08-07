/* 
 -----------------------------------------------------
            AUTOR: Ivan Mogollón
  -----------------------------------------------------
*/

using Prototipo_Agencia_Turismo.Consulta;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototipo_Agencia_Turismo
{
    public partial class Frm_reservacion : Form
    {
        IPHostEntry host;
        string localIP = "?";
        string usuario = "";
        DateTime fechai = DateTime.Now;
        //Logica
        int boton = 0;
        //Reservacion
        String idCotizacion;
        String idReservacion;
        String tipoPago;
        //Asig Transp
        String idTrasnporte;
        String idEmpleado;
        String fechaSalida;
        String fechaEntrada;
        //Variable para comparar fecha
        CultureInfo provider = CultureInfo.InvariantCulture;
        //Variables para modificacion
        String idAsignacion;
        public Frm_reservacion(String nombreUsuario)
        {
            InitializeComponent();
            usuario = nombreUsuario;
        }

        private void Frm_reservacion_Load(object sender, EventArgs e)
        {
            DateTime fechaHoy = DateTime.Now;
            string fecha = fechaHoy.ToString("d");
            Dtp_FecaEntrada.Text = fecha;
            Dtp_FecaSalida.Text = fecha;
            Desahiblitarbtn();
        }
        private void Habilitarbtn()
        {
            Btn_consultarVehiculo.Enabled = true;
            Btn_consultarPiloto.Enabled = true;
            Btn_reservar.Enabled = true;
        }

        private void Desahiblitarbtn()
        {
            Btn_consultarVehiculo.Enabled = false;
            Btn_consultarPiloto.Enabled = false;
            Btn_reservar.Enabled = false;
            Dtp_FecaEntrada.Enabled = false;
            Dtp_FecaSalida.Enabled = false;
            Btn_modificar.Enabled = false;
        }
        private void MostrarConsulta()
        {
            string num = Lbl_idCotizacion.Text;
            try
            {
                string consultaMostrar = "SELECT Fk_idTipoHabitacion, FK_idMenus, Fk_idLugarTuristico,cantidadHabitaciones FROM tbl_facturadetalle WHERE Pk_idFactura="+num+" AND estado = 0;";
                OdbcCommand comm = new OdbcCommand(consultaMostrar, Conexion.nuevaConexion());
                OdbcDataReader mostrarDatos = comm.ExecuteReader();

                while (mostrarDatos.Read())
                {
                    Dgv_detalleFactura.Refresh();
                    Dgv_detalleFactura.Rows.Add(mostrarDatos.GetString(0), mostrarDatos.GetString(1), mostrarDatos.GetString(2), mostrarDatos.GetString(3));
                }
                comm.Connection.Close();
                mostrarDatos.Close();
            }
            catch (Exception err)
            {
                Console.Write(err.Message);
            }
           
        }

        private void Btn_busquedaCotizacion_Click(object sender, EventArgs e)
        {
                 Frm_consultaCotizacion conCotizacion = new Frm_consultaCotizacion();
                 conCotizacion.ShowDialog();

                if (conCotizacion.DialogResult == DialogResult.OK)
                {
                    Lbl_idCotizacion.Text = conCotizacion.Dgv_consultaCotizacion.Rows[conCotizacion.Dgv_consultaCotizacion.CurrentRow.Index].
                    Cells[0].Value.ToString();
                    Lbl_nombCliente.Text = conCotizacion.Dgv_consultaCotizacion.Rows[conCotizacion.Dgv_consultaCotizacion.CurrentRow.Index].
                    Cells[1].Value.ToString();
                    Lbl_metodo.Text = conCotizacion.Dgv_consultaCotizacion.Rows[conCotizacion.Dgv_consultaCotizacion.CurrentRow.Index].
                    Cells[5].Value.ToString();
            }
            Dgv_detalleFactura.Rows.Clear();
            Dgv_detalleFactura.Refresh();
            if (Lbl_idCotizacion.Text == "" || Lbl_metodo.Text == "")
            {
                Btn_consultarReservacion.Enabled = true;
                Btn_consultarVehiculo.Enabled = false;
            }
            else
            {
                Btn_consultarReservacion.Enabled = false;
                Btn_consultarVehiculo.Enabled = true;
                MostrarConsulta();
            }

        }

        private void Btn_consultarMetodoPago_Click(object sender, EventArgs e)
        {
            Frm_consultaTipoPago conPago = new Frm_consultaTipoPago();
            conPago.ShowDialog();

            if (conPago.DialogResult == DialogResult.OK)
            {
                Lbl_metodo.Text = conPago.Dgv_consultaPago.Rows[conPago.Dgv_consultaPago.CurrentRow.Index].
                    Cells[0].Value.ToString();              
            }
        }

        private void Btn_consultarVehiculo_Click(object sender, EventArgs e)
        {
            Consulta.Frm_consultaTransporte conTransporte = new Consulta.Frm_consultaTransporte();
            conTransporte.ShowDialog();

            if (conTransporte.DialogResult == DialogResult.OK)
            {
                Lbl_vehiculo.Text =
                    conTransporte.Dgv_consultaTransporte.Rows[conTransporte.Dgv_consultaTransporte.CurrentRow.Index].
                    Cells[0].Value.ToString();

            }
            Btn_consultarPiloto.Enabled = true;
        }

        private void Btn_consultarPiloto_Click(object sender, EventArgs e)
        {
            Frm_consultaEmpleado con_Emp = new Frm_consultaEmpleado();
            con_Emp.ShowDialog();

            if (con_Emp.DialogResult == DialogResult.OK)
            {
                Lbl_piloto.Text = con_Emp.Dgv_consultaEmpleados.Rows[con_Emp.Dgv_consultaEmpleados.CurrentRow.Index].
                    Cells[0].Value.ToString();
            }
            Dtp_FecaSalida.Enabled = true;
        }
        
        private void Limpiar()
        {
            Lbl_reservacion.Text = "";
            Lbl_idCotizacion.Text = "";
            Lbl_nombCliente.Text = "";
            Lbl_metodo.Text = "";
            Lbl_vehiculo.Text = "";
            Lbl_piloto.Text = "";
            Dtp_FecaEntrada.Value = Dtp_FecaEntrada.Value.Date;
            Dtp_FecaSalida.Value = Dtp_FecaSalida.Value.Date;
            Dgv_detalleFactura.Rows.Clear();
            Dgv_detalleFactura.Refresh();
        }
        private void Btn_eliminar_Click(object sender, EventArgs e)
        {
            Limpiar();
            boton = 0;
            Desahiblitarbtn();
            Btn_consultarReservacion.Enabled = true;
            Btn_busquedaCotizacion.Enabled = true;
        }

        private void Btn_reservar_Click(object sender, EventArgs e)
        {
            //Reservacion
            idCotizacion = Lbl_idCotizacion.Text;
            tipoPago = Lbl_metodo.Text;
            //Asig Transp
            idTrasnporte = Lbl_vehiculo.Text;
            idEmpleado = Lbl_piloto.Text;
            fechaSalida = Dtp_FecaSalida.Text;
            fechaEntrada = Dtp_FecaEntrada.Text;
            if (Lbl_idCotizacion.Text == "" || Lbl_metodo.Text == "" || Lbl_vehiculo.Text == "" || Lbl_piloto.Text == "")
                MessageBox.Show("Algunos campos estan vacios.");
            else
            {
                try
                {
                    //Procedimiento para guardar reservacion
                    OdbcCommand comm2 = new OdbcCommand("{call Sp_InsertarReservacion(?,?)}", Conexion.nuevaConexion());
                    comm2.CommandType = CommandType.StoredProcedure;
                    comm2.Parameters.Add("idCotizacion", OdbcType.Text).Value = idCotizacion;
                    comm2.Parameters.Add("idPago", OdbcType.Text).Value = tipoPago;
                    comm2.ExecuteNonQuery(); MessageBox.Show("Reservacion creada exitosamente");
                    comm2.Connection.Close();

                    //Consulta para mostrar el ultimo campo ingresado en las reservaciones
                    string consultaMostrar = "select * from tbl_reservacion order by PK_idReservacion desc limit 1;";
                    OdbcCommand comm3 = new OdbcCommand(consultaMostrar, Conexion.nuevaConexion());
                    OdbcDataReader mostrarDatos = comm3.ExecuteReader();
                    while (mostrarDatos.Read())
                    {
                        idReservacion = mostrarDatos.GetString(0);
                    }
                    comm3.Connection.Close();
                    mostrarDatos.Close();
                    /*
                    int x = 0;

                    Int32.TryParse(idReservacion,out x);
                    if (x == 0)
                      */
                    if (idReservacion == "NULL")
                        Lbl_reservacion.Text = "0";
                    else
                        Lbl_reservacion.Text = idReservacion;

                    //Procedimiento para guardar asignacion de trasporte 
                    OdbcCommand comm4 = new OdbcCommand("{call Sp_InsertarAsigacionTransporte(?,?,?,?,?)}", Conexion.nuevaConexion());
                    comm4.CommandType = CommandType.StoredProcedure;
                    comm4.Parameters.Add("idTransporte", OdbcType.Text).Value = idTrasnporte;
                    comm4.Parameters.Add("idReservacion", OdbcType.Text).Value = idReservacion;
                    comm4.Parameters.Add("idEmpleado", OdbcType.Text).Value = idEmpleado;
                    comm4.Parameters.Add("salida", OdbcType.Text).Value = fechaSalida;
                    comm4.Parameters.Add("entrada", OdbcType.Text).Value = fechaEntrada;
                    comm4.ExecuteNonQuery(); MessageBox.Show("Reservacion transporte");
                    comm4.Connection.Close();

                    //Cambio de estado para cotizacion (Deja de ser una cotizacion y pasara a factura)
                    string consulta = "UPDATE `tbl_facturaencabezado` SET `Factura_Cotizacion` = '" + 1 +
                   "' WHERE Pk_idFactura = " + idReservacion;

                    OdbcCommand comm = new OdbcCommand(consulta, Conexion.nuevaConexion());
                    comm.ExecuteNonQuery();
                    comm.Connection.Close();
                    
                    //Bitacora
                    OdbcCommand comm1 = new OdbcCommand("{call SP_InsertarBitacora(?,?,?,?,?)}", Conexion.nuevaConexion());
                    comm1.CommandType = CommandType.StoredProcedure;
                    comm1.Parameters.Add("ope", OdbcType.Text).Value = "CREACION DE RESERVACION/ASIGNACION TRANSPORTE";
                    comm1.Parameters.Add("usr", OdbcType.Text).Value = usuario;
                    comm1.Parameters.Add("fecha", OdbcType.Text).Value = fechai.ToString("yyyy/MM/dd HH:mm:ss");
                    comm1.Parameters.Add("proc", OdbcType.Text).Value = "Empleado";
                    comm1.Parameters.Add("dirIp", OdbcType.Text).Value = localIP;
                    comm1.ExecuteNonQuery();
                    comm1.Connection.Close();

                }
                catch (Exception err)
                {
                    Console.WriteLine(err.Message);
                    MessageBox.Show("Error al intentar reservar.");
                }
                Limpiar();
                Desahiblitarbtn();
            }
        }

        private void Btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Dtp_FecaSalida_ValueChanged(object sender, EventArgs e)
        {
            DateTime fechaHoy = DateTime.Now;
            string fecha = fechaHoy.ToString("d");
            if (Dtp_FecaSalida.Value == fechaHoy || Dtp_FecaSalida.Value < fechaHoy)
                Btn_reservar.Enabled = false;
            //MessageBox.Show("Fecha incorrecta.");
            else
                Dtp_FecaEntrada.Enabled = true;
            //MessageBox.Show("Fecha correcta.");


        }
        /*
            Dtp_FecaSalida.Enabled = false;
            Btn_reservar.Enabled = true;
         */
        private void Dtp_FecaEntrada_ValueChanged(object sender, EventArgs e)
        {
            if (boton == 1)
            {
                if (Dtp_FecaSalida.Value > Dtp_FecaEntrada.Value)
                    Btn_modificar.Enabled = false;
                //MessageBox.Show("Fecha incorrecta.");
                else
                    Btn_modificar.Enabled = true;
                //MessageBox.Show("Fecha correcta.");
            }
            else
            {
                if (Dtp_FecaSalida.Value > Dtp_FecaEntrada.Value)
                    Btn_reservar.Enabled = false;
                //MessageBox.Show("Fecha incorrecta.");
                else
                    Btn_reservar.Enabled = true;
                //MessageBox.Show("Fecha correcta.");
            }

        }

        private void Pnl_principal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            idCotizacion = Lbl_idCotizacion.Text;
            tipoPago = Lbl_metodo.Text;
            idTrasnporte = Lbl_vehiculo.Text;
            idEmpleado = Lbl_piloto.Text;
            fechaSalida = Dtp_FecaSalida.Text;
            fechaEntrada = Dtp_FecaEntrada.Text;
           // MessageBox.Show(idCotizacion+" " + tipoPago + " " + idReservacion + " " + idTrasnporte + " " + idEmpleado + " " + fechaSalida + " " + fechaEntrada, idAsignacion);
            try
            {
                //PROCEDIMIENTO DE MODIFICACION
                OdbcCommand comm = new OdbcCommand("{call  Sp_ModificarReservacion(?,?,?,?,?,?,?,?)}", Conexion.nuevaConexion());
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.Add("idCotizacion", OdbcType.Text).Value = idCotizacion;
                comm.Parameters.Add("idPago", OdbcType.Text).Value = tipoPago;
                comm.Parameters.Add("cod", OdbcType.Text).Value = idReservacion;
                comm.Parameters.Add("idTransporte", OdbcType.Text).Value = idTrasnporte;
                comm.Parameters.Add("idEmpleado", OdbcType.Text).Value = idEmpleado;
                comm.Parameters.Add("salida", OdbcType.Text).Value = fechaSalida;
                comm.Parameters.Add("entrada", OdbcType.Text).Value = fechaEntrada;
                comm.Parameters.Add("cod2", OdbcType.Text).Value = idAsignacion;
                
                comm.ExecuteNonQuery();
                MessageBox.Show("Registro actualizado correctamente");
                comm.Connection.Close();
                
                //PROCEDIMIENTO DE BITACORA
                
                OdbcCommand comm1 = new OdbcCommand("{call SP_InsertarBitacora(?,?,?,?,?)}", Conexion.nuevaConexion());
                comm1.CommandType = CommandType.StoredProcedure;
                comm1.Parameters.Add("ope", OdbcType.Text).Value = "REGISTRO MODIFICADO";
                comm1.Parameters.Add("usr", OdbcType.Text).Value = usuario;
                comm1.Parameters.Add("fecha", OdbcType.Text).Value = fechai.ToString("yyyy/MM/dd HH:mm:ss");
                comm1.Parameters.Add("proc", OdbcType.Text).Value = "RESERVACION";
                comm1.Parameters.Add("dirIp", OdbcType.Text).Value = localIP;
                comm1.ExecuteNonQuery();
                comm1.Connection.Close();
                
                Limpiar();
                boton = 0;
                Desahiblitarbtn();
                Btn_consultarReservacion.Enabled = true;
                Btn_busquedaCotizacion.Enabled = true;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                MessageBox.Show("Error al intentar actualizar el registro");
            }
        }

        private void Btn_consultarReservacion_Click(object sender, EventArgs e)
        {
            Frm_consultaReservacion conReservacion = new Frm_consultaReservacion();
            conReservacion.ShowDialog();

            if (conReservacion.DialogResult == DialogResult.OK)
            {
                Lbl_idCotizacion.Text = conReservacion.Dgv_consultaReservacion.Rows[conReservacion.Dgv_consultaReservacion.CurrentRow.Index].
                Cells[1].Value.ToString();
                Lbl_nombCliente.Text = conReservacion.Dgv_consultaReservacion.Rows[conReservacion.Dgv_consultaReservacion.CurrentRow.Index].
                Cells[0].Value.ToString();
                Lbl_metodo.Text = conReservacion.Dgv_consultaReservacion.Rows[conReservacion.Dgv_consultaReservacion.CurrentRow.Index].
                Cells[2].Value.ToString();
                Lbl_vehiculo.Text = conReservacion.Dgv_consultaReservacion.Rows[conReservacion.Dgv_consultaReservacion.CurrentRow.Index].
                Cells[4].Value.ToString();
                Lbl_piloto.Text = conReservacion.Dgv_consultaReservacion.Rows[conReservacion.Dgv_consultaReservacion.CurrentRow.Index].
                Cells[5].Value.ToString();
                Dtp_FecaEntrada.Text = conReservacion.Dgv_consultaReservacion.Rows[conReservacion.Dgv_consultaReservacion.CurrentRow.Index].
                Cells[7].Value.ToString();
                Dtp_FecaSalida.Text = conReservacion.Dgv_consultaReservacion.Rows[conReservacion.Dgv_consultaReservacion.CurrentRow.Index].
                Cells[6].Value.ToString();
                idAsignacion = conReservacion.Dgv_consultaReservacion.Rows[conReservacion.Dgv_consultaReservacion.CurrentRow.Index].
                Cells[3].Value.ToString();
                idReservacion = conReservacion.Dgv_consultaReservacion.Rows[conReservacion.Dgv_consultaReservacion.CurrentRow.Index].
                Cells[0].Value.ToString();
               
            }
            Dgv_detalleFactura.Rows.Clear();
            Dgv_detalleFactura.Refresh();
            if (Lbl_idCotizacion.Text == "" )
            {
                
            }
            else
            {
                Btn_reservar.Enabled = false;
                Btn_modificar.Enabled = true;
                Dtp_FecaEntrada.Enabled = false;
                Dtp_FecaSalida.Enabled = false;
                boton = 1;
            }

        }
    }
}
