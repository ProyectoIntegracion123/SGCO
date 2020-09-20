using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using CapaEntidades;
using CapaLogicaNegocio;

namespace CapaPresentacion
{
    public partial class EditarPaciente : System.Web.UI.Page
    {
        String telefox;
        protected void Page_Load(object sender, EventArgs e)
        {
            CapaEntidades.Paciente objPaciente = PacienteLN.getInstance().DatosPaciente(Session["USER_ID"].ToString());
            txtNombres.Text = objPaciente.nombre;
            txtApellidos.Text = objPaciente.apellidos;
            DNI.Text = objPaciente.idPaciente;
            Edad.Text = objPaciente.edad.ToString(); 
            Direccion.Text = objPaciente.direccion;
            Telefono.Text = objPaciente.telefono;
            contraseña.Text = objPaciente.contra;
            fechanac.Text = String.Format("{0:dd/MM/yyyy}", objPaciente.fecha_nac);
        }
 

    protected void btnCancelar_Click(object sender, EventArgs e)
    {
        Response.Redirect("PrincipalPaciente.aspx");
    }

        protected void btnVer_Click(object sender, EventArgs e)
        {
            contraseña.TextMode = TextBoxMode.SingleLine;
        }
        protected void btnGuardar_Click(object sender, EventArgs e)
    {

            String idPacien = DNI.Text;
            String telefo = TelefonoNew.Text;
            String direcc = DireccionNew.Text;

      /*     if(String.Equals(telefo,""))
            {
                Response.Redirect("PrincipalPaciente.aspx");
            }
           else
            {
                bool response = PacienteLN.getInstance().EditarPaciente(idPacien, telefo);
                if (response == true)
                {
                    Response.Write("<script>alert('EDICION CORRECTA.')</script>");
                    Response.Redirect("PrincipalPaciente.aspx");
                }
                else
                {
                    Response.Write("< script > alert('EDICION INCORRECTA.') </ script > ");
                    // Response.Redirect("EditarPaciente.aspx");
                }
            }


            if (String.Equals(direcc, ""))
            {
                Response.Redirect("PrincipalPaciente.aspx");
            }
            else
            {
                bool response = PacienteLN.getInstance().EditarPaciente2(idPacien, direcc);
                if (response == true)
                {
                    Response.Write("<script>alert('EDICION CORRECTA.')</script>");
                    Response.Redirect("PrincipalPaciente.aspx");
                }
                else
                {
                    Response.Write("< script > alert('EDICION INCORRECTA.') </ script > ");
                    // Response.Redirect("EditarPaciente.aspx");
                }
            } */

            if (String.Equals(direcc, "") & String.Equals(telefo, ""))
            {
                Response.Redirect("PrincipalPaciente.aspx");
            }
            else
            {
                bool response = PacienteLN.getInstance().EditarPaciente3(idPacien, direcc, telefo);
                if (response == true)
                {
                    Response.Write("<script>alert('EDICION CORRECTA.')</script>");
                    Response.Redirect("PrincipalPaciente.aspx");
                }
                else
                {
                    Response.Write("< script > alert('EDICION INCORRECTA.') </ script > ");
                }
            }

        }


    }
}