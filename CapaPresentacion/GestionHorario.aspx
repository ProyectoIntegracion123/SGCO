<%@ Page Title="" Language="C#" MasterPageFile="~/Administrador.Master" AutoEventWireup="true" CodeBehind="GestionHorario.aspx.cs" Inherits="CapaPresentacion.GestionHorario" %>
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
                <asp:Button ID="btnBuscar" runat="server" CssClass="btn btn-primary" width="100px" Text="Buscar" OnClick="btnBuscar_Click"/>
            </div>
        </div>
        <div>
           <asp:GridView ID="listAlumnos" style="margin-left:10%;"  runat="server" AutoGenerateColumns="false" BackColor="White" BorderColor="#0066CC" BorderStyle="Solid" Font-Names="Comic Sans MS" Font-Size="Medium" ShowFooter="true" 
                DataKeyNames="idHorario" 
                OnRowEditing="listAlumnos_RowEditing"
                OnRowUpdating="listAlumnos_RowUpdating"
                ShowHeaderWhenEmpty="true">
                <Columns>
                     <asp:TemplateField HeaderText="IDHorario">
                        <ItemTemplate>
                            <asp:Label Text='<%# Eval("idHorario") %>' runat="server" />
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtHorario" Text='<%# Eval("idHorario") %>' runat="server" />
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:TextBox ID="txtHorarioFooter" runat="server" />
                        </FooterTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="IDAlum">
                        <ItemTemplate>
                            <asp:Label Text='<%# Eval("idAlumno") %>' runat="server" />
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtAlumno" Text='<%# Eval("idAlumno") %>' runat="server" />
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:TextBox ID="txtAlumnoFooter" runat="server" />
                        </FooterTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Nombre">
                        <ItemTemplate>
                            <asp:Label Text='<%# Eval("nombreAlumno") %>' runat="server" />
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtNombre" Text='<%# Eval("nombreAlumno") %>' runat="server" />
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:TextBox ID="txtNombreFooter" runat="server" />
                        </FooterTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Fecha">
                        <ItemTemplate>
                            <asp:Label Text='<%# Eval("fecha") %>' runat="server" />
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtFecha" Text='<%# Eval("fecha") %>' runat="server" />
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:TextBox ID="txtFechaFooter" runat="server" />
                        </FooterTemplate>
                    </asp:TemplateField>
                    
                   
                    <asp:TemplateField HeaderText="TURNO">
                        <ItemTemplate>
                            <asp:Label Text='<%# Eval("turno") %>' runat="server" />
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtTurno" Text='<%# Eval("turno") %>' runat="server" />
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:TextBox ID="txtTurnoFooter" runat="server" />
                        </FooterTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:ImageButton ImageUrl="~/images/edit.png" runat="server" CommandName="Edit" ToolTip="Edit" Width="20px" Height="20px"/>
                            <asp:ImageButton ImageUrl="~/images/delete.png" runat="server" CommandName="Delete" ToolTip="Delete" Width="20px" Height="20px"/>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:ImageButton ImageUrl="~/images/save.png" runat="server" CommandName="Update" ToolTip="Update" Width="20px" Height="20px"/>
                            <asp:ImageButton ImageUrl="~/images/cancel.png" runat="server" CommandName="Cancel" ToolTip="Cancel" Width="20px" Height="20px"/>
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:ImageButton ImageUrl="~/images/addnew.png" runat="server" CommandName="AddNew" ToolTip="Add New" Width="20px" Height="20px"/>
                        </FooterTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
            <br />
            <asp:Label ID="lblSuccesMessage" Text="" runat="server" ForeColor="Green" />
            <br />
            <asp:Label ID="lblErrorMessage" Text="" runat="server" ForeColor="Red" />
        </div>
        
     </section>
</asp:Content>
