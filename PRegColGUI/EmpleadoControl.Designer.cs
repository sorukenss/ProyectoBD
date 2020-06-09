namespace PRegColGUI
{
    partial class EmpleadoControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmpleadoControl));
            this.CPLateral = new System.Windows.Forms.Panel();
            this.BTCerrarSesion = new System.Windows.Forms.Button();
            this.CPDatos = new System.Windows.Forms.Panel();
            this.BTEliminarFamilia = new System.Windows.Forms.Button();
            this.BTElminarPersona = new System.Windows.Forms.Button();
            this.BTModificarPersona = new System.Windows.Forms.Button();
            this.BTAgregarFamilia = new System.Windows.Forms.Button();
            this.BTAgregarPersona = new System.Windows.Forms.Button();
            this.BTDatos = new System.Windows.Forms.Button();
            this.CPConsulta = new System.Windows.Forms.Panel();
            this.BTConsulta2 = new System.Windows.Forms.Button();
            this.BTConsulta1 = new System.Windows.Forms.Button();
            this.BTConsultas = new System.Windows.Forms.Button();
            this.LBNombreU = new System.Windows.Forms.Label();
            this.CPLogo = new System.Windows.Forms.Panel();
            this.CPBG = new System.Windows.Forms.Panel();
            this.LBRegcol = new System.Windows.Forms.Label();
            this.CPCuadroBG = new System.Windows.Forms.Panel();
            this.LBInformacion3 = new System.Windows.Forms.Label();
            this.LBInformacion2 = new System.Windows.Forms.Label();
            this.LBInformacion1 = new System.Windows.Forms.Label();
            this.PBInformacion = new System.Windows.Forms.PictureBox();
            this.CPLateral.SuspendLayout();
            this.CPDatos.SuspendLayout();
            this.CPConsulta.SuspendLayout();
            this.CPLogo.SuspendLayout();
            this.CPCuadroBG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBInformacion)).BeginInit();
            this.SuspendLayout();
            // 
            // CPLateral
            // 
            this.CPLateral.AutoScroll = true;
            this.CPLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(81)))), ((int)(((byte)(137)))));
            this.CPLateral.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            this.CPLateral.Size = new System.Drawing.Size(218, 594);
            this.CPLateral.TabIndex = 0;
            this.CPLateral.Paint += new System.Windows.Forms.PaintEventHandler(this.CPLateral_Paint);
            // 
            // BTCerrarSesion
            // 
            this.BTCerrarSesion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BTCerrarSesion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(121)))));
            this.BTCerrarSesion.FlatAppearance.BorderSize = 0;
            this.BTCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTCerrarSesion.Font = new System.Drawing.Font("SF Pro Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTCerrarSesion.ForeColor = System.Drawing.Color.White;
            this.BTCerrarSesion.Location = new System.Drawing.Point(0, 597);
            this.BTCerrarSesion.Name = "BTCerrarSesion";
            this.BTCerrarSesion.Size = new System.Drawing.Size(197, 44);
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
            this.CPDatos.Location = new System.Drawing.Point(0, 347);
            this.CPDatos.Name = "CPDatos";
            this.CPDatos.Size = new System.Drawing.Size(197, 111);
            this.CPDatos.TabIndex = 5;
            // 
            // BTEliminarFamilia
            // 
            this.BTEliminarFamilia.FlatAppearance.BorderSize = 0;
            this.BTEliminarFamilia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTEliminarFamilia.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTEliminarFamilia.ForeColor = System.Drawing.Color.White;
            this.BTEliminarFamilia.Location = new System.Drawing.Point(1, 85);
            this.BTEliminarFamilia.Name = "BTEliminarFamilia";
            this.BTEliminarFamilia.Size = new System.Drawing.Size(218, 26);
            this.BTEliminarFamilia.TabIndex = 7;
            this.BTEliminarFamilia.Text = "Eliminar Familia";
            this.BTEliminarFamilia.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.BTEliminarFamilia.UseVisualStyleBackColor = true;
            this.BTEliminarFamilia.Click += new System.EventHandler(this.button1_Click);
            // 
            // BTElminarPersona
            // 
            this.BTElminarPersona.FlatAppearance.BorderSize = 0;
            this.BTElminarPersona.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTElminarPersona.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTElminarPersona.ForeColor = System.Drawing.Color.White;
            this.BTElminarPersona.Location = new System.Drawing.Point(0, 64);
            this.BTElminarPersona.Name = "BTElminarPersona";
            this.BTElminarPersona.Size = new System.Drawing.Size(218, 26);
            this.BTElminarPersona.TabIndex = 6;
            this.BTElminarPersona.Text = "Eliminar Persona";
            this.BTElminarPersona.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.BTElminarPersona.UseVisualStyleBackColor = true;
            this.BTElminarPersona.Click += new System.EventHandler(this.BTElminarPersona_Click);
            // 
            // BTModificarPersona
            // 
            this.BTModificarPersona.FlatAppearance.BorderSize = 0;
            this.BTModificarPersona.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTModificarPersona.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTModificarPersona.ForeColor = System.Drawing.Color.White;
            this.BTModificarPersona.Location = new System.Drawing.Point(0, 44);
            this.BTModificarPersona.Name = "BTModificarPersona";
            this.BTModificarPersona.Size = new System.Drawing.Size(218, 26);
            this.BTModificarPersona.TabIndex = 5;
            this.BTModificarPersona.Text = "Modificar Persona";
            this.BTModificarPersona.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.BTModificarPersona.UseVisualStyleBackColor = true;
            this.BTModificarPersona.Click += new System.EventHandler(this.BTModificarPersona_Click);
            // 
            // BTAgregarFamilia
            // 
            this.BTAgregarFamilia.FlatAppearance.BorderSize = 0;
            this.BTAgregarFamilia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTAgregarFamilia.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTAgregarFamilia.ForeColor = System.Drawing.Color.White;
            this.BTAgregarFamilia.Location = new System.Drawing.Point(0, 22);
            this.BTAgregarFamilia.Name = "BTAgregarFamilia";
            this.BTAgregarFamilia.Size = new System.Drawing.Size(218, 26);
            this.BTAgregarFamilia.TabIndex = 4;
            this.BTAgregarFamilia.Text = "Agregar Familia";
            this.BTAgregarFamilia.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.BTAgregarFamilia.UseVisualStyleBackColor = true;
            this.BTAgregarFamilia.Click += new System.EventHandler(this.BTAgregarFamilia_Click);
            // 
            // BTAgregarPersona
            // 
            this.BTAgregarPersona.FlatAppearance.BorderSize = 0;
            this.BTAgregarPersona.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTAgregarPersona.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTAgregarPersona.ForeColor = System.Drawing.Color.White;
            this.BTAgregarPersona.Location = new System.Drawing.Point(0, 0);
            this.BTAgregarPersona.Name = "BTAgregarPersona";
            this.BTAgregarPersona.Size = new System.Drawing.Size(218, 26);
            this.BTAgregarPersona.TabIndex = 3;
            this.BTAgregarPersona.Text = "Agregar Persona";
            this.BTAgregarPersona.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.BTAgregarPersona.UseVisualStyleBackColor = true;
            this.BTAgregarPersona.Click += new System.EventHandler(this.BTAgregarPersona_Click);
            // 
            // BTDatos
            // 
            this.BTDatos.Dock = System.Windows.Forms.DockStyle.Top;
            this.BTDatos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(121)))));
            this.BTDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTDatos.Font = new System.Drawing.Font("SF Pro Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTDatos.ForeColor = System.Drawing.Color.White;
            this.BTDatos.Location = new System.Drawing.Point(0, 303);
            this.BTDatos.Name = "BTDatos";
            this.BTDatos.Size = new System.Drawing.Size(197, 44);
            this.BTDatos.TabIndex = 6;
            this.BTDatos.Text = "Datos";
            this.BTDatos.UseVisualStyleBackColor = true;
            this.BTDatos.Click += new System.EventHandler(this.BTDatos_Click);
            // 
            // CPConsulta
            // 
            this.CPConsulta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(91)))));
            this.CPConsulta.Controls.Add(this.BTConsulta2);
            this.CPConsulta.Controls.Add(this.BTConsulta1);
            this.CPConsulta.Dock = System.Windows.Forms.DockStyle.Top;
            this.CPConsulta.Location = new System.Drawing.Point(0, 203);
            this.CPConsulta.Name = "CPConsulta";
            this.CPConsulta.Size = new System.Drawing.Size(197, 100);
            this.CPConsulta.TabIndex = 3;
            // 
            // BTConsulta2
            // 
            this.BTConsulta2.FlatAppearance.BorderSize = 0;
            this.BTConsulta2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTConsulta2.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTConsulta2.ForeColor = System.Drawing.Color.White;
            this.BTConsulta2.Location = new System.Drawing.Point(0, 51);
            this.BTConsulta2.Name = "BTConsulta2";
            this.BTConsulta2.Size = new System.Drawing.Size(218, 45);
            this.BTConsulta2.TabIndex = 4;
            this.BTConsulta2.Text = "Buscar Familia";
            this.BTConsulta2.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.BTConsulta2.UseVisualStyleBackColor = true;
            this.BTConsulta2.Click += new System.EventHandler(this.BTConsulta2_Click_1);
            // 
            // BTConsulta1
            // 
            this.BTConsulta1.FlatAppearance.BorderSize = 0;
            this.BTConsulta1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTConsulta1.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTConsulta1.ForeColor = System.Drawing.Color.White;
            this.BTConsulta1.Location = new System.Drawing.Point(0, 0);
            this.BTConsulta1.Name = "BTConsulta1";
            this.BTConsulta1.Size = new System.Drawing.Size(218, 45);
            this.BTConsulta1.TabIndex = 3;
            this.BTConsulta1.Text = "Buscar Persona";
            this.BTConsulta1.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.BTConsulta1.UseVisualStyleBackColor = true;
            this.BTConsulta1.Click += new System.EventHandler(this.BTConsulta1_Click_1);
            // 
            // BTConsultas
            // 
            this.BTConsultas.Dock = System.Windows.Forms.DockStyle.Top;
            this.BTConsultas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(121)))));
            this.BTConsultas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTConsultas.Font = new System.Drawing.Font("SF Pro Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTConsultas.ForeColor = System.Drawing.Color.White;
            this.BTConsultas.Location = new System.Drawing.Point(0, 159);
            this.BTConsultas.Name = "BTConsultas";
            this.BTConsultas.Size = new System.Drawing.Size(197, 44);
            this.BTConsultas.TabIndex = 4;
            this.BTConsultas.Text = "Consulta";
            this.BTConsultas.UseVisualStyleBackColor = true;
            this.BTConsultas.Click += new System.EventHandler(this.BTConsultas_Click_1);
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
            this.LBNombreU.Size = new System.Drawing.Size(197, 29);
            this.LBNombreU.TabIndex = 2;
            this.LBNombreU.Text = "Buen dia Usuario";
            this.LBNombreU.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LBNombreU.Click += new System.EventHandler(this.LBNombreU_Click);
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
            this.CPLogo.Size = new System.Drawing.Size(197, 130);
            this.CPLogo.TabIndex = 1;
            // 
            // CPBG
            // 
            this.CPBG.Location = new System.Drawing.Point(213, -1);
            this.CPBG.Name = "CPBG";
            this.CPBG.Size = new System.Drawing.Size(913, 594);
            this.CPBG.TabIndex = 1;
            // 
            // LBRegcol
            // 
            this.LBRegcol.AutoSize = true;
            this.LBRegcol.Font = new System.Drawing.Font("SF Pro Display", 24F, System.Drawing.FontStyle.Bold);
            this.LBRegcol.ForeColor = System.Drawing.Color.White;
            this.LBRegcol.Location = new System.Drawing.Point(34, 554);
            this.LBRegcol.Name = "LBRegcol";
            this.LBRegcol.Size = new System.Drawing.Size(162, 43);
            this.LBRegcol.TabIndex = 1;
            this.LBRegcol.Text = "REGCOL";
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
            this.CPCuadroBG.Size = new System.Drawing.Size(906, 594);
            this.CPCuadroBG.TabIndex = 1;
            this.CPCuadroBG.Paint += new System.Windows.Forms.PaintEventHandler(this.CPCuadroBG_Paint);
            // 
            // LBInformacion3
            // 
            this.LBInformacion3.AutoSize = true;
            this.LBInformacion3.Font = new System.Drawing.Font("SF Pro Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBInformacion3.Location = new System.Drawing.Point(247, 487);
            this.LBInformacion3.Name = "LBInformacion3";
            this.LBInformacion3.Size = new System.Drawing.Size(449, 25);
            this.LBInformacion3.TabIndex = 3;
            this.LBInformacion3.Text = "Desarrollado por: Felix Ochoa e Isaac Pimienta";
            // 
            // LBInformacion2
            // 
            this.LBInformacion2.AutoSize = true;
            this.LBInformacion2.Font = new System.Drawing.Font("SF Pro Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBInformacion2.Location = new System.Drawing.Point(177, 455);
            this.LBInformacion2.Name = "LBInformacion2";
            this.LBInformacion2.Size = new System.Drawing.Size(367, 25);
            this.LBInformacion2.TabIndex = 2;
            this.LBInformacion2.Text = "Un programa de caracterizacion familiar  ";
            // 
            // LBInformacion1
            // 
            this.LBInformacion1.AutoSize = true;
            this.LBInformacion1.Font = new System.Drawing.Font("SF Pro Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBInformacion1.Location = new System.Drawing.Point(177, 432);
            this.LBInformacion1.Name = "LBInformacion1";
            this.LBInformacion1.Size = new System.Drawing.Size(617, 25);
            this.LBInformacion1.TabIndex = 1;
            this.LBInformacion1.Text = "Este programa ha sido desarrollado bajo C# gratuitamente para todos";
            // 
            // PBInformacion
            // 
            this.PBInformacion.Image = ((System.Drawing.Image)(resources.GetObject("PBInformacion.Image")));
            this.PBInformacion.Location = new System.Drawing.Point(151, 127);
            this.PBInformacion.Name = "PBInformacion";
            this.PBInformacion.Size = new System.Drawing.Size(598, 302);
            this.PBInformacion.TabIndex = 0;
            this.PBInformacion.TabStop = false;
            // 
            // EmpleadoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1124, 594);
            this.Controls.Add(this.CPCuadroBG);
            this.Controls.Add(this.CPLateral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmpleadoControl";
            this.Text = "EmpleadoControl";
            this.Load += new System.EventHandler(this.EmpleadoControl_Load);
            this.CPLateral.ResumeLayout(false);
            this.CPLateral.PerformLayout();
            this.CPDatos.ResumeLayout(false);
            this.CPConsulta.ResumeLayout(false);
            this.CPLogo.ResumeLayout(false);
            this.CPCuadroBG.ResumeLayout(false);
            this.CPCuadroBG.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBInformacion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel CPLateral;
        private System.Windows.Forms.Label LBRegcol;
        private System.Windows.Forms.Panel CPLogo;
        private System.Windows.Forms.Panel CPDatos;
        private System.Windows.Forms.Button BTEliminarFamilia;
        private System.Windows.Forms.Button BTElminarPersona;
        private System.Windows.Forms.Button BTModificarPersona;
        private System.Windows.Forms.Button BTAgregarFamilia;
        private System.Windows.Forms.Button BTAgregarPersona;
        private System.Windows.Forms.Button BTDatos;
        private System.Windows.Forms.Panel CPConsulta;
        private System.Windows.Forms.Button BTConsulta2;
        private System.Windows.Forms.Button BTConsulta1;
        private System.Windows.Forms.Button BTConsultas;
        private System.Windows.Forms.Label LBNombreU;
        private System.Windows.Forms.Panel CPBG;
        private System.Windows.Forms.Panel CPCuadroBG;
        private System.Windows.Forms.Label LBInformacion3;
        private System.Windows.Forms.Label LBInformacion2;
        private System.Windows.Forms.Label LBInformacion1;
        private System.Windows.Forms.Button BTCerrarSesion;
        private System.Windows.Forms.PictureBox PBInformacion;
    }
}