using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Entidad.HistoriaClinica.Enfermeria
{
  public  class EnfermeriaClinica
    {
        public DataTable dtInsumos;
        public DataTable dtGlucometria = new DataTable();
        public DataTable  dtInsumosCopia = new DataTable();
        public int idOrdenMedica { set; get; }
        public String tipo { set; get; }
        public int idInsumo { set; get; }
        public int idAtencion { set; get; }
        public DateTime fecha { set; get; }
        public int idNota { set; get; }
        public String nota { set; get; }
        public Boolean insumoAprovado { set; get; }
        public Boolean procedimientoAprobado { set; get; }
        public Boolean glucometriaAprobado { set; get; }
        public Boolean notaAprobado { set; get; }
        public DateTime fechaInsumo { set; get; }
        public DateTime fechaNota { set; get; }
        public Boolean Auditoria { set; get; }
        public DataSet dsInsumos = new DataSet();
        public DataTable dtNotas = new DataTable();
        public DateTime fechaProcedimiento { set; get; }
        public DataTable dtProcedimientos = new DataTable();
        public DataTable dtGlucometriaCopia = new DataTable();
        
    }
}
