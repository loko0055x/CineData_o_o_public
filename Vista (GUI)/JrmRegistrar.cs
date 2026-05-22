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
    public partial class JrmRegistrar : Form
    {
        public JrmRegistrar()
        {
            InitializeComponent();
        }

        private void JrmRegistrar_Load(object sender, EventArgs e)
        {

        }

        public static int dni;
        public static string contra;
        public static Boolean estadoregistrarse;

        private void btnregistrarse_Click(object sender, EventArgs e)
        {
            Cliente_Premiun cli = new Cliente_Premiun();
            cli.Dni = int.Parse(txtdni.Text);
            cli.Nombre = txtnom.Text;
            cli.Apellido = txtape.Text;
            cli.Celular = int.Parse(txttelef.Text);

            if (rbtm.Checked==true)
            {
                cli.Sexo = "M";
            }
            else if (rbtf.Checked==true)
            {
                cli.Sexo = "F";

            }
            cli.Correo = txtcorreo.Text;

            if (txtcontra1.Text.Equals(txtcontra2.Text))
            {
                cli.Contraseña = txtcontra1.Text;
                if (ClienteConectar_BD.agregarcliente(cli) == 1)
                {
                    Utilidades.mostrarmensaje("cliente agregado correctamente");
                    dni = cli.Dni;
                    contra = cli.Contraseña;
                    estadoregistrarse = true;
                    JrmEscogerpelicula op = new JrmEscogerpelicula();
                    op.Visible = true;
                    this.Hide();
                }
                else {
                    Utilidades.mostrarmensaje("error al agregar");
                    estadoregistrarse = false;

                }
            }
            else {
                Utilidades.mostrarmensaje("Error las contraseñas son incorrectas no coinciden xd");
                estadoregistrarse = false;

            }




        }

        private void btnmenu_Click(object sender, EventArgs e)
        {
            JrmEscogerpelicula op = new JrmEscogerpelicula();
            op.Visible = true;
            this.Hide();
        }
    }
}
