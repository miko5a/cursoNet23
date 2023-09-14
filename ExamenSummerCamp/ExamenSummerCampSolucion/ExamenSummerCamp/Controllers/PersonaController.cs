using DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Modelos;

namespace ExamenSummerCamp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonaController : ControllerBase
    {
        private readonly IRepositorioPersona repositorioPersona;

        public PersonaController(IRepositorioPersona repositorioPersona)
        {
            this.repositorioPersona = repositorioPersona;
        }

        [HttpGet]
        //api/Persona
        public async Task<ActionResult<IEnumerable<PersonaDTO>>> Obtener10PersonasMayores21()
        {

            var lista = await repositorioPersona.Obtener10PersonasAsync();

            var listaDTO = new List<PersonaDTO>();

            foreach (var persona in lista)
            {
                listaDTO.Add(new PersonaDTO
                {
                    Nombre = persona.Nombre,
                    Edad = (DateTime.Now.Year - persona.FechaNacimiento.Year),
                    Telefono = persona.Telefono
                });
            }

            return Ok(listaDTO);

        }

        //api/Persona
        [HttpPost]
        public async Task<ActionResult<PersonaDTO>> AgregarPersona(PersonaForCreationDto persona)
        {

            Persona personaEntidad = new Persona
            {
                Nombre = persona.Nombre,
                FechaNacimiento = persona.FechaNacimiento,
                Telefono = persona.Telefono
            };

            var success = await repositorioPersona.AgregarPersonaAsync(personaEntidad);

            if (!success)
            {
                //! STATUS = 400
                return BadRequest();
            }

            await repositorioPersona.SaveAsync();

            //! STATUS = 200
            return Ok();
        }
    }
}
