namespace Procesamientos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            abrirToolStripMenuItem = new ToolStripMenuItem();
            guardarToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            pctLienzo = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            ofdAbrir = new OpenFileDialog();
            label5 = new Label();
            label6 = new Label();
            txtImagen = new TextBox();
            txtXimagen = new TextBox();
            txtYimagen = new TextBox();
            txtYpct = new TextBox();
            txtXpct = new TextBox();
            txtPicture = new TextBox();
            label4 = new Label();
            label7 = new Label();
            btnTmImagen = new Button();
            btnTmPicture = new Button();
            pctPixel = new PictureBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pctLienzo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctPixel).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { abrirToolStripMenuItem, guardarToolStripMenuItem, salirToolStripMenuItem });
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(60, 20);
            archivoToolStripMenuItem.Text = "Archivo";
            // 
            // abrirToolStripMenuItem
            // 
            abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            abrirToolStripMenuItem.Size = new Size(116, 22);
            abrirToolStripMenuItem.Text = "Abrir";
            abrirToolStripMenuItem.Click += abrirToolStripMenuItem_Click;
            // 
            // guardarToolStripMenuItem
            // 
            guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            guardarToolStripMenuItem.Size = new Size(116, 22);
            guardarToolStripMenuItem.Text = "Guardar";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(116, 22);
            salirToolStripMenuItem.Text = "Salir";
            // 
            // pctLienzo
            // 
            pctLienzo.BackColor = SystemColors.ActiveCaptionText;
            pctLienzo.Location = new Point(12, 42);
            pctLienzo.Name = "pctLienzo";
            pctLienzo.Size = new Size(330, 330);
            pctLienzo.SizeMode = PictureBoxSizeMode.StretchImage;
            pctLienzo.TabIndex = 1;
            pctLienzo.TabStop = false;
            pctLienzo.Click += pctLienzo_Click;
            pctLienzo.MouseMove += pctLienzo_MouseMove;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(351, 52);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 2;
            label1.Text = "Imagen";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(351, 162);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 3;
            label2.Text = "Picture";
            // 
            // ofdAbrir
            // 
            ofdAbrir.FileName = "ofdAbrir";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(351, 111);
            label5.Name = "label5";
            label5.Size = new Size(14, 15);
            label5.TabIndex = 6;
            label5.Text = "X";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(532, 120);
            label6.Name = "label6";
            label6.Size = new Size(14, 15);
            label6.TabIndex = 7;
            label6.Text = "Y";
            // 
            // txtImagen
            // 
            txtImagen.Location = new Point(532, 76);
            txtImagen.Name = "txtImagen";
            txtImagen.Size = new Size(175, 23);
            txtImagen.TabIndex = 8;
            // 
            // txtXimagen
            // 
            txtXimagen.Location = new Point(373, 115);
            txtXimagen.Name = "txtXimagen";
            txtXimagen.Size = new Size(100, 23);
            txtXimagen.TabIndex = 9;
            // 
            // txtYimagen
            // 
            txtYimagen.Location = new Point(607, 115);
            txtYimagen.Name = "txtYimagen";
            txtYimagen.Size = new Size(100, 23);
            txtYimagen.TabIndex = 10;
            // 
            // txtYpct
            // 
            txtYpct.Location = new Point(607, 226);
            txtYpct.Name = "txtYpct";
            txtYpct.Size = new Size(100, 23);
            txtYpct.TabIndex = 16;
            // 
            // txtXpct
            // 
            txtXpct.Location = new Point(373, 226);
            txtXpct.Name = "txtXpct";
            txtXpct.Size = new Size(100, 23);
            txtXpct.TabIndex = 15;
            // 
            // txtPicture
            // 
            txtPicture.Location = new Point(532, 187);
            txtPicture.Name = "txtPicture";
            txtPicture.Size = new Size(175, 23);
            txtPicture.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(532, 231);
            label4.Name = "label4";
            label4.Size = new Size(14, 15);
            label4.TabIndex = 13;
            label4.Text = "Y";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(351, 222);
            label7.Name = "label7";
            label7.Size = new Size(14, 15);
            label7.TabIndex = 12;
            label7.Text = "X";
            // 
            // btnTmImagen
            // 
            btnTmImagen.Location = new Point(351, 76);
            btnTmImagen.Name = "btnTmImagen";
            btnTmImagen.Size = new Size(159, 23);
            btnTmImagen.TabIndex = 17;
            btnTmImagen.Text = "Tamaño de la imagen";
            btnTmImagen.UseVisualStyleBackColor = true;
            btnTmImagen.Click += btnTmImagen_Click;
            // 
            // btnTmPicture
            // 
            btnTmPicture.Location = new Point(351, 187);
            btnTmPicture.Name = "btnTmPicture";
            btnTmPicture.Size = new Size(159, 23);
            btnTmPicture.TabIndex = 18;
            btnTmPicture.Text = "Tamaño del picture";
            btnTmPicture.UseVisualStyleBackColor = true;
            btnTmPicture.Click += btnTmPicture_Click;
            // 
            // pctPixel
            // 
            pctPixel.BackColor = SystemColors.ActiveCaptionText;
            pctPixel.Location = new Point(427, 266);
            pctPixel.Name = "pctPixel";
            pctPixel.Size = new Size(202, 138);
            pctPixel.TabIndex = 19;
            pctPixel.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 420);
            Controls.Add(pctPixel);
            Controls.Add(btnTmPicture);
            Controls.Add(btnTmImagen);
            Controls.Add(txtYpct);
            Controls.Add(txtXpct);
            Controls.Add(txtPicture);
            Controls.Add(label4);
            Controls.Add(label7);
            Controls.Add(txtYimagen);
            Controls.Add(txtXimagen);
            Controls.Add(txtImagen);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pctLienzo);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pctLienzo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctPixel).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private PictureBox pctLienzo;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem abrirToolStripMenuItem;
        private ToolStripMenuItem guardarToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private Label label1;
        private Label label2;
        private OpenFileDialog ofdAbrir;
        private Label label5;
        private Label label6;
        private TextBox txtImagen;
        private TextBox txtXimagen;
        private TextBox txtYimagen;
        private TextBox txtYpct;
        private TextBox txtXpct;
        private TextBox txtPicture;
        private Label label4;
        private Label label7;
        private Button btnTmImagen;
        private Button btnTmPicture;
        private PictureBox pctPixel;
    }
}