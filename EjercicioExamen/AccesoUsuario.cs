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
    public partial class AccesoUsuario : Form
    {
       static List<Datos> lUsuarios = new List<Datos>();
        public AccesoUsuario()
        {
            InitializeComponent();
        }
        

        private void bSalir_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Estas seguro de que desea cerrar el formulario?", "Confirmacion", MessageBoxButtons.YesNo) == DialogResult.Yes)
                this.Close();
        }

        private void bAcceder_Click(object sender, EventArgs e)
        {
            Registro registro = new Registro(this);

            String usuario = tbUsr.Text,contraseña=tbContraseña.Text,datosUsuario="";
            Boolean credencialesCorrectas = false;
            foreach(Datos usr in lUsuarios)
            {
                if (usr.Usr == usuario && usr.Psw == contraseña)
                    credencialesCorrectas = true;
            }
            if (credencialesCorrectas)
            {
                foreach (Datos usr in lUsuarios)
                {
                    if (usr.Usr == usuario && usr.Psw == contraseña)
                       datosUsuario= usr.toString();
                }
                MostrarUsuario mostrarUsuario = new MostrarUsuario(datosUsuario);
                mostrarUsuario.Show();
            }
            else
                registro.ShowDialog();
        }

        private void AccesoUsuario_Load(object sender, EventArgs e)
        {
            lNUsr.Text= lUsuarios.Count().ToString();
        }
          public void AgregarUsuario(Datos usuario)
        {
            lUsuarios.Add(usuario);
        }

        private void AccesoUsuario_Validating(object sender, CancelEventArgs e)
        {
            lNUsr.Text = lUsuarios.Count().ToString();
        }
    }
}
