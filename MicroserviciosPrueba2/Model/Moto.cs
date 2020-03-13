using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroserviciosPrueba2
{
    /// <summary>
    /// Clase moto, que hereda de la clase vehículo
    /// </summary>
    public class Moto : Vehiculo
    {
        protected string tipo { get; set; }
        public override string mensajeAceptado => "YUPI! Mi color es " + this.color + " y puedo entrar en el parking.";
        public override string mensajeDenegado => "Hey!, soy una " + this.tipo + " y vais a lamentar no haberme dejado pasar. ";

        public Moto()
        {
            ArrayList tiposDisponibles = new ArrayList();
            tiposDisponibles = InstanciarTipo();
            this.tipo = ElegirTipo(tiposDisponibles);
        }

        /// <summary>
        /// Instancia de los tipos disponibles para una moto
        /// </summary>
        /// <returns></returns>
        private ArrayList InstanciarTipo()
        {
            ArrayList tipo = new ArrayList();

            try
            {
                tipo.Add("Harley");
                tipo.Add("Ducati");

                return tipo;
            }
            catch (Exception ex)
            {
                return tipo;
            }
        }

        /// <summary>
        /// Función que elige aleatoriamente un color para un vehículo
        /// </summary>
        /// <param name="_coloresDisponibles"></param>
        /// <returns> Color elegido aleatoriamente o cadena colorDefecto en caso de excepción </returns>
        private string ElegirTipo(ArrayList _tiposDisponibles)
        {
            const string tipoDefecto = "tipoDefecto";

            try
            {
                var random = new Random();
                int eleccion = random.Next(_tiposDisponibles.Count);

                return _tiposDisponibles[eleccion].ToString();
            }
            catch (Exception ex)
            {
                return tipoDefecto;
            }
        }
    }
}
