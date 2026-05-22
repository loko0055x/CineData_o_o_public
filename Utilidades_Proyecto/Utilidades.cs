using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Utilidades_Proyecto
{
    public class Utilidades
    {
        public static void mostrarmensaje(string msg) {
            MessageBox.Show(msg);
        }

        public static Image CargaImagenMemoria(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        //este metodo es para abrir una imagen con ayuda de un pixture box 
        public static void abrir_imagen(OpenFileDialog openFileDialog1, PictureBox pix)
        {
            try
            {
                openFileDialog1.ShowDialog();
                if (openFileDialog1.FileName.Equals("") == false)
                {
                    pix.Load(openFileDialog1.FileName);
                }
            }
            catch (Exception ex)
            {
                mostrarmensaje("error al abrir" + ex.Message);
            }
        }

    }
}
