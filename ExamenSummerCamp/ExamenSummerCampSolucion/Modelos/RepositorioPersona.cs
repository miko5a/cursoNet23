using Microsoft.EntityFrameworkCore;

namespace Modelos
{
    public class RepositorioPersona : IRepositorioPersona
    {
        private readonly Contexto contexto;

        public RepositorioPersona(Contexto contexto)
        {
            this.contexto = contexto;
        }

        public async Task<bool> AgregarPersonaAsync(Persona persona)
        {
            if (await PersonaExiste(persona))
            {
                return false;
            }

            contexto.Persona.Add(persona);
            return true;
        }

        public async Task<IEnumerable<Persona>> Obtener10PersonasAsync()
        {
            return await contexto.Persona
                .Where(p => (DateTime.Now.Year - p.FechaNacimiento.Year) > 21)
                .OrderByDescending(p => p.FechaRegistro)
                .Take(10)
                .ToListAsync();
        }

        public Task<bool> PersonaExiste(Persona persona)
        {
            return contexto.Persona.AnyAsync(p => p.Nombre == persona.Nombre);
        }

        public async Task<bool> SaveAsync()
        {
            return (await contexto.SaveChangesAsync() >= 0);
        }
    }
}
