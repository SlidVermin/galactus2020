using Entidad.HistoriaClinica.OrdenMedica;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Vista.General;

namespace Vista.HistoriaClinica.OrdenMedica
{
    public partial class OrdenMedicaUI : Form
    {

        private int idAtencion;
        private OrdenClinica ordenClinica = new OrdenClinica();
        private IndicacionesUI indicacionesUI = new IndicacionesUI();
        private OxigenoUI oxigenoUI = new OxigenoUI();
        private ProcedimientosUI procedimientosUI = new ProcedimientosUI();
        private MedicamentosUI medicamentosUI = new MedicamentosUI();
        private InfusionImpregnacionUI infusionImpregnacionUI = new InfusionImpregnacionUI();
        public int accionOrden;
        #region "Conctrutores"
        public OrdenMedicaUI()
        {
            InitializeComponent();
        }
        public OrdenMedicaUI(int idAtencion, bool auditoria)
        {
            InitializeComponent();
            this.idAtencion = idAtencion;
            ordenClinica.idAtencion = idAtencion;
            ordenClinica.auditoria = auditoria;
            indicacionesUI.indicacion = ordenClinica.indicacion;
            procedimientosUI.idAtencion = idAtencion;
            procedimientosUI.procedimientos = ordenClinica.procedimiento;
            medicamentosUI.idAtencion = idAtencion;
            medicamentosUI.auditoria = auditoria;
            medicamentosUI.medicamentos = ordenClinica.medicamento;
            infusionImpregnacionUI.idAtencion = idAtencion;
            infusionImpregnacionUI.auditoria = auditoria;
            infusionImpregnacionUI.medicamentos = ordenClinica.medicamento;
            oxigenoUI.idAtencion = idAtencion;
            oxigenoUI.oxigeno = ordenClinica.oxigeno;
        }
        #endregion

        private void OrdenMedicaUI_Load(object sender, EventArgs e)
        {
            GeneralUI.cargarFormularioEnPestana(tpIndicaciones, indicacionesUI);
            GeneralUI.cargarFormularioEnPestana(tpOxigeno, oxigenoUI);
            GeneralUI.cargarFormularioEnPestana(tbProcedimientos, procedimientosUI);
            GeneralUI.cargarFormularioEnPestana(tpMedicamentos, medicamentosUI);
            GeneralUI.cargarFormularioEnPestana(tpInfusionImpregnacion, infusionImpregnacionUI);
            GeneralUI.posCargadoForm(this, tstMenuOrdenMedica, tsBtNuevo, tsBtBuscar);
        }
        #region "Botones"
        private void tsBtNuevo_Click(object sender, EventArgs e)
        {

            /*GeneralUI.formNuevo(this, tstMenuOrdenMedica, tsBtGuardar, tsBtCancelar);
            ordenClinica.nuevaOrden();
            crearOrden(ordenClinica);
            txtBCodigoOrden.ReadOnly = true;
            procedimientosUI.enlazarDgv();
            oxigenoUI.enlazarDgv();
            medicamentosUI.enlazarDgv();
            infusionImpregnacionUI.enlazarDgv();
            activarEdicion();  */         
        }
        void activarEdicion()
        {
            indicacionesUI.edicion = true;
            procedimientosUI.edicion = true;
            oxigenoUI.edicion = true;
            infusionImpregnacionUI.edicion = true;
            medicamentosUI.edicion = true;
            indicacionesUI.txtIndicaciones.ReadOnly = false;
        }
        void desactivarEdicion()
        {
            indicacionesUI.edicion = false;
            procedimientosUI.edicion = false;
            medicamentosUI.edicion = false;
            oxigenoUI.edicion = false;
            infusionImpregnacionUI.edicion = false;
        }

