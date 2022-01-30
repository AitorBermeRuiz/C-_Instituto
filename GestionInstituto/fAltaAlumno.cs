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
    public partial class fAltaAlumno : Form
    {
       
        public fAltaAlumno()
        {
            InitializeComponent();
        }

        private void combobCurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            const string DAMA1 = "1º DAM A";
            const string DAMB1 = "1º DAM B";
            const string DAMA2 = "2º DAM A";
            const string DAMB2 = "2º DAM B";
            switch (combobCurso.SelectedItem)
            {
                //poner dos case juntos es similar a poner un or en un if, en este caso al no ver
                //un break en el primer case iria a las condiciones del que si que tenga un break 
                //que es eel segundo case
                case DAMA1:
                case DAMB1:
                    checkedLb1DAM.Visible = true;
                    checkedLb2DAM.Visible = false;
                    
                    break;
                case DAMA2:
                case DAMB2:
                    checkedLb1DAM.Visible = false;
                    checkedLb2DAM.Visible = true;
                    break;
                default:
                    checkedLb1DAM.Visible = false;
                    checkedLb2DAM.Visible = false;
                    break;
            }

        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            //Dependiendo de que checked list box este activo guardaria los datos de 
            //ese checked list box en la lista
            List<String> modulos = new List<string>();
            if (checkedLb1DAM.Visible)
            {
                foreach(String item in checkedLb1DAM.CheckedItems)
                {
                    modulos.Add(item);
                }
            }
            else
            {
                foreach (String item in checkedLb2DAM.CheckedItems)
                {
                    modulos.Add(item);
                }
            }
            String nombre = tbNombre.Text;
            String appellido = tbApellidos.Text;
            String DNI = tbDni.Text;
            String mail = tbMain.Text;
            String curso = combobCurso.Text;
            cAlumno alumno = new cAlumno(tbNombre.Text, tbApellidos.Text, tbDni.Text, tbMain.Text, combobCurso.Text, modulos);

            guardarFichero(alumno);
            vaciarCampos();
        }
        private void guardarFichero(cAlumno alumno) 
        {
            FileStream fs = new FileStream("Alumnos.txt", FileMode.Append);
            BinaryFormatter formatter = new BinaryFormatter();

            formatter.Serialize(fs, alumno);
            fs.Close();

        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void vaciarCampos()
        {
            tbApellidos.Clear();
            tbNombre.Clear();
            tbMain.Clear();
            tbDni.Clear();
            combobCurso.SelectedIndex = -1;
            
            for (int i = 0; i < checkedLb1DAM.Items.Count; ++i)
            {
                checkedLb1DAM.SetItemChecked(i, false);
            }
            for (int i = 0; i < checkedLb2DAM.Items.Count; ++i)
            {
                checkedLb2DAM.SetItemChecked(i, false);
            }
        }

    }
}
