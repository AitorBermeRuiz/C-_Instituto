
namespace GestionInstituto
{
    partial class fAltaAlumno
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
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbApellidos = new System.Windows.Forms.TextBox();
            this.lApellidos = new System.Windows.Forms.Label();
            this.tbMain = new System.Windows.Forms.TextBox();
            this.lMail = new System.Windows.Forms.Label();
            this.tbDni = new System.Windows.Forms.TextBox();
            this.lDni = new System.Windows.Forms.Label();
            this.combobCurso = new System.Windows.Forms.ComboBox();
            this.lCurso = new System.Windows.Forms.Label();
            this.lModulos = new System.Windows.Forms.Label();
            this.checkedLb1DAM = new System.Windows.Forms.CheckedListBox();
            this.checkedLb2DAM = new System.Windows.Forms.CheckedListBox();
            this.bAdd = new System.Windows.Forms.Button();
            this.bCancelar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lNombre
            // 
            this.lNombre.AutoSize = true;
            this.lNombre.Location = new System.Drawing.Point(12, 36);
            this.lNombre.Name = "lNombre";
            this.lNombre.Size = new System.Drawing.Size(47, 13);
            this.lNombre.TabIndex = 0;
            this.lNombre.Text = "Nombre:";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(70, 33);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(160, 20);
            this.tbNombre.TabIndex = 1;
            // 
            // tbApellidos
            // 
            this.tbApellidos.Location = new System.Drawing.Point(70, 71);
            this.tbApellidos.Name = "tbApellidos";
            this.tbApellidos.Size = new System.Drawing.Size(160, 20);
            this.tbApellidos.TabIndex = 7;
            // 
            // lApellidos
            // 
            this.lApellidos.AutoSize = true;
            this.lApellidos.Location = new System.Drawing.Point(12, 74);
            this.lApellidos.Name = "lApellidos";
            this.lApellidos.Size = new System.Drawing.Size(52, 13);
            this.lApellidos.TabIndex = 6;
            this.lApellidos.Text = "Apellidos:";
            // 
            // tbMain
            // 
            this.tbMain.Location = new System.Drawing.Point(70, 147);
            this.tbMain.Name = "tbMain";
            this.tbMain.Size = new System.Drawing.Size(160, 20);
            this.tbMain.TabIndex = 11;
            // 
            // lMail
            // 
            this.lMail.AutoSize = true;
            this.lMail.Location = new System.Drawing.Point(12, 150);
            this.lMail.Name = "lMail";
            this.lMail.Size = new System.Drawing.Size(29, 13);
            this.lMail.TabIndex = 10;
            this.lMail.Text = "Mail:";
            // 
            // tbDni
            // 
            this.tbDni.Location = new System.Drawing.Point(70, 109);
            this.tbDni.Name = "tbDni";
            this.tbDni.Size = new System.Drawing.Size(160, 20);
            this.tbDni.TabIndex = 9;
            // 
            // lDni
            // 
            this.lDni.AutoSize = true;
            this.lDni.Location = new System.Drawing.Point(12, 112);
            this.lDni.Name = "lDni";
            this.lDni.Size = new System.Drawing.Size(29, 13);
            this.lDni.TabIndex = 8;
            this.lDni.Text = "DNI:";
            // 
            // combobCurso
            // 
            this.combobCurso.FormattingEnabled = true;
            this.combobCurso.Items.AddRange(new object[] {
            "1º DAM A",
            "1º DAM B",
            "2º DAM A",
            "2º DAM B"});
            this.combobCurso.Location = new System.Drawing.Point(334, 32);
            this.combobCurso.Name = "combobCurso";
            this.combobCurso.Size = new System.Drawing.Size(121, 21);
            this.combobCurso.TabIndex = 12;
            this.combobCurso.SelectedIndexChanged += new System.EventHandler(this.combobCurso_SelectedIndexChanged);
            // 
            // lCurso
            // 
            this.lCurso.AutoSize = true;
            this.lCurso.Location = new System.Drawing.Point(265, 36);
            this.lCurso.Name = "lCurso";
            this.lCurso.Size = new System.Drawing.Size(37, 13);
            this.lCurso.TabIndex = 13;
            this.lCurso.Text = "Curso:";
            // 
            // lModulos
            // 
            this.lModulos.AutoSize = true;
            this.lModulos.Location = new System.Drawing.Point(265, 74);
            this.lModulos.Name = "lModulos";
            this.lModulos.Size = new System.Drawing.Size(50, 13);
            this.lModulos.TabIndex = 14;
            this.lModulos.Text = "Modulos:";
            // 
            // checkedLb1DAM
            // 
            this.checkedLb1DAM.FormattingEnabled = true;
            this.checkedLb1DAM.Items.AddRange(new object[] {
            "Programación",
            "BBDD",
            "Entornos",
            "Marcas"});
            this.checkedLb1DAM.Location = new System.Drawing.Point(334, 74);
            this.checkedLb1DAM.Name = "checkedLb1DAM";
            this.checkedLb1DAM.Size = new System.Drawing.Size(120, 64);
            this.checkedLb1DAM.TabIndex = 15;
            this.checkedLb1DAM.Visible = false;
            // 
            // checkedLb2DAM
            // 
            this.checkedLb2DAM.FormattingEnabled = true;
            this.checkedLb2DAM.Items.AddRange(new object[] {
            "Interfaces",
            "Moviles",
            "Procesos",
            "Acceso a datos"});
            this.checkedLb2DAM.Location = new System.Drawing.Point(335, 74);
            this.checkedLb2DAM.Name = "checkedLb2DAM";
            this.checkedLb2DAM.Size = new System.Drawing.Size(120, 64);
            this.checkedLb2DAM.TabIndex = 16;
            this.checkedLb2DAM.Visible = false;
            // 
            // bAdd
            // 
            this.bAdd.Location = new System.Drawing.Point(55, 213);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(75, 23);
            this.bAdd.TabIndex = 17;
            this.bAdd.Text = "Añadir";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // bCancelar
            // 
            this.bCancelar.Location = new System.Drawing.Point(178, 213);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(75, 23);
            this.bCancelar.TabIndex = 18;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // fAltaAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 251);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.checkedLb2DAM);
            this.Controls.Add(this.checkedLb1DAM);
            this.Controls.Add(this.lModulos);
            this.Controls.Add(this.lCurso);
            this.Controls.Add(this.combobCurso);
            this.Controls.Add(this.tbMain);
            this.Controls.Add(this.lMail);
            this.Controls.Add(this.tbDni);
            this.Controls.Add(this.lDni);
            this.Controls.Add(this.tbApellidos);
            this.Controls.Add(this.lApellidos);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.lNombre);
            this.Name = "fAltaAlumno";
            this.Text = "Alta Alumno";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lNombre;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbApellidos;
        private System.Windows.Forms.Label lApellidos;
        private System.Windows.Forms.TextBox tbMain;
        private System.Windows.Forms.Label lMail;
        private System.Windows.Forms.TextBox tbDni;
        private System.Windows.Forms.Label lDni;
        private System.Windows.Forms.ComboBox combobCurso;
        private System.Windows.Forms.Label lCurso;
        private System.Windows.Forms.Label lModulos;
        private System.Windows.Forms.CheckedListBox checkedLb1DAM;
        private System.Windows.Forms.CheckedListBox checkedLb2DAM;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}