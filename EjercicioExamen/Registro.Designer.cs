
namespace EjercicioExamen
{
    partial class Registro
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
            this.bVolver = new System.Windows.Forms.Button();
            this.bGuardar = new System.Windows.Forms.Button();
            this.tbContraseña = new System.Windows.Forms.TextBox();
            this.tbUsr = new System.Windows.Forms.TextBox();
            this.lContraseña = new System.Windows.Forms.Label();
            this.lUsr = new System.Windows.Forms.Label();
            this.lNombre = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.lfNacim = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lMedia = new System.Windows.Forms.Label();
            this.tbNota = new System.Windows.Forms.TextBox();
            this.lModulo2 = new System.Windows.Forms.Label();
            this.tbModulo2 = new System.Windows.Forms.TextBox();
            this.lModulo1 = new System.Windows.Forms.Label();
            this.tbModulo1 = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // bVolver
            // 
            this.bVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bVolver.Location = new System.Drawing.Point(376, 86);
            this.bVolver.Name = "bVolver";
            this.bVolver.Size = new System.Drawing.Size(82, 26);
            this.bVolver.TabIndex = 11;
            this.bVolver.Text = "Volver";
            this.bVolver.UseVisualStyleBackColor = true;
            this.bVolver.Click += new System.EventHandler(this.bVolver_Click);
            // 
            // bGuardar
            // 
            this.bGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bGuardar.Location = new System.Drawing.Point(376, 22);
            this.bGuardar.Name = "bGuardar";
            this.bGuardar.Size = new System.Drawing.Size(82, 26);
            this.bGuardar.TabIndex = 10;
            this.bGuardar.Text = "Guardar";
            this.bGuardar.UseVisualStyleBackColor = true;
            this.bGuardar.Click += new System.EventHandler(this.bGuardar_Click);
            // 
            // tbContraseña
            // 
            this.tbContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbContraseña.Location = new System.Drawing.Point(264, 22);
            this.tbContraseña.MaxLength = 6;
            this.tbContraseña.Name = "tbContraseña";
            this.tbContraseña.PasswordChar = '*';
            this.tbContraseña.Size = new System.Drawing.Size(85, 20);
            this.tbContraseña.TabIndex = 9;
            // 
            // tbUsr
            // 
            this.tbUsr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsr.Location = new System.Drawing.Point(68, 22);
            this.tbUsr.MaxLength = 5;
            this.tbUsr.Name = "tbUsr";
            this.tbUsr.Size = new System.Drawing.Size(85, 20);
            this.tbUsr.TabIndex = 8;
            // 
            // lContraseña
            // 
            this.lContraseña.AutoSize = true;
            this.lContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lContraseña.Location = new System.Drawing.Point(183, 25);
            this.lContraseña.Name = "lContraseña";
            this.lContraseña.Size = new System.Drawing.Size(75, 13);
            this.lContraseña.TabIndex = 7;
            this.lContraseña.Text = "Contraseña:";
            // 
            // lUsr
            // 
            this.lUsr.AutoSize = true;
            this.lUsr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lUsr.Location = new System.Drawing.Point(8, 25);
            this.lUsr.Name = "lUsr";
            this.lUsr.Size = new System.Drawing.Size(54, 13);
            this.lUsr.TabIndex = 6;
            this.lUsr.Text = "Usuario:";
            // 
            // lNombre
            // 
            this.lNombre.AutoSize = true;
            this.lNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNombre.Location = new System.Drawing.Point(8, 89);
            this.lNombre.Name = "lNombre";
            this.lNombre.Size = new System.Drawing.Size(54, 13);
            this.lNombre.TabIndex = 12;
            this.lNombre.Text = "Nombre:";
            // 
            // tbNombre
            // 
            this.tbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNombre.Location = new System.Drawing.Point(68, 86);
            this.tbNombre.MaxLength = 30000;
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(85, 20);
            this.tbNombre.TabIndex = 13;
            // 
            // lfNacim
            // 
            this.lfNacim.AutoSize = true;
            this.lfNacim.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lfNacim.Location = new System.Drawing.Point(8, 134);
            this.lfNacim.Name = "lfNacim";
            this.lfNacim.Size = new System.Drawing.Size(113, 13);
            this.lfNacim.TabIndex = 14;
            this.lfNacim.Text = "Fecha Nacimiento:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(127, 134);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lMedia);
            this.groupBox1.Controls.Add(this.tbNota);
            this.groupBox1.Controls.Add(this.lModulo2);
            this.groupBox1.Controls.Add(this.tbModulo2);
            this.groupBox1.Controls.Add(this.lModulo1);
            this.groupBox1.Controls.Add(this.tbModulo1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 182);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 162);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Notas";
            // 
            // lMedia
            // 
            this.lMedia.AutoSize = true;
            this.lMedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMedia.Location = new System.Drawing.Point(187, 50);
            this.lMedia.Name = "lMedia";
            this.lMedia.Size = new System.Drawing.Size(45, 13);
            this.lMedia.TabIndex = 25;
            this.lMedia.Text = "Media:";
            // 
            // tbNota
            // 
            this.tbNota.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNota.Location = new System.Drawing.Point(256, 47);
            this.tbNota.MaxLength = 2;
            this.tbNota.Name = "tbNota";
            this.tbNota.Size = new System.Drawing.Size(85, 20);
            this.tbNota.TabIndex = 24;
            // 
            // lModulo2
            // 
            this.lModulo2.AutoSize = true;
            this.lModulo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lModulo2.Location = new System.Drawing.Point(6, 68);
            this.lModulo2.Name = "lModulo2";
            this.lModulo2.Size = new System.Drawing.Size(59, 13);
            this.lModulo2.TabIndex = 23;
            this.lModulo2.Text = "Modulo2:";
            // 
            // tbModulo2
            // 
            this.tbModulo2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbModulo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbModulo2.Location = new System.Drawing.Point(75, 65);
            this.tbModulo2.MaxLength = 2;
            this.tbModulo2.Name = "tbModulo2";
            this.tbModulo2.Size = new System.Drawing.Size(85, 20);
            this.tbModulo2.TabIndex = 22;
            this.tbModulo2.Validating += new System.ComponentModel.CancelEventHandler(this.Validating_notas);
            // 
            // lModulo1
            // 
            this.lModulo1.AutoSize = true;
            this.lModulo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lModulo1.Location = new System.Drawing.Point(6, 22);
            this.lModulo1.Name = "lModulo1";
            this.lModulo1.Size = new System.Drawing.Size(59, 13);
            this.lModulo1.TabIndex = 21;
            this.lModulo1.Text = "Modulo1:";
            // 
            // tbModulo1
            // 
            this.tbModulo1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbModulo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbModulo1.Location = new System.Drawing.Point(75, 19);
            this.tbModulo1.MaxLength = 2;
            this.tbModulo1.Name = "tbModulo1";
            this.tbModulo1.Size = new System.Drawing.Size(85, 20);
            this.tbModulo1.TabIndex = 19;
            this.tbModulo1.Validating += new System.ComponentModel.CancelEventHandler(this.Validating_notas);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 366);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lfNacim);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.lNombre);
            this.Controls.Add(this.bVolver);
            this.Controls.Add(this.bGuardar);
            this.Controls.Add(this.tbContraseña);
            this.Controls.Add(this.tbUsr);
            this.Controls.Add(this.lContraseña);
            this.Controls.Add(this.lUsr);
            this.Name = "Registro";
            this.Text = "Registro";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bVolver;
        private System.Windows.Forms.Button bGuardar;
        private System.Windows.Forms.TextBox tbContraseña;
        private System.Windows.Forms.TextBox tbUsr;
        private System.Windows.Forms.Label lContraseña;
        private System.Windows.Forms.Label lUsr;
        private System.Windows.Forms.Label lNombre;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label lfNacim;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lMedia;
        private System.Windows.Forms.TextBox tbNota;
        private System.Windows.Forms.Label lModulo2;
        private System.Windows.Forms.TextBox tbModulo2;
        private System.Windows.Forms.Label lModulo1;
        private System.Windows.Forms.TextBox tbModulo1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}