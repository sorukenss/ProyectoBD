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
    public partial class FrmLogin : Form
    {
        AdministradorService administradorService;
        public FrmLogin()
        {
            administradorService = new AdministradorService(ConfigConection.connectionString);
            InitializeComponent();
            administradorService.ConsultarEmpleados();
        }

        private void CPCuadroblanco_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CPBackground_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LBInformacion_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AbrirFromHija(new AdministradorControl());
            Limpiar();
        }

        private void CPCajaAzul_Paint(object sender, PaintEventArgs e)
        {
        }

        private void LBUsuario_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

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
            CPBackground.Controls.Add(FormularioHija);
            CPBackground.Tag = FormularioHija;
            FormularioHija.BringToFront();
            FormularioHija.Show();
        }

        private void Limpiar()
        {
            TBUsuario.Text = "";
            TBPassword.Text = "";
        }

        private void BTEntrar_Click(object sender, EventArgs e)
        {
            if((TBUsuario.Text.Equals("1")) && (TBPassword.Text.Equals("1")))
            {
                AbrirFromHija(new AdministradorControl());
                Limpiar();
            }
            else if (administradorService.IniciarSesionEmpleado(TBUsuario.Text, TBPassword.Text) == true)
            {
                AbrirFromHija(new FrmControl());
                Limpiar();
            }
            else
            {
                MessageBox.Show("No se pudo encontrar el usuario.", "Fallo al Iniciar Sesion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Limpiar();
            }
            Limpiar();
        }

        private void BTPwVisible_Click(object sender, EventArgs e)
        {
            if(TBPassword.PasswordChar == '*')
            {
                TBPassword.PasswordChar = '\0';
            }
            else
            {
                TBPassword.PasswordChar = '*';
            }
        }
    }
}
