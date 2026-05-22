using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaGUI
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //  Application.Run(new FrmEscogerPelicula());
            // Application.Run(new Frm_Empleados());
           //Application.Run(new FrmEdicionPelicula());
          Application.Run(new FrmEscogerPelicula());

           // Application.Run(new FrmAdministradores());

        }

           
        }
    }

