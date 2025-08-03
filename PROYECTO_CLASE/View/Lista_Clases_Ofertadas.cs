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
    public partial class Lista_Clases_Ofertadas : Form
    {
        string Filtro = Modulo_ParametrosActivos.CarreraJop;

        public Lista_Clases_Ofertadas()
        {
            InitializeComponent();
            CargarDatosCla();
            DGVClases_Ofertadas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            FiltradoGeneral();
        }

        public void CargarDatosCla()
        {
            new Clases_Controller().ListarClases();
            // Se agrega una columna para mostrar si ya está matriculada la clase
            if (!Modulo_Clases.GetClases.Columns.Contains("Matriculada"))
                Modulo_Clases.GetClases.Columns.Add("Matriculada", typeof(bool));

            string idAlumno = Modulo_ParametrosActivos.IdAlumnoJop;
            var controller = new Clases_Controller();

            foreach (DataRow row in Modulo_Clases.GetClases.Rows)
            {
                string Codigo = row["IdAsignatura"].ToString();
                bool estaMatriculada = controller.VerificarClaseMatriculada(Codigo, idAlumno);
                row["Matriculada"] = estaMatriculada;
            }
            DGVClases_Ofertadas.DataSource = Modulo_Clases.GetClases;

        }
        void FiltradoGeneral()
        {
            Modulo_Clases.GetClases.DefaultView.RowFilter = $"Carrera like'%{Filtro}%'";
        }

        void Filtrado()
        {
            Modulo_Clases.GetClases.DefaultView.RowFilter = $"IdAsignatura+Asignatura+Sede like'%{TxtFiltrado.Text}%' and Carrera like'%{Filtro}%'";

        }

        private void DGVClases_Ofertadas_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (Modulo_ParametrosActivos.RolJop == "Estudiante")
            {
                BtnMatricular.Visible = true;
                lblAgregarClases.Visible = true;
            }
        }

        private void BtnMatricular_Click(object sender, EventArgs e)
        {
            string IdAsignatura = DGVClases_Ofertadas.SelectedRows[0].Cells["IdAsignatura"].Value.ToString();
            string idAlumno = Modulo_ParametrosActivos.IdAlumnoJop;

            var controller = new Clases_Controller();
            if (controller.VerificarClaseMatriculada(IdAsignatura, idAlumno))
            {
                MessageBox.Show("Ya estás matriculado en esta clase. Si deseas cambiarla, primero debes desmatricularla.");
                return;
            }

            Registro_ClaseOfertada Formulario = new Registro_ClaseOfertada(DGVClases_Ofertadas.SelectedCells[1].Value.ToString());
            Formulario.Padre = this;
            Formulario.Show();
        }

        private void TxtFiltrado_TextChanged_1(object sender, EventArgs e)
        {
            if (TxtFiltrado.Text == "")
            {
                FiltradoGeneral();
            }
            else
                Filtrado();
        }
    }
}
