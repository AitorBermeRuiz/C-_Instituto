using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FechasNacimiento
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime f = dateTimePicker1.Value;
            DateTime a = DateTime.Today;
            label3.Text = (f.Day.ToString() + "/" + f.Month+"/"+a.Year);

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime i = monthCalendar1.SelectionStart;
            DateTime f = monthCalendar1.SelectionEnd;
            SelectionRange numdias = monthCalendar1.SelectionRange;

            int dias =  f.Day - i.Day +1;
            label8.Text = i.Day.ToString() +"/"+i.Month.ToString() +"/"+ i.Year.ToString();
            label5.Text = f.ToString();
            label9.Text = dias.ToString();
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
