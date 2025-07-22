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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace PROYECTO_CLASE.View
{
    public partial class Registro_Usuario : Form
    {
        string Modo = "";
        public Lista_Usuario Padre;

        public Registro_Usuario()
        {
            InitializeComponent();
            Modo = "Agregando";
         
        }
        
        public Registro_Usuario(string Usuario)
        {
            InitializeComponent();
            Modo = "Editando";

            TxtUsuario.Text = Usuario;
            
           

            Modulo_Usuario Usu = new Usuario_Controller().ConsultarUsuario(TxtUsuario.Text);

            TxtIdUsuario.Text = Usu.IdUsuario;
            TxtIdUsuario.Enabled = false;

    

            CBRol.Text = Usu.Rol;
            TxtContrasena.Text = Usu.Contrasena;

        }

        void SalvarRegistros()
        {
            try
            {
                Modulo_Usuario Usu = new Modulo_Usuario();

                Usu.IdUsuario = TxtIdUsuario.Text;
                Usu.Usuario = TxtUsuario.Text;
                Usu.Rol = CBRol.Text;
                Usu.Contrasena = TxtContrasena.Text;


                if (Modo == "Agregando")
                {
                    if (new Usuario_Controller().CrearUsuario(Usu) == true)
                    {
                        MessageBox.Show("Registro Agregado Exitosamente...!!");
                        Padre.CargarDatosUsu();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error a Agregar Registro");
                    }
                }
                else
                {
                    if (new Usuario_Controller().IditarUsuario(Usu) == true)
                    {
                        MessageBox.Show("Registro Actualizado Exitosamente...!!");
                        Padre.CargarDatosUsu();
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

        private void CKBMostrar_CheckedChanged(object sender, EventArgs e)
        {
            if(CKBMostrar.Checked == true) 
            {
                TxtContrasena.UseSystemPasswordChar = false;
            }
            else
                TxtContrasena.UseSystemPasswordChar=true; 
        }

        private void Usuario_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
