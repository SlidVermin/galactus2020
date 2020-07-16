using Entidad.HistoriaClinica.OrdenMedica;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Vista.General;

namespace Vista.HistoriaClinica.OrdenMedica
{
    public partial class MedicamentosUI : Form
    {
        public bool edicion = false;
        public bool auditoria { get; set; }
        public int idAtencion { get; set; }
        public DateTime fecha { get; set; }
        public OrdenClinicaMedicamento medicamentos { get; set; }
        public MedicamentosUI()
        {
            InitializeComponent();
        }

        private void MedicamentosUI_Load(object sender, EventArgs e)
        {
            inicializarForm();
        }
        void inicializarForm()
        {
            enlazarDgv();
        }
        public void enlazarDgv()
        {
            if (medicamentos != null)
            {
                dgvOrdenMedicamentos.AutoGenerateColumns = false;
                dgvOrdenMedicamentos.DataSource = medicamentos.tblMedicamentos;
            }
        }
        void cargarMedicamento(DataRow filaResultado)
        {
            /*DataRowCollection filas = medicamentos.tblMedicamentos.Rows;
            int cantidad = filas.Count - 1;
            filas[cantidad]["idEquivalencia"] = filaResultado.Field<int>("ID");
            filas[cantidad]["Descripción"] = filaResultado.Field<string>("Descripción");
            filas[cantidad]["Unidad"] = filaResultado.Field<string>("Unidad");
            filas[cantidad]["TipoMedicamento"] = ConstanteGeneral.MEDICAMENTO;
            filas[cantidad]["Dosis"] = 0;
            filas[cantidad]["Horario"] = ConstanteGeneral.POR_DEFINIR;
            filas[cantidad]["Hora Inicial"] = ConstanteGeneral.POR_DEFINIR;
            filas[cantidad]["Via admin."] = ConstanteGeneral.POR_DEFINIR;
            filas[cantidad]["idMedicamento"] = medicamentos.obtenerConsecutivo();
            filas.Add();
            dgvOrdenMedicamentos.Columns["idMedicamento"].Visible = false;*/
        }
        void cargarVia(DataRow filaResultado)
        {
            int fila = dgvOrdenMedicamentos.CurrentCell.RowIndex;
            medicamentos.tblMedicamentos.Rows[fila]["idViaAdmon"] = filaResultado.Field<int>("Código");
            medicamentos.tblMedicamentos.Rows[fila]["Via admin."] = filaResultado.Field<string>("Descripción");

        }
        private void dgvOrdenMedicamentos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex >= 0)
            {
                GeneralUI.deshabilitarColumnas(dgvOrdenMedicamentos);
                if (edicion)
                {
                    dgvOrdenMedicamentos.Columns["Dosis"].ReadOnly = false;
                    dgvOrdenMedicamentos.Columns["Horario"].ReadOnly = false;
                    dgvOrdenMedicamentos.Columns["HoraInicial"].ReadOnly = false;
                    dgvOrdenMedicamentos.Columns["Suspender"].ReadOnly = false;
                    if (GeneralUI.verificarUbicacionCelda(e, dgvOrdenMedicamentos, "quitar") & e.RowIndex < dgvOrdenMedicamentos.Rows.Count - 1)
                    {
                        if (Mensajes.preguntaAnular())
                        {
                            dgvOrdenMedicamentos.Rows.RemoveAt(e.RowIndex);
                        }
                    }
                    else if (GeneralUI.verificarUbicacionCelda(e, dgvOrdenMedicamentos, "agregar") & e.RowIndex == dgvOrdenMedicamentos.Rows.Count - 1)
                    {
                        agregarMedicamento();
                    }
                    else if (GeneralUI.verificarUbicacionCelda(e, dgvOrdenMedicamentos, "viaAdmin") & e.RowIndex != dgvOrdenMedicamentos.Rows.Count - 1)
                    {
                        agregarVia();
                    }
                }
            }
        }
       
        

        /// <summary>
        /// Agrega nuevos medicamentos teniendo encuenta los que ya estan seleccionados
        /// </summary>
        void agregarMedicamento() {
            /*try
            {
                List<string> parametros = new List<string>();

                DataTable tablaParametros = new DataTable();
                DataTable tablasSeleccionado = new DataTable();

                tablaParametros.Columns.Add("Parametro", Type.GetType("System.Object"));
                tablaParametros.Columns.Add("Valor", Type.GetType("System.Object"));

                object[] myObjArray = { "@pAuditoria", auditoria };
                object[] myObjArray1 = { "@pIdAtencion", idAtencion };
                object[] myObjArray2 = { "@pFechaOrden", fecha };
                object[] myObjArray3 = { "@pFiltro", "" };

                DataView view = new DataView(medicamentos.tblMedicamentos);

                tablasSeleccionado = view.ToTable(true, new string[] { "idEquivalencia" }).Copy();
                tablasSeleccionado.Rows.RemoveAt(tablasSeleccionado.Rows.Count - 1);
                object[] myObjArray4 = { "@pTblSeleccionados", tablasSeleccionado };

                tablaParametros.Rows.Add(myObjArray);
                tablaParametros.Rows.Add(myObjArray1);  
                tablaParametros.Rows.Add(myObjArray2);
                tablaParametros.Rows.Add(myObjArray3);
                tablaParametros.Rows.Add(myObjArray4);

                GeneralUI.buscarDevuelveFila(Sentencias.ORDEN_CLINICA_BUSCAR_MEDICAMENTOS,
                                            parametros,
                                            new GeneralUI.cargarInfoFila(cargarMedicamento),
                                            Mensajes.BUSQUEDA_EQUIVALENCIA,
                                            true,
                                            null,
                                            tablasSeleccionado,
                                            tablaParametros);
            }
            catch (Exception ex)
            {
                Mensajes.mensajeError(ex);
            }*/
        }
        void agregarVia()
        {
            /*try
            {
                List<string> parametros = new List<string>();

                DataTable tablaParametros = new DataTable();
                DataTable tablasSeleccionado = new DataTable();
                int idEquivalencia;
                idEquivalencia = (int)dgvOrdenMedicamentos.Rows[dgvOrdenMedicamentos.CurrentCell.RowIndex].Cells["idEquivalencia"].Value;
                tablaParametros.Columns.Add("Parametro", Type.GetType("System.Object"));
                tablaParametros.Columns.Add("Valor", Type.GetType("System.Object"));

                object[] myObjArray = { "@pIdEquivalencia", idEquivalencia };

                tablaParametros.Rows.Add(myObjArray);

                GeneralUI.buscarDevuelveFila(Sentencias.ORDEN_CLINICA_BUSCAR_MEDICAMENTOS_VIA,
                                            parametros,
                                            new GeneralUI.cargarInfoFila(cargarVia),
                                            Mensajes.BUSQUEDA_VIA,
                                            true,
                                            null,
                                            tablasSeleccionado,
                                            tablaParametros);
            }
            catch (Exception ex)
            {
                Mensajes.mensajeError(ex);
            }*/
        }
        private void dgvOrdenMedicamentos_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            dgvOrdenMedicamentos.CancelEdit();
            Mensajes.mensajeInformacion(Mensajes.CANTIDAD_INVALIDA);
        }
    }
}
