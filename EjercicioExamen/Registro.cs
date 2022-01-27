using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioExamen
{
    public partial class Registro : Form
    {
        AccesoUsuario accesoUsuario;

        public Registro(AccesoUsuario accesoUsuario)
        {
            InitializeComponent();
            this.accesoUsuario = accesoUsuario;
        }

        public Registro()
        {
            InitializeComponent();
        }


        private void bGuardar_Click(object sender, EventArgs e)
        {
            String usr = tbUsr.Text, contraseña = tbContraseña.Text,nombre = tbNombre.Text;
            DateTime nacim = dateTimePicker1.Value;
            float notaMedia = float.Parse(tbNota.Text);
            Datos usuario = new Datos(usr, contraseña,nombre,nacim,notaMedia);
            accesoUsuario.AgregarUsuario(usuario);
            Borrar();
        }
        private void Borrar()
        {
            tbUsr.Clear();
            tbContraseña.Clear();
            tbNombre.Clear();
            tbModulo1.Clear();
            tbModulo2.Clear();
            tbNota.Clear();
        }

        private void Validating_notas(object sender, CancelEventArgs e)
        {
            TextBox tbNota2 = (TextBox)sender;
            if (Int32.TryParse(tbNota2.Text, out int aux))
            {
                String modulo1 = tbModulo1.Text, modulo2 = tbModulo2.Text;
                if (modulo1 == "")
                {
                    modulo1 = "0";
                }
                if (modulo2 == "")
                {
                    modulo2 = "0";
                }

                float notaMedia = (float.Parse(modulo1) + float.Parse(modulo2)) / 2;
                tbNota.Text = notaMedia + "";
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(tbNota2, "Campo debe ser numerico");
                e.Cancel = true;
            }
        }

        private void bVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
