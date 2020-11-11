using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void botonCerrarSesion_Click(object sender, EventArgs e)
        {
            InicioSesion inicioSesion = new InicioSesion();
            inicioSesion.Show();
            this.Hide();
        }

        private void botonBovinos_Click(object sender, EventArgs e)
        {
            MenuBovinos menuBovinos = new MenuBovinos();
            menuBovinos.Show();
            this.Hide();

        }

        private void botonDueños_Click(object sender, EventArgs e)
        {
            MenuDueños menuDueños = new MenuDueños();
            menuDueños.Show();
            this.Hide();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void botonUsuarios_Click(object sender, EventArgs e)
        {
            MenuUsuarios menuUsuarios = new MenuUsuarios();
            menuUsuarios.Show();
            this.Hide();
        }

        private void botonProductos_Click(object sender, EventArgs e)
        {
            MenuProductos menuProductos = new MenuProductos();
            menuProductos.Show();
            this.Hide();
        }

        private void botonPeso_Click(object sender, EventArgs e)
        {
            MenuPeso menuPeso = new MenuPeso();
            menuPeso.Show();
            this.Hide();
        }

        private void botonEnfermedades_Click(object sender, EventArgs e)
        {
            MenuEnfermedades menuEnfermedades = new MenuEnfermedades();
            menuEnfermedades.Show();
            this.Hide();
        }

        private void botonTratamientos_Click(object sender, EventArgs e)
        {
            MenuTratamientos menuTratamientos = new MenuTratamientos();
            menuTratamientos.Show();
            this.Hide();
        }
    }
}
