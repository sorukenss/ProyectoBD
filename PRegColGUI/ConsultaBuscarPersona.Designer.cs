namespace PRegColGUI
{
    partial class ConsultaBuscarPersona
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
            this.BTBuscar = new System.Windows.Forms.Button();
            this.LBCedula = new System.Windows.Forms.Label();
            this.TBCedula = new System.Windows.Forms.TextBox();
            this.CPSemiBG = new System.Windows.Forms.Panel();
            this.DGVCedula = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.CPSemiBG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCedula)).BeginInit();
            this.SuspendLayout();
            // 
            // BTBuscar
            // 
            this.BTBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTBuscar.Font = new System.Drawing.Font("SF Pro Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTBuscar.Location = new System.Drawing.Point(473, 63);
            this.BTBuscar.Name = "BTBuscar";
            this.BTBuscar.Size = new System.Drawing.Size(92, 41);
            this.BTBuscar.TabIndex = 0;
            this.BTBuscar.Text = "Buscar";
            this.BTBuscar.UseVisualStyleBackColor = true;
            this.BTBuscar.Click += new System.EventHandler(this.BTBuscar_Click);
            // 
            // LBCedula
            // 
            this.LBCedula.AutoSize = true;
            this.LBCedula.Font = new System.Drawing.Font("SF Pro Display", 13F);
            this.LBCedula.Location = new System.Drawing.Point(188, 52);
            this.LBCedula.Name = "LBCedula";
            this.LBCedula.Size = new System.Drawing.Size(68, 23);
            this.LBCedula.TabIndex = 1;
            this.LBCedula.Text = "Cedula";
            this.LBCedula.Click += new System.EventHandler(this.LBCedula_Click);
            // 
            // TBCedula
            // 
            this.TBCedula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBCedula.Font = new System.Drawing.Font("SF Pro Display", 15F, System.Drawing.FontStyle.Bold);
            this.TBCedula.Location = new System.Drawing.Point(262, 43);
            this.TBCedula.Name = "TBCedula";
            this.TBCedula.Size = new System.Drawing.Size(189, 33);
            this.TBCedula.TabIndex = 2;
            this.TBCedula.TextChanged += new System.EventHandler(this.TBCedula_TextChanged);
            // 
            // CPSemiBG
            // 
            this.CPSemiBG.BackColor = System.Drawing.Color.White;
            this.CPSemiBG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CPSemiBG.Controls.Add(this.label1);
            this.CPSemiBG.Controls.Add(this.textBox1);
            this.CPSemiBG.Controls.Add(this.DGVCedula);
            this.CPSemiBG.Controls.Add(this.LBCedula);
            this.CPSemiBG.Controls.Add(this.BTBuscar);
            this.CPSemiBG.Controls.Add(this.TBCedula);
            this.CPSemiBG.ForeColor = System.Drawing.Color.Black;
            this.CPSemiBG.Location = new System.Drawing.Point(76, 36);
            this.CPSemiBG.Name = "CPSemiBG";
            this.CPSemiBG.Size = new System.Drawing.Size(747, 528);
            this.CPSemiBG.TabIndex = 3;
            this.CPSemiBG.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // DGVCedula
            // 
            this.DGVCedula.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVCedula.Location = new System.Drawing.Point(75, 131);
            this.DGVCedula.Name = "DGVCedula";
            this.DGVCedula.RowHeadersWidth = 43;
            this.DGVCedula.Size = new System.Drawing.Size(594, 347);
            this.DGVCedula.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SF Pro Display", 13F);
            this.label1.Location = new System.Drawing.Point(128, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Codigo Familia";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("SF Pro Display", 15F, System.Drawing.FontStyle.Bold);
            this.textBox1.Location = new System.Drawing.Point(262, 82);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(189, 33);
            this.textBox1.TabIndex = 5;
            // 
            // ConsultaBuscarPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 594);
            this.Controls.Add(this.CPSemiBG);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConsultaBuscarPersona";
            this.Text = "ConsultaBuscarPersona";
            this.CPSemiBG.ResumeLayout(false);
            this.CPSemiBG.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCedula)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTBuscar;
        private System.Windows.Forms.Label LBCedula;
        private System.Windows.Forms.TextBox TBCedula;
        private System.Windows.Forms.Panel CPSemiBG;
        private System.Windows.Forms.DataGridView DGVCedula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}