using Conexiones;
using Participantes_Clases;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador_Conectar_BD
{
    public class ClienteConectar_BD
    {
        private static SqlCommand consultasql;
        private static SqlDataReader resultadosql;
        static string sql;
        public static int agregarcliente(Cliente_Premiun cli) {
            int valor = 0;
            try
            {
                sql = "insert into cliente_premiun values" +
                    "('"+cli.Dni+"','"+cli.Nombre+"','"+cli.Apellido+"',"+cli.Celular+",'"+cli.Sexo+"','"+cli.Correo+"','"+cli.Contraseña+"',''); ";
                consultasql = new SqlCommand(sql, Conexion.con());
                if (consultasql.ExecuteNonQuery()>0)
                {
                    valor = 1;
                }
            }
            catch (Exception ex)
            {
            }

            return valor;
        
        }


        public static int verificarsiclienteexiste(Cliente_Premiun cli) {
            int valor = 0;
            try
            {
                sql = "select nombre, apellido from cliente_premiun where dni = '"+cli.Dni+"' and contraseña = '"+cli.Contraseña+"'";
                consultasql = new SqlCommand(sql,Conexion.con());
                resultadosql = consultasql.ExecuteReader();
                if (resultadosql.Read())
                {
                    valor=1;
                }
            }
            catch (Exception ex)
            {

            }
            return valor;
        }


        public static Cliente_Premiun c;

        public static void  retornardatosclientes(Cliente_Premiun cli)
        {
            c = new Cliente_Premiun();
            try
            {
                sql = "select nombre, apellido,correo from cliente_premiun where dni = '" + cli.Dni + "' and contraseña = '" + cli.Contraseña + "'";
                consultasql = new SqlCommand(sql, Conexion.con());
                resultadosql = consultasql.ExecuteReader();
                if (resultadosql.Read())
                {
                    c.Nombre =""+ resultadosql[0];
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
