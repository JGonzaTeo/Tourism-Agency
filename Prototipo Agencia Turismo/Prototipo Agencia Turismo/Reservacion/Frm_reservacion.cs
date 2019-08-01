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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototipo_Agencia_Turismo
{
    public partial class Frm_reservacion : Form
    {
        //Reservacion
        String idCotizacion;
        String idReservacion;
        String tipoPago;
        //Asig Transp
        String idTrasnporte;
        String idEmpleado;
        String fechaSalida;
        String fechaEntrada;

        public Frm_reservacion()
        {
            InitializeComponent();
        }

        private void Frm_reservacion_Load(object sender, EventArgs e)
        {

        }

        private void Btn_busquedaCotizacion_Click(object sender, EventArgs e)
        {
                Frm_consultaRestaurante conRestaurante = new Frm_consultaRestaurante();
                conRestaurante.ShowDialog();

                if (conRestaurante.DialogResult == DialogResult.OK)
                {
                    Lbl_idCotizacion.Text = conRestaurante.Dgv_consultaRestaurante.Rows[conRestaurante.Dgv_consultaRestaurante.CurrentRow.Index].
                    Cells[0].Value.ToString();

                }
            
        }

        private void Btn_consultarMetodoPago_Click(object sender, EventArgs e)
        {
            Frm_consultaTipoPago conPago = new Frm_consultaTipoPago();
            conPago.ShowDialog();

            if (conPago.DialogResult == DialogResult.OK)
            {
                Lbl_metodoPago.Text = conPago.Dgv_consultaPago.Rows[conPago.Dgv_consultaPago.CurrentRow.Index].
                    Cells[0].Value.ToString();              
            }
        }

        private void Btn_consultarVehiculo_Click(object sender, EventArgs e)
        {
            Consulta.Frm_consultaTransporte conTransporte = new Consulta.Frm_consultaTransporte();
            conTransporte.ShowDialog();

            if (conTransporte.DialogResult == DialogResult.OK)
            {
                Lbl_idVehiculo.Text =
                    conTransporte.Dgv_consultaTransporte.Rows[conTransporte.Dgv_consultaTransporte.CurrentRow.Index].
                    Cells[0].Value.ToString();

            }
        }

        private void Btn_consultarPiloto_Click(object sender, EventArgs e)
        {
            Frm_consultaEmpleado con_Emp = new Frm_consultaEmpleado();
            con_Emp.ShowDialog();

            if (con_Emp.DialogResult == DialogResult.OK)
            {
                Lbl_idPiloto.Text = con_Emp.Dgv_consultaEmpleados.Rows[con_Emp.Dgv_consultaEmpleados.CurrentRow.Index].
                    Cells[0].Value.ToString();

            }
        }

        private void Btn_eliminar_Click(object sender, EventArgs e)
        {
 
            Lbl_idReservacion.Text = "";
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

        private void Btn_reservar_Click(object sender, EventArgs e)
        {
            fechaSalida = Dtp_FecaSalida.Text;
            fechaEntrada = Dtp_FecaEntrada.Text;
            OdbcCommand comm = new OdbcCommand("{call Sp_InsertarReservacion(?,?,?,?,?,?)}", Conexion.nuevaConexion());
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.Add("idTransporte", OdbcType.Text).Value = idTrasnporte;
            comm.Parameters.Add("idReservacion", OdbcType.Text).Value = idReservacion;
            comm.Parameters.Add("idEmpleado", OdbcType.Text).Value = idEmpleado;
            comm.Parameters.Add("salida", OdbcType.Text).Value = fechaSalida;
            comm.Parameters.Add("entrada", OdbcType.Text).Value = fechaEntrada;
            comm.ExecuteNonQuery(); MessageBox.Show("Registro Guardado correctamente");
            OdbcCommand comm2 = new OdbcCommand("{call Sp_InsertarReservacion(?,?)}", Conexion.nuevaConexion());
            comm2.CommandType = CommandType.StoredProcedure;
            comm2.Parameters.Add("idCotizacion", OdbcType.Text).Value = idCotizacion;
            comm2.Parameters.Add("idPago", OdbcType.Text).Value = tipoPago;
            comm2.ExecuteNonQuery(); MessageBox.Show("Registro Guardado correctamente");
        }
    }
}
