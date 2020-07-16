using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Modelo.General.Instrucciones;
using Modelo.General;
using Entidad.HistoriaClinica;

namespace Modelo.HistoriaClinica
{
    public class IngresoClinicoDAL
   { 
        public static void guardarIngreso(IngresoClinico ingreso)
        {
            try
            {
                using (System.Data.SqlClient.SqlCommand comando = new SqlCommand())
                {
                    comando.Connection = SesionActualDAL.getConexion();
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.CommandText = SentenciasDAL.CREAR_INGRESO_CLINICO;
                    comando.Parameters.Add(new SqlParameter("@IdAtencion", System.Data.SqlDbType.Int)).Value = ingreso.IdAtencion;
                    comando.Parameters.Add(new SqlParameter("@Peso", System.Data.SqlDbType.NVarChar)).Value = ingreso.Peso;
                    comando.Parameters.Add(new SqlParameter("@MotivoIngreso", System.Data.SqlDbType.NVarChar)).Value = ingreso.MotivoIngreso;
                    comando.Parameters.Add(new SqlParameter("@AntecedentesMedicos", System.Data.SqlDbType.NVarChar)).Value = ingreso.AntecedentesMedicos;
                    comando.Parameters.Add(new SqlParameter("@AntecedentesQuirurgicos", System.Data.SqlDbType.NVarChar)).Value = ingreso.AntecedentesQuirurgicos;
                    comando.Parameters.Add(new SqlParameter("@AntecedentesTransfusionales", System.Data.SqlDbType.NVarChar)).Value = ingreso.AntecedentesTransfusionales;
                    comando.Parameters.Add(new SqlParameter("@AntecedentesAlergicos", System.Data.SqlDbType.NVarChar)).Value = ingreso.AntecedentesAlergicos;
                    comando.Parameters.Add(new SqlParameter("@AntecedentesTraumaticos", System.Data.SqlDbType.NVarChar)).Value = ingreso.AntecedentesTraumaticos;
                    comando.Parameters.Add(new SqlParameter("@AntecedentesToxicos", System.Data.SqlDbType.NVarChar)).Value = ingreso.AntecedentesToxicos;
                    comando.Parameters.Add(new SqlParameter("@AntecedentesFamiliares", System.Data.SqlDbType.NVarChar)).Value = ingreso.AntecedentesFamiliares;
                    comando.Parameters.Add(new SqlParameter("@RevisionSistema", System.Data.SqlDbType.NVarChar)).Value = ingreso.RevisionSistema;
                    comando.Parameters.Add(new SqlParameter("@Generales", System.Data.SqlDbType.NVarChar)).Value = ingreso.Generales;
                    comando.Parameters.Add(new SqlParameter("@SignosVitales", System.Data.SqlDbType.NVarChar)).Value = ingreso.SignosVitales;
                    comando.Parameters.Add(new SqlParameter("@CabezaCuello", System.Data.SqlDbType.NVarChar)).Value = ingreso.CabezaCuello;
                    comando.Parameters.Add(new SqlParameter("@Torax", System.Data.SqlDbType.NVarChar)).Value = ingreso.Torax;
                    comando.Parameters.Add(new SqlParameter("@CardioPulmonar", System.Data.SqlDbType.NVarChar)).Value = ingreso.CardioPulmonar;
                    comando.Parameters.Add(new SqlParameter("@Abdomen", System.Data.SqlDbType.NVarChar)).Value = ingreso.Abdomen;
                    comando.Parameters.Add(new SqlParameter("@GenitalUrinario", System.Data.SqlDbType.NVarChar)).Value = ingreso.GenitalUrinario;
                    comando.Parameters.Add(new SqlParameter("@Extremidades", System.Data.SqlDbType.NVarChar)).Value = ingreso.Extremidades;
                    comando.Parameters.Add(new SqlParameter("@SistemaNervioso", System.Data.SqlDbType.NVarChar)).Value = ingreso.SistemaNervioso;
                    comando.Parameters.Add(new SqlParameter("@Paraclinicos", System.Data.SqlDbType.NVarChar)).Value = ingreso.Paraclinicos;
                    comando.Parameters.Add(new SqlParameter("@Analisis", System.Data.SqlDbType.NVarChar)).Value = ingreso.Analisis;
                    comando.Parameters.Add(new SqlParameter("@Pronosticos", System.Data.SqlDbType.NVarChar)).Value = ingreso.Pronostico;
                    comando.Parameters.Add(new SqlParameter("@IdUsuario", System.Data.SqlDbType.NVarChar)).Value = SesionActualDAL.IdUsuario;
                    comando.Parameters.Add(new SqlParameter("@ResumenClinico", System.Data.SqlDbType.NVarChar)).Value = ingreso.resumenClinico;
                    comando.Parameters.Add(new SqlParameter("@PielFaneras", System.Data.SqlDbType.NVarChar)).Value = ingreso.pielFaneras;
                    comando.Parameters.Add(new SqlParameter("@FechaOrigen", System.Data.SqlDbType.DateTime)).Value = DateTime.Today;
                    comando.Parameters.Add(new SqlParameter("@tblImpresion", System.Data.SqlDbType.Structured)).Value = ingreso.dtAlistar;
                    comando.Parameters.Add(new SqlParameter("@tblMaterno", System.Data.SqlDbType.Structured)).Value = ingreso.dtMaterno;
                    comando.Parameters.Add(new SqlParameter("@tblNacimiento", System.Data.SqlDbType.Structured)).Value = ingreso.dtNacimiento;
                    comando.Parameters.Add(new SqlParameter("@tblRecienNacido", System.Data.SqlDbType.Structured)).Value = ingreso.dtRecienNacido;

                    comando.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void cargarDiagnostico(IngresoClinico ingreso)
        {
            List<string> list = new List<string>();
            list.Add(Convert.ToString(ingreso.IdAtencion));
            ingreso.dtDiagnostico = OperacionesBD.cargarResultadosSQL(SentenciasDAL.CARGAR_DIAGNOSTICO_INGRESO, list);
        }

        public static void cargarDatos(IngresoClinico ingreso)
        {
            List<string> list = new List<string>();
            list.Add(Convert.ToString(ingreso.IdAtencion));
          ingreso.dsDatos =  OperacionesBD.llenarDataset(SentenciasDAL.CARGAR_INGRESO, list);
        }

        public static void cargarDiagnosticoImpresion(IngresoClinico ingreso)
        {
            List<string> list = new List<string>();
            list.Add(Convert.ToString(ingreso.IdAtencion));
            ingreso.dtImpresion = OperacionesBD.cargarResultadosSQL(SentenciasDAL.CARGAR_DIAGNOSTICO_IMPRESION, list);
        }
    }
}
