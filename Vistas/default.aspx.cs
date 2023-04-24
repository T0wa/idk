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
    public partial class login : System.Web.UI.Page
    {
        negocioUsuario neg = new negocioUsuario();
        usuario user = new usuario();

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            user.NombreUsuario = username.Text;
            user.Contraseña = password.Text;

            if (neg.existeUsuario(user)) //SE CARGA LA VARIABLE SESSION
            {
                Session["Usuario"] = neg.cargarSession(user);

                Response.Redirect("inicio.aspx");
            }
            else
            {
                lbl1.Text = "No se encontró el usuario";
                lbl1.Visible = true;
            }
        }
    }
}