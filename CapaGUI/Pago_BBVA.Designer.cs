namespace CapaGUI
{
    partial class Pago_BBVA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pago_BBVA));
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.cmdtipodoc = new System.Windows.Forms.ComboBox();
            this.cmdanio = new System.Windows.Forms.ComboBox();
            this.cmdmes = new System.Windows.Forms.ComboBox();
            this.txtnumdoc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txttarjeta = new System.Windows.Forms.TextBox();
            this.cmdtipopago = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnpagar = new CapaGUI.RJButton();
            this.label6 = new System.Windows.Forms.Label();
            this.lvlnombre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(163, 42);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 16);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 86;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(99, 42);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 16);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 85;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(36, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 16);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 84;
            this.pictureBox1.TabStop = false;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(314, 91);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(106, 20);
            this.textBox3.TabIndex = 80;
            // 
            // cmdtipodoc
            // 
            this.cmdtipodoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdtipodoc.FormattingEnabled = true;
            this.cmdtipodoc.Items.AddRange(new object[] {
            "Dni",
            "Carnet de extrangeria",
            "Pasaporte",
            "Ruc"});
            this.cmdtipodoc.Location = new System.Drawing.Point(8, 120);
            this.cmdtipodoc.Name = "cmdtipodoc";
            this.cmdtipodoc.Size = new System.Drawing.Size(211, 21);
            this.cmdtipodoc.TabIndex = 79;
            this.cmdtipodoc.Text = "Tipo Documento";
            // 
            // cmdanio
            // 
            this.cmdanio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdanio.FormattingEnabled = true;
            this.cmdanio.Location = new System.Drawing.Point(137, 91);
            this.cmdanio.Name = "cmdanio";
            this.cmdanio.Size = new System.Drawing.Size(121, 21);
            this.cmdanio.TabIndex = 78;
            this.cmdanio.Text = "Año";
            // 
            // cmdmes
            // 
            this.cmdmes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdmes.FormattingEnabled = true;
            this.cmdmes.Location = new System.Drawing.Point(8, 93);
            this.cmdmes.Name = "cmdmes";
            this.cmdmes.Size = new System.Drawing.Size(121, 21);
            this.cmdmes.TabIndex = 77;
            this.cmdmes.Text = "Mes";
            this.cmdmes.SelectedIndexChanged += new System.EventHandler(this.cmdmes_SelectedIndexChanged);
            // 
            // txtnumdoc
            // 
            this.txtnumdoc.Location = new System.Drawing.Point(228, 121);
            this.txtnumdoc.Name = "txtnumdoc";
            this.txtnumdoc.Size = new System.Drawing.Size(192, 20);
            this.txtnumdoc.TabIndex = 76;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(268, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 75;
            this.label2.Text = "CVV";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 13);
            this.label1.TabIndex = 74;
            this.label1.Text = "NUMERO DE TARJETA";
            // 
            // txttarjeta
            // 
            this.txttarjeta.Location = new System.Drawing.Point(152, 65);
            this.txttarjeta.Name = "txttarjeta";
            this.txttarjeta.Size = new System.Drawing.Size(141, 20);
            this.txttarjeta.TabIndex = 73;
            // 
            // cmdtipopago
            // 
            this.cmdtipopago.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdtipopago.FormattingEnabled = true;
            this.cmdtipopago.Items.AddRange(new object[] {
            "Devito",
            "Credito"});
            this.cmdtipopago.Location = new System.Drawing.Point(299, 64);
            this.cmdtipopago.Name = "cmdtipopago";
            this.cmdtipopago.Size = new System.Drawing.Size(121, 21);
            this.cmdtipopago.TabIndex = 72;
            this.cmdtipopago.Text = "--Tipo de Tarjeta--";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(30, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(350, 30);
            this.label4.TabIndex = 71;
            this.label4.Text = "Tarjeta de Crédito o Débito";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnpagar
            // 
            this.btnpagar.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnpagar.Backgroundcolor = System.Drawing.Color.MidnightBlue;
            this.btnpagar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnpagar.BorderRadius = 20;
            this.btnpagar.BorderSize = 0;
            this.btnpagar.FlatAppearance.BorderSize = 0;
            this.btnpagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpagar.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpagar.ForeColor = System.Drawing.Color.White;
            this.btnpagar.Location = new System.Drawing.Point(152, 214);
            this.btnpagar.Name = "btnpagar";
            this.btnpagar.Size = new System.Drawing.Size(150, 40);
            this.btnpagar.TabIndex = 87;
            this.btnpagar.Text = "Realizar Pago";
            this.btnpagar.Textdcolor = System.Drawing.Color.White;
            this.btnpagar.UseVisualStyleBackColor = false;
            this.btnpagar.Click += new System.EventHandler(this.btnpagar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 18);
            this.label6.TabIndex = 88;
            this.label6.Text = "* No se hacen cambios ni devoluciones\r\n* Toda la información de pago es segura";
            // 
            // lvlnombre
            // 
            this.lvlnombre.Location = new System.Drawing.Point(276, 144);
            this.lvlnombre.Name = "lvlnombre";
            this.lvlnombre.Size = new System.Drawing.Size(135, 42);
            this.lvlnombre.TabIndex = 89;
            // 
            // Pago_BBVA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 271);
            this.Controls.Add(this.lvlnombre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnpagar);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.cmdtipodoc);
            this.Controls.Add(this.cmdanio);
            this.Controls.Add(this.cmdmes);
            this.Controls.Add(this.txtnumdoc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txttarjeta);
            this.Controls.Add(this.cmdtipopago);
            this.Controls.Add(this.label4);
            this.Name = "Pago_BBVA";
            this.Text = "Pago_BBVA";
            this.Load += new System.EventHandler(this.Pago_BBVA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox cmdtipodoc;
        private System.Windows.Forms.ComboBox cmdanio;
        private System.Windows.Forms.ComboBox cmdmes;
        private System.Windows.Forms.TextBox txtnumdoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttarjeta;
        private System.Windows.Forms.ComboBox cmdtipopago;
        private System.Windows.Forms.Label label4;
        private RJButton btnpagar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lvlnombre;
    }
}