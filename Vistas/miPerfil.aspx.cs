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
    public partial class miPerfil : System.Web.UI.Page
    {
        usuario user = new usuario();
        negocioUsuario negUser = new negocioUsuario();
        protected void Page_Load(object sender, EventArgs e)
        {
            user = Session["Usuario"] as usuario;

            lblNombre.Text = user.NombreUsuario.ToUpper();
            lblEmail.Text = user.Mail;
            lblContra.Text = user.Contraseña;

            img1.ImageUrl = user.Pp;
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            user = Session["Usuario"] as usuario;

            negUser.cargarPP(txtUrl.Text, user);
            Session["Usuario"] = negUser.cargarSession(user);

            img1.ImageUrl = user.Pp;

            txtUrl.Text = "";
        }
    }
}