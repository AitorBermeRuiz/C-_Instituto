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
    public partial class BusquedaDonante : Form
    {
        List<Usuarios> lUsuarios;
        public BusquedaDonante()
        {
            InitializeComponent();
        }

        public BusquedaDonante(List<Usuarios> lUsuarios)
        {
            InitializeComponent();
            this.lUsuarios = lUsuarios;
        }
        private void bBuscar_Click(object sender, EventArgs e)
        {
            String dni = tbDNI.Text;
            tbDNI.Clear();

            foreach(Usuarios usr in lUsuarios)
            {
                if (dni == usr.Dni&& usr.Activo==true)
                {
                    tbMostrar.Text= usr.toString();
                }
            }
        }
    }
}
