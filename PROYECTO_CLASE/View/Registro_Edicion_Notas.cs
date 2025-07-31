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
    public partial class Registro_Edicion_Notas : Form
    {
        public Lista_Notas Padre;
        public Registro_Edicion_Notas(string Alumno)
        {
            InitializeComponent();

            TxtAlumno.Text = Alumno;
            TxtAlumno.Enabled = false;

            Modulo_Notas Not = new Notas_Controller().ConsultarNotas(TxtAlumno.Text);

            TxtIdAlumno.Text = Not.IdAlumno;
            TxtIdAlumno.Enabled = false;
            TxtCodigo.Text = Not.Codigo;
            TxtCodigo.Enabled = false;
            TxtClase.Text = Not.Clase;
            TxtClase.Enabled = false;
            TxtIdCATE.Text = Not.IdCatedratico;
            TxtIdCATE.Enabled = false;
            TxtCatedratico.Text = Not.Catedratico;
            TxtCatedratico.Enabled = false;
            TxtEstatus.Text = Not.Estatus;
            TxtEstatus.Enabled = true;
            TxtUv.Text = Not.UV;
            TxtUv.Enabled = false;
            TxtNota.Text = Convert.ToString(Not.Nota);
            TxtAnio.Text = Not.Anio;
            TxtAnio.Enabled = false;
            TxtPeriodo.Text = Not.Periodo;
            TxtPeriodo.Enabled = false;
          
        }

        void SalvarRegistros()
        {
            try
            {

                Modulo_Notas Not = new Modulo_Notas();

                Not.IdAlumno = TxtIdAlumno.Text;
                Not.Alumno = TxtAlumno.Text;
                Not.Codigo = TxtCodigo.Text;
                Not.Clase = TxtClase.Text;
                Not.Catedratico = TxtCatedratico.Text;
                Not.IdCatedratico = TxtIdCATE.Text;
                Not.UV = TxtUv.Text;
                Not.Estatus = TxtEstatus.Text;
                Not.Nota = Convert.ToInt32( TxtNota.Text);
                Not.Anio = TxtAnio.Text;
                Not.Periodo = TxtPeriodo.Text;


                if (new Notas_Controller().IditarNotas(Not) == true)
                {
                    MessageBox.Show("Registros Agregado Exitosamente...!!");
                    Padre.CargarDatosNota();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error a Agregar Registros");
                }

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            SalvarRegistros();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
