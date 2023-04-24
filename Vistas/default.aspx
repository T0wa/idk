<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="Vistas.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<link rel="styleSheet" href="styleLogin.css" />
    <title></title>

</head>
<body>

    <div class="container">
      <form id="formLogin" runat="server">
        <img src="https://www.freepnglogos.com/uploads/coffee-logo-png/coffee-logo-symbol-19.png" width="350" alt="coffee logo symbol" />
        <h2>Iniciar sesión</h2>
        <label for="username">Nombre de usuario:</label>
          <asp:TextBox ID="username"  runat="server"></asp:TextBox>
&nbsp;<label for="password">Contraseña: </label>
          <asp:TextBox ID="password"  type="password" runat="server"></asp:TextBox>
&nbsp;&nbsp;
          <br />
          <br />
          <asp:ImageButton ID="ImageButton1" runat="server" Height="89px" ImageUrl="https://cdn.onlinewebfonts.com/svg/img_71288.png" OnClick="ImageButton1_Click" Width="96px" />
          <br />
          <br />
          <asp:Label ID="lbl1" runat="server" Visible="False" ForeColor="Red"></asp:Label>
      </form>
      <div class="image-wrapper"></div>
    </div>


</body>
</html>
