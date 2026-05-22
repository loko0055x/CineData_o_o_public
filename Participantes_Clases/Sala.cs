using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Participantes_Clases
{
    public class Sala
    {

        private int idsala;
        private String nombrepelicula;
        private String linkpeli ;



        public Sala()
        {

        }

        public Sala(int idsala, String nombrepelicula,string link)
        {
            this.idsala = idsala;
            this.nombrepelicula = nombrepelicula;
            this.linkpeli = link;
        }

        public int Idsala { get => idsala; set => idsala = value; }
        public string Nombrepelicula { get => nombrepelicula; set => nombrepelicula = value; }
        public string Linkpeli { get => linkpeli; set => linkpeli = value; }
    }
}
