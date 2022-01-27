
namespace Autobus
{
    partial class fMostrar
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
            this.tbMostrar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbMostrar
            // 
            this.tbMostrar.Enabled = false;
            this.tbMostrar.Location = new System.Drawing.Point(12, 12);
            this.tbMostrar.Multiline = true;
            this.tbMostrar.Name = "tbMostrar";
            this.tbMostrar.Size = new System.Drawing.Size(565, 426);
            this.tbMostrar.TabIndex = 0;
            // 
            // fMostrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 450);
            this.Controls.Add(this.tbMostrar);
            this.Name = "fMostrar";
            this.Text = "fMostrar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbMostrar;
    }
}