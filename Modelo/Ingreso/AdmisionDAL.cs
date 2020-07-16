using Modelo.General;
using Modelo.General.Instrucciones;
using Modelo.Ingreso;
using System.Data.SqlClient;
using System;
using Entidad.Ingreso;

namespace Modelo.Ingreso
{
    public class AdmisionDAL
    {
        public static void guardar(Admision admision)            
        {
            try
            {
                using (SqlCommand comando = new SqlCommand())
                {
                    comando.Connection = SesionActualDAL.getConexion();
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.CommandText = SentenciasDAL.ADMISION_CREAR;
                    comando.Parameters.Add(new SqlParameter("@IdAtencion", System.Data.SqlDbType.Int)).Value = admision.idAdmision;
                    comando.Parameters.Add(new SqlParameter("@IdPaciente", System.Data.SqlDbType.Int)).Value = admision.idPaciente;
                    comando.Parameters.Add(new SqlParameter("@IdEspecialidad", System.Data.SqlDbType.Int)).Value = admision.idEspecialidad;
                    comando.Parameters.Add(new SqlParameter("@IdTriage", System.Data.SqlDbType.Int)).Value = admision.idTriage;
                    comando.Parameters.Add(new SqlParameter("@IdContrato", System.Data.SqlDbType.Int)).Value = admision.idContrato;
                    comando.Parameters.Add(new SqlParameter("@Ideps", System.Data.SqlDbType.Int)).Value = admision.idEps;
                    comando.Parameters.Add(new SqlParameter("@TipoDocumentoAcom", System.Data.SqlDbType.Int)).Value = admision.tipoDocumentoAcompañante;
                    comando.Parameters.Add(new SqlParameter("@DocumentoAcom", System.Data.SqlDbType.Int)).Value = (admision.identificacionAcompañante.Equals(String.Empty)) ? 0: int.Parse(admision.identificacionAcompañante);
                    comando.Parameters.Add(new SqlParameter("@TipoDocumentoRes", System.Data.SqlDbType.Int)).Value = admision.tipoDocumentoResponsable;
                    comando.Parameters.Add(new SqlParameter("@DocumentoRes", System.Data.SqlDbType.Int)).Value = (admision.identificacionResponsable.Equals(String.Empty)) ? 0: int.Parse(admision.identificacionResponsable) ;
                    comando.Parameters.Add(new SqlParameter("@IdMunicipioAcom", System.Data.SqlDbType.Int)).Value = admision.idMunicipioAcompañante;
                    comando.Parameters.Add(new SqlParameter("@IdMunicipioRes", System.Data.SqlDbType.Int)).Value = admision.idMunicipioResponsable;
                    comando.Parameters.Add(new SqlParameter("@DireccionAcom", System.Data.SqlDbType.NVarChar)).Value = admision.direccionAcompañante;
                    comando.Parameters.Add(new SqlParameter("@DireccionRes", System.Data.SqlDbType.NVarChar)).Value = admision.direccionResponsable;
                    comando.Parameters.Add(new SqlParameter("@TelefonoAcom", System.Data.SqlDbType.Int)).Value = (admision.telefonoAcompañante.Equals(String.Empty)) ? 0: int.Parse(admision.telefonoAcompañante);
                    comando.Parameters.Add(new SqlParameter("@TelefonoRes", System.Data.SqlDbType.Int)).Value = (admision.telefonoResponsable.Equals(String.Empty)) ? 0 : int.Parse(admision.telefonoResponsable);
                    comando.Parameters.Add(new SqlParameter("@idUsuario", System.Data.SqlDbType.Int)).Value = SesionActualDAL.IdUsuario;
                    comando.Parameters.Add(new SqlParameter("@fechaAdmision", System.Data.SqlDbType.Date)).Value = admision.fecha;
                    comando.Parameters.Add(new SqlParameter("@acompananteTrue", System.Data.SqlDbType.Bit)).Value = admision.acompanante;
                    comando.Parameters.Add(new SqlParameter("@responsableTrue", System.Data.SqlDbType.Bit)).Value = admision.responsable;
                    comando.Parameters.Add(new SqlParameter("@nombreAcompanante", System.Data.SqlDbType.NVarChar)).Value = admision.nombreAcompañante;
                    comando.Parameters.Add(new SqlParameter("@nombreResponsable", System.Data.SqlDbType.NVarChar)).Value = admision.nombreResponsable;
                    admision.idAdmision = (int) comando.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void eliminar(Admision admision)
        {
            try
            {
                using (SqlCommand comando = new SqlCommand())
                {
                    comando.Connection = SesionActualDAL.getConexion();
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.CommandText = SentenciasDAL.ADMISION_ANULAR;
                    comando.Parameters.Add(new SqlParameter("@IdAdmision", System.Data.SqlDbType.Int)).Value = admision.idAdmision;
                    comando.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
