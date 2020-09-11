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
    public partial class RegistrarPaciente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {

            }
        }
        private CapaEntidades.Paciente GetEntity()
        {
            CapaEntidades.Paciente objPaciente = new CapaEntidades.Paciente();
            objPaciente.idPaciente = DNI.Text ;
            objPaciente.contra = contraseña.Text;
            objPaciente.nombre = txtNombres.Text;
            objPaciente.apellidos = txtApellidos.Text;
            objPaciente.edad= Convert.ToInt32(Edad.Text);
            objPaciente.telefono = Telefono.Text;
            objPaciente.direccion =Direccion.Text;
            objPaciente.fecha_nac = Convert.ToDateTime(fechanac.Text);
            objPaciente.estado = "1";
            objPaciente.usuario = "1";

            return objPaciente;
        }
        private CapaEntidades.Paciente GetPaciente()
        {
            return null;
        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            //Registro del paciente
            CapaEntidades.Paciente objPaciente = GetEntity();
            //Enviar a la capa Logica de Negocio
            bool response = PacienteLN.getInstance().RegistrarPaciente(objPaciente);
            if (response == true)
            {
                Response.Write("<script>alert('REGISTRO CORRECTO.')</script>");
            }
            else
            {
                Response.Write("< script > alert('REGISTRO INCORRECTO.') </ script > ");
            }
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
    }
}