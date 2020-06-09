namespace PRegColGUI
{
    partial class ConsultaBuscarFamilia
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
            this.DVGFamilia = new System.Windows.Forms.DataGridView();
            this.LBFamilia = new System.Windows.Forms.Label();
            this.BTBuscar = new System.Windows.Forms.Button();
            this.TBFamiliaId = new System.Windows.Forms.TextBox();
            this.CPSemiBG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DVGFamilia)).BeginInit();
            this.SuspendLayout();
            // 
            // CPSemiBG
            // 
            this.CPSemiBG.BackColor = System.Drawing.Color.White;
            this.CPSemiBG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CPSemiBG.Controls.Add(this.DVGFamilia);
            this.CPSemiBG.Controls.Add(this.LBFamilia);
            this.CPSemiBG.Controls.Add(this.BTBuscar);
            this.CPSemiBG.Controls.Add(this.TBFamiliaId);
            this.CPSemiBG.ForeColor = System.Drawing.Color.Black;
            this.CPSemiBG.Location = new System.Drawing.Point(119, 73);
            this.CPSemiBG.Name = "CPSemiBG";
            this.CPSemiBG.Size = new System.Drawing.Size(657, 357);
            this.CPSemiBG.TabIndex = 4;
            // 
            // DVGFamilia
            // 
            this.DVGFamilia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DVGFamilia.Location = new System.Drawing.Point(66, 118);
            this.DVGFamilia.Name = "DVGFamilia";
            this.DVGFamilia.RowHeadersWidth = 43;
            this.DVGFamilia.Size = new System.Drawing.Size(532, 146);
            this.DVGFamilia.TabIndex = 3;
            // 
            // LBFamilia
            // 
            this.LBFamilia.AutoSize = true;
            this.LBFamilia.Font = new System.Drawing.Font("SF Pro Display", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBFamilia.Location = new System.Drawing.Point(79, 53);
            this.LBFamilia.Name = "LBFamilia";
            this.LBFamilia.Size = new System.Drawing.Size(156, 28);
            this.LBFamilia.TabIndex = 1;
            this.LBFamilia.Text = "Codigo Familia";
            // 
            // BTBuscar
            // 
            this.BTBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTBuscar.Font = new System.Drawing.Font("SF Pro Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTBuscar.Location = new System.Drawing.Point(467, 46);
            this.BTBuscar.Name = "BTBuscar";
            this.BTBuscar.Size = new System.Drawing.Size(92, 41);
            this.BTBuscar.TabIndex = 0;
            this.BTBuscar.Text = "Buscar";
            this.BTBuscar.UseVisualStyleBackColor = true;
            this.BTBuscar.Click += new System.EventHandler(this.BTBuscar_Click);
            // 
            // TBFamiliaId
            // 
            this.TBFamiliaId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBFamiliaId.Font = new System.Drawing.Font("SF Pro Display", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBFamiliaId.Location = new System.Drawing.Point(241, 48);
            this.TBFamiliaId.Name = "TBFamiliaId";
            this.TBFamiliaId.Size = new System.Drawing.Size(189, 38);
            this.TBFamiliaId.TabIndex = 2;
            // 
            // ConsultaBuscarFamilia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 594);
            this.Controls.Add(this.CPSemiBG);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConsultaBuscarFamilia";
            this.Text = "ConsultaBuscarFamilia";
            this.Load += new System.EventHandler(this.ConsultaBuscarFamilia_Load);
            this.CPSemiBG.ResumeLayout(false);
            this.CPSemiBG.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DVGFamilia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel CPSemiBG;
        private System.Windows.Forms.Label LBFamilia;
        private System.Windows.Forms.Button BTBuscar;
        private System.Windows.Forms.TextBox TBFamiliaId;
        private System.Windows.Forms.DataGridView DVGFamilia;
    }
}