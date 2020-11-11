using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Enfermedad
    {
        private String id_enfermdad, nombreEnfermedad;

        public string Id_enfermdad { get => id_enfermdad; set => id_enfermdad = value; }
        public string NombreEnfermedad { get => nombreEnfermedad; set => nombreEnfermedad = value; }
    }
}
