/* 
 -----------------------------------------------------
            AUTOR: José Gonzalez
  -----------------------------------------------------
*/

using Prototipo_Agencia_Turismo.Consulta;
using System;
using System.Data;
using System.Data.Odbc;
using System.Net;
using System.Windows.Forms;

namespace Prototipo_Agencia_Turismo.Mantenimiento
{
    public partial class Frm_mantBono_Desc : Form
    {
        IPHostEntry host;
        string localIP = "?";
        string nombreUsuario = " ";
        DateTime fechai = DateTime.Now;
        Validacion v = new Validacion();

        bool presionado = false;
        String var1;

        String cod_bono;
        String nombre;
        String valor;
        String tipo;

        public Frm_mantBono_Desc(string usuario)
        {
            InitializeComponent();
            nombreUsuario = usuario;
            Txt_nombre.Enabled = false;
            Txt_valor.Enabled = false;
            Txt_idBonoDesc.Enabled = false;
            Chk_bono.Enabled = false;
            Chk_descuento.Enabled = false;
        }

        private void Habilitarcampos()
        {
            Txt_idBonoDesc.Enabled = true;
            Txt_nombre.Enabled = true;
            Txt_valor.Enabled = true;
            Chk_bono.Enabled = true;
            Chk_descuento.Enabled = true;

        }


        private void Deshabilitarcampos()
        {
            Txt_idBonoDesc.Enabled = false;
            Txt_nombre.Enabled = false;
            Txt_valor.Enabled = false;
            Chk_bono.Enabled = false;
            Chk_descuento.Enabled = false;

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
            Txt_idBonoDesc.Text = " ";
            Txt_nombre.Text = " ";
            Txt_valor.Text = " ";
            Chk_bono.Checked = false;
            Chk_descuento.Checked = false;
        }

