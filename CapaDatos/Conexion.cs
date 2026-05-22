using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilidades_Proyecto;


namespace CapaDatos
{
    public class Conexion
    {
        static SqlConnection conectar;
        public static SqlConnection con()
        {

            try
            {
                string datos = "Data Source=DESKTOP-6N9PFRV;Initial Catalog=Cine_Data_O_O;User=sa;Password=lokito@14JCB#/rubick";
                conectar = new SqlConnection(datos);
                conectar.Open();
                //  mensaje.mostrarmensaje("Entro ala BD correctamente");
            }
            catch (Exception ex)
            {
                Utilidades.mostrarmensaje("Error" + ex.Message);
            }
            return conectar;
        }

        public static void cerrarconexion()
        {
            if (con().State == ConnectionState.Open)
            {
                conectar.Close();
            }

        }
    }
}
