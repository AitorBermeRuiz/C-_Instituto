using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DonacionesSangre
{
    public partial class NuevoDonante : Form
    {
        Form1 Form1;
        public NuevoDonante()
        {
            InitializeComponent();
        }
        public NuevoDonante(Form1 Form1)
        {
            InitializeComponent();
            this.Form1 = Form1;
        }


        private void bGuardar_Click(object sender, EventArgs e)
        {
                String dni = tbDni.Text;
                String nombre = tbNombre.Text;
            int telefono;
                if (tbTelefono.Text.Equals(""))
                    telefono = 0;
                else
                    telefono = Int32.Parse(tbTelefono.Text);
                String grupo = guardarGrupo();
                String factor = guardarFactor();
                String grupoFactor = grupo + factor;
                if (dni == null || nombre == null || grupo == "" || factor == "")
                {
                    MessageBox.Show("Campos obligatorios no rellenados");

                }

                else
                {
                    Usuarios Usuario = new Usuarios(dni, nombre, grupo, factor, telefono);
                    Form1.agregarUsuario(Usuario);
                    Form1.diccionario[grupoFactor]++;
                }
                clear();

        }

        private String guardarGrupo()
        {
            if (rd0.Checked)
                return rd0.Text;
            else if (rdA.Checked)
                return rdA.Text;
            else if (rdB.Checked)
                return rdB.Text;
            else if (rdAB.Checked)
                return rdAB.Text;
            else
                return "";
        }
        private String guardarFactor()
        {
            if (rdPositive.Checked)
                return rdPositive.Text;
            else if (rdNegative.Checked)
                return rdNegative.Text;
            else
                return "";
        }
        private void clear()
        {
            tbNombre.Clear();
            tbDni.Clear();
            tbTelefono.Clear();
            rd0.Checked = false;
            rdA.Checked = false;
            rdB.Checked = false;
            rdAB.Checked = false;
            rdPositive.Checked = false;
            rdNegative.Checked = false;

        }

        private void bCancelar_Click(object sender, EventArgs e)
        {

            this.Close();
        }


        private void validacion(object sender, CancelEventArgs e){
            TextBox tbSender = (TextBox)sender;
            if (tbSender.Text == "")
            {
                //errorProvider1.SetError(tbDni, "El campo debe ser obligatorio");
                errorProvider1.SetError(tbSender, "Este campo es obligatorio rellenarlo");
                e.Cancel = true;
            }
            else
                errorProvider1.Clear();
        }
    }
}
