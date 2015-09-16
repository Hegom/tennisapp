using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;   
using TennisScore;
using TennisScore.Modelo;   

namespace TennisScore
{
    public class LogicaConfigurarPartido
    {
        public bool ValidarCampos(ConfiguracionPartido Campos)
        {   

            if (Campos.Genero == null || Campos.NumeroDeSets== 0 || Campos.NombreJugadorUno == null || Campos.NacionalidadJugadorUno== null || Campos.NombreJugadorDos== null || Campos.NacionalidadJugadorDos == null || Campos.Servicio== 0 )
            {
                return false;
            }

            return true;
        }        
    }
}
