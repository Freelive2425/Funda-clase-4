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
    public partial class FrmIngresoCurso : Form
    {
        CMatriculaUPC objmatricula = new CMatriculaUPC();
        public FrmIngresoCurso()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (!objmatricula.CursoExiste(txtBoxCodigo.Text))
            {
                CCurso curso = new CCurso();
                curso.Codigo = txtBoxCodigo.Text;
                curso.Nombre = txtboxNombre.Text;
                objmatricula.InsertarCurso(curso);
            }
            txtBoxCodigo.Clear();
            txtboxNombre.Clear();
            txtBoxCodigo.Focus();
        }
    }
}
