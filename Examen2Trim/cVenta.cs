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
    public partial class cVenta : Form
    {
        private List<cProductos> productos;
        private Form1 f1;
        public cVenta()
        {
            InitializeComponent();
        }

        public cVenta(List<cProductos> productos, Form1 f1)
        {
            InitializeComponent();
            this.productos = productos;
            this.f1 = f1;
        }
        private void BuscarProduct(object sender, CancelEventArgs e)
        {
            if (Int32.TryParse(tbCod.Text, out int result))
            {
                if (f1.codigoRepetido(result))
                {
                    foreach (cProductos prod in productos)
                    {
                        if (prod.Cod == result)
                        {
                            tbNombre.Text = prod.Nombre;
                            tbPrecio.Text = prod.Precio + "";
                            tbPrecio.Text = prod.Precio + "";
                        }
                    }
                    bAceptar.Enabled = true;
                }
                else
                {
                    MessageBox.Show("El codigo no se encuentra en la BBDD", "Error");
                    borrar();
                    bAceptar.Enabled = false;
                }

            }

        }
        private void borrar()
        {
            tbCod.Clear();
            tbNombre.Clear();
            tbPrecio.Clear();
            tbTotal.Clear();
            tbUnidades.Clear();
        }

        private void CalcularTotal(object sender, CancelEventArgs e)
        {
            if (!Int32.TryParse(tbPrecio.Text, out int precio))
                MessageBox.Show("Precio debe ser numerico", "Error");
            if (!Int32.TryParse(tbUnidades.Text, out int unidades))
                MessageBox.Show("Unidades debe ser numerico", "Error");
            int total = precio * unidades;
            tbTotal.Text = total + "";
        }

        private void bCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bAceptar_Click(object sender, EventArgs e)
        {
            if (f1.modUnidadesLista(Int32.Parse(tbCod.Text), Int32.Parse(tbUnidades.Text), "-"))
                MessageBox.Show("Stock minimo superado", "Error");
            else
                f1.guardar();
        }
    }
}
