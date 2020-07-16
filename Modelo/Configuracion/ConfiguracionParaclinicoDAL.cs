using System;
using System.Data.SqlClient;
using Modelo.Configuracion;
using Modelo.General.Instrucciones;
using Modelo.General;

namespace Modelo.Configuracion
{
    public class ConfiguracionParaclinicoDAL
    {
        public static void guardarClasificacionParaclinico(ConfiguracionParaclinico clasifParaclinico) {
            try
            {
                using (SqlCommand sentencia = new SqlCommand())
                {
                    sentencia.Connection = SesionActualDAL.getConexion();
                    sentencia.CommandType = System.Data.CommandType.StoredProcedure;

                    sentencia.CommandText = SentenciasDAL.CLASIFICACION_PROCEDIMIENTO_CREAR;
                    sentencia.Parameters.Add(new SqlParameter("@pIdGrupo", System.Data.SqlDbType.Int)).Value = clasifParaclinico.idGrupo;
                    sentencia.Parameters.Add(new SqlParameter("@pTbConfig", System.Data.SqlDbType.Structured)).Value = clasifParaclinico.dtRegistro;
                    sentencia.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void guardarClasificacionExamen(ConfiguracionParaclinico clasifParaclinico)
        {
            try
            {
                using (SqlCommand sentencia = new SqlCommand())
                {
                    sentencia.Connection = SesionActualDAL.getConexion();
                    sentencia.CommandType = System.Data.CommandType.StoredProcedure;

                    sentencia.CommandText = SentenciasDAL.CLASIFICACION_EXAMEN_CREAR;
                    sentencia.Parameters.Add(new SqlParameter("@pIdGrupo", System.Data.SqlDbType.Int)).Value = clasifParaclinico.idTipoLaboratorio;
                    sentencia.Parameters.Add(new SqlParameter("@pTbConfig", System.Data.SqlDbType.Structured)).Value = clasifParaclinico.dtRegistro;
                    sentencia.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void guardarClasificacionEstancia(ConfiguracionParaclinico clasifParaclinico)
        {
            try
            {
                using (SqlCommand sentencia = new SqlCommand())
                {
                    sentencia.Connection = SesionActualDAL.getConexion();
                    sentencia.CommandType = System.Data.CommandType.StoredProcedure;

                    sentencia.CommandText = SentenciasDAL.CLASIFICACION_ESTANCIA_CREAR;
                    sentencia.Parameters.Add(new SqlParameter("@pIdGrupo", System.Data.SqlDbType.Int)).Value = clasifParaclinico.idAreaServicio;
                    sentencia.Parameters.Add(new SqlParameter("@pTbConfig", System.Data.SqlDbType.Structured)).Value = clasifParaclinico.dtRegistro;
                    sentencia.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
