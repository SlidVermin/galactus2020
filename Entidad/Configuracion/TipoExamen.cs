using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Entidad.Configuracion
{
    public class TipoExamen
    {
        public int idTipoExamen { get; set; }

        public string descripcion { get; set; }
        public bool ckAgrupable { get; set; }
        public int tipo { get; set; }

        public DataTable llenarComboTipoArchivo()
        {
            DataTable dt = new DataTable();
            DataRow dRows;

            dt.Columns.Add("Codigo", Type.GetType("System.Int32"));
            dt.Columns.Add("Descripcion", Type.GetType("System.String"));

            dt.Clear();

            dRows = dt.NewRow();
            dRows[0] = 1;
            dRows[1] = "Laboratorio";
            dt.Rows.Add(dRows);

            dRows = dt.NewRow();
            dRows[0] = 2;
            dRows[1] = "PDF";
            dt.Rows.Add(dRows);

            return dt;
        }
    }
}
