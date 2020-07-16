using Modelo.General.Constantes;
using System;

namespace Modelo.General.Instrucciones
{
    public class SentenciasDAL
    {
        #region GENERALES 
        public const string SEG_AUTENTICACION = ConstanteGeneral.ESQUEMA_SEGURIDAD + "[uspLoginValidar]";
        public const string SEG_ARMAR_MENU = ConstanteGeneral.ESQUEMA_SEGURIDAD + "[uspMenuArmar]";
        public const string SEG_LLENAR_PERMISOS = ConstanteGeneral.ESQUEMA_SEGURIDAD + "[uspMenuPermisosLlenar]";
        public const string CLASIFICACION_PROCEDIMIENTO_PAGINACION = ConstanteGeneral.ESQUEMA_GENERAL + "[uspProcedimientoPaginacionCargar]";
        public const string EXAMEN_PARACLINICOS_PAGINACION = ConstanteGeneral.ESQUEMA_GENERAL + "[uspProcedimientoExamenPaginacionCargar]";
        public const string ESTANCIA_PARACLINICOS_PAGINACION = ConstanteGeneral.ESQUEMA_GENERAL + "[uspProcedimientoEstanciaPaginacionCargar]";
        public const string ECOCARDIOGRAMA_PARAMETROS_CARGAR= ConstanteGeneral.ESQUEMA_GENERAL + "[uspEcocardiogramaParametroCargar]";
        public const string EMPRESA_BUSCAR = ConstanteGeneral.ESQUEMA_GENERAL + "[uspEmpresaBuscar]";
        public const string EMPRESA_CARGAR = ConstanteGeneral.ESQUEMA_GENERAL + "[uspEmpresaCargar]";

        public const string GRUPO_PARACLINICO_LISTAR = ConstanteGeneral.ESQUEMA_GENERAL + "uspGruposParaclinicoListar";
        public const string EXAMEN_LABORATORIO_LISTAR = ConstanteGeneral.ESQUEMA_GENERAL + "[uspTipoExamenListar]";

        public const string EMPLEADO_CARGO_BUSCAR = ConstanteGeneral.ESQUEMA_GENERAL + "[uspEmpleadoCargoBuscar]";
        public const string CLASIFICACION_PROCEDIMIENTO_CREAR = ConstanteGeneral.ESQUEMA_GENERAL + "[uspClasificacionGrupoParaclinicoCrear]";
        public const string CLASIFICACION_EXAMEN_CREAR = ConstanteGeneral.ESQUEMA_GENERAL + "[uspClasificacionExamenCrear]";
        public const string CLASIFICACION_ESTANCIA_CREAR = ConstanteGeneral.ESQUEMA_GENERAL + "[uspClasificacionEstanciaCrear]";

        public const string TIPO_EXAMEN_CREAR = ConstanteGeneral.ESQUEMA_GENERAL + "[uspTipoExamenCrear]";
        public const string TIPO_EXAMEN_BUSCAR = ConstanteGeneral.ESQUEMA_GENERAL + "[uspTipoExamenBuscar]";
        public const string TIPO_EXAMEN_ANULAR = ConstanteGeneral.ESQUEMA_GENERAL + "[uspTipoExamenAnular]";
        #endregion
        #region INVENTARIO 
        public const string ALMACEN_BUSCAR = ConstanteGeneral.ESQUEMA_ALMACEN  + "[uspBodegaBuscar]";
        public const string PRODUCTO_LISTAR_EQUIVALENCIA = ConstanteGeneral.ESQUEMA_ALMACEN + "[uspEquivalenciaListar]";
        public const string PRODUCTO_BUSCAR = ConstanteGeneral.ESQUEMA_ALMACEN + "[uspProductoBuscar]";
        public const string PRODUCTO_CARGAR = ConstanteGeneral.ESQUEMA_ALMACEN + "[uspProductoCargar]";

