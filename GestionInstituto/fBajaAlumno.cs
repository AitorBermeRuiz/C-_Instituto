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

namespace GestionInstituto
{
    public partial class fBajaAlumno : Form
    {
        public fBajaAlumno()
        {
            InitializeComponent();
        }

        private void bAceptar_Click(object sender, EventArgs e)
        {
            string aux = " " + tbDni + " ? ";
            if (MessageBox.Show("Estas seguro que quieres dar de baja al usuario?", "Verificacion", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string DNI = tbDni.Text;
                try
                {

                    FileStream fs = new FileStream("Alumnos.txt", FileMode.Open);
                    BinaryFormatter formatter = new BinaryFormatter();
                    FileStream fs1 = new FileStream("Auxiliar.txt", FileMode.Create);

                    while (fs.Position != fs.Length)
                    {

                        cAlumno alumno = (cAlumno)formatter.Deserialize(fs);
                        if (DNI == alumno.DNI1)
                        {
                            alumno.Activo = false;
                        }
                        formatter.Serialize(fs1, alumno);

                    }
                    fs.Close();
                    
                    fs1.Close();
                    File.Delete("Alumnos.txt");
                    File.Copy(fs1.Name, "Alumnos.txt");
                    File.Delete("Auxiliar.txt");
                }
                catch (FileNotFoundException fnfe) { MessageBox.Show("Fichero no existente"); }
            }
        }
    }
}
