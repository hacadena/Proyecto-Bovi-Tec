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
    public partial class RegistrarDueño : Form
    {
        public RegistrarDueño()
        {
            InitializeComponent();
        }

        private void botonCancelarRegistarPersona_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void botonSiguienteRegistrarPersona_Click(object sender, EventArgs e)
        {
            RegistrarUsuarios registrarUsuarios = new RegistrarUsuarios();
            registrarUsuarios.Show();
            this.Hide();
        }
    }
}
