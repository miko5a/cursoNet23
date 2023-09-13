using Entidades;
using Microsoft.EntityFrameworkCore;
namespace Context
{
    public class ContextoConversor : DbContext
    {

        public ContextoConversor(DbContextOptions<ContextoConversor> opciones) : base(opciones)
        {
        }
        public DbSet<Usuario> usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}