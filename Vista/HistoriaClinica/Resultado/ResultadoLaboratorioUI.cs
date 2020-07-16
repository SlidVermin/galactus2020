using Entidad.HistoriaClinica.Resultado;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Vista.General;

namespace Vista.HistoriaClinica.Resultado
{
    public partial class ResultadoLaboratorioUI : Form
    {
        private ResultadoLaboratorio resultadoLab = new ResultadoLaboratorio();
        private int idProcedimiento;

        public ResultadoLaboratorioUI(int idOrdenMedica,int idProcedimiento, int auditoria, int idSolicitud)
        {
            InitializeComponent();
            resultadoLab.idSolicitud = idSolicitud;
            resultadoLab.idOrdenMedica = idOrdenMedica;
            this.idProcedimiento = idProcedimiento;
            resultadoLab.auditoria = auditoria;
        }
        private void tstModificar_Click(object sender, EventArgs e)
        {
            /*if (Mensajes.preguntaSiNo(Mensajes.Modificar_FORM)== true) {
                GeneralC.deshabilitarBotones(ref tstMenuPatron);
                habilitarControles();
                tsbGuardar.Enabled = true;
                tsbCancelar.Enabled = true;
            }*/
        }

        private void tsbCancelar_Click(object sender, EventArgs e)
        {
            /*if (Mensajes.preguntaSiNo(Mensajes.CANCELAR_FORM) == true) {
                cargarInformacionADatos();
            }*/
        }

        private void tsbGuardar_Click(object sender, EventArgs e)
        {
            /*if (dtpMuestra.Value.Date >= dtpResultado.Value.Date)
            {
                Mensajes.mensajeAdvertencia("La fecha de muestra, no puede ser igual o mayor a la fecha de resultado");
            }
            else
            {
                if (Mensajes.preguntaGuardar() == true)
                {
                    try {
                        cargarResultadoLab();
                        ResultadoLaboratorioDAL.guardarResultadoLab(resultadoLab);
                        GeneralC.habilitarBotones(ref tstMenuPatron);
                        GeneralC.deshabilitarControles(this);
                        tsbGuardar.Enabled = false;
                        tsbCancelar.Enabled = false;
                        btnSalir.Enabled = true;
                        Mensajes.mensajeInformacion(Mensajes.CONFIRMACION_GUARDADO);
                    }
                    catch (Exception ex)
                    {
                        Mensajes.mensajeError(ex);
                    }
                }
            }*/
        }
        private void tsbAnular_Click(object sender, EventArgs e)
        {
            /*if (Mensajes.preguntaAnular() == true) {
                if (ResultadoLaboratorioDAL.anularResulatdoLab(resultadoLab.codigoResultado, resultadoLab.auditoria) == true) {
                    cargarInformacionADatos();
                    Mensajes.mensajeInformacion(Mensajes.CONFIRMACION_ANULADO);
                }
            }*/
        }

        private void tstImprimir_Click(object sender, EventArgs e)
        {

        }
        private void habilitarControles() {
            dtpMuestra.Enabled = true;
            dtpResultado.Enabled = true;
            dgvResultados.ReadOnly = false;
            txtObservacion.ReadOnly = false;
            dgvResultados.Columns["dgCodigo"].ReadOnly = true;
            dgvResultados.Columns["dgDescripcion"].ReadOnly = true;
            dgvResultados.Columns["dgResultado"].ReadOnly = false;
            dgvResultados.Columns["dgReferencia"].ReadOnly = true;
        }

