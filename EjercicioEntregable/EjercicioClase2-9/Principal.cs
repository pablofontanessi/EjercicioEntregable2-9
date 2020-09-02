using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase2_9
{
    public class Principal
    {
        List<Siniestro> ListadoSiniestros = new List<Siniestro>();
        List<Personas> ListadoPersonas = new List<Personas>();
        List<Seguros> ListadoSeguros = new List<Seguros>();
        public bool ValidacionCreacionSiniestro(int DniInformador, DateTime FechaSiniestro, long NroPoliza)
        {
            
            bool PolizaEncontrada = false;
            Seguros PolizaAsegurado = new Seguros();
            foreach (var seguro in ListadoSeguros)
            {
                if (seguro.NumeroDePoliza == NroPoliza)
                {
                    PolizaEncontrada = true;
                    PolizaAsegurado = seguro;
                }
            }
            if (PolizaEncontrada)
            {
                if (PolizaAsegurado is Incendios)
                {
                    Incendios PolizaIncendio = PolizaAsegurado as Incendios;

                    if (PolizaIncendio.Tomador.DNI == DniInformador & PolizaIncendio.CantidadMatafuegos >= PolizaIncendio.CantidadEnchufes)
                    {
                        if (PolizaIncendio.EsCasa == true && PolizaIncendio.MetrosCuadradosCasa < 400)
                        {
                            return true;
                        }
                        else
                        {
                            return  true;
                        }

                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    if (PolizaAsegurado is Automotor)
                    {
                        Automotor PolizaAutomotor = PolizaAsegurado as Automotor;

                        if (PolizaAutomotor.Beneficiario.DNI == DniInformador & PolizaAutomotor.Patente.Length > 6)
                        {
                            if (PolizaAutomotor.TipoVehiculo == "moto" & (DateTime.Today.Year - PolizaAutomotor.AnioFabricacion) < 5)
                            {
                                return  true;
                            }
                            else
                            {
                                return  false;
                            }
                        }
                    }
                    else
                    {
                        if (PolizaAsegurado is RoboDanio)
                        {
                            RoboDanio PolizaRoboDanio = PolizaAsegurado as RoboDanio;

                            if (PolizaRoboDanio.Beneficiario.DNI == DniInformador & PolizaRoboDanio.Tomador.DNI == DniInformador & PolizaRoboDanio.TamanioPulgadas < 6)
                            {
                                return  true;
                            }
                            else
                            {
                                return  false;
                            }
                        }
                    }

                }
            }

            return false;

        }
        public bool RegistrarSiniestros(int DniInformador, DateTime FechaSiniestro, long NroPoliza)
        {
            if(ValidacionCreacionSiniestro( DniInformador,  FechaSiniestro, NroPoliza))
            {
                Personas Informador = ObtenerPersonaPorDNI(DniInformador);
                Siniestro NuevoSiniestro = new Siniestro(FechaSiniestro, NroPoliza, Informador);
                ListadoSiniestros.Add(NuevoSiniestro);
                return true;
            }
            return false;
        }
        public Personas ObtenerPersonaPorDNI(int DNI)
        {
            Personas personaVacia = new Personas();
            foreach (var persona in ListadoPersonas)
            {
                if (persona.DNI == DNI)
                {
                    return persona;
                }
            }
            personaVacia.DNI = DNI;
            return personaVacia;
        }

        public List<Reporte> ObtenerListadoSiniestroPorPersona(int Dni)
        {
            List<Reporte> ListadoSiniestroReport = new List<Reporte>();
            foreach (var siniestro in ListadoSiniestros)
            {
                if (siniestro.Informador.DNI == Dni)
                {
                    Reporte PersonaEncontrada = new Reporte();
                    PersonaEncontrada.NombreYApellido = siniestro.Informador.ObtenerNombreYApellido();
                    PersonaEncontrada.FechaSiniestro = siniestro.FechaSiniestro;
                    PersonaEncontrada.TipoSeguro = ObtenerTipoSeguro(siniestro.NroPoliza);
                    ListadoSiniestroReport.Add(PersonaEncontrada);
                }
            }
            return ListadoSiniestroReport;
        
        }
        public string ObtenerTipoSeguro(long NroPoliza)
        {
            foreach (var seguro in ListadoSeguros)
            {
                if (seguro.NumeroDePoliza == NroPoliza)
                {
                    if (seguro is Incendios)
                    {
                        return "Incendio";
                    }
                    else
                    {
                        if (seguro is Automotor)
                        {
                            return "Automotor";
                        }
                        else
                        {
                            if (seguro is RoboDanio)
                            {
                                return "Robo y Daño";
                            }
                        }
                    }
                }
            }
            return "No encontro Tipo";
        }
    }
}
