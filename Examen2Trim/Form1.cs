using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen2Trim
{
    public partial class Form1 : Form
    {
        private List<cProductos> productos = new List<cProductos>();
        private String rutaFichero;
        public Form1()
        {
            InitializeComponent();
        }

        private void salirAPPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void crearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Primero trabajamos con todo el formulario, despues le damos a guardar y guardamos la lista.
            //Si le damos a cerrar el ruta fichero se pondra a ninguno y borraremos la lista para trabajar con ella y poder darle a crear posteriormente.
            //Al darle al abrir seleccionamos el archivo y cargamos los datos en la lista.
            saveFileDialog1.Filter = "Documentos de texto (*.txt)|*.txt|" +
                "Todos los archivos (*.*)|*.*";

            //Initial directory: C:\Users\aitor\source\repos\cSharp_Instituto\Examen2Trim\almacenes
            //los archivos se van a guardar ahi.
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                rutaFichero = saveFileDialog1.FileName;
                lTipoArchivo.Text = saveFileDialog1.FileName.Substring(saveFileDialog1.InitialDirectory.Length + 1);
                FileStream fs = new FileStream(rutaFichero, FileMode.Create);
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fs, productos);
                fs.Close();
            }
        }
        public void guardar()
        {
            FileStream fs = new FileStream(rutaFichero, FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fs, productos);
            fs.Close();
        }

        private void abrirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Documentos de texto (*.txt)|*.txt|" +
                "Todos los archivos (*.*)|*.*";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                rutaFichero = openFileDialog1.FileName;
                lTipoArchivo.Text = openFileDialog1.FileName.Substring(openFileDialog1.InitialDirectory.Length + 1);
                FileStream fs = new FileStream(rutaFichero, FileMode.Open);
                BinaryFormatter formatter = new BinaryFormatter();
                productos = (List<cProductos>) formatter.Deserialize(fs);
                fs.Close();
            }
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            productos.Clear();
            lTipoArchivo.Text = "ningún archivo seleccionado";
        }

        
        public bool codigoRepetido(int cod)
        {
            bool codigoRep = false;
            foreach (cProductos prod in productos)
            {
                if (prod.Cod == cod)
                    codigoRep = true;
            }
            return codigoRep;
        }
        
        public void AgregarProducto(cProductos prod)
        {
            productos.Add(prod);
        }
        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAlta alta = new fAlta(this);
            alta.ShowDialog();
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fConsultar consulta = new fConsultar(productos);
            consulta.ShowDialog();
        }

        private void compraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fCompra compra = new fCompra(this,productos);
            compra.ShowDialog();
        }
        public bool modUnidadesLista(int cod, int unidades, String operador)
        {
            bool stockSuperado = false;
            foreach (cProductos prod in productos)
            {
                if (prod.Cod == cod)
                {
                    if (operador.Equals("+"))
                    {
                        int unTotales = prod.NumUnidades + unidades;
                        if (unTotales > prod.StockMax)
                            stockSuperado = true;
                        else if (unTotales < prod.StockMin)
                            stockSuperado = true;
                        else
                            prod.NumUnidades += unidades;
                    }
                    else
                    {
                        int unTotales = prod.NumUnidades - unidades;
                        if (unTotales < prod.StockMin)
                            stockSuperado = true;
                        else
                            prod.NumUnidades -= unidades;
                    }
                }
            }
            return stockSuperado;
        }

        private void ventaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cVenta venta = new cVenta(productos, this);
            venta.ShowDialog();
        }
    }
}
