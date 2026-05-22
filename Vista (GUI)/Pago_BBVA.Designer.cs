namespace Vista__GUI_
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmdtipopago = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnumtarjeta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.cmdmes = new System.Windows.Forms.ComboBox();
            this.cmdanio = new System.Windows.Forms.ComboBox();
            this.cmdtipodoc = new System.Windows.Forms.ComboBox();
            this.txtnumdoc = new System.Windows.Forms.TextBox();
            this.btnpagar = new System.Windows.Forms.Button();
            this.lvlnombre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Vista__GUI_.Properties.Resources.BBVA;
            this.pictureBox1.Location = new System.Drawing.Point(109, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(341, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // cmdtipopago
            // 
            this.cmdtipopago.FormattingEnabled = true;
            this.cmdtipopago.Items.AddRange(new object[] {
            "Devito",
            "Credito"});
            this.cmdtipopago.Location = new System.Drawing.Point(205, 118);
            this.cmdtipopago.Name = "cmdtipopago";
            this.cmdtipopago.Size = new System.Drawing.Size(121, 21);
            this.cmdtipopago.TabIndex = 1;
            this.cmdtipopago.Text = "--Tipo de Pago--";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Numero Tarjeta";
            // 
            // txtnumtarjeta
            // 
            this.txtnumtarjeta.Location = new System.Drawing.Point(146, 170);
            this.txtnumtarjeta.Name = "txtnumtarjeta";
            this.txtnumtarjeta.Size = new System.Drawing.Size(100, 20);
            this.txtnumtarjeta.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(449, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "CVV";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(439, 170);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            // 
            // cmdmes
            // 
            this.cmdmes.FormattingEnabled = true;
            this.cmdmes.Location = new System.Drawing.Point(53, 234);
            this.cmdmes.Name = "cmdmes";
            this.cmdmes.Size = new System.Drawing.Size(121, 21);
            this.cmdmes.TabIndex = 6;
            this.cmdmes.Text = "Mes";
            // 
            // cmdanio
            // 
            this.cmdanio.FormattingEnabled = true;
            this.cmdanio.Location = new System.Drawing.Point(216, 234);
            this.cmdanio.Name = "cmdanio";
            this.cmdanio.Size = new System.Drawing.Size(121, 21);
            this.cmdanio.TabIndex = 7;
            this.cmdanio.Text = "Año";
            // 
            // cmdtipodoc
            // 
            this.cmdtipodoc.FormattingEnabled = true;
            this.cmdtipodoc.Items.AddRange(new object[] {
            "Dni",
            "Carnet de extrangeria",
            "Pasaporte",
            "Ruc"});
            this.cmdtipodoc.Location = new System.Drawing.Point(400, 243);
            this.cmdtipodoc.Name = "cmdtipodoc";
            this.cmdtipodoc.Size = new System.Drawing.Size(121, 21);
            this.cmdtipodoc.TabIndex = 8;
            this.cmdtipodoc.Text = "Tipo Documento";
            // 
            // txtnumdoc
            // 
            this.txtnumdoc.Location = new System.Drawing.Point(205, 302);
            this.txtnumdoc.Name = "txtnumdoc";
            this.txtnumdoc.Size = new System.Drawing.Size(106, 20);
            this.txtnumdoc.TabIndex = 9;
            // 
            // btnpagar
            // 
            this.btnpagar.Location = new System.Drawing.Point(186, 346);
            this.btnpagar.Name = "btnpagar";
            this.btnpagar.Size = new System.Drawing.Size(264, 63);
            this.btnpagar.TabIndex = 10;
            this.btnpagar.Text = "Realizar Pago";
            this.btnpagar.UseVisualStyleBackColor = true;
            this.btnpagar.Click += new System.EventHandler(this.btnpagar_Click);
            // 
            // lvlnombre
            // 
            this.lvlnombre.Location = new System.Drawing.Point(514, 79);
            this.lvlnombre.Name = "lvlnombre";
            this.lvlnombre.Size = new System.Drawing.Size(135, 42);
            this.lvlnombre.TabIndex = 11;
            // 
            // Pago_BBVA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 421);
            this.Controls.Add(this.lvlnombre);
            this.Controls.Add(this.btnpagar);
            this.Controls.Add(this.txtnumdoc);
            this.Controls.Add(this.cmdtipodoc);
            this.Controls.Add(this.cmdanio);
            this.Controls.Add(this.cmdmes);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtnumtarjeta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdtipopago);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pago_BBVA";
            this.Text = "Pago_BBVA";
            this.Load += new System.EventHandler(this.Pago_BBVA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cmdtipopago;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnumtarjeta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox cmdmes;
        private System.Windows.Forms.ComboBox cmdanio;
        private System.Windows.Forms.ComboBox cmdtipodoc;
        private System.Windows.Forms.TextBox txtnumdoc;
        private System.Windows.Forms.Button btnpagar;
        private System.Windows.Forms.Label lvlnombre;
    }
}