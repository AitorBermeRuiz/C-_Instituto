
namespace BilletesAutobus
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
            this.btUsuarios = new System.Windows.Forms.Button();
            this.btBilletes = new System.Windows.Forms.Button();
            this.btComprobar = new System.Windows.Forms.Button();
            this.btSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btUsuarios
            // 
            this.btUsuarios.Location = new System.Drawing.Point(64, 12);
            this.btUsuarios.Name = "btUsuarios";
            this.btUsuarios.Size = new System.Drawing.Size(179, 36);
            this.btUsuarios.TabIndex = 0;
            this.btUsuarios.Text = "Registrar Usuarios";
            this.btUsuarios.UseVisualStyleBackColor = true;
            this.btUsuarios.Click += new System.EventHandler(this.btUsuarios_Click);
            // 
            // btBilletes
            // 
            this.btBilletes.Location = new System.Drawing.Point(64, 67);
            this.btBilletes.Name = "btBilletes";
            this.btBilletes.Size = new System.Drawing.Size(179, 36);
            this.btBilletes.TabIndex = 1;
            this.btBilletes.Text = "Comprar Billetes";
            this.btBilletes.UseVisualStyleBackColor = true;
            this.btBilletes.Click += new System.EventHandler(this.btBilletes_Click);
            // 
            // btComprobar
            // 
            this.btComprobar.Location = new System.Drawing.Point(64, 122);
            this.btComprobar.Name = "btComprobar";
            this.btComprobar.Size = new System.Drawing.Size(179, 36);
            this.btComprobar.TabIndex = 2;
            this.btComprobar.Text = "Comprobación";
            this.btComprobar.UseVisualStyleBackColor = true;
            this.btComprobar.Click += new System.EventHandler(this.btComprobar_Click);
            // 
            // btSalir
            // 
            this.btSalir.Location = new System.Drawing.Point(64, 179);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(77, 36);
            this.btSalir.TabIndex = 3;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = true;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 312);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.btComprobar);
            this.Controls.Add(this.btBilletes);
            this.Controls.Add(this.btUsuarios);
            this.Name = "Form1";
            this.Text = "Billetes Autobus";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btUsuarios;
        private System.Windows.Forms.Button btBilletes;
        private System.Windows.Forms.Button btComprobar;
        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.Label label1;
    }
}

