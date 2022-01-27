using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autobus
{
    public class Usuarios
    {
        String dni, nombre;
        int edad,numAsientos;
        public Usuarios(String dni, String nombre,int edad)
        {
            this.dni         = dni;
            this.nombre      = nombre;
            this.edad        = edad;
            this.numAsientos = 0;
        }

        public String GetDni()
        {
            return dni;
        }
        public void SetDni(String dni)
        {
            this.dni = dni;
        }
        public String GetNombre()
        {
            return nombre;
        }
        public void SetNombre(String nombre)
        {
            this.nombre = nombre;
        }
        public int GetEdad()
        {
            return edad;
        }
        public void SetEdad(int edad)
        {
            this.edad = edad;
        }
        public int GetNumAsientos()
        {
            return numAsientos;
        }
        public void SetNumAsientos(int numAsientos)
        {
            this.numAsientos = numAsientos;
        }
        override
        public String ToString()
        {
            return (dni + "\t" + nombre + "\t" + edad + "\t" + numAsientos);
        }
    }
}
