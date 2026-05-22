namespace Vista__GUI_
{
    partial class Jrm_IniciarSecion
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
            this.txtdni = new System.Windows.Forms.TextBox();
            this.txtcontra = new System.Windows.Forms.TextBox();
            this.btniniciarsecion = new System.Windows.Forms.Button();
            this.btnprincipal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(194, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dni";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtdni
            // 
            this.txtdni.Location = new System.Drawing.Point(297, 71);
            this.txtdni.Name = "txtdni";
            this.txtdni.Size = new System.Drawing.Size(100, 20);
            this.txtdni.TabIndex = 2;
            // 
            // txtcontra
            // 
            this.txtcontra.Location = new System.Drawing.Point(297, 151);
            this.txtcontra.Name = "txtcontra";
            this.txtcontra.Size = new System.Drawing.Size(100, 20);
            this.txtcontra.TabIndex = 3;
            this.txtcontra.UseSystemPasswordChar = true;
            // 
            // btniniciarsecion
            // 
            this.btniniciarsecion.Location = new System.Drawing.Point(596, 185);
            this.btniniciarsecion.Name = "btniniciarsecion";
            this.btniniciarsecion.Size = new System.Drawing.Size(101, 29);
            this.btniniciarsecion.TabIndex = 4;
            this.btniniciarsecion.Text = "iniciar secion";
            this.btniniciarsecion.UseVisualStyleBackColor = true;
            this.btniniciarsecion.Click += new System.EventHandler(this.btniniciarsecion_Click);
            // 
            // btnprincipal
            // 
            this.btnprincipal.Location = new System.Drawing.Point(45, 272);
            this.btnprincipal.Name = "btnprincipal";
            this.btnprincipal.Size = new System.Drawing.Size(101, 46);
            this.btnprincipal.TabIndex = 5;
            this.btnprincipal.Text = "Regresar menu principal";
            this.btnprincipal.UseVisualStyleBackColor = true;
            this.btnprincipal.Click += new System.EventHandler(this.btnprincipal_Click);
            // 
            // Jrm_IniciarSecion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnprincipal);
            this.Controls.Add(this.btniniciarsecion);
            this.Controls.Add(this.txtcontra);
            this.Controls.Add(this.txtdni);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Jrm_IniciarSecion";
            this.Text = "Jrm_IniciarSecion";
            this.Load += new System.EventHandler(this.Jrm_IniciarSecion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtdni;
        private System.Windows.Forms.TextBox txtcontra;
        private System.Windows.Forms.Button btniniciarsecion;
        private System.Windows.Forms.Button btnprincipal;
    }
}