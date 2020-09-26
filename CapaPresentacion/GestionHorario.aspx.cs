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
    public partial class GestionHorario : System.Web.UI.Page
    {
        string connectionString = @"Server=rodrinchelo.database.windows.net;Database=ClinicaOdontologica;User Id=UserClinica;Password=Clinica123;";
        string buscar;
        protected void Page_Load(object sender, EventArgs e)
        {
           /* if (!IsPostBack)
            {
                PopulateGridView();
            }*/
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
             buscar=txtBuscar.Text;
            PopulateGridView(buscar);

        }

        void PopulateGridView(String buscar)
        {
            DataTable dtbl = new DataTable();
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("select ha.idHorario,a.idAlumno, a.nombreAlumno,ho.fecha,ho.turno from Alumno a inner join Horario_has_Alumno  ha on   a.idAlumno=ha.idAlumno inner join Horario ho on ho.idHorario = ha.idHorario where a.idAlumno =" + buscar+"", sqlCon);
                sqlDa.Fill(dtbl);
            }
            if (dtbl.Rows.Count > 0)
            {
                listAlumnos.DataSource = dtbl;
                listAlumnos.DataBind();
            }
            else
            {
                dtbl.Rows.Add(dtbl.NewRow());
                listAlumnos.DataSource = dtbl;
                listAlumnos.DataBind();
                listAlumnos.Rows[0].Cells.Clear();
                listAlumnos.Rows[0].Cells.Add(new TableCell());
                listAlumnos.Rows[0].Cells[0].ColumnSpan = dtbl.Columns.Count;
                listAlumnos.Rows[0].Cells[0].Text = "No data";
                listAlumnos.Rows[0].Cells[0].HorizontalAlign = HorizontalAlign.Center;
            }
        }
        protected void listAlumnos_RowEditing(object sender, GridViewEditEventArgs e)
        {
            listAlumnos.EditIndex = e.NewEditIndex;
            //PopulateGridView(buscar);
        }
        protected void listAlumnos_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            try
            {

                Console.WriteLine(buscar);
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    string query = "update Horario_has_Alumno set idHorario=@idHorario where idAlumno=" +buscar+"";
                    SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
                    sqlCmd.Parameters.AddWithValue("@idHorario", Convert.ToInt32(listAlumnos.DataKeys[e.RowIndex].Value.ToString()));
                    sqlCmd.ExecuteNonQuery();
                    listAlumnos.EditIndex = -1;
                    PopulateGridView(buscar);
                    lblSuccesMessage.Text = "Alumno Modificado";
                    lblErrorMessage.Text = "";
                }
            }


            catch (Exception ex)
            {
                lblSuccesMessage.Text = "";
                lblErrorMessage.Text = ex.Message;
            }
        }
        /*
        protected void listAlumnosHorario_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            try
            {

                if (e.CommandName.Equals("AddNew"))
                {
                    using (SqlConnection sqlCon = new SqlConnection(connectionString))
                    {
                        sqlCon.Open();
                        string query = "INSERT INTO Alumno (idAlumno,nombreAlumno,apellidoAlumno,telefono,turno) VALUES (@idAlumno,@nombreAlumno,@apellidoAlumno,@telefono,@turno)";
                        SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
                        sqlCmd.Parameters.AddWithValue("@idAlumno", (listAlumnos.FooterRow.FindControl("txtIDFooter") as TextBox).Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@nombreAlumno", (listAlumnos.FooterRow.FindControl("txtNombreFooter") as TextBox).Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@apellidoAlumno", (listAlumnos.FooterRow.FindControl("txtApellidoFooter") as TextBox).Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@telefono", (listAlumnos.FooterRow.FindControl("txtTelefonoFooter") as TextBox).Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@turno", (listAlumnos.FooterRow.FindControl("txtTurnoFooter") as TextBox).Text.Trim());
                        sqlCmd.ExecuteNonQuery();
                        PopulateGridView();
                        lblSuccesMessage.Text = "Nuevo Alumno Agregado";
                        lblErrorMessage.Text = "";
                    }
                }

            }
            catch (Exception ex)
            {
                lblSuccesMessage.Text = "";
                lblErrorMessage.Text = ex.Message;
            }
        }

        protected void listAlumnos_RowEditing(object sender, GridViewEditEventArgs e)
        {
            listAlumnos.EditIndex = e.NewEditIndex;
            PopulateGridView();
        }

        protected void listAlumnos_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            listAlumnos.EditIndex = -1;
            PopulateGridView();
        }

        protected void listAlumnos_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            try
            {


                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    string query = "UPDATE Alumno SET idAlumno=@idAlumno,nombreAlumno=@nombreAlumno,apellidoAlumno=@apellidoAlumno,telefono=@telefono,turno=@turno WHERE idAlumno=@idAlumno";
                    SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
                    sqlCmd.Parameters.AddWithValue("@idAlumno", Convert.ToInt32(listAlumnos.DataKeys[e.RowIndex].Value.ToString()));
                    sqlCmd.Parameters.AddWithValue("@nombreAlumno", (listAlumnos.Rows[e.RowIndex].FindControl("txtNombre") as TextBox).Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@apellidoAlumno", (listAlumnos.Rows[e.RowIndex].FindControl("txtApellido") as TextBox).Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@telefono", (listAlumnos.Rows[e.RowIndex].FindControl("txtTelefono") as TextBox).Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@turno", (listAlumnos.Rows[e.RowIndex].FindControl("txtTurno") as TextBox).Text.Trim());
                    sqlCmd.ExecuteNonQuery();
                    listAlumnos.EditIndex = -1;
                    PopulateGridView();
                    lblSuccesMessage.Text = "Alumno Modificado";
                    lblErrorMessage.Text = "";
                }
            }


            catch (Exception ex)
            {
                lblSuccesMessage.Text = "";
                lblErrorMessage.Text = ex.Message;
            }
        }

        protected void listAlumnos_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {


                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    string query = "DELETE FROM Alumno WHERE idAlumno=@idAlumno";
                    SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
                    sqlCmd.Parameters.AddWithValue("@idAlumno", Convert.ToInt32(listAlumnos.DataKeys[e.RowIndex].Value.ToString()));
                    sqlCmd.ExecuteNonQuery();
                    PopulateGridView();
                    lblSuccesMessage.Text = "Alumno Eliminado";
                    lblErrorMessage.Text = "";
                }
            }
            catch (Exception ex)
            {
                lblSuccesMessage.Text = "";
                lblErrorMessage.Text = ex.Message;
            }
        }*/


    }
}