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

        public Paciente DatosPaciente(String idPaciente)
        {
            try
            {
                return PacienteDAO.getInstance().DatosPaciente(idPaciente);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public bool EditarPaciente(String idPaciente, String telefono)
        {
            try
            {
                return PacienteDAO.getInstance().EditarPaciente(idPaciente, telefono);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool EditarPaciente2(String idPaciente, String direccion)
        {
            try
            {
                return PacienteDAO.getInstance().EditarPaciente2(idPaciente, direccion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool EditarPaciente3(String idPaciente, String direccion, String telefono)
        {
            try
            {
                return PacienteDAO.getInstance().EditarPaciente3(idPaciente, direccion, telefono);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}