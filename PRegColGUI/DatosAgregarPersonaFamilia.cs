using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRegColGUI
{
    public partial class DatosAgregarPersonaFamilia : Form
    {
        public DatosAgregarPersonaFamilia()
        {
            InitializeComponent();
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTAgregar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Integrante agregado exitosamente", "Mensaje de Agregar", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
