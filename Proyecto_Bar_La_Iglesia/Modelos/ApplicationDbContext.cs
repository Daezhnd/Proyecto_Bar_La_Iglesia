using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Bar_La_Iglesia.Modelos
{
    class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseNpgsql("Host=localhost; Database=; Username=postgres; password=;").EnableSensitiveDataLogging(true);
        }
        //*******

        public DbSet<Personal> Personal { get; set; }
        public DbSet<Mercancia> Mercancia { get; set; }
        public DbSet<HistorialVenta> HistorialVenta { get; set; }
        //*******

    }//fin class
}//fin proyecto
