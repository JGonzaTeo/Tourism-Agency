using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
namespace Prototipo_Agencia_Turismo
{
    public partial class Form1 : Form
    {
        public class Funciones
        {
            public static bool ValidarCampoEntero(TextBox CajaDeTexto)
            {
                try
                {
                    int d = Convert.ToInt32(CajaDeTexto.Text);
                    return true;
                }
                catch (Exception ex)
                {
                    CajaDeTexto.Text = "0";
                    CajaDeTexto.Select(0, CajaDeTexto.Text.Length);
                    return false;
                }
            }
            public static bool ValidarCampoDecimal(TextBox CajaDeTexto)
            {
                try
                {
                    decimal d = Convert.ToDecimal(CajaDeTexto.Text);
                    return true;
                }
                catch (Exception ex)
                {
                    CajaDeTexto.Text = "0";
                    CajaDeTexto.Select(0, CajaDeTexto.Text.Length);
                    return false;
                }
            }
        }
    }
}

