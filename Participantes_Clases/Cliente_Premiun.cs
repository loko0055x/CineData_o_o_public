using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Participantes_Clases
{
    public class Cliente_Premiun
    {

        private int dni;
        private String nombre;
        private String apellido;
        private int celular;
        private String sexo;
        private String correo;
        private String contraseña;

      
        public Cliente_Premiun(int dni, String nombre, String apellido, int celular, String sexo, String correo, String contraseña)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.apellido = apellido;
            this.celular = celular;
            this.sexo = sexo;
            this.correo = correo;
            this.contraseña = contraseña;
        }

        public Cliente_Premiun()
        {

        }

        public Cliente_Premiun(int dni,string contra) {
            this.dni = dni;
            this.contraseña = contra;

        }

        public int Dni { get => dni; set => dni = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Celular { get => celular; set => celular = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }

    }
}
