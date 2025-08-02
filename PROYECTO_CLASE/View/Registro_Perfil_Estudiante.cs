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
    public partial class Registro_Perfil_Estudiante : Form
    {
        public Registro_Perfil_Estudiante()
        {
            InitializeComponent();
            Inavilitar();
            BtnGuardar.Visible = false;
            lblGuardarEdicion.Visible = false;
            CargarDatos();
            CargarCarrera();
            CargarSede();
        }


        void Inavilitar()
        {
            txtIdAlum.Enabled = false;
            TxtNombre.Enabled = false;
            TxtApellido.Enabled = false;
            TxtIdentidad.Enabled = false;
            CBCarrera.Enabled = false;
            TxtIdCarrera.Enabled = false;
            CBSede.Enabled = false;
            TxtIdSede.Enabled = false;
            TxtTelefono.Enabled = false;
            TxtCorreo.Enabled = false;
        }
        void Avilitar()
        {
            txtIdAlum.Enabled = false;
            TxtNombre.Enabled = true;
            TxtApellido.Enabled = true;
            TxtIdentidad.Enabled = true;
            CBCarrera.Enabled = true;
            TxtIdCarrera.Enabled = false;
            CBSede.Enabled = true;
            TxtIdSede.Enabled = false;
            TxtTelefono.Enabled = true;
            TxtCorreo.Enabled = true;
        }
        void Editando()
        {
            Modulo_Alumno Alu = new Modulo_Alumno();
            Alu.IdAlumno = txtIdAlum.Text;
            Alu.Nombre = TxtNombre.Text;
            Alu.Apellido = TxtApellido.Text;
            Alu.IdUsuario = Modulo_ParametrosActivos.IdUsuarioJop;
            Alu.Usuario = Modulo_ParametrosActivos.UsuarioJop;
            Alu.Rol = Modulo_ParametrosActivos.RolJop;
            Alu.Contrasena = Modulo_ParametrosActivos.ContrasenaJop;
            Alu.Identidad = TxtIdentidad.Text;
            Alu.Carrera = CBCarrera.Text;
            Alu.IdCarrera = TxtIdCarrera.Text;
            Alu.Sede = CBSede.Text;
            Alu.IdSede = TxtIdSede.Text;
            Alu.Telefono = TxtTelefono.Text;
            Alu.Correo = TxtCorreo.Text;

            Modulo_Usuario Usu = new Modulo_Usuario();
            Usu.IdUsuario = Modulo_ParametrosActivos.IdUsuarioJop;
            Usu.Usuario = Modulo_ParametrosActivos.UsuarioJop;
            Usu.Rol = Modulo_ParametrosActivos.RolJop;
            Usu.Contrasena = Modulo_ParametrosActivos.ContrasenaJop;

            if (new Alumno_Controller().IditarAlumno(Alu) == true && new Usuario_Controller().IditarUsuario(Usu) == true)
            {
                MessageBox.Show("Registro Actualizado Exitosamente...!!");
                BtnGuardar.Visible = false;
            }
            else
            {
                MessageBox.Show("Error a Actualizadar Registro");
            }

        }
        void CargarDatos()
        {
            txtIdAlum.Text = Modulo_ParametrosActivos.IdAlumnoJop;
            TxtNombre.Text = Modulo_ParametrosActivos.NombreJop;
            TxtApellido.Text = Modulo_ParametrosActivos.ApellidoJop;
            TxtIdentidad.Text = Modulo_ParametrosActivos.IdentidadJop;
            CBCarrera.Text = Modulo_ParametrosActivos.CarreraJop;
            TxtIdCarrera.Text = Modulo_ParametrosActivos.IdCarreraJop;
            CBSede.Text = Modulo_ParametrosActivos.SedeJop;
            TxtIdSede.Text = Modulo_ParametrosActivos.IdSedeJop;
            TxtTelefono.Text = Modulo_ParametrosActivos.TelefonoJop;
            TxtCorreo.Text = Modulo_ParametrosActivos.CorreoJop;
        }


        private void BtnEdicion_Click(object sender, EventArgs e)
        {
            Avilitar();
            BtnGuardar.Visible = true;
            lblGuardarEdicion.Visible = true;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Editando();
            Inavilitar();
            BtnGuardar.Visible = false;
            lblGuardarEdicion.Visible = false;
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

        private void Registro_Perfil_Estudiante_Load(object sender, EventArgs e)
        {

        }
    }
}
