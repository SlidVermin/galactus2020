using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista.HistoriaClinica.Fisioterapia
{
    public partial class HojaOxigenoUI : Form
    {
        private int idAtencion;
        private bool auditoria;
        public HojaOxigenoUI()
        {
            InitializeComponent();
        }
        public HojaOxigenoUI(int idAtencion,bool auditoria)
        {
            InitializeComponent();
            this.idAtencion = idAtencion;
            this.auditoria = auditoria;
        }
        void cargarHoja()
        {
                
            /*DataSet tablasResultados = new DataSet();
            List<string> Parametros = new List<string>();
            Parametros.Add(auditoria.ToString());
            Parametros.Add(idAtencion.ToString());
            tablasResultados = GeneralUI.llenarDataset(Sentencias.FISIOTERAPIA_OXIGENO_CARGAR, Parametros);
            if (tablasResultados.Tables.Count > 0)
            {
                txtFisioterapeuta.Text = tablasResultados.Tables["Table"].Rows[0].Field<string>("Nombre");
            }
            dgvOxigeno.DataSource = tablasResultados.Tables["Table1"];*/
               
        }


        private void HojaOxigenoUI_Load(object sender, EventArgs e)
        {
            btBuscarUsuario.Enabled = true;
            cargarHoja();
        }
    }
}
