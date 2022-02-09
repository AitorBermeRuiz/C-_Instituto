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
    public partial class fQueja : Form
    {
        String usr, pass,nombre,queja;

        

        public fQueja()
        {
            InitializeComponent();
        }

        public fQueja(string usr, string pass, string nombre,String queja)
        {
            InitializeComponent();
            tbName.ReadOnly = false;
            this.usr = usr;
            this.pass = pass;
            this.nombre = nombre;
            tbName.Text = nombre;
            this.queja = queja;
            tbName.ReadOnly = true;
        }
        private void bGuardar_Click(object sender, EventArgs e)
        {
            
        }


    }
}
