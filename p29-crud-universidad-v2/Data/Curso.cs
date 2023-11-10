using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
public class Curso {
[DatabaseGenerated(DatabaseGeneratedOption.None)]
public int CursoId { get; set; }
[StringLength(50, MinimumLength = 3)]
public string Titulo { get; set; }
[Range(0, 5)]
public int Creditos { get; set; }
public ICollection<Inscripcion> Inscripciones { get; set; }
}