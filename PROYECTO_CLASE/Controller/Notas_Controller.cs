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
    internal class Notas_Controller
    {
        //Evento para cargar los datos de la Base SQL a los DataGridView
        public void ListarNotas()
        {
            try
            {
                DataTable dt = new DataTable();
                using (SqlConnection Con = new Conexion().GetConexion())
                {
                    Con.Open();
                    string sql = "select * from Notas";

                    using (SqlCommand cmd = new SqlCommand(sql, Con))
                    {
                        SqlDataAdapter LeerDatos = new SqlDataAdapter(cmd);
                        LeerDatos.Fill(dt);
                    }
                    Modulo_Notas.GetNotas = dt;
                    Con.Close();

                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

        }
        //Evento para Guardar Nuevo Registros en la Base de SQL
        public bool CrearNotas(Modulo_Notas Not)
        {
            try
            {
                using (SqlConnection Con = new Conexion().GetConexion())
                {
                    Con.Open();
                    string sql = "insert into Notas(IdAlumno,Alumno,Codigo,Clases,Catedratico, IdCatedratico ,Estatus,UV,Nota,Anio,Periodo) values ('" + Not.IdAlumno + "','" + Not.Alumno + "','" + Not.Codigo + "','" + Not.Clase + "','" + Not.Catedratico + "','" + Not.IdCatedratico + "','" + Not.Estatus + "','" + Not.UV + "','" + Not.Nota + "','" + Not.Anio + "','" + Not.Periodo + "')";

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
        public bool IditarNotas(Modulo_Notas Not)
        {
            try
            {
                using (SqlConnection Con = new Conexion().GetConexion())
                {
                    Con.Open();
                    string sql = "update Notas set Alumno = '" + Not.Alumno + "',Codigo = '" + Not.Codigo + "', Clases = '" + Not.Clase + "',Catedratico = '" + Not.Catedratico + "', IdCatedratico = '" + Not.IdCatedratico + "' , Estatus = '" + Not.Estatus + "', UV = '" + Not.UV + "', Nota = '" + Not.Nota + "', Anio =  '" + Not.Anio + "', Periodo = '" + Not.Periodo + "' where IdAlumno = '" + Not.IdAlumno + "'";

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
        public Modulo_Notas ConsultarNotas(string Alumno)
        {
            try
            {
                Modulo_Notas Not = new Modulo_Notas();
                using (SqlConnection Con = new Conexion().GetConexion())
                {
                    Con.Open();

                    string sql = "select * from Notas where Alumno = '" + Alumno + "'";

                    using (SqlCommand cmd = new SqlCommand(sql, Con))
                    {

                        SqlDataReader LeerDatos = cmd.ExecuteReader();


                        if (LeerDatos.HasRows)
                        {
                            while (LeerDatos.Read())
                            {
                                Not.IdAlumno = LeerDatos.GetString(0);
                                Not.Alumno = LeerDatos.GetString(1);
                                Not.Codigo = LeerDatos.GetString(2);
                                Not.Clase = LeerDatos.GetString(3);
                                Not.Catedratico = LeerDatos.GetString(4);
                                Not.IdCatedratico = LeerDatos.GetString(5);
                                Not.Estatus = LeerDatos.GetString(6);
                                Not.UV = LeerDatos.GetString(7);
                                Not.Nota = LeerDatos.GetInt32(8);
                                Not.Anio = LeerDatos.GetString(9);
                                Not.Periodo = LeerDatos.GetString(10);

                            }

                            return Not;

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
        public bool EliminarNotas(String Codigo)
        {
            try
            {
                using (SqlConnection Con = new Conexion().GetConexion())
                {
                    Con.Open();
                    string sql = "delete Notas where Codigo = '" + Codigo + "' ";

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
