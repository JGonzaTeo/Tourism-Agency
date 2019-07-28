/* 
 -----------------------------------------------------
            AUTOR: Ivan Mogollón
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

namespace Prototipo_Agencia_Turismo.Mantenimiento
{
    public partial class Frm_mantHotel : Form
    {
        public Frm_mantHotel()
        {
            InitializeComponent();
        }

        private void Frm_mantHotelcs_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
