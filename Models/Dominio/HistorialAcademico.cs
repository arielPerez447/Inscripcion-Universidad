using System;
namespace SistemaDeInscripcionUniversitario.Models.Dominio
{
    public class HistorialAcademico : EntityBase
    {
        public int IdMateria { get; set; }
        public virtual Materia Materias {get; set;}
        public DateTime Fecha_Examen { get; set; }
        public Decimal Nota { get; set; }
    }
}