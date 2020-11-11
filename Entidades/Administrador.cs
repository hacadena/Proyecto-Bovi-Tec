using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Administrador : Persona
    {
        private Usuario usuario;

        internal Usuario Usuario { get => usuario; set => usuario = value; }
    }
}
