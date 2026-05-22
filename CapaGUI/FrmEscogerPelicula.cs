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

namespace CapaGUI
{
    public partial class FrmEscogerPelicula : Form
    {
        public FrmEscogerPelicula()
        {
            InitializeComponent();
            prueba();
        }

        private void FrmEscogerPelicula_Load(object sender, EventArgs e)
        {
            retornarnombres();
        }
        public static int codigogeneral;
        void retornarnombres()
        {
            if (Frm_IniciarSecion.estadoiniciarsecion == true)
            {
                ClientePremiun cli = new ClientePremiun(Frm_IniciarSecion.dni, Frm_IniciarSecion.contra);
                ClienteConectar_BD.retornardatosclientes(cli);
                ClientePremiun x = ClienteConectar_BD.c;
                txtnomusuario.Text = "Bienvenido señor@ " + x.Nombre + " " + x.Apellido;
                mnuiniciarsecion.Enabled = false;
                mnuregistrarse.Enabled = false;
            }
            else if (FrmRegistro.estadoregistrarse == true)
            {
                ClientePremiun cl = new ClientePremiun(FrmRegistro.dni, FrmRegistro.contra);
                ClienteConectar_BD.retornardatosclientes(cl);
                cl = ClienteConectar_BD.c;
                txtnomusuario.Text = "Bienvenido señor@ " + cl.Nombre + " " + cl.Apellido;
                mnuiniciarsecion.Enabled = false;
                mnuregistrarse.Enabled = false;

            }


        }
        void prueba()
        {



            PictureBox[] arreglo = new PictureBox[6];
            arreglo[0] = pix1;
            arreglo[1] = pix2;
            arreglo[2] = pix3;
            arreglo[3] = pix4;
            arreglo[4] = pix5;
            arreglo[5] = pix6;

            for (int i = 0; i < arreglo.Length; i++)
            {
                SalaConectar_BD.mostrarfoto(i + 1, arreglo[i]);
            }

        }

        private void rjcFecha_Click(object sender, EventArgs e)
        {

        }

       

        private void HoraFecha_Tick(object sender, EventArgs e)
        {
            txtfecha.Text = DateTime.Now.ToString("F");


        }
        private void irformulario(Form op)
        {
            op.Visible = true;
            this.Hide();
        }

        private void pixsalir_Click(object sender, EventArgs e)
        {
            FrmEscogerPelicula op = new FrmEscogerPelicula();
            irformulario(op);

       //     Dispose();
        }


        private void mnuregistrarse_Click(object sender, EventArgs e)
        {
            FrmRegistro op = new FrmRegistro();
            irformulario(op);
        }

        private void iniciarSecionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mnuiniciarsecion_Click(object sender, EventArgs e)
        {
            Frm_IniciarSecion op = new Frm_IniciarSecion();
            op.Visible = true;
            this.Hide();
        }

        private void rjCiruclarPictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void BtnTrailers_Click(object sender, EventArgs e)
        {
            btnPeliculas.Enabled = false;
            pix1.Visible= false;
            pix2.Visible = false;
            pix3.Visible = false;
            pix4.Visible = false;
            pix5.Visible = false;
            pix6.Visible = false;
          
            abrirformhija(new FrmTrailer());
        }

        private void btnPeliculas_Click(object sender, EventArgs e)
        {

            pix1.Visible = true;
            pix2.Visible = true;
            pix3.Visible = true;
            pix4.Visible = true;
            pix5.Visible = true;
            pix6.Visible = true;
        }

        private void BtnDulceria_Click(object sender, EventArgs e)
        {

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

        private void pix1_Click_1(object sender, EventArgs e)
        {
            codigogeneral = 1;

            FrmButacas op = new FrmButacas();
            irformulario(op);
        }

        private void pix2_Click_1(object sender, EventArgs e)
        {
            codigogeneral = 2;

            FrmButacas op = new FrmButacas();
            irformulario(op);
        }

        private void pix3_Click_1(object sender, EventArgs e)
        {
            codigogeneral = 3;

            FrmButacas op = new FrmButacas();
            irformulario(op);
        }

        private void pix4_Click_1(object sender, EventArgs e)
        {
            codigogeneral = 4;

            FrmButacas op = new FrmButacas();
            irformulario(op);
        }

        private void pix5_Click_1(object sender, EventArgs e)
        {
            codigogeneral = 5;

            FrmButacas op = new FrmButacas();
            irformulario(op);
        }

        private void pix6_Click_1(object sender, EventArgs e)
        {
            codigogeneral = 6;

            FrmButacas op = new FrmButacas();
            irformulario(op);
        }
    }
}
