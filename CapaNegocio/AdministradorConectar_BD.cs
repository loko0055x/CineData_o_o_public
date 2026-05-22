using CapaDatos;
using Encapsulado_Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class AdministradorConectar_BD
    {
        private static SqlCommand consultasql;
        private static SqlDataReader resultadosql;
        static string sql;

        //RECORDAR QUE TENEMOS QUE CREAR UN METODO PARA QUE EL CORREO DE CADA ADMINISTRADOR NO SE REPITA
        public static int VerificarAdminsiExiste(Administrador adm)
        {
            int valor = 0;
            try
            {

                consultasql = new SqlCommand("SP_VerificarAdmin", Conexion.con());
                consultasql.CommandType = CommandType.StoredProcedure;
                consultasql.Parameters.AddWithValue("@correo", adm.Correo);
                consultasql.Parameters.AddWithValue("@contra", adm.Contrasenia);
                resultadosql = consultasql.ExecuteReader();
                if (resultadosql.Read())
                {
                    valor = 1;
                }
            }
            catch (Exception ex)
            {
            }

            return valor;

        }

        public static int agregaradmin(Administrador adm)
        {
            int valor = 0;

            try
            {

                consultasql = new SqlCommand("spAgregarAdmin", Conexion.con());
                consultasql.CommandType = CommandType.StoredProcedure;
                consultasql.Parameters.AddWithValue("@dni", adm.Dni);
                consultasql.Parameters.AddWithValue("@nombre", adm.Nombre);
                consultasql.Parameters.AddWithValue("@apellido", adm.Apellido);
                consultasql.Parameters.AddWithValue("@salario", adm.Salario);
                consultasql.Parameters.AddWithValue("@correo", adm.Correo);
                consultasql.Parameters.AddWithValue("@contraseña", adm.Contrasenia);
                consultasql.Parameters.AddWithValue("@direccion", adm.Dirreccion);
                consultasql.Parameters.AddWithValue("@telefono", adm.Celular);
                consultasql.Parameters.AddWithValue("@sexo", adm.Sexo);
                consultasql.Parameters.AddWithValue("@fechanacimiento", adm.Fecha);
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


        public static int actualizaradmin(Administrador adm)
        {
            int valor = 0;

            try
            {

                consultasql = new SqlCommand("spActualizarAdmin", Conexion.con());
                consultasql.CommandType = CommandType.StoredProcedure;
                consultasql.Parameters.AddWithValue("@dni", adm.Dni);
                consultasql.Parameters.AddWithValue("@nombre", adm.Nombre);
                consultasql.Parameters.AddWithValue("@apellido", adm.Apellido);
                consultasql.Parameters.AddWithValue("@salario", adm.Salario);
                consultasql.Parameters.AddWithValue("@correo", adm.Correo);
                consultasql.Parameters.AddWithValue("@contraseña", adm.Contrasenia);
                consultasql.Parameters.AddWithValue("@direccion", adm.Dirreccion);
                consultasql.Parameters.AddWithValue("@telefono", adm.Celular);
                consultasql.Parameters.AddWithValue("@sexo", adm.Sexo);
                consultasql.Parameters.AddWithValue("@fechanacimiento", adm.Fecha);
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

        public static int eliminaradmin(int dni)
        {
            int valor = 0;
            try
            {

                consultasql = new SqlCommand("spEliminaAdmin", Conexion.con());
                consultasql.CommandType = CommandType.StoredProcedure;
                consultasql.Parameters.AddWithValue("@dni", dni);
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

        
       



        public static DataTable mostraradministradores()
        {
            DataTable tablita = new DataTable();
            tablita.Columns.Add("Dni");
            tablita.Columns.Add("Nombre");
            tablita.Columns.Add("Apellido");
            tablita.Columns.Add("Salario");
            tablita.Columns.Add("Correo");
            tablita.Columns.Add("Contra");
            tablita.Columns.Add("Direccion");
            tablita.Columns.Add("Telefono");
            tablita.Columns.Add("Sexo");
            tablita.Columns.Add("Fecha-Nac");


            try
            {
                consultasql = new SqlCommand("SP_ConsultarAdmin", Conexion.con());
                consultasql.CommandType = CommandType.StoredProcedure;
                resultadosql = consultasql.ExecuteReader();
                while (resultadosql.Read())
                {
                    object[] data = new object[10];
                    for (int i = 0; i < data.Length; i++)
                    {
                        data[i] = "" + resultadosql[i];
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
