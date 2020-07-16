using Entidad.HistoriaClinica.Resultado;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Vista.General;

namespace Vista.HistoriaClinica.Resultado
{
    public partial class InformeQuirurgicoUI : Form
    {
        InformeQuirurgico informeQx;
        private bool edicion = false;
        public InformeQuirurgicoUI()
        {
            InitializeComponent();
        }

        private void InformeQuirurgicoUI_Load(object sender, EventArgs e)
        {
            informeQx = new InformeQuirurgico();
            GeneralUI.deshabilitarBotones(ref tstMenuPatron);
            GeneralUI.deshabilitarControles(this);
            dtpFechaFin.Value = dtpFechaFin.Value.AddHours(+1);
            enlazarDgvProcedimiento();
            enlazarDgvMedicamento();
            tsbBuscar.Enabled = true;
            tsbNuevo.Enabled = true;
            btnSalir.Enabled = true;
        }

        private void tsbBuscarNit_Click(object sender, EventArgs e)
        {
            /*List<string> parametro = new List<string>();

            parametro.Add(informeQx.Auditoria.ToString());
            parametro.Add(string.Empty);

            try
            {
                GeneralC.buscarDevuelveFila(Sentencias.PACIENTE_INFORME_QX_BUSCAR,
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

        private void tsbNuevo_Click(object sender, EventArgs e)
        {

            /*GeneralC.deshabilitarBotones(ref tstMenuPatron);
            GeneralC.habilitarControles(this);

            GeneralC.deshabilitarControles(pnlInformacion);
            GeneralC.limpiarControles(this);

            desactivadoPermanentemente();

            informeQx.idInformeQX = ConstanteGeneral.PREDETERMINADO;
            tsbBuscarPaciente.Enabled = true;

            informeQx.dtProcedimiento.Rows.Add();
            informeQx.dtMedicamento.Rows.Add();

            edicion = true;
            tsbGuardar.Enabled = true;
            tsbCancelar.Enabled = true;*/

        }

        private void tstModificar_Click(object sender, EventArgs e)
        {
            /*if (Mensajes.preguntaSiNo(Mensajes.Modificar_FORM) == true)
            {
                GeneralC.deshabilitarBotones(ref tstMenuPatron);
                GeneralC.habilitarControles(this);

                GeneralC.deshabilitarControles(pnlInformacion);
                desactivadoPermanentemente();

                informeQx.dtProcedimiento.Rows.Add();
                informeQx.dtMedicamento.Rows.Add();

                edicion = true;

                tsbGuardar.Enabled = true;
                tsbCancelar.Enabled = true;
            }*/
        }

        private void tsbCancelar_Click(object sender, EventArgs e)
        {
            /*if (Mensajes.preguntaSiNo(Mensajes.CANCELAR_FORM) == true)
            {
                GeneralC.deshabilitarBotones(ref tstMenuPatron);
                GeneralC.deshabilitarControles(this);
                GeneralC.limpiarControles(this);
                edicion = false;
                informeQx.idInformeQX = ConstanteGeneral.PREDETERMINADO;

                tsbNuevo.Enabled = true;
                tsbBuscar.Enabled = true;
                btnSalir.Enabled = true;

            }*/
        }
        private void tsbGuardar_Click(object sender, EventArgs e)
        {
            /*if (validarCampos() == true)
            {
                if (Mensajes.preguntaGuardar())
                    try
                    {
                        crearNuevaInformeQx();

                        InformeQuirurgicoDAL.guardarInformeQuirurgico(informeQx);

                        GeneralC.habilitarBotones(ref tstMenuPatron);
                        GeneralC.deshabilitarControles(this);

                        cargarInformeQxMedicamento();
                        cargarInformeQxProcedimiento();

                        btnSalir.Enabled = true;
                        tsbGuardar.Enabled = false;
                        tsbCancelar.Enabled = false;

                        Mensajes.mensajeInformacion(Mensajes.CONFIRMACION_GUARDADO);

                    }
                    catch (Exception ex)
                    {
                        Mensajes.mensajeError(ex);
                    }
            }*/
        }

