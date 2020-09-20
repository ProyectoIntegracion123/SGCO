<%@ Page Title="" Language="C#" MasterPageFile="~/Paciente.Master" AutoEventWireup="true" CodeBehind="EditarPaciente.aspx.cs" Inherits="CapaPresentacion.EditarPaciente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

 <section class="content-header">
     <h1 style="text-align:center">ACTUALIZAR DATOS DE PACIENTE</h1>
 </section>
 <section class="content" >
     <div class="row" align="center">
         <div class="col-md-12">
             <div class="box box-primary" align="center">
                 <div class="box-body">
                     <div class="form-group">
                         <label>NOMBRES</label>
                     </div>
                     <div class="form-group">
                         <asp:TextBox ID="txtNombres" runat="server" Text="" CssClass="form-control" Width="236px" ReadOnly="True"></asp:TextBox>
                     </div>
                     <div class="form-group">
                         <label>APELLIDOS</label>
                     </div>
                     <div class="form-group">
                         <asp:TextBox ID="txtApellidos" runat="server" Text="" CssClass="form-control" Width="232px" ReadOnly="True"></asp:TextBox>
                     </div>     
                     <div class="form-group">
                         <label>DNI</label>
                     </div>
                     <div class="form-group">
                         <asp:TextBox ID="DNI" runat="server" Text="" CssClass="form-control" Width="232px" ReadOnly="True"></asp:TextBox>
                     </div>  
                     <div class="form-group">
                         <label>Edad</label>
                     </div>
                     <div class="form-group">
                         <asp:TextBox ID="Edad" runat="server" Text="" CssClass="form-control" Width="232px" ReadOnly="True"></asp:TextBox>
                     </div>    
                     <div class="form-group">
                         <label>Telefono Actual</label>
                     </div>
                     <div class="form-group">
                         <asp:TextBox ID="Telefono" runat="server" Text="" CssClass="form-control" Width="232px" MaxLength="9" ReadOnly="True" ></asp:TextBox>
                     </div>   
                     <div class="form-group">
                         <label>Telefono Nuevo</label>
                     </div>
                     <div class="form-group">
                         <asp:TextBox ID="TelefonoNew" runat="server" Text="" CssClass="form-control" Width="232px" MaxLength="9"  ></asp:TextBox>
                     </div>   
                       <div class="form-group">
                         <label>Direccion Actual</label>
                     </div>
                     <div class="form-group">
                         <asp:TextBox ID="Direccion" runat="server" Text="" CssClass="form-control" Width="232px" ReadOnly="True"></asp:TextBox>
                     </div>   
                             <div class="form-group">
                         <label>Direccion Nueva</label>
                     </div>
                     <div class="form-group">
                         <asp:TextBox ID="DireccionNew" runat="server" Text="" CssClass="form-control" Width="232px"></asp:TextBox>
                     </div>   
                     <div class="form-group">
                         <label>Fecha de Nacimiento</label>
                     </div>
                     <div class="form-group">
                         <asp:TextBox ID="fechanac" runat="server" Text="" CssClass="form-control" Width="232px" ReadOnly="True" MaxLength="9"></asp:TextBox>
                     </div>  
                      <div class="form-group">
                         <label>Contraseña</label>
                     </div>
                     <div class="form-group">
                         <asp:TextBox ID="contraseña" runat="server" Text="" CssClass="form-control" Width="232px" ReadOnly="True" TextMode="Password"></asp:TextBox>
                         <asp:Button ID="btnVer" runat="server" CssClass="btn btn-primary" Width="50px" Text="Ver"     OnClick="btnVer_Click"   />
                     </div>   
                 </div>
             </div>
         </div>
         
     </div>
     
         <div align="center">
             <table>
                 <tr>
                    <td>
                        <asp:Button ID="btnGuardar" runat="server" CssClass="btn btn-primary" Width="200px" Text="Guardar"  Height="38px" OnClick="btnGuardar_Click"    />
                    </td>
                     <td>&nbsp;&nbsp;&nbsp;&nbsp;</td>
                    <td>
                        <asp:Button ID="btnCancelar" runat="server" CssClass="btn btn-danger" Width="200px" Text="Cancelar" Height="44px" OnClick="btnCancelar_Click"  />
                    </td>
                 </tr>
             </table>
         </div>
 </section>
</asp:Content>