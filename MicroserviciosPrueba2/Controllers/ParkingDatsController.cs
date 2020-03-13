using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
//using MicroserviciosPrueba2.Model;
using Microsoft.AspNetCore.Mvc;

namespace MicroserviciosPrueba2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParkingDatsController : ControllerBase
    {

        static List<ParkingDat> _Parking = new List<ParkingDat>()
        {
            new ParkingDat(){nombre = "p_prueba", nplazascoche=15, nplazasmoto=15, colorSel="azul"}
        };

        [HttpGet]
        public IActionResult Gets()
        {
            if(_Parking.Count == 0)
            {
                return NotFound("No list found");
            }
            return Ok(_Parking);
        }
    }
}