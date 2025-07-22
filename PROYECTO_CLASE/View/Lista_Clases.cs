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
    public partial class Lista_Clases : Form
    {
        public Lista_Clases()
        {
            InitializeComponent();
            CargarDatosCla();
            DGVAlumno.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            BtnEliminar.Enabled = false;
        }
        public void CargarDatosCla()
        {
            new Clases_Controller().ListarClases();
            DGVAlumno.DataSource = Modulo_Clases.GetClases;
        }
        void Filtrado()
        {
            Modulo_Clases.GetClases.DefaultView.RowFilter = $"IdAsignatura+Asignatura+Sede+Carrera like'%{TxtFiltrado.Text}%'";

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            Registro_Clases Formulario = new Registro_Clases();
            Formulario.Padre = this;
            Formulario.Show();
        }

        private void DGVAlumno_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Registro_Clases Formulario = new Registro_Clases(DGVAlumno.SelectedCells[1].Value.ToString());
            Formulario.Padre = this;
            Formulario.Show();
            BtnEliminar.Enabled = false;
        }
        void EiminarRegistro()
        {
            if (MessageBox.Show("Esta Seguro de Eliminar el Registro", "sistema Pregunta", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if (new Clases_Controller().EliminarClases(DGVAlumno.SelectedCells[0].Value.ToString()) == true)
                {
                    MessageBox.Show("Registro Eliminado Exitosamente...!!");
                    CargarDatosCla();
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
