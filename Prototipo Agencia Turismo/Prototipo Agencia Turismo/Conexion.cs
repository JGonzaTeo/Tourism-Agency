using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;

namespace Prototipo_Agencia_Turismo
{
    class Conexion
    {
        public static OdbcConnection nuevaConexion()
        {
            OdbcConnection conectar = new OdbcConnection("Dsn=agencia_turismo");
            conectar.Open();
            //MessageBox.Show("Conexion Exitosa");
            return conectar;
        }
    }
}
