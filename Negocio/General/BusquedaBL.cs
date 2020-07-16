using Modelo.General;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.General
{
   
public class BusquedaBL
{
    public static DataTable llenarResultado(string query,
                                            List<string> parametros)
    {
        DataTable tblTemp;
        tblTemp = OperacionesBD.cargarResultadosSQL(query, parametros);
        return tblTemp;
    }
    public static DataTable llenarResultadoConParametros(string query,
                                                            DataTable listado)
    {
        DataTable tblTemp;
        tblTemp = OperacionesBD.llenarTablaConParametros(query, listado);
        return tblTemp;
    }
}    
}