        private void tsbBuscar_Click(object sender, EventArgs e)
        {
            /*List<string> parametro = new List<string>();

            parametro.Add(informeQx.Auditoria.ToString());
            parametro.Add(string.Empty);
            try
            {
                GeneralC.buscarDevuelveFila(Sentencias.INFORME_QX_BUSCAR,
                                        parametro,
                                        new GeneralC.cargarInfoFila(cargarInformeQX),
                                        Titulos.TITULO_BUSCAR_INFORME_QX,
                                        true,
                                        listaParametroOculto());
            }
            catch (Exception ex) {
                Mensajes.mensajeError(ex);
            }*/
        }

        private void tsbAnular_Click(object sender, EventArgs e)
        {
            /*if (Mensajes.preguntaAnular())
            {
                try
                {

                    if (InformeQuirurgicoDAL.anularInformeQuirurgico(informeQx.idInformeQX,informeQx.Auditoria) == true)
                    {
                        GeneralC.deshabilitarBotones(ref tstMenuPatron);
                        GeneralC.limpiarControles(this);
                        GeneralC.deshabilitarControles(this);

                        btnSalir.Enabled = true;
                        tsbBuscar.Enabled = true;
                        tsbNuevo.Enabled = true;

                        Mensajes.mensajeInformacion(Mensajes.CONFIRMACION_ANULADO);
                    }

                }
                catch (Exception ex)
                {
                    Mensajes.mensajeError(ex);
                }
            }*/
        }

        private void tsbBuscarVia_Click(object sender, EventArgs e)
        {
            /*List<string> parametro = new List<string>();
            try
            {
                parametro.Add(ConstanteGeneral.VIA_ADMINISTRACION.ToString());
                parametro.Add(string.Empty);

                GeneralC.buscarDevuelveFila(Sentencias.PARAMETROS_CONSULTAR_DESCRIPCION,
                                        parametro,
                                        new GeneralC.cargarInfoFila(cargarVia),
                                        Titulos.TITULO_BUSCAR_VIA,
                                        true);
            }
            catch (Exception ex) {
                Mensajes.mensajeError(ex);
            }*/
        }

        private void tsbBuscarAyudante_Click(object sender, EventArgs e)
        {
           /* List<string> parametro = new List<string>();
            parametro.Add(string.Empty);

            GeneralC.buscarDevuelveFila(Sentencias.EMPLEADO_CARGO_BUSCAR,
                                    parametro,
                                    new GeneralC.cargarInfoFila(cargarAyudante),
                                    Titulos.TITULO_BUSCAR_AYUDANTE,
                                    true);*/
        }

        private void tsbBuscarAnastesiologo_Click(object sender, EventArgs e)
        {
           /* List<string> parametro = new List<string>();
            parametro.Add(string.Empty);

            GeneralC.buscarDevuelveFila(Sentencias.EMPLEADO_CARGO_BUSCAR,
                                    parametro,
                                    new GeneralC.cargarInfoFila(cargarAnastesiologo),
                                    Titulos.TITULO_BUSCAR_ANASTESIOLOGO,
                                    true);*/
        }

        private void tsbBuscarAnastesia_Click(object sender, EventArgs e)
        {
            /*List<string> parametro = new List<string>();
            parametro.Add(string.Empty);

            GeneralC.buscarDevuelveFila(Sentencias.INFORME_QX_MEDICAMENTO_ANASTESIA,
                                    parametro,
                                    new GeneralC.cargarInfoFila(cargarAnastesia),
                                    Titulos.TITULO_BUSCAR_ANASTESIA,
                                    true);*/
        }

        #region btnSalir

