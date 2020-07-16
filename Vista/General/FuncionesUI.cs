using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista.General
{
    public class FuncionesUI
    {

        public static void validarValoresNumericos(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 46 || e.KeyChar == 44)
            {
                e.KeyChar = char.Parse(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator);
            }
            if (e.KeyChar >= 48 && e.KeyChar <= 57 || e.KeyChar == 8 || e.KeyChar == char.Parse(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
