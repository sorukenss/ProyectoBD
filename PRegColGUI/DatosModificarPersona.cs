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
    public partial class DatosModificarPersona : Form
    {
        public DatosModificarPersona()
        {
            InitializeComponent();
        }

        private void DatosModificarPersona_Load(object sender, EventArgs e)
        {

        }

        private void LBIDModificar_Click(object sender, EventArgs e)
        {

        }

        private void TBIdModificar_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTAgregar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Datos modificados exitosamente", "Mensaje de Modificar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
