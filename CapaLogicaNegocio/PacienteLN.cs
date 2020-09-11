using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaAccesoDatos;
using CapaEntidades;
namespace CapaLogicaNegocio
{
    public class PacienteLN
    {
        #region "PATRON SINGLETON"
        private static PacienteLN objPaciente = null;
        private PacienteLN() { }
        public static PacienteLN getInstance()
        {
            if(objPaciente ==null)
            {
                objPaciente = new PacienteLN();
            }
            return objPaciente;
        }
        #endregion
 

    public Paciente AccesoSistema(String idPaciente, String contra)
    {
        try
        {
            return PacienteDAO.getInstance().AccesoSistema(idPaciente, contra);
        }
        catch(Exception ex)
        {
            throw ex;
        }
        
    }

        public bool RegistrarPaciente(Paciente objPaciente)
        {
            try
            {
                return PacienteDAO.getInstance().RegistrarPaciente(objPaciente);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}