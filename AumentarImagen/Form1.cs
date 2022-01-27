using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AumentarImagen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {  
            pictureBox1.Size = new Size(pictureBox1.Size.Width+10, pictureBox1.Size.Height+10);
            pictureBox1.Location = new Point(pictureBox1.Location.X-5,pictureBox1.Location.Y-5 );
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
           /* int X, Y;
            X = pictureBox1.Location.X;
            Y = pictureBox1.Location.Y;

            Y = Y + 10;
            pictureBox1.Location = new Point(X, Y);*/
            pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y + 10);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            /* int X, Y;
             X = pictureBox1.Location.X;
             Y = pictureBox1.Location.Y;

             X = X + 10;
             pictureBox1.Location = new Point(X, Y);*/
            pictureBox1.Location = new Point(pictureBox1.Location.X+10, pictureBox1.Location.Y);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(pictureBox1.Location.X - 10, pictureBox1.Location.Y);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y - 10);

        }

        private void button6_Click(object sender, EventArgs e)
        {
           /* int J, N;
            J = pictureBox1.Size.Width;
            N = pictureBox1.Size.Height;

            J = J - 10;
            N = N - 10;

            pictureBox1.Size = new Size(J, N);*/
            pictureBox1.Size = new Size(pictureBox1.Size.Width - 10, pictureBox1.Size.Height - 10);
            pictureBox1.Location = new Point(pictureBox1.Location.X + 5, pictureBox1.Location.Y + 5);


        }
    }
}
