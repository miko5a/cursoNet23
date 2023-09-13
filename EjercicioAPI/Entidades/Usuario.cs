using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Entidades
{
    public class Usuario
    {
        [Key]
        public string id { get; set; }

        [Required]
        [MaxLength(50)]
        public string nombre { get; set; }

        [Required]
        [MaxLength(25)]
        public string telefono { get; set; }

        [Required]
        public DateTime? fechaNacimiento { get; set; }


    }
}