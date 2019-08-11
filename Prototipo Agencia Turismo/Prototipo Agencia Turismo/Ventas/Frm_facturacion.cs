/* 
 -----------------------------------------------------
            AUTOR: Edson Juarez
  -----------------------------------------------------
*/

using Prototipo_Agencia_Turismo.Consulta;
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
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace Prototipo_Agencia_Turismo.Cotizacion
{
    public partial class Frm_facturacion : Form
    {
        DateTime fecha = DateTime.Now;
        string usuario = " ";
        int idEmpleado = 1;
        int factura_cotizacion = 0;

        //variable para almacenar y convertir la cantidad y precio de una habitación
        string precioHabitacion = " ";
        double precioHabitacionConvertido = 0;
        double totalPrecioHabitacion = 0;
        string cantidadHabitacion = " ";
        double cantidadHabitacionConvertido = 0;

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
            Grb_Hotel.Enabled = true;
            Grb_Restaurante.Enabled = true;
            Grb_LugarT.Enabled = true;
            Lbl_titulo.Text = "FACTURACIÓN";
            factura_cotizacion = 1;
        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private DataTable Cargar()
        {
            DataTable dt = new DataTable();
            string consultaTipoPago = "SELECT * FROM tbl_tipopagos";
            OdbcCommand comm = new OdbcCommand(consultaTipoPago, Conexion.nuevaConexion());
            OdbcDataAdapter adap = new OdbcDataAdapter(comm);
            adap.Fill(dt);
            comm.Connection.Close();
            return dt;
        }

        private void Frm_facturacion_Load(object sender, EventArgs e)
        {
            //Deshabilitar secciones del form 
            Grpbx_encabezado.Enabled = false;
            Grb_Hotel.Enabled = false;
            Grb_Restaurante.Enabled = false;
            Grb_LugarT.Enabled = false;

            Txt_IdEmpleado.Text = usuario;
            Lbl_fechaEmision.Text = fecha.ToString("yyyy/MM/dd");

            Cbo_tipoPago.DataSource = Cargar();
            Cbo_tipoPago.DisplayMember = "NombreTipoPago";
            Cbo_tipoPago.ValueMember = "Pk_idTipoPago";
        }

        private void Rbtn_facturacion_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void Rbtn_cotizacion_CheckedChanged(object sender, EventArgs e)
        {
            Grpbx_encabezado.Enabled = true;
            Grb_Hotel.Enabled = true;
            Grb_Restaurante.Enabled = true;
            Grb_LugarT.Enabled = true;
            Lbl_titulo.Text = "COTIZACIÓN";
            factura_cotizacion = 0;
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
        }

        private void Btn_consultaHotel_Click(object sender, EventArgs e)
        {
            Frm_consultaHotel consultaHotel = new Frm_consultaHotel();
            consultaHotel.ShowDialog();

            if (consultaHotel.DialogResult == DialogResult.OK)
            {
                Txt_lugarHotel.Text = consultaHotel.Dgv_consultaHotel.Rows[consultaHotel.Dgv_consultaHotel.CurrentRow.Index].Cells[1].Value.ToString();
            }
            Btn_consultaHabitación.Enabled = true;
        }

        private void Btn_consultaHabitación_Click(object sender, EventArgs e)
        {
            Frm_consultaHabitacion consultaHabitacion = new Frm_consultaHabitacion();
            consultaHabitacion.ShowDialog();

            

            if(consultaHabitacion.DialogResult == DialogResult.OK)
            {
                Txt_habitacion.Text = consultaHabitacion.Dgv_consultaHabitacion.Rows[consultaHabitacion.Dgv_consultaHabitacion.CurrentRow.Index].Cells[2].Value.ToString();
                Lbl_idHabitacion.Text = consultaHabitacion.Dgv_consultaHabitacion.Rows[consultaHabitacion.Dgv_consultaHabitacion.CurrentRow.Index].Cells[0].Value.ToString();
                precioHabitacion = consultaHabitacion.Dgv_consultaHabitacion.Rows[consultaHabitacion.Dgv_consultaHabitacion.CurrentRow.Index].Cells[4].Value.ToString();
            }
            cantidadHabitacion = Cbo_noHab.SelectedIndex.ToString();

            //Conversiones de precio y cantidad de la habitación
            precioHabitacionConvertido = Convert.ToDouble(precioHabitacion);
            cantidadHabitacionConvertido = Convert.ToDouble(cantidadHabitacion);

            //Calculo del total
            totalPrecioHabitacion = precioHabitacionConvertido * cantidadHabitacionConvertido + precioHabitacionConvertido;
            Lbl_precioHabitacion.Text = Convert.ToString(totalPrecioHabitacion);
        }

        private void Btn_consultaRestaurante_Click(object sender, EventArgs e)
        {
            Frm_consultaRestaurante consultaRestaurante = new Frm_consultaRestaurante();
            consultaRestaurante.ShowDialog();

            if(consultaRestaurante.DialogResult == DialogResult.OK)
            {
                Txt_lugarRestaurante.Text = consultaRestaurante.Dgv_consultaRestaurante.Rows[consultaRestaurante.Dgv_consultaRestaurante.CurrentRow.Index].Cells[1].Value.ToString();
            }
            Btn_consultaMenu.Enabled = true;
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
        }

        int contadorFila = 0; //controla que los campos no se asignen en la misma fila del Dgv
        double total = 0;

        private void Btn_colocar_Click(object sender, EventArgs e)
        {
            //Si no existe nada en el Dgv
            if(contadorFila == 0)
            {
                if (string.IsNullOrEmpty(Txt_habitacion.Text) == true || string.IsNullOrEmpty(Cbo_noHab.Text) == true ||
                    string.IsNullOrEmpty(Txt_menu.Text) == true || string.IsNullOrEmpty(Txt_lugarTuristico.Text) == true)
                {

                    MessageBox.Show("Algunos campos no han sido llenados");
                }
                else
                {
                    //agrega los valores de los Labels al DataGrid
                    Dgv_detalleFactura.Rows.Add(Lbl_idHabitacion.Text, Lbl_idMenu.Text, Lbl_idLugarT.Text,
                    Cbo_noHab.SelectedIndex.ToString());

                    //Suma los precios de cada servicio
                    double importe = Convert.ToDouble(Lbl_precioHabitacion.Text) + Convert.ToDouble(Lbl_precioMenu.Text)
                        + Convert.ToDouble(Lbl_precioLugarT.Text);

                    Dgv_detalleFactura.Rows[contadorFila].Cells[4].Value = importe;
                    contadorFila++;
                }
            }
            else
            {
                if (string.IsNullOrEmpty(Txt_habitacion.Text) == true || string.IsNullOrEmpty(Cbo_noHab.Text) == true ||
                  string.IsNullOrEmpty(Txt_menu.Text) == true || string.IsNullOrEmpty(Txt_lugarTuristico.Text) == true)
                {

                    MessageBox.Show("Algunos campos no han sido llenados");
                }
                else
                {
                    //agrega los valores de los Labels al DataGrid
                    Dgv_detalleFactura.Rows.Add(Lbl_idHabitacion.Text, Lbl_idMenu.Text, Lbl_idLugarT.Text,
                    Cbo_noHab.SelectedIndex.ToString());

                    //Suma los precios de cada servicio
                    double importe = Convert.ToDouble(Lbl_precioHabitacion.Text) + Convert.ToDouble(Lbl_precioMenu.Text)
                        + Convert.ToDouble(Lbl_precioLugarT.Text);

                    Dgv_detalleFactura.Rows[contadorFila].Cells[4].Value = importe;
                    contadorFila++;
                }
            }
            total = 0;

            //recorrera todas las filas del Dgv
            foreach(DataGridViewRow Fila in Dgv_detalleFactura.Rows)
            {
                //calculará el total de la factura
                total += Convert.ToDouble(Fila.Cells[4].Value);
            }
            Lbl_resultado.Text = " " + total.ToString();

            LimpiarDetalle();
        }

        private void Btn_quitar_Click(object sender, EventArgs e)
        {
            //Si existe algún dato en el Dgv
            if(contadorFila > 0)
            {
                total = total - Convert.ToDouble(Dgv_detalleFactura.Rows[Dgv_detalleFactura.CurrentRow.Index]
                    .Cells[4].Value);

                Lbl_resultado.Text = " " + total.ToString();

                Dgv_detalleFactura.Rows.RemoveAt(Dgv_detalleFactura.CurrentRow.Index);
                contadorFila--;
            }
            else
            {
                MessageBox.Show("No hay ningún campo para elminar");
            }
        }

        private void Limpiar()
        {
            Lbl_resultado.Text = " ";
            //Área de encabezado
            Txt_codigoCliente.Text = " ";
            Txt_cliente.Text = " ";
            Cbo_Pasajero.Text = " ";

            //Área de selección de habitación
            Txt_lugarHotel.Text = " ";
            Txt_habitacion.Text = " ";
            Lbl_idHabitacion.Text = " ";
            Cbo_noHab.Text = " ";
            Lbl_precioHabitacion.Text = " ";

            //Área de selección de menú
            Txt_lugarRestaurante.Text = " ";
            Txt_menu.Text = " ";
            Lbl_idMenu.Text = " ";
            Lbl_precioMenu.Text = " ";

            //Área de lugar turístico
            Txt_lugarTuristico.Text = " ";
            Lbl_idLugarT.Text = " ";
            Lbl_precioLugarT.Text = " ";
        }

        private void LimpiarDetalle()
        {
            //Área de selección de habitación
            Txt_lugarHotel.Text = "";
            Txt_habitacion.Text = "";
            Lbl_idHabitacion.Text = "";
            Cbo_noHab.Text = "";
            Lbl_precioHabitacion.Text = "";

            //Área de selección de menú
            Txt_lugarRestaurante.Text = "";
            Txt_menu.Text = "";
            Lbl_idMenu.Text = "";
            Lbl_precioMenu.Text = "";

            //Área de lugar turístico
            Txt_lugarTuristico.Text = "";
            Lbl_idLugarT.Text = "";
            Lbl_precioLugarT.Text = "";
        }

        int codLinea = 0;
        int numFactura = 0;
        private void obtenerCodigoLinea()
        {
            
        }

        private void Btn_facturar_Click(object sender, EventArgs e)
        {
            //algoritmo para obtener la dirección IP de la máquina
            IPHostEntry host;
            string localIP = "?";
            host = Dns.GetHostEntry(Dns.GetHostName());

            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily.ToString() == "InterNetwork")
                {
                    localIP = ip.ToString();
                }
            } //fin de algoritmo

            if (contadorFila > 0)
            {
                try
                {
                    int idCliente = Convert.ToInt32(Txt_codigoCliente.Text);
                    
                    //inserta registro de factura encabezado a la BD
                    string consultaInsertar = "INSERT INTO tbl_facturaencabezado (Pk_idCliente, Pk_idEmpleado, fechaCotizacion," +
                         "cantidadPasajeros, Fk_idTipoPago, Total, Factura_Cotizacion) VALUES('"+idCliente+"' , " +
                         "'"+idEmpleado+"', '"+Lbl_fechaEmision.Text+"', '"+Convert.ToInt32(Cbo_Pasajero.Text)+"', " +
                         "'"+Convert.ToInt32(Cbo_tipoPago.SelectedValue)+"', '"+Convert.ToInt32(Lbl_resultado.Text)+"', " +
                         "'"+factura_cotizacion+"')";

                    OdbcCommand comm = new OdbcCommand(consultaInsertar, Conexion.nuevaConexion());
                    comm.ExecuteNonQuery();
                    comm.Connection.Close();

                    //Selecciona el Id actual de la factura
                    comm = new OdbcCommand("SELECT MAX(Pk_idFactura) FROM tbl_facturaencabezado;", Conexion.nuevaConexion());
                    OdbcDataReader consulta = comm.ExecuteReader();

                    while(consulta.Read())
                    {
                        numFactura = consulta.GetInt32(0);
                    }
                    comm.Connection.Close();
                    consulta.Close();

                    Random rnd = new Random();
                    //Recorrera cada fila del Dgv
                    foreach (DataGridViewRow Fila in Dgv_detalleFactura.Rows)
                    {
                        codLinea = rnd.Next();
                        consultaInsertar = "INSERT INTO tbl_facturadetalle (Pk_idFactura, Pk_codigoLinea, " +
                            "Fk_idTipoHabitacion, FK_idMenus, Fk_idLugarTuristico, cantidadHabitaciones) VALUES(" +
                            "'" + numFactura + "', '" + codLinea + "', '" + Convert.ToInt32(Fila.Cells[0].Value.ToString()) + "'," +
                            "'" + Convert.ToInt32(Fila.Cells[1].Value.ToString()) + "', '" + Fila.Cells[2].Value.ToString() + "'," +
                            "'" + Convert.ToInt32(Fila.Cells[3].Value.ToString()) + "')";

                        comm = new OdbcCommand(consultaInsertar, Conexion.nuevaConexion());
                        comm.ExecuteNonQuery();
                    }
                    comm.Connection.Close();
                    
                    MessageBox.Show("Se realizo la factura correctamente");
                    Dgv_detalleFactura.Rows.Clear();
                    Limpiar();
                    Grpbx_encabezado.Enabled = true;
                    contadorFila = 0;

                    OdbcCommand commBitacora = new OdbcCommand("{call SP_InsertarBitacora(?,?,?,?,?)}", Conexion.nuevaConexion());
                    commBitacora.CommandType = CommandType.StoredProcedure;
                    commBitacora.Parameters.Add("ope", OdbcType.Text).Value = "PROCESO DE FACTURACIÓN";
                    commBitacora.Parameters.Add("usr", OdbcType.Text).Value = usuario;
                    commBitacora.Parameters.Add("fecha", OdbcType.Text).Value = fecha.ToString("yyyy/MM/dd HH:mm:ss");
                    commBitacora.Parameters.Add("proc", OdbcType.Text).Value = "VENTAS";
                    commBitacora.Parameters.Add("dirIp", OdbcType.Text).Value = localIP;
                    commBitacora.ExecuteNonQuery();

                    commBitacora.Connection.Close();

                    Frm_reporteFactura reporteFactura = new Frm_reporteFactura();
                    ReportDocument oRep = new ReportDocument();
                    ParameterField pf = new ParameterField();
                    ParameterFields pfs = new ParameterFields();
                    ParameterDiscreteValue pdv = new ParameterDiscreteValue();
                    pf.Name = "numFac"; // variable del store procedure
                    pdv.Value = numFactura; // variable donde se  guarda el numero de factura
                    pf.CurrentValues.Add(pdv);
                    pfs.Add(pf);
                    reporteFactura.crystalReportViewer1.ParameterFieldInfo = pfs;
                    oRep.Load("C:/Reportes/reporteFactura.rpt");
                    reporteFactura.crystalReportViewer1.ReportSource = oRep;
                    reporteFactura.Show();
                    
                }
                catch(Exception err)
                {
                    Console.WriteLine(err.Message);
                    MessageBox.Show("Error al realizar la factura");
                }
            }
            else
            {
                MessageBox.Show("No se han ingresado campos para facturar");
            }
        }

        private void Btn_ayuda_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "C:\\Ayudas Agencia Turismo.chm");
        }
    }
}
