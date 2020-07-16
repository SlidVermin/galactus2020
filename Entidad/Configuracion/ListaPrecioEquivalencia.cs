using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Configuracion
{
    public class ListaPrecioEquivalencia
    {
        public int idLista { get; set; }
        public string nombre { get; set; }
        public DataTable tablaEquivalencia { get; set; }
        //public BindingSource tblFuente { get; set; }
        public ListaPrecioEquivalencia()
        {
            idLista = 0;
            nombre = string.Empty;
            tablaEquivalencia = new DataTable();
//            tblFuente = new BindingSource();
           
        }
        public void enlazarDt() {
            colocarColumnas();
            //tblFuente.DataSource = tablaEquivalencia;
        }
        void colocarColumnas()
        {
            if ( tablaEquivalencia.Columns.Count == 0) {
                
                tablaEquivalencia.Columns.Add("Id", Type.GetType("System.Int32"));
                tablaEquivalencia.Columns.Add("Nombre", Type.GetType("System.String"));
                tablaEquivalencia.Columns.Add("Precio", Type.GetType("System.Double"));
                tablaEquivalencia.Columns.Add("mostrar",Type.GetType("System.Boolean"));
                DataColumn[] keys = new DataColumn[1];
                keys[0] = tablaEquivalencia.Columns[0];
                tablaEquivalencia.PrimaryKey = keys; 
            }
        }
    }
}
