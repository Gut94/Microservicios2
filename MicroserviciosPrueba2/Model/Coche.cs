using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroserviciosPrueba2
{
    /// <summary>
    /// Clase coche, que hereda de la clase vehículo
    /// </summary>
    public class Coche : Vehiculo
    {
        // Modificación propiedad mensajeAceptado
        public override string mensajeAceptado => "BROOM! BROOM ! Mi color es " + this.color + " y puedo entrar en el parking.";
    }
}
