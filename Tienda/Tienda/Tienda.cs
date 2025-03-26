using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda
{
    class Tienda
    {
        private List<Usuario> usuarios = new List<Usuario>();
        private Inventario inventario = new Inventario();
        private Cliente prota;
        public void agregar_usuario(string username , string contrasena, string email)
        {
            Usuario usuario = new Usuario(usuarios.Count() + 1, username, contrasena, email , "Cliente");
            usuarios.Add(usuario);
            Console.WriteLine("Ingrese sus nombres");
            string nombres = Console.ReadLine();
            Console.WriteLine("Ingrese sus apellidos");
            string apellidos = Console.ReadLine();
            usuario.agregar_cliente(nombres, apellidos);
            Console.Clear();
            Console.WriteLine("REGISTRADO EXITOSAMENTE");
        }
        public bool iniciar_sesion(string usuario , string contrasena)
        {
            int i = 0;
            while(i < usuarios.Count())
            {
                if (usuarios[i].obtener_username() == usuario)
                {
                    if(contrasena == usuarios[i].obtener_contrasena())
                    {
                        prota = usuarios[i].iniciar_cliente(usuarios[i].obtener_id_usuario());
                        if (prota != null)
                        {
                            Console.Clear();
                            Console.WriteLine("SESION INICIADA");
                            return true;
                        }
                        else
                        {
                            Console.WriteLine("El usuario no es un cliente");
                        }
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("CONTRASENA INCORRECTA");
                        Console.WriteLine("INGRESAR CONTRASENA");
                        contrasena = Console.ReadLine();
                    }
                }
                else
                {
                    ++i;
                }
            }
            Console.WriteLine("USUARIO NO ENCONTRADO");
            return false;
        }
        public void iniciar_tienda()
        {
            inventario.iniciar_inventario();
        }
        public void mostrar_categorias()
        {
            inventario.mostrar_categorias();
        }
        public void mostrar_Productos(int indice)
        {
            inventario.mostrar_productos(indice);
        }
        public Inventario obtener_inventario()
        {
            return inventario;
        }
        public Cliente obtener_cliente()
        {
            return prota;
        }
        
    }
}
