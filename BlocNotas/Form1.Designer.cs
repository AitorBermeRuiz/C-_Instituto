
namespace BlocNotas
{
    partial class Form1
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
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarComoTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.textoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fuenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TextBox = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.guardarTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.textoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoTSM,
            this.abrirTSM,
            this.guardarTSM,
            this.guardarComoTSM,
            this.imprimirTSM});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // nuevoTSM
            // 
            this.nuevoTSM.Name = "nuevoTSM";
            this.nuevoTSM.Size = new System.Drawing.Size(180, 22);
            this.nuevoTSM.Text = "Nuevo";
            this.nuevoTSM.Click += new System.EventHandler(this.nuevoTSM_Click);
            // 
            // abrirTSM
            // 
            this.abrirTSM.Name = "abrirTSM";
            this.abrirTSM.Size = new System.Drawing.Size(180, 22);
            this.abrirTSM.Text = "Abrir";
            this.abrirTSM.Click += new System.EventHandler(this.abrirTSM_Click);
            // 
            // guardarComoTSM
            // 
            this.guardarComoTSM.Name = "guardarComoTSM";
            this.guardarComoTSM.Size = new System.Drawing.Size(180, 22);
            this.guardarComoTSM.Text = "Guardar como";
            this.guardarComoTSM.Click += new System.EventHandler(this.guardarComoTSM_Click);
            // 
            // imprimirTSM
            // 
            this.imprimirTSM.Name = "imprimirTSM";
            this.imprimirTSM.Size = new System.Drawing.Size(180, 22);
            this.imprimirTSM.Text = "Imprimir";
            // 
            // textoToolStripMenuItem
            // 
            this.textoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fuenteToolStripMenuItem});
            this.textoToolStripMenuItem.Name = "textoToolStripMenuItem";
            this.textoToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.textoToolStripMenuItem.Text = "Formato";
            // 
            // fuenteToolStripMenuItem
            // 
            this.fuenteToolStripMenuItem.Name = "fuenteToolStripMenuItem";
            this.fuenteToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.fuenteToolStripMenuItem.Text = "Fuente";
            // 
            // TextBox
            // 
            this.TextBox.Location = new System.Drawing.Point(0, 27);
            this.TextBox.Multiline = true;
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(800, 424);
            this.TextBox.TabIndex = 1;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.InitialDirectory = "C:\\Users\\aitor\\Documents\\Visual Studio 2019\\Ejemplos";
            this.saveFileDialog1.Title = "Guardar como";
            // 
            // guardarTSM
            // 
            this.guardarTSM.Name = "guardarTSM";
            this.guardarTSM.Size = new System.Drawing.Size(180, 22);
            this.guardarTSM.Text = "Guardar";
            this.guardarTSM.Click += new System.EventHandler(this.guardarTSM_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "*Sin titulo: Bloc de notas";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoTSM;
        private System.Windows.Forms.ToolStripMenuItem abrirTSM;
        private System.Windows.Forms.ToolStripMenuItem guardarComoTSM;
        private System.Windows.Forms.ToolStripMenuItem imprimirTSM;
        private System.Windows.Forms.ToolStripMenuItem textoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fuenteToolStripMenuItem;
        private System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem guardarTSM;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

