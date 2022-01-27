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
    public partial class BajaDonante : Form
    {
        List<Usuarios> lUsuarios;
        Dictionary<String, int> diccionario;
        public BajaDonante()
        {
            InitializeComponent();
        }

        public BajaDonante(List<Usuarios> lUsuarios, Dictionary<String, int> diccionario)
        {
            InitializeComponent();
            this.lUsuarios = lUsuarios;
            this.diccionario = diccionario;
        }

        private void bBuscar_Click(object sender, EventArgs e)
        {
            String dni = tbDNI.Text;
            tbDNI.Clear();
            foreach (Usuarios usr in lUsuarios)
            {
                if (dni == usr.Dni) {
                    if (MessageBox.Show("¿Desea Eleminar al usuario " + usr.Nombre + "?", "Confirmacion",
                        MessageBoxButtons.YesNo) == DialogResult.Yes) 
                        {
                            usr.Activo = false;
                            diccionario[usr.Grupo + usr.Factor]--;
                        }
                }
            }
             
        }
    }   
}
