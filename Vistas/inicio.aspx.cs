using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
using Negocio;


namespace Vistas
{
    public partial class inicio : System.Web.UI.Page
    {
        usuario user = new usuario();
        protected void Page_Load(object sender, EventArgs e)
        {
            user = Session["Usuario"] as usuario;

            lblUsuario.Text = user.NombreUsuario.ToUpper();
            imgPfp.ImageUrl = user.Pp;

            lblBienvenida.Text = "BIENVENIDO " + user.NombreUsuario.ToUpper() + "! ESPERAMOS QUE SU ESTADÍA SEA DE LO MÁS AGRADABLE";


        }

        protected void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Session["Usuario"] = null;
            Response.Redirect("default.aspx");
        }

        protected void btnPerfil_Click(object sender, EventArgs e)
        {
            Response.Redirect("miPerfil.aspx");
        }
    }
}