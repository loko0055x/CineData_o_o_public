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
    public partial class JrmButacas : Form
    {
        public JrmButacas()
        {
            InitializeComponent();
            mostrarfotonombre();
            verbutacaescogida();
            arr = new List<int>();
            arreglo = new List<string>();
            contador = 0;
            nombresala = lvlnombre.Text;
        }
        public static string nombresala;
        private void JrmButacas_Load(object sender, EventArgs e)
        {
            
        }

        //ojo = JrmEscogerpelicula.codigogeneral  = es la sala o numero de sala escogida


       private  void mostrarfotonombre() {

            SalaConectar_BD.mostrarfoto(JrmEscogerpelicula.codigogeneral, pix);
            Sala s = SalaConectar_BD.sa;
            lvlcodigo.Text = "" + s.Idsala;
            lvlnombre.Text = "" + s.Nombrepelicula;
        }


        void verbutacaescogida() {
         /*   int n1=1,n2=1;
            Boolean estado1 =(n1==1 ||n2==1);

            if (n1==1 ||  n2==1)
            {

            }
         //hacer todo lo mismo y poner en una arreglo y si hay alguno que sea true ese sera el verdaero

*/

            switch (JrmEscogerpelicula.codigogeneral)
            {
                case 1:botones("A", 1);
                break;
                case 2:botones("B", 2);
                break;
                case 3:botones("C", 3);
                break;
                case 4:botones("D", 4);
                break;
                case 5:botones("E", 5);
                break;
                case 6:botones("F", 6); 
                break;
                default:
                  Utilidades.mostrarmensaje("error sala invalida");
                break;

            }

        }




        //cuantos botonesxd
        static int filas = 3;
        static int columnas = 5;


        //largo y ancho el grosor del boton
        static int largo = 60;
        static int ancho = 60;

        //lugares donde estaran los botones
        static int ejeX = 30;
        static int ejeY = 30;

         static Button[,] matriz = new Button[filas, columnas];

        void botones(string nombresala,int codigosala)
        {
            ejeX = 30;
            ejeY = 30;
            matriz = new Button[filas, columnas];
            int contador = 1;
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    matriz[i, j] = new Button();
                    matriz[i, j].SetBounds(ejeX, ejeY, largo, ancho);
                    matriz[i, j].Text = ""+nombresala+"-" + contador;
                    matriz[i, j].BackColor = Color.Green;
                    matriz[i, j].Click += new EventHandler(eventodelboton);
                    if (AsientoConectar_BD.retornarestado(contador, codigosala).Equals("no"))
                    {
                        matriz[i, j].BackColor = Color.White;
                        matriz[i, j].Enabled = false;
                    }
                   panelcontenedor.Controls.Add(matriz[i, j]);
                    ejeX = ejeX + 60;
                    contador++;
                }
                ejeX = 30;
                ejeY += 60;
            }

         

        }
       public static int contador = 0;
        public static List<String> arreglo = new List<string>();
        public static List<int> arr = new List<int>();

        private void eventodelboton(object sender, EventArgs e)
        {
            Button btn = sender as Button;


            if (btn.BackColor == Color.Green)
            {
                btn.BackColor = Color.Red;

                string nuevacadena = new string(btn.Text.ToCharArray().Where(c => char.IsDigit(c)).ToArray());
                int num = int.Parse(nuevacadena);
             //   AsientoConectar_BD.Actualizarasientos_no(num, JrmEscogerpelicula.codigogeneral);
                arreglo.Add(btn.Text);
                arr.Add(num);
                contador++;
            }
            else
            {
                btn.BackColor = Color.Green;

                string nuevacadena = new string(btn.Text.ToCharArray().Where(c => char.IsDigit(c)).ToArray());
                int num = int.Parse(nuevacadena);
             //   AsientoConectar_BD.Actualizarasientos_si(num, JrmEscogerpelicula.codigogeneral); arreglo.Remove(btn.Text);
                arr.Remove(num);
                contador--;
            }






        }

        private void btnsiguiente_Click(object sender, EventArgs e)
        {
            Console.WriteLine("---------------------NUEVOOO--------------------------------");
            foreach (string op in arreglo)
            {
                Console.WriteLine(op);
            }

            foreach (int op in arr)
            {
                Console.WriteLine(op);

            }
            MessageBox.Show("la cantidad de enbtradas es " + contador);


            JrmEntradas xd = new JrmEntradas();
            xd.Visible = true;
            this.Hide();

        }


       
        void actualizasiatodos() {
            int cont=1;
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    matriz[i, j].BackColor = Color.Green;
                    matriz[i, j].Enabled = true;
                    AsientoConectar_BD.Actualizarasientos_si(cont, JrmEscogerpelicula.codigogeneral);
                        cont++;
                }
            }
        
        }

        private void btnactualizarsitodos_Click(object sender, EventArgs e)
        {
            actualizasiatodos();
        }

        private void lvlnombre_Click(object sender, EventArgs e)
        {

        }

        private void lvlcodigo_Click(object sender, EventArgs e)
        {

        }

        private void pix_Click(object sender, EventArgs e)
        {

        }
    }
}
