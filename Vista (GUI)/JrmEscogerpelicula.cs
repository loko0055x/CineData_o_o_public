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
    public partial class JrmEscogerpelicula : Form
    {
        public JrmEscogerpelicula()
        {
            InitializeComponent();
            prueba();
        }

        private void JrmEscogerpelicula_Load(object sender, EventArgs e)
        {
            retornarnombres();
        }
        void retornarnombres (){
            if (Jrm_IniciarSecion.estadoiniciarsecion==true)
            {
                Cliente_Premiun cli = new Cliente_Premiun(Jrm_IniciarSecion.dni, Jrm_IniciarSecion.contra);
                ClienteConectar_BD.retornardatosclientes(cli);
                Cliente_Premiun x = ClienteConectar_BD.c;
                lvlnombres.Text="Bienvenido señor@ "+x.Nombre + " "+x.Apellido;
                mnuiniciarsecion.Enabled = false;
                mnuregistrarse.Enabled = false;
            }
            else if (JrmRegistrar.estadoregistrarse==true)
            {
                Cliente_Premiun cl = new Cliente_Premiun(JrmRegistrar.dni,JrmRegistrar.contra);
                ClienteConectar_BD.retornardatosclientes(cl);
                cl = ClienteConectar_BD.c;
                lvlnombres.Text = "Bienvenido señor@ " + cl.Nombre + " " + cl.Apellido;
                mnuiniciarsecion.Enabled = false;
                mnuregistrarse.Enabled = false;

            }


        }



        public static int codigogeneral;





        void prueba() {



            PictureBox[] arreglo = new PictureBox[6];
            arreglo[0] = pix1;
            arreglo[1] = pix2;
            arreglo[2] = pix3;
            arreglo[3] = pix4;
            arreglo[4] = pix5;
            arreglo[5] = pix6;

            for (int i = 0; i < arreglo.Length; i++)
            {
                SalaConectar_BD.mostrarfoto(i+1, arreglo[i]);
            }

        }

      

        private void iniciaSecionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Jrm_IniciarSecion op = new Jrm_IniciarSecion();
            op.Visible = true;
            this.Hide();
        }

        private void registrateToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void irformulario(Form op) {
            op.Visible = true;
            this.Hide();
        }

        private void registrateAhoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JrmRegistrar op = new JrmRegistrar();
            irformulario(op);
        }

        private void pix1_Click(object sender, EventArgs e)
        {
            codigogeneral = 1;

            JrmButacas op = new JrmButacas();
            irformulario(op);
        }

        private void pix2_Click(object sender, EventArgs e)
        {
            codigogeneral = 2;
            JrmButacas op = new JrmButacas();
            irformulario(op);

        }

        private void pix3_Click(object sender, EventArgs e)
        {
            codigogeneral = 3;
            JrmButacas op = new JrmButacas();
            irformulario(op);
        }

        private void pix4_Click(object sender, EventArgs e)
        {
            codigogeneral = 4;
            JrmButacas op = new JrmButacas();
            irformulario(op);
        }

        private void pix5_Click(object sender, EventArgs e)
        {
            codigogeneral = 5;
            JrmButacas op = new JrmButacas();
            irformulario(op);
        }

        private void pix6_Click(object sender, EventArgs e)
        {
            codigogeneral = 6;
            JrmButacas op = new JrmButacas();
            irformulario(op);
        }

        private void iniciarSecionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
