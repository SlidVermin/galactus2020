using Entidad.HistoriaClinica;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Vista.General;

namespace Vista.HistoriaClinica
{
    public partial class SolicitudLabUI : Form
    {
        SolicitudLab solicitudLab = new SolicitudLab();
        public SolicitudLabUI(int idAtencion)
        {
            InitializeComponent();
            solicitudLab.idAtencion = idAtencion;
        }

        private void TipoExamenUI_Load(object sender, EventArgs e)
        {
            /*validarGrilla();
            GeneralC.deshabilitarControles(this);
            GeneralC.deshabilitarBotones(ref tstMenuPatron);
            GeneralC.llenarCombo(Sentencias.PROVEEDOR_LABORATORIO_CONSULTAR, "Codigo", "Descripcion", cmbLaboratorio);
            tsbNuevo.Enabled = true;
            tsbBuscar.Enabled = true;*/
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            /*GeneralC.formNuevo(this, tstMenuPatron, tsbGuardar, tsbCancelar);
            dgvEdicion();
            solicitudLab.idSolicitud = ConstanteGeneral.PREDETERMINADO;*/
        }

        private void tsbCancelar_Click(object sender, EventArgs e)
        {
            //GeneralC.fnCancelarForm(this, tstMenuPatron, tsbNuevo, tsbBuscar);   
        }

        private void tsbGuardar_Click(object sender, EventArgs e)
        {
            /*try
            {
                if (validarDatos() == true)
                {
                    if (Mensajes.preguntaGuardar())
                    {
                        dgvResultadoLaboratorio.EndEdit();
                        objetoSolicitudLabCrear();
                        SolicitudLabDAL.guardarSolicitudLab(solicitudLab);
                        GeneralC.deshabilitarBotones(ref tstMenuPatron);
                        GeneralC.deshabilitarControles(this);
                        tsbNuevo.Enabled = true;
                        tsbBuscar.Enabled = true;
                        tstImprimir.Enabled = true;
                        tsbAnular.Enabled = true;
                        Mensajes.mensajeInformacion(Mensajes.CONFIRMACION_GUARDADO);
                    }
                }
            }
            catch (Exception ex) {
                Mensajes.mensajeError(ex);
            }*/
        }

        private void tsbBuscar_Click(object sender, EventArgs e)
        {
            /*List<string> parametro = new List<string>();
            parametro.Add(string.Empty);
            parametro.Add(solicitudLab.idAtencion.ToString());
            GeneralC.buscarDevuelveFila(Sentencias.BUSCAR_SOLICITUD_LAB,
                                    parametro,
                                    new GeneralC.cargarInfoFila(cargarRegistro),
                                    Titulos.TITULO_BUSCAR_SOLICITUD_LABORATORIO,
                                    true);*/
        }

        private void tsbAnular_Click(object sender, EventArgs e)
        {
            /*try
            {
                if (Mensajes.preguntaAnular() == true) {
                    if (SolicitudLabDAL.anularSolicitudLab(solicitudLab.idSolicitud) == true)
                    {
                        GeneralC.posAnular(this, tstMenuPatron, tsbNuevo, tsbBuscar);
                    }
                    else
                    {
                        Mensajes.mensajeAdvertencia("Solicitud imposible de anular, ya a sido procesada");
                    }
                   
            }
            }
            catch (Exception ex) {
                Mensajes.mensajeError(ex);
            }*/
        }
        
        private bool validarDatos() {
            /*if (cmbLaboratorio.SelectedIndex == 0)
            {
                Mensajes.mensajeAdvertencia("Favor seleccionar el laboratorio");
            }
            else {
             return true;
            }*/

            return false;
        }

        private void cargarRegistro(DataRow dRows) {
            solicitudLab.idSolicitud= dRows.Field<int>("codigo");
            cmbLaboratorio.SelectedValue = dRows.Field<int>("idproveedor");
            dtpFechaSolicitud.Value= dRows.Field<DateTime>("Fecha");
            cargarExamenLabEnviado();
            GeneralUI.posBuscar(this, tstMenuPatron, tsbNuevo, tsbBuscar,tstImprimir,tsbNuevo);
        }

        private void objetoSolicitudLabCrear() {
            solicitudLab.idLaboratorio = Convert.ToInt32(cmbLaboratorio.SelectedValue);
            solicitudLab.fecha = dtpFechaSolicitud.Value;
        }
        private void validarGrilla() {
            dgvResultadoLaboratorio.Columns[0].DataPropertyName = "idOrdenMedica";
            dgvResultadoLaboratorio.Columns[1].DataPropertyName = "idProcedimiento";
            dgvResultadoLaboratorio.Columns[2].DataPropertyName = "Cups";
            dgvResultadoLaboratorio.Columns[3].DataPropertyName = "Descripcion";
            dgvResultadoLaboratorio.Columns[4].DataPropertyName = "Enviado";
            dgvResultadoLaboratorio.DataSource = solicitudLab.dtLaboratorio;
            dgvResultadoLaboratorio.AutoGenerateColumns = false;

        }
        private void cargarExamenLabPendiente() {
           /* List<string> paramtro = new List<string>();
            try
            {
                paramtro.Add(dtpFechaSolicitud.Value.ToString("dd-MM-yyyy"));
                solicitudLab.dtLaboratorio = GeneralC.cargarResultadosSQL(Sentencias.CARGAR_SOLICITUDES_PENDIENTES, paramtro);
                dgvResultadoLaboratorio.DataSource = solicitudLab.dtLaboratorio;
            }
            catch (Exception ex) {
                Mensajes.mensajeError(ex);
            }*/
        }

        private void cargarExamenLabEnviado()
        {
           /* List<string> paramtro = new List<string>();
            try
            {
                paramtro.Add(solicitudLab.idSolicitud.ToString());
                solicitudLab.dtLaboratorio = GeneralC.cargarResultadosSQL(Sentencias.CARGAR_SOLICITUDES_ENVIADO, paramtro);
                dgvResultadoLaboratorio.DataSource = solicitudLab.dtLaboratorio;
            }
            catch (Exception ex) {
                Mensajes.mensajeError(ex);
            }*/
        }
        private void dtpFechaSolicitud_ValueChanged(object sender, EventArgs e)
        {
            if (tsbGuardar.Enabled == true) {
                cargarExamenLabPendiente();
            }
        }
        private void dgvEdicion() {
            dgvResultadoLaboratorio.ReadOnly = false;
            dgvResultadoLaboratorio.Columns[0].ReadOnly = true;
            dgvResultadoLaboratorio.Columns[2].ReadOnly = true;
            dgvResultadoLaboratorio.Columns[3].ReadOnly = true;
            dgvResultadoLaboratorio.Columns[4].ReadOnly = false;
        }
    }
}
