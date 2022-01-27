
namespace Empleados
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
            this.Nombre = new System.Windows.Forms.Label();
            this.TBNombre = new System.Windows.Forms.TextBox();
            this.Apellido = new System.Windows.Forms.Label();
            this.DNI = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.FechaNacim = new System.Windows.Forms.Label();
            this.FechaInc = new System.Windows.Forms.Label();
            this.TBApellido = new System.Windows.Forms.TextBox();
            this.TBDNI = new System.Windows.Forms.TextBox();
            this.TBEmail = new System.Windows.Forms.TextBox();
            this.DTNacim = new System.Windows.Forms.DateTimePicker();
            this.DTInc = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BAceptar = new System.Windows.Forms.Button();
            this.BCancelar = new System.Windows.Forms.Button();
            this.BTodos = new System.Windows.Forms.Button();
            this.BMantenimiento = new System.Windows.Forms.Button();
            this.BJefe = new System.Windows.Forms.Button();
            this.BOperario = new System.Windows.Forms.Button();
            this.LOculto = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre.Location = new System.Drawing.Point(82, 19);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(54, 13);
            this.Nombre.TabIndex = 13;
            this.Nombre.Text = "Nombre:";
            // 
            // TBNombre
            // 
            this.TBNombre.Location = new System.Drawing.Point(142, 16);
            this.TBNombre.Name = "TBNombre";
            this.TBNombre.Size = new System.Drawing.Size(200, 20);
            this.TBNombre.TabIndex = 0;
            this.TBNombre.TextChanged += new System.EventHandler(this.TBNombre_TextChanged);
            // 
            // Apellido
            // 
            this.Apellido.AutoSize = true;
            this.Apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Apellido.Location = new System.Drawing.Point(80, 63);
            this.Apellido.Name = "Apellido";
            this.Apellido.Size = new System.Drawing.Size(56, 13);
            this.Apellido.TabIndex = 14;
            this.Apellido.Text = "Apellido:";
            // 
            // DNI
            // 
            this.DNI.AutoSize = true;
            this.DNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DNI.Location = new System.Drawing.Point(76, 109);
            this.DNI.Name = "DNI";
            this.DNI.Size = new System.Drawing.Size(60, 13);
            this.DNI.TabIndex = 15;
            this.DNI.Text = "DNI/NIE:";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.Location = new System.Drawing.Point(95, 156);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(41, 13);
            this.Email.TabIndex = 16;
            this.Email.Text = "Email:";
            this.Email.Click += new System.EventHandler(this.Email_Click);
            // 
            // FechaNacim
            // 
            this.FechaNacim.AutoSize = true;
            this.FechaNacim.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaNacim.Location = new System.Drawing.Point(23, 203);
            this.FechaNacim.Name = "FechaNacim";
            this.FechaNacim.Size = new System.Drawing.Size(113, 13);
            this.FechaNacim.TabIndex = 17;
            this.FechaNacim.Text = "Fecha Nacimiento:";
            // 
            // FechaInc
            // 
            this.FechaInc.AutoSize = true;
            this.FechaInc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaInc.Location = new System.Drawing.Point(12, 253);
            this.FechaInc.Name = "FechaInc";
            this.FechaInc.Size = new System.Drawing.Size(128, 13);
            this.FechaInc.TabIndex = 18;
            this.FechaInc.Text = "Fecha Incorporacion:";
            // 
            // TBApellido
            // 
            this.TBApellido.Location = new System.Drawing.Point(142, 60);
            this.TBApellido.Name = "TBApellido";
            this.TBApellido.Size = new System.Drawing.Size(200, 20);
            this.TBApellido.TabIndex = 1;
            // 
            // TBDNI
            // 
            this.TBDNI.Location = new System.Drawing.Point(142, 106);
            this.TBDNI.Name = "TBDNI";
            this.TBDNI.Size = new System.Drawing.Size(200, 20);
            this.TBDNI.TabIndex = 2;
            // 
            // TBEmail
            // 
            this.TBEmail.Location = new System.Drawing.Point(142, 153);
            this.TBEmail.Name = "TBEmail";
            this.TBEmail.Size = new System.Drawing.Size(200, 20);
            this.TBEmail.TabIndex = 3;
            // 
            // DTNacim
            // 
            this.DTNacim.Location = new System.Drawing.Point(142, 195);
            this.DTNacim.MaxDate = new System.DateTime(3622, 4, 3, 0, 0, 0, 0);
            this.DTNacim.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.DTNacim.Name = "DTNacim";
            this.DTNacim.Size = new System.Drawing.Size(200, 20);
            this.DTNacim.TabIndex = 4;
            this.DTNacim.Value = new System.DateTime(2021, 10, 6, 0, 0, 0, 0);
            this.DTNacim.ValueChanged += new System.EventHandler(this.DTNacim_ValueChanged);
            // 
            // DTInc
            // 
            this.DTInc.Location = new System.Drawing.Point(142, 246);
            this.DTInc.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.DTInc.Name = "DTInc";
            this.DTInc.Size = new System.Drawing.Size(200, 20);
            this.DTInc.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(86, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Puesto:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(142, 287);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // BAceptar
            // 
            this.BAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BAceptar.Location = new System.Drawing.Point(83, 353);
            this.BAceptar.Name = "BAceptar";
            this.BAceptar.Size = new System.Drawing.Size(98, 29);
            this.BAceptar.TabIndex = 7;
            this.BAceptar.Text = "Aceptar";
            this.BAceptar.UseVisualStyleBackColor = true;
            this.BAceptar.Click += new System.EventHandler(this.BAceptar_Click);
            // 
            // BCancelar
            // 
            this.BCancelar.Location = new System.Drawing.Point(244, 353);
            this.BCancelar.Name = "BCancelar";
            this.BCancelar.Size = new System.Drawing.Size(98, 30);
            this.BCancelar.TabIndex = 8;
            this.BCancelar.Text = "Cancelar";
            this.BCancelar.UseVisualStyleBackColor = true;
            this.BCancelar.Click += new System.EventHandler(this.BCancelar_Click);
            // 
            // BTodos
            // 
            this.BTodos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTodos.Location = new System.Drawing.Point(377, 193);
            this.BTodos.Name = "BTodos";
            this.BTodos.Size = new System.Drawing.Size(98, 29);
            this.BTodos.TabIndex = 12;
            this.BTodos.Text = "Todos";
            this.BTodos.UseVisualStyleBackColor = true;
            this.BTodos.Click += new System.EventHandler(this.BTodos_Click);
            // 
            // BMantenimiento
            // 
            this.BMantenimiento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BMantenimiento.Location = new System.Drawing.Point(377, 148);
            this.BMantenimiento.Name = "BMantenimiento";
            this.BMantenimiento.Size = new System.Drawing.Size(98, 29);
            this.BMantenimiento.TabIndex = 11;
            this.BMantenimiento.Text = "Mantenimiento";
            this.BMantenimiento.UseVisualStyleBackColor = true;
            this.BMantenimiento.Click += new System.EventHandler(this.BMantenimiento_Click);
            // 
            // BJefe
            // 
            this.BJefe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BJefe.Location = new System.Drawing.Point(377, 101);
            this.BJefe.Name = "BJefe";
            this.BJefe.Size = new System.Drawing.Size(98, 29);
            this.BJefe.TabIndex = 10;
            this.BJefe.Text = "Jefe";
            this.BJefe.UseVisualStyleBackColor = true;
            this.BJefe.Click += new System.EventHandler(this.BJefe_Click);
            // 
            // BOperario
            // 
            this.BOperario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BOperario.Location = new System.Drawing.Point(377, 55);
            this.BOperario.Name = "BOperario";
            this.BOperario.Size = new System.Drawing.Size(98, 29);
            this.BOperario.TabIndex = 9;
            this.BOperario.Text = "Operario";
            this.BOperario.UseVisualStyleBackColor = true;
            this.BOperario.Click += new System.EventHandler(this.BOperario_Click);
            // 
            // LOculto
            // 
            this.LOculto.AutoSize = true;
            this.LOculto.Location = new System.Drawing.Point(85, 430);
            this.LOculto.Name = "LOculto";
            this.LOculto.Size = new System.Drawing.Size(38, 13);
            this.LOculto.TabIndex = 20;
            this.LOculto.Text = "Oculto";
            this.LOculto.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 462);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 571);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LOculto);
            this.Controls.Add(this.BOperario);
            this.Controls.Add(this.BJefe);
            this.Controls.Add(this.BMantenimiento);
            this.Controls.Add(this.BTodos);
            this.Controls.Add(this.BCancelar);
            this.Controls.Add(this.BAceptar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DTInc);
            this.Controls.Add(this.DTNacim);
            this.Controls.Add(this.TBEmail);
            this.Controls.Add(this.TBDNI);
            this.Controls.Add(this.TBApellido);
            this.Controls.Add(this.FechaInc);
            this.Controls.Add(this.FechaNacim);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.DNI);
            this.Controls.Add(this.Apellido);
            this.Controls.Add(this.TBNombre);
            this.Controls.Add(this.Nombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.TextBox TBNombre;
        private System.Windows.Forms.Label Apellido;
        private System.Windows.Forms.Label DNI;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label FechaNacim;
        private System.Windows.Forms.Label FechaInc;
        private System.Windows.Forms.TextBox TBApellido;
        private System.Windows.Forms.TextBox TBDNI;
        private System.Windows.Forms.TextBox TBEmail;
        private System.Windows.Forms.DateTimePicker DTNacim;
        private System.Windows.Forms.DateTimePicker DTInc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button BAceptar;
        private System.Windows.Forms.Button BCancelar;
        private System.Windows.Forms.Button BTodos;
        private System.Windows.Forms.Button BMantenimiento;
        private System.Windows.Forms.Button BJefe;
        private System.Windows.Forms.Button BOperario;
        private System.Windows.Forms.Label LOculto;
        private System.Windows.Forms.Label label2;
    }
}

