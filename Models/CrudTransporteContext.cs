using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebApiEmptransporte.Models
{
    public partial class CrudTransporteContext : DbContext
    {
        public CrudTransporteContext()
        {
        }

        public CrudTransporteContext(DbContextOptions<CrudTransporteContext> options)
            : base(options)
       {
        }

        public DbSet<Propietarios> Propietario { get; set; }     
        public DbSet<Vehiculo> vehiculos { get; set; }     
        public DbSet<Conductor> conductors { get; set; }     
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseNpgsql(@"Server=localhost;Port=5432;Database=CrudTransporte;User Id=postgres;Password=Poli123.");
                base.OnConfiguring(optionsBuilder);

                // optionsBuilder.UseSqlServer("Server=JDLOBATON10;Database=CrudTransporte;Trusted_Connection=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
