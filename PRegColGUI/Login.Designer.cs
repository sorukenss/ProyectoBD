namespace PRegColGUI
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.CPBackground = new System.Windows.Forms.Panel();
            this.CPCajaAzul = new System.Windows.Forms.Panel();
            this.BTEntrar = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.TBPassword = new System.Windows.Forms.TextBox();
            this.PBLinea1 = new System.Windows.Forms.PictureBox();
            this.TBUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LBUsuario = new System.Windows.Forms.Label();
            this.CPCajaBlanca = new System.Windows.Forms.Panel();
            this.PBLlave = new System.Windows.Forms.PictureBox();
            this.LBInformacion3 = new System.Windows.Forms.Label();
            this.LBInformacion2 = new System.Windows.Forms.Label();
            this.LBInformacion = new System.Windows.Forms.Label();
            this.LBIniciarSesion = new System.Windows.Forms.Label();
            this.BTPwVisible = new System.Windows.Forms.Button();
            this.CPBackground.SuspendLayout();
            this.CPCajaAzul.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBLinea1)).BeginInit();
            this.CPCajaBlanca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBLlave)).BeginInit();
            this.SuspendLayout();
            // 
            // CPBackground
            // 
            this.CPBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.CPBackground.Controls.Add(this.CPCajaAzul);
            this.CPBackground.Controls.Add(this.CPCajaBlanca);
            this.CPBackground.Location = new System.Drawing.Point(-1, -2);
            this.CPBackground.Name = "CPBackground";
            this.CPBackground.Size = new System.Drawing.Size(1140, 633);
            this.CPBackground.TabIndex = 0;
            this.CPBackground.Paint += new System.Windows.Forms.PaintEventHandler(this.CPBackground_Paint);
            // 
            // CPCajaAzul
            // 
            this.CPCajaAzul.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(81)))), ((int)(((byte)(137)))));
            this.CPCajaAzul.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CPCajaAzul.Controls.Add(this.BTPwVisible);
            this.CPCajaAzul.Controls.Add(this.BTEntrar);
            this.CPCajaAzul.Controls.Add(this.pictureBox2);
            this.CPCajaAzul.Controls.Add(this.TBPassword);
            this.CPCajaAzul.Controls.Add(this.PBLinea1);
            this.CPCajaAzul.Controls.Add(this.TBUsuario);
            this.CPCajaAzul.Controls.Add(this.label1);
            this.CPCajaAzul.Controls.Add(this.LBUsuario);
            this.CPCajaAzul.Location = new System.Drawing.Point(507, 58);
            this.CPCajaAzul.Name = "CPCajaAzul";
            this.CPCajaAzul.Size = new System.Drawing.Size(493, 466);
            this.CPCajaAzul.TabIndex = 1;
            this.CPCajaAzul.Paint += new System.Windows.Forms.PaintEventHandler(this.CPCajaAzul_Paint);
            // 
            // BTEntrar
            // 
            this.BTEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTEntrar.Font = new System.Drawing.Font("SF Pro Display", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTEntrar.ForeColor = System.Drawing.Color.White;
            this.BTEntrar.Location = new System.Drawing.Point(182, 310);
            this.BTEntrar.Name = "BTEntrar";
            this.BTEntrar.Size = new System.Drawing.Size(122, 47);
            this.BTEntrar.TabIndex = 6;
            this.BTEntrar.Text = "Entrar";
            this.BTEntrar.UseVisualStyleBackColor = true;
            this.BTEntrar.Click += new System.EventHandler(this.BTEntrar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(87, 263);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(316, 1);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // TBPassword
            // 
            this.TBPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(81)))), ((int)(((byte)(137)))));
            this.TBPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBPassword.Font = new System.Drawing.Font("SF Pro Display", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBPassword.ForeColor = System.Drawing.Color.White;
            this.TBPassword.Location = new System.Drawing.Point(87, 232);
            this.TBPassword.Name = "TBPassword";
            this.TBPassword.PasswordChar = '*';
            this.TBPassword.Size = new System.Drawing.Size(306, 28);
            this.TBPassword.TabIndex = 4;
            // 
            // PBLinea1
            // 
            this.PBLinea1.Image = ((System.Drawing.Image)(resources.GetObject("PBLinea1.Image")));
            this.PBLinea1.Location = new System.Drawing.Point(87, 163);
            this.PBLinea1.Name = "PBLinea1";
            this.PBLinea1.Size = new System.Drawing.Size(316, 1);
            this.PBLinea1.TabIndex = 3;
            this.PBLinea1.TabStop = false;
            // 
            // TBUsuario
            // 
            this.TBUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(81)))), ((int)(((byte)(137)))));
            this.TBUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBUsuario.Font = new System.Drawing.Font("SF Pro Display", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBUsuario.ForeColor = System.Drawing.Color.White;
            this.TBUsuario.Location = new System.Drawing.Point(87, 132);
            this.TBUsuario.Name = "TBUsuario";
            this.TBUsuario.Size = new System.Drawing.Size(306, 28);
            this.TBUsuario.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SF Pro Display", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(92, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "CONTRASEÑA";
            // 
            // LBUsuario
            // 
            this.LBUsuario.AutoSize = true;
            this.LBUsuario.Font = new System.Drawing.Font("SF Pro Display", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBUsuario.ForeColor = System.Drawing.Color.White;
            this.LBUsuario.Location = new System.Drawing.Point(92, 98);
            this.LBUsuario.Name = "LBUsuario";
            this.LBUsuario.Size = new System.Drawing.Size(118, 29);
            this.LBUsuario.TabIndex = 0;
            this.LBUsuario.Text = "USUARIO";
            this.LBUsuario.Click += new System.EventHandler(this.LBUsuario_Click);
            // 
            // CPCajaBlanca
            // 
            this.CPCajaBlanca.BackColor = System.Drawing.Color.White;
            this.CPCajaBlanca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CPCajaBlanca.Controls.Add(this.PBLlave);
            this.CPCajaBlanca.Controls.Add(this.LBInformacion3);
            this.CPCajaBlanca.Controls.Add(this.LBInformacion2);
            this.CPCajaBlanca.Controls.Add(this.LBInformacion);
            this.CPCajaBlanca.Controls.Add(this.LBIniciarSesion);
            this.CPCajaBlanca.Location = new System.Drawing.Point(152, 157);
            this.CPCajaBlanca.Name = "CPCajaBlanca";
            this.CPCajaBlanca.Size = new System.Drawing.Size(520, 289);
            this.CPCajaBlanca.TabIndex = 0;
            this.CPCajaBlanca.Paint += new System.Windows.Forms.PaintEventHandler(this.CPCuadroblanco_Paint);
            // 
            // PBLlave
            // 
            this.PBLlave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PBLlave.Image = ((System.Drawing.Image)(resources.GetObject("PBLlave.Image")));
            this.PBLlave.Location = new System.Drawing.Point(149, 190);
            this.PBLlave.Name = "PBLlave";
            this.PBLlave.Size = new System.Drawing.Size(75, 69);
            this.PBLlave.TabIndex = 4;
            this.PBLlave.TabStop = false;
            this.PBLlave.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // LBInformacion3
            // 
            this.LBInformacion3.AutoSize = true;
            this.LBInformacion3.Font = new System.Drawing.Font("SF Pro Display", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBInformacion3.Location = new System.Drawing.Point(43, 160);
            this.LBInformacion3.Name = "LBInformacion3";
            this.LBInformacion3.Size = new System.Drawing.Size(109, 33);
            this.LBInformacion3.TabIndex = 3;
            this.LBInformacion3.Text = "seguro.";
            // 
            // LBInformacion2
            // 
            this.LBInformacion2.AutoSize = true;
            this.LBInformacion2.Font = new System.Drawing.Font("SF Pro Display", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBInformacion2.Location = new System.Drawing.Point(43, 131);
            this.LBInformacion2.Name = "LBInformacion2";
            this.LBInformacion2.Size = new System.Drawing.Size(279, 33);
            this.LBInformacion2.TabIndex = 2;
            this.LBInformacion2.Text = "Informacion en un lugar";
            // 
            // LBInformacion
            // 
            this.LBInformacion.AutoSize = true;
            this.LBInformacion.Font = new System.Drawing.Font("SF Pro Display", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBInformacion.Location = new System.Drawing.Point(43, 102);
            this.LBInformacion.Name = "LBInformacion";
            this.LBInformacion.Size = new System.Drawing.Size(263, 33);
            this.LBInformacion.TabIndex = 1;
            this.LBInformacion.Text = "Recuerda mantener la";
            this.LBInformacion.Click += new System.EventHandler(this.LBInformacion_Click);
            // 
            // LBIniciarSesion
            // 
            this.LBIniciarSesion.AutoSize = true;
            this.LBIniciarSesion.Font = new System.Drawing.Font("SF Pro Display", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBIniciarSesion.Location = new System.Drawing.Point(62, 34);
            this.LBIniciarSesion.Name = "LBIniciarSesion";
            this.LBIniciarSesion.Size = new System.Drawing.Size(254, 46);
            this.LBIniciarSesion.TabIndex = 0;
            this.LBIniciarSesion.Text = "Iniciar Sesion";
            // 
            // BTPwVisible
            // 
            this.BTPwVisible.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(81)))), ((int)(((byte)(137)))));
            this.BTPwVisible.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(81)))), ((int)(((byte)(137)))));
            this.BTPwVisible.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(81)))), ((int)(((byte)(137)))));
            this.BTPwVisible.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTPwVisible.Image = ((System.Drawing.Image)(resources.GetObject("BTPwVisible.Image")));
            this.BTPwVisible.Location = new System.Drawing.Point(362, 232);
            this.BTPwVisible.Name = "BTPwVisible";
            this.BTPwVisible.Size = new System.Drawing.Size(41, 28);
            this.BTPwVisible.TabIndex = 2;
            this.BTPwVisible.UseVisualStyleBackColor = true;
            this.BTPwVisible.Click += new System.EventHandler(this.BTPwVisible_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 631);
            this.Controls.Add(this.CPBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caracterizacion RegCol";
            this.Load += new System.EventHandler(this.Login_Load);
            this.CPBackground.ResumeLayout(false);
            this.CPCajaAzul.ResumeLayout(false);
            this.CPCajaAzul.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBLinea1)).EndInit();
            this.CPCajaBlanca.ResumeLayout(false);
            this.CPCajaBlanca.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBLlave)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel CPBackground;
        private System.Windows.Forms.Panel CPCajaBlanca;
        private System.Windows.Forms.Panel CPCajaAzul;
        private System.Windows.Forms.Label LBInformacion;
        private System.Windows.Forms.Label LBIniciarSesion;
        private System.Windows.Forms.Label LBInformacion3;
        private System.Windows.Forms.Label LBInformacion2;
        private System.Windows.Forms.PictureBox PBLlave;
        private System.Windows.Forms.Label LBUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBUsuario;
        private System.Windows.Forms.PictureBox PBLinea1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox TBPassword;
        private System.Windows.Forms.Button BTEntrar;
        private System.Windows.Forms.Button BTPwVisible;
    }
}

