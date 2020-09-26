using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CapaAccesoDatos
{
    public class AlumnoDAO
    {
        private static AlumnoDAO aluDao = null;
        private AlumnoDAO() { }
        public static AlumnoDAO getInstance()
        {
            if (aluDao == null)
            {
                aluDao = new AlumnoDAO();
            }
            return aluDao;
        }
        public List<Alumno> ListarAlumnos()
        {
            SqlConnection conexion = null;
            SqlCommand cmd = null;
            List<Alumno> alumno = new List<Alumno>();
            SqlDataReader dr = null;
            try
            {
                conexion = Conexion.getInstance().ConexionDB();
                cmd = new SqlCommand("spListarAlumnos", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                conexion.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Alumno alu = new Alumno(Convert.ToInt32(dr[0]), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString());
                        alumno.Add(alu);
                    }
                }
            }
            catch (Exception ex)
            {
                alumno = null;
                throw ex;
            }
            finally
            {
                conexion.Close();
            }
            return alumno;
        }
    }

}