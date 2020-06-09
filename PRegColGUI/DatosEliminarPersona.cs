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
    public partial class DatosEliminarPersona : Form
    {
        public DatosEliminarPersona()
        {
            InitializeComponent();
        }

        private void BTEliminar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Integrante eliminada exitosamente", "Mensaje de Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}
