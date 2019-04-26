namespace EjercicioListas
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ingresosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeAlumnosMatriculadosEnUnCursoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cursoConMasAlumnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarCursosQueLlevaUnAlumnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alumnoConTIUMayorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresoCursoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresoAlumnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresosToolStripMenuItem,
            this.consultasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(486, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ingresosToolStripMenuItem
            // 
            this.ingresosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresoCursoToolStripMenuItem,
            this.ingresoAlumnoToolStripMenuItem});
            this.ingresosToolStripMenuItem.Name = "ingresosToolStripMenuItem";
            this.ingresosToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.ingresosToolStripMenuItem.Text = "Ingresos";
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaDeAlumnosMatriculadosEnUnCursoToolStripMenuItem,
            this.cursoConMasAlumnosToolStripMenuItem,
            this.listarCursosQueLlevaUnAlumnoToolStripMenuItem,
            this.alumnoConTIUMayorToolStripMenuItem});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // listaDeAlumnosMatriculadosEnUnCursoToolStripMenuItem
            // 
            this.listaDeAlumnosMatriculadosEnUnCursoToolStripMenuItem.Name = "listaDeAlumnosMatriculadosEnUnCursoToolStripMenuItem";
            this.listaDeAlumnosMatriculadosEnUnCursoToolStripMenuItem.Size = new System.Drawing.Size(300, 22);
            this.listaDeAlumnosMatriculadosEnUnCursoToolStripMenuItem.Text = "Lista de alumnos matriculados en un curso";
            this.listaDeAlumnosMatriculadosEnUnCursoToolStripMenuItem.Click += new System.EventHandler(this.listaDeAlumnosMatriculadosEnUnCursoToolStripMenuItem_Click);
            // 
            // cursoConMasAlumnosToolStripMenuItem
            // 
            this.cursoConMasAlumnosToolStripMenuItem.Name = "cursoConMasAlumnosToolStripMenuItem";
            this.cursoConMasAlumnosToolStripMenuItem.Size = new System.Drawing.Size(300, 22);
            this.cursoConMasAlumnosToolStripMenuItem.Text = "Curso con mas alumnos";
            // 
            // listarCursosQueLlevaUnAlumnoToolStripMenuItem
            // 
            this.listarCursosQueLlevaUnAlumnoToolStripMenuItem.Name = "listarCursosQueLlevaUnAlumnoToolStripMenuItem";
            this.listarCursosQueLlevaUnAlumnoToolStripMenuItem.Size = new System.Drawing.Size(300, 22);
            this.listarCursosQueLlevaUnAlumnoToolStripMenuItem.Text = "Listar cursos que lleva un alumno";
            // 
            // alumnoConTIUMayorToolStripMenuItem
            // 
            this.alumnoConTIUMayorToolStripMenuItem.Name = "alumnoConTIUMayorToolStripMenuItem";
            this.alumnoConTIUMayorToolStripMenuItem.Size = new System.Drawing.Size(300, 22);
            this.alumnoConTIUMayorToolStripMenuItem.Text = "Alumno con TIU mayor ";
            // 
            // ingresoCursoToolStripMenuItem
            // 
            this.ingresoCursoToolStripMenuItem.Name = "ingresoCursoToolStripMenuItem";
            this.ingresoCursoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ingresoCursoToolStripMenuItem.Text = "Ingreso curso";
            this.ingresoCursoToolStripMenuItem.Click += new System.EventHandler(this.ingresoCursoToolStripMenuItem_Click);
            // 
            // ingresoAlumnoToolStripMenuItem
            // 
            this.ingresoAlumnoToolStripMenuItem.Name = "ingresoAlumnoToolStripMenuItem";
            this.ingresoAlumnoToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.ingresoAlumnoToolStripMenuItem.Text = "Ingreso Alumno";
            this.ingresoAlumnoToolStripMenuItem.Click += new System.EventHandler(this.ingresoAlumnoToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 387);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ingresosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresoCursoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeAlumnosMatriculadosEnUnCursoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cursoConMasAlumnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarCursosQueLlevaUnAlumnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alumnoConTIUMayorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresoAlumnoToolStripMenuItem;
    }
}

