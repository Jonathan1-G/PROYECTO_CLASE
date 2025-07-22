using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_CLASE.Model
{
    internal class Modulo_Matricula
    {
        public Modulo_Matricula() { }
        public string IdAlumno { get; set; }
        public string Alumno { get;set; }
        public string Sede { get; set; }   
        public string Codigo { get; set; }
        public string Clase { get; set; }
        public string UV { get; set; }
        public string Dia { get; set; } 
        public string Estatus { get; set; }
        public string Inicio { get; set; }
        public string Fin { get; set; }

        public static DataTable GetMatricula { get; set; }
    }
}
