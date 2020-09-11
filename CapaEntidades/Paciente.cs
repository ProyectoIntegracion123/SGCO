using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Paciente
    {
        public String idPaciente { get; set; }
        public String contra { get; set; }
        public String nombre { get; set; }
        public String apellidos { get; set; }
        public int edad { get; set; }
        public String telefono { get; set; }
        public String direccion { get; set; }
        public DateTime fecha_nac { get; set; }
        public String estado { get; set;}
        public String usuario { get; set; }

    public Paciente() { }

    public Paciente(String idPaciente, String contra, String nombre, String apellidos, int edad, String telefono,String direccion, DateTime fecha_nac, String estado, String usuario)
        {
            this.idPaciente = idPaciente;
            this.contra = contra;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.edad = edad;
            this.telefono = telefono;
            this.direccion = direccion;
            this.fecha_nac = fecha_nac;
            this.estado = estado;
            this.usuario = usuario;
        }


}
}
