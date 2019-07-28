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
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Prototipo_Agencia_Turismo.Form1;

namespace Prototipo_Agencia_Turismo.Mantenimiento
{
    public partial class Frm_mantMenuscs : Form
    {
        //Declaracion de variables globales

        bool presionado = false;
        string usuario;
        DateTime fecha = DateTime.Now;

        string idMenu = " ";
        string idRestaurante = " ";
        string nombre = " ";
        string descripcion = " ";
        string precio = " ";

        //Validaciones
        Validacion v = new Validacion();

        //Metodos
        private void DeshabilitarCampos()
        {
            Txt_idMenu.Enabled = false;
            Txt_restaurante.Enabled = false;
            Txt_nombre.Enabled = false;
            Txt_descipcion.Enabled = false;
            Txt_precio.Enabled = false;
            Btn_busqueda.Enabled = false;
        }

        private void HabilitarCampos()
        {
            Txt_idMenu.Enabled = false;
            Txt_restaurante.Enabled = false;
            Txt_nombre.Enabled = true;
            Txt_descipcion.Enabled = true;
            Txt_precio.Enabled = true;
            Btn_busqueda.Enabled = true;
        }

        private void DeshabilitarBtn()
        {
            Btn_ingresar.Enabled = false;
            Btn_editar.Enabled = false;
            Btn_guardar.Enabled = false;
            Btn_borrar.Enabled = false;
            Btn_consultar.Enabled = false;
        }

        private void HabilitarBtn()
        {
            Btn_ingresar.Enabled = true;
            Btn_editar.Enabled = true;
            Btn_guardar.Enabled = true;
            Btn_borrar.Enabled = true;
            Btn_consultar.Enabled = true;
        }

        private void Limpiar()
        {
            Txt_idMenu.Text = "";
            Txt_restaurante.Text = "";
            Txt_nombre.Text = "";
            Txt_descipcion.Text = "";
            Txt_precio.Text = "";
        }
        public Frm_mantMenuscs()
        {
            InitializeComponent();
        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

       

        private void Btn_busqueda_Click(object sender, EventArgs e)
        {
            if (presionado == false)
            {
                DeshabilitarBtn();
                Btn_consultar.Enabled = true;
                presionado = true;
            }
            else
            {

                Frm_consultaRestaurante conRestaurante = new Frm_consultaRestaurante();
                conRestaurante.ShowDialog();

                if (conRestaurante.DialogResult == DialogResult.OK)
                {
                    Txt_restaurante.Text = conRestaurante.Dgv_consultaRestaurante.Rows[conRestaurante.Dgv_consultaRestaurante.CurrentRow.Index].
                    Cells[0].Value.ToString();


                    Txt_nombre.Focus();
                    presionado = false;
                    HabilitarBtn();
                }
            }
        }

        private void Btn_ingresar_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
            Txt_nombre.Focus();
        }

        private void ActualizarDatos()
        {
            idMenu = Txt_idMenu.Text;
            nombre = Txt_nombre.Text;
            descripcion = Txt_descipcion.Text;
            precio = Txt_precio.Text;
            idRestaurante = Txt_restaurante.Text;
           
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
                string consulta = "UPDATE `tbl_menus` SET `Fk_idRestaurantes` = '" + idRestaurante + "'" +
                    ", `nombreMenu` = '" + nombre + "', `descripcionMenu` = '" + descripcion + "', `precioMenu` = '" + precio +
                    "' WHERE Pk_idmenus = " + idMenu;

                OdbcCommand comm = new OdbcCommand(consulta, Conexion.nuevaConexion());
                comm.ExecuteNonQuery();
                MessageBox.Show("Registro actualizado correctamente");

                OdbcCommand comm1 = new OdbcCommand("{call SP_InsertarBitacora(?,?,?,?,?)}", Conexion.nuevaConexion());
                comm1.CommandType = CommandType.StoredProcedure;
                comm1.Parameters.Add("ope", OdbcType.Text).Value = "ACTUALIZACIÓN DE REGISTRO";
                comm1.Parameters.Add("usr", OdbcType.Text).Value = usuario;
                comm1.Parameters.Add("fecha", OdbcType.Text).Value = fecha.ToString("yyyy/MM/dd HH:mm:ss");
                comm1.Parameters.Add("proc", OdbcType.Text).Value = "MENUS";
                comm1.Parameters.Add("dirIp", OdbcType.Text).Value = localIP;
                comm1.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                MessageBox.Show("Error al intentar actualizar el registro");
            }
        }

        private void Btn_editar_Click(object sender, EventArgs e)
        {
            if (presionado == false)
            {
                DeshabilitarBtn();
                Btn_editar.Enabled = true;
                HabilitarCampos();
                presionado = true;
                Txt_idMenu.Enabled = false;
                Txt_restaurante.Enabled = false;
            }
            else
            {
                ActualizarDatos();
                Txt_nombre.Focus();
                presionado = false;
                DeshabilitarCampos();
                HabilitarBtn();
                Limpiar();
            }
        }

