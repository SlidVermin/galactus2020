using System;
using System.Data.SqlClient;
using Modelo.Facturacion;
using Modelo.General.Instrucciones;
using Modelo.General;

namespace Modelo.Facturacion
{
    public class FacturaPacienteDAL
    {
        public static void guardar(FacturaPaciente factura)
        {
            try
            {
                using (SqlCommand comando = new SqlCommand())
                {
                    comando.Connection = SesionActualDAL.getConexion();
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.CommandText = SentenciasDAL.FACTURA_PACIENTE_CREAR;
                    comando.Parameters.Add(new SqlParameter("@IdAdmision", System.Data.SqlDbType.Int)).Value = factura.idAdmision;
                    comando.Parameters.Add(new SqlParameter("@IdContrato", System.Data.SqlDbType.Int)).Value = factura.idContrato;
                    comando.Parameters.Add(new SqlParameter("@idUsuario", System.Data.SqlDbType.Int)).Value = SesionActualDAL.IdUsuario;
                    comando.Parameters.Add(new SqlParameter("@fechaCreacion", System.Data.SqlDbType.Date)).Value = factura.fechaCreacion;
                    comando.Parameters.Add(new SqlParameter("@fechaVencimiento", System.Data.SqlDbType.Date)).Value = factura.fechaVencimiento;
                    //comando.Parameters.Add(new SqlParameter("@pTblOxigeno", System.Data.SqlDbType.Structured)).Value = factura.dtCambiosOxigeno;
                    //comando.Parameters.Add(new SqlParameter("@pTblMedicamento", System.Data.SqlDbType.Structured)).Value = factura.dtCambiosEquivalencia;
                    //comando.Parameters.Add(new SqlParameter("@pTblCUPS", System.Data.SqlDbType.Structured)).Value = factura.dtCambiosCUPS;
                    factura.codigoFactura = Convert.ToString(comando.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void eliminar(FacturaPaciente factura)
        {
            try
            {
                using (SqlCommand comando = new SqlCommand())
                {
                    comando.Connection = SesionActualDAL.getConexion();
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.CommandText = SentenciasDAL.FACTURA_PACIENTE_ANULAR;
                    comando.Parameters.Add(new SqlParameter("@CodigoFactura", System.Data.SqlDbType.Int)).Value = factura.codigoFactura;
                    comando.Parameters.Add(new SqlParameter("@idUsuario", System.Data.SqlDbType.Int)).Value = SesionActualDAL.IdUsuario;
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
