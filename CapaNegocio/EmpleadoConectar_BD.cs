using CapaDatos;
using Encapsulado_Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
namespace CapaNegocio
{
    public class EmpleadoConectar_BD
    {
        private static SqlCommand consultasql;
        private static SqlDataReader resultadosql;
        static string sql;

        public static int agregarempleado(Empleados emp)
        {
            int valor = 0;

            try
            {
                consultasql = new SqlCommand("SP_AgregarEmple", Conexion.con());
                consultasql.CommandType = CommandType.StoredProcedure;
                consultasql.Parameters.AddWithValue("@id", emp.Idempleado);
                consultasql.Parameters.AddWithValue("@nombre", emp.Nombre);
                consultasql.Parameters.AddWithValue("@apellido", emp.Apellido);
                consultasql.Parameters.AddWithValue("@salario", emp.Salario);
                consultasql.Parameters.AddWithValue("@correo", emp.Correo);
                consultasql.Parameters.AddWithValue("@cargo", emp.Cargo);
                consultasql.Parameters.AddWithValue("@horaxsemana", emp.Horassem);
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



        public static int actualizarempleado(Empleados emp)
        {
            int valor = 0;

            try
            {
                consultasql = new SqlCommand("SP_ActualizarEmple", Conexion.con());
                consultasql.CommandType = CommandType.StoredProcedure;
                consultasql.Parameters.AddWithValue("@id", emp.Idempleado);
                consultasql.Parameters.AddWithValue("@nombre", emp.Nombre);
                consultasql.Parameters.AddWithValue("@apellido", emp.Apellido);
                consultasql.Parameters.AddWithValue("@salario", emp.Salario);
                consultasql.Parameters.AddWithValue("@correo", emp.Correo);
                consultasql.Parameters.AddWithValue("@cargo", emp.Cargo);
                consultasql.Parameters.AddWithValue("@horaxsemana", emp.Horassem);
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


        public static int eliminarempleado(string codigo)
        {
            int valor = 0;

            try
            {
                consultasql = new SqlCommand("SP_EliminarEmple", Conexion.con());
                consultasql.CommandType = CommandType.StoredProcedure;
                consultasql.Parameters.AddWithValue("@id", codigo);
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

        public static Empleados emp;
        public static void mostrarempleadoxcodigo(string cod)
        {
            emp = new Empleados();
            try
            {
                consultasql = new SqlCommand("SP_MostrarEmpleadoxCodigo", Conexion.con());
                consultasql.CommandType = CommandType.StoredProcedure;
                consultasql.Parameters.AddWithValue("@id",cod);
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

        public static DataTable tablaempleados()
        {
            DataTable tablita = new DataTable();
            tablita.Columns.Add("idempleado");
            tablita.Columns.Add("Nombre");
            tablita.Columns.Add("Apellido");
            tablita.Columns.Add("Salario");
            tablita.Columns.Add("Correo");
            tablita.Columns.Add("Cargo");
            tablita.Columns.Add("Horas/sem");
            try
            {
                consultasql = new SqlCommand("SP_MostrarEmple", Conexion.con());
                consultasql.CommandType = CommandType.StoredProcedure;
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
