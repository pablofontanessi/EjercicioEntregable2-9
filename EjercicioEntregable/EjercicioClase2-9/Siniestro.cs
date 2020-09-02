using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase2_9
{
   public class Siniestro
    {
        public Personas Informador { get; set; } 
        public DateTime FechaSiniestro { get; set; }
        public long NroPoliza { get; set; }
        public Siniestro(DateTime FechaSiniestros, long NroDePolizas, Personas informador)
        {
            FechaSiniestro = FechaSiniestros;
            NroPoliza = NroDePolizas;
            Informador = informador; 

        }
    }
}
