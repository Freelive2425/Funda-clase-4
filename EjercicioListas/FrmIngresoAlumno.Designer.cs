namespace EjercicioListas
{
    partial class FrmIngresoAlumno
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
            this.lblTiu = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCurso = new System.Windows.Forms.Label();
            this.txtboxTiu = new System.Windows.Forms.TextBox();
            this.txtboxNombre = new System.Windows.Forms.TextBox();
            this.btnMatricula = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblTiu
            // 
            this.lblTiu.AutoSize = true;
            this.lblTiu.Location = new System.Drawing.Point(13, 13);
            this.lblTiu.Name = "lblTiu";
            this.lblTiu.Size = new System.Drawing.Size(25, 13);
            this.lblTiu.TabIndex = 0;
            this.lblTiu.Text = "TIU";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(13, 87);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Location = new System.Drawing.Point(186, 10);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(34, 13);
            this.lblCurso.TabIndex = 2;
            this.lblCurso.Text = "Curso";
            this.lblCurso.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtboxTiu
            // 
            this.txtboxTiu.Location = new System.Drawing.Point(16, 47);
            this.txtboxTiu.Name = "txtboxTiu";
            this.txtboxTiu.Size = new System.Drawing.Size(100, 20);
            this.txtboxTiu.TabIndex = 3;
            // 
            // txtboxNombre
            // 
            this.txtboxNombre.Location = new System.Drawing.Point(16, 112);
            this.txtboxNombre.Name = "txtboxNombre";
            this.txtboxNombre.Size = new System.Drawing.Size(100, 20);
            this.txtboxNombre.TabIndex = 4;
            // 
            // btnMatricula
            // 
            this.btnMatricula.Location = new System.Drawing.Point(16, 268);
            this.btnMatricula.Name = "btnMatricula";
            this.btnMatricula.Size = new System.Drawing.Size(124, 23);
            this.btnMatricula.TabIndex = 5;
            this.btnMatricula.Text = "Matricula";
            this.btnMatricula.UseVisualStyleBackColor = true;
            this.btnMatricula.Click += new System.EventHandler(this.btnMatricula_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(183, 268);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(124, 23);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(187, 29);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox1.Size = new System.Drawing.Size(120, 212);
            this.listBox1.TabIndex = 7;
            // 
            // FrmIngresoAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 327);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnMatricula);
            this.Controls.Add(this.txtboxNombre);
            this.Controls.Add(this.txtboxTiu);
            this.Controls.Add(this.lblCurso);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblTiu);
            this.Name = "FrmIngresoAlumno";
            this.Text = "FrmIngresoAlumno";
            this.Load += new System.EventHandler(this.FrmIngresoAlumno_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTiu;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.TextBox txtboxTiu;
        private System.Windows.Forms.TextBox txtboxNombre;
        private System.Windows.Forms.Button btnMatricula;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ListBox listBox1;
    }
}