using System.ComponentModel.DataAnnotations;
public class Inscripcion
{
public int InscripcionId { get; set; }
public int CursoId { get; set; }
public int EstudianteId { get; set; }
public float? Promedio { get; set; }
public Curso Curso { get; set; }
public Estudiante Estudiante { get; set; }
}