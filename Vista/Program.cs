using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vista.General;

namespace Vista
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.ThreadException += new ThreadExceptionEventHandler(ManejadorExcepcion.Form_UIThreadException);
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);    

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginUI());
        }
    }
}
