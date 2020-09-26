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
    public partial class StudentView : System.Web.UI.Page
    {
        string connectionString = @"Server=rodrinchelo.database.windows.net;Database=ClinicaOdontologica;User Id=UserClinica;Password=Clinica123;";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                PopulateGridView();
            }
        }

        void PopulateGridView()
        {
           /* List<Alumno> alumnos = AlumnoLN.getInstance().ListarAlumnos();
            listAlumnos.DataSource = alumnos;
            listAlumnos.DataBind();*/
            DataTable dtbl = new DataTable();
            using (SqlConnection sqlCon= new SqlConnection(connectionString))
            {
                sqlCon.Open();
              //  SqlDataAdapter sqlDa = new SqlDataAdapter("Select * from HC", sqlCon);
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM HC INNER JOIN Cita ON HC.idHC = Cita.idHA;", sqlCon);
                sqlDa.Fill(dtbl);
            }
            if(dtbl.Rows.Count > 0)
            {
                listHC.DataSource = dtbl;
                listHC.DataBind();
            }
            else
            {
                dtbl.Rows.Add(dtbl.NewRow());
                listHC.DataSource = dtbl;
                listHC.DataBind();
                listHC.Rows[0].Cells.Clear();
                listHC.Rows[0].Cells.Add(new TableCell());
                listHC.Rows[0].Cells[0].ColumnSpan = dtbl.Columns.Count;
                listHC.Rows[0].Cells[0].Text = "No data";
                listHC.Rows[0].Cells[0].HorizontalAlign = HorizontalAlign.Center;
            }
        }
    }
}