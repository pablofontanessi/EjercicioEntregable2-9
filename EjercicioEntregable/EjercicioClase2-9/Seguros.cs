using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase2_9
{
    public class Seguros
    {
        public Personas Tomador { get; set; }
        public Personas Beneficiario { get; set; }
        public double PrimaAsegurada { get; set; } //valor anual
        public long NumeroDePoliza { get; set; }
        public double CostoProducto { get; set; } // valor mensual

        public double CalcularCobertura()
        {
            double Cobertura = ((CostoProducto*12)/PrimaAsegurada) *100; //El *100 para que vaya en porcentaje

            return Cobertura;

        }

    }
}
