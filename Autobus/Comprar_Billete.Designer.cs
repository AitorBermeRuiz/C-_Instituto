
namespace Autobus
{
    partial class Comprar_Billete
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
            this.tbNumAsiento = new System.Windows.Forms.TextBox();
            this.lAsiento = new System.Windows.Forms.Label();
            this.bRegistrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lDNI
            // 
            this.lDNI.AutoSize = true;
            this.lDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDNI.Location = new System.Drawing.Point(12, 25);
            this.lDNI.Name = "lDNI";
            this.lDNI.Size = new System.Drawing.Size(37, 18);
            this.lDNI.TabIndex = 0;
            this.lDNI.Text = "DNI:";
            // 
            // tbDNI
            // 
            this.tbDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDNI.Location = new System.Drawing.Point(79, 22);
            this.tbDNI.Name = "tbDNI";
            this.tbDNI.Size = new System.Drawing.Size(131, 24);
            this.tbDNI.TabIndex = 1;
            // 
            // tbNumAsiento
            // 
            this.tbNumAsiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNumAsiento.Location = new System.Drawing.Point(79, 71);
            this.tbNumAsiento.Name = "tbNumAsiento";
            this.tbNumAsiento.Size = new System.Drawing.Size(131, 24);
            this.tbNumAsiento.TabIndex = 3;
            // 
            // lAsiento
            // 
            this.lAsiento.AutoSize = true;
            this.lAsiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAsiento.Location = new System.Drawing.Point(12, 77);
            this.lAsiento.Name = "lAsiento";
            this.lAsiento.Size = new System.Drawing.Size(61, 18);
            this.lAsiento.TabIndex = 2;
            this.lAsiento.Text = "Asiento:";
            // 
            // bRegistrar
            // 
            this.bRegistrar.Location = new System.Drawing.Point(55, 150);
            this.bRegistrar.Name = "bRegistrar";
            this.bRegistrar.Size = new System.Drawing.Size(119, 42);
            this.bRegistrar.TabIndex = 4;
            this.bRegistrar.Text = "REGISTRAR";
            this.bRegistrar.UseVisualStyleBackColor = true;
            this.bRegistrar.Click += new System.EventHandler(this.bRegistrar_Click);
            // 
            // Comprar_Billete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 260);
            this.Controls.Add(this.bRegistrar);
            this.Controls.Add(this.tbNumAsiento);
            this.Controls.Add(this.lAsiento);
            this.Controls.Add(this.tbDNI);
            this.Controls.Add(this.lDNI);
            this.Name = "Comprar_Billete";
            this.Text = "Comprar_Billete";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lDNI;
        private System.Windows.Forms.TextBox tbDNI;
        private System.Windows.Forms.TextBox tbNumAsiento;
        private System.Windows.Forms.Label lAsiento;
        private System.Windows.Forms.Button bRegistrar;
    }
}