using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_CLASE.Model
{
    internal class Mudulo_Catedratico
    {
        public Mudulo_Catedratico() { }
        public string IdCatedratico { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string IdUsuario { get; set; }
        public string Usuario { get; set; }
        public string Rol { get; set; }
        public string Contrasena { get; set; }
        public string Identidad { get; set; }
        public string Sede { get; set; }
        public string IdSede { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }

        public static DataTable GetCatedratico { get; set; }
    }
}
