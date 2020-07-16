using System;
using System.Data.SqlClient;
using System.Data;
using Modelo.General;
using Modelo.General.Instrucciones;
using Entidad.HistoriaClinica.Resultado;

namespace Modelo.HistoriaClinica.Resultado
{
    public class InformeQuirurgicoDAL
    {
        public static InformeQuirurgico guardarInformeQuirurgico(InformeQuirurgico informeQx)
        {
            try
            {
                using (SqlCommand sentencia = new SqlCommand())
                {
                    sentencia.Connection = SesionActualDAL.getConexion();
                    sentencia.CommandType = CommandType.StoredProcedure;

                    sentencia.CommandText = SentenciasDAL.INFORME_QX_CREAR;
                    sentencia.Parameters.Add(new SqlParameter("@pIdInformeQX", SqlDbType.Int)).Value = informeQx.idInformeQX;
                    sentencia.Parameters.Add(new SqlParameter("@piOrdenMedica", SqlDbType.Int)).Value = informeQx.idOrdenMedica;
                    sentencia.Parameters.Add(new SqlParameter("@pidProcedimiento", SqlDbType.Int)).Value = informeQx.idProcedimiento;
                    sentencia.Parameters.Add(new SqlParameter("@pNota", SqlDbType.NVarChar)).Value = informeQx.notaQuirurgica;
                    sentencia.Parameters.Add(new SqlParameter("@pIdVia", SqlDbType.Int)).Value = informeQx.idVia;
                    sentencia.Parameters.Add(new SqlParameter("@pIdAyudante", SqlDbType.Int)).Value = informeQx.idAyudante;
                    sentencia.Parameters.Add(new SqlParameter("@pIdAnastesia", SqlDbType.Int)).Value = informeQx.idAnastesia;
                    sentencia.Parameters.Add(new SqlParameter("@pIdAnastesiologo", SqlDbType.Int)).Value = informeQx.idAnastesiologo;
                    sentencia.Parameters.Add(new SqlParameter("@pfechaInicio", SqlDbType.DateTime)).Value = informeQx.fechaInicio;
                    sentencia.Parameters.Add(new SqlParameter("@pfechaFin", SqlDbType.DateTime)).Value = informeQx.fechaFin;
                    sentencia.Parameters.Add(new SqlParameter("@pIdUsuario", SqlDbType.Int)).Value = SesionActualDAL.IdUsuario;
                    sentencia.Parameters.Add(new SqlParameter("@pAuditoria", SqlDbType.Int)).Value = informeQx.Auditoria;
                    sentencia.Parameters.Add(new SqlParameter("@pTbMedicamento", SqlDbType.Structured)).Value = extrarDatatable(informeQx.dtMedicamento);
                    sentencia.Parameters.Add(new SqlParameter("@pTbProcedimiento", SqlDbType.Structured)).Value = extrarDatatableProcedimiento(informeQx.dtProcedimiento);
                    informeQx.idInformeQX = (int)sentencia.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return informeQx;
        }

        public static Boolean anularInformeQuirurgico(int codigo, int Auditoria)
        {
            Boolean resultado = false;

            try
            {
                using (SqlCommand sentencia = new SqlCommand())
                {
                    sentencia.Connection = SesionActualDAL.getConexion();
                    sentencia.CommandType = CommandType.StoredProcedure;
                    sentencia.CommandText = SentenciasDAL.INFORME_QX_ANULAR;
                    sentencia.Parameters.Add(new SqlParameter("@idInformeQX", SqlDbType.Int)).Value = codigo;
                    sentencia.Parameters.Add(new SqlParameter("@pAuditoria", SqlDbType.Int)).Value = Auditoria;
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
        private static DataTable extrarDatatableProcedimiento(DataTable dt)
        {
            DataTable dtExtraido = new DataTable();
            dtExtraido = dt.Copy();
            dtExtraido.Columns.Remove("Descripcion");
            dtExtraido.Columns.Remove("cups");
            dtExtraido.Rows.RemoveAt(dtExtraido.Rows.Count - 1);
            return dtExtraido;
        }
    }
}
