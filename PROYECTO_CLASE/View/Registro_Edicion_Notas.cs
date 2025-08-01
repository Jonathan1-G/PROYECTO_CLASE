﻿using System;
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
        string FiltroCat = Modulo_ParametrosActivos.IdcatedraticoJop;
        public Registro_Edicion_Notas(string IdAlumno, string Codigo)
        {
            InitializeComponent();

            TxtIdAlumno.Text = IdAlumno;
            TxtIdAlumno.Enabled = false;
            TxtCodigo.Text = Codigo;
            TxtCodigo.Enabled = false;

            Modulo_Notas Not = new Notas_Controller().ConsultarNotas(TxtIdAlumno.Text, TxtCodigo.Text);

            TxtAlumno.Text = Not.Alumno;
            TxtAlumno.Enabled = false;
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
                Not.Nota = Convert.ToInt32(TxtNota.Text);
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

        void cate()
        {
            Modulo_Notas.GetNotas.DefaultView.RowFilter = $"IdCatedratico like'%{FiltroCat}%'";
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            SalvarRegistros();
            cate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void TxtCatedratico_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtIdCATE_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void TxtEstatus_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TxtClase_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtAlumno_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtIdAlumno_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void TxtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void TxtPeriodo_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtAnio_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtUv_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtNota_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
