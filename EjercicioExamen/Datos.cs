using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioExamen
{
   public class Datos
    {
        String usr, psw, nombre;
        DateTime nacim;
        float notaMedia;

        public Datos(string usr, string psw, string nombre, DateTime nacim, float notaMedia)
        {
            this.usr = usr;
            this.psw = psw;
            this.nombre = nombre;
            this.nacim = nacim;
            this.notaMedia = notaMedia;
        }

        public string Usr { get => usr; set => usr = value; }
        public string Psw { get => psw; set => psw = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public DateTime Nacim { get => nacim; set => nacim = value; }
        public float NotaMedia { get => notaMedia; set => notaMedia = value; }
        public String toString()
        {
            return "Nombre: " + nombre + ", Fecha nacimiento: " + nacim.Day + "/" + nacim.Month + "/" + nacim.Year + ", Nota media: " + notaMedia;
        }
    }
}
