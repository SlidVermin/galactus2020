using Modelo.General;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;


namespace Modelo.General
{
    public class OperacionesBD
    {
        public static DataTable cargarResultadosSQL(string query, List<string> parametros)
        {
            DataTable dtResultado = new DataTable();
            string listaParametros = obtenerParametros(parametros);
            dtResultado.Clear();
            try
            {
                using (SqlDataAdapter adaptador = new SqlDataAdapter(query + listaParametros, SesionActualDAL.getConexion()))
                {
                    adaptador.Fill(dtResultado);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return dtResultado;

        }
        public static void llenarTablaParameter(string query,
                                      List<SqlParameter> parametros,
                                      DataTable tablaResultado)
        {
            tablaResultado.Clear();
            try
            {
                using (SqlCommand comando = new SqlCommand())
                {
                    comando.Connection = SesionActualDAL.getConexion();
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.CommandText = query;
                    if (parametros != null)
                    {
                        foreach (SqlParameter param in parametros)
                        {
                            SqlParameter sqlParametros = new SqlParameter();
                            sqlParametros = new SqlParameter(param.ParameterName, param.DbType);
                            sqlParametros.Value = param.Value;
                            comando.Parameters.Add(sqlParametros);
                        }
                    }
                    using (SqlDataAdapter adaptar = new SqlDataAdapter(comando))
                    {
                        adaptar.Fill(tablaResultado);
                    }
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
      
        public static object castFromDbItemVacio(Object DbItem)
        {
            if (DbItem is DBNull)
            {
                return DbItem = "";
            }
            else
            {
                return DbItem;
            }
        }
        
        public static DataTable copiarNewDatatable(DataTable dtDatos,
                                                   String nombreCampo,
                                                   int codigoCampo)
        {
            DataTable dt = new DataTable();
            dt = dtDatos.Clone();
            DataRow[] filas;
            try

            {
                filas = dtDatos.Select(nombreCampo + "='" + codigoCampo + "'");
                foreach (DataRow dw in filas)
                {
                    dt.ImportRow(dw);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dt;
        }

        public static DataRow obtenerRegistroCompleto(string query,
                                                      List<string> parametros)
        {
            string listaParametros = obtenerParametros(parametros);
            try
            {
                using (DataTable tablaResultado = new DataTable())
                {
                    using (SqlDataAdapter adaptador = new SqlDataAdapter(query + listaParametros, SesionActualDAL.getConexion()))
                    {
                         adaptador.Fill(tablaResultado);
                    }
                if (tablaResultado.Rows.Count > 0)
                {
                    return tablaResultado.Rows[0];
                }
                else
                {
                    return null;
                }
            }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static DateTime obtenerFechaServidor()
        {

            try
            {
                DateTime fechaServidor = new DateTime();
                DataTable dtAlmacenar = new DataTable();

                using (SqlDataAdapter da = new SqlDataAdapter("select getdate()", SesionActualDAL.getConexion()))
                {
                    da.Fill(dtAlmacenar);
                }
                if (dtAlmacenar.Rows.Count > 0)
                {
                    fechaServidor = dtAlmacenar.Rows[0].Field<DateTime>(0);
                }
                return fechaServidor;
            }
            catch (Exception ex)
            {
                throw ex;
                return DateTime.Now;
            }

        }
        public static DataSet llenarDataset(string query,
                                            List<string> parametros)
        {
            string listaParametros = obtenerParametros(parametros);
            try
            {
                using (DataSet dataset = new DataSet())
                {
                    dataset.Clear();
                    using (SqlDataAdapter adaptador = new SqlDataAdapter(query + listaParametros, SesionActualDAL.getConexion()))
                    {
                        adaptador.Fill(dataset);
                    }
                    if (dataset.Tables.Count > 0)
                    {
                        return dataset;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static string obtenerParametros(List<string> parametros)
        {
            string lisatdoParametros;
            if (parametros == null || parametros.Count == 0)
            {
                return "";
            }
            string comillaSimple = Convert.ToChar(39).ToString();
            string coma = Convert.ToChar(44).ToString();
            lisatdoParametros = comillaSimple + parametros.First() + comillaSimple;
            for (int indice = 1; indice <= parametros.Count - 1; indice++)
            {
                lisatdoParametros += coma + comillaSimple + parametros[indice] + comillaSimple;
            }
            return lisatdoParametros;
        }

        public static void quitarColumnaDatatable(string nombreColumna, DataTable tabla)
        {
            if (tabla.Columns.Contains(nombreColumna))
            {
                tabla.Columns.Remove(nombreColumna);
            }
        }

        public static DataTable llenarTablaConParametros(string query, DataTable listado)
        {
            DataTable tablaResultado = new DataTable();
            try
            {
                using (SqlCommand comando = new SqlCommand())
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.CommandText = query;
                    comando.Connection = SesionActualDAL.getConexion();

                    foreach (DataRow item in listado.Rows)
                    {

                        comando.Parameters.AddWithValue(item.Field<string>("parametro"), item.Field<object>("valor"));
                    }

                    using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
                    {
                        adaptador.Fill(tablaResultado);
                    }
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return tablaResultado;

        }

        public static DataRow devuelveUnaFila(string consulta,
                                              List<string> parametros)
        {
            DataTable dtResultados = new DataTable();
            dtResultados = OperacionesBD.cargarResultadosSQL(consulta, parametros);
            if (dtResultados.Rows.Count > 0)
            {
                return dtResultados.Rows[0];
            }
            return null;
        }
    }
}