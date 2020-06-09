using BLL;
using Entity;
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
    public partial class DatosEmpleadoAgregarEmpleado : Form
    {
        AdministradorService administradorService;
        public DatosEmpleadoAgregarEmpleado()
        {
            administradorService = new AdministradorService(ConfigConection.connectionString);
            InitializeComponent();
        }

        private Empleado MapearEmpleado()
        {
            Empleado empleado = new Empleado();
            empleado.Cedula = TBCedula.Text;
            empleado.primerNombre = TBPrimerNombre.Text;
            empleado.segundoNombre = TBSegundoNombre.Text;
            empleado.primerApellido = TBPrimerApellido.Text;
            empleado.segundoApellido = TBSegundoApellido.Text;
            empleado.Sexo = CBSexo.Text;
            empleado.Password = TBPassword.Text;
            empleado.Email = TBCorreoE.Text;

            return empleado;
        }

        private void Limpiar()
        {
            TBPrimerNombre.Text = "";
            TBSegundoNombre.Text = "";
            TBPrimerApellido.Text = "";
            TBSegundoApellido.Text = "";
            CBSexo.Text = "";
            TBCedula.Text = "";
            TBPassword.Text = "";
            TBCorreoE.Text = "";
        }
        private void BTAgregar_Click(object sender, EventArgs e)
        {
            Empleado empleado = MapearEmpleado();
            MessageBox.Show(administradorService.GuardarEmpleado(empleado), "Mensaje de Agregar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Limpiar();
        }

        private void LBPassword_Click(object sender, EventArgs e)
        {

        }

        private void TBPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBCorreoE_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
