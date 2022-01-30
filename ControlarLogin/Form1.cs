using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlarLogin
{
    public partial class Form1 : Form
    {
        int contador = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String TextLogin = textBox1.Text;
            String TextPaswd = textBox2.Text;

           
            

                if (TextLogin == "usr1" && TextPaswd == "1234")
                    textBox3.Text = "Hola " + TextLogin + " tu contraseña es: " + TextPaswd;
                else if (TextLogin == "usr1" && TextPaswd != "1234")
                {
                    textBox3.Text = "Contraseña Incorrecta";
                    contador++;
                }
                else
                {
                    textBox3.Text = "Credenciales Incorrectas";
                    contador++;
                }
            if (contador >= 3)
                this.Close();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
