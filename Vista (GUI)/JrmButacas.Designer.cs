namespace Vista__GUI_
{
    partial class JrmButacas
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
            this.label1 = new System.Windows.Forms.Label();
            this.panelcontenedor = new System.Windows.Forms.Panel();
            this.btnsiguiente = new System.Windows.Forms.Button();
            this.btnactualizarsitodos = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lvlnombre = new System.Windows.Forms.Label();
            this.pix = new System.Windows.Forms.PictureBox();
            this.lvlcodigo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pix)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Butacas sala ";
            // 
            // panelcontenedor
            // 
            this.panelcontenedor.Location = new System.Drawing.Point(52, 76);
            this.panelcontenedor.Name = "panelcontenedor";
            this.panelcontenedor.Size = new System.Drawing.Size(503, 292);
            this.panelcontenedor.TabIndex = 1;
            // 
            // btnsiguiente
            // 
            this.btnsiguiente.Location = new System.Drawing.Point(640, 402);
            this.btnsiguiente.Name = "btnsiguiente";
            this.btnsiguiente.Size = new System.Drawing.Size(112, 36);
            this.btnsiguiente.TabIndex = 2;
            this.btnsiguiente.Text = "siguiente formulario";
            this.btnsiguiente.UseVisualStyleBackColor = true;
            this.btnsiguiente.Click += new System.EventHandler(this.btnsiguiente_Click);
            // 
            // btnactualizarsitodos
            // 
            this.btnactualizarsitodos.Location = new System.Drawing.Point(625, 91);
            this.btnactualizarsitodos.Name = "btnactualizarsitodos";
            this.btnactualizarsitodos.Size = new System.Drawing.Size(112, 36);
            this.btnactualizarsitodos.TabIndex = 3;
            this.btnactualizarsitodos.Text = "Actualizar si a todos";
            this.btnactualizarsitodos.UseVisualStyleBackColor = true;
            this.btnactualizarsitodos.Click += new System.EventHandler(this.btnactualizarsitodos_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(242, 418);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 16;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Red;
            this.textBox2.Location = new System.Drawing.Point(402, 418);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 15;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Green;
            this.textBox1.Location = new System.Drawing.Point(105, 418);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(239, 381);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Asiento ocupado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(399, 381);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "en proceso de reservacion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(102, 381);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Asiento disponible";
            // 
            // lvlnombre
            // 
            this.lvlnombre.Location = new System.Drawing.Point(447, 22);
            this.lvlnombre.Name = "lvlnombre";
            this.lvlnombre.Size = new System.Drawing.Size(100, 23);
            this.lvlnombre.TabIndex = 17;
            this.lvlnombre.Click += new System.EventHandler(this.lvlnombre_Click);
            // 
            // pix
            // 
            this.pix.Location = new System.Drawing.Point(590, 163);
            this.pix.Name = "pix";
            this.pix.Size = new System.Drawing.Size(198, 176);
            this.pix.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pix.TabIndex = 18;
            this.pix.TabStop = false;
            this.pix.Click += new System.EventHandler(this.pix_Click);
            // 
            // lvlcodigo
            // 
            this.lvlcodigo.Location = new System.Drawing.Point(637, 22);
            this.lvlcodigo.Name = "lvlcodigo";
            this.lvlcodigo.Size = new System.Drawing.Size(100, 23);
            this.lvlcodigo.TabIndex = 19;
            this.lvlcodigo.Click += new System.EventHandler(this.lvlcodigo_Click);
            // 
            // JrmButacas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 463);
            this.Controls.Add(this.lvlcodigo);
            this.Controls.Add(this.pix);
            this.Controls.Add(this.lvlnombre);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btnactualizarsitodos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnsiguiente);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panelcontenedor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Name = "JrmButacas";
            this.Text = "JrmButacas";
            this.Load += new System.EventHandler(this.JrmButacas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pix)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelcontenedor;
        private System.Windows.Forms.Button btnsiguiente;
        private System.Windows.Forms.Button btnactualizarsitodos;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lvlnombre;
        private System.Windows.Forms.PictureBox pix;
        private System.Windows.Forms.Label lvlcodigo;
    }
}