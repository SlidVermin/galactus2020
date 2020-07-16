using Entidad.HistoriaClinica.OrdenMedica;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Vista.HistoriaClinica.OrdenMedica
{
    public partial class InfusionImpregnacionUI : Form
    {
        public bool edicion = false;
        public bool auditoria { get; set; }
        public int idAtencion { get; set; }
        public DateTime fecha { get; set; }
        public OrdenClinicaMedicamento medicamentos { get; set; }
        public InfusionImpregnacionUI()
        {
            InitializeComponent();
        }

        private void InfusionImpregnacionUI_Load(object sender, EventArgs e)
        {
            inicializarForm();
        }

        void inicializarForm()
        {
          
        }
        public void enlazarDgv()
        {
            if (medicamentos != null)
            {
                dgvOrdenInfusionImpregnacion.AutoGenerateColumns = false;
                dgvOrdenInfusionImpregnacion.DataSource = medicamentos.tblInfusionImpregnacion;
            }
        }
        void cargarMedicamento(DataRow filaResultado)
        {
            /*DataRowCollection filas = medicamentos.tblInfusionImpregnacion.Rows;
            int cantidad = filas.Count - 1;
            filas[cantidad]["idEquivalencia"] = filaResultado.Field<int>("ID");
            filas[cantidad]["Descripción"] = filaResultado.Field<string>("Descripción");
            filas[cantidad]["Unidad"] = filaResultado.Field<string>("Unidad");
            filas[cantidad]["Dosis"] = 0;
            filas[cantidad]["cc/hora"] = 0;
            filas[cantidad]["Hora inicial"] = ConstanteGeneral.POR_DEFINIR;
            filas[cantidad]["Acepta disolvente"] = filaResultado.Field<bool>("Acepta disolvente");
            if (filaResultado.Field<bool>("Acepta disolvente")){
                filas[cantidad]["Disolvente"] = ConstanteGeneral.POR_DEFINIR;
            }
            if (filas[cantidad]["TipoMedicamento"].ToString() == ConstanteGeneral.INFUSION)
            {
                filas[cantidad]["Mezcla"] = ConstanteGeneral.POR_DEFINIR;               
            }
            filas[cantidad]["idMedicamento"] = medicamentos.obtenerConsecutivo();
            filas.Add();
            dgvOrdenInfusionImpregnacion.EndEdit();
            dgvOrdenInfusionImpregnacion.Columns["idMedicamento"].Visible = false;*/
        }
        void cargarDisolvente(DataRow filaResultado)
        {
            int fila = dgvOrdenInfusionImpregnacion.CurrentCell.RowIndex;
            medicamentos.tblInfusionImpregnacion.Rows[fila]["idEquivalenciaDisolvente"] = filaResultado.Field<int>("ID");
            medicamentos.tblInfusionImpregnacion.Rows[fila]["Disolvente"] = filaResultado.Field<string>("Descripción");

        }

        private void dgvOrdenInfusionImpregnacion_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            /*dgvOrdenInfusionImpregnacion.CancelEdit();
            Mensajes.mensajeInformacion(Mensajes.CANTIDAD_INVALIDA);*/
        }
        void agregarMedicamento()
        {
            /*try
            {
                List<string> parametros = new List<string>();
                DataTable tablasSeleccionado = new DataTable();
                DataTable tablaParametros = new DataTable();

                tablaParametros.Columns.Add("Parametro", Type.GetType("System.Object"));
                tablaParametros.Columns.Add("Valor", Type.GetType("System.Object"));

                object[] myObjArray = { "@pAuditoria", auditoria };
                object[] myObjArray1 = { "@pIdAtencion", idAtencion };
                object[] myObjArray2 = { "@pFechaOrden", fecha.Date };
                object[] myObjArray3 = { "@pFiltro", "" };

                
                tablaParametros.Rows.Add(myObjArray);
                tablaParametros.Rows.Add(myObjArray1);
                tablaParametros.Rows.Add(myObjArray2);
                tablaParametros.Rows.Add(myObjArray3);

                GeneralUI.buscarDevuelveFila(Sentencias.ORDEN_CLINICA_BUSCAR_INFUSION_IMPREGNACION,
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
        void agregarDisolvente()
        {
           /* try
            {
                List<string> parametros = new List<string>();

                DataTable tablaParametros = new DataTable();
                DataTable tablasSeleccionado = new DataTable();
                int idEquivalencia;
                idEquivalencia = (int)dgvOrdenInfusionImpregnacion.Rows[dgvOrdenInfusionImpregnacion.CurrentCell.RowIndex].Cells["idEquivalencia"].Value;
                tablaParametros.Columns.Add("Parametro", Type.GetType("System.Object"));
                tablaParametros.Columns.Add("Valor", Type.GetType("System.Object"));

                object[] myObjArray = { "@pAuditoria", auditoria };
                object[] myObjArray1 = { "@pIdAtencion", idAtencion };
                object[] myObjArray2 = { "@pFechaOrden", fecha };
                object[] myObjArray3 = { "@pFiltro", "" };

                tablaParametros.Rows.Add(myObjArray);
                tablaParametros.Rows.Add(myObjArray1);
                tablaParametros.Rows.Add(myObjArray2);
                tablaParametros.Rows.Add(myObjArray3);

                GeneralUI.buscarDevuelveFila(Sentencias.ORDEN_CLINICA_BUSCAR_DISOLVENTE,
                                            parametros,
                                            new GeneralUI.cargarInfoFila(cargarDisolvente),
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
        private void dgvOrdenInfusionImpregnacion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           /* if (e.RowIndex >= 0)
            {

                GeneralUI.deshabilitarColumnas(dgvOrdenInfusionImpregnacion);
                if (edicion)
                {
                    dgvOrdenInfusionImpregnacion.Columns["Dosis"].ReadOnly = false;
                    dgvOrdenInfusionImpregnacion.Columns["Suspender"].ReadOnly = false;
                    dgvOrdenInfusionImpregnacion.Columns["Horainicial"].ReadOnly = false;
                    dgvOrdenInfusionImpregnacion.Columns["cchora"].ReadOnly = false;
                    int fila = dgvOrdenInfusionImpregnacion.CurrentCell.RowIndex;

                    if (!string.IsNullOrEmpty(medicamentos.tblInfusionImpregnacion.Rows[fila]["idEquivalenciaDisolvente"].ToString()))
                    {
                        dgvOrdenInfusionImpregnacion.Columns["dgCantidadDisolventeOrdenINIM"].ReadOnly = false;
                    }
                    if (GeneralUI.verificarUbicacionCelda(e, dgvOrdenInfusionImpregnacion, "quitar") & e.RowIndex < dgvOrdenInfusionImpregnacion.Rows.Count - 1)
                    {
                        if (Mensajes.preguntaAnular())
                        {
                            medicamentos.quitarMezcla(int.Parse(dgvOrdenInfusionImpregnacion.Rows[dgvOrdenInfusionImpregnacion.CurrentCell.RowIndex].Cells["IdMedicamento"].Value.ToString()));
                            dgvOrdenInfusionImpregnacion.Rows.RemoveAt(e.RowIndex);
                        }
                    }
                    else if (GeneralUI.verificarUbicacionCelda(e, dgvOrdenInfusionImpregnacion, "agregar") & e.RowIndex == dgvOrdenInfusionImpregnacion.Rows.Count - 1)
                    {
                        agregarTipoInfusionImpregnacion();
                    }
                    else if (GeneralUI.verificarUbicacionCelda(e, dgvOrdenInfusionImpregnacion, "Disolvente") &
                             e.RowIndex != dgvOrdenInfusionImpregnacion.Rows.Count - 1 &
                             dgvOrdenInfusionImpregnacion.Rows[e.RowIndex].Cells["Disolvente"].Value.ToString() == ConstanteGeneral.POR_DEFINIR)
                    {
                        agregarDisolvente();
                    
                    
                    }
                }
                else if (GeneralUI.verificarUbicacionCelda(e, dgvOrdenInfusionImpregnacion, "Mezcla") &
                             (dgvOrdenInfusionImpregnacion.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == ConstanteGeneral.POR_DEFINIR ||
                              dgvOrdenInfusionImpregnacion.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == ConstanteGeneral.MEZCLA))
                {
                    GeneralUI.abrirMezcla(dgvOrdenInfusionImpregnacion,ref medicamentos.tblMezcla,edicion, idAtencion, fecha,auditoria);
                        verificarMezcla();
                }
            }*/
        }
        public void verificarMezcla()
        {
           /* int i;
            for (i = 0;i< dgvOrdenInfusionImpregnacion.RowCount; i++)
            {
                if (! string.IsNullOrEmpty(dgvOrdenInfusionImpregnacion.Rows[i].Cells["IdMedicamento"].Value.ToString()) &&
                    medicamentos.tblMezcla.Select("idMedicamento=" + dgvOrdenInfusionImpregnacion.Rows[i].Cells["IdMedicamento"].Value).Count() > 0)
                {
                    dgvOrdenInfusionImpregnacion.Rows[i].Cells["Mezcla"].Style.BackColor = Color.LightGreen;
                    dgvOrdenInfusionImpregnacion.Rows[i].Cells["Mezcla"].Value = ConstanteGeneral.MEZCLA;
                }else
                {
                    if (dgvOrdenInfusionImpregnacion.Rows[i].Cells["Mezcla"].Value.ToString() == ConstanteGeneral.MEZCLA) {
                        dgvOrdenInfusionImpregnacion.Rows[i].Cells["Mezcla"].Value = ConstanteGeneral.POR_DEFINIR;
                    }
                    dgvOrdenInfusionImpregnacion.Rows[i].Cells["Mezcla"].Style.BackColor = dgvOrdenInfusionImpregnacion.Rows[i].Cells["Descripcion"].Style.BackColor;
                }
                
            }
            dgvOrdenInfusionImpregnacion.Columns["idMedicamento"].Visible = false;*/
        }
        
        public void agregarTipoInfusionImpregnacion()
        {
           /* List<string> parametros = new List<string>();
            GeneralUI.buscarDevuelveFila(Sentencias.BUSCAR_TIPO_MEDICAMENTO,
                                               parametros,
                                               new GeneralUI.cargarInfoFila(cargarTipoInfusionImpregnacion),
                                               Mensajes.BUSQUEDA_EQUIVALENCIA, true);
            if (string.IsNullOrEmpty(dgvOrdenInfusionImpregnacion.Rows[dgvOrdenInfusionImpregnacion.CurrentCell.RowIndex].Cells["Descripcion"].Value.ToString()))
            {
                if (dgvOrdenInfusionImpregnacion.CurrentCell.RowIndex == dgvOrdenInfusionImpregnacion.RowCount - 1)
                {
                    dgvOrdenInfusionImpregnacion.Rows[dgvOrdenInfusionImpregnacion.CurrentCell.RowIndex].Cells["Tipo"].Value = DBNull.Value;
                }
                else
                {
                    dgvOrdenInfusionImpregnacion.Rows.RemoveAt(dgvOrdenInfusionImpregnacion.CurrentCell.RowIndex);
                }
                
            }*/
        }
       
    public void cargarTipoInfusionImpregnacion(DataRow filaResultado)
        {
            dgvOrdenInfusionImpregnacion.Rows[dgvOrdenInfusionImpregnacion.CurrentCell.RowIndex].Cells["tipoMedicamento"].Value = filaResultado.Field<string>("Código");
            dgvOrdenInfusionImpregnacion.Rows[dgvOrdenInfusionImpregnacion.CurrentCell.RowIndex].Cells["Tipo"].Value = filaResultado.Field<string>("Descripción");
            agregarMedicamento();
        }
        private void dgvOrdenInfusionImpregnacion_KeyDown(object sender, KeyEventArgs e)
        {
          /*  if (edicion && e.KeyCode == Keys.Delete && dgvOrdenInfusionImpregnacion.CurrentCell.RowIndex  >= 0)
            {
                bool filaVacia;
                int filaActual;
                filaActual = dgvOrdenInfusionImpregnacion.CurrentCell.RowIndex;

                filaVacia = ((dgvOrdenInfusionImpregnacion.Rows[filaActual].Cells["idMedicamento"].Value == null) ||
                string.IsNullOrEmpty(dgvOrdenInfusionImpregnacion.Rows[filaActual].Cells["idMedicamento"].Value.ToString())) ? true : false;

                if (!filaVacia)
                {
                    dgvOrdenInfusionImpregnacion.Rows[filaActual].Cells["idEquivalenciaDisolvente"].Value = DBNull.Value;
                    dgvOrdenInfusionImpregnacion.Rows[filaActual].Cells["Disolvente"].Value = ConstanteGeneral.POR_DEFINIR;
                    dgvOrdenInfusionImpregnacion.Rows[filaActual].Cells["dgCantidadDisolventeOrdenINIM"].Value = 0;
                }
                
            }*/
        }
    }
}
