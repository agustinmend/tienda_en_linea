using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda
{
    class Inventario
    {
        private List<Categoria_Producto> inventario = new List<Categoria_Producto>();

        public void agregar_categoria()
        {
            Console.WriteLine("INGRESE NOMBRE DE LA CATEGORIA A AGREGAR");
            string nombre = Console.ReadLine();
            Categoria_Producto categoria = new Categoria_Producto(nombre);
        }
        public void mostrar_categorias()
        {
            int i = 0;
            while (i < inventario.Count) {
                Console.WriteLine((i + 1).ToString() + ".- " + inventario[i].obtener_nombre_categoria());
                ++i;
            }
        }
        public void iniciar_inventario()
        {
            string nombre;
            int stock;
            double precio;
            Categoria_Producto categoria = new Categoria_Producto("Electrodomesticos");
            nombre = "Aspiradora";
            stock = 20;
            precio = 500.23;
            categoria.iniciar_categoria(nombre, stock , precio);
            nombre = "Licuadora";
            stock = 50;
            precio = 200;
            categoria.iniciar_categoria(nombre, stock, precio);
            nombre = "lavadora";
            stock = 10;
            precio = 450.99;
            categoria.iniciar_categoria(nombre, stock, precio);
            nombre = "Microondas";
            stock = 15;
            precio = 305.17;
            categoria.iniciar_categoria(nombre, stock, precio);
            inventario.Add(categoria);
            Categoria_Producto categoria1 = new Categoria_Producto("Accesorios de escritorio");
            nombre = "Mouse";
            stock = 45;
            precio = 10;
            categoria1.iniciar_categoria(nombre, stock , precio);
            nombre = "Teclado";
            stock = 60;
            precio = 22.36;
            categoria1.iniciar_categoria(nombre, stock, precio);
            nombre = "Mousepack";
            stock = 15;
            precio = 5.99;
            categoria1.iniciar_categoria(nombre, stock, precio);
            nombre = "Silla";
            stock = 7;
            precio = 42.50;
            categoria1.iniciar_categoria(nombre, stock, precio);
            inventario.Add(categoria1);
            Categoria_Producto categoria2 = new Categoria_Producto("Muebles");
            nombre = "Sofa";
            stock = 5;
            precio = 462.53;
            categoria2.iniciar_categoria(nombre, stock , precio);
            nombre = "Cama";
            stock = 4;
            precio = 378.11;
            categoria2.iniciar_categoria(nombre, stock, precio);
            nombre = "Mesa";
            stock = 8;
            precio = 213.44;
            categoria2.iniciar_categoria(nombre, stock, precio);
            nombre = "Ropero";
            stock = 3;
            precio = 700;
            categoria2.iniciar_categoria(nombre, stock, precio);
            inventario.Add(categoria2);
        }
        public void mostrar_productos(int indice)
        {
            inventario[indice].mostrar_productos();
        }
        public Producto obtener_producto(int categoria , int productoid)
        {
            return inventario[categoria].obtener_producto(productoid);
        }
        public void actualizar_inventario(Pedido pedido)
        {
            List<Producto> productos = pedido.obtener_ordenes();
            for(int i = 0; i < productos.Count; ++i)
            {
                for(int j = 0; j < inventario.Count; ++j)
                {
                    for(int k = 0; k < inventario[j].obtener_productos().Count; ++k)
                    {
                        if (inventario[j].obtener_producto(k).obtener_nombre() == productos[i].obtener_nombre())
                        {
                            inventario[j].obtener_producto(k).disminuir_stock();
                        }
                    }
                }
            }
        }
    }
}
