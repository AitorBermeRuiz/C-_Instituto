using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen1Trimestre
{
    public partial class fRegistro : Form
    {
        Form1 f1;

        public fRegistro(Form1 f1)
        {
            InitializeComponent();
            this.f1 = f1;
        }

        public fRegistro()
        {
            InitializeComponent();
        }

        private void validating_CampoVacio(object sender, CancelEventArgs e)
        {
            TextBox campo = (TextBox)sender;
            
            if (tbUser.Text.Length == 0)
            {
                errorProvider1.SetError(tbUser, "El campo no puede quedar vacio");
                bGaurdar.Enabled = false;
            } else if(tbPass.Text.Length == 0)
            {
                errorProvider1.SetError(tbPass, "El campo no puede quedar vacio");
                bGaurdar.Enabled = false;
            }
            else
            {
                
                errorProvider1.Clear();
                bGaurdar.Enabled = true;
                if (campo.Name.Equals(tbName.Name))
                {
                    if (f1.comprobarNombreRepetido(tbUser.Text)) {
                        MessageBox.Show("El usuario ya existe, escriba otro", "Usuario repetido", MessageBoxButtons.OK);
                        tbUser.Clear();
                    }
                    
                }
                    

            }
        }

        

        private void comprobarEdad(object sender, EventArgs e)
        {

            //No lo tengo asignado al validating ya que si se me ponia el boton en false entonces tenia que poner 
            //una fecha que fuera mayor de edad y aparte cambiar a un tb cualquiera para que el botón se me mostrara.

            //He puesto en cambio : ValueChanged
            DateTime now = DateTime.Today;
            int edad = DateTime.Today.Year - dateTimePicker1.Value.Year;

            if (DateTime.Today < dateTimePicker1.Value.AddYears(edad))
                --edad;

            if (edad < 18)
            {
                errorProvider2.SetError(dateTimePicker1, "El usuario tiene que ser mayor de edad");
                bGaurdar.Enabled = false;
            }
            else
            {
                errorProvider2.Clear();
                bGaurdar.Enabled = true;
            }
        }

        private void bGaurdar_Click(object sender, EventArgs e)
        {
            cUsuarios usuario = new cUsuarios(tbUser.Text, tbPass.Text, tbName.Text, dateTimePicker1.Value);
            f1.registrarUsuario(usuario);
        }

        private void bVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
