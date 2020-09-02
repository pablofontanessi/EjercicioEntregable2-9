using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase2_9
{
    public class Personas
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int DNI { get; set; }

        public string ObtenerNombreYApellido()
        {
            return Nombre + " " + Apellido;
        }
        
    }
}
