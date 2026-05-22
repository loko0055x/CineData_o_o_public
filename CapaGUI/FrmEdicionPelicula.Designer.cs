namespace CapaGUI
{
    partial class FrmEdicionPelicula
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEdicionPelicula));
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btntrailer = new System.Windows.Forms.Button();
            this.txtruta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnactualizar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnombrepeli = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.tblpeliculas = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnabririmagen = new System.Windows.Forms.Button();
            this.pix = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pixsalir = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblpeliculas)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pixsalir)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(239, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(338, 42);
            this.label2.TabIndex = 36;
            this.label2.Text = "Edicion Peliculas";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btntrailer);
            this.panel1.Controls.Add(this.txtruta);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnactualizar);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtnombrepeli);
            this.panel1.Controls.Add(this.txtid);
            this.panel1.Controls.Add(this.tblpeliculas);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(789, 400);
            this.panel1.TabIndex = 37;
            // 
            // btntrailer
            // 
            this.btntrailer.Location = new System.Drawing.Point(392, 124);
            this.btntrailer.Name = "btntrailer";
            this.btntrailer.Size = new System.Drawing.Size(20, 22);
            this.btntrailer.TabIndex = 40;
            this.btntrailer.Text = "O";
            this.btntrailer.UseVisualStyleBackColor = true;
            this.btntrailer.Click += new System.EventHandler(this.btntrailer_Click);
            // 
            // txtruta
            // 
            this.txtruta.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtruta.Location = new System.Drawing.Point(219, 119);
            this.txtruta.Name = "txtruta";
            this.txtruta.Size = new System.Drawing.Size(197, 31);
            this.txtruta.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(105, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 23);
            this.label4.TabIndex = 39;
            this.label4.Text = "Link pelicula";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 23);
            this.label1.TabIndex = 31;
            this.label1.Text = "Nombre pelicula";
            // 
            // btnactualizar
            // 
            this.btnactualizar.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnactualizar.Location = new System.Drawing.Point(61, 184);
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.Size = new System.Drawing.Size(326, 31);
            this.btnactualizar.TabIndex = 33;
            this.btnactualizar.Text = "Actualizar Pelicula";
            this.btnactualizar.UseVisualStyleBackColor = true;
            this.btnactualizar.Click += new System.EventHandler(this.btnactualizar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(120, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 23);
            this.label3.TabIndex = 30;
            this.label3.Text = "ID Pelicula";
            // 
            // txtnombrepeli
            // 
            this.txtnombrepeli.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombrepeli.Location = new System.Drawing.Point(219, 66);
            this.txtnombrepeli.Name = "txtnombrepeli";
            this.txtnombrepeli.Size = new System.Drawing.Size(197, 31);
            this.txtnombrepeli.TabIndex = 29;
            // 
            // txtid
            // 
            this.txtid.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.Location = new System.Drawing.Point(219, 18);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(197, 31);
            this.txtid.TabIndex = 28;
            // 
            // tblpeliculas
            // 
            this.tblpeliculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblpeliculas.Location = new System.Drawing.Point(61, 221);
            this.tblpeliculas.Name = "tblpeliculas";
            this.tblpeliculas.Size = new System.Drawing.Size(326, 161);
            this.tblpeliculas.TabIndex = 25;
            this.tblpeliculas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblpeliculas_CellClick);
            this.tblpeliculas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblpeliculas_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnabririmagen);
            this.panel2.Controls.Add(this.pix);
            this.panel2.Location = new System.Drawing.Point(451, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(338, 400);
            this.panel2.TabIndex = 34;
            // 
            // btnabririmagen
            // 
            this.btnabririmagen.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnabririmagen.Location = new System.Drawing.Point(53, 20);
            this.btnabririmagen.Name = "btnabririmagen";
            this.btnabririmagen.Size = new System.Drawing.Size(256, 31);
            this.btnabririmagen.TabIndex = 32;
            this.btnabririmagen.Text = "Abrir imagen";
            this.btnabririmagen.UseVisualStyleBackColor = true;
            this.btnabririmagen.Click += new System.EventHandler(this.btnabririmagen_Click);
            // 
            // pix
            // 
            this.pix.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pix.Location = new System.Drawing.Point(53, 73);
            this.pix.Name = "pix";
            this.pix.Size = new System.Drawing.Size(256, 208);
            this.pix.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pix.TabIndex = 24;
            this.pix.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pixsalir
            // 
            this.pixsalir.Image = ((System.Drawing.Image)(resources.GetObject("pixsalir.Image")));
            this.pixsalir.Location = new System.Drawing.Point(12, 9);
            this.pixsalir.Name = "pixsalir";
            this.pixsalir.Size = new System.Drawing.Size(27, 21);
            this.pixsalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pixsalir.TabIndex = 71;
            this.pixsalir.TabStop = false;
            this.pixsalir.Click += new System.EventHandler(this.pixsalir_Click);
            // 
            // FrmEdicionPelicula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 468);
            this.Controls.Add(this.pixsalir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmEdicionPelicula";
            this.Text = "FrmEdicionPelicula";
            this.Load += new System.EventHandler(this.FrmEdicionPelicula_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblpeliculas)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pixsalir)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pixsalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnactualizar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtnombrepeli;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.DataGridView tblpeliculas;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnabririmagen;
        private System.Windows.Forms.PictureBox pix;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btntrailer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtruta;
    }
}