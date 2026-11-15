using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BancoUH.CapaDatos
{
    public class Cls_Usuarios
    {
        public int UsuarioID { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }

        public Cls_Usuarios(int usuarioID, string nombre, string correo)
        {
            UsuarioID = usuarioID;
            Nombre = nombre;
            Correo = correo;
        }

        public Cls_Usuarios() { }
    }
}