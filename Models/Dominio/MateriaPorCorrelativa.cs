namespace SistemaDeInscripcionUniversitario.Models.Dominio
{
    public class MateriaPorCorrelativa : EntityBase
    {
        public int IdMateria { get; set; }
        public int IdPrimeraCorrelativa { get; set; }
        public int IdSegundaCorrelativa { get; set; }

        public virtual Materia Materia { get; set; }
        public virtual Correlativa PrimeraCorrelativa { get; set; }
        public virtual Correlativa SegundaCorrelativa { get; set; }
    }
}