namespace PRegColGUI
{
    partial class ConsultaBuscarEmpleado
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
            this.BTVisualizarDatos = new System.Windows.Forms.Button();
            this.DGVVisualizarEmpleado = new System.Windows.Forms.DataGridView();
            this.BTGenerarPDF = new System.Windows.Forms.Button();
            this.BTEnviarCorreo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVVisualizarEmpleado)).BeginInit();
            this.SuspendLayout();
            // 
            // BTVisualizarDatos
            // 
            this.BTVisualizarDatos.Font = new System.Drawing.Font("SF Pro Display", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTVisualizarDatos.Location = new System.Drawing.Point(159, 440);
            this.BTVisualizarDatos.Name = "BTVisualizarDatos";
            this.BTVisualizarDatos.Size = new System.Drawing.Size(191, 48);
            this.BTVisualizarDatos.TabIndex = 1;
            this.BTVisualizarDatos.Text = "Visualizar Datos";
            this.BTVisualizarDatos.UseVisualStyleBackColor = true;
            this.BTVisualizarDatos.Click += new System.EventHandler(this.BTVisualizarDatos_Click);
            // 
            // DGVVisualizarEmpleado
            // 
            this.DGVVisualizarEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVVisualizarEmpleado.Location = new System.Drawing.Point(89, 70);
            this.DGVVisualizarEmpleado.Name = "DGVVisualizarEmpleado";
            this.DGVVisualizarEmpleado.RowHeadersWidth = 47;
            this.DGVVisualizarEmpleado.Size = new System.Drawing.Size(750, 364);
            this.DGVVisualizarEmpleado.TabIndex = 0;
            this.DGVVisualizarEmpleado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // BTGenerarPDF
            // 
            this.BTGenerarPDF.Font = new System.Drawing.Font("SF Pro Display", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTGenerarPDF.Location = new System.Drawing.Point(373, 440);
            this.BTGenerarPDF.Name = "BTGenerarPDF";
            this.BTGenerarPDF.Size = new System.Drawing.Size(191, 48);
            this.BTGenerarPDF.TabIndex = 2;
            this.BTGenerarPDF.Text = "Generar PDF";
            this.BTGenerarPDF.UseVisualStyleBackColor = true;
            this.BTGenerarPDF.Click += new System.EventHandler(this.BTGenerarPDF_Click);
            // 
            // BTEnviarCorreo
            // 
            this.BTEnviarCorreo.Font = new System.Drawing.Font("SF Pro Display", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTEnviarCorreo.Location = new System.Drawing.Point(585, 440);
            this.BTEnviarCorreo.Name = "BTEnviarCorreo";
            this.BTEnviarCorreo.Size = new System.Drawing.Size(191, 48);
            this.BTEnviarCorreo.TabIndex = 3;
            this.BTEnviarCorreo.Text = "Enviar Correo";
            this.BTEnviarCorreo.UseVisualStyleBackColor = true;
            this.BTEnviarCorreo.Click += new System.EventHandler(this.BTEnviarCorreo_Click);
            // 
            // ConsultaBuscarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 594);
            this.Controls.Add(this.BTEnviarCorreo);
            this.Controls.Add(this.BTGenerarPDF);
            this.Controls.Add(this.BTVisualizarDatos);
            this.Controls.Add(this.DGVVisualizarEmpleado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConsultaBuscarEmpleado";
            this.Text = "ConsultaBuscarEmpleado";
            this.Load += new System.EventHandler(this.ConsultaBuscarEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVVisualizarEmpleado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BTVisualizarDatos;
        private System.Windows.Forms.DataGridView DGVVisualizarEmpleado;
        private System.Windows.Forms.Button BTGenerarPDF;
        private System.Windows.Forms.Button BTEnviarCorreo;
    }
}