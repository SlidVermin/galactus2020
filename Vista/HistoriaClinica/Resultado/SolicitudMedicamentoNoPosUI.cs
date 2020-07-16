using Entidad.HistoriaClinica.Resultado;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Vista.General;

namespace Vista.HistoriaClinica.Resultado
{
    public partial class SolicitudMedicamentoNoPosUI : Form
    {
        MedicamentosNoPos medicamento = new MedicamentosNoPos();
        public SolicitudMedicamentoNoPosUI()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SolicitudMedicamentoNoPosUI_Load(object sender, EventArgs e)
        {
            /*GeneralUI.posCargadoForm(this, tstMenuPatron, null, tsbBuscar);
            btBuscarOrden.Enabled = true;
            btnSalir.Enabled = true;
            txtfechaSolicitud.Text = Convert.ToString(GeneralC.obtenerFechaServidor());
            tablecerDatagridview();*/
        }
        public void establecerDatagridview()
        {
            dgvDiagnostico.Columns["dgId"].DataPropertyName = "Id";
            dgvDiagnostico.Columns["dgidEvolucion"].DataPropertyName = "idEvolucion";
            dgvDiagnostico.Columns["dgCodigo"].DataPropertyName = "Código";
            dgvDiagnostico.Columns["dgDescripcion"].DataPropertyName = "Descripcion";
            dgvDiagnostico.Columns["dgAsignar"].DataPropertyName = "Asignar";          
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Mensajes.SALIR_FORM, Mensajes.NOMBRE_SOFT, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btBuscarOrden_Click(object sender, EventArgs e)
        {
            /*try
            {
                List<string> parametros = new List<string>();
                parametros.Add(Convert.ToString(medicamento.auditoria));
                List<string> listaOculta = new List<string>();
                listaOculta.Add("idEquivalencia");
                listaOculta.Add("idSolicitudNoPos");
                GeneralC.buscarDevuelveFila(Sentencias.BUSCAR_ORDEN_MEDICAMENTO_NOPOS,
                                                   parametros,
                                                   new GeneralC.cargarInfoFila(cargarRegistro),
                                                   Mensajes.BUSQUEDA_EPS, true, listaOculta);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }*/
        }
        public void cargarRegistro(DataRow resultado)
        {
            /*GeneralUI.limpiarControles(this);
            medicamento.idAtencion = resultado.Field<int>("Atencion");
            medicamento.idOrdenMedica = resultado.Field<int>("Código orden");
            medicamento.idSolicitud = resultado.Field<int>("idSolicitudNoPos");
            medicamento.nombreMedicamentoActual = resultado.Field<String>("Medicamento");
            medicamento.idMedicamentoActual = resultado.Field<int>("idEquivalencia");
            medicamento.cargarDatos();
            Datos();
            dgvDiagnostico.DataSource = medicamento.dsDatos.Tables["table1"];
            dgvDiagnostico.ReadOnly = false;
            habilitarBotonesPredeterminado();
            deshabilitarColumnas();
            habilitarControles();
            txtfechaSolicitud.Text = Convert.ToString(GeneralC.obtenerFechaServidor());*/

        }
        public void Datos()
        {
            txtAtencion.Text = Convert.ToString(medicamento.idAtencion);
            txtHistoriaClinica.Text = medicamento.documento;
            txtPaciente.Text = medicamento.paciente;
            txtEdad.Text = medicamento.edad;
            txtCama.Text = medicamento.cama;
            txtCausaExterna.Text = medicamento.causaExterna;
            txtInstitucion.Text = medicamento.institucion;
            txtArea.Text = medicamento.area;
            txtEntorno.Text = medicamento.entorno;
            txtFechaAdmision.Text = Convert.ToString(medicamento.fechaIngreso);
            txtEstancia.Text = medicamento.estancia;
            txtEstado.Text = medicamento.estado;
            txtMedicamentoNOPOS.Text = medicamento.nombreMedicamentoActual;
        }
        public void habilitarControles()
        {
            txtMotivoIngreso.ReadOnly = false;
            txtResumenHistoriaClinica.ReadOnly = false;
            txtRespuestaClinica.ReadOnly = false;
            txtReacciones.ReadOnly = false;
            txtFrecuencia.ReadOnly = false;
            txtDoisis.ReadOnly = false;
            txtnumeroDoisi.ReadOnly = false;
            txtRazonSuspender.ReadOnly = false;
            txtPrecauciones.ReadOnly = false;
            txtEfecto.ReadOnly = false;
            txtIndicacion.ReadOnly = false;
            ndDuracion.ReadOnly = false;
            ndDuracion.Enabled = true;
            chkExisteMedicamento.Enabled = true;
            chkPreinscripcion.Enabled = true;
            chkTecnologiaSalud.Enabled = true;
            txtPeligro.ReadOnly = false;
            txtExiste.ReadOnly = false;
            chkPosibilidad.Enabled = true;
            dtFechaComite.Enabled = true;
            txtEncabezado.ReadOnly = false;
            txtDecision.ReadOnly = false;

            txtAtencion.ReadOnly = true;
            txtArea.ReadOnly = true;
            txtCama.ReadOnly = true;
            txtCausaExterna.ReadOnly = true;
            txtEdad.ReadOnly = true;
            txtEntorno.ReadOnly = true;
            txtEstado.ReadOnly = true;
            txtEstancia.ReadOnly = true;
            txtFechaAdmision.ReadOnly = true;
            txtfechaSolicitud.ReadOnly = true;
            txtInstitucion.ReadOnly = true;
            txtPaciente.ReadOnly = true;
            txtHistoriaClinica.ReadOnly = true;
           
        }

        public void habilitarBotonesPredeterminado()
        {
            tsbCancelar.Enabled = true;
            tsbGuardar.Enabled = true;
            tsbBuscar.Enabled = false;
            tstModificar.Enabled = false;
            tsbAnular.Enabled = false;
            tstImprimir.Enabled = false;          
        }
        public void deshabilitarColumnas()
        {
            dgvDiagnostico.Columns[0].ReadOnly = true;
            dgvDiagnostico.Columns[1].ReadOnly = true;
            dgvDiagnostico.Columns[2].ReadOnly = true;
            dgvDiagnostico.Columns[3].ReadOnly = true;
        }
        private void chkExisteMedicamento_CheckedChanged(object sender, EventArgs e)
        {
            /*if (chkExisteMedicamento.Checked)
            {
                txtRazonSuspender.ReadOnly = false;
                btMedicamento.Enabled = true;
            }else
            {
                txtRazonSuspender.ReadOnly = true;
                txtRazonSuspender.Clear();
                txtMedicamento.Clear();
                medicamento.idMedicamentoReemplazar = ConstanteGeneral.PREDETERMINADO;
                btMedicamento.Enabled = false;
            }*/
        }

        private void btMedicamento_Click(object sender, EventArgs e)
        {
           /* try
            {
                List<string> parametros = new List<string>();

                GeneralC.buscarDevuelveFila(Sentencias.BUSCAR_MEDICAMENTO_NOPOS_REEMPLAZAR,
                                                   parametros,
                                                   new GeneralC.cargarInfoFila(cargarMedicamento),
                                                   Mensajes.BUSQUEDA_EPS, true);
            }
            catch (Exception ex)
            {
                Mensajes.mensajeError(ex);
            }*/
        }
        public void cargarMedicamento(DataRow resultado)
        {
            medicamento.idMedicamentoReemplazar = resultado.Field<int>("id");
            txtMedicamento.Text = resultado.Field<String>("Descripcion");
        }

        
        private void tsbNuevo_Click(object sender, EventArgs e)
        {
        }

        private void tsbCancelar_Click(object sender, EventArgs e)
        {
            /*GeneralUI.fnCancelarForm(this, tstMenuPatron, tsbNuevo, tsbBuscar);
            medicamento.idSolicitud = ConstanteGeneral.PREDETERMINADO;
            btnSalir.Enabled = true;
            btBuscarOrden.Enabled = true;*/
        }
        public bool validarForm()
        {
            /*medicamento.dsDatos.Tables["table2"].AcceptChanges();
            medicamento.dsDatos.Tables["table1"].AcceptChanges();
            if (txtMotivoIngreso.Text.Equals(string.Empty))
            {
                MessageBox.Show("Por favor debe llenar el campo motivo ingreso", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tabPestañas.SelectedIndex = 0;
                txtMotivoIngreso.Focus();
               
                return false;
            }else if (txtResumenHistoriaClinica.Text.Equals(string.Empty))
            {
                MessageBox.Show("Por favor debe llenar el campo resumen historia clinica", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tabPestañas.SelectedIndex = 0;
                txtResumenHistoriaClinica.Focus();              
                return false;
            }else if(medicamento.idSolicitud == ConstanteGeneral.PREDETERMINADO && medicamento.dsDatos.Tables["table1"].Select("Asignar = 1","").Count() ==0 )
            {
                MessageBox.Show("Por favor debe seleccionar un diagnostico", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tabPestañas.SelectedIndex = 0;
                dgvDiagnostico.Focus();
                return false;      
            }
            else if (medicamento.idSolicitud != ConstanteGeneral.PREDETERMINADO && medicamento.dsDatos.Tables["table2"].Select("Asignar = 1", "").Count() == 0)
            {
                MessageBox.Show("Por favor debe seleccionar un diagnostico", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tabPestañas.SelectedIndex = 0;
                dgvDiagnostico.Focus();
                return false;
            }
            else if(chkExisteMedicamento.Checked && txtMedicamento.Text.Equals(string.Empty))
            {
                MessageBox.Show("Por favor debe seleccionar el medicamento POS", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tabPestañas.SelectedIndex = 0;
                txtMedicamento.Focus();
                return false;
            }else if(chkExisteMedicamento.Checked && txtMedicamento.Text != String.Empty && txtRazonSuspender.Text.Equals(string.Empty))
            {
                MessageBox.Show("Por favor justitifique la razon para suspender", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tabPestañas.SelectedIndex = 0;
                txtRazonSuspender.Focus();
                return false;
            }else if (txtEfecto.Text.Equals(string.Empty))
            {
                MessageBox.Show("Por favor llenar el campo efecto deseado", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tabPestañas.SelectedIndex = 0;
                txtEfecto.Focus();
                return false;
            }else if (txtIndicacion.Text.Equals(string.Empty))
            {
                MessageBox.Show("Por favor llenar el campo indicacion de efecto", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tabPestañas.SelectedIndex = 0;
                txtIndicacion.Focus();
                return false;
            }else if (txtRespuestaClinica.Text.Equals(string.Empty))
            {
                MessageBox.Show("Por favor llenar el campo respuesta clinica", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tabPestañas.SelectedIndex = 0;
                txtRespuestaClinica.Focus();
                return false;
            }else if(ndDuracion.Value == 0)
            {
                MessageBox.Show("Por favor digite la cantidad duracion (dias)", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tabPestañas.SelectedIndex = 0;
                ndDuracion.Focus();
                return false;
            }else if (txtFrecuencia.Text.Equals(string.Empty))
            {
                MessageBox.Show("Por favor llenar el campo frecuencia", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tabPestañas.SelectedIndex = 0;
                txtFrecuencia.Focus();
                return false;
            }else if (txtnumeroDoisi.Text.Equals(string.Empty))
            {
                MessageBox.Show("Por favor llenar el campo numero de solicitud", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tabPestañas.SelectedIndex = 0;
                txtnumeroDoisi.Focus();
                return false;
            }else if (txtDoisis.Text.Equals(string.Empty))
            {
                MessageBox.Show("Por favor llenar el campo dosis", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tabPestañas.SelectedIndex = 0;
                txtDoisis.Focus();
                return false;
            }else if (txtPrecauciones.Text.Equals(string.Empty))
            {
                MessageBox.Show("Por favor llenar el campo precaucion", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tabPestañas.SelectedIndex = 1;
                txtPrecauciones.Focus();
                return false;
            }else if (txtPeligro.Text.Equals(string.Empty))
            {
                MessageBox.Show("Por favor llenar el campo peligro", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tabPestañas.SelectedIndex = 1;
                txtPeligro.Focus();
                return false;
            }else if (txtReacciones.Text.Equals(string.Empty))
            {
                MessageBox.Show("Por favor llenar el campo reacciones secundaria", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tabPestañas.SelectedIndex = 1;
                txtReacciones.Focus();
                return false;
            }else if (txtExiste.Text.Equals(string.Empty))
            {
                MessageBox.Show("Por favor llenar el campo contraindicaciones", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tabPestañas.SelectedIndex = 1;
                txtExiste.Focus();
                return false;
            }else if (txtEncabezado.Text.Equals(string.Empty))
            {
                MessageBox.Show("Por favor llenar el campo encabezado", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tabPestañas.SelectedIndex = 2;
                txtEncabezado.Focus();
                return false;
            }else if (txtDecision.Text.Equals(string.Empty))
            {
                MessageBox.Show("Por favor llenar el campo decision", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tabPestañas.SelectedIndex = 2;
                txtDecision.Focus();
                return false;
            }*/
            return true;
        }
        public void asignarDatos()
        {
            medicamento.fechaSolicitud = Convert.ToDateTime(txtfechaSolicitud.Text);
            medicamento.diasTratamiento = (int) ndDuracion.Value;
            medicamento.dosis = txtDoisis.Text;
            medicamento.frecuencia = txtFrecuencia.Text;
            medicamento.dosisSolicitada = txtnumeroDoisi.Text;
            medicamento.resumenHC = txtResumenHistoriaClinica.Text;
            medicamento.otroPosUtilizado = chkExisteMedicamento.Checked;
            medicamento.respuestaPos = txtRespuestaClinica.Text;
            medicamento.efectoDeseado = txtEfecto.Text;
            medicamento.indicacionEfecto = txtIndicacion.Text;
            medicamento.explicacionRazon = txtRazonSuspender.Text;
            medicamento.criterio1 = chkPreinscripcion.Checked;
            medicamento.criterio2 = chkTecnologiaSalud.Checked;
            medicamento.precaucionesOtros = txtPrecauciones.Text;
            medicamento.peligro = txtPeligro.Text;
            medicamento.posibilidadTerapeutica = chkPosibilidad.Checked;
            medicamento.reaccionesSecundaria = txtReacciones.Text;
            medicamento.contraIndicaciones = txtExiste.Text;
            medicamento.fechaCTC = dtFechaComite.Value;
            medicamento.encabezadoCTC = txtEncabezado.Text;
            medicamento.decisionCTC = txtDecision.Text;
            medicamento.motivoIngreso = txtMotivoIngreso.Text;
        }
       
        public void guardarDatos()
        {
            /*try
            {
                if (validarForm() && MessageBox.Show(Mensajes.GUARDAR_FORM, Mensajes.NOMBRE_SOFT, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        asignarDatos();
                        medicamento.guardar();                       
                        GeneralC.posGuardar(this, tstMenuPatron, tsbNuevo, tsbBuscar, tstModificar, tsbAnular, null, Mensajes.CONFIRMACION_GUARDADO);
                        btnSalir.Enabled = true;
                        btBuscarOrden.Enabled = true;
                        tstImprimir.Enabled = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }*/
        }
        private void tsbGuardar_Click(object sender, EventArgs e)
        {
            dgvDiagnostico.EndEdit();
            dgvDiagnostico.CommitEdit(DataGridViewDataErrorContexts.Commit);
            guardarDatos();
        }

        private void tsbBuscar_Click(object sender, EventArgs e)
        {
           /* try
            {
                List<string> parametros = new List<string>();
                parametros.Add(Convert.ToString( medicamento.auditoria));      
                GeneralUI.buscarDevuelveFila(Sentencias.BUSCAR_MEDICAMENTO_NOPOS,
                                                   parametros,
                                                   new GeneralC.cargarInfoFila(cargarDatos),
                                                   Mensajes.BUSQUEDA_EPS, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }*/
        }
        public void cargarDatos(DataRow resultado)
        {
            /*medicamento.idSolicitud = resultado.Field<int>("Código");
            medicamento.idAtencion = resultado.Field<int>("atencion");
            medicamento.idOrdenMedica = resultado.Field<int>("Código orden");
            medicamento.cargarDatos();
            Datos();
            txtfechaSolicitud.Text = Convert.ToString(medicamento.fechaSolicitud);
            ndDuracion.Value = medicamento.diasTratamiento;
            txtDoisis.Text= medicamento.dosis;
            txtFrecuencia.Text= medicamento.frecuencia ;
            txtnumeroDoisi.Text= medicamento.dosisSolicitada ;
            txtResumenHistoriaClinica.Text= medicamento.resumenHC ;
            chkExisteMedicamento.Checked= medicamento.otroPosUtilizado ;
            txtRespuestaClinica.Text= medicamento.respuestaPos ;
            txtEfecto.Text= medicamento.efectoDeseado ;
            txtIndicacion.Text= medicamento.indicacionEfecto ;
            txtRazonSuspender.Text= medicamento.explicacionRazon ;
            chkPreinscripcion.Checked= medicamento.criterio1;
            chkTecnologiaSalud.Checked= medicamento.criterio2 ;
            txtPrecauciones.Text= medicamento.precaucionesOtros ;
            txtPeligro.Text= medicamento.peligro ;
            chkPosibilidad.Checked= medicamento.posibilidadTerapeutica ;
            txtReacciones.Text= medicamento.reaccionesSecundaria ;
            txtExiste.Text= medicamento.contraIndicaciones ;
            dtFechaComite.Value= medicamento.fechaCTC;
            txtEncabezado.Text= medicamento.encabezadoCTC ;
            txtDecision.Text= medicamento.decisionCTC ;
            txtMotivoIngreso.Text = medicamento.motivoIngreso;
            txtMedicamento.Text = medicamento.nombreMedicamentoNuevo;
            dgvDiagnostico.DataSource = medicamento.dsDatos.Tables["table2"];
            habilitarBotonesBuscar();*/
        }
        public void habilitarBotonesBuscar()
        {
            tstModificar.Enabled = true;
            tsbAnular.Enabled = true;
            tsbCancelar.Enabled = false;
            tstImprimir.Enabled = true;
        }

        private void tstModificar_Click(object sender, EventArgs e)
        {
            dgvDiagnostico.EndEdit();
            dgvDiagnostico.CommitEdit(DataGridViewDataErrorContexts.Commit);
            medicamento.dsDatos.Tables["table2"].AcceptChanges();
            GeneralUI.fnModificarForm(this, tstMenuPatron, tsbGuardar, tsbCancelar);
            habilitarControles();
            dgvDiagnostico.ReadOnly = false;
            deshabilitarColumnas();
            btBuscarOrden.Enabled = false;
        }

        private void tsbAnular_Click(object sender, EventArgs e)
        {
            /*if (MessageBox.Show(Mensajes.ANULAR_FORM, Mensajes.NOMBRE_SOFT, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    medicamento.anular();
                    GeneralC.posAnular(this, tstMenuPatron, tsbNuevo, tsbBuscar, Mensajes.CONFIRMACION_ANULADO);
                    medicamento.idSolicitud = ConstanteGeneral.PREDETERMINADO;
                    btnSalir.Enabled = true;
                    btBuscarOrden.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }*/
        }
    }
}
