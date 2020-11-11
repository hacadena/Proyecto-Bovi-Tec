using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Persona
    {
        private String primerNombre, segundoNombre, primerApellido, segundoApellido,sexo,correo,telefono,direccion,identificacion;
        private int fecha;

        public string PrimerNombre { get => primerNombre; set => primerNombre = value; }
        public string SegundoNombre { get => segundoNombre; set => segundoNombre = value; }
        public string PrimerApellido { get => primerApellido; set => primerApellido = value; }
        public string SegundoApellido { get => segundoApellido; set => segundoApellido = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Identificacion { get => identificacion; set => identificacion = value; }
        public int Fecha { get => fecha; set => fecha = value; }
    }
}
