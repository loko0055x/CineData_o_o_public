namespace Vista__GUI_
{
    partial class JrmMetodoPago
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnombres = new System.Windows.Forms.TextBox();
            this.txtcorreo = new System.Windows.Forms.TextBox();
            this.rbtpago1 = new System.Windows.Forms.RadioButton();
            this.rbtpago2 = new System.Windows.Forms.RadioButton();
            this.rbtpago3 = new System.Windows.Forms.RadioButton();
            this.contenedor = new System.Windows.Forms.Panel();
            this.btnimprimir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(275, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Elije un Metodo de Pago";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre Completo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Correo";
            // 
            // txtnombres
            // 
            this.txtnombres.Location = new System.Drawing.Point(215, 48);
            this.txtnombres.Name = "txtnombres";
            this.txtnombres.Size = new System.Drawing.Size(100, 20);
            this.txtnombres.TabIndex = 3;
            // 
            // txtcorreo
            // 
            this.txtcorreo.Location = new System.Drawing.Point(215, 93);
            this.txtcorreo.Name = "txtcorreo";
            this.txtcorreo.Size = new System.Drawing.Size(100, 20);
            this.txtcorreo.TabIndex = 8;
            // 
            // rbtpago1
            // 
            this.rbtpago1.AutoSize = true;
            this.rbtpago1.Location = new System.Drawing.Point(48, 189);
            this.rbtpago1.Name = "rbtpago1";
            this.rbtpago1.Size = new System.Drawing.Size(152, 17);
            this.rbtpago1.TabIndex = 5;
            this.rbtpago1.TabStop = true;
            this.rbtpago1.Text = "Tarjeta de Credito o Debito";
            this.rbtpago1.UseVisualStyleBackColor = true;
            this.rbtpago1.CheckedChanged += new System.EventHandler(this.rbtpago1_CheckedChanged);
            // 
            // rbtpago2
            // 
            this.rbtpago2.AutoSize = true;
            this.rbtpago2.Location = new System.Drawing.Point(48, 244);
            this.rbtpago2.Name = "rbtpago2";
            this.rbtpago2.Size = new System.Drawing.Size(57, 17);
            this.rbtpago2.TabIndex = 6;
            this.rbtpago2.TabStop = true;
            this.rbtpago2.Text = "Paypal";
            this.rbtpago2.UseVisualStyleBackColor = true;
            this.rbtpago2.CheckedChanged += new System.EventHandler(this.rbtpago2_CheckedChanged);
            // 
            // rbtpago3
            // 
            this.rbtpago3.AutoSize = true;
            this.rbtpago3.Location = new System.Drawing.Point(48, 305);
            this.rbtpago3.Name = "rbtpago3";
            this.rbtpago3.Size = new System.Drawing.Size(128, 17);
            this.rbtpago3.TabIndex = 7;
            this.rbtpago3.TabStop = true;
            this.rbtpago3.Text = "Billeteras Electronicas";
            this.rbtpago3.UseVisualStyleBackColor = true;
            this.rbtpago3.CheckedChanged += new System.EventHandler(this.rbtpago3_CheckedChanged);
            // 
            // contenedor
            // 
            this.contenedor.Location = new System.Drawing.Point(242, 134);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(680, 421);
            this.contenedor.TabIndex = 9;
            // 
            // btnimprimir
            // 
            this.btnimprimir.Location = new System.Drawing.Point(672, 36);
            this.btnimprimir.Name = "btnimprimir";
            this.btnimprimir.Size = new System.Drawing.Size(141, 42);
            this.btnimprimir.TabIndex = 10;
            this.btnimprimir.Text = "Imprimir x consola";
            this.btnimprimir.UseVisualStyleBackColor = true;
            this.btnimprimir.Click += new System.EventHandler(this.btnimprimir_Click);
            // 
            // JrmMetodoPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 567);
            this.Controls.Add(this.btnimprimir);
            this.Controls.Add(this.contenedor);
            this.Controls.Add(this.rbtpago3);
            this.Controls.Add(this.rbtpago2);
            this.Controls.Add(this.rbtpago1);
            this.Controls.Add(this.txtcorreo);
            this.Controls.Add(this.txtnombres);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "JrmMetodoPago";
            this.Text = "JrmMetodoPago";
            this.Load += new System.EventHandler(this.JrmMetodoPago_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtnombres;
        private System.Windows.Forms.TextBox txtcorreo;
        private System.Windows.Forms.RadioButton rbtpago1;
        private System.Windows.Forms.RadioButton rbtpago2;
        private System.Windows.Forms.RadioButton rbtpago3;
        private System.Windows.Forms.Panel contenedor;
        private System.Windows.Forms.Button btnimprimir;
    }
}