        private void ActualizarDatos()
        {
            cod_bono = Txt_idBonoDesc.Text;
            nombre = Txt_nombre.Text;
            valor = Txt_valor.Text;
            if (Chk_bono.Checked == true && Chk_descuento.Checked == false)
            {
                tipo = "0";
            }
            else
            {
                tipo = "1";
            }

            try
            {
                OdbcCommand comm = new OdbcCommand("{call Sp_ModificarBonos_Desc(?,?,?,?)}", Conexion.nuevaConexion());
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.Add("cod", OdbcType.Text).Value = cod_bono;
                comm.Parameters.Add("nom", OdbcType.Text).Value = nombre;
                comm.Parameters.Add("valor", OdbcType.Text).Value = valor;
                comm.Parameters.Add("tipo", OdbcType.Text).Value = tipo;
                comm.ExecuteNonQuery();
                MessageBox.Show("Registro actualizado correctamente");
                comm.Connection.Close();

                OdbcCommand comm1 = new OdbcCommand("{call SP_InsertarBitacora(?,?,?,?,?)}", Conexion.nuevaConexion());
                comm1.CommandType = CommandType.StoredProcedure;
                comm1.Parameters.Add("ope", OdbcType.Text).Value = "REGISTRO MODIFICADO";
                comm1.Parameters.Add("usr", OdbcType.Text).Value = nombreUsuario;
                comm1.Parameters.Add("fecha", OdbcType.Text).Value = fechai.ToString("yyyy/MM/dd HH:mm:ss");
                comm1.Parameters.Add("proc", OdbcType.Text).Value = "Bonos Y Descuentos";
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
            cod_bono = Txt_idBonoDesc.Text;
            nombre = Txt_nombre.Text;
            valor = Txt_valor.Text;
            if (Chk_bono.Checked == true && Chk_descuento.Checked == false)
            {
                tipo = "0";
            }
            else
            {
                tipo = "1";
            }

            try
            {
                OdbcCommand comm = new OdbcCommand("{call Sp_InsertarBonos_Desc(?,?,?,?)}", Conexion.nuevaConexion());
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.Add("cod", OdbcType.Text).Value = cod_bono;
                comm.Parameters.Add("nom", OdbcType.Text).Value = nombre;
                comm.Parameters.Add("valor", OdbcType.Text).Value = valor;
                comm.Parameters.Add("tipo", OdbcType.Text).Value = tipo;
                comm.ExecuteNonQuery();
                MessageBox.Show("Registro Guardado correctamente");
                comm.Connection.Close();

                OdbcCommand comm1 = new OdbcCommand("{call SP_InsertarBitacora(?,?,?,?,?)}", Conexion.nuevaConexion());
                comm1.CommandType = CommandType.StoredProcedure;
                comm1.Parameters.Add("ope", OdbcType.Text).Value = "REGISTRO INGRESADO";
                comm1.Parameters.Add("usr", OdbcType.Text).Value = nombreUsuario;
                comm1.Parameters.Add("fecha", OdbcType.Text).Value = fechai.ToString("yyyy/MM/dd HH:mm:ss");
                comm1.Parameters.Add("proc", OdbcType.Text).Value = "Bonos Y Descuentos";
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
            cod_bono = Txt_idBonoDesc.Text;

            try
            {
                OdbcCommand comm = new OdbcCommand("{call Sp_EliminarBonos_Desc(?,?)}", Conexion.nuevaConexion());
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.Add("cod", OdbcType.Text).Value = cod_bono;
                comm.Parameters.Add("estdo", OdbcType.Text).Value = "1";
                comm.ExecuteNonQuery();
                MessageBox.Show("Registro eliminado correctamente");
                comm.Connection.Close();

                OdbcCommand comm1 = new OdbcCommand("{call SP_InsertarBitacora(?,?,?,?,?)}", Conexion.nuevaConexion());
                comm1.CommandType = CommandType.StoredProcedure;
                comm1.Parameters.Add("ope", OdbcType.Text).Value = "REGISTRO BORRADO";
                comm1.Parameters.Add("usr", OdbcType.Text).Value = nombreUsuario;
                comm1.Parameters.Add("fecha", OdbcType.Text).Value = fechai.ToString("yyyy/MM/dd HH:mm:ss");
                comm1.Parameters.Add("proc", OdbcType.Text).Value = "Bonos Y Descuentos";
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

        private void Txt_idHotel_TextChanged(object sender, EventArgs e)
        {

        }

        private void Frm_mantBono_Desc_Load(object sender, EventArgs e)
        {

        }

 
   

        private void Btn_cerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_minimizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_ingresar_Click_1(object sender, EventArgs e)
        {
            Habilitarcampos();
        }

        private void Btn_consultar_Click_1(object sender, EventArgs e)
        {
            if (presionado == false)
            {
                Desahiblitarbtn();
                Btn_consultar.Enabled = true;
                presionado = true;
            }
            else
            {
                Frm_consultaBonos_Desc conBonos_Desc = new Frm_consultaBonos_Desc();
                conBonos_Desc.ShowDialog();

                if (conBonos_Desc.DialogResult == DialogResult.OK)
                {
                    Txt_idBonoDesc.Text = conBonos_Desc.Dgv_consultaBonoYDesc.Rows[conBonos_Desc.Dgv_consultaBonoYDesc.CurrentRow.Index].
                        Cells[0].Value.ToString();

                    Txt_nombre.Text = conBonos_Desc.Dgv_consultaBonoYDesc.Rows[conBonos_Desc.Dgv_consultaBonoYDesc.CurrentRow.Index].
                        Cells[1].Value.ToString();

                    Txt_valor.Text = conBonos_Desc.Dgv_consultaBonoYDesc.Rows[conBonos_Desc.Dgv_consultaBonoYDesc.CurrentRow.Index].
                        Cells[2].Value.ToString();

                    var1 = conBonos_Desc.Dgv_consultaBonoYDesc.Rows[conBonos_Desc.Dgv_consultaBonoYDesc.CurrentRow.Index].
                        Cells[3].Value.ToString();

                    if (var1 == "0")
                    {
                        Chk_bono.Checked = true;
                        Chk_descuento.Checked = false;
                    }
                    else
                    {
                        Chk_descuento.Checked = true;
                        Chk_bono.Checked = false;
                    }

                    Txt_idBonoDesc.Focus();
                    presionado = false;
                    Habilitarbtn();
                }
            }
        }

        private void Btn_borrar_Click_1(object sender, EventArgs e)
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
                Txt_idBonoDesc.Focus();
                presionado = false;
                Deshabilitarcampos();
                Habilitarbtn();
                Limpiar();
            }
        }

        private void Btn_editar_Click_1(object sender, EventArgs e)
        {
            if (presionado == false)
            {
                Desahiblitarbtn();
                Btn_editar.Enabled = true;
                presionado = true;
                Txt_idBonoDesc.Enabled = false;
            }
            else
            {
                ActualizarDatos();
                Txt_idBonoDesc.Focus();
                presionado = false;
                Deshabilitarcampos();
                Habilitarbtn();
                Limpiar();
            }
        }

        private void Btn_guardar_Click_1(object sender, EventArgs e)
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
                Txt_idBonoDesc.Focus();
                presionado = false;
                Deshabilitarcampos();
                Habilitarbtn();
                Limpiar();

            }
        }

        private void Btn_cancelar_Click_1(object sender, EventArgs e)
        {
            Limpiar();
            presionado = false;
            Habilitarbtn();
        }

        private void Txt_idBonoDesc_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            v.soloCodigo(e);
        }

        private void Txt_nombre_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            v.soloLetra(e);
        }

        private void Txt_valor_KeyPress_1(object sender, KeyPressEventArgs e)
        {
             v.soloNumero(e);
        }

        private void Txt_valor_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloNumero(e);
        }

        private void Txt_valor_TextChanged(object sender, EventArgs e)
        {

        }
    }
}