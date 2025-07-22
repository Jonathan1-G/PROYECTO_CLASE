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
    public partial class Lista_Campus : Form
    {
        public Lista_Campus()
        {
            InitializeComponent();
            CargarDatosCam();
            DGVCampus.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            BtnEliminar.Enabled = false;
        }
        public void CargarDatosCam()
        {
            new Campus_Controller().ListarCampus();
            DGVCampus.DataSource = Modulo_Campus.GetCampus;
        }
        void Filtrado()
        {
           Modulo_Campus.GetCampus.DefaultView.RowFilter = $"Sede+IdSede like'%{TxtFiltrado.Text}%'";
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            Registro_Campus Formulario = new Registro_Campus();
            Formulario.Padre = this;
            Formulario.Show();
        }

        private void DGVCampus_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Registro_Campus Formulario = new Registro_Campus(DGVCampus.SelectedCells[0].Value.ToString());
            Formulario.Padre = this;
            Formulario.Show();
            BtnEliminar.Enabled = false;
        }

        void EliminarRegistro()
        {
            if (MessageBox.Show("Esta Seguro de Eliminar el Registro", "sistema Pregunta", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if (new Campus_Controller().EliminarCampus(DGVCampus.SelectedCells[0].Value.ToString()) == true)
                {
                    MessageBox.Show("Registro Eliminado Exitosamente...!!");
                    CargarDatosCam();
                }
            }
            BtnEliminar.Enabled = false;
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            EliminarRegistro();
        }

        private void DGVCampus_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BtnEliminar.Enabled = false;
        }

        private void DGVCampus_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            BtnEliminar.Enabled = true;
        }

        private void TxtFiltrado_TextChanged(object sender, EventArgs e)
        {
            Filtrado();
        }

        private void DGVCampus_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
