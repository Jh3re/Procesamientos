namespace Procesamientos
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pctLienzo = new PictureBox();
            menuStrip1 = new MenuStrip();
            aToolStripMenuItem = new ToolStripMenuItem();
            abrirToolStripMenuItem = new ToolStripMenuItem();
            guardarToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            basicosToolStripMenuItem = new ToolStripMenuItem();
            imagenOriginalToolStripMenuItem = new ToolStripMenuItem();
            filtrosDeColorToolStripMenuItem = new ToolStripMenuItem();
            rojoToolStripMenuItem = new ToolStripMenuItem();
            verdeToolStripMenuItem = new ToolStripMenuItem();
            azulToolStripMenuItem = new ToolStripMenuItem();
            efectosToolStripMenuItem = new ToolStripMenuItem();
            ofdAbrir = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pctLienzo).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pctLienzo
            // 
            pctLienzo.BackColor = SystemColors.ActiveCaptionText;
            pctLienzo.Location = new Point(12, 57);
            pctLienzo.Name = "pctLienzo";
            pctLienzo.Size = new Size(329, 269);
            pctLienzo.TabIndex = 1;
            pctLienzo.TabStop = false;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { aToolStripMenuItem, basicosToolStripMenuItem, filtrosDeColorToolStripMenuItem, efectosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(362, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // aToolStripMenuItem
            // 
            aToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { abrirToolStripMenuItem, guardarToolStripMenuItem, salirToolStripMenuItem });
            aToolStripMenuItem.Name = "aToolStripMenuItem";
            aToolStripMenuItem.Size = new Size(60, 20);
            aToolStripMenuItem.Text = "Archivo";
            // 
            // abrirToolStripMenuItem
            // 
            abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            abrirToolStripMenuItem.Size = new Size(180, 22);
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
            // basicosToolStripMenuItem
            // 
            basicosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { imagenOriginalToolStripMenuItem });
            basicosToolStripMenuItem.Name = "basicosToolStripMenuItem";
            basicosToolStripMenuItem.Size = new Size(58, 20);
            basicosToolStripMenuItem.Text = "Basicos";
            // 
            // imagenOriginalToolStripMenuItem
            // 
            imagenOriginalToolStripMenuItem.Name = "imagenOriginalToolStripMenuItem";
            imagenOriginalToolStripMenuItem.Size = new Size(180, 22);
            imagenOriginalToolStripMenuItem.Text = "Imagen original";
            imagenOriginalToolStripMenuItem.Click += imagenOriginalToolStripMenuItem_Click;
            // 
            // filtrosDeColorToolStripMenuItem
            // 
            filtrosDeColorToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { rojoToolStripMenuItem, verdeToolStripMenuItem, azulToolStripMenuItem });
            filtrosDeColorToolStripMenuItem.Name = "filtrosDeColorToolStripMenuItem";
            filtrosDeColorToolStripMenuItem.Size = new Size(97, 20);
            filtrosDeColorToolStripMenuItem.Text = "Filtros de color";
            // 
            // rojoToolStripMenuItem
            // 
            rojoToolStripMenuItem.Name = "rojoToolStripMenuItem";
            rojoToolStripMenuItem.Size = new Size(180, 22);
            rojoToolStripMenuItem.Text = "Rojo";
            rojoToolStripMenuItem.Click += rojoToolStripMenuItem_Click;
            // 
            // verdeToolStripMenuItem
            // 
            verdeToolStripMenuItem.Name = "verdeToolStripMenuItem";
            verdeToolStripMenuItem.Size = new Size(180, 22);
            verdeToolStripMenuItem.Text = "Verde";
            verdeToolStripMenuItem.Click += verdeToolStripMenuItem_Click;
            // 
            // azulToolStripMenuItem
            // 
            azulToolStripMenuItem.Name = "azulToolStripMenuItem";
            azulToolStripMenuItem.Size = new Size(180, 22);
            azulToolStripMenuItem.Text = "Azul";
            azulToolStripMenuItem.Click += azulToolStripMenuItem_Click;
            // 
            // efectosToolStripMenuItem
            // 
            efectosToolStripMenuItem.Name = "efectosToolStripMenuItem";
            efectosToolStripMenuItem.Size = new Size(57, 20);
            efectosToolStripMenuItem.Text = "Efectos";
            // 
            // ofdAbrir
            // 
            ofdAbrir.FileName = "openFileDialog1";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(362, 348);
            Controls.Add(pctLienzo);
            Controls.Add(menuStrip1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pctLienzo).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pctLienzo;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem aToolStripMenuItem;
        private ToolStripMenuItem abrirToolStripMenuItem;
        private ToolStripMenuItem guardarToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem basicosToolStripMenuItem;
        private ToolStripMenuItem imagenOriginalToolStripMenuItem;
        private ToolStripMenuItem filtrosDeColorToolStripMenuItem;
        private ToolStripMenuItem rojoToolStripMenuItem;
        private ToolStripMenuItem verdeToolStripMenuItem;
        private ToolStripMenuItem azulToolStripMenuItem;
        private ToolStripMenuItem efectosToolStripMenuItem;
        private OpenFileDialog ofdAbrir;
    }
}