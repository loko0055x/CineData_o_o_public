using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulado_Clases
{
    public class Boleta
    {

        private String nombre;
        private String apellido;
        private String correo;
        private String nombrepeli;
        private List<TipoEntrada> arregloentrada;
        private double subtotalentradas;
        private List<Dulceria> arreglodul;
        private double subtotaldulceria;
        private String tipopago;
        private double total;
        private List<Nombresala> arreglobutacas;
        private DateTime fecha;
        public Boleta()
        {
        }

        public Boleta(string nombre, string apellido, string correo, string nombrepeli, double subtotalentradas, double subtotaldulceria, string tipopago, double total)
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

        public Boleta(string nombre, string apellido, string correo, string nombrepeli, List<TipoEntrada> arregloentrada, double subtotalentradas, List<Dulceria> arreglodul, double subtotaldulceria, string tipopago, double total, List<Nombresala> arreglobutacas, DateTime fecha)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.correo = correo;
            this.nombrepeli = nombrepeli;
            this.arregloentrada = arregloentrada;
            this.subtotalentradas = subtotalentradas;
            this.arreglodul = arreglodul;
            this.subtotaldulceria = subtotaldulceria;
            this.tipopago = tipopago;
            this.total = total;
            this.arreglobutacas = arreglobutacas;
            this.fecha = fecha;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Nombrepeli { get => nombrepeli; set => nombrepeli = value; }
        public List<TipoEntrada> Arregloentrada { get => arregloentrada; set => arregloentrada = value; }
        public double Subtotalentradas { get => subtotalentradas; set => subtotalentradas = value; }
        public List<Dulceria> Arreglodul { get => arreglodul; set => arreglodul = value; }
        public double Subtotaldulceria { get => subtotaldulceria; set => subtotaldulceria = value; }
        public string Tipopago { get => tipopago; set => tipopago = value; }
        public double Total { get => total; set => total = value; }
        public List<Nombresala> Arreglobutacas { get => arreglobutacas; set => arreglobutacas = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
    }
}