        public const string EQUIVALENCIA_BUSCAR = ConstanteGeneral.ESQUEMA_ALMACEN + "[uspEquivalenciaBuscar]";
        public const string EQUIVALENCIA_CARGAR = ConstanteGeneral.ESQUEMA_ALMACEN + "[uspEquivalenciaCargar]";
        #endregion
        #region ADMISIONES
        public const String MANUAL_SERVICIO_CREAR = "";
        public const String MANUAL_SERVICIO_BUSCAR = "";
        public const String MANUAL_SERVICIO_CARGAR_SOAT = "";
        public const String MANUAL_SERVICIO_CARGAR_ISS = "";
        public const String MANUAL_SERVICIO_CARGAR_CUPS = "";
        public const String MANUAL_SERVICIO_CONSULTAR_SOAT = "";
        public const String MANUAL_SERVICIO_CONSULTAR_ISS = "";
        public const String MANUAL_SERVICIO_CONSULTAR_CUPS = "";
       
        #endregion
        #region CONFIGURACIÓN 
        public const String PARAMETROS_CARGAR = ConstanteGeneral.ESQUEMA_PARAMETRO +  "[uspParametrosCargar]";
        public const String PARAMETROS_CARGAR_DOCUMENTOS = ConstanteGeneral.ESQUEMA_PARAMETRO + "[uspParametrosCargarDocumentos]";
        public const String PARAMETROS_LISTAR_DOCUMENTOS = ConstanteGeneral.ESQUEMA_PARAMETRO + "[uspParametrosBuscarDocumentos]";
        public const string PARAMETROS_CONSULTAR_DESCRIPCION = ConstanteGeneral.ESQUEMA_PARAMETRO + "[uspParametroDescripcion]";
        public const string PARAMETROS_CONSULTAR_DESCRIPCION_SABANA = ConstanteGeneral.ESQUEMA_PARAMETRO + "[uspParametroDescripcionSabana]";
        public const String GENERAL_CONFIGURACION_PROCEDIMIENTOS_MEDICOS_BUSCAR = ConstanteGeneral.ESQUEMA_GENERAL + "[uspConfiguracionProcedimientosMedicosBuscar]";
       
        //public const String PARAMETROS_LISTAR_DOCUMENTOS = ConstanteGeneral.ESQUEMA_PARAMETRO + "[uspParametrosBuscarDocumentos]";
        #endregion
        #region SEGURIDAD
        public const String ROL_BUSCAR = ConstanteGeneral.ESQUEMA_SEGURIDAD + "[uspUsuarioRolBuscar]";
        public const String USUARIO_BUSCAR = ConstanteGeneral.ESQUEMA_SEGURIDAD + "[uspUsuarioBuscar]";
        #endregion
        #region UBICACION
        public const String CARGARPAIS = ConstanteGeneral.ESQUEMA_ADMISION + "uspPaisCargar";
        public const String CARGAR_DEPARTAMENTO = ConstanteGeneral.ESQUEMA_ADMISION + "uspDepartamentoCargar";
        public const String CARGAR_MUNICIPIO = ConstanteGeneral.ESQUEMA_ADMISION + "uspMunicipioCargar";
        public const String CARGAR_TIPO_DOCUMENTOS = ConstanteGeneral.ESQUEMA_ADMISION + "uspTipoDocumentosBuscar";
        public const String CARGAR_GENERO = ConstanteGeneral.ESQUEMA_ADMISION + "uspGeneroBuscar";
        public const String CARGAR_ESTADO_CIVIL = ConstanteGeneral.ESQUEMA_ADMISION + "uspEstadoCivilBuscar";
        public const String CARGAR_REGIMEN = ConstanteGeneral.ESQUEMA_ADMISION + "uspRegimenCargar";
        public const String CARGAR_AFILIACION = ConstanteGeneral.ESQUEMA_ADMISION + "uspAfiliacionCargar";
        public const String CARGAR_ZONA = ConstanteGeneral.ESQUEMA_ADMISION + "uspZonaCargar";
        public const String CARGAR_ESTRATO_SOCIAL = ConstanteGeneral.ESQUEMA_ADMISION + "uspEstratoSocialCargar";
        public const String CARGAR_EPS = ConstanteGeneral.ESQUEMA_ADMISION + "uspEpsBuscar";
        public const String PACIENTE_CREAR = ConstanteGeneral.ESQUEMA_ADMISION + "uspPacienteCrear";
        public const String PACIENTE_BUSCAR = ConstanteGeneral.ESQUEMA_ADMISION + "uspPacienteBuscar";
        public const String PACIENTE_CARGAR = ConstanteGeneral.ESQUEMA_ADMISION + "uspPacienteCargar";
        public const String UBICACION_GEOGRAFICA = ConstanteGeneral.ESQUEMA_ADMISION + "uspUbicacionGeografica";
        public const String PACIENTE_ANULAR = ConstanteGeneral.ESQUEMA_ADMISION + "uspPacienteAnular";
        public const String PACIENTE_PARAMETROS_CARGAR = ConstanteGeneral.ESQUEMA_ADMISION + "uspPacienteParametros";

