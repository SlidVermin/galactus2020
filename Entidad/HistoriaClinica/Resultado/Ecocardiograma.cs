using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace Entidad.HistoriaClinica.Resultado { 
    public class Ecocardiograma
    {
        public int idOrdenMedica { get; set; }
        public int idProcedimiento { get; set; }
        public int idEco { get; set; }
        public string lectura { get; set; }
        public DateTime fecha { get; set; }
        public int auditoria { get; set; }
        public int idAreaAtencion { get; set; }
        public DataTable dtParametro { get; set; }

        public Ecocardiograma() {
            dtParametro = new DataTable();
            dtParametro.Columns.Add("IdParametro", Type.GetType("System.Int32"));
            dtParametro.Columns.Add("Descripcion", Type.GetType("System.String"));
            dtParametro.Columns.Add("Resultado", Type.GetType("System.String"));
            dtParametro.Columns.Add("Referencia", Type.GetType("System.String"));
        }     
    }
}
