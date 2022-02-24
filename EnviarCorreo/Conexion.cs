using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnviarCorreo
{
    class Conexion
    {
        public static string Cadena2()
        {
            SqlConnectionStringBuilder csql = new SqlConnectionStringBuilder();
            csql.DataSource = "localhost";
            csql.InitialCatalog = "ConexionDeCorreo";
            csql.UserID = "sa";
            csql.Password = "CUENA";
            csql.ConnectTimeout = 1000;
            return csql.ConnectionString;
        }

    }
}
