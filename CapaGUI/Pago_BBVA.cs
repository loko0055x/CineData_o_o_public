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
    public partial class Pago_BBVA : Form
    {
        public Pago_BBVA()
        {
            InitializeComponent();
            inabilitarboton();
        }

        private void cmdmes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        public static Boolean estadobbva;

        private void inabilitarboton()
        {
            if (Pago_BBVA.estadobbva == true || Pago_Paypal.estadopaypal == true || Pago_Yape.estadoyape == true)
            {
                btnpagar.Enabled = false;

            }
        }

        public static List<Boleta> arreglo = new List<Boleta>();




        private void btnpagar_Click(object sender, EventArgs e)
        {
            double total = FrmEntradas.subtotalentradas + FrmDulceria.subtotaldulces;
            Boleta bol = new Boleta(FrmMetodoPago.nombres, FrmMetodoPago.apellido, FrmMetodoPago.correo
                , FrmButacas.nombresala, FrmEntradas.subtotalentradas, FrmDulceria.subtotaldulces, "BBVA", total);
            if (BoletaConectar_BD.agregarboleta(bol) == 1)
            {
                Utilidades.mostrarmensaje("Agregado correctamente");
                foreach (int i in FrmButacas.arr)
                {
                    AsientoConectar_BD.Actualizarasientos_no(i, FrmEscogerPelicula.codigogeneral);
                }
                arreglo.Add(bol);

                estadobbva = true;
                FrmReporte op = new FrmReporte();
                op.Visible = true;
                this.Dispose();
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
            lvlnombre.Text = "" + FrmMetodoPago.nombres + " " + FrmMetodoPago.apellido;
        }
    }
}
