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
            //Tengo una lista de modulos, dependiendo de que checkedListBox este visible hacemos un forEach para guardar
            //sus item activos, es decir modulos en los que está matriculado.
            
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
            //A la hora de darle al boton de guardar comprobamos si el DNI ya existe, si si que existe le preguntamos si 
            //quiere dar de baja a ese alumno, entonces le dariamos de baja. De lo contrario, si no existe el dni,
            //simplemente se guarda en el fichero

            switch (comprobacionDniyActivo(alumno.DNI1)) {

                case 0://Dni no existe
                    FileStream fs = new FileStream("Alumnos.txt", FileMode.Append);
                    BinaryFormatter formatter = new BinaryFormatter();

                    formatter.Serialize(fs, alumno);
                    fs.Close();
                    errorProvider1.Clear();
                    break;
                case 1://Dni existe en el fichero pero dado de baja
                    if (MessageBox.Show("El dni ya existe, quieres darle de alta?, si no introduce un dni no existente",
                    "Alta", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        fGestionAlumnos.altaBaja(true, alumno.DNI1);
                        errorProvider1.Clear();
                    }
                    else
                        errorProvider1.SetError(tbDni, "Cambie el dni por favor");
                    break;
                case 2://Dni existe en el fichero y dado de alta
                    errorProvider1.SetError(tbDni, "Dni ya existe y dado de alta, por favor cambie el dni");
                    break;
            }

            /*if (comprobacionDniyActivo(alumno.DNI1))
            { 
                if (MessageBox.Show("El dni ya existe, quieres darle de alta?, si no introduce un dni no existente",
                    "Alta", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    fGestionAlumnos.altaBaja(true, alumno.DNI1);
                }
            }else
            {
                FileStream fs = new FileStream("Alumnos.txt", FileMode.Append);
                BinaryFormatter formatter = new BinaryFormatter();

                formatter.Serialize(fs, alumno);
                fs.Close();
            }*/

        }

        public static int comprobacionDniyActivo(String dni)
        {
            //Función que comprueba si el dni está guardado en el fichero, si el usuario esta activo cuando se le
            //quiere dar de alta.
            
            //0 Dni no existe,
            //1 Dni existe pero esta dado de baja
            //2 Dni existe y esta dado de alta
            int cond = 0;
            FileStream fs = new FileStream("Alumnos.txt", FileMode.Open);
            BinaryFormatter formatter = new BinaryFormatter();

            while (fs.Position != fs.Length)
            {

                cAlumno alumno = (cAlumno)formatter.Deserialize(fs);
                if (dni == alumno.DNI1 && alumno.Activo)
                    cond = 2;
                else if (dni == alumno.DNI1 && alumno.Activo == false)
                    cond = 1;
                

            }
            fs.Close();
            return cond;
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
            //Pone el desplegable en blanco
            combobCurso.SelectedIndex = -1;
            
            //Hace un for de los todos los item de la lista, y pone a false uno a uno
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
