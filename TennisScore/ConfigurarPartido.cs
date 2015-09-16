using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TennisScore.Modelo;
using TennisScore;

namespace TennisScore
{
    public partial class    ConfigurarPartido : Form
    {
        public ConfigurarPartido()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            rbtCinco.Enabled = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            ConfiguracionPartido configPartido = new ConfiguracionPartido();
            //Agregar Genero
            if (rbtMasculino.Checked)
            {
                configPartido.Genero = rbtMasculino.Text;
            }
            else
            {
                if (rbtFemenino.Checked)
                {
                    configPartido.Genero = rbtFemenino.Text;
                }
            }

            //Agregar sets
            if (rbtUno.Checked)
            {
                configPartido.NumeroDeSets = Convert.ToInt32(rbtUno.Text);
            }
            else
            {
                if (rbtTres.Checked)
                {
                    configPartido.NumeroDeSets= Convert.ToInt32(rbtTres.Text);
                }
                else
                {
                    if (rbtCinco.Checked)
                    {
                        configPartido.NumeroDeSets= Convert.ToInt32(rbtCinco.Text);
                    }
                }
            }

            //Agregar Nombre jugador uno
            if (txtNombreJugadorUno.Text != "")
            {
                configPartido.NombreJugadorUno = txtNombreJugadorUno.Text;
                
            }

            if (txtNacionalidadJugadorUno.Text != "")
            {
                configPartido.NacionalidadJugadorUno= txtNacionalidadJugadorUno.Text;
            }

            if (txtNombreJugadorDos.Text != "")
            {
                configPartido.NombreJugadorDos= txtNombreJugadorDos.Text;
            }

            if (txtNacionalidadJugadorDos.Text != "")
            {
                configPartido.NacionalidadJugadorDos= txtNacionalidadJugadorDos.Text;
            }

            if (rbtServicioJugadorUno.Checked)
            {
                configPartido.Servicio = 1;
            }
            else
            {
                if (rbtServicioJugadorDos.Checked)
                {
                        configPartido.Servicio = 2;
                }
            }

            LogicaConfigurarPartido logica = new LogicaConfigurarPartido();
            bool Respuesta = logica.ValidarCampos(configPartido);
            if (Respuesta == false)
            {
                MessageBox.Show("No ha completado todos los campos, por favor verifiquelos.");
            }
            else 
            {
                RegistrarMarcador rm = new RegistrarMarcador(configPartido);
                rm.Show();
            }
        }

        private void rbtFemenino_CheckedChanged(object sender, EventArgs e)
        {
            rbtCinco.Enabled = false;
        }

        private void gbxGenero_Enter(object sender, EventArgs e)
        {
           
        }


    }
}
