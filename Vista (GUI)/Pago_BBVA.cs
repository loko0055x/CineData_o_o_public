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
    public partial class Pago_BBVA : Form
    {
        public Pago_BBVA()
        {
            InitializeComponent();
            inabilitarboton();
        }
        public static Boolean estadobbva;

        private void inabilitarboton() {
            if (Pago_BBVA.estadobbva == true || Pago_Paypal.estadopaypal == true || Pago_Yape.estadoyape == true)
            {
                btnpagar.Enabled = false;

            }
        }



        private void Pago_BBVA_Load(object sender, EventArgs e)
        {
            for (int i = 1990; i < 2023; i++)
            {
                cmdanio.Items.Add(i);

            }
            for (int i = 1; i < 13; i++)
            {
                cmdmes.Items.Add(i);
            }
            lvlnombre.Text = ""+JrmMetodoPago.nombres+" "+JrmMetodoPago.apellido;
        }

        public static List<Boleta> arreglo = new List<Boleta>();

        private void btnpagar_Click(object sender, EventArgs e)
        {
            double total = JrmEntradas.subtotalentradas + JrmDulceria.subtotaldulces;
            Boleta bol = new Boleta(JrmMetodoPago.nombres,JrmMetodoPago.apellido,JrmMetodoPago.correo
                ,JrmButacas.nombresala,JrmEntradas.subtotalentradas,JrmDulceria.subtotaldulces,"BBVA",total);
            if (BoletaConectar_BD.agregarboleta(bol) == 1)
            {
                Utilidades.mostrarmensaje("Agregado correctamente");
                foreach (int i in JrmButacas.arr)
                {
                    AsientoConectar_BD.Actualizarasientos_no(i, JrmEscogerpelicula.codigogeneral);
                }
                arreglo.Add(bol);

                estadobbva = true;
                JrmReporte_Boleta op = new JrmReporte_Boleta();
                op.Visible = true;
                this.Dispose();
            }





        }
    }
}
