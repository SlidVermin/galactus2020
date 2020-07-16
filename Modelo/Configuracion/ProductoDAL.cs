using System;
using System.Data;
using System.Data.SqlClient;
using Modelo.Configuracion;
using Modelo.General;
using Modelo.General.Constantes;

namespace Modelo.Inventario
{
    public class ProductoDAL
    {
        public static void guardar(Producto objProducto)
        {
            try
            {
                using (SqlCommand sentencia = new SqlCommand())
                {
                    sentencia.Connection = SesionActualDAL.getConexion();
                    sentencia.CommandType = CommandType.StoredProcedure;
                    sentencia.CommandText = ConstanteGeneral.ESQUEMA_ALMACEN + "[uspProductoCrear]";
                    sentencia.Parameters.Add(new SqlParameter("@pIdProducto", SqlDbType.Int)).Value = objProducto.idProducto;
                    sentencia.Parameters.Add(new SqlParameter("@pDescripcion", SqlDbType.NVarChar)).Value = objProducto.descripcion;
                    sentencia.Parameters.Add(new SqlParameter("@pIdEquivalencia", SqlDbType.Int)).Value = objProducto.idEquivalencia;
                    sentencia.Parameters.Add(new SqlParameter("@pIdMarca", SqlDbType.Int)).Value = objProducto.idMarca;
                    sentencia.Parameters.Add(new SqlParameter("@pIdPresentacion", SqlDbType.Int)).Value = objProducto.idPresentacion;
                    sentencia.Parameters.Add(new SqlParameter("@pRegistroSanitario", SqlDbType.NVarChar)).Value = objProducto.registroSanitario;
                    sentencia.Parameters.Add(new SqlParameter("@pCodigoCUM", SqlDbType.NVarChar)).Value = objProducto.codigoCUM;
                    sentencia.Parameters.Add(new SqlParameter("@pIva",SqlDbType.Float)).Value = objProducto.iva;
                    sentencia.Parameters.Add(new SqlParameter("@pUsuario", SqlDbType.Int)).Value = SesionActualDAL.IdUsuario;
                    objProducto.idProducto = (int)sentencia.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public static void anular(Producto objProducto)
        {
            try
            {
                using (SqlCommand sentencia = new SqlCommand())
                {
                    sentencia.Connection = SesionActualDAL.getConexion();
                    sentencia.CommandType = System.Data.CommandType.StoredProcedure;
                    sentencia.CommandText = ConstanteGeneral.ESQUEMA_ALMACEN + "[uspProductoAnular]";
                    sentencia.Parameters.Add(new SqlParameter("@pIdProducto", SqlDbType.Int)).Value = objProducto.idProducto; ;
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
