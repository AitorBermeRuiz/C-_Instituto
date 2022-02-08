
namespace DonacionesSangre
{
    partial class NuevoDonante
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
            this.lNombre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lDNI = new System.Windows.Forms.Label();
            this.lFactor = new System.Windows.Forms.Label();
            this.lGrupo = new System.Windows.Forms.Label();
            this.rd0 = new System.Windows.Forms.RadioButton();
            this.rdB = new System.Windows.Forms.RadioButton();
            this.rdA = new System.Windows.Forms.RadioButton();
            this.rdAB = new System.Windows.Forms.RadioButton();
            this.flGrupo = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.rdPositive = new System.Windows.Forms.RadioButton();
            this.rdNegative = new System.Windows.Forms.RadioButton();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbTelefono = new System.Windows.Forms.TextBox();
            this.tbDni = new System.Windows.Forms.TextBox();
            this.bGuardar = new System.Windows.Forms.Button();
            this.bCancelar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.flGrupo.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lNombre
            // 
            this.lNombre.AutoSize = true;
            this.lNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNombre.Location = new System.Drawing.Point(12, 63);
            this.lNombre.Name = "lNombre";
            this.lNombre.Size = new System.Drawing.Size(60, 16);
            this.lNombre.TabIndex = 0;
            this.lNombre.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Telefono:";
            // 
            // lDNI
            // 
            this.lDNI.AutoSize = true;
            this.lDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDNI.Location = new System.Drawing.Point(12, 20);
            this.lDNI.Name = "lDNI";
            this.lDNI.Size = new System.Drawing.Size(34, 16);
            this.lDNI.TabIndex = 3;
            this.lDNI.Text = "DNI:";
            // 
            // lFactor
            // 
            this.lFactor.AutoSize = true;
            this.lFactor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lFactor.Location = new System.Drawing.Point(13, 210);
            this.lFactor.Name = "lFactor";
            this.lFactor.Size = new System.Drawing.Size(49, 16);
            this.lFactor.TabIndex = 4;
            this.lFactor.Text = "Factor:";
            // 
            // lGrupo
            // 
            this.lGrupo.AutoSize = true;
            this.lGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lGrupo.Location = new System.Drawing.Point(13, 156);
            this.lGrupo.Name = "lGrupo";
            this.lGrupo.Size = new System.Drawing.Size(48, 16);
            this.lGrupo.TabIndex = 5;
            this.lGrupo.Text = "Grupo:";
            // 
            // rd0
            // 
            this.rd0.AutoSize = true;
            this.rd0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd0.Location = new System.Drawing.Point(3, 3);
            this.rd0.Name = "rd0";
            this.rd0.Size = new System.Drawing.Size(33, 20);
            this.rd0.TabIndex = 6;
            this.rd0.Text = "0";
            this.rd0.UseVisualStyleBackColor = true;
            // 
            // rdB
            // 
            this.rdB.AutoSize = true;
            this.rdB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdB.Location = new System.Drawing.Point(83, 3);
            this.rdB.Name = "rdB";
            this.rdB.Size = new System.Drawing.Size(35, 20);
            this.rdB.TabIndex = 7;
            this.rdB.Text = "B";
            this.rdB.UseVisualStyleBackColor = true;
            // 
            // rdA
            // 
            this.rdA.AutoSize = true;
            this.rdA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdA.Location = new System.Drawing.Point(42, 3);
            this.rdA.Name = "rdA";
            this.rdA.Size = new System.Drawing.Size(35, 20);
            this.rdA.TabIndex = 8;
            this.rdA.Text = "A";
            this.rdA.UseVisualStyleBackColor = true;
            // 
            // rdAB
            // 
            this.rdAB.AutoSize = true;
            this.rdAB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdAB.Location = new System.Drawing.Point(124, 3);
            this.rdAB.Name = "rdAB";
            this.rdAB.Size = new System.Drawing.Size(44, 20);
            this.rdAB.TabIndex = 9;
            this.rdAB.Text = "AB";
            this.rdAB.UseVisualStyleBackColor = true;
            // 
            // flGrupo
            // 
            this.flGrupo.Controls.Add(this.rd0);
            this.flGrupo.Controls.Add(this.rdA);
            this.flGrupo.Controls.Add(this.rdB);
            this.flGrupo.Controls.Add(this.rdAB);
            this.flGrupo.Location = new System.Drawing.Point(77, 156);
            this.flGrupo.Name = "flGrupo";
            this.flGrupo.Size = new System.Drawing.Size(172, 27);
            this.flGrupo.TabIndex = 10;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.rdPositive);
            this.flowLayoutPanel2.Controls.Add(this.rdNegative);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(76, 210);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(75, 27);
            this.flowLayoutPanel2.TabIndex = 11;
            // 
            // rdPositive
            // 
            this.rdPositive.AutoSize = true;
            this.rdPositive.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdPositive.Location = new System.Drawing.Point(3, 3);
            this.rdPositive.Name = "rdPositive";
            this.rdPositive.Size = new System.Drawing.Size(33, 20);
            this.rdPositive.TabIndex = 6;
            this.rdPositive.TabStop = true;
            this.rdPositive.Text = "+";
            this.rdPositive.UseVisualStyleBackColor = true;
            // 
            // rdNegative
            // 
            this.rdNegative.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdNegative.AutoSize = true;
            this.rdNegative.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdNegative.Location = new System.Drawing.Point(42, 3);
            this.rdNegative.Name = "rdNegative";
            this.rdNegative.Size = new System.Drawing.Size(30, 20);
            this.rdNegative.TabIndex = 8;
            this.rdNegative.TabStop = true;
            this.rdNegative.Text = "-";
            this.rdNegative.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rdNegative.UseVisualStyleBackColor = true;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(77, 63);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(172, 20);
            this.tbNombre.TabIndex = 13;
            this.tbNombre.Validating += new System.ComponentModel.CancelEventHandler(this.validacion);
            // 
            // tbTelefono
            // 
            this.tbTelefono.Location = new System.Drawing.Point(76, 107);
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.Size = new System.Drawing.Size(172, 20);
            this.tbTelefono.TabIndex = 14;
            // 
            // tbDni
            // 
            this.tbDni.Location = new System.Drawing.Point(77, 12);
            this.tbDni.Name = "tbDni";
            this.tbDni.Size = new System.Drawing.Size(172, 20);
            this.tbDni.TabIndex = 15;
            this.tbDni.Validating += new System.ComponentModel.CancelEventHandler(this.validacion);
            // 
            // bGuardar
            // 
            this.bGuardar.Location = new System.Drawing.Point(54, 274);
            this.bGuardar.Name = "bGuardar";
            this.bGuardar.Size = new System.Drawing.Size(75, 23);
            this.bGuardar.TabIndex = 16;
            this.bGuardar.Text = "Guardar";
            this.bGuardar.UseVisualStyleBackColor = true;
            this.bGuardar.Click += new System.EventHandler(this.bGuardar_Click);
            // 
            // bCancelar
            // 
            this.bCancelar.Location = new System.Drawing.Point(160, 274);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(75, 23);
            this.bCancelar.TabIndex = 17;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // NuevoDonante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 343);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.bGuardar);
            this.Controls.Add(this.tbDni);
            this.Controls.Add(this.tbTelefono);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flGrupo);
            this.Controls.Add(this.lGrupo);
            this.Controls.Add(this.lFactor);
            this.Controls.Add(this.lDNI);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lNombre);
            this.Name = "NuevoDonante";
            this.Text = "NuevoDonante";
            this.flGrupo.ResumeLayout(false);
            this.flGrupo.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lDNI;
        private System.Windows.Forms.Label lFactor;
        private System.Windows.Forms.Label lGrupo;
        private System.Windows.Forms.RadioButton rd0;
        private System.Windows.Forms.RadioButton rdB;
        private System.Windows.Forms.RadioButton rdA;
        private System.Windows.Forms.RadioButton rdAB;
        private System.Windows.Forms.FlowLayoutPanel flGrupo;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.RadioButton rdPositive;
        private System.Windows.Forms.RadioButton rdNegative;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbTelefono;
        private System.Windows.Forms.TextBox tbDni;
        private System.Windows.Forms.Button bGuardar;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}