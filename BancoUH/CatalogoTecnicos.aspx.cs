using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BancoUH
{
    public partial class CatalogoTecnicos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Acciones iniciales al cargar la página (si se requieren)
            }
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            string especialidad = txtEspecialidad.Text.Trim();

            int resultado = Capa_Logica.Tecnicos_CL.AgregarTecnico(nombre, especialidad);

            if (resultado > 0)
            {
                Response.Write("<script>alert('¡Técnico agregado exitosamente!');</script>");
            }
            else
            {
                Response.Write("<script>alert('Error al agregar el técnico.');</script>");
            }
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtTecnicoID.Text, out int id))
            {
                string nombre = txtNombre.Text.Trim();
                string especialidad = txtEspecialidad.Text.Trim();

                int resultado = Capa_Logica.Tecnicos_CL.ActualizarTecnico(id, nombre, especialidad);

                if (resultado > 0)
                {
                    Response.Write("<script>alert('¡Técnico actualizado exitosamente!');</script>");
                }
                else
                {
                    Response.Write("<script>alert('Error al actualizar (verifique el ID).');</script>");
                }
            }
            else
            {
                Response.Write("<script>alert('Por favor, ingrese un ID de técnico válido.');</script>");
            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtTecnicoID.Text, out int id))
            {
                int resultado = Capa_Logica.Tecnicos_CL.EliminarTecnico(id);

                if (resultado > 0)
                {
                    Response.Write("<script>alert('¡Técnico eliminado exitosamente!');</script>");
                }
                else
                {
                    Response.Write("<script>alert('Error al eliminar (verifique el ID).');</script>");
                }
            }
            else
            {
                Response.Write("<script>alert('Por favor, ingrese un ID de técnico válido para eliminar.');</script>");
            }
        }
    }
}