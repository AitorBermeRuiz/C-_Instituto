using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2Trim
{
    [Serializable]
    public class cProductos
    {
        int cod;
        String nombre;
        int numUnidades, precio, stockMin, stockMax;

        public cProductos(int cod, string nombre, int precio, int stockMin, int stockMax)
        {
            this.cod = cod;
            this.nombre = nombre;
            this.numUnidades = 0;
            this.precio = precio;
            this.stockMin = stockMin;
            this.stockMax = stockMax;
        }

        public int Cod { get => cod; set => cod = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int NumUnidades { get => numUnidades; set => numUnidades = value; }
        public int Precio { get => precio; set => precio = value; }
        public int StockMin { get => stockMin; set => stockMin = value; }
        public int StockMax { get => stockMax; set => stockMax = value; }
    }
}
