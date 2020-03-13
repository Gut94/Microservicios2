using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroserviciosPrueba2
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        /*public DbSet<User> Users { get; set; }
        public DbSet<Group> Groups { get; set; }*/
        //public DbSet<Parking> Parkings { get; set; } guardar parametros en vez del parking
        public DbSet<ParkingDat> ParkingDats { get; set; }
    }
}
