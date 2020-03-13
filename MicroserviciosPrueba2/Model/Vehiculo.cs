using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroserviciosPrueba2
{
    /// <summary>
    /// Clase de un vehículo genérico, de la que heredan las clases: coche, moto y bicicleta
    /// </summary>
    public class Vehiculo
    {
        // Propiedad color
        private string _color;
        public string color
        {
            get
            {
                return _color;
            }
            set
            {
                _color = value;
            }
        }
        // Propiedad mensajeAceptado
        private string _mensajeAceptado = "Genial, puedo entrar en el parking.";
        public virtual string mensajeAceptado
        {
            get
            {
                return _mensajeAceptado;
            }
        }
        private string _mensajeDenegado = "¡Maldita sea!, no puede entrar en el parking.";
        public virtual string mensajeDenegado
        {
            get
            {
                return _mensajeDenegado;
            }
        }

        //Propiedad mensajeDenegado
        /// <summary>
        /// Constructor de un vehículo, asignándose los mensajes de entrada y 
        /// denegación de entrada a un parking y eligiéndose su color
        /// </summary>
        public Vehiculo()
        {
            ArrayList coloresDisponibles = new ArrayList();
            coloresDisponibles = InstanciarColores();
            this.color = ElegirColor(coloresDisponibles);
        }

        /// <summary>
        /// Instancia de los colores disponibles para un vehículo
        /// </summary>
        /// <returns> Array con los colores </returns>
        private ArrayList InstanciarColores()
        {
            ArrayList colores = new ArrayList();

            try
            {
                colores.Add("azul");
                colores.Add("blanco");
                colores.Add("negro");
                colores.Add("rosa");

                return colores;

            }
            catch (Exception ex)
            {
                return colores;
            }
        }

        /// <summary>
        /// Función que elige aleatoriamente un color para un vehículo
        /// </summary>
        /// <param name="_coloresDisponibles"></param>
        /// <returns> Color elegido aleatoriamente o cadena colorDefecto en caso de excepción </returns>
        private string ElegirColor(ArrayList _coloresDisponibles)
        {
            const string colorDefecto = "ColorDefecto";

            try
            {
                var random = new Random();
                int eleccion = random.Next(_coloresDisponibles.Count);

                return _coloresDisponibles[eleccion].ToString();
            }
            catch (Exception ex)
            {
                return colorDefecto;
            }
        }
    }
}
