using Conexiones;
using Participantes_Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador_Conectar_BD
{
    public class EmpleadoConectar_BD
    {
        private static SqlCommand consultasql;
        private static SqlDataReader resultadosql;
        static string sql;

        public static int agregarempleado(Empleado emp) {
            int valor = 0;

            try
            {
                sql = "insert into empleados values ('"+emp.Idempleado+"','"+emp.Nombre+"','"+emp.Apellido+"','"+emp.Salario+"','"+emp.Correo+"','','','','"+emp.Cargo+"','','"+emp.Horassem+"'); ";
                
                consultasql = new SqlCommand(sql, Conexion.con());
                if (consultasql.ExecuteNonQuery() > 0)
                {
                    valor = 1;
                }
            }
            catch (Exception ex)
            {
            }

            return valor;

        }



        public static int actualizarempleado(Empleado emp)
        {
            int valor = 0;

            try
            {
                sql = "update empleados set nombre = '" + emp.Nombre + "', apellido = '" + emp.Apellido + "', salario = '" + emp.Salario + "', correo = '" + emp.Correo + "', cargo = '" + emp.Cargo + "', horasalasemana = '" + emp.Horassem + "' where idempleado = '" + emp.Idempleado + "'; ";
                consultasql = new SqlCommand(sql, Conexion.con());
                if (consultasql.ExecuteNonQuery() > 0)
                {
                    valor = 1;
                }
            }
            catch (Exception ex)
            {
            }

            return valor;

        }


        public static int eliminarempleado(string codigo) {
            int valor = 0;

            try
            {
                sql = "delete from empleados where idempleado = '" + codigo + "';                ";
                consultasql = new SqlCommand(sql, Conexion.con());
                if (consultasql.ExecuteNonQuery() > 0)
                {
                    valor = 1;
                }
            }
            catch (Exception ex)
            {
            }

            return valor;

        }

        public static Empleado emp;
        public static void mostrarempleadoxcodigo(string cod) {
            emp = new Empleado();
            try
            {
                sql = " select idempleado, nombre, apellido, salario, correo, cargo, horasalasemana from empleados where idempleado = '"+cod+"'";
                consultasql = new SqlCommand(sql, Conexion.con());
                resultadosql = consultasql.ExecuteReader();
                if (resultadosql.Read())
                {
                    emp.Idempleado = "" + resultadosql[0];
                    emp.Nombre = "" + resultadosql[1];
                    emp.Apellido = "" + resultadosql[2];
                    emp.Salario = float.Parse("" + resultadosql[3]);
                    emp.Correo = "" + resultadosql[4];
                    emp.Cargo = "" + resultadosql[5];
                    emp.Horassem = "" + resultadosql[6];

                }
            }
            catch (Exception ex)
            {              
            }

        }

        public static DataTable tablaempleados() {
            DataTable tablita = new DataTable();
            tablita.Rows.Add("ID Empleado");
            tablita.Rows.Add("Nombre");
            tablita.Rows.Add("Apellido");
            tablita.Rows.Add("Salario");
            tablita.Rows.Add("Correo");
            tablita.Rows.Add("Cargo");
            tablita.Rows.Add("Horas/sem");
            try
            {
                sql = " select idempleado, nombre, apellido, salario, correo, cargo, horasalasemana from empleados ";
                consultasql = new SqlCommand(sql, Conexion.con());
                resultadosql = consultasql.ExecuteReader();
               
                object[] data = new object[7];
                while (resultadosql.Read())
                {
                    for (int i = 0; i < data.Length; i++)
                    {
                        data[i] = resultadosql[i];
                    }
                    tablita.Rows.Add(data);
                }
            }
            catch (Exception ex)
            {

                
            }
            return tablita;
        }

    }
}
