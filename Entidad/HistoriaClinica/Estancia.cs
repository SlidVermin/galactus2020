using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad.HistoriaClinica
{
    public class Estancia
    {
        public DataTable dtEstancia { get; set; }

        public DataTable dtCambiosEstancia = new DataTable(); 
        public bool auditoria { get; set; }
        public int idAtencion { get; set; }        

    }
}
