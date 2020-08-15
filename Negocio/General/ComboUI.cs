using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Negocio.General
{
    public class ComboUI
    {
        public static void llenarComboDatosDefinidor(System.Data.DataTable dt,
                                                     string valueMember,
                                                     string displayMember,
                                                     ComboBox combo)

        {
            DataTable dtAux = new DataTable();
            dtAux = dt.Clone();
            DataRow drFila = dtAux.NewRow();

            drFila[0] = "-1";
            drFila[1] = "----Seleccionar----";
            dtAux.Rows.Add(drFila);

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dRows in dt.Select())
                {
                    dtAux.ImportRow(dRows);
                }

                combo.DataSource = dtAux;
                combo.DisplayMember = displayMember;
                combo.ValueMember = valueMember;

                combo.AutoCompleteMode = AutoCompleteMode.None;
                combo.AutoCompleteSource = AutoCompleteSource.None;
                combo.DropDownStyle = ComboBoxStyle.DropDownList;
            }
        }


        /*public static void configurarCombo(DataTable dtDatosCombo, string valueMember, string displayMember, ComboBox combo)
        {

        }*/
        public static void llenarCombo(DataTable datosCombo,
                                       string valueMember,
                                       string displayMember,
                                       ComboBox combo)
        {
            /*DataTable dt = new DataTable();
            DataRow drFila = dt.NewRow();

            dt.Columns.Add(valueMember);
            dt.Columns.Add(displayMember);
            drFila[0] = "-1";
            drFila[1] = "----Seleccionar----";
            dt.Rows.Add(drFila);
            using (SqlDataAdapter adaptador = new SqlDataAdapter(query, UsuarioActual.getConexion()))
            {
                adaptador.Fill(dt);
            }
            */if (datosCombo.Rows.Count > 0)
            {
                combo.DataSource = datosCombo;
                combo.DisplayMember = displayMember;
                combo.ValueMember = valueMember;

                combo.AutoCompleteMode = AutoCompleteMode.None;
                combo.AutoCompleteSource = AutoCompleteSource.None;
                combo.DropDownStyle = ComboBoxStyle.DropDownList;
            }
        }
        public static void llenarComboDependiente(ComboBox comboPadre, ComboBox comboHijo, string query)
        {
            if (comboPadre.SelectedIndex > 0)
            {
                string filtro = (comboPadre.SelectedIndex == 0) ? ConstanteGeneral.PREDETERMINADA : comboPadre.SelectedValue.ToString();
                GeneralUI.llenarCombo(query + " " + filtro + "",
                                     ConstanteGeneral.VALUEMEMBER,
                                     ConstanteGeneral.DISPLAYMEMBER,
                                     comboHijo);
                validarComboUbicacion(comboPadre, comboHijo);
            }
        }

        public static void validarComboUbicacion(ComboBox cbUbicacion,
                                                    ComboBox cbDeshabilitar)
        {
            if (cbUbicacion.SelectedIndex > 0)
            {
                cbDeshabilitar.Enabled = true;
            }
            else
            {
                cbDeshabilitar.Enabled = false;
            }
        }

        public static void cargarCombosDatatable(DataTable dt, Int32 idParametro, ComboBox combo)
        {
            DataTable dtC = new DataTable();
            DataRow[] filas;
            dtC = dt.Clone();
            filas = dt.Select("idParametro=" + idParametro);
            foreach (DataRow fila in filas)
            {
                dtC.ImportRow(fila);
            }
            dtC.Columns.Remove("idParametro");
            llenarComboDatosDefinidor(dtC, ConstanteGeneral.VALUEMEMBER, ConstanteGeneral.DISPLAYMEMBER, combo);
        }

    }
}
