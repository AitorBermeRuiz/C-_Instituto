
namespace Examen1Trimestre
{
    partial class fRegistro
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
            this.lUser = new System.Windows.Forms.Label();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.lPass = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lName = new System.Windows.Forms.Label();
            this.lFechaNacim = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.bGaurdar = new System.Windows.Forms.Button();
            this.bVolver = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // lUser
            // 
            this.lUser.AutoSize = true;
            this.lUser.Location = new System.Drawing.Point(33, 45);
            this.lUser.Name = "lUser";
            this.lUser.Size = new System.Drawing.Size(40, 13);
            this.lUser.TabIndex = 0;
            this.lUser.Text = "USER:";
            // 
            // tbUser
            // 
            this.tbUser.Location = new System.Drawing.Point(95, 42);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(124, 20);
            this.tbUser.TabIndex = 1;
            this.tbUser.Validating += new System.ComponentModel.CancelEventHandler(this.validating_CampoVacio);
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(371, 42);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(124, 20);
            this.tbPass.TabIndex = 3;
            this.tbPass.Validating += new System.ComponentModel.CancelEventHandler(this.validating_CampoVacio);
            // 
            // lPass
            // 
            this.lPass.AutoSize = true;
            this.lPass.Location = new System.Drawing.Point(309, 45);
            this.lPass.Name = "lPass";
            this.lPass.Size = new System.Drawing.Size(33, 13);
            this.lPass.TabIndex = 2;
            this.lPass.Text = "Pass:";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(95, 113);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(242, 20);
            this.tbName.TabIndex = 5;
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Location = new System.Drawing.Point(33, 116);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(47, 13);
            this.lName.TabIndex = 4;
            this.lName.Text = "Nombre:";
            // 
            // lFechaNacim
            // 
            this.lFechaNacim.AutoSize = true;
            this.lFechaNacim.Location = new System.Drawing.Point(33, 180);
            this.lFechaNacim.Name = "lFechaNacim";
            this.lFechaNacim.Size = new System.Drawing.Size(109, 13);
            this.lFechaNacim.TabIndex = 6;
            this.lFechaNacim.Text = "Fecha de nacimiento:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(157, 180);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 7;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.comprobarEdad);
            // 
            // bGaurdar
            // 
            this.bGaurdar.Location = new System.Drawing.Point(282, 257);
            this.bGaurdar.Name = "bGaurdar";
            this.bGaurdar.Size = new System.Drawing.Size(75, 23);
            this.bGaurdar.TabIndex = 8;
            this.bGaurdar.Text = "GUARDAR";
            this.bGaurdar.UseVisualStyleBackColor = true;
            this.bGaurdar.Click += new System.EventHandler(this.bGaurdar_Click);
            // 
            // bVolver
            // 
            this.bVolver.Location = new System.Drawing.Point(420, 257);
            this.bVolver.Name = "bVolver";
            this.bVolver.Size = new System.Drawing.Size(75, 23);
            this.bVolver.TabIndex = 9;
            this.bVolver.Text = "VOLVER";
            this.bVolver.UseVisualStyleBackColor = true;
            this.bVolver.Click += new System.EventHandler(this.bVolver_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // fRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 329);
            this.Controls.Add(this.bVolver);
            this.Controls.Add(this.bGaurdar);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lFechaNacim);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lName);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.lPass);
            this.Controls.Add(this.tbUser);
            this.Controls.Add(this.lUser);
            this.Name = "fRegistro";
            this.Text = "fRegistro";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lUser;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.Label lPass;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.Label lFechaNacim;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button bGaurdar;
        private System.Windows.Forms.Button bVolver;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}