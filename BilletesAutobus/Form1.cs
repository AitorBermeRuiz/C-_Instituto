using System;
using System.Collections;
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
    public partial class Form1 : Form
    {
        List<Usuarios> listaUsuarios = new List<Usuarios>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btUsuarios_Click(object sender, EventArgs e)
        {
            //Formulario registro de usuarios
            Form2 fRegistrar = new Form2(this);
            fRegistrar.Show();
        }

        private void btBilletes_Click(object sender, EventArgs e)
        {
            //Formulario compra de billetes usuarios registrados
            Form3 fComprar = new Form3();
            fComprar.Show();
        }

        private void btComprobar_Click(object sender, EventArgs e)
        {
            // Formulario muestra lista usuarios
            Form4 fMostrar = new Form4(listaUsuarios);
            fMostrar.Show();

        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public Boolean dniRepetido(String DNI)
        {
            Boolean encontrado = false; 
            foreach (Usuarios u in listaUsuarios)
            {
                if (u.getDNI() == DNI)
                {
                    encontrado = true;
                }
            }
            return encontrado;
        }
        public void annadeUsuario(Usuarios u)
        {
            listaUsuarios.Add(u);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
