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
            if (MessageBox.Show("Estas seguro que quieres dar de baja al usuario?", "Verificacion", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string DNI = tbDni.Text;
                //Función en Form1 que recibe True para dar de alta y false para dar de baja
                switch (fAltaAlumno.comprobacionDniyActivo(DNI))
                {
                    case 0:
                        errorProvider1.SetError(tbDni, "Dni no existente");
                        break;
                    case 1:
                        errorProvider1.SetError(tbDni, "Dni ya dado de baja");
                        break;
                    case 2:
                        fGestionAlumnos.altaBaja(false, DNI);
                        errorProvider1.Clear();
                        tbDni.Clear();
                        break;
                }
                
            }
        }
    }
}
