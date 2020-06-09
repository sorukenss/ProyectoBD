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
    public partial class DatosAgregarFamilia : Form
    {
        public DatosAgregarFamilia()
        {
            InitializeComponent();
        }

        private void BTBuscar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Familia agregada exitosamente", "Mensaje de Agregar", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void LBCedula_Click(object sender, EventArgs e)
        {

        }
    }
}
