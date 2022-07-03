using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaDeInscripcionUniversitario.Models.Dominio
{
    public class Materia : EntityBase
    {
        public string NombreMateria { get; set; }
        public int IdCarrera { get; set; }
        public virtual Carrera Carrera { get; set; }
        public virtual List<MateriaPorCorrelativa> MateriaPorCorrelativas { get; set; }
    }
}