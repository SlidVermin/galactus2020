using Entidad.HistoriaClinica;
using System;
using System.Windows.Forms;
using Vista.General;

namespace Vista.HistoriaClinica.IngresoMedico
{
    public partial class IngresoClinicoUI : Form
    {
        private string entorno;
        private int idAtencion;
        private bool auditoria;
        private bool esNeonatal;
/*        IngresoClinico ingreso = new IngresoClinico();
        public ValoracionIngresoUI valoracionUI = new ValoracionIngresoUI();
        private AntecedentesIngresoUI antecedentesUI = new AntecedentesIngresoUI();
        private AntecedentesMaternosUI antecedentesMaternosUI = new AntecedentesMaternosUI();
        private AntecedenteRecienNacidoUI antecedenteRecienNacidoUI = new AntecedenteRecienNacidoUI();
        private EventoNacimientoUI eventoNacimientoUI = new EventoNacimientoUI();
        private ExamenFisicoUI examenFisicoUI = new ExamenFisicoUI();
        private AnalisisUI analisisUI = new AnalisisUI();*/
       
        public IngresoClinicoUI()
        {
            InitializeComponent();
        }

        public IngresoClinicoUI(int idAtencion,bool auditoria,bool esNeonatal)
        {
            InitializeComponent();
            this.idAtencion = idAtencion;
            this.auditoria = auditoria;
            this.esNeonatal = esNeonatal;
        }

        private void IngresoClinicoUI_Load(object sender, EventArgs e)
        {
            /*valoracionUI = new ValoracionIngresoUI(idAtencion);

            GeneralUI.cargarFormularioEnPestana(tpValoracion, valoracionUI);
            GeneralUI.cargarFormularioEnPestana(tpAntecedentes, antecedentesUI);
            GeneralUI.cargarFormularioEnPestana(tpAntecedentesMaterno, antecedentesMaternosUI);
            GeneralUI.cargarFormularioEnPestana(tpAntecedentesNacimiento, eventoNacimientoUI);
            GeneralUI.cargarFormularioEnPestana(tpRecienNacido, antecedenteRecienNacidoUI);
            GeneralUI.cargarFormularioEnPestana(tpExamenFisico, examenFisicoUI);
            GeneralUI.cargarFormularioEnPestana(tpAnalisis, analisisUI);

            GeneralUI.posCargadoForm(this, tsIngreso, tsbModificar, null);
            cargarIngreso();*/
        }

