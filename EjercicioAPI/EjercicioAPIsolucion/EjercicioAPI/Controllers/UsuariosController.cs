using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Modelos;
using AutoMapper;
using Entidades;

namespace EjercicioAPI.Controllers
{
    [Route("api/usuarios")]
    [ApiController]
    public class UsuariosControllerAPI : ControllerBase
    {
        private readonly IRepositorioUsuarios repositorioUsuarios;
        private readonly IMapper _mapper;

        public UsuariosControllerAPI(IRepositorioUsuarios repositorioUsuarios,
        IMapper mapper)
        {
            this.repositorioUsuarios = repositorioUsuarios;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<List<Consulta>>> GetUsuarios()
        {
            var usuarios = repositorioUsuarios.getUsuarios();

            if (usuarios == null)
            {
                return NotFound();
            }

            return Ok(usuarios);
        }

        [HttpPost]
        [Route("registro")]
        public async Task<IActionResult> registro([FromBody] UsuarioAltaDto registro)
        {

            var userExists = await repositorioUsuarios.getUser(registro.nombre);
            if (userExists != null)
            return StatusCode(StatusCodes.Status500InternalServerError, new Respuesta { Status = "Error", Message = "Nombre de Usuario Existe!" });

            Usuario userAlta = new()
            {
                id = Guid.NewGuid().ToString(),
                nombre = registro.nombre,
                telefono = registro.telefono,
                fechaNacimiento = registro.fechaNacimiento
            };

            var usuario = await repositorioUsuarios.postUsuario(userAlta);
        

            return Ok(new Respuesta { Status = "Success", Message = "Usuario creado correctamente!" });
        }


    }
}