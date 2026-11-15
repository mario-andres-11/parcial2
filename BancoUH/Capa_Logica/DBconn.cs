using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace BancoUH.Capa_Logica
{
    public class DBconn
    {
        public static SqlConnection obtenerConexion()
        {
            
            string cadena = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=bancouh;Integrated Security=True";
            SqlConnection conexion = new SqlConnection(cadena);
            conexion.Open();
            return conexion;
        }
    }
}