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
    public partial class RegistrarUsuarios : Form
    {
        public RegistrarUsuarios()
        {
            InitializeComponent();
        }

        private void botonCancelarRegistrarUsuarios_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void botonConfirmarRegistro_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Usuario Registrado Correctamente", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            this.Hide();
        }
    }
}
