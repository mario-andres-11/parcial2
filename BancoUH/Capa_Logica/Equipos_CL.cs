using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace BancoUH.Capa_Logica
{
    public class Equipos_CL
    {
        public static int AgregarEquipo(string tipoEquipo, string modelo, int usuarioID)
        {
            int retorno = 0;
            try
            {
                using (SqlConnection Conn = Capa_Logica.DBconn.obtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO Equipos (TipoEquipo, Modelo, UsuarioID) VALUES (@tipoEquipo, @modelo, @usuarioID)", Conn)
                    {
                        CommandType = CommandType.Text
                    };
                    cmd.Parameters.Add(new SqlParameter("@tipoEquipo", tipoEquipo));
                    cmd.Parameters.Add(new SqlParameter("@modelo", modelo));
                    cmd.Parameters.Add(new SqlParameter("@usuarioID", usuarioID));
                    retorno = cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException)
            {
                retorno = 0;
            }
            return retorno;
        }

        public static int EliminarEquipo(int equipoID)
        {
            int retorno = 0;
            try
            {
                using (SqlConnection Conn = Capa_Logica.DBconn.obtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("DELETE FROM Equipos WHERE EquipoID = @equipoID", Conn)
                    {
                        CommandType = CommandType.Text
                    };
                    cmd.Parameters.Add(new SqlParameter("@equipoID", equipoID));
                    retorno = cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException)
            {
                retorno = 0;
            }
            return retorno;
        }

        public static int ActualizarEquipo(int equipoID, string tipoEquipo, string modelo, int usuarioID)
        {
            int retorno = 0;
            try
            {
                using (SqlConnection Conn = Capa_Logica.DBconn.obtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("UPDATE Equipos SET TipoEquipo = @tipoEquipo, Modelo = @modelo, UsuarioID = @usuarioID WHERE EquipoID = @equipoID", Conn)
                    {
                        CommandType = CommandType.Text
                    };
                    cmd.Parameters.Add(new SqlParameter("@equipoID", equipoID));
                    cmd.Parameters.Add(new SqlParameter("@tipoEquipo", tipoEquipo));
                    cmd.Parameters.Add(new SqlParameter("@modelo", modelo));
                    cmd.Parameters.Add(new SqlParameter("@usuarioID", usuarioID));
                    retorno = cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException)
            {
                retorno = 0;
            }
            return retorno;
        }
    }
}