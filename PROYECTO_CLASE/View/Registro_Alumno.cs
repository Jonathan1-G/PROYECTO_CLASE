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
    public partial class Registro_Alumno : Form
    {
        string Modo = "";
        public Lista_Alumno Padre;
        public Lista_Usuario Pad;
        public Registro_Alumno()
        {
            InitializeComponent();
            Modo = "Agregando";
            CargarCarrera();
            CargarSede();

        }
        public Registro_Alumno(string Usuario)
        {
            InitializeComponent();
            Modo = "Editando";
            CargarCarrera();
            CargarSede();

            TxtUsuario.Text = Usuario;

            Modulo_Alumno Alu = new Alumno_Controller().ConsultarAlumno(TxtUsuario.Text);

            txtIdAlum.Text = Alu.IdAlumno;
            TxtNombre.Text = Alu.Nombre;
            TxtApellido.Text = Alu.Apellido;

            TxtIdUsuario.Text= Alu.IdUsuario;
            TxtIdUsuario.Enabled = false;
            

            CBRol.Text = Alu.Rol;
            TxtContrasena.Text = Alu.Contrasena;
            TxtIdentidad.Text = Alu.Identidad;
            CBCarrera.Text = Alu.Carrera;

            TxtIdCarrera.Text = Alu.Carrera;
            TxtIdCarrera.Enabled = false;
           

            CBSede.Text = Alu.Sede;

            TxtIdSede.Text = Alu.IdSede;
            TxtIdSede.Enabled = false;
           

            TxtTelefono.Text = Alu.Telefono;
            TxtCorreo.Text = Alu.Correo;
        }

        void SalvarRegistros()
        {
            try
            {
                Modulo_Alumno Alu = new Modulo_Alumno();
                Alu.IdAlumno = txtIdAlum.Text;
                Alu.Nombre = TxtNombre.Text;
                Alu.Apellido=TxtApellido.Text;
                Alu.IdUsuario = TxtIdUsuario.Text;
                Alu.Usuario = TxtUsuario.Text;
                Alu.Rol = CBRol.Text;
                Alu.Contrasena = TxtContrasena.Text;
                Alu.Identidad = TxtIdentidad.Text;
                Alu.Carrera = CBCarrera.Text;
                Alu.IdCarrera = TxtIdCarrera.Text;
                Alu.Sede = CBSede.Text;
                Alu.IdSede = TxtIdSede.Text;
                Alu.Telefono = TxtTelefono.Text;
                Alu.Correo = TxtCorreo.Text;

                Modulo_Usuario Usu = new Modulo_Usuario();
                Usu.IdUsuario = TxtIdUsuario.Text;
                Usu.Usuario = TxtUsuario.Text;
                Usu.Rol = CBRol.Text;
                Usu.Contrasena = TxtContrasena.Text;


                if (Modo == "Agregando")
                {
                    if (new Alumno_Controller().CrearAlumno(Alu) == true && new Usuario_Controller().CrearUsuario(Usu) == true)
                    {
                        MessageBox.Show("Registro Agregado Exitosamente...!!");
                        Padre.CargarDatosAlu();                       
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error a Agregar Registro");
                    }
                }
                else
                {
                    if (new Alumno_Controller().IditarAlumno(Alu) == true && new Usuario_Controller().IditarUsuario(Usu) == true)
                    {
                        MessageBox.Show("Registro Actualizado Exitosamente...!!");
                        Padre.CargarDatosAlu();
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

        private void txtIdAlum_TextChanged(object sender, EventArgs e)
        {
            TxtIdUsuario.Text = txtIdAlum.Text;
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

        public string[] Captar_info(string Carrera)
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

        private void CBCarrera_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBCarrera.SelectedIndex >= 0)
            {
                string[] valores = Captar_info(CBCarrera.Text);

                TxtIdCarrera.Text = valores[0];
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

        private void CKBMostrar_CheckedChanged(object sender, EventArgs e)
        {
            if (CKBMostrar.Checked == true)
            {
                TxtContrasena.UseSystemPasswordChar = false;
            }
            else
                TxtContrasena.UseSystemPasswordChar = true;
        }
    }
}
