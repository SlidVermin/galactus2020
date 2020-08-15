using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad.Configuracion
{
    public class Empresa
    {
        public Empresa()
        {
            idEmpresa = 0;
        }
        public int idEmpresa { get; set; }
        public string nit { get; set; }
        public string razonSocial { get; set; }
        public string codigoHabilitacion { get; set; }
        public int ubicacion { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public string celular { get; set; }
        public string email { get; set; }
        public string sigla { get; set; }
        public string encabezado { get; set; }
        public string pie { get; set; }
        public byte[] logo { get; set; }
        public int idResponsable { get; set; }


    }
}
