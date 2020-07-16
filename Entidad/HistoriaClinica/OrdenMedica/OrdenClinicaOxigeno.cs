using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad.HistoriaClinica.OrdenMedica
{
    public class OrdenClinicaOxigeno
    {
        /*public OrdenClinicaOxigeno()
        {
            tblOxigeno = new DataTable();
            tblOxigeno.Columns.Add("idOxigeno", Type.GetType("System.Int32"));
            tblOxigeno.Columns.Add("Descripción", Type.GetType("System.String"));
            tblOxigeno.Columns.Add("Suspender", Type.GetType("System.Boolean"));
            tblOxigeno.Columns["Suspender"].DefaultValue = false;
            tblOxigeno.Columns.Add("Observación", Type.GetType("System.String"));
        }

        public void prepararDT()
        {
            dtCambiosOxigeno = GeneralUI.copiarTablaCondicional(tblOxigeno, "idOxigeno is not null");
            dtCambiosOxigeno.Columns.Remove("Descripción");
            int i;
            for (i = 0; i < dtCambiosOxigeno.Rows.Count; i++)
            {
                dtCambiosOxigeno.Rows[i]["Suspender"] = (string.IsNullOrEmpty(dtCambiosOxigeno.Rows[i]["Suspender"].ToString()) ?
                                                                    false :
                                                                    dtCambiosOxigeno.Rows[i]["Suspender"]);
                
            }
        }*/
    }
}
