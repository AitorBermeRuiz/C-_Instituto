
namespace Examen2Trim
{
    partial class fAlta
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
            this.lCod = new System.Windows.Forms.Label();
            this.tbCod = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.lNombre = new System.Windows.Forms.Label();
            this.tbStockMin = new System.Windows.Forms.TextBox();
            this.lStockMin = new System.Windows.Forms.Label();
            this.tbPrecio = new System.Windows.Forms.TextBox();
            this.lPrecio = new System.Windows.Forms.Label();
            this.tbStockMax = new System.Windows.Forms.TextBox();
            this.lStockMax = new System.Windows.Forms.Label();
            this.bAceptar = new System.Windows.Forms.Button();
            this.bCancelar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lCod
            // 
            this.lCod.AutoSize = true;
            this.lCod.Location = new System.Drawing.Point(12, 27);
            this.lCod.Name = "lCod";
            this.lCod.Size = new System.Drawing.Size(88, 13);
            this.lCod.TabIndex = 0;
            this.lCod.Text = "Codigo producto:";
            // 
            // tbCod
            // 
            this.tbCod.Location = new System.Drawing.Point(114, 24);
            this.tbCod.Name = "tbCod";
            this.tbCod.Size = new System.Drawing.Size(100, 20);
            this.tbCod.TabIndex = 1;
            this.tbCod.Validating += new System.ComponentModel.CancelEventHandler(this.noInteger);
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(114, 68);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(100, 20);
            this.tbNombre.TabIndex = 3;
            // 
            // lNombre
            // 
            this.lNombre.AutoSize = true;
            this.lNombre.Location = new System.Drawing.Point(12, 71);
            this.lNombre.Name = "lNombre";
            this.lNombre.Size = new System.Drawing.Size(47, 13);
            this.lNombre.TabIndex = 2;
            this.lNombre.Text = "Nombre:";
            // 
            // tbStockMin
            // 
            this.tbStockMin.Location = new System.Drawing.Point(114, 153);
            this.tbStockMin.Name = "tbStockMin";
            this.tbStockMin.Size = new System.Drawing.Size(100, 20);
            this.tbStockMin.TabIndex = 7;
            this.tbStockMin.Validating += new System.ComponentModel.CancelEventHandler(this.noInteger);
            // 
            // lStockMin
            // 
            this.lStockMin.AutoSize = true;
            this.lStockMin.Location = new System.Drawing.Point(12, 156);
            this.lStockMin.Name = "lStockMin";
            this.lStockMin.Size = new System.Drawing.Size(73, 13);
            this.lStockMin.TabIndex = 6;
            this.lStockMin.Text = "Stock minimo:";
            // 
            // tbPrecio
            // 
            this.tbPrecio.Location = new System.Drawing.Point(114, 109);
            this.tbPrecio.Name = "tbPrecio";
            this.tbPrecio.Size = new System.Drawing.Size(100, 20);
            this.tbPrecio.TabIndex = 5;
            this.tbPrecio.Validating += new System.ComponentModel.CancelEventHandler(this.noInteger);
            // 
            // lPrecio
            // 
            this.lPrecio.AutoSize = true;
            this.lPrecio.Location = new System.Drawing.Point(12, 112);
            this.lPrecio.Name = "lPrecio";
            this.lPrecio.Size = new System.Drawing.Size(40, 13);
            this.lPrecio.TabIndex = 4;
            this.lPrecio.Text = "Precio:";
            // 
            // tbStockMax
            // 
            this.tbStockMax.Location = new System.Drawing.Point(114, 191);
            this.tbStockMax.Name = "tbStockMax";
            this.tbStockMax.Size = new System.Drawing.Size(100, 20);
            this.tbStockMax.TabIndex = 9;
            this.tbStockMax.Validating += new System.ComponentModel.CancelEventHandler(this.noInteger);
            // 
            // lStockMax
            // 
            this.lStockMax.AutoSize = true;
            this.lStockMax.Location = new System.Drawing.Point(12, 194);
            this.lStockMax.Name = "lStockMax";
            this.lStockMax.Size = new System.Drawing.Size(76, 13);
            this.lStockMax.TabIndex = 8;
            this.lStockMax.Text = "Stock maximo:";
            // 
            // bAceptar
            // 
            this.bAceptar.Location = new System.Drawing.Point(300, 47);
            this.bAceptar.Name = "bAceptar";
            this.bAceptar.Size = new System.Drawing.Size(95, 37);
            this.bAceptar.TabIndex = 10;
            this.bAceptar.Text = "Aceptar";
            this.bAceptar.UseVisualStyleBackColor = true;
            this.bAceptar.Click += new System.EventHandler(this.bAceptar_Click);
            // 
            // bCancelar
            // 
            this.bCancelar.Location = new System.Drawing.Point(300, 134);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(95, 35);
            this.bCancelar.TabIndex = 11;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // fAlta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 245);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.bAceptar);
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
            this.Name = "fAlta";
            this.Text = "fAlta";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lCod;
        private System.Windows.Forms.TextBox tbCod;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label lNombre;
        private System.Windows.Forms.TextBox tbStockMin;
        private System.Windows.Forms.Label lStockMin;
        private System.Windows.Forms.TextBox tbPrecio;
        private System.Windows.Forms.Label lPrecio;
        private System.Windows.Forms.TextBox tbStockMax;
        private System.Windows.Forms.Label lStockMax;
        private System.Windows.Forms.Button bAceptar;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}