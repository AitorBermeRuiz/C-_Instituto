
namespace Examen2Trim
{
    partial class fConsultar
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
            this.bSiguiente = new System.Windows.Forms.Button();
            this.bPrimero = new System.Windows.Forms.Button();
            this.tbStockMax = new System.Windows.Forms.TextBox();
            this.lStockMax = new System.Windows.Forms.Label();
            this.tbStockMin = new System.Windows.Forms.TextBox();
            this.lStockMin = new System.Windows.Forms.Label();
            this.tbPrecio = new System.Windows.Forms.TextBox();
            this.lPrecio = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.lNombre = new System.Windows.Forms.Label();
            this.tbCod = new System.Windows.Forms.TextBox();
            this.lCod = new System.Windows.Forms.Label();
            this.tbUnidades = new System.Windows.Forms.TextBox();
            this.lUnidades = new System.Windows.Forms.Label();
            this.bUltimo = new System.Windows.Forms.Button();
            this.bAnterior = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bSiguiente
            // 
            this.bSiguiente.Location = new System.Drawing.Point(309, 82);
            this.bSiguiente.Name = "bSiguiente";
            this.bSiguiente.Size = new System.Drawing.Size(95, 35);
            this.bSiguiente.TabIndex = 23;
            this.bSiguiente.Text = "Siguiente";
            this.bSiguiente.UseVisualStyleBackColor = true;
            this.bSiguiente.Click += new System.EventHandler(this.bSiguiente_Click);
            // 
            // bPrimero
            // 
            this.bPrimero.Location = new System.Drawing.Point(309, 35);
            this.bPrimero.Name = "bPrimero";
            this.bPrimero.Size = new System.Drawing.Size(95, 37);
            this.bPrimero.TabIndex = 22;
            this.bPrimero.Text = "Primero";
            this.bPrimero.UseVisualStyleBackColor = true;
            this.bPrimero.Click += new System.EventHandler(this.bPrimero_Click);
            // 
            // tbStockMax
            // 
            this.tbStockMax.Location = new System.Drawing.Point(123, 179);
            this.tbStockMax.Name = "tbStockMax";
            this.tbStockMax.Size = new System.Drawing.Size(100, 20);
            this.tbStockMax.TabIndex = 21;
            // 
            // lStockMax
            // 
            this.lStockMax.AutoSize = true;
            this.lStockMax.Location = new System.Drawing.Point(21, 182);
            this.lStockMax.Name = "lStockMax";
            this.lStockMax.Size = new System.Drawing.Size(76, 13);
            this.lStockMax.TabIndex = 20;
            this.lStockMax.Text = "Stock maximo:";
            // 
            // tbStockMin
            // 
            this.tbStockMin.Location = new System.Drawing.Point(123, 141);
            this.tbStockMin.Name = "tbStockMin";
            this.tbStockMin.Size = new System.Drawing.Size(100, 20);
            this.tbStockMin.TabIndex = 19;
            // 
            // lStockMin
            // 
            this.lStockMin.AutoSize = true;
            this.lStockMin.Location = new System.Drawing.Point(21, 144);
            this.lStockMin.Name = "lStockMin";
            this.lStockMin.Size = new System.Drawing.Size(73, 13);
            this.lStockMin.TabIndex = 18;
            this.lStockMin.Text = "Stock minimo:";
            // 
            // tbPrecio
            // 
            this.tbPrecio.Location = new System.Drawing.Point(123, 97);
            this.tbPrecio.Name = "tbPrecio";
            this.tbPrecio.Size = new System.Drawing.Size(100, 20);
            this.tbPrecio.TabIndex = 17;
            // 
            // lPrecio
            // 
            this.lPrecio.AutoSize = true;
            this.lPrecio.Location = new System.Drawing.Point(21, 100);
            this.lPrecio.Name = "lPrecio";
            this.lPrecio.Size = new System.Drawing.Size(40, 13);
            this.lPrecio.TabIndex = 16;
            this.lPrecio.Text = "Precio:";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(123, 56);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(100, 20);
            this.tbNombre.TabIndex = 15;
            // 
            // lNombre
            // 
            this.lNombre.AutoSize = true;
            this.lNombre.Location = new System.Drawing.Point(21, 59);
            this.lNombre.Name = "lNombre";
            this.lNombre.Size = new System.Drawing.Size(47, 13);
            this.lNombre.TabIndex = 14;
            this.lNombre.Text = "Nombre:";
            // 
            // tbCod
            // 
            this.tbCod.Location = new System.Drawing.Point(123, 12);
            this.tbCod.Name = "tbCod";
            this.tbCod.Size = new System.Drawing.Size(100, 20);
            this.tbCod.TabIndex = 13;
            // 
            // lCod
            // 
            this.lCod.AutoSize = true;
            this.lCod.Location = new System.Drawing.Point(21, 15);
            this.lCod.Name = "lCod";
            this.lCod.Size = new System.Drawing.Size(88, 13);
            this.lCod.TabIndex = 12;
            this.lCod.Text = "Codigo producto:";
            // 
            // tbUnidades
            // 
            this.tbUnidades.Location = new System.Drawing.Point(123, 219);
            this.tbUnidades.Name = "tbUnidades";
            this.tbUnidades.Size = new System.Drawing.Size(100, 20);
            this.tbUnidades.TabIndex = 25;
            // 
            // lUnidades
            // 
            this.lUnidades.AutoSize = true;
            this.lUnidades.Location = new System.Drawing.Point(21, 222);
            this.lUnidades.Name = "lUnidades";
            this.lUnidades.Size = new System.Drawing.Size(55, 13);
            this.lUnidades.TabIndex = 24;
            this.lUnidades.Text = "Unidades:";
            // 
            // bUltimo
            // 
            this.bUltimo.Location = new System.Drawing.Point(309, 179);
            this.bUltimo.Name = "bUltimo";
            this.bUltimo.Size = new System.Drawing.Size(95, 35);
            this.bUltimo.TabIndex = 27;
            this.bUltimo.Text = "Ultimo";
            this.bUltimo.UseVisualStyleBackColor = true;
            this.bUltimo.Click += new System.EventHandler(this.bUltimo_Click);
            // 
            // bAnterior
            // 
            this.bAnterior.Location = new System.Drawing.Point(309, 132);
            this.bAnterior.Name = "bAnterior";
            this.bAnterior.Size = new System.Drawing.Size(95, 37);
            this.bAnterior.TabIndex = 26;
            this.bAnterior.Text = "Anterior";
            this.bAnterior.UseVisualStyleBackColor = true;
            this.bAnterior.Click += new System.EventHandler(this.bAnterior_Click);
            // 
            // fConsultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 285);
            this.Controls.Add(this.bUltimo);
            this.Controls.Add(this.bAnterior);
            this.Controls.Add(this.tbUnidades);
            this.Controls.Add(this.lUnidades);
            this.Controls.Add(this.bSiguiente);
            this.Controls.Add(this.bPrimero);
            this.Controls.Add(this.tbStockMax);
            this.Controls.Add(this.lStockMax);
            this.Controls.Add(this.tbStockMin);
            this.Controls.Add(this.lStockMin);
            this.Controls.Add(this.tbPrecio);
            this.Controls.Add(this.lPrecio);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.lNombre);
            this.Controls.Add(this.tbCod);
            this.Controls.Add(this.lCod);
            this.Name = "fConsultar";
            this.Text = "fConsultar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bSiguiente;
        private System.Windows.Forms.Button bPrimero;
        private System.Windows.Forms.TextBox tbStockMax;
        private System.Windows.Forms.Label lStockMax;
        private System.Windows.Forms.TextBox tbStockMin;
        private System.Windows.Forms.Label lStockMin;
        private System.Windows.Forms.TextBox tbPrecio;
        private System.Windows.Forms.Label lPrecio;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label lNombre;
        private System.Windows.Forms.TextBox tbCod;
        private System.Windows.Forms.Label lCod;
        private System.Windows.Forms.TextBox tbUnidades;
        private System.Windows.Forms.Label lUnidades;
        private System.Windows.Forms.Button bUltimo;
        private System.Windows.Forms.Button bAnterior;
    }
}