        private void btnSalir_MouseHover(object sender, EventArgs e)
        {
            btnSalir.BackColor = Color.LightCoral;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            /*if (MessageBox.Show(Mensajes.SALIR_FORM, Mensajes.NOMBRE_SOFT, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Close();
            }*/
        }
        private void btnSalir_MouseLeave(object sender, EventArgs e)
        {
            btnSalir.BackColor = Control.DefaultBackColor;
        }
        #endregion

        private void cargarInformacionAtencion(DataRow dRows) {
            txtAtencion.Text = dRows.Field<int>("idAtencion").ToString();
            txtPaciente.Text = dRows.Field<string>("paciente").ToString();
            txtIdentificacion.Text = dRows.Field<string>("Documento").ToString();
            txtServicio.Text = dRows.Field<string>("Entorno").ToString();
            txtOrdenMedica.Text = dRows.Field<int>("IdOrdenMedica").ToString();
            txtProcedimiento.Text = dRows.Field<string>("procedimiento").ToString();
            txtCodigoAdministradora.Text = dRows.Field<int>("IdContrato").ToString();
            txtAdministradora.Text = dRows.Field<string>("Nombre").ToString();
            dtFecha.Value= dRows.Field<DateTime>("FechaAdmision");
            informeQx.idOrdenMedica= dRows.Field<int>("IdOrdenMedica");
            informeQx.idProcedimiento = dRows.Field<int>("IdProcedimiento");
        }

        private void crearNuevaInformeQx() {
            informeQx.notaQuirurgica = txtNota.Text;
            informeQx.fechaInicio = dtpFechaInicio.Value;
            informeQx.fechaFin = dtpFechaFin.Value;
        }
        private void cargarInformeQX(DataRow dRows)
        {
            try
            {
                informeQx.idInformeQX = dRows.Field<int>("idInformeQX");
                informeQx.idVia = dRows.Field<int>("idVia");
                informeQx.idAnastesia = dRows.Field<int>("idAnastesia");
                informeQx.idAnastesiologo = dRows.Field<int>("idAnastesiologo");
                informeQx.idAyudante = dRows.Field<int>("idAyudante");

                txtAyudante.Text = dRows.Field<string>("Ayudante");
                txtVia.Text= dRows.Field<string>("Via");
                txtAnastesia.Text = dRows.Field<string>("Anastesia");
                txtAnastesiologo.Text = dRows.Field<string>("Anastesiologo");
                txtNota.Text= dRows.Field<string>("Nota");

                informeQx.fechaInicio = dRows.Field<DateTime>("Fecha Informe");
                informeQx.fechaFin = dRows.Field<DateTime>("FechaFin");
              
                          
                cargarInformacionAtencion(dRows);
                cargarInformeQxMedicamento();
                cargarInformeQxProcedimiento();

                GeneralUI.posBuscar(this, tstMenuPatron, tsbNuevo, tstModificar, tsbBuscar, tsbAnular);
                btnSalir.Enabled = true;

            }
            catch (Exception ex)
            {
               //Mensajes.mensajeError(ex);
            }        
        }

