using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda
{
    class Producto
    {
        private int codigo;
        private string nombre;
        private int stock;
        private double precio;
        public Producto(int Codigo, string Nombre, int Stock, double Precio)
        {
            codigo = Codigo;
            nombre = Nombre;
            stock = Stock;
            precio = Precio;
        }

        public string obtener_nombre()
        {
            return nombre;
        }
        public double obtener_precio()
        {
            return precio;
        }
        public int obtener_stock()
        {
            return stock;
        }
        public void disminuir_stock()
        {
            stock = stock - 1;
        }
    }
}
