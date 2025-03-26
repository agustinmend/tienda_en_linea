using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda
{
    class Usuario
    {
        protected int usuarioID;
        private string username;
        private string contrasena;
        protected string email;
        private string tipo;
        private List<Cliente> clientes = new List<Cliente>();
        private List<Administrador> admins = new List<Administrador>();

        public Usuario(int userID, string nombre_usuario, string Contrasena, string Email,  string Tipo)
        {
            usuarioID = userID;
            username = nombre_usuario;
            contrasena = Contrasena;
            email = Email;
            tipo = Tipo;
        }
        public string obtener_username()
        {
            return username;
        }
        public string obtener_contrasena()
        {
            return contrasena;
        }
        public string obtener_tipo()
        {
            return tipo;
        }
        public Cliente iniciar_cliente(int IDusuario)
        {
            for(int i = 0; i < clientes.Count; ++i)
            {
                if (clientes[i].obtener_id_cliente() == IDusuario)
                {
                    return clientes[i];
                }
            }
            return null;
        }
        public void agregar_cliente(string nombres, string apellidos)
        {
            Cliente cliente = new Cliente(usuarioID, email, nombres, apellidos, username, contrasena, tipo);
            clientes.Add(cliente);
        }
        public int obtener_id_usuario()
        {
            return usuarioID;
        }
    }
}
