
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PROYECTO_CLASE.Model;
using PROYECTO_CLASE.Controller;
using System.Windows.Forms;

namespace PROYECTO_CLASE.View
{
    public partial class Lista_Alumno : Form
    {
        public Lista_Alumno()
        {
            InitializeComponent();
            CargarDatosAlu();
            DGVAlumno.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            BtnEliminar.Enabled = false;
        }
        public void CargarDatosAlu()
        {
            new Alumno_Controller().ListarAlumno();
            DGVAlumno.DataSource = Modulo_Alumno.GetAlumno;
        }

        void Filtrado()
        {
            Modulo_Alumno.GetAlumno.DefaultView.RowFilter = $"IdAlumno+Nombre+Carrera+Identidad like'%{TxtFiltrado.Text}%'";
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            Registro_Alumno Formulario = new Registro_Alumno();
            Formulario.Padre = this;
            Formulario.Show();
        }

        private void DGVAlumno_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Registro_Alumno Formulario = new Registro_Alumno(DGVAlumno.SelectedCells[4].Value.ToString());
            Formulario.Padre = this;
            Formulario.Show();
            BtnEliminar.Enabled = false;
        }
        void EiminarRegistro()
        {
            if (MessageBox.Show("Esta Seguro de Eliminar el Registro", "sistema Pregunta", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if (new Alumno_Controller().EliminarAlumno(DGVAlumno.SelectedCells[0].Value.ToString()) == true && new Usuario_Controller().EliminarUsuario(DGVAlumno.SelectedCells[3].Value.ToString()) == true)
                {
                    MessageBox.Show("Registro Eliminado Exitosamente...!!");
                    CargarDatosAlu();
                }
            }
            BtnEliminar.Enabled = false;
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            EiminarRegistro();
        }

        private void DGVAlumno_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BtnEliminar.Enabled = false;
        }

        private void DGVAlumno_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            BtnEliminar.Enabled = true;
        }

        private void TxtFiltrado_TextChanged(object sender, EventArgs e)
        {
            Filtrado();
        }
    }
}
