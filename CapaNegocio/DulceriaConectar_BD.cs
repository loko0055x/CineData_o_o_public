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
    public class DulceriaConectar_BD
    {
        private static SqlCommand consultasql;
        private static SqlDataReader resultadosql;
        static string sql;

        public static Dulceria dul;
        public static void listardulces(int codigo)
        {

            dul = new Dulceria();
            try
            {
                consultasql = new SqlCommand("SP_ConsultarDulceria", Conexion.con());
                consultasql.CommandType = CommandType.StoredProcedure;
                consultasql.Parameters.AddWithValue("@id",codigo);
                resultadosql = consultasql.ExecuteReader();
                if (resultadosql.Read())
                {
                    dul.Nomdulceria = "" + resultadosql[1];
                    dul.Precio = float.Parse("" + resultadosql[2]);

                }

            }
            catch (Exception ex)
            {
            }


        }
    }
}
