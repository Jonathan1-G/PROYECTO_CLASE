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
    internal class Campus_Controller
    {
        //Evento para cargar los datos de la Base SQL a los DataGridView
        public void ListarCampus()
        {
            try
            {
                DataTable dt = new DataTable();
                using (SqlConnection Con = new Conexion().GetConexion())
                {
                    Con.Open();
                    string sql = "select * from Campus";

                    using (SqlCommand cmd = new SqlCommand(sql, Con))
                    {
                        SqlDataAdapter LeerDatos = new SqlDataAdapter(cmd);
                        LeerDatos.Fill(dt);
                    }
                    Modulo_Campus.GetCampus = dt;
                    Con.Close();

                }

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
        
        //Evento para Guardar Nuevo Registros en la Base de SQL
        public bool CrearCampus(Modulo_Campus Cam)
        {
            try
            {
                using (SqlConnection Con = new Conexion().GetConexion())
                {
                    Con.Open();
                    string sql = "insert into Campus(IdSede,Sede,Telefono,Direccion) values ('" + Cam.IdSede + "','" + Cam.Sede + "','" + Cam.Telefono + "','" + Cam.Direccion + "')";

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
        public bool IditarCampus(Modulo_Campus Cam)
        {
            try
            {
                using (SqlConnection Con = new Conexion().GetConexion())
                {
                    Con.Open();
                    string sql = "update Campus set Sede = '"+Cam.Sede+"', Telefono = '" + Cam.Telefono + "', Direccion = '" + Cam.Direccion + "' where IdSede = '" + Cam.IdSede + "'";

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
        public Modulo_Campus ConsultarCampus(string IdSede)
        {
            try
            {
                Modulo_Campus Cam = new Modulo_Campus();
                using (SqlConnection Con = new Conexion().GetConexion())
                {
                    Con.Open();

                    string sql = "select * from Campus where IdSede = '" + IdSede + "'";

                    using (SqlCommand cmd = new SqlCommand(sql, Con))
                    {

                        SqlDataReader LeerDatos = cmd.ExecuteReader();


                        if (LeerDatos.HasRows)
                        {
                            while (LeerDatos.Read())
                            {
                                Cam.IdSede = LeerDatos.GetString(0);
                                Cam.Sede = LeerDatos.GetString(1);
                                Cam.Telefono = LeerDatos.GetString(2);
                                Cam.Direccion = LeerDatos.GetString(3);

                            }

                            return Cam;

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
        public bool EliminarCampus(String IdSede)
        {
            try
            {
                using (SqlConnection Con = new Conexion().GetConexion())
                {
                    Con.Open();
                    string sql = "delete Campus where IdSede = '" + IdSede + "' ";

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
