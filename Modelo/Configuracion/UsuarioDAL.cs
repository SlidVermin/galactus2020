using Modelo.Configuracion;
using Modelo.General;
using Modelo.General.Constantes;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Modelo.Configuracion
{
    public class UsuarioDAL
    {
        public static void guardar(Usuario usuario)
        {
            try
            {
                using (SqlCommand sentencia = new SqlCommand())
                {
                    sentencia.Connection = SesionActualDAL.getConexion();
                    sentencia.CommandType = System.Data.CommandType.StoredProcedure;
                    sentencia.CommandText = ConstanteGeneral.ESQUEMA_SEGURIDAD + "[uspUsuarioCrear]";
                    sentencia.Parameters.Add(new SqlParameter("@pIdUsuario", SqlDbType.Int)).Value = usuario.idUsuario;
                    sentencia.Parameters.Add(new SqlParameter("@pNombre", SqlDbType.NVarChar)).Value = usuario.nombre;
                    sentencia.Parameters.Add(new SqlParameter("@pNombreLogin", SqlDbType.NVarChar)).Value = usuario.usuario;
                    sentencia.Parameters.Add(new SqlParameter("@pClave", SqlDbType.NVarChar)).Value = usuario.pass;
                    sentencia.Parameters.Add(new SqlParameter("@pIdRol", SqlDbType.Int)).Value = usuario.idRol;
                    sentencia.Parameters.Add(new SqlParameter("@pUsuario", SqlDbType.Int)).Value = SesionActualDAL.IdUsuario;
                    usuario.idUsuario = (int)sentencia.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public static void anular(Usuario usuario)
        {
            try
            {
                using (SqlCommand sentencia = new SqlCommand())
                {
                    sentencia.Connection = SesionActualDAL.getConexion();
                    sentencia.CommandType = System.Data.CommandType.StoredProcedure;
                    sentencia.CommandText = ConstanteGeneral.ESQUEMA_SEGURIDAD + "[uspUsuarioAnular]";
                    sentencia.Parameters.Add(new SqlParameter("@pIdUsuario", SqlDbType.Int)).Value = usuario.idUsuario; ;
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
