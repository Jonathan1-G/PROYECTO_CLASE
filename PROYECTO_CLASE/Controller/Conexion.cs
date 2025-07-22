using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace PROYECTO_CLASE.Controller
{
    internal class Conexion
    {

        public SqlConnection GetConexion()
        {
            SqlConnection Sqlcon = new SqlConnection(ConfigurationManager.ConnectionStrings["BDDBaseDatosProye"].ToString());

            return Sqlcon;
        }

    }
}
