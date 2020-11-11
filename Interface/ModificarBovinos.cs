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
    public partial class ModificarBovinos : Form
    {
        public ModificarBovinos()
        {
            InitializeComponent();
        }

        private void botonConfirmarModificacionBovina_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bovino Modificado Correctamente", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            this.Hide();
        }

        private void botonCancelarModificacionBovina_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
