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
    public partial class AdministradorControl : Form
    {
        public AdministradorControl()
        {
            InitializeComponent();
            customizeDesing();
        }

        private void customizeDesing()
        {
            CPConsulta.Visible = false;
            CPDatos.Visible = false;
            CPEmpleados.Visible = false;
        }

        private void OcultarCPMenus()
        {
            if (CPConsulta.Visible == true)
            {
                CPConsulta.Visible = false;
            }
            if (CPDatos.Visible == true)
            {
                CPDatos.Visible = false;
            }
            if (CPEmpleados.Visible == true)
            {
                CPEmpleados.Visible = false;
            }
        }

        private void MostrarCPMenus(Panel CPMenu)
        {
            if (CPMenu.Visible == false)
            {
                OcultarCPMenus();
                CPMenu.Visible = true;
            }
            else
            {
                CPMenu.Visible = false;
            }

        }

        private Form activeForm = null;

        private void AbrirFromHija(Form FormularioHija)
        {

            if (activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = FormularioHija;

            FormularioHija.TopLevel = false;
            FormularioHija.FormBorderStyle = FormBorderStyle.None;
            FormularioHija.Dock = DockStyle.Fill;
            CPCuadroBG.Controls.Add(FormularioHija);
            CPCuadroBG.Tag = FormularioHija;
            FormularioHija.BringToFront();
            FormularioHija.Show();
        }

        private void BTAgregarPersona_Click(object sender, EventArgs e)
        {
            AbrirFromHija(new DatosAgregarPersonaFamilia());
        }

        private void BTConsultas_Click(object sender, EventArgs e)
        {
            MostrarCPMenus(CPConsulta);
        }

        private void BTDatos_Click(object sender, EventArgs e)
        {
            MostrarCPMenus(CPDatos);

        }

        private void BTDatosEmpleados_Click(object sender, EventArgs e)
        {
            MostrarCPMenus(CPEmpleados);

        }

        private void BTConsulta1_Click(object sender, EventArgs e)
        {
            AbrirFromHija(new ConsultaBuscarPersona());
        }

        private void BTConsulta2_Click_1(object sender, EventArgs e)
        {
            AbrirFromHija(new ConsultaBuscarFamilia());
        }

        private void BTAgregarEmpleado_Click(object sender, EventArgs e)
        {
            AbrirFromHija(new DatosEmpleadoAgregarEmpleado());
        }

        private void BTModificarEmpleado_Click(object sender, EventArgs e)
        {
            AbrirFromHija(new DatosEmpleadosModificarEmpleado());
        }

        private void BTEliminarEmpleado_Click(object sender, EventArgs e)
        {
            AbrirFromHija(new DatosEmpleadosEliminarEmpleado());
        }

        private void BTModificarPersona_Click_1(object sender, EventArgs e)
        {
            AbrirFromHija(new DatosModificarPersona());
        }

        private void BTElminarPersona_Click_1(object sender, EventArgs e)
        {
            AbrirFromHija(new DatosEliminarPersona());
        }

        private void BTEliminarFamilia_Click(object sender, EventArgs e)
        {
            AbrirFromHija(new DatosEliminarFamilia());
        }

        private void BTAgregarFamilia_Click_1(object sender, EventArgs e)
        {
            AbrirFromHija(new DatosAgregarFamilia());
        }

        private void BTCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTConsulta2_Click(object sender, EventArgs e)
        {
            AbrirFromHija(new ConsultaBuscarFamilia());
        }

        private void CPCuadroBG_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BTBuscarEmpleado_Click(object sender, EventArgs e)
        {
            AbrirFromHija(new ConsultaBuscarEmpleado());
        }
    }
}

