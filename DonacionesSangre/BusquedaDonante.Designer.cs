
namespace DonacionesSangre
{
    partial class BusquedaDonante
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
            this.lDNI = new System.Windows.Forms.Label();
            this.tbDNI = new System.Windows.Forms.TextBox();
            this.bBuscar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbMostrar = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lDNI
            // 
            this.lDNI.AutoSize = true;
            this.lDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDNI.Location = new System.Drawing.Point(6, 28);
            this.lDNI.Name = "lDNI";
            this.lDNI.Size = new System.Drawing.Size(34, 16);
            this.lDNI.TabIndex = 0;
            this.lDNI.Text = "DNI:";
            // 
            // tbDNI
            // 
            this.tbDNI.Location = new System.Drawing.Point(46, 27);
            this.tbDNI.Name = "tbDNI";
            this.tbDNI.Size = new System.Drawing.Size(175, 20);
            this.tbDNI.TabIndex = 1;
            // 
            // bBuscar
            // 
            this.bBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBuscar.Location = new System.Drawing.Point(72, 105);
            this.bBuscar.Name = "bBuscar";
            this.bBuscar.Size = new System.Drawing.Size(88, 33);
            this.bBuscar.TabIndex = 2;
            this.bBuscar.Text = "Buscar";
            this.bBuscar.UseVisualStyleBackColor = true;
            this.bBuscar.Click += new System.EventHandler(this.bBuscar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbDNI);
            this.groupBox1.Controls.Add(this.bBuscar);
            this.groupBox1.Controls.Add(this.lDNI);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 177);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bucar Donante";
            // 
            // tbMostrar
            // 
            this.tbMostrar.Location = new System.Drawing.Point(270, 70);
            this.tbMostrar.Name = "tbMostrar";
            this.tbMostrar.Size = new System.Drawing.Size(411, 20);
            this.tbMostrar.TabIndex = 3;
            // 
            // BusquedaDonante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 231);
            this.Controls.Add(this.tbMostrar);
            this.Controls.Add(this.groupBox1);
            this.Name = "BusquedaDonante";
            this.Text = "BusquedaDonante";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lDNI;
        private System.Windows.Forms.TextBox tbDNI;
        private System.Windows.Forms.Button bBuscar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbMostrar;
    }
}