using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;

namespace SBanco
{
    public partial class Form1 : Form
    {
        CClientes[] woaClientes = new CClientes[1];
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String texto = "";

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            for (int i = 0; i < woaClientes.Length -1; i++)
            {
                texto =texto+ woaClientes[i].ToString() +"\n";
                
            }
            label4.Text = texto;
            label4.Visible = true;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                String wsTitular = textBox1.Text;
                int wiCuenta = Convert.ToInt32(textBox2.Text);
                long wlSaldo = Convert.ToInt64(textBox3.Text);

                woaClientes[woaClientes.Length - 1] = new CClientes(wsTitular, wiCuenta, wlSaldo);
                Array.Resize(ref woaClientes, woaClientes.Length + 1);
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();

                if (label4.Visible == true)
                {
                    label4.Visible = false;
                }
            }
            catch (Exception IOe)
            {
                label4.Visible = true;
                label4.Text = "Error, Datos incorrectos";
            }

        } 

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }
    }
    public class CClientes
    {
        String psTitular;
        int piCuenta;
        long plSaldo;

        public CClientes(String isTitular, int iiCuenta, long ilSaldo)
        {
            psTitular = isTitular;
            piCuenta  = iiCuenta;
            plSaldo   = ilSaldo;
            
        }

        public String ToString()
        {
            return ("Titular: " + psTitular + "\t Cuenta: " + piCuenta + "\t Saldo: " + plSaldo);
        }
    }
}
