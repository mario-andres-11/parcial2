using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BancoUH.CapaDatos
{
    public class Cls_Tecnicos
    {
        public int TecnicoID { get; set; }
        public string Nombre { get; set; }
        public string Especialidad { get; set; }

        public Cls_Tecnicos(int tecnicoID, string nombre, string especialidad)
        {
            TecnicoID = tecnicoID;
            Nombre = nombre;
            Especialidad = especialidad;
        }

        public Cls_Tecnicos() { }
    }
}