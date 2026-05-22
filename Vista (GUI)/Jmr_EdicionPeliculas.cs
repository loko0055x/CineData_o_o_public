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
    public partial class Jmr_EdicionPeliculas : Form
    {
        public string ruta = "";

        public Jmr_EdicionPeliculas()
        {
            InitializeComponent();
            tblpeliculas.DataSource = SalaConectar_BD.mostrarsalas();
            btnactualizar.Enabled = false;
            txtid.Enabled = false;
        }

        private void Jmr_EdicionPeliculas_Load(object sender, EventArgs e)
        {

        }

        private void tblpeliculas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = e.RowIndex;
            if (!(n == -1))
            {
                int  codigo=int.Parse(""+ tblpeliculas.Rows[n].Cells[0].Value);
                SalaConectar_BD.mostrarfoto(codigo,pix);
                Sala s = SalaConectar_BD.sa;
                txtid.Text = ""+s.Idsala;
                txtnombrepeli.Text = "" +s.Nombrepelicula;
                txtruta.Text = "" + s.Linkpeli;
            }
        }

        private void btnabririmagen_Click(object sender, EventArgs e)
        {
            Utilidades.abrir_imagen(openFileDialog1, pix);
            btnactualizar.Enabled = true;

        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            Sala s = new Sala(int.Parse(txtid.Text),txtnombrepeli.Text,txtruta.Text);
            if (SalaConectar_BD.actualizarsala(s, pix) == 1)
            {
                Utilidades.mostrarmensaje("Estas seguro que quieres actualizar la sala");
                Utilidades.mostrarmensaje("Acontinuacion se actualizara todas las salas en true");
                tblpeliculas.DataSource = SalaConectar_BD.mostrarsalas();

                for (int i = 0; i <6; i++)
                {
                    for (int j = 0; j <15; j++)
                    {
                        AsientoConectar_BD.Actualizarasientos_si(j+1,i+1);
                    }
                }

            }
            else {
                Utilidades.mostrarmensaje("error");
            }
        }

        private void btntrailer_Click(object sender, EventArgs e)
        {
             if (openFileDialog1.ShowDialog()==DialogResult.OK)
            { 
                ruta = openFileDialog1.FileName;
                txtruta.Text = ruta;
            }
        }
    }
}
