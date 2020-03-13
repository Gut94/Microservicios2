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

/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MicroserviciosPrueba1.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MicroserviciosPrueba1.Controllers
{//empty aoi controller
   [Route("api/[controller]")]
   [ApiController]
   public class StudentsController : ControllerBase
   {//https://www.youtube.com/watch?v=diOVSGxQPiE&list=PLSIKM6F-xklLbGCQlP6WjESwjkwBxxoB4
       static List<Student> _oStudent = new List<Student>(){
           new Student(){Id=1, Name="p_motos1",Roll=1001},
           new Student(){Id=2, Name="p_motos2",Roll=1002},
           new Student(){Id=3, Name="p_motos3",Roll=1003},
           new Student(){Id=4, Name="p_motos4",Roll=1004},
           new Student(){Id=5, Name="p_motos5",Roll=1005}
       };

       //AppDbContext _db = new AppDbContext();
       private readonly AppDbContext _context;
       //public AppDbContext Context => _context;

       public StudentsController(AppDbContext context)
       {
           _context = context;
       }



       [HttpGet]
       public IActionResult Gets()
       {
           if(_oStudent.Count == 0)
           {
               return NotFound("No list found.");
           }
           return Ok(_oStudent);
       }


       [HttpGet("GetStudent")]
       public IActionResult Get(int id)
       {
           var oStudent = _oStudent.SingleOrDefault(x => x.Id == id);
           if (oStudent == null)
           {
               return NotFound("No student found");
           }
           return Ok(oStudent);
       }


       [HttpPost]
       public IActionResult Save(Student oStudent)
       {
           _oStudent.Add(oStudent);
           if (_oStudent.Count == 0)
           {
               return NotFound("No list found.");
           }
           //context.TableName.AddObject(TableEntityInstance);
           //context.SaveChanges();
            _context.Students.Add(oStudent); //nombre del objeto en vez del la tabla?
            _context.SaveChanges();

           using (var context = new AppDbContext())
           {
               var blog = new Blog { Url = "http://sample.com" };
               context.Blogs.Add(blog);
               context.SaveChanges();
           }
           return Ok(_oStudent);
       }


       [HttpDelete]
       public IActionResult DeleteStudent(int id)
       {
           var oStudent = _oStudent.SingleOrDefault(x => x.Id == id);
           if (oStudent == null)
           {
               return NotFound("No student found");
           }
           _oStudent.Remove(oStudent);
           if (_oStudent.Count==0)
           {
               return NotFound("No list found.");
           }
           return Ok(_oStudent);
       }
   }
}
        */
