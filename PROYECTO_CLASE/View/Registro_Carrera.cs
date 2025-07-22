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
    public partial class Registro_Carrera : Form
    {
        string Modo = "";
        public Lista_Carrera Padre;
        public Registro_Carrera()
        {         
            InitializeComponent();
            Modo = "Agregando";
            CargarSede();
        }

        public Registro_Carrera(string IdCarrera)
        {
            InitializeComponent();
            Modo = "Editando";
            CargarSede();


            TxtIdCarrera.Text = IdCarrera;
            TxtIdCarrera.Enabled = false;

            Modulo_Carrera Car = new Carrera_Controller().ConsultarCarrera(TxtIdCarrera.Text);

            TxtCarrera.Text = Car.Carrera;
            CBSede.Text = Car.Sede;
            TxtIdSede.Text = Car.IdSede;

        }

        void SalvarRegistros()
        {
            try
            {
                Modulo_Carrera Car = new Modulo_Carrera();

                Car.IdCarrera = TxtIdCarrera.Text;
                Car.Carrera = TxtCarrera.Text;
                Car.Sede = CBSede.Text;
                Car.IdSede = TxtIdSede.Text;


                if (Modo == "Agregando")
                {
                    if (new Carrera_Controller().CrearCarrera(Car) == true)
                    {
                        MessageBox.Show("Registro Agregado Exitosamente...!!");
                        Padre.CargarDatosCar();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error a Agregar Registro");
                    }
                }
                else
                {
                    if (new Carrera_Controller().EditarCarrera(Car) == true)
                    {
                        MessageBox.Show("Registro Actualizado Exitosamente...!!");
                        Padre.CargarDatosCar();
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

        public void CargarSede()
        {
            try
            {
                CBSede.Items.Clear();             
                using (SqlConnection Con = new Conexion().GetConexion())
                {
                    Con.Open();
                    string sql = "select * from Campus";

                    using (SqlCommand cmd = new SqlCommand(sql, Con))
                    {
                        SqlDataReader LeerDatos = cmd.ExecuteReader();
                        while (LeerDatos.Read())
                        {
                            CBSede.Items.Add(LeerDatos[1].ToString());
                        }                        
                    }
                    Con.Close();                                                    

                }


            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);

            }
        }

        public string[] Captar_info(string Sede) 
        {
            using (SqlConnection Con = new Conexion().GetConexion())
            {
                Con.Open();
                string sql = "select * from Campus where Sede = '"+Sede+"'";

                using (SqlCommand cmd = new SqlCommand(sql, Con))
                {
                    SqlDataReader LeerDatos = cmd.ExecuteReader();
                    string[] resultado = null;
                    while (LeerDatos.Read())
                    {
                        string[] valores =
                        {
                            LeerDatos[0].ToString(),
                        };
                        resultado = valores;
                    }
                    Con.Close();
                    return resultado;
                }
                

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

        private void CBSede_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(CBSede.SelectedIndex >= 0) 
            {
                string[] valores = Captar_info(CBSede.Text);

                TxtIdSede.Text = valores[0];
            }
        }
    }
}
