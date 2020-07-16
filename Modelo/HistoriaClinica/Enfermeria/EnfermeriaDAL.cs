using System;
using System.Data;
using System.Data.SqlClient;
using Modelo.HistoriaClinica.Enfermeria;
using Modelo.General.Instrucciones;
using Modelo.General;
using Entidad.HistoriaClinica.Enfermeria;

namespace Modelo.HistoriaClinica.Enfermeria
{
    public class EnfermeriaDAL
    {
        public static void  guardarInsumos(EnfermeriaClinica enfermeria)
        {
            try
            {
                using (SqlCommand comando = new SqlCommand())
                {
                    comando.Connection = SesionActualDAL.getConexion();
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.CommandText = SentenciasDAL.CREAR_INSUMOS_ENFERMERIA;
                    comando.Parameters.Add(new SqlParameter("@Auditoria", SqlDbType.Int)).Value = enfermeria.Auditoria;
                    comando.Parameters.Add(new SqlParameter("@idOrden", SqlDbType.Int)).Value = enfermeria.idInsumo;
                    comando.Parameters.Add(new SqlParameter("@idAtencion", SqlDbType.Int)).Value = enfermeria.idAtencion;
                    comando.Parameters.Add(new SqlParameter("@Tipo", SqlDbType.NVarChar)).Value = enfermeria.tipo;
                    comando.Parameters.Add(new SqlParameter("@fecha", SqlDbType.DateTime)).Value = enfermeria.fecha;
                    comando.Parameters.Add(new SqlParameter("@idUsuario", SqlDbType.Int)).Value = SesionActualDAL.IdUsuario;
                    comando.Parameters.Add(new SqlParameter("@tblInsumos", SqlDbType.Structured)).Value = enfermeria.dtInsumosCopia;
                    enfermeria.idInsumo = (int)  comando.ExecuteScalar();
                }
            }catch(Exception ex)
            {
                throw ex;
            }
        }
      
        public static void guardarGlucometria(EnfermeriaClinica enfermeria)
        {
            try
            {
                using (SqlCommand comando = new SqlCommand())
                {
                    comando.Connection = SesionActualDAL.getConexion();
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.CommandText = SentenciasDAL.CREAR_GLUCOMETRIA_ENFERMERIA;
                    comando.Parameters.Add(new SqlParameter("@Auditoria", SqlDbType.Int)).Value = enfermeria.Auditoria;
                    comando.Parameters.Add(new SqlParameter("@idOrdenMedica", SqlDbType.Int)).Value = enfermeria.idOrdenMedica;
                    comando.Parameters.Add(new SqlParameter("@tblGlucometria", SqlDbType.Structured)).Value = enfermeria.dtGlucometriaCopia;
                    comando.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void guardarNota(EnfermeriaClinica enfermeria)
        {
            try
            {
                using (SqlCommand comando = new SqlCommand())
                {
                    comando.Connection = SesionActualDAL.getConexion();
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.CommandText = SentenciasDAL.CREAR_NOTA_ENFERMERIA;
                    comando.Parameters.Add(new SqlParameter("@Auditoria", SqlDbType.Bit)).Value = enfermeria.Auditoria;
                    comando.Parameters.Add(new SqlParameter("@idNota", SqlDbType.Int)).Value = enfermeria.idNota;
                    comando.Parameters.Add(new SqlParameter("@idAtencion", SqlDbType.Int)).Value = enfermeria.idAtencion;
                    comando.Parameters.Add(new SqlParameter("@TipoNota", SqlDbType.NVarChar)).Value = enfermeria.tipo;
                    comando.Parameters.Add(new SqlParameter("@fecha", SqlDbType.DateTime)).Value = enfermeria.fechaNota;
                    comando.Parameters.Add(new SqlParameter("@Nota", SqlDbType.NVarChar)).Value = enfermeria.nota;
                    comando.Parameters.Add(new SqlParameter("@idUsuarioOrigen", SqlDbType.Int)).Value = SesionActualDAL.IdUsuario;
                    enfermeria.idNota = (int) comando.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
       
    }
}
