using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Configuracion
{
    public class Producto
    {
        public int idProducto { get; set; }
        public string descripcion { get; set; }
        public int idMarca { get; set; }
        public int idEquivalencia { get; set; }
        public int idPresentacion { get; set; }
        public string registroSanitario { get; set; }
        public string codigoCUM { get; set; }
        public double iva { get; set; }
    }
}
