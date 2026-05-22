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
    public partial class JrmDulceria : Form
    {
        public JrmDulceria()
        {
            InitializeComponent();
            inabilitarbotonessiescero();
        }


        int num1;
        int num2;
        int num3;
        int num4;
        int num5;
        int num6;

        int[] arreglo = new int[6];
        Button[] arr = new Button[6];

        private void inabilitarbotonessiescero(){
            arreglo[0] = num1;
            arreglo[1] = num2;
            arreglo[2] = num3;
            arreglo[3] = num4;
            arreglo[4] = num5;
            arreglo[5] = num6;

            arr[0] = btnmenoscombo1;
            arr[1] = btnmenoscombo2;
            arr[2] = btnmenoscombo3;
            arr[3] = btnmenoscombo4;
            arr[4] = btnmenoscombo5;
            arr[5] = btnmenoscombo6;

            for (int i = 0; i < 6; i++)
            {
                if (arreglo[i] == 0)
                {
                    arr[i].Enabled = false;
                }
                else {
                    arr[i].Enabled = true;
                }
            }
           
        }
        int num = 0;


        Button[] btn = new Button[6];

        private void solo10dulces() {
            btn[0] = btnmascombo1;
            btn[1] = btnmascombo2;
            btn[2] = btnmascombo3;
            btn[3] = btnmascombo4;
            btn[4] = btnmascombo5;
            btn[5] = btnmascombo6;

            num = num1 + num2 + num3 + num4 + num5 + num6;

            if (num == 10)
            {
                Utilidades.mostrarmensaje("Nose puede escoger mas de 10 Dulcesxd");
                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false;
                }
            }
            else {
                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = true;
                }
            }
         
        }


        public static double sumadulces;
        public static double subtotaldulces;

        public static List<Dulceria> arreglodulces = new List<Dulceria>();
        void prueba() {
            //si es mayor o igual a 1 quiere decir que fue escogido cierta dulceria
            for (int i = 0; i < 6; i++)
            {
                if (arreglo[i]>=1)
                {
                    DulceriaConectar_BD.listardulces(i + 1);
                    Dulceria d = DulceriaConectar_BD.dul;
                    d.Cantidad = arreglo[i];
                    sumadulces = d.Cantidad * d.Precio;
                    subtotaldulces = subtotaldulces + sumadulces;
                    arreglodulces.Add(d);
                }
            }
        }



        public void prueba322() {
            foreach (Dulceria d in arreglodulces)
            {
                Console.WriteLine("" + d.Nomdulceria);
                Console.WriteLine("" + d.Precio);
                Console.WriteLine("" + d.Cantidad);

            }
        }


     /*   private void abrir<mitipo>() where mitipo : Form, new() { 
        }
     */
        private void JrmDulceria_Load(object sender, EventArgs e)
        {
        }

        private void btnmascombo1_Click(object sender, EventArgs e)
        {
            num1++;
            lvlcombo1.Text = ""+num1;
            inabilitarbotonessiescero();
            solo10dulces();
        }

        private void btnmenoscombo1_Click(object sender, EventArgs e)
        {
            num1--;
            lvlcombo1.Text = "" + num1;
            inabilitarbotonessiescero();
            solo10dulces();

        }

        private void btnmascombo2_Click(object sender, EventArgs e)
        {
            num2++;
            lvlcombo2.Text = "" + num2;
            inabilitarbotonessiescero();
            solo10dulces();

        }

        private void btnmenoscombo2_Click(object sender, EventArgs e)
        {
            num2--;
            lvlcombo2.Text = "" + num2;
            inabilitarbotonessiescero();
            solo10dulces();

        }

        private void btnmascombo3_Click(object sender, EventArgs e)
        {
            num3++;
            lvlcombo3.Text = "" + num3;
            inabilitarbotonessiescero();
            solo10dulces();

        }

        private void btnmenoscombo3_Click(object sender, EventArgs e)
        {
            num3--;
            lvlcombo3.Text = "" + num3;
            inabilitarbotonessiescero();
            solo10dulces();
        }

        private void btnmascombo4_Click(object sender, EventArgs e)
        {
            num4++;
            lvlcombo4.Text = "" + num4;
            inabilitarbotonessiescero();
            solo10dulces();

        }

        private void btnmenoscombo4_Click(object sender, EventArgs e)
        {
            num4--;
            lvlcombo4.Text = "" + num4;
            inabilitarbotonessiescero();
            solo10dulces();

        }

        private void btnmascombo5_Click(object sender, EventArgs e)
        {
            num5++;
            lvlcombo5.Text = "" + num5;
            inabilitarbotonessiescero();
            solo10dulces();

        }

        private void btnmenoscombo5_Click(object sender, EventArgs e)
        {
            num5--;
            lvlcombo5.Text = "" + num5;
            inabilitarbotonessiescero();
            solo10dulces();

        }

        private void btnmascombo6_Click(object sender, EventArgs e)
        {
            num6++;
            lvlcombo6.Text = "" + num6;
            inabilitarbotonessiescero();
            solo10dulces();

        }

        private void btnmenoscombo6_Click(object sender, EventArgs e)
        {
            num6--;
            lvlcombo6.Text = "" + num6;
            inabilitarbotonessiescero();
            solo10dulces();

        }

        private void btnsiguiente_Click(object sender, EventArgs e)
        {
            Console.WriteLine("--------------------------Dulceria cine data----------------------------------------");
            prueba();
            prueba322();
            JrmMetodoPago op = new JrmMetodoPago();
            op.Visible = true;
            this.Hide();
        }



    }
}
