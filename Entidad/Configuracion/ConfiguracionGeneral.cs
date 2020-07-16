using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Configuracion
{
    public class ConfiguracionGeneral
    {
        public int idParametro { get; set; }
        public int idDocumento { get; set; }
        public string descripcionDocumento { get; set; }
        public DataTable dtDocumentos { get; set; }
        //public BindingSource enlace;
        public ConfiguracionGeneral()
        {
            dtDocumentos = new DataTable();
            dtDocumentos.Columns.Add("Código", Type.GetType("System.Int32"));
            dtDocumentos.Columns.Add("Descripción", Type.GetType("System.String"));

            //enlace = new BindingSource();
            
        }
        public void llenarDocumentos()
        {
            /*try
            {
                List<string> listaParametros = new List<string>();
                listaParametros.Add(idParametro.ToString());
                dtDocumentos = GeneralDAL.cargarResultadosSQL(Sentencias.PARAMETROS_CARGAR_DOCUMENTOS, listaParametros);
                enlace.DataSource = dtDocumentos;
            }
            catch (Exception ex)
            {
                throw ex;
            }*/

        }
    }

}
