using Entidad.HistoriaClinica.Configuracion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Vista.General;

namespace Vista.HistoriaClinica.Configuracion
{

    public partial class ConfiguracionProcedimientoMedicoUI : Form
    {
        ConfiguracionProcedimientoMedico configuracionProcedimientoMedico = new ConfiguracionProcedimientoMedico();

        public object ApplicationView { get; private set; }

        public ConfiguracionProcedimientoMedicoUI()
        {
            InitializeComponent();
        }

        private void ConfiguracionProcedimientoMedicoUI_Load(object sender, EventArgs e)
        {
            /*GeneralUI.deshabilitarControles(this);
            GeneralUI.diseñoDGV(ref dgvEntorno);*/

        }

        private void tsbNuevo_Click(object sender, EventArgs e)        {
            
            /*configurarDatosDgv();

            configuracionProcedimientoMedico.tablaAreaAtencion.Rows.Add();
            configuracionProcedimientoMedico.tablaProcedimiento.Rows.Add();
            configuracionProcedimientoMedico.tablaMedicamentoInsumo.Rows.Add();

            dgvEntorno.Columns["dgBuscarArea"].DisplayIndex = (dgvEntorno.ColumnCount - 1);
            dgvProcedimientos.Columns["dgBuscarProcedimiento"].DisplayIndex = (dgvProcedimientos.ColumnCount - 1);
            dgvMedicamentos.Columns["dgBuscarMedicamento"].DisplayIndex = (dgvMedicamentos.ColumnCount - 1);

            dgvEntorno.Columns["dgQuitarArea"].DisplayIndex = (dgvEntorno.ColumnCount - 1);
            dgvProcedimientos.Columns["dgQuitarProcedimiento"].DisplayIndex = (dgvProcedimientos.ColumnCount - 1);
            dgvMedicamentos.Columns["dgQuitarMedicamento"].DisplayIndex = (dgvMedicamentos.ColumnCount - 1);
            */
        }
        private void configurarDatosDgv()
        {
            
            /*enlazarDatosDgv(dgvEntorno, "dgCodigoArea", "Código");
            enlazarDatosDgv(dgvEntorno, "dgDescripcionArea", "Descripción");

            enlazarDatosDgv(dgvMedicamentos, "dgCodigoMedicamento", "Código");
            enlazarDatosDgv(dgvMedicamentos, "dgDescripcionMedicamento", "Descripción");
            enlazarDatosDgv(dgvMedicamentos, "dgCantidadMedicamento", "Cantidad");

            enlazarDatosDgv(dgvProcedimientos, "dgCodigoProcedimiento", "Código");
            enlazarDatosDgv(dgvProcedimientos, "dgDescripcionProcedimiento", "Descripción");
            enlazarDatosDgv(dgvProcedimientos, "dgCantidadProcedimiento", "Cantidad");

            dgvEntorno.AutoGenerateColumns = false;
            dgvProcedimientos.AutoGenerateColumns = false;
            dgvMedicamentos.AutoGenerateColumns = false;

            dgvEntorno.DataSource = configuracionProcedimientoMedico.tablaAreaAtencion;
            dgvProcedimientos.DataSource = configuracionProcedimientoMedico.tablaProcedimiento;
            dgvMedicamentos.DataSource = configuracionProcedimientoMedico.tablaMedicamentoInsumo;*/

        }
        private void enlazarDatosDgv(DataGridView datagrid,string columnaDgv,string columnaDt)
        {
            datagrid.Columns[columnaDgv].DataPropertyName = columnaDt;
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            //GeneralUI.fnModificarForm(this, tstMenuPatron, tsbGuardar, tsbCancelar);
        }

        private void tsbCancelar_Click(object sender, EventArgs e)
        {
            //GeneralUI.fnCancelarForm(this, tstMenuPatron, tsbNuevo, tsbBuscar);
        }

        private void tsbBuscar_Click(object sender, EventArgs e)
        {
            /*try
            {
                List<string> parametros = new List<string>();
                parametros.Add("");
                GeneralUI.buscarDevuelveFila(Sentencias.PRODUCTO_BUSCAR,
                                            parametros,
                                            new GeneralUI.cargarInfoFila(cargarConfiguracionMedica),
                                            Mensajes.BUSQUEDA_PRODUCTO,
                                            true);
            }
            catch (Exception ex)
            {
                Mensajes.mensajeError(ex);
            }*/
        }

