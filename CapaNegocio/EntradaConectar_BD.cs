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
    public class EntradaConectar_BD
    { 
            private static SqlDataReader resultadosql;
            private static SqlCommand consultasql;
            static string sql;

            public static TipoEntrada en;
            public static void mostrardulceriaescogida(int codigo)
            {
                en = new TipoEntrada();
                try
                {
                    consultasql = new SqlCommand("SP_MostrarTipoEntrada", Conexion.con());
                    consultasql.CommandType = CommandType.StoredProcedure;
                    consultasql.Parameters.AddWithValue("@id", codigo);
                    resultadosql = consultasql.ExecuteReader();
                    if (resultadosql.Read())
                    {
                        en.Entrada = "" + resultadosql[0];
                        en.Precio = float.Parse("" + resultadosql[1]);
                    }
                }

                catch (Exception ex)
                {

                }

            }
    }
    
}