        private void validarGrilla() { 
            dgvResultados.Columns["dgCodigo"].DataPropertyName="Codigo";
            dgvResultados.Columns["dgParametro"].DataPropertyName = "Parametro";
            dgvResultados.Columns["dgDescripcion"].DataPropertyName="Descripcion";
            dgvResultados.Columns["dgResultado"].DataPropertyName="Resultado";
            dgvResultados.Columns["dgReferencia"].DataPropertyName="Referencia";
            dgvResultados.DataSource = resultadoLab.dtResultado;
            dgvResultados.AutoGenerateColumns = false;
        }
        public void cargarInformacionADatos()
        {
            /*List<string> paramtro = new List<string>();
            DataRow dRows;
            DataTable dtDatos = new DataTable();
            paramtro.Add(resultadoLab.auditoria.ToString());
            paramtro.Add(resultadoLab.idOrdenMedica.ToString());
            paramtro.Add(idProcedimiento.ToString());
            try {
                dtDatos = GeneralC.cargarResultadosSQL(Sentencias.BUSCAR_PACIENTE_RESULTADO_LAB, paramtro);
                dRows = dtDatos.Rows[0];

                txtAtencion.Text = dRows.Field<int>("idAtencion").ToString();
                txtPaciente.Text = dRows.Field<string>("paciente").ToString();
                txtIdentificacion.Text = dRows.Field<string>("Documento").ToString();
                txtServicio.Text = dRows.Field<string>("Entorno").ToString();
                txtOrdenMedica.Text = dRows.Field<int>("IdOrdenMedica").ToString();
                txtProcedimiento.Text = dRows.Field<string>("procedimiento").ToString();
                txtCodigoAdministradora.Text = dRows.Field<int>("IdContrato").ToString();
                txtAdministradora.Text = dRows.Field<string>("Nombre").ToString();
                resultadoLab.codigoGenero = dRows.Field<int>("IdGenero");
                resultadoLab.estadoRegistro = dRows.Field<bool>("EstadoRegistro");
                lbTitulo.Text = dRows.Field<string>("nombreExamen").ToString();
                txtObservacion.Text = dRows.Field<string>("Observacion").ToString();
                dtpMuestra.Value = dRows.Field<DateTime>("FechaMuestra");
                dtpResultado.Value = dRows.Field<DateTime>("FechaResultado");

                validarGrilla();
                cargarParametrosLaboratorio();

                GeneralC.deshabilitarControles(this);
                GeneralC.deshabilitarBotones(ref tstMenuPatron);
                btnSalir.Enabled = true;

                if (resultadoLab.estadoRegistro == true) {
                    resultadoLab.codigoResultado = dRows.Field<int>("idResultado");
                    tstModificar.Enabled = true;
                    tstImprimir.Enabled = true;
                    tsbAnular.Enabled = true;
                }
                else
                {
                    habilitarControles();
                    resultadoLab.codigoResultado = ConstanteGeneral.PREDETERMINADO;
                    tsbGuardar.Enabled = true;
                    tsbCancelar.Enabled = true;
                }
            }
            catch (Exception ex) {
                Mensajes.mensajeError(ex);
            }   */ 
        }
        private void cargarParametrosLaboratorio() {
            List<string> paramtro = new List<string>();

            paramtro.Add(resultadoLab.auditoria.ToString());
            paramtro.Add(resultadoLab.idOrdenMedica.ToString()); 
            paramtro.Add(resultadoLab.codigoGenero.ToString());
            paramtro.Add(idProcedimiento.ToString());
            paramtro.Add(Convert.ToUInt32(resultadoLab.estadoRegistro).ToString());

           /* resultadoLab.dtResultado = GeneralC.cargarResultadosSQL(Sentencias.CARGAR_RESULTADO_LAB, paramtro);
            dgvResultados.DataSource = resultadoLab.dtResultado;
            dgvResultados.Columns["dgCodigo"].Visible = false;*/

        }
        private void cargarResultadoLab() {
            resultadoLab.fechaMuestra = dtpMuestra.Value;
            resultadoLab.fechaResultado = dtpResultado.Value;
            resultadoLab.observacion = txtObservacion.Text;
        }

        #region btnSalir      
        private void btnSalir_Click(object sender, EventArgs e)
        {
           /* if (MessageBox.Show(Mensajes.SALIR_FORM, Mensajes.NOMBRE_SOFT, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Close();
            }*/
        }
        #endregion

    }
}
