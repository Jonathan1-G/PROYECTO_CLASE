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
            DGVClases_Ofertadas.DataSource = Modulo_Clases.GetClases;
        }
         void FiltradoGeneral()
        {
            Modulo_Clases.GetClases.DefaultView.RowFilter = $"Carrera like'%{Filtro}%'";
        }

        void Filtrado()
        {
            Modulo_Clases.GetClases.DefaultView.RowFilter = $"IdAsignatura+Asignatura+Sede like'%{TxtFiltrado.Text}%'";
            
        }

        private void TxtFiltrado_TextChanged(object sender, EventArgs e)
        {
            if (TxtFiltrado.Text == "")
            {
                FiltradoGeneral();
            }
            else
                Filtrado();


        }

        private void DGVClases_Ofertadas_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            BtnMatricular.Visible = true;
        }

        private void DGVClases_Ofertadas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BtnMatricular.Visible = false;
        }

        private void DGVClases_Ofertadas_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            BtnMatricular.Visible = false;
        }

        private void BtnMatricular_Click(object sender, EventArgs e)
        {
            Registro_ClaseOfertada Formulario = new Registro_ClaseOfertada(DGVClases_Ofertadas.SelectedCells[1].Value.ToString());
            Formulario.Padre = this;
            Formulario.Show();
        }
    }
}
