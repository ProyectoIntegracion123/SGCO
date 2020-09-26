using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace CapaPresentacion
{
    public partial class PrincipalAdministrador : System.Web.UI.Page
    {
        string connectionString = @"Server=rodrinchelo.database.windows.net;Database=ClinicaOdontologica;User Id=UserClinica;Password=Clinica123;";
        protected void Page_Load(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("select * from Alumno", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                listAlumnos.DataSource = dtbl;
                listAlumnos.DataBind();
            }
        }
    }
}