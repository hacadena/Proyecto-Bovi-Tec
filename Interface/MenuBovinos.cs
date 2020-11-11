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
    public partial class MenuBovinos : Form
    {
        public MenuBovinos()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegistrarBovinos registrarBovinos = new RegistrarBovinos();
            registrarBovinos.Show();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ModificarBovinos modificarBovinos = new ModificarBovinos();
            modificarBovinos.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CambiarEstadoBovino cambiarEstadoBovino = new CambiarEstadoBovino();
            cambiarEstadoBovino.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ConsultarBovinos consultarBovinos = new ConsultarBovinos();
            consultarBovinos.Show();
        }
    }
}