        public const String ADMISION_PACIENTE_CARGAR = ConstanteGeneral.ESQUEMA_ADMISION + "uspAdmisionPacienteCargar";
        public const String ADMISION_PACIENTE_BUSCAR = ConstanteGeneral.ESQUEMA_ADMISION + "uspAdmisionPacienteBuscar";
        public const String ADMISION_CONTRATO_EPS = ConstanteGeneral.ESQUEMA_ADMISION + "uspAdmisionContratoEps";
        public const String ADMISION_TERCERO_PACIENTE = ConstanteGeneral.ESQUEMA_ADMISION + "uspAdmisionTerceroPaciente";
        public const String ADMISION_ESPECIALIDAD = ConstanteGeneral.ESQUEMA_ADMISION + "uspAdmisionEspecialidad";
        public const String ADMISION_TRIAGE = ConstanteGeneral.ESQUEMA_ADMISION + "uspAdmisionTriage";
        public const String ADMISION_CREAR = ConstanteGeneral.ESQUEMA_ADMISION + "uspAdmisionCrear";
        public const String ADMISION_BUSCAR = ConstanteGeneral.ESQUEMA_ADMISION + "uspAdmisionBuscar";
        public const String ADMISION_ANULAR = ConstanteGeneral.ESQUEMA_ADMISION + "uspAdmisionAnular";
        public const String ADMISION_CARGAR = ConstanteGeneral.ESQUEMA_ADMISION + "uspAdmisionCargar";

        public const String GENERAL_AREA_ATENCION = ConstanteGeneral.ESQUEMA_GENERAL + "uspAreaAtencion";
        public const String GENERAL_ENTORNO_ATENCION = ConstanteGeneral.ESQUEMA_GENERAL + "uspEntornoAtencion";
        public const String ATENCION_CAUSA_EXTERNA = ConstanteGeneral.ESQUEMA_ADMISION + "uspAtencionCausaExterna";
        public const String ATENCION_INSTITUCION = ConstanteGeneral.ESQUEMA_ADMISION + "uspAtencionInstitucion";
        public const String ATENCION_CAMA = ConstanteGeneral.ESQUEMA_ADMISION + "uspAtencionCama";
        public const String ATENCION_BUSCAR_PACIENTE_ADMISIONADO = ConstanteGeneral.ESQUEMA_ADMISION + "uspAtencionPacienteAdmisionado";
        public const String GENERAL_BUSCAR_DIAGNOSTICO = ConstanteGeneral.ESQUEMA_GENERAL + "uspDiagnosticosBuscar";
        public const String ATENCION_VIA_INGRESO = ConstanteGeneral.ESQUEMA_ADMISION + "uspAtencionViaIngreso";
        public const String ATENCION_CREAR = ConstanteGeneral.ESQUEMA_ADMISION + "uspAtencionCrear";
        public const String ATENCION_BUSCAR = ConstanteGeneral.ESQUEMA_ADMISION + "uspAtencionBuscar";
        public const String ATENCION_CARGAR = ConstanteGeneral.ESQUEMA_ADMISION + "uspAtencionCargar";
        public const String ATENCION_PACIENTE_ATENCION = ConstanteGeneral.ESQUEMA_ADMISION + "uspAtencionPacienteCargar";
        public const String ATENCION_ANULAR = ConstanteGeneral.ESQUEMA_ADMISION + "uspAtencionAnular";

        
        #endregion

