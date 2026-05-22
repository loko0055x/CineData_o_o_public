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
    public partial class Pago_Yape : Form
    {
        public Pago_Yape()
        {
            InitializeComponent();
        }

        private void Pago_Yape_Load(object sender, EventArgs e)
        {
            inabilitarboton();
        }
        private void inabilitarboton()
        {
            if (Pago_BBVA.estadobbva == true || Pago_Paypal.estadopaypal == true || Pago_Yape.estadoyape == true)
            {
                btnpagar.Enabled = false;

            }
        }
        public static Boolean estadoyape;

        string pagotipo;
        public static List<Boleta> arreglo = new List<Boleta>();

        private void btnpagar_Click(object sender, EventArgs e)
        {
            double total = JrmEntradas.subtotalentradas + JrmDulceria.subtotaldulces;
            Boleta bol = new Boleta(JrmMetodoPago.nombres, JrmMetodoPago.apellido, JrmMetodoPago.correo
                , JrmButacas.nombresala, JrmEntradas.subtotalentradas, JrmDulceria.subtotaldulces, pagotipo, total);
            if (BoletaConectar_BD.agregarboleta(bol) == 1)
            {
                Utilidades.mostrarmensaje("Agregado correctamente");
                foreach (int i in JrmButacas.arr)
                {
                    AsientoConectar_BD.Actualizarasientos_no(i, JrmEscogerpelicula.codigogeneral);
                }
                arreglo.Add(bol);
                estadoyape = true;

                btnpagar.Enabled = false;
                JrmReporte_Boleta op = new JrmReporte_Boleta();
                op.Visible = true;
                this.Dispose();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pagotipo = "Yape";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pagotipo = "Tunki";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pagotipo = "Plin";
        }
    }
}
