
namespace Examen1Trimestre
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
            this.lUsr = new System.Windows.Forms.Label();
            this.tbUsr = new System.Windows.Forms.TextBox();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.lPass = new System.Windows.Forms.Label();
            this.bAcceso = new System.Windows.Forms.Button();
            this.bSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lUsr
            // 
            this.lUsr.AutoSize = true;
            this.lUsr.Location = new System.Drawing.Point(12, 35);
            this.lUsr.Name = "lUsr";
            this.lUsr.Size = new System.Drawing.Size(26, 13);
            this.lUsr.TabIndex = 0;
            this.lUsr.Text = "Usr:";
            // 
            // tbUsr
            // 
            this.tbUsr.Location = new System.Drawing.Point(54, 32);
            this.tbUsr.MaxLength = 5;
            this.tbUsr.Name = "tbUsr";
            this.tbUsr.Size = new System.Drawing.Size(100, 20);
            this.tbUsr.TabIndex = 1;
            // 
            // tbPass
            // 
            this.tbPass.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbPass.Location = new System.Drawing.Point(54, 73);
            this.tbPass.MaxLength = 8;
            this.tbPass.Name = "tbPass";
            this.tbPass.PasswordChar = '*';
            this.tbPass.Size = new System.Drawing.Size(100, 20);
            this.tbPass.TabIndex = 3;
            // 
            // lPass
            // 
            this.lPass.AutoSize = true;
            this.lPass.Location = new System.Drawing.Point(12, 76);
            this.lPass.Name = "lPass";
            this.lPass.Size = new System.Drawing.Size(33, 13);
            this.lPass.TabIndex = 2;
            this.lPass.Text = "Pass:";
            // 
            // bAcceso
            // 
            this.bAcceso.Location = new System.Drawing.Point(12, 143);
            this.bAcceso.Name = "bAcceso";
            this.bAcceso.Size = new System.Drawing.Size(75, 23);
            this.bAcceso.TabIndex = 4;
            this.bAcceso.Text = "Acceso";
            this.bAcceso.UseVisualStyleBackColor = true;
            this.bAcceso.Click += new System.EventHandler(this.bAcceso_Click);
            // 
            // bSalir
            // 
            this.bSalir.Location = new System.Drawing.Point(133, 143);
            this.bSalir.Name = "bSalir";
            this.bSalir.Size = new System.Drawing.Size(75, 23);
            this.bSalir.TabIndex = 5;
            this.bSalir.Text = "Salir";
            this.bSalir.UseVisualStyleBackColor = true;
            this.bSalir.Click += new System.EventHandler(this.bSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 232);
            this.Controls.Add(this.bSalir);
            this.Controls.Add(this.bAcceso);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.lPass);
            this.Controls.Add(this.tbUsr);
            this.Controls.Add(this.lUsr);
            this.Name = "Form1";
            this.Text = "Acceso usuarios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lUsr;
        private System.Windows.Forms.TextBox tbUsr;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.Label lPass;
        private System.Windows.Forms.Button bAcceso;
        private System.Windows.Forms.Button bSalir;
    }
}

