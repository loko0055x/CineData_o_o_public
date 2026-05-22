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
    public class BoletaConectar_BD
    {
        private static SqlCommand consultasql;
        private static SqlDataReader resultadosql;
        static string sql;
        public static int agregarboleta(Boleta bola) {
            try
            {
                sql = "insert into boleta(nombre, apellido, correo, nombrepelicula, subtotalentradas, subtotaldulceria, tipo_pago, total)values" +
                    "('"+bola.Nombre+"', '"+bola.Apellido+"', '"+bola.Correo+"', '"+bola.Nombrepeli+"', '"+bola.Subtotalentradas+"', '"+bola.Subtotaldulceria+"', '"+bola.Tipopago+"', '"+bola.Total+"')";
                consultasql = new SqlCommand(sql, Conexion.con());
                if (consultasql.ExecuteNonQuery()>0)
                {
                    return 1;
                }
            }
            catch (Exception ex)
            {
              
            }
            return 0;
        }
    }
}
