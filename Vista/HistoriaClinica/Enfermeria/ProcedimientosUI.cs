using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista.HistoriaClinica.Enfermeria
{
    public partial class ProcedimientosUI : Form
    {
        public ProcedimientosUI()
        {
            InitializeComponent();
        }

        private void ProcedimientosUI_Load(object sender, EventArgs e)
        {
            establecerDatagridview();
        }
        public void establecerDatagridview()
        {
            dgvProcedimientos.Columns["dgId"].DataPropertyName = "Id";
            dgvProcedimientos.Columns["dgCodigo"].DataPropertyName = "Código";
            dgvProcedimientos.Columns["dgDescripcion"].DataPropertyName = "Descripcion";
            dgvProcedimientos.Columns["dgLista"].DataPropertyName = "Lista";
            dgvProcedimientos.Columns["dgFormato"].DataPropertyName = "Formato";
        }
    }
}
