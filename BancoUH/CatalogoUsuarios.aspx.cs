using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BancoUH
{
    public partial class CatalogoUsuarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e) { }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            string correo = txtCorreo.Text.Trim();

            int res = Capa_Logica.Usuarios_CL.AgregarUsuario(nombre, correo);
            Response.Write(res > 0 ? "<script>alert('¡Usuario agregado exitosamente!');</script>" : "<script>alert('Error al agregar usuario.');</script>");
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtUsuarioID.Text, out int id))
            {
                string nombre = txtNombre.Text.Trim();
                string correo = txtCorreo.Text.Trim();

                int res = Capa_Logica.Usuarios_CL.ActualizarUsuario(id, nombre, correo);
                Response.Write(res > 0 ? "<script>alert('¡Usuario actualizado exitosamente!');</script>" : "<script>alert('Error al actualizar usuario.');</script>");
            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtUsuarioID.Text, out int id))
            {
                int res = Capa_Logica.Usuarios_CL.EliminarUsuario(id);
                Response.Write(res > 0 ? "<script>alert('¡Usuario eliminado exitosamente!');</script>" : "<script>alert('Error al eliminar usuario.');</script>");
            }
        }
    }
}