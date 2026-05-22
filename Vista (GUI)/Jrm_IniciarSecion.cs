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
    public partial class Jrm_IniciarSecion : Form
    {
        public Jrm_IniciarSecion()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public static int dni;
        public static string contra;
        public static Boolean estadoiniciarsecion;
        private void btniniciarsecion_Click(object sender, EventArgs e)
        {
            Administrador admin = new Administrador(txtdni.Text, txtcontra.Text);
            if (AdministradorConectar_BD.verificarsiadminexiste(admin) == 1)
            {
                Utilidades.mostrarmensaje("Bienvenido");
                Jrm_MDI_Administracion op = new Jrm_MDI_Administracion();
                op.Visible = true;
                this.Hide();
            }
            else
            {

                Cliente_Premiun cd = new Cliente_Premiun(int.Parse(txtdni.Text), txtcontra.Text);
                if (ClienteConectar_BD.verificarsiclienteexiste(cd) == 1)
                {
                    Utilidades.mostrarmensaje("Si existe");
                    dni = int.Parse(txtdni.Text);
                    contra = txtcontra.Text;
                    estadoiniciarsecion = true;
                    JrmEscogerpelicula op = new JrmEscogerpelicula();
                    op.Visible = true;
                    this.Hide();
                }
                else
                {
                    Utilidades.mostrarmensaje("Datos incorrectos no existe");
                    estadoiniciarsecion = false;
                }

            }
        }



        private void btnprincipal_Click(object sender, EventArgs e)
        {
            JrmEscogerpelicula op = new JrmEscogerpelicula();
            op.Visible = true;
            this.Hide();
        }

        private void Jrm_IniciarSecion_Load(object sender, EventArgs e)
        {

        }
    }
}
