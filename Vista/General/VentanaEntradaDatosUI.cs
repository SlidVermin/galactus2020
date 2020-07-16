using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista.General
{
    public partial class VentanaEntradaDatosUI : Form
    {
        string textoActual { get; set; }
        public VentanaEntradaDatosUI()
        {
            InitializeComponent();
        }

        private void VentanaEntradaDatosUI_Load(object sender, EventArgs e)
        {
            txtTexto.Text = textoActual;
            txtTexto.SelectionStart = txtTexto.TextLength;
        }
        public void obtenerTexto(string textoOrigen)
        {
            textoActual = textoOrigen;
        }

        public void obtenerEstado(bool permitirCambios)
        {
            tsBtGuardar.Enabled = permitirCambios;
            txtTexto.ReadOnly = !permitirCambios;
        }


        public string mostrarTexto() {
            return textoActual;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tsBtCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void VentanaEntradaDatosUI_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) {
                Close();
            }
        }

        private void tsBtGuardar_Click(object sender, EventArgs e)
        {
            textoActual = txtTexto.Text;
            DialogResult = DialogResult.OK;
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
