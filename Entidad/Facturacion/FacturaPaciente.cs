using System;
using System.Collections.Generic;
using System.Data;

namespace Modelo.Facturacion
{
    public class FacturaPaciente
    {
        public int idAdmision { get; set; }
        public int tipoFactura { get; set; }
        public int idContrato { get; set; }
        public double totalFactura { get; set; }
        public string codigoFactura { get; set; }
        public DateTime fechaCreacion { get; set; }
        public DateTime fechaVencimiento { get; set; }       

        public DataTable dtCambiosCUPS = new DataTable();
        public DataTable dtCambiosOxigeno = new DataTable();
        public DataTable dtCambiosEquivalencia = new DataTable();
    }
}
