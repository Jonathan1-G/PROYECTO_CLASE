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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        Boolean validando()
        {
            bool validado = true;

            if (string.IsNullOrEmpty(TxtUsuario.Text))
            {
                validado = false;
                MessageBox.Show("Debe de Ingresar un Usuario..!!");
            }
            else
            {
                if (string.IsNullOrEmpty(TxtContrasena.Text))
                {
                    validado = false;
                    MessageBox.Show("Debe de Ingresar una Contraseña..!!");
                }
            }
            return validado;
        }

        void Entrando()
        {
            if (validando() == true)
            {
                Modulo_Alumno Alu;
                Mudulo_Catedratico Cat;
                Modulo_Usuario Usu;
                

                Alu = new Alumno_Controller().ConsultarAlumno(TxtUsuario.Text);
                Cat = new Catedratico_Controller().ConsultarCatedratico(TxtUsuario.Text);
                Usu =  new Usuario_Controller().ConsultarUsuario(TxtUsuario.Text);

                if (Alu != null)
                {
                    if (Alu.Contrasena == TxtContrasena.Text)
                    {
                        Modulo_ParametrosActivos.IdAlumnoJop = Alu.IdAlumno;
                        Modulo_ParametrosActivos.NombreJop = Alu.Nombre;
                        Modulo_ParametrosActivos.ApellidoJop = Alu.Apellido;
                        Modulo_ParametrosActivos.IdUsuarioJop = Alu.IdUsuario;
                        Modulo_ParametrosActivos.UsuarioJop = TxtUsuario.Text;
                        Modulo_ParametrosActivos.RolJop = Alu.Rol;
                        Modulo_ParametrosActivos.ContrasenaJop = Alu.Contrasena;
                        Modulo_ParametrosActivos.IdentidadJop = Alu.Identidad;
                        Modulo_ParametrosActivos.CarreraJop = Alu.Carrera;
                        Modulo_ParametrosActivos.IdCarreraJop = Alu.IdCarrera;
                        Modulo_ParametrosActivos.SedeJop = Alu.Sede;
                        Modulo_ParametrosActivos.IdSedeJop = Alu.IdSede;
                        Modulo_ParametrosActivos.TelefonoJop = Alu.Telefono;
                        Modulo_ParametrosActivos.CorreoJop = Alu.Correo;
                        Modulo_ParametrosActivos.FechaSistema = DateTime.Now;
                        MessageBox.Show("Bienvenido " + Alu.Nombre + " " + Alu.Apellido);
                        this.Hide();
                        MENU Formu = new MENU();
                        Formu.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("La Contraseña Proporcionado es incorrecta...!!");
                    }

                }
                else
                if (Cat != null) 
                {
                    if (Cat.Contrasena == TxtContrasena.Text)
                    {
                        Modulo_ParametrosActivos.IdcatedraticoJop = Cat.IdCatedratico;
                        Modulo_ParametrosActivos.NombreJop = Cat.Nombre;
                        Modulo_ParametrosActivos.ApellidoJop = Cat.Apellido;
                        Modulo_ParametrosActivos.IdUsuarioJop = Cat.IdUsuario;
                        Modulo_ParametrosActivos.UsuarioJop = TxtUsuario.Text;
                        Modulo_ParametrosActivos.RolJop = Cat.Rol;
                        Modulo_ParametrosActivos.ContrasenaJop = Cat.Contrasena;
                        Modulo_ParametrosActivos.IdentidadJop = Cat.Identidad;
                        Modulo_ParametrosActivos.SedeJop = Cat.Sede;
                        Modulo_ParametrosActivos.IdSedeJop = Cat.IdSede;
                        Modulo_ParametrosActivos.TelefonoJop = Cat.Telefono;
                        Modulo_ParametrosActivos.CorreoJop = Cat.Correo;
                        Modulo_ParametrosActivos.FechaSistema = DateTime.Now;
                        MessageBox.Show("Bienvenido " + Cat.Nombre + " " + Cat.Apellido);
                        this.Hide();
                        MENU Formu = new MENU();
                        Formu.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("La Contraseña Proporcionado es incorrecta...!!");
                    }
                }
                else
                if (Usu != null)
                {
                    if (Usu.Contrasena == TxtContrasena.Text)
                    {
                        Modulo_ParametrosActivos.IdUsuarioJop = Usu.IdUsuario;
                        Modulo_ParametrosActivos.UsuarioJop = TxtUsuario.Text;
                        Modulo_ParametrosActivos.RolJop = Usu.Rol;
                        Modulo_ParametrosActivos.ContrasenaJop = Usu.Contrasena;                        
                        Modulo_ParametrosActivos.FechaSistema = DateTime.Now;
                        MessageBox.Show("Bienvenido " + Usu.Usuario);
                        this.Hide();
                        MENU Formu = new MENU();
                        Formu.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("La Contraseña Proporcionado es incorrecta...!!");
                    }
                }
                else
                {
                    MessageBox.Show("El Usuario Proporcionado no Existe...!!");
                }
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            Entrando();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TxtContrasena_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
                Entrando();
        }
    }
}
