using System;
using System.Data.SqlClient;
using Modelo.General.Constantes;
using Modelo.Configuracion;
using Modelo.General;
using Entidad.Configuracion;

namespace Modelo.Configuracion
{
    public class ConfiguracionGeneralDAL
    {
        public static void guardar(ConfiguracionGeneral objConfiguracionGeneral)
        {
            try
            {
                using (SqlCommand sentencia = new SqlCommand())
                {
                    sentencia.Connection = SesionActualDAL.getConexion();
                    sentencia.CommandType = System.Data.CommandType.StoredProcedure;
                    sentencia.CommandText = ConstanteGeneral.ESQUEMA_PARAMETRO + "[uspParametroGeneralUIrear]";
                    sentencia.Parameters.Add(new SqlParameter("@IdDescripcionValor", System.Data.SqlDbType.Int)).Value = objConfiguracionGeneral.idDocumento;
                    sentencia.Parameters.Add(new SqlParameter("@IdDescripcion", System.Data.SqlDbType.Int)).Value = objConfiguracionGeneral.idParametro;
                    sentencia.Parameters.Add(new SqlParameter("@Valor", System.Data.SqlDbType.NVarChar)).Value = objConfiguracionGeneral.descripcionDocumento;
                    sentencia.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public static void anular(ConfiguracionGeneral objConfiguracionGeneral)
        {
            try
            {
                using (SqlCommand sentencia = new SqlCommand())
                {
                    sentencia.Connection = SesionActualDAL.getConexion();
                    sentencia.CommandType = System.Data.CommandType.StoredProcedure;
                    sentencia.CommandText = ConstanteGeneral.ESQUEMA_PARAMETRO + "[uspParametroGeneralAnular]";
                    sentencia.Parameters.Add(new SqlParameter("@idParametro", System.Data.SqlDbType.Int)).Value = objConfiguracionGeneral.idParametro;
                    sentencia.Parameters.Add(new SqlParameter("@idDocumento", System.Data.SqlDbType.Int)).Value = objConfiguracionGeneral.idDocumento;
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
