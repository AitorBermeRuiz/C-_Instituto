
namespace EjercicioExamen
{
    partial class AccesoUsuario
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
            this.components = new System.ComponentModel.Container();
            this.lUsr = new System.Windows.Forms.Label();
            this.lContraseña = new System.Windows.Forms.Label();
            this.tbUsr = new System.Windows.Forms.TextBox();
            this.tbContraseña = new System.Windows.Forms.TextBox();
            this.bAcceder = new System.Windows.Forms.Button();
            this.bSalir = new System.Windows.Forms.Button();
            this.lAux = new System.Windows.Forms.Label();
            this.lNUsr = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lUsr
            // 
            this.lUsr.AutoSize = true;
            this.lUsr.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lUsr.Location = new System.Drawing.Point(13, 30);
            this.lUsr.Name = "lUsr";
            this.lUsr.Size = new System.Drawing.Size(72, 18);
            this.lUsr.TabIndex = 0;
            this.lUsr.Text = "Usuario:";
            // 
            // lContraseña
            // 
            this.lContraseña.AutoSize = true;
            this.lContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lContraseña.Location = new System.Drawing.Point(13, 84);
            this.lContraseña.Name = "lContraseña";
            this.lContraseña.Size = new System.Drawing.Size(100, 18);
            this.lContraseña.TabIndex = 1;
            this.lContraseña.Text = "Contraseña:";
            // 
            // tbUsr
            // 
            this.tbUsr.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsr.Location = new System.Drawing.Point(130, 27);
            this.tbUsr.Name = "tbUsr";
            this.tbUsr.Size = new System.Drawing.Size(173, 24);
            this.tbUsr.TabIndex = 2;
            // 
            // tbContraseña
            // 
            this.tbContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbContraseña.Location = new System.Drawing.Point(130, 81);
            this.tbContraseña.Name = "tbContraseña";
            this.tbContraseña.Size = new System.Drawing.Size(173, 24);
            this.tbContraseña.TabIndex = 3;
            // 
            // bAcceder
            // 
            this.bAcceder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAcceder.Location = new System.Drawing.Point(51, 189);
            this.bAcceder.Name = "bAcceder";
            this.bAcceder.Size = new System.Drawing.Size(113, 36);
            this.bAcceder.TabIndex = 4;
            this.bAcceder.Text = "Acceder";
            this.bAcceder.UseVisualStyleBackColor = true;
            this.bAcceder.Click += new System.EventHandler(this.bAcceder_Click);
            // 
            // bSalir
            // 
            this.bSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSalir.Location = new System.Drawing.Point(213, 189);
            this.bSalir.Name = "bSalir";
            this.bSalir.Size = new System.Drawing.Size(114, 36);
            this.bSalir.TabIndex = 5;
            this.bSalir.Text = "Salir";
            this.bSalir.UseVisualStyleBackColor = true;
            this.bSalir.Click += new System.EventHandler(this.bSalir_Click);
            // 
            // lAux
            // 
            this.lAux.AutoSize = true;
            this.lAux.Location = new System.Drawing.Point(194, 257);
            this.lAux.Name = "lAux";
            this.lAux.Size = new System.Drawing.Size(156, 13);
            this.lAux.TabIndex = 6;
            this.lAux.Text = "Numero de usuarios registrado: ";
            // 
            // lNUsr
            // 
            this.lNUsr.AutoSize = true;
            this.lNUsr.Location = new System.Drawing.Point(346, 257);
            this.lNUsr.Name = "lNUsr";
            this.lNUsr.Size = new System.Drawing.Size(0, 13);
            this.lNUsr.TabIndex = 7;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AccesoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 288);
            this.Controls.Add(this.lNUsr);
            this.Controls.Add(this.lAux);
            this.Controls.Add(this.bSalir);
            this.Controls.Add(this.bAcceder);
            this.Controls.Add(this.tbContraseña);
            this.Controls.Add(this.tbUsr);
            this.Controls.Add(this.lContraseña);
            this.Controls.Add(this.lUsr);
            this.Name = "AccesoUsuario";
            this.Text = "Acceso usuario:";
            this.Load += new System.EventHandler(this.AccesoUsuario_Load);
            this.Validating += new System.ComponentModel.CancelEventHandler(this.AccesoUsuario_Validating);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lUsr;
        private System.Windows.Forms.Label lContraseña;
        private System.Windows.Forms.TextBox tbUsr;
        private System.Windows.Forms.TextBox tbContraseña;
        private System.Windows.Forms.Button bAcceder;
        private System.Windows.Forms.Button bSalir;
        private System.Windows.Forms.Label lAux;
        private System.Windows.Forms.Label lNUsr;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

