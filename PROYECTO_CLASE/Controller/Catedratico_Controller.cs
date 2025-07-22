
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
    internal class Catedratico_Controller
    {
        //Evento para cargar los datos de la Base SQL a los DataGridView
        public void ListarCatedratico()
        {
            try
            {
                DataTable dt = new DataTable();
                using (SqlConnection Con = new Conexion().GetConexion())
                {
                    Con.Open();
                    string sql = "select * from Catedratico";

                    using (SqlCommand cmd = new SqlCommand(sql, Con))
                    {
                        SqlDataAdapter LeerDatos = new SqlDataAdapter(cmd);
                        LeerDatos.Fill(dt);
                    }
                    Mudulo_Catedratico.GetCatedratico = dt;
                    Con.Close();

                }

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
        //Evento para Guardar Nuevo Registros en la Base de SQL
        public bool CrearCatedratico(Mudulo_Catedratico cat)
        {
            try
            {
                using (SqlConnection Con = new Conexion().GetConexion())
                {
                    Con.Open();
                    string sql = "insert into Catedratico(IdCatedratico,Nombre,Apellido,IdUsuario,Usuario,Rol,Contrasena,Identidad,Sede,IdSede,Telefono,Correo) values ('" + cat.IdCatedratico + "','" + cat.Nombre + "','" + cat.Apellido + "','" + cat.IdUsuario + "','" + cat.Usuario + "','" + cat.Rol + "','" + cat.Contrasena + "','" + cat.Identidad + "','" + cat.Sede + "','" + cat.IdSede + "','" + cat.Telefono + "','" + cat.Correo + "')";

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
        public bool IditarCatedratico(Mudulo_Catedratico Cat)
        {
            try
            {
                using (SqlConnection Con = new Conexion().GetConexion())
                {
                    Con.Open();
                    string sql = "update Catedratico set Nombre = '" + Cat.Nombre + "', Apellido = '" + Cat.Apellido + "', IdUsuario = '" + Cat.IdUsuario + "', Usuario = '" + Cat.Usuario + "', Rol = '" + Cat.Rol + "', Contrasena = '" + Cat.Contrasena + "', Identidad = '" + Cat.Identidad + "', Sede = '" + Cat.Sede + "', IdSede = '" + Cat.IdSede + "', Telefono = '" + Cat.Telefono + "', Correo = '" + Cat.Correo + "' where IdCatedratico = '" + Cat.IdCatedratico + "'";

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
        public Mudulo_Catedratico ConsultarCatedratico(string Usuario)
        {
            try
            {
                Mudulo_Catedratico Cat = new Mudulo_Catedratico();
                using (SqlConnection Con = new Conexion().GetConexion())
                {
                    Con.Open();

                    string sql = "select * from Catedratico where Usuario = '" + Usuario + "'";

                    using (SqlCommand cmd = new SqlCommand(sql, Con))
                    {

                        SqlDataReader LeerDatos = cmd.ExecuteReader();


                        if (LeerDatos.HasRows)
                        {
                            while (LeerDatos.Read())
                            {
                                Cat.IdCatedratico = LeerDatos.GetString(0);
                                Cat.Nombre = LeerDatos.GetString(1);
                                Cat.Apellido = LeerDatos.GetString(2);
                                Cat.IdUsuario = LeerDatos.GetString(3);
                                Cat.Usuario = LeerDatos.GetString(4);
                                Cat.Rol = LeerDatos.GetString(5);
                                Cat.Contrasena = LeerDatos.GetString(6);
                                Cat.Identidad = LeerDatos.GetString(7);
                                Cat.Sede = LeerDatos.GetString(8);
                                Cat.IdSede = LeerDatos.GetString(9);
                                Cat.Telefono = LeerDatos.GetString(10);
                                Cat.Correo = LeerDatos.GetString(11);

                            }

                            return Cat;

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
        public bool EliminarCatedratico(String IdCatedratico)
        {
            try
            {
                using (SqlConnection Con = new Conexion().GetConexion())
                {
                    Con.Open();
                    string sql = "delete Catedratico where IdCatedratico = '" + IdCatedratico + "' ";

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