        private void cargarIngreso()
        {
            /*IngresoClinico ingreso = new IngresoClinico();
            ingreso.IdAtencion = idAtencion;
            ingreso.cargarDatos();

            valoracionUI.txtMotivoIngreso.Text = ingreso.MotivoIngreso;
            valoracionUI.txtResumenClinico.Text = ingreso.resumenClinico;
            antecedentesUI.txtAnteM.Text = ingreso.AntecedentesMedicos;
            antecedentesUI.txtAntecedentesAlergicos.Text = ingreso.AntecedentesAlergicos;
            antecedentesUI.txtAntecedentesFamiliares.Text = ingreso.AntecedentesFamiliares;
            antecedentesUI.txtAntecedentesQuirurgicos.Text = ingreso.AntecedentesQuirurgicos;
            antecedentesUI.txtAntecedentesToxicos.Text = ingreso.AntecedentesToxicos;
            antecedentesUI.txtAntecedentesTransfusionales.Text = ingreso.AntecedentesTransfusionales;
            antecedentesUI.txtAntecedentesTraumaticos.Text = ingreso.AntecedentesTraumaticos;
            antecedentesUI.txtRevisionSistema.Text = ingreso.RevisionSistema;
            examenFisicoUI.txtAbdomen.Text = ingreso.Abdomen;
            examenFisicoUI.txtCabezaCuello.Text = ingreso.CabezaCuello;
            examenFisicoUI.txtCardioPulmonar.Text = ingreso.CardioPulmonar;
            examenFisicoUI.txtExtremidades.Text = ingreso.Extremidades;
            examenFisicoUI.txtGenitalUrinario.Text = ingreso.GenitalUrinario;
            examenFisicoUI.txtSignosVitales.Text = ingreso.SignosVitales;
            examenFisicoUI.txtSistemaNervioso.Text = ingreso.SistemaNervioso;
            examenFisicoUI.txtTorax.Text = ingreso.Torax;
            examenFisicoUI.txtGenerales.Text = ingreso.Generales;
            examenFisicoUI.txtPielFaneras.Text = ingreso.pielFaneras;
            analisisUI.txtAnalisis.Text = ingreso.Analisis;
            analisisUI.txtPronostico.Text = ingreso.Pronostico;
            antecedentesMaternosUI.txtEdadMadreN.Text = ingreso.edadMadre;
            antecedentesMaternosUI.txtEdadGestN.Text = ingreso.edadGestional;
            antecedentesMaternosUI.txtFumN.Text = ingreso.fum;
            antecedentesMaternosUI.txtControlPN.Text = ingreso.controlPrenatal;
            antecedentesMaternosUI.txtDiabeteGN.Text = ingreso.diabeteGestacional;
            antecedentesMaternosUI.txtDiabeteMN.Text = ingreso.diabeteMellitius;
            antecedentesMaternosUI.txtEnferTN.Text = ingreso.enfermedadTiroidea;
            antecedentesMaternosUI.txtHabitosN.Text = ingreso.habitos;
            antecedentesMaternosUI.txtHemMN.Text = ingreso.hemoclasificacionMadre;
            antecedentesMaternosUI.txtHemPN.Text = ingreso.hemoclasificacionPadre;
            antecedentesMaternosUI.txtHiperGN.Text = ingreso.hipertensionGestacional;
            antecedentesMaternosUI.txtInfeccionesN.Text = ingreso.infeccionEmbarazo;
            antecedentesMaternosUI.txtMedDurEmbN.Text = ingreso.medicamentoDuranteEmbarazo;
            antecedentesMaternosUI.txtObstetricosN.Text = ingreso.obstreticos;
            antecedentesMaternosUI.txtPreeclampciaN.Text = ingreso.preeclampcia;
            antecedentesMaternosUI.txtTorch.Text = ingreso.torch;
            antecedentesMaternosUI.txtVacunacionN.Text = ingreso.vacunacion;
            eventoNacimientoUI.txtTipoParto.Text = ingreso.tipoParto;
            eventoNacimientoUI.txtApgar1N.Text = ingreso.apgar1;
            eventoNacimientoUI.txtApgar5.Text = ingreso.apgar5;
            eventoNacimientoUI.txtCaractLiquidoN.Text = ingreso.caractLiquidas;
            eventoNacimientoUI.txtInduccionP.Text = ingreso.inducionParto;
            eventoNacimientoUI.txtRmacionN.Text = ingreso.reanimacionNacer;
            eventoNacimientoUI.txtTRupturaM.Text = ingreso.rupturasMemb;
            antecedenteRecienNacidoUI.txtGlucometriasN.Text = ingreso.glucometrias;
            antecedenteRecienNacidoUI.txtHemoclasificacionN.Text = ingreso.hemoclasificacion;
            antecedenteRecienNacidoUI.txtTSHN.Text = ingreso.tsh;
            antecedenteRecienNacidoUI.txtVDRLN.Text = ingreso.vdrl;*/
        }

