using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Tratamiento
    {
        private string id_Tratamiento, nombreTratamiento, tipoTratamiento;

        public string Id_Tratamiento { get => id_Tratamiento; set => id_Tratamiento = value; }
        public string NombreTratamiento { get => nombreTratamiento; set => nombreTratamiento = value; }
        public string TipoTratamiento { get => tipoTratamiento; set => tipoTratamiento = value; }
    }
}
