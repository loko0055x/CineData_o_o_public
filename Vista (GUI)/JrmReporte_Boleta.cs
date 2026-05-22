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

namespace Vista__GUI_
{
    public partial class JrmReporte_Boleta : Form
    {
        public JrmReporte_Boleta()
        {
            InitializeComponent();
        }

        private void JrmReporte_Boleta_Load(object sender, EventArgs e)
        {
            vereporte();
        }

        private void prueba(List<Boleta> arreglo) {
            /*reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", arreglo));
            this.reportViewer1.RefreshReport();*/
        }

        private void vereporte() {
            if (Pago_BBVA.estadobbva==true)
            {
                prueba(Pago_BBVA.arreglo);
            }
            else if (Pago_Paypal.estadopaypal==true)
            {
                prueba(Pago_Paypal.arreglo);

            }
            else if (Pago_Yape.estadoyape==true)
            {
                prueba(Pago_Yape.arreglo);

            }

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void JrmReporte_Boleta_Load_1(object sender, EventArgs e)
        {

        }
    }
}