        void cargarConfiguracionMedica(DataRow fila)
        {
            /*configuracionProcedimientoMedico.idConfiguracion = fila.Field<int>("CodigoConfiguracion");
            List<string> listaParametros = new List<string>();
            listaParametros.Add(configuracionProcedimientoMedico.idConfiguracion.ToString());
            DataRow filaResultado = GeneralUI.obtenerRegistroCompleto(Sentencias.PRODUCTO_CARGAR, listaParametros);
            if (filaResultado != null)
            {
                configuracionProcedimientoMedico.idItem = filaResultado.Field<string>("idItem");
                configuracionProcedimientoMedico.descripcionItem = filaResultado.Field<string>("descripcionItem");
                configuracionProcedimientoMedico.idCliente = filaResultado.Field<int>("idCliente");
                configuracionProcedimientoMedico.descripcionCliente = filaResultado.Field<string>("descripcionCliente");
                configuracionProcedimientoMedico.moduloHc = filaResultado.Field<bool>("moduloHc");
                configuracionProcedimientoMedico.moduloFc = filaResultado.Field<bool>("moduloFc");
                configuracionProcedimientoMedico.noRepetible = filaResultado.Field<bool>("noRepetible");
                configuracionProcedimientoMedico.paquete = filaResultado.Field<bool>("paquete");
                configuracionProcedimientoMedico.tipo = filaResultado.Field<string>("tipoItem");

                txtBNombreCliente.Text = filaResultado.Field<string>("nombreCliente");                
                txtBNombreProcedimiento.Text = configuracionProcedimientoMedico.descripcionItem;                
            }*/


        }
        void cargarItemDatagrid(DataRow fila)
        {
            /*configuracionProcedimientoMedico.tablaAreaAtencion.Rows.Add();
            configuracionProcedimientoMedico.tablaAreaAtencion.Rows[dgvEntorno.CurrentRow.Index].SetField<int>(0,fila.Field<int>("Código"));
            configuracionProcedimientoMedico.tablaAreaAtencion.Rows[dgvEntorno.CurrentRow.Index].SetField<String>(1, fila.Field<String>("Descripción"));
            dgvEntorno.DataSource = configuracionProcedimientoMedico.tablaAreaAtencion;*/
            
        }
        

        private void tsbAnular_Click(object sender, EventArgs e)
        {
            /*if (MessageBox.Show(Mensajes.ANULAR_FORM, Mensajes.NOMBRE_SOFT, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {

                    GeneralUI.posAnular(this, tstMenuPatron, tsbNuevo, tsbBuscar, Mensajes.CONFIRMACION_ANULADO);
                }
                catch (Exception ex)
                {
                    Mensajes.mensajeError(ex);
                }

            }*/
        }

        private void dgvEntorno_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //buscarItemDatagrid(Sentencias.PRODUCTO_BUSCAR, new GeneralUI.cargarInfoFila(cargarItemDatagrid), Mensajes.BUSQUEDA_PRODUCTO);
        }
        //private void buscarItemDatagrid(string consulta, GeneralUI.cargarInfoFila metodo, string titulo) {
        private void buscarItemDatagrid()
        {
            /*try
            {
                List<string> parametros = new List<string>();
                parametros.Add("");
                GeneralUI.buscarDevuelveFila(consulta,
                                            parametros,
                                            new GeneralUI.cargarInfoFila(metodo),
                                           titulo,
                                            true);
            }
            catch (Exception ex)
            {
                Mensajes.mensajeError(ex);
            }*/
        }

        private void dgvProcedimientos_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            /*try
            {
                List<string> parametros = new List<string>();
                parametros.Add("");
                GeneralUI.buscarDevuelveFila(Sentencias.PRODUCTO_BUSCAR,
                                            parametros,
                                            new GeneralUI.cargarInfoFila(cargarConfiguracionMedica),
                                            Mensajes.BUSQUEDA_PRODUCTO,
                                            true);
            }
            catch (Exception ex)
            {
                Mensajes.mensajeError(ex);
            }*/
        }

        private void dgvMedicamentos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*try
            {
                List<string> parametros = new List<string>();
                parametros.Add("");
                GeneralUI.buscarDevuelveFila(Sentencias.PRODUCTO_BUSCAR,
                                            parametros,
                                            new GeneralUI.cargarInfoFila(cargarConfiguracionMedica),
                                            Mensajes.BUSQUEDA_PRODUCTO,
                                            true);
            }
            catch (Exception ex)
            {
                Mensajes.mensajeError(ex);
            }*/
        }

        private void pnlCerrarForm_Click(object sender, EventArgs e)
        {
            /*if (MessageBox.Show(Mensajes.SALIR_FORM, Mensajes.NOMBRE_SOFT, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }*/
        }
        
}
         
}
