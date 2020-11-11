using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Dueño : Persona
    {
        private Usuario usuario;
        private Bovino bovino;
        private List<Bovino> listaBovinos = new List<Bovino>();
    }
}
