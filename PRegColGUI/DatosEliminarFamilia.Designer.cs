namespace PRegColGUI
{
    partial class DatosEliminarFamilia
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
            this.LBCedula = new System.Windows.Forms.Label();
            this.BTEliminar = new System.Windows.Forms.Button();
            this.TBCedula = new System.Windows.Forms.TextBox();
            this.LBEliminarFamilia = new System.Windows.Forms.Label();
            this.CPSemiBG.SuspendLayout();
            this.SuspendLayout();
            // 
            // CPSemiBG
            // 
            this.CPSemiBG.BackColor = System.Drawing.Color.White;
            this.CPSemiBG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CPSemiBG.Controls.Add(this.LBCedula);
            this.CPSemiBG.Controls.Add(this.BTEliminar);
            this.CPSemiBG.Controls.Add(this.TBCedula);
            this.CPSemiBG.ForeColor = System.Drawing.Color.Black;
            this.CPSemiBG.Location = new System.Drawing.Point(184, 140);
            this.CPSemiBG.Name = "CPSemiBG";
            this.CPSemiBG.Size = new System.Drawing.Size(539, 315);
            this.CPSemiBG.TabIndex = 5;
            // 
            // LBCedula
            // 
            this.LBCedula.AutoSize = true;
            this.LBCedula.Font = new System.Drawing.Font("SF Pro Display", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBCedula.Location = new System.Drawing.Point(58, 119);
            this.LBCedula.Name = "LBCedula";
            this.LBCedula.Size = new System.Drawing.Size(156, 28);
            this.LBCedula.TabIndex = 1;
            this.LBCedula.Text = "Codigo Familia";
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
            // TBCedula
            // 
            this.TBCedula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBCedula.Font = new System.Drawing.Font("SF Pro Display", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBCedula.Location = new System.Drawing.Point(220, 114);
            this.TBCedula.Name = "TBCedula";
            this.TBCedula.Size = new System.Drawing.Size(189, 38);
            this.TBCedula.TabIndex = 2;
            // 
            // LBEliminarFamilia
            // 
            this.LBEliminarFamilia.AutoSize = true;
            this.LBEliminarFamilia.Font = new System.Drawing.Font("SF Pro Display", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBEliminarFamilia.Location = new System.Drawing.Point(331, 57);
            this.LBEliminarFamilia.Name = "LBEliminarFamilia";
            this.LBEliminarFamilia.Size = new System.Drawing.Size(256, 40);
            this.LBEliminarFamilia.TabIndex = 3;
            this.LBEliminarFamilia.Text = "Eliminar Familia";
            // 
            // DatosEliminarFamilia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 594);
            this.Controls.Add(this.LBEliminarFamilia);
            this.Controls.Add(this.CPSemiBG);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DatosEliminarFamilia";
            this.Text = "DatosEliminarFamilia";
            this.CPSemiBG.ResumeLayout(false);
            this.CPSemiBG.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel CPSemiBG;
        private System.Windows.Forms.Label LBCedula;
        private System.Windows.Forms.Button BTEliminar;
        private System.Windows.Forms.TextBox TBCedula;
        private System.Windows.Forms.Label LBEliminarFamilia;
    }
}