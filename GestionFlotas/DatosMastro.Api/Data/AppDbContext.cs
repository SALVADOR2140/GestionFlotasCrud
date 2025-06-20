using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GestionFlotas;

    public class AppDbContext : DbContext
    {
        public AppDbContext (DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<GestionFlotas.Camion> Camiones { get; set; } = default!;

public DbSet<GestionFlotas.Conductor> Conductores { get; set; } = default!;

public DbSet<GestionFlotas.Taller> Talleres { get; set; } = default!;


public DbSet<GestionFlotas.Mantenimiento> Mantenimientos { get; set; } = default!;

public DbSet<GestionFlotas.AlertaMantenimiento> AlertasMantenimientos { get; set; } = default!;



    //Metodo para configurar el modelo de la base de datos para mejorar la preciosion del kilometraje actual
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Camion
        modelBuilder.Entity<Camion>()
            .Property(c => c.KilometrajeActual)
            .HasColumnType("float");


    }


}
