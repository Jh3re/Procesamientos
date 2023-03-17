using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Procesamientos
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        Graphics Lienzo;
        //Variables
        Bitmap ImagenOriginal;
        Bitmap ImagenResultado;
        int AnchoImagen, AltoImagen;


        private void rojoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int i, j, rojo;
            Color miColor = new Color();
            Color nuevoColor = new Color();
            for (i = 0; i < AnchoImagen; i++)
            {
                for (j = 0; j < AltoImagen; j++)
                {
                    miColor = ImagenOriginal.GetPixel(i, j);
                    rojo = (miColor.R + miColor.B + miColor.G) / 3;
                    nuevoColor = Color.FromArgb(255, rojo, 0, 0);
                    ImagenResultado.SetPixel(i, j, nuevoColor);
                }
            }
            pctLienzo.Image = ImagenResultado;
            pctLienzo.Refresh();
        }

        private void verdeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int i, j, verde;
            Color miColor = new Color();
            Color nuevoColor = new Color();
            for (i = 0; i < AnchoImagen; i++)
            {
                for (j = 0; j < AltoImagen; j++)
                {
                    miColor = ImagenOriginal.GetPixel(i, j);
                    verde = (miColor.R + miColor.B + miColor.G) / 3;
                    nuevoColor = Color.FromArgb(255, 0, verde, 0);
                    ImagenResultado.SetPixel(i, j, nuevoColor);
                }
            }
            pctLienzo.Image = ImagenResultado;
            pctLienzo.Refresh();
        }

        private void azulToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int i, j, azul;
            Color miColor = new Color();
            Color nuevoColor = new Color();
            for (i = 0; i < AnchoImagen; i++)
            {
                for (j = 0; j < AltoImagen; j++)
                {
                    miColor = ImagenOriginal.GetPixel(i, j);
                    azul = (miColor.R + miColor.B + miColor.G) / 3;
                    nuevoColor = Color.FromArgb(255, 0, 0, azul);
                    ImagenResultado.SetPixel(i, j, nuevoColor);
                }
            }
            pctLienzo.Image = ImagenResultado;
            pctLienzo.Refresh();
        }

        private void imagenOriginalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImagenOriginal = (Bitmap)(Bitmap.FromFile(ofdAbrir.FileName));
            pctLienzo.Image = ImagenOriginal;
            pctLienzo.Refresh();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ofdAbrir.ShowDialog() == DialogResult.OK)
            {
                ImagenOriginal = (Bitmap)(Bitmap.FromFile(ofdAbrir.FileName));
                AnchoImagen = ImagenOriginal.Width;
                AltoImagen = ImagenOriginal.Height;
                pctLienzo.Image = ImagenOriginal;
                ImagenResultado = ImagenOriginal;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
