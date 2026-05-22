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
    public class DulceriaConectar_BD
    {
        private static SqlCommand consultasql;
        private static SqlDataReader resultadosql;
        static string sql;

        public static Dulceria dul;
        public static void listardulces(int codigo) {

            dul = new Dulceria();
             try
               {
                sql = "select * from dulceria where iddulceria='"+codigo+"'";
            consultasql = new SqlCommand( sql, Conexion.con());
            resultadosql = consultasql.ExecuteReader();
                if (resultadosql.Read())
                {
                    dul.Nomdulceria =""+ resultadosql[1];
                    dul.Precio = float.Parse(""+resultadosql[2]);

                }

            }
            catch (Exception ex)
            {
            }
        
        
        }

    }
}
