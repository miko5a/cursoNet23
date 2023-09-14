namespace Modelos
{
    public interface IRepositorioPersona
    {
        Task<bool> AgregarPersonaAsync(Persona persona);

        Task<IEnumerable<Persona>> Obtener10PersonasAsync();

        Task<bool> PersonaExiste(Persona persona);

        Task<bool> SaveAsync();
    }
}
