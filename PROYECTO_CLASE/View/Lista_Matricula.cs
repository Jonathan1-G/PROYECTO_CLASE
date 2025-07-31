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
    public partial class Lista_Matricula : Form
    {
        string Filtro = Modulo_ParametrosActivos.NombreJop + " " + Modulo_ParametrosActivos.ApellidoJop;
        public Lista_Matricula()
        {
            InitializeComponent();
            CargarDatosCla();
            DGVMatricula.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        public void CargarDatosCla()
        {
            new ResumenMatricula_Controller().ListarMatricula();
            DGVMatricula.DataSource = Modulo_Matricula.GetMatricula;
            FiltradoGeneral();
        }
        void FiltradoGeneral()
        {
            Modulo_Matricula.GetMatricula.DefaultView.RowFilter = $"Alumno like'%{Filtro}%'";
        }
        void Filtrado()
        {
            Modulo_Clases.GetClases.DefaultView.RowFilter = $"Codigo+Clase+Dia like'%{TxtFiltrado.Text}%'";

        }
        void EiminarRegistro()
        {
            if (MessageBox.Show("Esta Seguro de Eliminar el Registro", "sistema Pregunta", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if (new ResumenMatricula_Controller().EliminarMatricula(DGVMatricula.SelectedCells[4].Value.ToString()) == true && new Notas_Controller().EliminarNotas(DGVMatricula.SelectedCells[3].Value.ToString()) == true)
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

        private void DGVMatricula_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            BtnEliminar.Enabled = true;
        }

        private void TxtFiltrado_TextChanged(object sender, EventArgs e)
        {
            Filtrado();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
