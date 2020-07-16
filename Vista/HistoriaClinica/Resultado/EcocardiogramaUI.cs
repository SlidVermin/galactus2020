using Entidad.HistoriaClinica.Resultado;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Vista.General;

namespace Vista.HistoriaClinica.Resultado
{
    public partial class EcocardiogramaUI : Form

    {
        Ecocardiograma ecocardiograma = new Ecocardiograma();
        public EcocardiogramaUI()
        {
            InitializeComponent();
        }

        private void EcocardiogramaUI_Load(object sender, EventArgs e)
        {
            GeneralUI.deshabilitarBotones(ref tstMenuPatron);
            GeneralUI.deshabilitarControles(this);
            validarGrilla();
            tsbNuevo.Enabled = true;
            tsbBuscar.Enabled = true;
            btnSalir.Enabled = true;
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            /*GeneralUI.formNuevo(this,tstMenuPatron,tsbGuardar,tsbCancelar);
            GeneralUI.deshabilitarControles(pnlInformacion);
            ecocardiograma.idEco = ConstanteGeneral.PREDETERMINADO;
            editarRegistroGrilla();
            tsbBuscarNit.Enabled = true;
            dtpFecha.Enabled = true;*/
        }

        private void tstModificar_Click(object sender, EventArgs e)
        {
            if (GeneralUI.fnModificarForm(this, tstMenuPatron, tsbGuardar, tsbCancelar) == true) {
                GeneralUI.deshabilitarControles(pnlInformacion);
            editarRegistroGrilla();
            dtpFecha.Enabled = true;
            }    
        }

        private void tsbCancelar_Click(object sender, EventArgs e)
        {
            if (GeneralUI.fnCancelarForm(this, tstMenuPatron, tsbNuevo, tsbBuscar) == true) {
                btnSalir.Enabled = true;
            }
        }

        private void tsbGuardar_Click(object sender, EventArgs e)
        {
            /*try
            {
                if (validarCampos() == true) {
                    if (Mensajes.preguntaGuardar() == true)
                    {
                        objetoEcocardiogramaCrear();
                        EcocardiogramaDAL.guardarEcocardiograma(ecocardiograma);
                        GeneralC.posGuardar(this, tstMenuPatron, tsbNuevo, tstImprimir, tsbBuscar, tstModificar, tsbAnular);
                        btnSalir.Enabled = true;
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
           /* List<string> parametro = new List<string>();
            parametro.Add(ecocardiograma.auditoria.ToString());
            parametro.Add(string.Empty);

            GeneralC.buscarDevuelveFila(Sentencias.BUSCAR_ECOCARDIOGRAMA,
                                    parametro,
                                    new GeneralC.cargarInfoFila(cargarEcocardiograma),
                                    Titulos.TITULO_BUSCAR_ECOCARDIOGRAMA,
                                    true,
                                    listaParametroOculto());*/
        }

        private void tsbBuscarNit_Click(object sender, EventArgs e)
        {
            /*List<string> parametro = new List<string>();

            parametro.Add(ecocardiograma.auditoria.ToString());
            parametro.Add(string.Empty);
            try
            {
                GeneralC.buscarDevuelveFila(Sentencias.BUSCAR_PACIENTE_ECOCARDIOGRAMA,
                                        parametro,
                                        new GeneralC.cargarInfoFila(cargarInformacionAtencion),
                                        Titulos.TITULO_BUSCAR_PACIENTE,
                                        true,
                                        listaParametroOculto());
            }
            catch (Exception ex) {
                Mensajes.mensajeError(ex);
            }*/
        }

        private void tsbAnular_Click(object sender, EventArgs e)
        {
            /*if (Mensajes.preguntaAnular() == true) {
                try
                {
                    if (EcocardiogramaDAL.anularEcocardiograma(ecocardiograma.idEco, ecocardiograma.auditoria) == true)
                    {
                        GeneralC.posAnular(this, tstMenuPatron, tsbNuevo, tsbBuscar);
                        btnSalir.Enabled = true;
                        Mensajes.mensajeInformacion(Mensajes.CONFIRMACION_ANULADO);
                    }
                    else {
                        Mensajes.mensajeInformacion(Mensajes.IMPOSIBLE_ANULA);
                    }
                }
                catch (Exception ex) {
                    Mensajes.mensajeError(ex);
                }
            }*/
        }

