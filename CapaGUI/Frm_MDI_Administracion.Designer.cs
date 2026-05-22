namespace CapaGUI
{
    partial class Frm_MDI_Administracion
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
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.mantenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuempleados = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuadministradores = new System.Windows.Forms.ToolStripMenuItem();
            this.mnureporte = new System.Windows.Forms.ToolStripMenuItem();
            this.archivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuedicionpeliculas = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientoToolStripMenuItem,
            this.archivosToolStripMenuItem,
            this.ayudaToolStripMenuItem,
            this.reToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 24);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // mantenimientoToolStripMenuItem
            // 
            this.mantenimientoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuempleados,
            this.mnuadministradores,
            this.mnureporte});
            this.mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            this.mantenimientoToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.mantenimientoToolStripMenuItem.Text = "Mantenimiento";
            // 
            // mnuempleados
            // 
            this.mnuempleados.Name = "mnuempleados";
            this.mnuempleados.Size = new System.Drawing.Size(208, 22);
            this.mnuempleados.Text = "ABC_Empleados";
            this.mnuempleados.Click += new System.EventHandler(this.mnuempleados_Click);
            // 
            // mnuadministradores
            // 
            this.mnuadministradores.Name = "mnuadministradores";
            this.mnuadministradores.Size = new System.Drawing.Size(208, 22);
            this.mnuadministradores.Text = "ABC_Administradores";
            this.mnuadministradores.Click += new System.EventHandler(this.mnuadministradores_Click);
            // 
            // mnureporte
            // 
            this.mnureporte.Name = "mnureporte";
            this.mnureporte.Size = new System.Drawing.Size(208, 22);
            this.mnureporte.Text = "Reporte Clientes Premiun";
            this.mnureporte.Click += new System.EventHandler(this.mnureporte_Click);
            // 
            // archivosToolStripMenuItem
            // 
            this.archivosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuedicionpeliculas});
            this.archivosToolStripMenuItem.Name = "archivosToolStripMenuItem";
            this.archivosToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.archivosToolStripMenuItem.Text = "Archivos";
            // 
            // mnuedicionpeliculas
            // 
            this.mnuedicionpeliculas.Name = "mnuedicionpeliculas";
            this.mnuedicionpeliculas.Size = new System.Drawing.Size(180, 22);
            this.mnuedicionpeliculas.Text = "Edicion Peliculas";
            this.mnuedicionpeliculas.Click += new System.EventHandler(this.mnuedicionpeliculas_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // reToolStripMenuItem
            // 
            this.reToolStripMenuItem.Name = "reToolStripMenuItem";
            this.reToolStripMenuItem.Size = new System.Drawing.Size(12, 20);
            // 
            // Frm_MDI_Administracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip2);
            this.Name = "Frm_MDI_Administracion";
            this.Text = "Frm_MDI_Administracion";
            this.Load += new System.EventHandler(this.Frm_MDI_Administracion_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuempleados;
        private System.Windows.Forms.ToolStripMenuItem mnuadministradores;
        private System.Windows.Forms.ToolStripMenuItem mnureporte;
        private System.Windows.Forms.ToolStripMenuItem archivosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuedicionpeliculas;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reToolStripMenuItem;
    }
}