<%@ Page Title="" Language="C#" MasterPageFile="~/Hall.Master" AutoEventWireup="true" CodeBehind="RegistrarPaciente.aspx.cs" Inherits="CapaPresentacion.RegistrarPaciente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

 <section class="content-header">
     <h1 style="text-align:center">REGISTRO DE PACIENTES</h1>
 </section>
 <section class="content">
     <div class="row" align="center">
         <div class="col-md-6">
             <div class="box box-primary">
                 <div class="box-body">
                     <div class="form-group">
                         <label>NOMBRES</label>
                     </div>
                     <div class="form-group">
                         <asp:TextBox ID="txtNombres" runat="server" Text="" CssClass="form-control" Width="235px"></asp:TextBox>
                     </div>
                     <div class="form-group">
                         <label>APELLIDOS</label>
                     </div>
                     <div class="form-group">
                         <asp:TextBox ID="txtApellidos" runat="server" Text="" CssClass="form-control" Width="232px"></asp:TextBox>
                     </div>     
                     <div class="form-group">
                         <label>DNI</label>
                     </div>
                     <div class="form-group">
                         <asp:TextBox ID="DNI" runat="server" Text="" CssClass="form-control" Width="232px"></asp:TextBox>
                     </div>  
                     <div class="form-group">
                         <label>Edad</label>
                     </div>
                     <div class="form-group">
                         <asp:TextBox ID="Edad" runat="server" Text="" CssClass="form-control" Width="232px"></asp:TextBox>
                     </div>    
                     <div class="form-group">
                         <label>Telefono</label>
                     </div>
                     <div class="form-group">
                         <asp:TextBox ID="Telefono" runat="server" Text="" CssClass="form-control" Width="232px"></asp:TextBox>
                     </div>   
                       <div class="form-group">
                         <label>Direccion</label>
                     </div>
                     <div class="form-group">
                         <asp:TextBox ID="Direccion" runat="server" Text="" CssClass="form-control" Width="232px"></asp:TextBox>
                     </div>   
                     <div class="form-group">
                         <label>Fecha de Nacimiento</label>
                     </div>
                     <div class="form-group">
                         <asp:TextBox ID="fechanac" runat="server" Text="" CssClass="form-control" Width="232px"></asp:TextBox>
                     </div>  
                      <div class="form-group">
                         <label>Contraseña</label>
                     </div>
                     <div class="form-group">
                         <asp:TextBox ID="contraseña" runat="server" Text="" CssClass="form-control" Width="232px"></asp:TextBox>
                     </div>   
                 </div>
             </div>
         </div>
         
     </div>
     
         <div align="center">
             <table>
                 <tr>
                    <td>
                        <asp:Button ID="btnRegistrar" runat="server" CssClass="btn btn-primary" Width="200px" Text="Registrar" OnClick="btnRegistrar_Click" Height="38px"/>
                    </td>
                     <td>&nbsp;&nbsp;&nbsp;&nbsp;</td>
                    <td>
                        <asp:Button ID="btnCancelar" runat="server" CssClass="btn btn-danger" Width="200px" Text="Cancelar" Height="44px" OnClick="btnCancelar_Click"/>
                    </td>
                 </tr>
             </table>
         </div>
 </section>
</asp:Content>
