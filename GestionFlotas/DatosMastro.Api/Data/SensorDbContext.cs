using Microsoft.EntityFrameworkCore;
using GestionFlotas;

namespace DatosMastro.Api.Data
{
    public class SensorDbContext : DbContext
    {
        public SensorDbContext(DbContextOptions<SensorDbContext> options) : base(options) { }

        public DbSet<LecturaSensor> LecturasSensores { get; set; } = default!;
    }
}