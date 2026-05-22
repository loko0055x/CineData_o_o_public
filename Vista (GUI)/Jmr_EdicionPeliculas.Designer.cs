namespace Vista__GUI_
{
    partial class Jmr_EdicionPeliculas
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
            this.tblpeliculas = new System.Windows.Forms.DataGridView();
            this.pix = new System.Windows.Forms.PictureBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtnombrepeli = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnabririmagen = new System.Windows.Forms.Button();
            this.btnactualizar = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.txtruta = new System.Windows.Forms.TextBox();
            this.btntrailer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tblpeliculas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pix)).BeginInit();
            this.SuspendLayout();
            // 
            // tblpeliculas
            // 
            this.tblpeliculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblpeliculas.Location = new System.Drawing.Point(384, 247);
            this.tblpeliculas.Name = "tblpeliculas";
            this.tblpeliculas.Size = new System.Drawing.Size(266, 161);
            this.tblpeliculas.TabIndex = 22;
            this.tblpeliculas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblpeliculas_CellClick);
            // 
            // pix
            // 
            this.pix.Location = new System.Drawing.Point(36, 225);
            this.pix.Name = "pix";
            this.pix.Size = new System.Drawing.Size(245, 172);
            this.pix.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pix.TabIndex = 23;
            this.pix.TabStop = false;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(462, 60);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 20);
            this.txtid.TabIndex = 24;
            // 
            // txtnombrepeli
            // 
            this.txtnombrepeli.Location = new System.Drawing.Point(462, 143);
            this.txtnombrepeli.Name = "txtnombrepeli";
            this.txtnombrepeli.Size = new System.Drawing.Size(100, 20);
            this.txtnombrepeli.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(236, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "ID Pelicula";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(236, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Nombre pelicula";
            // 
            // btnabririmagen
            // 
            this.btnabririmagen.Location = new System.Drawing.Point(271, 456);
            this.btnabririmagen.Name = "btnabririmagen";
            this.btnabririmagen.Size = new System.Drawing.Size(92, 31);
            this.btnabririmagen.TabIndex = 28;
            this.btnabririmagen.Text = "Abrir imagen";
            this.btnabririmagen.UseVisualStyleBackColor = true;
            this.btnabririmagen.Click += new System.EventHandler(this.btnabririmagen_Click);
            // 
            // btnactualizar
            // 
            this.btnactualizar.Location = new System.Drawing.Point(698, 446);
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.Size = new System.Drawing.Size(121, 50);
            this.btnactualizar.TabIndex = 29;
            this.btnactualizar.Text = "Actualizar Pelicula";
            this.btnactualizar.UseVisualStyleBackColor = true;
            this.btnactualizar.Click += new System.EventHandler(this.btnactualizar_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(236, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Link pelicula";
            // 
            // txtruta
            // 
            this.txtruta.Location = new System.Drawing.Point(462, 194);
            this.txtruta.Name = "txtruta";
            this.txtruta.Size = new System.Drawing.Size(188, 20);
            this.txtruta.TabIndex = 30;
            // 
            // btntrailer
            // 
            this.btntrailer.Location = new System.Drawing.Point(698, 181);
            this.btntrailer.Name = "btntrailer";
            this.btntrailer.Size = new System.Drawing.Size(132, 39);
            this.btntrailer.TabIndex = 32;
            this.btntrailer.Text = "Abrir Carpeta trailer";
            this.btntrailer.UseVisualStyleBackColor = true;
            this.btntrailer.Click += new System.EventHandler(this.btntrailer_Click);
            // 
            // Jmr_EdicionPeliculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 508);
            this.Controls.Add(this.btntrailer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtruta);
            this.Controls.Add(this.btnactualizar);
            this.Controls.Add(this.btnabririmagen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtnombrepeli);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.pix);
            this.Controls.Add(this.tblpeliculas);
            this.Name = "Jmr_EdicionPeliculas";
            this.Text = "Jmr_EdicionPeliculas";
            this.Load += new System.EventHandler(this.Jmr_EdicionPeliculas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblpeliculas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pix)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tblpeliculas;
        private System.Windows.Forms.PictureBox pix;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtnombrepeli;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnabririmagen;
        private System.Windows.Forms.Button btnactualizar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtruta;
        private System.Windows.Forms.Button btntrailer;
    }
}