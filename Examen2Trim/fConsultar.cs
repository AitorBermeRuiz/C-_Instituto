using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen2Trim
{
    public partial class fConsultar : Form
    {
        private List<cProductos> productos;
        private int posLista = 0;
        public fConsultar()
        {
            InitializeComponent();
        }

        public fConsultar(List<cProductos> productos)
        {
            InitializeComponent();
            this.productos = productos;
        }

        private void bPrimero_Click(object sender, EventArgs e)
        {
            posLista = 0;
            IntroducirDatos();
        }

        private void bSiguiente_Click(object sender, EventArgs e)
        {
            if (posLista == productos.Count - 1)
            {
                MessageBox.Show("Ya estas en la ultima posicion", "posicion");
            }
            else {
                posLista++;
                IntroducirDatos(); 
            }
        }

        private void bAnterior_Click(object sender, EventArgs e)
        {
            if (posLista > 0)
            {
                posLista--;
                IntroducirDatos();
            }
        }

        private void bUltimo_Click(object sender, EventArgs e)
        {
            posLista = productos.Count - 1;
            IntroducirDatos();
        }
        private void IntroducirDatos()
        {
            tbCod.Text = productos[posLista].Cod+"";
            tbNombre.Text = productos[posLista].Nombre;
            tbPrecio.Text = productos[posLista].Precio + "";
            tbStockMin.Text = productos[posLista].StockMin + "";
            tbStockMax.Text = productos[posLista].StockMax + "";
            tbUnidades.Text = productos[posLista].NumUnidades + "";
        }
    }
}
