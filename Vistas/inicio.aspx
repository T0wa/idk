<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="inicio.aspx.cs" Inherits="Vistas.inicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
<link rel="stylesheet" href="styleInicio.css"/>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <header>
    <nav>
      <ul>
        <li><a href="#">INICIO</a></li>
        <li><a href="#">NOSOTROS</a></li>
        <li><a href="#">SERVICIOS</a></li>
        <li>
            
            <p class="dropdown-text" onclick="toggleDropdown()"> <asp:Label ID="lblUsuario" runat="server" Text=""></asp:Label> 
                
            </p>
            <asp:Image ID="imgPfp" runat="server" />
            
                <ul class="dropdown-list" id="dropdown">
                  <li> 
                      <asp:LinkButton ID="btnPerfil" runat="server" OnClick="btnPerfil_Click">Mi perfil</asp:LinkButton>
                    </li>
                  <li>
                      <asp:LinkButton ID="btnCerrarSesion" runat="server" OnClick="btnCerrarSesion_Click">Cerrar sesión</asp:LinkButton>
                    </li>
                </ul>
          </li>
      </ul>
    </nav>
  </header>

  <main>
    <section class="hero">
      <div class="hero-text">
        <h1>
            <asp:Label ID="lblBienvenida" runat="server" Text="Label"></asp:Label>
          </h1>
        <p>
            <asp:Label ID="lblMensaje" runat="server" Text="Lastimosamente aún la página sigue en construcción"></asp:Label>
          </p>
        <button>Ver más</button>
      </div>
    </section>

  </main>

  <footer>
    <p>&copy; 2023 Todos los derechos reservados.</p>
  </footer>

        </div>
    </form>
</body>

    <script>
        function toggleDropdown()
        {
            var dropdown = document.getElementById("dropdown");
            dropdown.classList.toggle("show-dropdown");
        }

    </script>

</html>
