namespace Procesamientos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Graphics Lienzo;
        Bitmap ImagenOriginal;

        int AnchoImagen, AltoImagen;
        int AnchoPicture, AltoPicture;
        int xi, yi;

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ofdAbrir.ShowDialog() == DialogResult.OK)
            {
                ImagenOriginal = (Bitmap)(Bitmap.FromFile(ofdAbrir.FileName));
                AnchoImagen = ImagenOriginal.Width;
                AltoImagen = ImagenOriginal.Height;
                pctLienzo.Image = ImagenOriginal;

            }
        }

        private void btnTmImagen_Click(object sender, EventArgs e)
        {
            txtImagen.Text = "x: " + ImagenOriginal.Width + " y: " + ImagenOriginal.Height + "";
        }

        private void btnTmPicture_Click(object sender, EventArgs e)
        {
            txtPicture.Text = "x: " + pctLienzo.Width + " y: " + pctLienzo.Height + "";
        }

        private void pctLienzo_MouseMove(object sender, MouseEventArgs e)
        {
            txtXpct.Text = e.X.ToString();
            txtYpct.Text = e.Y.ToString();

            xi = AnchoImagen * e.X / pctLienzo.Width;
            yi = AltoImagen * e.Y / pctLienzo.Height;

            txtXimagen.Text = xi.ToString();
            txtYimagen.Text = yi.ToString();


        }

        int posx, posy, a = 20;
        private void pctLienzo_Click(object sender, EventArgs e)
        {
            //posx = AnchoPicture / 2;
            //posy = AltoPicture / 2;

            posx = pctPixel.Width / 2;
            posy = pctPixel.Height / 2;

            Color miColor = new Color();


            miColor = ImagenOriginal.GetPixel(xi, yi);
            Brush miBrocha = new SolidBrush(miColor);
            Lienzo.FillRectangle(miBrocha, posx, posy, a, a);

            miColor = ImagenOriginal.GetPixel(xi + 1, yi);
            miBrocha = new SolidBrush(miColor);
            Lienzo.FillRectangle(miBrocha, posx + a, posy, a, a);

            miColor = ImagenOriginal.GetPixel(xi - 1, yi);
            miBrocha = new SolidBrush(miColor);
            Lienzo.FillRectangle(miBrocha, posx - a, posy, a, a);



            miColor = ImagenOriginal.GetPixel(xi, yi - 1);
            miBrocha = new SolidBrush(miColor);
            Lienzo.FillRectangle(miBrocha, posx, posy - a, a, a);

            miColor = ImagenOriginal.GetPixel(xi + 1, yi - 1);
            miBrocha = new SolidBrush(miColor);
            Lienzo.FillRectangle(miBrocha, posx + a, posy - a, a, a);

            miColor = ImagenOriginal.GetPixel(xi - 1, yi - 1);
            miBrocha = new SolidBrush(miColor);
            Lienzo.FillRectangle(miBrocha, posx - a, posy - a, a, a);



            miColor = ImagenOriginal.GetPixel(xi, yi + 1);
            miBrocha = new SolidBrush(miColor);
            Lienzo.FillRectangle(miBrocha, posx, posy + a, a, a);

            miColor = ImagenOriginal.GetPixel(xi + 1, yi + 1);
            miBrocha = new SolidBrush(miColor);
            Lienzo.FillRectangle(miBrocha, posx + a, posy + a, a, a);

            miColor = ImagenOriginal.GetPixel(xi - 1, yi + 1);
            miBrocha = new SolidBrush(miColor);
            Lienzo.FillRectangle(miBrocha, posx - a, posy + a, a, a);


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Lienzo = pctPixel.CreateGraphics();
        }
    }
}