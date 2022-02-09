
namespace Examen2Trim
{
    partial class cVenta
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
            this.bCancelar = new System.Windows.Forms.Button();
            this.bAceptar = new System.Windows.Forms.Button();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.lTotal = new System.Windows.Forms.Label();
            this.tbUnidades = new System.Windows.Forms.TextBox();
            this.lUnidades = new System.Windows.Forms.Label();
            this.tbPrecio = new System.Windows.Forms.TextBox();
            this.lPrecio = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.lNombre = new System.Windows.Forms.Label();
            this.tbCod = new System.Windows.Forms.TextBox();
            this.lCod = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bCancelar
            // 
            this.bCancelar.Location = new System.Drawing.Point(323, 128);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(95, 35);
            this.bCancelar.TabIndex = 53;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click_1);
            // 
            // bAceptar
            // 
            this.bAceptar.Location = new System.Drawing.Point(323, 41);
            this.bAceptar.Name = "bAceptar";
            this.bAceptar.Size = new System.Drawing.Size(95, 37);
            this.bAceptar.TabIndex = 52;
            this.bAceptar.Text = "Aceptar";
            this.bAceptar.UseVisualStyleBackColor = true;
            this.bAceptar.Click += new System.EventHandler(this.bAceptar_Click);
            // 
            // tbTotal
            // 
            this.tbTotal.Location = new System.Drawing.Point(114, 170);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Size = new System.Drawing.Size(100, 20);
            this.tbTotal.TabIndex = 51;
            // 
            // lTotal
            // 
            this.lTotal.AutoSize = true;
            this.lTotal.Location = new System.Drawing.Point(12, 173);
            this.lTotal.Name = "lTotal";
            this.lTotal.Size = new System.Drawing.Size(34, 13);
            this.lTotal.TabIndex = 50;
            this.lTotal.Text = "Total:";
            // 
            // tbUnidades
            // 
            this.tbUnidades.Location = new System.Drawing.Point(114, 131);
            this.tbUnidades.Name = "tbUnidades";
            this.tbUnidades.Size = new System.Drawing.Size(100, 20);
            this.tbUnidades.TabIndex = 49;
            this.tbUnidades.Validating += new System.ComponentModel.CancelEventHandler(this.CalcularTotal);
            // 
            // lUnidades
            // 
            this.lUnidades.AutoSize = true;
            this.lUnidades.Location = new System.Drawing.Point(12, 134);
            this.lUnidades.Name = "lUnidades";
            this.lUnidades.Size = new System.Drawing.Size(55, 13);
            this.lUnidades.TabIndex = 48;
            this.lUnidades.Text = "Unidades:";
            // 
            // tbPrecio
            // 
            this.tbPrecio.Location = new System.Drawing.Point(114, 91);
            this.tbPrecio.Name = "tbPrecio";
            this.tbPrecio.Size = new System.Drawing.Size(100, 20);
            this.tbPrecio.TabIndex = 47;
            // 
            // lPrecio
            // 
            this.lPrecio.AutoSize = true;
            this.lPrecio.Location = new System.Drawing.Point(12, 94);
            this.lPrecio.Name = "lPrecio";
            this.lPrecio.Size = new System.Drawing.Size(40, 13);
            this.lPrecio.TabIndex = 46;
            this.lPrecio.Text = "Precio:";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(114, 50);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(100, 20);
            this.tbNombre.TabIndex = 45;
            // 
            // lNombre
            // 
            this.lNombre.AutoSize = true;
            this.lNombre.Location = new System.Drawing.Point(12, 53);
            this.lNombre.Name = "lNombre";
            this.lNombre.Size = new System.Drawing.Size(47, 13);
            this.lNombre.TabIndex = 44;
            this.lNombre.Text = "Nombre:";
            // 
            // tbCod
            // 
            this.tbCod.Location = new System.Drawing.Point(114, 6);
            this.tbCod.Name = "tbCod";
            this.tbCod.Size = new System.Drawing.Size(100, 20);
            this.tbCod.TabIndex = 43;
            this.tbCod.Validating += new System.ComponentModel.CancelEventHandler(this.BuscarProduct);
            // 
            // lCod
            // 
            this.lCod.AutoSize = true;
            this.lCod.Location = new System.Drawing.Point(12, 9);
            this.lCod.Name = "lCod";
            this.lCod.Size = new System.Drawing.Size(88, 13);
            this.lCod.TabIndex = 42;
            this.lCod.Text = "Codigo producto:";
            // 
            // cVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 244);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.bAceptar);
            this.Controls.Add(this.tbTotal);
            this.Controls.Add(this.lTotal);
            this.Controls.Add(this.tbUnidades);
            this.Controls.Add(this.lUnidades);
            this.Controls.Add(this.tbPrecio);
            this.Controls.Add(this.lPrecio);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.lNombre);
            this.Controls.Add(this.tbCod);
            this.Controls.Add(this.lCod);
            this.Name = "cVenta";
            this.Text = "cVenta";
            this.Validating += new System.ComponentModel.CancelEventHandler(this.BuscarProduct);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.Button bAceptar;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.Label lTotal;
        private System.Windows.Forms.TextBox tbUnidades;
        private System.Windows.Forms.Label lUnidades;
        private System.Windows.Forms.TextBox tbPrecio;
        private System.Windows.Forms.Label lPrecio;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label lNombre;
        private System.Windows.Forms.TextBox tbCod;
        private System.Windows.Forms.Label lCod;
    }
}