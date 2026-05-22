using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Participantes_Clases
{
    public class pruebaxddd
    {
        private String nombre;
        private String apellido;
        private String correo;
      

        public pruebaxddd()
        {
        }

        public pruebaxddd(string nombre, string apellido, string correo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.correo = correo;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Correo { get => correo; set => correo = value; }
    }
}
