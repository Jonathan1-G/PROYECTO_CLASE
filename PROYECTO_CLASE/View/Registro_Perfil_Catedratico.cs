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
    public partial class Registro_Perfil_Catedratico : Form
    {
        public Registro_Perfil_Catedratico()
        {
            InitializeComponent();
            Inavilitar();
            BtnGuardar.Visible = false;
            CargarDatos();
            CargarSede();
        }

        void Inavilitar()
        {
            txtIdCate.Enabled = false;
            TxtNombre.Enabled = false;
            TxtApellido.Enabled = false;
            TxtIdentidad.Enabled = false;
            CBSede.Enabled = false;
            TxtIdSede.Enabled = false;
            TxtTelefono.Enabled = false;
            TxtCorreo.Enabled = false;
        }
        void Avilitar()
        {
            txtIdCate.Enabled = false;
            TxtNombre.Enabled = true;
            TxtApellido.Enabled = true;
            TxtIdentidad.Enabled = true;
            CBSede.Enabled = true;
            TxtIdSede.Enabled = false;
            TxtTelefono.Enabled = true;
            TxtCorreo.Enabled = true;
        }
        void Editando()
        {
            Mudulo_Catedratico Cat = new Mudulo_Catedratico();
            Cat.IdCatedratico = txtIdCate.Text;
            Cat.Nombre = TxtNombre.Text;
            Cat.Apellido = TxtApellido.Text;
            Cat.IdUsuario = Modulo_ParametrosActivos.IdUsuarioJop;
            Cat.Usuario = Modulo_ParametrosActivos.UsuarioJop;
            Cat.Rol = Modulo_ParametrosActivos.RolJop;
            Cat.Contrasena = Modulo_ParametrosActivos.ContrasenaJop;
            Cat.Identidad = TxtIdentidad.Text;
            Cat.Sede = CBSede.Text;
            Cat.IdSede = TxtIdSede.Text;
            Cat.Telefono = TxtTelefono.Text;
            Cat.Correo = TxtCorreo.Text;

            Modulo_Usuario Usu = new Modulo_Usuario();
            Usu.IdUsuario = Modulo_ParametrosActivos.IdUsuarioJop;
            Usu.Usuario = Modulo_ParametrosActivos.UsuarioJop;
            Usu.Rol = Modulo_ParametrosActivos.RolJop;
            Usu.Contrasena = Modulo_ParametrosActivos.ContrasenaJop;

            if (new Catedratico_Controller().IditarCatedratico(Cat) == true && new Usuario_Controller().IditarUsuario(Usu) == true)
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
            txtIdCate.Text = Modulo_ParametrosActivos.IdcatedraticoJop;
            TxtNombre.Text = Modulo_ParametrosActivos.NombreJop;
            TxtApellido.Text = Modulo_ParametrosActivos.ApellidoJop;
            TxtIdentidad.Text = Modulo_ParametrosActivos.IdentidadJop;
            CBSede.Text = Modulo_ParametrosActivos.SedeJop;
            TxtIdSede.Text = Modulo_ParametrosActivos.IdSedeJop;
            TxtIdSede.Text = Modulo_ParametrosActivos.IdSedeJop;
            TxtTelefono.Text = Modulo_ParametrosActivos.TelefonoJop;
            TxtCorreo.Text = Modulo_ParametrosActivos.CorreoJop;
        }

        private void BtnEdicion_Click(object sender, EventArgs e)
        {
            Avilitar();
            BtnGuardar.Visible = true;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Editando();
            Inavilitar();
            BtnGuardar.Visible = false;
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
    }
}
