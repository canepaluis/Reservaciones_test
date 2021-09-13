using Microsoft.EntityFrameworkCore;
using Reservaciones_test.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reservaciones_test.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            base.OnModelCreating(modelbuilder);

            modelbuilder.Entity(typeof(Reservaciones))
                .HasOne(typeof(Habitaciones), "habitacion")
                .WithMany()
                .HasForeignKey("habitacionId")
                .OnDelete(DeleteBehavior.Restrict); // no ON DELETE
            modelbuilder.Entity(typeof(Reservaciones))
                .HasOne(typeof(Hoteles), "hotel")
                .WithMany()
                .HasForeignKey("hotelId")
                .OnDelete(DeleteBehavior.Restrict); // no ON DELETE


        }

        public DbSet<Destinos> Destinos { get; set; }

        public DbSet<Hoteles> Hoteles { get; set; }

        public DbSet<Descripciones>  Descripciones { get; set; }

        public DbSet<Habitaciones> Habitaciones { get; set; }

        public DbSet<Reservaciones> Reservaciones { get; set; }

        public DbSet<T_Habitaciones> T_Habitaciones { get; set; }

        public DbSet<Servicios> Servicios { get; set; }

}
}
