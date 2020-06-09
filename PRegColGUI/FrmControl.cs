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
    public partial class FrmControl : Form
    {
        public FrmControl()
        {
            InitializeComponent();
            customizeDesing();
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
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void EmpleadoControl_Load(object sender, EventArgs e)
        {

        }

        private void customizeDesing()
        {
            CPConsulta.Visible = false;
            CPDatos.Visible = false;
        }

        private void OcultarCPMenus()
        {
            if(CPConsulta.Visible == true)
            {
                CPConsulta.Visible = false;
            }
            if (CPDatos.Visible == true)
            {
                CPDatos.Visible = false;
            }
        }

        private void MostrarCPMenus(Panel CPMenu)
        {
            if(CPMenu.Visible == false)
            {
                OcultarCPMenus();
                CPMenu.Visible = true;
            }
            else
            {
                CPMenu.Visible = false;
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFromHija(new DatosEliminarFamilia());

        }

        private void CPLateral_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BTDatos_Click(object sender, EventArgs e)
        {
            MostrarCPMenus(CPDatos);
        }

        private void BTConsultas_Click_1(object sender, EventArgs e)
        {
            MostrarCPMenus(CPConsulta);
        }

        private void LBNombreU_Click(object sender, EventArgs e)
        {

        }

        private void BTConsulta1_Click_1(object sender, EventArgs e)
        {
            AbrirFromHija(new ConsultaBuscarPersona());
        }

        private void BTConsulta2_Click_1(object sender, EventArgs e)
        {
            AbrirFromHija(new ConsultaBuscarFamilia());
        }

        private void BTAgregarPersona_Click(object sender, EventArgs e)
        {
            AbrirFromHija(new DatosAgregarPersonaFamilia());
        }

        private void BTAgregarFamilia_Click(object sender, EventArgs e)
        {
            AbrirFromHija(new DatosAgregarFamilia());
        }

        private void BTCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTModificarPersona_Click(object sender, EventArgs e)
        {
            AbrirFromHija(new DatosModificarPersona());
        }

        private void BTElminarPersona_Click(object sender, EventArgs e)
        {
            AbrirFromHija(new DatosEliminarPersona());
        }

        private void CPCuadroBG_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