        private void tsBtBuscar_Click(object sender, EventArgs e)
        {
            /*try
            {
                List<string> parametros = new List<string>();
                parametros.Add(ordenClinica.auditoria.ToString());
                parametros.Add(ordenClinica.idAtencion.ToString());
                parametros.Add(string.Empty);
                GeneralC.buscarDevuelveFila(Sentencias.ORDEN_CLINICA_BUSCAR,
                                            parametros,
                                            new GeneralC.cargarInfoFila(cargarOrdenClinica),
                                            Mensajes.BUSQUEDA_ORDENES_MEDICAS,
                                            true);
            }
            catch (Exception ex)
            {
                Mensajes.mensajeError(ex);
            }*/
        }
        private void tsBtModificar_Click(object sender, EventArgs e)
        {
           /* GeneralC.fnModificarForm(this, tstMenuOrdenMedica, tsBtGuardar, tsBtCancelar);
            txtBCodigoOrden.ReadOnly = true;
            ordenClinica.agregarFila();
            activarEdicion();*/
        }
        private void tsBtGuardar_Click(object sender, EventArgs e)
        {
            /*oxigenoUI.dgvOrdenOxigeno.EndEdit();
            ordenClinica.oxigeno.tblOxigeno.AcceptChanges();
            procedimientosUI.dgvProcedimientos.EndEdit();
            ordenClinica.procedimiento.tblProcedimientos.AcceptChanges();
            medicamentosUI.dgvOrdenMedicamentos.EndEdit();
            ordenClinica.medicamento.tblMedicamentos.AcceptChanges();
            infusionImpregnacionUI.dgvOrdenInfusionImpregnacion.EndEdit();
            ordenClinica.medicamento.tblInfusionImpregnacion.AcceptChanges();
            if (validarDatos() && Mensajes.preguntaGuardar())
            {
                try
                {
                    crearOrden(ordenClinica);
                    ordenClinica.oxigeno.prepararDT();
                    ordenClinica.medicamento.prepararDT();
                    OrdenClinicaDAL.guardarOrdenMedica(ordenClinica);
                    GeneralC.posGuardar(this, tstMenuOrdenMedica, tsBtNuevo, tsBtModificar, tsBtBuscar, tsBtAnular, null, Mensajes.CONFIRMACION_GUARDADO);
                    desactivarEdicion();
                    ordenClinica.medicamento.tblMedicamentos.Rows.RemoveAt(ordenClinica.medicamento.tblMedicamentos.Rows.Count - 1);
                    ordenClinica.medicamento.tblInfusionImpregnacion.Rows.RemoveAt(ordenClinica.medicamento.tblInfusionImpregnacion.Rows.Count - 1);
                    ordenClinica.procedimiento.tblProcedimientos.Rows.RemoveAt(ordenClinica.procedimiento.tblProcedimientos.Rows.Count - 1);
                    medicamentosUI.dgvOrdenMedicamentos.Columns["idMedicamento"].Visible = false;
                    infusionImpregnacionUI.dgvOrdenInfusionImpregnacion.Columns["idMedicamento"].Visible = false;
                    txtBCodigoOrden.Text = Convert.ToString(ordenClinica.idOrden);
                }
                catch (Exception ex)
                {
                    Mensajes.mensajeError(ex);
                }
            }*/
        }

        private void tsBtCancelar_Click(object sender, EventArgs e)
        {
            GeneralUI.fnCancelarForm(this, tstMenuOrdenMedica, tsBtNuevo, tsBtBuscar);
        }
        private void tsBtAnular_Click(object sender, EventArgs e)
        {
           /* if (Mensajes.preguntaAnular())
            {
                try
                {
                    OrdenClinicaDAL.anularOrdenMedica(ordenClinica);
                    
                    GeneralC.posAnular(this, tstMenuOrdenMedica, tsBtNuevo, tsBtBuscar, Mensajes.CONFIRMACION_ANULADO);
                    ordenClinica.nuevaOrden();
                    desactivarEdicion();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }*/
        }
        #endregion
        #region "Metodos y Funciones"
        void crearOrden(OrdenClinica ordenClinica)
        {
            ordenClinica.fechaOrden = DateTime.Parse(dtpFecha.Text);
            medicamentosUI.fecha = ordenClinica.fechaOrden;
            infusionImpregnacionUI.fecha = ordenClinica.fechaOrden;
        }
        bool validarDatos()
        {

            return (GeneralUI.validarSeleccion(ordenClinica.medicamento.tblMedicamentos, "Via admin.", true, " - Via admin. ") &&
                    GeneralUI.validarCantidad(ordenClinica.procedimiento.tblProcedimientos, "Cantidad", true, " - Procedimientos") &&
                    GeneralUI.validarCantidad(ordenClinica.medicamento.tblMedicamentos, "Dosis", true, " - Dosis Medicamentos") &&
                    GeneralUI.validarSeleccion(ordenClinica.medicamento.tblMedicamentos, "Horario", true, " - Horario ") &&
                    GeneralUI.validarCantidad(ordenClinica.medicamento.tblInfusionImpregnacion, "Dosis", true, " - Dosis infusión o impregnación") &&
                    GeneralUI.validarCantidad(ordenClinica.medicamento.tblInfusionImpregnacion, "cc/hora", true, " - cc/hora") &&
                    validarOxigeno() &&
                    validarDisolvente());
        }
        private bool validarOxigeno()
        {
            /* DataTable dtOxigeno;
             dtOxigeno = GeneralUI.copiarTablaCondicional(ordenClinica.oxigeno.tblOxigeno, "idOxigeno is not null");

             if (GeneralUI.copiarTablaCondicional(dtOxigeno, "[Suspender]=False or [Suspender] is null").Select().Count() > 1 ||
                 GeneralUI.copiarTablaCondicional(dtOxigeno, "[Suspender]=True ").Select().Count() > 1)
             {
                 Mensajes.mensajeInformacion(Mensajes.VALOR_INCORRECTO + " - Oxígeno");
                 return false;
             }
             else
             {
                 return true;
             }*/
            return false;
        }

