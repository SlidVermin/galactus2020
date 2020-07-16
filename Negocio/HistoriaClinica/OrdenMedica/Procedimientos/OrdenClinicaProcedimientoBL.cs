using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.OrdenMedica.Procedimientos
{
    public class OrdenClinicaProcedimiento
    {
          public DataTable tblProcedimientos { get; set; }
        public OrdenClinicaProcedimiento()
        {
            tblProcedimientos = new DataTable();
            tblProcedimientos.Columns.Add("idProcedimiento", Type.GetType("System.Int32"));
            tblProcedimientos.Columns.Add("cups", Type.GetType("System.String"));
            tblProcedimientos.Columns.Add("Cantidad", Type.GetType("System.Int32"));
            tblProcedimientos.Columns.Add("descripcion", Type.GetType("System.String"));
            tblProcedimientos.Columns.Add("Observacion", Type.GetType("System.String"));
            tblProcedimientos.Columns["Cantidad"].DefaultValue = 0;
        }
    }
}
