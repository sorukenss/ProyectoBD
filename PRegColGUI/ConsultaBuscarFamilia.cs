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
    public partial class ConsultaBuscarFamilia : Form
    {
        public ConsultaBuscarFamilia()
        {
            InitializeComponent();
        }

        private void BTBuscar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Familia encontrada exitosamente", "Mensaje de Buscar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ConsultaBuscarFamilia_Load(object sender, EventArgs e)
        {

        }

        private void BTGenerarEstadistica_Click(object sender, EventArgs e)
        {
           
        }
    }
}
