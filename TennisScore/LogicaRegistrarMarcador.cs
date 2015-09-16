using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TennisScore.Modelo;   

namespace TennisScore
{
    public class LogicaRegistrarMarcador
    {
        public void AumentarPunto(ref PuntajePartido puntajePartido, bool jugador1)
        {
            if (puntajePartido.VentajaJ1 && !jugador1)
            {
                puntajePartido.Deuce = true;
                puntajePartido.VentajaJ1 = false;
            }
            else if (puntajePartido.Ventajaj2 && jugador1)
            {
                puntajePartido.Deuce = true;
                puntajePartido.Ventajaj2 = false;
            }
            else
            {
                if (puntajePartido.Deuce)
                {
                    if (jugador1)
                    {
                        puntajePartido.VentajaJ1 = true;
                    }
                    else
                    {
                        puntajePartido.Ventajaj2 = true;
                    }

                    puntajePartido.Deuce = false;
                }
                else
                {
                    puntajePartido.VentajaJ1 = false;
                    puntajePartido.Ventajaj2 = false;

                    if (jugador1)
                    {
                        var puntaje = puntajePartido.PuntajeJugador1;
                        puntaje++;
                        puntajePartido.PuntajeJugador1 = puntaje;

                        if (puntajePartido.PuntajeJugador1 > 4)
                        {
                            puntajePartido.PuntajeJugador1 = 0;
                        }
                    }
                    else
                    {
                        var puntaje = puntajePartido.PuntajeJugador2;
                        puntaje++;
                        puntajePartido.PuntajeJugador2 = puntaje;

                        if (puntajePartido.PuntajeJugador2 > 4)
                        {
                            puntajePartido.PuntajeJugador2 = 0;
                        }
                    }

                    if (puntajePartido.PuntajeJugador1 == 3 && puntajePartido.PuntajeJugador2 == 3)
                    {
                        puntajePartido.Deuce = true;
                    }
                    else
                    {
                        puntajePartido.Deuce = false;
                    }
                }
            }

            puntajePartido.SetFinalizado = ValidarSetFinalizado(puntajePartido);
        }

        public void AumentarPuntoACE(ref PuntajePartido puntajePartido, bool p)
        {
            if (puntajePartido.Deuce)
            {
                if (p)
                {
                    puntajePartido.VentajaJ1 = true;
                    var puntajeAce = puntajePartido.ACEJ1;
                    puntajeAce++;
                    puntajePartido.ACEJ1 = puntajeAce;
                }
                else
                {
                    puntajePartido.Ventajaj2 = true;
                    var puntajeAce = puntajePartido.ACEJ2;
                    puntajeAce++;
                    puntajePartido.ACEJ2 = puntajeAce;
                }

                puntajePartido.Deuce = false;
            }
            else
            {
                if (p)
                {
                    var puntajeAce = puntajePartido.ACEJ1;
                    puntajeAce++;
                    puntajePartido.ACEJ1 = puntajeAce;
                    AumentarPunto(ref puntajePartido, true);

                }
                else
                {
                    var puntajeAce = puntajePartido.ACEJ2;
                    puntajeAce++;
                    puntajePartido.ACEJ2 = puntajeAce;
                    AumentarPunto(ref puntajePartido, false);
                }
            }
        }

        public void AumentarDobleFalta(ref PuntajePartido puntajePartido, bool p)
        {
            if (puntajePartido.Deuce)
            {
                if (p)
                {
                    puntajePartido.Ventajaj2 = true;
                    var puntajefalta = puntajePartido.DobleFaltaJ2;
                    puntajefalta++;
                    puntajePartido.DobleFaltaJ2 = puntajefalta;
                }
                else
                {
                    puntajePartido.VentajaJ1 = true;
                    
                    var puntajefalta = puntajePartido.DobleFaltaJ1;
                    puntajefalta++;
                    puntajePartido.DobleFaltaJ1 = puntajefalta;                   
                }

                puntajePartido.Deuce = false;
            }
            else
            {
                if (p)
                {
                    var puntajefalta = puntajePartido.DobleFaltaJ1;
                    puntajefalta++;
                    puntajePartido.DobleFaltaJ1 = puntajefalta;
                    AumentarPunto(ref puntajePartido, false);
                }
                else
                {
                    var puntajefalta = puntajePartido.DobleFaltaJ2;
                    puntajefalta++;
                    puntajePartido.DobleFaltaJ2 = puntajefalta;
                    AumentarPunto(ref puntajePartido, true);
                }
            }
        }

        public bool AumentarSet(PuntajePartido puntajePartido) 
        {
            return puntajePartido.PuntajeJugador1 > puntajePartido.PuntajeJugador2;
        }

        public bool SumarTotalSet(int PuntosJugadorUno, int PuntosJugadorDos)
        {
            if(PuntosJugadorUno > PuntosJugadorDos)
            {
            }
            return true;
        }

        public bool ValidarSetFinalizado(PuntajePartido puntajePartido)
        {
            //if(puntajePartido.PuntajeJugador1 == 3 && puntajePartido.PuntajeJugador2 < 3)
            //{
            //    return true;
            //}            

            return false;
        }
    }
}
