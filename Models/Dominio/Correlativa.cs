using System.Collections.Generic;

namespace SistemaDeInscripcionUniversitario.Models.Dominio
{
    public class Correlativa : EntityBase
    {
        public string NombreCorrelativa { get; set; }

        public virtual List<MateriaPorCorrelativa> MateriaPorCorrelativas { get; set; }
    }
}