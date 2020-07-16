using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad.HistoriaClinica.Enfermeria
{
    public class Sabana
    {
        public int idSabana { get; set; }
        public bool auditoria { get; set; }
        public int idAtencion { get; set; }
        public DateTime fecha { get; set; }

        public DataTable dtMedicamento { get; set; }
        public DataTable dtGoteo { get; set; }
        public DataTable dtCambiosGoteo { get; set; }
        public DataTable dtCambiosMedicamento { get; set; }         
               
    }
}