        private bool validarDisolvente()
        {
            /*DataTable dtImpregnacion;
            dtImpregnacion = GeneralUI.copiarTablaCondicional(ordenClinica.medicamento.tblInfusionImpregnacion, "tipoMedicamento='" + ConstanteGeneral.IMPREGNACION + "'");

            if (GeneralUI.copiarTablaCondicional(dtImpregnacion, "(Disolvente<>'" + ConstanteGeneral.POR_DEFINIR + "' and ([Cantidad] = 0 or[Cantidad] is null)) ").Select().Count() > 0 ||
                GeneralUI.copiarTablaCondicional(dtImpregnacion, "(Disolvente='" + ConstanteGeneral.POR_DEFINIR + "' and [Cantidad] > 0 and[Cantidad] is not null)").Select().Count() > 0)
            {
                Mensajes.mensajeInformacion(Mensajes.VALOR_INCORRECTO + " - Disolvente impregnación");
                return false;
            }
            else
            {
                return true;
            }*/
            return false;
        }

      
        void cargarOrdenClinica(DataRow filaResultado)
        {
           /* if (filaResultado != null)
            {
                ordenClinica.idOrden = filaResultado.Field<int>("Código Orden");
                txtBCodigoOrden.Text = ordenClinica.idOrden.ToString();
                dtpFecha.Text = filaResultado.Field<DateTime>("Fecha").ToString();

                DataSet tablasResultados = new DataSet();
                List<string> Parametros = new List<string>();
                Parametros.Add(ordenClinica.auditoria.ToString());
                Parametros.Add(ordenClinica.idOrden.ToString());
                tablasResultados = GeneralC.llenarDataset(Sentencias.ORDEN_CLINICA_CARGAR, Parametros);
                if (tablasResultados.Tables.Count > 0)
                {
                    ordenClinica.indicacion.indicacion = tablasResultados.Tables[0].Rows[0].Field<string>(0);
                }
                indicacionesUI.indicacion = ordenClinica.indicacion;
                indicacionesUI.visualizarIndicacionCargada();

                oxigenoUI.oxigeno.tblOxigeno.Clear();
                oxigenoUI.oxigeno.tblOxigeno = tablasResultados.Tables["Table1"].Copy();
                oxigenoUI.enlazarDgv();

                medicamentosUI.medicamentos.tblMedicamentos.Clear();
                medicamentosUI.medicamentos.tblMedicamentos = GeneralC.copiarTablaCondicional(tablasResultados.Tables["Table2"].Copy(), "tipoMedicamento='M'");
                medicamentosUI.medicamentos.tblMedicamentos.Columns.Remove("cc/hora");
                medicamentosUI.medicamentos.tblMedicamentos.Columns.Remove("idEquivalenciaDisolvente");
                medicamentosUI.medicamentos.tblMedicamentos.Columns.Remove("Disolvente");
                medicamentosUI.medicamentos.tblMedicamentos.Columns.Remove("Cantidad");
                medicamentosUI.medicamentos.tblMedicamentos.Columns.Remove("Tipo");
                medicamentosUI.medicamentos.tblMedicamentos.Columns.Remove("Acepta disolvente");
                medicamentosUI.medicamentos.homologarHorario();                

                infusionImpregnacionUI.medicamentos.tblInfusionImpregnacion = GeneralC.copiarTablaCondicional(tablasResultados.Tables["Table2"].Copy(), "tipoMedicamento in ('In','Im')");
                infusionImpregnacionUI.medicamentos.tblMezcla = tablasResultados.Tables["Table3"].Copy();
                infusionImpregnacionUI.medicamentos.tblInfusionImpregnacion.Columns.Remove("idViaAdmon");
                infusionImpregnacionUI.medicamentos.tblInfusionImpregnacion.Columns.Remove("Via admin.");
                infusionImpregnacionUI.medicamentos.tblInfusionImpregnacion.Columns.Remove("Horario");
                infusionImpregnacionUI.medicamentos.tblInfusionImpregnacion.Columns.Add("Mezcla");

                medicamentosUI.enlazarDgv();
                infusionImpregnacionUI.enlazarDgv();

                procedimientosUI.procedimientos.tblProcedimientos.Clear();
                procedimientosUI.procedimientos.tblProcedimientos = tablasResultados.Tables["Table4"].Copy();
                procedimientosUI.enlazarDgv();
                infusionImpregnacionUI.verificarMezcla();
                GeneralC.posBuscar(this, tstMenuOrdenMedica, tsBtNuevo, tsBtBuscar, tsBtModificar, tsBtAnular);
            }*/
        }


        #endregion

        private void tcOrdenMedica_SelectedIndexChanged(object sender, EventArgs e)
        {
            infusionImpregnacionUI.verificarMezcla();
        }
    }
}
