using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista.HistoriaClinica
{
    public partial class EgresoUI : Form
    {
        private int idAtencion;
        private bool auditoria;
        public EgresoUI()
        {
            InitializeComponent();
        }

        public EgresoUI(int idAtencion,bool auditoria)
        {
            InitializeComponent();
            this.idAtencion = idAtencion;
            this.auditoria = auditoria;
        }
    }
}
