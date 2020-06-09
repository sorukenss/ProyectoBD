using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Entity;

namespace PRegColGUI
{
    public partial class ConsultaBuscarEmpleado : Form
    {
        AdministradorService administradorService;
        List<Empleado> Empleados;

        public ConsultaBuscarEmpleado()
        {
            administradorService = new AdministradorService(ConfigConection.connectionString);
            InitializeComponent();
            Empleados = new List<Empleado>();
            Empleados = administradorService.ConsultarEmpleados();

        }

        private void ConsultaBuscarEmpleado_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void BTVisualizarDatos_Click(object sender, EventArgs e)
        {
            DGVVisualizarEmpleado.DataSource = null;
            DGVVisualizarEmpleado.DataSource = administradorService.ConsultarEmpleados();
            DGVVisualizarEmpleado.AutoResizeColumns();
            DGVVisualizarEmpleado.ReadOnly = true;
            DGVVisualizarEmpleado.Columns[0].Visible = false;
            DGVVisualizarEmpleado.Columns[1].HeaderText = "Contraseña";
            DGVVisualizarEmpleado.Columns[2].HeaderText = "Correo electrónico";
            DGVVisualizarEmpleado.Columns[3].HeaderText = "Primer Nombre";
            DGVVisualizarEmpleado.Columns[4].HeaderText = "Segundo Nombre";
            DGVVisualizarEmpleado.Columns[5].HeaderText = "Primer Apellido";
            DGVVisualizarEmpleado.Columns[6].HeaderText = "Segundo Apellido";
        }

        private void BTGenerarPDF_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Guardar Informe";
            saveFileDialog.InitialDirectory = @"c:/document";
            saveFileDialog.DefaultExt = "pdf";
            string filename = "";
            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                filename = saveFileDialog.FileName;
                if(filename != "" && Empleados.Count > 0)
                {
                    string mensaje = administradorService.GenerarPdf(Empleados, filename);

                    MessageBox.Show(mensaje, "Generar PDF", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se especifico una ruta o no hay datos en el reporte.", "Generar PDF", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BTEnviarCorreo_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filename = string.Empty;

            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.InitialDirectory = @"c:/document";
            fileDialog.Filter = "pdf files (*.pdf) | *.pdf | All files (*.*) | *.*";
            fileDialog.FilterIndex = 2;
            fileDialog.RestoreDirectory = true;

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                filename = fileDialog.FileName;
                if (filename != "" && Empleados.Count > 0)
                {
                    string mensaje = administradorService.EnviarEmail(filename);

                    MessageBox.Show(mensaje, "Enviar EMail", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se especifico una ruta o no hay datos en el reporte.", "Enviar Email y PDF", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
