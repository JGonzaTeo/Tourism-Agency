/* 
 -----------------------------------------------------
            AUTOR: José Gonzalez
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

namespace Prototipo_Agencia_Turismo.Mantenimiento
{
    public partial class Frm_manGuiaTuristico : Form
    {

        IPHostEntry host;
        string localIP = "?";
        string nombreUsuario = " ";
        DateTime fechai = DateTime.Now;
        Validacion v = new Validacion();
        String cod_guia;
        String ruta;
        String descripcion;
        bool presionado = false;
        public Frm_manGuiaTuristico(String usuario)
        {
            InitializeComponent();
           nombreUsuario = usuario;
        }

        private void Habilitarcampos()
        {
            Txt_idguia.Enabled = true;
            Txt_ruta.Enabled = true;
            Txt_descripcion.Enabled = true;

        }


        private void Deshabilitarcampos()
        {
            Txt_idguia.Enabled = false;
            Txt_ruta.Enabled = false;
            Txt_descripcion.Enabled = false;

        }

        private void Habilitarbtn()
        {
            Btn_ingresar.Enabled = true;
            Btn_editar.Enabled = true;
            Btn_guardar.Enabled = true;
            Btn_borrar.Enabled = true;
            Btn_consultar.Enabled = true;
        }

        private void Desahiblitarbtn()
        {
            Btn_ingresar.Enabled = false;
            Btn_editar.Enabled = false;
            Btn_guardar.Enabled = false;
            Btn_borrar.Enabled = false;
            Btn_consultar.Enabled = false;
        }

        private void Limpiar()
        {
            Txt_idguia.Text = " ";
            Txt_ruta.Text = " ";
            Txt_descripcion.Text = " ";

        }

        private void ActualizarDatos()
        {
            cod_guia = Txt_idguia.Text;
            ruta = Txt_ruta.Text;
            descripcion = Txt_descripcion.Text;

            try
            {
                OdbcCommand comm = new OdbcCommand("{call  Sp_Modificarguia(?,?,?)}", Conexion.nuevaConexion());
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.Add("cod", OdbcType.Text).Value = cod_guia;
                comm.Parameters.Add("rut", OdbcType.Text).Value = ruta;
                comm.Parameters.Add("descrip", OdbcType.Text).Value = descripcion;
                comm.ExecuteNonQuery();
                MessageBox.Show("Registro actualizado correctamente");
                comm.Connection.Close();

                OdbcCommand comm1 = new OdbcCommand("{call SP_InsertarBitacora(?,?,?,?,?)}", Conexion.nuevaConexion());
                comm1.CommandType = CommandType.StoredProcedure;
                comm1.Parameters.Add("ope", OdbcType.Text).Value = "REGISTRO Modificado";
                comm1.Parameters.Add("usr", OdbcType.Text).Value = nombreUsuario;
                comm1.Parameters.Add("fecha", OdbcType.Text).Value = fechai.ToString("yyyy/MM/dd HH:mm:ss");
                comm1.Parameters.Add("proc", OdbcType.Text).Value = "Guia Turistico";
                comm1.Parameters.Add("dirIp", OdbcType.Text).Value = localIP;
                comm1.ExecuteNonQuery();
                comm1.Connection.Close();
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                MessageBox.Show("Error al intentar actualizar el registro");
            }
        }


        private void Guardardatos()
        {
            cod_guia = Txt_idguia.Text;
            ruta = Txt_ruta.Text;
            descripcion = Txt_descripcion.Text;

            try
            {
                OdbcCommand comm = new OdbcCommand("{call Sp_Insertarguia(?,?,?)}", Conexion.nuevaConexion());
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.Add("cod", OdbcType.Text).Value = cod_guia;
                comm.Parameters.Add("rut", OdbcType.Text).Value = ruta;
                comm.Parameters.Add("descrip", OdbcType.Text).Value = descripcion;
                comm.ExecuteNonQuery();
                MessageBox.Show("Registro Guardado correctamente");
                comm.Connection.Close();

                OdbcCommand comm1 = new OdbcCommand("{call SP_InsertarBitacora(?,?,?,?,?)}", Conexion.nuevaConexion());
                comm1.CommandType = CommandType.StoredProcedure;
                comm1.Parameters.Add("ope", OdbcType.Text).Value = "REGISTRO INGRESADO";
                comm1.Parameters.Add("usr", OdbcType.Text).Value = nombreUsuario;
                comm1.Parameters.Add("fecha", OdbcType.Text).Value = fechai.ToString("yyyy/MM/dd HH:mm:ss");
                comm1.Parameters.Add("proc", OdbcType.Text).Value = "Guia Turistico";
                comm1.Parameters.Add("dirIp", OdbcType.Text).Value = localIP;
                comm1.ExecuteNonQuery();
                comm1.Connection.Close();

            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                MessageBox.Show("Error al intentar actualizar el registro");
            }
        }

        private void Borrardatos()
        {
            cod_guia = Txt_idguia.Text;

            try
            {
                OdbcCommand comm = new OdbcCommand("{call Sp_Eliminarguia(?,?)}", Conexion.nuevaConexion());
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.Add("cod", OdbcType.Text).Value = cod_guia;
                comm.Parameters.Add("estdo", OdbcType.Text).Value = "1";
                comm.ExecuteNonQuery();
                MessageBox.Show("Registro eliminado correctamente");
                comm.Connection.Close();

                OdbcCommand comm1 = new OdbcCommand("{call SP_InsertarBitacora(?,?,?,?,?)}", Conexion.nuevaConexion());
                comm1.CommandType = CommandType.StoredProcedure;
                comm1.Parameters.Add("ope", OdbcType.Text).Value = "BORRAR REGISTRO";
                comm1.Parameters.Add("usr", OdbcType.Text).Value = nombreUsuario;
                comm1.Parameters.Add("fecha", OdbcType.Text).Value = fechai.ToString("yyyy/MM/dd HH:mm:ss");
                comm1.Parameters.Add("proc", OdbcType.Text).Value = "Guia Truristico";
                comm1.Parameters.Add("dirIp", OdbcType.Text).Value = localIP;
                comm1.ExecuteNonQuery();
                comm1.Connection.Close();
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                MessageBox.Show("Error al intentar borrar el registro");
            }
        }

        private void Btn_ingresar_Click(object sender, EventArgs e)
        {
            Habilitarcampos();
        }

        private void Btn_editar_Click(object sender, EventArgs e)
        {

            if (presionado == false)
            {
                Desahiblitarbtn();
                Btn_editar.Enabled = true;
                presionado = true;
                Txt_idguia.Enabled = false;
            }
            else
            {
                ActualizarDatos();
                Txt_idguia.Focus();
                presionado = false;
                Deshabilitarcampos();
                Habilitarbtn();
                Limpiar();
            }
        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            if (presionado == false)
            {
                Desahiblitarbtn();
                Btn_guardar.Enabled = true;
                presionado = true;
            }
            else
            {
                Guardardatos();
                Txt_idguia.Focus();
                presionado = false;
                Deshabilitarcampos();
                Habilitarbtn();
                Limpiar();

            }
        }

        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
            presionado = false;
            Habilitarbtn();
        }

        private void Btn_borrar_Click(object sender, EventArgs e)
        {
            if (presionado == false)
            {
                Desahiblitarbtn();
                Btn_borrar.Enabled = true;
                presionado = true;
            }
            else
            {
                Borrardatos();
                Txt_idguia.Focus();
                presionado = false;
                Deshabilitarcampos();
                Habilitarbtn();
                Limpiar();
            }
        }

        private void Btn_consultar_Click(object sender, EventArgs e)
        {
            if (presionado == false)
            {
                Desahiblitarbtn();
                Btn_consultar.Enabled = true;
                presionado = true;
            }
            else
            {
                Frm_consultaGuiaT conBonos_Desc = new Frm_consultaGuiaT();
                conBonos_Desc.ShowDialog();

                if (conBonos_Desc.DialogResult == DialogResult.OK)
                {
                    Txt_idguia.Text = conBonos_Desc.Dgv_consultaBonoYDesc.Rows[conBonos_Desc.Dgv_consultaBonoYDesc.CurrentRow.Index].
                        Cells[0].Value.ToString();

                    Txt_ruta.Text = conBonos_Desc.Dgv_consultaBonoYDesc.Rows[conBonos_Desc.Dgv_consultaBonoYDesc.CurrentRow.Index].
                        Cells[1].Value.ToString();

                    Txt_descripcion.Text = conBonos_Desc.Dgv_consultaBonoYDesc.Rows[conBonos_Desc.Dgv_consultaBonoYDesc.CurrentRow.Index].
                        Cells[2].Value.ToString();



                    Txt_idguia.Focus();
                    presionado = false;
                    Habilitarbtn();
                }
            }
        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Frm_manGuiaTuristico_Load(object sender, EventArgs e)
        {

        }

        private void Txt_idguia_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloCodigo(e);
        }

        private void Txt_ruta_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloLetra(e);
        }

        private void Btn_ayuda_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "C:\\Ayudas Agencia Turismo.chm");
        }
    }
}

