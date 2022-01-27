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
    public partial class MostrarUsuario : Form
    {
        String datosUsuario;

        public MostrarUsuario(string datosUsuario)
        {
            InitializeComponent();
            this.datosUsuario = datosUsuario;
            textBox1.Text = this.datosUsuario;
        }

        public MostrarUsuario()
        {
            InitializeComponent();
        }

        private void bSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
