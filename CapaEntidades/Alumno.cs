using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CapaEntidades
{
    public class Alumno
    {
        public int idAlumno { get; set; }
        public string nombreAlumno { get; set; }
        public string apellidoAlumno { get; set; }
        public string telefono { get; set; }
        public string turno { get; set; }
        public string usuario { get; set; }
        public Alumno(int idAlumno, string nombreAlumno, string apellidoAlumno, string telefono, string turno, string usuario)
        {
            this.idAlumno = idAlumno;
            this.nombreAlumno = nombreAlumno;
            this.apellidoAlumno = apellidoAlumno;
            this.telefono = telefono;
            this.turno = turno;
            this.usuario = usuario;
        }
        public Alumno() { }
    }
}