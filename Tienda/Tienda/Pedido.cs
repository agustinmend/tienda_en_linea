using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda
{
    class Pedido
    {
        private int ordenID;
        private string status;
        private List<Producto> ordenes;
        private Factura factura;

        public Pedido(int OrdenID, string Status , List<Producto> Ordenes)
        {
            ordenID = OrdenID;
            status = Status;
            ordenes = Ordenes;
        }

        public void crear_factura(string nombres , string apellidos)
        {
            if(factura == null)
            {
                factura = new Factura(ordenID, ordenes.Count, ordenes, calcular_precio() , nombres , apellidos);
            }
        }
        public double calcular_precio()
        {
            double total = 0;
            for (int i = 0; i < ordenes.Count; ++i)
            {
                total = total + ordenes[i].obtener_precio();
            }
            return total;
        }
        public List<Producto> obtener_ordenes()
        {
            return ordenes;
        }
        public Factura obtener_factura()
        {
            if(factura != null)
            {
                return factura;
            }
            else
            {
                return null;
            }
        }
    }
}