        private void objetoEcocardiogramaCrear() {
            ecocardiograma.lectura = txtObservacion.Text;
            ecocardiograma.fecha = dtpFecha.Value;
        }
        private void cargarInformacionAtencion(DataRow dRows)
        {
            txtAtencion.Text = dRows.Field<int>("idAtencion").ToString();
            txtPaciente.Text = dRows.Field<string>("paciente").ToString();
            txtIdentificacion.Text = dRows.Field<string>("Documento").ToString();
            txtServicio.Text = dRows.Field<string>("Entorno").ToString();
            txtOrdenMedica.Text = dRows.Field<int>("IdOrdenMedica").ToString();
            txtProcedimiento.Text = dRows.Field<string>("procedimiento").ToString();
            txtCodigoAdministradora.Text = dRows.Field<int>("IdContrato").ToString();
            txtAdministradora.Text = dRows.Field<string>("Nombre").ToString();
            dtFechaIngreso.Value = dRows.Field<DateTime>("FechaAdmision");
            ecocardiograma.idOrdenMedica = dRows.Field<int>("IdOrdenMedica");
            ecocardiograma.idProcedimiento = dRows.Field<int>("IdProcedimiento");
            ecocardiograma.idAreaAtencion= dRows.Field<int>("IdArea");
            cargarParametro();
        }
        private List<string> listaParametroOculto()
        {
            /*List<string> paramtro = new List<string>();

            paramtro.Add("idAtencion");
            paramtro.Add("IdOrdenMedica");
            paramtro.Add("IdContrato");
            paramtro.Add("Nombre");
            paramtro.Add("FechaAdmision");
            paramtro.Add("IdProcedimiento");
            paramtro.Add("IdArea");

            if (ecocardiograma.idEco != ConstanteGeneral.PREDETERMINADO)
            {
                paramtro.Add("idEco");
                paramtro.Add("Nota");
            }

            return paramtro;*/
            return null;
        }
        private void cargarEcocardiograma(DataRow dRows)
        {
            /*try
            {
                ecocardiograma.idEco = dRows.Field<int>("idEco");
                dtpFecha.Value = dRows.Field<DateTime>("Fecha Resultado");
                txtObservacion.Text = dRows.Field<string>("Nota").ToString();
                cargarInformacionAtencion(dRows);
                cargarParametroRegistrado();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            GeneralC.posBuscar(this, tstMenuPatron, tsbNuevo, tstModificar, tsbBuscar, tsbAnular, tstImprimir);
            btnSalir.Enabled = true;*/
        }

        #region btnSalir

        private void btnSalir_MouseHover(object sender, EventArgs e)
        {
            btnSalir.BackColor = Color.LightCoral;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Mensajes.SALIR_FORM, Mensajes.NOMBRE_SOFT, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Close();
            }
        }
        private void btnSalir_MouseLeave(object sender, EventArgs e)
        {
            btnSalir.BackColor = Control.DefaultBackColor;
        }


        #endregion

        private void validarGrilla() {
            dgvParametro.Columns[0].DataPropertyName = "idParametro";
            dgvParametro.Columns[1].DataPropertyName = "Descripcion";
            dgvParametro.Columns[2].DataPropertyName = "Resultado";
            dgvParametro.Columns[3].DataPropertyName = "Referencia";
            dgvParametro.DataSource = ecocardiograma.dtParametro;
            dgvParametro.AutoGenerateColumns = false;
        }

        private void cargarParametro() {
            /*List<string> paramtro = new List<string>();
            paramtro.Add(ecocardiograma.idAreaAtencion.ToString());
            ecocardiograma.dtParametro = GeneralC.cargarResultadosSQL(Sentencias.ECOCARDIOGRAMA_PARAMETROS_CARGAR, paramtro);
            dgvParametro.DataSource = ecocardiograma.dtParametro;*/
        }

        private void cargarParametroRegistrado()
        {
            /*List<string> paramtro = new List<string>();
            paramtro.Add(ecocardiograma.idEco.ToString());
            paramtro.Add(ecocardiograma.idAreaAtencion.ToString());
            paramtro.Add(ecocardiograma.auditoria.ToString());
            ecocardiograma.dtParametro = GeneralC.cargarResultadosSQL(Sentencias.CARGAR_PARAMETROS_ECOCARDIOGRAMA_REGISTRADO, paramtro);
            dgvParametro.DataSource = ecocardiograma.dtParametro;*/
        }

        private void editarRegistroGrilla() {
            dgvParametro.ReadOnly = false;
            dgvParametro.Columns[1].ReadOnly = true;
            dgvParametro.Columns[2].ReadOnly = false;
            dgvParametro.Columns[3].ReadOnly =  true;
        }
        private bool validarCampos() {

            if (txtIdentificacion.Text == string.Empty) {
                Mensajes.mensajeAdvertencia("¡ Favor cargar un paciente !");
            } else if (txtObservacion.Text == string.Empty) {
                Mensajes.mensajeAdvertencia("¡ Favor digitar la conclusión del resultado !");
            }  else {
                return true;
            }

            return false;
        }
    }
}
