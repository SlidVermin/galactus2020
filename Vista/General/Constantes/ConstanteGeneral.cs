using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vista.General.Constantes
{
    class ConstanteGeneral
    {
        public const String TEXTBOX_CODIGO = "txtCodigo";
        public const String BOTON_OPCION = "btOpcion";

        public const String TIPO_LETRA_ELEMENTO = "xxx";
        public const String FORMULARIO_LOGO = "";
        public const String LINEA_TITULO = "";

        public const int ESTADO_LISTO = 1;

        public const int SIN_VALOR_NUMERICO = 0;

        public const int METODO_CUPS = 1;
        public const int METODO_SOAT = 2;
        public const int METODO_ISS = 3;

        public const string TITULO_ATENCIÓN_MEDICA = "Lista de pacientes/Atención medica";
        public const string TITULO_ATENCIÓN_ENFERMERIA = "Lista de pacientes/Atención enfermeria";

        public const String VALUEMEMBER = "Código";
        public const String DISPLAYMEMBER = "Descripcion";
        public const String VALUE_VALOR = "IdDescripcionValor";
        public const String DISPLAY_VALOR = "Valor";
        public const String PREDETERMINADA = "-1";
        public const int PREDETERMINADO = -1;

        public const String ENFERMERIA_INSUMOS = "E";
        public const String FISOTERAPEUTAS_INSUMOS = "F";

        public const String VALUEMEMBER_PAIS = "IdPais";
        public const String DISPLAYMEMBER_PAIS = "Descripcion";

        public const String VALUEMEMBER_DEPARTAMENTO = "IdDepartamento";
        public const String DISPLAYMEMBER_DEPARTAMENTO = "Descripcion";

        public const string ESQUEMA_ALMACEN = "[Almacen].";
        public const string ESQUEMA_SEGURIDAD = "[Seguridad].";
        public const string ESQUEMA_PARAMETRO = "[Parametro].";
        public const string ESQUEMA_ADMISION = "[Admision].";
        public const string ESQUEMA_GENERAL = "[General].";
        public const string ESQUEMA_TERCERO = "[Tercero].";
        public const string ESQUEMA_PROVEEDOR = "[Proveedor].";
        public const string ESQUEMA_CLIENTE = "[Cliente].";
        public const string ESQUEMA_HISTORIA_CLINICA = "[HistoriaClinica].";
        public const string ESQUEMA_LABORATORIO = "[Laboratorio].";
        public const string ESQUEMA_FORMATO = "[Formato].";

        public const int ESTADO_INICIADO = 4219;

        public const string POR_DEFINIR = "Por definir";
        public const string MEZCLA = "Mezcla";
        public const string CODIGO_AZUL = "Cód. Azul";
        public const string AHORA = "Ahora";
        public const string RAZON_NECESARIA = "Razón nec.";
        public const string MEDICAMENTO = "M";
        public const string INFUSION = "In";
        public const string IMPREGNACION = "Im";
        public const string HORARIO_MEDICAMENTO_POR_DEFINIR = "200";
        public const string HORARIO_MEDICAMENTO_CODIGO_AZUL = "100";
        public const string HORARIO_MEDICAMENTO_AHORA = "101";
        public const string HORARIO_MEDICAMENTO_RAZON_NECESARIA = "102";
        public const string TIPO_EQUIVALENCIA = "E";
        public const string TIPO_OXIGENO = "O";
        public const string TIPO_CUPS = "C";
        public const string SABANA_SIN_APLICAR = "X";
        public const string SABANA_SUSPENDIDO = "S";
        public const string SABANA_MODIFICADO = "M";
        public const string SABANA_ID_SIN_APLICAR = "0";
        public const string SABANA_ID_SUSPENDIDO = "-100";
        public const string SABANA_ID_MODIFICADO = "-200";
        
        public enum PARAMETRO_PACIENTE
        {
            REGIMEN = 51,
            ZONA = 53,
            AFILIACION = 46,
            CLASESOCIAL=47,
            ESTADOCIVIL=49,
            DOCUMENTOS = 29,
            GENERO = 69,
            MASCULINO = 4936,
            FEMENINO = 4937
        }

        #region codigoConfiguracionExamen
        public const int ID_LABORATORIO = 4945;
        public const int ID_IMAGENOLOGIA = 4946;
        #endregion

        #region configuracion general
        public const int MARCA = 1;
        public const int PRESENTACION = 2;
        public const int SEXO = 3;
        public const int ESTADO_CIVIL = 4;
        public const int LINEA = 5;
        public const int VIAS_ADMINISTRACION = 6;
        public const int UNIDADES_DE_MEDIDA = 7;
        public const int REGIMEN_SOCIO_ECONOMICO = 13;
        public const int BANCO = 14;
        public const int TRIAGE = 71;
        public const int ESPECIALIDAD = 48;
        public const int CAMA = 72;
        public const int VIA_INGRESO = 52;
        public const int CAUSA_EXTERNA = 37;
        public const int INSTITUCIÓN = 43;
        public const int ESTADO_ATENCION = 39;
        public const int VIA_ADMINISTRACION = 21;
        #endregion
        #region Menu
        public const string MENU_ATENCION_MEDICA = "27";
        public const string MENU_ATENCION_ENFERMERIA = "29";
        #endregion
    }
}
