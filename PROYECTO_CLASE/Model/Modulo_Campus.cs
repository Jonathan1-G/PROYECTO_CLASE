using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_CLASE.Model
{
    internal class Modulo_Campus
    {
        public Modulo_Campus() { }

        public string IdSede { get; set; }
        public string Sede { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }

        public static DataTable GetCampus { get; set; }
    }
}
