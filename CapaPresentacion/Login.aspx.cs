using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaEntidades;
using CapaLogicaNegocio;

namespace CapaPresentacion
{
    public partial class Login : System.Web.UI.Page
    {

        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_Ingresar_Click(object sender, EventArgs e)
        {

                String idPaciente =  String.Format("{0,4}",Request.Form["txtUsuario"]);
                String contra = String.Format("{0,3}", Request.Form["txtPassword"]);
           
        if(idPaciente.Equals("admin"))
            {
                Response.Redirect("VerAlumnos.aspx");
            }
            else
            {
                CapaEntidades.Paciente objPaciente = PacienteLN.getInstance().AccesoSistema(idPaciente, contra);

                if (objPaciente != null)
                {
                    Session["USER_ID"] = idPaciente;
                    Response.Redirect("PrincipalPaciente.aspx");
                }
                else
                {
                    Response.Write("<script>alert('USUARIO INCORRECTO.')</script>");
                }
            }



        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("RegistrarPaciente.aspx");
        }
    }
}