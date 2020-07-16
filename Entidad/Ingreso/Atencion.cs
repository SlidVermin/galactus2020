using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad.Ingreso
{
    public class Atencion
    {
        public int idAtencion { get; set; }
        public int idAdmision { get; set; }
        public string idCama { get; set; }
        public string idViaIngreso { get; set; }
        public string idCausaExterna { get; set; }
        public string idEntorno { get; set; }
        public string idArea { get; set; }
        public string idInstitucion { get; set; }
        public string observacion { get; set; }
        public DateTime fechaIngreso { get; set; }
        public int idEstadoAtencion { get; set; }
        public int numeroAutorizacion { get; set; }
        public DateTime fechaAdmision { get; set; }
        public string nombrePaciente { get; set; }
        public DataTable dtDiagnostico = new DataTable();
        public DataTable dtCambio = new DataTable();

    }
}
