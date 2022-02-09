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
    public partial class fAlta : Form
    {
        Form1 f1;
        public fAlta()
        {
            InitializeComponent();
        }

        public fAlta(Form1 f1)
        {
            InitializeComponent();
            this.f1 = f1;
        }

        private void bAceptar_Click(object sender, EventArgs e)
        {
            int cod = Int32.Parse(tbCod.Text);
            if (!f1.codigoRepetido(cod))
            {
                cProductos product = new cProductos(Int32.Parse(tbCod.Text),tbNombre.Text, Int32.Parse(tbPrecio.Text), Int32.Parse(tbStockMin.Text), Int32.Parse(tbStockMax.Text));
                f1.AgregarProducto(product);
                borrarDatos();
            }
            else
            {
                MessageBox.Show("El codigo esta repetido, por favor escriba otro", "Codigo repetido");
            }
        }

        private void noInteger(object sender, CancelEventArgs e)
        {
            TextBox t = (TextBox)sender;
            if(Int32.TryParse(t.Text, out int result))
            {
                errorProvider1.Clear();
                bAceptar.Enabled = true;
            }
            else
            {
                errorProvider1.SetError(t, "Tiene que ser un numero sin decimales.");
                bAceptar.Enabled = false;
            }
        }
        private void borrarDatos()
        {
            tbCod.Clear();
            tbNombre.Clear();
            tbPrecio.Clear();
            tbStockMax.Clear();
            tbStockMin.Clear();
        }
    }
}
