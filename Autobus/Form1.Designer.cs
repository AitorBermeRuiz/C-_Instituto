
namespace Autobus
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
            this.BRegistro = new System.Windows.Forms.Button();
            this.BComprar = new System.Windows.Forms.Button();
            this.BComprobacion = new System.Windows.Forms.Button();
            this.BSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BRegistro
            // 
            this.BRegistro.Location = new System.Drawing.Point(35, 54);
            this.BRegistro.Name = "BRegistro";
            this.BRegistro.Size = new System.Drawing.Size(133, 46);
            this.BRegistro.TabIndex = 0;
            this.BRegistro.Text = "Registrar Usuario";
            this.BRegistro.UseVisualStyleBackColor = true;
            this.BRegistro.Click += new System.EventHandler(this.BRegistro_Click);
            // 
            // BComprar
            // 
            this.BComprar.Location = new System.Drawing.Point(35, 129);
            this.BComprar.Name = "BComprar";
            this.BComprar.Size = new System.Drawing.Size(133, 46);
            this.BComprar.TabIndex = 1;
            this.BComprar.Text = "Comprar Billete";
            this.BComprar.UseVisualStyleBackColor = true;
            this.BComprar.Click += new System.EventHandler(this.BComprar_Click);
            // 
            // BComprobacion
            // 
            this.BComprobacion.Location = new System.Drawing.Point(35, 200);
            this.BComprobacion.Name = "BComprobacion";
            this.BComprobacion.Size = new System.Drawing.Size(133, 44);
            this.BComprobacion.TabIndex = 2;
            this.BComprobacion.Text = "Comprobacion";
            this.BComprobacion.UseVisualStyleBackColor = true;
            this.BComprobacion.Click += new System.EventHandler(this.BComprobacion_Click);
            // 
            // BSalir
            // 
            this.BSalir.Location = new System.Drawing.Point(35, 272);
            this.BSalir.Name = "BSalir";
            this.BSalir.Size = new System.Drawing.Size(133, 40);
            this.BSalir.TabIndex = 3;
            this.BSalir.Text = "Salir";
            this.BSalir.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 346);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(145, 354);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 383);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BSalir);
            this.Controls.Add(this.BComprobacion);
            this.Controls.Add(this.BComprar);
            this.Controls.Add(this.BRegistro);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BRegistro;
        private System.Windows.Forms.Button BComprar;
        private System.Windows.Forms.Button BComprobacion;
        private System.Windows.Forms.Button BSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

