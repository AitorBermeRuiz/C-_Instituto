
namespace Calculadora
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
            this.Pantalla = new System.Windows.Forms.GroupBox();
            this.LPantalla = new System.Windows.Forms.Label();
            this.B1 = new System.Windows.Forms.Button();
            this.B2 = new System.Windows.Forms.Button();
            this.B3 = new System.Windows.Forms.Button();
            this.B4 = new System.Windows.Forms.Button();
            this.B5 = new System.Windows.Forms.Button();
            this.B6 = new System.Windows.Forms.Button();
            this.B7 = new System.Windows.Forms.Button();
            this.B8 = new System.Windows.Forms.Button();
            this.B9 = new System.Windows.Forms.Button();
            this.B0 = new System.Windows.Forms.Button();
            this.BC = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.BIgual = new System.Windows.Forms.Button();
            this.BDividir = new System.Windows.Forms.Button();
            this.BMultiplicar = new System.Windows.Forms.Button();
            this.Brestar = new System.Windows.Forms.Button();
            this.BSumar = new System.Windows.Forms.Button();
            this.Pantalla.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pantalla
            // 
            this.Pantalla.Controls.Add(this.LPantalla);
            this.Pantalla.Location = new System.Drawing.Point(13, 13);
            this.Pantalla.Name = "Pantalla";
            this.Pantalla.Size = new System.Drawing.Size(358, 42);
            this.Pantalla.TabIndex = 0;
            this.Pantalla.TabStop = false;
            this.Pantalla.Text = "Pantalla";
            // 
            // LPantalla
            // 
            this.LPantalla.Location = new System.Drawing.Point(61, 10);
            this.LPantalla.Name = "LPantalla";
            this.LPantalla.Size = new System.Drawing.Size(297, 29);
            this.LPantalla.TabIndex = 0;
            this.LPantalla.Text = "0";
            this.LPantalla.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // B1
            // 
            this.B1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.B1.Location = new System.Drawing.Point(12, 195);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(68, 47);
            this.B1.TabIndex = 1;
            this.B1.Text = "1";
            this.B1.UseVisualStyleBackColor = true;
            this.B1.Click += new System.EventHandler(this.click);
            // 
            // B2
            // 
            this.B2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.B2.Location = new System.Drawing.Point(99, 195);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(68, 47);
            this.B2.TabIndex = 2;
            this.B2.Text = "2";
            this.B2.UseVisualStyleBackColor = true;
            this.B2.Click += new System.EventHandler(this.click);
            // 
            // B3
            // 
            this.B3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.B3.Location = new System.Drawing.Point(186, 195);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(68, 47);
            this.B3.TabIndex = 3;
            this.B3.Text = "3";
            this.B3.UseVisualStyleBackColor = true;
            this.B3.Click += new System.EventHandler(this.click);
            // 
            // B4
            // 
            this.B4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.B4.Location = new System.Drawing.Point(13, 128);
            this.B4.Name = "B4";
            this.B4.Size = new System.Drawing.Size(68, 47);
            this.B4.TabIndex = 4;
            this.B4.Text = "4";
            this.B4.UseVisualStyleBackColor = true;
            this.B4.Click += new System.EventHandler(this.click);
            // 
            // B5
            // 
            this.B5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.B5.Location = new System.Drawing.Point(99, 128);
            this.B5.Name = "B5";
            this.B5.Size = new System.Drawing.Size(68, 47);
            this.B5.TabIndex = 5;
            this.B5.Text = "5";
            this.B5.UseVisualStyleBackColor = true;
            this.B5.Click += new System.EventHandler(this.click);
            // 
            // B6
            // 
            this.B6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.B6.Location = new System.Drawing.Point(186, 128);
            this.B6.Name = "B6";
            this.B6.Size = new System.Drawing.Size(68, 47);
            this.B6.TabIndex = 6;
            this.B6.Text = "6";
            this.B6.UseVisualStyleBackColor = true;
            this.B6.Click += new System.EventHandler(this.click);
            // 
            // B7
            // 
            this.B7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.B7.Location = new System.Drawing.Point(13, 61);
            this.B7.Name = "B7";
            this.B7.Size = new System.Drawing.Size(68, 47);
            this.B7.TabIndex = 7;
            this.B7.Text = "7";
            this.B7.UseVisualStyleBackColor = true;
            this.B7.Click += new System.EventHandler(this.click);
            // 
            // B8
            // 
            this.B8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.B8.Location = new System.Drawing.Point(99, 61);
            this.B8.Name = "B8";
            this.B8.Size = new System.Drawing.Size(68, 47);
            this.B8.TabIndex = 8;
            this.B8.Text = "8";
            this.B8.UseVisualStyleBackColor = true;
            this.B8.Click += new System.EventHandler(this.click);
            // 
            // B9
            // 
            this.B9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.B9.Location = new System.Drawing.Point(186, 61);
            this.B9.Name = "B9";
            this.B9.Size = new System.Drawing.Size(68, 47);
            this.B9.TabIndex = 9;
            this.B9.Text = "9";
            this.B9.UseVisualStyleBackColor = true;
            this.B9.Click += new System.EventHandler(this.click);
            // 
            // B0
            // 
            this.B0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.B0.Location = new System.Drawing.Point(13, 262);
            this.B0.Name = "B0";
            this.B0.Size = new System.Drawing.Size(241, 47);
            this.B0.TabIndex = 10;
            this.B0.Text = "0";
            this.B0.UseVisualStyleBackColor = true;
            this.B0.Click += new System.EventHandler(this.click);
            // 
            // BC
            // 
            this.BC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BC.Location = new System.Drawing.Point(43, 325);
            this.BC.Name = "BC";
            this.BC.Size = new System.Drawing.Size(68, 47);
            this.BC.TabIndex = 11;
            this.BC.Text = "C";
            this.BC.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(145, 325);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 47);
            this.button1.TabIndex = 12;
            this.button1.Text = "CE";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // BIgual
            // 
            this.BIgual.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BIgual.Location = new System.Drawing.Point(303, 325);
            this.BIgual.Name = "BIgual";
            this.BIgual.Size = new System.Drawing.Size(68, 47);
            this.BIgual.TabIndex = 13;
            this.BIgual.Text = "=";
            this.BIgual.UseVisualStyleBackColor = true;
            this.BIgual.Click += new System.EventHandler(this.BIgual_Click);
            // 
            // BDividir
            // 
            this.BDividir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BDividir.Location = new System.Drawing.Point(303, 262);
            this.BDividir.Name = "BDividir";
            this.BDividir.Size = new System.Drawing.Size(68, 47);
            this.BDividir.TabIndex = 14;
            this.BDividir.Text = "/";
            this.BDividir.UseVisualStyleBackColor = true;
            this.BDividir.Click += new System.EventHandler(this.operador);
            // 
            // BMultiplicar
            // 
            this.BMultiplicar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BMultiplicar.Location = new System.Drawing.Point(303, 195);
            this.BMultiplicar.Name = "BMultiplicar";
            this.BMultiplicar.Size = new System.Drawing.Size(68, 47);
            this.BMultiplicar.TabIndex = 15;
            this.BMultiplicar.Text = "*";
            this.BMultiplicar.UseVisualStyleBackColor = true;
            this.BMultiplicar.Click += new System.EventHandler(this.operador);
            // 
            // Brestar
            // 
            this.Brestar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Brestar.Location = new System.Drawing.Point(303, 128);
            this.Brestar.Name = "Brestar";
            this.Brestar.Size = new System.Drawing.Size(68, 47);
            this.Brestar.TabIndex = 16;
            this.Brestar.Text = "-";
            this.Brestar.UseVisualStyleBackColor = true;
            this.Brestar.Click += new System.EventHandler(this.operador);
            // 
            // BSumar
            // 
            this.BSumar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BSumar.Location = new System.Drawing.Point(303, 61);
            this.BSumar.Name = "BSumar";
            this.BSumar.Size = new System.Drawing.Size(68, 47);
            this.BSumar.TabIndex = 17;
            this.BSumar.Text = "+";
            this.BSumar.UseVisualStyleBackColor = true;
            this.BSumar.Click += new System.EventHandler(this.operador);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 450);
            this.Controls.Add(this.BSumar);
            this.Controls.Add(this.Brestar);
            this.Controls.Add(this.BMultiplicar);
            this.Controls.Add(this.BDividir);
            this.Controls.Add(this.BIgual);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BC);
            this.Controls.Add(this.B0);
            this.Controls.Add(this.B9);
            this.Controls.Add(this.B8);
            this.Controls.Add(this.B7);
            this.Controls.Add(this.B6);
            this.Controls.Add(this.B5);
            this.Controls.Add(this.B4);
            this.Controls.Add(this.B3);
            this.Controls.Add(this.B2);
            this.Controls.Add(this.B1);
            this.Controls.Add(this.Pantalla);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Pantalla.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Pantalla;
        private System.Windows.Forms.Label LPantalla;
        private System.Windows.Forms.Button B1;
        private System.Windows.Forms.Button B2;
        private System.Windows.Forms.Button B3;
        private System.Windows.Forms.Button B4;
        private System.Windows.Forms.Button B5;
        private System.Windows.Forms.Button B6;
        private System.Windows.Forms.Button B7;
        private System.Windows.Forms.Button B8;
        private System.Windows.Forms.Button B9;
        private System.Windows.Forms.Button B0;
        private System.Windows.Forms.Button BC;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BIgual;
        private System.Windows.Forms.Button BDividir;
        private System.Windows.Forms.Button BMultiplicar;
        private System.Windows.Forms.Button Brestar;
        private System.Windows.Forms.Button BSumar;
    }
}

