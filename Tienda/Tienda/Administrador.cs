using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda
{
    class Administrador
    {
        string nombre_admin;
        string contrasena;

        public Administrador(string Nombre_admin, string Contrasena)
        {
            nombre_admin = Nombre_admin;
            contrasena = Contrasena;
        }
    }
}