        private IngresoClinico crearIngreso()
        {
            /*ingreso.IdAtencion = idAtencion;
            ingreso.Peso = valoracionUI.txtpeso.Text;
            ingreso.MotivoIngreso = valoracionUI.txtMotivoIngreso.Text;
            ingreso.resumenClinico = valoracionUI.txtResumenClinico.Text;
            ingreso.Paraclinicos = "PRUEBA";
            ingreso.AntecedentesMedicos = antecedentesUI.txtAnteM.Text;
            ingreso.AntecedentesQuirurgicos = antecedentesUI.txtAntecedentesQuirurgicos.Text;
            ingreso.AntecedentesTransfusionales = antecedentesUI.txtAntecedentesTransfusionales.Text;
            ingreso.AntecedentesAlergicos = antecedentesUI.txtAntecedentesAlergicos.Text;
            ingreso.AntecedentesTraumaticos = antecedentesUI.txtAntecedentesTraumaticos.Text;
            ingreso.AntecedentesToxicos = antecedentesUI.txtAntecedentesToxicos.Text;
            ingreso.AntecedentesFamiliares = antecedentesUI.txtAntecedentesFamiliares.Text;
            ingreso.RevisionSistema = antecedentesUI.txtRevisionSistema.Text;
            ingreso.Generales = examenFisicoUI.txtGenerales.Text;
            ingreso.SignosVitales = examenFisicoUI.txtSignosVitales.Text;
            ingreso.CabezaCuello = examenFisicoUI.txtCabezaCuello.Text;
            ingreso.Torax = examenFisicoUI.txtTorax.Text;
            ingreso.CardioPulmonar = examenFisicoUI.txtCardioPulmonar.Text;
            ingreso.Abdomen = examenFisicoUI.txtAbdomen.Text;
            ingreso.GenitalUrinario = examenFisicoUI.txtGenitalUrinario.Text;
            ingreso.Extremidades = examenFisicoUI.txtExtremidades.Text;
            ingreso.SistemaNervioso = examenFisicoUI.txtSistemaNervioso.Text;            
            ingreso.Analisis = analisisUI.txtAnalisis.Text;
            ingreso.Pronostico = analisisUI.txtPronostico.Text;
            ingreso.pielFaneras = examenFisicoUI.txtPielFaneras.Text;
            alistarDt(valoracionUI.ingreso);
            ingreso. establecerDtMaterno();
            ingreso.establecerDtNacimiento();
            ingreso.establecerDtRecienNacido();
            if(antecedentesMaternosUI.txtEdadMadreN.Text != string.Empty)
            {
                ingreso.dtMaterno.Rows.Add(idAtencion,antecedentesMaternosUI.txtEdadMadreN.Text, antecedentesMaternosUI.txtEdadGestN.Text,
                                     antecedentesMaternosUI.txtPreeclampciaN.Text, antecedentesMaternosUI.txtFumN.Text,
                                     antecedentesMaternosUI.txtObstetricosN.Text, antecedentesMaternosUI.txtHemMN.Text,
                                     antecedentesMaternosUI.txtHemPN.Text, antecedentesMaternosUI.txtVacunacionN.Text,
                                     antecedentesMaternosUI.txtControlPN.Text, antecedentesMaternosUI.txtMedDurEmbN.Text,
                                     antecedentesMaternosUI.txtHiperGN.Text, antecedentesMaternosUI.txtHabitosN.Text,
                                     antecedentesMaternosUI.txtInfeccionesN.Text, antecedentesMaternosUI.txtEnferTN.Text,
                                     antecedentesMaternosUI.txtDiabeteGN.Text, antecedentesMaternosUI.txtDiabeteMN.Text,
                                     antecedentesMaternosUI.txtTorch.Text);
            }
            if(eventoNacimientoUI.txtTipoParto.Text != string.Empty)
            {
                ingreso.dtNacimiento.Rows.Add(idAtencion,eventoNacimientoUI.txtTipoParto.Text,eventoNacimientoUI.txtInduccionP.Text,
                                              eventoNacimientoUI.txtApgar1N.Text,eventoNacimientoUI.txtRmacionN.Text,eventoNacimientoUI.txtTRupturaM.Text,
                                              eventoNacimientoUI.txtCaractLiquidoN.Text,eventoNacimientoUI.txtApgar5.Text);
            }
            if(antecedenteRecienNacidoUI.txtHemoclasificacionN.Text != string.Empty)
            {
                ingreso.dtRecienNacido.Rows.Add(idAtencion,antecedenteRecienNacidoUI.txtHemoclasificacionN.Text,
                                                antecedenteRecienNacidoUI.txtTSHN.Text,antecedenteRecienNacidoUI.txtVDRLN.Text,
                                                antecedenteRecienNacidoUI.txtGlucometriasN.Text);
            }
          
            return ingreso;*/
            return null;
        }
       
