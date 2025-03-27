using System;
using System.Collections.Specialized;

namespace Tienda
{
    class Program
    {
        public static void Main(string[] args)
        {
            Tienda tienda = new Tienda();
            tienda.iniciar_tienda();
            bool sesion = false;
            string opcion = "";
            while (true)
            {
                if (sesion == false)
                {
                    Console.WriteLine("BIENVENIDO A TIENDAENLINEA");
                    Console.WriteLine("SELECCIONE LA OPCION QUE DESEE");
                    Console.WriteLine("1.REGISTRARSE");
                    Console.WriteLine("2.INICIAR SESION");
                    Console.WriteLine("3.SALIR");
                    opcion = Console.ReadLine();
                    Console.Clear();
                }
                if (sesion == true)
                {

                    Console.WriteLine("SELECCIONE QUE DESEA VER");
                    Console.WriteLine("Escriba 'ver' para ver carrito");
                    Console.WriteLine("Escriba 'cerrar' para cerrar sesion");
                    Console.WriteLine("Escriba 'vaciar' para vaciar carrito");
                    Console.WriteLine("Escriba 'comprar' para comprar productos del carrito");
                    Console.WriteLine("Escriba 'buscar' para buscar producto");
                    tienda.mostrar_categorias();
                    string respuesta = Console.ReadLine();
                    if(respuesta == "ver")
                    {
                        Console.Clear();
                        tienda.obtener_cliente().obtener_carrito().mostrar_carrito();
                    }
                    else if(respuesta == "cerrar")
                    {
                        sesion = false;
                        Console.Clear();
                    }
                    else if(respuesta == "vaciar")
                    {
                        Console.Clear();
                        tienda.obtener_cliente().obtener_carrito().vaciar_carrito();
                    }
                    else if (respuesta == "comprar")
                    {
                        Console.Clear();
                        tienda.obtener_cliente().confirmar_pedido();
                        Console.WriteLine("COMPRA EXITOSA");
                        Console.WriteLine("Ver factura?");
                        Console.WriteLine("1.Si");
                        Console.WriteLine("2.No");
                        string ver = Console.ReadLine();
                        if(ver == "1")
                        {
                            tienda.obtener_cliente().obtener_ultimo_pedido().obtener_factura().mostrar_factura();
                        }
                    }
                    else if(respuesta == "buscar")
                    {
                        Console.Clear();
                        Console.WriteLine("Ingrese nombre del producto");
                        string abreviacion = Console.ReadLine();
                        tienda.obtener_cliente().busqueda(abreviacion, tienda.obtener_inventario());
                    }
                    else
                    {
                        int indice = int.Parse(respuesta) - 1;
                        while (true)
                        {
                            Console.WriteLine("Seleccione que desea anadir al carrito");
                            Console.WriteLine("Presione 0 para volver");
                            tienda.mostrar_Productos(indice);
                            string producto = Console.ReadLine();
                            int product = int.Parse(producto) - 1;
                            if (producto == "0")
                            {
                                break;
                            }
                            Producto producto_elegido = tienda.obtener_inventario().obtener_producto(indice, product);
                            Console.Clear();
                            tienda.obtener_cliente().obtener_carrito().anadir_al_carrito(producto_elegido);
                        }

                    }

                }
                else if (opcion == "1")
                {
                    Console.Clear();
                    Console.WriteLine("INGRESE UN NOMBRE DE USUARIO");
                    string username = Console.ReadLine();
                    Console.WriteLine("INGRESE UNA CONTRASENA");
                    string contrasena = Console.ReadLine();
                    Console.WriteLine("INGRESE EMAIL");
                    string email = Console.ReadLine();
                    tienda.agregar_usuario(username, contrasena , email);

                }
                else if(opcion == "2")
                {
                    Console.Clear();
                    Console.WriteLine("INGRESE SU NOMBRE DE USUARIO");
                    string username = Console.ReadLine();
                    Console.WriteLine("INGRESE SU CONTRASENA");
                    string contrasena = Console.ReadLine();
                    sesion = tienda.iniciar_sesion(username, contrasena);
                }
                else if(opcion == "3")
                {
                    Console.Clear();
                    Console.WriteLine("GRACIAS POR SU PREFERENCIA");
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Escoja una opcion valida");
                }
            }
        }
    }
}