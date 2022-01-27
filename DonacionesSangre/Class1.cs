using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonacionesSangre
{
    public class Usuarios
    {
        String dni, nombre, grupo,factor;
        int telefono;
        Boolean activo;

        public Usuarios(string dni, string nombre, string grupo, string factor, int telefono)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.grupo = grupo;
            this.factor = factor;
            this.telefono = telefono;
            this.activo = true;
        }

        public string Dni { get => dni; set => dni = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Grupo { get => grupo; set => grupo = value; }
        public string Factor { get => factor; set => factor = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        public Boolean Activo { get => activo; set => activo = value; }

        public string toString()
        {
            return "Usuario: " + nombre + ", " + dni + ", " + telefono + ". Tipo de sangre: " + grupo + " " + factor + ". activo? " + activo;
        }

    }
}
