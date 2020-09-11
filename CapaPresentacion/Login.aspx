<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="CapaPresentacion.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="~/styles/font-awesome.min.css" rel="stylesheet" />
    <link href="~/styles/style.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
        <div class="main-bg">
        <!-- title -->
        <h1>SISTEMA GESTION DE CITAS ODONTOLOGICAS</h1>
        <!-- //title -->
        <!-- content -->
        <div class="sub-main-w3">
            <div class="bg-content-w3pvt">
                <div class="top-content-style">
                    <img src="images/teeth.jpg" alt="" />
                </div>
                <form action="Login.aspx" method="post">
                    <p class="legend">Login<span class="fa fa-hand-o-down"></span></p>
                    <div class="input">
                          <input type="text" runat="server" id="txtUsuario" placeholder="Username" name="txtUsuario" required /> 
                          <span class="fa fa-envelope"></span> 
                    </div>
                    <div class="input">
                        <input type="password" runat="server" id="txtPassword" placeholder="Password" name="txtPassword" required />
                          <span class="fa fa-unlock"></span>
 
                    </div>
                    <asp:Button runat="server" type="submit" class="btn submit" Text="Ingresar" Width="200px" OnClick="btn_Ingresar_Click" />
                    
                </form>
                <asp:LinkButton runat="server" type="submit" class="btn submit" Text="REGISTRATE" Width="200px" OnClick="LinkButton1_Click" BackColor="white"/>
            </div>
        </div>
        <!-- //content -->
        <!-- copyright -->
        <div class="copyright">
            <h2>
                &copy; 2020. All rights reserved
                <a href="" target="_blank">UNMSM</a>
            </h2>
        </div>
        <!-- //copyright -->
    </div>
        </div>
    </form>
</body>
</html>
