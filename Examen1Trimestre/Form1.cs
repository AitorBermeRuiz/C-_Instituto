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
    public partial class Form1 : Form
    {
        private String nombre;
        cUsuarios[] lUsuarios = new cUsuarios[0];
        public Form1()
        {
            InitializeComponent();
        }

        private void bAcceso_Click(object sender, EventArgs e)
        {
            if (usuarioRegistrado())
            {
                fQueja queja = new fQueja(tbUsr.Text, tbPass.Text,nombre);
                queja.Show();
            }
            else
            {
                fRegistro registro = new fRegistro(this);
                registro.ShowDialog();
            }
        }
        public void guardarQueja(String usr, String psw,String queja)
        {
            foreach (cUsuarios usuar in lUsuarios)
            {
                if (usuar.Usr.Equals(usr) && usuar.Pass.Equals(psw))
                    usuar.Queja = queja;
            }
        }

        private bool usuarioRegistrado()
        {
            bool registrado = false;
            if (lUsuarios.Length == 0)
                registrado = false;
            else
            {
                foreach (cUsuarios aux in lUsuarios)
                {
                    if (aux.Usr.Equals(tbUsr.Text) && aux.Pass.Equals(tbPass.Text))
                    {
                        registrado = true;
                        this.nombre = aux.Nombre;
                    }
                }
            }
            return registrado;
        }
        public bool comprobarNombreRepetido(String usr)
        {
            bool repetido = false;
            foreach (cUsuarios aux in lUsuarios)
            {
                if (aux.Usr.Equals(usr))
                    repetido = true;
            }
            return repetido;
        }
        public void registrarUsuario(cUsuarios Usuario)
        {
            Array.Resize(ref lUsuarios, lUsuarios.Length + 1);
            lUsuarios[lUsuarios.Length - 1] = Usuario;
        }

        private void bSalir_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Estas seguro que quieres salir del programa", "Salir", MessageBoxButtons.YesNo) == DialogResult.Yes)
                this.Close();
            
        }
        public void guardarQueja()
        {

        }
    }
}
