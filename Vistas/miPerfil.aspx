<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="miPerfil.aspx.cs" Inherits="Vistas.miPerfil" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
<link rel="stylesheet" href="stylePerfil.css"/>
</head>


  <body>
      <form id="form1" runat="server">
 <nav class="navbar">
  <ul>
    <li><a href="inicio.aspx">INICIO</a></li>
    <li><h1>MI PERFIL</h1></li>
  </ul>
</nav>

    <div class="container">
      <div class="card">
        <div class="avatar">
            <asp:Image ID="img1" runat="server" />
          </div>
        <h1 class="name"><asp:Label ID="lblNombre" runat="server" ></asp:Label></h1>
        <ul class="details">
          <li class="email">Email: <asp:Label ID="lblEmail" runat="server"></asp:Label> </li>
          <li class="phone">Contraseña: <asp:Label ID="lblContra" runat="server"></asp:Label> 
            </li>
        </ul>
          <input type="button" id="btnFoto" value="Cambiar foto de perfil" style="height:50px;"/>
      </div>
    </div>


 <!-- CARD PARA CAMBIAR LA FOTO DE PERFIL  -->
     <div id="invisible">
      <div class="card2">
          INTRODUZCA EL LINK DE LA FOTO QUE DESEA TENER: 
          <asp:TextBox ID="txtUrl" runat="server"></asp:TextBox>
          <asp:Button ID="btnAceptar" runat="server" Height="33px" Text="Aceptar" Width="81px" OnClick="btnAceptar_Click" />
      </div>
    </div>

      </form>
  </body>


    <!-- JS PARA MOSTRAR EL APARTADO INVISIBLE  -->
    <script>
        let boton = document.getElementById("btnFoto");
        let content = document.getElementById("invisible");

        const change = () => {
            content.id="container2";
        }


        boton.addEventListener("click", change);

    </script>

</html>
