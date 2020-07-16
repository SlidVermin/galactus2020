using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Entidad.HistoriaClinica.Fisioterapeuta
{
   public class Fisioterapeutas
    {
        public DataTable dtInsumos = new DataTable();
        public DataSet dsInsumos = new DataSet();
        public int idInsumo { set; get; }
        public int idNota { set; get; }
        public String nota { set; get; }
    }
}
