using System;
using System.Data;
using System.Data.SqlClient;
using Modelo.Configuracion;
using Modelo.General.Instrucciones;
using Modelo.General;

namespace Modelo.Configuracion
{
    public class TipoExamenDAL
    {
        public static TipoExamen guardarTipoExamen(TipoExamen tipoExamen)
        {
            try
            {
                using (SqlCommand sentencia = new SqlCommand())
                {
                    sentencia.Connection = SesionActualDAL.getConexion();
                    sentencia.CommandType = CommandType.StoredProcedure;

                    sentencia.CommandText = SentenciasDAL.TIPO_EXAMEN_CREAR;
                    sentencia.Parameters.Add(new SqlParameter("@pIdTipoExamen", SqlDbType.Int)).Value = tipoExamen.idTipoExamen;
                    sentencia.Parameters.Add(new SqlParameter("@pDescripcion", SqlDbType.NVarChar)).Value = tipoExamen.descripcion;
                    sentencia.Parameters.Add(new SqlParameter("@pAgrupable", SqlDbType.Bit)).Value = tipoExamen.ckAgrupable;
                    sentencia.Parameters.Add(new SqlParameter("@pTipo", SqlDbType.Int)).Value = tipoExamen.tipo;
                    tipoExamen.idTipoExamen = (int)sentencia.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return tipoExamen;
        }

        public static Boolean anularTipoExamen(int codigo)
        {
            Boolean resultado = false;

            try
            {
                using (SqlCommand sentencia = new SqlCommand())
                {
                    sentencia.Connection = SesionActualDAL.getConexion();
                    sentencia.CommandType = CommandType.StoredProcedure;
                    sentencia.CommandText = SentenciasDAL.TIPO_EXAMEN_ANULAR;
                    sentencia.Parameters.Add(new SqlParameter("@pidTipoExamen", SqlDbType.Int)).Value = codigo;
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
