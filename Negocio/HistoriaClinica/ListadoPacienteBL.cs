using Modelo.General;
using Modelo.General.Constantes;
using Modelo.General;
using System;
using System.Collections.Generic;
using System.Data;

namespace Negocio.HistoriaClinica
{
    public class ListadoPaciente
    {
        public DataTable dtPacientes = new DataTable();
        public String idMenu { get; set; }
        public bool auditoria { get; set; }
        public int idEntorno { get; set; }
        public int idArea { get; set; }
        public int idEstadoAtencion { get; set; }
        public string filtro { get; set; }
        public ListadoPaciente()
        {
            this.idEntorno = 0;
            this.filtro = "";
        }
        public void listarPacientes()
        {
            auditoria = false;
            List<String> param = new List<string>();
            param.Add(Convert.ToString(auditoria));
            param.Add(Convert.ToString(idArea));
            param.Add(Convert.ToString(idEntorno));
            param.Add(Convert.ToString(idEstadoAtencion));
            param.Add(Convert.ToString(filtro));
            dtPacientes = OperacionesBD.cargarResultadosSQL(ConsultasHistoriaClinica.LISTAR_PACIENTE, param);
        }
    }
}
