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
    public partial class Form2 : Form
    {
        //ArrayList listaUsuarios = new ArrayList();
        private Form1 principal;
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(Form1 f)
        {
            InitializeComponent();
            this.principal = f;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //validaciones();
            registrarUsuario();
        }

        public void registrarUsuario()
        {
            String nombre = tbNombre.Text;
            String dni = tbDNI.Text;
            int telefono = int.Parse(tbTelefono.Text);
            String email = tbEmail.Text;
            if (!this.principal.dniRepetido(dni))
            {
                Usuarios usuario = new Usuarios(nombre, dni, telefono, email);
                this.principal.annadeUsuario(usuario);
            }
            else 
            {
                MessageBox.Show("Usuario existente");
            }
            this.Close();
            //return usuario;
        }

        public void validaciones()
        {
            //Usuarios nuevoUsuario = registrarUsuario();
            //bool existe = false;
            //bool emailCorrecto = false;

            //foreach(Usuarios usuario in listaUsuarios)
            //{
            //    if (nuevoUsuario.getDNI().Equals(usuario.getDNI()))
            //    {
            //        existe = true;
            //    }
            //    else
            //    {
            //        if (!tbEmail.Text.Contains("@"))
            //        {
            //            emailCorrecto = true;
            //        }
            //    }


            //}

            //if (existe)
            //{
            //    MessageBox.Show("Ese usuario ya existe");
            //}
            //else
            //{
            //    if (emailCorrecto)
            //    {
            //        MessageBox.Show("Debe introducir un email correcto");
            //    }
            //    else
            //    {
            //        listaUsuarios.Add(nuevoUsuario);
            //        MessageBox.Show("Usuario Registrado");

            //        vaciarCeldas();
            //    }
            //}

        }

        //public void vaciarCeldas()
        //{
        //    tbNombre.Text = " ";
        //    tbDNI.Text = " ";
        //    tbTelefono.Text = "";
        //    tbEmail.Text = " ";
        //}

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
