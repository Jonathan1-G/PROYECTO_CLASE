using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_CLASE.Model
{
    internal class Modulo_Notas
    {
        public Modulo_Notas() { }
        public string IdAlumno { get; set; }
        public string Alumno { get; set; }
        public string Codigo { get; set; }
        public string Clase { get; set; }
        public string Catedratico { get; set; }
        public string IdCatedratico { get; set; }
        public string Estatus { get; set; }
        public string UV { get; set; }
        public int Nota { get; set; }
        public string Anio { get; set; }
        public string Periodo { get; set; }

        public static DataTable GetNotas { get; set; }
    }
}
