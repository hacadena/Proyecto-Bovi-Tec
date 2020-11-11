using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Usuario
    {
        private string contraseña, tipoDeUsuario,idUsuario;

        public string Contraseña { get => contraseña; set => contraseña = value; }
        public string TipoDeUsuario { get => tipoDeUsuario; set => tipoDeUsuario = value; }
        public string IdUsuario { get => idUsuario; set => idUsuario = value; }
    }
}
