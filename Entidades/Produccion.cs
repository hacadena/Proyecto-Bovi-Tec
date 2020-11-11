using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Produccion
    {
        private string id_Produccion,cantidad;

        public string Id_Produccion { get => id_Produccion; set => id_Produccion = value; }
        public string Cantidad { get => cantidad; set => cantidad = value; }
    }
}
