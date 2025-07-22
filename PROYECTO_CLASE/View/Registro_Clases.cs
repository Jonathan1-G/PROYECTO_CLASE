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
    public partial class Registro_Clases : Form
    {
        string Modo = "";
        public Lista_Clases Padre;
        public Registro_Clases()
        {
            InitializeComponent();
            Modo = "Agregando";                       
            CargarCatedratico();
            CargarCarrera();
            CargarSede();
        }
        public Registro_Clases(string Asignatura)
        {
            InitializeComponent();
            Modo = "Editando";            
            CargarCatedratico();
            CargarCarrera();
            CargarSede();


            TxtAsignatura.Text = Asignatura;
            

            Modulo_Clases Cla = new Clases_Controller().ConsultarClases(TxtAsignatura.Text);
            TxtIdAsignatura.Text = Cla.IdAsignatura;
            TxtIdAsignatura.Enabled = false;

            TxtCreditos.Text = Cla.Creditos;
            TxtHInicio.Text = Cla.HInicio;
            TxtHFin.Text = Cla.HFin;
            TxtDia.Text = Cla.dia;
            CBCarrera.Text = Cla.Carrera;
            TxtIdCarrera.Text = Cla.IdCarrera;

            CBCatedratico.Text = Cla.Catedratico;

            TxtIdCatedratico.Text = Cla.IdCatedratico;
            TxtIdCatedratico.Enabled = false;

            CBSede.Text = Cla.Sede;

            TxtIdSede.Text = Cla.IdSede;
            TxtIdSede.Enabled = false;

            TxtPrecio.Text = Cla.Precio.ToString();

        }

        void SalvarRegistros()
        {
            try
            {
                Modulo_Clases Cla = new Modulo_Clases();

                Cla.IdAsignatura = TxtIdAsignatura.Text;
                Cla.Asignatura = TxtAsignatura.Text;
                Cla.Creditos = TxtCreditos.Text;
                Cla.HInicio = TxtHInicio.Text;
                Cla.HFin = TxtHFin.Text;
                Cla.dia = TxtDia.Text;
                Cla.Carrera = CBCarrera.Text;
                Cla.IdCarrera = TxtIdCarrera.Text;
                Cla.Catedratico = CBCatedratico.Text;
                Cla.IdCatedratico = TxtIdCatedratico.Text;
                Cla.Sede = CBSede.Text;
                Cla.IdSede = TxtIdSede.Text;
                Cla.Precio = decimal.Parse(TxtPrecio.Text);


                if (Modo == "Agregando")
                {
                    if (new Clases_Controller().CrearClases(Cla) == true)
                    {
                        MessageBox.Show("Registro Agregado Exitosamente...!!");
                        Padre.CargarDatosCla();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error a Agregar Registro");
                    }
                }
                else
                {
                    if (new Clases_Controller().IditarClases(Cla) == true)
                    {
                        MessageBox.Show("Registro Actualizado Exitosamente...!!");
                        Padre.CargarDatosCla();
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
        public string[] Captar_infoSede(string Sede)
        {
            using (SqlConnection Con = new Conexion().GetConexion())
            {
                Con.Open();
                string sql = "select * from Campus where Sede = '" + Sede + "'";

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
        public void CargarCatedratico()
        {
            try
            {
                CBCatedratico.Items.Clear();
                using (SqlConnection Con = new Conexion().GetConexion())
                {
                    Con.Open();
                    string sql = "select * from Catedratico";

                    using (SqlCommand cmd = new SqlCommand(sql, Con))
                    {
                        SqlDataReader LeerDatos = cmd.ExecuteReader();
                        while (LeerDatos.Read())
                        {
                            CBCatedratico.Items.Add(LeerDatos[1].ToString());
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
        public string[] Captar_info_Catedratico(string Nombre)
        {
            using (SqlConnection Con = new Conexion().GetConexion())
            {
                Con.Open();
                string sql = "select * from Catedratico where Nombre = '" + Nombre + "'" ;

                using (SqlCommand cmd = new SqlCommand(sql, Con))
                {
                    SqlDataReader LeerDatos = cmd.ExecuteReader();
                    string[] resultado = null;
                    while (LeerDatos.Read())
                    {
                        string[] valores =
                        {
                            LeerDatos[0].ToString(),
                            LeerDatos[2].ToString(),
                            
                        };
                        resultado = valores;
                    }
                    Con.Close();
                    return resultado;
                }


            }
        }
        public void CargarCarrera()
        {
            try
            {
                CBSede.Items.Clear();
                using (SqlConnection Con = new Conexion().GetConexion())
                {
                    Con.Open();
                    string sql = "select * from Carrera";

                    using (SqlCommand cmd = new SqlCommand(sql, Con))
                    {
                        SqlDataReader LeerDatos = cmd.ExecuteReader();
                        while (LeerDatos.Read())
                        {
                            CBCarrera.Items.Add(LeerDatos[1].ToString());
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
        public string[] Captar_info_Carrera(string Carrera)
        {
            using (SqlConnection Con = new Conexion().GetConexion())
            {
                Con.Open();
                string sql = "select * from Carrera where Carrera = '" + Carrera + "'";

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
            if (CBSede.SelectedIndex >= 0)
            {
                string[] valores = Captar_infoSede(CBSede.Text);

                TxtIdSede.Text = valores[0];
            }
        }

        private void CBCatedratico_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBCatedratico.SelectedIndex >= 0)
            {
                string[] valores = Captar_info_Catedratico(CBCatedratico.Text);

                TxtIdCatedratico.Text = valores[0];
                TxtCate.Text = CBCatedratico.Text +" "+ valores[1];

            }
        }

        private void CBCarrera_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBCarrera.SelectedIndex >= 0)
            {
                string[] valores = Captar_info_Carrera(CBCarrera.Text);

                TxtIdCarrera.Text = valores[0];                

            }
        }
    }
}
