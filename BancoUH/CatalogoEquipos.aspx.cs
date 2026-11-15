using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BancoUH
{
    public partial class CatalogoEquipos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e) { }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            string tipo = txtTipoEquipo.Text.Trim();
            string modelo = txtModelo.Text.Trim();
            if (int.TryParse(txtUsuarioID.Text, out int usrId))
            {
                int res = Capa_Logica.Equipos_CL.AgregarEquipo(tipo, modelo, usrId);
                Response.Write(res > 0 ? "<script>alert('Equipo agregado correctamente');</script>" : "<script>alert('Error al agregar');</script>");
            }
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtEquipoID.Text, out int eqId) && int.TryParse(txtUsuarioID.Text, out int usrId))
            {
                string tipo = txtTipoEquipo.Text.Trim();
                string modelo = txtModelo.Text.Trim();
                int res = Capa_Logica.Equipos_CL.ActualizarEquipo(eqId, tipo, modelo, usrId);
                Response.Write(res > 0 ? "<script>alert('Equipo actualizado correctamente');</script>" : "<script>alert('Error al actualizar');</script>");
            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtEquipoID.Text, out int eqId))
            {
                int res = Capa_Logica.Equipos_CL.EliminarEquipo(eqId);
                Response.Write(res > 0 ? "<script>alert('Equipo eliminado correctamente');</script>" : "<script>alert('Error al eliminar');</script>");
            }
        }
    }
}