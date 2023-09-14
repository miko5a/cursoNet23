using Microsoft.EntityFrameworkCore;

namespace Modelos
{
    public class Contexto: DbContext
    {
        public Contexto(DbContextOptions<Contexto> opciones) : base(opciones) { }

        public DbSet<Persona> Persona { get; set; }
    }
}
