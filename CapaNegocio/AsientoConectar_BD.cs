using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Encapsulado_Clases;

namespace CapaNegocio
{
    public class AsientoConectar_BD
    {
        private static SqlCommand consultasql;
        private static SqlDataReader resultadosql;
        static string sql;
        public static void Actualizarasientos_si(int numeroasiento, int codsala)
        {
            try
            {
                string sql = "update asientos set estado='si' where numasiento=@numeroasiento and idsala=@codsala;";
                consultasql = new SqlCommand(sql, Conexion.con());
                consultasql.Parameters.AddWithValue("@numeroasiento", numeroasiento);
                consultasql.Parameters.AddWithValue("@codsala", codsala);
                if (consultasql.ExecuteNonQuery() > 0)
                {

                }

            }
            catch (Exception ex)
            {

            }
        }


        public static void Actualizarasientos_no(int numeroasiento, int codsala)
        {
            try
            {
                string sql = "update asientos set estado='no' where numasiento=@numeroasiento and idsala=@codsala;";
                consultasql = new SqlCommand(sql, Conexion.con());
                consultasql.Parameters.AddWithValue("@numeroasiento", numeroasiento);
                consultasql.Parameters.AddWithValue("@codsala", codsala);
                if (consultasql.ExecuteNonQuery() > 0)
                {

                }

            }
            catch (Exception ex)
            {

            }
        }

        public static string retornarestado(int numeroasiento, int codsala)
        {
            string estado = "";
            try
            {
                sql = "select estado from asientos where numasiento='" + numeroasiento + "' and idsala='" + codsala + "'";
                consultasql = new SqlCommand(sql, Conexion.con());
                resultadosql = consultasql.ExecuteReader();
                if (resultadosql.Read())
                {
                    estado = "" + resultadosql[0];
                }
            }
            catch (Exception ex)
            {

            }

            return estado;
        }


    }
}
