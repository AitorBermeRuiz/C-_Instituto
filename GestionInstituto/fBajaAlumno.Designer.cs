
namespace GestionInstituto
{
    partial class fBajaAlumno
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
            this.components = new System.ComponentModel.Container();
            this.lDni = new System.Windows.Forms.Label();
            this.tbDni = new System.Windows.Forms.TextBox();
            this.bAceptar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lDni
            // 
            this.lDni.AutoSize = true;
            this.lDni.Location = new System.Drawing.Point(12, 44);
            this.lDni.Name = "lDni";
            this.lDni.Size = new System.Drawing.Size(29, 13);
            this.lDni.TabIndex = 0;
            this.lDni.Text = "DNI:";
            // 
            // tbDni
            // 
            this.tbDni.Location = new System.Drawing.Point(47, 41);
            this.tbDni.Name = "tbDni";
            this.tbDni.Size = new System.Drawing.Size(120, 20);
            this.tbDni.TabIndex = 1;
            // 
            // bAceptar
            // 
            this.bAceptar.Location = new System.Drawing.Point(197, 135);
            this.bAceptar.Name = "bAceptar";
            this.bAceptar.Size = new System.Drawing.Size(75, 23);
            this.bAceptar.TabIndex = 2;
            this.bAceptar.Text = "Aceptar";
            this.bAceptar.UseVisualStyleBackColor = true;
            this.bAceptar.Click += new System.EventHandler(this.bAceptar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // fBajaAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 181);
            this.Controls.Add(this.bAceptar);
            this.Controls.Add(this.tbDni);
            this.Controls.Add(this.lDni);
            this.Name = "fBajaAlumno";
            this.Text = "Baja Alumno";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lDni;
        private System.Windows.Forms.TextBox tbDni;
        private System.Windows.Forms.Button bAceptar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}