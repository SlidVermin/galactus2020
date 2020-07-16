using System;
using System.Data;
using System.Data.SqlClient;
using Modelo.HistoriaClinica;
using Modelo.General.Instrucciones;
using Modelo.General;
using Entidad.HistoriaClinica;

namespace Modelo.HistoriaClinica
{
    public class EstanciaDAL
    {
        public static void guardar(Estancia estancia)
        {
            try
            {
                using (SqlCommand comando = new SqlCommand())
                {
                    comando.Connection = SesionActualDAL.getConexion();
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.CommandText = SentenciasDAL.CREAR_ESTANCIA;
                    comando.Parameters.Add(new SqlParameter("@pAuditoria", SqlDbType.Int)).Value = estancia.auditoria;
                    comando.Parameters.Add(new SqlParameter("@pIdAtencion", SqlDbType.Int)).Value = estancia.idAtencion;
                    comando.Parameters.Add(new SqlParameter("@pIdUsuarioOrigen", SqlDbType.Int)).Value = SesionActualDAL.IdUsuario;
                    comando.Parameters.Add(new SqlParameter("@pTblEstancia", SqlDbType.Structured)).Value = estancia.dtCambiosEstancia;
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
