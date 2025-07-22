using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PROYECTO_CLASE.Model;

namespace PROYECTO_CLASE.Controller
{
    internal class Alumno_Controller
    {
        //Evento para cargar los datos de la Base SQL a los DataGridView
        public void ListarAlumno()
        {
            try
            {
                DataTable dt = new DataTable();
                using (SqlConnection Con = new Conexion().GetConexion())
                {
                    Con.Open();
                    string sql = "select * from Alumno";

                    using (SqlCommand cmd = new SqlCommand(sql, Con))
                    {
                        SqlDataAdapter LeerDatos = new SqlDataAdapter(cmd);
                        LeerDatos.Fill(dt);
                    }
                    Modulo_Alumno.GetAlumno = dt;
                    Con.Close();

                }

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
        //Evento para Guardar Nuevo Registros en la Base de SQL
        public bool CrearAlumno(Modulo_Alumno Alu)
        {
            try
            {
                using (SqlConnection Con = new Conexion().GetConexion())
                {
                    Con.Open();
                    string sql = "insert into Alumno(IdAlumno,Nombre,Apellido,IdUsuario,Usuario,Rol,Contrasena,Identidad,Carrera,IdCarrera,Sede,IdSede,Telefono,Correo) values ('" + Alu.IdAlumno + "','" + Alu.Nombre + "','" + Alu.Apellido + "','" + Alu.IdUsuario + "','" + Alu.Usuario + "','" + Alu.Rol + "','" + Alu.Contrasena + "','" + Alu.Identidad + "','" + Alu.Carrera + "','" + Alu.IdCarrera + "','" + Alu.Sede + "','" + Alu.IdSede + "','" + Alu.Telefono + "','" + Alu.Correo + "')";

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
        //Evento para Editar Registros Existentes en la Base de Datos SQL
        public bool IditarAlumno(Modulo_Alumno Alu)
        {
            try
            {
                using (SqlConnection Con = new Conexion().GetConexion())
                {
                    Con.Open();
                    string sql = "update Alumno set Nombre = '" + Alu.Nombre + "', Apellido = '" + Alu.Apellido + "', IdUsuario = '" + Alu.IdUsuario + "', Usuario = '" + Alu.Usuario + "', Rol = '" + Alu.Rol + "', Contrasena = '" + Alu.Contrasena + "', Identidad = '" + Alu.Identidad + "', Carrera = '" + Alu.Carrera + "', IdCarrera = '" + Alu.IdCarrera + "', Sede = '" + Alu.Sede + "', IdSede = '" + Alu.IdSede + "', Telefono = '" + Alu.Telefono + "', Correo = '" + Alu.Correo + "' where IdAlumno = '" + Alu.IdAlumno + "'";

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
        public Modulo_Alumno ConsultarAlumno(string Usuario)
        {
            try
            {
                Modulo_Alumno Alu = new Modulo_Alumno();
                using (SqlConnection Con = new Conexion().GetConexion())
                {
                    Con.Open();

                    string sql = "select * from Alumno where Usuario = '" + Usuario + "'";

                    using (SqlCommand cmd = new SqlCommand(sql, Con))
                    {

                        SqlDataReader LeerDatos = cmd.ExecuteReader();


                        if (LeerDatos.HasRows)
                        {
                            while (LeerDatos.Read())
                            {
                                Alu.IdAlumno = LeerDatos.GetString(0);
                                Alu.Nombre = LeerDatos.GetString(1);
                                Alu.Apellido = LeerDatos.GetString(2);
                                Alu.IdUsuario = LeerDatos.GetString(3);
                                Alu.Usuario = LeerDatos.GetString(4);
                                Alu.Rol = LeerDatos.GetString(5);
                                Alu.Contrasena = LeerDatos.GetString(6);
                                Alu.Identidad = LeerDatos.GetString(7);
                                Alu.Carrera = LeerDatos.GetString(8);
                                Alu.IdCarrera = LeerDatos.GetString(9);
                                Alu.Sede = LeerDatos.GetString(10);
                                Alu.IdSede = LeerDatos.GetString(11);
                                Alu.Telefono = LeerDatos.GetString(12);
                                Alu.Correo = LeerDatos.GetString(13);

                            }

                            return Alu;

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
        //Evento para Eliminar Registros de La Base SQL
        public bool EliminarAlumno(String IdAlumno)
        {
            try
            {
                using (SqlConnection Con = new Conexion().GetConexion())
                {
                    Con.Open();
                    string sql = "delete Alumno where IdAlumno = '" + IdAlumno + "' ";

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
