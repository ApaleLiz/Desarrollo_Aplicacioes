using System.ComponentModel.DataAnnotations;
public class Estudiante {
public int Id { get; set; }
[Required, StringLength(50)]
public string Nombre { get; set; }
[Required, StringLength(50)]
public string Apeido { get; set; }
[DataType(DataType.Date)]
[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}",
ApplyFormatInEditMode = true)]
public DateTime FechaInscripcion { get; set; }
[Display(Name = "Nombre Completo")]
public string NombreCompleto {
get { return Nombre + " " + Apeido; }
}
public ICollection<Inscripcion> Inscripciones { get; set; }
}