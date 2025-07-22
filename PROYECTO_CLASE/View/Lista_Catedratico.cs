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
    public partial class Lista_Catedratico : Form
    {
        public Lista_Catedratico()
        {
            InitializeComponent();
            CargarDatosCat();
            DGVCatedratico.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            BtnEliminar.Enabled = false;
        }
        public void CargarDatosCat()
        {
            new Catedratico_Controller().ListarCatedratico();
            DGVCatedratico.DataSource = Mudulo_Catedratico.GetCatedratico;
        }
        void Filtrado()
        {
            Mudulo_Catedratico.GetCatedratico.DefaultView.RowFilter = $"IdCatedratico+Nombre+Apellido+Identidad like'%{TxtFiltrado.Text}%'";
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            Registro_Catedratico Formulario = new Registro_Catedratico();
            Formulario.Padre = this;
            Formulario.Show();
        }

        private void DGVCatedratico_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Registro_Catedratico Formulario = new Registro_Catedratico(DGVCatedratico.SelectedCells[4].Value.ToString());
            Formulario.Padre = this;
            Formulario.Show();
            BtnEliminar.Enabled = false;
        }
        void EiminarRegistro()
        {
            if (MessageBox.Show("Esta Seguro de Eliminar el Registro", "sistema Pregunta", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if (new Catedratico_Controller().EliminarCatedratico(DGVCatedratico.SelectedCells[0].Value.ToString()) == true && new Usuario_Controller().EliminarUsuario(DGVCatedratico.SelectedCells[3].Value.ToString()) == true)
                {
                    MessageBox.Show("Registro Eliminado Exitosamente...!!");
                    CargarDatosCat();
                }
            }
            BtnEliminar.Enabled = false;
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            EiminarRegistro();
        }

        private void DGVCatedratico_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BtnEliminar.Enabled = false;
        }

        private void DGVCatedratico_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            BtnEliminar.Enabled = true;
        }

        private void TxtFiltrado_TextChanged(object sender, EventArgs e)
        {
            Filtrado();
        }
    }
}
