using System;
using System.Data.SqlClient;
using Modelo.General;
using Modelo.General.Constantes;
using Modelo.Inventario;

namespace Modelo.Inventario
{
    public class BodegaDAL
    {
        public static void guardar(Bodega objBodega)
        {
            try
            {
                using (SqlCommand sentencia = new SqlCommand())
                {
                    sentencia.Connection = SesionActualDAL.getConexion();
                    sentencia.CommandType = System.Data.CommandType.StoredProcedure;
                    sentencia.CommandText = ConstanteGeneral.ESQUEMA_ALMACEN + "[uspBodegaCrear]";
                    sentencia.Parameters.Add(new SqlParameter("@pIdBodega", System.Data.SqlDbType.Int)).Value = objBodega.idBodega;
                    sentencia.Parameters.Add(new SqlParameter("@pIdDescripcion", System.Data.SqlDbType.NVarChar)).Value = objBodega.descripcion;
                    sentencia.Parameters.Add(new SqlParameter("@pUsuario", System.Data.SqlDbType.Int)).Value = SesionActualDAL.IdUsuario;
                    objBodega.idBodega = (int)sentencia.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public static void anular(Bodega objBodega)
        {
            try
            {
                using (SqlCommand sentencia = new SqlCommand())
                {
                    sentencia.Connection = SesionActualDAL.getConexion();
                    sentencia.CommandType = System.Data.CommandType.StoredProcedure;
                    sentencia.CommandText = ConstanteGeneral.ESQUEMA_ALMACEN + "[uspBodegaAnular]";
                    sentencia.Parameters.Add(new SqlParameter("@pIdBodega", System.Data.SqlDbType.Int)).Value = objBodega.idBodega; ;
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
