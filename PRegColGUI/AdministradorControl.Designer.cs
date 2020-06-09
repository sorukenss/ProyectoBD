namespace PRegColGUI
{
    partial class AdministradorControl
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdministradorControl));
            this.LBInformacion2 = new System.Windows.Forms.Label();
            this.PBInformacion = new System.Windows.Forms.PictureBox();
            this.BTCerrarSesion = new System.Windows.Forms.Button();
            this.CPDatos = new System.Windows.Forms.Panel();
            this.BTEliminarFamilia = new System.Windows.Forms.Button();
            this.BTElminarPersona = new System.Windows.Forms.Button();
            this.BTModificarPersona = new System.Windows.Forms.Button();
            this.BTAgregarFamilia = new System.Windows.Forms.Button();
            this.BTAgregarPersona = new System.Windows.Forms.Button();
            this.LBInformacion3 = new System.Windows.Forms.Label();
            this.CPCuadroBG = new System.Windows.Forms.Panel();
            this.LBInformacion1 = new System.Windows.Forms.Label();
            this.CPBG = new System.Windows.Forms.Panel();
            this.BTConsulta2 = new System.Windows.Forms.Button();
            this.BTConsulta1 = new System.Windows.Forms.Button();
            this.BTDatos = new System.Windows.Forms.Button();
            this.CPConsulta = new System.Windows.Forms.Panel();
            this.BTBuscarEmpleado = new System.Windows.Forms.Button();
            this.BTConsultas = new System.Windows.Forms.Button();
            this.LBNombreU = new System.Windows.Forms.Label();
            this.LBRegcol = new System.Windows.Forms.Label();
            this.CPLateral = new System.Windows.Forms.Panel();
            this.CPEmpleados = new System.Windows.Forms.Panel();
            this.BTEliminarEmpleado = new System.Windows.Forms.Button();
            this.BTModificarEmpleado = new System.Windows.Forms.Button();
            this.BTAgregarEmpleado = new System.Windows.Forms.Button();
            this.BTDatosEmpleados = new System.Windows.Forms.Button();
            this.CPLogo = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.PBInformacion)).BeginInit();
            this.CPDatos.SuspendLayout();
            this.CPCuadroBG.SuspendLayout();
            this.CPConsulta.SuspendLayout();
            this.CPLateral.SuspendLayout();
            this.CPEmpleados.SuspendLayout();
            this.CPLogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // LBInformacion2
            // 
            this.LBInformacion2.AutoSize = true;
            this.LBInformacion2.Font = new System.Drawing.Font("SF Pro Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBInformacion2.Location = new System.Drawing.Point(180, 393);
            this.LBInformacion2.Name = "LBInformacion2";
            this.LBInformacion2.Size = new System.Drawing.Size(386, 26);
            this.LBInformacion2.TabIndex = 2;
            this.LBInformacion2.Text = "Un programa de caracterizacion familiar  ";
            // 
            // PBInformacion
            // 
            this.PBInformacion.Image = ((System.Drawing.Image)(resources.GetObject("PBInformacion.Image")));
            this.PBInformacion.Location = new System.Drawing.Point(168, 90);
            this.PBInformacion.Name = "PBInformacion";
            this.PBInformacion.Size = new System.Drawing.Size(598, 257);
            this.PBInformacion.TabIndex = 0;
            this.PBInformacion.TabStop = false;
            // 
            // BTCerrarSesion
            // 
            this.BTCerrarSesion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BTCerrarSesion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(121)))));
            this.BTCerrarSesion.FlatAppearance.BorderSize = 0;
            this.BTCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTCerrarSesion.Font = new System.Drawing.Font("SF Pro Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTCerrarSesion.ForeColor = System.Drawing.Color.White;
            this.BTCerrarSesion.Location = new System.Drawing.Point(0, 614);
            this.BTCerrarSesion.Name = "BTCerrarSesion";
            this.BTCerrarSesion.Size = new System.Drawing.Size(200, 44);
            this.BTCerrarSesion.TabIndex = 7;
            this.BTCerrarSesion.Text = "Cerrar Sesion";
            this.BTCerrarSesion.UseVisualStyleBackColor = true;
            this.BTCerrarSesion.Click += new System.EventHandler(this.BTCerrarSesion_Click);
            // 
            // CPDatos
            // 
            this.CPDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(91)))));
            this.CPDatos.Controls.Add(this.BTEliminarFamilia);
            this.CPDatos.Controls.Add(this.BTElminarPersona);
            this.CPDatos.Controls.Add(this.BTModificarPersona);
            this.CPDatos.Controls.Add(this.BTAgregarFamilia);
            this.CPDatos.Controls.Add(this.BTAgregarPersona);
            this.CPDatos.Dock = System.Windows.Forms.DockStyle.Top;
            this.CPDatos.Location = new System.Drawing.Point(0, 335);
            this.CPDatos.Name = "CPDatos";
            this.CPDatos.Size = new System.Drawing.Size(200, 146);
            this.CPDatos.TabIndex = 5;
            // 
            // BTEliminarFamilia
            // 
            this.BTEliminarFamilia.FlatAppearance.BorderSize = 0;
            this.BTEliminarFamilia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTEliminarFamilia.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTEliminarFamilia.ForeColor = System.Drawing.Color.White;
            this.BTEliminarFamilia.Location = new System.Drawing.Point(-2, 117);
            this.BTEliminarFamilia.Name = "BTEliminarFamilia";
            this.BTEliminarFamilia.Size = new System.Drawing.Size(218, 29);
            this.BTEliminarFamilia.TabIndex = 7;
            this.BTEliminarFamilia.Text = "Eliminar Familia";
            this.BTEliminarFamilia.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.BTEliminarFamilia.UseVisualStyleBackColor = true;
            this.BTEliminarFamilia.Click += new System.EventHandler(this.BTEliminarFamilia_Click);
            // 
            // BTElminarPersona
            // 
            this.BTElminarPersona.FlatAppearance.BorderSize = 0;
            this.BTElminarPersona.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTElminarPersona.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTElminarPersona.ForeColor = System.Drawing.Color.White;
            this.BTElminarPersona.Location = new System.Drawing.Point(0, 86);
            this.BTElminarPersona.Name = "BTElminarPersona";
            this.BTElminarPersona.Size = new System.Drawing.Size(218, 32);
            this.BTElminarPersona.TabIndex = 6;
            this.BTElminarPersona.Text = "Eliminar Persona";
            this.BTElminarPersona.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.BTElminarPersona.UseVisualStyleBackColor = true;
            this.BTElminarPersona.Click += new System.EventHandler(this.BTElminarPersona_Click_1);
            // 
            // BTModificarPersona
            // 
            this.BTModificarPersona.FlatAppearance.BorderSize = 0;
            this.BTModificarPersona.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTModificarPersona.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTModificarPersona.ForeColor = System.Drawing.Color.White;
            this.BTModificarPersona.Location = new System.Drawing.Point(0, 61);
            this.BTModificarPersona.Name = "BTModificarPersona";
            this.BTModificarPersona.Size = new System.Drawing.Size(218, 26);
            this.BTModificarPersona.TabIndex = 5;
            this.BTModificarPersona.Text = "Modificar Persona";
            this.BTModificarPersona.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.BTModificarPersona.UseVisualStyleBackColor = true;
            this.BTModificarPersona.Click += new System.EventHandler(this.BTModificarPersona_Click_1);
            // 
            // BTAgregarFamilia
            // 
            this.BTAgregarFamilia.FlatAppearance.BorderSize = 0;
            this.BTAgregarFamilia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTAgregarFamilia.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTAgregarFamilia.ForeColor = System.Drawing.Color.White;
            this.BTAgregarFamilia.Location = new System.Drawing.Point(0, 32);
            this.BTAgregarFamilia.Name = "BTAgregarFamilia";
            this.BTAgregarFamilia.Size = new System.Drawing.Size(218, 39);
            this.BTAgregarFamilia.TabIndex = 4;
            this.BTAgregarFamilia.Text = "Agregar Familia";
            this.BTAgregarFamilia.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.BTAgregarFamilia.UseVisualStyleBackColor = true;
            this.BTAgregarFamilia.Click += new System.EventHandler(this.BTAgregarFamilia_Click_1);
            // 
            // BTAgregarPersona
            // 
            this.BTAgregarPersona.FlatAppearance.BorderSize = 0;
            this.BTAgregarPersona.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTAgregarPersona.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTAgregarPersona.ForeColor = System.Drawing.Color.White;
            this.BTAgregarPersona.Location = new System.Drawing.Point(0, 0);
            this.BTAgregarPersona.Name = "BTAgregarPersona";
            this.BTAgregarPersona.Size = new System.Drawing.Size(218, 35);
            this.BTAgregarPersona.TabIndex = 3;
            this.BTAgregarPersona.Text = "Agregar Persona";
            this.BTAgregarPersona.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.BTAgregarPersona.UseVisualStyleBackColor = true;
            this.BTAgregarPersona.Click += new System.EventHandler(this.BTAgregarPersona_Click);
            // 
            // LBInformacion3
            // 
            this.LBInformacion3.AutoSize = true;
            this.LBInformacion3.Font = new System.Drawing.Font("SF Pro Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBInformacion3.Location = new System.Drawing.Point(235, 437);
            this.LBInformacion3.Name = "LBInformacion3";
            this.LBInformacion3.Size = new System.Drawing.Size(469, 26);
            this.LBInformacion3.TabIndex = 3;
            this.LBInformacion3.Text = "Desarrollado por: Felix Ochoa e Isaac Pimienta";
            // 
            // CPCuadroBG
            // 
            this.CPCuadroBG.Controls.Add(this.LBInformacion3);
            this.CPCuadroBG.Controls.Add(this.LBInformacion2);
            this.CPCuadroBG.Controls.Add(this.LBInformacion1);
            this.CPCuadroBG.Controls.Add(this.PBInformacion);
            this.CPCuadroBG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CPCuadroBG.Location = new System.Drawing.Point(218, 0);
            this.CPCuadroBG.Name = "CPCuadroBG";
            this.CPCuadroBG.Size = new System.Drawing.Size(922, 633);
            this.CPCuadroBG.TabIndex = 3;
            this.CPCuadroBG.Paint += new System.Windows.Forms.PaintEventHandler(this.CPCuadroBG_Paint);
            // 
            // LBInformacion1
            // 
            this.LBInformacion1.AutoSize = true;
            this.LBInformacion1.Font = new System.Drawing.Font("SF Pro Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBInformacion1.Location = new System.Drawing.Point(180, 370);
            this.LBInformacion1.Name = "LBInformacion1";
            this.LBInformacion1.Size = new System.Drawing.Size(650, 26);
            this.LBInformacion1.TabIndex = 1;
            this.LBInformacion1.Text = "Este programa ha sido desarrollado bajo C# gratuitamente para todos";
            // 
            // CPBG
            // 
            this.CPBG.Location = new System.Drawing.Point(213, -1);
            this.CPBG.Name = "CPBG";
            this.CPBG.Size = new System.Drawing.Size(913, 594);
            this.CPBG.TabIndex = 1;
            // 
            // BTConsulta2
            // 
            this.BTConsulta2.FlatAppearance.BorderSize = 0;
            this.BTConsulta2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTConsulta2.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTConsulta2.ForeColor = System.Drawing.Color.White;
            this.BTConsulta2.Location = new System.Drawing.Point(-2, 29);
            this.BTConsulta2.Name = "BTConsulta2";
            this.BTConsulta2.Size = new System.Drawing.Size(218, 27);
            this.BTConsulta2.TabIndex = 4;
            this.BTConsulta2.Text = "Buscar Familia";
            this.BTConsulta2.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.BTConsulta2.UseVisualStyleBackColor = true;
            this.BTConsulta2.Click += new System.EventHandler(this.BTConsulta2_Click);
            // 
            // BTConsulta1
            // 
            this.BTConsulta1.FlatAppearance.BorderSize = 0;
            this.BTConsulta1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTConsulta1.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTConsulta1.ForeColor = System.Drawing.Color.White;
            this.BTConsulta1.Location = new System.Drawing.Point(0, 0);
            this.BTConsulta1.Name = "BTConsulta1";
            this.BTConsulta1.Size = new System.Drawing.Size(218, 29);
            this.BTConsulta1.TabIndex = 3;
            this.BTConsulta1.Text = "Buscar Persona";
            this.BTConsulta1.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.BTConsulta1.UseVisualStyleBackColor = true;
            this.BTConsulta1.Click += new System.EventHandler(this.BTConsulta1_Click);
            // 
            // BTDatos
            // 
            this.BTDatos.Dock = System.Windows.Forms.DockStyle.Top;
            this.BTDatos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(121)))));
            this.BTDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTDatos.Font = new System.Drawing.Font("SF Pro Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTDatos.ForeColor = System.Drawing.Color.White;
            this.BTDatos.Location = new System.Drawing.Point(0, 291);
            this.BTDatos.Name = "BTDatos";
            this.BTDatos.Size = new System.Drawing.Size(200, 44);
            this.BTDatos.TabIndex = 6;
            this.BTDatos.Text = "Datos Familia";
            this.BTDatos.UseVisualStyleBackColor = true;
            this.BTDatos.Click += new System.EventHandler(this.BTDatos_Click);
            // 
            // CPConsulta
            // 
            this.CPConsulta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(91)))));
            this.CPConsulta.Controls.Add(this.BTBuscarEmpleado);
            this.CPConsulta.Controls.Add(this.BTConsulta2);
            this.CPConsulta.Controls.Add(this.BTConsulta1);
            this.CPConsulta.Dock = System.Windows.Forms.DockStyle.Top;
            this.CPConsulta.Location = new System.Drawing.Point(0, 204);
            this.CPConsulta.Name = "CPConsulta";
            this.CPConsulta.Size = new System.Drawing.Size(200, 87);
            this.CPConsulta.TabIndex = 3;
            // 
            // BTBuscarEmpleado
            // 
            this.BTBuscarEmpleado.FlatAppearance.BorderSize = 0;
            this.BTBuscarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTBuscarEmpleado.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTBuscarEmpleado.ForeColor = System.Drawing.Color.White;
            this.BTBuscarEmpleado.Location = new System.Drawing.Point(-2, 60);
            this.BTBuscarEmpleado.Name = "BTBuscarEmpleado";
            this.BTBuscarEmpleado.Size = new System.Drawing.Size(218, 27);
            this.BTBuscarEmpleado.TabIndex = 5;
            this.BTBuscarEmpleado.Text = "Buscar Empleado";
            this.BTBuscarEmpleado.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.BTBuscarEmpleado.UseVisualStyleBackColor = true;
            this.BTBuscarEmpleado.Click += new System.EventHandler(this.BTBuscarEmpleado_Click);
            // 
            // BTConsultas
            // 
            this.BTConsultas.Dock = System.Windows.Forms.DockStyle.Top;
            this.BTConsultas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(121)))));
            this.BTConsultas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTConsultas.Font = new System.Drawing.Font("SF Pro Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTConsultas.ForeColor = System.Drawing.Color.White;
            this.BTConsultas.Location = new System.Drawing.Point(0, 160);
            this.BTConsultas.Name = "BTConsultas";
            this.BTConsultas.Size = new System.Drawing.Size(200, 44);
            this.BTConsultas.TabIndex = 4;
            this.BTConsultas.Text = "Consulta";
            this.BTConsultas.UseVisualStyleBackColor = true;
            this.BTConsultas.Click += new System.EventHandler(this.BTConsultas_Click);
            // 
            // LBNombreU
            // 
            this.LBNombreU.AutoSize = true;
            this.LBNombreU.Cursor = System.Windows.Forms.Cursors.Default;
            this.LBNombreU.Dock = System.Windows.Forms.DockStyle.Top;
            this.LBNombreU.Font = new System.Drawing.Font("SF Pro Display", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBNombreU.ForeColor = System.Drawing.Color.White;
            this.LBNombreU.Location = new System.Drawing.Point(0, 130);
            this.LBNombreU.Name = "LBNombreU";
            this.LBNombreU.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LBNombreU.Size = new System.Drawing.Size(171, 30);
            this.LBNombreU.TabIndex = 2;
            this.LBNombreU.Text = "              Usuario";
            this.LBNombreU.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LBRegcol
            // 
            this.LBRegcol.AutoSize = true;
            this.LBRegcol.Font = new System.Drawing.Font("SF Pro Display", 24F, System.Drawing.FontStyle.Bold);
            this.LBRegcol.ForeColor = System.Drawing.Color.White;
            this.LBRegcol.Location = new System.Drawing.Point(34, 554);
            this.LBRegcol.Name = "LBRegcol";
            this.LBRegcol.Size = new System.Drawing.Size(166, 44);
            this.LBRegcol.TabIndex = 1;
            this.LBRegcol.Text = "REGCOL";
            // 
            // CPLateral
            // 
            this.CPLateral.AutoScroll = true;
            this.CPLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(81)))), ((int)(((byte)(137)))));
            this.CPLateral.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CPLateral.Controls.Add(this.CPEmpleados);
            this.CPLateral.Controls.Add(this.BTDatosEmpleados);
            this.CPLateral.Controls.Add(this.BTCerrarSesion);
            this.CPLateral.Controls.Add(this.CPDatos);
            this.CPLateral.Controls.Add(this.BTDatos);
            this.CPLateral.Controls.Add(this.CPConsulta);
            this.CPLateral.Controls.Add(this.BTConsultas);
            this.CPLateral.Controls.Add(this.LBNombreU);
            this.CPLateral.Controls.Add(this.CPLogo);
            this.CPLateral.Controls.Add(this.LBRegcol);
            this.CPLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.CPLateral.Location = new System.Drawing.Point(0, 0);
            this.CPLateral.Name = "CPLateral";
            this.CPLateral.Size = new System.Drawing.Size(218, 633);
            this.CPLateral.TabIndex = 2;
            // 
            // CPEmpleados
            // 
            this.CPEmpleados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(91)))));
            this.CPEmpleados.Controls.Add(this.BTEliminarEmpleado);
            this.CPEmpleados.Controls.Add(this.BTModificarEmpleado);
            this.CPEmpleados.Controls.Add(this.BTAgregarEmpleado);
            this.CPEmpleados.Dock = System.Windows.Forms.DockStyle.Top;
            this.CPEmpleados.Location = new System.Drawing.Point(0, 525);
            this.CPEmpleados.Name = "CPEmpleados";
            this.CPEmpleados.Size = new System.Drawing.Size(200, 89);
            this.CPEmpleados.TabIndex = 8;
            // 
            // BTEliminarEmpleado
            // 
            this.BTEliminarEmpleado.FlatAppearance.BorderSize = 0;
            this.BTEliminarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTEliminarEmpleado.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTEliminarEmpleado.ForeColor = System.Drawing.Color.White;
            this.BTEliminarEmpleado.Location = new System.Drawing.Point(0, 57);
            this.BTEliminarEmpleado.Name = "BTEliminarEmpleado";
            this.BTEliminarEmpleado.Size = new System.Drawing.Size(218, 28);
            this.BTEliminarEmpleado.TabIndex = 6;
            this.BTEliminarEmpleado.Text = "Eliminar Empleado";
            this.BTEliminarEmpleado.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.BTEliminarEmpleado.UseVisualStyleBackColor = true;
            this.BTEliminarEmpleado.Click += new System.EventHandler(this.BTEliminarEmpleado_Click);
            // 
            // BTModificarEmpleado
            // 
            this.BTModificarEmpleado.FlatAppearance.BorderSize = 0;
            this.BTModificarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTModificarEmpleado.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTModificarEmpleado.ForeColor = System.Drawing.Color.White;
            this.BTModificarEmpleado.Location = new System.Drawing.Point(-2, 28);
            this.BTModificarEmpleado.Name = "BTModificarEmpleado";
            this.BTModificarEmpleado.Size = new System.Drawing.Size(218, 33);
            this.BTModificarEmpleado.TabIndex = 5;
            this.BTModificarEmpleado.Text = "Modificar Empleado";
            this.BTModificarEmpleado.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.BTModificarEmpleado.UseVisualStyleBackColor = true;
            this.BTModificarEmpleado.Click += new System.EventHandler(this.BTModificarEmpleado_Click);
            // 
            // BTAgregarEmpleado
            // 
            this.BTAgregarEmpleado.FlatAppearance.BorderSize = 0;
            this.BTAgregarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTAgregarEmpleado.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTAgregarEmpleado.ForeColor = System.Drawing.Color.White;
            this.BTAgregarEmpleado.Location = new System.Drawing.Point(0, 0);
            this.BTAgregarEmpleado.Name = "BTAgregarEmpleado";
            this.BTAgregarEmpleado.Size = new System.Drawing.Size(218, 31);
            this.BTAgregarEmpleado.TabIndex = 3;
            this.BTAgregarEmpleado.Text = "Agregar Empleado";
            this.BTAgregarEmpleado.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.BTAgregarEmpleado.UseVisualStyleBackColor = true;
            this.BTAgregarEmpleado.Click += new System.EventHandler(this.BTAgregarEmpleado_Click);
            // 
            // BTDatosEmpleados
            // 
            this.BTDatosEmpleados.Dock = System.Windows.Forms.DockStyle.Top;
            this.BTDatosEmpleados.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(121)))));
            this.BTDatosEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTDatosEmpleados.Font = new System.Drawing.Font("SF Pro Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTDatosEmpleados.ForeColor = System.Drawing.Color.White;
            this.BTDatosEmpleados.Location = new System.Drawing.Point(0, 481);
            this.BTDatosEmpleados.Name = "BTDatosEmpleados";
            this.BTDatosEmpleados.Size = new System.Drawing.Size(200, 44);
            this.BTDatosEmpleados.TabIndex = 9;
            this.BTDatosEmpleados.Text = "Datos Empleados";
            this.BTDatosEmpleados.UseVisualStyleBackColor = true;
            this.BTDatosEmpleados.Click += new System.EventHandler(this.BTDatosEmpleados_Click);
            // 
            // CPLogo
            // 
            this.CPLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CPLogo.BackgroundImage")));
            this.CPLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CPLogo.Controls.Add(this.CPBG);
            this.CPLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.CPLogo.Location = new System.Drawing.Point(0, 0);
            this.CPLogo.Name = "CPLogo";
            this.CPLogo.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.CPLogo.Size = new System.Drawing.Size(200, 130);
            this.CPLogo.TabIndex = 1;
            // 
            // AdministradorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 633);
            this.Controls.Add(this.CPCuadroBG);
            this.Controls.Add(this.CPLateral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdministradorControl";
            this.Text = "AdministradorControl";
            ((System.ComponentModel.ISupportInitialize)(this.PBInformacion)).EndInit();
            this.CPDatos.ResumeLayout(false);
            this.CPCuadroBG.ResumeLayout(false);
            this.CPCuadroBG.PerformLayout();
            this.CPConsulta.ResumeLayout(false);
            this.CPLateral.ResumeLayout(false);
            this.CPLateral.PerformLayout();
            this.CPEmpleados.ResumeLayout(false);
            this.CPLogo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LBInformacion2;
        private System.Windows.Forms.PictureBox PBInformacion;
        private System.Windows.Forms.Button BTCerrarSesion;
        private System.Windows.Forms.Panel CPDatos;
        private System.Windows.Forms.Button BTEliminarFamilia;
        private System.Windows.Forms.Button BTElminarPersona;
        private System.Windows.Forms.Button BTModificarPersona;
        private System.Windows.Forms.Button BTAgregarFamilia;
        private System.Windows.Forms.Button BTAgregarPersona;
        private System.Windows.Forms.Label LBInformacion3;
        private System.Windows.Forms.Panel CPCuadroBG;
        private System.Windows.Forms.Label LBInformacion1;
        private System.Windows.Forms.Panel CPBG;
        private System.Windows.Forms.Button BTConsulta2;
        private System.Windows.Forms.Button BTConsulta1;
        private System.Windows.Forms.Button BTDatos;
        private System.Windows.Forms.Panel CPConsulta;
        private System.Windows.Forms.Button BTConsultas;
        private System.Windows.Forms.Label LBNombreU;
        private System.Windows.Forms.Label LBRegcol;
        private System.Windows.Forms.Panel CPLateral;
        private System.Windows.Forms.Panel CPLogo;
        private System.Windows.Forms.Panel CPEmpleados;
        private System.Windows.Forms.Button BTEliminarEmpleado;
        private System.Windows.Forms.Button BTModificarEmpleado;
        private System.Windows.Forms.Button BTAgregarEmpleado;
        private System.Windows.Forms.Button BTDatosEmpleados;
        private System.Windows.Forms.Button BTBuscarEmpleado;
    }
}