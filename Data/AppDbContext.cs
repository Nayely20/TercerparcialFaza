using Microsoft.EntityFrameworkCore;
using ProyectoFaza.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFaza.Data
{
    public class AppDbContext : DbContext
    {

        public DbSet<Muebles>Muebles { get; set; } 

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)

        {
        }
    }
}
