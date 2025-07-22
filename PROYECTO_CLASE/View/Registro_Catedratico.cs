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
    public partial class Registro_Catedratico : Form
    {
        string Modo = "";
        public Lista_Catedratico Padre;
        public Lista_Usuario Pad;
        public Registro_Catedratico()
        {
            InitializeComponent();
            Modo = "Agregando";
            CargarSede();
        }
        public Registro_Catedratico(string Usuario)
        {
            InitializeComponent();
            Modo = "Editando";

            CargarSede();

            TxtUsuario.Text = Usuario;

            Mudulo_Catedratico Cat = new Catedratico_Controller().ConsultarCatedratico(TxtUsuario.Text);

            txtIdCatedratico.Text = Cat.IdCatedratico;
            TxtNombre.Text = Cat.Nombre;
            TxtApellido.Text = Cat.Apellido;

            TxtIdUsuario.Text = Cat.IdUsuario;
            TxtIdUsuario.Enabled = false;


            CBRol.Text = Cat.Rol;
            TxtContrasena.Text = Cat.Contrasena;
            TxtIdentidad.Text = Cat.Identidad;
          
            CBSede.Text = Cat.Sede;

            TxtIdSede.Text = Cat.IdSede;
            TxtIdSede.Enabled = false;


            TxtTelefono.Text = Cat.Telefono;
            TxtCorreo.Text = Cat.Correo;
        }

        void SalvarRegistros()
        {
            try
            {
                Mudulo_Catedratico Cat = new Mudulo_Catedratico();
                Cat.IdCatedratico = txtIdCatedratico.Text;
                Cat.Nombre = TxtNombre.Text;
                Cat.Apellido = TxtApellido.Text;
                Cat.IdUsuario = TxtIdUsuario.Text;
                Cat.Usuario = TxtUsuario.Text;
                Cat.Rol = CBRol.Text;
                Cat.Contrasena = TxtContrasena.Text;
                Cat.Identidad = TxtIdentidad.Text;
                Cat.Sede = CBSede.Text;
                Cat.IdSede = TxtIdSede.Text;
                Cat.Telefono = TxtTelefono.Text;
                Cat.Correo = TxtCorreo.Text;

                Modulo_Usuario Usu = new Modulo_Usuario();
                Usu.IdUsuario = TxtIdUsuario.Text;
                Usu.Usuario = TxtUsuario.Text;
                Usu.Rol = CBRol.Text;
                Usu.Contrasena = TxtContrasena.Text;


                if (Modo == "Agregando")
                {
                    if (new Catedratico_Controller().CrearCatedratico(Cat) == true && new Usuario_Controller().CrearUsuario(Usu) == true)
                    {
                        MessageBox.Show("Registro Agregado Exitosamente...!!");
                        Padre.CargarDatosCat();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error a Agregar Registro");
                    }
                }
                else
                {
                    if (new Catedratico_Controller().IditarCatedratico(Cat) == true && new Usuario_Controller().IditarUsuario(Usu) == true)
                    {
                        MessageBox.Show("Registro Actualizado Exitosamente...!!");
                        Padre.CargarDatosCat();
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

        private void CBSede_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBSede.SelectedIndex >= 0)
            {
                string[] valores = Captar_infoSede(CBSede.Text);

                TxtIdSede.Text = valores[0];
            }
        }

        private void txtIdCatedratico_TextChanged(object sender, EventArgs e)
        {
            TxtIdUsuario.Text = txtIdCatedratico.Text;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            SalvarRegistros();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CKBMostrar_CheckedChanged(object sender, EventArgs e)
        {
            if (CKBMostrar.Checked == true)
            {
                TxtContrasena.UseSystemPasswordChar = false;
            }
            else
                TxtContrasena.UseSystemPasswordChar = true;
        }

        private void Catedratico_Form_Load(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
