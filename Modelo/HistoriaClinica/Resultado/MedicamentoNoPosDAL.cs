using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using Modelo.General;
using Modelo.General.Instrucciones;
using Entidad.HistoriaClinica.Resultado;

namespace Modelo.HistoriaClinica.Resultado
{
    public class MedicamentoNoPosDAL
    {
        public static void guardarNoPos(MedicamentosNoPos medicamentoNoPos)
        {
            try
            {
                using (SqlCommand comando = new SqlCommand())
                {
                    comando.Connection = SesionActualDAL.getConexion();
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.CommandText = SentenciasDAL.CREAR_MEDICAMENTO_NOPOS;
                    comando.Parameters.Add(new SqlParameter("@IdAtencion", SqlDbType.Int)).Value = medicamentoNoPos.idAtencion;
                    comando.Parameters.Add(new SqlParameter("@idSolicitudNoPos", SqlDbType.Int)).Value=medicamentoNoPos.idSolicitud;
                    comando.Parameters.Add(new SqlParameter("@idOrdenMedica", SqlDbType.Int)).Value = medicamentoNoPos.idOrdenMedica;
                    comando.Parameters.Add(new SqlParameter("@FechaSolicitud", SqlDbType.DateTime)).Value=medicamentoNoPos.fechaSolicitud;
                    comando.Parameters.Add(new SqlParameter("@MedicamentoActual", SqlDbType.Int)).Value=medicamentoNoPos.idMedicamentoActual;
                    comando.Parameters.Add(new SqlParameter("@MedicamentoReemplazar", SqlDbType.Int)).Value=medicamentoNoPos.idMedicamentoReemplazar;
                    comando.Parameters.Add(new SqlParameter("@DiasTratamiento", SqlDbType.Int)).Value=medicamentoNoPos.diasTratamiento;
                    comando.Parameters.Add(new SqlParameter("@Dosis", SqlDbType.NVarChar)).Value=medicamentoNoPos.dosis;
                    comando.Parameters.Add(new SqlParameter("@Frecuencia", SqlDbType.NVarChar)).Value=medicamentoNoPos.frecuencia;
                    comando.Parameters.Add(new SqlParameter("@DosisSolicitada", SqlDbType.NVarChar)).Value=medicamentoNoPos.dosisSolicitada;
                    comando.Parameters.Add(new SqlParameter("@ResumenHc", SqlDbType.NVarChar)).Value=medicamentoNoPos.resumenHC;
                    comando.Parameters.Add(new SqlParameter("@OtroPosUtilizado", SqlDbType.Bit)).Value=medicamentoNoPos.otroPosUtilizado;
                    comando.Parameters.Add(new SqlParameter("@RespuestaPos", SqlDbType.NVarChar)).Value=medicamentoNoPos.respuestaPos;
                    comando.Parameters.Add(new SqlParameter("@EfectoDeseado", SqlDbType.NVarChar)).Value=medicamentoNoPos.efectoDeseado;
                    comando.Parameters.Add(new SqlParameter("@IndicacionEfecto", SqlDbType.NVarChar)).Value=medicamentoNoPos.indicacionEfecto;
                    comando.Parameters.Add(new SqlParameter("@ExplicacionRazon", SqlDbType.NVarChar)).Value=medicamentoNoPos.explicacionRazon;
                    comando.Parameters.Add(new SqlParameter("@Criterio1", SqlDbType.Bit)).Value=medicamentoNoPos.criterio1;
                    comando.Parameters.Add(new SqlParameter("@Criterio2", SqlDbType.Bit)).Value=medicamentoNoPos.criterio2;
                    comando.Parameters.Add(new SqlParameter("@PrecaucionesOtros", SqlDbType.NVarChar)).Value=medicamentoNoPos.precaucionesOtros;
                    comando.Parameters.Add(new SqlParameter("@Peligro", SqlDbType.NVarChar)).Value=medicamentoNoPos.peligro;
                    comando.Parameters.Add(new SqlParameter("@ReaccionesSegundaria", SqlDbType.NVarChar)).Value=medicamentoNoPos.reaccionesSecundaria;
                    comando.Parameters.Add(new SqlParameter("@ContraIndicaciones", SqlDbType.NVarChar)).Value=medicamentoNoPos.contraIndicaciones;
                    comando.Parameters.Add(new SqlParameter("@FechaCTC", SqlDbType.DateTime)).Value=medicamentoNoPos.fechaCTC;
                    comando.Parameters.Add(new SqlParameter("@EncabezadoCTC", SqlDbType.NVarChar)).Value=medicamentoNoPos.encabezadoCTC;
                    comando.Parameters.Add(new SqlParameter("@DecisionCTC", SqlDbType.NVarChar)).Value=medicamentoNoPos.decisionCTC;
                    comando.Parameters.Add(new SqlParameter("@IdUsuario", SqlDbType.Int)).Value = SesionActualDAL.IdUsuario;
                    comando.Parameters.Add(new SqlParameter("@Auditoria", SqlDbType.Bit)).Value=medicamentoNoPos.auditoria;
                    comando.Parameters.Add(new SqlParameter("@tblDiagnostico", SqlDbType.Structured)).Value=medicamentoNoPos.dtDiagnostico;
                    comando.Parameters.Add(new SqlParameter("@PosibilidadTerapeutica", SqlDbType.Bit)).Value = medicamentoNoPos.posibilidadTerapeutica;
                    comando.Parameters.Add(new SqlParameter("@MotivoIngreso", SqlDbType.NVarChar)).Value = medicamentoNoPos.motivoIngreso;
                    medicamentoNoPos.idSolicitud = (int) comando.ExecuteScalar();
                }
            }catch(Exception ex)
            {
                throw ex;
            }
        }
        public static void cargarDatos(MedicamentosNoPos medicamentoNoPos)
        {
            try
            {
                List<string> lista = new List<string>();
                lista.Add(Convert.ToString(medicamentoNoPos.idAtencion));
                lista.Add(Convert.ToString(medicamentoNoPos.idSolicitud));
                lista.Add(Convert.ToString(medicamentoNoPos.auditoria));
                medicamentoNoPos.dsDatos = OperacionesBD.llenarDataset(SentenciasDAL.CARGAR_MEDICAMENTO_NOPOS, lista);
            }catch(Exception ex)
            {
                throw ex;
            }
        }
        public static void anular(MedicamentosNoPos medicamentoNoPos)
        {
            try
            {
                using (SqlCommand comando = new SqlCommand())
                {
                    comando.Connection = SesionActualDAL.getConexion();
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.CommandText = SentenciasDAL.ANULAR_MEDICAMENTO_NOPOS;
                    comando.Parameters.Add(new SqlParameter("@IdSolicitudNoPos", SqlDbType.Int)).Value = medicamentoNoPos.idSolicitud;
                    comando.Parameters.Add(new SqlParameter("@auditoria", SqlDbType.Bit)).Value = medicamentoNoPos.auditoria;
                    comando.ExecuteNonQuery();
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
