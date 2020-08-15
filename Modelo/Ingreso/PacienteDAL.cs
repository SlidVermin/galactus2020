using System;
using System.Data.SqlClient;
using Modelo.General;
using Modelo.General.Instrucciones;
using Entidad.Ingreso;

namespace Modelo.Ingreso
{
    public class PacienteDAL
    {
       public static void guardar(Paciente paciente)
        {
            try
            {
                using(SqlCommand comando = new SqlCommand())
                {
                    comando.Connection = SesionActualDAL.getConexion();
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.CommandText = SentenciasDAL.PACIENTE_CREAR;
                    comando.Parameters.Add(new SqlParameter("@IdPaciente", System.Data.SqlDbType.Int)).Value = paciente.idPaciente;
                    comando.Parameters.Add(new SqlParameter("@IdTipoidentificacion", System.Data.SqlDbType.Int)).Value = paciente.tipoIdentificacion;
                    comando.Parameters.Add(new SqlParameter("@Documento", System.Data.SqlDbType.Int)).Value = paciente.documentoIndentidad;
                    comando.Parameters.Add(new SqlParameter("@IdMunicipioExpedicion", System.Data.SqlDbType.Int)).Value = paciente.idMunicipioExpedicion;
                    comando.Parameters.Add(new SqlParameter("@PimerNombre", System.Data.SqlDbType.NVarChar)).Value = paciente.primeroNombre;
                    comando.Parameters.Add(new SqlParameter("@SegundoNombre", System.Data.SqlDbType.NVarChar)).Value = paciente.segundoNombre;
                    comando.Parameters.Add(new SqlParameter("@PrimerApellido", System.Data.SqlDbType.NVarChar)).Value = paciente.primerApellido;
                    comando.Parameters.Add(new SqlParameter("@SegundoApellido", System.Data.SqlDbType.NVarChar)).Value = paciente.segundoApellido;
                    comando.Parameters.Add(new SqlParameter("@IdGenero", System.Data.SqlDbType.Int)).Value = paciente.idGenero;
                    comando.Parameters.Add(new SqlParameter("@IdMunicipioResidencia", System.Data.SqlDbType.Int)).Value = paciente.idMunicipioResidencia;
                    comando.Parameters.Add(new SqlParameter("@IdMunicipioNacimiento", System.Data.SqlDbType.Int)).Value = paciente.idMunicipioNacimiento;
                    comando.Parameters.Add(new SqlParameter("@Direccion", System.Data.SqlDbType.NVarChar)).Value = paciente.direccionResidencia;
                    comando.Parameters.Add(new SqlParameter("@Telefono", System.Data.SqlDbType.NVarChar)).Value = paciente.telefono;
                    comando.Parameters.Add(new SqlParameter("@Celular", System.Data.SqlDbType.NVarChar)).Value = paciente.celular;
                    comando.Parameters.Add(new SqlParameter("@IdEps", System.Data.SqlDbType.Int)).Value = paciente.idEps;
                    comando.Parameters.Add(new SqlParameter("@FechaNacimiento", System.Data.SqlDbType.Date)).Value = paciente.fechaNacimiento;
                    comando.Parameters.Add(new SqlParameter("@Correo", System.Data.SqlDbType.NVarChar)).Value = paciente.correo;
                    comando.Parameters.Add(new SqlParameter("@IdUsuario", System.Data.SqlDbType.Int)).Value = SesionActualDAL.IdUsuario;
                    comando.Parameters.Add(new SqlParameter("@IdRegimen", System.Data.SqlDbType.Int)).Value = paciente.idRegimen;
                    comando.Parameters.Add(new SqlParameter("@IdTipoAfiliacion", System.Data.SqlDbType.Int)).Value = paciente.idTipoAfiliacion;
                    comando.Parameters.Add(new SqlParameter("@IdEstratoSocial", System.Data.SqlDbType.Int)).Value = paciente.idestrato;
                    comando.Parameters.Add(new SqlParameter("@IdEstadoCivil", System.Data.SqlDbType.Int)).Value = paciente.idEstadoCivil;
                    comando.Parameters.Add(new SqlParameter("@IdZona", System.Data.SqlDbType.Int)).Value = paciente.idZonaUrbana;
                    paciente.idPaciente = (int)comando.ExecuteScalar();
                }
            }catch(Exception ex)
            {
                throw ex;
            }
        }
        public static void eliminarPaciente(Paciente paciente)
        {
            try
            {
                using(SqlCommand comando = new SqlCommand())
                {
                    comando.Connection = SesionActualDAL.getConexion();
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.CommandText = SentenciasDAL.PACIENTE_ANULAR;
                    comando.Parameters.Add(new SqlParameter("@IdPaciente", System.Data.SqlDbType.Int)).Value = paciente.idPaciente;
                    comando.ExecuteNonQuery();
                }
            }catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
