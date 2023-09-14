using System.ComponentModel.DataAnnotations;

namespace Modelos
{
    public class Persona
    {
        [Key]
        [MaxLength(50)]
        public string Nombre { get; set; }

        [Required]
        public DateTimeOffset FechaNacimiento { get; set; }

        [MaxLength(25)]
        public string Telefono { get; set; }

        public DateTime FechaRegistro { get; set; } = DateTime.Now;
    }
}
