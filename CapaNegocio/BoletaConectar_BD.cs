using CapaDatos;
using Encapsulado_Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class BoletaConectar_BD
    {
        private static SqlCommand consultasql;
        private static SqlDataReader resultadosql;
        static string sql;
        public static int agregarboleta(Boleta bola)
        {
            try
            {
                // Query SQL de insert directo
                string query = @"INSERT INTO boleta
                        (nombre, apellido, correo, nombrepelicula, subtotalentradas, subtotaldulceria, tipo_pago, total)
                         VALUES
                        (@nombre, @apellido, @correo, @nombrepelicula, @subtotalentradas, @subtotaldulceria, @tipo_pago, @total)";

                consultasql = new SqlCommand(query, Conexion.con());
                consultasql.CommandType = CommandType.Text;

                consultasql.Parameters.AddWithValue("@nombre", bola.Nombre);
                consultasql.Parameters.AddWithValue("@apellido", bola.Apellido);
                consultasql.Parameters.AddWithValue("@correo", bola.Correo);
                consultasql.Parameters.AddWithValue("@nombrepelicula", bola.Nombrepeli);
                consultasql.Parameters.AddWithValue("@subtotalentradas", bola.Subtotalentradas);
                consultasql.Parameters.AddWithValue("@subtotaldulceria", bola.Subtotaldulceria);
                consultasql.Parameters.AddWithValue("@tipo_pago", bola.Tipopago);
                consultasql.Parameters.AddWithValue("@total", bola.Total);

                if (consultasql.ExecuteNonQuery() > 0)
                {
                    return 1;
                }
            }
            catch (Exception ex)
            {
                // Aquí podrías loguear el error si quieres
                Console.WriteLine("Error: " + ex.Message);
            }
            return 0;
        }


    }
}
