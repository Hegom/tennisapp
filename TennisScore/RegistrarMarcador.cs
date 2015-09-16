using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TennisScore.Modelo;

namespace TennisScore
{
    public partial class RegistrarMarcador : Form
    {
        PuntajePartido PuntajePartido_;
        LogicaRegistrarMarcador logica = new LogicaRegistrarMarcador();
        ConfiguracionPartido configuracionDelPartido;

        public RegistrarMarcador(ConfiguracionPartido ConfiguracionDelPartido)
        {
            configuracionDelPartido = ConfiguracionDelPartido;
            InitializeComponent();
            PuntajePartido_ = new PuntajePartido();
            PuntajePartido_.Set = 1;
            MostrarPuntaje();
            PonerJugadores();
            InhabilitarSets();
        }

        private void MostrarPuntaje()
        {
            if (PuntajePartido_.SetFinalizado)
            {
                AumentarSet();
                lblPuntajeJugador1.Text = string.Empty;
                lblPuntajeJugador2.Text = string.Empty;
                lblDeuce.Text = string.Empty;               
                lblAceJ1.Text = string.Empty;
                lblAceJ2.Text = string.Empty;
                lblDobleFaltaJ1.Text = string.Empty;
                lblDobleFaltaJ2.Text = string.Empty;
                lblSet.Text = PuntajePartido_.Set.ToString();

                PuntajePartido_.SetFinalizado = false;
            }
            else
            {
                if (PuntajePartido_.PuntajeJugador1 == 0)
                {
                    lblPuntajeJugador1.Text = "0";
                }

                if (PuntajePartido_.PuntajeJugador1 == 1)
                {
                    lblPuntajeJugador1.Text = "15";
                }

                if (PuntajePartido_.PuntajeJugador1 == 2)
                {
                    lblPuntajeJugador1.Text = "30";
                }

                if (PuntajePartido_.PuntajeJugador1 == 3)
                {
                    lblPuntajeJugador1.Text = "40";
                }

                if (PuntajePartido_.PuntajeJugador2 == 0)
                {
                    lblPuntajeJugador2.Text = "0";
                }

                if (PuntajePartido_.PuntajeJugador2 == 1)
                {
                    lblPuntajeJugador2.Text = "15";
                }

                if (PuntajePartido_.PuntajeJugador2 == 2)
                {
                    lblPuntajeJugador2.Text = "30";
                }

                if (PuntajePartido_.PuntajeJugador2 == 3)
                {
                    lblPuntajeJugador2.Text = "40";
                }

                lblAceJ1.Text = PuntajePartido_.ACEJ1.ToString();
                lblAceJ2.Text = PuntajePartido_.ACEJ2.ToString();
                lblDobleFaltaJ1.Text = PuntajePartido_.DobleFaltaJ1.ToString();
                lblDobleFaltaJ2.Text = PuntajePartido_.DobleFaltaJ2.ToString();
                lblSet1J1.Text = "0";
                lblSet1J2.Text = "0";
                //<<<<<<< .mine
                //            lblTotalSetJ1.Text = "0";
                //            lblTotalSetJ2.Text = "0";
                //=======

                if (PuntajePartido_.VentajaJ1)
                {
                    lblPuntajeJugador1.Text = lblPuntajeJugador1.Text + " AD";
                }

                if (PuntajePartido_.VentajaJ2)
                {
                    lblPuntajeJugador2.Text = lblPuntajeJugador2.Text + " AD";
                }

                if (PuntajePartido_.Deuce)
                {
                    lblDeuce.Text = "Deuce";
                }
                else
                {
                    lblDeuce.Text = string.Empty;
                }

                lblSet.Text = PuntajePartido_.Set.ToString();
            }

        }

        private void btnAdicionarPuntoJugador1_Click(object sender, EventArgs e)
        {
            var puntaje = PuntajePartido_;
            logica.AumentarPunto(ref  puntaje, true);
            MostrarPuntaje();
        }

        private void btnAdicionarPuntoJugador2_Click(object sender, EventArgs e)
        {
            var puntaje = PuntajePartido_;
            logica.AumentarPunto(ref  puntaje, false);
            MostrarPuntaje();
        }

        private void btnAdicionarACEJugador1_Click(object sender, EventArgs e)
        {
            var puntaje = PuntajePartido_;
            logica.AumentarPuntoACE(ref  puntaje, true);
            MostrarPuntaje();
        }

        private void btnAdicionarDobleFaltaJugador1_Click(object sender, EventArgs e)
        {
            var puntaje = PuntajePartido_;
            logica.AumentarDobleFalta(ref  puntaje, true);
            MostrarPuntaje();
        }

        private void btnBorrarUltimoJugador1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdicionarACEJugador2_Click(object sender, EventArgs e)
        {
            var puntaje = PuntajePartido_;
            logica.AumentarPuntoACE(ref  puntaje, false);
            MostrarPuntaje();
        }

        private void btnAdicionarDobleFaltaJugador2_Click(object sender, EventArgs e)
        {
            var puntaje = PuntajePartido_;
            logica.AumentarDobleFalta(ref  puntaje, false);
            MostrarPuntaje();
        }

