using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilletesAutobus
{
    public partial class Form4 : Form
    {
        List<Usuarios> l;
        public Form4()
        {
            InitializeComponent();
        }
        public Form4(List<Usuarios> lista)
        {
            this.l = lista;
            InitializeComponent();
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Usuario \t  DNI \t  em@il \t Telefono \t Plaza" + System.Environment.NewLine;
            foreach (Usuarios u in this.l)
                {
                textBox1.Text = textBox1.Text + u.ToString();
                }
        }
    }
}
