using CrystalDecisions.Shared;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Vista.HistoriaClinica
{
    public partial class ResumenFacturaUI : Form
    {
        private int idAtencion;
        private bool auditoria;
        public ResumenFacturaUI()
        {
            InitializeComponent();
        }
        public ResumenFacturaUI(int idAtencion, bool auditoria)
        {
            InitializeComponent();
            this.idAtencion = idAtencion;
            this.auditoria = auditoria;
        }
        private void ResumenFacturaUI_Load(object sender, EventArgs e)
        {
            
        }
        public void cargar()
        {
            /*DataSet tablasResultados = new DataSet();
            List<string> Parametros = new List<string>();
            Parametros.Add(auditoria.ToString());
            Parametros.Add(idAtencion.ToString());
            tablasResultados = GeneralC.llenarDataset(Sentencias.RESUMEN_FACTURA_CARGAR, Parametros);
            dgvDetalle.DataSource = tablasResultados.Tables["table"];
            dgvAgrupado.DataSource = tablasResultados.Tables["table1"];
            dgvResumenDiario.DataSource = tablasResultados.Tables["table2"];
            dgvConsolidado.DataSource = tablasResultados.Tables["table3"];*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
           /* RptResumenAtencion rpt = new RptResumenAtencion();
            rpt = generarReporte();
            GeneralC.exportarReporte(rpt, 
                                "Resumen Facturacion", 
                                null, 
                                ExportFormatType.PortableDocFormat);*/
        }
        /*public RptResumenAtencion generarReporte()
        {
            RptResumenAtencion rptResumenAtencion = new RptResumenAtencion();
            Hashtable tbl = new Hashtable();

            // Add some elements to the hash table. There are no 
            // duplicate keys, but some of the values are duplicates.
            tbl.Add("@pAuditoria", auditoria);
            tbl.Add("@pIdAtencion", idAtencion);
            tbl.Add("@pAuditoria2", auditoria);
            tbl.Add("@pIdAtencion2", idAtencion);
            foreach (DictionaryEntry item in tbl)
            {
                rptResumenAtencion.SetParameterValue(item.Key.ToString(), item.Value);
            }
                    
            return rptResumenAtencion;
        }*/
        
    }
}
