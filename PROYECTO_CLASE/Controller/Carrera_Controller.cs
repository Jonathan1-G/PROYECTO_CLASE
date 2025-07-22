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
    internal class Carrera_Controller
    {
        //Evento para cargar los datos de la Base SQL a los DataGridView
        public void ListarCarrera()
        {
            try
            {
                DataTable dt = new DataTable();
                using (SqlConnection Con = new Conexion().GetConexion())
                {
                    Con.Open();
                    string sql = "select * from Carrera";

                    using (SqlCommand cmd = new SqlCommand(sql, Con))
                    {
                        SqlDataAdapter LeerDatos = new SqlDataAdapter(cmd);
                        LeerDatos.Fill(dt);
                    }
                    Modulo_Carrera.GetCarrera = dt;
                    Con.Close();

                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

        }
        //Evento para Guardar Nuevo Registros en la Base de SQL
        public bool CrearCarrera(Modulo_Carrera Car)
        {
            try
            {
                using (SqlConnection Con = new Conexion().GetConexion())
                {
                    Con.Open();
                    string sql = "insert into Carrera(IdCarrera,Carrera,Sede,IdSede) values ('" + Car.IdCarrera + "','" + Car.Carrera + "','" + Car.Sede + "','" + Car.IdSede + "')";

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
        public bool EditarCarrera(Modulo_Carrera Car)
        {
            try
            {
                using (SqlConnection Con = new Conexion().GetConexion())
                {
                    Con.Open();
                    string sql = "update Carrera set Carrera = '" + Car.Carrera + "',Sede = '" + Car.Sede + "', IdSede = '" + Car.IdSede + "' where IdCarrera = '" + Car.IdCarrera + "'";

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
        public Modulo_Carrera ConsultarCarrera(string IdCarrera)
        {
            try
            {
                Modulo_Carrera Car = new Modulo_Carrera();
                using (SqlConnection Con = new Conexion().GetConexion())
                {
                    Con.Open();

                    string sql = "select * from Carrera where IdCarrera = '" + IdCarrera + "'";

                    using (SqlCommand cmd = new SqlCommand(sql, Con))
                    {

                        SqlDataReader LeerDatos = cmd.ExecuteReader();


                        if (LeerDatos.HasRows)
                        {
                            while (LeerDatos.Read())
                            {
                                Car.IdCarrera = LeerDatos.GetString(0);
                                Car.Carrera = LeerDatos.GetString(1);
                                Car.Sede = LeerDatos.GetString(2);
                                Car.IdSede = LeerDatos.GetString(3);

                            }

                            return Car;

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
        public bool EliminarCarrera(String IdCarrera)
        {
            try
            {
                using (SqlConnection Con = new Conexion().GetConexion())
                {
                    Con.Open();
                    string sql = "delete Carrera where IdCarrera = '" + IdCarrera + "' ";

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
