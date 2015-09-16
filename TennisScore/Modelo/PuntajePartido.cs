using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TennisScore.Modelo
{
    public class PuntajePartido
    {
        public int PuntajeJugador1 { get; set; }
        public int PuntajeJugador2 { get; set; }
        public int ACEJ1 { get; set; }
        public int ACEJ2 { get; set; }
        public int DobleFaltaJ1 { get; set; }
        public int DobleFaltaJ2 { get; set; }
        public bool VentajaJ1 { get; set; }
        public bool VentajaJ2 { get; set; }
        public int Set { get; set; }
        public bool Deuce { get; set; }

        public bool SetFinalizado { get; set; }
    }
}
