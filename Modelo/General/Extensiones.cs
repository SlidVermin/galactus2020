using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.General
{
    public static class Extensiones
    {
        public static string[] cortarCadena(this String cadena,char separador) {
            return cadena.Split(separador);
        }
     
    }
}
