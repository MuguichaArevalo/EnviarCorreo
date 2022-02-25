using Dapper;
using EnviarCorreo.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnviarCorreo.Data
{
    public class DP_Clientes
    {
        public List<Clientes> BuscarContratosPorIdCliente()
        {
            List<Clientes> clientes;

            using (SqlConnection con = new SqlConnection(Conexion.Cadena2()))
            {
                string query = @"select * FROM Correo";
                clientes = con.Query<Clientes>(query).ToList();
            }
            return clientes;
        }
        public void Dispose()
        {

        }
    }
}