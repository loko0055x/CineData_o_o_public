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
    public partial class FrmDulceria : Form
    {
        public FrmDulceria()
        {
            InitializeComponent();
            inabilitarbotonessiescero();
            mostrarfotonombre();

        }
        private void mostrarfotonombre()
        {

            SalaConectar_BD.mostrarfoto(FrmEscogerPelicula.codigogeneral, pix);
            Salas s = SalaConectar_BD.sa;
            lvlcodigo.Text = "" + s.Idsala;
            lvlnombre.Text = "" + s.Nombrepelicula;
        }


        private void label170_Click(object sender, EventArgs e)
        {

        }

        private void pixsalir_Click(object sender, EventArgs e)
        {
            FrmEscogerPelicula op = new FrmEscogerPelicula();
            op.Visible = true;
            this.Hide();
        }

        private void FrmDulceria_Load(object sender, EventArgs e)
        {

        }
        public static double sumadulces;
        public static double subtotaldulces;

        public static List<Dulceria> arreglodulces = new List<Dulceria>();
        void prueba()
        {


            //si es mayor o igual a 1 quiere decir que fue escogido cierta dulceria
            for (int i = 0; i < 6; i++)
            {
                if (arreglo[i] >= 1)
                {
                    Console.WriteLine("LISTANDO DULCES");

                    DulceriaConectar_BD.listardulces(i + 1);
                    Dulceria d = DulceriaConectar_BD.dul;
                    d.Cantidad = arreglo[i];
                    sumadulces = d.Cantidad * d.Precio;
                    subtotaldulces = subtotaldulces + sumadulces;
                    arreglodulces.Add(d);
                    Console.WriteLine("etro y "+d);

                }
            }
        }
        public void prueba322()
        {
            foreach (Dulceria d in arreglodulces)
            {
                Console.WriteLine("" + d.Nomdulceria);
                Console.WriteLine("" + d.Precio);
                Console.WriteLine("" + d.Cantidad);

            }
        }
        int num1;
        int num2;
        int num3;
        int num4;
        int num5;
        int num6;

        int[] arreglo = new int[6];
        Button[] arr = new Button[6];

        private void inabilitarbotonessiescero()
        {
            arreglo[0] = num1;
            arreglo[1] = num2;
            arreglo[2] = num3;
            arreglo[3] = num4;
            arreglo[4] = num5;
            arreglo[5] = num6;

            arr[0] = btnmenos1;
            arr[1] = btnmenos2;
            arr[2] = btnmenos3;
            arr[3] = btnmenos4;
            arr[4] = btnmenos5;
            arr[5] = btnmenos6;

            for (int i = 0; i < 6; i++)
            {
                if (arreglo[i] == 0)
                {
                    arr[i].Enabled = false;
                }
                else
                {
                    arr[i].Enabled = true;
                }
            }

        }


        int num;
        Button[] btn = new Button[6];

        private void solo10dulces()
        {
            btn[0] = btnmas1;
            btn[1] = btnmas2;
            btn[2] = btnmas3;
            btn[3] = btnmas4;
            btn[4] = btnmas5;
            btn[5] = btnmas6;

            num = num1 + num2 + num3 + num4 + num5 + num6;

            if (num == 10)
            {
                Utilidades.mostrarmensaje("Nose puede escoger mas de 10 Dulcesxd");
                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false;
                }
            }
            else
            {
                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = true;
                }
            }

        }

        private void btnsiguiente_Click(object sender, EventArgs e)
        {
            
        }

    

        private void btnmas1_Click(object sender, EventArgs e)
        {
            num1++;
            lblcombo1.Text = "" + num1;
            inabilitarbotonessiescero();
            solo10dulces();
        }

        private void btnmenos1_Click(object sender, EventArgs e)
        {
            num1--;
            lblcombo1.Text = "" + num1;
            inabilitarbotonessiescero();
            solo10dulces();

        }

        private void btnmas2_Click(object sender, EventArgs e)
        {
            num2++;
            lblcombo2.Text = "" + num2;
            inabilitarbotonessiescero();
            solo10dulces();

        }
        private void btnmenos2_Click(object sender, EventArgs e)
        {
            num2--;
            lblcombo2.Text = "" + num2;
            inabilitarbotonessiescero();
            solo10dulces();

        }

        private void btnmas3_Click(object sender, EventArgs e)
        {
            num3++;
            lblcombo3.Text = "" + num3;
            inabilitarbotonessiescero();
            solo10dulces();


        }
        private void btnmenos3_Click(object sender, EventArgs e)
        {
            num3--;
            lblcombo3.Text = "" + num3;
            inabilitarbotonessiescero();
            solo10dulces();

        }


        private void btnmas4_Click(object sender, EventArgs e)
        {
            num4++;
            lblcombo4.Text = "" + num4;
            inabilitarbotonessiescero();
            solo10dulces();

        }



        private void btnmenos4_Click(object sender, EventArgs e)
        {
            num4--;
            lblcombo4.Text = "" + num4;
            inabilitarbotonessiescero();
            solo10dulces();

        }

        private void btnmas5_Click(object sender, EventArgs e)
        {
            num5++;
            lblcombo5.Text = "" + num5;
            inabilitarbotonessiescero();
            solo10dulces();

        }
        private void btnmenos5_Click(object sender, EventArgs e)
        {
            num5--;
            lblcombo5.Text = "" + num5;
            inabilitarbotonessiescero();
            solo10dulces();

        }

        private void btnmas6_Click(object sender, EventArgs e)
        {
            num6++;
            lblcombo6.Text = "" + num6;
            inabilitarbotonessiescero();
            solo10dulces();


        }
        private void btnmenos6_Click(object sender, EventArgs e)
        {
            num6--;
            lblcombo6.Text = "" + num6;
            inabilitarbotonessiescero();
            solo10dulces();

        }

        private void BtnSiguiente_Click(object sender, EventArgs e)
        {
            Console.WriteLine("--------------------------Dulceria cine data----------------------------------------");
            prueba();
            prueba322();
            FrmMetodoPago op = new FrmMetodoPago();
            op.Visible = true;
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
