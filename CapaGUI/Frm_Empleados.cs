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
    public partial class Frm_Empleados : Form
    {
        public Frm_Empleados()
        {
            InitializeComponent();
            arreglo[0]=txtcodigo;
            arreglo[1] = txtnombres;
            arreglo[2] = txtape;
            arreglo[3] = txtsalario;
            arreglo[4] = txtcorreo;


        }


        private void Frm_Empleados_Load(object sender, EventArgs e)
        {
            tblempleados.DataSource = EmpleadoConectar_BD.tablaempleados();

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            Empleados emp = new Empleados(txtcodigo.Text,txtnombres.Text, txtape.Text, float.Parse(txtsalario.Text), txtcorreo.Text, cbocargo.Text, "");

            

            if (rbt1.Checked)
            {
                emp.Horassem = rbt1.Text;
            }
            else if (rbt2.Checked)
            {
                emp.Horassem = rbt2.Text;

            }
            Console.WriteLine("" + emp.Idempleado);
            Console.WriteLine("" + emp.Nombre);
            Console.WriteLine("" + emp.Apellido);
            Console.WriteLine("" + emp.Salario);
            Console.WriteLine("" + emp.Correo);
            Console.WriteLine("" + emp.Cargo);
            Console.WriteLine("" + emp.Horassem);


            if (EmpleadoConectar_BD.agregarempleado(emp) == 1)
            {
                Utilidades.mostrarmensaje("se agrego correctamente");
                tblempleados.DataSource = EmpleadoConectar_BD.tablaempleados();

            }
            else
            {
                Utilidades.mostrarmensaje("error");

            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (EmpleadoConectar_BD.eliminarempleado(txtcodigo.Text) == 1)
            {
                Utilidades.mostrarmensaje("se elimino correctamente");
                tblempleados.DataSource = EmpleadoConectar_BD.tablaempleados();

            }
            else
            {
                Utilidades.mostrarmensaje("error");

            }
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            Empleados emp = new Empleados(txtcodigo.Text, txtnombres.Text, txtape.Text, float.Parse(txtsalario.Text), txtcorreo.Text, cbocargo.Text, "");
            if (rbt1.Checked)
            {
                emp.Horassem = rbt1.Text;
            }
            else if (rbt2.Checked)
            {
                emp.Horassem = rbt2.Text;

            }
            if (EmpleadoConectar_BD.actualizarempleado(emp) == 1)
            {
                Utilidades.mostrarmensaje("se actualizo correctamente");
                tblempleados.DataSource = EmpleadoConectar_BD.tablaempleados();

            }
            else
            {
                Utilidades.mostrarmensaje("error");

            }

        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
           
        }

        private void pixsalir_Click(object sender, EventArgs e)
        {
            Frm_MDI_Administracion op = new Frm_MDI_Administracion();
            op.Visible = true;
            this.Hide();
        }

        TextBox[] arreglo = new TextBox[5];


        private void tblempleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = e.RowIndex;
            if (!(n == -1))
            {
                //  txtdni.Text = "" + tbladmin.Rows[n].Cells[0].Value;
                for (int i = 0; i < arreglo.Length; i++)
                {
                    arreglo[i].Text = "" + tblempleados.Rows[n].Cells[i].Value;
                }
                cbocargo.Text = "" + tblempleados.Rows[n].Cells[5].Value;

                string horario = "" + tblempleados.Rows[n].Cells[6].Value;
                if (horario.Equals("24H/semana",StringComparison.InvariantCultureIgnoreCase))
                {
                    rbt1.Checked = true;
                }
                else if (horario.Equals("48H/semana", StringComparison.InvariantCultureIgnoreCase))
                {
                    rbt2.Checked = true;

                }


            }
        }
    }
   
}
