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
       
    public partial class Registro_Campus : Form
    {
        string Modo = "";
        public Lista_Campus Padre;
        public Registro_Campus()
        {
            InitializeComponent();
            Modo = "Agregando";
        }

        public Registro_Campus(string IdSede)
        {
            InitializeComponent();
            Modo = "Editando";


            TxtIdSede.Text = IdSede;
            TxtIdSede.Enabled = false;

            Modulo_Campus Cam = new Campus_Controller().ConsultarCampus(TxtIdSede.Text);


            TxtSede.Text = Cam.Sede;

            TxtTelefono.Text = Cam.Telefono;
            TxtDireccion.Text = Cam.Direccion;

        }

        void SalvarRegistros()
        {
            try
            {
                Modulo_Campus Cam = new Modulo_Campus();

                Cam.IdSede = TxtIdSede.Text;
                Cam.Sede = TxtSede.Text;
                Cam.Telefono = TxtTelefono.Text;
                Cam.Direccion = TxtDireccion.Text;


                if (Modo == "Agregando")
                {
                    if (new Campus_Controller().CrearCampus(Cam) == true)
                    {
                        MessageBox.Show("Registro Agregado Exitosamente...!!");
                        Padre.CargarDatosCam();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error a Agregar Registro");
                    }
                }
                else
                {
                    if (new Campus_Controller().IditarCampus(Cam) == true)
                    {
                        MessageBox.Show("Registro Actualizado Exitosamente...!!");
                        Padre.CargarDatosCam();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error a Actualizadar Registro");
                    }

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
    }
}