        private void btnBorrarUltimoJugador2_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Cargar los nombres de los jugadores y sus nacionalidades
        /// </summary>
        public void PonerJugadores()
        {
            lblNombreJugador1.Text = configuracionDelPartido.NombreJugadorUno;
            lblNombreJugador2.Text = configuracionDelPartido.NombreJugadorDos;
            lblNacionJugador1.Text = configuracionDelPartido.NacionalidadJugadorUno;
            lblNacionJugador2.Text = configuracionDelPartido.NacionalidadJugadorDos;
            lblNombreJugador1Set.Text = configuracionDelPartido.NombreJugadorUno;
            lblNombreJugador2Set.Text = configuracionDelPartido.NombreJugadorDos;
        }

        /// <summary>
        /// Inhabilitar Sets
        /// </summary>
        public void InhabilitarSets()
        {
            int NumeroDeSets = configuracionDelPartido.NumeroDeSets;
            if (NumeroDeSets == 1)
            {
                lblSet2J1.Text = "No aplica";
                lblSet2J2.Text = "No aplica";
                lblSet3J1.Text = "No aplica";
                lblSet3J2.Text = "No aplica";
                lblSet4J1.Text = "No aplica";
                lblSet4J2.Text = "No Aplica";
                lblSet5J1.Text = "No aplica";
                lblSet5J2.Text = "No Aplica";
            }
            if (NumeroDeSets == 3)
            {
                lblSet2J1.Text = "0";
                lblSet2J2.Text = "0";
                lblSet3J1.Text = "0";
                lblSet3J2.Text = "0";
                lblSet4J1.Text = "No aplica";
                lblSet4J2.Text = "No Aplica";
                lblSet5J1.Text = "No aplica";
                lblSet5J2.Text = "No Aplica";
            }
            if (NumeroDeSets == 5)
            {
                lblSet2J1.Text = "0";
                lblSet2J2.Text = "0";
                lblSet3J1.Text = "0";
                lblSet3J2.Text = "0";
                lblSet4J1.Text = "0";
                lblSet4J2.Text = "0";
                lblSet5J1.Text = "0";
                lblSet5J2.Text = "0";
            }
        }

        public void AumentarSet()
        {
            var setActual = PuntajePartido_.Set;
           

            bool Respuesta = logica.AumentarSet(PuntajePartido_);

            if (Respuesta == true)
            {
                switch (setActual)
                {
                    case 1:
                        int valor1 = Convert.ToInt32(lblSet1J1.Text) + 1;
                        lblSet1J1.Text = valor1.ToString();
                        break;
                    case 2:
                        int valor2 = Convert.ToInt32(lblSet2J1.Text) + 1;
                        lblSet2J1.Text = valor2.ToString();
                        break;
                    case 3:
                        int valor3 = Convert.ToInt32(lblSet3J1.Text) + 1;
                        lblSet3J1.Text = valor3.ToString();
                        break;
                    case 4:
                        int valor4 = Convert.ToInt32(lblSet4J1.Text) + 1;
                        lblSet4J1.Text = valor4.ToString();
                        break;
                    case 5:
                        int valor5 = Convert.ToInt32(lblSet5J1.Text) + 1;
                        lblSet5J1.Text = valor5.ToString();
                        break;
                    default:
                        Console.WriteLine("Default case");
                        break;
                }
            }
            else
            {
                switch (setActual)
                {
                    case 1:
                        int valor1 = Convert.ToInt32(lblSet1J2.Text) + 1;
                        lblSet1J2.Text = valor1.ToString();
                        break;
                    case 2:
                        int valor2 = Convert.ToInt32(lblSet2J2.Text) + 1;
                        lblSet2J2.Text = valor2.ToString();
                        break;
                    case 3:
                        int valor3 = Convert.ToInt32(lblSet3J2.Text) + 1;
                        lblSet3J2.Text = valor3.ToString();
                        break;
                    case 4:
                        int valor4 = Convert.ToInt32(lblSet4J2.Text) + 1;
                        lblSet4J2.Text = valor4.ToString();
                        break;
                    case 5:
                        int valor5 = Convert.ToInt32(lblSet5J2.Text) + 1;
                        lblSet5J2.Text = valor5.ToString();
                        break;
                    default:
                        Console.WriteLine("Default case");
                        break;
                }
            }

            setActual++;
            PuntajePartido_.Set = setActual;
        }

        //public void AumentarSet(PuntajePartido puntajePartido, int set)
        //{
        //    bool Respuesta = logica.AumentarSet(puntajePartido);

        //    if (Respuesta == true)
        //    {
        //        switch (set)
        //        {
        //            case 1:
        //                int valor1 = Convert.ToInt32(lblSet1J1) + 1;
        //                lblSet1J1.Text = valor1.ToString();
        //                break;
        //            case 2:
        //                int valor2 = Convert.ToInt32(lblSet2J1) + 1;
        //                lblSet2J1.Text = valor2.ToString();
        //                break;
        //            case 3:
        //                int valor3 = Convert.ToInt32(lblSet3J1) + 1;
        //                lblSet3J1.Text = valor3.ToString();
        //                break;
        //            case 4:
        //                int valor4 = Convert.ToInt32(lblSet4J1) + 1;
        //                lblSet4J1.Text = valor4.ToString();
        //                break;
        //            case 5:
        //                int valor5 = Convert.ToInt32(lblSet5J1) + 1;
        //                lblSet5J1.Text = valor5.ToString();
        //                break;
        //            default:
        //                Console.WriteLine("Default case");
        //                break;
        //        }
    }
}
