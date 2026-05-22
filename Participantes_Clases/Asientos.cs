using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Participantes_Clases
{
    public class Asientos
    {
        private int numasiento;
        private int idsala;
        private String estado;

        public Asientos()
        {
        }

        public Asientos(int numasiento, int idsala, String estado)
        {
            this.numasiento = numasiento;
            this.idsala = idsala;
            this.estado = estado;
        }

        public int Numasiento { get => numasiento; set => numasiento = value; }
        public int Idsala { get => idsala; set => idsala = value; }
        public string Estado { get => estado; set => estado = value; }

    }
}
