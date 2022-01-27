using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static int Op1, Op2, Result;
        static String Operador;
        private void B1_Click(object sender, EventArgs e)
        {
            Quitar0("1");
        }
        private void Quitar0(String i)
        {
            if(LPantalla.Text == "0")
                LPantalla.Text = i;
            else
                LPantalla.Text += i;
        }
        private void operador(object sender, EventArgs e)
        {
            Op1 = Int32.Parse(LPantalla.Text);
            Button boton = (Button) sender;
            Operador = boton.Text;
            LPantalla.Text = "0";

        }
        private void click(object sender, EventArgs e)
        {
            Button buton = (Button)sender;
            String txt = buton.Text;
            Quitar0(txt);
        }
       
       

        private void BIgual_Click(object sender, EventArgs e)
        {
            Op2 = Int32.Parse(LPantalla.Text);
            if (Op1 <= 0 || Op2 <= 0)
            {
                BIgual.Enabled = false;
            } else
            {
                switch (Operador)
                {
                    case "+": {
                            Result = Op1 + Op2;
                            break;
                        }
                    case "-":
                        {
                            Result = Op1 - Op2;
                            break;
                        }
                    case "*":
                        {
                            Result = Op1 * Op2;
                            break;
                        }
                    case "/":
                        {
                            Result = Op1 / Op2;
                            break;
                        }
                }
                LPantalla.Text = Result.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


    }
}
