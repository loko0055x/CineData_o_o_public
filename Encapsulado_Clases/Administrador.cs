using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulado_Clases
{
    public class Administrador
    {
        private int dni;
        private String nombre;
        private String apellido;
        private double salario;
        private String correo;
        private String contrasenia;
        private String dirreccion;
        private int celular;
        private String sexo;
        private DateTime fecha;



        public Administrador()
        {
        }

        public Administrador(int dni, String nombre, String apellido, double salario, String correo, String contraseña, String dirreccion, int celular, String sexo, DateTime fecha)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.apellido = apellido;
            this.salario = salario;
            this.correo = correo;
            this.contrasenia = contraseña;
            this.dirreccion = dirreccion;
            this.celular = celular;
            this.sexo = sexo;
            this.fecha = fecha;
        }

        public Administrador(string correo, string contra)
        {
            this.correo = correo;
            this.contrasenia = contra;

        }



        public int Dni {
            get => dni; set => dni = value; }
        public string Nombre {
            get => nombre; set => nombre = value; }
        public string Apellido {
            get => apellido; set => apellido = value; }
        public double Salario { 
            get => salario; set => salario = value; }
        public string Correo { 
            get => correo; set => correo = value; }
        public string Contrasenia {
            get => contrasenia; set => contrasenia = value; }
        public string Dirreccion {
            get => dirreccion; set => dirreccion = value; }
        public int Celular {
            get => celular; set => celular = value; }
        public string Sexo {
            get => sexo; set => sexo = value; }
        public DateTime Fecha { 
            get => fecha; set => fecha = value; }
    }
}
