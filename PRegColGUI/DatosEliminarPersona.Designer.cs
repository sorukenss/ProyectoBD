namespace PRegColGUI
{
    partial class DatosEliminarPersona
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
            this.LBIdentificacion = new System.Windows.Forms.Label();
            this.BTEliminar = new System.Windows.Forms.Button();
            this.TBIdentificacion = new System.Windows.Forms.TextBox();
            this.LBEliminarPersona = new System.Windows.Forms.Label();
            this.LBCodigoFamilia = new System.Windows.Forms.Label();
            this.TBCodigoFamilia = new System.Windows.Forms.TextBox();
            this.CPSemiBG.SuspendLayout();
            this.SuspendLayout();
            // 
            // CPSemiBG
            // 
            this.CPSemiBG.BackColor = System.Drawing.Color.White;
            this.CPSemiBG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CPSemiBG.Controls.Add(this.LBCodigoFamilia);
            this.CPSemiBG.Controls.Add(this.LBIdentificacion);
            this.CPSemiBG.Controls.Add(this.TBCodigoFamilia);
            this.CPSemiBG.Controls.Add(this.BTEliminar);
            this.CPSemiBG.Controls.Add(this.TBIdentificacion);
            this.CPSemiBG.ForeColor = System.Drawing.Color.Black;
            this.CPSemiBG.Location = new System.Drawing.Point(184, 140);
            this.CPSemiBG.Name = "CPSemiBG";
            this.CPSemiBG.Size = new System.Drawing.Size(539, 315);
            this.CPSemiBG.TabIndex = 5;
            // 
            // LBIdentificacion
            // 
            this.LBIdentificacion.AutoSize = true;
            this.LBIdentificacion.Font = new System.Drawing.Font("SF Pro Display", 13F);
            this.LBIdentificacion.Location = new System.Drawing.Point(95, 96);
            this.LBIdentificacion.Name = "LBIdentificacion";
            this.LBIdentificacion.Size = new System.Drawing.Size(119, 23);
            this.LBIdentificacion.TabIndex = 1;
            this.LBIdentificacion.Text = "Identificacion";
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
            // TBIdentificacion
            // 
            this.TBIdentificacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBIdentificacion.Font = new System.Drawing.Font("SF Pro Display", 15F, System.Drawing.FontStyle.Bold);
            this.TBIdentificacion.Location = new System.Drawing.Point(220, 91);
            this.TBIdentificacion.Name = "TBIdentificacion";
            this.TBIdentificacion.Size = new System.Drawing.Size(189, 33);
            this.TBIdentificacion.TabIndex = 2;
            // 
            // LBEliminarPersona
            // 
            this.LBEliminarPersona.AutoSize = true;
            this.LBEliminarPersona.Font = new System.Drawing.Font("SF Pro Display", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBEliminarPersona.Location = new System.Drawing.Point(331, 57);
            this.LBEliminarPersona.Name = "LBEliminarPersona";
            this.LBEliminarPersona.Size = new System.Drawing.Size(274, 40);
            this.LBEliminarPersona.TabIndex = 6;
            this.LBEliminarPersona.Text = "Eliminar Persona";
            // 
            // LBCodigoFamilia
            // 
            this.LBCodigoFamilia.AutoSize = true;
            this.LBCodigoFamilia.Font = new System.Drawing.Font("SF Pro Display", 13F);
            this.LBCodigoFamilia.Location = new System.Drawing.Point(86, 133);
            this.LBCodigoFamilia.Name = "LBCodigoFamilia";
            this.LBCodigoFamilia.Size = new System.Drawing.Size(128, 23);
            this.LBCodigoFamilia.TabIndex = 7;
            this.LBCodigoFamilia.Text = "Codigo Familia";
            // 
            // TBCodigoFamilia
            // 
            this.TBCodigoFamilia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBCodigoFamilia.Font = new System.Drawing.Font("SF Pro Display", 15F, System.Drawing.FontStyle.Bold);
            this.TBCodigoFamilia.Location = new System.Drawing.Point(220, 133);
            this.TBCodigoFamilia.Name = "TBCodigoFamilia";
            this.TBCodigoFamilia.Size = new System.Drawing.Size(189, 33);
            this.TBCodigoFamilia.TabIndex = 8;
            // 
            // DatosEliminarPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 594);
            this.Controls.Add(this.LBEliminarPersona);
            this.Controls.Add(this.CPSemiBG);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DatosEliminarPersona";
            this.Text = "DatosEliminarPersona";
            this.CPSemiBG.ResumeLayout(false);
            this.CPSemiBG.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel CPSemiBG;
        private System.Windows.Forms.Label LBIdentificacion;
        private System.Windows.Forms.Button BTEliminar;
        private System.Windows.Forms.TextBox TBIdentificacion;
        private System.Windows.Forms.Label LBEliminarPersona;
        private System.Windows.Forms.Label LBCodigoFamilia;
        private System.Windows.Forms.TextBox TBCodigoFamilia;
    }
}