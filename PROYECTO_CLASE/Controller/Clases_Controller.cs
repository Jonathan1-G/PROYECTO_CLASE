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
    internal class Clases_Controller
    {
        //Evento para cargar los datos de la Base SQL a los DataGridView
        public void ListarClases()
        {
            try
            {
                DataTable dt = new DataTable();
                using (SqlConnection Con = new Conexion().GetConexion())
                {
                    Con.Open();
                    string sql = "select * from Clases";

                    using (SqlCommand cmd = new SqlCommand(sql, Con))
                    {
                        SqlDataAdapter LeerDatos = new SqlDataAdapter(cmd);
                        LeerDatos.Fill(dt);
                    }
                    Modulo_Clases.GetClases = dt;
                    Con.Close();

                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

        }
        //Evento para Guardar Nuevo Registros en la Base de SQL
        public bool CrearClases(Modulo_Clases Cla)
        {
            try
            {
                using (SqlConnection Con = new Conexion().GetConexion())
                {
                    Con.Open();
                    string sql = "insert into Clases(IdAsignatura,Asignatura,Creditos,HInicio, HFin,dia,Carrera,IdCarrera,Catedratico,IdCatedratico,Sede,IdSede,Precio) values ('" + Cla.IdAsignatura + "','" + Cla.Asignatura + "','" + Cla.Creditos + "','" + Cla.HInicio + "','" + Cla.HFin + "','" + Cla.dia + "','" + Cla.Carrera + "','" + Cla.IdCarrera + "','" + Cla.Catedratico + "','" + Cla.IdCatedratico + "','" + Cla.Sede + "','" + Cla.IdSede + "','" + Cla.Precio + "')";

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
        public bool IditarClases(Modulo_Clases Cla)
        {
            try
            {
                using (SqlConnection Con = new Conexion().GetConexion())
                {
                    Con.Open();
                    string sql = "update Clases set Asignatura = '" + Cla.Asignatura + "',Creditos = '" + Cla.Creditos + "', HInicio = '" + Cla.HInicio + "', HFin = '" + Cla.HFin + "', dia = '" + Cla.dia + "', Carrera = '" + Cla.Carrera + "', IdCarrera = '" + Cla.IdCarrera + "', Catedratico = '" + Cla.Catedratico + "', IdCatedratico = '" + Cla.IdCatedratico + "', Sede = '" + Cla.Sede + "', IdSede = '" + Cla.IdSede + "', Precio = '" + Cla.Precio + "' where IdAsignatura = '" + Cla.IdAsignatura + "'";

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
        public Modulo_Clases ConsultarClases(string Asignatura)
        {
            try
            {
                Modulo_Clases Cla = new Modulo_Clases();
                using (SqlConnection Con = new Conexion().GetConexion())
                {
                    Con.Open();

                    string sql = "select * from Clases where Asignatura = '" + Asignatura + "'";

                    using (SqlCommand cmd = new SqlCommand(sql, Con))
                    {

                        SqlDataReader LeerDatos = cmd.ExecuteReader();


                        if (LeerDatos.HasRows)
                        {
                            while (LeerDatos.Read())
                            {
                                Cla.IdAsignatura = LeerDatos.GetString(0);
                                Cla.Asignatura = LeerDatos.GetString(1);
                                Cla.Creditos = LeerDatos.GetString(2);
                                Cla.HInicio = LeerDatos.GetString(3);
                                Cla.HFin = LeerDatos.GetString(4);
                                Cla.dia = LeerDatos.GetString(5);
                                Cla.Carrera = LeerDatos.GetString(6);
                                Cla.IdCarrera = LeerDatos.GetString(7);
                                Cla.Catedratico = LeerDatos.GetString(8);
                                Cla.IdCatedratico = LeerDatos.GetString(9);
                                Cla.Sede = LeerDatos.GetString(10);
                                Cla.IdSede = LeerDatos.GetString(11);
                                Cla.Precio = LeerDatos.GetDecimal(12);

                            }

                            return Cla;

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
        public bool EliminarClases(String IdAsignatura)
        {
            try
            {
                using (SqlConnection Con = new Conexion().GetConexion())
                {
                    Con.Open();
                    string sql = "delete Clases where IdAsignatura = '" + IdAsignatura + "' ";

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
