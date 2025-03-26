using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda
{
    class Categoria_Producto
    {
        private List<Producto> categoria = new List<Producto>();
        private string nombre_categoria;

        public Categoria_Producto(string Nombre_categoria)
        {
            nombre_categoria = Nombre_categoria;
        }

        public void agregar_producto()
        {
            Console.WriteLine("INGRESE NOMBRE DEL PRODUCTO");
            string nombre = Console.ReadLine();
            Console.WriteLine("INGRESE STOCK DEL PRODUCTO");
            int stock = int.Parse(Console.ReadLine());
            Console.WriteLine("INGRESE EL PRECIO DEL PRODUCTO");
            double precio = Convert.ToDouble(Console.ReadLine());
            Producto producto = new Producto(categoria.Count ,nombre , stock , precio);
            categoria.Add(producto);
        }
        public string obtener_nombre_categoria()
        {
            return nombre_categoria;
        }
        public void iniciar_categoria(string nombre , int stock , double precio)
        {
            Producto producto = new Producto(categoria.Count, nombre, stock, precio);
            categoria.Add(producto);
        }
        public void mostrar_productos()
        {
            int i = 0;
            while(i < categoria.Count)
            {
                Console.WriteLine((i + 1).ToString() + ".- " + categoria[i].obtener_nombre() + "  costo: " + categoria[i].obtener_precio());
                ++i;
            }
        }
        public Producto obtener_producto(int indice)
        {
            return categoria[indice];
        }
        public List<Producto> obtener_productos()
        {
            return categoria;
        }
    }
}
