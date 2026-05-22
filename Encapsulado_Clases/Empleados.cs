using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulado_Clases
{
    public class Empleados
    {
        private String idempleado;
        private String nombre;
        private String apellido;
        private double salario;
        private String correo;
        private String cargo;
        private String horassem;

        public Empleados()
        {
        }

        public Empleados(String idempleado, String nombre, String apellido, double salario, String correo, String cargo, String horassem)
        {
            this.idempleado = idempleado;
            this.nombre = nombre;
            this.apellido = apellido;
            this.salario = salario;
            this.correo = correo;
            this.cargo = cargo;
            this.horassem = horassem;
        }

        public string Idempleado { get => idempleado; set => idempleado = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public double Salario { get => salario; set => salario = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Cargo { get => cargo; set => cargo = value; }
        public string Horassem { get => horassem; set => horassem = value; }
    }
}
