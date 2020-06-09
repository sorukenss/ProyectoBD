namespace PRegColGUI
{
    partial class DatosEmpleadosEliminarEmpleado
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
            this.LBEliminarEmpleado = new System.Windows.Forms.Label();
            this.CPSemiBG = new System.Windows.Forms.Panel();
            this.LBUsuarioID = new System.Windows.Forms.Label();
            this.BTEliminar = new System.Windows.Forms.Button();
            this.TBUsuarioID = new System.Windows.Forms.TextBox();
            this.CPSemiBG.SuspendLayout();
            this.SuspendLayout();
            // 
            // LBEliminarEmpleado
            // 
            this.LBEliminarEmpleado.AutoSize = true;
            this.LBEliminarEmpleado.Font = new System.Drawing.Font("SF Pro Display", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBEliminarEmpleado.Location = new System.Drawing.Point(331, 98);
            this.LBEliminarEmpleado.Name = "LBEliminarEmpleado";
            this.LBEliminarEmpleado.Size = new System.Drawing.Size(300, 40);
            this.LBEliminarEmpleado.TabIndex = 8;
            this.LBEliminarEmpleado.Text = "Eliminar Empleado";
            // 
            // CPSemiBG
            // 
            this.CPSemiBG.BackColor = System.Drawing.Color.White;
            this.CPSemiBG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CPSemiBG.Controls.Add(this.LBUsuarioID);
            this.CPSemiBG.Controls.Add(this.BTEliminar);
            this.CPSemiBG.Controls.Add(this.TBUsuarioID);
            this.CPSemiBG.ForeColor = System.Drawing.Color.Black;
            this.CPSemiBG.Location = new System.Drawing.Point(184, 181);
            this.CPSemiBG.Name = "CPSemiBG";
            this.CPSemiBG.Size = new System.Drawing.Size(539, 315);
            this.CPSemiBG.TabIndex = 7;
            // 
            // LBUsuarioID
            // 
            this.LBUsuarioID.AutoSize = true;
            this.LBUsuarioID.Font = new System.Drawing.Font("SF Pro Display", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBUsuarioID.Location = new System.Drawing.Point(101, 119);
            this.LBUsuarioID.Name = "LBUsuarioID";
            this.LBUsuarioID.Size = new System.Drawing.Size(113, 28);
            this.LBUsuarioID.TabIndex = 1;
            this.LBUsuarioID.Text = "ID Usuario";
            // 
            // BTEliminar
            // 
            this.BTEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTEliminar.Font = new System.Drawing.Font("SF Pro Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTEliminar.Location = new System.Drawing.Point(219, 185);
            this.BTEliminar.Name = "BTEliminar";
            this.BTEliminar.Size = new System.Drawing.Size(92, 41);
            this.BTEliminar.TabIndex = 0;
            this.BTEliminar.Text = "Eliminar";
            this.BTEliminar.UseVisualStyleBackColor = true;
            this.BTEliminar.Click += new System.EventHandler(this.BTEliminar_Click);
            // 
            // TBUsuarioID
            // 
            this.TBUsuarioID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBUsuarioID.Font = new System.Drawing.Font("SF Pro Display", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBUsuarioID.Location = new System.Drawing.Point(220, 114);
            this.TBUsuarioID.Name = "TBUsuarioID";
            this.TBUsuarioID.Size = new System.Drawing.Size(189, 38);
            this.TBUsuarioID.TabIndex = 2;
            // 
            // DatosEmpleadosEliminarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 594);
            this.Controls.Add(this.LBEliminarEmpleado);
            this.Controls.Add(this.CPSemiBG);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DatosEmpleadosEliminarEmpleado";
            this.Text = "DatosEmpleadosEliminarEmpleado";
            this.CPSemiBG.ResumeLayout(false);
            this.CPSemiBG.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBEliminarEmpleado;
        private System.Windows.Forms.Panel CPSemiBG;
        private System.Windows.Forms.Label LBUsuarioID;
        private System.Windows.Forms.Button BTEliminar;
        private System.Windows.Forms.TextBox TBUsuarioID;
    }
}