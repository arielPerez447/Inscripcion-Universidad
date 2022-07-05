using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaDeInscripcionUniversitario.Models.Dominio
{
    public class Estudiante : EntityBase
    {
        [Required]
        public string Nombre { get; set; }

        [Required]
        public string Apellido { get; set; }
        public int IdCarrera { get; set; }
        public virtual Carrera Carrera { get; set; }

        public int IdHistoriaAcademnico { get; set; }
        public virtual HistorialAcademico Historial { get; set; }
    }
}