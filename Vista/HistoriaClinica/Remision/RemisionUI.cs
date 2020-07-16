using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vista.General;

namespace Vista.HistoriaClinica.Remision
{
    public partial class RemisionUI : Form
    {
        private int idAtencion;
        private bool auditoria;
        private Anexo9UI anexo9 = new Anexo9UI();
        public RemisionUI()
        {
            InitializeComponent();
        }
        public RemisionUI(int idAtencion,bool auditoria)
        {
            InitializeComponent();
            this.idAtencion = idAtencion;
            this.auditoria = auditoria;
        }
        private void tstPropiedadesOrdenMedica_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void RemisionUI_Load(object sender, EventArgs e)
        {
            GeneralUI.cargarFormularioEnPestana(tpAnexo, anexo9);
        }
    }
}
