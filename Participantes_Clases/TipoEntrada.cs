using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Participantes_Clases
{
    public  class TipoEntrada
    {
       
        private string entrada;
        private float precio;
        private int cantidad;
        public TipoEntrada() { 
        
        }

        public TipoEntrada(string nombre, float precio, int cantidad)
        {
            this.entrada = nombre;
            this.precio = precio;
            this.cantidad = cantidad;
        }

        public string Entrada { get => entrada; set => entrada = value; }
        public float Precio { get => precio; set => precio = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
    }
}
