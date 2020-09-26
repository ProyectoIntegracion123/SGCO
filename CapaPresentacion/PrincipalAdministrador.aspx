<%@ Page Title="" Language="C#" MasterPageFile="~/Administrador.Master" AutoEventWireup="true" CodeBehind="PrincipalAdministrador.aspx.cs" Inherits="CapaPresentacion.PrincipalAdministrador" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="content-header">
        
    </section>

    <section class="content">
        <div class="row">
            <div class="form-group">
            <label>Código Alumno: </label>
            </div>
            <div class="form-group">
                <asp:TextBox ID="txtBuscar" runat="server"></asp:TextBox>
            </div>
            <div>
                <asp:Buttonrunat="server" CssClass="btn btn-primary" Width="100px"Text="Buscar"/>
            </div>
        </div>
        
     </section>
</asp:Content>
