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
    public partial class Frm_IniciarSecion : Form
    {
        String user = "";
        String passw = "";
        public static int dni;
        public static string contra;
        public static Boolean estadoiniciarsecion;
        public Frm_IniciarSecion()
        {
            InitializeComponent();
        }

        private void Frm_IniciarSecion_Load(object sender, EventArgs e)
        {
            txtdni.Text = "Introduzca el usuario";
            txtdni.ForeColor = Color.Gray;
            txtcontra.PasswordChar = '\0';
            txtcontra.Text = "Introduzca la contraseña";
            txtcontra.ForeColor = Color.Gray;
            txtcontra.UseSystemPasswordChar = false;
        }

        private void pixsalir_Click(object sender, EventArgs e)
        {
           Dispose();
        }

        private void pixver_Click(object sender, EventArgs e)
        {
            txtcontra.UseSystemPasswordChar = true;
            pixver.Visible = false;
            pixver.Enabled = false;
            pixnover.Visible = true;
            pixnover.Enabled = true;
        }

        private void pixnover_Click(object sender, EventArgs e)
        {
            txtcontra.UseSystemPasswordChar = false;
            pixver.Visible = true;
            pixver.Enabled = true;
            pixnover.Visible = false;
            pixnover.Enabled = false;
        }

        private void txtpassw_Leave(object sender, EventArgs e)
        {
            passw = txtcontra.Text;
            if (passw.Equals("Introduzca la contraseña"))
            {
                txtcontra.Text = "Introduzca la contraseñao";
                txtcontra.ForeColor = Color.Gray;
            }
            else
            {
                if (passw.Equals(""))
                {
                    txtcontra.Text = "Introduzca la contraseña";
                    txtcontra.ForeColor = Color.Gray;
                }
                else
                {
                    txtcontra.Text = passw;
                    txtcontra.ForeColor = Color.Black;
                }
            }
        }

        private void txtusu_Enter(object sender, EventArgs e)
        {
            txtdni.Text = "";
            txtdni.ForeColor = Color.Black;
        }

        private void txtpassw_Enter(object sender, EventArgs e)
        {
            txtcontra.Text = "";
            txtcontra.ForeColor = Color.Black;
            txtcontra.PasswordChar = '*';
        }

        private void txtusu_Leave(object sender, EventArgs e)
        {
            user = txtdni.Text;
            if (user.Equals("Introduzca el usuario"))
            {
                txtdni.Text = "Introduzca el usuario";
                txtdni.ForeColor = Color.Gray;
            }
            else
            {
                if (user.Equals(""))
                {
                    txtdni.Text = "Introduzca el usuario";
                    txtdni.ForeColor = Color.Gray;
                }
                else
                {
                    txtdni.Text = user;
                    txtdni.ForeColor = Color.Black;
                }
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            

            
        }

        private void btniniciar_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            FrmRegistro reg = new FrmRegistro();

            reg.Visible = true;
            this.Hide();
        }

        private void BtnInvitado_Click(object sender, EventArgs e)
        {

        }

        private void BtnIniciarSesion_Click(object sender, EventArgs e)
        {
            Administrador admin = new Administrador(txtdni.Text, txtcontra.Text);
            if (AdministradorConectar_BD.VerificarAdminsiExiste(admin) == 1)
            {
                Utilidades.mostrarmensaje("Bienvenido");
                Frm_MDI_Administracion op = new Frm_MDI_Administracion();
                op.Visible = true;
                this.Hide();
            }
            else
            {
                int numericValue;
                bool estadonumero = int.TryParse(txtdni.Text, out numericValue);


                if (estadonumero == true)
                {
                    ClientePremiun cd = new ClientePremiun(int.Parse(txtdni.Text), txtcontra.Text);
                    if (ClienteConectar_BD.verificarsiclienteexiste(cd) == 1)
                    {
                        Utilidades.mostrarmensaje("Si existe");
                        dni = int.Parse(txtdni.Text);
                        contra = txtcontra.Text;
                        estadoiniciarsecion = true;
                        FrmEscogerPelicula op = new FrmEscogerPelicula();
                        op.Visible = true;
                        this.Hide();
                    }
                    else
                    {
                        Utilidades.mostrarmensaje("Datos incorrectos no existe");
                        estadoiniciarsecion = false;
                    }

                }

                else
                {
                    Utilidades.mostrarmensaje("No coindicen los datos");

                }



            }
        }

        private void BtnInvitado_Click_1(object sender, EventArgs e)
        {
            FrmEscogerPelicula op = new FrmEscogerPelicula();
            op.Visible = true;
            this.Hide();
               
        }
    }
}
