using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad.HistoriaClinica.Resultado
{
    public class ResultadoOrdenMedica
    {
       public DataTable dtResultado;

        public ResultadoOrdenMedica() {
            dtResultado = new DataTable();

            dtResultado.Columns.Add("idOrdenMedica", Type.GetType("System.Int32"));
            dtResultado.Columns.Add("idSolicitud", Type.GetType("System.Int32"));
            dtResultado.Columns.Add("idProcedimiento", Type.GetType("System.Int32"));
            dtResultado.Columns.Add("Estado", Type.GetType("System.Int32"));
            dtResultado.Columns.Add("Descripcion", Type.GetType("System.String"));
            dtResultado.Columns.Add("Lectura", Type.GetType("System.Boolean"));

        }
    }
}
