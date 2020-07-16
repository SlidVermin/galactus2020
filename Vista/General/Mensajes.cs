using System;
using System.Windows.Forms;

namespace Vista.General
{
    public class Mensajes
    {
        public const string NOMBRE_SOFT = "Galactus";
        public const string Modificar_FORM = "¿ Desea Modificar el registro ?";
        public const string CANCELAR_FORM = "¿ Desea cancelar ?";
        public const string GUARDAR_FORM = "¿ Desea guardar ?";
        public const string ANULAR_FORM = "¿ Desea borrar ?";
        public const string SALIR_FORM = "¿ Desea salir ?";
        public const string CONFIRMACION_GUARDADO = "Registro Guardado !";
        public const string CONFIRMACION_ANULADO = "Registro anulado !";
        public const string IMPOSIBLE_ANULA = "Registro imposible de anular !";
        public const string INFORMACION_REQUERIA = "Falta información !";
        public const string VALOR_EXISTENTE = "Este valor ya existe !";
        public const string CANTIDAD_INVALIDA = "Debe colocar una cantidad válida !";
        public const string VALOR_INCORRECTO = "Por favor corrija la información !";

        #region Titulos
        public const string BUSQUEDA_BODEGA = "Busqueda de Bodega";
        public const string BUSQUEDA_PRODUCTO = "Busqueda de Productos";
        public const string BUSQUEDA_EQUIVALENCIA = "Busqueda de Equivalencia";
        public const string BUSQUEDA_MARCA = "Busqueda de Marca";
        public const string BUSQUEDA_PRESENTACION = "Busqueda de Presentación";
        public const string BUSQUEDA_UNIDAD_MEDIDA = "Busqueda de Unidades de Medida";
        public const string BUSQUEDA_ROL = "Busqueda de Roles";
        public const string BUSQUEDA_USUARIOS = "Busqueda de Usuarios";
        public const string BUSQUEDA_EPS = "Busqueda eps";
        public const string BUSQUEDA_PACIENTE = "Busqueda Paciente";
        public const string BUSQUEDA_EMPRESA = "Busqueda Empresa";
        public const string BUSQUEDA_CONTRATO_EPS = "Busqueda contrato eps";
        public const string BUSQUEDA_AREA = "Busqueda area";
        public const string BUSCAR_EVOLUCION = "Busqueda de evoluciones medicas";
        public const string BUSCAR_ORDEN = "Busqueda de orden medicas";
        public const string BUQEDA_INSUMOS = "Busqueda insumos";
        public const string BUSQUEDA_VIA = "Busqueda de vias de aministración";
        public const string BUSQUEDA_LISTA_PRECIO = "Busqueda lista precio";

        #region "Historia Clinica"
        public const string BUSQUEDA_ADMISIONES = "Busqueda de Admisiones";
        public const string BUSQUEDA_ORDENES_MEDICAS = "Busqueda Ordenes";
        public const string BUSQUEDA_PROCEDIMIENTOS = "Busqueda procedimientos";
        public const string BUSQUEDA_ESTANCIAS = "Busqueda estancias";
        #endregion


        #endregion
        public static void mensajeAdvertencia(string mensaje)
        {
            MessageBox.Show(mensaje, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        public static void mensajeInformacion(string mensaje)
        {
            MessageBox.Show(mensaje, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void mensajePorDefectoFaltaInformacion()
        {
            MessageBox.Show(INFORMACION_REQUERIA, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        public static void mostrarMensajeError(Exception  ex)
        {
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error );
        }
        public static bool preguntaSiNo(string msgPregunta)
        {
            return MessageBox.Show(msgPregunta, NOMBRE_SOFT, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }
        public static bool preguntaGuardar()
        {
            return preguntaSiNo(GUARDAR_FORM);
        }
        public static bool preguntaAnular()
        {
            return preguntaSiNo(ANULAR_FORM);
        }
    }
}
