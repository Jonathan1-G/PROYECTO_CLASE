using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PROYECTO_CLASE.Model;
using PROYECTO_CLASE.Controller;
using System.Windows.Forms;

namespace PROYECTO_CLASE.View
{
    public partial class Lista_Carrera : Form
    {
        public Lista_Carrera()
        {
            InitializeComponent();
            CargarDatosCar();
            DGVCarrera.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            BtnEliminar.Enabled = false;
        }
        public void CargarDatosCar()
        {
            new Carrera_Controller().ListarCarrera();
            DGVCarrera.DataSource = Modulo_Carrera.GetCarrera;
        }

        void Filtrado()
        {
           Modulo_Carrera.GetCarrera.DefaultView.RowFilter = $"IdCarrera+Carrera like'%{TxtFiltrado.Text}%'";
        }

        void EliminarRegistro()
        {
            if (MessageBox.Show("Esta Seguro de Eliminar el Registro", "sistema Pregunta", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if (new Carrera_Controller().EliminarCarrera(DGVCarrera.SelectedCells[0].Value.ToString()) == true)
                {
                    MessageBox.Show("Registro Eliminado Exitosamente...!!");
                    CargarDatosCar();
                }
            }
            BtnEliminar.Enabled = false;
        }     

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            Registro_Carrera Formulario = new Registro_Carrera();
            Formulario.Padre = this;
            Formulario.Show();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            EliminarRegistro();
        }




        private void DGVCarrera_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BtnEliminar.Enabled = false;
        }

        private void DGVCarrera_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            BtnEliminar.Enabled = true;
        }

        private void DGVCarrera_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Registro_Carrera Formulario = new Registro_Carrera(DGVCarrera.SelectedCells[0].Value.ToString());
            Formulario.Padre = this;
            Formulario.Show();
            BtnEliminar.Enabled = false;
        }

        private void TxtFiltrado_TextChanged(object sender, EventArgs e)
        {
            Filtrado();
        }
    }
}
