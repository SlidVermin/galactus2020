using Modelo.Ingreso;
using Modelo.General;
using Modelo.General.Instrucciones;
using System;
using System.Data.SqlClient;
using Entidad.Ingreso;

namespace Modelo.Ingreso
{
    public class AtencionDAL
    {
        public static void guardar(Atencion atencion)
        {
            try
            {
                using (SqlCommand comando = new SqlCommand())
                {
                    comando.Connection = SesionActualDAL.getConexion();
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.CommandText = SentenciasDAL.ATENCION_CREAR;
                    comando.Parameters.Add(new SqlParameter("@IdAtencion", System.Data.SqlDbType.Int)).Value = atencion.idAtencion;
                    comando.Parameters.Add(new SqlParameter("@idAdmision", System.Data.SqlDbType.Int)).Value = atencion.idAdmision;
                    comando.Parameters.Add(new SqlParameter("@IdArea", System.Data.SqlDbType.Int)).Value = atencion.idArea;
                    comando.Parameters.Add(new SqlParameter("@IdEntorno", System.Data.SqlDbType.Int)).Value = atencion.idEntorno;
                    comando.Parameters.Add(new SqlParameter("@IdCausaExterna", System.Data.SqlDbType.Int)).Value = atencion.idCausaExterna;
                    comando.Parameters.Add(new SqlParameter("@IdInstitucion", System.Data.SqlDbType.Int)).Value = atencion.idInstitucion;
                    comando.Parameters.Add(new SqlParameter("@IdViaIngreso", System.Data.SqlDbType.Int)).Value = atencion.idViaIngreso;
                    comando.Parameters.Add(new SqlParameter("@IdCama", System.Data.SqlDbType.Int)).Value = atencion.idCama;
                    comando.Parameters.Add(new SqlParameter("@IdUsuario", System.Data.SqlDbType.Int)).Value = SesionActualDAL.IdUsuario;
                    comando.Parameters.Add(new SqlParameter("@FechaIngreso", System.Data.SqlDbType.Date)).Value = atencion.fechaIngreso;
                    comando.Parameters.Add(new SqlParameter("@NumeroAutorizacion", System.Data.SqlDbType.Int)).Value = atencion.numeroAutorizacion;
                    comando.Parameters.Add(new SqlParameter("@idEstadoAtencion", System.Data.SqlDbType.Int)).Value = atencion.idEstadoAtencion;
                    comando.Parameters.Add(new SqlParameter("@tblDiagnostico", System.Data.SqlDbType.Structured)).Value = atencion.dtCambio;
                    atencion.idAtencion = (int)comando.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void anular(Atencion atencion)
        {
            try
            {
                using (SqlCommand comando = new SqlCommand())
                {
                    comando.Connection = SesionActualDAL.getConexion();
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.CommandText = SentenciasDAL.ATENCION_ANULAR;
                    comando.Parameters.Add(new SqlParameter("@idAtencion", System.Data.SqlDbType.Int)).Value = atencion.idAtencion;
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
