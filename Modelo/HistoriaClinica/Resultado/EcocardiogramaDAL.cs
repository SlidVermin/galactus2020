using System;
using System.Data;
using System.Data.SqlClient;
using Modelo.HistoriaClinica.Resultado;
using Modelo.General.Instrucciones;
using Modelo.General;
using Entidad.HistoriaClinica.Resultado;

namespace Modelo.HistoriaClinica.Resultado
{
    public class EcocardiogramaDAL
    {
        public static Ecocardiograma guardarEcocardiograma(Ecocardiograma ecocardiograma)
        {
            try
            {
                using (SqlCommand sentencia = new SqlCommand())
                {
                    sentencia.Connection = SesionActualDAL.getConexion();
                    sentencia.CommandType = System.Data.CommandType.StoredProcedure;

                    sentencia.CommandText = SentenciasDAL.CREAR_ECOCARDIOGARMA;
                    sentencia.Parameters.Add(new SqlParameter("@pIdEco", SqlDbType.Int)).Value = ecocardiograma.idEco;
                    sentencia.Parameters.Add(new SqlParameter("@pIdOrdenMedica", SqlDbType.Int)).Value = ecocardiograma.idOrdenMedica;
                    sentencia.Parameters.Add(new SqlParameter("@pIdProcedimiento", SqlDbType.Int)).Value = ecocardiograma.idProcedimiento;
                    sentencia.Parameters.Add(new SqlParameter("@pNota", SqlDbType.NVarChar)).Value = ecocardiograma.lectura;
                    sentencia.Parameters.Add(new SqlParameter("@pFecha", SqlDbType.DateTime)).Value = ecocardiograma.fecha;
                    sentencia.Parameters.Add(new SqlParameter("@pIdUsuario", SqlDbType.Int)).Value = SesionActualDAL.IdUsuario;
                    sentencia.Parameters.Add(new SqlParameter("@pAuditoria", SqlDbType.Int)).Value = ecocardiograma.auditoria;
                    sentencia.Parameters.Add(new SqlParameter("@ptbParametro", SqlDbType.Structured)).Value = extrarDatatable(ecocardiograma.dtParametro);
                    ecocardiograma.idEco = (int)sentencia.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ecocardiograma;
        }

        public static Boolean anularEcocardiograma(int codigo, int auditoria)
        {
            Boolean resultado = false;
            try
            {
                using (SqlCommand sentencia = new SqlCommand())
                {
                    sentencia.Connection = SesionActualDAL.getConexion();
                    sentencia.CommandType = System.Data.CommandType.StoredProcedure;
                    sentencia.CommandText = SentenciasDAL.ANULAR_ECOCARDIOGRAMA;

                    sentencia.Parameters.Add(new SqlParameter("@pIdEco", SqlDbType.Int)).Value = codigo;
                    sentencia.Parameters.Add(new SqlParameter("@pAuditoria", SqlDbType.Int)).Value = auditoria;
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
        private static DataTable extrarDatatable(DataTable dt)
        {
            DataTable dtExtraido = new DataTable();
            dtExtraido = dt.Copy();
            dtExtraido.Columns.Remove("Descripcion");
            dtExtraido.Rows.RemoveAt(dtExtraido.Rows.Count - 1);
            return dtExtraido;
        }
    }
}
