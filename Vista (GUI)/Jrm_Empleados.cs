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
    public partial class Jrm_Empleados : Form
    {
        public Jrm_Empleados()
        {
            InitializeComponent();
        }

        private void Jrm_Empleados_Load(object sender, EventArgs e)
        {
        }



        private void btnagregar_Click(object sender, EventArgs e)
        {
                Empleado emp = new Empleado(txtcodigo.Text,txtnom.Text,txtape.Text,float.Parse(txtsalario.Text),txtcorreo.Text,cmdcargo.Text,"");

       //     Empleado emp = new Empleado();
           
            if (rbt24.Checked)
            {
                emp.Horassem = rbt24.Text;
            }
            else if (rbt48.Checked)
            {
                emp.Horassem = rbt48.Text;

            }
            Console.WriteLine(""+emp.Idempleado);
            Console.WriteLine("" + emp.Nombre);
            Console.WriteLine("" + emp.Apellido);
            Console.WriteLine("" + emp.Salario);
            Console.WriteLine("" + emp.Correo);
            Console.WriteLine("" + emp.Cargo);
            Console.WriteLine("" + emp.Horassem);


            if (EmpleadoConectar_BD.agregarempleado(emp)==1)
            {
                Utilidades.mostrarmensaje("se agrego correctamente");
            }
            else
            {
                Utilidades.mostrarmensaje("error");

            }
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            Empleado emp = new Empleado(txtcodigo.Text, txtnom.Text, txtape.Text, float.Parse(txtsalario.Text), txtcorreo.Text, cmdcargo.Text, "");
            if (rbt24.Checked)
            {
                emp.Horassem = rbt24.Text;
            }
            else if (rbt48.Checked)
            {
                emp.Horassem = rbt48.Text;

            }
            if (EmpleadoConectar_BD.actualizarempleado(emp) == 1)
            {
                Utilidades.mostrarmensaje("se actualizo correctamente");
            }
            else
            {
                Utilidades.mostrarmensaje("error");

            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (EmpleadoConectar_BD.eliminarempleado(txtcodigo.Text)==1)
            {
                Utilidades.mostrarmensaje("se elimino correctamente");
            }
            else
            {
                Utilidades.mostrarmensaje("error");

            }
        }
    }
}