        public void alistarDt(IngresoClinico ingreso)
        {
          /*this.ingreso.dtAlistar = ingreso.dtImpresion.Copy();
          this.ingreso.dtAlistar.Columns.Remove("Código");
          if(this.ingreso.dtAlistar.Rows.Count > 0)
            {
                this.ingreso.dtAlistar.Rows.RemoveAt(this.ingreso.dtAlistar.Rows.Count -1);
                ingreso.dtImpresion.Rows.RemoveAt(ingreso.dtImpresion.Rows.Count - 1);
            }*/
        }
        private void tsbModificar_Click(object sender, EventArgs e)
        {
            /*GeneralUI.fnModificarForm(this, tsIngreso, tsbGuardar, tsbCancelar);
            valoracionUI.ingreso.dtImpresion.Rows.Add();
            deshabilitarControles();*/
        }

        private void tsbGuardar_Click(object sender, EventArgs e)
        {
            guardarIngreso();
        }
        public bool validarForm()
        {
            /*if (valoracionUI.txtResumenClinico.Text.Equals(string.Empty))
            {
                MessageBox.Show("Por favor el campo resumen clinico se encuentra vacio", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                valoracionUI.txtResumenClinico.Focus();
                tcIngresoClinico.SelectedIndex = 0;
                return false;
            }else if (valoracionUI.txtMotivoIngreso.Text.Equals(string.Empty))
            {
                MessageBox.Show("Por favor el campo motivo ingreso se encuentra vacio", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                valoracionUI.txtMotivoIngreso.Focus();
                tcIngresoClinico.SelectedIndex = 0;
                return false;
            }else if (antecedentesUI.txtAntecedentesMedicos.Text.Equals(string.Empty))
            {
                MessageBox.Show("Por favor el campo antecedentes medicos se encuentra vacio", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                antecedentesUI.txtAntecedentesMedicos.Focus();
                tcIngresoClinico.SelectedIndex = 1;
                return false;
            }else if (antecedentesUI.txtAntecedentesTraumaticos.Text.Equals(string.Empty))
            {
                MessageBox.Show("Por favor el campo antecedentes traumatico se encuentra vacio", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                antecedentesUI.txtAntecedentesTraumaticos.Focus();
                tcIngresoClinico.SelectedIndex = 1;
                return false;
            }else if (antecedentesUI.txtAntecedentesAlergicos.Text.Equals(string.Empty))
            {
                MessageBox.Show("Por favor el campo antecedentes alergico se encuentra vacio", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                antecedentesUI.txtAntecedentesAlergicos.Focus();
                tcIngresoClinico.SelectedIndex = 1;
                return false;
            }else if (antecedentesUI.txtAntecedentesQuirurgicos.Text.Equals(string.Empty))
            {
                MessageBox.Show("Por favor el campo antecedentes quirurgicos se encuentra vacio", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                antecedentesUI.txtAntecedentesQuirurgicos.Focus();
                tcIngresoClinico.SelectedIndex = 1;
                return false;
            }else if (antecedentesUI.txtAntecedentesTransfusionales.Text.Equals(string.Empty))
            {
                MessageBox.Show("Por favor el campo antecedentes transfusionales se encuentra vacio", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                antecedentesUI.txtAntecedentesTransfusionales.Focus();
                tcIngresoClinico.SelectedIndex = 1;
                return false;
            }else if (antecedentesUI.txtAntecedentesToxicos.Text.Equals(string.Empty))
            {
                MessageBox.Show("Por favor el campo antecedentes toxicos se encuentra vacio", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                antecedentesUI.txtAntecedentesToxicos.Focus();
                tcIngresoClinico.SelectedIndex = 1;
                return false;
            }else if (antecedentesUI.txtAntecedentesFamiliares.Text.Equals(string.Empty))
            {
                MessageBox.Show("Por favor el campo antecedentes familiares se encuentra vacio", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                antecedentesUI.txtAntecedentesFamiliares.Focus();
                tcIngresoClinico.SelectedIndex = 1;
                return false;
            }else if (antecedentesUI.txtRevisionSistema.Text.Equals(string.Empty))
            {
                MessageBox.Show("Por favor el campo revision sistemas se encuentra vacio", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                antecedentesUI.txtRevisionSistema.Focus();
                tcIngresoClinico.SelectedIndex = 1;
                return false;
            }else if(antecedentesMaternosUI.txtEdadMadreN.Text.Equals(string.Empty) && esNeonatal)
            {
                MessageBox.Show("Por favor el campo edad madre se encuentra vacio", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                antecedentesMaternosUI.txtEdadMadreN.Focus();
                tcIngresoClinico.SelectedIndex = 2;
                return false;
            }else if (antecedentesMaternosUI.txtEdadGestN.Text.Equals(string.Empty) && esNeonatal)
            {
                MessageBox.Show("Por favor el campo edad gestacional se encuentra vacio", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                antecedentesMaternosUI.txtEdadGestN.Focus();
                tcIngresoClinico.SelectedIndex = 2;
                return false;
            }   else if (antecedentesMaternosUI.txtFumN.Text.Equals(string.Empty) && esNeonatal)
            {
                MessageBox.Show("Por favor el campo fum se encuentra vacio", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                antecedentesMaternosUI.txtFumN.Focus();
                tcIngresoClinico.SelectedIndex = 2;
                return false;
            }
            else if (antecedentesMaternosUI.txtObstetricosN.Text.Equals(string.Empty) && esNeonatal)
            {
                MessageBox.Show("Por favor el campo obstetricos se encuentra vacio", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                antecedentesMaternosUI.txtObstetricosN.Focus();
                tcIngresoClinico.SelectedIndex = 2;
                return false;
            }
            else if (antecedentesMaternosUI.txtHemMN.Text.Equals(string.Empty) && esNeonatal)
            {
                MessageBox.Show("Por favor el campo hemoclasificacion de la madre se encuentra vacio", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                antecedentesMaternosUI.txtHemMN.Focus();
                tcIngresoClinico.SelectedIndex = 2;
                return false;
            }
            else if (antecedentesMaternosUI.txtHemPN.Text.Equals(string.Empty) && esNeonatal)
            {
                MessageBox.Show("Por favor el campo hemoclasificacion del padre se encuentra vacio", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                antecedentesMaternosUI.txtHemPN.Focus();
                tcIngresoClinico.SelectedIndex = 2;
                return false;
            }
            else if (antecedentesMaternosUI.txtControlPN.Text.Equals(string.Empty) && esNeonatal)
            {
                MessageBox.Show("Por favor el campo control prenatal se encuentra vacio", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                antecedentesMaternosUI.txtControlPN.Focus();
                tcIngresoClinico.SelectedIndex = 2;
                return false;
            }
            else if (antecedentesMaternosUI.txtMedDurEmbN.Text.Equals(string.Empty) && esNeonatal)
            {
                MessageBox.Show("Por favor el campo medicamento durante embarazo se encuentra vacio", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                antecedentesMaternosUI.txtMedDurEmbN.Focus();
                tcIngresoClinico.SelectedIndex = 2;
                return false;
            }
            else if (antecedentesMaternosUI.txtHabitosN.Text.Equals(string.Empty) && esNeonatal)
            {
                MessageBox.Show("Por favor el campo habitos se encuentra vacio", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                antecedentesMaternosUI.txtHabitosN.Focus();
                tcIngresoClinico.SelectedIndex = 2;
                return false;
            }
            else if (antecedentesMaternosUI.txtInfeccionesN.Text.Equals(string.Empty) && esNeonatal)
            {
                MessageBox.Show("Por favor el campo infeccion en el embarazo se encuentra vacio", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                antecedentesMaternosUI.txtInfeccionesN.Focus();
                tcIngresoClinico.SelectedIndex = 2;
                return false;
            }
            else if (antecedentesMaternosUI.txtDiabeteGN.Text.Equals(string.Empty) && esNeonatal)
            {
                MessageBox.Show("Por favor el campo diabete gestacional se encuentra vacio", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                antecedentesMaternosUI.txtDiabeteGN.Focus();
                tcIngresoClinico.SelectedIndex = 2;
                return false;
            }
            else if (antecedentesMaternosUI.txtDiabeteMN.Text.Equals(string.Empty) && esNeonatal)
            {
                MessageBox.Show("Por favor el campo diabete mellitus se encuentra vacio", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                antecedentesMaternosUI.txtDiabeteMN.Focus();
                tcIngresoClinico.SelectedIndex = 2;
                return false;
            }
            else if (antecedentesMaternosUI.txtHiperGN.Text.Equals(string.Empty) && esNeonatal)
            {
                MessageBox.Show("Por favor el campo hiper gestacional se encuentra vacio", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                antecedentesMaternosUI.txtHiperGN.Focus();
                tcIngresoClinico.SelectedIndex = 2;
                return false;
            }
            else if (antecedentesMaternosUI.txtPreeclampciaN.Text.Equals(string.Empty) && esNeonatal)
            {
                MessageBox.Show("Por favor el campo preeclampcia se encuentra vacio", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                antecedentesMaternosUI.txtPreeclampciaN.Focus();
                tcIngresoClinico.SelectedIndex = 2;
                return false;
            }
            else if (antecedentesMaternosUI.txtEnferTN.Text.Equals(string.Empty) && esNeonatal)
            {
                MessageBox.Show("Por favor el campo enfermedad toroidea se encuentra vacio", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                antecedentesMaternosUI.txtEnferTN.Focus();
                tcIngresoClinico.SelectedIndex = 2;
                return false;
            }
            else if (antecedentesMaternosUI.txtVacunacionN.Text.Equals(string.Empty) && esNeonatal)
            {
                MessageBox.Show("Por favor el campo vacunacion se encuentra vacio", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                antecedentesMaternosUI.txtVacunacionN.Focus();
                tcIngresoClinico.SelectedIndex = 2;
                return false;
            }
            else if (antecedentesMaternosUI.txtTorch.Text.Equals(string.Empty) && esNeonatal)
            {
                MessageBox.Show("Por favor el campo torch se encuentra vacio", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                antecedentesMaternosUI.txtTorch.Focus();
                tcIngresoClinico.SelectedIndex = 2;
                return false;
            }
            else if (eventoNacimientoUI.txtTipoParto.Text.Equals(string.Empty) && esNeonatal)
            {
                MessageBox.Show("Por favor el campo tipo parto se encuentra vacio", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                eventoNacimientoUI.txtTipoParto.Focus();
                tcIngresoClinico.SelectedIndex = 3;
                return false;
            }
            else if (eventoNacimientoUI.txtInduccionP.Text.Equals(string.Empty) && esNeonatal)
            {
                MessageBox.Show("Por favor el campo inducion parto se encuentra vacio", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                eventoNacimientoUI.txtInduccionP.Focus();
                tcIngresoClinico.SelectedIndex = 3;
                return false;
            }
            else if (eventoNacimientoUI.txtApgar1N.Text.Equals(string.Empty) && esNeonatal)
            {
                MessageBox.Show("Por favor el campo apgar 1 se encuentra vacio", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                eventoNacimientoUI.txtApgar1N.Focus();
                tcIngresoClinico.SelectedIndex = 3;
                return false;
            }
            else if (eventoNacimientoUI.txtRmacionN.Text.Equals(string.Empty) && esNeonatal)
            {
                MessageBox.Show("Por favor el campo reanimacion al nacer se encuentra vacio", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                eventoNacimientoUI.txtRmacionN.Focus();
                tcIngresoClinico.SelectedIndex = 3;
                return false;
            }
            else if (eventoNacimientoUI.txtTRupturaM.Text.Equals(string.Empty) && esNeonatal)
            {
                MessageBox.Show("Por favor el campo rupturas memb se encuentra vacio", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                eventoNacimientoUI.txtTRupturaM.Focus();
                tcIngresoClinico.SelectedIndex = 3;
                return false;
            }
            else if (eventoNacimientoUI.txtCaractLiquidoN.Text.Equals(string.Empty) && esNeonatal)
            {
                MessageBox.Show("Por favor el campo caracteristicas liquidas se encuentra vacio", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                eventoNacimientoUI.txtCaractLiquidoN.Focus();
                tcIngresoClinico.SelectedIndex = 3;
                return false;
            }
            else if (eventoNacimientoUI.txtApgar5.Text.Equals(string.Empty) && esNeonatal)
            {
                MessageBox.Show("Por favor el campo apgar 5 se encuentra vacio", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                eventoNacimientoUI.txtApgar5.Focus();
                tcIngresoClinico.SelectedIndex = 3;
                return false;
            }
            else if (antecedenteRecienNacidoUI.txtHemoclasificacionN.Text.Equals(string.Empty) && esNeonatal)
            {
                MessageBox.Show("Por favor el campo hemoclasificacion se encuentra vacio", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                antecedenteRecienNacidoUI.txtHemoclasificacionN.Focus();
                tcIngresoClinico.SelectedIndex = 4;
                return false;
            }
            else if (antecedenteRecienNacidoUI.txtTSHN.Text.Equals(string.Empty) && esNeonatal)
            {
                MessageBox.Show("Por favor el campo tsh se encuentra vacio", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                antecedenteRecienNacidoUI.txtTSHN.Focus();
                tcIngresoClinico.SelectedIndex = 4;
                return false;
            }
            else if (antecedenteRecienNacidoUI.txtVDRLN.Text.Equals(string.Empty) && esNeonatal)
            {
                MessageBox.Show("Por favor el campo vdrl se encuentra vacio", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                antecedenteRecienNacidoUI.txtVDRLN.Focus();
                tcIngresoClinico.SelectedIndex = 4;
                return false;
            }
            else if (antecedenteRecienNacidoUI.txtGlucometriasN.Text.Equals(string.Empty) && esNeonatal)
            {
                MessageBox.Show("Por favor el campo glucometria se encuentra vacio", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                antecedenteRecienNacidoUI.txtGlucometriasN.Focus();
                tcIngresoClinico.SelectedIndex = 4;
                return false;
            }*/
            return true;
        }
        private void guardarIngreso() {           
            /*if (validarForm() && MessageBox.Show(Mensajes.GUARDAR_FORM, Mensajes.NOMBRE_SOFT, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    IngresoClinicoDAL.guardarIngreso(crearIngreso());
                    GeneralUI.posGuardar(this, tsIngreso, tsbModificar, null, null, null, null, Mensajes.CONFIRMACION_GUARDADO);

                }
                catch (Exception ex)
                {
                    Mensajes.mensajeError(ex);
                }
            }*/
        }
        /*public void historiaClinica(HistoriaClinicaUI historia)
        {
            entorno = historia.txtServicio.Text;
        }*/

        private void IngresoClinicoUI_Shown(object sender, EventArgs e)
        {
            /*ingreso.IdAtencion = idAtencion;
            ingreso.generoPestañas();
            if(ingreso.genero == (int) ConstanteGeneral.PARAMETRO_PACIENTE.MASCULINO && !esNeonatal)
            {
                tcIngresoClinico.TabPages.Remove(tpAntecedentesMaterno);
                tcIngresoClinico.TabPages.Remove(tpAntecedentesNacimiento);
                tcIngresoClinico.TabPages.Remove(tpRecienNacido);
            }*/
        }

        private void tsbCancelar_Click(object sender, EventArgs e)
        {
            /*GeneralUI.fnCancelarForm(this, tsIngreso, tsbModificar, null);
            cargarIngreso();
            valoracionUI.cargarDatos();*/
           
        }
        private void deshabilitarControles()
        {
            /*valoracionUI.txtAutorizacion.ReadOnly = true;
            valoracionUI.txtcama.ReadOnly = true;
            valoracionUI.txtcausaexterna.ReadOnly = true;
            valoracionUI.txtinstitucion.ReadOnly = true;
            valoracionUI.txtviaingreso.ReadOnly = true;*/
        }
    }
}
