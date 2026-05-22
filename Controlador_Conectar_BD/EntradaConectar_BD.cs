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
    public class EntradaConectar_BD
    {
        private static SqlDataReader resultadosql;
        private static SqlCommand consultasql;
        static string sql;

        public static TipoEntrada en;
        public static void mostrardulceriaescogida(int codigo)
        {
            en = new TipoEntrada();
            try {
                sql = "select tipoentrada,precio from tipoentrada  where id ='"+codigo+"'";
                consultasql = new SqlCommand(sql,Conexion.con());
                resultadosql = consultasql.ExecuteReader();
                if (resultadosql.Read())
                {
                    en.Entrada = "" + resultadosql[0];
                    en.Precio = float.Parse("" + resultadosql[1]);
                }
            }

            catch (Exception ex) { 
            
            }
        
        }

    }
}
