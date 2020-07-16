using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.General
{
    public class Busqueda
    {
        string query;
        bool busquedaPorCodigo;
        bool buscarConEnter;
        DataTable tablaResultado;
        public string Query { get; set; }
        public bool BuscarConEnter { get; set; }
        public bool BusquedaPorCodigo { get; set; }
        public DataTable TablaResultados { get; set; }
        public DataTable itemsSelecionados { get; set; }
        public DataTable listadoParametros { get; set; }
        public List<string> parametros = new List<string>();

        public Busqueda()
        {
            this.query = "";
            this.busquedaPorCodigo = false;
            this.buscarConEnter = false;
        }
    }
}
