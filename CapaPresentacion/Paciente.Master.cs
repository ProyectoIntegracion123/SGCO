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
    public partial class Paciente : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            CapaEntidades.Paciente objPaciente = PacienteLN.getInstance().DatosPaciente(Session["USER_ID"].ToString());
            nombre.Text = objPaciente.nombre;
            apellidos.Text = objPaciente.apellidos;
            edad.Text = objPaciente.edad.ToString()+" años";

          
        }
    }
}