        private List<string> listaParametroOculto()
        {
            /* List<string> paramtro = new List<string>();

             paramtro.Add("idAtencion");
             paramtro.Add("IdOrdenMedica");
             paramtro.Add("IdProcedimiento");
             paramtro.Add("IdContrato");
             paramtro.Add("Nombre");
             paramtro.Add("FechaAdmision");

             if (informeQx.idInformeQX != ConstanteGeneral.PREDETERMINADO) {  
                 paramtro.Add("idInformeQX");
                 paramtro.Add("idVia");
                 paramtro.Add("idAnastesia");
                 paramtro.Add("idAnastesiologo");
                 paramtro.Add("idAyudante");
                 paramtro.Add("Via");
                 paramtro.Add("Anastesia");
                 paramtro.Add("Anastesiologo");
                 paramtro.Add("Ayudante");
                 paramtro.Add("FechaFin");
                 paramtro.Add("Nota");
             }

             return paramtro;*/
            return null;
        }
        private bool validarCampos()
        {
            /* if (txtAtencion.Text == string.Empty)
             {
                 Mensajes.mensajeAdvertencia("¡ Favor seleccionar el paciente !");
                 return false;
             }
             else if (txtNota.Text == string.Empty)
             {
                 Mensajes.mensajeAdvertencia("¡ Favor realice la nota correspondiente al resultado !");
                 return false;
             }
             else if (informeQx.idVia == ConstanteGeneral.SIN_VALOR_NUMERICO)
             {
                 Mensajes.mensajeAdvertencia("¡ Favor seleccionar una via !");
                 return false;
             }
             else if (informeQx.idAnastesia == ConstanteGeneral.SIN_VALOR_NUMERICO)
             {
                 Mensajes.mensajeAdvertencia("¡ Favor seleccionar una anastesia !");
                 return false;
             }
             else if (informeQx.idAyudante == ConstanteGeneral.SIN_VALOR_NUMERICO)
             {
                 Mensajes.mensajeAdvertencia("¡ Favor seleccionar un ayudante !");
                 return false;
             }
             else if (dtpFechaInicio.Value > dtpFechaFin.Value)
             {
                 Mensajes.mensajeAdvertencia("¡ la fecha inicio debe ser menor a la fecha fin !");
                 return false;
             }
             else
             {
                 return true;
             }*/
            return false;
        }
        private void cargarVia(DataRow dRows) {
            informeQx.idVia = dRows.Field<int>("codigo");
            txtVia.Text = dRows.Field<string>("Descripcion");
        }
        private void cargarAyudante(DataRow dRows)
        {
            informeQx.idAyudante = dRows.Field<int>("Codigo");
            txtAyudante.Text = dRows.Field<string>("Nombre");
        }
        private void cargarAnastesiologo(DataRow dRows)
        {
            informeQx.idAnastesiologo = dRows.Field<int>("Codigo");
            txtAnastesiologo.Text = dRows.Field<string>("Nombre");
        }
        private void cargarAnastesia(DataRow dRows)
        {
            informeQx.idAnastesia = dRows.Field<int>("codigo");
            txtAnastesia.Text = dRows.Field<string>("descripcion");
        }
        private void desactivadoPermanentemente() {
            txtAyudante.ReadOnly = true;
            txtVia.ReadOnly = true;
            txtAnastesia.ReadOnly = true;
            txtAnastesiologo.ReadOnly = true;
        }

