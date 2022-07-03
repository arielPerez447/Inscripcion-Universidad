using System.ComponentModel.DataAnnotations;

namespace SistemaDeInscripcionUniversitario.Models.Dominio
{
    public class EntityBase
    {
        [Key]
        public int Id { get; set; }
    }
}
