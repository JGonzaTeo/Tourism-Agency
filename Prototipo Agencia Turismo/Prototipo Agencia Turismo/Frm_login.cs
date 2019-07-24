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

namespace Prototipo_Agencia_Turismo
{
    public partial class Frm_login : Form
    {
        public Frm_login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombreUsuario = " ";
            string contrasenaUsuario = " ";

            nombreUsuario = textBox1.Text;
            contrasenaUsuario = textBox2.Text;

            if(nombreUsuario == "Admin" && contrasenaUsuario == "123")
            {
                Frm_mdi mdi = new Frm_mdi();
                mdi.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Los datos ingresados son incorrectos...");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Frm_login_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
        }
    }
}
