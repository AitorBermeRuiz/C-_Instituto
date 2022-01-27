using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletesAutobus
{
    public class Usuarios
    {
        private String nombre;
        private String dni;
        private int telefono;
        private String email;
        private int plaza;

        public Usuarios(String nombre, String dni, int telefono, String email)
        {
            this.nombre = nombre;
            this.dni = dni;
            this.telefono = telefono;
            this.email = email;
            this.plaza = 0;
        }

        public String getNombre()
        {
            return nombre;
        }

        public void setNombre(String nombre)
        {
            this.nombre = nombre;
        }

        public String getDNI()
        {
            return this.dni;
        }

        public void setDNI(String dni)
        {
            this.dni = dni;
        }

        public int getTelefono()
        {
            return telefono;
        }

        public void setTelefono(int telefono)
        {
            this.telefono = telefono;
        }

        public String getEmail()
        {
            return email;
        }

        public void setEmail(String email)
        {
            this.email = email;
        }


        public override string ToString()
        {
            return this.nombre + "\t" + this.dni + "\t" + this.email + "\t" + this.telefono + "\t" + this.plaza + System.Environment.NewLine;
        }





    }
}
