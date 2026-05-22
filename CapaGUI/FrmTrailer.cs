using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaGUI
{
    public partial class FrmTrailer : Form
    {
        public FrmTrailer()
        {
            InitializeComponent();
        }

        private void FrmTrailer_Load(object sender, EventArgs e)
        {
            SalaConectar_BD.rellenarlista(listBox1);
        }

        private void BtnReproducir_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = ruta;
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void BtnParar_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();

        }

        private void BtnPausar_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();

        }

        public string ruta;

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nombrepeli = "" + listBox1.Text;
            ruta = SalaConectar_BD.video(nombrepeli);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
