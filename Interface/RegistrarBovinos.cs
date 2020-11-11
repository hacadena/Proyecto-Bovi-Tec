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
    public partial class RegistrarBovinos : Form
    {
        public RegistrarBovinos()
        {
            InitializeComponent();
        }

        private void botonConfirmarRegistroBovino_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bovino Registrado Correctamente", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            this.Hide();
        }

        private void botonCancelarRegistarBovino_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
