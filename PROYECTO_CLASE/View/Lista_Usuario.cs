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
    public partial class Lista_Usuario : Form
    {
        public Lista_Usuario()
        {
            InitializeComponent();
            CargarDatosUsu();
            DGVUsuario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            BtnEliminar.Enabled = false;
        }
        public void CargarDatosUsu()
        {
            new Usuario_Controller().ListarUsuario();
            DGVUsuario.DataSource = Modulo_Usuario.GetUsuario;
        }
        void Filtrado()
        {
            Modulo_Usuario.GetUsuario.DefaultView.RowFilter = $"IdUsuario+Usuario+Rol like'%{TxtFiltrado.Text}%'";

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            Registro_Usuario Formulario = new Registro_Usuario();
            Formulario.Padre = this;
            Formulario.Show();
        }

        private void DGVUsuario_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Registro_Usuario Formulario = new Registro_Usuario(DGVUsuario.SelectedCells[1].Value.ToString());
            Formulario.Padre = this;
            Formulario.Show();
            BtnEliminar.Enabled = false;
        }
        void EiminarRegistro()
        {
            if (MessageBox.Show("Esta Seguro de Eliminar el Registro", "sistema Pregunta", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if (new Usuario_Controller().EliminarUsuario(DGVUsuario.SelectedCells[0].Value.ToString()) == true)
                {
                    MessageBox.Show("Registro Eliminado Exitosamente...!!");
                    CargarDatosUsu();
                }
            }
            BtnEliminar.Enabled = false;
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            EiminarRegistro();
        }

        private void DGVUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BtnEliminar.Enabled = false;
        }

        private void DGVUsuario_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            BtnEliminar.Enabled = true;
        }

        private void TxtFiltrado_TextChanged(object sender, EventArgs e)
        {
            Filtrado();
        }
    }
}
