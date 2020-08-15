using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad.Almacen
{
    public class Equivalencia
    {
        public int idEquivalencia { set; get; }
        public string descripcion { get; set; }
        public string codigoATC { get; set; }
        public string descripcionATC { get; set; }
        public string grupoATC { get; set; }
        public Nullable <int> idUnidadMedida { set; get; }
        public double concentracion { get; set; }
        public double osmolalidad { get; set; }
        public bool pos { get; set; }
        public bool medicamentoEspecial { get; set; }

        public DataTable tablaVias = new DataTable();
        public DataTable tablaLineas = new DataTable();
        public DataTable tablaProductos = new DataTable();

        public Equivalencia()
        {
            tablaVias.Columns.Add("Código",Type.GetType("System.Int16"));
            tablaVias.Columns.Add("Descripción", Type.GetType("System.String"));
            tablaVias.Columns.Add("Verificar", Type.GetType("System.Boolean"));
            tablaVias.Columns["Verificar"].DefaultValue = false;

            tablaLineas.Columns.Add("Código", Type.GetType("System.Int16"));
            tablaLineas.Columns.Add("Descripción", Type.GetType("System.String"));
            tablaLineas.Columns.Add("Verificar", Type.GetType("System.Boolean"));
            tablaLineas.Columns["Verificar"].DefaultValue = false;

            tablaProductos.Columns.Add("codigo", Type.GetType("System.Int16"));
            tablaProductos.Columns.Add("descripcion", Type.GetType("System.String"));
            tablaProductos.Columns.Add("marca", Type.GetType("System.String"));
        }
    }
    
}
