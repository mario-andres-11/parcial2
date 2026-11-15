using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace BancoUH.Capa_Logica
{
    public class Usuarios_CL
    {
        public static int AgregarUsuario(string nombre, string correo)
        {
            int retorno = 0;
            using (SqlConnection Conn = DBconn.obtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Usuarios (Nombre, Correo) VALUES (@nombre, @correo)", Conn)
                {
                    CommandType = CommandType.Text
                };
                cmd.Parameters.Add(new SqlParameter("@nombre", nombre));
                cmd.Parameters.Add(new SqlParameter("@correo", correo));
                retorno = cmd.ExecuteNonQuery();
            }
            return retorno;
        }

        public static int ActualizarUsuario(int usuarioID, string nombre, string correo)
        {
            int retorno = 0;
            using (SqlConnection Conn = DBconn.obtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("UPDATE Usuarios SET Nombre = @nombre, Correo = @correo WHERE UsuarioID = @usuarioID", Conn)
                {
                    CommandType = CommandType.Text
                };
                cmd.Parameters.Add(new SqlParameter("@usuarioID", usuarioID));
                cmd.Parameters.Add(new SqlParameter("@nombre", nombre));
                cmd.Parameters.Add(new SqlParameter("@correo", correo));
                retorno = cmd.ExecuteNonQuery();
            }
            return retorno;
        }

        public static int EliminarUsuario(int usuarioID)
        {
            int retorno = 0;
            using (SqlConnection Conn = DBconn.obtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Usuarios WHERE UsuarioID = @usuarioID", Conn)
                {
                    CommandType = CommandType.Text
                };
                cmd.Parameters.Add(new SqlParameter("@usuarioID", usuarioID));
                retorno = cmd.ExecuteNonQuery();
            }
            return retorno;
        }
    }
}