using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TennisScore.Modelo
{
    public class ConfiguracionPartido
    {
        public string Genero { get; set; }
        public int NumeroDeSets { get; set; }
        public string NombreJugadorUno { get; set; }
        public string NacionalidadJugadorUno { get; set; }
        public string NombreJugadorDos { get; set; }
        public string NacionalidadJugadorDos { get; set; }
        public int Servicio { get; set; }
     }
}
