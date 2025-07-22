using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_CLASE.Model
{
    internal class Modulo_Clases
    {
        public Modulo_Clases() { }

        public string IdAsignatura { get; set; }
        public string Asignatura { get; set; }
        public string Creditos { get; set; }
        public string HInicio { get; set; }
        public string HFin { get; set; }
        public string dia { get; set; }
        public string Carrera { get; set; }
        public string IdCarrera { get; set; }
        public string Catedratico { get; set; }
        public string IdCatedratico { get; set; }
        public string Sede { get; set; }
        public string IdSede { get; set; }
        public decimal Precio { get; set; }


        public static DataTable GetClases  { get; set; }
    }
}
