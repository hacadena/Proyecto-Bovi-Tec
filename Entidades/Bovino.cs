using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Bovino
    {
        private string Id_bovino, edad, sexo, numeroDePartos, tipo, estado, Id_delDueño;
        private Peso peso;
        private Tratamiento tratamiento;
        private Enfermedad enfermedad;
        private Produccion produccion;
        private List<Peso> listaPesos = new List<Peso>();
        private List<Tratamiento> listaTratamientos = new List<Tratamiento>();
        private List<Enfermedad> listaEnfermedades = new List<Enfermedad>();
        private List<Produccion> listaProducciones = new List<Produccion>();

        public string Id_bovino1 { get => Id_bovino; set => Id_bovino = value; }
        public string Edad { get => edad; set => edad = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public string NumeroDePartos { get => numeroDePartos; set => numeroDePartos = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public string Estado { get => estado; set => estado = value; }
        public string Id_delDueño1 { get => Id_delDueño; set => Id_delDueño = value; }
        internal Peso Peso { get => peso; set => peso = value; }
        internal Tratamiento Tratamiento { get => tratamiento; set => tratamiento = value; }
        internal Enfermedad Enfermedad { get => enfermedad; set => enfermedad = value; }
        internal Produccion Produccion { get => produccion; set => produccion = value; }
        internal List<Peso> ListaPesos { get => listaPesos; set => listaPesos = value; }
        internal List<Tratamiento> ListaTratamientos { get => listaTratamientos; set => listaTratamientos = value; }
        internal List<Enfermedad> ListaEnfermedades { get => listaEnfermedades; set => listaEnfermedades = value; }
        internal List<Produccion> ListaProducciones { get => listaProducciones; set => listaProducciones = value; }
    }
}
