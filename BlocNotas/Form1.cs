using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BlocNotas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Boolean ArchivoGuardadoAlgunaVez = false;
        private String nombre;
        private void nuevoTSM_Click(object sender, EventArgs e)
        {
            if (TextBox.TextLength != 0)
            {
                if(MessageBox.Show("Estas seguro que quieres borrar los datos escritos?", "Confirmacion", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                    TextBox.Clear();
                    ArchivoGuardadoAlgunaVez = false;
                    this.Text = "*Sin titulo: Bloc de notas";
                }
            }
        }
        
        private void guardarComoTSM_Click(object sender, EventArgs e)
        {

            String contenidoTB = TextBox.Text;
            saveFileDialog1.Filter = "Documentos de texto (*.txt)|*.txt|"+
                "Todos los archivos (*.*)|*.*";
                                    
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                nombre = saveFileDialog1.FileName;
                FileStream fs = new FileStream(nombre, FileMode.Create);
                StreamWriter sw = new StreamWriter(fs);
                
                sw.Write(contenidoTB);

                sw.Close();fs.Close();
                String nombreFichero = saveFileDialog1.FileName.Substring(saveFileDialog1.InitialDirectory.Length+1);
                this.Text = nombreFichero + ": Bloc de notas";
                ArchivoGuardadoAlgunaVez = true;
            }
        }

        private void guardarTSM_Click(object sender, EventArgs e)
        {
            if (!ArchivoGuardadoAlgunaVez)
            {
                guardarComoTSM_Click(sender,e);
            }
            else
            {
                FileStream fs = new FileStream(nombre, FileMode.Create);
                StreamWriter sw = new StreamWriter(fs);
                sw.Write(TextBox.Text);
                sw.Close(); fs.Close();

            }
        }

        private void abrirTSM_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter= "Documentos de texto (*.txt)|*.txt|" +
                "Todos los archivos (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}
