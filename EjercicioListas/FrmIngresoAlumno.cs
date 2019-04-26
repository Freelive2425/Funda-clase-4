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
    public partial class FrmIngresoAlumno : Form
    {
        CMatriculaUPC objmatricula = new CMatriculaUPC();
        public FrmIngresoAlumno()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FrmIngresoAlumno_Load(object sender, EventArgs e)
        {
            listBox1.DisplayMember = "Nombre";
            listBox1.ValueMember = "Codigo";
            listBox1.DataSource = CMatriculaUPC.Cursos;
            listBox1.SelectedIndex = -1;
        }

        private void btnMatricula_Click(object sender, EventArgs e)
        {
            CAlumno alumno = new CAlumno();
            alumno.TIU = Convert.ToInt32(txtboxTiu.Text);
            alumno.NombreCompleto = txtboxNombre.Text;
            foreach (CCurso curso in listBox1.SelectedItems)
                objmatricula.InsertarAlumnoEnCurso(curso.Codigo, alumno);
            txtboxTiu.Clear();
            txtboxNombre.Clear();
            listBox1.SelectedIndex = -1;
            txtboxTiu.Focus();
        }
    }
}
