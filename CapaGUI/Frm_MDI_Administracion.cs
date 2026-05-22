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
    public partial class Frm_MDI_Administracion : Form
    {
        public Frm_MDI_Administracion()
        {
            InitializeComponent();
        }
        private void irformulario(Form jrm)
        {
            jrm.Visible = true;
            this.Hide();
        }

        private void Frm_MDI_Administracion_Load(object sender, EventArgs e)
        {

        }

        private void mnuempleados_Click(object sender, EventArgs e)
        {
            Frm_Empleados op = new Frm_Empleados();
            irformulario(op);

        }

        private void mnuadministradores_Click(object sender, EventArgs e)
        {
            FrmAdministradores op = new FrmAdministradores();
            irformulario(op);

        }

        private void mnureporte_Click(object sender, EventArgs e)
        {

        }

        private void mnuedicionpeliculas_Click(object sender, EventArgs e)
        {
            FrmEdicionPelicula op = new FrmEdicionPelicula();
            irformulario(op);

        }
    }
}