       #region tabProcedimiento
        public void enlazarDgvProcedimiento()
        {
                dgvProcedimientos.AutoGenerateColumns = false;
                dgvProcedimientos.Columns["cups"].DataPropertyName = "cups";
                dgvProcedimientos.Columns["descripcion"].DataPropertyName = "descripcion";
                dgvProcedimientos.Columns["cantidad"].DataPropertyName = "cantidad";
                dgvProcedimientos.Columns["justificacion"].DataPropertyName = "Observacion";
                dgvProcedimientos.DataSource = informeQx.dtProcedimiento;
        }
        void cargarProcedimiento(DataRow filaResultado)
        {
            DataRowCollection filas = informeQx.dtProcedimiento.Rows;
            int cantidad = filas.Count - 1;
            filas[cantidad]["idProcedimiento"] = filaResultado.Field<int>("ID");
            filas[cantidad]["cups"] = filaResultado.Field<string>("Código");
            filas[cantidad]["descripcion"] = filaResultado.Field<string>("Descripción");
            filas[cantidad]["cantidad"] = 1;
            filas.Add();
        }
        private void cargarInformeQxProcedimiento()
        {
           /* List<string> paramtro = new List<string>();
            paramtro.Add(informeQx.Auditoria.ToString());
            paramtro.Add(informeQx.idInformeQX.ToString());
            informeQx.dtProcedimiento = GeneralC.cargarResultadosSQL(Sentencias.CARGAR_INFORME_QX_PROCEDIMIENTO, paramtro);
            dgvProcedimientos.DataSource = informeQx.dtProcedimiento;*/
        }
        private void dgvProcedimientos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           /* if (txtAtencion.Text != string.Empty)
            {
                if (e.RowIndex >= 0)
                {
                    GeneralUI.deshabilitarColumnas(dgvProcedimientos);
                    if (edicion)
                    {
                        dgvProcedimientos.Columns["cantidad"].ReadOnly = false;
                        if (GeneralUI.verificarUbicacionCelda(e, dgvProcedimientos, "quitar") & e.RowIndex < dgvProcedimientos.Rows.Count - 1)
                        {
                            if (Mensajes.preguntaAnular())
                            {
                                dgvProcedimientos.Rows.RemoveAt(e.RowIndex);
                            }
                        }
                        else if (GeneralC.verificarUbicacionCelda(e, dgvProcedimientos, "agregar") & e.RowIndex == dgvProcedimientos.Rows.Count - 1)
                        {
                            try
                            {
                                List<string> parametros = new List<string>();

                                DataTable tablaParametros = new DataTable();
                                DataTable tablasSeleccionado = new DataTable();

                                tablaParametros.Columns.Add("Parametro", Type.GetType("System.Object"));
                                tablaParametros.Columns.Add("Valor", Type.GetType("System.Object"));

                                object[] myObjArray = { "@pIdAtencion", txtAtencion.Text };
                                object[] myObjArray1 = { "@pFiltro", "" };

                                DataView view = new DataView(informeQx.dtProcedimiento);

                                tablasSeleccionado = view.ToTable(true, new string[] { "idProcedimiento" }).Copy();
                                tablasSeleccionado.Columns.Add("valor");
                                tablasSeleccionado.Rows.RemoveAt(tablasSeleccionado.Rows.Count - 1);
                                object[] myObjArray2 = { "@pTblSeleccionados", tablasSeleccionado };

                                tablaParametros.Rows.Add(myObjArray);
                                tablaParametros.Rows.Add(myObjArray1);
                                tablaParametros.Rows.Add(myObjArray2);

                                GeneralC.buscarDevuelveFila(Sentencias.ORDEN_CLINICA_BUSCAR_PROCEDIMIENTOS,
                                                            parametros,
                                                            new GeneralC.cargarInfoFila(cargarProcedimiento),
                                                            Mensajes.BUSQUEDA_PROCEDIMIENTOS,
                                                            true,
                                                            null,
                                                            tablasSeleccionado,
                                                            tablaParametros);
                            }
                            catch (Exception ex)
                            {
                                Mensajes.mensajeError(ex);
                            }
                        }
                    }
                    abrirObservacion();
                }
            }

            else {

                Mensajes.mensajeAdvertencia("Favor Cargar los datos del paciente");
            }*/
        }
        private void abrirObservacion()
        {
            GeneralUI.abrirVentanaEntradaDatos(ref dgvProcedimientos,
                                              "Justificación",
                                              "cups",
                                              edicion);
        }
         private void dgvProcedimientos_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (string.IsNullOrEmpty(dgvProcedimientos.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()))
            {
                dgvProcedimientos.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = 0;
            }
        }
        private void dgvProcedimientos_KeyPress(object sender, KeyPressEventArgs e)
        {
            abrirObservacion();
        }
       private void dgvProcedimientos_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            dgvProcedimientos.CancelEdit();
            Mensajes.mensajeInformacion(Mensajes.CANTIDAD_INVALIDA);
        }

        #endregion

       #region tabMedicamento
        public void enlazarDgvMedicamento()
        {
            dgvMedicamento.AutoGenerateColumns = false;
            dgvMedicamento.Columns["codigoMed"].DataPropertyName = "idMedicamento";
            dgvMedicamento.Columns["descripcionMed"].DataPropertyName = "descripcion";
            dgvMedicamento.Columns["cantidadMed"].DataPropertyName = "cantidad";
            dgvMedicamento.DataSource = informeQx.dtMedicamento;
        }
        void cargarMedicamento(DataRow filaResultado)
        {
            DataRowCollection filas = informeQx.dtMedicamento.Rows;
            int cantidad = filas.Count - 1;
            filas[cantidad]["idMedicamento"] = filaResultado.Field<int>("Codigo");
            filas[cantidad]["descripcion"] = filaResultado.Field<string>("Descripcion");
            filas[cantidad]["cantidad"] = 1;
            filas.Add();
        }
        private void cargarInformeQxMedicamento()
        {
           /* List<string> paramtro = new List<string>();
            paramtro.Add(informeQx.Auditoria.ToString());
            paramtro.Add(informeQx.idInformeQX.ToString());
            informeQx.dtMedicamento = GeneralC.cargarResultadosSQL(Sentencias.CARGAR_INFORME_QX_MEDICAMENTO, paramtro);
            dgvMedicamento.DataSource = informeQx.dtMedicamento;*/
        }

        private void dgvMedicamento_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           /* if (txtAtencion.Text != string.Empty)
            {
                if (e.RowIndex >= 0)
                {
                    GeneralC.deshabilitarColumnas(dgvMedicamento);
                    if (edicion)
                    {
                        dgvMedicamento.Columns["cantidadMed"].ReadOnly = false;
                        if (GeneralC.verificarUbicacionCelda(e, dgvMedicamento, "quitarMed") & e.RowIndex < dgvMedicamento.Rows.Count - 1)
                        {
                            if (Mensajes.preguntaAnular())
                            {
                                dgvMedicamento.Rows.RemoveAt(e.RowIndex);
                            }
                        }
                        else if (GeneralC.verificarUbicacionCelda(e, dgvMedicamento, "agregarMed") & e.RowIndex == dgvMedicamento.Rows.Count - 1)
                        {
                            try
                            {
                                List<string> parametros = new List<string>();

                                DataTable tablaParametros = new DataTable();
                                DataTable tablasSeleccionado = new DataTable();

                                tablaParametros.Columns.Add("Parametro", Type.GetType("System.Object"));
                                tablaParametros.Columns.Add("Valor", Type.GetType("System.Object"));
     
                                object[] myObjArray1 = { "@pFiltro", "" };

                                DataView view = new DataView(informeQx.dtMedicamento);

                                tablasSeleccionado = view.ToTable(true, new string[] { "idMedicamento" }).Copy();
                                tablasSeleccionado.Columns.Add("valor");
                                tablasSeleccionado.Rows.RemoveAt(tablasSeleccionado.Rows.Count - 1);
                                object[] myObjArray2 = { "@pTblSeleccionados", tablasSeleccionado };

                                tablaParametros.Rows.Add(myObjArray1);
                                tablaParametros.Rows.Add(myObjArray2);

                                GeneralC.buscarDevuelveFila(Sentencias.LISTAR_MEDICAMENTOS,
                                                            parametros,
                                                            new GeneralC.cargarInfoFila(cargarMedicamento),
                                                            Mensajes.BUSQUEDA_EQUIVALENCIA,
                                                            true,
                                                            null,
                                                            tablasSeleccionado,
                                                            tablaParametros);
                            }
                            catch (Exception ex)
                            {
                                Mensajes.mensajeError(ex);
                            }
                        }
                    }
                }
            }
            else
            {
                Mensajes.mensajeAdvertencia("Favor Cargar los datos del paciente");
            }*/
        }
        private void dgvMedicamento_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            dgvMedicamento.CancelEdit();
            Mensajes.mensajeInformacion(Mensajes.CANTIDAD_INVALIDA);
        }
        private void dgvMedicamento_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (string.IsNullOrEmpty(dgvMedicamento.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()))
            {
                dgvMedicamento.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = 0;
            }
        }
        #endregion

       
    }
}
