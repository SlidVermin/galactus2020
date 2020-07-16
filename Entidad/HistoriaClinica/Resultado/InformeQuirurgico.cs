using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Entidad.HistoriaClinica.Resultado
{
    public class InformeQuirurgico
    {
        public int idInformeQX { get; set; }
        public int idOrdenMedica { get; set; }
        public int idProcedimiento { get; set; }
        public int idVia {get; set;} 
        public int idAyudante { get; set; }
        public int idAnastesiologo { get; set; }
        public int idAnastesia { get; set; }
        public int Auditoria { get; set; }
        public string notaQuirurgica { get; set; }
        public DateTime fechaInicio { get; set; }
        public DateTime fechaFin { get; set; }
        public DataTable dtProcedimiento { get; set; }
        public DataTable dtMedicamento { get; set; }

        public InformeQuirurgico() {
            dtProcedimiento = new DataTable();
            dtMedicamento = new DataTable();
            dtProcedimiento.Columns.Add("idProcedimiento", Type.GetType("System.Int32"));
            dtProcedimiento.Columns.Add("cups", Type.GetType("System.String"));
            dtProcedimiento.Columns.Add("Cantidad", Type.GetType("System.Int32"));
            dtProcedimiento.Columns.Add("descripcion", Type.GetType("System.String"));
            dtProcedimiento.Columns.Add("Observacion", Type.GetType("System.String"));
            dtProcedimiento.Columns["Cantidad"].DefaultValue = 1;

            dtMedicamento.Columns.Add("idMedicamento", Type.GetType("System.Int32"));
            dtMedicamento.Columns.Add("descripcion", Type.GetType("System.String"));
            dtMedicamento.Columns.Add("Cantidad", Type.GetType("System.Int32"));
            dtMedicamento.Columns["Cantidad"].DefaultValue = 1;
        }

    }
}
