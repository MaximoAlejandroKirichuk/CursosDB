namespace PracticaFINAL
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewCursos = new System.Windows.Forms.DataGridView();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.dataGridViewProspectos = new System.Windows.Forms.DataGridView();
            this.btnProspectosModificar = new System.Windows.Forms.Button();
            this.btnProspectosBorrar = new System.Windows.Forms.Button();
            this.btnAgregarPropectos = new System.Windows.Forms.Button();
            this.userControl11 = new PracticaFINAL.UserControl1();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCursos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProspectos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 260);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewCursos
            // 
            this.dataGridViewCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCursos.Location = new System.Drawing.Point(0, 18);
            this.dataGridViewCursos.Name = "dataGridViewCursos";
            this.dataGridViewCursos.Size = new System.Drawing.Size(417, 216);
            this.dataGridViewCursos.TabIndex = 1;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(99, 260);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 2;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(180, 260);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(18, 289);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(118, 25);
            this.btnExportar.TabIndex = 5;
            this.btnExportar.Text = "Exportar cursos";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // dataGridViewProspectos
            // 
            this.dataGridViewProspectos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProspectos.Location = new System.Drawing.Point(495, 51);
            this.dataGridViewProspectos.Name = "dataGridViewProspectos";
            this.dataGridViewProspectos.Size = new System.Drawing.Size(417, 216);
            this.dataGridViewProspectos.TabIndex = 7;
            // 
            // btnProspectosModificar
            // 
            this.btnProspectosModificar.Location = new System.Drawing.Point(658, 267);
            this.btnProspectosModificar.Name = "btnProspectosModificar";
            this.btnProspectosModificar.Size = new System.Drawing.Size(75, 23);
            this.btnProspectosModificar.TabIndex = 10;
            this.btnProspectosModificar.Text = "Modificar";
            this.btnProspectosModificar.UseVisualStyleBackColor = true;
            // 
            // btnProspectosBorrar
            // 
            this.btnProspectosBorrar.Location = new System.Drawing.Point(576, 267);
            this.btnProspectosBorrar.Name = "btnProspectosBorrar";
            this.btnProspectosBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnProspectosBorrar.TabIndex = 9;
            this.btnProspectosBorrar.Text = "Borrar";
            this.btnProspectosBorrar.UseVisualStyleBackColor = true;
            this.btnProspectosBorrar.Click += new System.EventHandler(this.btnProspectosBorrar_Click);
            // 
            // btnAgregarPropectos
            // 
            this.btnAgregarPropectos.Location = new System.Drawing.Point(495, 267);
            this.btnAgregarPropectos.Name = "btnAgregarPropectos";
            this.btnAgregarPropectos.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarPropectos.TabIndex = 8;
            this.btnAgregarPropectos.Text = "Agregar";
            this.btnAgregarPropectos.UseVisualStyleBackColor = true;
            this.btnAgregarPropectos.Click += new System.EventHandler(this.btnAgregarPropectos_Click);
            // 
            // userControl11
            // 
            this.userControl11.Location = new System.Drawing.Point(576, 322);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(322, 259);
            this.userControl11.TabIndex = 6;
            this.userControl11.Load += new System.EventHandler(this.userControl11_Load);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewCursos);
            this.groupBox1.Controls.Add(this.btnBorrar);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnModificar);
            this.groupBox1.Controls.Add(this.btnExportar);
            this.groupBox1.Location = new System.Drawing.Point(15, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(449, 330);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cursos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 588);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnProspectosModificar);
            this.Controls.Add(this.btnProspectosBorrar);
            this.Controls.Add(this.btnAgregarPropectos);
            this.Controls.Add(this.dataGridViewProspectos);
            this.Controls.Add(this.userControl11);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCursos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProspectos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridViewCursos;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnExportar;
        private UserControl1 userControl11;
        private System.Windows.Forms.DataGridView dataGridViewProspectos;
        private System.Windows.Forms.Button btnProspectosModificar;
        private System.Windows.Forms.Button btnProspectosBorrar;
        private System.Windows.Forms.Button btnAgregarPropectos;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

