using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaDeInscripcionUniversitario.Models.Dominio
{
    public class Estudiante : Persona
    {
        [ForeignKey(nameof(Carrera))]
        public int IdCarrera { get; set; }
        public virtual Carrera Carrera { get; set; }

        public int idLegajo { get; set; }

        public int idHistorial { get; set; }
    }
}