        #region Gestion
        public const string BUSCAR_TERCERO = ConstanteGeneral.ESQUEMA_TERCERO + "[uspTerceroBuscar]";
        public const string BUSCAR_TERCERO_CLIENTE = ConstanteGeneral.ESQUEMA_TERCERO + "[uspTerceroClienteBuscar]";
        public const string CREAR_CLIENTE = ConstanteGeneral.ESQUEMA_CLIENTE + "[uspClienteCrear]";
        public const string BUSCAR_CLIENTE = ConstanteGeneral.ESQUEMA_CLIENTE + "[uspClienteBuscar]";
        public const string ANULAR_CLIENTE = ConstanteGeneral.ESQUEMA_CLIENTE + "[uspClienteAnular]";

        public const string BUSCAR_TERCERO_PROVEEDOR = ConstanteGeneral.ESQUEMA_TERCERO + "[uspTerceroProveedorBuscar]";
        public const string CREAR_PROVEEDOR = ConstanteGeneral.ESQUEMA_CLIENTE + "[uspProveedorCrear]";
        public const string BUSCAR_PROVEEDOR = ConstanteGeneral.ESQUEMA_CLIENTE + "[uspProveedorBuscar]";
        public const string ANULAR_PROVEEDOR = ConstanteGeneral.ESQUEMA_CLIENTE + "[uspProveedorAnular]";
        public const string PROVEEDOR_LABORATORIO_CONSULTAR = ConstanteGeneral.ESQUEMA_PROVEEDOR + "uspProveedorLaboratorioConsultar";
        #endregion

        #region Historia Clinica
        public const string BUSCAR_PACIENTE_HEMODIALISIS = ConstanteGeneral.ESQUEMA_FORMATO + "[uspPacienteHemodialisisConsultar]";
        public const string CARGAR_HEMODIALISIS_MEDICAMENTO = ConstanteGeneral.ESQUEMA_FORMATO + "[uspHemodialisisMedicamentoCargar]";
        public const string BUSCAR_HEMODIALISIS = ConstanteGeneral.ESQUEMA_FORMATO + "[uspHemodialisisBuscar]";
        public const string ANULAR_HEMODIALISIS = ConstanteGeneral.ESQUEMA_FORMATO + "[uspHemodialisisAnular]";
        public const string CREAR_HEMODIALISIS = ConstanteGeneral.ESQUEMA_FORMATO + "[uspHemodialisisCrear]";

        public const string BUSCAR_PACIENTE_ECOCARDIOGRAMA = ConstanteGeneral.ESQUEMA_FORMATO + "[uspPacienteEcocardiogramaConsultar]";
        public const string CARGAR_PARAMETROS_ECOCARDIOGRAMA_REGISTRADO = ConstanteGeneral.ESQUEMA_FORMATO + "[uspEcocardiogramaParametroRegistradoCargar]";
        public const string BUSCAR_ECOCARDIOGRAMA = ConstanteGeneral.ESQUEMA_FORMATO + "[uspEcocardiogramaBuscar]";
        public const string ANULAR_ECOCARDIOGRAMA = ConstanteGeneral.ESQUEMA_FORMATO + "[uspEcocardiogramaAnular]";
        public const string CREAR_ECOCARDIOGARMA = ConstanteGeneral.ESQUEMA_FORMATO + "[uspEcocardiogramaCrear]";

        public const string INFORME_QX_MEDICAMENTO_ANASTESIA = ConstanteGeneral.ESQUEMA_HISTORIA_CLINICA + "[uspMedicamentoAnasteaBuscar]";
        public const string PACIENTE_INFORME_QX_BUSCAR = ConstanteGeneral.ESQUEMA_FORMATO +"[uspPacienteInformeQxConsultar]";
        public const string CARGAR_INFORME_QX_MEDICAMENTO = ConstanteGeneral.ESQUEMA_FORMATO + "[uspInformeQxMedicamentoCargar]";
        public const string CARGAR_INFORME_QX_PROCEDIMIENTO = ConstanteGeneral.ESQUEMA_FORMATO + "[uspInformeQxProcedimientoCargar]";
        public const string INFORME_QX_BUSCAR = ConstanteGeneral.ESQUEMA_FORMATO + "[uspInformeQxBuscar]";
        public const string INFORME_QX_ANULAR = ConstanteGeneral.ESQUEMA_FORMATO + "[uspInformeQxAnular]";
        public const string INFORME_QX_CREAR = ConstanteGeneral.ESQUEMA_FORMATO + "[uspInformeQxCrear]";

