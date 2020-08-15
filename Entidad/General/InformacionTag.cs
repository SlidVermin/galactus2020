using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad.General
{
    public class InformacionTag
    {
        private int idMenu;
        private string nombre;
        private string nombreForm;

        public int IdMenu
        {
            get
            {
                return idMenu;
            }

            set
            {
                idMenu = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public string NombreForm
        {
            get
            {
                return nombreForm;
            }

            set
            {
                nombreForm = value;
            }
        }
    }
}
