using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autobus
{
    public partial class Comprar_Billete : Form
    {
        Form1 f1;
        public Comprar_Billete(Form1 f1)
        {
            InitializeComponent();
            this.f1 = f1;
        }

        private void bRegistrar_Click(object sender, EventArgs e)
        {
            String dni = tbDNI.Text;
            int numAsiento = Int32.Parse(tbNumAsiento.Text);
            f1.ComprarBillete(dni, numAsiento);
        }
    }
}
