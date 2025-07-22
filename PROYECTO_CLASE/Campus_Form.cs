using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_CLASE
{
    public partial class Campus_Form : Form
    {
        string Modo = "";
       // public Modulo_Campus Padre;

        public Campus_Form()
        {
            InitializeComponent();
            Modo = "Agregando";
            LblModo.Text = Modo;
        }
        public Campus_Form(string Sede, string Telefono, string Direccion)
        {
            InitializeComponent();
            Modo = "Editando";
            LblModo.Text = Modo;

            txtnombresede.Text = Sede;
            TxtTelefono.Text = Telefono;
            TxtDireccion.Text = Direccion;

        }

        void SalvarRegistros()
        {
            try
            {
                Clase_Campus Cam = new Clase_Campus();

                Cam.Sede = txtnombresede.Text;
                Cam.Telefono = TxtTelefono.Text;
                Cam.Direccion = TxtDireccion.Text;


                if (Modo == "Agregando")
                {
                    if (new Eventos_Campus().CrearCampus(Cam) == true)
                    {
                        MessageBox.Show("Registro Agregado Exitosamente...!!");
                        //Padre.CargarDatosCam();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error a Agregar Registro");
                    }
                }
                else
                {
                    if (new Eventos_Campus().IditarCampus(Cam) == true)
                    {
                        MessageBox.Show("Registro Actualizado Exitosamente...!!");
                        //Padre.CargarDatosCam();
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

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            SalvarRegistros();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
