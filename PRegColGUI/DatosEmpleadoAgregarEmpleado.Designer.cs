namespace PRegColGUI
{
    partial class DatosEmpleadoAgregarEmpleado
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
            this.CPSemiBG = new System.Windows.Forms.Panel();
            this.LBPassword = new System.Windows.Forms.Label();
            this.TBPassword = new System.Windows.Forms.TextBox();
            this.BTAgregar = new System.Windows.Forms.Button();
            this.CBSexo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TBCedula = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TBSegundoApellido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TBPrimerApellido = new System.Windows.Forms.TextBox();
            this.LBSegundoNombre = new System.Windows.Forms.Label();
            this.TBSegundoNombre = new System.Windows.Forms.TextBox();
            this.LBPrimerNombre = new System.Windows.Forms.Label();
            this.TBPrimerNombre = new System.Windows.Forms.TextBox();
            this.LBCorreoE = new System.Windows.Forms.Label();
            this.TBCorreoE = new System.Windows.Forms.TextBox();
            this.CPSemiBG.SuspendLayout();
            this.SuspendLayout();
            // 
            // CPSemiBG
            // 
            this.CPSemiBG.BackColor = System.Drawing.Color.White;
            this.CPSemiBG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CPSemiBG.Controls.Add(this.LBCorreoE);
            this.CPSemiBG.Controls.Add(this.TBCorreoE);
            this.CPSemiBG.Controls.Add(this.LBPassword);
            this.CPSemiBG.Controls.Add(this.TBPassword);
            this.CPSemiBG.Controls.Add(this.BTAgregar);
            this.CPSemiBG.Controls.Add(this.CBSexo);
            this.CPSemiBG.Controls.Add(this.label6);
            this.CPSemiBG.Controls.Add(this.label5);
            this.CPSemiBG.Controls.Add(this.TBCedula);
            this.CPSemiBG.Controls.Add(this.label4);
            this.CPSemiBG.Controls.Add(this.TBSegundoApellido);
            this.CPSemiBG.Controls.Add(this.label3);
            this.CPSemiBG.Controls.Add(this.TBPrimerApellido);
            this.CPSemiBG.Controls.Add(this.LBSegundoNombre);
            this.CPSemiBG.Controls.Add(this.TBSegundoNombre);
            this.CPSemiBG.Controls.Add(this.LBPrimerNombre);
            this.CPSemiBG.Controls.Add(this.TBPrimerNombre);
            this.CPSemiBG.ForeColor = System.Drawing.Color.Black;
            this.CPSemiBG.Location = new System.Drawing.Point(80, 86);
            this.CPSemiBG.Name = "CPSemiBG";
            this.CPSemiBG.Size = new System.Drawing.Size(747, 422);
            this.CPSemiBG.TabIndex = 5;
            // 
            // LBPassword
            // 
            this.LBPassword.AutoSize = true;
            this.LBPassword.Font = new System.Drawing.Font("SF Pro Display", 11F);
            this.LBPassword.Location = new System.Drawing.Point(401, 129);
            this.LBPassword.Name = "LBPassword";
            this.LBPassword.Size = new System.Drawing.Size(93, 20);
            this.LBPassword.TabIndex = 30;
            this.LBPassword.Text = "Contraseña";
            this.LBPassword.Click += new System.EventHandler(this.LBPassword_Click);
            // 
            // TBPassword
            // 
            this.TBPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBPassword.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold);
            this.TBPassword.Location = new System.Drawing.Point(500, 129);
            this.TBPassword.Name = "TBPassword";
            this.TBPassword.PasswordChar = '*';
            this.TBPassword.Size = new System.Drawing.Size(114, 29);
            this.TBPassword.TabIndex = 31;
            this.TBPassword.TextChanged += new System.EventHandler(this.TBPassword_TextChanged);
            // 
            // BTAgregar
            // 
            this.BTAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTAgregar.Font = new System.Drawing.Font("SF Pro Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTAgregar.Location = new System.Drawing.Point(254, 235);
            this.BTAgregar.Name = "BTAgregar";
            this.BTAgregar.Size = new System.Drawing.Size(215, 41);
            this.BTAgregar.TabIndex = 29;
            this.BTAgregar.Text = "Agregar empleado";
            this.BTAgregar.UseVisualStyleBackColor = true;
            this.BTAgregar.Click += new System.EventHandler(this.BTAgregar_Click);
            // 
            // CBSexo
            // 
            this.CBSexo.Font = new System.Drawing.Font("SF Pro Display", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBSexo.FormattingEnabled = true;
            this.CBSexo.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.CBSexo.Location = new System.Drawing.Point(500, 95);
            this.CBSexo.Name = "CBSexo";
            this.CBSexo.Size = new System.Drawing.Size(114, 31);
            this.CBSexo.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("SF Pro Display", 11F);
            this.label6.Location = new System.Drawing.Point(449, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 20);
            this.label6.TabIndex = 25;
            this.label6.Text = "Sexo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("SF Pro Display", 11F);
            this.label5.Location = new System.Drawing.Point(390, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "Identificacion";
            // 
            // TBCedula
            // 
            this.TBCedula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBCedula.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold);
            this.TBCedula.Location = new System.Drawing.Point(500, 60);
            this.TBCedula.Name = "TBCedula";
            this.TBCedula.Size = new System.Drawing.Size(114, 29);
            this.TBCedula.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("SF Pro Display", 11F);
            this.label4.Location = new System.Drawing.Point(81, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Segundo Apellido";
            // 
            // TBSegundoApellido
            // 
            this.TBSegundoApellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBSegundoApellido.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold);
            this.TBSegundoApellido.Location = new System.Drawing.Point(219, 160);
            this.TBSegundoApellido.Name = "TBSegundoApellido";
            this.TBSegundoApellido.Size = new System.Drawing.Size(114, 29);
            this.TBSegundoApellido.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("SF Pro Display", 11F);
            this.label3.Location = new System.Drawing.Point(99, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Primer Apellido";
            // 
            // TBPrimerApellido
            // 
            this.TBPrimerApellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBPrimerApellido.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold);
            this.TBPrimerApellido.Location = new System.Drawing.Point(219, 126);
            this.TBPrimerApellido.Name = "TBPrimerApellido";
            this.TBPrimerApellido.Size = new System.Drawing.Size(114, 29);
            this.TBPrimerApellido.TabIndex = 20;
            // 
            // LBSegundoNombre
            // 
            this.LBSegundoNombre.AutoSize = true;
            this.LBSegundoNombre.Font = new System.Drawing.Font("SF Pro Display", 11F);
            this.LBSegundoNombre.Location = new System.Drawing.Point(79, 95);
            this.LBSegundoNombre.Name = "LBSegundoNombre";
            this.LBSegundoNombre.Size = new System.Drawing.Size(134, 20);
            this.LBSegundoNombre.TabIndex = 17;
            this.LBSegundoNombre.Text = "Segundo Nombre";
            // 
            // TBSegundoNombre
            // 
            this.TBSegundoNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBSegundoNombre.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold);
            this.TBSegundoNombre.Location = new System.Drawing.Point(219, 92);
            this.TBSegundoNombre.Name = "TBSegundoNombre";
            this.TBSegundoNombre.Size = new System.Drawing.Size(114, 29);
            this.TBSegundoNombre.TabIndex = 18;
            // 
            // LBPrimerNombre
            // 
            this.LBPrimerNombre.AutoSize = true;
            this.LBPrimerNombre.Font = new System.Drawing.Font("SF Pro Display", 11F);
            this.LBPrimerNombre.Location = new System.Drawing.Point(97, 63);
            this.LBPrimerNombre.Name = "LBPrimerNombre";
            this.LBPrimerNombre.Size = new System.Drawing.Size(116, 20);
            this.LBPrimerNombre.TabIndex = 15;
            this.LBPrimerNombre.Text = "Primer Nombre";
            // 
            // TBPrimerNombre
            // 
            this.TBPrimerNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBPrimerNombre.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold);
            this.TBPrimerNombre.Location = new System.Drawing.Point(219, 60);
            this.TBPrimerNombre.Name = "TBPrimerNombre";
            this.TBPrimerNombre.Size = new System.Drawing.Size(114, 29);
            this.TBPrimerNombre.TabIndex = 16;
            // 
            // LBCorreoE
            // 
            this.LBCorreoE.AutoSize = true;
            this.LBCorreoE.Font = new System.Drawing.Font("SF Pro Display", 11F);
            this.LBCorreoE.Location = new System.Drawing.Point(354, 163);
            this.LBCorreoE.Name = "LBCorreoE";
            this.LBCorreoE.Size = new System.Drawing.Size(140, 20);
            this.LBCorreoE.TabIndex = 32;
            this.LBCorreoE.Text = "Correo electrónico";
            // 
            // TBCorreoE
            // 
            this.TBCorreoE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBCorreoE.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold);
            this.TBCorreoE.Location = new System.Drawing.Point(500, 160);
            this.TBCorreoE.Name = "TBCorreoE";
            this.TBCorreoE.Size = new System.Drawing.Size(114, 29);
            this.TBCorreoE.TabIndex = 33;
            this.TBCorreoE.TextChanged += new System.EventHandler(this.TBCorreoE_TextChanged);
            // 
            // DatosEmpleadoAgregarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 594);
            this.Controls.Add(this.CPSemiBG);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DatosEmpleadoAgregarEmpleado";
            this.Text = "DatosEmpleadoAgregarEmpleado";
            this.CPSemiBG.ResumeLayout(false);
            this.CPSemiBG.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel CPSemiBG;
        private System.Windows.Forms.ComboBox CBSexo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TBCedula;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TBSegundoApellido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBPrimerApellido;
        private System.Windows.Forms.Label LBSegundoNombre;
        private System.Windows.Forms.TextBox TBSegundoNombre;
        private System.Windows.Forms.Label LBPrimerNombre;
        private System.Windows.Forms.TextBox TBPrimerNombre;
        private System.Windows.Forms.Button BTAgregar;
        private System.Windows.Forms.Label LBPassword;
        private System.Windows.Forms.TextBox TBPassword;
        private System.Windows.Forms.Label LBCorreoE;
        private System.Windows.Forms.TextBox TBCorreoE;
    }
}