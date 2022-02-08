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
    public partial class TiposDisponibles : Form
    {
        List<Usuarios> lUsuarios;
        Dictionary<String, int> diccionario;

        public TiposDisponibles()
        {
            InitializeComponent();
        }
        public TiposDisponibles(List<Usuarios> lUsuarios, Dictionary<String, int> diccionario)
        {
            InitializeComponent();
            this.lUsuarios = lUsuarios;
            this.diccionario = diccionario;
        }

        private void TiposDisponibles_Load(object sender, EventArgs e)
        {

        }

        private void bBuscar_Click(object sender, EventArgs e)
        {
            for (int index = 0; index < diccionario.Count; index++)
            {
                var item = diccionario.ElementAt(index);
                var itemKey = item.Key;
                var itemValue = item.Value;
                if (itemValue > 0)
                    textBox1.Text += itemKey + "=" + itemValue + "\r\n";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
