using Context;
using Entidades;
using Microsoft.EntityFrameworkCore;

namespace Modelos
{
    public class RepositorioUsuarios : IRepositorioUsuarios
    {
        private readonly ContextoConversor _context;

        public RepositorioUsuarios(ContextoConversor context)
        {
            _context = context;
        }

        public IEnumerable<Consulta> getUsuarios()
        {
            var baseDate = DateTime.Now;
            baseDate = baseDate.AddYears(-21);

            var query = from h in _context.usuarios
                        where h.fechaNacimiento < baseDate
                        orderby h.nombre descending

                        select new Consulta
                        {
                            //id = h.id,
                            nombre = h.nombre,
                            telefono = h.telefono,
                            fechaNacimiento = h.fechaNacimiento,
                        };
            var resultado = query.Take(10);

            return resultado;
        }

        public async Task<Usuario> getUser(string nombreUsuario)
        {
            var resultad = _context.usuarios.FirstOrDefault(m => m.nombre == nombreUsuario);

            return resultad;
            
        }

        public async Task<Usuario> postUsuario(Usuario usuario)
        {
                Usuario existeUsuario = _context.usuarios.FirstOrDefault(m => m.id == usuario.id);

                Usuario listaUsuario = new Usuario();

                if (existeUsuario == null)
                {
                    listaUsuario.id = Guid.NewGuid().ToString();
                    listaUsuario.nombre = usuario.nombre;
                    listaUsuario.telefono = usuario.telefono;
                    listaUsuario.fechaNacimiento = usuario.fechaNacimiento;

                    _context.Add(listaUsuario);
                    _context.SaveChanges();
                }

                return usuario;
        }
    }
}
