using System;
using System.Data.SqlClient;
using CapaDatos;
using System.Windows.Forms;
using Utilidades_Proyecto;
using Encapsulado_Clases;
using System.IO;
using System.Drawing.Imaging;
using System.Data;

namespace CapaNegocio
{
    public class SalaConectar_BD
    {
        private static SqlCommand consultasql;
        private static SqlDataReader resultadosql;
        static string sql;
        public static Salas sa;

      
        public static int actualizarsala(Salas s, PictureBox pix)
        {
            int valor = 0;

            try
            {
                sql = "update sala set nombrepelicula='" + s.Nombrepelicula + "',imagenfoto=@foto ,linktrailer='" + s.Linkpeli + "' where idsala='" + s.Idsala + "';";
                consultasql = new SqlCommand(sql, Conexion.con());
                consultasql.Parameters.AddWithValue("@foto", SqlDbType.Image);
                MemoryStream ms = new MemoryStream();
                pix.Image.Save(ms, ImageFormat.Jpeg);
                consultasql.Parameters["@foto"].Value = ms.GetBuffer();
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


       


        private static SqlDataAdapter st;
       public static void rellenarlista(ListBox lista)
        {
            try
            {
                DataTable tablita = new DataTable();
                string sql = "SELECT  nombrepelicula FROM sala";
                st = new SqlDataAdapter(sql, Conexion.con());
                st.Fill(tablita);
                lista.DataSource = tablita;
                lista.DisplayMember = "nombrepelicula";

            }
            catch (Exception ex)
            {

                throw;
            }
        }
        public static string video(string nombrepeli)
        {
            string link = "";
            try
            {
                string sql = "select linktrailer from sala where nombrepelicula = '" + nombrepeli + "'";
                consultasql = new SqlCommand(sql, Conexion.con());
                resultadosql = consultasql.ExecuteReader();
                if (resultadosql.Read())
                {
                    link = "" + resultadosql[0];
                }

            }
            catch (Exception ex)
            {


            }
            return link;



        }


        

        public static void mostrarfoto(int codigo, PictureBox pix)
        {
            sa = new Salas();
            try
            {
                sql = "select * from sala where idsala = '" + codigo + "'";
                consultasql = new SqlCommand(sql, Conexion.con());
                resultadosql = consultasql.ExecuteReader();
                if (resultadosql.Read())

                {
                    sa.Idsala = int.Parse("" + resultadosql[0]);
                    sa.Nombrepelicula = "" + resultadosql[1];
                    pix.Image = Utilidades.CargaImagenMemoria((byte[])resultadosql[2]);
                    sa.Linkpeli = "" + resultadosql[3];


                }
            }
            catch (Exception ex)
            {
            }


        }

      
        public static DataTable mostrarsalas()
        {
            DataTable tablita = new DataTable();
            tablita.Columns.Add("ID Sala");
            tablita.Columns.Add("Nombre Pelicula ");
            tablita.Columns.Add("Link Pelicula");

            try
            {
                sql = "select idsala,nombrepelicula,linktrailer from sala";
                consultasql = new SqlCommand(sql, Conexion.con());
                resultadosql = consultasql.ExecuteReader();
                while (resultadosql.Read())
                {
                    object[] data = new object[3];
                    for (int i = 0; i < data.Length; i++)
                    {
                        data[i] = resultadosql[i];
                    }
                    tablita.Rows.Add(data);
                }
            }
            catch (Exception ex)
            {


            }
            return tablita;
        }

        public static byte[] pruebaimagem(int codigo)
        {
            byte[] arreglo = new byte[0];
            try
            {
                sql = "select * from sala where idsala = '" + codigo + "'";
                consultasql = new SqlCommand(sql, Conexion.con());
                resultadosql = consultasql.ExecuteReader();
                if (resultadosql.Read())
                {

                }
            }
            catch (Exception) { }


            return arreglo;
        }




    }
}
