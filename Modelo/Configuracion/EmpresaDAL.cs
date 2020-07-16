using System;
using System.Data;
using System.Data.SqlClient;
using Modelo.General.Constantes;
using Modelo.Configuracion;
using Modelo.General;

namespace Modelo.Configuracion
{
    public class EmpresaDAL
    {
        public static void guardar(Empresa empresa)
        {

            try
            {
                using (SqlCommand sentencia = new SqlCommand())
                {
                    sentencia.Connection = SesionActualDAL.getConexion();
                    sentencia.CommandType = System.Data.CommandType.StoredProcedure;
                    sentencia.CommandText = ConstanteGeneral.ESQUEMA_GENERAL + "[uspEmpresaCrear]";
                    sentencia.Parameters.Add(new SqlParameter("@idEmpresa", SqlDbType.Int)).Value = empresa.idEmpresa;
                    sentencia.Parameters.Add(new SqlParameter("@Nit", SqlDbType.NVarChar)).Value = empresa.nit;
                    sentencia.Parameters.Add(new SqlParameter("@RazonSocial", SqlDbType.NVarChar)).Value = empresa.razonSocial;
                    sentencia.Parameters.Add(new SqlParameter("@CodigoHabilitacion", SqlDbType.NVarChar)).Value = empresa.codigoHabilitacion;
                    sentencia.Parameters.Add(new SqlParameter("@IdMunicipio", SqlDbType.Int)).Value = empresa.ubicacion;
                    sentencia.Parameters.Add(new SqlParameter("@Direccion", SqlDbType.NVarChar)).Value = empresa.direccion;
                    sentencia.Parameters.Add(new SqlParameter("@Telefono", SqlDbType.NVarChar)).Value = empresa.telefono;
                    sentencia.Parameters.Add(new SqlParameter("@Celular", SqlDbType.NVarChar)).Value = empresa.celular;
                    sentencia.Parameters.Add(new SqlParameter("@Email", SqlDbType.NVarChar)).Value = empresa.email;
                    sentencia.Parameters.Add(new SqlParameter("@Sigla", SqlDbType.NVarChar)).Value = empresa.sigla;
                    sentencia.Parameters.Add(new SqlParameter("@EncabezadoFactura", SqlDbType.NVarChar)).Value = empresa.encabezado;
                    sentencia.Parameters.Add(new SqlParameter("@PieFactura", SqlDbType.NVarChar)).Value = empresa.pie;
                    sentencia.Parameters.Add(new SqlParameter("@Logo", SqlDbType.Image)).Value = empresa.logo;
                    sentencia.Parameters.Add(new SqlParameter("@IdTercero", SqlDbType.Int)).Value = empresa.idResponsable;
                    sentencia.Parameters.Add(new SqlParameter("@IdUsuario", SqlDbType.Int)).Value = SesionActualDAL.IdUsuario;
                    empresa.idEmpresa = (int)sentencia.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void anular(Empresa empresa)
        {
            try
            {
                using (SqlCommand sentencia = new SqlCommand())
                {
                    sentencia.Connection = SesionActualDAL.getConexion();
                    sentencia.CommandType = System.Data.CommandType.StoredProcedure;
                    sentencia.CommandText = ConstanteGeneral.ESQUEMA_GENERAL + "[uspEmpresaAnular]";
                    sentencia.Parameters.Add(new SqlParameter("@pIdEmpresa", SqlDbType.Int)).Value = empresa.idEmpresa; ;
                    sentencia.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
