using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_CLASE.Model
{
    internal class Modulo_Alumno
    {
        public Modulo_Alumno() { }
        public string IdAlumno { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string IdUsuario { get; set; }
        public string Usuario { get; set; }
        public string Rol { get; set; }
        public string Contrasena { get; set; }
        public string Identidad { get; set; }
        public string Carrera { get; set; }
        public string IdCarrera { get; set; }
        public string Sede { get; set; }
        public string IdSede { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }

        public static DataTable GetAlumno { get; set; }
    }
}
