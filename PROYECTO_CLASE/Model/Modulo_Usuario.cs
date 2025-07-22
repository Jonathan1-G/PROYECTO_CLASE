using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_CLASE.Model
{
    internal class Modulo_Usuario
    {
        public Modulo_Usuario() { }

        public string IdUsuario { get; set; }
        public string Usuario { get; set; }
        public string Rol { get; set; }
        public string Contrasena { get; set; }

        public static DataTable GetUsuario { get; set; }
    }
}
