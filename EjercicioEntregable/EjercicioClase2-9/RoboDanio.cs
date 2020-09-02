using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase2_9
{
    class RoboDanio: Seguros
    {
        public string ModeloTelefono { get; set; }
        public float TamanioPulgadas { get; set; }
        public float PrecioActual { get; set; }
        public DateTime FechaCompra { get; set; }
    }
}
