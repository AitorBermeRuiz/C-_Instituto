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
    public partial class FRegistroUsuarios : Form
    {
        Form1 f1;
        public FRegistroUsuarios(Form1 f1)
        {
            InitializeComponent();
            this.f1 = f1;
        }

        private void BCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BRegistrar_Click(object sender, EventArgs e)
        {
            String nombre = TBNombre.Text;
            String dni = TBDNI.Text;
            int edad = Int32.Parse(TBEdad.Text);

            Usuarios usr = new Usuarios(dni, nombre, edad);
            f1.AgegarUsuarios(usr);
            cancelar();
        }
        private void cancelar()
        {
            TBDNI.Clear();
            TBNombre.Clear();
            TBEdad.Clear();

        }
    }
}
