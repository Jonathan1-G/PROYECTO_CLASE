using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PROYECTO_CLASE.Model;
using System.Windows.Forms;

namespace PROYECTO_CLASE.Controller
{
    internal class ResumenMatricula_Controller
    {
        //Evento para cargar los datos de la Base SQL a los DataGridView
        public void ListarMatricula()
        {
            try
            {
                DataTable dt = new DataTable();
                using (SqlConnection Con = new Conexion().GetConexion())
                {
                    Con.Open();
                    string sql = "select * from Matricula";

                    using (SqlCommand cmd = new SqlCommand(sql, Con))
                    {
                        SqlDataAdapter LeerDatos = new SqlDataAdapter(cmd);
                        LeerDatos.Fill(dt);
                    }
                    Modulo_Matricula.GetMatricula = dt;
                    Con.Close();

                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

        }
        //Evento para Guardar Nuevo Registros en la Base de SQL
        public bool CrearMatricula(Modulo_Matricula Mat)
        { 
            try
            {
                using (SqlConnection Con = new Conexion().GetConexion())
                {
                    Con.Open();
                    string sql = "insert into Matricula(IdAlumno,Alumno,Sede,Codigo,Clase,UV,Dia,Estatus,Inicio,Fin) values ('" + Mat.IdAlumno + "','" + Mat.Alumno + "','" + Mat.Sede + "','" + Mat.Codigo + "','" + Mat.Clase + "','" + Mat.UV + "','" + Mat.Dia + "','" + Mat.Estatus + "','" + Mat.Inicio + "','" + Mat.Fin + "')";

                    using (SqlCommand cmd = new SqlCommand(sql, Con))
                    {
                        cmd.ExecuteNonQuery();
                    }
                    Con.Close();

                }

                return true;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
                return false;
            }
        }
        //Evento para Editar los Registros ya Existentes
        public bool IditarMatricula(Modulo_Matricula Mat)
        {
            try
            {
                using (SqlConnection Con = new Conexion().GetConexion())
                {
                    Con.Open();
                    string sql = "update Matricula set Alumno = '" + Mat.Alumno + "',Sede = '" + Mat.Sede + "', Clase = '" + Mat.Clase + "',Codigo = '" + Mat.Codigo + "', UV = '" + Mat.UV + "', Dia = '" + Mat.Dia + "', Estatus =  '" + Mat.Estatus + "', Inicio = '" + Mat.Inicio + "', Fin = '" + Mat.Fin + "''  where IdAlumno = '" + Mat.IdAlumno + "'";

                    using (SqlCommand cmd = new SqlCommand(sql, Con))
                    {
                        cmd.ExecuteNonQuery();
                    }
                    Con.Close();

                }

                return true;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
                return false;
            }
        }
        //Evento para Editar los Registros ya Existentes
        public Modulo_Matricula ConsultarMatricula(string Alumno)
        {
            try
            {
                Modulo_Matricula Mat = new Modulo_Matricula();
                using (SqlConnection Con = new Conexion().GetConexion())
                {
                    Con.Open();

                    string sql = "select * from Matricula where Alumno = '" + Alumno + "'";

                    using (SqlCommand cmd = new SqlCommand(sql, Con))
                    {

                        SqlDataReader LeerDatos = cmd.ExecuteReader();


                        if (LeerDatos.HasRows)
                        {
                            while (LeerDatos.Read())
                            {
                                Mat.IdAlumno = LeerDatos.GetString(0);
                                Mat.Alumno = LeerDatos.GetString(1);
                                Mat.Sede = LeerDatos.GetString(2);
                                Mat.Codigo = LeerDatos.GetString(3);
                                Mat.Clase = LeerDatos.GetString(4);
                                Mat.UV = LeerDatos.GetString(5);
                                Mat.Dia = LeerDatos.GetString(6);
                                Mat.Estatus = LeerDatos.GetString(7);
                                Mat.Inicio = LeerDatos.GetString(8);
                                Mat.Fin = LeerDatos.GetString(9);

                            }

                            return Mat;

                        }

                    }
                    Con.Close();
                    return null;
                }


            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
                return null;
            }
        }
        //Evento para Eliminar los Registros ya Existentes
        public bool EliminarMatricula(String Clase)
        {
            try
            {
                using (SqlConnection Con = new Conexion().GetConexion())
                {
                    Con.Open();
                    string sql = "delete Matricula where Clase = '" + Clase + "' ";

                    using (SqlCommand cmd = new SqlCommand(sql, Con))
                    {
                        cmd.ExecuteNonQuery();
                    }
                    Con.Close();

                }

                return true;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
                return false;
            }
        }
    }
}
