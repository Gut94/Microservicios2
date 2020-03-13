using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MicroserviciosPrueba2
{
    public class ParkingDat
    {
        [Key]
        public string nombre { get; set; }
        public int nplazascoche { get; set; }
        public int nplazasmoto { get; set; }
        //public int? nplazasmoto
        //{
        //    get { return _nplazasmoto; }
        //    set
        //    {
        //        if (value != null)
        //        {
        //            _nplazasmoto = 15;
        //        }
        //    }
        //}
        public string colorSel { get; set; }



        //private int _nplazasmoto = null;
    }
}
