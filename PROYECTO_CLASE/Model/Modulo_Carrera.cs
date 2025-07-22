using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_CLASE.Model
{
    internal class Modulo_Carrera
    {
        public Modulo_Carrera() { }
        public string IdCarrera { get; set; }
        public string Carrera { get; set; }
        public string Sede { get; set; }
        public string IdSede { get; set; }

        public static DataTable GetCarrera { get; set; }
    }
}
