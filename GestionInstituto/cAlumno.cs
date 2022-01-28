using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionInstituto
{
    [Serializable]
    class cAlumno
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
    }
}
