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
    public partial class Jrm_MDI_Administracion : Form
    {
        public Jrm_MDI_Administracion()
        {
            InitializeComponent();
        }

        private void Jrm_MDI_Administracion_Load(object sender, EventArgs e)
        {

        }
        private void irformulario(Form jrm) {
            jrm.Visible = true;
            this.Hide();
        }

        private void mnuempleados_Click(object sender, EventArgs e)
        {
            Jrm_Empleados op = new Jrm_Empleados();
            irformulario(op);
        }

        private void mnuadministradores_Click(object sender, EventArgs e)
        {
            Jrm_Administradores op = new Jrm_Administradores();
            irformulario(op);
        }

        private void mnuedicionpeliculas_Click(object sender, EventArgs e)
        {
            Jmr_EdicionPeliculas op = new Jmr_EdicionPeliculas();
            irformulario(op);
        }
    }
}
