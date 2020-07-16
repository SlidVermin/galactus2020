using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.General
{
    public class DigitoVerificacion
    {
        public string documento { get; set; }
        public int digito { get; set; }

        public string quitarsimbolos(string numero)
        {
            numero = numero.Replace(",", string.Empty);
            numero = numero.Replace(".", string.Empty);
            numero = numero.Replace("-", string.Empty);
            numero = numero.Replace(" ", string.Empty);
            numero = numero.Replace("_", string.Empty);
            return numero;
        }
        private void calcularDigito()
        {
            long total = 0;
            int residuo = 0;
            DataTable tabla = new DataTable();
            tabla.Columns.Add("Num", Type.GetType("System.Int32"));
            tabla.Rows.Add(71);
            tabla.Rows.Add(67);
            tabla.Rows.Add(59);
            tabla.Rows.Add(53);
            tabla.Rows.Add(47);
            tabla.Rows.Add(43);
            tabla.Rows.Add(41);
            tabla.Rows.Add(37);
            tabla.Rows.Add(29);
            tabla.Rows.Add(23);
            tabla.Rows.Add(19);
            tabla.Rows.Add(17);
            tabla.Rows.Add(13);
            tabla.Rows.Add(7);
            tabla.Rows.Add(3);

            for (int i = 0; i < 15; i++)
            {
                int digitoIndividual = 0;
                if (documento.Length > i)
                {
                    digitoIndividual= Convert.ToInt32(documento.Substring((i), 1));
                }
                total += digitoIndividual * tabla.Rows[i].Field<int>("Num");
            }
            residuo = Convert.ToInt32(total % 11);
            switch (residuo)
            {
                case 0:
                    digito = 0;
                    break;
                case 1:
                    digito = 1;
                    break;
                default:
                    digito = 11 - residuo;
                    break;

            }
        }
        public int calculaNit(string num)
        {
            num = quitarsimbolos(num);
            string mascara = "";
            for (int indice = 0; indice < 15 - num.Length; indice++)
            {
                mascara += "0";
            }
            documento = string.Format(mascara + "{0}", num);
            calcularDigito();
            return digito;
        }
        
    }
}
