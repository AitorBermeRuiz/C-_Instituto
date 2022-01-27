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
    public partial class fMostrar : Form
    {
        public fMostrar(List<Usuarios> lUsuarios)
        {
            InitializeComponent();
            String sUsuarios = "DNI\tNombre\tEdad\tNº Asientos\r\n";
            foreach (Usuarios usr in lUsuarios)
            {
                sUsuarios += usr.ToString()+"\r\n";
            }
            tbMostrar.Text = sUsuarios;
        }
        

    }
}
