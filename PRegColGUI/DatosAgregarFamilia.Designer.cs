namespace PRegColGUI
{
    partial class DatosAgregarFamilia
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
            this.LBCedula = new System.Windows.Forms.Label();
            this.BTAgregar = new System.Windows.Forms.Button();
            this.TBCedula = new System.Windows.Forms.TextBox();
            this.CPSemiBG = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.CPSemiBG.SuspendLayout();
            this.SuspendLayout();
            // 
            // LBCedula
            // 
            this.LBCedula.AutoSize = true;
            this.LBCedula.Font = new System.Drawing.Font("SF Pro Display", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBCedula.Location = new System.Drawing.Point(184, 131);
            this.LBCedula.Name = "LBCedula";
            this.LBCedula.Size = new System.Drawing.Size(163, 28);
            this.LBCedula.TabIndex = 1;
            this.LBCedula.Text = "Agregar Familia";
            this.LBCedula.Click += new System.EventHandler(this.LBCedula_Click);
            // 
            // BTAgregar
            // 
            this.BTAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTAgregar.Font = new System.Drawing.Font("SF Pro Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTAgregar.Location = new System.Drawing.Point(330, 240);
            this.BTAgregar.Name = "BTAgregar";
            this.BTAgregar.Size = new System.Drawing.Size(92, 41);
            this.BTAgregar.TabIndex = 0;
            this.BTAgregar.Text = "Agregar";
            this.BTAgregar.UseVisualStyleBackColor = true;
            this.BTAgregar.Click += new System.EventHandler(this.BTBuscar_Click);
            // 
            // TBCedula
            // 
            this.TBCedula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBCedula.Font = new System.Drawing.Font("SF Pro Display", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBCedula.Location = new System.Drawing.Point(353, 126);
            this.TBCedula.Name = "TBCedula";
            this.TBCedula.Size = new System.Drawing.Size(189, 38);
            this.TBCedula.TabIndex = 2;
            // 
            // CPSemiBG
            // 
            this.CPSemiBG.BackColor = System.Drawing.Color.White;
            this.CPSemiBG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CPSemiBG.Controls.Add(this.label1);
            this.CPSemiBG.Controls.Add(this.textBox1);
            this.CPSemiBG.Controls.Add(this.LBCedula);
            this.CPSemiBG.Controls.Add(this.BTAgregar);
            this.CPSemiBG.Controls.Add(this.TBCedula);
            this.CPSemiBG.ForeColor = System.Drawing.Color.Black;
            this.CPSemiBG.Location = new System.Drawing.Point(80, 73);
            this.CPSemiBG.Name = "CPSemiBG";
            this.CPSemiBG.Size = new System.Drawing.Size(747, 422);
            this.CPSemiBG.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SF Pro Display", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(225, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Integrantes";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("SF Pro Display", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(353, 172);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(189, 38);
            this.textBox1.TabIndex = 4;
            // 
            // DatosAgregarFamilia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 594);
            this.Controls.Add(this.CPSemiBG);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DatosAgregarFamilia";
            this.Text = "DatosAgregarFamilia";
            this.CPSemiBG.ResumeLayout(false);
            this.CPSemiBG.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LBCedula;
        private System.Windows.Forms.Button BTAgregar;
        private System.Windows.Forms.TextBox TBCedula;
        private System.Windows.Forms.Panel CPSemiBG;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}