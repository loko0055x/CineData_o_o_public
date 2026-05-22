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
    public partial class Jrm_Administradores : Form
    {
        public Jrm_Administradores()
        {
            InitializeComponent();
            tbladmin.DataSource = AdministradorConectar_BD.mostraradministradores();
            arreglo[0] =txtdni;
            arreglo[1] = txtnom;
            arreglo[2] = txtape;
            arreglo[3] = txtsalario;
            arreglo[4] = txtcorreo;
            arreglo[5] = txtcontra;
            arreglo[6] = txtdireccion;
            arreglo[7] = txttelef;
            

        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            Administrador admin = new Administrador(int.Parse(txtdni.Text),txtnom.Text,txtape.Text,float.Parse(txtsalario.Text),txtcorreo.Text
                ,txtcontra.Text,txtdireccion.Text,int.Parse(txttelef.Text),"",DateTime.Parse( datetime.Text));
            if (rbth.Checked)
            {
                admin.Sexo = rbth.Text;
            }
            else if (rbtm.Checked)
            {
                admin.Sexo = rbtm.Text;

            }

            if (AdministradorConectar_BD.agregaradmin(admin) == 1)
            {
                Utilidades.mostrarmensaje("se agrego correctamente");
                tbladmin.DataSource = AdministradorConectar_BD.mostraradministradores();

            }
            else {          
                    Utilidades.mostrarmensaje("error"); 
            }
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            Administrador admin = new Administrador(int.Parse(txtdni.Text), txtnom.Text, txtape.Text, float.Parse(txtsalario.Text), txtcorreo.Text
               , txtcontra.Text, txtdireccion.Text, int.Parse(txttelef.Text), "", DateTime.Parse(datetime.Text));
            if (rbth.Checked)
            {
                admin.Sexo = rbth.Text;
            }
            else if (rbtm.Checked)
            {
                admin.Sexo = rbtm.Text;

            }
            if (AdministradorConectar_BD.actualizaradmin(admin) == 1)
            {
                Utilidades.mostrarmensaje("se actualiza correctamente");
                tbladmin.DataSource = AdministradorConectar_BD.mostraradministradores();

            }
            else
            {
                Utilidades.mostrarmensaje("error");
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (AdministradorConectar_BD.eliminaradmin(int.Parse(txtdni.Text))==1)
            {
                Utilidades.mostrarmensaje("se elimino correctamente");
                tbladmin.DataSource = AdministradorConectar_BD.mostraradministradores();


            }
            else
            {
                Utilidades.mostrarmensaje("error");
            }
        }

        private void Jrm_Administradores_Load(object sender, EventArgs e)
        {

        }

        TextBox[] arreglo = new TextBox[8];
        private void tbladmin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = e.RowIndex;
            if (!(n == -1))
            {
            //  txtdni.Text = "" + tbladmin.Rows[n].Cells[0].Value;
                for (int i = 0; i < arreglo.Length; i++)
                {
                    arreglo[i].Text = "" + tbladmin.Rows[n].Cells[i].Value;
                }
                string sexo =  "" + tbladmin.Rows[n].Cells[8].Value;
                if (sexo.Equals("m", StringComparison.InvariantCultureIgnoreCase))
                {
                    rbtm.Checked = true;
                }
                else if (sexo.Equals("h", StringComparison.InvariantCultureIgnoreCase))
                {
                    rbth.Checked = true;

                }
                datetime.Text = "" + tbladmin.Rows[n].Cells[9].Value ;
            }


        }
    }
}
