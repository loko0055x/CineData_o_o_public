using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulado_Clases
{
    public class Nombresala
    {
        private int codigo;
        private string nomsala;


        public Nombresala(int codigo, string nomsala)
        {
            this.codigo = codigo;
            this.nomsala = nomsala;
        }
        public Nombresala() { 
        }


        public int Codigo { get => codigo; set => codigo = value; }
        public string Nomsala { get => nomsala; set => nomsala = value; }
    }
}
