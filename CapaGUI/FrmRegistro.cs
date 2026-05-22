using CapaNegocio;
using Encapsulado_Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilidades_Proyecto;

namespace CapaGUI
{
    public partial class FrmRegistro : Form
    {
        String nombre = "";
        String apellido = "";
        String telefono = "";
        String correo = "";

        String user = "";
        String passw1 = "";
        String passw2 = "";

        public FrmRegistro()
        {
            InitializeComponent();
        }


        public static int dni;
        public static string contra;
        public static Boolean estadoregistrarse;


        private void btnmenu_Click(object sender, EventArgs e)
        {

        }


        private void BtnContinuar_Click(object sender, EventArgs e)
        {
            ClientePremiun cli = new ClientePremiun();
            cli.Dni = int.Parse(txtdni.Text);
            cli.Nombre = txtnom.Text;
            cli.Apellido = txtape.Text;
            cli.Celular = int.Parse(txttelef.Text);

            if (rbtm.Checked == true)
            {
                cli.Sexo = "M";
            }
            else if (rbtf.Checked == true)
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
                    FrmEscogerPelicula op = new FrmEscogerPelicula();
                    op.Visible = true;
                    this.Hide();
                }
                else
                {
                    Utilidades.mostrarmensaje("error al agregar");
                    estadoregistrarse = false;

                }
            }
            else
            {
                Utilidades.mostrarmensaje("Error las contraseñas son incorrectas no coinciden xd");
                estadoregistrarse = false;

            }
        }

        private void FrmRegistro_Load_1(object sender, EventArgs e)
        {
            txtdni.Text = "Introduzca Nº Identificación";
            txtdni.ForeColor = Color.Gray;
            txtcontra1.PasswordChar = '\0';
            txtcontra1.Text = "Introduzca contraseña";
            txtcontra1.ForeColor = Color.Gray;
            txtcontra1.UseSystemPasswordChar = false;
            txtcontra2.PasswordChar = '\0';
            txtcontra2.Text = "Verificar contraseña";
            txtcontra2.ForeColor = Color.Gray;
            txtcontra2.UseSystemPasswordChar = false;
            txtnom.Text = "Introduzca Nombre";
            txtnom.ForeColor = Color.Gray;
            txtape.Text = "Introduzca Apellido";
            txtape.ForeColor = Color.Gray;
            txttelef.Text = "Introduzca Telefono";
            txttelef.ForeColor = Color.Gray;
            txtcorreo.Text = "Introduzca Correo";
            txtcorreo.ForeColor = Color.Gray;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Frm_IniciarSecion op = new Frm_IniciarSecion();
            op.Visible = true;
            this.Hide();
        }

        private void pixnover1_Click_1(object sender, EventArgs e)
        {
            txtcontra1.UseSystemPasswordChar = false;
            pixver1.Visible = true;
            pixver1.Enabled = true;
            pixnover1.Visible = false;
            pixnover1.Enabled = false;
        }

        private void pixnover2_Click_1(object sender, EventArgs e)
        {
            txtcontra2.UseSystemPasswordChar = false;
            pixver2.Visible = true;
            pixver2.Enabled = true;
            pixnover2.Visible = false;
            pixnover2.Enabled = false;
        }

        private void pixver1_Click_1(object sender, EventArgs e)
        {
            txtcontra1.UseSystemPasswordChar = true;
            pixver1.Visible = false;
            pixver1.Enabled = false;
            pixnover1.Visible = true;
            pixnover1.Enabled = true;
        }

        private void pixver2_Click_1(object sender, EventArgs e)
        {
            txtcontra2.UseSystemPasswordChar = true;
            pixver2.Visible = false;
            pixver2.Enabled = false;
            pixnover2.Visible = true;
            pixnover2.Enabled = true;
        }

        private void txtcontra2_Enter_1(object sender, EventArgs e)
        {
            txtcontra2.Text = "";
            txtcontra2.ForeColor = Color.Black;
            txtcontra2.PasswordChar = '*';
        }

        private void txtnom_Leave_1(object sender, EventArgs e)
        {
            nombre = txtnom.Text;
            if (nombre.Equals("Introduzca Nombre"))
            {
                txtnom.Text = "Introduzca Nombre";
                txtnom.ForeColor = Color.Gray;
            }
            else
            {
                if (nombre.Equals(""))
                {
                    txtnom.Text = "Introduzca Nombre";
                    txtnom.ForeColor = Color.Gray;
                }
                else
                {
                    txtnom.Text = nombre;
                    txtnom.ForeColor = Color.Black;
                }
            }
        }

        private void txtape_Enter_1(object sender, EventArgs e)
        {
            txtape.Text = "";
            txtape.ForeColor = Color.Black;
        }

        private void txtape_Leave_1(object sender, EventArgs e)
        {
            apellido = txtape.Text;
            if (apellido.Equals("Introduzca Apellido"))
            {
                txtape.Text = "Introduzca Apellido";
                txtape.ForeColor = Color.Gray;
            }
            else
            {
                if (apellido.Equals(""))
                {
                    txtape.Text = "Introduzca Apellido";
                    txtape.ForeColor = Color.Gray;
                }
                else
                {
                    txtape.Text = apellido;
                    txtape.ForeColor = Color.Black;
                }
            }
        }

        private void txttelef_Enter_1(object sender, EventArgs e)
        {
            txttelef.Text = "";
            txttelef.ForeColor = Color.Black;
        }

        private void txttelef_Leave_1(object sender, EventArgs e)
        {
            telefono = txttelef.Text;
            if (telefono.Equals("Introduzca Telefono"))
            {
                txttelef.Text = "Introduzca Telefono";
                txttelef.ForeColor = Color.Gray;
            }
            else
            {
                if (telefono.Equals(""))
                {
                    txttelef.Text = "Introduzca Telefono";
                    txttelef.ForeColor = Color.Gray;
                }
                else
                {
                    txttelef.Text = telefono;
                    txttelef.ForeColor = Color.Black;
                }
            }
        }

        private void txtcorreo_Enter_1(object sender, EventArgs e)
        {
            txtcorreo.Text = "";
            txtcorreo.ForeColor = Color.Black;
        }

        private void txtcorreo_Leave_1(object sender, EventArgs e)
        {
            correo = txtcorreo.Text;
            if (correo.Equals("Introduzca Correo"))
            {
                txtcorreo.Text = "Introduzca Correo";
                txtcorreo.ForeColor = Color.Gray;
            }
            else
            {
                if (correo.Equals(""))
                {
                    txtcorreo.Text = "Introduzca Correo";
                    txtcorreo.ForeColor = Color.Gray;
                }
                else
                {
                    txtcorreo.Text = correo;
                    txtcorreo.ForeColor = Color.Black;
                }
            }
        }

        private void txtdni_Enter_1(object sender, EventArgs e)
        {
            txtdni.Text = "";
            txtdni.ForeColor = Color.Black;
        }

        private void txtdni_Leave_1(object sender, EventArgs e)
        {
            user = txtdni.Text;
            if (user.Equals("Introduzca Nº Identificación"))
            {
                txtdni.Text = "Introduzca Nº Identificación";
                txtdni.ForeColor = Color.Gray;
            }
            else
            {
                if (user.Equals(""))
                {
                    txtdni.Text = "Introduzca Nº Identificación";
                    txtdni.ForeColor = Color.Gray;
                }
                else
                {
                    txtdni.Text = user;
                    txtdni.ForeColor = Color.Black;
                }
            }
        }

        private void txtcontra1_Enter_1(object sender, EventArgs e)
        {
            txtcontra1.Text = "";
            txtcontra1.ForeColor = Color.Black;
            txtcontra1.PasswordChar = '*';
        }

        private void txtcontra1_Leave_1(object sender, EventArgs e)
        {
            passw1 = txtcontra1.Text;
            if (passw1.Equals("Introduzca Contraseña"))
            {
                txtcontra1.Text = "Introduzca Contraseña";
                txtcontra1.ForeColor = Color.Gray;
            }
            else
            {
                if (passw1.Equals(""))
                {
                    txtcontra1.Text = "Introduzca Contraseña";
                    txtcontra1.ForeColor = Color.Gray;
                }
                else
                {
                    txtcontra1.Text = passw1;
                    txtcontra1.ForeColor = Color.Black;
                }
            }
        }

        private void txtcontra2_Leave_1(object sender, EventArgs e)
        {
            passw2 = txtcontra2.Text;
            if (passw2.Equals("Confirmar Contraseña"))
            {
                txtcontra2.Text = "Confirmar Contraseña";
                txtcontra2.ForeColor = Color.Gray;
            }
            else
            {
                if (passw2.Equals(""))
                {
                    txtcontra2.Text = "Confirmar Contraseña";
                    txtcontra2.ForeColor = Color.Gray;
                }
                else
                {
                    txtcontra2.Text = passw2;
                    txtcontra2.ForeColor = Color.Black;
                }
            }
        }

        private void txtnom_Enter(object sender, EventArgs e)
        {
            txtnom.Text = "";
            txtnom.ForeColor = Color.Black;
        }
    }
}
