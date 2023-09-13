using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Entidades
{
    public class UsuarioAltaDto
    {
        public string nombre { get; set; }

        public string telefono { get; set; }

        public DateTime? fechaNacimiento { get; set; }


    }
}