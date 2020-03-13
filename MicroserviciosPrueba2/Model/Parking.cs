using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroserviciosPrueba2
{
    public class Parking
    {
        /// <summary>
        /// nombre
        /// </summary>
       /* public string nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {

            }
        }*/
        public string nombre { get; set; }
        /// <summary>
        /// plazas para coche
        /// </summary>
        /*private int nplazascoche
        {
            get
            {
                return this.nplazascoche;
            }
            set
            {

            }
        }*/
        private int nplazascoche { get; set; }

        /// <summary>
        ///  plazas para moto
        /// </summary>
       /* private int nplazasmoto
        {
            get
            {
                return this.nplazasmoto;
            }
            set
            {

            }
        }*/
        private int nplazasmoto { get; set; }
        /// <summary>
        /// plazas para bici
        /// </summary>
       /* private int nplazasbicicleta
        {
            get
            {
                return this.nplazasbicicleta;
            }
            set
            {

            }
        }*/
        private int nplazasbicicleta { get; set; }

        /// <summary>
        /// lista de vehículos aparcados dentro del parking
        /// </summary>
        public List<Vehiculo> vehaparcados = new List<Vehiculo>();

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="_nombre">nombre del parking</param>
        /// <param name="_nplazascoche">Plazas para coches</param>
        /// <param name="_nplazasmoto">Plazas para moto</param>
        public Parking(string _nombre, int _nplazascoche, int _nplazasmoto = 0)
        {
            this.nombre = _nombre;
            this.nplazascoche = _nplazascoche;

            if (_nplazasmoto == 0)
            {
                this.nplazasmoto = 15;
            }
            else
            {
                this.nplazasmoto = _nplazasmoto;
            }
        }

        public String getNombre1()
        {
            return nombre;
        }
    }
}