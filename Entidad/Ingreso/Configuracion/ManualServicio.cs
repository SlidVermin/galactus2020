
using System;
using System.Data;

namespace Modelo.Ingreso.Configuracion
{
    public class ManualServicio
    {
       public DataTable dtSoat = new DataTable();
       public DataTable dtISS = new DataTable();
       public DataTable dtCups = new DataTable();

        public void manualServicio() {
            dtSoat.Columns.Add("Codigo", Type.GetType("System.String"));
            dtSoat.Columns.Add("Descripcion", Type.GetType("System.String"));
            dtSoat.Columns.Add("Valor", Type.GetType("System.Decimal"));
        }

    }
}
