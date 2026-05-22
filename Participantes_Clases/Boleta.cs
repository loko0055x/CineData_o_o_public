using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Participantes_Clases
{
    public class Boleta
    {
        private String nombre;
        private String apellido;
        private String correo;
        private String nombrepeli;
        private double subtotalentradas;
        private double subtotaldulceria;
        private String tipopago;
        private double total;

        public Boleta()
        {
        }

        public Boleta( String nombre, String apellido, String correo, String nombrepeli, double subtotalentradas, double subtotaldulceria, String tipopago, double total)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.correo = correo;
            this.nombrepeli = nombrepeli;
            this.subtotalentradas = subtotalentradas;
            this.subtotaldulceria = subtotaldulceria;
            this.tipopago = tipopago;
            this.total = total;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Nombrepeli { get => nombrepeli; set => nombrepeli = value; }
        public double Subtotalentradas { get => subtotalentradas; set => subtotalentradas = value; }
        public double Subtotaldulceria { get => subtotaldulceria; set => subtotaldulceria = value; }
        public string Tipopago { get => tipopago; set => tipopago = value; }
        public double Total { get => total; set => total = value; }
    }
}
