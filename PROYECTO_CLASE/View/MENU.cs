using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_CLASE.View
{
    public partial class MENU : Form
    {
        public MENU()
        {
            InitializeComponent();
            Paneles();
            InfoUsuario();
            ValidaciondeUsuario();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            BtnMaximizar.Visible = false;
            BtnRestaurar.Visible = true;
        }

        private void BtnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            BtnRestaurar.Visible = false;
            BtnMaximizar.Visible = true;
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        void InfoUsuario()
        {
                       
            if(Modulo_ParametrosActivos.FechaSistema.Month >= 1 && Modulo_ParametrosActivos.FechaSistema.Month <= 4)
            {
                int Año = Convert.ToInt32(Modulo_ParametrosActivos.FechaSistema.Year);
                string Periodo;

                Año = Modulo_ParametrosActivos.FechaSistema.Year;
                Periodo = "1";

                Modulo_ParametrosActivos.Anio = Año;
                Modulo_ParametrosActivos.Periodo = Periodo;

                lblPeriodo.Text = Año + " ;  " + Periodo ;
            }
            else
                if(Modulo_ParametrosActivos.FechaSistema.Month >= 5 && Modulo_ParametrosActivos.FechaSistema.Month <= 8)
            {
                
                string Periodo;

                int Año = Convert.ToInt32(Modulo_ParametrosActivos.FechaSistema.Year);
                Periodo = "2";

                lblPeriodo.Text = Año + " ; " + Periodo;
            }
            else
                if (Modulo_ParametrosActivos.FechaSistema.Month >= 9 && Modulo_ParametrosActivos.FechaSistema.Month <= 12)
            {
                int Año = Convert.ToInt32(Modulo_ParametrosActivos.FechaSistema.Year);
                string Periodo;

                Año = Modulo_ParametrosActivos.FechaSistema.Year;
                Periodo = "3";

                lblPeriodo.Text = Año + " ; " + Periodo;
            }
            lblRol.Text = Modulo_ParametrosActivos.RolJop;
            lblSede.Text = Modulo_ParametrosActivos.SedeJop;
            lblUsuario.Text = Modulo_ParametrosActivos.NombreJop + " " + Modulo_ParametrosActivos.ApellidoJop;
            LblBienvenida.Text = " Bienvenido " + Modulo_ParametrosActivos.NombreJop + " " + Modulo_ParametrosActivos.ApellidoJop;
            lblPlan.Text = Modulo_ParametrosActivos.CarreraJop;
        }
        void ValidaciondeUsuario ()
        {
            if(Modulo_ParametrosActivos.RolJop == "Estudiante" )
            {
                BtnParametros.Visible = false;
                btnPMaestro.Visible = false;
            }
            else
                if(Modulo_ParametrosActivos.RolJop == "CATEDRATICO(A)")
            {
                BtnParametros.Visible = false;
                BtnPEst.Visible = false;
                BtnMatriculas.Visible = false;
            }
            else
                if(Modulo_ParametrosActivos.RolJop == "ADMIN")
            {
                lblUsuario.Visible = false;
                lblPlan.Visible = false;
                lblSede.Visible = false;
                lblRol.Text = Modulo_ParametrosActivos.RolJop;
                LblBienvenida.Text = " Bienvenido ";
            }
        }
            


        private void Paneles()
        {
            panelInformacion.Visible = false;
            panelMatricula.Visible = false;
            panelParametros.Visible = false;
            //....
        }
        private void OcultarPaneles()
        {
            if (panelInformacion.Visible == true)  
            panelInformacion.Visible = false;
            
            if(panelMatricula.Visible == true)
             panelMatricula.Visible = false;

            if (panelParametros.Visible == true)
                panelParametros.Visible = false;
        }

        private void MostrarPaneles(Panel Paneles)
        {
            if(Paneles.Visible == false)
            {
                OcultarPaneles();
                Paneles.Visible = true;
            }
            else
                Paneles.Visible = false;
        }
        private Form ActivoForm = null;
        private void AbrirFormHijo(Form HijoForm)
        {
            if (ActivoForm != null)
            {
                ActivoForm.Close();
            }
            ActivoForm = HijoForm;
            HijoForm.TopLevel = false;
            HijoForm.FormBorderStyle = FormBorderStyle.None;
            HijoForm.Dock = DockStyle.Fill;
            panelcontenedor.Controls.Add(HijoForm);
            panelcontenedor.Tag = HijoForm;
            HijoForm.BringToFront();
            HijoForm.Show();

        }


        private void BtnInformacion_Click(object sender, EventArgs e)
        {
            MostrarPaneles(panelInformacion);
        }

        private void btnNotas_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new Lista_Notas());
            OcultarPaneles();
        }

        private void BtnPEst_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new Registro_Perfil_Estudiante());
            OcultarPaneles();
        }

        private void btnPMaestro_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new Registro_Perfil_Catedratico());
            OcultarPaneles();
        }

        private void BtnMatriculas_Click(object sender, EventArgs e)
        {
            MostrarPaneles(panelMatricula);
        }

        private void BtnClasesOfer_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new Lista_Clases_Ofertadas());
            OcultarPaneles();
        }

        private void BtnResumeMa_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new Lista_Matricula());
            OcultarPaneles();
        }

        private void BtnParametros_Click(object sender, EventArgs e)
        {
            MostrarPaneles(panelParametros);
        }

        private void BtnCampus_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new Lista_Campus());
            OcultarPaneles();
        }

        private void BtnCarreras_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new Lista_Carrera());
            OcultarPaneles();
        }

        private void BtnClases_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new Lista_Clases());
            OcultarPaneles();
        }

        private void BtnCatedratico_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new Lista_Catedratico());
            OcultarPaneles();
        }

        private void BtnEstudiante_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new Lista_Alumno());
            OcultarPaneles();
        }

        private void BtnUsuario_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new Lista_Usuario());
            OcultarPaneles();
        }

        private void lblUsuario_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Adios " + Modulo_ParametrosActivos.UsuarioJop);
            this.Hide();
            Login Formu = new Login();
            Formu.ShowDialog();

        }

        private void panelcontenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        /*Size = Screen.PrimaryScreen.WorkingArea.Size;
            Location = Screen.PrimaryScreen.WorkingArea.Location;*/
    }
}
