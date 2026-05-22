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
    public class ClienteConectar_BD
    {
        private static SqlCommand consultasql;
        private static SqlDataReader resultadosql;
        static string sql;
        public static int agregarcliente(ClientePremiun cli)
        {
            int valor = 0;
            try
            {
                consultasql = new SqlCommand("SP_InsertarClienteP", Conexion.con());
                consultasql.CommandType = CommandType.StoredProcedure;
                consultasql.Parameters.AddWithValue("@dni", cli.Dni);
                consultasql.Parameters.AddWithValue("@nombre", cli.Nombre);
                consultasql.Parameters.AddWithValue("@apellido", cli.Apellido);
                consultasql.Parameters.AddWithValue("@celular", cli.Celular);
                consultasql.Parameters.AddWithValue("@sexo", cli.Sexo);
                consultasql.Parameters.AddWithValue("@correo", cli.Correo);
                consultasql.Parameters.AddWithValue("@contra", cli.Contraseña);
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


        public static int verificarsiclienteexiste(ClientePremiun cli)
        {
            int valor = 0;
            try
            {
                consultasql = new SqlCommand("SP_RetornarClienteP", Conexion.con());
                consultasql.CommandType = CommandType.StoredProcedure;
                consultasql.Parameters.AddWithValue("@dni", cli.Dni);
                consultasql.Parameters.AddWithValue("@contra", cli.Contraseña);
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


        public static ClientePremiun c;

        public static void retornardatosclientes(ClientePremiun cli)
        {
            c = new ClientePremiun();
            try
            {
                sql = "select nombre, apellido,correo from cliente_premiun where dni = '" + cli.Dni + "' and contraseña = '" + cli.Contraseña + "'";
                consultasql = new SqlCommand(sql, Conexion.con());
                resultadosql = consultasql.ExecuteReader();
                if (resultadosql.Read())
                {
                    c.Nombre = "" + resultadosql[0];
                    c.Apellido = "" + resultadosql[1];
                    c.Correo = "" + resultadosql[2];
                }
            }
            catch (Exception ex)
            {

            }
        }



    }
}
