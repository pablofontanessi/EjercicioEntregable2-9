using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase2_9
{
    class Automotor: Seguros
    {
        public string Patente { get; set; }
        public string Marca { get; set; }
        public int AnioFabricacion{ get; set; }
        public string TipoVehiculo { get; set; }
        public int CantidadMaximaOcupantes{ get; set; }
    }
}
