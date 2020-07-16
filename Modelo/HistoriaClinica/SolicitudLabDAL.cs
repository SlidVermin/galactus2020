using System;
using System.Data;
using System.Data.SqlClient;
using Modelo.HistoriaClinica;
using Modelo.General.Instrucciones;
using Modelo.General;
using Entidad.HistoriaClinica;

namespace Modelo.HistoriaClinica
{
    public class SolicitudLabDAL
    {
        public static SolicitudLab guardarSolicitudLab(SolicitudLab solicitudLab)
        {
            try
            {
                using (SqlCommand sentencia = new SqlCommand())
                {
                    sentencia.Connection = SesionActualDAL.getConexion();
                    sentencia.CommandType = System.Data.CommandType.StoredProcedure;
                    sentencia.CommandText = SentenciasDAL.CREAR_SOLICITUD_LAB;
                    sentencia.Parameters.Add(new SqlParameter("@pIdSolicitudLab", SqlDbType.Int)).Value = solicitudLab.idSolicitud;
                    sentencia.Parameters.Add(new SqlParameter("@pIdLaboratorio", SqlDbType.Int)).Value = solicitudLab.idLaboratorio;
                    sentencia.Parameters.Add(new SqlParameter("@pIdUsuario", SqlDbType.Int)).Value = SesionActualDAL.IdUsuario;
                    sentencia.Parameters.Add(new SqlParameter("@pFecha", SqlDbType.Date)).Value = solicitudLab.fecha;
                    sentencia.Parameters.Add(new SqlParameter("@pTablaLab", SqlDbType.Structured)).Value = solicitudLab.dtLaboratorio;
                    solicitudLab.idSolicitud = (int)sentencia.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return solicitudLab;
        }

        public static Boolean anularSolicitudLab(int codigo)
        {
            Boolean resultado = false;
            try
            {
                using (SqlCommand sentencia = new SqlCommand())
                {
                    sentencia.Connection = SesionActualDAL.getConexion();
                    sentencia.CommandType =CommandType.StoredProcedure;
                    sentencia.CommandText = SentenciasDAL.ANULAR_SOLICITUD_LAB;

                    sentencia.Parameters.Add(new SqlParameter("@pIdSolicitudLab", SqlDbType.Int)).Value = codigo;
                    sentencia.ExecuteNonQuery();

                    resultado = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return resultado;
        }
    }
}
