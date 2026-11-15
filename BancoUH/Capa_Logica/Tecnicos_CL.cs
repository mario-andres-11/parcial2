using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace BancoUH.Capa_Logica
{
    public class Tecnicos_CL
    {
        public static int AgregarTecnico(string nombre, string especialidad)
        {
            int retorno = 0;
            try
            {
                using (SqlConnection Conn = Capa_Logica.DBconn.obtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO Tecnicos (Nombre, Especialidad) VALUES (@nombre, @especialidad)", Conn)
                    {
                        CommandType = CommandType.Text
                    };
                    cmd.Parameters.Add(new SqlParameter("@nombre", nombre));
                    cmd.Parameters.Add(new SqlParameter("@especialidad", especialidad));
                    retorno = cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException)
            {
                retorno = 0;
            }
            return retorno;
        }

        public static int EliminarTecnico(int tecnicoID)
        {
            int retorno = 0;
            try
            {
                using (SqlConnection Conn = Capa_Logica.DBconn.obtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("DELETE FROM Tecnicos WHERE TecnicoID = @tecnicoID", Conn)
                    {
                        CommandType = CommandType.Text
                    };
                    cmd.Parameters.Add(new SqlParameter("@tecnicoID", tecnicoID));
                    retorno = cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException)
            {
                retorno = 0;
            }
            return retorno;
        }

        public static int ActualizarTecnico(int tecnicoID, string nombre, string especialidad)
        {
            int retorno = 0;
            try
            {
                using (SqlConnection Conn = Capa_Logica.DBconn.obtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("UPDATE Tecnicos SET Nombre = @nombre, Especialidad = @especialidad WHERE TecnicoID = @tecnicoID", Conn)
                    {
                        CommandType = CommandType.Text
                    };
                    cmd.Parameters.Add(new SqlParameter("@tecnicoID", tecnicoID));
                    cmd.Parameters.Add(new SqlParameter("@nombre", nombre));
                    cmd.Parameters.Add(new SqlParameter("@especialidad", especialidad));
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