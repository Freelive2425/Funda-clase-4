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
    public partial class FrmListarAlumnosMatriculados : Form
    {
        public FrmListarAlumnosMatriculados()
        {
            InitializeComponent();
        }

        private void FrmListarAlumnosMatriculados_Load(object sender, EventArgs e)
        {
            listBoxCursos.DisplayMember = "Nombre";
            listBoxCursos.ValueMember = "Codigo";
            listBoxCursos.DataSource = CMatriculaUPC.Cursos;

        }

        private void listBoxCursos_SelectedIndexChanged(object sender, EventArgs e)
        {
            CCurso curso = (CCurso)listBoxCursos.SelectedItem;
            listBoxAlumnos.DisplayMember = "NombreCompleto";
            listBoxAlumnos.ValueMember = "TIU";
            listBoxAlumnos.DataSource = curso.Alumnos;
        }
    }
}
