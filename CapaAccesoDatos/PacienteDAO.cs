﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CapaEntidades;
using System.Data;

namespace CapaAccesoDatos
{
    public class PacienteDAO
    {
        #region "PATRON SINGLETON"
        private static PacienteDAO daoPaciente = null;
        private PacienteDAO() { }
        public static PacienteDAO getInstance()
        {
            if(daoPaciente == null)
            {
                daoPaciente = new PacienteDAO();
            }
            return daoPaciente;
        }
        #endregion

        public Paciente AccesoSistema(String idPaciente, String contra)
        {
            SqlConnection conexion = null;
            SqlCommand cmd = null;
            Paciente objPaciente = null;
            SqlDataReader dr = null;

            try
            {
                conexion = Conexion.getInstance().ConexionDB();
                cmd = new SqlCommand("spAccesoSistema", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@prmUser", idPaciente);
                cmd.Parameters.AddWithValue("@prmPass", contra);
                conexion.Open();
                dr = cmd.ExecuteReader();
                if ( dr.Read())
                {
                    objPaciente = new Paciente();
                    objPaciente.idPaciente = dr["idPaciente"].ToString();
                    objPaciente.contra = dr["contra"].ToString();
                }
            }
            catch (Exception ex)
            {
                objPaciente = null;
                throw ex;
            }
            finally
            {
                conexion.Close();
            }
            return objPaciente;
        }

        public bool RegistrarPaciente(Paciente objPaciente)
        {


            SqlConnection con = null;
            SqlCommand cmd = null;
            bool response = false;
            try
            {
                con = Conexion.getInstance().ConexionDB();
                cmd = new SqlCommand("spRegistrarPaciente", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@prmNombres", objPaciente.nombre);
                cmd.Parameters.AddWithValue("@prmApellidos", objPaciente.apellidos);
                cmd.Parameters.AddWithValue("@prmDNI", objPaciente.idPaciente);
                cmd.Parameters.AddWithValue("@prmEdad", objPaciente.edad);
                cmd.Parameters.AddWithValue("@prmTelefono", objPaciente.telefono);
                cmd.Parameters.AddWithValue("@prmDireccion", objPaciente.direccion);
                cmd.Parameters.AddWithValue("@prmFechaNac", objPaciente.fecha_nac);
                cmd.Parameters.AddWithValue("@prmEstado", objPaciente.estado);
                cmd.Parameters.AddWithValue("@prmUsuario", objPaciente.usuario);
                cmd.Parameters.AddWithValue("@prmContra", objPaciente.contra);
                con.Open();

                int filas = cmd.ExecuteNonQuery();
                if (filas > 0) response = true;
            }
            catch (Exception ex)
            {
                response = false;
                throw ex;
            }
            finally
            {
                con.Close();
            }
            return response;
        }
    }
}
