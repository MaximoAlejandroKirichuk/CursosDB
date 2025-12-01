namespace PracticaFINAL
{
    partial class UserControl1
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewC = new System.Windows.Forms.DataGridView();
            this.btnImportar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewC)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewC
            // 
            this.dataGridViewC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewC.Location = new System.Drawing.Point(13, 52);
            this.dataGridViewC.Name = "dataGridViewC";
            this.dataGridViewC.Size = new System.Drawing.Size(303, 150);
            this.dataGridViewC.TabIndex = 0;
            // 
            // btnImportar
            // 
            this.btnImportar.Location = new System.Drawing.Point(63, 228);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(118, 25);
            this.btnImportar.TabIndex = 1;
            this.btnImportar.Text = "Importar cursos";
            this.btnImportar.UseVisualStyleBackColor = true;
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnImportar);
            this.Controls.Add(this.dataGridViewC);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(342, 281);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewC;
        private System.Windows.Forms.Button btnImportar;
    }
}