        public const string BUSCAR_PACIENTE_RESULTADO_LAB = ConstanteGeneral.ESQUEMA_LABORATORIO + "[uspPacienteSolicitudExamenBuscar]";
        public const string CARGAR_RESULTADO_LAB = ConstanteGeneral.ESQUEMA_LABORATORIO + "[uspPacienteSolicitudExamenCargar]";
        public const string ANULAR_RESULTADO_LAB = ConstanteGeneral.ESQUEMA_LABORATORIO + "[uspResultadoExamenAnulado]";
        public const string CREAR_RESULTADO_LAB = ConstanteGeneral.ESQUEMA_LABORATORIO +"[uspResultadoExamenCrear]";

        public const string ORDEN_CLINICA_CREAR = ConstanteGeneral.ESQUEMA_HISTORIA_CLINICA + "[uspOrdenMedicaCrear]";
        public const string ORDEN_CLINICA_BUSCAR = ConstanteGeneral.ESQUEMA_HISTORIA_CLINICA + "[uspOrdenMedicaBuscar]";
        public const string ORDEN_CLINICA_CARGAR = ConstanteGeneral.ESQUEMA_HISTORIA_CLINICA + "[uspOrdenMedicaCargar]";
        public const string ORDEN_CLINICA_ANULAR = ConstanteGeneral.ESQUEMA_HISTORIA_CLINICA + "[uspOrdenMedicaAnular]";

        public const string ORDEN_CLINICA_BUSCAR_PROCEDIMIENTOS= ConstanteGeneral.ESQUEMA_HISTORIA_CLINICA + "[uspListaCUPSBuscar]";
        public const string ORDEN_CLINICA_BUSCAR_ESTANCIAS = ConstanteGeneral.ESQUEMA_HISTORIA_CLINICA + "[uspListaCUPSEstanciaBuscar]";
        public const string ORDEN_CLINICA_BUSCAR_OXIGENO = ConstanteGeneral.ESQUEMA_HISTORIA_CLINICA + "[uspListaOxigenoBuscar]";
        public const string ORDEN_CLINICA_BUSCAR_MEDICAMENTOS_VIA = ConstanteGeneral.ESQUEMA_HISTORIA_CLINICA + "[uspMedicamentoViaBuscar]";
        public const string ORDEN_CLINICA_BUSCAR_MEDICAMENTOS = ConstanteGeneral.ESQUEMA_HISTORIA_CLINICA + "[uspMedicamentoAtencionBuscar]";
        public const string ORDEN_CLINICA_BUSCAR_INFUSION_IMPREGNACION = ConstanteGeneral.ESQUEMA_HISTORIA_CLINICA + "[uspInfusionImpregnacionAtencionBuscar]";
        public const string ORDEN_CLINICA_BUSCAR_MEZCLA = ConstanteGeneral.ESQUEMA_HISTORIA_CLINICA + "[uspMezclaAtencionBuscar]";
        public const string ORDEN_CLINICA_BUSCAR_DISOLVENTE = ConstanteGeneral.ESQUEMA_HISTORIA_CLINICA + "[uspDisolventeAtencionBuscar]";
        public const string FISIOTERAPIA_OXIGENO_CARGAR = ConstanteGeneral.ESQUEMA_HISTORIA_CLINICA + "uspFisioterapiaOxigenoCargar";
        public const string SABANA_CARGAR = ConstanteGeneral.ESQUEMA_HISTORIA_CLINICA + "uspSabanaCargar";
        public const string SABANA_CREAR = ConstanteGeneral.ESQUEMA_HISTORIA_CLINICA + "uspSabanaCrear";

