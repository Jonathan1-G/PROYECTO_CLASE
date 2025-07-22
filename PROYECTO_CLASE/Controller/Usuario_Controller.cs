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
    internal class Usuario_Controller
    {
        //Evento para cargar los datos de la Base SQL a los DataGridView
        public void ListarUsuario()
        {
            try
            {
                DataTable dt = new DataTable();
                using (SqlConnection Con = new Conexion().GetConexion())
                {
                    Con.Open();
                    string sql = "select * from Usuario";

                    using (SqlCommand cmd = new SqlCommand(sql, Con))
                    {
                        SqlDataAdapter LeerDatos = new SqlDataAdapter(cmd);
                        LeerDatos.Fill(dt);
                    }
                    Modulo_Usuario.GetUsuario = dt;
                    Con.Close();

                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

        }
        //Evento para Guardar Nuevo Registros en la Base de SQL
        public bool CrearUsuario(Modulo_Usuario Usu)
        {
            try
            {
                using (SqlConnection Con = new Conexion().GetConexion())
                {
                    Con.Open();
                    string sql = "insert into Usuario(IdUsuario,Usuario,Rol,Contrasena) values ('" + Usu.IdUsuario + "','" + Usu.Usuario + "','" + Usu.Rol + "','" + Usu.Contrasena + "')";

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
        public bool IditarUsuario(Modulo_Usuario Usu)
        {
            try
            {
                using (SqlConnection Con = new Conexion().GetConexion())
                {
                    Con.Open();
                    string sql = "update Usuario set Usuario = '" + Usu.Usuario + "', Rol = '" + Usu.Rol + "', Contrasena = '" + Usu.Contrasena+ "' where IdUsuario = '" + Usu.IdUsuario + "'";

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
        public Modulo_Usuario ConsultarUsuario(string Usuario)
        {
            try
            {
                Modulo_Usuario Usu = new Modulo_Usuario();
                using (SqlConnection Con = new Conexion().GetConexion())
                {
                    Con.Open();

                    string sql = "select * from Usuario where Usuario = '" + Usuario + "'";

                    using (SqlCommand cmd = new SqlCommand(sql, Con))
                    {

                        SqlDataReader LeerDatos = cmd.ExecuteReader();


                        if (LeerDatos.HasRows)
                        {
                            while (LeerDatos.Read())
                            {
                                Usu.IdUsuario = LeerDatos.GetString(0);
                                Usu.Usuario = LeerDatos.GetString(1);
                                Usu.Rol = LeerDatos.GetString(2);
                                Usu.Contrasena = LeerDatos.GetString(3);
                                
                            }

                            return Usu;

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
        public bool EliminarUsuario(String IdUsuario)
        {
            try
            {
                using (SqlConnection Con = new Conexion().GetConexion())
                {
                    Con.Open();
                    string sql = "delete Usuario where IdUsuario = '" + IdUsuario + "' ";

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
