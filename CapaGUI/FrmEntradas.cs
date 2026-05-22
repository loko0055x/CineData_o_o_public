using CapaNegocio;
using Encapsulado_Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaGUI
{
    public partial class FrmEntradas : Form
    {
        public FrmEntradas()
        {
            InitializeComponent();
            lavelesxd();

            inabilitarbotonsiescero();
            lvlcantidad.Text = "" + FrmButacas.contador;
            btnsiguiente.Enabled = false;
            retornarbeneficios();
            if (0== FrmButacas.contador)
            {
                MessageBox.Show("Error no se escogio nada ");
                this.Dispose();
            }
        }

        private void FrmEntradas_Load(object sender, EventArgs e)
        {
        }
        static int filas = 3;
        static int columnas = 1;

        //int ejex = 350;//este es para mas ala derecha 
        int ejex = 283;//este es para mas ala derecha 
        int ejey = 99;//este es para mas abajo
                    //    int ejey = 110;//este es para mas abajo
        public Label[,] matriz = new Label[filas, columnas];


        static int num1;
        static int num2;
        static int num3;


        //metodo que invente para poner lavels
        public void lavelesxd()
        {
           
            matriz = new Label[filas, columnas];
            int xxx = 0;
            for (int i = 0; i < 3; i++)
            {//fila
                for (int j = 0; j < 1; j++)
                {//columna
                    matriz[i, j] = new Label();
                    matriz[i, j].SetBounds(ejex, ejey, 50, 20);
                    matriz[i, j].Text = "" + xxx;//mensaje

                    panel1.Controls.Add(matriz[i, j]);



                    ejey += 80;
                    //recuerda que el ejex y ejey son la posicion delos lavels nomas             
                }
            }
            num1 = int.Parse(matriz[0, 0].Text);
            num2 = int.Parse(matriz[1, 0].Text);
            num3 = int.Parse(matriz[2, 0].Text);

        }

        int[] arr = new int[3];
        private void inabilitarbotonsiescero()
        {
            arr[0] = num1;
            arr[1] = num2;
            arr[2] = num3;
            Button[] btn = new Button[3];
            btn[0] = btnmenosgeneral;
            btn[1] = btnmenos60anios;
            btn[2] = btnniniosmenos;
            for (int i = 0; i < 3; i++)
            {
                if (arr[i] == 0)
                {
                    btn[i].Enabled = false;
                }
                else
                {
                    btn[i].Enabled = true;
                }
            }

        }
        public static double sumaentradas;
        public static double subtotalentradas;


        public static List<TipoEntrada> arreglo = new List<TipoEntrada>();
        void verentradasescogida()
        {
            for (int i = 0; i < 3; i++)
            {
                if (arr[i] >= 1)
                {
                    TipoEntrada op = new TipoEntrada();
                    EntradaConectar_BD.mostrardulceriaescogida(i + 1);//aea
                    op = EntradaConectar_BD.en;
                    sumaentradas = op.Precio * arr[i];
                    subtotalentradas = subtotalentradas + sumaentradas;
                    op.Cantidad = arr[i];
                    arreglo.Add(op);

                }
            }
        }

        void retornarbeneficios()
        {
            if (Frm_IniciarSecion.estadoiniciarsecion == true || FrmRegistro.estadoregistrarse == true)
            {
                pixfeliz.ImageLocation = "C:/Users/USER/Downloads/CineDataDefinitivo/CapaGUI/Imagenes/cara-feliz.png";
                pixfeliz.SizeMode = PictureBoxSizeMode.StretchImage;
                lvlletra.Text = "Felicidades Eres Beneficiario";
            }
            else
            {
                pixfeliz.ImageLocation = "C:/Users/USER/Downloads/CineDataDefinitivo/CapaGUI/Imagenes/cara-triste.png";
                pixfeliz.SizeMode = PictureBoxSizeMode.StretchImage;
                lvlletra.Text = "Uy que mal no eres beneficiario";


            }


        }


        private int suma()
        {
            int suma = num1 + num2 + num3;
            return suma;
        }

        private void siesmayoralacantidadescogida()
        {

            if (suma() == FrmButacas.contador)
            {
                btnmasgeneral.Enabled = false;
                btnmas60anios.Enabled = false;
                btnniniosmas.Enabled = false;
                btnsiguiente.Enabled = true;
            }
            else
            {
                btnmasgeneral.Enabled = true;
                btnmas60anios.Enabled = true;
                btnniniosmas.Enabled = true;
                btnsiguiente.Enabled = false;

            }
        }

        private void btnformbutacas_Click(object sender, EventArgs e)
        {
           
        }

        private void btnsiguiente_Click(object sender, EventArgs e)
        {
           
        }

        private void btnmasgeneral_Click(object sender, EventArgs e)
        {
            num1++;
            matriz[0, 0].Text = "" + num1;
            inabilitarbotonsiescero();
            siesmayoralacantidadescogida();

        }

        private void btnmenosgeneral_Click(object sender, EventArgs e)
        {
            num1--;
            matriz[0, 0].Text = "" + num1;
            inabilitarbotonsiescero();
            siesmayoralacantidadescogida();

        }
        private void btnmas60anios_Click(object sender, EventArgs e)
        {
            num2++;
            matriz[1, 0].Text = "" + num2;
            inabilitarbotonsiescero();
            siesmayoralacantidadescogida();

        }
        private void btnmenos60anios_Click(object sender, EventArgs e)
        {
            num2--;
            matriz[1, 0].Text = "" + num2;
            inabilitarbotonsiescero();
            siesmayoralacantidadescogida();

        }
        private void btnniniosmas_Click(object sender, EventArgs e)
        {
            num3++;
            matriz[2, 0].Text = "" + num3;
            inabilitarbotonsiescero();
            siesmayoralacantidadescogida();

        }

        private void btnniniosmenos_Click(object sender, EventArgs e)
        {
            num3--;
            matriz[2, 0].Text = "" + num3;
            inabilitarbotonsiescero();
            siesmayoralacantidadescogida();

        }

        private void lvlcantidad_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnSiguiente_Click_1(object sender, EventArgs e)
        {
            //MessageBox.Show("general " + num1 + "\n" +
            /*  "ancianos " + num2 + "\n" +
              "niños" + num3);*/
            int x = 0;
            Console.WriteLine("-----------------------------------------------------------------");
            verentradasescogida();

            foreach (TipoEntrada xd in arreglo)
            {
                x++;
                Console.WriteLine("" + xd.Entrada);
                Console.WriteLine("" + xd.Precio);
                Console.WriteLine("" + xd.Cantidad);

            }
            Console.WriteLine("x tiene " + x + "iteraciones  ");
            FrmDulceria hh = new FrmDulceria();
            hh.Visible = true;
            this.Hide();
        }

        private void btnformbutacass_Click(object sender, EventArgs e)
        {
            FrmButacas op = new FrmButacas();
            op.Visible = true;
            this.Hide();
        }

        private void btnmasgeneral_Click_1(object sender, EventArgs e)
        {
            num1++;
            matriz[0, 0].Text = "" + num1;
            inabilitarbotonsiescero();
            siesmayoralacantidadescogida();
        }

        private void btnmenosgeneral_Click_1(object sender, EventArgs e)
        {
            num1--;
            matriz[0, 0].Text = "" + num1;
            inabilitarbotonsiescero();
            siesmayoralacantidadescogida();
        }

        private void btnmas60anios_Click_1(object sender, EventArgs e)
        {
            num2++;
            matriz[1, 0].Text = "" + num2;
            inabilitarbotonsiescero();
            siesmayoralacantidadescogida();
        }

        private void btnmenos60anios_Click_1(object sender, EventArgs e)
        {
            num2--;
            matriz[1, 0].Text = "" + num2;
            inabilitarbotonsiescero();
            siesmayoralacantidadescogida();
        }

        private void btnniniosmas_Click_1(object sender, EventArgs e)
        {
            num3++;
            matriz[2, 0].Text = "" + num3;
            inabilitarbotonsiescero();
            siesmayoralacantidadescogida();
        }

        private void btnniniosmenos_Click_1(object sender, EventArgs e)
        {
            num3--;
            matriz[2, 0].Text = "" + num3;
            inabilitarbotonsiescero();
            siesmayoralacantidadescogida();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
