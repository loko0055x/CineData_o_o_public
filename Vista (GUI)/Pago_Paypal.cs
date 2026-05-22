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
    public partial class Pago_Paypal : Form
    {
        public Pago_Paypal()
        {
            InitializeComponent();
        }
        public static Boolean estadopaypal;
        private void inabilitarboton()
        {
            if (Pago_BBVA.estadobbva == true || Pago_Paypal.estadopaypal == true || Pago_Yape.estadoyape == true)
            {
                btnpagar.Enabled = false;

            }
        }
        private void Pago_Paypal_Load(object sender, EventArgs e)
        {
            inabilitarboton();
        }
        public static List<Boleta> arreglo = new List<Boleta>();

        private void btnpagar_Click(object sender, EventArgs e)
        {
            double total = JrmEntradas.subtotalentradas + JrmDulceria.subtotaldulces;
            Boleta bol = new Boleta(JrmMetodoPago.nombres, JrmMetodoPago.apellido, JrmMetodoPago.correo
                , JrmButacas.nombresala, JrmEntradas.subtotalentradas, JrmDulceria.subtotaldulces, "Paypal", total);
            if (BoletaConectar_BD.agregarboleta(bol) == 1)
            {
                Utilidades.mostrarmensaje("Agregado correctamente");
                foreach (int i in JrmButacas.arr)
                {
                    AsientoConectar_BD.Actualizarasientos_no(i, JrmEscogerpelicula.codigogeneral);
                }
                arreglo.Add(bol);
                estadopaypal = true;
                btnpagar.Enabled = false;

                JrmReporte_Boleta op = new JrmReporte_Boleta();
                op.Visible = true;
                this.Dispose();

            }
}
    }
}
