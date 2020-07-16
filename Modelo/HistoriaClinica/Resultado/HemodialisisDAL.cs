using System;
using System.Data.SqlClient;
using System.Data;
using Modelo.HistoriaClinica.Resultado;
using Modelo.General.Instrucciones;
using Modelo.General;
using Entidad.HistoriaClinica.Resultado;

namespace Modelo.HistoriaClinica.Resultado
{
    public class HemodialisisDAL
    {
        public static Hemodialisis guardarHemodialisis(Hemodialisis hemodialisis)
        {
            try
            {
                using (SqlCommand sentencia = new SqlCommand())
                {
                    sentencia.Connection = SesionActualDAL.getConexion();
                    sentencia.CommandType = System.Data.CommandType.StoredProcedure;

                    sentencia.CommandText = SentenciasDAL.CREAR_HEMODIALISIS;
                    sentencia.Parameters.Add(new SqlParameter("@pIdHemodialisis", SqlDbType.Int)).Value = hemodialisis.idHemodialisis;
                    sentencia.Parameters.Add(new SqlParameter("@pIdOrdenMedica", SqlDbType.Int)).Value = hemodialisis.idOrdenMedica;
                    sentencia.Parameters.Add(new SqlParameter("@pIdProcedimiento", SqlDbType.Int)).Value = hemodialisis.idProcedimiento;
                    sentencia.Parameters.Add(new SqlParameter("@pNota", SqlDbType.NVarChar)).Value = hemodialisis.nota;
                    sentencia.Parameters.Add(new SqlParameter("@pNotaSigno", SqlDbType.NVarChar)).Value = hemodialisis.notaSigno;
                    sentencia.Parameters.Add(new SqlParameter("@pFecha", SqlDbType.DateTime)).Value = hemodialisis.fecha;
                    sentencia.Parameters.Add(new SqlParameter("@pIdUsuario", SqlDbType.Int)).Value = SesionActualDAL.IdUsuario;
                    sentencia.Parameters.Add(new SqlParameter("@pAuditoria", SqlDbType.Int)).Value = hemodialisis.auditoria;
                    sentencia.Parameters.Add(new SqlParameter("@ptbMedicamento", SqlDbType.Structured)).Value = extrarDatatable(hemodialisis.dtMedicamento);
                    hemodialisis.idHemodialisis = (int)sentencia.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return hemodialisis;
        }

        public static Boolean anularHemodialisis(int codigo,int auditoria)
        {
            Boolean resultado = false;
            try
            {
                using (SqlCommand sentencia = new SqlCommand())
                {
                    sentencia.Connection = SesionActualDAL.getConexion();
                    sentencia.CommandType = System.Data.CommandType.StoredProcedure;
                    sentencia.CommandText = SentenciasDAL.ANULAR_HEMODIALISIS;

                    sentencia.Parameters.Add(new SqlParameter("@pIdHemodialisis", SqlDbType.Int)).Value = codigo;
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
        private static DataTable extrarDatatable(DataTable dt) {
            DataTable dtExtraido = new DataTable();
            dtExtraido = dt.Copy();
            dtExtraido.Columns.Remove("Descripcion");
            dtExtraido.Rows.RemoveAt(dtExtraido.Rows.Count-1);
            return dtExtraido;
        }
    }
}
