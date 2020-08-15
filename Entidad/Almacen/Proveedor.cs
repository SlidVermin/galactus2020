using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Entidad.Almacen
{
    public class Proveedor : GeneralTercero
    {
        public int diaVencimiento { get; set; }
        public string codigoBanco { get; set; }
        public string codigoTipoCuenta { get; set; }
        public string identidicacion { get; set; }
        public string cuenta { get; set; }
        public DataTable dtPlazo { get; set; }

        public Proveedor() {

        }
    }
}
