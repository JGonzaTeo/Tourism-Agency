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
        public Frm_login()
        {
            InitializeComponent();
        }

        private void IniciarSesion()
        {
            try
            {
                string contrasenaDesencriptada = " ";

                string nombreUsuario = " ";
                string tipoPerfil = " ";
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

                string consultaUsuario = string.Format("SELECT * FROM tbl_usuario WHERE estado = 1;");
                OdbcCommand comm = new OdbcCommand(consultaUsuario, Conexion.nuevaConexion());
                OdbcDataReader mostrarUsuarios = comm.ExecuteReader();

                while (mostrarUsuarios.Read())
                {
                    contrasenaDesencriptada = Seguridad_Login.DesEncriptar(mostrarUsuarios.GetString(2));
                    Console.WriteLine("CONTRASENA DESENCRIPTADA: " +contrasenaDesencriptada);
                    if ((Txt_usuario.Text == mostrarUsuarios.GetString(1)) && (Txt_contrasena.Text == contrasenaDesencriptada))
                    {
                        nombreUsuario = mostrarUsuarios.GetString(1);
                        tipoPerfil = mostrarUsuarios.GetString(3);
                        MessageBox.Show("INICIANDO SESIÓN");
                        Frm_mdi mdiMenu = new Frm_mdi(nombreUsuario, tipoPerfil);
              
                        mdiMenu.Show();
                        break;
                    }
                    else
                    {
                        Console.Write("DATOS INCORRECTOS");
                        Txt_usuario.Focus();
                        Frm_mdi mdiMenu = new Frm_mdi(nombreUsuario, tipoPerfil);
                        MessageBox.Show("Error");
                        this.Hide();
                        mdiMenu.Show();
                    }
                }

                OdbcCommand commBitacora = new OdbcCommand("{call SP_InsertarBitacora(?,?,?,?,?)}", Conexion.nuevaConexion());
                commBitacora.CommandType = CommandType.StoredProcedure;
                commBitacora.Parameters.Add("ope", OdbcType.Text).Value = "INICION DE SESIÓN";
                commBitacora.Parameters.Add("usr", OdbcType.Text).Value = nombreUsuario;
                commBitacora.Parameters.Add("fecha", OdbcType.Text).Value = fecha_ingreso;
                commBitacora.Parameters.Add("proc", OdbcType.Text).Value = "-------------";
                commBitacora.Parameters.Add("dirIp", OdbcType.Text).Value = localIP;
                commBitacora.ExecuteNonQuery();
            }
            catch(Exception err)
            {
                Console.Write("Error: " + err.Message);
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
