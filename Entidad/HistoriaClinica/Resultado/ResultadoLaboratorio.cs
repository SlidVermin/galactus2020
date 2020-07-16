using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Entidad.HistoriaClinica.Resultado
{
    public class ResultadoLaboratorio
    {
          public int idSolicitud { get; set; }
          public int idOrdenMedica { get; set; }
          public int codigoResultado { get; set; }
          public  int codigoAtencion {get; set; }
          public int codigoGenero { get; set; }
          public int auditoria { get; set; }
          public bool estadoRegistro { get; set; }
          public string observacion { get; set; }
          public DateTime fechaResultado { get; set; }
          public DateTime fechaMuestra { get; set; }
          public DataTable dtResultado { get; set; }

        public ResultadoLaboratorio() {
            dtResultado = new DataTable();
            dtResultado.Columns.Add("Codigo", Type.GetType("System.Int32"));
            dtResultado.Columns.Add("Parametro", Type.GetType("System.Int32"));
            dtResultado.Columns.Add("Descripcion", Type.GetType("System.String"));
            dtResultado.Columns.Add("Resultado", Type.GetType("System.String"));
            dtResultado.Columns.Add("Referencia", Type.GetType("System.String"));
        }
    }
}
