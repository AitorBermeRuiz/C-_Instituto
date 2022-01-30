using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace GestionInstituto
{
    [Serializable]
    public class cAlumno
    {
        String nombre, apellido, DNI, mail, curso;
        List<String> Modulos;
        List<int> notas=null;
        Boolean activo;
        

        public cAlumno(string nombre, string apellido, string dNI, string mail, string curso, List<string> modulos)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            DNI = dNI;
            this.mail = mail;
            this.curso = curso;
            Modulos = modulos;
            activo = true;
            
        }

        public List<string> Modulos1 { get => Modulos; set => Modulos = value; }
        public bool Activo { get => activo; set => activo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string DNI1 { get => DNI; set => DNI = value; }
        public string Mail { get => mail; set => mail = value; }
        public string Curso { get => curso; set => curso = value; }

        public String toStringSinNotas()
        {
            return ("Nombre y Apellidos: "+ nombre + " " + apellido + ", DNI: " + DNI + ", Mail: " + mail + ", Curso: " + curso);
        }
    }
}
