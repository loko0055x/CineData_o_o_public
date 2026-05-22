using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista__GUI_
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
            Application.Run(new JrmEscogerpelicula());
             //Application.Run(new JrmMetodoPago());
          /*  string texto = "";
            if (texto.Length >0)
            {
                Console.WriteLine("es mas de 1  " + texto.Length);
            }
            else {
                Console.WriteLine("esta mal o vacio" + texto.Length);
            }
          */




        }
    }
}
