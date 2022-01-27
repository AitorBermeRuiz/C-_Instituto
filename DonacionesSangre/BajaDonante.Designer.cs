
namespace DonacionesSangre
{
    partial class BajaDonante
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
            this.tbDNI = new System.Windows.Forms.TextBox();
            this.bEliminar = new System.Windows.Forms.Button();
            this.lDNI = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbDNI
            // 
            this.tbDNI.Location = new System.Drawing.Point(52, 26);
            this.tbDNI.Name = "tbDNI";
            this.tbDNI.Size = new System.Drawing.Size(175, 20);
            this.tbDNI.TabIndex = 1;
            // 
            // bEliminar
            // 
            this.bEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEliminar.Location = new System.Drawing.Point(69, 94);
            this.bEliminar.Name = "bEliminar";
            this.bEliminar.Size = new System.Drawing.Size(88, 33);
            this.bEliminar.TabIndex = 2;
            this.bEliminar.Text = "Eliminar";
            this.bEliminar.UseVisualStyleBackColor = true;
            this.bEliminar.Click += new System.EventHandler(this.bBuscar_Click);
            // 
            // lDNI
            // 
            this.lDNI.AutoSize = true;
            this.lDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDNI.Location = new System.Drawing.Point(12, 27);
            this.lDNI.Name = "lDNI";
            this.lDNI.Size = new System.Drawing.Size(34, 16);
            this.lDNI.TabIndex = 0;
            this.lDNI.Text = "DNI:";
            // 
            // BajaDonante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 257);
            this.Controls.Add(this.bEliminar);
            this.Controls.Add(this.tbDNI);
            this.Controls.Add(this.lDNI);
            this.Name = "BajaDonante";
            this.Text = "BajaDonante";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbDNI;
        private System.Windows.Forms.Button bEliminar;
        private System.Windows.Forms.Label lDNI;
    }
}