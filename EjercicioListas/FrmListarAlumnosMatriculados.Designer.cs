namespace EjercicioListas
{
    partial class FrmListarAlumnosMatriculados
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
            this.listBoxCursos = new System.Windows.Forms.ListBox();
            this.listBoxAlumnos = new System.Windows.Forms.ListBox();
            this.lblCursos = new System.Windows.Forms.Label();
            this.lblAlumnos = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxCursos
            // 
            this.listBoxCursos.FormattingEnabled = true;
            this.listBoxCursos.Location = new System.Drawing.Point(12, 60);
            this.listBoxCursos.Name = "listBoxCursos";
            this.listBoxCursos.Size = new System.Drawing.Size(109, 199);
            this.listBoxCursos.TabIndex = 0;
            this.listBoxCursos.SelectedIndexChanged += new System.EventHandler(this.listBoxCursos_SelectedIndexChanged);
            // 
            // listBoxAlumnos
            // 
            this.listBoxAlumnos.FormattingEnabled = true;
            this.listBoxAlumnos.Location = new System.Drawing.Point(204, 60);
            this.listBoxAlumnos.Name = "listBoxAlumnos";
            this.listBoxAlumnos.Size = new System.Drawing.Size(120, 199);
            this.listBoxAlumnos.TabIndex = 1;
            // 
            // lblCursos
            // 
            this.lblCursos.AutoSize = true;
            this.lblCursos.Location = new System.Drawing.Point(13, 13);
            this.lblCursos.Name = "lblCursos";
            this.lblCursos.Size = new System.Drawing.Size(39, 13);
            this.lblCursos.TabIndex = 2;
            this.lblCursos.Text = "Cursos";
            // 
            // lblAlumnos
            // 
            this.lblAlumnos.AutoSize = true;
            this.lblAlumnos.Location = new System.Drawing.Point(201, 13);
            this.lblAlumnos.Name = "lblAlumnos";
            this.lblAlumnos.Size = new System.Drawing.Size(109, 13);
            this.lblAlumnos.TabIndex = 3;
            this.lblAlumnos.Text = "Alumnos matriculados";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(204, 310);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // FrmListarAlumnosMatriculados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 366);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblAlumnos);
            this.Controls.Add(this.lblCursos);
            this.Controls.Add(this.listBoxAlumnos);
            this.Controls.Add(this.listBoxCursos);
            this.Name = "FrmListarAlumnosMatriculados";
            this.Text = "FrmListarAlumnosMatriculados";
            this.Load += new System.EventHandler(this.FrmListarAlumnosMatriculados_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxCursos;
        private System.Windows.Forms.ListBox listBoxAlumnos;
        private System.Windows.Forms.Label lblCursos;
        private System.Windows.Forms.Label lblAlumnos;
        private System.Windows.Forms.Button btnSalir;
    }
}