using System;
using System.Data;
using System.Data.SqlClient;
using Modelo.General.Constantes;
using Modelo.Configuracion;
using Modelo.General;
using Entidad.Configuracion;

namespace Modelo.Configuracion
{
    public class ListaPrecioEquivalenciaDAL
    {
        public static void guardar(ListaPrecioEquivalencia objLista)
        {
            try
            {
                DataTable tblData = new DataTable();
                tblData = objLista.tablaEquivalencia.DefaultView.ToTable(true,new string[] { "Id", "Precio", "mostrar" }).Copy();

                if (tblData.Columns.Count>0)
                {
                    tblData.Columns.Add("Activo",Type.GetType("System.Boolean"), "IIF(Precio>0,True,False)");
                }
                tblData.AcceptChanges();
                using (SqlCommand sentencia = new SqlCommand())
                {
                    sentencia.Connection = SesionActualDAL.getConexion();
                    sentencia.CommandType = System.Data.CommandType.StoredProcedure;
                    sentencia.CommandText = ConstanteGeneral.ESQUEMA_GENERAL + "[uspListaPrecioCrear]";
                    sentencia.Parameters.Add(new SqlParameter("@pId", SqlDbType.Int)).Value = objLista.idLista;
                    sentencia.Parameters.Add(new SqlParameter("@pNombre", SqlDbType.NVarChar)).Value = objLista.nombre;
                    sentencia.Parameters.Add(new SqlParameter("@pIdUsuario", SqlDbType.Int)).Value = SesionActualDAL.IdUsuario;
                    sentencia.Parameters.Add(new SqlParameter("@pTablaEquivalencia", SqlDbType.Structured)).Value = tblData;
                    objLista.idLista = (int)sentencia.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public static void anular(ListaPrecioEquivalencia objLista)
        {
            try
            {
                using (SqlCommand sentencia = new SqlCommand())
                {
                    sentencia.Connection = SesionActualDAL.getConexion();
                    sentencia.CommandType = System.Data.CommandType.StoredProcedure;
                    sentencia.CommandText = ConstanteGeneral.ESQUEMA_GENERAL + "[uspListaPrecioAnular]";
                    sentencia.Parameters.Add(new SqlParameter("@pId", SqlDbType.Int)).Value = objLista.idLista;
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
