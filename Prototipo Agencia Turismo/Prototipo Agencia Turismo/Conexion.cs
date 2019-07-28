using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototipo_Agencia_Turismo
{
    class Conexion
    {
        public static OdbcConnection nuevaConexion()
        {
            OdbcConnection conectar = new OdbcConnection("Dsn=ventas_directas");
            conectar.Open();
            // MessageBox.Show("Conexion Exitosa");
            return conectar;
        }
    }
}
