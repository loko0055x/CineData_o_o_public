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
    public partial class FrmAdministradores : Form
    {
        public FrmAdministradores()
        {
            InitializeComponent();
            tbladmin.DataSource = AdministradorConectar_BD.mostraradministradores();
            arreglo[0] = txtdni;
            arreglo[1] = txtnombres;
            arreglo[2] = txtape;
            arreglo[3] = txtsalario;
            arreglo[4] = txtcorreo;
            arreglo[5] = txtcontra;
            arreglo[6] = txtdirec;
            arreglo[7] = txtcell;

        }
        TextBox[] arreglo = new TextBox[8];


        private void FrmAdministradores_Load(object sender, EventArgs e)
        {
           

        }

        private void pixsalir_Click(object sender, EventArgs e)
        {
            Frm_MDI_Administracion op = new Frm_MDI_Administracion();
            op.Visible = true;
            this.Hide();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            Administrador admin = new Administrador(int.Parse(txtdni.Text), txtnombres.Text, txtape.Text, float.Parse(txtsalario.Text), txtcorreo.Text
               , txtcontra.Text, txtdirec.Text, int.Parse(txtcell.Text), "", DateTime.Parse(dtmfecha.Text));
            if (rbt1.Checked)
            {
                admin.Sexo = rbt1.Text;
            }
            else if (rbt2.Checked)
            {
                admin.Sexo = rbt2.Text;

            }

            if (AdministradorConectar_BD.agregaradmin(admin) == 1)
            {
                Utilidades.mostrarmensaje("se agrego correctamente");
                tbladmin.DataSource = AdministradorConectar_BD.mostraradministradores();

            }
            else
            {
                Utilidades.mostrarmensaje("error");
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (AdministradorConectar_BD.eliminaradmin(int.Parse(txtdni.Text)) == 1)
            {
                Utilidades.mostrarmensaje("se elimino correctamente");
                tbladmin.DataSource = AdministradorConectar_BD.mostraradministradores();


            }
            else
            {
                Utilidades.mostrarmensaje("error");
            }
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            Administrador admin = new Administrador(int.Parse(txtdni.Text), txtnombres.Text, txtape.Text, float.Parse(txtsalario.Text), txtcorreo.Text
             , txtcontra.Text, txtdirec.Text, int.Parse(txtcell.Text), "", DateTime.Parse(dtmfecha.Text));
            if (rbt1.Checked)
            {
                admin.Sexo = rbt1.Text;
            }
            else if (rbt2.Checked)
            {
                admin.Sexo = rbt2.Text;

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
                string sexo = "" + tbladmin.Rows[n].Cells[8].Value;
                if (sexo.Equals("m", StringComparison.InvariantCultureIgnoreCase))
                {
                    rbt1.Checked = true;
                }
                else if (sexo.Equals("h", StringComparison.InvariantCultureIgnoreCase))
                {
                    rbt2.Checked = true;

                }
                dtmfecha.Text = "" + tbladmin.Rows[n].Cells[9].Value;
            }
        }
    }
}
