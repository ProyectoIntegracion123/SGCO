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
                         <asp:TextBox ID="txtNombres" runat="server" Text="" CssClass="form-control" Width="235px" MaxLength="30" ></asp:TextBox>
             
                     </div>
                     <div class="form-group">
                         <label>APELLIDOS</label>
                     </div>
                     <div class="form-group">
                         <asp:TextBox ID="txtApellidos" runat="server" Text="" CssClass="form-control" Width="232px" MaxLength="30"></asp:TextBox>
                     </div>     
                     <div class="form-group">
                         <label>DNI</label>
                     </div>
                     <div class="form-group">
                         <asp:TextBox ID="DNI" runat="server" Text="" CssClass="form-control" Width="232px" MaxLength="8"></asp:TextBox>
                     </div>  
                     <div class="form-group">
                         <label>EDAD</label>
                     </div>
                     <div class="form-group">
                         <asp:TextBox ID="Edad" runat="server" Text="" CssClass="form-control" Width="232px" MaxLength="2"></asp:TextBox>
                     </div>    
                     <div class="form-group">
                         <label>N° CELULAR</label>
                     </div>
                     <div class="form-group">
                         <asp:TextBox ID="Telefono" runat="server" Text="" CssClass="form-control" Width="232px" MaxLength="9"></asp:TextBox>
                     </div>   
                       <div class="form-group">
                         <label>Direccion</label>
                     </div>
                     <div class="form-group">
                         <asp:TextBox ID="Direccion" runat="server" Text="" CssClass="form-control" Width="232px" MaxLength="30"></asp:TextBox>
                     </div>   
                     <div class="form-group">
                         <label>Fecha de Nacimiento</label> 
                     </div>
                      <div class="form-group">
                         <label>Dia</label> &nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp
                         <label>Mes</label> &nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp
                         <label>Año</label> 
                     </div>
                     <div class="form-group">
                         <asp:TextBox ID="fn_dia" runat="server" Text=""  placeholder="DD" CssClass="form-control" Width="50px" MaxLength="2" ></asp:TextBox>&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp
                         <asp:TextBox ID="fn_mes" runat="server" Text=""  placeholder="MM" CssClass="form-control" Width="50px" MaxLength="2" ></asp:TextBox>&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp
                         <asp:TextBox ID="fn_anio" runat="server" Text=""  placeholder="YYYY" CssClass="form-control" Width="50px" MaxLength="4" ></asp:TextBox>
                     </div>  
                      <div class="form-group">
                         <label>Contraseña</label>
                     </div>
                     <div class="form-group">
                         <asp:TextBox ID="contraseña" runat="server" Text="" CssClass="form-control" Width="232px" TextMode="Password"></asp:TextBox>
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
