<%@ Page Title="" Language="C#" MasterPageFile="~/Paciente.Master" AutoEventWireup="true" CodeBehind="PrincipalPaciente.aspx.cs" Inherits="CapaPresentacion.PrincipalPaciente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <%--<link href="//maxcdn.bootstrapcdn.com/bootstrap/3.2.0/css/bootstrap.min.css" rel="stylesheet" type="text/css" />--%>
    <section class="content-header">
        
    </section>

    <section class="content">
        <div class="row">
            <div align="center">
                <asp:Table ID="Citas" runat="server" Width="65%">
                    <asp:TableHeaderRow >
                        <asp:TableHeaderCell BorderColor="Black" BorderWidth="1px" BackColor="Salmon" Width="33%">Cita</asp:TableHeaderCell>
                        <asp:TableHeaderCell BorderColor="Black" BorderWidth="1px" BackColor="Salmon" Width="33%">Fecha</asp:TableHeaderCell>
                        <asp:TableHeaderCell BorderColor="Black" BorderWidth="1px" BackColor="Salmon" Width="33%">Estado</asp:TableHeaderCell>
                    </asp:TableHeaderRow>
                    <asp:TableRow>
                        <asp:TableCell BorderColor="Black" BorderWidth="1px">C1</asp:TableCell>
                        <asp:TableCell BorderColor="Black" BorderWidth="1px">C1</asp:TableCell>
                        <asp:TableCell BorderColor="Black" BorderWidth="1px">C1</asp:TableCell>
                    </asp:TableRow>
                </asp:Table>
            </div>
        </div>


        
    </section>

    <div align="center">
        <table>
            <tr>
                <td>
                    <asp:Button ID="btnReservarCita" runat="server" Text="Reservar Cita" CssClass="btn btn-primary" />
                </td>
                <td>
                    <asp:Button ID="btnModificarCita" runat="server" Text="Modificar Cita" CssClass="btn btn-primary" />
                </td>
            </tr>
        </table>
    </div>
</asp:Content>
