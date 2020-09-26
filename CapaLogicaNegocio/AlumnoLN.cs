using CapaAccesoDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CapaLogicaNegocio
{
    public class AlumnoLN
    {
        private static AlumnoLN aluln = null;
        private AlumnoLN() { }
        public static AlumnoLN getInstance()
        {
            if (aluln == null)
            {
                aluln = new AlumnoLN();
            }
            return aluln;
        }
        public List<Alumno> ListarAlumnos()
        {
            try
            {
                return AlumnoDAO.getInstance().ListarAlumnos();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
