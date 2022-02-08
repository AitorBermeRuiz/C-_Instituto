using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DonacionesSangre
{
    public partial class Form1 : Form
    {
        List<Usuarios> lUsuarios = new List<Usuarios>();
        public Dictionary<String, int> diccionario = crearDiccionario();

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
            BajaDonante fBajaDonante = new BajaDonante(lUsuarios,diccionario);
            fBajaDonante.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tiposDisponiblesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TiposDisponibles fTiposDisponibles = new TiposDisponibles(lUsuarios,diccionario);
            
            fTiposDisponibles.Show();
        }
        private static Dictionary<String, int> crearDiccionario()
        {
            Dictionary<String, int> diccionario = new Dictionary<string, int>()
            {
                {"0+",0 },
                {"0-",0 },
                {"A+",0 },
                {"A-",0 },
                {"B+",0 },
                {"B-",0 },
                {"AB+",0 },
                {"AB-",0 }
            };
            return diccionario;
        }
    }
}
