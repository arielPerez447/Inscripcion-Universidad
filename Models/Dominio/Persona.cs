using System.ComponentModel.DataAnnotations;

namespace SistemaDeInscripcionUniversitario.Models.Dominio
{
    public class Persona : EntityBase
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }
    }
}