
namespace Examen1Trimestre
{
    partial class fQueja
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
            this.lUsr = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lQueja = new System.Windows.Forms.Label();
            this.tbQueja = new System.Windows.Forms.TextBox();
            this.bGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lUsr
            // 
            this.lUsr.AutoSize = true;
            this.lUsr.Location = new System.Drawing.Point(33, 44);
            this.lUsr.Name = "lUsr";
            this.lUsr.Size = new System.Drawing.Size(46, 13);
            this.lUsr.TabIndex = 0;
            this.lUsr.Text = "Usuario:";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(85, 41);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 20);
            this.tbName.TabIndex = 1;
            // 
            // lQueja
            // 
            this.lQueja.AutoSize = true;
            this.lQueja.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lQueja.Location = new System.Drawing.Point(12, 141);
            this.lQueja.Name = "lQueja";
            this.lQueja.Size = new System.Drawing.Size(74, 18);
            this.lQueja.TabIndex = 2;
            this.lQueja.Text = "QUEJAS";
            // 
            // tbQueja
            // 
            this.tbQueja.Location = new System.Drawing.Point(27, 187);
            this.tbQueja.Multiline = true;
            this.tbQueja.Name = "tbQueja";
            this.tbQueja.Size = new System.Drawing.Size(745, 202);
            this.tbQueja.TabIndex = 3;
            // 
            // bGuardar
            // 
            this.bGuardar.Location = new System.Drawing.Point(253, 407);
            this.bGuardar.Name = "bGuardar";
            this.bGuardar.Size = new System.Drawing.Size(273, 31);
            this.bGuardar.TabIndex = 4;
            this.bGuardar.Text = "Guardar";
            this.bGuardar.UseVisualStyleBackColor = true;
            this.bGuardar.Click += new System.EventHandler(this.bGuardar_Click);
            // 
            // fQueja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bGuardar);
            this.Controls.Add(this.tbQueja);
            this.Controls.Add(this.lQueja);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lUsr);
            this.Name = "fQueja";
            this.Text = "fQueja";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lUsr;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lQueja;
        private System.Windows.Forms.TextBox tbQueja;
        private System.Windows.Forms.Button bGuardar;
    }
}