        private void GuardarDatos()
        {
            idMenu = Txt_idMenu.Text;
            nombre = Txt_nombre.Text;
            descripcion = Txt_descipcion.Text;
            precio = Txt_precio.Text;
            idRestaurante = Txt_restaurante.Text;

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
                string consulta = "INSERT INTO `tbl_menus` VALUES ('" + 0 + "', '" + idRestaurante + "', '" + nombre + "'," +
                    " '" + descripcion + "', '" + precio + "', '" + 1 + "')";

                OdbcCommand comm = new OdbcCommand(consulta, Conexion.nuevaConexion());
                comm.ExecuteNonQuery();
                MessageBox.Show("Registro guardado correctamente");

                OdbcCommand comm1 = new OdbcCommand("{call SP_InsertarBitacora(?,?,?,?,?)}", Conexion.nuevaConexion());
                comm1.CommandType = CommandType.StoredProcedure;
                comm1.Parameters.Add("ope", OdbcType.Text).Value = "NUEVO REGISTRO";
                comm1.Parameters.Add("usr", OdbcType.Text).Value = usuario;
                comm1.Parameters.Add("fecha", OdbcType.Text).Value = fecha.ToString("yyyy/MM/dd HH:mm:ss");
                comm1.Parameters.Add("proc", OdbcType.Text).Value = "MENUS";
                comm1.Parameters.Add("dirIp", OdbcType.Text).Value = localIP;
                comm1.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                MessageBox.Show("Error al intentar guardar el registro");
            }
        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            if (presionado == false)
            {
                DeshabilitarBtn();
                Btn_guardar.Enabled = true;
                presionado = true;
            }
            else
            {
                GuardarDatos();
                presionado = false;
                DeshabilitarCampos();
                HabilitarBtn();
                Limpiar();
            }
        }

        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
            presionado = false;
            HabilitarBtn();
        }

        private void BorrarDatos()
        {
            idMenu = Txt_idMenu.Text;

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
                string consulta = "UPDATE `tbl_menus` SET `estadoMenu` = '" + 0 + 
                    "' WHERE Pk_idmenus = " + idMenu;

                OdbcCommand comm = new OdbcCommand(consulta, Conexion.nuevaConexion());
                comm.ExecuteNonQuery();
                MessageBox.Show("Registro eliminado correctamente");

                OdbcCommand comm1 = new OdbcCommand("{call SP_InsertarBitacora(?,?,?,?,?)}", Conexion.nuevaConexion());
                comm1.CommandType = CommandType.StoredProcedure;
                comm1.Parameters.Add("ope", OdbcType.Text).Value = "ACTUALIZACIÓN DE REGISTRO";
                comm1.Parameters.Add("usr", OdbcType.Text).Value = usuario;
                comm1.Parameters.Add("fecha", OdbcType.Text).Value = fecha.ToString("yyyy/MM/dd HH:mm:ss");
                comm1.Parameters.Add("proc", OdbcType.Text).Value = "MENUS";
                comm1.Parameters.Add("dirIp", OdbcType.Text).Value = localIP;
                comm1.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                MessageBox.Show("Error al intentar eliminar el registro");
            }
        }

        private void Btn_borrar_Click(object sender, EventArgs e)
        {
            if (presionado == false)
            {
                DeshabilitarBtn();
                Btn_borrar.Enabled = true;
                presionado = true;
            }
            else
            {
                BorrarDatos();
                Txt_nombre.Focus();
                presionado = false;
                DeshabilitarCampos();
                HabilitarBtn();
                Limpiar();
            }
        }

        private void Btn_consultar_Click(object sender, EventArgs e)
        {
            if (presionado == false)
            {
                DeshabilitarBtn();
                Btn_consultar.Enabled = true;
                presionado = true;
            }
            else
            {

                Frm_consultaMenu conMenu = new Frm_consultaMenu();
                conMenu.ShowDialog();

                if (conMenu.DialogResult == DialogResult.OK)
                {
                    Txt_idMenu.Text = conMenu.Dgv_consultaMenu.Rows[conMenu.Dgv_consultaMenu.CurrentRow.Index].
                        Cells[0].Value.ToString();
                    Txt_restaurante.Text = conMenu.Dgv_consultaMenu.Rows[conMenu.Dgv_consultaMenu.CurrentRow.Index].
                        Cells[1].Value.ToString();
                    Txt_nombre.Text = conMenu.Dgv_consultaMenu.Rows[conMenu.Dgv_consultaMenu.CurrentRow.Index].
                        Cells[2].Value.ToString();
                    Txt_descipcion.Text = conMenu.Dgv_consultaMenu.Rows[conMenu.Dgv_consultaMenu.CurrentRow.Index].
                        Cells[3].Value.ToString();
                    Txt_precio.Text = conMenu.Dgv_consultaMenu.Rows[conMenu.Dgv_consultaMenu.CurrentRow.Index].
                        Cells[4].Value.ToString();


                    Txt_nombre.Focus();
                    presionado = false;
                    HabilitarBtn();
                }
            }
        }

        private void Frm_mantMenuscs_Load(object sender, EventArgs e)
        {
            DeshabilitarCampos();
        }

        private void Txt_precio_KeyUp(object sender, KeyEventArgs e)
        {
            Funciones.ValidarCampoDecimal((TextBox)sender);
        }
    }
}
