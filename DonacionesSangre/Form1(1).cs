using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DonacionesSangre
{
    public partial class Form1 : Form
    {
      List<Usuarios> lUsuarios = new List<Usuarios>();
        public Form1()
        {
            InitializeComponent();
        }

        private void nuevoDonanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NuevoDonante fNuevoDonante = new NuevoDonante(this);
            fNuevoDonante.Show();

        }

        public void agregarUsuario(Usuarios usuario)
        {
            lUsuarios.Add(usuario);
        }

        private void busquedaDonanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BusquedaDonante fBusquedaDonante = new BusquedaDonante(lUsuarios);
            fBusquedaDonante.Show();
        }

        private void bajaDonanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BajaDonante fBajaDonante = new BajaDonante(lUsuarios);
            fBajaDonante.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tiposDisponiblesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TiposDisponibles fTiposDisponibles = new TiposDisponibles(lUsuarios);
            fTiposDisponibles.Show();
        }
    }
}
