using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1Trimestre
{

    public class cUsuarios { 

        String usr, pass, nombre;
        DateTime fechaNacim;
        String queja;

        public cUsuarios(string usr, string pass, string nombre, DateTime fechaNacim)
        {
            this.usr = usr;
            this.pass = pass;
            this.nombre = nombre;
            this.fechaNacim = fechaNacim;
            queja = "Introduzca aqui la queja. Gracias jejje!!!!";
        }

        public string Usr { get => usr; set => usr = value; }
        public string Pass { get => pass; set => pass = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public DateTime FechaNacim { get => fechaNacim; set => fechaNacim = value; }
        public string Queja { get => queja; set => queja = value; }
    }
}
