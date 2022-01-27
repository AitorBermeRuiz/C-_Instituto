
namespace Trabajo_Fechas
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
            this.FechaNacim = new System.Windows.Forms.DateTimePicker();
            this.Fecha_Nacim = new System.Windows.Forms.Label();
            this.Cumpleaños = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // FechaNacim
            // 
            this.FechaNacim.Location = new System.Drawing.Point(145, 17);
            this.FechaNacim.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.FechaNacim.Name = "FechaNacim";
            this.FechaNacim.Size = new System.Drawing.Size(200, 20);
            this.FechaNacim.TabIndex = 0;
            this.FechaNacim.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // Fecha_Nacim
            // 
            this.Fecha_Nacim.AutoSize = true;
            this.Fecha_Nacim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fecha_Nacim.Location = new System.Drawing.Point(12, 17);
            this.Fecha_Nacim.Name = "Fecha_Nacim";
            this.Fecha_Nacim.Size = new System.Drawing.Size(127, 15);
            this.Fecha_Nacim.TabIndex = 1;
            this.Fecha_Nacim.Text = "Fecha Nacimiento:";
            this.Fecha_Nacim.Click += new System.EventHandler(this.label1_Click);
            // 
            // Cumpleaños
            // 
            this.Cumpleaños.AutoSize = true;
            this.Cumpleaños.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cumpleaños.Location = new System.Drawing.Point(11, 65);
            this.Cumpleaños.Name = "Cumpleaños";
            this.Cumpleaños.Size = new System.Drawing.Size(128, 15);
            this.Cumpleaños.TabIndex = 2;
            this.Cumpleaños.Text = "Tu cumpleaños es:";
            this.Cumpleaños.Click += new System.EventHandler(this.label2_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.listBox1.Location = new System.Drawing.Point(411, 109);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(163, 82);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Cumpleaños);
            this.Controls.Add(this.Fecha_Nacim);
            this.Controls.Add(this.FechaNacim);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker FechaNacim;
        private System.Windows.Forms.Label Fecha_Nacim;
        private System.Windows.Forms.Label Cumpleaños;
        private System.Windows.Forms.ListBox listBox1;
    }
}

