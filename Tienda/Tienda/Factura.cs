using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda
{
    class Factura
    {
        private int nro_factura;
        private int cantidad;
        private List<Producto> productos;
        private double precio_unitario;
        private string nombre_cliente;
        private string apellidos_cliente;
        public Factura(int Nro_factura, int Cantidad, List<Producto> Productos, double Precio_unitario, string Nombre_cliente, string Apellidos_cliente)
        {
            nro_factura = Nro_factura;
            cantidad = Cantidad;
            productos = Productos;
            precio_unitario = Precio_unitario;
            nombre_cliente = Nombre_cliente;
            apellidos_cliente = Apellidos_cliente;
        }

        public void mostrar_factura()
        {
            Console.Clear();
            Console.WriteLine("FACTURA");
            Console.WriteLine("Nro Factura: " + nro_factura.ToString());
            Console.WriteLine("Nombre cliente: " + nombre_cliente);
            Console.WriteLine("Apellidos cliente: " + apellidos_cliente);
            Console.WriteLine(productos.Count.ToString());
            Console.WriteLine("Precio unitario: " + precio_unitario.ToString());
        }
    }
}
