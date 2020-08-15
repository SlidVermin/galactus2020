using Entidad.Facturacion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Vista.General;

namespace Vista.Facturacion
{
    public partial class FacturaUI : Form
    {
        FacturaPaciente factura = new FacturaPaciente();
        public FacturaUI()
        {
            InitializeComponent();
        }

        private void btBuscarContrato_Click(object sender, EventArgs e)
        {
            /*try
            {
                List<string> parametros = new List<string>();
                GeneralC.buscarDevuelveFila(Sentencias.FACTURA_PACIENTE_BUSCAR_CONTRATO,
                                                   parametros,
                                                   new GeneralC.cargarInfoFila(cargarContratoEps),
                                                   Mensajes.BUSQUEDA_CONTRATO_EPS, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }*/
        }

        public void cargarContratoEps(DataRow fila)
        {
            GeneralUI.limpiarControles(this);  
            txtCodigoContrato.Text = Convert.ToString(fila.Field<int>("Código"));
            txtDocumento.Text = fila.Field<String>("NIT");
            txtNombre.Text = fila.Field<String>("Cliente");
            txtTarifa.Text = fila.Field<String>("Tarifa");
            txtListaPrecio.Text = fila.Field<String>("Lista de precio");
            factura.idContrato = fila.Field<int>("Código");
            btBuscarAtencion.Enabled = true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            /*if (MessageBox.Show(Mensajes.SALIR_FORM, Mensajes.NOMBRE_SOFT, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Close();
            }*/
        }

        private void btBuscarAtencion_Click(object sender, EventArgs e)
        {
           /* try
            {
                List<string> parametros = new List<string>();
                parametros.Add(null);
                parametros.Add(Convert.ToString(factura.idContrato));  
                GeneralC.buscarDevuelveFila(Sentencias.FACTURA_PACIENTE_BUSCAR_ADMISION,
                                                   parametros,
                                                   new GeneralC.cargarInfoFila(cargarAdmision),
                                                   Mensajes.BUSQUEDA_ADMISIONES, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }*/
        }
        public void cargarAdmision(DataRow fila)
        {
            /*txtAdmision.Text = Convert.ToString(fila.Field<int>("Admisión"));
            txtPaciente.Text = fila.Field<String>("Paciente");
            dtpIngreso.Value = fila.Field<DateTime>("Fecha ingreso");
            dtpEgreso.Value = fila.Field<DateTime>("Fecha egreso");
            txtAfiliacion.Text = fila.Field<String>("Afiliación");
            txtRegimen.Text = fila.Field<String>("Régimen");
            factura.idAdmision = fila.Field<int>("Admisión");
            factura.tipoFactura = fila.Field<int>("tipoFactura");
            factura.cargarDatos(); 
            dgvProcedimientos.DataSource =factura.dsDatos.Tables["table"];
            dgvOxigenos.DataSource = factura.dsDatos.Tables["table1"];
            dgvMedicamentos.DataSource = factura.dsDatos.Tables["table2"];
            txtValorFactura.Text = factura.totalFactura.ToString("C0");
            dtpVence.Enabled = true;*/
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            GeneralUI.formNuevo(this, tstMenuPatron, tsbGuardar, tsbCancelar);
            GeneralUI.deshabilitarControles(this); 
            btBuscarContrato.Enabled = true;
            btnSalir.Enabled = true; 
        }

        private void FacturaUI_Load(object sender, EventArgs e)
        {
            GeneralUI.deshabilitarControles(this);
            btnSalir.Enabled = true;
        }
    }
}
