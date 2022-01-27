using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Autobus
{
    public partial class Form1 : Form
    {
        List<Usuarios> lUsuarios = new List<Usuarios>();
        public Form1()
        {
            InitializeComponent();
        }

        private void BRegistro_Click(object sender, EventArgs e)
        {
            FRegistroUsuarios fRegistros = new FRegistroUsuarios(this);
            fRegistros.Show();
        }

        public void AgegarUsuarios(Usuarios usr)
        {
            if (!ComprobarDni(usr))
                lUsuarios.Add(usr);
            else
                MessageBox.Show("DNI Repetido!!!");

        }
        public Boolean ComprobarDni(Usuarios usr)
        {
            Boolean dniRepetido = false;
            foreach (Usuarios comprobar in lUsuarios)
            {
                if (usr.GetDni() == comprobar.GetDni())
                    dniRepetido = true;
            }
            return  dniRepetido;
        }
        public void ComprarBillete(String dni, int numAsiento)
        {
            Boolean dniEncontrado = false, asientoOcupado = false;
            foreach (Usuarios comprobar in lUsuarios)
            {
                if (dni == comprobar.GetDni())
                {
                    dniEncontrado = true;

                    foreach (Usuarios asientosRepetidos in lUsuarios)
                    {
                        if (numAsiento == asientosRepetidos.GetNumAsientos())
                        {
                            asientoOcupado = true;
                        }
                    }
                    if (asientoOcupado == true)
                    {
                        MessageBox.Show("Asiento ocupado");
                    }
                    else
                    {
                        comprobar.SetNumAsientos(numAsiento);
                    }
                }
            }
            if (dniEncontrado == false)
            {
                MessageBox.Show("DNI No registrado.!!");
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void BComprobacion_Click(object sender, EventArgs e)
        {
            fMostrar fMostrar = new fMostrar(lUsuarios);
            fMostrar.Show();
        }

        private void BComprar_Click(object sender, EventArgs e)
        {
            Comprar_Billete fCopmprarBillete = new Comprar_Billete(this);
            fCopmprarBillete.Show();
        }
    }
}
