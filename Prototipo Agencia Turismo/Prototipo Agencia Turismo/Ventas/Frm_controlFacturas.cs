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
using System.Data.Odbc;
using System.Net;

namespace Prototipo_Agencia_Turismo.Ventas
{
    public partial class Frm_controlFacturas : Form
    {
        string usuario = " ";
        DateTime fecha = DateTime.Now;

        public Frm_controlFacturas(string nombreUsuario)
        {
            InitializeComponent();
            usuario = nombreUsuario;
        }

        private void LimpiarEncabezado()
        {
            Lbl_idCliente.Text = "";
            Lbl_idTipoPago.Text = "";
            Lbl_codFactura.Text = "";
            Txt_cliente.Text = "";
            Lbl_fechaEmision.Text = "";
            Cbo_Pasajero.Text = "";
            Cmbx_tipoPago.Text = "";
        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Frm_controlFacturas_Load(object sender, EventArgs e)
        {

        }

        private void Rbtn_eliminar_CheckedChanged(object sender, EventArgs e)
        {
            Grpbx_encabezado.Enabled = true;
            Cmbx_tipoPago.Enabled = false;
            Cbo_Pasajero.Enabled = false;

            Btn_facturar.Text = "Eliminar factura";
            Btn_facturar.Enabled = true;
            Btn_facturar.Focus();
        }

        private void Btn_consultaFactura_Click(object sender, EventArgs e)
        {
            Frm_consultaCotizacion consultaFactura = new Frm_consultaCotizacion();
            consultaFactura.ShowDialog();

            if(consultaFactura.DialogResult == DialogResult.OK)
            {
                Lbl_codFactura.Text =
                    consultaFactura.Dgv_consultaCotizacion.Rows[consultaFactura.Dgv_consultaCotizacion.CurrentRow.Index].
                        Cells[0].Value.ToString();

                Lbl_idCliente.Text =
                    consultaFactura.Dgv_consultaCotizacion.Rows[consultaFactura.Dgv_consultaCotizacion.CurrentRow.Index].
                        Cells[1].Value.ToString();

                Lbl_fechaEmision.Text =
                    consultaFactura.Dgv_consultaCotizacion.Rows[consultaFactura.Dgv_consultaCotizacion.CurrentRow.Index].
                        Cells[3].Value.ToString();

                Cbo_Pasajero.Text =
                    consultaFactura.Dgv_consultaCotizacion.Rows[consultaFactura.Dgv_consultaCotizacion.CurrentRow.Index].
                        Cells[4].Value.ToString();

                Lbl_idTipoPago.Text =
                    consultaFactura.Dgv_consultaCotizacion.Rows[consultaFactura.Dgv_consultaCotizacion.CurrentRow.Index].
                        Cells[5].Value.ToString();

                Lbl_resultado.Text =
                    consultaFactura.Dgv_consultaCotizacion.Rows[consultaFactura.Dgv_consultaCotizacion.CurrentRow.Index].
                        Cells[6].Value.ToString();

                try
                {
                    string mostrarTipoPago = "SELECT T.NombreTipoPago FROM tbl_tipopagos T INNER JOIN " +
                        "tbl_facturaencabezado FE ON T.Pk_idTipoPago = " + Lbl_idTipoPago.Text;

                    OdbcCommand comm = new OdbcCommand(mostrarTipoPago, Conexion.nuevaConexion());
                    OdbcDataReader mostrarDatos = comm.ExecuteReader();

                    if (mostrarDatos.Read())
                    {
                        Cmbx_tipoPago.Text = mostrarDatos.GetString(0);
                    }
                    comm.Connection.Close();
                    mostrarDatos.Close();

                    string mostrarNombreCliente = "SELECT C.nombreCliente FROM tbl_cliente C INNER JOIN " +
                        "tbl_facturaencabezado FE ON C.Pk_idCliente = " + Lbl_idCliente.Text;

                    comm = new OdbcCommand(mostrarNombreCliente, Conexion.nuevaConexion());
                    mostrarDatos = comm.ExecuteReader();

                    if(mostrarDatos.Read())
                    {
                        Txt_cliente.Text = mostrarDatos.GetString(0);
                    }
                    comm.Connection.Close();
                    mostrarDatos.Close();

                    string mostrarDetalleFactura = "SELECT * FROM tbl_facturadetalle WHERE Pk_idFactura = " + Lbl_codFactura.Text;
                    comm = new OdbcCommand(mostrarDetalleFactura, Conexion.nuevaConexion());
                    mostrarDatos = comm.ExecuteReader();

                    Dgv_detalleFactura.Rows.Clear();
                    while(mostrarDatos.Read())
                    {
                        Dgv_detalleFactura.Rows.Add(mostrarDatos.GetString(0), mostrarDatos.GetString(1),
                            mostrarDatos.GetString(2), mostrarDatos.GetString(3), "xxxxx");
                    }
                }
                catch(Exception err)
                {
                    Console.WriteLine(err.Message);
                }
            }
        }

        private void Btn_facturar_Click(object sender, EventArgs e)
        {
            if(Btn_facturar.Text == "Eliminar factura")
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

                try
                {
                    string eliminarFactura = "UPDATE tbl_facturaencabezado SET estado = 1 WHERE Pk_idFactura = " + Lbl_codFactura.Text;
                    OdbcCommand comm = new OdbcCommand(eliminarFactura, Conexion.nuevaConexion());
                    comm.ExecuteNonQuery();
                    comm.Connection.Close();

                    OdbcCommand commBitacora = new OdbcCommand("{call SP_InsertarBitacora(?,?,?,?,?)}", Conexion.nuevaConexion());
                    commBitacora.CommandType = CommandType.StoredProcedure;
                    commBitacora.Parameters.Add("ope", OdbcType.Text).Value = "ELIMINACIÓN DE FACTURA";
                    commBitacora.Parameters.Add("usr", OdbcType.Text).Value = usuario;
                    commBitacora.Parameters.Add("fecha", OdbcType.Text).Value = fecha.ToString("yyyy/MM/dd HH:mm:ss");
                    commBitacora.Parameters.Add("proc", OdbcType.Text).Value = "CONTROL DE FACTURAS";
                    commBitacora.Parameters.Add("dirIp", OdbcType.Text).Value = localIP;
                    commBitacora.ExecuteNonQuery();

                    commBitacora.Connection.Close();

                    MessageBox.Show("La factura ha sido eliminada");
                    LimpiarEncabezado();
                    Dgv_detalleFactura.Rows.Clear();
                }
                catch(Exception err)
                {
                    Console.WriteLine(err.Message);
                    MessageBox.Show("No se ha ingresado ninguna factura para eliminar");
                }
            }
            else
            {

            }
        }

        private void Btn_ayuda_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "C:\\Ayudas Agencia Turismo.chm");
        }
    }
}
