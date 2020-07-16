using System;
using System.Data.SqlClient;
using System.Data;
using Modelo.General;
using Modelo.General.Instrucciones;
using Entidad.HistoriaClinica.OrdenMedica;

namespace Modelo.HistoriaClinica
{
    public class OrdenClinicaDAL
    {
        public static void guardarOrdenMedica(OrdenClinica OrdenClinica)
        {
            DataView trasformador = new DataView(OrdenClinica.procedimiento.tblProcedimientos, "cantidad > 0 ", "", DataViewRowState.CurrentRows);
            DataTable tblProcedimientos = new DataTable();
            tblProcedimientos = trasformador.ToTable("tabla", true, new string[] { "idProcedimiento", "Cantidad", "Observacion" });
            try
            {
                using (System.Data.SqlClient.SqlCommand comando = new SqlCommand())
                {
                    comando.Connection = SesionActualDAL.getConexion();
                    using (SqlTransaction trans = comando.Connection.BeginTransaction())
                    {
                        
                        comando.Transaction = trans;
                        comando.CommandType = System.Data.CommandType.StoredProcedure;
                    
                        comando.CommandText = SentenciasDAL.ORDEN_CLINICA_CREAR;
                        comando.Parameters.Add(new SqlParameter("@pAuditoria", System.Data.SqlDbType.Bit)).Value = OrdenClinica.auditoria;
                        comando.Parameters.Add(new SqlParameter("@pIdOrdenMedica", System.Data.SqlDbType.Int)).Value = OrdenClinica.idOrden;
                        comando.Parameters.Add(new SqlParameter("@pIdAtencion", System.Data.SqlDbType.Int)).Value = OrdenClinica.idAtencion;
                        comando.Parameters.Add(new SqlParameter("@pFechaOrden", System.Data.SqlDbType.DateTime)).Value = OrdenClinica.fechaOrden;
                        comando.Parameters.Add(new SqlParameter("@pObservacion", System.Data.SqlDbType.NVarChar)).Value = OrdenClinica.indicacion.indicacion;
                        comando.Parameters.Add(new SqlParameter("@pIdUsuarioOrigen", System.Data.SqlDbType.Int)).Value = SesionActualDAL.IdUsuario;
                        comando.Parameters.Add(new SqlParameter("@pIdUsuarioOrigenFisio", System.Data.SqlDbType.Int)).Value = SesionActualDAL.IdUsuario;
                        //comando.Parameters.Add(new SqlParameter("@pTblOxigeno", System.Data.SqlDbType.Structured)).Value = OrdenClinica.oxigeno.dtCambiosOxigeno;
                        comando.Parameters.Add(new SqlParameter("@pTblMedicamento", System.Data.SqlDbType.Structured)).Value = OrdenClinica.medicamento.dtCambiosMedicamento;
                        comando.Parameters.Add(new SqlParameter("@pTblInfusionImpregnacion", System.Data.SqlDbType.Structured)).Value = OrdenClinica.medicamento.dtCambiosInfusionImpregnacion;
                        comando.Parameters.Add(new SqlParameter("@pTblMezcla", System.Data.SqlDbType.Structured)).Value = OrdenClinica.medicamento.dtCambiosMezcla;
                        comando.Parameters.Add(new SqlParameter("@pTblCUPS", System.Data.SqlDbType.Structured)).Value = tblProcedimientos;
                        OrdenClinica.idOrden = (int)comando.ExecuteScalar();
                        try {
                            trans.Commit();
                        }
                        catch (Exception ex)
                        {
                            trans.Rollback();
                            throw ex;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void anularOrdenMedica(OrdenClinica OrdenClinica)
        {
            try
            {
                using (System.Data.SqlClient.SqlCommand comando = new SqlCommand())
                {
                    comando.Connection = SesionActualDAL.getConexion();
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.CommandText = SentenciasDAL.ORDEN_CLINICA_ANULAR;
                    comando.Parameters.Add(new SqlParameter("@pIdOrdenMedica", System.Data.SqlDbType.Int)).Value = OrdenClinica.idOrden;
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
