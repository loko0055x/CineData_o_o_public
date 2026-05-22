using Controlador_Conectar_BD;
using Participantes_Clases;
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

namespace Vista__GUI_
{
    public partial class JrmMetodoPago : Form
    {
        public JrmMetodoPago()
        {
            InitializeComponent();
            retornarnombresycooreo();
        }

        void retornarnombresycooreo()
        {
            if (Jrm_IniciarSecion.estadoiniciarsecion == true)
            {
                Cliente_Premiun cli = new Cliente_Premiun(Jrm_IniciarSecion.dni, Jrm_IniciarSecion.contra);
                ClienteConectar_BD.retornardatosclientes(cli);
                Cliente_Premiun x = ClienteConectar_BD.c;
                txtnombres.Text = "" + x.Nombre + "" + x.Apellido;
                txtcorreo.Text = "" + x.Correo;
                txtnombres.Enabled = false;
                txtcorreo.Enabled = false;
            }
            else if (JrmRegistrar.estadoregistrarse == true)
            {
                Cliente_Premiun cl = new Cliente_Premiun(JrmRegistrar.dni, JrmRegistrar.contra);
                ClienteConectar_BD.retornardatosclientes(cl);
                cl = ClienteConectar_BD.c;
                txtnombres.Text = "" + cl.Nombre + "" + cl.Apellido;
                txtcorreo.Text = "" + cl.Correo;
                txtnombres.Enabled = false;
                txtcorreo.Enabled = false;

            }
        }

            private void JrmMetodoPago_Load(object sender, EventArgs e)
        {

        }



       /* public static agregarboleta(bo) { 
        
        }
       */


        /* private void abrirformsxd<mitipo>() where mitipo : Form, new() { 

         }
        */
        public static string nombres;
        public static string apellido;
        public static string correo;
        int  habilitarradiobutton() {
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
                    Utilidades.mostrarmensaje("error falta nombre completo"+ex.Message);
                
                }
                
            }
         
            else {
                Utilidades.mostrarmensaje("Erro falta rellenar campos");
            }

            return valor;
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
   

        private void rbtpago1_CheckedChanged(object sender, EventArgs e)
        {
           if (habilitarradiobutton()==1)
            {
                abrirformhija(new Pago_BBVA());
                txtcorreo.Enabled = false;
                txtnombres.Enabled = false;

            }

        }

        private void rbtpago2_CheckedChanged(object sender, EventArgs e)
        {
        

           if (habilitarradiobutton() == 1)
            {
                  abrirformhija(new Pago_Paypal());
                txtcorreo.Enabled = false;
                txtnombres.Enabled = false;
            }

        }

        private void rbtpago3_CheckedChanged(object sender, EventArgs e)
        {

            if (habilitarradiobutton() == 1)
            {
                 abrirformhija(new Pago_Yape());
                txtcorreo.Enabled = false;
                txtnombres.Enabled = false;
            }

        }

        private void btnimprimir_Click(object sender, EventArgs e)
        {
            Console.WriteLine("--------------Consola-----------------");
            Console.WriteLine("Nombre dela pelicula " + JrmButacas.nombresala);

            Console.WriteLine("Numero De asiento escogido ");
            
            foreach (string op in JrmButacas.arreglo)
            {
                Console.WriteLine(op);
            }
            Console.WriteLine("EL SUB TOTAL DELAS ENTRADAS ES " +JrmEntradas.subtotalentradas);

            Console.WriteLine("Entradas");
            Console.WriteLine("Tipo Entrada         Precio   Cantidad");
            foreach (TipoEntrada xd in JrmEntradas.arreglo)
            {
                Console.Write("" + xd.Entrada+"       "   +  xd.Precio +  "      "+xd.Cantidad);
                Console.WriteLine("");
                
            }
            Console.WriteLine("\nDulceria");
            Console.WriteLine("Nombre combo  Precio  Cantidad");
            foreach (Dulceria d in JrmDulceria.arreglodulces)
            {
                Console.Write("    " + d.Nomdulceria+     "    "   +d.Precio+"       "    +d.Cantidad );
               
            }
            Console.WriteLine("EL SUB TOTAL DELA DULCERIA " + JrmDulceria.subtotaldulces);


            Console.WriteLine("");
            Console.WriteLine("EL monto total a pagar es "+(JrmEntradas.subtotalentradas+JrmDulceria.subtotaldulces));
        }
    }
}
