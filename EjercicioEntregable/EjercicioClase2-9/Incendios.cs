using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase2_9
{
    class Incendios: Seguros
    {
        public float MetrosCuadradosCasa { get; set; }
        public int CantidadMatafuegos { get; set; }
        public int CantidadEnchufes { get; set; }
        public bool EsCasa { get; set; } //Si es false es lugar de trabajo
        public float MontoMateriales { get; set; }

    }
}