        public const String CREAR_INGRESO_CLINICO = ConstanteGeneral.ESQUEMA_HISTORIA_CLINICA + "uspIngresoAdultoCrear";
        public const String CARGAR_DIAGNOSTICO_INGRESO = ConstanteGeneral.ESQUEMA_HISTORIA_CLINICA + "uspIngresoAdultoDiagnosticoCargar";
        public const String CARGAR_INGRESO = ConstanteGeneral.ESQUEMA_HISTORIA_CLINICA + "uspIngresoAdultoCargar";
        public const String CARGAR_DATOS_ATENCION = ConstanteGeneral.ESQUEMA_HISTORIA_CLINICA + "uspDatosAtencion";
        public const String CARGAR_DIAGNOSTICO_IMPRESION = ConstanteGeneral.ESQUEMA_HISTORIA_CLINICA + "uspIngresoAdultoImpresionCargar";
        public const String CREAR_EVOLUCION_MEDICA = ConstanteGeneral.ESQUEMA_HISTORIA_CLINICA + "uspEvolucionMedicaCrear";
        public const String BUSCAR_EVOLUCION_MEDICA = ConstanteGeneral.ESQUEMA_HISTORIA_CLINICA + "uspEvolucionMedicaBuscar";
        public const String CARGAR_EVOLUCION_MEDICA = ConstanteGeneral.ESQUEMA_HISTORIA_CLINICA + "uspEvolucionMedicaCargar";
        public const String ANULAR_EVOLUCION_MEDICA = ConstanteGeneral.ESQUEMA_HISTORIA_CLINICA + "uspEvolucionMedicaAnular";

        public const String BUSCAR_INSUMOS_ENFERMERIA = ConstanteGeneral.ESQUEMA_HISTORIA_CLINICA + "uspEnfermeriaBuscarInsumos";
        public const String ENFERMERIA_INSUMOS_BUSCAR = ConstanteGeneral.ESQUEMA_HISTORIA_CLINICA + "uspEnfermeriaInsumosBuscar";
        public const String CARGAR_GLUCOMETRIAS_ENFERMERIA = ConstanteGeneral.ESQUEMA_HISTORIA_CLINICA + "uspEnfermeriaGlucometriaCargar";
        public const String CREAR_GLUCOMETRIA_ENFERMERIA = ConstanteGeneral.ESQUEMA_HISTORIA_CLINICA + "uspEnfermeriaGlucometriaCrear";
        public const String CREAR_INSUMOS_ENFERMERIA = ConstanteGeneral.ESQUEMA_HISTORIA_CLINICA + "uspEnfermeriaInsumosCrear";
        public const String CARGAR_INSUMOS_ENFERMERIA = ConstanteGeneral.ESQUEMA_HISTORIA_CLINICA + "uspEnfermeriaInsumosCargar";
        public const String BUSCAR_ORDEN_MEDICA_ENFERMERIA = ConstanteGeneral.ESQUEMA_HISTORIA_CLINICA + "uspEnfermeriaOrdenMedicaBuscar";
        public const String CARGAR_PROCEDIMIENTOS_ENFERMERIA = ConstanteGeneral.ESQUEMA_HISTORIA_CLINICA + "uspEnfermeriaProcedimientosCargar";
        public const String BUSCAR_ORDEN_MEDICA_GENERAL = ConstanteGeneral.ESQUEMA_HISTORIA_CLINICA + "uspEnfermeriaProcedimientoOrdenMedicaBuscar";
        public const String CARGAR_ESTANCIA = ConstanteGeneral.ESQUEMA_HISTORIA_CLINICA + "uspEstanciaCargar";
        public const String CREAR_ESTANCIA = ConstanteGeneral.ESQUEMA_HISTORIA_CLINICA + "uspEstanciaCrear";        
        public const String CREAR_NOTA_ENFERMERIA = ConstanteGeneral.ESQUEMA_HISTORIA_CLINICA + "uspEnfermeriaNotaCrear";
        public const String BUSCAR_NOTA_ENFERMERIA = ConstanteGeneral.ESQUEMA_HISTORIA_CLINICA + "uspEnfermeriaNotaBuscar";
        public const String CARGAR_NOTA_ENFERMERIA = ConstanteGeneral.ESQUEMA_HISTORIA_CLINICA + "uspEnfermeriaNotaCargar";
        public const String GENERO_VERIFICAR_INGRESO = ConstanteGeneral.ESQUEMA_HISTORIA_CLINICA + "uspIngresoVerificarGenero";
        public const String BUSCAR_TIPO_MEDICAMENTO = ConstanteGeneral.ESQUEMA_HISTORIA_CLINICA + "uspTipoMedicamentoBuscar";

