using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Entidad.HistoriaClinica.Resultado
{
    public class Hemodialisis
    {
      public int idHemodialisis { get; set; }
      public  int idOrdenMedica { get; set; }
      public int idProcedimiento { get; set; }
      public int auditoria { get; set; }
      public DateTime fecha { get; set; }
      public  string nota { get; set; }
      public  string notaSigno { get; set; }
      public DataTable dtMedicamento { get; set; }

        public Hemodialisis() {
            dtMedicamento = new DataTable();

            dtMedicamento.Columns.Add("idMedicamento", Type.GetType("System.Int32"));
            dtMedicamento.Columns.Add("descripcion", Type.GetType("System.String"));
            dtMedicamento.Columns.Add("Cantidad", Type.GetType("System.Int32"));
            dtMedicamento.Columns["Cantidad"].DefaultValue = 1;
        }
    }
}
