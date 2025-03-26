using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda
{
    class Cliente : Usuario
    {
        private int clienteid;
        private string nombre_cliente;
        private string apellidos;
        private List<Pedido> pedidos = new List<Pedido>();
        private Carrito carrito;

        public Cliente(int ClienteID, string Email, string Nombre_cliente, string Apellidos, string Nombre_usuario, string Contrasena, string Tipo)
            : base(ClienteID, Nombre_usuario, Contrasena, Email, Tipo)
        {
            clienteid = ClienteID;
            nombre_cliente = Nombre_cliente;
            apellidos = Apellidos;
            carrito = new Carrito();
        }

        public Carrito obtener_carrito()
        {
            return carrito;
        }
        public void confirmar_pedido()
        {
            Pedido pedido = new Pedido(pedidos.Count + 1, "Pendiente", carrito.obtener_pedido());
            pedido.crear_factura(nombre_cliente , apellidos);
            pedidos.Add(pedido);
            carrito.vaciar_carrito();
        }
        public Pedido obtener_ultimo_pedido()
        {
            if (pedidos[pedidos.Count - 1] != null)
            {
                return pedidos[pedidos.Count - 1];
            }
            else
            {
                Console.WriteLine("No ha realizado pedidos");
                return null;
            }
        }
        public int obtener_id_cliente()
        {
            return clienteid;
        }
        public string obtener_nombres_cliente()
        {
            return nombre_cliente;
        }
        public string obtener_apelllidos_cliente()
        {
            return apellidos;
        }
    }
}
