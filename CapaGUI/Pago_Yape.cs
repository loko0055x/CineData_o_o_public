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
    public partial class Pago_Yape : Form
    {
        public Pago_Yape()
        {
            InitializeComponent();
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
        public static List<Boleta> arreglo = new List<Boleta>();
        string pagotipo;

        private void btnpagar_Click(object sender, EventArgs e)
        {
 

            double total = FrmEntradas.subtotalentradas + FrmDulceria.subtotaldulces;
            Boleta bol = new Boleta(FrmMetodoPago.nombres, FrmMetodoPago.apellido, FrmMetodoPago.correo
                , FrmButacas.nombresala, FrmEntradas.subtotalentradas, FrmDulceria.subtotaldulces, pagotipo, total);
            if (BoletaConectar_BD.agregarboleta(bol) == 1)
            {
                Utilidades.mostrarmensaje("Agregado correctamente");
                foreach (int i in FrmButacas.arr)
                {
                    AsientoConectar_BD.Actualizarasientos_no(i, FrmEscogerPelicula.codigogeneral);
                }

                arreglo.Add(bol);
                estadoyape = true;
                btnpagar.Enabled = false;
                FrmReporte op = new FrmReporte();
                op.Visible = true;
                this.Dispose();
            }
        }

        private void btnyape_Click(object sender, EventArgs e)
        {
            pagotipo = "Yape";
        }

        private void btntunki_Click(object sender, EventArgs e)
        {
            pagotipo = "Tunki";
        }

        private void btnplin_Click(object sender, EventArgs e)
        {
            pagotipo = "Plin";
        }
    }
}
