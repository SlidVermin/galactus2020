using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Modelo.General.Instrucciones;
using Modelo.General;
using Entidad.HistoriaClinica.Evolucion;

namespace Modelo.HistoriaClinica
{
    public class EvolucionMedicaDAL
    {
        public static void guardarEvolucion(EvolucionMedica evolucionMedica)
        {
            try
            {
                using (SqlCommand comando = new SqlCommand())
                {
                    comando.Connection = SesionActualDAL.getConexion();
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.CommandText = SentenciasDAL.CREAR_EVOLUCION_MEDICA;
                    comando.Parameters.Add(new SqlParameter("@IdAtencion", System.Data.SqlDbType.Int)).Value = evolucionMedica.IdAtencion;
                    comando.Parameters.Add(new SqlParameter("@IdEvolucion", System.Data.SqlDbType.Int)).Value = evolucionMedica.idEvolucion;
                    comando.Parameters.Add(new SqlParameter("@Fecha", System.Data.SqlDbType.DateTime)).Value = evolucionMedica.fechaEvolucion;
                    comando.Parameters.Add(new SqlParameter("@Subjetivos", System.Data.SqlDbType.NVarChar)).Value = evolucionMedica.Subjetivos;
                    comando.Parameters.Add(new SqlParameter("@Generales", System.Data.SqlDbType.NVarChar)).Value = evolucionMedica.Generales;
                    comando.Parameters.Add(new SqlParameter("@SignosVitales", System.Data.SqlDbType.NVarChar)).Value = evolucionMedica.SignosVitales;
                    comando.Parameters.Add(new SqlParameter("@GenitoUrinario", System.Data.SqlDbType.NVarChar)).Value = evolucionMedica.GenitalUrinario;
                    comando.Parameters.Add(new SqlParameter("@Torax", System.Data.SqlDbType.NVarChar)).Value = evolucionMedica.Torax;
                    comando.Parameters.Add(new SqlParameter("@SistemaNervioso", System.Data.SqlDbType.NVarChar)).Value = evolucionMedica.SistemaNervioso;
                    comando.Parameters.Add(new SqlParameter("@Abdomen", System.Data.SqlDbType.NVarChar)).Value = evolucionMedica.Abdomen;
                    comando.Parameters.Add(new SqlParameter("@PielFanera", System.Data.SqlDbType.NVarChar)).Value = evolucionMedica.PielFanera;
                    comando.Parameters.Add(new SqlParameter("@Extremidades", System.Data.SqlDbType.NVarChar)).Value = evolucionMedica.Extremidades;
                    comando.Parameters.Add(new SqlParameter("@CabezaCuello", System.Data.SqlDbType.NVarChar)).Value = evolucionMedica.CabezaCuello;
                    comando.Parameters.Add(new SqlParameter("@CardioPulmonar", System.Data.SqlDbType.NVarChar)).Value = evolucionMedica.CardioPulmonar;
                    comando.Parameters.Add(new SqlParameter("@Analisis", System.Data.SqlDbType.NVarChar)).Value = evolucionMedica.Analisis;
                    comando.Parameters.Add(new SqlParameter("@Plan", System.Data.SqlDbType.NVarChar)).Value = evolucionMedica.Plan;
                    comando.Parameters.Add(new SqlParameter("@idUsuario", System.Data.SqlDbType.Int)).Value = SesionActualDAL.IdUsuario;
                    comando.Parameters.Add(new SqlParameter("@tblDiagnostico", System.Data.SqlDbType.Structured)).Value = evolucionMedica.dtAlistar;

                    evolucionMedica.idEvolucion = (int)  comando.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void borrarEvolucion(EvolucionMedica evolucionMedica)
        {
            try
            {
                using (SqlCommand comando = new SqlCommand())
                {
                    comando.Connection = SesionActualDAL.getConexion();
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.CommandText = SentenciasDAL.ANULAR_EVOLUCION_MEDICA;
                    comando.Parameters.Add(new SqlParameter("@idEvolucion", System.Data.SqlDbType.Int)).Value = evolucionMedica.idEvolucion;
                    comando.ExecuteNonQuery();
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public static void cargarDatos(EvolucionMedica evolucionMedica)
        {
            try
            {
                List<String> list = new List<String>();
                list.Add(Convert.ToString(evolucionMedica.idEvolucion));
                evolucionMedica.dsDatos = OperacionesBD.llenarDataset(SentenciasDAL.CARGAR_EVOLUCION_MEDICA, list);
            }catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
