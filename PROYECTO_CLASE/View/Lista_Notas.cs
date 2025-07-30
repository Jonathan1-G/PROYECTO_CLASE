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
    public partial class Lista_Notas : Form
    {
        string FiltroCat = Modulo_ParametrosActivos.IdcatedraticoJop;
        //string FiltoAl = Modulo_ParametrosActivos.NombreJop + " " + Modulo_ParametrosActivos.ApellidoJop;
        string FiltoAl = Modulo_ParametrosActivos.IdAlumnoJop;
        public Lista_Notas()
        {
            InitializeComponent();
            CargarDatosNota();
            DGVNotas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            if (Modulo_ParametrosActivos.RolJop == "Estudiante")
            {
                FiltradoAlumno();
            }
            else if (Modulo_ParametrosActivos.RolJop == "CATEDRATICO(A)")
            {
                cate();
            }

        }
        public void CargarDatosNota()
        {
            new Notas_Controller().ListarNotas();
            DGVNotas.DataSource = Modulo_Notas.GetNotas;
        }


        void FiltradoAlumno()
        {
            Modulo_Notas.GetNotas.DefaultView.RowFilter = $"IdAlumno like'%{FiltoAl}%'";
        }
        void cate ()
        {
            Modulo_Notas.GetNotas.DefaultView.RowFilter = $"IdCatedratico like'%{FiltroCat}%'";
        }
        void Filtrado()
        {
            Modulo_Clases.GetClases.DefaultView.RowFilter = $"Codigo+Clase+Dia+Alumno+IdAlumno like'%{TxtFiltrado.Text}%'";
        }
        void Validacion()
        {
            if(Modulo_ParametrosActivos.RolJop == "CATEDRATICO(A)")
            {
                BtnMatricular.Visible = true;
            }
            else
                if(Modulo_ParametrosActivos.RolJop == "Estudiante")
            {
                BtnMatricular.Visible=false;
            }
        }

        private void TxtFiltrado_TextChanged(object sender, EventArgs e)
        {
            Filtrado();
        }


        private void BtnMatricular_Click(object sender, EventArgs e)
        {
            Registro_Edicion_Notas Formulario = new Registro_Edicion_Notas(DGVNotas.SelectedCells[0].Value.ToString(), DGVNotas.SelectedCells[2].Value.ToString());
            Formulario.Padre = this;
            Formulario.Show();
           
        }

        private void DGVNotas_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(Modulo_ParametrosActivos.RolJop == "Estudiante")
            {
                BtnMatricular.Visible = false;
                FiltradoAlumno();
            }
            else
                if (Modulo_ParametrosActivos.RolJop == "CATEDRATICO(A)")
            {
                BtnMatricular.Visible = true;
            }
        }

    }
}