        public const string LISTAR_RESULTADO_LABORATORIO = ConstanteGeneral.ESQUEMA_HISTORIA_CLINICA + "[uspResultadoLaboratorioListar]";
        public const string RESUMEN_FACTURA_CARGAR = ConstanteGeneral.ESQUEMA_HISTORIA_CLINICA + "[uspResumenFacturaCargar]";

        public const string CARGAR_SOLICITUDES_ENVIADO = ConstanteGeneral.ESQUEMA_HISTORIA_CLINICA + "[uspExamenesLabEnviados]";
        public const string CARGAR_SOLICITUDES_PENDIENTES = ConstanteGeneral.ESQUEMA_HISTORIA_CLINICA + "[uspExamenesLabPendiente]";
        public const string BUSCAR_SOLICITUD_LAB = ConstanteGeneral.ESQUEMA_HISTORIA_CLINICA + "[uspSolicitudLabBuscar]";
        public const string ANULAR_SOLICITUD_LAB = ConstanteGeneral.ESQUEMA_HISTORIA_CLINICA + "[uspSolicitudLabAnular]";
        public const string CREAR_SOLICITUD_LAB = ConstanteGeneral.ESQUEMA_HISTORIA_CLINICA + "[uspSolicitudLabCrear]";

        #endregion
        #region "Facturacion"
        public const string FACTURA_PACIENTE_CREAR = ConstanteGeneral.ESQUEMA_HISTORIA_CLINICA + "uspFacturaPacienteCrear";
        public const string FACTURA_PACIENTE_ANULAR = ConstanteGeneral.ESQUEMA_HISTORIA_CLINICA + "uspFacturaPacienteAnular";
        public const string FACTURA_PACIENTE_CARGAR_ADMISION = ConstanteGeneral.ESQUEMA_HISTORIA_CLINICA + "uspFacturaPacienteAdmisionCargar";
        public const string FACTURA_PACIENTE_BUSCAR_ADMISION = ConstanteGeneral.ESQUEMA_HISTORIA_CLINICA + "uspFacturaPacienteAdmisionBuscar";
        public const string FACTURA_PACIENTE_BUSCAR_CONTRATO = ConstanteGeneral.ESQUEMA_HISTORIA_CLINICA + "uspFacturaPacienteContratoPendienteBuscar";
      
        #endregion
        #region Formatos
        public const string BUSCAR_ORDEN_MEDICAMENTO_NOPOS = ConstanteGeneral.ESQUEMA_FORMATO + "uspMedicamentoNoPosOrdenBuscar";
        public const string CARGAR_MEDICAMENTO_NOPOS = ConstanteGeneral.ESQUEMA_FORMATO + "uspMedicamentoNoPosCargar";
        public const string BUSCAR_MEDICAMENTO_NOPOS_REEMPLAZAR = ConstanteGeneral.ESQUEMA_FORMATO + "uspMedicamentoNoPosReemplazarBuscar";
        public const string CREAR_MEDICAMENTO_NOPOS = ConstanteGeneral.ESQUEMA_FORMATO + "uspMedicamentoNoPosCrear";
        public const string BUSCAR_MEDICAMENTO_NOPOS = ConstanteGeneral.ESQUEMA_FORMATO + "uspMedicamentoNoPosBuscar";
        public const string ANULAR_MEDICAMENTO_NOPOS = ConstanteGeneral.ESQUEMA_FORMATO + "uspMedicamentoNoPosAnular";

        public const string BUSCAR_ORDEN_MEDICA_JUSTIFICACION_ANT = ConstanteGeneral.ESQUEMA_FORMATO + "uspJustificacionAntibioticoOrdenBuscar";
        public const string CARGAR_JUSTIFICACION_ANT = ConstanteGeneral.ESQUEMA_FORMATO + "uspJustificacionAntibioticoCargar";

        public const string LISTAR_MEDICAMENTOS = ConstanteGeneral.ESQUEMA_HISTORIA_CLINICA + "[uspListaMedicamentoBuscar]";
        #endregion
    }
}
