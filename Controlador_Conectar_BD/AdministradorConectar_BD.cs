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
    public class AdministradorConectar_BD
    {
        private static SqlCommand consultasql;
        private static SqlDataReader resultadosql;
        static string sql;

        //RECORDAR QUE TENEMOS QUE CREAR UN METODO PARA QUE EL CORREO DE CADA ADMINISTRADOR NO SE REPITA
        public static int verificarsiadminexiste(Administrador adm){
            int valor = 0;
            try
            {
                sql = "select  dni from administradores where correo='"+adm.Correo+"' and contraseña='"+adm.Contrasenia+"'";
                consultasql = new SqlCommand(sql, Conexion.con());
                resultadosql = consultasql.ExecuteReader();
                if (resultadosql.Read())
                {
                    valor = 1;
                }
            }
            catch (Exception)
            {

                throw;
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
                consultasql.Parameters.AddWithValue("@nombre",adm.Nombre);
                consultasql.Parameters.AddWithValue("@apellido",adm.Apellido);
                consultasql.Parameters.AddWithValue("@salario",adm.Salario);
                consultasql.Parameters.AddWithValue("@correo",adm.Correo);
                consultasql.Parameters.AddWithValue("@contraseña",adm.Contrasenia);
                consultasql.Parameters.AddWithValue("@direccion",adm.Dirreccion);
                consultasql.Parameters.AddWithValue("@telefono",adm.Celular);
                consultasql.Parameters.AddWithValue("@sexo",adm.Sexo);
                consultasql.Parameters.AddWithValue("@fechanacimiento",adm.Fecha);               
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

        public static int eliminaradmin(int dni) {
            int valor = 0;
            try
            {
               
                consultasql = new SqlCommand("spEliminaAdmin", Conexion.con());
                consultasql.CommandType = CommandType.StoredProcedure;
                consultasql.Parameters.AddWithValue("@dni",dni);
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

        public static Administrador admin;
        public static void buscaradmin(int dni) {
            admin = new Administrador();
            try
            {
                sql = " select * from empleados where administradores = '" + dni + "'";
                consultasql = new SqlCommand(sql, Conexion.con());
                resultadosql = consultasql.ExecuteReader();
                if (resultadosql.Read())
                {
                    admin.Dni = int.Parse("" + resultadosql[0]);
                    admin.Nombre = "" + resultadosql[1];

                }
            }
            catch (Exception ex)
            {

                
            }

         }



        public static DataTable mostraradministradores() {
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
                sql = "select *from administradores";
                consultasql = new SqlCommand(sql, Conexion.con());
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
