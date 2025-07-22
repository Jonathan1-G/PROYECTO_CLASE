using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_CLASE
{
    internal class Clase_Clases
    {
        public Clase_Clases() { }

        public int IdAsignatura { get; set; }
        public string Asignatura { get; set; }
        public string Creditos { get; set; }
        public string HInicio { get; set; }
        public string HFin { get; set; }
        public string dia { get; set; }
        public string Catedratico { get; set; }
        public int IdCatedratico { get; set; }
        public string Sede { get; set; }
        public int IdSede { get; set; }
        public decimal Precio { get; set; }


        public static DataTable GetClases  { get; set; }
    }
}
