using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioListas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ingresoCursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmIngresoCurso frm = new FrmIngresoCurso();
            frm.ShowDialog();
        }

        private void ingresoAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmIngresoAlumno frm = new FrmIngresoAlumno();
            frm.ShowDialog();
        }

        private void listaDeAlumnosMatriculadosEnUnCursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListarAlumnosMatriculados frm = new FrmListarAlumnosMatriculados();
            frm.ShowDialog();
        }
    }
}
