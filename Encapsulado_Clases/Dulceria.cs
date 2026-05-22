using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulado_Clases
{
    public class Dulceria
    {
        private int iddulceria;
        private String nomdulceria;
        private double precio;
        private int cantidad;

        public Dulceria()
        {
        }

        public Dulceria(int iddulceria, String nomdulceria, double precio, int cantidad)
        {
            this.iddulceria = iddulceria;
            this.nomdulceria = nomdulceria;
            this.precio = precio;
            this.cantidad = cantidad;
        }

        public int Iddulceria { get => iddulceria; set => iddulceria = value; }
        public string Nomdulceria { get => nomdulceria; set => nomdulceria = value; }
        public double Precio { get => precio; set => precio = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
    }
}
