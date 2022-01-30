
namespace GestionInstituto
{
    partial class fGestionAlumnos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.matriculaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaAlumnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bajaAlumnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoAlumnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ºDAMAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ºDAMBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ºDAMAToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ºDAMBToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tODOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lMostrarAlumnos = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.matriculaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // matriculaToolStripMenuItem
            // 
            this.matriculaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaAlumnoToolStripMenuItem,
            this.bajaAlumnoToolStripMenuItem,
            this.listadoAlumnosToolStripMenuItem});
            this.matriculaToolStripMenuItem.Name = "matriculaToolStripMenuItem";
            this.matriculaToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.matriculaToolStripMenuItem.Text = "Matricula";
            // 
            // altaAlumnoToolStripMenuItem
            // 
            this.altaAlumnoToolStripMenuItem.Name = "altaAlumnoToolStripMenuItem";
            this.altaAlumnoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.altaAlumnoToolStripMenuItem.Text = "Alta alumno";
            this.altaAlumnoToolStripMenuItem.Click += new System.EventHandler(this.altaAlumnoToolStripMenuItem_Click);
            // 
            // bajaAlumnoToolStripMenuItem
            // 
            this.bajaAlumnoToolStripMenuItem.Name = "bajaAlumnoToolStripMenuItem";
            this.bajaAlumnoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bajaAlumnoToolStripMenuItem.Text = "Baja alumno";
            this.bajaAlumnoToolStripMenuItem.Click += new System.EventHandler(this.bajaAlumnoToolStripMenuItem_Click);
            // 
            // listadoAlumnosToolStripMenuItem
            // 
            this.listadoAlumnosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ºDAMAToolStripMenuItem,
            this.ºDAMBToolStripMenuItem,
            this.ºDAMAToolStripMenuItem1,
            this.ºDAMBToolStripMenuItem1,
            this.tODOSToolStripMenuItem});
            this.listadoAlumnosToolStripMenuItem.Name = "listadoAlumnosToolStripMenuItem";
            this.listadoAlumnosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listadoAlumnosToolStripMenuItem.Text = "Listado alumnos";
            // 
            // ºDAMAToolStripMenuItem
            // 
            this.ºDAMAToolStripMenuItem.Name = "ºDAMAToolStripMenuItem";
            this.ºDAMAToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ºDAMAToolStripMenuItem.Text = "1º DAM A";
            this.ºDAMAToolStripMenuItem.Click += new System.EventHandler(this.ºDAMAToolStripMenuItem_Click);
            // 
            // ºDAMBToolStripMenuItem
            // 
            this.ºDAMBToolStripMenuItem.Name = "ºDAMBToolStripMenuItem";
            this.ºDAMBToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ºDAMBToolStripMenuItem.Text = "1º DAM B";
            this.ºDAMBToolStripMenuItem.Click += new System.EventHandler(this.ºDAMBToolStripMenuItem_Click);
            // 
            // ºDAMAToolStripMenuItem1
            // 
            this.ºDAMAToolStripMenuItem1.Name = "ºDAMAToolStripMenuItem1";
            this.ºDAMAToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.ºDAMAToolStripMenuItem1.Text = "2º DAM A";
            this.ºDAMAToolStripMenuItem1.Click += new System.EventHandler(this.ºDAMAToolStripMenuItem1_Click);
            // 
            // ºDAMBToolStripMenuItem1
            // 
            this.ºDAMBToolStripMenuItem1.Name = "ºDAMBToolStripMenuItem1";
            this.ºDAMBToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.ºDAMBToolStripMenuItem1.Text = "2º DAM B";
            this.ºDAMBToolStripMenuItem1.Click += new System.EventHandler(this.ºDAMBToolStripMenuItem1_Click);
            // 
            // tODOSToolStripMenuItem
            // 
            this.tODOSToolStripMenuItem.Name = "tODOSToolStripMenuItem";
            this.tODOSToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tODOSToolStripMenuItem.Text = "TODOS";
            this.tODOSToolStripMenuItem.Click += new System.EventHandler(this.tODOSToolStripMenuItem_Click);
            // 
            // lMostrarAlumnos
            // 
            this.lMostrarAlumnos.Location = new System.Drawing.Point(336, 24);
            this.lMostrarAlumnos.Name = "lMostrarAlumnos";
            this.lMostrarAlumnos.Size = new System.Drawing.Size(452, 417);
            this.lMostrarAlumnos.TabIndex = 1;
            this.lMostrarAlumnos.Text = "Mostrar alumnos";
            this.lMostrarAlumnos.Visible = false;
            // 
            // fGestionAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lMostrarAlumnos);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fGestionAlumnos";
            this.Text = "Gestión alumnos";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem matriculaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaAlumnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bajaAlumnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoAlumnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ºDAMAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ºDAMBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ºDAMAToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ºDAMBToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tODOSToolStripMenuItem;
        private System.Windows.Forms.Label lMostrarAlumnos;
    }
}

