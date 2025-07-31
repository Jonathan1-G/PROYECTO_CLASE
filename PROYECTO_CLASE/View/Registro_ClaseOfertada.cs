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
    public partial class Registro_ClaseOfertada : Form
    {

        public Lista_Clases_Ofertadas Padre;
        public Registro_ClaseOfertada(string Asignatura)
        {
            InitializeComponent();


            TxtClase.Text = Asignatura;
            TxtClase.Enabled = false;

            Modulo_Clases Cla = new Clases_Controller().ConsultarClases(TxtClase.Text);
            
            TxtCodigo.Text = Cla.IdAsignatura;
            TxtCodigo.Enabled = false;
            TxtSede.Text = Cla.Sede;
            TxtSede.Enabled = false;
            TxtCredito.Text = Cla.Creditos;
            TxtCredito.Enabled = false;
            TxtDia.Text = Cla.dia;
            TxtDia.Enabled = false;
            TxtInicio.Text = Cla.HInicio;
            TxtInicio.Enabled = false;
            TxtFin.Text = Cla.HFin;
            TxtFin.Enabled = false;
            TxtIdCate.Text = Cla.IdCatedratico;
            TxtIdCate.Enabled = false;
            TxtCate.Text= Cla.Catedratico;
            TxtCate.Enabled = false;

            TxtIdAlumno.Text = Modulo_ParametrosActivos.IdAlumnoJop;
            TxtAlumno.Text = Modulo_ParametrosActivos.NombreJop + " " + Modulo_ParametrosActivos.ApellidoJop;

        }

        void SalvarRegistros()
        {
            try
            {
                Modulo_Matricula Mat = new Modulo_Matricula();

                Mat.IdAlumno = TxtIdAlumno.Text;
                Mat.Alumno = TxtAlumno.Text;
                Mat.Sede = TxtSede.Text;
                Mat.Codigo = TxtCodigo.Text;
                Mat.Clase = TxtClase.Text;
                Mat.UV = TxtCredito.Text;
                Mat.Dia = TxtDia.Text;
                Mat.Estatus = TxtEstatus.Text;
                Mat.Inicio = TxtInicio.Text;
                Mat.Fin = TxtFin.Text;
                
                Modulo_Notas Not = new Modulo_Notas();

                Not.IdAlumno = TxtIdAlumno.Text;
                Not.Alumno = TxtAlumno.Text;
                Not.Codigo = TxtCodigo.Text;
                Not.Clase = TxtClase.Text;
                Not.Catedratico = TxtCate.Text;
                Not.IdCatedratico = TxtIdCate.Text;
                Not.UV = TxtCredito.Text;
                Not.Estatus = TxtEstatus.Text;
                
                Not.Nota = 0;
                string Anio = Convert.ToString(Modulo_ParametrosActivos.FechaSistema.Year);
                Not.Anio = Anio;
                string Periodos;

                if (Modulo_ParametrosActivos.FechaSistema.Month >= 1 && Modulo_ParametrosActivos.FechaSistema.Month <= 4)
                {
                    
                    Periodos = "1";
                    Not.Periodo = Periodos;
                }
                else
               if (Modulo_ParametrosActivos.FechaSistema.Month >= 5 && Modulo_ParametrosActivos.FechaSistema.Month <= 8)
                {                    
                    Periodos = "2";
                    Not.Periodo = Periodos;
                }
                else
               if (Modulo_ParametrosActivos.FechaSistema.Month >= 9 && Modulo_ParametrosActivos.FechaSistema.Month <= 12)
                {
                    Periodos = "3";
                    Not.Periodo = Periodos;
                }
                               




                if (new ResumenMatricula_Controller().CrearMatricula(Mat) == true && new Notas_Controller().CrearNotas(Not) == true)
                    {
                        MessageBox.Show("Registros Agregado Exitosamente...!!");
                        Padre.CargarDatosCla();
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
