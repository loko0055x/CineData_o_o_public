using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulado_Clases
{
    public class Salas
    {
        private int idsala;
        private String nombrepelicula;
        private String linkpeli;
        //private String url imagen ;



        public Salas()
        {

        }

        public Salas(int idsala, string nombrepelicula, string linkpeli)
        {
            this.idsala = idsala;
            this.nombrepelicula = nombrepelicula;
            this.linkpeli = linkpeli;
        }

        public int Idsala { get => idsala; set => idsala = value; }
        public string Nombrepelicula { get => nombrepelicula; set => nombrepelicula = value; }
        public string Linkpeli { get => linkpeli; set => linkpeli = value; }
    }
}
