/* 
 -----------------------------------------------------
            AUTOR: Edson Juarez
  -----------------------------------------------------
*/

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
using Prototipo_Agencia_Turismo.Seguridad;

namespace Prototipo_Agencia_Turismo
{
    public partial class Frm_login : Form
    {
        string contrasenaDesencriptada = " ";
        int idUsuario = 0;
        string nombreUsuario = " ";
        int estadoLogeado = 0;
        int tipoPerfil = 0;
        string actualizarCampo = " ";
        bool datosIncorrectos = false;

        public Frm_login()
        {
            InitializeComponent();
        }

        private void IniciarSesion()
        {
            contrasenaDesencriptada = " ";
            idUsuario = 0;
            nombreUsuario = " ";
            tipoPerfil = 0;
            estadoLogeado = 0;
            actualizarCampo = " ";
            DateTime fecha_ingreso = DateTime.Now;
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
                //Ejecución de consulta para buscar el usuario
                string consultaUsuario = string.Format("SELECT * FROM tbl_usuario WHERE estado = 1;");
                OdbcCommand comm = new OdbcCommand(consultaUsuario, Conexion.nuevaConexion());
                OdbcDataReader mostrarUsuarios = comm.ExecuteReader();

                while (mostrarUsuarios.Read())
                {
                    //guarda la contraseña del usuario desencriptada 
                    contrasenaDesencriptada = Seguridad_Login.DesEncriptar(mostrarUsuarios.GetString(2));
                    nombreUsuario = mostrarUsuarios.GetString(1);
                    estadoLogeado = mostrarUsuarios.GetInt32(5);
                    //si los campos escritos en el Formulario son iguales a los del registro de la BD se permite el logeo
                    if (Txt_usuario.Text != mostrarUsuarios.GetString(1) || Txt_contrasena.Text != contrasenaDesencriptada)
                    {
                        //MessageBox.Show("DATOS INCORRECTOS");
                        Txt_usuario.Focus();
                        datosIncorrectos = true;
                    }
                    else
                    {
                        if (estadoLogeado == 1)
                        {
                            MessageBox.Show("ESTE USUARIO ESTA LOGEADO ACTUALMENTE");
                            datosIncorrectos = false;
                        }
                        else
                        {
                            Console.WriteLine("WORKS");
                            idUsuario = mostrarUsuarios.GetInt32(0);
                            nombreUsuario = mostrarUsuarios.GetString(1);
                            Console.WriteLine("WORKS2");
                            tipoPerfil = mostrarUsuarios.GetInt32(3);
                            Console.WriteLine("WORKS3");
                            MessageBox.Show("INICIANDO SESIÓN");
                            Frm_mdi mdiMenu = new Frm_mdi(idUsuario, nombreUsuario, tipoPerfil);
                            this.Hide();
                            mdiMenu.Show();

                            Console.WriteLine("Inicio de sesión");
                            //Consulta para verificar que el usuario solo pueda logearse al sistema 1 vez
                            actualizarCampo = "UPDATE tbl_usuario SET logeado = '1' WHERE Pk_idUsuario= " + idUsuario + " AND Fk_idPerfil= '" + tipoPerfil + "'";
                            OdbcCommand commAct = new OdbcCommand(actualizarCampo, Conexion.nuevaConexion());
                            commAct.ExecuteNonQuery();
                            datosIncorrectos = false;
                            Console.WriteLine("WORKS3");
                            break;
                        }
                    }
                }
                
                OdbcCommand commBitacora = new OdbcCommand("{call SP_InsertarBitacora(?,?,?,?,?)}", Conexion.nuevaConexion());
                commBitacora.CommandType = CommandType.StoredProcedure;
                commBitacora.Parameters.Add("ope", OdbcType.Text).Value = "INICION DE SESIÓN";
                commBitacora.Parameters.Add("usr", OdbcType.Text).Value = nombreUsuario;
                commBitacora.Parameters.Add("fecha", OdbcType.Text).Value = fecha_ingreso.ToString("yyyy/MM/dd HH:mm:ss");
                commBitacora.Parameters.Add("proc", OdbcType.Text).Value = "-------------";
                commBitacora.Parameters.Add("dirIp", OdbcType.Text).Value = localIP;
                commBitacora.ExecuteNonQuery();

                if(datosIncorrectos == true)
                {
                    MessageBox.Show("DATOS INCORRECTOS");
                }
            }
            catch(Exception err)
            {
                Console.Write("Error: " + err.Message);
                Console.Write("DATOS INCORRECTOS");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            IniciarSesion();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Frm_login_Load(object sender, EventArgs e)
        {
            Txt_usuario.Focus();
        }
    }
}
