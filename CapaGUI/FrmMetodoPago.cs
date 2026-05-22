using CapaNegocio;
using Encapsulado_Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilidades_Proyecto;

namespace CapaGUI
{
    public partial class FrmMetodoPago : Form
    {
        public FrmMetodoPago()
        {
            InitializeComponent();
            retornarnombresycooreo();
        }

        private void FrmMetodoPago_Load(object sender, EventArgs e)
        {

        }

        void retornarnombresycooreo()
        {
            if (Frm_IniciarSecion.estadoiniciarsecion == true)
            {
                ClientePremiun cli = new ClientePremiun(Frm_IniciarSecion.dni, Frm_IniciarSecion.contra);
                ClienteConectar_BD.retornardatosclientes(cli);
                ClientePremiun x = ClienteConectar_BD.c;
                txtnombres.Text = "" + x.Nombre + " " + x.Apellido;
                txtcorreo.Text = "" + x.Correo;
                inabilitartexbox();

            }
            else if (FrmRegistro.estadoregistrarse == true)
            {
                ClientePremiun cl = new ClientePremiun(FrmRegistro.dni, FrmRegistro.contra);
                ClienteConectar_BD.retornardatosclientes(cl);
                cl = ClienteConectar_BD.c;
                txtnombres.Text = "" + cl.Nombre + " " + cl.Apellido;
                txtcorreo.Text = "" + cl.Correo;
                inabilitartexbox();


            }
        }

        private void abrirformhija(object formhija)
        {


            if (this.contenedor.Controls.Count > 0)//si existe algun control en el interior del panel   
                this.contenedor.Controls.RemoveAt(0);//si es verdadero lo eliminamos
                                                     //sino no funciona xd
            Form jrm = formhija as Form;
            jrm.TopLevel = false;//con esto le decimos que no es un formulario de nivel superior  o
                                 //formulario segundario
            jrm.Dock = DockStyle.Fill;//se acople a todo el panel contenedor
            this.contenedor.Controls.Add(jrm);
            this.contenedor.Tag = jrm;
            jrm.Show();







        }
        public static string nombres;
        public static string apellido;
        public static string correo;
        int habilitarradiobutton()
        {
            int valor = 0;

            if (txtnombres.Text.Length > 0 && txtcorreo.Text.Length > 0)
            {
                string[] token = txtnombres.Text.Split(' ');
                try
                {
                    nombres = token[0];
                    apellido = token[1];
                    correo = txtcorreo.Text;
                    valor = 1;

                }
                catch (Exception ex)
                {
                    Utilidades.mostrarmensaje("error falta nombre completo" + ex.Message);

                }

            }

            else
            {
                Utilidades.mostrarmensaje("Erro falta rellenar campos");
            }

            return valor;
        }

        void inabilitartexbox() {
            txtnombres.Enabled = false;
            txtcorreo.Enabled = false;
        }

        private void rbtpago1_CheckedChanged(object sender, EventArgs e)
        {
            if (habilitarradiobutton() == 1)
            {
                abrirformhija(new Pago_BBVA());
            //    inabilitartexbox();

            }
        }

        private void rbtpago2_CheckedChanged(object sender, EventArgs e)
        {
            if (habilitarradiobutton() == 1)
            {
                abrirformhija(new Pago_Paypal());
              //  inabilitartexbox();

            }
        }

        private void rbtpago3_CheckedChanged(object sender, EventArgs e)
        {
            if (habilitarradiobutton() == 1)
            {
                abrirformhija(new Pago_Yape());
              //  inabilitartexbox();

            }
        }

        private void btnimprimir_Click(object sender, EventArgs e)
        {
            Console.WriteLine("--------------Consola-----------------");
            Console.WriteLine("Nombre dela pelicula " + FrmButacas.nombresala);

            Console.WriteLine("Numero De asiento escogido ");

            foreach (string op in FrmButacas.arreglo)
            {
                Console.WriteLine(op);
            }
            Console.WriteLine("EL SUB TOTAL DELAS ENTRADAS ES " + FrmEntradas.subtotalentradas);

            Console.WriteLine("Entradas");
            Console.WriteLine("Tipo Entrada         Precio   Cantidad");
            foreach (TipoEntrada xd in FrmEntradas.arreglo)
            {
                Console.Write("" + xd.Entrada + "       " + xd.Precio + "      " + xd.Cantidad);
                Console.WriteLine("");

            }
            Console.WriteLine("\nDulceria");
            Console.WriteLine("Nombre combo  Precio  Cantidad");
            foreach (Dulceria d in FrmDulceria.arreglodulces)
            {
                Console.Write("    " + d.Nomdulceria + "    " + d.Precio + "       " + d.Cantidad);

            }
            Console.WriteLine("EL SUB TOTAL DELA DULCERIA " + FrmDulceria.subtotaldulces);


            Console.WriteLine("");
            Console.WriteLine("EL monto total a pagar es " + (FrmEntradas.subtotalentradas + FrmDulceria.subtotaldulces));
        }
    }
}
