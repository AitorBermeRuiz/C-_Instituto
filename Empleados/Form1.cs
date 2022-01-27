using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Empleados
{
    public partial class Form1 : Form
    {
        Empleados[] paoEmpleados = new Empleados[1];
        public Form1()
        {
            InitializeComponent();
        }

        private void Email_Click(object sender, EventArgs e)
        {

        }

        private void DTNacim_ValueChanged(object sender, EventArgs e)
        {

        }

        private void BAceptar_Click(object sender, EventArgs e)
        {
            String Nombre       = TBNombre.Text;
            String Apellido     = TBApellido.Text;
            String DNI          = TBDNI.Text;
            String Email        = TBEmail.Text;
            String Puesto       = textBox1.Text.ToLower();
            DateTime FechaNacim = DTNacim.Value;
            DateTime FechaInc   = DTInc.Value;

            if (Puesto.Equals("operario") || Puesto.Equals("jefe") || Puesto.Equals("mantenimiento"))
            {
                guardarEmpleados(Nombre, Apellido, DNI, Email, Puesto, FechaNacim, FechaInc);
                limpiar();
                label2.Visible = false;
            }else{
                label2.Text = "ERROR. Puesto tiene que ser igual a operario, jefe,mantenimiento";
                label2.Visible = true;
                textBox1.Clear();
            }
        }
        private void guardarEmpleados(String Nombre,String Apellido, String DNI,String Email,String Puesto,DateTime FechaNacim,DateTime FechaInc)
        {
            paoEmpleados[paoEmpleados.Length - 1] = new Empleados(Nombre, Apellido, DNI, Email, Puesto,
                                                                           FechaNacim, FechaInc);
            Array.Resize(ref paoEmpleados, paoEmpleados.Length + 1);
        }
        private void BCancelar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void TBNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTodos_Click(object sender, EventArgs e)
        {
            LOculto.Text = "";
            for (int i = 0; i < paoEmpleados.Length-1; ++i)
            {
                LOculto.Text= LOculto.Text+ paoEmpleados[i].toString();
            }
            LOculto.Visible = true;
        }
        private void limpiar()
        {
            TBNombre.Clear();TBApellido.Clear();TBDNI.Clear();TBEmail.Clear();textBox1.Clear();
            DTNacim.ResetText(); DTInc.ResetText();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BOperario_Click(object sender, EventArgs e)
        {
            LOculto.Text = "";
            for (int i = 0; i < paoEmpleados.Length - 1; ++i)
            { if(paoEmpleados[i].getPuesto().Equals("operario"))
                LOculto.Text += paoEmpleados[i].toString();
            }
            LOculto.Visible = true;
        }

        private void BJefe_Click(object sender, EventArgs e)
        {
            LOculto.Text = "";
            for (int i = 0; i < paoEmpleados.Length - 1; ++i)
            {
                if (paoEmpleados[i].getPuesto().Equals("jefe"))
                    LOculto.Text += paoEmpleados[i].toString();
            }
            LOculto.Visible = true;
        }

        private void BMantenimiento_Click(object sender, EventArgs e)
        {
            LOculto.Text = "";
            for (int i = 0; i < paoEmpleados.Length - 1; ++i)
            {
                if (paoEmpleados[i].getPuesto().Equals("mantenimiento"))
                    LOculto.Text +=paoEmpleados[i].toString();
            }
            LOculto.Visible = true;
        }
    }
    class Empleados
    {
        String Nombre, Apellido, DNI, Email,Puesto;
        DateTime FechaNacim, FechaIncorp;

        public Empleados(string nombre, string apellido, string dNI, string email,String puesto, DateTime fechaNacim, DateTime fechaIncorp)
        {
            Nombre      = nombre;
            Apellido    = apellido;
            DNI         = dNI;
            Email       = email;
            Puesto      = puesto;
            FechaNacim  = fechaNacim;
            FechaIncorp = fechaIncorp;
        }

        public String getPuesto()
        {
            return Puesto;
        }
        public String toString()
        {
            return Nombre + ", " + Apellido + ", " + DNI + ", " + Email + ", " + Puesto + ", " + FechaNacim + ", " + FechaIncorp+ "\n";
        }
    }
}
