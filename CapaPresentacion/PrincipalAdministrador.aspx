<%@ Page Title="" Language="C#" MasterPageFile="~/Administrador.Master" AutoEventWireup="true" CodeBehind="PrincipalAdministrador.aspx.cs" Inherits="CapaPresentacion.PrincipalAdministrador" %>

<DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="listAlumnos" runat="server" AutoGenerateColumns="false">
                <Columns>
                    <asp:BoundField DataField="idAlumno" HeaderText="ID ALUMNO" />
                    <asp:BoundField DataField="nombreAlumno" HeaderText="NOMBRES" />
                    <asp:BoundField DataField="apellidoAlumno" HeaderText="APELLIDOS" />
                    <asp:BoundField DataField="telefono" HeaderText="TELEFONO" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>