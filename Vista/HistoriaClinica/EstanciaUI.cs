using Entidad.HistoriaClinica;
using System;
using System.Data;
using System.Windows.Forms;
using Vista.General;

namespace Vista.HistoriaClinica
{
    public partial class EstanciaUI : Form
    {
        private int idAtencion;
        private Estancia estancia= new Estancia();
        public EstanciaUI()
        {
            InitializeComponent();
        }

        public EstanciaUI(int idAtencion, bool auditoria)
        {
            InitializeComponent();
            this.idAtencion = idAtencion;
            estancia.idAtencion = idAtencion;
            estancia.auditoria = auditoria;
        }
        private void listarEstancia()
        {
           /* try
            {
                estancia.listarEstancia();
                dgvEstancia.DataSource = estancia.dtEstancia;
                dgvEstancia.Enabled = true;
            }
            catch(Exception ex)
            {
                Mensajes.mensajeError(ex);
            }*/
        }

        private void EstanciaUI_Load(object sender, EventArgs e)
        {
            listarEstancia();
        }

        private void tsBtModificar_Click(object sender, EventArgs e)
        {
            /*GeneralUI.deshabilitarBotones(ref tstMenu);
            tsBtCancelar.Enabled = true;
            tsBtGuardar.Enabled = true;
            dgvEstancia.Columns["dgExcluirEstancia"].ReadOnly = false;*/
        }

        private void tsBtCancelar_Click(object sender, EventArgs e)
        {
            GeneralUI.fnCancelarForm(this, tstMenu, tsBtModificar, tsBtModificar);
            listarEstancia();
            terminarEdicion();
        }

        private void tsBtGuardar_Click(object sender, EventArgs e)
        {
            guardar();
        }
        private void guardar()
        {
           /* if (GeneralC.validarDetalleVacio(estancia.dtEstancia, "Descripción", false) && 
                GeneralC.validarDetalleVacio(estancia.dtEstancia , "Observación", false) && 
                Mensajes.preguntaGuardar())
            {
                try
                {
                    estancia.guardar();
                    GeneralC.posGuardar(this, tstMenu, tsBtModificar, tsBtImprimir, null, null, null, Mensajes.CONFIRMACION_GUARDADO);
                    terminarEdicion();
                }
                catch (Exception ex)
                {
                    Mensajes.mensajeError(ex);
                }
            }*/
        }
        private void terminarEdicion()
        {
            dgvEstancia.Columns["dgExcluirEstancia"].ReadOnly = true;
            dgvEstancia.Enabled = true;
        }

        private void dgvEstancia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string nombreColumna;
            nombreColumna = dgvEstancia.Columns[e.ColumnIndex].HeaderText;
            if (nombreColumna.Equals("Asignar") && tsBtGuardar.Enabled)
            {
                buscarEstancia();
            }
            
        }
        

        private void buscarEstancia()
        {
            /*try
            {
                List<string> parametros = new List<string>();
                parametros.Add(Convert.ToString(estancia.idAtencion));
                parametros.Add(Convert.ToString(null));
                GeneralC.buscarDevuelveFila(Sentencias.ORDEN_CLINICA_BUSCAR_ESTANCIAS,
                                                   parametros,
                                                   new GeneralC.cargarInfoFila(agregarEstancia),
                                                   Mensajes.BUSQUEDA_ESTANCIAS, true);
            }
            catch (Exception ex)
            {
                Mensajes.mensajeError(ex);
            }*/
        }
        private void agregarEstancia(DataRow fila)
        {
            estancia.dtEstancia.Rows[dgvEstancia.CurrentCell.RowIndex]["idProcedimiento"] = fila.Field<int>("ID");
            estancia.dtEstancia.Rows[dgvEstancia.CurrentCell.RowIndex]["Código"] = fila.Field<string>("Código");
            estancia.dtEstancia.Rows[dgvEstancia.CurrentCell.RowIndex]["Descripción"] = fila.Field<string>("Descripción");
            dgvEstancia.EndEdit();
            ((DataTable)dgvEstancia.DataSource).AcceptChanges();
        }

        private void dgvEstancia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            abrirObservacion();
        }
        private void abrirObservacion()
        {
            GeneralUI.abrirVentanaEntradaDatos(ref dgvEstancia, 
                                              "Observación", 
                                              "dgCodigoCUPSEstancia", 
                                              tsBtGuardar.Enabled);
        }

        private void dgvEstancia_KeyPress(object sender, KeyPressEventArgs e)
        {
            abrirObservacion();
        }
    }
}
