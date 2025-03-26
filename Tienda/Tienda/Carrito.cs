using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Tienda
{
    class Carrito
    {
        private List<Producto> pedido = new List<Producto>();
        
        public void anadir_al_carrito(Producto producto)
        {
            if(validar_stock() == true)
            {
                pedido.Add(producto);
                Console.WriteLine("se agrego al carrito el producto: " + producto.obtener_nombre());
            }
            else
            {
                Console.WriteLine("Stock insuficiente");
            }
        }
        public void vaciar_carrito()
        {
            pedido.Clear();
            Console.WriteLine("Carrito vaciado");
        }

        public double calcular_precio()
        {
            double total = 0;
            for(int i = 0; i < pedido.Count; ++i)
            {
                total = total + pedido[i].obtener_precio();
            }
            return total;
        }
        public List<Producto> obtener_pedido()
        {
            return pedido;
        }
        public bool validar_stock()
        {
            bool result = true;
            for(int i = 0; i < pedido.Count; ++i)
            {
                int cantidad = 0;
                for(int j = 0; j < pedido.Count; ++j)
                {
                    if (pedido[i].obtener_nombre() == pedido[j].obtener_nombre())
                    {
                        ++cantidad;
                    }
                }
                if(cantidad > pedido[i].obtener_stock())
                {
                    result = false;
                }
            }
            return result;
        }
        public void mostrar_carrito()
        {
            Console.Clear();
            Console.WriteLine("CARRITO");
            for(int i = 0; i <pedido.Count; ++i)
            {
                Console.WriteLine(pedido[i].obtener_nombre() + " precio: " + pedido[i].obtener_precio().ToString());
            }
            Console.WriteLine("Costo total: " + calcular_precio().ToString());
            Console.WriteLine("");
        }
    }
}
