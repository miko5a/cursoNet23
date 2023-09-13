using Entidades;

namespace Modelos
{
    public interface IRepositorioUsuarios
    {
        Task<Usuario> postUsuario(Usuario usuario);
        IEnumerable<Consulta> getUsuarios();
        Task<Usuario> getUser(string id);
    }
}